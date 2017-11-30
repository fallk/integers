using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A131511
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,26L,29L,31L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,46L,47L,51L,53L,55L,56L,57L,58L,59L,61L,62L,63L,65L,67L,68L,69L,71L,73L,74L,79L,82L,83L,85L,86L,87L,88L,89L,91L,93L,94L,95L,97L,101L,102L,103L,104L,105L };
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
public class A131511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131511Inst : IEnumerable<long>
{
public static readonly long[] Value=A131511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131511.Bytes);
public long this[int i]=>Value[i];

public static A131511Inst Instance=new A131511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131592
{
public static readonly BigInteger[] Value={ 4L,4L,87L,86606L,204330315L,792563962432L,4719861842243387L,BigInteger.Parse("41451006295401961098") };
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
public class A131592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131592Inst Instance=new A131592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131593
{
public static readonly long[] Value={ 4L,12L,34L,118L,520L,1738L,5310L,13528L,25332L };
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
public class A131593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131593Inst : IEnumerable<long>
{
public static readonly long[] Value=A131593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131593.Bytes);
public long this[int i]=>Value[i];

public static A131593Inst Instance=new A131593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131594
{
public static readonly long[] Value={ 4L,7L,1L,4L,0L,4L,5L,2L,0L,7L,9L,1L,0L,3L,1L,6L,8L,2L,9L,3L,3L,8L,9L,6L,2L,4L,1L,4L,0L,3L,2L,3L,2L,6L,9L,2L,8L,5L,6L,5L,5L,7L,2L,9L,1L,7L,9L,2L,3L,1L,6L,0L,2L,4L,3L,9L,2L,2L,2L,6L,5L,7L,9L,3L,3L,0L,2L,4L,4L,1L,5L,9L,4L,8L,7L,3L,6L,9L,0L,1L,2L,9L,5L,0L,1L,2L,9L,1L,7L,8L,1L,0L,9L,2L,1L,3L,8L,5L,7L,5L,7L,8L,3L,3L,7L };
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
public class A131594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131594Inst : IEnumerable<long>
{
public static readonly long[] Value=A131594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131594.Bytes);
public long this[int i]=>Value[i];

public static A131594Inst Instance=new A131594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131595
{
public static readonly long[] Value={ 2L,0L,6L,4L,5L,7L,2L,8L,8L,0L,7L,0L,6L,7L,6L,0L,3L,0L,7L,3L,1L,0L,8L,1L,4L,3L,7L,2L,8L,6L,6L,3L,3L,1L,5L,1L,9L,2L,8L,8L,8L,4L,9L,0L,0L,4L,0L,1L,2L,2L,3L,7L,9L,9L,5L,0L,4L,8L,5L,1L,3L,6L,4L,8L,4L,2L,8L,6L,4L,2L,7L,9L,0L,6L,5L,0L,7L,5L,9L,4L,7L,7L,5L,9L,8L,9L,2L,9L,4L,8L,9L,6L,6L,5L,1L,0L,5L,2L,8L,8L,5L,9L,2L,6L,5L,1L,3L,7L,0L,5L,5L,4L,1L,7L,7L,0L,0L,3L,1L,9L };
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
public class A131595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131595Inst : IEnumerable<long>
{
public static readonly long[] Value=A131595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131595.Bytes);
public long this[int i]=>Value[i];

public static A131595Inst Instance=new A131595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131596
{
public static readonly long[] Value={ 1L,0L,3L,8L,8L,7L,9L,9L,9L,5L,4L,5L,7L,1L,2L,9L,6L,4L,1L,9L,3L,7L,6L,0L,0L,9L,5L,3L };
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
public class A131596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131596Inst : IEnumerable<long>
{
public static readonly long[] Value=A131596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131596.Bytes);
public long this[int i]=>Value[i];

public static A131596Inst Instance=new A131596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131597
{
public static readonly long[] Value={ 0L,1L,3L,2L,3L,4L,4L,3L,4L,4L,2L,4L,3L,5L,4L,4L,4L,4L,3L,4L,4L,3L,5L,4L,4L,4L,5L,5L,2L,5L,3L,5L,4L,4L,5L,4L,3L,3L,4L,4L,4L,5L,4L,3L,5L,5L,5L,4L,5L,5L,5L,4L,5L,5L,3L,5L,5L,3L,2L,5L,4L,3L,5L,6L,4L,5L,4L,4L,5L,6L,3L,4L,3L,4L,5L,3L,5L,5L,3L,5L,6L,5L,5L,5L,5L,5L,4L,4L,3L,5L,5L,5L,5L,6L,5L,5L,4L,6L,5L,5L,3L,5L,5L,4L,5L };
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
public class A131597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131597Inst : IEnumerable<long>
{
public static readonly long[] Value=A131597.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131597.Bytes);
public long this[int i]=>Value[i];

public static A131597Inst Instance=new A131597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131598
{
public static readonly long[] Value={ 2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L };
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
public class A131598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131598Inst : IEnumerable<long>
{
public static readonly long[] Value=A131598.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131598.Bytes);
public long this[int i]=>Value[i];

public static A131598Inst Instance=new A131598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131599
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,24L,26L,84L,284L,816L,1424L,1674L,149274L,278874L,280726L,2808716L,2963576L,8533626L,23558584L,27969274L,28769826L,29804174L,47778874L,88769826L,282980174L,297956374L,884776174L,934198626L,1645509274L,2660505174L };
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
public class A131599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131599Inst : IEnumerable<long>
{
public static readonly long[] Value=A131599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131599.Bytes);
public long this[int i]=>Value[i];

public static A131599Inst Instance=new A131599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131600
{
public static readonly long[] Value={ 19L,37L,55L,397L,1063L,2053L,9199L,28333L,65287L,230869L,740863L,1916029L,6071671L,19407205L,53895727L,163185805L,512515495L,1482638581L,4419983071L,13645261981L,40332756439L,119892451717L,365507167375L,1091496783277L,3249560914183L,9828689926933L,29475632025919L };
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
public class A131600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131600Inst : IEnumerable<long>
{
public static readonly long[] Value=A131600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131600.Bytes);
public long this[int i]=>Value[i];

public static A131600Inst Instance=new A131600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131601
{
public static readonly long[] Value={ 49L,97L,145L,2497L,7153L,14113L,133969L,477313L,1154737L,7585249L,30496273L,85923649L,450015601L,1913836705L,6038171857L,27638920705L,119503082545L,409335331681L,1736003525521L,7472151487681L,27120247408369L,110448416633377L,469111688042065L,1770883563643777L };
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
public class A131601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131601Inst : IEnumerable<long>
{
public static readonly long[] Value=A131601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131601.Bytes);
public long this[int i]=>Value[i];

public static A131601Inst Instance=new A131601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131602
{
public static readonly long[] Value={ 1L,9L,14L,3L,7L,7L,9L,11L,9L,7L,15L,4L,10L,7L,12L,1L,5L,15L,3L,9L,12L,12L,0L,6L,0L,5L,12L,14L,13L,12L,8L,3L,4L,1L,0L,8L,2L,2L,7L,6L,11L,15L,3L,10L,2L,7L,2L,5L,1L,15L,8L,6L,12L,6L,10L,1L,1L,13L,0L,12L,1L,8L,14L,9L,5L,2L,7L,6L,7L,15L,0L,11L,1L,5L,3L,13L,2L,7L,11L,7L,15L,0L,3L,4L,7L,0L,4L,5L,11L,5L,11L };
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
public class A131602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131602Inst : IEnumerable<long>
{
public static readonly long[] Value=A131602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131602.Bytes);
public long this[int i]=>Value[i];

public static A131602Inst Instance=new A131602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131603
{
public static readonly long[] Value={ 4L,3L,6L,5L,4L,4L,4L,4L,4L,5L,5L,9L,10L,10L,10L,9L,10L,9L,10L,10L,9L,13L,16L,15L,14L,14L,14L,14L,14L,15L,8L,12L,15L,14L,13L,13L,13L,13L,13L,14L,8L,12L,15L,14L,13L,13L,13L,13L,13L,14L,7L,11L,14L,13L,12L,12L,12L,12L,12L,13L,8L,12L,15L,14L,13L,13L,13L,13L,13L,14L,7L,11L,14L,13L,12L,12L,12L,12L,12L,13L,7L,11L,14L,13L,12L,12L,12L,12L,12L,13L,9L,13L,16L,15L,14L,14L,14L,14L,14L,15L,9L };
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
public class A131603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131603Inst : IEnumerable<long>
{
public static readonly long[] Value=A131603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131603.Bytes);
public long this[int i]=>Value[i];

public static A131603Inst Instance=new A131603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131604
{
public static readonly long[] Value={ 2L,67L,71L,151L,157L,199L,257L,263L,277L,281L,311L,359L,373L,401L,461L,467L,499L,503L,521L,523L,541L,563L,571L,577L,613L,641L,661L,673L,677L,733L,739L,743L,761L,809L,829L,859L,863L,911L,929L,941L,967L,983L,991L,1019L,1031L,1051L,1063L,1093L,1103L,1123L };
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
public class A131604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131604Inst : IEnumerable<long>
{
public static readonly long[] Value=A131604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131604.Bytes);
public long this[int i]=>Value[i];

public static A131604Inst Instance=new A131604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131605
{
public static readonly long[] Value={ 1L,36L,100L,144L,196L,216L,225L,324L,400L,441L,484L,576L,676L,784L,900L,1000L,1089L,1156L,1225L,1296L,1444L,1521L,1600L,1728L,1764L,1936L,2025L,2116L,2304L,2500L,2601L,2704L,2744L,2916L,3025L,3136L,3249L,3364L,3375L,3600L,3844L,3969L,4225L,4356L,4624L };
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
public class A131605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131605Inst : IEnumerable<long>
{
public static readonly long[] Value=A131605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131605.Bytes);
public long this[int i]=>Value[i];

public static A131605Inst Instance=new A131605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131606
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,8L,4L,2L,1L,81L,27L,9L,3L,1L,3125L,625L,125L,25L,5L,1L,262144L,32768L,4096L,512L,64L,8L,1L,62748517L,4826809L,371293L,28561L,2197L,169L,13L,1L,37822859361L,1801088541L,85766121L,4084101L,194481L,9261L,441L,21L,1L,60716992766464L };
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
public class A131606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131606Inst : IEnumerable<long>
{
public static readonly long[] Value=A131606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131606.Bytes);
public long this[int i]=>Value[i];

public static A131606Inst Instance=new A131606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131607
{
public static readonly long[] Value={ 1L,4L,9L,23L,57L,139L,336L,811L,1960L,4732L,11424L,27580L,66585L,160752L,388089L,936931L,2261953L,5460839L,13183632L,31828103L };
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
public class A131607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131607Inst : IEnumerable<long>
{
public static readonly long[] Value=A131607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131607.Bytes);
public long this[int i]=>Value[i];

public static A131607Inst Instance=new A131607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131944
{
public static readonly long[] Value={ 1L,1L,-5L,1L,6L,-5L,8L,1L,-23L,6L,12L,-5L,14L,8L,-30L,1L,18L,-23L,20L,6L,-40L,12L,24L,-5L,31L,14L,-77L,8L,30L,-30L,32L,1L,-60L,18L,48L,-23L,38L,20L,-70L,6L,42L,-40L,44L,12L,-138L,24L,48L,-5L,57L,31L,-90L,14L,54L,-77L,72L,8L,-100L,30L,60L,-30L,62L,32L,-184L };
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
public class A131944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131944Inst : IEnumerable<long>
{
public static readonly long[] Value=A131944.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131944.Bytes);
public long this[int i]=>Value[i];

public static A131944Inst Instance=new A131944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131945
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,8L,10L,15L,18L,26L,32L,45L,55L,74L,90L,119L,145L,188L,228L,291L,351L,442L,532L,664L,796L,982L,1172L,1435L,1708L,2076L,2462L,2972L,3512L,4214L,4966L,5929L,6965L,8272L,9688L,11457L,13383L,15762L,18362L,21543L,25031L,29264L,33922L,39533L,45717L };
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
public class A131945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131945Inst : IEnumerable<long>
{
public static readonly long[] Value=A131945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131945.Bytes);
public long this[int i]=>Value[i];

public static A131945Inst Instance=new A131945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131946
{
public static readonly long[] Value={ 1L,-4L,4L,-4L,20L,-24L,4L,-32L,52L,-4L,24L,-48L,20L,-56L,32L,-24L,116L,-72L,4L,-80L,120L,-32L,48L,-96L,52L,-124L,56L,-4L,160L,-120L,24L,-128L,244L,-48L,72L,-192L,20L,-152L,80L,-56L,312L,-168L,32L,-176L,240L,-24L,96L,-192L,116L,-228L,124L,-72L,280L,-216L,4L };
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
public class A131946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131946Inst : IEnumerable<long>
{
public static readonly long[] Value=A131946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131946.Bytes);
public long this[int i]=>Value[i];

public static A131946Inst Instance=new A131946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131947
{
public static readonly long[] Value={ 1L,-1L,1L,-5L,6L,-1L,8L,-13L,1L,-6L,12L,-5L,14L,-8L,6L,-29L,18L,-1L,20L,-30L,8L,-12L,24L,-13L,31L,-14L,1L,-40L,30L,-6L,32L,-61L,12L,-18L,48L,-5L,38L,-20L,14L,-78L,42L,-8L,44L,-60L,6L,-24L,48L,-29L,57L,-31L,18L,-70L,54L,-1L,72L,-104L,20L,-30L,60L,-30L,62L };
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
public class A131947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131947Inst : IEnumerable<long>
{
public static readonly long[] Value=A131947.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131947.Bytes);
public long this[int i]=>Value[i];

public static A131947Inst Instance=new A131947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131948
{
public static readonly long[] Value={ 1L,3L,3L,5L,6L,5L,7L,9L,9L,7L,9L,12L,14L,12L,9L,11L,15L,20L,20L,15L,11L,13L,18L,27L,32L,27L,18L,13L,15L,21L,35L,49L,49L,35L,21L,15L,17L,24L,44L,72L,86L,72L,44L,24L,17L,19L,27L,54L,102L,144L,144L,102L,54L,27L,19L };
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
public class A131948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131948Inst : IEnumerable<long>
{
public static readonly long[] Value=A131948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131948.Bytes);
public long this[int i]=>Value[i];

public static A131948Inst Instance=new A131948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131949
{
public static readonly long[] Value={ 1L,6L,16L,32L,56L,92L,148L,240L,400L,692L,1244L,2312L,4408L,8556L,16804L,33248L,66080L,131684L,262828L,525048L,1049416L,2098076L,4195316L,8389712L,16778416L,33555732L,67110268L,134219240L,268437080L,536872652L };
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
public class A131949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131949Inst : IEnumerable<long>
{
public static readonly long[] Value=A131949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131949.Bytes);
public long this[int i]=>Value[i];

public static A131949Inst Instance=new A131949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131950
{
public static readonly long[] Value={ 1L,3L,3L,5L,4L,5L,7L,6L,6L,7L,9L,8L,10L,8L,9L,11L,10L,15L,15L,10L,11L,13L,12L,21L,26L,21L,12L,13L,15L,14L,28L,42L,42L,28L,14L,15L,17L,16L,36L,64L,78L,64L,36L,16L,17L,19L,18L,45L,93L,135L,135L,93L,45L,18L,19L };
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
public class A131950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131950Inst : IEnumerable<long>
{
public static readonly long[] Value=A131950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131950.Bytes);
public long this[int i]=>Value[i];

public static A131950Inst Instance=new A131950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131951
{
public static readonly long[] Value={ 1L,6L,14L,26L,44L,72L,118L,198L,344L,620L,1154L,2202L,4276L,8400L,16622L,33038L,65840L,131412L,262522L,524706L,1049036L,2097656L,4194854L,8389206L,16777864L,33555132L,67109618L };
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
public class A131951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131951Inst : IEnumerable<long>
{
public static readonly long[] Value=A131951.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131951.Bytes);
public long this[int i]=>Value[i];

public static A131951Inst Instance=new A131951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131952
{
public static readonly long[] Value={ 2047L,8388607L,1082401L,3277L,536870911L,8727391L,4033L,137438953471L,9588151L };
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
public class A131952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131952Inst : IEnumerable<long>
{
public static readonly long[] Value=A131952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131952.Bytes);
public long this[int i]=>Value[i];

public static A131952Inst Instance=new A131952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131953
{
public static readonly long[] Value={ 1L,4L,2L,4L,5L,4L,10L,5L,7L,8L,16L,11L,7L,11L,16L,34L,17L,13L,11L,19L,32L,64L,35L,19L,17L,19L,35L,64L,130L,65L,37L,23L,25L,35L,67L,128L,256L,131L,67L,41L,31L,41L,67L,131L,256L,514L,257L,133L,71L,49L,47L,73L,131L,259L,512L };
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
public class A131953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131953Inst : IEnumerable<long>
{
public static readonly long[] Value=A131953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131953.Bytes);
public long this[int i]=>Value[i];

public static A131953Inst Instance=new A131953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131954
{
public static readonly long[] Value={ 1L,3L,9L,6L,9L,18L,18L,18L,36L,36L,45L,36L,36L,54L,54L,72L,72L,63L,54L,63L,72L,81L,108L,90L,81L,90L,117L,99L,144L,126L,144L,117L,153L,153L,153L,180L,162L,117L,198L,207L,153L,198L,198L,234L,216L,225L,234L,243L,234L,225L,207L,288L,297L,279L,297L,351L,279L,306L,333L,297L };
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
public class A131954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131954Inst : IEnumerable<long>
{
public static readonly long[] Value=A131954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131954.Bytes);
public long this[int i]=>Value[i];

public static A131954Inst Instance=new A131954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131955
{
public static readonly long[] Value={ 1L,3L,6L,5L,2L,5L,2L,17L,17L,23L,14L,23L,23L,23L,23L,23L,41L,41L,41L,41L,41L,50L,41L,59L,68L,59L,68L,59L,68L,86L,86L,104L,95L,95L,104L,86L,104L,86L,122L,95L,104L,113L,149L,95L,140L,95L,131L,122L,149L,140L,140L,113L,185L,149L,185L,149L,176L,194L,176L,185L,194L,194L,203L };
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
public class A131955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131955Inst : IEnumerable<long>
{
public static readonly long[] Value=A131955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131955.Bytes);
public long this[int i]=>Value[i];

public static A131955Inst Instance=new A131955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131956
{
public static readonly long[] Value={ 6L,7L,9L,9L,9L,14L,9L,13L,13L,11L,13L,14L,9L,14L,11L,17L,15L,18L,9L,11L,11L,22L,24L,23L,13L,11L,13L,15L,10L,14L,14L,21L,18L,15L,17L,14L,10L,14L,9L,13L,21L,18L,20L,20L,22L,37L,39L,38L,15L,18L,10L,11L,14L,22L,24L,23L,13L,11L,13L,16L,13L,16L,17L,25L,21L,22L,15L,16L,13L,26L,28L,25L,15L };
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
public class A131956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131956Inst : IEnumerable<long>
{
public static readonly long[] Value=A131956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131956.Bytes);
public long this[int i]=>Value[i];

public static A131956Inst Instance=new A131956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131957
{
public static readonly long[] Value={ 4L,4L,4L,5L,6L,6L,5L,6L,5L,6L,6L,7L,6L,7L,6L,7L,6L,7L,6L,6L,8L,8L,7L,8L,6L,7L,7L,8L,7L,8L,7L,8L,7L,8L,6L,8L,7L,7L,7L,7L,6L,8L,8L,9L,8L,9L,8L,10L,7L,8L,7L,7L,7L,9L,8L,9L,7L,8L,8L,9L,8L,9L,8L,9L,8L,9L,8L,8L,8L,7L,8L,10L,8L,7L,7L,8L,8L,8L,7L,8L,8L,8L,7L,10L,10L,10L,9L,10L,8L,10L,10L,10L,10L,10L,9L,12L,8L,9L,7L,9L };
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
public class A131957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131957Inst : IEnumerable<long>
{
public static readonly long[] Value=A131957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131957.Bytes);
public long this[int i]=>Value[i];

public static A131957Inst Instance=new A131957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131958
{
public static readonly BigInteger[] Value={ 5L,73L,21601L,BigInteger.Parse("2097197194438629126172451944256706311040000000000001") };
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
public class A131958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131958Inst Instance=new A131958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131959
{
public static readonly long[] Value={ 1L,2L,3L,8L };
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
public class A131959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131959Inst : IEnumerable<long>
{
public static readonly long[] Value=A131959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131959.Bytes);
public long this[int i]=>Value[i];

public static A131959Inst Instance=new A131959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132232
{
public static readonly long[] Value={ 11L,41L,71L,101L,131L,191L,251L,281L,311L,401L,431L,461L,491L,521L,641L,701L,761L,821L,881L,911L,941L,971L,1031L,1061L,1091L,1151L,1181L,1301L,1361L,1451L,1481L,1511L,1571L,1601L,1721L,1811L,1871L,1901L,1931L,2081L,2111L,2141L,2351L,2381L,2411L,2441L,2531L };
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
public class A132232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132232Inst : IEnumerable<long>
{
public static readonly long[] Value=A132232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132232.Bytes);
public long this[int i]=>Value[i];

public static A132232Inst Instance=new A132232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132233
{
public static readonly long[] Value={ 13L,43L,73L,103L,163L,193L,223L,283L,313L,373L,433L,463L,523L,613L,643L,673L,733L,823L,853L,883L,1033L,1063L,1093L,1123L,1153L,1213L,1303L,1423L,1453L,1483L,1543L,1663L,1693L,1723L,1753L,1783L,1873L,1933L,1993L,2053L,2083L,2113L,2143L,2203L,2293L,2383L };
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
public class A132233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132233Inst : IEnumerable<long>
{
public static readonly long[] Value=A132233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132233.Bytes);
public long this[int i]=>Value[i];

public static A132233Inst Instance=new A132233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132234
{
public static readonly long[] Value={ 19L,79L,109L,139L,199L,229L,349L,379L,409L,439L,499L,619L,709L,739L,769L,829L,859L,919L,1009L,1039L,1069L,1129L,1249L,1279L,1399L,1429L,1459L,1489L,1549L,1579L,1609L,1669L,1699L,1759L,1789L,1879L,1999L,2029L,2089L,2179L,2239L,2269L,2389L,2539L,2659L,2689L };
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
public class A132234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132234Inst : IEnumerable<long>
{
public static readonly long[] Value=A132234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132234.Bytes);
public long this[int i]=>Value[i];

public static A132234Inst Instance=new A132234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132235
{
public static readonly long[] Value={ 23L,53L,83L,113L,173L,233L,263L,293L,353L,383L,443L,503L,563L,593L,653L,683L,743L,773L,863L,953L,983L,1013L,1103L,1163L,1193L,1223L,1283L,1373L,1433L,1493L,1523L,1553L,1583L,1613L,1733L,1823L,1913L,1973L,2003L,2063L,2153L,2213L,2243L,2273L,2333L,2393L };
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
public class A132235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132235Inst : IEnumerable<long>
{
public static readonly long[] Value=A132235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132235.Bytes);
public long this[int i]=>Value[i];

public static A132235Inst Instance=new A132235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132236
{
public static readonly long[] Value={ 29L,59L,89L,149L,179L,239L,269L,359L,389L,419L,449L,479L,509L,569L,599L,659L,719L,809L,839L,929L,1019L,1049L,1109L,1229L,1259L,1289L,1319L,1409L,1439L,1499L,1559L,1619L,1709L,1889L,1949L,1979L,2039L,2069L,2099L,2129L,2309L,2339L,2399L,2459L,2549L,2579L };
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
public class A132236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132236Inst : IEnumerable<long>
{
public static readonly long[] Value=A132236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132236.Bytes);
public long this[int i]=>Value[i];

public static A132236Inst Instance=new A132236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132237
{
public static readonly long[] Value={ 7L,23L,37L,53L,67L,83L,97L,113L,127L,157L,173L,233L,263L,277L,293L,307L,337L,353L,367L,383L,397L,443L,457L,487L,503L,547L,563L,577L,593L,607L,653L,683L,727L,743L,757L,773L,787L,863L,877L,907L,937L,953L,967L,983L,997L,1013L,1087L,1103L };
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
public class A132237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132237Inst : IEnumerable<long>
{
public static readonly long[] Value=A132237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132237.Bytes);
public long this[int i]=>Value[i];

public static A132237Inst Instance=new A132237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132238
{
public static readonly long[] Value={ 11L,13L,41L,43L,71L,73L,101L,103L,131L,163L,191L,193L,223L,251L,281L,283L,311L,313L,373L,401L,431L,433L,461L,463L,491L,521L,523L,613L,641L,643L,673L,701L,733L,761L,821L,823L,853L,881L,883L,911L,941L,971L,1031L,1033L,1061L,1063L };
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
public class A132238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132238Inst : IEnumerable<long>
{
public static readonly long[] Value=A132238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132238.Bytes);
public long this[int i]=>Value[i];

public static A132238Inst Instance=new A132238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132239
{
public static readonly long[] Value={ 17L,19L,47L,79L,107L,109L,137L,139L,167L,197L,199L,227L,229L,257L,317L,347L,349L,379L,409L,439L,467L,499L,557L,587L,617L,619L,647L,677L,709L,739L,769L,797L,827L,829L,857L,859L,887L,919L,947L,977L,1009L,1039L,1069L,1097L,1129L,1187L };
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
public class A132239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132239Inst : IEnumerable<long>
{
public static readonly long[] Value=A132239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132239.Bytes);
public long this[int i]=>Value[i];

public static A132239Inst Instance=new A132239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132240
{
public static readonly long[] Value={ 29L,31L,59L,61L,89L,149L,151L,179L,181L,211L,239L,241L,269L,271L,331L,359L,389L,419L,421L,449L,479L,509L,541L,569L,571L,599L,601L,631L,659L,661L,691L,719L,751L,809L,811L,839L,929L,991L,1019L,1021L,1049L,1051L,1109L,1171L,1201L,1229L,1231L };
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
public class A132240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132240Inst : IEnumerable<long>
{
public static readonly long[] Value=A132240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132240.Bytes);
public long this[int i]=>Value[i];

public static A132240Inst Instance=new A132240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132241
{
public static readonly long[] Value={ 11L,13L,41L,43L,71L,73L,101L,103L,191L,193L,281L,283L,311L,313L,431L,433L,461L,463L,521L,523L,641L,643L,821L,823L,881L,883L,1031L,1033L,1061L,1063L,1091L,1093L,1151L,1153L,1301L,1303L,1451L,1453L,1481L,1483L,1721L,1723L,1871L,1873L };
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
public class A132241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132241Inst : IEnumerable<long>
{
public static readonly long[] Value=A132241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132241.Bytes);
public long this[int i]=>Value[i];

public static A132241Inst Instance=new A132241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132242
{
public static readonly long[] Value={ 17L,19L,107L,109L,137L,139L,197L,199L,227L,229L,347L,349L,617L,619L,827L,829L,857L,859L,1277L,1279L,1427L,1429L,1487L,1489L,1607L,1609L,1667L,1669L,1697L,1699L,1787L,1789L,1877L,1879L,1997L,1999L,2027L,2029L,2087L,2089L,2237L,2239L,2267L,2269L,2657L,2659L };
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
public class A132242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132242Inst : IEnumerable<long>
{
public static readonly long[] Value=A132242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132242.Bytes);
public long this[int i]=>Value[i];

public static A132242Inst Instance=new A132242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132243
{
public static readonly long[] Value={ 29L,31L,59L,61L,149L,151L,179L,181L,239L,241L,269L,271L,419L,421L,569L,571L,599L,601L,659L,661L,809L,811L,1019L,1021L,1049L,1051L,1229L,1231L,1289L,1291L,1319L,1321L,1619L,1621L,1949L,1951L,2129L,2131L,2309L,2311L,2339L,2341L,2549L,2551L,2729L,2731L,2789L };
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
public class A132243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132243Inst : IEnumerable<long>
{
public static readonly long[] Value=A132243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132243.Bytes);
public long this[int i]=>Value[i];

public static A132243Inst Instance=new A132243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132244
{
public static readonly long[] Value={ 11L,13L,17L,19L,41L,43L,71L,73L,101L,103L,107L,109L,137L,139L,191L,193L,197L,199L,227L,229L,281L,283L,311L,313L,347L,349L,431L,433L,461L,463L,521L,523L,617L,619L,641L,643L,821L,823L,827L,829L,857L,859L,881L,883L,1031L,1033L,1061L,1063L };
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
public class A132244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132244Inst : IEnumerable<long>
{
public static readonly long[] Value=A132244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132244.Bytes);
public long this[int i]=>Value[i];

public static A132244Inst Instance=new A132244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132245
{
public static readonly long[] Value={ 11L,13L,29L,31L,41L,43L,59L,61L,71L,73L,101L,103L,149L,151L,179L,181L,191L,193L,239L,241L,269L,271L,281L,283L,311L,313L,419L,421L,431L,433L,461L,463L,521L,523L,569L,571L,599L,601L,641L,643L,659L,661L,809L,811L,821L,823L,881L,883L,1019L,1021L };
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
public class A132245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132245Inst : IEnumerable<long>
{
public static readonly long[] Value=A132245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132245.Bytes);
public long this[int i]=>Value[i];

public static A132245Inst Instance=new A132245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132246
{
public static readonly long[] Value={ 17L,19L,29L,31L,59L,61L,107L,109L,137L,139L,149L,151L,179L,181L,197L,199L,227L,229L,239L,241L,269L,271L,347L,349L,419L,421L,569L,571L,599L,601L,617L,619L,659L,661L,809L,811L,827L,829L,857L,859L,1019L,1021L,1049L,1051L,1229L,1231L };
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
public class A132246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132246Inst : IEnumerable<long>
{
public static readonly long[] Value=A132246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132246.Bytes);
public long this[int i]=>Value[i];

public static A132246Inst Instance=new A132246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132247
{
public static readonly long[] Value={ 11L,13L,17L,19L,29L,31L,41L,43L,59L,61L,71L,73L,101L,103L,107L,109L,137L,139L,149L,151L,179L,181L,191L,193L,197L,199L,227L,229L,239L,241L,269L,271L,281L,283L,311L,313L,347L,349L,419L,421L,431L,433L,461L,463L,521L,523L,569L,571L,599L,601L,617L,619L,641L,643L };
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
public class A132247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132247Inst : IEnumerable<long>
{
public static readonly long[] Value=A132247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132247.Bytes);
public long this[int i]=>Value[i];

public static A132247Inst Instance=new A132247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132344
{
public static readonly long[] Value={ 0L,1L,4L,6L,16L,20L,48L,56L,128L,144L,320L,352L,768L,832L,1792L,1920L,4096L,4352L,9216L,9728L,20480L,21504L,45056L,47104L,98304L,102400L,212992L,221184L,458752L,475136L,983040L,1015808L,2097152L,2162688L,4456448L };
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
public class A132344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132344Inst : IEnumerable<long>
{
public static readonly long[] Value=A132344.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132344.Bytes);
public long this[int i]=>Value[i];

public static A132344Inst Instance=new A132344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132345
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,4L,4L,4L,5L,5L,5L,5L,8L,8L,10L,10L,11L,11L,11L,11L,12L,16L,16L,18L,19L,19L,19L,19L,22L,22L,22L,22L,27L,27L,27L,27L,28L,28L,28L,28L,29L,31L,31L,31L,34L,40L,44L,44L,45L,45L,47L,47L,48L,48L,48L,48L,49L,49L,49L,51L,58L,58L,58L,58L,59L,59L,59L,59L,64L,64L,64L,68L };
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
public class A132345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132345Inst : IEnumerable<long>
{
public static readonly long[] Value=A132345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132345.Bytes);
public long this[int i]=>Value[i];

public static A132345Inst Instance=new A132345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132346
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,18L };
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
public class A132346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132346Inst : IEnumerable<long>
{
public static readonly long[] Value=A132346.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132346.Bytes);
public long this[int i]=>Value[i];

public static A132346Inst Instance=new A132346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132347
{
public static readonly BigInteger[] Value={ 1L,10L,100L,1001L,10010L,100101L,1001011L,10010111L,100101112L,1001011122L,10010111223L,100101112234L,1001011122345L,10010111223457L,100101112234579L,10010111223457912L,1001011122345791216L,BigInteger.Parse("100101112234579121621") };
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
public class A132347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132347Inst Instance=new A132347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132348
{
public static readonly long[] Value={ 0L,1L,7L,16L,17L,111L,47L,97L,131L,170L,161L,201L,170L,184L,255L,307L,160L,334L,231L,247L,162L,183L,406L,441L,242L,439L,328L,367L,370L,427L,430L,399L,363L,322L,573L,400L,483L,576L,606L,483L,572L,438L,475L,592L,770L,726L,543L,836L,555L,770L,871L,796L,1109L,755L };
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
public class A132348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132348Inst : IEnumerable<long>
{
public static readonly long[] Value=A132348.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132348.Bytes);
public long this[int i]=>Value[i];

public static A132348Inst Instance=new A132348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132349
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,3L,2L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,3L,0L,0L,0L,0L,5L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L };
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
public class A132349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132349Inst : IEnumerable<long>
{
public static readonly long[] Value=A132349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132349.Bytes);
public long this[int i]=>Value[i];

public static A132349Inst Instance=new A132349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132350
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L };
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
public class A132350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132350Inst : IEnumerable<long>
{
public static readonly long[] Value=A132350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132350.Bytes);
public long this[int i]=>Value[i];

public static A132350Inst Instance=new A132350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132351
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,6L,6L,6L,7L,8L,9L,10L,11L,12L,12L,13L,14L,15L,16L,17L,18L,19L,20L,20L,21L,21L,22L,23L,24L,25L,25L,26L,27L,28L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L };
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
public class A132351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132351Inst : IEnumerable<long>
{
public static readonly long[] Value=A132351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132351.Bytes);
public long this[int i]=>Value[i];

public static A132351Inst Instance=new A132351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132352
{
public static readonly long[] Value={ 1L,3L,6L,9L,13L,18L,24L,30L,36L,43L,51L,60L,70L,81L,93L,105L,118L,132L,147L,163L,180L,198L,217L,237L,257L,278L,299L,321L,344L,368L,393L,418L,444L,471L,499L,527L,556L,586L,617L,649L,682L,716L,751L,787L,824L,862L,901L,941L,981L,1022L,1064L,1107L,1151L,1196L,1242L,1289L,1337L };
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
public class A132352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132352Inst : IEnumerable<long>
{
public static readonly long[] Value=A132352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132352.Bytes);
public long this[int i]=>Value[i];

public static A132352Inst Instance=new A132352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132353
{
public static readonly long[] Value={ 1L,2L,6L,20L,61L,183L,547L,1640L,4920L,14762L,44287L,132861L,398581L,1195742L,3587226L,10761680L,32285041L,96855123L,290565367L,871696100L,2615088300L,7845264902L,23535794707L,70607384121L,211822152361L,635466457082L };
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
public class A132353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132353Inst : IEnumerable<long>
{
public static readonly long[] Value=A132353.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132353.Bytes);
public long this[int i]=>Value[i];

public static A132353Inst Instance=new A132353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132354
{
public static readonly long[] Value={ 0L,5L,9L,24L,32L,57L,69L,104L,120L,165L,185L,240L,264L,329L,357L,432L,464L,549L,585L,680L,720L,825L,869L,984L,1032L,1157L,1209L,1344L,1400L,1545L,1605L,1760L,1824L,1989L,2057L,2232L,2304L,2489L,2565L,2760L,2840L,3045L,3129L,3344L,3432L,3657L,3749L,3984L,4080L };
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
public class A132354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132354Inst : IEnumerable<long>
{
public static readonly long[] Value=A132354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132354.Bytes);
public long this[int i]=>Value[i];

public static A132354Inst Instance=new A132354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132355
{
public static readonly long[] Value={ 0L,7L,11L,32L,40L,75L,87L,136L,152L,215L,235L,312L,336L,427L,455L,560L,592L,711L,747L,880L,920L,1067L,1111L,1272L,1320L,1495L,1547L,1736L,1792L,1995L,2055L,2272L,2336L,2567L,2635L,2880L,2952L,3211L,3287L,3560L,3640L,3927L,4011L,4312L,4400L,4715L,4807L };
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
public class A132355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132355Inst : IEnumerable<long>
{
public static readonly long[] Value=A132355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132355.Bytes);
public long this[int i]=>Value[i];

public static A132355Inst Instance=new A132355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132356
{
public static readonly long[] Value={ 0L,8L,12L,36L,44L,84L,96L,152L,168L,240L,260L,348L,372L,476L,504L,624L,656L,792L,828L,980L,1020L,1188L,1232L,1416L,1464L,1664L,1716L,1932L,1988L,2220L,2280L,2528L,2592L,2856L,2924L,3204L,3276L,3572L,3648L,3960L,4040L,4368L,4452L,4796L,4884L,5244L,5336L,5712L };
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
public class A132356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132356Inst : IEnumerable<long>
{
public static readonly long[] Value=A132356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132356.Bytes);
public long this[int i]=>Value[i];

public static A132356Inst Instance=new A132356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132357
{
public static readonly long[] Value={ 1L,4L,14L,41L,122L,364L,1093L,3280L,9842L,29525L,88574L,265720L,797161L,2391484L,7174454L,21523361L,64570082L,193710244L,581130733L,1743392200L,5230176602L,15690529805L,47071589414L,141214768240L,423644304721L };
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
public class A132357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132357Inst : IEnumerable<long>
{
public static readonly long[] Value=A132357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132357.Bytes);
public long this[int i]=>Value[i];

public static A132357Inst Instance=new A132357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132358
{
public static readonly BigInteger[] Value={ 2L,3L,13L,251L,65521L,4294967291L,18446744073709551557UL,BigInteger.Parse("340282366920938463463374607431768211297"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639747") };
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
public class A132358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132358Inst Instance=new A132358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132359
{
public static readonly long[] Value={ 1L,11L,12L,21L,25L,31L,32L,36L,41L,51L,52L,61L,63L,64L,71L,72L,75L,81L,91L,92L,101L,111L,112L,121L,125L,128L,131L,132L,141L,144L,147L,151L,152L,153L,161L,171L,172L,175L,181L,191L,192L,201L,211L,212L,216L,221L,224L,225L,231L,232L,241L,243L,251L,252L,261L,271L,272L };
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
public class A132359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132359Inst : IEnumerable<long>
{
public static readonly long[] Value=A132359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132359.Bytes);
public long this[int i]=>Value[i];

public static A132359Inst Instance=new A132359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132664
{
public static readonly long[] Value={ 1L,2L,5L,4L,3L,9L,8L,7L,6L,16L,15L,14L,13L,12L,11L,10L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L };
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
public class A132664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132664Inst : IEnumerable<long>
{
public static readonly long[] Value=A132664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132664.Bytes);
public long this[int i]=>Value[i];

public static A132664Inst Instance=new A132664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132665
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,11L,10L,9L,8L,7L,19L,18L,17L,16L,15L,14L,13L,12L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,87L,86L,85L,84L,83L,82L,81L,80L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L };
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
public class A132665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132665Inst : IEnumerable<long>
{
public static readonly long[] Value=A132665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132665.Bytes);
public long this[int i]=>Value[i];

public static A132665Inst Instance=new A132665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132666
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,10L,9L,8L,7L,14L,13L,12L,11L,22L,21L,20L,19L,18L,17L,16L,15L,30L,29L,28L,27L,26L,25L,24L,23L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,94L,93L,92L,91L,90L,89L,88L,87L,86L,85L };
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
public class A132666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132666Inst : IEnumerable<long>
{
public static readonly long[] Value=A132666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132666.Bytes);
public long this[int i]=>Value[i];

public static A132666Inst Instance=new A132666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132667
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,12L,11L,10L,9L,8L,7L,21L,20L,19L,18L,17L,16L,15L,14L,13L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,120L,119L,118L,117L,116L };
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
public class A132667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132667Inst : IEnumerable<long>
{
public static readonly long[] Value=A132667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132667.Bytes);
public long this[int i]=>Value[i];

public static A132667Inst Instance=new A132667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132668
{
public static readonly long[] Value={ 1L,4L,3L,2L,8L,7L,6L,5L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,84L,83L,82L,81L,80L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L };
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
public class A132668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132668Inst : IEnumerable<long>
{
public static readonly long[] Value=A132668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132668.Bytes);
public long this[int i]=>Value[i];

public static A132668Inst Instance=new A132668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132669
{
public static readonly long[] Value={ 1L,5L,4L,3L,2L,10L,9L,8L,7L,6L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,155L,154L,153L,152L,151L,150L,149L,148L,147L,146L,145L,144L,143L };
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
public class A132669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132669Inst : IEnumerable<long>
{
public static readonly long[] Value=A132669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132669.Bytes);
public long this[int i]=>Value[i];

public static A132669Inst Instance=new A132669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132670
{
public static readonly long[] Value={ 1L,6L,5L,4L,3L,2L,12L,11L,10L,9L,8L,7L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L };
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
public class A132670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132670Inst : IEnumerable<long>
{
public static readonly long[] Value=A132670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132670.Bytes);
public long this[int i]=>Value[i];

public static A132670Inst Instance=new A132670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132671
{
public static readonly long[] Value={ 1L,7L,6L,5L,4L,3L,2L,14L,13L,12L,11L,10L,9L,8L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,105L,104L,103L,102L,101L,100L,99L,98L,97L,96L,95L,94L,93L,92L };
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
public class A132671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132671Inst : IEnumerable<long>
{
public static readonly long[] Value=A132671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132671.Bytes);
public long this[int i]=>Value[i];

public static A132671Inst Instance=new A132671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132672
{
public static readonly long[] Value={ 1L,8L,7L,6L,5L,4L,3L,2L,16L,15L,14L,13L,12L,11L,10L,9L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L };
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
public class A132672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132672Inst : IEnumerable<long>
{
public static readonly long[] Value=A132672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132672.Bytes);
public long this[int i]=>Value[i];

public static A132672Inst Instance=new A132672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132673
{
public static readonly long[] Value={ 1L,9L,8L,7L,6L,5L,4L,3L,2L,18L,17L,16L,15L,14L,13L,12L,11L,10L,90L,89L,88L,87L,86L,85L,84L,83L,82L,81L,80L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L };
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
public class A132673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132673Inst : IEnumerable<long>
{
public static readonly long[] Value=A132673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132673.Bytes);
public long this[int i]=>Value[i];

public static A132673Inst Instance=new A132673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132674
{
public static readonly long[] Value={ 1L,10L,9L,8L,7L,6L,5L,4L,3L,2L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,110L,109L,108L,107L,106L,105L,104L,103L,102L,101L,100L,99L,98L,97L,96L,95L,94L,93L,92L,91L,90L,89L,88L,87L,86L,85L,84L,83L,82L,81L,80L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L };
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
public class A132674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132674Inst : IEnumerable<long>
{
public static readonly long[] Value=A132674.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132674.Bytes);
public long this[int i]=>Value[i];

public static A132674Inst Instance=new A132674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132675
{
public static readonly long[] Value={ 10L,2746L,703178L,44013L,11325150L,181202413L,2766L,44269L,173L,2781L,712173L,2986L,47789L,47806L,2989L,47838L,47871L,12255213L,190L,48813L,12496365L,3053L,12508653L,3054L,48879L,12513261L,3243L,3245L,51934L,51966L,52958L,847341L,3310L };
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
public class A132675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132675Inst : IEnumerable<long>
{
public static readonly long[] Value=A132675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132675.Bytes);
public long this[int i]=>Value[i];

public static A132675Inst Instance=new A132675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132676
{
public static readonly long[] Value={ 10L,173L,190L,250L,2746L,2766L,2781L,2986L,2989L,3053L,3054L,3243L,3245L,3310L,3499L,3501L,3566L,3771L,4013L,4077L,4078L,44013L,44269L,47789L,47806L,47838L,47871L,48813L,48879L,51934L,51966L,52958L,56014L,56063L,57005L,57007L,57069L,64206L };
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
public class A132676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132676Inst : IEnumerable<long>
{
public static readonly long[] Value=A132676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132676.Bytes);
public long this[int i]=>Value[i];

public static A132676Inst Instance=new A132676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132677
{
public static readonly long[] Value={ 1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L,1L,2L,-3L };
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
public class A132677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132677Inst : IEnumerable<long>
{
public static readonly long[] Value=A132677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132677.Bytes);
public long this[int i]=>Value[i];

public static A132677Inst Instance=new A132677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132678
{
public static readonly long[] Value={ 0L,1L,3L,4L,56L,67L,670L,7740L,41842L,47345L,89440L,93196L,189277L,247372L,321327L,474346L,826237L,1988987L,2364721L,2886736L,2937246L,5426145L,12969551L,34658342L,109686031L,373121462L,681070488L,1000410504L,4064275165L };
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
public class A132678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132678Inst : IEnumerable<long>
{
public static readonly long[] Value=A132678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132678.Bytes);
public long this[int i]=>Value[i];

public static A132678Inst Instance=new A132678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132679
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,16L,19L,28L,31L,32L,35L,44L,47L,64L,67L,76L,79L,112L,115L,124L,127L,128L,131L,140L,143L,176L,179L,188L,191L,256L,259L,268L,271L,304L,307L,316L,319L,448L,451L,460L,463L,496L,499L,508L,511L,512L,515L,524L,527L,560L,563L,572L,575L,704L,707L,716L };
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
public class A132679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132679Inst : IEnumerable<long>
{
public static readonly long[] Value=A132679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132679.Bytes);
public long this[int i]=>Value[i];

public static A132679Inst Instance=new A132679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132760
{
public static readonly long[] Value={ 0L,16L,34L,54L,76L,100L,126L,154L,184L,216L,250L,286L,324L,364L,406L,450L,496L,544L,594L,646L,700L,756L,814L,874L,936L,1000L,1066L,1134L,1204L,1276L,1350L,1426L,1504L,1584L,1666L,1750L,1836L,1924L,2014L,2106L,2200L,2296L,2394L,2494L };
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
public class A132760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132760Inst : IEnumerable<long>
{
public static readonly long[] Value=A132760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132760.Bytes);
public long this[int i]=>Value[i];

public static A132760Inst Instance=new A132760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132761
{
public static readonly long[] Value={ 0L,18L,38L,60L,84L,110L,138L,168L,200L,234L,270L,308L,348L,390L,434L,480L,528L,578L,630L,684L,740L,798L,858L,920L,984L,1050L,1118L,1188L,1260L,1334L,1410L,1488L,1568L,1650L,1734L,1820L,1908L,1998L,2090L,2184L,2280L,2378L,2478L,2580L };
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
public class A132761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132761Inst : IEnumerable<long>
{
public static readonly long[] Value=A132761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132761.Bytes);
public long this[int i]=>Value[i];

public static A132761Inst Instance=new A132761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132762
{
public static readonly long[] Value={ 0L,20L,42L,66L,92L,120L,150L,182L,216L,252L,290L,330L,372L,416L,462L,510L,560L,612L,666L,722L,780L,840L,902L,966L,1032L,1100L,1170L,1242L,1316L,1392L,1470L,1550L,1632L,1716L,1802L,1890L,1980L,2072L,2166L,2262L,2360L,2460L,2562L,2666L };
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
public class A132762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132762Inst : IEnumerable<long>
{
public static readonly long[] Value=A132762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132762.Bytes);
public long this[int i]=>Value[i];

public static A132762Inst Instance=new A132762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132763
{
public static readonly long[] Value={ 0L,22L,46L,72L,100L,130L,162L,196L,232L,270L,310L,352L,396L,442L,490L,540L,592L,646L,702L,760L,820L,882L,946L,1012L,1080L,1150L,1222L,1296L,1372L,1450L,1530L,1612L,1696L,1782L,1870L,1960L,2052L,2146L,2242L,2340L,2440L,2542L,2646L,2752L };
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
public class A132763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132763Inst : IEnumerable<long>
{
public static readonly long[] Value=A132763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132763.Bytes);
public long this[int i]=>Value[i];

public static A132763Inst Instance=new A132763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132764
{
public static readonly long[] Value={ 0L,23L,48L,75L,104L,135L,168L,203L,240L,279L,320L,363L,408L,455L,504L,555L,608L,663L,720L,779L,840L,903L,968L,1035L,1104L,1175L,1248L,1323L,1400L,1479L,1560L,1643L,1728L,1815L,1904L,1995L,2088L,2183L,2280L,2379L,2480L,2583L,2688L,2795L };
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
public class A132764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132764Inst : IEnumerable<long>
{
public static readonly long[] Value=A132764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132764.Bytes);
public long this[int i]=>Value[i];

public static A132764Inst Instance=new A132764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132765
{
public static readonly long[] Value={ 0L,24L,50L,78L,108L,140L,174L,210L,248L,288L,330L,374L,420L,468L,518L,570L,624L,680L,738L,798L,860L,924L,990L,1058L,1128L,1200L,1274L,1350L,1428L,1508L,1590L,1674L,1760L,1848L,1938L,2030L,2124L,2220L,2318L,2418L,2520L,2624L,2730L,2838L };
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
public class A132765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132765Inst : IEnumerable<long>
{
public static readonly long[] Value=A132765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132765.Bytes);
public long this[int i]=>Value[i];

public static A132765Inst Instance=new A132765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132766
{
public static readonly long[] Value={ 0L,25L,52L,81L,112L,145L,180L,217L,256L,297L,340L,385L,432L,481L,532L,585L,640L,697L,756L,817L,880L,945L,1012L,1081L,1152L,1225L,1300L,1377L,1456L,1537L,1620L,1705L,1792L,1881L,1972L,2065L,2160L,2257L,2356L,2457L,2560L,2665L,2772L,2881L };
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
public class A132766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132766Inst : IEnumerable<long>
{
public static readonly long[] Value=A132766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132766.Bytes);
public long this[int i]=>Value[i];

public static A132766Inst Instance=new A132766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132767
{
public static readonly long[] Value={ 0L,26L,54L,84L,116L,150L,186L,224L,264L,306L,350L,396L,444L,494L,546L,600L,656L,714L,774L,836L,900L,966L,1034L,1104L,1176L,1250L,1326L,1404L,1484L,1566L,1650L,1736L,1824L,1914L,2006L,2100L,2196L,2294L,2394L,2496L,2600L,2706L,2814L,2924L };
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
public class A132767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132767Inst : IEnumerable<long>
{
public static readonly long[] Value=A132767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132767.Bytes);
public long this[int i]=>Value[i];

public static A132767Inst Instance=new A132767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132768
{
public static readonly long[] Value={ 0L,27L,56L,87L,120L,155L,192L,231L,272L,315L,360L,407L,456L,507L,560L,615L,672L,731L,792L,855L,920L,987L,1056L,1127L,1200L,1275L,1352L,1431L,1512L,1595L,1680L,1767L,1856L,1947L,2040L,2135L,2232L,2331L,2432L,2535L,2640L,2747L,2856L,2967L };
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
public class A132768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132768Inst : IEnumerable<long>
{
public static readonly long[] Value=A132768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132768.Bytes);
public long this[int i]=>Value[i];

public static A132768Inst Instance=new A132768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132769
{
public static readonly long[] Value={ 0L,28L,58L,90L,124L,160L,198L,238L,280L,324L,370L,418L,468L,520L,574L,630L,688L,748L,810L,874L,940L,1008L,1078L,1150L,1224L,1300L,1378L,1458L,1540L,1624L,1710L,1798L,1888L,1980L,2074L,2170L,2268L,2368L,2470L,2574L,2680L,2788L,2898L,3010L };
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
public class A132769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132769Inst : IEnumerable<long>
{
public static readonly long[] Value=A132769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132769.Bytes);
public long this[int i]=>Value[i];

public static A132769Inst Instance=new A132769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132770
{
public static readonly long[] Value={ 0L,29L,60L,93L,128L,165L,204L,245L,288L,333L,380L,429L,480L,533L,588L,645L,704L,765L,828L,893L,960L,1029L,1100L,1173L,1248L,1325L,1404L,1485L,1568L,1653L,1740L,1829L,1920L,2013L,2108L,2205L,2304L,2405L,2508L,2613L,2720L,2829L,2940L,3053L };
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
public class A132770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132770Inst : IEnumerable<long>
{
public static readonly long[] Value=A132770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132770.Bytes);
public long this[int i]=>Value[i];

public static A132770Inst Instance=new A132770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132771
{
public static readonly long[] Value={ 0L,30L,62L,96L,132L,170L,210L,252L,296L,342L,390L,440L,492L,546L,602L,660L,720L,782L,846L,912L,980L,1050L,1122L,1196L,1272L,1350L,1430L,1512L,1596L,1682L,1770L,1860L,1952L,2046L,2142L,2240L,2340L,2442L,2546L,2652L,2760L,2870L,2982L,3096L };
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
public class A132771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132771Inst : IEnumerable<long>
{
public static readonly long[] Value=A132771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132771.Bytes);
public long this[int i]=>Value[i];

public static A132771Inst Instance=new A132771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132772
{
public static readonly long[] Value={ 0L,31L,64L,99L,136L,175L,216L,259L,304L,351L,400L,451L,504L,559L,616L,675L,736L,799L,864L,931L,1000L,1071L,1144L,1219L,1296L,1375L,1456L,1539L,1624L,1711L,1800L,1891L,1984L,2079L,2176L,2275L,2376L,2479L,2584L,2691L,2800L,2911L,3024L };
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
public class A132772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132772Inst : IEnumerable<long>
{
public static readonly long[] Value=A132772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132772.Bytes);
public long this[int i]=>Value[i];

public static A132772Inst Instance=new A132772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132773
{
public static readonly long[] Value={ 0L,32L,66L,102L,140L,180L,222L,266L,312L,360L,410L,462L,516L,572L,630L,690L,752L,816L,882L,950L,1020L,1092L,1166L,1242L,1320L,1400L,1482L,1566L,1652L,1740L,1830L,1922L,2016L,2112L,2210L,2310L,2412L,2516L,2622L,2730L,2840L,2952L,3066L };
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
public class A132773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132773Inst : IEnumerable<long>
{
public static readonly long[] Value=A132773.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132773.Bytes);
public long this[int i]=>Value[i];

public static A132773Inst Instance=new A132773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132774
{
public static readonly long[] Value={ 1L,2L,3L,0L,4L,5L,0L,0L,6L,7L,0L,0L,0L,8L,9L,0L,0L,0L,0L,10L,11L,0L,0L,0L,0L,0L,12L,13L,0L,0L,0L,0L,0L,0L,14L,15L };
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
public class A132774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132774Inst : IEnumerable<long>
{
public static readonly long[] Value=A132774.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132774.Bytes);
public long this[int i]=>Value[i];

public static A132774Inst Instance=new A132774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132775
{
public static readonly long[] Value={ 1L,3L,3L,5L,10L,5L,7L,21L,21L,7L,9L,36L,54L,36L,9L,11L,55L,110L,110L,55L,11L,13L,78L,195L,260L,195L,78L,13L,15L,105L,315L,525L,525L,315L,105L,15L,17L,136L,476L,952L,1190L,952L,476L,136L,17L,19L,171L,684L,1596L,2394L,2394L,1596L,684L,171L,19L };
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
public class A132775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132775Inst : IEnumerable<long>
{
public static readonly long[] Value=A132775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132775.Bytes);
public long this[int i]=>Value[i];

public static A132775Inst Instance=new A132775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132904
{
public static readonly long[] Value={ 2357L,35711L,571113L,7111317L,11131719L,13171923L,17192329L,19232931L,23293137L,29313741L,31374143L,37414347L,41434753L,43475359L,47535961L,53596167L,59616771L,61677173L,67717379L,71737983L,73798389L,79838997L,838997101L };
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
public class A132904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132904Inst : IEnumerable<long>
{
public static readonly long[] Value=A132904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132904.Bytes);
public long this[int i]=>Value[i];

public static A132904Inst Instance=new A132904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132905
{
public static readonly long[] Value={ 235711L,3571113L,57111317L,711131719L,1113171923L,1317192329L,1719232931L,1923293137L,2329313741L,2931374143L,3137414347L,3741434753L,4143475359L,4347535961L,4753596167L,5359616771L,5961677173L,6167717379L,6771737983L };
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
public class A132905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132905Inst : IEnumerable<long>
{
public static readonly long[] Value=A132905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132905.Bytes);
public long this[int i]=>Value[i];

public static A132905Inst Instance=new A132905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132906
{
public static readonly long[] Value={ 23571113L,357111317L,5711131719L,71113171923L,111317192329L,131719232931L,171923293137L,192329313741L,232931374143L,293137414347L,313741434753L,374143475359L,414347535961L,434753596167L,475359616771L,535961677173L };
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
public class A132906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132906Inst : IEnumerable<long>
{
public static readonly long[] Value=A132906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132906.Bytes);
public long this[int i]=>Value[i];

public static A132906Inst Instance=new A132906Inst();

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