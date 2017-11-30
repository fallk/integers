using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A112541
{
public static readonly BigInteger[] Value={ 1L,2L,8L,48L,400L,4390L,60624L,1013404L,19881728L,447085170L,11319529600L,318298578664L,9834869311488L,331059072378814L,12055438037135360L,472096504892128500L,BigInteger.Parse("19781301201305534464"),BigInteger.Parse("882991510898240350666") };
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
public class A112541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112541Inst Instance=new A112541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112542
{
public static readonly long[] Value={ 312L,312L,104L,312L,312L,104L,312L,312L,1L };
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
public class A112542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112542Inst : IEnumerable<long>
{
public static readonly long[] Value=A112542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112542.Bytes);
public long this[int i]=>Value[i];

public static A112542Inst Instance=new A112542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112543
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,4L,3L,2L,1L,5L,2L,1L,1L,1L,6L,5L,4L,3L,2L,1L,7L,3L,5L,1L,3L,1L,1L,8L,7L,2L,5L,4L,1L,2L,1L,9L,4L,7L,3L,1L,2L,3L,1L,1L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,11L,5L,3L,2L,7L,1L,5L,1L,1L,1L,1L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,13L,6L,11L,5L,9L,4L,1L,3L,5L,2L,3L,1L,1L,14L,13L,4L,11L,2L,3L,8L,7L,2L };
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
public class A112543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112543Inst : IEnumerable<long>
{
public static readonly long[] Value=A112543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112543.Bytes);
public long this[int i]=>Value[i];

public static A112543Inst Instance=new A112543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112544
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,2L,3L,4L,1L,1L,1L,2L,5L,1L,2L,3L,4L,5L,6L,1L,1L,3L,1L,5L,3L,7L,1L,2L,1L,4L,5L,2L,7L,8L,1L,1L,3L,2L,1L,3L,7L,4L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,1L,1L,1L,5L,1L,7L,2L,3L,5L,11L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,1L,1L,3L,2L,5L,3L,1L,4L,9L,5L,11L,6L,13L,1L,2L,1L,4L,1L,2L,7L,8L,3L };
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
public class A112544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112544Inst : IEnumerable<long>
{
public static readonly long[] Value=A112544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112544.Bytes);
public long this[int i]=>Value[i];

