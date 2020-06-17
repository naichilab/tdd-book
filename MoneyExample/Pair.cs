using System;

namespace MoneyExample
{
    public class Pair : IEquatable<Pair>
    {
        public bool Equals(Pair other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _from == other._from && _to == other._to;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Pair) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_from, _to);
        }

        public static bool operator ==(Pair left, Pair right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Pair left, Pair right)
        {
            return !Equals(left, right);
        }

        private string _from;
        private string _to;

        public Pair(string from, string to)
        {
            _from = from;
            _to = to;
        }
    }
}