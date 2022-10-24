using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
        public void Send(string[] names, IMessageChannel iMessageChannel, string text){
            var contacts = Search(names);
            foreach (Contact c in contacts){
                if (iMessageChannel != null){
                    Message message = iMessageChannel.NewMessage(Owner, c);
                    message.Text = text;
                    iMessageChannel.Send(message);
                }
            }  
            
        }

        //Aplicando Creator
        public void Add(string name, string phone, string email, string twitterId){
            Contact contacto = new Contact(name);
            contacto.Email = email;
            contacto.TwitterId = twitterId;
            contacto.Phone = phone;
            persons.Add(contacto);
        }

        public void Remove(Contact contact){
            persons.Remove(contact);
        }


    }
}