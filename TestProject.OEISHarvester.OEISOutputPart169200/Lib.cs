using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199657
{
public static readonly long[] Value={ 25L,333L,1667438L,9252915567L,136727214560643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199657Inst : IEnumerable<long>
{
public static readonly long[] Value=A199657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199657.Bytes);
public long this[int i]=>Value[i];

public static A199657Inst Instance=new A199657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199658
{
public static readonly long[] Value={ 8L,106L,530762L,2945294501L,43521624105025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199658Inst : IEnumerable<long>
{
public static readonly long[] Value=A199658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199658.Bytes);
public long this[int i]=>Value[i];

public static A199658Inst Instance=new A199658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199659
{
public static readonly long[] Value={ 1L,-3L,0L,8L,-9L,0L,17L,-27L,0L,46L,-57L,0L,98L,-126L,0L,198L,-243L,0L,371L,-465L,0L,692L,-828L,0L,1205L,-1458L,0L,2082L,-2463L,0L,3463L,-4104L,0L,5678L,-6642L,0L,9085L,-10623L,0L,14370L,-16632L,0L,22273L,-25758L,0L,34178L,-39246L,0L,51674L,-59220L,0L,77362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199659Inst : IEnumerable<long>
{
public static readonly long[] Value=A199659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199659.Bytes);
public long this[int i]=>Value[i];

public static A199659Inst Instance=new A199659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199660
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,2L,20L,6L,114L,24L,864L,120L,8280L,720L,96480L,5040L,1325520L,40320L,20966400L,362880L,374855040L,3628800L,7468070400L,39916800L,163938297600L,479001600L,3929729126400L,6227020800L,102104460057600L,87178291200L,2857878742118400L,1307674368000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199660Inst : IEnumerable<long>
{
public static readonly long[] Value=A199660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199660.Bytes);
public long this[int i]=>Value[i];

public static A199660Inst Instance=new A199660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199661
{
public static readonly long[] Value={ 5L,8L,1L,1L,4L,8L,2L,2L,7L,2L,0L,3L,4L,1L,2L,1L,1L,1L,9L,8L,6L,7L,9L,7L,6L,7L,4L,6L,2L,0L,6L,4L,9L,6L,4L,4L,1L,8L,5L,6L,1L,6L,2L,0L,1L,6L,1L,1L,7L,0L,7L,3L,7L,6L,2L,0L,1L,5L,4L,7L,9L,9L,6L,6L,0L,2L,2L,5L,9L,3L,2L,1L,8L,0L,0L,7L,7L,5L,4L,2L,9L,9L,7L,1L,8L,6L,2L,4L,3L,7L,4L,6L,6L,1L,7L,1L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199661Inst : IEnumerable<long>
{
public static readonly long[] Value=A199661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199661.Bytes);
public long this[int i]=>Value[i];

public static A199661Inst Instance=new A199661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199662
{
public static readonly long[] Value={ 3L,1L,6L,7L,5L,0L,8L,2L,8L,7L,7L,1L,2L,2L,1L,1L,7L,1L,8L,8L,6L,7L,9L,6L,1L,8L,0L,6L,1L,0L,9L,6L,1L,7L,9L,7L,9L,9L,7L,1L,7L,1L,8L,9L,4L,6L,2L,9L,3L,3L,7L,5L,0L,8L,2L,0L,8L,4L,6L,3L,7L,9L,0L,0L,9L,7L,7L,1L,5L,3L,5L,3L,6L,2L,0L,4L,8L,6L,3L,3L,7L,5L,0L,5L,6L,7L,0L,8L,2L,3L,5L,6L,1L,1L,2L,2L,9L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199662Inst : IEnumerable<long>
{
public static readonly long[] Value=A199662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199662.Bytes);
public long this[int i]=>Value[i];

public static A199662Inst Instance=new A199662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199663
{
public static readonly long[] Value={ 3L,3L,9L,6L,3L,1L,2L,6L,0L,3L,1L,9L,1L,7L,8L,8L,7L,5L,3L,6L,7L,4L,6L,6L,6L,6L,2L,4L,7L,8L,8L,0L,8L,0L,5L,3L,1L,0L,7L,7L,8L,8L,4L,2L,3L,0L,7L,5L,8L,5L,8L,3L,6L,7L,9L,4L,4L,2L,5L,8L,9L,3L,3L,9L,1L,4L,2L,6L,9L,0L,4L,8L,9L,8L,1L,0L,0L,4L,4L,8L,4L,3L,5L,4L,8L,0L,0L,1L,3L,6L,6L,3L,6L,7L,4L,9L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199663Inst : IEnumerable<long>
{
public static readonly long[] Value=A199663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199663.Bytes);
public long this[int i]=>Value[i];

public static A199663Inst Instance=new A199663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199664
{
public static readonly long[] Value={ 6L,6L,5L,5L,9L,9L,0L,7L,7L,3L,3L,0L,6L,7L,6L,1L,5L,2L,5L,0L,5L,2L,6L,5L,1L,9L,2L,2L,6L,8L,8L,5L,3L,0L,2L,8L,5L,4L,3L,4L,8L,9L,7L,4L,7L,9L,1L,5L,0L,6L,1L,4L,7L,2L,4L,8L,9L,4L,2L,4L,2L,2L,3L,7L,9L,0L,9L,6L,8L,0L,5L,6L,1L,6L,1L,3L,3L,8L,6L,2L,2L,1L,1L,6L,4L,8L,5L,2L,3L,8L,1L,0L,0L,5L,5L,9L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199664Inst : IEnumerable<long>
{
public static readonly long[] Value=A199664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199664.Bytes);
public long this[int i]=>Value[i];

public static A199664Inst Instance=new A199664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199665
{
public static readonly long[] Value={ 9L,4L,7L,9L,7L,2L,6L,4L,7L,8L,8L,9L,8L,1L,4L,2L,4L,4L,0L,4L,2L,0L,5L,0L,6L,9L,6L,1L,9L,7L,5L,5L,0L,2L,2L,3L,4L,0L,0L,4L,3L,8L,1L,4L,9L,4L,1L,5L,5L,9L,3L,8L,6L,5L,5L,0L,1L,9L,5L,0L,6L,5L,6L,2L,0L,1L,0L,5L,5L,9L,7L,4L,0L,7L,4L,5L,0L,6L,2L,1L,6L,8L,5L,0L,2L,5L,1L,0L,1L,5L,1L,7L,3L,0L,9L,3L,9L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199665Inst : IEnumerable<long>
{
public static readonly long[] Value=A199665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199665.Bytes);
public long this[int i]=>Value[i];

public static A199665Inst Instance=new A199665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199666
{
public static readonly long[] Value={ 5L,6L,3L,5L,6L,9L,2L,0L,4L,2L,2L,5L,5L,1L,5L,6L,4L,2L,4L,9L,0L,5L,0L,1L,8L,0L,7L,1L,3L,5L,1L,3L,2L,0L,4L,5L,0L,6L,1L,0L,7L,4L,4L,7L,2L,4L,3L,2L,6L,8L,7L,2L,9L,5L,8L,0L,3L,4L,8L,3L,5L,5L,1L,2L,7L,8L,6L,1L,1L,1L,5L,2L,8L,6L,2L,5L,9L,0L,0L,1L,3L,7L,8L,1L,1L,0L,6L,7L,0L,2L,5L,4L,8L,3L,7L,3L,1L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199666Inst : IEnumerable<long>
{
public static readonly long[] Value=A199666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199666.Bytes);
public long this[int i]=>Value[i];

public static A199666Inst Instance=new A199666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199667
{
public static readonly long[] Value={ 3L,0L,7L,3L,2L,0L,6L,2L,1L,1L,8L,2L,8L,1L,9L,4L,0L,7L,3L,4L,1L,1L,9L,6L,6L,6L,9L,3L,8L,6L,1L,5L,4L,9L,1L,9L,8L,2L,5L,4L,5L,0L,8L,1L,6L,4L,8L,4L,3L,3L,6L,2L,0L,7L,1L,8L,6L,5L,5L,8L,1L,5L,0L,8L,0L,0L,3L,9L,2L,5L,4L,8L,6L,2L,7L,6L,6L,1L,5L,9L,2L,9L,6L,3L,3L,6L,7L,8L,6L,6L,7L,5L,0L,0L,8L,2L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199667Inst : IEnumerable<long>
{
public static readonly long[] Value=A199667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199667.Bytes);
public long this[int i]=>Value[i];

public static A199667Inst Instance=new A199667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199668
{
public static readonly long[] Value={ 3L,5L,3L,9L,0L,4L,4L,5L,9L,0L,7L,0L,7L,6L,7L,0L,0L,9L,6L,9L,0L,0L,0L,7L,1L,0L,2L,7L,2L,4L,6L,6L,4L,6L,4L,6L,9L,9L,1L,2L,0L,3L,8L,6L,5L,8L,0L,0L,6L,9L,0L,2L,6L,6L,0L,2L,1L,1L,9L,5L,5L,6L,6L,0L,8L,6L,7L,0L,2L,0L,6L,3L,7L,4L,7L,6L,7L,8L,0L,9L,7L,9L,4L,8L,2L,0L,8L,9L,0L,6L,2L,8L,8L,3L,9L,5L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199668Inst : IEnumerable<long>
{
public static readonly long[] Value=A199668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199668.Bytes);
public long this[int i]=>Value[i];

public static A199668Inst Instance=new A199668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199669
{
public static readonly long[] Value={ 7L,1L,9L,8L,5L,9L,8L,6L,7L,2L,0L,4L,1L,1L,7L,6L,4L,9L,3L,6L,1L,1L,3L,3L,4L,4L,0L,9L,1L,0L,7L,0L,0L,9L,5L,3L,2L,3L,1L,1L,8L,6L,0L,3L,7L,4L,7L,5L,9L,5L,9L,4L,6L,2L,6L,8L,9L,8L,0L,2L,9L,4L,6L,0L,8L,9L,6L,0L,5L,8L,6L,9L,6L,8L,7L,8L,1L,5L,3L,9L,7L,6L,4L,6L,5L,0L,5L,2L,2L,5L,9L,0L,1L,5L,4L,3L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199669Inst : IEnumerable<long>
{
public static readonly long[] Value=A199669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199669.Bytes);
public long this[int i]=>Value[i];

public static A199669Inst Instance=new A199669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199670
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,119L,1134L,13201L,181594L,2882061L,51836302L,1041959555L,23148374886L,563234624575L,14895783741202L,425457081218169L,13052033357204842L,428016906877603589L,14941465218939490686UL,BigInteger.Parse("553193807213161191259"),BigInteger.Parse("21651761774465075118502"),BigInteger.Parse("893244763931287659927399") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199670Inst Instance=new A199670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199671
{
public static readonly long[] Value={ 22L,355L,1667793L,9254583360L,136736469144003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199671Inst : IEnumerable<long>
{
public static readonly long[] Value=A199671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199671.Bytes);
public long this[int i]=>Value[i];

public static A199671Inst Instance=new A199671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199672
{
public static readonly long[] Value={ 7L,113L,530875L,2945825376L,43524569930401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199672Inst : IEnumerable<long>
{
public static readonly long[] Value=A199672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199672.Bytes);
public long this[int i]=>Value[i];

public static A199672Inst Instance=new A199672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199673
{
public static readonly long[] Value={ 1L,2L,2L,3L,12L,6L,4L,48L,72L,24L,5L,160L,540L,480L,120L,6L,480L,3240L,5760L,3600L,720L,7L,1344L,17010L,53760L,63000L,30240L,5040L,8L,3584L,81648L,430080L,840000L,725760L,282240L,40320L,9L,9216L,367416L,3096576L,9450000L,13063680L,8890560L,2903040L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199673Inst : IEnumerable<long>
{
public static readonly long[] Value=A199673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199673.Bytes);
public long this[int i]=>Value[i];

public static A199673Inst Instance=new A199673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199674
{
public static readonly long[] Value={ 1L,17L,186L,1273L,5614L,16403L,31726L,39159L,27945L,8748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199674Inst : IEnumerable<long>
{
public static readonly long[] Value=A199674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199674.Bytes);
public long this[int i]=>Value[i];

public static A199674Inst Instance=new A199674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199675
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,31L,170L,1129L,8737L,77198L,767683L,8482519L,103093958L,1366897597L,19633740673L,303706037546L,5033465370031L,88983532209967L,1671402633292562L,33241154368669921L,697834148797749601L,15420722865332961206UL,BigInteger.Parse("357805114894717632331"),BigInteger.Parse("8697446048869287663271") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199675Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199675.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199675Inst Instance=new A199675Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199676
{
public static readonly long[] Value={ 1L,1L,3L,5L,18L,57L,285L,1513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199676Inst : IEnumerable<long>
{
public static readonly long[] Value=A199676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199676.Bytes);
public long this[int i]=>Value[i];

public static A199676Inst Instance=new A199676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199677
{
public static readonly long[] Value={ 9L,73L,649L,5833L,52489L,472393L,4251529L,38263753L,344373769L,3099363913L,27894275209L,251048476873L,2259436291849L,20334926626633L,183014339639689L,1647129056757193L,14824161510814729L,133417453597332553L,1200757082375992969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199677Inst : IEnumerable<long>
{
public static readonly long[] Value=A199677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199677.Bytes);
public long this[int i]=>Value[i];

public static A199677Inst Instance=new A199677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199678
{
public static readonly long[] Value={ 11L,91L,811L,7291L,65611L,590491L,5314411L,47829691L,430467211L,3874204891L,34867844011L,313810596091L,2824295364811L,25418658283291L,228767924549611L,2058911320946491L,18530201888518411L,166771816996665691L,1500946352969991211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199678Inst : IEnumerable<long>
{
public static readonly long[] Value=A199678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199678.Bytes);
public long this[int i]=>Value[i];

public static A199678Inst Instance=new A199678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199679
{
public static readonly long[] Value={ 3L,25L,223L,2005L,18043L,162385L,1461463L,13153165L,118378483L,1065406345L,9588657103L,86297913925L,776681225323L,6990131027905L,62911179251143L,566200613260285L,5095805519342563L,45862249674083065L,412760247066747583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199679Inst : IEnumerable<long>
{
public static readonly long[] Value=A199679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199679.Bytes);
public long this[int i]=>Value[i];

public static A199679Inst Instance=new A199679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199680
{
public static readonly long[] Value={ 6L,50L,446L,4010L,36086L,324770L,2922926L,26306330L,236756966L,2130812690L,19177314206L,172595827850L,1553362450646L,13980262055810L,125822358502286L,1132401226520570L,10191611038685126L,91724499348166130L,825520494133495166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199680Inst : IEnumerable<long>
{
public static readonly long[] Value=A199680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199680.Bytes);
public long this[int i]=>Value[i];

public static A199680Inst Instance=new A199680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199681
{
public static readonly long[] Value={ 12L,100L,892L,8020L,72172L,649540L,5845852L,52612660L,473513932L,4261625380L,38354628412L,345191655700L,3106724901292L,27960524111620L,251644717004572L,2264802453041140L,20383222077370252L,183448998696332260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199681Inst : IEnumerable<long>
{
public static readonly long[] Value=A199681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199681.Bytes);
public long this[int i]=>Value[i];

public static A199681Inst Instance=new A199681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199682
{
public static readonly long[] Value={ 3L,21L,201L,2001L,20001L,200001L,2000001L,20000001L,200000001L,2000000001L,20000000001L,200000000001L,2000000000001L,20000000000001L,200000000000001L,2000000000000001L,20000000000000001L,200000000000000001L,2000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199682Inst : IEnumerable<long>
{
public static readonly long[] Value=A199682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199682.Bytes);
public long this[int i]=>Value[i];

public static A199682Inst Instance=new A199682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199683
{
public static readonly long[] Value={ 4L,31L,301L,3001L,30001L,300001L,3000001L,30000001L,300000001L,3000000001L,30000000001L,300000000001L,3000000000001L,30000000000001L,300000000000001L,3000000000000001L,30000000000000001L,300000000000000001L,3000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199683Inst : IEnumerable<long>
{
public static readonly long[] Value=A199683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199683.Bytes);
public long this[int i]=>Value[i];

public static A199683Inst Instance=new A199683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199684
{
public static readonly long[] Value={ 5L,41L,401L,4001L,40001L,400001L,4000001L,40000001L,400000001L,4000000001L,40000000001L,400000000001L,4000000000001L,40000000000001L,400000000000001L,4000000000000001L,40000000000000001L,400000000000000001L,4000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199684Inst : IEnumerable<long>
{
public static readonly long[] Value=A199684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199684.Bytes);
public long this[int i]=>Value[i];

public static A199684Inst Instance=new A199684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199685
{
public static readonly long[] Value={ 6L,51L,501L,5001L,50001L,500001L,5000001L,50000001L,500000001L,5000000001L,50000000001L,500000000001L,5000000000001L,50000000000001L,500000000000001L,5000000000000001L,50000000000000001L,500000000000000001L,5000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199685Inst : IEnumerable<long>
{
public static readonly long[] Value=A199685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199685.Bytes);
public long this[int i]=>Value[i];

public static A199685Inst Instance=new A199685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199686
{
public static readonly long[] Value={ 7L,61L,601L,6001L,60001L,600001L,6000001L,60000001L,600000001L,6000000001L,60000000001L,600000000001L,6000000000001L,60000000000001L,600000000000001L,6000000000000001L,60000000000000001L,600000000000000001L,6000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199686Inst : IEnumerable<long>
{
public static readonly long[] Value=A199686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199686.Bytes);
public long this[int i]=>Value[i];

public static A199686Inst Instance=new A199686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199687
{
public static readonly long[] Value={ 8L,71L,701L,7001L,70001L,700001L,7000001L,70000001L,700000001L,7000000001L,70000000001L,700000000001L,7000000000001L,70000000000001L,700000000000001L,7000000000000001L,70000000000000001L,700000000000000001L,7000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199687Inst : IEnumerable<long>
{
public static readonly long[] Value=A199687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199687.Bytes);
public long this[int i]=>Value[i];

public static A199687Inst Instance=new A199687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199688
{
public static readonly long[] Value={ 3L,27L,267L,2667L,26667L,266667L,2666667L,26666667L,266666667L,2666666667L,26666666667L,266666666667L,2666666666667L,26666666666667L,266666666666667L,2666666666666667L,26666666666666667L,266666666666666667L,2666666666666666667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199688Inst : IEnumerable<long>
{
public static readonly long[] Value=A199688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199688.Bytes);
public long this[int i]=>Value[i];

public static A199688Inst Instance=new A199688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199689
{
public static readonly long[] Value={ 9L,81L,801L,8001L,80001L,800001L,8000001L,80000001L,800000001L,8000000001L,80000000001L,800000000001L,8000000000001L,80000000000001L,800000000000001L,8000000000000001L,80000000000000001L,800000000000000001L,8000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199689Inst : IEnumerable<long>
{
public static readonly long[] Value=A199689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199689.Bytes);
public long this[int i]=>Value[i];

public static A199689Inst Instance=new A199689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199690
{
public static readonly long[] Value={ 4L,37L,367L,3667L,36667L,366667L,3666667L,36666667L,366666667L,3666666667L,36666666667L,366666666667L,3666666666667L,36666666666667L,366666666666667L,3666666666666667L,36666666666666667L,366666666666666667L,3666666666666666667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199690Inst : IEnumerable<long>
{
public static readonly long[] Value=A199690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199690.Bytes);
public long this[int i]=>Value[i];

public static A199690Inst Instance=new A199690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199691
{
public static readonly long[] Value={ 12L,111L,1101L,11001L,110001L,1100001L,11000001L,110000001L,1100000001L,11000000001L,110000000001L,1100000000001L,11000000000001L,110000000000001L,1100000000000001L,11000000000000001L,110000000000000001L,1100000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199691Inst : IEnumerable<long>
{
public static readonly long[] Value=A199691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199691.Bytes);
public long this[int i]=>Value[i];

public static A199691Inst Instance=new A199691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199692
{
public static readonly long[] Value={ 5L,41L,73L,149L,157L,277L,313L,613L,617L,709L,929L,1117L,1201L,1741L,1753L,1873L,2381L,2897L,2969L,3469L,3613L,3637L,3697L,4513L,4597L,5101L,5953L,6173L,6857L,6869L,7577L,8089L,8581L,9661L,10369L,10513L,11717L,12097L,12653L,12973L,13001L,13649L,14461L,15313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199692Inst : IEnumerable<long>
{
public static readonly long[] Value=A199692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199692.Bytes);
public long this[int i]=>Value[i];

public static A199692Inst Instance=new A199692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199693
{
public static readonly long[] Value={ 12L,4L,16L,126L,6L,2L,2L,8L,8L,16L,2L,6L,8L,48L,8L,6L,4L,24L,4L,24L,12L,24L,2L,8L,2L,896L,6L,224L,28L,6L,8L,4L,2L,4L,64L,4L,4L,224L,8L,8L,2L,4L,12L,124L,24L,14L,256L,32L,2L,14L,62L,2L,4L,24L,14L,24L,4L,28L,6L,12L,8L,4L,2L,8L,2L,4L,2L,32L,16L,60L,24L,56L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199693Inst : IEnumerable<long>
{
public static readonly long[] Value=A199693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199693.Bytes);
public long this[int i]=>Value[i];

public static A199693Inst Instance=new A199693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199694
{
public static readonly long[] Value={ 1L,2L,4L,8L,19L,42L,99L,208L,443L,906L,1853L,3780L,7595L,15246L,30537L,61160L,122413L,244930L,489985L,980080L,1960257L,3920646L,7841419L,15682972L,31366187L,62732582L,125465509L,250931320L,501863047L,1003726454L,2007453193L,4014906880L,8029814297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199694Inst : IEnumerable<long>
{
public static readonly long[] Value=A199694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199694.Bytes);
public long this[int i]=>Value[i];

public static A199694Inst Instance=new A199694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199695
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,175L,8281L,1856261L,649893049L,817291210163L,1847322434679121L,14368726069959027071UL,BigInteger.Parse("342031303262647675287601"),BigInteger.Parse("13964481217238950868653586531"),BigInteger.Parse("1889891784470148590323094656731121"),BigInteger.Parse("586215019967842464352819482405063771511") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199695Inst Instance=new A199695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199696
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,35L,91L,7337L,25493L,9351479L,42980489L,78695113801L,584834423801L,4754839123536133L,43472885623916761L,BigInteger.Parse("1887750276489057845213"),BigInteger.Parse("21019416307292530253881"),BigInteger.Parse("4675204650607654300508731931"),BigInteger.Parse("77008997457626136207428248409") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199696Inst Instance=new A199696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199697
{
public static readonly long[] Value={ 1L,2L,6L,8L,14L,32L,56L,100L,204L,388L,722L,1416L,2750L,5256L,10222L,19944L,38650L,75272L,147142L,287120L,561018L,1098752L,2152092L,4217620L,8276376L,16250292L,31921374L,62754072L,123440514L,242921784L,478310952L,942260548L,1856994908L,3661288036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199697Inst : IEnumerable<long>
{
public static readonly long[] Value=A199697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199697.Bytes);
public long this[int i]=>Value[i];

public static A199697Inst Instance=new A199697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199698
{
public static readonly long[] Value={ 1L,4L,14L,52L,200L,708L,2642L,10000L,37984L,144876L,554120L,2128672L,8204180L,31697564L,122734614L,476170124L,1850664202L,7204005752L,28081918548L,109604285492L,428278469018L,1675246478864L,6559126501510L,25703606447364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199698Inst : IEnumerable<long>
{
public static readonly long[] Value=A199698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199698.Bytes);
public long this[int i]=>Value[i];

public static A199698Inst Instance=new A199698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199699
{
public static readonly long[] Value={ 1L,6L,32L,168L,892L,4964L,27854L,156920L,891684L,5095360L,29236016L,168361392L,972601784L,5633548460L,32706291872L,190266981972L,1108856802378L,6472638961608L,37836350087956L,221461180199752L,1297757839607606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199699Inst : IEnumerable<long>
{
public static readonly long[] Value=A199699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199699.Bytes);
public long this[int i]=>Value[i];

public static A199699Inst Instance=new A199699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199700
{
public static readonly long[] Value={ 1L,8L,52L,380L,2734L,20116L,149942L,1128388L,8545180L,65055556L,497505902L,3818857188L,29405977172L,227044808964L,1757143904470L,13626887453432L,105870556547144L,823864569255344L,6420445347122416L,50100342760566184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199700Inst : IEnumerable<long>
{
public static readonly long[] Value=A199700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199700.Bytes);
public long this[int i]=>Value[i];

public static A199700Inst Instance=new A199700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199701
{
public static readonly long[] Value={ 1L,10L,82L,724L,6504L,59992L,559028L,5252900L,49700882L,472873888L,4519281222L,43353372676L,417214414596L,4026070558436L,38943205468034L,377469980604452L,3665456335373858L,35651726951195532L,347268836196275908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199701Inst : IEnumerable<long>
{
public static readonly long[] Value=A199701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199701.Bytes);
public long this[int i]=>Value[i];

public static A199701Inst Instance=new A199701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199702
{
public static readonly long[] Value={ 1L,12L,114L,1236L,13324L,147072L,1643204L,18527516L,210316392L,2400684208L,27527644696L,316844861020L,3658598730648L,42361908912360L,491666143730354L,5718341649577364L,66629811252553344L,777637357808739752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199702Inst : IEnumerable<long>
{
public static readonly long[] Value=A199702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199702.Bytes);
public long this[int i]=>Value[i];

public static A199702Inst Instance=new A199702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199703
{
public static readonly long[] Value={ 1L,14L,156L,1940L,24394L,314532L,4099204L,53901956L,713719390L,9503449352L,127119684220L,1706849222504L,22991898594206L,310564824249656L,4205016717658718L,57054704774633892L,775562100878527252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199703Inst : IEnumerable<long>
{
public static readonly long[] Value=A199703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199703.Bytes);
public long this[int i]=>Value[i];

public static A199703Inst Instance=new A199703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199704
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,6L,1L,6L,14L,8L,1L,8L,32L,52L,14L,1L,10L,52L,168L,200L,32L,1L,12L,82L,380L,892L,708L,56L,1L,14L,114L,724L,2734L,4964L,2642L,100L,1L,16L,156L,1236L,6504L,20116L,27854L,10000L,204L,1L,18L,200L,1940L,13324L,59992L,149942L,156920L,37984L,388L,1L,20L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199704Inst : IEnumerable<long>
{
public static readonly long[] Value=A199704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199704.Bytes);
public long this[int i]=>Value[i];

public static A199704Inst Instance=new A199704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199705
{
public static readonly long[] Value={ 6L,14L,32L,52L,82L,114L,156L,200L,254L,310L,376L,444L,522L,602L,692L,784L,886L,990L,1104L,1220L,1346L,1474L,1612L,1752L,1902L,2054L,2216L,2380L,2554L,2730L,2916L,3104L,3302L,3502L,3712L,3924L,4146L,4370L,4604L,4840L,5086L,5334L,5592L,5852L,6122L,6394L,6676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199705Inst : IEnumerable<long>
{
public static readonly long[] Value=A199705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199705.Bytes);
public long this[int i]=>Value[i];

public static A199705Inst Instance=new A199705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199706
{
public static readonly long[] Value={ 8L,52L,168L,380L,724L,1236L,1940L,2872L,4068L,5552L,7360L,9528L,12080L,15052L,18480L,22388L,26812L,31788L,37340L,43504L,50316L,57800L,65992L,74928L,84632L,95140L,106488L,118700L,131812L,145860L,160868L,176872L,193908L,212000L,231184L,251496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199706Inst : IEnumerable<long>
{
public static readonly long[] Value=A199706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199706.Bytes);
public long this[int i]=>Value[i];

public static A199706Inst Instance=new A199706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199707
{
public static readonly long[] Value={ 14L,200L,892L,2734L,6504L,13324L,24394L,41344L,65788L,99858L,145596L,205612L,282386L,379036L,498440L,644218L,819692L,1028960L,1275766L,1564716L,1899968L,2286630L,2729288L,3233528L,3804374L,4447920L,5169588L,5975974L,6872944L,7867572L,8966146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199707Inst : IEnumerable<long>
{
public static readonly long[] Value=A199707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199707.Bytes);
public long this[int i]=>Value[i];

public static A199707Inst Instance=new A199707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199708
{
public static readonly long[] Value={ 32L,708L,4964L,20116L,59992L,147072L,314532L,608420L,1089752L,1836600L,2946204L,4537152L,6751384L,9756388L,13747296L,18948952L,25618064L,34045344L,44557532L,57519592L,73336788L,92456792L,115371796L,142620672L,174790996L,212521224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199708Inst : IEnumerable<long>
{
public static readonly long[] Value=A199708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199708.Bytes);
public long this[int i]=>Value[i];

public static A199708Inst Instance=new A199708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199709
{
public static readonly long[] Value={ 56L,2642L,27854L,149942L,559028L,1643204L,4099204L,9059092L,18251656L,34171380L,60292468L,101279218L,163252890L,254042820L,383508158L,563826638L,809873706L,1139548482L,1574209250L,2139036592L,2863528108L,3781894246L,4933615190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199709Inst : IEnumerable<long>
{
public static readonly long[] Value=A199709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199709.Bytes);
public long this[int i]=>Value[i];

public static A199709Inst Instance=new A199709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199710
{
public static readonly long[] Value={ 1L,1L,14L,41L,223L,979L,3878L,20483L,70897L,408073L,1329734L,7964417L,25250959L,154039339L,482301806L,2967115019L,9237038497L,57046572241L,177128072702L,1095861584537L,3398526529663L,21043253658307L,65224098543926L,404010494645843L,1251923775716881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199710Inst : IEnumerable<long>
{
public static readonly long[] Value=A199710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199710.Bytes);
public long this[int i]=>Value[i];

public static A199710Inst Instance=new A199710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199711
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,4L,4L,1L,1L,3L,6L,7L,5L,1L,1L,3L,7L,10L,11L,6L,1L,1L,3L,9L,13L,17L,16L,7L,1L,1L,4L,11L,16L,27L,28L,22L,8L,1L,1L,4L,13L,22L,37L,44L,44L,29L,9L,1L,1L,4L,15L,24L,49L,64L,72L,66L,37L,10L,1L,1L,5L,18L,32L,66L,85L,116L,116L,95L,46L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199711Inst : IEnumerable<long>
{
public static readonly long[] Value=A199711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199711.Bytes);
public long this[int i]=>Value[i];

public static A199711Inst Instance=new A199711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199712
{
public static readonly long[] Value={ 3L,7L,8L,5L,8L,0L,6L,5L,6L,7L,5L,1L,9L,7L,4L,0L,6L,6L,6L,7L,6L,7L,6L,8L,4L,2L,8L,1L,7L,8L,8L,3L,1L,6L,0L,8L,6L,9L,8L,0L,2L,8L,9L,6L,1L,3L,5L,7L,8L,4L,4L,1L,9L,5L,8L,2L,1L,8L,7L,9L,2L,0L,7L,5L,8L,2L,9L,1L,4L,2L,0L,7L,4L,1L,6L,0L,0L,7L,4L,2L,2L,4L,2L,6L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199712Inst : IEnumerable<long>
{
public static readonly long[] Value=A199712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199712.Bytes);
public long this[int i]=>Value[i];

public static A199712Inst Instance=new A199712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199713
{
public static readonly long[] Value={ 23L,13L,53L,17L,101L,31L,71L,109L,223L,229L,103L,73L,149L,347L,347L,353L,359L,163L,167L,107L,137L,97L,283L,389L,179L,1013L,1013L,701L,1009L,131L,271L,311L,173L,193L,419L,1051L,571L,613L,617L,317L,197L,811L,911L,1039L,719L,919L,1021L,1223L,2027L,1229L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199713Inst : IEnumerable<long>
{
public static readonly long[] Value=A199713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199713.Bytes);
public long this[int i]=>Value[i];

public static A199713Inst Instance=new A199713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199714
{
public static readonly long[] Value={ 0L,9L,23L,30L,35L,49L,58L,73L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199714Inst : IEnumerable<long>
{
public static readonly long[] Value=A199714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199714.Bytes);
public long this[int i]=>Value[i];

public static A199714Inst Instance=new A199714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199715
{
public static readonly long[] Value={ 2L,8L,2L,3L,4L,9L,4L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199715Inst : IEnumerable<long>
{
public static readonly long[] Value=A199715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199715.Bytes);
public long this[int i]=>Value[i];

public static A199715Inst Instance=new A199715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199716
{
public static readonly long[] Value={ 16L,20L,21L,35L,37L,50L,51L,54L,55L,61L,66L,68L,76L,79L,81L,83L,86L,89L,90L,105L,112L,115L,118L,121L,125L,128L,130L,131L,134L,141L,142L,145L,146L,149L,150L,151L,153L,156L,160L,161L,165L,168L,180L,181L,186L,190L,191L,195L,200L,202L,208L,211L,212L,219L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199716Inst : IEnumerable<long>
{
public static readonly long[] Value=A199716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199716.Bytes);
public long this[int i]=>Value[i];

public static A199716Inst Instance=new A199716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199717
{
public static readonly long[] Value={ 6L,11L,13L,24L,26L,27L,31L,34L,36L,41L,46L,48L,56L,57L,62L,63L,69L,71L,73L,88L,91L,92L,96L,97L,101L,102L,104L,106L,111L,116L,119L,122L,123L,126L,132L,136L,139L,154L,166L,167L,171L,173L,174L,176L,178L,179L,187L,188L,189L,193L,196L,201L,206L,207L,209L,216L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199717Inst : IEnumerable<long>
{
public static readonly long[] Value=A199717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199717.Bytes);
public long this[int i]=>Value[i];

public static A199717Inst Instance=new A199717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199718
{
public static readonly long[] Value={ 5L,9L,10L,15L,23L,25L,29L,30L,32L,40L,42L,43L,44L,45L,49L,58L,60L,65L,70L,72L,75L,80L,85L,87L,93L,94L,95L,98L,99L,100L,107L,109L,110L,114L,117L,120L,133L,135L,137L,140L,155L,158L,159L,163L,164L,170L,172L,175L,177L,184L,185L,192L,194L,197L,198L,199L,204L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199718Inst : IEnumerable<long>
{
public static readonly long[] Value=A199718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199718.Bytes);
public long this[int i]=>Value[i];

public static A199718Inst Instance=new A199718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199719
{
public static readonly long[] Value={ 1L,8L,3L,7L,1L,8L,8L,7L,3L,0L,0L,1L,5L,1L,4L,3L,9L,2L,4L,2L,5L,7L,5L,6L,9L,4L,4L,1L,6L,2L,2L,0L,0L,8L,2L,3L,2L,5L,5L,8L,4L,2L,3L,7L,5L,1L,1L,5L,2L,9L,8L,6L,0L,1L,3L,5L,4L,9L,2L,3L,6L,1L,7L,3L,4L,8L,3L,1L,2L,5L,7L,1L,2L,9L,0L,7L,2L,5L,7L,0L,9L,7L,2L,6L,5L,2L,8L,7L,3L,8L,1L,9L,8L,4L,7L,6L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199719Inst : IEnumerable<long>
{
public static readonly long[] Value=A199719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199719.Bytes);
public long this[int i]=>Value[i];

public static A199719Inst Instance=new A199719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199720
{
public static readonly long[] Value={ 1L,6L,7L,5L,7L,1L,3L,3L,5L,8L,1L,7L,7L,0L,1L,5L,2L,7L,0L,4L,0L,5L,4L,3L,4L,8L,9L,1L,5L,2L,9L,3L,0L,4L,6L,0L,2L,9L,7L,1L,7L,0L,1L,7L,0L,7L,7L,6L,4L,1L,4L,8L,9L,9L,7L,3L,1L,7L,4L,6L,6L,7L,6L,8L,1L,8L,4L,0L,9L,5L,0L,6L,8L,2L,0L,7L,2L,6L,1L,6L,0L,3L,0L,4L,1L,5L,2L,6L,7L,8L,4L,1L,6L,2L,3L,6L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199720Inst : IEnumerable<long>
{
public static readonly long[] Value=A199720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199720.Bytes);
public long this[int i]=>Value[i];

public static A199720Inst Instance=new A199720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199721
{
public static readonly long[] Value={ 1L,4L,6L,4L,3L,3L,5L,1L,0L,3L,8L,6L,8L,0L,6L,7L,6L,6L,9L,6L,2L,3L,7L,2L,0L,4L,7L,8L,4L,2L,0L,4L,0L,8L,3L,7L,6L,2L,4L,9L,2L,5L,7L,4L,8L,6L,5L,8L,7L,2L,1L,7L,0L,0L,0L,4L,2L,3L,4L,7L,0L,1L,5L,6L,4L,2L,9L,2L,1L,9L,5L,7L,5L,8L,3L,4L,2L,4L,6L,0L,5L,7L,9L,4L,7L,6L,4L,9L,5L,8L,0L,7L,8L,8L,8L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199721Inst : IEnumerable<long>
{
public static readonly long[] Value=A199721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199721.Bytes);
public long this[int i]=>Value[i];

public static A199721Inst Instance=new A199721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199722
{
public static readonly long[] Value={ 1L,1L,7L,3L,1L,4L,8L,3L,8L,0L,8L,5L,5L,4L,0L,4L,0L,7L,9L,5L,3L,5L,9L,8L,3L,2L,2L,6L,8L,7L,2L,9L,2L,2L,6L,3L,8L,8L,3L,5L,8L,6L,5L,0L,3L,2L,0L,0L,9L,5L,2L,8L,9L,8L,4L,1L,2L,5L,8L,8L,4L,1L,1L,2L,4L,3L,1L,2L,6L,8L,6L,4L,8L,6L,0L,3L,4L,7L,1L,1L,7L,9L,6L,5L,8L,1L,0L,0L,6L,8L,7L,5L,2L,5L,3L,9L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199722Inst : IEnumerable<long>
{
public static readonly long[] Value=A199722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199722.Bytes);
public long this[int i]=>Value[i];

public static A199722Inst Instance=new A199722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199723
{
public static readonly long[] Value={ 1L,7L,8L,0L,6L,0L,8L,1L,1L,9L,9L,6L,6L,6L,3L,5L,2L,0L,4L,3L,3L,7L,8L,0L,1L,8L,4L,9L,0L,7L,6L,6L,6L,6L,9L,2L,2L,1L,7L,0L,4L,2L,1L,7L,2L,5L,7L,3L,1L,8L,2L,1L,6L,4L,4L,5L,0L,6L,1L,2L,5L,1L,4L,5L,5L,7L,4L,8L,0L,4L,1L,0L,5L,0L,9L,3L,6L,1L,6L,8L,3L,3L,2L,8L,5L,0L,1L,3L,2L,4L,6L,4L,7L,8L,4L,6L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199723Inst : IEnumerable<long>
{
public static readonly long[] Value=A199723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199723.Bytes);
public long this[int i]=>Value[i];

public static A199723Inst Instance=new A199723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199724
{
public static readonly long[] Value={ 1L,6L,5L,1L,0L,0L,0L,9L,3L,4L,4L,3L,9L,7L,1L,5L,7L,9L,8L,3L,0L,6L,8L,4L,8L,0L,8L,9L,8L,0L,4L,5L,7L,2L,8L,1L,4L,4L,1L,5L,8L,2L,8L,5L,5L,2L,9L,2L,4L,1L,7L,7L,2L,2L,7L,0L,8L,0L,6L,8L,6L,3L,4L,0L,5L,3L,0L,3L,9L,3L,7L,2L,0L,6L,4L,5L,5L,1L,8L,9L,7L,0L,1L,0L,4L,9L,1L,3L,7L,3L,7L,4L,0L,8L,3L,2L,9L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199724Inst : IEnumerable<long>
{
public static readonly long[] Value=A199724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199724.Bytes);
public long this[int i]=>Value[i];

public static A199724Inst Instance=new A199724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199725
{
public static readonly long[] Value={ 1L,4L,9L,2L,4L,6L,3L,2L,3L,9L,8L,0L,6L,3L,7L,8L,6L,7L,2L,0L,7L,0L,4L,0L,6L,5L,8L,9L,5L,2L,8L,0L,4L,3L,7L,9L,9L,0L,6L,1L,7L,7L,3L,6L,3L,5L,7L,2L,8L,3L,4L,3L,9L,2L,8L,5L,2L,5L,8L,7L,8L,2L,8L,0L,2L,6L,8L,9L,2L,1L,3L,0L,5L,6L,7L,0L,6L,7L,6L,5L,8L,6L,7L,6L,6L,6L,9L,3L,5L,0L,8L,0L,7L,5L,7L,2L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199725Inst : IEnumerable<long>
{
public static readonly long[] Value=A199725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199725.Bytes);
public long this[int i]=>Value[i];

public static A199725Inst Instance=new A199725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199726
{
public static readonly long[] Value={ 1L,2L,9L,2L,7L,6L,2L,3L,8L,4L,7L,7L,3L,4L,9L,5L,8L,4L,6L,0L,6L,7L,8L,8L,8L,4L,3L,5L,4L,1L,5L,7L,7L,9L,4L,2L,1L,7L,5L,7L,9L,7L,4L,4L,3L,8L,5L,3L,3L,8L,3L,3L,0L,4L,0L,0L,1L,6L,5L,1L,7L,8L,5L,7L,9L,6L,3L,9L,9L,4L,3L,6L,1L,3L,5L,4L,8L,4L,5L,8L,8L,3L,6L,6L,0L,3L,3L,9L,3L,1L,8L,8L,8L,5L,3L,3L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199726Inst : IEnumerable<long>
{
public static readonly long[] Value=A199726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199726.Bytes);
public long this[int i]=>Value[i];

public static A199726Inst Instance=new A199726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199727
{
public static readonly long[] Value={ 1L,7L,4L,3L,6L,8L,8L,9L,5L,6L,4L,9L,1L,3L,0L,2L,3L,1L,6L,1L,6L,2L,9L,2L,1L,5L,5L,3L,0L,1L,3L,6L,0L,0L,8L,5L,3L,4L,0L,4L,4L,2L,1L,2L,6L,5L,1L,5L,2L,8L,7L,9L,2L,8L,4L,2L,3L,0L,9L,1L,7L,6L,0L,3L,6L,8L,5L,9L,2L,4L,2L,1L,5L,3L,6L,5L,0L,9L,1L,4L,4L,6L,5L,7L,6L,4L,8L,3L,9L,1L,2L,3L,1L,9L,0L,1L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199727Inst : IEnumerable<long>
{
public static readonly long[] Value=A199727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199727.Bytes);
public long this[int i]=>Value[i];

public static A199727Inst Instance=new A199727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199728
{
public static readonly long[] Value={ 1L,6L,3L,5L,6L,8L,8L,7L,5L,1L,1L,5L,4L,1L,1L,0L,1L,7L,9L,7L,7L,8L,6L,1L,4L,4L,1L,8L,0L,3L,7L,7L,9L,0L,9L,4L,8L,4L,0L,9L,9L,5L,7L,9L,5L,1L,2L,3L,6L,0L,7L,1L,2L,7L,8L,3L,2L,8L,3L,6L,7L,8L,3L,3L,6L,7L,9L,0L,7L,1L,7L,4L,8L,1L,6L,2L,8L,8L,7L,4L,5L,8L,1L,5L,6L,0L,2L,3L,7L,3L,3L,8L,9L,0L,7L,7L,6L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199728Inst : IEnumerable<long>
{
public static readonly long[] Value=A199728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199728.Bytes);
public long this[int i]=>Value[i];

public static A199728Inst Instance=new A199728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199729
{
public static readonly long[] Value={ 1L,5L,0L,8L,8L,1L,6L,7L,0L,3L,3L,4L,9L,5L,0L,3L,0L,5L,0L,7L,8L,1L,0L,1L,8L,0L,8L,2L,7L,2L,2L,1L,6L,3L,4L,0L,4L,3L,9L,1L,6L,0L,1L,1L,1L,5L,3L,6L,3L,4L,9L,5L,7L,1L,8L,3L,5L,6L,9L,7L,7L,9L,0L,0L,4L,5L,5L,7L,7L,3L,8L,6L,2L,8L,6L,5L,0L,7L,4L,7L,7L,6L,6L,5L,3L,0L,0L,1L,4L,4L,2L,4L,5L,8L,4L,3L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199729Inst : IEnumerable<long>
{
public static readonly long[] Value=A199729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199729.Bytes);
public long this[int i]=>Value[i];

public static A199729Inst Instance=new A199729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199730
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,2L,0L,0L,6L,2L,3L,6L,1L,3L,7L,1L,8L,4L,4L,2L,2L,5L,1L,0L,3L,4L,8L,6L,3L,3L,7L,3L,9L,6L,5L,4L,6L,2L,4L,7L,3L,4L,9L,1L,7L,2L,6L,7L,2L,4L,4L,4L,8L,6L,3L,3L,6L,7L,0L,9L,2L,9L,2L,5L,2L,1L,6L,1L,5L,6L,1L,8L,7L,2L,8L,0L,4L,4L,8L,2L,8L,9L,4L,3L,7L,5L,7L,3L,7L,2L,4L,8L,0L,7L,5L,1L,2L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199730Inst : IEnumerable<long>
{
public static readonly long[] Value=A199730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199730.Bytes);
public long this[int i]=>Value[i];

public static A199730Inst Instance=new A199730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199731
{
public static readonly long[] Value={ 3L,8L,0L,2L,8L,4L,2L,7L,0L,0L,6L,2L,3L,5L,9L,1L,7L,1L,6L,4L,0L,4L,3L,7L,9L,7L,5L,1L,8L,8L,5L,5L,4L,9L,8L,3L,5L,2L,0L,1L,6L,2L,3L,0L,2L,9L,5L,9L,6L,2L,4L,3L,7L,0L,5L,5L,8L,8L,6L,2L,4L,0L,5L,4L,1L,0L,7L,3L,1L,2L,1L,0L,7L,7L,9L,5L,1L,0L,7L,4L,3L,9L,3L,3L,6L,0L,5L,3L,6L,4L,5L,4L,5L,6L,8L,5L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199731Inst : IEnumerable<long>
{
public static readonly long[] Value=A199731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199731.Bytes);
public long this[int i]=>Value[i];

public static A199731Inst Instance=new A199731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199732
{
public static readonly long[] Value={ 1L,7L,1L,7L,7L,6L,1L,7L,0L,1L,5L,5L,9L,1L,4L,6L,7L,3L,7L,9L,4L,6L,5L,4L,6L,9L,3L,7L,6L,8L,3L,0L,8L,4L,0L,1L,0L,8L,3L,6L,6L,9L,6L,2L,7L,3L,2L,6L,4L,6L,5L,7L,0L,5L,3L,1L,8L,2L,8L,1L,3L,5L,5L,1L,1L,2L,3L,7L,5L,0L,4L,2L,0L,1L,0L,9L,6L,6L,9L,3L,3L,1L,2L,8L,9L,7L,5L,5L,1L,6L,9L,0L,7L,5L,6L,1L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199732Inst : IEnumerable<long>
{
public static readonly long[] Value=A199732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199732.Bytes);
public long this[int i]=>Value[i];

public static A199732Inst Instance=new A199732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199733
{
public static readonly long[] Value={ 3L,7L,4L,6L,1L,6L,8L,5L,6L,5L,5L,2L,8L,2L,2L,1L,3L,4L,0L,6L,8L,7L,0L,1L,3L,5L,6L,0L,5L,2L,7L,5L,9L,6L,9L,7L,8L,8L,5L,6L,5L,4L,6L,3L,8L,9L,1L,5L,6L,5L,1L,1L,2L,9L,8L,1L,8L,6L,5L,6L,4L,7L,4L,8L,5L,8L,6L,8L,4L,6L,3L,2L,8L,1L,8L,3L,2L,6L,3L,6L,7L,2L,5L,2L,8L,2L,4L,8L,1L,0L,6L,7L,7L,2L,4L,4L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199733Inst : IEnumerable<long>
{
public static readonly long[] Value=A199733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199733.Bytes);
public long this[int i]=>Value[i];

public static A199733Inst Instance=new A199733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199734
{
public static readonly long[] Value={ 1L,6L,2L,5L,2L,7L,8L,3L,8L,3L,3L,7L,8L,4L,4L,8L,6L,4L,3L,9L,3L,3L,0L,0L,3L,2L,2L,6L,2L,4L,6L,8L,3L,6L,1L,0L,6L,0L,8L,6L,5L,5L,9L,6L,7L,1L,6L,5L,8L,5L,7L,2L,8L,1L,5L,4L,4L,7L,5L,9L,5L,5L,8L,3L,7L,9L,3L,6L,1L,2L,3L,7L,9L,4L,4L,8L,6L,8L,8L,1L,9L,7L,7L,8L,7L,3L,1L,5L,2L,5L,4L,9L,3L,4L,0L,9L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199734Inst : IEnumerable<long>
{
public static readonly long[] Value=A199734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199734.Bytes);
public long this[int i]=>Value[i];

public static A199734Inst Instance=new A199734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199735
{
public static readonly long[] Value={ 3L,6L,9L,2L,2L,1L,4L,2L,4L,5L,4L,3L,5L,8L,4L,0L,4L,6L,1L,1L,2L,1L,0L,1L,6L,8L,2L,9L,3L,7L,2L,6L,8L,7L,5L,3L,8L,5L,0L,8L,6L,7L,2L,6L,7L,2L,8L,8L,7L,7L,5L,4L,8L,6L,6L,1L,1L,3L,9L,7L,7L,6L,9L,2L,3L,2L,9L,4L,3L,2L,8L,2L,7L,9L,0L,8L,1L,8L,4L,0L,2L,9L,2L,5L,4L,9L,9L,1L,9L,7L,2L,2L,4L,2L,6L,7L,1L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199735Inst : IEnumerable<long>
{
public static readonly long[] Value=A199735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199735.Bytes);
public long this[int i]=>Value[i];

public static A199735Inst Instance=new A199735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199736
{
public static readonly long[] Value={ 1L,5L,1L,9L,5L,1L,4L,9L,2L,6L,4L,7L,0L,4L,0L,1L,2L,2L,1L,5L,8L,5L,7L,0L,5L,1L,6L,2L,0L,9L,8L,1L,4L,8L,9L,9L,0L,5L,5L,6L,3L,3L,9L,8L,8L,6L,8L,9L,3L,4L,3L,5L,6L,3L,8L,8L,5L,1L,9L,2L,1L,5L,1L,6L,1L,7L,9L,8L,1L,3L,3L,8L,5L,2L,1L,7L,2L,7L,8L,9L,7L,2L,6L,8L,0L,2L,0L,5L,3L,1L,2L,0L,1L,8L,1L,2L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199736Inst : IEnumerable<long>
{
public static readonly long[] Value=A199736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199736.Bytes);
public long this[int i]=>Value[i];

public static A199736Inst Instance=new A199736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199737
{
public static readonly long[] Value={ 3L,6L,4L,1L,7L,3L,6L,5L,1L,0L,4L,2L,3L,2L,0L,3L,0L,8L,9L,1L,5L,6L,8L,0L,1L,7L,1L,2L,1L,9L,1L,6L,8L,8L,9L,1L,9L,4L,7L,4L,4L,1L,5L,6L,3L,0L,6L,1L,3L,8L,5L,4L,5L,6L,9L,0L,8L,9L,9L,4L,2L,4L,5L,1L,9L,9L,5L,8L,6L,1L,0L,9L,4L,0L,3L,4L,5L,1L,0L,1L,0L,9L,8L,2L,7L,9L,2L,6L,9L,6L,7L,0L,5L,5L,8L,2L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199737Inst : IEnumerable<long>
{
public static readonly long[] Value=A199737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199737.Bytes);
public long this[int i]=>Value[i];

public static A199737Inst Instance=new A199737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199738
{
public static readonly long[] Value={ 1L,3L,9L,6L,9L,4L,8L,6L,8L,3L,5L,4L,5L,6L,8L,4L,7L,7L,2L,3L,5L,2L,8L,6L,3L,5L,7L,9L,4L,6L,5L,2L,6L,8L,2L,1L,3L,9L,8L,0L,4L,3L,6L,8L,9L,7L,5L,9L,2L,7L,1L,4L,1L,0L,6L,1L,4L,0L,9L,5L,0L,0L,9L,7L,9L,8L,5L,7L,9L,4L,3L,9L,4L,6L,9L,5L,5L,3L,7L,2L,4L,5L,5L,0L,3L,7L,8L,5L,0L,4L,7L,9L,5L,3L,7L,9L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199738Inst : IEnumerable<long>
{
public static readonly long[] Value=A199738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199738.Bytes);
public long this[int i]=>Value[i];

public static A199738Inst Instance=new A199738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199739
{
public static readonly long[] Value={ 1L,4L,4L,0L,9L,8L,5L,1L,6L,3L,2L,1L,0L,3L,7L,3L,7L,7L,8L,4L,5L,1L,3L,8L,0L,4L,5L,4L,2L,3L,4L,8L,2L,8L,4L,2L,7L,0L,0L,4L,4L,4L,9L,0L,2L,5L,8L,2L,4L,3L,7L,6L,1L,9L,4L,5L,8L,1L,2L,3L,9L,0L,7L,5L,8L,1L,0L,0L,9L,0L,6L,8L,5L,1L,7L,2L,3L,1L,6L,1L,3L,5L,1L,8L,1L,2L,2L,7L,6L,6L,1L,9L,1L,2L,4L,3L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199739Inst : IEnumerable<long>
{
public static readonly long[] Value=A199739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199739.Bytes);
public long this[int i]=>Value[i];

public static A199739Inst Instance=new A199739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199740
{
public static readonly long[] Value={ 1L,2L,7L,3L,0L,8L,0L,7L,1L,4L,9L,0L,1L,0L,1L,5L,3L,5L,9L,2L,5L,0L,2L,7L,2L,7L,8L,3L,1L,5L,1L,9L,3L,1L,8L,9L,0L,6L,6L,8L,3L,2L,5L,7L,2L,2L,2L,0L,8L,4L,0L,8L,0L,9L,8L,9L,7L,0L,7L,5L,2L,5L,0L,5L,4L,1L,1L,7L,3L,9L,5L,0L,4L,6L,9L,5L,9L,7L,1L,1L,5L,0L,7L,2L,8L,6L,7L,7L,2L,1L,6L,8L,7L,1L,1L,5L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199740Inst : IEnumerable<long>
{
public static readonly long[] Value=A199740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199740.Bytes);
public long this[int i]=>Value[i];

public static A199740Inst Instance=new A199740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199741
{
public static readonly long[] Value={ 1L,0L,6L,4L,2L,3L,0L,2L,2L,2L,8L,7L,1L,0L,7L,3L,0L,2L,6L,1L,0L,0L,2L,1L,4L,1L,1L,4L,3L,2L,9L,4L,3L,7L,0L,9L,6L,1L,8L,8L,5L,3L,9L,5L,1L,3L,2L,8L,5L,9L,0L,3L,4L,3L,2L,7L,7L,7L,8L,0L,7L,8L,2L,9L,8L,7L,6L,2L,3L,4L,5L,8L,5L,6L,7L,8L,1L,2L,6L,1L,3L,4L,2L,7L,5L,4L,9L,5L,8L,7L,5L,5L,7L,3L,7L,3L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199741Inst : IEnumerable<long>
{
public static readonly long[] Value=A199741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199741.Bytes);
public long this[int i]=>Value[i];

public static A199741Inst Instance=new A199741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199742
{
public static readonly long[] Value={ 7L,9L,7L,7L,7L,5L,5L,9L,3L,3L,0L,1L,3L,9L,6L,5L,6L,4L,7L,3L,4L,0L,8L,3L,2L,2L,9L,1L,2L,9L,0L,2L,4L,5L,4L,4L,4L,1L,8L,4L,2L,8L,9L,4L,1L,3L,6L,1L,8L,0L,6L,2L,5L,8L,3L,6L,2L,8L,4L,6L,0L,1L,5L,1L,1L,2L,9L,9L,9L,1L,1L,6L,8L,4L,5L,4L,0L,3L,8L,6L,7L,5L,8L,8L,2L,3L,3L,0L,3L,1L,6L,3L,1L,5L,3L,5L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199742Inst : IEnumerable<long>
{
public static readonly long[] Value=A199742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199742.Bytes);
public long this[int i]=>Value[i];

public static A199742Inst Instance=new A199742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199743
{
public static readonly long[] Value={ 15L,32L,96L,960L,5280L,640320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199743Inst : IEnumerable<long>
{
public static readonly long[] Value=A199743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199743.Bytes);
public long this[int i]=>Value[i];

public static A199743Inst Instance=new A199743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199744
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,2L,-1L,-4L,1L,7L,0L,-12L,-3L,20L,10L,-32L,-25L,49L,55L,-71L,-112L,95L,216L,-111L,-399L,94L,710L,11L,-1220L,-316L,2024L,1037L,-3233L,-2573L,4941L,5634L,-7137L,-11440L,9505L,22015L,-11008L,-40592L,9073L,72112L,1934L,-123712L,-33453L,204897L,107499L,-326675L,-264664L,498119L,577060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199744Inst : IEnumerable<long>
{
public static readonly long[] Value=A199744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199744.Bytes);
public long this[int i]=>Value[i];

public static A199744Inst Instance=new A199744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199745
{
public static readonly long[] Value={ 2145L,2730L,4641L,4845L,5005L,5460L,5610L,6435L,7410L,8190L,8778L,9177L,10725L,10920L,11220L,11305L,11730L,13485L,13585L,13650L,13923L,14535L,14820L,16380L,16830L,17017L,17556L,19110L,19305L,20010L,20930L,21489L,21505L,21840L,22230L,22440L,23460L,23529L,23595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199745Inst : IEnumerable<long>
{
public static readonly long[] Value=A199745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199745.Bytes);
public long this[int i]=>Value[i];

public static A199745Inst Instance=new A199745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199746
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,66L,449L,3678L,35111L,383192L,4704300L,64172052L,962908056L,15762088585L,279514500434L,5338014558032L,109224066408835L,2383887010044728L,55281768382909480L,1357381019671809552L,BigInteger.Parse("35180557115610914376"),BigInteger.Parse("959798458208463538416"),BigInteger.Parse("27494554196938752676656") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199746Inst Instance=new A199746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199747
{
public static readonly BigInteger[] Value={ 1L,2L,21L,455L,14950L,658008L,36288252L,2404808340L,186087894300L,16466440817750L,1639875152957965L,181513211783531667L,BigInteger.Parse("22105238818111121361"),BigInteger.Parse("2937279723907795168000"),BigInteger.Parse("422879027090638497044400"),BigInteger.Parse("65572027180886570401929144"),BigInteger.Parse("10894880155433107077641916792") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199747Inst Instance=new A199747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199748
{
public static readonly BigInteger[] Value={ 1L,1L,10L,220L,7315L,324632L,18009460L,1198774720L,93080887185L,8258898672310L,824313388697656L,91408035226209520L,11149106984707682900UL,BigInteger.Parse("1483408105790477598270"),BigInteger.Parse("213807915740948618992925"),BigInteger.Parse("33186033477308745271085760"),BigInteger.Parse("5518696446064784220490766525") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199748Inst Instance=new A199748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199749
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,1L,61L,-23L,-391L,149L,8731L,-50299L,-422111L,7453L,1282822973L,57034969L,-20654287L,-312999143L,9991318331L,1542439211L,-22986862505597L,-201806454439L,-211506271693601L,5229666198697L,1077172798985427449L,-61387659243913771L,-6860376024090670391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199749Inst : IEnumerable<long>
{
public static readonly long[] Value=A199749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199749.Bytes);
public long this[int i]=>Value[i];

public static A199749Inst Instance=new A199749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199750
{
public static readonly ulong[] Value={ 3L,23L,243L,2663L,29283L,322103L,3543123L,38974343L,428717763L,4715895383L,51874849203L,570623341223L,6276856753443L,69045424287863L,759499667166483L,8354496338831303L,91899459727144323L,1010894056998587543L,11119834626984462963UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199750Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199750.Bytes);
public ulong this[int i]=>Value[i];

public static A199750Inst Instance=new A199750Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199751
{
public static readonly long[] Value={ 2L,17L,182L,1997L,21962L,241577L,2657342L,29230757L,321538322L,3536921537L,38906136902L,427967505917L,4707642565082L,51784068215897L,569624750374862L,6265872254123477L,68924594795358242L,758170542748940657L,8339875970238347222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199751Inst : IEnumerable<long>
{
public static readonly long[] Value=A199751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199751.Bytes);
public long this[int i]=>Value[i];

public static A199751Inst Instance=new A199751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199752
{
public static readonly long[] Value={ 4L,34L,364L,3994L,43924L,483154L,5314684L,58461514L,643076644L,7073843074L,77812273804L,855935011834L,9415285130164L,103568136431794L,1139249500749724L,12531744508246954L,137849189590716484L,1516341085497881314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199752Inst : IEnumerable<long>
{
public static readonly long[] Value=A199752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199752.Bytes);
public long this[int i]=>Value[i];

public static A199752Inst Instance=new A199752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199753
{
public static readonly long[] Value={ 5L,45L,485L,5325L,58565L,644205L,7086245L,77948685L,857435525L,9431790765L,103749698405L,1141246682445L,12553713506885L,138090848575725L,1518999334332965L,16708992677662605L,183798919454288645L,2021788113997175085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199753Inst : IEnumerable<long>
{
public static readonly long[] Value=A199753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199753.Bytes);
public long this[int i]=>Value[i];

public static A199753Inst Instance=new A199753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199754
{
public static readonly long[] Value={ 3L,28L,303L,3328L,36603L,402628L,4428903L,48717928L,535897203L,5894869228L,64843561503L,713279176528L,7846070941803L,86306780359828L,949374583958103L,10443120423539128L,114874324658930403L,1263617571248234428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199754Inst : IEnumerable<long>
{
public static readonly long[] Value=A199754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199754.Bytes);
public long this[int i]=>Value[i];

public static A199754Inst Instance=new A199754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199755
{
public static readonly long[] Value={ 6L,56L,606L,6656L,73206L,805256L,8857806L,97435856L,1071794406L,11789738456L,129687123006L,1426558353056L,15692141883606L,172613560719656L,1898749167916206L,20886240847078256L,229748649317860806L,2527235142496468856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199755Inst : IEnumerable<long>
{
public static readonly long[] Value=A199755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199755.Bytes);
public long this[int i]=>Value[i];

public static A199755Inst Instance=new A199755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199756
{
public static readonly long[] Value={ 7L,67L,727L,7987L,87847L,966307L,10629367L,116923027L,1286153287L,14147686147L,155624547607L,1711870023667L,18830570260327L,207136272863587L,2278499001499447L,25063489016493907L,275698379181432967L,3032682170995762627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199756Inst : IEnumerable<long>
{
public static readonly long[] Value=A199756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199756.Bytes);
public long this[int i]=>Value[i];

public static A199756Inst Instance=new A199756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}