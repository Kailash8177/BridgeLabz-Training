using System;
using System.Collections.Generic;
using System.Text;

namespace delivery_chain_management
{
    internal class ParcelUtility : IParcelTracker
    {

        private StageNode head;
        public void AddStage(string stageName)
        {
            if (head == null)
            {
                head = new StageNode(stageName);
                return;
            }

            StageNode temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new StageNode(stageName);


        }
        public void AddCheckPoint(string afterStage, string newStage)
        {

            if (head == null)
            {

                Console.WriteLine("The Item is not brought yet");
                return;
                
            }
           

            StageNode temp = head;

            while( temp != null && temp.stageName != afterStage)
            {
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("Enter the valid stage");
                return;
            }

            StageNode t = temp.next;
            temp.next = new StageNode(newStage);
            temp = temp.next;
            temp.next = t;
        }
        public void TrackParcel()
        {
            if (head == null)
            {
                Console.WriteLine("No parcel stages available");
                return;
            }

            StageNode temp = head;
            Console.WriteLine("Parcel Journey:");

            while (temp != null)
            {
                Console.Write(temp.stageName);

                if (temp.next != null)
                    Console.Write(" → ");

                temp = temp.next;
            }
            Console.WriteLine();
        }
        public void CheckParcel()
        {
            StageNode temp = head;

            while (temp != null)
            {
                if (temp.stageName == "Delivered")
                {
                    Console.WriteLine(" Parcel Delivered Successfully");
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine(" Parcel Lost or Missing");
        }

    }
}
