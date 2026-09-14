using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.UTILS.ConsoleLib
{
    public delegate void MenuChooseEventHandler(object sender, MenuChooseEventArgs args);

    public class ConsoleMenu
    {
        // Field
        private string title;
        private string footer;
        private List<string> dsItems;

        private IMenuChooseListener menuChooseListener = null;
        public event MenuChooseEventHandler MenuChoose;

        public ConsoleMenu(string title, string footer, params string[] items)
        {
            this.title = title;
            this.footer = footer;
            dsItems = new List<string>();
            for (int i = 0; i <= items.Length - 1; i++)
            {
                dsItems.Add(items[i]);
            }
        }

        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(this.title);
            Console.WriteLine("================================================");
            for (int i = 0; i < dsItems.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, dsItems[i]);
            }
            Console.WriteLine("================================================");
            Console.Write(this.footer);
            int chon = int.Parse(Console.ReadLine());
            Console.WriteLine("================================================");
            return chon;
        }

        public void AddMenuChooseListener(IMenuChooseListener listener)
        {
            menuChooseListener = listener;
        }
        public virtual void OnMenuChoose(MenuChooseEventArgs args)
        {
            Console.WriteLine("Ban dang chon 1 chuc nang thu {0} voi ten {1}!", args.Item, args.ItemText);
        }
        public void Process()
        {
            int chon = 0;
            do
            {
                chon = ShowMenu();
                MenuChooseEventArgs args = null;
                if (chon < 0 || chon > dsItems.Count - 1)
                    args = new MenuChooseEventArgs(chon, string.Empty);
                else
                    args = new MenuChooseEventArgs(chon, dsItems[chon - 1]);
                if (MenuChoose != null)// Fire, Raise Event
                    MenuChoose(this, args);
                else if (menuChooseListener != null)
                    menuChooseListener.MenuChoose(this, args);
                else
                    this.OnMenuChoose(args);
                if (args.IsExit)
                {
                    break;
                }
                Console.WriteLine("Nhan Enter de tiep tuc...");
                Console.ReadLine();
            } while (chon != -1);
        }
    }
}
