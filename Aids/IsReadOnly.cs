namespace SportClub.Aids {
    public static class IsReadOnly {
        public static bool Field<T>(string name) 
            => typeof(T).GetField(name)?.IsInitOnly ?? false;

        public static bool Property<T>(string name) 
            => !typeof(T).GetProperty(name)?.CanWrite ?? false;
    }
}