public static A112544Inst Instance=new A112544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112545
{
public static readonly long[] Value={ 7L,5L,2L,5L,7L,2L,5L,3L,3L,3L,3L,5L,11L,3L,53L,3L,3L,3L,5L,3L,3L,3L,3L,5L,5L,13L,53L,5L,59L,61L,3L,3L,11L,5L,3L,157L,3L,3L,173L,3L,5L,11L,97L,7L,3L,211L,3L,113L,5L,3L,3L,5L,3L,257L,263L,3L,3L,3L,5L,7L,5L,151L,5L,157L,7L,3L,3L,7L,5L,3L,3L,3L,373L,3L,3L,3L,5L,13L,5L,5L,5L,7L,3L,3L,3L,3L,5L,5L,29L,3L,3L };
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
public class A112545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112545Inst : IEnumerable<long>
{
public static readonly long[] Value=A112545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112545.Bytes);
public long this[int i]=>Value[i];

public static A112545Inst Instance=new A112545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112546
{
public static readonly long[] Value={ 1L,8L,4L,50L,171L,14L,461L,78L,12203L,312L,318880L,2184L,57725L,5804L,1401L,9722L,4678L,3457L,748L,2255L,33936L,17379L,228810L,191744L,418737L,477214L,210178L,208280L,827058L,1419710L,2100776L,1328500L };
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
public class A112546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112546Inst : IEnumerable<long>
{
public static readonly long[] Value=A112546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112546.Bytes);
public long this[int i]=>Value[i];

public static A112546Inst Instance=new A112546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112547
{
public static readonly long[] Value={ 1L,8L,10L,50L,171L,39L,461L,78L,12203L,312L,318880L,2184L,57725L,5804L,1401L,3251L };
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
public class A112547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112547Inst : IEnumerable<long>
{
public static readonly long[] Value=A112547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112547.Bytes);
public long this[int i]=>Value[i];

public static A112547Inst Instance=new A112547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112548
{
public static readonly long[] Value={ 12L,16L,18L,26L,34L,36L,38L,42L,74L,114L,118L,396L,674L,1870L,4306L,22808L };
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
public class A112548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112548Inst : IEnumerable<long>
{
public static readonly long[] Value=A112548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112548.Bytes);
public long this[int i]=>Value[i];

public static A112548Inst Instance=new A112548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112549
{
public static readonly long[] Value={ 1L,8L,10L,12L,171L,13L,461L,26L,12203L,104L,318880L,728L,57725L,5804L,6698L,9722L };
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
public class A112549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112549Inst : IEnumerable<long>
{
public static readonly long[] Value=A112549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112549.Bytes);
public long this[int i]=>Value[i];

public static A112549Inst Instance=new A112549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112550
{
public static readonly BigInteger[] Value={ 41L,282407L,99054112352057L,BigInteger.Parse("29847243642863658530046303259457"),BigInteger.Parse("438302112913620818033722039251417607232953642602702120391887945707") };
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
public class A112550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112550Inst Instance=new A112550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112551
{
public static readonly long[] Value={ 168L,1242L,3042L,492L,30012L,171480L,2299722L,5052450L };
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
public class A112551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112551Inst : IEnumerable<long>
{
public static readonly long[] Value=A112551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112551.Bytes);
public long this[int i]=>Value[i];

public static A112551Inst Instance=new A112551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112552
{
public static readonly long[] Value={ 1L,0L,1L,-2L,0L,1L,0L,-3L,0L,1L,3L,0L,-4L,0L,1L,0L,6L,0L,-5L,0L,1L,-4L,0L,10L,0L,-6L,0L,1L,0L,-10L,0L,15L,0L,-7L,0L,1L,5L,0L,-20L,0L,21L,0L,-8L,0L,1L,0L,15L,0L,-35L,0L,28L,0L,-9L,0L,1L,-6L,0L,35L,0L,-56L,0L,36L,0L,-10L,0L,1L,0L,-21L,0L,70L,0L,-84L,0L,45L,0L,-11L,0L,1L,7L,0L,-56L,0L,126L,0L,-120L,0L,55L,0L,-12L,0L,1L };
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
public class A112552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112552Inst : IEnumerable<long>
{
public static readonly long[] Value=A112552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112552.Bytes);
public long this[int i]=>Value[i];

public static A112552Inst Instance=new A112552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112553
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,0L,2L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-2L,0L,2L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-2L,0L,2L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-2L,0L,2L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-2L,0L,2L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-2L,0L,2L,1L,-1L,-1L,0L,0L,0L };
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
public class A112553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112553Inst : IEnumerable<long>
{
public static readonly long[] Value=A112553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112553.Bytes);
public long this[int i]=>Value[i];

public static A112553Inst Instance=new A112553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112554
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,3L,0L,1L,5L,0L,4L,0L,1L,0L,9L,0L,5L,0L,1L,14L,0L,14L,0L,6L,0L,1L,0L,28L,0L,20L,0L,7L,0L,1L,42L,0L,48L,0L,27L,0L,8L,0L,1L,0L,90L,0L,75L,0L,35L,0L,9L,0L,1L,132L,0L,165L,0L,110L,0L,44L,0L,10L,0L,1L,0L,297L,0L,275L,0L,154L,0L,54L,0L,11L,0L,1L,429L,0L,572L,0L,429L,0L,208L,0L,65L,0L };
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
public class A112554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112554Inst : IEnumerable<long>
{
public static readonly long[] Value=A112554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112554.Bytes);
public long this[int i]=>Value[i];

public static A112554Inst Instance=new A112554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112555
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,1L,1L,1L,1L,-1L,-2L,-2L,0L,1L,1L,3L,4L,2L,1L,1L,-1L,-4L,-7L,-6L,-3L,0L,1L,1L,5L,11L,13L,9L,3L,1L,1L,-1L,-6L,-16L,-24L,-22L,-12L,-4L,0L,1L,1L,7L,22L,40L,46L,34L,16L,4L,1L,1L,-1L,-8L,-29L,-62L,-86L,-80L,-50L,-20L,-5L,0L,1L,1L,9L,37L,91L,148L,166L,130L,70L,25L,5L,1L,1L,-1L,-10L,-46L,-128L,-239L,-314L,-296L,-200L,-95L,-30L,-6L,0L };
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
public class A112555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112555Inst : IEnumerable<long>
{
public static readonly long[] Value=A112555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112555.Bytes);
public long this[int i]=>Value[i];

public static A112555Inst Instance=new A112555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112556
{
public static readonly long[] Value={ 1L,2L,2L,4L,10L,32L,112L,408L,1514L,5680L,21472L,81644L,311896L,1196132L,4602236L,17757184L,68680170L,266200112L,1033703056L,4020716124L,15662273840L,61092127492L,238582873476L,932758045124L,3650336341240L,14298633670932L,56055986383412L,219931273282348L,863504076182884L,3392593262288780L,13337336618626132L };
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
public class A112556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112556Inst : IEnumerable<long>
{
public static readonly long[] Value=A112556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112556.Bytes);
public long this[int i]=>Value[i];

public static A112556Inst Instance=new A112556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112557
{
public static readonly long[] Value={ 1L,4L,10L,18L,30L,42L,58L,78L,102L,118L,150L,174L,210L,240L,274L,322L,360L,402L,442L,498L,540L,612L,648L,718L,780L,840L,918L,990L,1054L,1122L,1200L,1278L,1392L,1428L,1548L,1632L,1714L,1834L,1882L,2040L,2118L,2242L,2314L,2434L,2580L,2662L,2760L,2922L,3054L };
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
public class A112557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112557Inst : IEnumerable<long>
{
public static readonly long[] Value=A112557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112557.Bytes);
public long this[int i]=>Value[i];

public static A112557Inst Instance=new A112557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112558
{
public static readonly long[] Value={ 1L,5L,13L,25L,39L,61L,79L,103L,133L,169L,207L,241L,289L,331L,387L,447L,481L,553L,613L,687L,763L,819L,927L,979L,1093L,1179L,1261L,1347L,1471L,1539L,1693L,1759L,1899L,2019L,2161L,2263L,2367L,2527L,2703L,2779L,2967L,3073L,3199L,3373L,3529L,3691L,3841L,3987L,4203L };
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
public class A112558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112558Inst : IEnumerable<long>
{
public static readonly long[] Value=A112558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112558.Bytes);
public long this[int i]=>Value[i];

public static A112558Inst Instance=new A112558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112559
{
public static readonly long[] Value={ 3L,9L,18L,24L,48L,69L,93L,102L,108L,144L,168L,177L,213L,249L,258L,273L,282L,324L,357L,363L,387L,399L,438L,444L,504L,507L,573L,609L,669L,678L,738L,759L,762L,777L,807L,864L,867L,909L,942L,948L,963L,1014L,1068L,1074L,1182L,1197L,1248L,1299L,1389L,1392L,1413L,1488L };
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
public class A112559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112559Inst : IEnumerable<long>
{
public static readonly long[] Value=A112559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112559.Bytes);
public long this[int i]=>Value[i];

public static A112559Inst Instance=new A112559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112560
{
public static readonly long[] Value={ 1L,4L,13L,28L,61L,88L,133L,208L,313L,364L,541L,724L,853L,1048L,1261L,1564L,1993L,2104L,2581L,3028L,3553L,3904L,4621L,5368L,5893L,6544L,7141L,8104L,9373L,9904L,11113L,12088L,13333L,14428L,15433L,17368L,19021L,20188L,21733L,23944L,25261L,27304L };
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
public class A112560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112560Inst : IEnumerable<long>
{
public static readonly long[] Value=A112560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112560.Bytes);
public long this[int i]=>Value[i];

public static A112560Inst Instance=new A112560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112561
{
public static readonly long[] Value={ 1L,5L,21L,61L,125L,261L,421L,605L,1101L,1681L,2525L,2781L,4201L,5645L,6741L,9541L,11765L,13701L,17641L,21305L,27981L,29401L,37265L,43521L,51541L,59945L,65781L,78121L,89345L,99981L,121381L,124445L,144321L,173041L,189965L,212361L,229381L };
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
public class A112561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112561Inst : IEnumerable<long>
{
public static readonly long[] Value=A112561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112561.Bytes);
public long this[int i]=>Value[i];

public static A112561Inst Instance=new A112561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112562
{
public static readonly long[] Value={ 1L,6L,31L,96L,241L,546L,1171L,1776L,2761L,5046L,7591L,11856L,19021L,20706L,31711L,44016L,60481L,71946L,92191L,120216L,138601L,181986L,226831L,302496L,379381L,400686L,487831L,574656L,704461L,831606L,1029631L,1092936L,1333321L,1462146L };
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
public class A112562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112562Inst : IEnumerable<long>
{
public static readonly long[] Value=A112562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112562.Bytes);
public long this[int i]=>Value[i];

public static A112562Inst Instance=new A112562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112563
{
public static readonly long[] Value={ 1L,7L,43L,169L,505L,1051L,2527L,5083L,7729L,11635L,22681L,33937L,55483L,90889L,132595L,152251L,238057L,327643L,451249L,543355L,776161L,997927L,1258993L,1441609L,1924315L,2397571L,3221737L,4036033L,4900399L,5438665L,6691651L };
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
public class A112563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112563Inst : IEnumerable<long>
{
public static readonly long[] Value=A112563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112563.Bytes);
public long this[int i]=>Value[i];

public static A112563Inst Instance=new A112563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112564
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,7L,6L,1L,1L,5L,13L,13L,10L,1L,1L,6L,21L,28L,19L,12L,1L,1L,7L,31L,61L,61L,27L,18L,1L,1L,8L,43L,96L,125L,88L,39L,22L,1L,1L,9L,57L,169L,241L,261L,133L,49L,30L,1L,1L,10L,73L,232L,505L,546L,421L,208L,63L,34L,1L,1L,11L,91L,361L,785L,1051L,1171L,605L,313L };
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
public class A112564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112564Inst : IEnumerable<long>
{
public static readonly long[] Value=A112564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112564.Bytes);
public long this[int i]=>Value[i];

public static A112564Inst Instance=new A112564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112565
{
public static readonly long[] Value={ 1L,2L,7L,28L,125L,546L,2527L,11096L,43633L,186130L,809831L,3423432L,14022373L,58574894L,250708291L,1038612976L,4353755777L,18333324162L,74663736859L,311293807040L,1286700247561L,4917768055222L,20458840039199L,83985256000824L };
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
public class A112565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112565Inst : IEnumerable<long>
{
public static readonly long[] Value=A112565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112565.Bytes);
public long this[int i]=>Value[i];

public static A112565Inst Instance=new A112565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112566
{
public static readonly long[] Value={ 1L,3L,9L,31L,109L,421L,1585L,5454L,20681L,80983L,311221L,1168531L,4505761L,17907735L,69240865L,272109736L,1078430833L,4147985381L,16383884581L,64335012378L,234179431201L,929947274509L,3651532869601L,14453209093051L,56596999501225L };
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
public class A112566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112566Inst : IEnumerable<long>
{
public static readonly long[] Value=A112566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112566.Bytes);
public long this[int i]=>Value[i];

public static A112566Inst Instance=new A112566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112567
{
public static readonly long[] Value={ 1L,1L,3L,11L,47L,193L,869L,3583L,12399L,51287L,217551L,867797L,3274727L,13099145L,55568089L,216651145L,878354151L,3609915051L,13596245715L,55617915013L,220140920491L,676614665133L,2955537029341L,11835711831601L,48642769948139L };
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
public class A112567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112567Inst : IEnumerable<long>
{
public static readonly long[] Value=A112567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112567.Bytes);
public long this[int i]=>Value[i];

public static A112567Inst Instance=new A112567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112568
{
public static readonly long[] Value={ 1L,3L,13L,61L,241L,1051L,5041L,20161L,91081L,392041L,1681681L,6530173L,27168961L,115590931L };
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
public class A112568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112568Inst : IEnumerable<long>
{
public static readonly long[] Value=A112568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112568.Bytes);
public long this[int i]=>Value[i];

public static A112568Inst Instance=new A112568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112569
{
public static readonly long[] Value={ 1L,2L,4L,9L,19L,43L,88L,207L,423L,951L,2094L,4511L,9445L,22025L,45172L,93483L,205101L,435515L,882322L,1983637L,3983429L,8659805L,17928712L,36742421L,76317521L,163095069L,331056988L,693360803L,1444266731L };
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
public class A112569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112569Inst : IEnumerable<long>
{
public static readonly long[] Value=A112569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112569.Bytes);
public long this[int i]=>Value[i];

public static A112569Inst Instance=new A112569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112570
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,2L,0L,1L,-2L,5L,-5L,4L,-6L,18L,-30L,35L,-43L,84L,-167L,261L,-352L,545L,-1010L,1790L,-2783L,4207L,-7025L,12464L,-21071L,33567L,-54154L,92317L,-159366L,266150L,-435285L,725260L,-1239404L,2112351L,-3535532L,5894852L,-9964767L,17008752L,-28880694L,48645873L };
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
public class A112570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112570Inst : IEnumerable<long>
{
public static readonly long[] Value=A112570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112570.Bytes);
public long this[int i]=>Value[i];

public static A112570Inst Instance=new A112570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112571
{
public static readonly long[] Value={ 1L,1L,3L,-1L,-2L,6L,0L,-16L,23L,40L,-140L,13L,591L,-827L,-1577L,5887L,-500L,-27095L,38922L,77859L,-295183L,21310L,1428714L,-2069421L,-4295099L,16345171L,-921876L,-81760620L,118435457L,253839799L,-963510264L,37372170L,4936868645L,-7119213992L,-15717478733L,59293735690L };
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
public class A112571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112571Inst : IEnumerable<long>
{
public static readonly long[] Value=A112571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112571.Bytes);
public long this[int i]=>Value[i];

public static A112571Inst Instance=new A112571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112572
{
public static readonly long[] Value={ 1L,1L,-1L,3L,-6L,18L,-52L,156L,-481L,1512L,-4828L,15621L,-51081L,168537L,-560309L,1874975L,-6309964L,21341241L,-72497698L,247247463L,-846187023L,2905210526L,-10003144986L,34532780087L,-119499263663L,414431066955L,-1440182574644L,5014115406096L };
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
public class A112572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112572Inst : IEnumerable<long>
{
public static readonly long[] Value=A112572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112572.Bytes);
public long this[int i]=>Value[i];

public static A112572Inst Instance=new A112572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112573
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,-2L,5L,-6L,5L,3L,-26L,70L,-141L,221L,-229L,-18L,891L,-2914L,6524L,-11238L,13690L,-4214L,-37619L,145018L,-353534L,657080L,-895234L,534007L,1654246L,-7840402L,20737566L,-41200153L,61402057L,-50500722L,-68352913L,441195837L,-1272153666L,2690651374L };
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
public class A112573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112573Inst : IEnumerable<long>
{
public static readonly long[] Value=A112573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112573.Bytes);
public long this[int i]=>Value[i];

public static A112573Inst Instance=new A112573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112574
{
public static readonly long[] Value={ 1L,3L,0L,2L,0L,3L,-8L,30L,-90L,290L,-930L,3000L,-9696L,31461L,-102420L,334467L,-1095510L,3598464L,-11852026L,39136629L,-129548493L,429817733L,-1429178703L,4761992751L,-15898024868L,53174651133L,-178168302693L,597971203902L,-2010093276240L,6767100270918L };
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
public class A112574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112574Inst : IEnumerable<long>
{
public static readonly long[] Value=A112574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112574.Bytes);
public long this[int i]=>Value[i];

public static A112574Inst Instance=new A112574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112575
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,12L,22L,41L,78L,147L,276L,520L,980L,1845L,3474L,6543L,12322L,23204L,43698L,82293L,154974L,291847L,549608L,1035024L,1949160L,3670665L,6912610L,13017851L,24515262L,46167228L,86942286L,163730017L,308336942L,580661211L,1093503228L };
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
public class A112575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112575Inst : IEnumerable<long>
{
public static readonly long[] Value=A112575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112575.Bytes);
public long this[int i]=>Value[i];

public static A112575Inst Instance=new A112575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112576
{
public static readonly long[] Value={ 0L,1L,1L,4L,6L,16L,29L,67L,132L,288L,588L,1253L,2597L,5480L,11430L,24020L,50233L,105383L,220632L,462528L,968808L,2030377L,4253641L,8913436L,18675174L,39131464L,81989909L,171795691L,359958780L,754224480L,1580315220L,3311234189L };
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
public class A112576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112576Inst : IEnumerable<long>
{
public static readonly long[] Value=A112576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112576.Bytes);
public long this[int i]=>Value[i];

public static A112576Inst Instance=new A112576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112577
{
public static readonly long[] Value={ 0L,1L,1L,5L,8L,26L,52L,143L,317L,811L,1884L,4668L,11076L,27053L,64805L,157273L,378364L,915598L,2206976L,5333731L,12867673L,31080023L,75010008L,181128696L,437221032L,1055645785L,2548391209L,6152624621L,14853322640L,35859784130L,86572058860L };
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
public class A112577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112577Inst : IEnumerable<long>
{
public static readonly long[] Value=A112577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112577.Bytes);
public long this[int i]=>Value[i];

public static A112577Inst Instance=new A112577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112578
{
public static readonly BigInteger[] Value={ 0L,8L,900L,359424L,370828800L,820150272000L,3435918974208000L,BigInteger.Parse("24957654229057536000"),BigInteger.Parse("294060698786444083200000"),BigInteger.Parse("5334667831784096818790400000"),BigInteger.Parse("42889554205720574193041408000000") };
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
public class A112578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112578Inst Instance=new A112578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112579
{
public static readonly BigInteger[] Value={ 0L,8L,900L,366336L,378028800L,833156928000L,3477528928742400L,BigInteger.Parse("25183876050321408000"),BigInteger.Parse("296058177312000019660800"),BigInteger.Parse("5362158372805111867637760000"),BigInteger.Parse("143458227395428379364635443200000") };
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
public class A112579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112579Inst Instance=new A112579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112580
{
public static readonly BigInteger[] Value={ 1L,12L,1152L,431424L,427723200L,920031955200L,3777894212198400L,BigInteger.Parse("27039993414897254400"),BigInteger.Parse("315084437077115278540800"),BigInteger.Parse("5667616936309704095784960000"),BigInteger.Parse("150796432741520745587273564160000") };
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
public class A112580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112580Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112580.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112580Inst Instance=new A112580Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112581
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,14L,21L,28L,39L,50L,69L,87L,115L,146L,189L,235L,302L,371L,469L,575L,714L,867L,1072L,1292L,1577L,1894L,2293L,2734L,3293L,3902L,4664L,5511L,6542L,7690L,9094L,10638L,12507L,14588L,17073L,19830L,23121L,26757L,31066L,35860L,41469L,47701L };
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
public class A112581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112581Inst : IEnumerable<long>
{
public static readonly long[] Value=A112581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112581.Bytes);
public long this[int i]=>Value[i];

public static A112581Inst Instance=new A112581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112582
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,7L,8L,9L,11L,12L,14L,18L,19L,21L,26L,28L,32L,37L,39L,44L,51L,56L,61L,70L,76L,83L,96L,102L,111L,126L,135L,148L,165L,176L,191L,212L,228L,245L,270L,289L,310L,344L,365L,390L,428L,454L,489L,531L,563L,602L,654L,697L,740L,800L,848L,902L,977L,1031L,1093L };
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
public class A112582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112582Inst : IEnumerable<long>
{
public static readonly long[] Value=A112582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112582.Bytes);
public long this[int i]=>Value[i];

public static A112582Inst Instance=new A112582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112583
{
public static readonly long[] Value={ 1L,8L,4L,50L,171L,39L,461L,78L,12203L,312L,318880L,2184L,57725L,5804L,1401L,3251L };
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
public class A112583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112583Inst : IEnumerable<long>
{
public static readonly long[] Value=A112583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112583.Bytes);
public long this[int i]=>Value[i];

public static A112583Inst Instance=new A112583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112584
{
public static readonly long[] Value={ 1L,8L,4L,50L,63L,39L,461L,78L,12203L,312L,318880L,2184L,57725L,5804L,6698L,9722L };
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
public class A112584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112584Inst : IEnumerable<long>
{
public static readonly long[] Value=A112584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112584.Bytes);
public long this[int i]=>Value[i];

public static A112584Inst Instance=new A112584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112585
{
public static readonly long[] Value={ 1L,8L,10L,12L,171L,69L,461L,26L,12203L,104L,318880L,728L,57725L,5804L,6698L,9722L };
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
public class A112585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112585Inst : IEnumerable<long>
{
public static readonly long[] Value=A112585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112585.Bytes);
public long this[int i]=>Value[i];

public static A112585Inst Instance=new A112585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112586
{
public static readonly long[] Value={ 1L,3L,15L,50L,171L,69L,461L,78L,12203L,312L,318880L,2184L,57725L,5804L,6698L,5091L };
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
public class A112586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112586Inst : IEnumerable<long>
{
public static readonly long[] Value=A112586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112586.Bytes);
public long this[int i]=>Value[i];

public static A112586Inst Instance=new A112586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112587
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,24L,28L,30L,36L,40L,42L,48L,60L,72L,84L,90L,120L };
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
public class A112587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112587Inst : IEnumerable<long>
{
public static readonly long[] Value=A112587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112587.Bytes);
public long this[int i]=>Value[i];

public static A112587Inst Instance=new A112587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112588
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,32L,33L,34L,35L,37L,38L,39L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,96L };
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
public class A112588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112588Inst : IEnumerable<long>
{
public static readonly long[] Value=A112588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112588.Bytes);
public long this[int i]=>Value[i];

public static A112588Inst Instance=new A112588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112589
{
public static readonly long[] Value={ 1L,8L,4L,50L,171L,39L,461L,78L,12203L,312L,318880L,2184L,57725L,5804L,1401L,9722L };
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
public class A112589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112589Inst : IEnumerable<long>
{
public static readonly long[] Value=A112589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112589.Bytes);
public long this[int i]=>Value[i];

public static A112589Inst Instance=new A112589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112590
{
public static readonly long[] Value={ 1L,8L,10L,1L,171L,1L,461L,1L,12203L,1L,318880L,1L,57725L,1L,6698L,1L };
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
public class A112590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112590Inst : IEnumerable<long>
{
public static readonly long[] Value=A112590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112590.Bytes);
public long this[int i]=>Value[i];

public static A112590Inst Instance=new A112590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112591
{
public static readonly long[] Value={ 1L,6L,2L,12L,6L,28L,2L,4L,10L,2L,58L,12L,2L,4L,26L,14L,6L,126L,4L,14L,6L,28L,10L,56L,4L,2L,12L,6L,28L,14L,252L,10L,2L,30L,2L,10L,62L,4L,10L,30L,6L,10L,126L,4L,2L,20L,12L,60L,6L,12L,6L,30L,10L,506L,6L,10L,2L,26L,12L,2L,62L,22L,4L,14L,4L,118L,26L,10L,6L,60L,6L,8L,26L,14L,4L,250L,8L,28L,8L };
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
public class A112591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112591Inst : IEnumerable<long>
{
public static readonly long[] Value=A112591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112591.Bytes);
public long this[int i]=>Value[i];

public static A112591Inst Instance=new A112591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112592
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,1L,3L,2L,3L,2L,4L,2L,2L,2L,4L,5L,0L,5L,0L,5L,0L,6L,3L,3L,3L,0L,3L,3L,7L,5L,0L,5L,6L,0L,6L,5L,8L,4L,4L,4L,3L,4L,5L,4L,4L,9L,2L,8L,2L,8L,1L,9L,2L,8L,1L,10L,4L,8L,4L,10L,2L,10L,4L,8L,4L,10L,11L,0L,11L,0L,7L,0L,11L,0L,11L,0L,11L,0L,12L,6L,6L,6L,6L,6L,5L,6L,6L,6L,1L,6L,6L,13L,2L,2L,2L,12L,2L,13L,2L };
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
public class A112592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112592Inst : IEnumerable<long>
{
public static readonly long[] Value=A112592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112592.Bytes);
public long this[int i]=>Value[i];

public static A112592Inst Instance=new A112592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112593
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,3L,3L,3L,5L,5L,0L,5L,5L,0L,5L,7L,5L,5L,5L,0L,5L,5L,5L,5L,9L,8L,8L,8L,1L,8L,7L,8L,8L,1L,8L,11L,4L,10L,4L,11L,3L,10L,4L,10L,4L,11L,3L,11L,13L,6L,11L,6L,10L,4L,13L,6L,11L,6L,9L,4L,13L,6L,8L,15L,6L,9L,6L,14L,5L,15L,6L,9L,6L,13L,5L,12L,6L,8L,6L,15L,17L,8L,5L,8L,12L,3L,16L,8L,5L,3L,17L,3L,16L };
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
public class A112593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112593Inst : IEnumerable<long>
{
public static readonly long[] Value=A112593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112593.Bytes);
public long this[int i]=>Value[i];

public static A112593Inst Instance=new A112593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112594
{
public static readonly long[] Value={ 0L,3L,4L,5L,8L,9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,21L,24L,25L,26L,27L,28L,29L,30L,31L,32L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,80L,81L,82L,83L,84L,85L,86L };
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
public class A112594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112594Inst : IEnumerable<long>
{
public static readonly long[] Value=A112594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112594.Bytes);
public long this[int i]=>Value[i];

public static A112594Inst Instance=new A112594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112595
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,8L,11L,19L,30L,79L,109L,297L,406L,1109L,2624L,3733L,6357L,16447L,22804L,62055L,146914L,355883L,502797L,1361477L,1864274L,5090025L,6954299L,18998623L,25952922L,96857389L,122810311L,219667700L,562145711L,1343959122L,3250063955L };
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
public class A112595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112595Inst : IEnumerable<long>
{
public static readonly long[] Value=A112595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112595.Bytes);
public long this[int i]=>Value[i];

public static A112595Inst Instance=new A112595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112596
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,13L,18L,31L,49L,129L,178L,485L,663L,1811L,4285L,6096L,10381L,26858L,37239L,101336L,239911L,581158L,821069L,2223296L,3044365L,8312026L,11356391L,31024808L,42381199L,158168405L,200549604L,358718009L,917985622L,2194689253L,5307364128L };
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
public class A112596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112596Inst : IEnumerable<long>
{
public static readonly long[] Value=A112596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112596.Bytes);
public long this[int i]=>Value[i];

public static A112596Inst Instance=new A112596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112597
{
public static readonly long[] Value={ 1L,5L,2L,4L,6L,9L,9L,9L,6L,0L,5L,3L,8L,0L,9L,4L,3L,5L,9L,9L,2L,3L,3L,6L,3L,5L,7L,5L,6L,8L,8L,4L,2L,1L,1L,6L,2L,2L,2L,0L,2L,2L,3L,6L,2L,3L,1L,9L,9L,7L,7L,1L,2L,1L,9L,8L,4L,5L,7L,2L,2L,2L,6L,5L,6L,8L,4L,1L,6L,3L,0L,4L,8L,2L,0L,2L,3L,5L,7L,2L,3L,2L,3L,7L,0L,4L,8L,2L,3L,8L,3L,0L,4L,8L,6L,0L,9L,5L,7L,9L,5L,9L,9L,7L,6L };
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
public class A112597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112597Inst : IEnumerable<long>
{
public static readonly long[] Value=A112597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112597.Bytes);
public long this[int i]=>Value[i];

public static A112597Inst Instance=new A112597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112598
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,11L,17L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L };
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
public class A112598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112598Inst : IEnumerable<long>
{
public static readonly long[] Value=A112598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112598.Bytes);
public long this[int i]=>Value[i];

public static A112598Inst Instance=new A112598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112599
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,0L,3L,0L,4L,2L,0L,2L,2L,5L,0L,4L,0L,4L,0L,6L,1L,3L,1L,2L,1L,3L,7L,5L,4L,5L,7L,3L,7L,5L,8L,7L,7L,7L,5L,6L,5L,7L,7L,9L,7L,8L,7L,7L,7L,4L,7L,8L,5L,10L,7L,9L,7L,9L,6L,5L,7L,9L,6L,10L,11L,7L,6L,7L,8L,4L,8L,7L,6L,6L,11L,4L,12L,5L,9L,5L,12L,5L,9L,5L,9L,5L,10L,5L,12L,13L,9L,7L,9L,6L,6L,13L,9L,7L };
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
public class A112599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112599Inst : IEnumerable<long>
{
public static readonly long[] Value=A112599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112599.Bytes);
public long this[int i]=>Value[i];

public static A112599Inst Instance=new A112599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112600
{
public static readonly long[] Value={ 2L,5L,11L,37L,13L,23L,19L,23L,37L,127L,47L,61L,61L,47L,67L,61L,277L,83L,79L,97L,127L,83L,101L,131L,269L,109L,131L,109L,113L,157L,137L,181L,157L,181L,151L,173L,173L,179L,173L,211L,223L,251L,193L,197L,223L,233L,223L,251L,271L,241L,239L,269L,293L,281L,313L,347L,293L };
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
public class A112600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112600Inst : IEnumerable<long>
{
public static readonly long[] Value=A112600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112600.Bytes);
public long this[int i]=>Value[i];

public static A112600Inst Instance=new A112600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112601
{
public static readonly long[] Value={ 2L,3L,7L,23L,103L,613L,4751L,47137L,582511L,8758339L,156819893L,3283370969L,79174605361L,2171048919947L,66970610115763L };
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
public class A112601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112601Inst : IEnumerable<long>
{
public static readonly long[] Value=A112601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112601.Bytes);
public long this[int i]=>Value[i];

public static A112601Inst Instance=new A112601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112602
{
public static readonly long[] Value={ 3L,1L,4L,1L,5L,9L,2L,6L,5L,3L,5L,8L,9L,7L,9L,3L,2L,3L,8L,4L,6L,2L,6L,4L,3L,3L,8L,3L,2L,7L,9L,5L,0L,2L,8L,8L,4L,1L,9L,7L,1L,6L,9L,3L,9L,9L,3L,7L,5L,1L,0L,5L,8L,2L,0L,9L,7L,4L,9L,4L,4L,5L,9L,2L,3L,0L,7L,8L,1L,6L,4L,0L,6L,2L,8L,6L,2L,0L,8L,8L,2L,1L,4L,8L,0L,8L,6L,5L,1L,3L,2L,8L,2L,3L,0L,6L,6L,4L,7L,0L,9L,3L,8L,4L,4L,6L,0L,9L,5L,5L,5L,2L,2L,3L };
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
public class A112602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112602Inst : IEnumerable<long>
{
public static readonly long[] Value=A112602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112602.Bytes);
public long this[int i]=>Value[i];

public static A112602Inst Instance=new A112602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112603
{
public static readonly long[] Value={ 1L,3L,2L,1L,4L,2L,1L,4L,0L,2L,5L,2L,2L,0L,2L,3L,4L,2L,0L,6L,0L,1L,4L,0L,2L,4L,4L,0L,3L,2L,2L,4L,2L,0L,0L,2L,3L,8L,0L,2L,4L,0L,2L,0L,2L,3L,6L,0L,0L,4L,2L,2L,4L,2L,2L,3L,2L,2L,0L,4L,0L,4L,0L,0L,8L,2L,1L,4L,0L,0L,8L,2L,2L,0L,2L,2L,0L,2L,1L,4L,2L,4L,6L,0L,2L,4L,0L,4L,0L,0L,0L,7L,4L,0L,4L,2L,2L,0L,0L,0L,6L,2L,4L,4L,2L };
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
public class A112603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112603Inst : IEnumerable<long>
{
public static readonly long[] Value=A112603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112603.Bytes);
public long this[int i]=>Value[i];

public static A112603Inst Instance=new A112603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112604
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,2L,1L,0L,0L,2L,0L,0L,3L,0L,2L,2L,0L,0L,2L,0L,1L,0L,0L,2L,2L,0L,0L,2L,0L,2L,1L,0L,2L,4L,0L,0L,0L,0L,0L,2L,0L,0L,3L,0L,0L,2L,0L,2L,2L,0L,2L,0L,0L,0L,4L,0L,1L,2L,0L,2L,2L,0L,0L,0L,0L,0L,0L,0L,4L,2L,0L,0L,1L,0L,0L,4L,0L,2L,2L,0L,0L,2L,0L,2L,2L,0L,0L,2L,0L,0L,3L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,2L,0L,2L };
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
public class A112604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112604Inst : IEnumerable<long>
{
public static readonly long[] Value=A112604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112604.Bytes);
public long this[int i]=>Value[i];

public static A112604Inst Instance=new A112604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112605
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,1L,2L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,2L,0L,0L,4L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,2L,0L,3L,2L,0L,0L,2L,0L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,2L,0L,2L,2L,0L,0L,0L,0L,1L,4L,0L,0L,4L,0L,0L,2L,0L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,2L,0L,0L,4L,0L,2L,0L,0L,1L,2L,0L,0L,2L,0L,2L,0L,0L,4L,4L,0L,0L,0L,0L };
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
public class A112605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112605Inst : IEnumerable<long>
{
public static readonly long[] Value=A112605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112605.Bytes);
public long this[int i]=>Value[i];

public static A112605Inst Instance=new A112605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112606
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,3L,2L,0L,2L,1L,0L,2L,0L,0L,1L,2L,0L,0L,0L,0L,3L,0L,0L,2L,2L,0L,4L,1L,0L,2L,0L,0L,0L,4L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,3L,0L,0L,0L,0L,0L,2L,2L,0L,2L,3L,0L,2L,0L,0L,4L,2L,0L,0L,2L,0L,1L,0L,0L,4L,0L,0L,2L,0L,0L,2L,0L,0L,1L,2L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,4L,1L,0L,0L,0L,0L,2L,4L,0L,4L,0L,0L,4L,0L,0L };
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
public class A112606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112606Inst : IEnumerable<long>
{
public static readonly long[] Value=A112606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112606.Bytes);
public long this[int i]=>Value[i];

public static A112606Inst Instance=new A112606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112607
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,2L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,2L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,2L,1L,0L,1L,0L,0L,3L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L };
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
public class A112607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112607Inst : IEnumerable<long>
{
public static readonly long[] Value=A112607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112607.Bytes);
public long this[int i]=>Value[i];

public static A112607Inst Instance=new A112607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112608
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,2L,0L,0L,2L,1L,0L,4L,0L,0L,0L,0L,0L,2L,3L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,0L,1L,0L,4L,0L,0L,2L,2L,0L,2L,0L,0L,2L,0L,0L,0L,1L,0L,2L,2L,0L,4L,0L,0L,4L,0L,0L,0L,0L,0L,2L,0L,0L,2L,3L,0L,2L,0L,0L,2L,0L,0L,2L,2L,0L,0L,2L,0L,2L,0L,0L,2L,4L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,4L,0L,0L,2L,0L,0L,2L,4L,0L,0L };
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
public class A112608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112608Inst : IEnumerable<long>
{
public static readonly long[] Value=A112608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112608.Bytes);
public long this[int i]=>Value[i];

public static A112608Inst Instance=new A112608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112609
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,2L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,2L,1L,0L,2L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L };
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
public class A112609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112609Inst : IEnumerable<long>
{
public static readonly long[] Value=A112609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112609.Bytes);
public long this[int i]=>Value[i];

public static A112609Inst Instance=new A112609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112610
{
public static readonly long[] Value={ 1L,6L,13L,14L,18L,32L,31L,30L,48L,38L,42L,78L,57L,54L,80L,62L,84L,96L,74L,96L,121L,108L,90L,128L,98L,102L,192L,110L,114L,182L,133L,156L,176L,160L,138L,192L,180L,150L,234L,158L,192L,288L,183L,174L,240L,182L,228L,320L,194L,198L,272L,252L,240L,288L,256L,252L,403L,230L };
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
public class A112610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112610Inst : IEnumerable<long>
{
public static readonly long[] Value=A112610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112610.Bytes);
public long this[int i]=>Value[i];

public static A112610Inst Instance=new A112610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112611
{
public static readonly long[] Value={ 0L,4L,24L,60L,480L,2580L,10200L,59100L,303600L,1396500L,7347000L,37099500L,180030000L,916552500L,4599165000L,22749787500L,114487050000L,573173362500L,2854795125000L,14307190687500L,71569168500000L,357347616562500L };
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
public class A112611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112611Inst : IEnumerable<long>
{
public static readonly long[] Value=A112611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112611.Bytes);
public long this[int i]=>Value[i];

public static A112611Inst Instance=new A112611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112612
{
public static readonly long[] Value={ 3L,26L,624L };
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
public class A112612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112612Inst : IEnumerable<long>
{
public static readonly long[] Value=A112612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112612.Bytes);
public long this[int i]=>Value[i];

public static A112612Inst Instance=new A112612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112613
{
public static readonly long[] Value={ 1L,5L,24L };
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
public class A112613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112613Inst : IEnumerable<long>
{
public static readonly long[] Value=A112613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112613.Bytes);
public long this[int i]=>Value[i];

public static A112613Inst Instance=new A112613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112614
{
public static readonly long[] Value={ 15L,14120L,371515454L };
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
public class A112614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112614Inst : IEnumerable<long>
{
public static readonly long[] Value=A112614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112614.Bytes);
public long this[int i]=>Value[i];

public static A112614Inst Instance=new A112614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112615
{
public static readonly long[] Value={ 1L,71L,23778L };
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
public class A112615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112615Inst : IEnumerable<long>
{
public static readonly long[] Value=A112615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112615.Bytes);
public long this[int i]=>Value[i];

public static A112615Inst Instance=new A112615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112616
{
public static readonly long[] Value={ 1L,9L,57L,847L,15303L };
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
public class A112616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112616Inst : IEnumerable<long>
{
public static readonly long[] Value=A112616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112616.Bytes);
public long this[int i]=>Value[i];

public static A112616Inst Instance=new A112616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112617
{
public static readonly long[] Value={ 1L,39L,1483L,354009L,208211284L };
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
public class A112617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112617Inst : IEnumerable<long>
{
public static readonly long[] Value=A112617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112617.Bytes);
public long this[int i]=>Value[i];

public static A112617Inst Instance=new A112617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112618
{
public static readonly long[] Value={ 3L,7L,14L,5L,8L,6L,28L,18L,29L,77L,14L,19L,35L,82L,29L,33L,64L,68L,100L,132L,31L,18L,270L,109L,19L,186L,13L,184L,105L,172L,586L,79L,11L,34L,10L,223L,71L,37L,41L,314L,100L,25L,72L,171L,382L,26L,83L,361L,34L,249L,36L,28L,506L,304L,54L,37L,177L,331L,61L,536L,777L,458L,30L,123L };
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
public class A112618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112618Inst : IEnumerable<long>
{
public static readonly long[] Value=A112618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112618.Bytes);
public long this[int i]=>Value[i];

public static A112618Inst Instance=new A112618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112619
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,18L,79L,326L,1278L,4875L,17978L,64720L,227842L,787546L,2678207L,8982754L,29761361L,97557854L };
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
public class A112619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112619Inst : IEnumerable<long>
{
public static readonly long[] Value=A112619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112619.Bytes);
public long this[int i]=>Value[i];

public static A112619Inst Instance=new A112619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112620
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,1L,5L,4L,5L,3L,9L,3L,11L,8L,6L,9L,15L,5L,17L,8L,12L,11L,21L,7L,18L,13L,12L,12L,27L,7L,29L,19L,15L,18L,24L,12L,35L,23L,23L,17L,39L,12L,41L,20L,19L,25L,45L,18L,38L,24L,23L,26L,51L,21L,40L,30L,35L,31L,57L,18L,59L,38L,37L,38L,47L,24L,65L,36L,38L,27L,69L,24L,71L,41L,36L,43L };
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
public class A112620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112620Inst : IEnumerable<long>
{
public static readonly long[] Value=A112620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112620.Bytes);
public long this[int i]=>Value[i];

public static A112620Inst Instance=new A112620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112621
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,2L,1L,27L,4L,2L,1L,5L,1L,2L,2L,256L,1L,5L,1L,5L,2L,2L,1L,28L,4L,2L,27L,5L,1L,3L,1L,3125L,2L,2L,2L,8L,1L,2L,2L,28L,1L,3L,1L,5L,5L,2L,1L,257L,4L,5L,2L,5L,1L,28L,2L,28L,2L,2L,1L,6L,1L,2L,5L,46656L,2L,3L,1L,5L,2L,3L,1L,31L,1L,2L,5L,5L,2L,3L,1L,257L,256L,2L,1L,6L,2L,2L,2L,28L,1L,6L,2L,5L,2L,2L,2L,3126L,1L,5L,5L,8L,1L,3L,1L,28L,3L };
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
public class A112621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112621Inst : IEnumerable<long>
{
public static readonly long[] Value=A112621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112621.Bytes);
public long this[int i]=>Value[i];

public static A112621Inst Instance=new A112621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112622
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,1L,27L,4L,1L,1L,4L,1L,1L,1L,256L,1L,4L,1L,4L,1L,1L,1L,27L,4L,1L,27L,4L,1L,1L,1L,3125L,1L,1L,1L,16L,1L,1L,1L,27L,1L,1L,1L,4L,4L,1L,1L,256L,4L,4L,1L,4L,1L,27L,1L,27L,1L,1L,1L,4L,1L,1L,4L,46656L,1L,1L,1L,4L,1L,1L,1L,108L,1L,1L,4L,4L,1L,1L,1L,256L,256L,1L,1L,4L,1L,1L,1L,27L,1L,4L,1L,4L,1L,1L,1L,3125L,1L,4L,4L,16L,1L,1L,1L,27L,1L };
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
public class A112622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112622Inst : IEnumerable<long>
{
public static readonly long[] Value=A112622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112622.Bytes);
public long this[int i]=>Value[i];

public static A112622Inst Instance=new A112622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112623
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,6L,2L,2L,1L,3L,1L,2L,2L,24L,1L,3L,1L,3L,2L,2L,1L,7L,2L,2L,6L,3L,1L,3L,1L,120L,2L,2L,2L,4L,1L,2L,2L,7L,1L,3L,1L,3L,3L,2L,1L,25L,2L,3L,2L,3L,1L,7L,2L,7L,2L,2L,1L,4L,1L,2L,3L,720L,2L,3L,1L,3L,2L,3L,1L,8L,1L,2L,3L,3L,2L,3L,1L,25L,24L,2L,1L,4L,2L,2L,2L,7L,1L,4L,2L,3L,2L,2L,2L,121L,1L,3L,3L,4L,1L };
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
public class A112623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112623Inst : IEnumerable<long>
{
public static readonly long[] Value=A112623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112623.Bytes);
public long this[int i]=>Value[i];

public static A112623Inst Instance=new A112623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112624
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,6L,2L,1L,1L,2L,1L,1L,1L,24L,1L,2L,1L,2L,1L,1L,1L,6L,2L,1L,6L,2L,1L,1L,1L,120L,1L,1L,1L,4L,1L,1L,1L,6L,1L,1L,1L,2L,2L,1L,1L,24L,2L,2L,1L,2L,1L,6L,1L,6L,1L,1L,1L,2L,1L,1L,2L,720L,1L,1L,1L,2L,1L,1L,1L,12L,1L,1L,2L,2L,1L,1L,1L,24L,24L,1L,1L,2L,1L,1L,1L,6L,1L,2L,1L,2L,1L,1L,1L,120L,1L,2L,2L,4L,1L };
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
public class A112624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112624Inst : IEnumerable<long>
{
public static readonly long[] Value=A112624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112624.Bytes);
public long this[int i]=>Value[i];

public static A112624Inst Instance=new A112624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112625
{
public static readonly long[] Value={ 152539L,175573L,292147L,303337L,437527L,590137L,1115683L,1134961L,1178659L,1205707L,1281751L,1587301L,1597759L,1673209L,1853641L,1898371L,1945243L,1997617L,2139157L,2191429L,2399641L,2417533L,2638747L,2656663L,2744587L };
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
public class A112625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112625Inst : IEnumerable<long>
{
public static readonly long[] Value=A112625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112625.Bytes);
public long this[int i]=>Value[i];

public static A112625Inst Instance=new A112625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112626
{
public static readonly long[] Value={ 1L,3L,1L,9L,5L,1L,27L,19L,7L,1L,81L,65L,33L,9L,1L,243L,211L,131L,51L,11L,1L,729L,665L,473L,233L,73L,13L,1L,2187L,2059L,1611L,939L,379L,99L,15L,1L,6561L,6305L,5281L,3489L,1697L,577L,129L,17L,1L,19683L,19171L,16867L,12259L,6883L,2851L,835L,163L,19L,1L,59049L,58025L };
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
public class A112626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112626Inst : IEnumerable<long>
{
public static readonly long[] Value=A112626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112626.Bytes);
public long this[int i]=>Value[i];

public static A112626Inst Instance=new A112626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112627
{
public static readonly long[] Value={ 1L,3L,19L,51L,307L,819L,4915L,13107L,78643L,209715L,1258291L,3355443L,20132659L,53687091L,322122547L,858993459L,5153960755L,13743895347L,82463372083L,219902325555L,1319413953331L,3518437208883L,21110623253299L,56294995342131L,337769972052787L,900719925474099L };
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
public class A112627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112627Inst : IEnumerable<long>
{
public static readonly long[] Value=A112627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112627.Bytes);
public long this[int i]=>Value[i];

public static A112627Inst Instance=new A112627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112628
{
public static readonly long[] Value={ 9L,0L,0L,3L,1L,6L,3L,1L,6L,1L,5L,7L,1L,0L,6L,0L,6L,9L,5L,5L,5L,1L,9L,9L,1L,9L,1L,0L,0L,6L,7L,4L,0L,5L,8L,2L,6L,6L,4L,5L,7L,4L,1L,4L,9L,9L,5L,5L,2L,2L,0L,6L,2L,5L,5L,7L,1L,4L,3L,7L,4L,7L,1L,2L,3L,1L,4L,5L,8L,7L,3L,0L,7L,1L,9L,0L,4L,6L,3L,4L,4L,9L,9L,8L,0L,8L,2L,7L,7L,7L,7L,5L,4L,0L,8L,2L,3L,4L,0L,9L,9L,7L,5L,5L,1L };
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
public class A112628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112628Inst : IEnumerable<long>
{
public static readonly long[] Value=A112628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112628.Bytes);
public long this[int i]=>Value[i];

public static A112628Inst Instance=new A112628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112629
{
public static readonly long[] Value={ 9L,25L,49L,169L,225L };
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
public class A112629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112629Inst : IEnumerable<long>
{
public static readonly long[] Value=A112629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112629.Bytes);
public long this[int i]=>Value[i];

public static A112629Inst Instance=new A112629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112630
{
public static readonly long[] Value={ 16L,49L,121L,169L,289L,361L,961L,1225L,1681L,2401L,3025L,3481L,5041L,7225L,8281L,9025L,11881L,15625L,19321L,25921L,30625L,32041L,32761L,39601L,48841L,55225L,57121L,70225L,72361L,93025L,96721L,101761L,108241L };
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
public class A112630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112630Inst : IEnumerable<long>
{
public static readonly long[] Value=A112630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112630.Bytes);
public long this[int i]=>Value[i];

public static A112630Inst Instance=new A112630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112631
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,0L,3L,5L,7L,5L,10L,4L,12L,9L,6L,5L,16L,3L,18L,2L,17L,5L,22L,8L,22L,12L,13L,8L,28L,5L,30L,5L,30L,15L,22L,9L,36L,23L,18L,16L,40L,2L,42L,15L,20L,9L,46L,20L,46L,12L,23L,21L,52L,10L,33L,26L,40L,27L,58L,21L,60L,23L,41L,31L,55L,11L,66L,32L,44L,21L,70L,19L,72L,23L,40L,28L,63L,17L };
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
public class A112631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112631Inst : IEnumerable<long>
{
public static readonly long[] Value=A112631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112631.Bytes);
public long this[int i]=>Value[i];

public static A112631Inst Instance=new A112631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112632
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,3L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,2L,1L,2L,3L,4L,3L,4L,3L,4L,3L,2L,1L,2L,1L,2L,3L,2L,3L,4L,5L,6L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,3L,4L,3L,4L,5L,4L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,3L,2L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,6L,7L,6L,5L };
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
public class A112632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112632Inst : IEnumerable<long>
{
public static readonly long[] Value=A112632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112632.Bytes);
public long this[int i]=>Value[i];

public static A112632Inst Instance=new A112632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112633
{
public static readonly long[] Value={ 3L,7L,19L,31L,107L,127L,607L,1279L,2203L,4423L,86243L,110503L,216091L,756839L,1257787L,20996011L,24036583L,25964951L };
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
public class A112633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112633Inst : IEnumerable<long>
{
public static readonly long[] Value=A112633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112633.Bytes);
public long this[int i]=>Value[i];

public static A112633Inst Instance=new A112633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112634
{
public static readonly long[] Value={ 2L,5L,13L,17L,61L,89L,521L,2281L,3217L,4253L,9689L,9941L,11213L,19937L,21701L,23209L,44497L,132049L,859433L,1398269L,2976221L,3021377L,6972593L,13466917L,30402457L };
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
public class A112634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112634Inst : IEnumerable<long>
{
public static readonly long[] Value=A112634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112634.Bytes);
public long this[int i]=>Value[i];

public static A112634Inst Instance=new A112634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112635
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,0L,3L,5L,4L,1L,10L,0L,6L,2L,13L,10L,16L,1L,18L,6L,14L,8L,22L,4L,23L,6L,17L,8L,28L,15L,30L,11L,19L,18L,24L,2L,36L,21L,28L,12L,40L,12L,42L,20L,24L,21L,46L,12L,47L,24L,36L,2L,40L,21L,49L,37L,22L,26L,58L,14L,60L,31L,51L,44L,50L,8L,66L,36L,44L,23L,70L,8L,72L,37L,55L,40L,62L,20L };
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
public class A112635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112635Inst : IEnumerable<long>
{
public static readonly long[] Value=A112635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112635.Bytes);
public long this[int i]=>Value[i];

public static A112635Inst Instance=new A112635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112636
{
public static readonly long[] Value={ 1L,2L,3L,14L,24L,28L,48L,72L,84L,132L,140L,144L,154L,155L,165L,180L,192L,196L,203L,208L,215L,216L };
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
public class A112636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112636Inst : IEnumerable<long>
{
public static readonly long[] Value=A112636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112636.Bytes);
public long this[int i]=>Value[i];

public static A112636Inst Instance=new A112636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112637
{
public static readonly BigInteger[] Value={ 0L,6L,702L,375186L,68548170L,212649972618L,5572180693170L,52037240544974502L,11661547289636534670UL,BigInteger.Parse("9015983814263107529634"),BigInteger.Parse("262721633707681615189866"),BigInteger.Parse("10335648343425700490571339750"),BigInteger.Parse("309124221331162265697856664958") };
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
public class A112637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112637Inst Instance=new A112637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112638
{
public static readonly long[] Value={ 2L,4L,16L,46L,196L,946L,8296L,65246L,385596L,1568346L,3925096L,17165846L,59491596L,333414346L,1000627096L,1003689846L,1013327596L,1019992346L,1099915096L,1899135846L,8291221596L,65211444346L,385412777096L,1566619439846L,3899692777596L };
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
public class A112638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112638Inst : IEnumerable<long>
{
public static readonly long[] Value=A112638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112638.Bytes);
public long this[int i]=>Value[i];

public static A112638Inst Instance=new A112638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112639
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,7L,9L,12L,16L,22L,29L,38L,51L,67L,89L,119L,157L,209L,276L,366L,486L,643L,853L,1130L,1496L,1983L,2626L,3480L,4610L,6106L,8090L,10716L,14196L,18807L,24913L,33004L,43721L,57917L,76725L,101638L,134643L,178364L,236281L,313007L,414645L };
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
public class A112639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112639Inst : IEnumerable<long>
{
public static readonly long[] Value=A112639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112639.Bytes);
public long this[int i]=>Value[i];

public static A112639Inst Instance=new A112639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112640
{
public static readonly long[] Value={ 28683369L,36165987L,38660193L,86050107L,108497961L,115980579L,131339637L,138428433L,140397543L,153393669L,160876287L,258150321L,277272567L,296394813L,315517059L,325493883L,347941737L,353761551L,372883797L,373715199L,392006043L };
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
public class A112640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112640Inst : IEnumerable<long>
{
public static readonly long[] Value=A112640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112640.Bytes);
public long this[int i]=>Value[i];

public static A112640Inst Instance=new A112640Inst();

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