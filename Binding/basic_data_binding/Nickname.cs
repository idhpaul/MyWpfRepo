using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_data_binding
{
    public class Nickname : INotifyPropertyChanged
    {

        public Nickname() : this("name", "nick") { }
        public Nickname(string name, string nick)
        {
            this.name = name;
            this.nick = nick;
        }

        string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                Notify("Name");
            }
        }

        string nick;
        public string Nick
        {
            get => nick;
            set
            {
                nick = value;
                Notify("Nick");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void Notify(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

    }
}
