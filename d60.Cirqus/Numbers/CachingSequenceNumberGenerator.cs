﻿namespace d60.Cirqus.Numbers
{
    class CachingSequenceNumberGenerator : ISequenceNumberGenerator
    {
        long _current;
        public CachingSequenceNumberGenerator(long first)
        {
            _current = first;
        }

        public long Next()
        {
            return _current++;
        }
    }
}