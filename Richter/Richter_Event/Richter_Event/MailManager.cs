using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Richter_Event
{
    class MailManager
    {
        public void SimulateNeMail(string from, string to, string subject)
        {   //create object for keep information,to be sent to the recipients of the notification
            NewMailEventArgs e = new NewMailEventArgs(from, to, subject);
            OnNewMail(e);
        }
        public  event EventHandler<NewMailEventArgs> newMail;
        protected virtual void OnNewMail(NewMailEventArgs e)
        {

            EventHandler<NewMailEventArgs> temp = Volatile.Read(ref newMail);
            if (temp != null) temp(this, e);
        }

        protected virtual void OnNewMail2(NewMailEventArgs e)
        {
            if (newMail != null) newMail(this, e);
        }


    }



    /* При компиляции этой строки компилятор превращает ее в следующие три конструкции:
     =====>   public event EventHandler<NewMailEventArgs> NewMail;
   */
    class Compile
    {
        // 1. ЗАКРЫТОЕ поле делегата, инициализированное значением null
        private EventHandler<NewMailEventArgs> NewMail = null;
        // 2. ОТКРЫТЫЙ метод add_Xxx (где Xxx – это имя события)
        // Позволяет объектам регистрироваться для получения уведомлений о событии
        public void add_NewMail(EventHandler<NewMailEventArgs> value)
        {
            // Цикл и вызов CompareExchange – хитроумный способ добавления
            // делегата способом, безопасным в отношении потоков
            EventHandler<NewMailEventArgs> prevHandler;
            EventHandler<NewMailEventArgs> newMail = this.NewMail;
            do
            {
                prevHandler = newMail;
                EventHandler<NewMailEventArgs> newHandler =
                (EventHandler<NewMailEventArgs>)Delegate.Combine(prevHandler, value);
                newMail = Interlocked.CompareExchange<EventHandler<NewMailEventArgs>>(
                ref this.NewMail, newHandler, prevHandler);
            } while (newMail != prevHandler);
        }

        // 3. ОТКРЫТЫЙ метод remove_Xxx (где Xxx – это имя события)
        // Позволяет объектам отменять регистрацию в качестве
        // получателей уведомлений о cобытии
        public void remove_NewMail(EventHandler<NewMailEventArgs> value)
        {
            // Цикл и вызов CompareExchange – хитроумный способ
            // удаления делегата способом, безопасным в отношении потоков
            EventHandler<NewMailEventArgs> prevHandler;
            EventHandler<NewMailEventArgs> newMail = this.NewMail;
            do
            {
                prevHandler = newMail;
                EventHandler<NewMailEventArgs> newHandler =
                (EventHandler<NewMailEventArgs>)Delegate.Remove(prevHandler, value);
                newMail = Interlocked.CompareExchange<EventHandler<NewMailEventArgs>>(
                ref this.NewMail, newHandler, prevHandler);
            } while (newMail != prevHandler);
        }
    }
}
