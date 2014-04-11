using System;

namespace Adatkezelõ
{
    public class Message
    {

        private String body;
        private DateTime date;
        private User reciever;
        private User sender;
        private String subject;

        public Message()
        {

        }

        public String Body
        {
            get { return body; }
            set { body = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public User Reciever
        {
            get { return reciever; }
            set { reciever = value; }
        }
        public User Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public String Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}