namespace Singly_Linked_List
{
    class node
    {
        public int noMhs;
        public string nama;
        public node next;
    }

    class List
    {
        node START;
        public List()
        {
            START = null;
        }

        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\nMasukkan nomor Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan nama Mahasiswa");
            nm = Console.ReadLine();
            node nodeBaru = new node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;

            if (START == null || nim <= START.noMhs)
            {
                if((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomor mahasiswa sama tidak diijinkan\n");
                    return;
                }
                node Previous, current;
                Previous = START;
                current = START;

                while ((current != null) && (nim >= current.noMhs))
                {
                    if (nim == current.noMhs)
                    {
                        Console.WriteLine("\nNomor Mahasiswa sama tidak diijinkan\n");
                        return;
                    }
                    Previous = current;
                    current = current.next;
                }

                nodeBaru.next = current;
                Previous.next = nodeBaru;
            }
        }
    }
}
