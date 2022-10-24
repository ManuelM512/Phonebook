using TwitterUCU;

namespace Library{
    public class Twitter : IMessageChannel{
        public void Send(Message message){
            var twitter = new TwitterMessage();
            twitter.SendMessage(message.Text, message.To);
        }

        public Message NewMessage(Contact from, Contact to){
            TwitterMsj twitterMsj = new TwitterMsj(from.TwitterId, to.TwitterId);
            return twitterMsj;
        }
    }
}