using WhatsAppApiUCU;

namespace Library{
    public class Whatsapp: IMessageChannel{
        public void Send(Message message){
            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+598"+message.To, message.Text);
        }

        public Message NewMessage(Contact from, Contact to){
            WhatsappMsj whatsappMsj = new WhatsappMsj(from.Phone, to.Phone);
            return whatsappMsj;
        }
    }
}