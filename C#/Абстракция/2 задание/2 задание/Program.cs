using System;

namespace _2_задание
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();

    }
    class Player: IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Мелодия проигрывается... ");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Мелодия приостановлена... ");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Мелодия остановлена ");
        }
        public void Record()
        {
            Console.WriteLine("Запись началась... ");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись приостановлена... ");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            IRecodable recorder = new Player();
            player.Play();
            recorder.Record();
            recorder.Pause();
            recorder.Record();
            recorder.Stop();
            player.Stop();
        }
    }
}
