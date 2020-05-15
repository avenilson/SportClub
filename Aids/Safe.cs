using System;

namespace SportClub.Aids {
    public static class Safe {
        private static readonly object key = new object();
        public static T Run<T>(Func<T> function, T valueOnException,
            bool useLock = false) {
            return useLock 
                ? LockedRun(function, valueOnException) 
                : Run(function, valueOnException);
        }
        public static void Run(Action action, bool useLock = false) {
            if (useLock) LockedRun(action);
            else run(action);
        }

        private static T Run<T>(Func<T> function, T valueOnExeption) {
            try 
            {
               return function(); 
            } 
            catch (Exception e) 
            {
                Log.Exception(e);
                return valueOnExeption;
            }
        }

        private static T LockedRun<T>(Func<T> function, T valueOnExeption) {
            lock (key) { return Run(function, valueOnExeption); }
        }
        private static void run(Action action) {
            try { action(); } catch (Exception e) { Log.Exception(e); }
        }
        private static void LockedRun(Action action) {
            lock (key) { run(action); }
        }
    }
}