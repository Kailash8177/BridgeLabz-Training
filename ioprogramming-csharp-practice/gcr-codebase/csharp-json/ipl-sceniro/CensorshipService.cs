using Newtonsoft.Json;
using IplCensorshipAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IplCensorshipAnalyzer.Services
{
    public static class CensorshipService
    {
        // Mask team name rule
        public static string MaskTeamName(string team)
        {
            var parts = team.Split(' ');
            if (parts.Length >= 2)
                return parts[0] + " ***" + (parts.Length > 2 ? " " + parts[^1] : "");
            return team;
        }

        // JSON Processing
        public static void ProcessJson(string inputPath, string outputPath)
        {
            var matches = JsonConvert.DeserializeObject<List<IplMatch>>(File.ReadAllText(inputPath));

            foreach (var match in matches)
            {
                string maskedTeam1 = MaskTeamName(match.team1);
                string maskedTeam2 = MaskTeamName(match.team2);

                match.score = new Dictionary<string, int>
                {
                    { maskedTeam1, match.score[match.team1] },
                    { maskedTeam2, match.score[match.team2] }
                };

                match.team1 = maskedTeam1;
                match.team2 = maskedTeam2;
                match.winner = MaskTeamName(match.winner);
                match.player_of_match = "REDACTED";
            }

            File.WriteAllText(outputPath,
                JsonConvert.SerializeObject(matches, Formatting.Indented));
        }

        // CSV Processing
        public static void ProcessCsv(string inputPath, string outputPath)
        {
            var lines = File.ReadAllLines(inputPath);
            var sb = new StringBuilder();

            sb.AppendLine(lines[0]); // header

            for (int i = 1; i < lines.Length; i++)
            {
                var data = lines[i].Split(',');

                data[1] = MaskTeamName(data[1]); // team1
                data[2] = MaskTeamName(data[2]); // team2
                data[5] = MaskTeamName(data[5]); // winner
                data[6] = "REDACTED";             // player_of_match

                sb.AppendLine(string.Join(",", data));
            }

            File.WriteAllText(outputPath, sb.ToString());
        }
    }
}
