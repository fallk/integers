using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A143783
{
public static readonly BigInteger[] Value={ 3L,1L,-2L,15L,-137984787083L,BigInteger.Parse("6902195348070069511711186593994436908244064708018164500799150599256") };
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
public class A143783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143783Inst Instance=new A143783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143782
{
public static readonly long[] Value={ 2L,0L,-1L,0L,-3L,898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143782Inst : IEnumerable<long>
{
public static readonly long[] Value=A143782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143782.Bytes);
public long this[int i]=>Value[i];

public static A143782Inst Instance=new A143782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143781
{
public static readonly BigInteger[] Value={ 0L,-1L,-1L,3L,118L,BigInteger.Parse("-199068134034785153195409370979964879499768447341765846329146257207125965412281784631240438087") };
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
public class A143781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143781Inst Instance=new A143781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143780
{
public static readonly BigInteger[] Value={ -1L,0L,-1L,6L,-26444L,BigInteger.Parse("341989937615742945541647800") };
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
public class A143780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143780Inst Instance=new A143780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143779
{
public static readonly BigInteger[] Value={ 0L,-1L,-3L,0L,-16L,231L,53325L,2843555576L,8085808313800691712L,BigInteger.Parse("65380296087528385371720710929665490863"),BigInteger.Parse("4274583116492879495671558465604382082843695840997226026463670361542736484669") };
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
public class A143779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143779Inst Instance=new A143779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143778
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,12L,6L,1L,10L,40L,60L,25L,1L,15L,100L,300L,375L,136L,1L,21L,210L,1050L,2625L,2856L,927L,1L,18L,392L,2940L,12250L,26656L,25956L,7690L,1L,36L,672L,7056L,44100L,15993L,311472L,276840L,75913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143778Inst : IEnumerable<long>
{
public static readonly long[] Value=A143778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143778.Bytes);
public long this[int i]=>Value[i];

public static A143778Inst Instance=new A143778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143777
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,1L,13L,26L,7L,1L,40L,260L,280L,47L,1L,121L,2420L,8470L,5687L,628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143777Inst : IEnumerable<long>
{
public static readonly long[] Value=A143777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143777.Bytes);
public long this[int i]=>Value[i];

public static A143777Inst Instance=new A143777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143776
{
public static readonly BigInteger[] Value={ 118L,61318L,32730551749894L,BigInteger.Parse("233592048827366522661214"),BigInteger.Parse("2141662167055484666186673758527328459608763158"),BigInteger.Parse("2227825214147655788431110667440233064879987880421955931545425603586478") };
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
public class A143776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143776Inst Instance=new A143776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143775
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,4L,1L,4L,6L,4L,9L,1L,9L,16L,16L,9L,24L,1L,24L,48L,52L,45L,24L,75L,1L,75L,168L,188L,171L,144L,75L,269L,1L,269L,670L,780L,711L,624L,525L,269L,1091L,1L,1091L,2990L,3632L,3348L,2904L,2550L,2152L,1091L,4940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143775Inst : IEnumerable<long>
{
public static readonly long[] Value=A143775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143775.Bytes);
public long this[int i]=>Value[i];

public static A143775Inst Instance=new A143775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143774
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,7L,14L,6L,1L,15L,70L,70L,28L,1L,31L,310L,930L,868L,204L,1L,63L,1302L,8370L,18228L,12852L,2344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143774Inst : IEnumerable<long>
{
public static readonly long[] Value=A143774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143774.Bytes);
public long this[int i]=>Value[i];

public static A143774Inst Instance=new A143774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143773
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,2L,3L,1L,5L,1L,4L,3L,6L,1L,8L,1L,7L,5L,6L,1L,14L,2L,7L,8L,11L,1L,17L,1L,14L,11L,9L,3L,29L,1L,10L,15L,23L,1L,28L,1L,23L,25L,12L,1L,51L,2L,20L,25L,32L,1L,44L,11L,39L,31L,15L,1L,94L,1L,16L,40L,52L,19L,64L,1L,57L,45L,44L,1L,126L,1L,19L,83L,74L,6L,90L,1L,124L,63L,21L,1L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143773Inst : IEnumerable<long>
{
public static readonly long[] Value=A143773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143773.Bytes);
public long this[int i]=>Value[i];

public static A143773Inst Instance=new A143773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143772
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,1L,3L,8L,1L,1L,3L,2L,1L,1L,2L,3L,4L,1L,1L,3L,2L,1L,12L,1L,3L,8L,1L,1L,3L,2L,1L,1L,2L,3L,4L,1L,1L,8L,3L,2L,1L,1L,3L,8L,1L,6L,1L,3L,2L,1L,1L,3L,4L,1L,6L,1L,3L,2L,1L,1L,2L,3L,8L,1L,1L,4L,3L,2L,1L,24L,1L,3L,4L,1L,1L,3L,2L,1L,1L,3L,8L,1L,1L,4L,3L,2L,1L,24L,1L,2L,3L,4L,1L,6L,1L,3L,2L,1L,1L,2L,3L,8L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143772Inst : IEnumerable<long>
{
public static readonly long[] Value=A143772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143772.Bytes);
public long this[int i]=>Value[i];

public static A143772Inst Instance=new A143772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143771
{
public static readonly long[] Value={ 3L,4L,1L,6L,1L,8L,3L,2L,1L,12L,1L,14L,3L,8L,1L,18L,1L,20L,3L,2L,1L,24L,1L,2L,3L,4L,1L,30L,1L,32L,3L,2L,1L,12L,1L,38L,3L,8L,1L,42L,1L,44L,3L,2L,1L,48L,1L,2L,3L,4L,1L,54L,1L,8L,3L,2L,1L,60L,1L,62L,3L,8L,1L,6L,1L,68L,3L,2L,1L,72L,1L,74L,3L,4L,1L,6L,1L,80L,3L,2L,1L,84L,1L,2L,3L,8L,1L,90L,1L,4L,3L,2L,1L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143771Inst : IEnumerable<long>
{
public static readonly long[] Value=A143771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143771.Bytes);
public long this[int i]=>Value[i];

public static A143771Inst Instance=new A143771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143770
{
public static readonly long[] Value={ 2L,12L,60L,120L,840L,2520L,5040L,27720L,55440L,110880L,166320L,720720L,1441440L,2162160L,3603600L,7207200L,10810800L,36756720L,61261200L,122522400L,183783600L,367567200L,698377680L,2327925600L,3491888400L,6983776800L,13967553600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143770Inst : IEnumerable<long>
{
public static readonly long[] Value=A143770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143770.Bytes);
public long this[int i]=>Value[i];

public static A143770Inst Instance=new A143770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143769
{
public static readonly long[] Value={ -3L,0L,27L,-18L,-63L,36L,207L,-126L,-603L,360L,1827L,-1098L,-5463L,3276L,16407L,-9846L,-49203L,29520L,147627L,-88578L,-442863L,265716L,1328607L,-797166L,-3985803L,2391480L,11957427L,-7174458L,-35872263L,21523356L,107616807L,-64570086L,-322850403L,193710240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143769Inst : IEnumerable<long>
{
public static readonly long[] Value=A143769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143769.Bytes);
public long this[int i]=>Value[i];

public static A143769Inst Instance=new A143769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143768
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,169L,2041L,30811L,560827L,11957905L,292399345L,8069068531L,248093713891L,8411093625529L,311750189715433L,12541478207183563L,544268121894899851L,BigInteger.Parse("25345579186001847841"),BigInteger.Parse("1260715969618060192225") };
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
public class A143768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143768Inst Instance=new A143768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143543
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,1L,38L,19L,6L,1L,728L,230L,55L,10L,1L,26704L,5098L,825L,125L,15L,1L,1866256L,207536L,20818L,2275L,245L,21L,1L,251548592L,15891372L,925036L,64673L,5320L,434L,28L,1L,66296291072L,2343580752L,76321756L,3102204L,169113L,11088L,714L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143543Inst : IEnumerable<long>
{
public static readonly long[] Value=A143543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143543.Bytes);
public long this[int i]=>Value[i];

public static A143543Inst Instance=new A143543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143542
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,2L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143542Inst : IEnumerable<long>
{
public static readonly long[] Value=A143542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143542.Bytes);
public long this[int i]=>Value[i];

public static A143542Inst Instance=new A143542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143541
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143541Inst : IEnumerable<long>
{
public static readonly long[] Value=A143541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143541.Bytes);
public long this[int i]=>Value[i];

public static A143541Inst Instance=new A143541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143540
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,2L,1L,0L,0L,3L,2L,0L,1L,0L,3L,2L,0L,1L,0L,0L,4L,3L,0L,2L,0L,1L,0L,4L,3L,0L,2L,0L,1L,0L,0L,4L,3L,0L,2L,0L,1L,0L,0L,0L,4L,3L,0L,2L,0L,1L,0L,0L,0L,0L,5L,4L,0L,3L,0L,2L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143540Inst : IEnumerable<long>
{
public static readonly long[] Value=A143540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143540.Bytes);
public long this[int i]=>Value[i];

public static A143540Inst Instance=new A143540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143539
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,0L,2L,3L,1L,3L,1L,1L,3L,1L,2L,3L,3L,1L,2L,3L,1L,4L,2L,1L,5L,1L,1L,5L,3L,1L,2L,4L,1L,3L,4L,2L,5L,3L,1L,4L,2L,2L,6L,2L,1L,3L,2L,3L,5L,4L,1L,5L,5L,1L,6L,3L,2L,5L,1L,2L,2L,4L,3L,5L,4L,0L,7L,4L,1L,6L,3L,1L,5L,2L,2L,5L,6L,1L,2L,5L,2L,7L,4L,2L,6L,2L,2L,9L,2L,3L,4L,4L,2L,2L,4L,1L,9L,5L,3L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143539Inst : IEnumerable<long>
{
public static readonly long[] Value=A143539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143539.Bytes);
public long this[int i]=>Value[i];

public static A143539Inst Instance=new A143539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143538
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143538Inst : IEnumerable<long>
{
public static readonly long[] Value=A143538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143538.Bytes);
public long this[int i]=>Value[i];

public static A143538Inst Instance=new A143538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143537
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,2L,2L,1L,0L,3L,3L,2L,1L,3L,3L,2L,1L,1L,0L,4L,4L,3L,2L,2L,1L,1L,4L,4L,3L,2L,2L,1L,1L,0L,4L,4L,3L,2L,2L,1L,1L,0L,0L,4L,4L,3L,2L,2L,1L,1L,0L,0L,0L,5L,5L,4L,3L,3L,2L,2L,1L,1L,1L,1L,5L,5L,4L,3L,3L,2L,21L,1L,1L,1L,0L,6L,6L,5L,4L,4L,3L,3L,2L,2L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143537Inst : IEnumerable<long>
{
public static readonly long[] Value=A143537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143537.Bytes);
public long this[int i]=>Value[i];

public static A143537Inst Instance=new A143537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143536
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143536Inst : IEnumerable<long>
{
public static readonly long[] Value=A143536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143536.Bytes);
public long this[int i]=>Value[i];

public static A143536Inst Instance=new A143536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143535
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143535Inst : IEnumerable<long>
{
public static readonly long[] Value=A143535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143535.Bytes);
public long this[int i]=>Value[i];

public static A143535Inst Instance=new A143535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143534
{
public static readonly long[] Value={ 0L,1L,1L,6L,166L,2504L,33102L,411100L,4911098L,57111096L,651111094L,7311111092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143534Inst : IEnumerable<long>
{
public static readonly long[] Value=A143534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143534.Bytes);
public long this[int i]=>Value[i];

public static A143534Inst Instance=new A143534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143533
{
public static readonly long[] Value={ 0L,1L,2L,4L,18L,40L,162L,526L,1708L,4838L,13522L,34062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143533Inst : IEnumerable<long>
{
public static readonly long[] Value=A143533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143533.Bytes);
public long this[int i]=>Value[i];

public static A143533Inst Instance=new A143533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143532
{
public static readonly long[] Value={ 0L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,166L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,2L,1L,2L,2504L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143532Inst : IEnumerable<long>
{
public static readonly long[] Value=A143532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143532.Bytes);
public long this[int i]=>Value[i];

public static A143532Inst Instance=new A143532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143531
{
public static readonly long[] Value={ 1L,8L,2L,8L,6L,4L,3L,2L,6L,9L,7L,5L,2L,5L,2L,2L,6L,1L,0L,4L,0L,9L,7L,3L,2L,5L,2L,7L,3L,1L,8L,0L,6L,9L,3L,2L,0L,0L,0L,8L,6L,5L,2L,9L,1L,8L,1L,1L,0L,1L,9L,8L,6L,3L,2L,3L,9L,2L,0L,2L,7L,7L,9L,1L,1L,5L,9L,7L,7L,1L,1L,1L,7L,2L,0L,4L,6L,4L,1L,1L,8L,0L,0L,9L,2L,7L,8L,5L,5L,0L,1L,1L,2L,5L,5L,8L,2L,4L,4L,2L,1L,5L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143531Inst : IEnumerable<long>
{
public static readonly long[] Value=A143531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143531.Bytes);
public long this[int i]=>Value[i];

public static A143531Inst Instance=new A143531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143530
{
public static readonly long[] Value={ 1L,4L,8L,2L,7L,7L,3L,7L,8L,7L,1L,0L,0L,8L,0L,7L,6L,5L,8L,5L,8L,6L,3L,8L,4L,4L,4L,7L,7L,0L,6L,0L,5L,9L,3L,1L,2L,0L,2L,7L,1L,7L,1L,2L,9L,2L,5L,0L,3L,2L,5L,4L,2L,5L,1L,4L,0L,8L,8L,6L,4L,7L,8L,3L,4L,2L,0L,0L,3L,1L,7L,2L,3L,7L,2L,7L,9L,8L,6L,0L,1L,9L,1L,1L,4L,0L,1L,1L,6L,5L,2L,8L,8L,1L,0L,5L,5L,9L,5L,1L,3L,8L,0L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143530Inst : IEnumerable<long>
{
public static readonly long[] Value=A143530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143530.Bytes);
public long this[int i]=>Value[i];

public static A143530Inst Instance=new A143530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143529
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,7L,9L,11L,12L,10L,13L,16L,18L,17L,19L,14L,20L,21L,23L,29L,22L,15L,32L,25L,28L,35L,70L,24L,26L,38L,35L,30L,45L,47L,99L,34L,27L,39L,37L,40L,49L,52L,57L,169L,41L,31L,48L,43L,42L,50L,54L,76L,59L,408L,58L,36L,51L,55L,44L,62L,69L,81L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143529Inst : IEnumerable<long>
{
public static readonly long[] Value=A143529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143529.Bytes);
public long this[int i]=>Value[i];

public static A143529Inst Instance=new A143529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143528
{
public static readonly long[] Value={ 1L,2L,3L,7L,4L,5L,12L,9L,6L,8L,41L,14L,11L,13L,10L,70L,19L,16L,18L,15L,17L,239L,24L,21L,23L,20L,22L,29L,408L,53L,26L,28L,25L,27L,34L,46L,1393L,82L,31L,33L,30L,32L,39L,51L,58L,2378L,111L,36L,38L,35L,37L,44L,56L,63L,75L,8119L,140L,65L,43L,40L,42L,49L,61L,68L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143528Inst : IEnumerable<long>
{
public static readonly long[] Value=A143528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143528.Bytes);
public long this[int i]=>Value[i];

public static A143528Inst Instance=new A143528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143495
{
public static readonly long[] Value={ 1L,3L,1L,9L,7L,1L,27L,37L,12L,1L,81L,175L,97L,18L,1L,243L,781L,660L,205L,25L,1L,729L,3367L,4081L,1890L,380L,33L,1L,2187L,14197L,23772L,15421L,4550L,644L,42L,1L,6561L,58975L,133057L,116298L,47271L,9702L,1022L,52L,1L,19683L,242461L,724260L,830845L,447195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143495Inst : IEnumerable<long>
{
public static readonly long[] Value=A143495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143495.Bytes);
public long this[int i]=>Value[i];

public static A143495Inst Instance=new A143495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143494
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,1L,8L,19L,9L,1L,16L,65L,55L,14L,1L,32L,211L,285L,125L,20L,1L,64L,665L,1351L,910L,245L,27L,1L,128L,2059L,6069L,5901L,2380L,434L,35L,1L,256L,6305L,26335L,35574L,20181L,5418L,714L,44L,1L,512L,19171L,111645L,204205L,156660L,58107L,11130L,1110L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143494Inst : IEnumerable<long>
{
public static readonly long[] Value=A143494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143494.Bytes);
public long this[int i]=>Value[i];

public static A143494Inst Instance=new A143494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143493
{
public static readonly long[] Value={ 1L,4L,1L,20L,9L,1L,120L,74L,15L,1L,840L,638L,179L,22L,1L,6720L,5944L,2070L,355L,30L,1L,60480L,60216L,24574L,5265L,625L,39L,1L,604800L,662640L,305956L,77224L,11515L,1015L,49L,1L,6652800L,7893840L,4028156L,1155420L,203889L,22680L,1554L,60L,1L,79833600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143493Inst : IEnumerable<long>
{
public static readonly long[] Value=A143493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143493.Bytes);
public long this[int i]=>Value[i];

public static A143493Inst Instance=new A143493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143492
{
public static readonly long[] Value={ 1L,3L,1L,12L,7L,1L,60L,47L,12L,1L,360L,342L,119L,18L,1L,2520L,2754L,1175L,245L,25L,1L,20160L,24552L,12154L,3135L,445L,33L,1L,181440L,241128L,133938L,40369L,7140L,742L,42L,1L,1814400L,2592720L,1580508L,537628L,111769L,14560L,1162L,52L,1L,19958400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143492Inst : IEnumerable<long>
{
public static readonly long[] Value=A143492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143492.Bytes);
public long this[int i]=>Value[i];

public static A143492Inst Instance=new A143492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143491
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,1L,24L,26L,9L,1L,120L,154L,71L,14L,1L,720L,1044L,580L,155L,20L,1L,5040L,8028L,5104L,1665L,295L,27L,1L,40320L,69264L,48860L,18424L,4025L,511L,35L,1L,362880L,663696L,509004L,214676L,54649L,8624L,826L,44L,1L,3628800L,6999840L,5753736L,2655764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143491Inst : IEnumerable<long>
{
public static readonly long[] Value=A143491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143491.Bytes);
public long this[int i]=>Value[i];

public static A143491Inst Instance=new A143491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143490
{
public static readonly long[] Value={ 3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143490Inst : IEnumerable<long>
{
public static readonly long[] Value=A143490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143490.Bytes);
public long this[int i]=>Value[i];

public static A143490Inst Instance=new A143490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143489
{
public static readonly long[] Value={ 2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143489Inst : IEnumerable<long>
{
public static readonly long[] Value=A143489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143489.Bytes);
public long this[int i]=>Value[i];

public static A143489Inst Instance=new A143489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143488
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143488Inst : IEnumerable<long>
{
public static readonly long[] Value=A143488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143488.Bytes);
public long this[int i]=>Value[i];

public static A143488Inst Instance=new A143488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143487
{
public static readonly long[] Value={ 4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143487Inst : IEnumerable<long>
{
public static readonly long[] Value=A143487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143487.Bytes);
public long this[int i]=>Value[i];

public static A143487Inst Instance=new A143487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143486
{
public static readonly long[] Value={ 3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143486Inst : IEnumerable<long>
{
public static readonly long[] Value=A143486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143486.Bytes);
public long this[int i]=>Value[i];

public static A143486Inst Instance=new A143486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143485
{
public static readonly long[] Value={ 2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143485Inst : IEnumerable<long>
{
public static readonly long[] Value=A143485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143485.Bytes);
public long this[int i]=>Value[i];

public static A143485Inst Instance=new A143485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143484
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143484Inst : IEnumerable<long>
{
public static readonly long[] Value=A143484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143484.Bytes);
public long this[int i]=>Value[i];

public static A143484Inst Instance=new A143484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143483
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,8L,18L,20L,20L,24L,24L,24L,24L,32L,32L,36L,36L,40L,48L,60L,88L,96L,100L,120L,162L,168L,168L,176L,180L,192L,220L,256L,288L,288L,360L,360L,384L,400L,400L,432L,504L,560L,600L,616L,736L,736L,756L,800L,864L,864L,936L,936L,1000L,1008L,1008L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143483Inst : IEnumerable<long>
{
public static readonly long[] Value=A143483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143483.Bytes);
public long this[int i]=>Value[i];

public static A143483Inst Instance=new A143483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143482
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,12L,7L,16L,27L,50L,33L,72L,39L,56L,45L,64L,51L,108L,57L,100L,105L,154L,115L,288L,125L,286L,243L,392L,203L,690L,217L,416L,363L,544L,455L,864L,407L,836L,663L,1000L,451L,1512L,559L,1276L,1125L,1334L,799L,2256L,931L,2000L,1377L,1924L,1007L,2862L,1375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143482Inst : IEnumerable<long>
{
public static readonly long[] Value=A143482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143482.Bytes);
public long this[int i]=>Value[i];

public static A143482Inst Instance=new A143482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143481
{
public static readonly long[] Value={ 1L,2L,6L,8L,20L,24L,42L,48L,54L,64L,110L,112L,120L,132L,144L,160L,192L,216L,288L,320L,324L,360L,396L,416L,440L,480L,486L,504L,616L,624L,660L,672L,720L,736L,840L,864L,1008L,1044L,1104L,1120L,1200L,1224L,1260L,1280L,1296L,1320L,1380L,1408L,1512L,1560L,1632L,1680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143481Inst : IEnumerable<long>
{
public static readonly long[] Value=A143481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143481.Bytes);
public long this[int i]=>Value[i];

public static A143481Inst Instance=new A143481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143480
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,72L,49L,104L,81L,160L,121L,348L,143L,322L,285L,352L,221L,648L,323L,800L,567L,814L,437L,1272L,575L,1066L,729L,1204L,667L,2370L,713L,1376L,1221L,1598L,1225L,2592L,1073L,2242L,1833L,2840L,1271L,4326L,1333L,2816L,2565L,2806L,1457L,4272L,1813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143480Inst : IEnumerable<long>
{
public static readonly long[] Value=A143480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143480.Bytes);
public long this[int i]=>Value[i];

public static A143480Inst Instance=new A143480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143431
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143431Inst : IEnumerable<long>
{
public static readonly long[] Value=A143431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143431.Bytes);
public long this[int i]=>Value[i];

public static A143431Inst Instance=new A143431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143430
{
public static readonly long[] Value={ 7L,7L,43L,13L,43L,97L,43L,67L,193L,157L,31L,211L,61L,523L,73L,241L,13L,19L,97L,67L,13L,67L,157L,283L,193L,79L,157L,67L,151L,211L,67L,13L,7L,739L,109L,7L,151L,157L,73L,109L,61L,97L,223L,79L,157L,373L,109L,211L,193L,163L,67L,13L,31L,229L,19L,151L,31L,43L,31L,199L,7L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143430Inst : IEnumerable<long>
{
public static readonly long[] Value=A143430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143430.Bytes);
public long this[int i]=>Value[i];

public static A143430Inst Instance=new A143430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143429
{
public static readonly long[] Value={ 7L,7L,13L,13L,13L,13L,13L,31L,31L,19L,31L,7L,19L,7L,43L,7L,7L,13L,13L,7L,13L,61L,43L,7L,31L,37L,37L,13L,151L,19L,13L,13L,7L,67L,13L,7L,19L,13L,7L,13L,43L,73L,43L,19L,13L,67L,43L,13L,13L,7L,7L,13L,31L,73L,19L,7L,31L,43L,31L,67L,7L,31L,37L,13L,31L,7L,37L,7L,103L,43L,13L,13L,19L,13L,43L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143429Inst : IEnumerable<long>
{
public static readonly long[] Value=A143429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143429.Bytes);
public long this[int i]=>Value[i];

public static A143429Inst Instance=new A143429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143428
{
public static readonly long[] Value={ 53L,11L,11L,11L,17L,53L,197L,227L,11L,53L,17L,53L,23L,17L,179L,269L,47L,311L,17L,11L,59L,41L,11L,53L,137L,11L,83L,53L,59L,17L,47L,17L,11L,47L,173L,269L,23L,101L,11L,137L,443L,53L,107L,263L,11L,23L,251L,17L,137L,383L,479L,353L,107L,173L,71L,197L,17L,107L,101L,179L,89L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143428Inst : IEnumerable<long>
{
public static readonly long[] Value=A143428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143428.Bytes);
public long this[int i]=>Value[i];

public static A143428Inst Instance=new A143428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143427
{
public static readonly long[] Value={ 5L,5L,11L,11L,5L,5L,11L,23L,5L,11L,17L,41L,23L,5L,11L,17L,29L,17L,17L,11L,47L,41L,11L,11L,41L,11L,29L,41L,5L,11L,29L,17L,11L,5L,47L,17L,17L,53L,11L,5L,17L,17L,47L,29L,11L,23L,11L,5L,17L,5L,17L,29L,11L,17L,29L,11L,17L,5L,11L,17L,5L,17L,17L,29L,17L,17L,5L,23L,23L,11L,113L,17L,113L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143427Inst : IEnumerable<long>
{
public static readonly long[] Value=A143427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143427.Bytes);
public long this[int i]=>Value[i];

public static A143427Inst Instance=new A143427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143426
{
public static readonly long[] Value={ 1L,1L,2L,7L,32L,175L,1086L,7429L,54994L,435120L,3647686L,32192596L,297654824L,2872372828L,28841766844L,300592170551L,3244942353856L,36219458512421L,417365572999944L,4958429472475171L,60659660219655616L,763325035692109389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143426Inst : IEnumerable<long>
{
public static readonly long[] Value=A143426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143426.Bytes);
public long this[int i]=>Value[i];

public static A143426Inst Instance=new A143426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143425
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,4L,1L,2L,0L,8L,1L,0L,0L,0L,16L,1L,2L,4L,0L,0L,32L,1L,0L,0L,0L,0L,0L,64L,1L,2L,0L,8L,0L,0L,0L,128L,1L,0L,4L,0L,0L,0L,0L,0L,256L,1L,2L,0L,0L,16L,0L,0L,0L,0L,512L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1024L,1L,2L,4L,8L,0L,32L,0L,0L,0L,0L,0L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143425Inst : IEnumerable<long>
{
public static readonly long[] Value=A143425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143425.Bytes);
public long this[int i]=>Value[i];

public static A143425Inst Instance=new A143425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143424
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,0L,4L,0L,-2L,0L,8L,-1L,0L,0L,0L,16L,1L,-2L,-4L,0L,0L,32L,-1L,0L,0L,0L,0L,0L,64L,0L,0L,0L,-8L,0L,0L,0L,128L,0L,0L,-4L,0L,0L,0L,0L,0L,256L,1L,-2L,0L,0L,-16L,0L,0L,0L,0L,512L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1024L,0L,2L,0L,-8L,0L,-32L,0L,0L,0L,0L,0L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143424Inst : IEnumerable<long>
{
public static readonly long[] Value=A143424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143424.Bytes);
public long this[int i]=>Value[i];

public static A143424Inst Instance=new A143424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143423
{
public static readonly long[] Value={ 2L,4L,8L,14L,16L,22L,26L,32L,38L,44L,46L,52L,58L,62L,64L,74L,82L,86L,92L,94L,104L,106L,162L,116L,118L,122L,128L,134L,142L,146L,158L,164L,166L,172L,178L,188L,194L,202L,206L,212L,214L,218L,242L,226L,236L,244L,254L,256L,262L,268L,274L,278L,284L,292L,298L,302L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143423Inst : IEnumerable<long>
{
public static readonly long[] Value=A143423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143423.Bytes);
public long this[int i]=>Value[i];

public static A143423Inst Instance=new A143423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143422
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,1L,4L,5L,2L,3L,1L,7L,1L,1L,6L,5L,6L,2L,2L,1L,9L,1L,1L,2L,1L,5L,7L,1L,1L,11L,1L,8L,1L,4L,4L,2L,13L,2L,1L,2L,1L,5L,1L,4L,2L,11L,1L,8L,1L,4L,1L,1L,2L,16L,1L,1L,4L,10L,2L,2L,1L,8L,1L,6L,1L,5L,3L,1L,17L,1L,1L,5L,2L,3L,1L,2L,12L,3L,1L,6L,1L,1L,4L,1L,21L,1L,5L,9L,2L,1L,7L,1L,1L,3L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143422Inst : IEnumerable<long>
{
public static readonly long[] Value=A143422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143422.Bytes);
public long this[int i]=>Value[i];

public static A143422Inst Instance=new A143422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143421
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,3L,1L,1L,1L,3L,3L,2L,1L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,6L,1L,2L,1L,2L,2L,1L,4L,2L,1L,1L,1L,4L,1L,2L,1L,6L,1L,1L,1L,3L,1L,1L,1L,5L,1L,1L,3L,2L,2L,1L,1L,4L,1L,2L,1L,5L,1L,1L,4L,1L,1L,3L,1L,1L,1L,1L,7L,2L,1L,2L,1L,1L,2L,1L,10L,1L,4L,1L,1L,1L,3L,1L,1L,2L,4L,3L,1L,6L,1L,1L,1L,2L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143421Inst : IEnumerable<long>
{
public static readonly long[] Value=A143421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143421.Bytes);
public long this[int i]=>Value[i];

public static A143421Inst Instance=new A143421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143420
{
public static readonly long[] Value={ 1L,8L,55L,370L,2520L,15272L,123151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143420Inst : IEnumerable<long>
{
public static readonly long[] Value=A143420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143420.Bytes);
public long this[int i]=>Value[i];

public static A143420Inst Instance=new A143420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143419
{
public static readonly long[] Value={ 1L,-1L,1L,0L,1L,1L,1L,2L,2L,4L,4L,7L,9L,12L,17L,23L,32L,44L,60L,83L,113L,156L,214L,294L,403L,554L,760L,1044L,1433L,1967L,2701L,3708L,5091L,6988L,9596L,13172L,18085L,24828L,34086L,46797L,64246L,88203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143419Inst : IEnumerable<long>
{
public static readonly long[] Value=A143419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143419.Bytes);
public long this[int i]=>Value[i];

public static A143419Inst Instance=new A143419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143418
{
public static readonly long[] Value={ 1L,3L,3L,6L,15L,6L,10L,45L,45L,10L,15L,105L,190L,105L,15L,21L,210L,595L,595L,210L,21L,28L,378L,1540L,2415L,1540L,378L,28L,36L,630L,3486L,7875L,7875L,3486L,630L,36L,45L,980L,7140L,21945L,31626L,21945L,7140L,980L,45L,55L,1485L,27060L,54285L,106491L,106491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143418Inst : IEnumerable<long>
{
public static readonly long[] Value=A143418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143418.Bytes);
public long this[int i]=>Value[i];

public static A143418Inst Instance=new A143418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143417
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,24L,5L,10L,15L,16L,20L,30L,40L,48L,60L,80L,120L,240L,7L,9L,14L,18L,21L,28L,36L,42L,56L,63L,72L,84L,126L,168L,252L,504L,32L,96L,160L,480L,11L,22L,33L,44L,66L,88L,132L,264L,13L,26L,35L,39L,45L,52L,65L,70L,78L,90L,91L,104L,105L,112L,117L,130L,140L,144L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143417Inst : IEnumerable<long>
{
public static readonly long[] Value=A143417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143417.Bytes);
public long this[int i]=>Value[i];

public static A143417Inst Instance=new A143417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143416
{
public static readonly long[] Value={ 6L,21L,22L,57L,77L,161L,166L,201L,205L,221L,301L,309L,377L,437L,454L,497L,517L,597L,745L,749L,886L,901L,1057L,1357L,1457L,1461L,1469L,1517L,1577L,1841L,1961L,2021L,2041L,2077L,2182L,2317L,2361L,2537L,2701L,3046L,3097L,3397L,3437L,3497L,3737L,3841L,3901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143416Inst : IEnumerable<long>
{
public static readonly long[] Value=A143416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143416.Bytes);
public long this[int i]=>Value[i];

public static A143416Inst Instance=new A143416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143383
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,40L,240L,560L,13440L,120960L,241920L,887040L,394240L,138378240L,276756480L,593049600L,66421555200L,4136140800L,173717913600L,14302774886400L,171633298636800L,144171970854912L,7208598542745600L,283414985441280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143383Inst : IEnumerable<long>
{
public static readonly long[] Value=A143383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143383.Bytes);
public long this[int i]=>Value[i];

public static A143383Inst Instance=new A143383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143382
{
public static readonly long[] Value={ 1L,2L,5L,17L,71L,121L,731L,1711L,41099L,370019L,740101L,2713789L,1206137L,423355111L,846710651L,1814380259L,203210595443L,12654139763L,531473870981L,43758015399281L,525096184837561L,441080795274037L,22054039763790029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143382Inst : IEnumerable<long>
{
public static readonly long[] Value=A143382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143382.Bytes);
public long this[int i]=>Value[i];

public static A143382Inst Instance=new A143382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143381
{
public static readonly long[] Value={ 0L,2L,0L,6L,2L,0L,14L,30L,2L,0L,78L,230L,174L,2L,0L,230L,14094L,4834L,1092L,2L,0L,1902L,187106L,3785126L,114442L,7188L,2L,0L,6902L,26185806L,250560122L,1225289412L,2908990L,48852L,2L,0L,76110L,557115782L,682502468094L,423419180642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143381Inst : IEnumerable<long>
{
public static readonly long[] Value=A143381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143381.Bytes);
public long this[int i]=>Value[i];

public static A143381Inst Instance=new A143381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143380
{
public static readonly long[] Value={ 1L,2L,0L,0L,1L,-2L,0L,0L,-3L,0L,0L,0L,-2L,-2L,0L,0L,2L,-2L,0L,0L,-1L,2L,0L,0L,0L,2L,0L,0L,1L,2L,0L,0L,2L,-2L,0L,0L,4L,2L,0L,0L,-2L,0L,0L,0L,0L,2L,0L,0L,-1L,0L,0L,0L,-2L,0L,0L,0L,2L,-4L,0L,0L,-1L,-2L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,-2L,-2L,0L,0L,-2L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143380Inst : IEnumerable<long>
{
public static readonly long[] Value=A143380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143380.Bytes);
public long this[int i]=>Value[i];

public static A143380Inst Instance=new A143380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143379
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-1L,1L,1L,1L,-1L,1L,0L,1L,0L,0L,-2L,-1L,0L,0L,-1L,1L,1L,-2L,0L,0L,0L,1L,1L,0L,2L,0L,1L,-1L,-1L,0L,1L,-1L,0L,0L,1L,0L,-1L,-1L,0L,-1L,-1L,-1L,0L,0L,0L,1L,0L,1L,0L,1L,-1L,-1L,2L,0L,-1L,1L,-1L,1L,0L,3L,1L,-1L,0L,0L,0L,1L,-2L,0L,0L,-1L,-1L,0L,-1L,0L,1L,0L,0L,1L,-1L,-1L,-1L,0L,0L,0L,0L,-1L,0L,-2L,0L,1L,2L,1L,-1L,0L,2L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143379Inst : IEnumerable<long>
{
public static readonly long[] Value=A143379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143379.Bytes);
public long this[int i]=>Value[i];

public static A143379Inst Instance=new A143379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143378
{
public static readonly long[] Value={ 1L,1L,-3L,-2L,2L,-1L,0L,1L,2L,4L,-2L,0L,-1L,-2L,2L,-1L,0L,-2L,-2L,-2L,0L,0L,1L,4L,-2L,2L,1L,0L,-2L,0L,4L,0L,2L,0L,0L,1L,0L,-4L,0L,-2L,-3L,0L,2L,2L,-4L,0L,0L,2L,-2L,0L,-2L,-3L,2L,0L,2L,2L,0L,1L,4L,0L,0L,0L,2L,0L,0L,-4L,0L,2L,0L,2L,-1L,0L,0L,2L,-2L,2L,-2L,-1L,-2L,-4L,0L,0L,0L,-2L,-2L,0L,0L,2L,2L,-2L,2L,0L,1L,0L,0L,-2L,0L,0L,0L,-2L,5L,2L,-4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143378Inst : IEnumerable<long>
{
public static readonly long[] Value=A143378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143378.Bytes);
public long this[int i]=>Value[i];

public static A143378Inst Instance=new A143378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143377
{
public static readonly long[] Value={ 1L,-2L,0L,0L,1L,2L,0L,0L,-3L,0L,0L,0L,-2L,2L,0L,0L,2L,2L,0L,0L,-1L,-2L,0L,0L,0L,-2L,0L,0L,1L,-2L,0L,0L,2L,2L,0L,0L,4L,-2L,0L,0L,-2L,0L,0L,0L,0L,-2L,0L,0L,-1L,0L,0L,0L,-2L,0L,0L,0L,2L,4L,0L,0L,-1L,2L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,-2L,2L,0L,0L,-2L,-2L,0L,0L,0L,-2L,0L,0L,0L,4L,0L,0L,1L,0L,0L,0L,4L,0L,0L,0L,-2L,0L,0L,0L,2L,-2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143377Inst : IEnumerable<long>
{
public static readonly long[] Value=A143377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143377.Bytes);
public long this[int i]=>Value[i];

public static A143377Inst Instance=new A143377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143376
{
public static readonly long[] Value={ 1L,4L,2L,12L,12L,4L,32L,48L,32L,8L,80L,160L,160L,80L,16L,192L,480L,640L,480L,192L,32L,448L,1344L,2240L,2240L,1344L,448L,64L,1024L,3584L,7168L,8960L,7168L,3584L,1024L,128L,2304L,9216L,21504L,32256L,32256L,21504L,9216L,2304L,256L,5120L,23040L,61440L,107520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143376Inst : IEnumerable<long>
{
public static readonly long[] Value=A143376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143376.Bytes);
public long this[int i]=>Value[i];

public static A143376Inst Instance=new A143376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143375
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,1L,4L,2L,6L,8L,8L,19L,14L,34L,36L,54L,86L,93L,172L,194L,308L,427L,552L,878L,1076L,1675L,2224L,3120L,4546L,5986L,8928L,11933L,17104L,24005L,32928L,47534L,64640L,92523L,128348L,179418L,253994L,350622L,498000L,690790L,971508L,1362840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143375Inst : IEnumerable<long>
{
public static readonly long[] Value=A143375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143375.Bytes);
public long this[int i]=>Value[i];

public static A143375Inst Instance=new A143375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143374
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,1L,2L,-1L,2L,0L,-1L,0L,0L,0L,-2L,-2L,2L,-3L,-1L,1L,2L,3L,4L,1L,-3L,0L,-2L,3L,-4L,2L,0L,-1L,-1L,-2L,-1L,0L,-2L,-2L,2L,2L,-1L,0L,5L,-1L,5L,0L,2L,-3L,-3L,-3L,1L,3L,2L,2L,-2L,4L,-6L,-4L,2L,-2L,-1L,2L,-6L,0L,8L,-4L,-3L,2L,5L,1L,-6L,3L,6L,-1L,1L,-4L,-10L,1L,2L,-1L,2L,-5L,-2L,6L,13L,4L,1L,-1L,2L,1L,4L,-4L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143374Inst : IEnumerable<long>
{
public static readonly long[] Value=A143374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143374.Bytes);
public long this[int i]=>Value[i];

public static A143374Inst Instance=new A143374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143373
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,17L,30L,55L,100L,181L,330L,599L,1088L,1978L,3593L,6529L,11864L,21556L,39169L,71171L,129319L,234978L,426961L,775801L,1409655L,2561384L,4654113L,8456664L,15366012L,27920509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143373Inst : IEnumerable<long>
{
public static readonly long[] Value=A143373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143373.Bytes);
public long this[int i]=>Value[i];

public static A143373Inst Instance=new A143373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143372
{
public static readonly long[] Value={ 1L,-1L,3L,-4L,10L,-13L,27L,-38L,70L,-99L,173L,-242L,400L,-548L,869L,-1136L,1718L,-2088L,2936L,-3033L,3615L,-1763L,-513L,10082L,-24172L,58958L,-111749L,220258L,-385285L,693194L,-1157154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143372Inst : IEnumerable<long>
{
public static readonly long[] Value=A143372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143372.Bytes);
public long this[int i]=>Value[i];

public static A143372Inst Instance=new A143372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143371
{
public static readonly long[] Value={ 1L,8L,25L,56L,105L,176L,273L,400L,561L,760L,1001L,1288L,1625L,2016L,2465L,2976L,3553L,4200L,4921L,5720L,6601L,7568L,8625L,9776L,11025L,12376L,13833L,15400L,17081L,18880L,20801L,22848L,25025L,27336L,29785L,32376L,35113L,38000L,41041L,44240L,47601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143371Inst : IEnumerable<long>
{
public static readonly long[] Value=A143371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143371.Bytes);
public long this[int i]=>Value[i];

public static A143371Inst Instance=new A143371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143370
{
public static readonly long[] Value={ 1L,4L,2L,7L,6L,2L,10L,10L,6L,2L,13L,14L,10L,6L,2L,16L,18L,14L,10L,6L,2L,19L,22L,18L,14L,10L,6L,2L,22L,26L,22L,18L,14L,10L,6L,2L,25L,30L,26L,22L,18L,14L,10L,6L,2L,28L,34L,30L,26L,22L,18L,14L,10L,6L,2L,31L,38L,34L,30L,26L,22L,18L,14L,10L,6L,2L,34L,42L,38L,34L,30L,26L,22L,18L,14L,10L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143370Inst : IEnumerable<long>
{
public static readonly long[] Value=A143370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143370.Bytes);
public long this[int i]=>Value[i];

public static A143370Inst Instance=new A143370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143369
{
public static readonly long[] Value={ 36604L,304804L,2137492L,13143988L,73561204L,385003252L,1919944180L,9239885812L,43293991924L,198728338420L,897605155828L,4002258869236L,17658743397364L,77238940933108L,335382756072436L,1447262942927860L,6212030751579124L,26540148350000116L,112928927250390004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143369Inst : IEnumerable<long>
{
public static readonly long[] Value=A143369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143369.Bytes);
public long this[int i]=>Value[i];

public static A143369Inst Instance=new A143369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143368
{
public static readonly long[] Value={ 0L,1L,8L,4L,25L,72L,10L,56L,154L,320L,20L,105L,280L,570L,1000L,35L,176L,459L,920L,1595L,2520L,56L,273L,700L,1386L,2380L,3731L,5488L,84L,400L,1012L,1984L,3380L,5264L,7700L,10752L,120L,561L,1404L,2730L,4620L,7155L,10416L,14484L,19440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143368Inst : IEnumerable<long>
{
public static readonly long[] Value=A143368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143368.Bytes);
public long this[int i]=>Value[i];

public static A143368Inst Instance=new A143368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143335
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,1L,-2L,0L,-1L,-3L,2L,-6L,1L,-4L,-3L,-3L,-5L,-4L,-7L,-6L,-9L,-8L,-14L,-10L,-18L,-18L,-20L,-28L,-27L,-38L,-39L,-50L,-57L,-67L,-79L,-94L,-109L,-128L,-154L,-175L,-213L,-244L,-292L,-341L,-400L,-475L,-553L,-655L,-768L,-905L,-1062L,-1253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143335Inst : IEnumerable<long>
{
public static readonly long[] Value=A143335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143335.Bytes);
public long this[int i]=>Value[i];

public static A143335Inst Instance=new A143335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143334
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,5L,5L,1L,1L,8L,8L,8L,1L,1L,11L,12L,12L,11L,1L,1L,14L,13L,14L,13L,14L,1L,1L,17L,17L,17L,17L,17L,17L,1L,1L,20L,20L,20L,20L,20L,20L,20L,1L,1L,23L,24L,24L,24L,24L,24L,24L,23L,1L,1L,30L,29L,30L,30L,30L,30L,30L,29L,30L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143334Inst : IEnumerable<long>
{
public static readonly long[] Value=A143334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143334.Bytes);
public long this[int i]=>Value[i];

public static A143334Inst Instance=new A143334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143333
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,3L,3L,1L,1L,0L,0L,0L,1L,1L,5L,0L,0L,5L,1L,1L,0L,15L,0L,15L,0L,1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,9L,0L,0L,0L,0L,0L,0L,9L,1L,1L,0L,45L,0L,0L,0L,0L,0L,45L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143333Inst : IEnumerable<long>
{
public static readonly long[] Value=A143333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143333.Bytes);
public long this[int i]=>Value[i];

public static A143333Inst Instance=new A143333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143332
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,7L,12L,11L,31L,51L,44L,117L,216L,157L,453L,851L,566L,803L,788L,127L,859L,931L,440L,521L,432L,409L,809L,739L,458L,239L,828L,947L,391L,531L,148L,173L,360L,837L,61L,1011L,942L,475L,36L,375L,307L,579L,496L,145L,864L,689L,465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143332Inst : IEnumerable<long>
{
public static readonly long[] Value=A143332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143332.Bytes);
public long this[int i]=>Value[i];

public static A143332Inst Instance=new A143332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143331
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143331Inst : IEnumerable<long>
{
public static readonly long[] Value=A143331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143331.Bytes);
public long this[int i]=>Value[i];

public static A143331Inst Instance=new A143331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143330
{
public static readonly long[] Value={ 1L,1L,3L,8L,25L,83L,289L,1041L,3847L,14504L,55569L,215727L,846761L,3354858L,13398965L,53888063L,218053915L,887107888L,3626373205L,14887942624L,61358959587L,253771944529L,1052917272543L,4381374717994L,18280470530047L,76459765772375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143330Inst : IEnumerable<long>
{
public static readonly long[] Value=A143330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143330.Bytes);
public long this[int i]=>Value[i];

public static A143330Inst Instance=new A143330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143329
{
public static readonly long[] Value={ 3L,2L,7L,11L,19L,61L,47L,109L,73L,223L,211L,251L,239L,167L,151L,157L,137L,439L,421L,419L,499L,463L,331L,787L,827L,971L,991L,1009L,947L,911L,641L,647L,659L,701L,757L,613L,569L,521L,1549L,1663L,1747L,1789L,1697L,1667L,1933L,1951L,1877L,1291L,1367L,1531L,1447L,1451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143329Inst : IEnumerable<long>
{
public static readonly long[] Value=A143329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143329.Bytes);
public long this[int i]=>Value[i];

public static A143329Inst Instance=new A143329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143328
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,6L,5L,1L,5L,10L,14L,8L,1L,6L,15L,30L,32L,14L,1L,7L,21L,55L,90L,80L,23L,1L,8L,28L,91L,205L,294L,196L,41L,1L,9L,36L,140L,406L,829L,964L,508L,71L,1L,10L,45L,204L,728L,1960L,3409L,3304L,1318L,127L,1L,11L,55L,285L,1212L,4088L,9695L,14569L,11464L,3502L,226L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143328Inst : IEnumerable<long>
{
public static readonly long[] Value=A143328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143328.Bytes);
public long this[int i]=>Value[i];

public static A143328Inst Instance=new A143328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143327
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,5L,1L,1L,4L,11L,11L,1L,1L,5L,19L,35L,26L,1L,1L,6L,29L,79L,115L,53L,1L,1L,7L,41L,149L,334L,347L,116L,1L,1L,8L,55L,251L,773L,1339L,1075L,236L,1L,1L,9L,71L,391L,1546L,3869L,5434L,3235L,488L,1L,1L,10L,89L,575L,2791L,9281L,19493L,21754L,9787L,983L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143327Inst : IEnumerable<long>
{
public static readonly long[] Value=A143327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143327.Bytes);
public long this[int i]=>Value[i];

public static A143327Inst Instance=new A143327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143326
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,9L,10L,1L,5L,16L,33L,22L,1L,6L,25L,76L,105L,52L,1L,7L,36L,145L,316L,345L,106L,1L,8L,49L,246L,745L,1336L,1041L,232L,1L,9L,64L,385L,1506L,3865L,5356L,3225L,472L,1L,10L,81L,568L,2737L,9276L,19345L,21736L,9705L,976L,1L,11L,100L,801L,4600L,19537L,55686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143326Inst : IEnumerable<long>
{
public static readonly long[] Value=A143326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143326.Bytes);
public long this[int i]=>Value[i];

public static A143326Inst Instance=new A143326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143325
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,3L,0L,1L,3L,8L,6L,0L,1L,4L,15L,24L,15L,0L,1L,5L,24L,60L,80L,27L,0L,1L,6L,35L,120L,255L,232L,63L,0L,1L,7L,48L,210L,624L,1005L,728L,120L,0L,1L,8L,63L,336L,1295L,3096L,4095L,2160L,252L,0L,1L,9L,80L,504L,2400L,7735L,15624L,16320L,6552L,495L,0L,1L,10L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143325Inst : IEnumerable<long>
{
public static readonly long[] Value=A143325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143325.Bytes);
public long this[int i]=>Value[i];

public static A143325Inst Instance=new A143325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143324
{
public static readonly long[] Value={ 1L,2L,0L,3L,2L,0L,4L,6L,6L,0L,5L,12L,24L,12L,0L,6L,20L,60L,72L,30L,0L,7L,30L,120L,240L,240L,54L,0L,8L,42L,210L,600L,1020L,696L,126L,0L,9L,56L,336L,1260L,3120L,4020L,2184L,240L,0L,10L,72L,504L,2352L,7770L,15480L,16380L,6480L,504L,0L,11L,90L,720L,4032L,16800L,46410L,78120L,65280L,19656L,990L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143324Inst : IEnumerable<long>
{
public static readonly long[] Value=A143324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143324.Bytes);
public long this[int i]=>Value[i];

public static A143324Inst Instance=new A143324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143323
{
public static readonly long[] Value={ 1L,1L,-2L,-1L,1L,-2L,-2L,1L,3L,1L,0L,2L,0L,-2L,-2L,-1L,0L,3L,0L,-1L,4L,0L,-2L,-2L,1L,0L,-4L,2L,2L,-2L,0L,1L,0L,0L,-2L,-3L,0L,0L,0L,1L,2L,4L,-2L,0L,3L,-2L,-2L,2L,3L,1L,0L,0L,0L,-4L,0L,-2L,0L,2L,0L,2L,2L,0L,-6L,-1L,0L,0L,-2L,0L,4L,-2L,0L,3L,0L,0L,-2L,0L,0L,0L,0L,-1L,5L,2L,-2L,-4L,0L,-2L,-4L,0L,2L,3L,0L,2L,0L,-2L,0L,-2L,0L,3L,0L,-1L,2L,0L,-2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143323Inst : IEnumerable<long>
{
public static readonly long[] Value=A143323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143323.Bytes);
public long this[int i]=>Value[i];

public static A143323Inst Instance=new A143323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143322
{
public static readonly long[] Value={ 6L,21L,28L,36L,50L,96L,99L,216L,225L,301L,325L,352L,400L,441L,486L,495L,496L,576L,630L,676L,697L,784L,847L,925L,1225L,1296L,1333L,1521L,1536L,1587L,1695L,1701L,1792L,1909L,2025L,2041L,2133L,2145L,2500L,2601L,2624L,2916L,2926L,3025L,3200L,3220L,3276L,3456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143322Inst : IEnumerable<long>
{
public static readonly long[] Value=A143322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143322.Bytes);
public long this[int i]=>Value[i];

public static A143322Inst Instance=new A143322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143321
{
public static readonly long[] Value={ 15L,20L,24L,35L,54L,95L,98L,104L,119L,135L,143L,144L,160L,189L,207L,209L,224L,287L,319L,323L,324L,351L,363L,375L,377L,384L,390L,459L,464L,527L,539L,559L,608L,779L,845L,864L,875L,899L,923L,989L,999L,1000L,1007L,1029L,1189L,1199L,1215L,1280L,1343L,1349L,1375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143321Inst : IEnumerable<long>
{
public static readonly long[] Value=A143321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143321.Bytes);
public long this[int i]=>Value[i];

public static A143321Inst Instance=new A143321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143320
{
public static readonly long[] Value={ 1L,4L,-1L,8L,-1L,-1L,15L,-4L,-1L,0L,21L,-4L,-1L,0L,-1L,33L,-8L,-4L,0L,-1L,1L,41L,-8L,-4L,0L,-1L,1L,-1L,56L,-15L,-4L,0L,-1L,1L,-1L,0L,69L,-15L,-8L,0L,-1L,1L,-1L,0L,0L,87L,-21L,-8L,0L,-4L,1L,-1L,0L,0L,1L,99L,-21L,-8L,0L,-4L,1L,-1L,0L,0L,1L,-1L,127L,-33L,-15L,0L,-4L,4L,-1L,0L,0L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143320Inst : IEnumerable<long>
{
public static readonly long[] Value=A143320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143320.Bytes);
public long this[int i]=>Value[i];

public static A143320Inst Instance=new A143320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143271
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,6L,3L,6L,9L,12L,2L,4L,6L,8L,10L,4L,8L,12L,16L,20L,24L,2L,4L,6L,8L,10L,12L,14L,4L,8L,12L,16L,20L,24L,28L,32L,3L,6L,9L,12L,15L,18L,21L,24L,27L,4L,8L,12L,16L,20L,24L,28L,32L,36L,40L,2L,4L,6L,8L,10L,12L,146L,16L,18L,20L,22L,6L,12L,18L,24L,30L,36L,42L,48L,54L,60L,66L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143271Inst : IEnumerable<long>
{
public static readonly long[] Value=A143271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143271.Bytes);
public long this[int i]=>Value[i];

public static A143271Inst Instance=new A143271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143270
{
public static readonly long[] Value={ 1L,4L,12L,24L,50L,72L,126L,176L,252L,320L,462L,552L,754L,896L,1080L,1280L,1632L,1836L,2280L,2560L,2940L,3300L,3956L,4320L,5000L,5512L,6210L,6776L,7830L,8340L,9548L,10368L,11352L,12240L,13440L,14256L,15984L,17100L,18486L,19600L,21730L,22764L,25112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143270Inst : IEnumerable<long>
{
public static readonly long[] Value=A143270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143270.Bytes);
public long this[int i]=>Value[i];

public static A143270Inst Instance=new A143270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143269
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,6L,4L,4L,8L,8L,5L,5L,10L,10L,20L,6L,6L,12L,12L,24L,12L,7L,7L,14L,14L,28L,14L,42L,8L,8L,16L,16L,32L,16L,48L,32L,9L,9L,18L,18L,36L,18L,54L,36L,54L,10L,10L,20L,20L,40L,20L,60L,40L,60L,40L,11L,11L,22L,22L,44L,22L,66L,44L,66L,44L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143269Inst : IEnumerable<long>
{
public static readonly long[] Value=A143269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143269.Bytes);
public long this[int i]=>Value[i];

public static A143269Inst Instance=new A143269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143268
{
public static readonly long[] Value={ 1L,3L,12L,20L,60L,42L,168L,144L,270L,220L,660L,312L,1092L,630L,960L,1088L,2448L,1026L,3420L,1680L,2772L,2530L,6072L,2400L,6500L,4212L,6804L,4872L,12180L,3720L,14880L,8448L,11220L,9520L,15120L,7992L,25308L,13338L,18720L,13120L,34440L,10836L,39732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143268Inst : IEnumerable<long>
{
public static readonly long[] Value=A143268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143268.Bytes);
public long this[int i]=>Value[i];

public static A143268Inst Instance=new A143268Inst();

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