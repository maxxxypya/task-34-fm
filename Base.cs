using System;

   abstract class BaseArr : IBaseArr
    {

        public virtual void Create(bool avto_input = false)
        {
            if (avto_input)
            {
                AvtoInput();
            }
            else
            {
                SelfInput();
            }
        }

        public abstract void AvtoInput();

        public abstract void SelfInput();

        public abstract void WriteArray();
    }

