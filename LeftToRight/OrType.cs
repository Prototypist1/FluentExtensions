﻿using System;
using System.Collections.Generic;

namespace Prototypist.Toolbox
{
    public class p<T1> : IIsPossibly<T1> { }
    public class p<T1, T2> : p<T1>, IIsPossibly<T2> { }
    public class p<T1, T2, T3> : p<T1, T2>, IIsPossibly<T3> { }
    public class p<T1, T2, T3, T4> : p<T1, T2, T3>, IIsPossibly<T4> { }
    public class p<T1, T2, T3, T4, T5> : p<T1, T2, T3, T4>, IIsPossibly<T5> { }

    public abstract class OrType<T1, T2> : p<T1, T2>, IOrType<T1, T2>
    {
        public bool Is<T>(out T res)
        {
            if (this is IIsDefinately<T> definate)
            {
                res = definate.Value;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }

        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;

        public void Switch(Action<T1> a1, Action<T2> a2)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            throw new Exception("bug!");
        }
    }
    public abstract class OrType<T1, T2, T3> : p<T1, T2, T3>, IOrType<T1, T2, T3>
    {


        public bool Is<T>(out T res)
        {
            if (this is IIsDefinately<T> definate)
            {
                res = definate.Value;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }

        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;

        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            throw new Exception("bug!");
        }
    }
    public abstract class OrType<T1, T2, T3, T4> : p<T1, T2, T3, T4>, IOrType<T1, T2, T3, T4>
    {
        public bool Is<T>(out T res)
        {
            if (this is IIsDefinately<T> definate)
            {
                res = definate.Value;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }
        public T4 Is4OrThrow()
        {
            if (this is IIsDefinately<T4> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T4)}");
        }

        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;
        public IIsPossibly<T4> Possibly4() => this;

        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else if (this is IIsDefinately<T4> definate4)
            {
                a4(definate4.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            if (this is IIsDefinately<T4> definate4)
            {
                return f4(definate4.Value);
            }
            throw new Exception("bug!");
        }
    }
    public abstract class OrType<T1, T2, T3, T4, T5> : p<T1, T2, T3, T4, T5>, IOrType<T1, T2, T3, T4, T5>
    {
        public bool Is<T>(out T res)
        {
            if (this is IIsDefinately<T> definate)
            {
                res = definate.Value;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }
        public T4 Is4OrThrow()
        {
            if (this is IIsDefinately<T4> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T4)}");
        }
        public T5 Is5OrThrow()
        {
            if (this is IIsDefinately<T5> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T5)}");
        }

        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;
        public IIsPossibly<T4> Possibly4() => this;
        public IIsPossibly<T5> Possibly5() => this;

        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else if (this is IIsDefinately<T4> definate4)
            {
                a4(definate4.Value);
            }
            else if (this is IIsDefinately<T5> definate5)
            {
                a5(definate5.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            if (this is IIsDefinately<T4> definate4)
            {
                return f4(definate4.Value);
            }
            if (this is IIsDefinately<T5> definate5)
            {
                return f5(definate5.Value);
            }
            throw new Exception("bug!");
        }
    }

    public class OrType_1<T1, T2> : OrType<T1, T2>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
    }
    public class OrType_2<T1, T2> : OrType<T1, T2>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
    }

    public class OrType_1<T1, T2, T3> : OrType<T1, T2, T3>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
    }
    public class OrType_2<T1, T2, T3> : OrType<T1, T2, T3>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
    }
    public class OrType_3<T1, T2, T3> : OrType<T1, T2, T3>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
    }

    public class OrType_1<T1, T2, T3, T4> : OrType<T1, T2, T3, T4>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
    }
    public class OrType_2<T1, T2, T3, T4> : OrType<T1, T2, T3, T4>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
    }
    public class OrType_3<T1, T2, T3, T4> : OrType<T1, T2, T3, T4>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
    }
    public class OrType_4<T1, T2, T3, T4> : OrType<T1, T2, T3, T4>, IIsDefinately<T4>
    {
        public OrType_4(T4 value)
        {
            this.Value = value;
        }

        public T4 Value { get; }
    }

    public class OrType_1<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
    }
    public class OrType_2<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
    }
    public class OrType_3<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
    }
    public class OrType_4<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T4>
    {
        public OrType_4(T4 value)
        {
            this.Value = value;
        }

        public T4 Value { get; }
    }
    public class OrType_5<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T5>
    {
        public OrType_5(T5 value)
        {
            this.Value = value;
        }

        public T5 Value { get; }
    }


    public class OrType {

        public static OrType<T1, T2> Make<T1, T2>(T1 value) => new OrType_1<T1,T2>(value);
        public static OrType<T1, T2> Make<T1, T2>(T2 value) => new OrType_2<T1, T2>(value);
        
        public static OrType<T1, T2,T3> Make<T1, T2,T3>(T1 value) => new OrType_1<T1, T2,T3>(value);
        public static OrType<T1, T2,T3> Make<T1, T2,T3>(T2 value) => new OrType_2<T1, T2,T3>(value);
        public static OrType<T1, T2, T3> Make<T1, T2, T3>(T3 value) => new OrType_3<T1, T2, T3>(value);
        
        public static OrType<T1, T2, T3,T4> Make<T1, T2, T3, T4>(T1 value) => new OrType_1<T1, T2, T3, T4>(value);
        public static OrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T2 value) => new OrType_2<T1, T2, T3, T4>(value);
        public static OrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T3 value) => new OrType_3<T1, T2, T3, T4>(value);
        public static OrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T4 value) => new OrType_4<T1, T2, T3, T4>(value);

        public static OrType<T1, T2, T3, T4,T5> Make<T1, T2, T3, T4, T5>(T1 value) => new OrType_1<T1, T2, T3, T4, T5>(value);
        public static OrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T2 value) => new OrType_2<T1, T2, T3, T4, T5>(value);
        public static OrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T3 value) => new OrType_3<T1, T2, T3, T4, T5>(value);
        public static OrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T4 value) => new OrType_4<T1, T2, T3, T4, T5>(value);
        public static OrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T5 value) => new OrType_5<T1, T2, T3, T4, T5>(value);
    }
    
}
