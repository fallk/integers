using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197405
{
public static readonly long[] Value={ 5L,71L,358L,3305L,25621L,199384L,1634731L,13013551L,103260478L,825286477L,6597403489L,52719871616L,421012069157L,3360781198751L,26839340562982L,214392512110323L,1712358386200271L,13675010695945780L,109210026376844947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197405Inst : IEnumerable<long>
{
public static readonly long[] Value=A197405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197405.Bytes);
public long this[int i]=>Value[i];

public static A197405Inst Instance=new A197405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197406
{
public static readonly long[] Value={ 9L,227L,1626L,25621L,356211L,4499426L,60334353L,801294395L,10631272297L,141478252511L,1877225887699L,24928405579380L,331380977085358L,4402455983432465L,58475570189400714L,776864156510384965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197406Inst : IEnumerable<long>
{
public static readonly long[] Value=A197406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197406.Bytes);
public long this[int i]=>Value[i];

public static A197406Inst Instance=new A197406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197407
{
public static readonly BigInteger[] Value={ 16L,664L,7232L,199384L,4499426L,93153650L,2065093081L,45796265386L,1003308210971L,22026879283832L,484764553481336L,10667288376795442L,234488008953014630L,5155498381464737047L,BigInteger.Parse("113400638560649259216") };
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
public class A197407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197407Inst Instance=new A197407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197408
{
public static readonly BigInteger[] Value={ 25L,2107L,34717L,1634731L,60334353L,2065093081L,77683473682L,2861267797023L,104224692369107L,3821001855576417L,140295906943370100L,5143358134125047217L,BigInteger.Parse("188539285472381998575"),BigInteger.Parse("6914680866283564114758"),BigInteger.Parse("253564501233044701809946") };
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
public class A197408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197408Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197408.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197408Inst Instance=new A197408Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197409
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,20L,20L,5L,9L,71L,60L,71L,9L,16L,227L,358L,358L,227L,16L,25L,664L,1626L,3305L,1626L,664L,25L,39L,2107L,7232L,25621L,25621L,7232L,2107L,39L,64L,6675L,34717L,199384L,356211L,199384L,34717L,6675L,64L,105L,20696L,160988L,1634731L,4499426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197409Inst : IEnumerable<long>
{
public static readonly long[] Value=A197409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197409.Bytes);
public long this[int i]=>Value[i];

public static A197409Inst Instance=new A197409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197410
{
public static readonly long[] Value={ 1L,3L,4L,21L,6L,216L,8L,315L,52L,432L,12L,80640L,14L,720L,864L,9765L,18L,176904L,20L,232848L,1408L,1512L,24L,149299200L,186L,2016L,2080L,460992L,30L,274827168L,32L,615195L,2880L,3240L,3744L,13333320000L,38L,3960L,3808L,680400000L,42L,702079488L,44L,1270080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197410Inst : IEnumerable<long>
{
public static readonly long[] Value=A197410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197410.Bytes);
public long this[int i]=>Value[i];

public static A197410Inst Instance=new A197410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197411
{
public static readonly long[] Value={ 2L,1L,9L,4L,2L,3L,2L,9L,1L,9L,0L,1L,6L,9L,1L,9L,1L,4L,4L,4L,7L,4L,1L,6L,4L,0L,9L,4L,9L,3L,4L,0L,8L,4L,2L,1L,5L,8L,8L,8L,0L,2L,1L,6L,0L,3L,0L,6L,8L,3L,7L,9L,9L,6L,9L,1L,4L,7L,7L,4L,8L,0L,0L,9L,3L,5L,2L,7L,5L,8L,6L,8L,6L,0L,7L,7L,7L,8L,5L,9L,5L,4L,3L,6L,7L,3L,0L,8L,6L,2L,5L,8L,2L,9L,9L,8L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197411Inst : IEnumerable<long>
{
public static readonly long[] Value=A197411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197411.Bytes);
public long this[int i]=>Value[i];

public static A197411Inst Instance=new A197411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197412
{
public static readonly long[] Value={ 3L,2L,8L,1L,3L,7L,2L,2L,9L,5L,3L,1L,1L,0L,4L,9L,8L,9L,9L,4L,2L,4L,7L,9L,8L,3L,5L,4L,8L,3L,9L,6L,1L,9L,2L,2L,0L,2L,2L,6L,2L,0L,6L,6L,2L,9L,3L,8L,6L,2L,2L,6L,7L,8L,2L,6L,3L,8L,5L,7L,0L,6L,9L,2L,5L,6L,4L,6L,8L,4L,3L,8L,5L,9L,1L,0L,5L,5L,0L,5L,4L,3L,1L,2L,1L,6L,5L,0L,7L,0L,0L,5L,7L,5L,8L,2L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197412Inst : IEnumerable<long>
{
public static readonly long[] Value=A197412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197412.Bytes);
public long this[int i]=>Value[i];

public static A197412Inst Instance=new A197412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197413
{
public static readonly long[] Value={ 1L,9L,6L,0L,6L,6L,9L,6L,5L,4L,5L,8L,7L,9L,3L,5L,5L,9L,3L,9L,5L,4L,4L,8L,6L,8L,8L,3L,3L,1L,5L,7L,6L,5L,6L,8L,5L,3L,1L,5L,9L,7L,0L,0L,2L,3L,6L,7L,6L,8L,2L,2L,3L,1L,5L,7L,7L,3L,5L,6L,1L,5L,0L,9L,2L,1L,7L,0L,1L,5L,8L,8L,6L,1L,8L,5L,3L,3L,8L,8L,4L,0L,0L,3L,4L,1L,5L,1L,5L,3L,0L,4L,5L,7L,7L,5L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197413Inst : IEnumerable<long>
{
public static readonly long[] Value=A197413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197413.Bytes);
public long this[int i]=>Value[i];

public static A197413Inst Instance=new A197413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197414
{
public static readonly long[] Value={ 1L,3L,3L,9L,6L,7L,6L,6L,2L,2L,8L,1L,7L,2L,7L,1L,4L,4L,4L,1L,6L,8L,1L,3L,5L,4L,0L,2L,5L,6L,6L,4L,9L,2L,1L,5L,6L,2L,3L,9L,6L,8L,8L,4L,2L,5L,0L,7L,6L,2L,7L,4L,1L,3L,6L,6L,6L,5L,9L,0L,0L,8L,3L,6L,9L,5L,1L,7L,3L,6L,7L,6L,8L,5L,6L,4L,8L,0L,8L,0L,4L,2L,1L,5L,2L,5L,6L,5L,4L,8L,8L,3L,3L,9L,5L,2L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197414Inst : IEnumerable<long>
{
public static readonly long[] Value=A197414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197414.Bytes);
public long this[int i]=>Value[i];

public static A197414Inst Instance=new A197414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197415
{
public static readonly long[] Value={ 0L,5L,8L,7L,7L,5L,0L,5L,6L,2L,2L,4L,6L,2L,9L,9L,5L,0L,9L,7L,7L,6L,4L,4L,1L,4L,2L,2L,4L,2L,5L,9L,4L,8L,4L,2L,4L,0L,9L,2L,7L,7L,4L,9L,0L,1L,9L,2L,7L,3L,1L,7L,9L,3L,6L,4L,3L,0L,6L,4L,7L,4L,3L,2L,6L,6L,6L,5L,3L,6L,9L,2L,4L,4L,8L,5L,1L,6L,4L,0L,7L,6L,4L,5L,9L,9L,9L,1L,5L,3L,3L,0L,2L,2L,3L,7L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197415Inst : IEnumerable<long>
{
public static readonly long[] Value=A197415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197415.Bytes);
public long this[int i]=>Value[i];

public static A197415Inst Instance=new A197415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197416
{
public static readonly long[] Value={ 3L,0L,8L,1L,3L,5L,0L,0L,0L,5L,8L,6L,8L,0L,2L,5L,0L,2L,1L,7L,6L,0L,9L,5L,6L,4L,7L,9L,0L,4L,4L,8L,6L,8L,6L,8L,8L,7L,7L,6L,7L,8L,8L,2L,0L,4L,0L,9L,0L,9L,1L,3L,1L,9L,6L,5L,0L,0L,7L,8L,7L,1L,5L,1L,2L,7L,8L,6L,8L,6L,2L,5L,5L,1L,6L,0L,9L,2L,3L,2L,5L,8L,7L,6L,2L,9L,5L,2L,4L,1L,8L,7L,9L,1L,8L,2L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197416Inst : IEnumerable<long>
{
public static readonly long[] Value=A197416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197416.Bytes);
public long this[int i]=>Value[i];

public static A197416Inst Instance=new A197416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197417
{
public static readonly long[] Value={ 3L,8L,0L,7L,9L,8L,4L,5L,0L,3L,8L,6L,1L,9L,1L,2L,5L,4L,6L,8L,0L,8L,5L,5L,5L,4L,4L,9L,1L,1L,1L,3L,6L,6L,4L,2L,2L,1L,9L,3L,6L,1L,3L,8L,3L,2L,0L,1L,4L,2L,5L,8L,3L,0L,4L,3L,5L,5L,0L,6L,7L,5L,4L,8L,6L,5L,9L,7L,6L,5L,7L,0L,8L,0L,0L,1L,4L,9L,2L,9L,4L,6L,2L,3L,0L,4L,7L,5L,5L,3L,0L,0L,5L,5L,5L,0L,9L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197417Inst : IEnumerable<long>
{
public static readonly long[] Value=A197417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197417.Bytes);
public long this[int i]=>Value[i];

public static A197417Inst Instance=new A197417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197418
{
public static readonly long[] Value={ 1L,4L,9L,5L,9L,0L,9L,5L,4L,6L,4L,3L,9L,9L,9L,4L,8L,5L,7L,4L,9L,6L,5L,7L,5L,1L,8L,6L,3L,1L,6L,9L,6L,8L,0L,9L,1L,1L,9L,8L,1L,3L,6L,9L,1L,3L,1L,7L,2L,9L,0L,6L,0L,5L,8L,0L,7L,1L,1L,0L,0L,7L,9L,7L,7L,0L,8L,4L,0L,5L,9L,6L,7L,6L,1L,5L,8L,4L,6L,4L,0L,5L,7L,9L,6L,1L,3L,1L,5L,9L,5L,9L,2L,5L,2L,3L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197418Inst : IEnumerable<long>
{
public static readonly long[] Value=A197418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197418.Bytes);
public long this[int i]=>Value[i];

public static A197418Inst Instance=new A197418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197419
{
public static readonly long[] Value={ 1L,-1L,1L,5L,-2L,1L,-1L,5L,-3L,1L,1L,-2L,5L,-4L,1L,1L,1L,-5L,25L,-5L,1L,-5L,1L,3L,-10L,25L,-6L,1L,-1L,-5L,7L,7L,-35L,35L,-7L,1L,7L,-4L,-10L,28L,7L,-28L,70L,-8L,1L,3L,21L,-6L,-10L,21L,63L,-42L,30L,-9L,1L,-15L,3L,21L,-20L,-25L,42L,21L,-60L,75L,-10L,1L,-5L,-15L,33L,77L,-55L,-55L,77L,33L,-165L,275L,-11L,1L,7601L,-10L,-45L,66L,231L,-132L,-110L,132L,99L,-110L,55L,-12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197419Inst : IEnumerable<long>
{
public static readonly long[] Value=A197419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197419.Bytes);
public long this[int i]=>Value[i];

public static A197419Inst Instance=new A197419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197420
{
public static readonly long[] Value={ 1L,1L,1L,6L,1L,1L,2L,2L,1L,1L,10L,1L,1L,1L,1L,6L,2L,1L,3L,1L,1L,42L,1L,2L,1L,2L,1L,1L,6L,6L,2L,2L,2L,2L,1L,1L,30L,3L,3L,3L,1L,1L,3L,1L,1L,10L,10L,1L,1L,1L,5L,1L,1L,1L,1L,22L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,6L,2L,2L,2L,1L,1L,1L,1L,2L,6L,1L,1L,2730L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197420Inst : IEnumerable<long>
{
public static readonly long[] Value=A197420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197420.Bytes);
public long this[int i]=>Value[i];

public static A197420Inst Instance=new A197420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197421
{
public static readonly long[] Value={ 44839L,60859L,130411L,204749L,303767L,902971L,1027969L,1471633L,2514257L,3658769L,6908719L,7415743L,21966317L,28168523L,32413109L,37049567L,44034163L,47856331L,373881787L,425445073L,443609813L,564963589L,732111109L,758871401L,857997893L,995046653L,2489902577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197421Inst : IEnumerable<long>
{
public static readonly long[] Value=A197421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197421.Bytes);
public long this[int i]=>Value[i];

public static A197421Inst Instance=new A197421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197422
{
public static readonly long[] Value={ 1103L,9281L,10949L,12157L,26921L,48757L,61949L,87407L,92459L,95923L,124087L,162859L,198811L,289417L,363809L,467183L,530983L,754981L,792307L,830677L,1124051L,1537373L,1662307L,1706251L,1830401L,2023183L,2507963L,2534879L,3358099L,3616721L,3912901L,3929707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197422Inst : IEnumerable<long>
{
public static readonly long[] Value=A197422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197422.Bytes);
public long this[int i]=>Value[i];

public static A197422Inst Instance=new A197422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197423
{
public static readonly long[] Value={ 1L,0L,3L,14L,5L,25L,69L,16L,20L,4L,34L,28L,41L,9L,8L,53L,73L,12L,7L,38L,46L,81L,13L,18L,120L,138L,6L,156L,186L,52L,31L,33L,14L,166L,98L,97L,96L,104L,35L,105L,27L,22L,93L,146L,5L,48L,55L,249L,15L,91L,37L,42L,187L,77L,90L,124L,352L,25L,110L,394L,89L,280L,69L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197423Inst : IEnumerable<long>
{
public static readonly long[] Value=A197423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197423.Bytes);
public long this[int i]=>Value[i];

public static A197423Inst Instance=new A197423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197424
{
public static readonly long[] Value={ 4L,36L,225L,1600L,10816L,74529L,509796L,3496900L,23961025L,164249856L,1125736704L,7716041281L,52886200900L,362488284900L,2484529385121L,17029223715904L,116720020119616L,800010960336225L,5483356589096100L,37583485459535236L,257601040852192129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197424Inst : IEnumerable<long>
{
public static readonly long[] Value=A197424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197424.Bytes);
public long this[int i]=>Value[i];

public static A197424Inst Instance=new A197424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197425
{
public static readonly long[] Value={ 1L,9L,68L,5197L,720447L,337295264L,529968166606L,2583340386672393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197425Inst : IEnumerable<long>
{
public static readonly long[] Value=A197425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197425.Bytes);
public long this[int i]=>Value[i];

public static A197425Inst Instance=new A197425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197426
{
public static readonly long[] Value={ 4L,20L,68L,448L,2152L,10684L,55567L,280544L,1425111L,7280350L,37165198L,189316196L,965915209L,4926863205L,25123365839L,128156345456L,653685106884L,3334114760247L,17006120383127L,86741818975198L,442435364449588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197426Inst : IEnumerable<long>
{
public static readonly long[] Value=A197426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197426.Bytes);
public long this[int i]=>Value[i];

public static A197426Inst Instance=new A197426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197427
{
public static readonly long[] Value={ 5L,71L,448L,5197L,43909L,410456L,4017895L,37566429L,351740354L,3301443327L,31135760775L,294213106126L,2771339919971L,26068700897789L,245447885397640L,2313251869240159L,21800440099050007L,205343629421991480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197427Inst : IEnumerable<long>
{
public static readonly long[] Value=A197427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197427.Bytes);
public long this[int i]=>Value[i];

public static A197427Inst Instance=new A197427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197428
{
public static readonly ulong[] Value={ 9L,227L,2152L,43909L,720447L,11769456L,195632425L,3187783369L,53026008675L,881220874951L,14498616415957L,239536136122464L,3969393711476942L,65665510796270903L,1084945281836331610L,17938093372334278851UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197428Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A197428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197428.Bytes);
public ulong this[int i]=>Value[i];

public static A197428Inst Instance=new A197428Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197429
{
public static readonly BigInteger[] Value={ 16L,664L,10684L,410456L,11769456L,337295264L,9869104795L,292706228390L,8642552356445L,253114165333694L,7454560598765350L,220113696023686560L,6476539750313171801L,BigInteger.Parse("190545665782624046543"),BigInteger.Parse("5615390905643680916267") };
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
public class A197429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197429Inst Instance=new A197429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197430
{
public static readonly BigInteger[] Value={ 25L,2107L,55567L,4017895L,195632425L,9869104795L,529968166606L,27927270266251L,1461399711177586L,76357681634837889L,4016048479413867754L,BigInteger.Parse("210995429397329769859"),BigInteger.Parse("11066069030221109085243"),BigInteger.Parse("581180575552246936955138") };
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
public class A197430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197430.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197430Inst Instance=new A197430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197431
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,20L,20L,5L,9L,71L,68L,71L,9L,16L,227L,448L,448L,227L,16L,25L,664L,2152L,5197L,2152L,664L,25L,39L,2107L,10684L,43909L,43909L,10684L,2107L,39L,64L,6675L,55567L,410456L,720447L,410456L,55567L,6675L,64L,105L,20696L,280544L,4017895L,11769456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197431Inst : IEnumerable<long>
{
public static readonly long[] Value=A197431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197431.Bytes);
public long this[int i]=>Value[i];

public static A197431Inst Instance=new A197431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197432
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,5L,6L,6L,7L,7L,8L,8L,9L,14L,15L,15L,16L,16L,17L,17L,18L,19L,20L,20L,21L,21L,22L,22L,23L,42L,43L,43L,44L,44L,45L,45L,46L,47L,48L,48L,49L,49L,50L,50L,51L,56L,57L,57L,58L,58L,59L,59L,60L,61L,62L,62L,63L,63L,64L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197432Inst : IEnumerable<long>
{
public static readonly long[] Value=A197432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197432.Bytes);
public long this[int i]=>Value[i];

public static A197432Inst Instance=new A197432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197433
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,14L,15L,16L,17L,19L,20L,21L,22L,42L,43L,44L,45L,47L,48L,49L,50L,56L,57L,58L,59L,61L,62L,63L,64L,132L,133L,134L,135L,137L,138L,139L,140L,146L,147L,148L,149L,151L,152L,153L,154L,174L,175L,176L,177L,179L,180L,181L,182L,188L,189L,190L,191L,193L,194L,195L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197433Inst : IEnumerable<long>
{
public static readonly long[] Value=A197433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197433.Bytes);
public long this[int i]=>Value[i];

public static A197433Inst Instance=new A197433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197434
{
public static readonly BigInteger[] Value={ 3L,34L,5032L,5184780L,41434710920L,2476133354164264L,BigInteger.Parse("1112998745351676081292") };
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
public class A197434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197434Inst Instance=new A197434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197435
{
public static readonly long[] Value={ 3L,6L,10L,28L,66L,164L,400L,982L,2406L,5898L,14456L,35434L,86852L,212884L,521802L,1278994L,3134954L,7684116L,18834610L,46165692L,113157168L,277360614L,679841246L,1666365362L,4084444032L,10011419722L,24539086364L,60147988628L,147429308586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197435Inst : IEnumerable<long>
{
public static readonly long[] Value=A197435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197435.Bytes);
public long this[int i]=>Value[i];

public static A197435Inst Instance=new A197435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197436
{
public static readonly long[] Value={ 6L,34L,246L,1736L,12450L,89528L,644328L,4638654L,33398106L,240473126L,1731475912L,12467176650L,89767756044L,646357555524L,4653989082594L,33510269018262L,241285084850682L,1737332890742456L,12509374882010702L,90071661504230880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197436Inst : IEnumerable<long>
{
public static readonly long[] Value=A197436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197436.Bytes);
public long this[int i]=>Value[i];

public static A197436Inst Instance=new A197436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197437
{
public static readonly BigInteger[] Value={ 10L,246L,5032L,98356L,1933358L,37989740L,746250884L,14659367358L,287967404918L,5656823960766L,111122501459806L,2182887521173568L,42880585565696148L,842345101555883176L,16547005149070978968UL,BigInteger.Parse("325048936455561795752") };
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
public class A197437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197437Inst Instance=new A197437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197438
{
public static readonly BigInteger[] Value={ 28L,1736L,98356L,5184780L,279785830L,15068331840L,811669674888L,43723066740718L,2355282493094894L,126874994917842426L,6834535322256736280L,BigInteger.Parse("368164567512212216530"),BigInteger.Parse("19832386906421976298012"),BigInteger.Parse("1068336297549353928162784") };
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
public class A197438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197438Inst Instance=new A197438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197439
{
public static readonly BigInteger[] Value={ 66L,12450L,1933358L,279785830L,41434710920L,6117749044788L,903529041581340L,133441483281347232L,BigInteger.Parse("19707781710109683796"),BigInteger.Parse("2910613305873428168598"),BigInteger.Parse("429864171311414595234150"),BigInteger.Parse("63486005383317296504335560") };
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
public class A197439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197439Inst Instance=new A197439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197440
{
public static readonly BigInteger[] Value={ 164L,89528L,37989740L,15068331840L,6117749044788L,2476133354164264L,1002605692717130692L,BigInteger.Parse("405955156856554399238"),BigInteger.Parse("164371431760256700590038"),BigInteger.Parse("66554100814528841770905242"),BigInteger.Parse("26947801511575118488851200530") };
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
public class A197440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197440Inst Instance=new A197440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197441
{
public static readonly BigInteger[] Value={ 400L,644328L,746250884L,811669674888L,903529041581340L,1002605692717130692L,BigInteger.Parse("1112998745351676081292"),BigInteger.Parse("1235511655153578238343970"),BigInteger.Parse("1371513250568819862402121642"),BigInteger.Parse("1522485346268679493501795851082") };
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
public class A197441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197441Inst Instance=new A197441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197442
{
public static readonly long[] Value={ 3L,6L,6L,10L,34L,10L,28L,246L,246L,28L,66L,1736L,5032L,1736L,66L,164L,12450L,98356L,98356L,12450L,164L,400L,89528L,1933358L,5184780L,1933358L,89528L,400L,982L,644328L,37989740L,279785830L,279785830L,37989740L,644328L,982L,2406L,4638654L,746250884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197442Inst : IEnumerable<long>
{
public static readonly long[] Value=A197442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197442.Bytes);
public long this[int i]=>Value[i];

public static A197442Inst Instance=new A197442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197443
{
public static readonly BigInteger[] Value={ 1L,5L,81L,4837L,1108699L,982926107L,3148323076125L,37516007592943532L,BigInteger.Parse("1657994465210882573048") };
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
public class A197443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197443Inst Instance=new A197443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197444
{
public static readonly long[] Value={ 2L,5L,12L,36L,107L,321L,957L,2868L,8581L,25694L,76914L,230273L,689377L,2063867L,6178778L,18498023L,55379290L,165794354L,496354537L,1485984549L,4448735449L,13318609060L,39873206463L,119372269782L,357376295102L,1069911935955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197444Inst : IEnumerable<long>
{
public static readonly long[] Value=A197444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197444.Bytes);
public long this[int i]=>Value[i];

public static A197444Inst Instance=new A197444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197445
{
public static readonly long[] Value={ 3L,12L,81L,474L,2678L,15410L,88767L,510482L,2936714L,16895217L,97197637L,559175541L,3216923150L,18506887013L,106469709385L,612517802024L,3523801014059L,20272347435052L,116626354899557L,670948774602366L,3859953085161367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197445Inst : IEnumerable<long>
{
public static readonly long[] Value=A197445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197445.Bytes);
public long this[int i]=>Value[i];

public static A197445Inst Instance=new A197445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197446
{
public static readonly long[] Value={ 4L,36L,474L,4837L,52117L,585194L,6455759L,71202438L,787298158L,8700460833L,96129107870L,1062244177133L,11737953179188L,129703872646573L,1433228960340464L,15837211757913841L,175001375414696401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197446Inst : IEnumerable<long>
{
public static readonly long[] Value=A197446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197446.Bytes);
public long this[int i]=>Value[i];

public static A197446Inst Instance=new A197446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197447
{
public static readonly BigInteger[] Value={ 7L,107L,2678L,52117L,1108699L,23829080L,504568165L,10724642167L,228248265080L,4853181015432L,103200753393047L,2194748772730124L,46673287485335449L,992547357156970890L,BigInteger.Parse("21107504726738892508"),BigInteger.Parse("448871249985110511395") };
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
public class A197447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197447Inst Instance=new A197447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197448
{
public static readonly BigInteger[] Value={ 11L,321L,15410L,585194L,23829080L,982926107L,40087361395L,1640477445822L,67160665746869L,2747685400705119L,112433629005651948L,4600917175526994358L,BigInteger.Parse("188267595598497672073"),BigInteger.Parse("7703877269427034462338"),BigInteger.Parse("315242428170240015474340") };
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
public class A197448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197448Inst Instance=new A197448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197449
{
public static readonly BigInteger[] Value={ 16L,957L,88767L,6455759L,504568165L,40087361395L,3148323076125L,247785141871837L,19514460176530843L,1536223846055481075L,BigInteger.Parse("120945067934443941208"),BigInteger.Parse("9522042330180130196817"),BigInteger.Parse("749659600975504964938552") };
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
public class A197449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197449Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197449.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197449Inst Instance=new A197449Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197450
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,12L,12L,4L,7L,36L,81L,36L,7L,11L,107L,474L,474L,107L,11L,16L,321L,2678L,4837L,2678L,321L,16L,26L,957L,15410L,52117L,52117L,15410L,957L,26L,41L,2868L,88767L,585194L,1108699L,585194L,88767L,2868L,41L,62L,8581L,510482L,6455759L,23829080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197450Inst : IEnumerable<long>
{
public static readonly long[] Value=A197450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197450.Bytes);
public long this[int i]=>Value[i];

public static A197450Inst Instance=new A197450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197451
{
public static readonly long[] Value={ 1L,7L,31L,583L,15825L,1097175L,168397471L,55114740895L,39081044835889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197451Inst : IEnumerable<long>
{
public static readonly long[] Value=A197451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197451.Bytes);
public long this[int i]=>Value[i];

public static A197451Inst Instance=new A197451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197452
{
public static readonly long[] Value={ 2L,10L,31L,84L,290L,923L,2887L,9216L,29288L,92868L,294893L,936361L,2972409L,9436595L,29959267L,95112260L,301956214L,958634094L,3043413512L,9662045566L,30674490204L,97383543481L,309167462063L,981526438497L,3116091639355L,9892781977749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197452Inst : IEnumerable<long>
{
public static readonly long[] Value=A197452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197452.Bytes);
public long this[int i]=>Value[i];

public static A197452Inst Instance=new A197452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197453
{
public static readonly long[] Value={ 3L,23L,84L,583L,2233L,10758L,53337L,252125L,1209824L,5768661L,27595593L,132068806L,631286751L,3018734589L,14435100274L,69026970467L,330080196953L,1578377336418L,7547555375561L,36091265919103L,172582773358524L,825263869695369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197453Inst : IEnumerable<long>
{
public static readonly long[] Value=A197453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197453.Bytes);
public long this[int i]=>Value[i];

public static A197453Inst Instance=new A197453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197454
{
public static readonly long[] Value={ 5L,57L,290L,2233L,15825L,104318L,738363L,5142371L,35673015L,248507899L,1727900136L,12019095470L,83618547829L,581654826801L,4046193710054L,28146680058973L,195796930694058L,1362027864550703L,9474705122664336L,65909095102841385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197454Inst : IEnumerable<long>
{
public static readonly long[] Value=A197454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197454.Bytes);
public long this[int i]=>Value[i];

public static A197454Inst Instance=new A197454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197455
{
public static readonly long[] Value={ 13L,275L,2887L,53337L,738363L,11014567L,168397471L,2499153985L,37543948067L,563650708913L,8446755201728L,126708291472793L,1900212948780127L,28496971166752387L,427384695145743821L,6409496691822202443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197455Inst : IEnumerable<long>
{
public static readonly long[] Value=A197455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197455.Bytes);
public long this[int i]=>Value[i];

public static A197455Inst Instance=new A197455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197456
{
public static readonly long[] Value={ 8L,122L,923L,10758L,104318L,1097175L,11014567L,112906556L,1151692226L,11746179526L,119887238727L,1222862832433L,12477649526031L,127300836703227L,1298804091935221L,13251229266573000L,135196822837023688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197456Inst : IEnumerable<long>
{
public static readonly long[] Value=A197456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197456.Bytes);
public long this[int i]=>Value[i];

public static A197456Inst Instance=new A197456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197457
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,10L,10L,3L,5L,23L,31L,23L,5L,8L,57L,84L,84L,57L,8L,13L,122L,290L,583L,290L,122L,13L,21L,275L,923L,2233L,2233L,923L,275L,21L,34L,623L,2887L,10758L,15825L,10758L,2887L,623L,34L,55L,1394L,9216L,53337L,104318L,104318L,53337L,9216L,1394L,55L,89L,3133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197457Inst : IEnumerable<long>
{
public static readonly long[] Value=A197457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197457.Bytes);
public long this[int i]=>Value[i];

public static A197457Inst Instance=new A197457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197458
{
public static readonly BigInteger[] Value={ 1L,2L,16L,265L,7343L,304186L,17525812L,1336221251L,129980132305L,15686404067098L,2297230134084416L,400977650310256537L,BigInteger.Parse("82188611938415464231"),BigInteger.Parse("19536244019455339261970"),BigInteger.Parse("5328019975275896220786388"),BigInteger.Parse("1651867356348327784988233291"),BigInteger.Parse("577522171260292028520919811777") };
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
public class A197458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197458Inst Instance=new A197458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197459
{
public static readonly long[] Value={ 1L,1L,3L,4L,12L,27L,78L,208L,635L,1859L,5726L,17526L,54620L,170479L,536714L,1694567L,5376764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197459Inst : IEnumerable<long>
{
public static readonly long[] Value=A197459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197459.Bytes);
public long this[int i]=>Value[i];

public static A197459Inst Instance=new A197459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197460
{
public static readonly long[] Value={ 1L,1L,4L,6L,19L,49L,143L,403L,1235L,3681L,11354L,34944L,108956L,340635L,1072593L,3388161L,10751029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197460Inst : IEnumerable<long>
{
public static readonly long[] Value=A197460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197460.Bytes);
public long this[int i]=>Value[i];

public static A197460Inst Instance=new A197460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197461
{
public static readonly long[] Value={ 3L,6L,14L,36L,99L,281L,816L,2415L,7260L,22074L,67743L,209552L,652566L,2043672L,6431715L,20328504L,64494678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197461Inst : IEnumerable<long>
{
public static readonly long[] Value=A197461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197461.Bytes);
public long this[int i]=>Value[i];

public static A197461Inst Instance=new A197461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197462
{
public static readonly long[] Value={ 1L,3L,3L,9L,14L,38L,74L,185L,414L,1026L,2440L,6077L,14926L,37454L,93749L,237035L,599815L,1526020L,3889117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197462Inst : IEnumerable<long>
{
public static readonly long[] Value=A197462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197462.Bytes);
public long this[int i]=>Value[i];

public static A197462Inst Instance=new A197462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197463
{
public static readonly long[] Value={ 2L,3L,6L,13L,28L,66L,148L,349L,828L,2005L,4880L,12043L,29852L,74645L,187498L,473448L,1199630L,3050554L,7778234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197463Inst : IEnumerable<long>
{
public static readonly long[] Value=A197463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197463.Bytes);
public long this[int i]=>Value[i];

public static A197463Inst Instance=new A197463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197464
{
public static readonly long[] Value={ 12L,18L,36L,75L,168L,386L,888L,2079L,4960L,11988L,29280L,72145L,179112L,447636L,1124956L,2840097L,7197780L,18301738L,46669404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197464Inst : IEnumerable<long>
{
public static readonly long[] Value=A197464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197464.Bytes);
public long this[int i]=>Value[i];

public static A197464Inst Instance=new A197464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197465
{
public static readonly long[] Value={ 1L,2L,2L,6L,8L,22L,42L,112L,252L,650L,1584L,4091L,10369L,26938L,69651L,182116L,476272L,1253067L,3302187L,8733551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197465Inst : IEnumerable<long>
{
public static readonly long[] Value=A197465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197465.Bytes);
public long this[int i]=>Value[i];

public static A197465Inst Instance=new A197465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197466
{
public static readonly long[] Value={ 1L,2L,3L,8L,14L,36L,80L,206L,494L,1259L,3144L,8085L,20676L,53635L,139144L,363630L,952148L,2504626L,6603367L,17463287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197466Inst : IEnumerable<long>
{
public static readonly long[] Value=A197466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197466.Bytes);
public long this[int i]=>Value[i];

public static A197466Inst Instance=new A197466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197467
{
public static readonly long[] Value={ 4L,6L,12L,25L,56L,132L,320L,792L,1976L,4962L,12576L,32140L,82704L,214044L,556576L,1453210L,3808592L,10015134L,26413468L,69844263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197467Inst : IEnumerable<long>
{
public static readonly long[] Value=A197467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197467.Bytes);
public long this[int i]=>Value[i];

public static A197467Inst Instance=new A197467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197468
{
public static readonly long[] Value={ 1L,2L,26L,184L,5408L,165200L,16544206L,2117012786L,779857304215L,396015611721478L,546971557228648382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197468Inst : IEnumerable<long>
{
public static readonly long[] Value=A197468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197468.Bytes);
public long this[int i]=>Value[i];

public static A197468Inst Instance=new A197468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197469
{
public static readonly long[] Value={ 1L,2L,6L,12L,24L,50L,98L,194L,394L,786L,1562L,3138L,6282L,12530L,25082L,50210L,100330L,200658L,401498L,802818L,1605450L,3211442L,6422714L,12844514L,25690282L,51381138L,102759194L,205520322L,411044874L,822081650L,1644162938L,3288342434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197469Inst : IEnumerable<long>
{
public static readonly long[] Value=A197469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197469.Bytes);
public long this[int i]=>Value[i];

public static A197469Inst Instance=new A197469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197470
{
public static readonly long[] Value={ 3L,6L,26L,46L,181L,374L,1300L,2886L,9446L,22060L,69096L,167466L,507600L,1265434L,3741192L,9529514L,27644128L,71580304L,204668940L,536641128L,1517618972L,4017418484L,11266355518L,30042504088L,83713614532L,224474050480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197470Inst : IEnumerable<long>
{
public static readonly long[] Value=A197470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197470.Bytes);
public long this[int i]=>Value[i];

public static A197470Inst Instance=new A197470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197471
{
public static readonly long[] Value={ 1L,12L,46L,184L,748L,2824L,10934L,42474L,164782L,638460L,2473902L,9589038L,37167908L,144059050L,558354234L,2164121964L,8387927204L,32510787510L,126008566828L,488396574430L,1892976376006L,7336987712088L,28437432700816L,110220652223106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197471Inst : IEnumerable<long>
{
public static readonly long[] Value=A197471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197471.Bytes);
public long this[int i]=>Value[i];

public static A197471Inst Instance=new A197471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197472
{
public static readonly long[] Value={ 4L,24L,181L,748L,5408L,22672L,151748L,684002L,4368923L,20344854L,126020110L,603916958L,3643523708L,17866994674L,105586791488L,527450827498L,3064686007756L,15542757419162L,89084044386061L,457335065118848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197472Inst : IEnumerable<long>
{
public static readonly long[] Value=A197472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197472.Bytes);
public long this[int i]=>Value[i];

public static A197472Inst Instance=new A197472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197473
{
public static readonly long[] Value={ 4L,50L,374L,2824L,22672L,165200L,1265828L,9507212L,72145488L,544829612L,4121917612L,31166838320L,235726500646L,1782712177744L,13482608699280L,101968288116918L,771180418816752L,5832406885650952L,44110365514811080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197473Inst : IEnumerable<long>
{
public static readonly long[] Value=A197473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197473.Bytes);
public long this[int i]=>Value[i];

public static A197473Inst Instance=new A197473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197474
{
public static readonly long[] Value={ 5L,98L,1300L,10934L,151748L,1265828L,16544206L,145244408L,1830370547L,16537658774L,202870487557L,1878224690406L,22527034080238L,212875475502774L,2505004507267645L,24087191716817350L,278905922435987885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197474Inst : IEnumerable<long>
{
public static readonly long[] Value=A197474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197474.Bytes);
public long this[int i]=>Value[i];

public static A197474Inst Instance=new A197474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197475
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,3L,1L,6L,6L,1L,4L,12L,26L,12L,4L,4L,24L,46L,46L,24L,4L,5L,50L,181L,184L,181L,50L,5L,8L,98L,374L,748L,748L,374L,98L,8L,9L,194L,1300L,2824L,5408L,2824L,1300L,194L,9L,13L,394L,2886L,10934L,22672L,22672L,10934L,2886L,394L,13L,17L,786L,9446L,42474L,151748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197475Inst : IEnumerable<long>
{
public static readonly long[] Value=A197475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197475.Bytes);
public long this[int i]=>Value[i];

public static A197475Inst Instance=new A197475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197476
{
public static readonly long[] Value={ 1L,1L,3L,7L,7L,4L,3L,9L,3L,2L,9L,0L,5L,4L,5L,5L,5L,5L,7L,7L,8L,9L,4L,4L,9L,8L,6L,0L,0L,5L,5L,0L,0L,8L,3L,4L,9L,5L,8L,4L,8L,0L,4L,2L,9L,0L,3L,4L,9L,5L,7L,5L,2L,7L,2L,0L,1L,5L,1L,8L,2L,5L,2L,6L,7L,3L,6L,0L,9L,8L,3L,4L,7L,3L,4L,7L,2L,7L,2L,1L,7L,7L,9L,8L,8L,0L,3L,2L,8L,0L,5L,1L,7L,6L,4L,4L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197476Inst : IEnumerable<long>
{
public static readonly long[] Value=A197476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197476.Bytes);
public long this[int i]=>Value[i];

public static A197476Inst Instance=new A197476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197477
{
public static readonly long[] Value={ 8L,4L,1L,8L,3L,5L,5L,3L,5L,6L,1L,4L,3L,6L,3L,8L,0L,7L,4L,8L,5L,7L,3L,2L,6L,7L,6L,5L,6L,2L,1L,6L,4L,3L,0L,7L,6L,5L,3L,5L,8L,5L,7L,8L,5L,5L,3L,3L,9L,3L,6L,3L,3L,0L,6L,4L,3L,9L,5L,3L,0L,8L,4L,2L,8L,3L,1L,2L,0L,2L,8L,3L,2L,1L,4L,7L,6L,8L,9L,1L,4L,5L,1L,4L,8L,3L,3L,7L,8L,4L,4L,7L,7L,7L,4L,5L,5L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197477Inst : IEnumerable<long>
{
public static readonly long[] Value=A197477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197477.Bytes);
public long this[int i]=>Value[i];

public static A197477Inst Instance=new A197477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197478
{
public static readonly long[] Value={ 6L,6L,5L,3L,7L,5L,3L,1L,9L,8L,2L,0L,6L,9L,4L,5L,9L,9L,9L,4L,1L,0L,9L,7L,6L,2L,4L,1L,4L,1L,6L,9L,7L,3L,2L,1L,2L,9L,4L,4L,4L,0L,0L,4L,9L,3L,7L,5L,9L,6L,0L,2L,5L,5L,6L,0L,6L,2L,0L,9L,0L,9L,6L,7L,4L,4L,0L,1L,3L,1L,7L,1L,1L,4L,8L,5L,3L,7L,9L,5L,5L,8L,6L,5L,1L,2L,8L,2L,4L,6L,6L,5L,1L,3L,5L,5L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197478Inst : IEnumerable<long>
{
public static readonly long[] Value=A197478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197478.Bytes);
public long this[int i]=>Value[i];

public static A197478Inst Instance=new A197478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197479
{
public static readonly long[] Value={ 6L,8L,1L,0L,8L,9L,8L,1L,8L,2L,4L,2L,8L,7L,4L,0L,0L,6L,1L,8L,5L,0L,5L,2L,8L,1L,6L,3L,2L,7L,8L,2L,8L,5L,2L,4L,9L,2L,5L,1L,8L,5L,8L,5L,6L,2L,5L,7L,5L,2L,2L,5L,5L,9L,6L,2L,2L,9L,7L,5L,8L,1L,5L,4L,8L,1L,2L,3L,5L,4L,3L,9L,3L,2L,9L,2L,9L,2L,8L,1L,4L,2L,2L,6L,5L,5L,2L,2L,7L,3L,7L,8L,6L,5L,8L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197479Inst : IEnumerable<long>
{
public static readonly long[] Value=A197479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197479.Bytes);
public long this[int i]=>Value[i];

public static A197479Inst Instance=new A197479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197480
{
public static readonly long[] Value={ 5L,6L,8L,8L,7L,1L,9L,6L,6L,4L,5L,2L,7L,2L,7L,7L,7L,8L,8L,9L,4L,7L,2L,4L,9L,3L,0L,0L,2L,7L,5L,0L,4L,1L,7L,4L,7L,9L,2L,4L,0L,2L,1L,4L,5L,1L,7L,4L,7L,8L,7L,6L,3L,6L,0L,0L,7L,5L,9L,1L,2L,6L,3L,3L,6L,8L,0L,4L,9L,1L,7L,3L,6L,7L,3L,6L,3L,6L,0L,8L,8L,9L,9L,4L,0L,1L,6L,4L,0L,2L,5L,8L,8L,2L,2L,3L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197480Inst : IEnumerable<long>
{
public static readonly long[] Value=A197480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197480.Bytes);
public long this[int i]=>Value[i];

public static A197480Inst Instance=new A197480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197481
{
public static readonly long[] Value={ 3L,7L,9L,2L,4L,7L,9L,7L,7L,6L,3L,5L,1L,5L,1L,8L,5L,2L,5L,9L,6L,4L,8L,3L,2L,8L,6L,6L,8L,5L,0L,0L,2L,7L,8L,3L,1L,9L,4L,9L,3L,4L,7L,6L,3L,4L,4L,9L,8L,5L,8L,4L,2L,4L,0L,0L,5L,0L,6L,0L,8L,4L,2L,2L,4L,5L,3L,6L,6L,1L,1L,5L,7L,8L,2L,4L,2L,4L,0L,5L,9L,3L,2L,9L,3L,4L,4L,2L,6L,8L,3L,9L,2L,1L,4L,9L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197481Inst : IEnumerable<long>
{
public static readonly long[] Value=A197481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197481.Bytes);
public long this[int i]=>Value[i];

public static A197481Inst Instance=new A197481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197482
{
public static readonly long[] Value={ 1L,8L,4L,3L,7L,6L,8L,1L,7L,6L,0L,3L,1L,7L,2L,1L,5L,6L,9L,6L,3L,9L,9L,3L,8L,4L,9L,7L,7L,2L,3L,6L,2L,1L,2L,7L,3L,1L,4L,5L,9L,9L,1L,3L,5L,1L,6L,5L,3L,9L,9L,3L,0L,9L,3L,2L,5L,4L,2L,7L,2L,3L,0L,7L,6L,3L,8L,2L,4L,4L,1L,3L,0L,1L,5L,3L,3L,2L,5L,3L,8L,9L,7L,4L,9L,9L,4L,1L,8L,9L,9L,1L,0L,2L,9L,9L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197482Inst : IEnumerable<long>
{
public static readonly long[] Value=A197482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197482.Bytes);
public long this[int i]=>Value[i];

public static A197482Inst Instance=new A197482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197483
{
public static readonly long[] Value={ 4L,8L,2L,3L,9L,5L,0L,9L,8L,8L,1L,1L,1L,2L,6L,5L,7L,7L,2L,3L,0L,9L,1L,1L,3L,9L,5L,0L,2L,4L,5L,6L,5L,4L,4L,2L,8L,4L,2L,0L,7L,8L,7L,1L,4L,4L,9L,5L,2L,9L,7L,2L,8L,3L,0L,9L,9L,1L,3L,5L,2L,3L,9L,6L,5L,1L,4L,0L,9L,1L,0L,6L,5L,4L,5L,6L,0L,9L,7L,1L,3L,1L,6L,8L,1L,7L,2L,4L,8L,9L,8L,7L,7L,6L,9L,3L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197483Inst : IEnumerable<long>
{
public static readonly long[] Value=A197483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197483.Bytes);
public long this[int i]=>Value[i];

public static A197483Inst Instance=new A197483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197484
{
public static readonly long[] Value={ 1L,1L,7L,93L,2584L,141328L,17631774L,4677852344L,2704563311389L,3400269169904466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197484Inst : IEnumerable<long>
{
public static readonly long[] Value=A197484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197484.Bytes);
public long this[int i]=>Value[i];

public static A197484Inst Instance=new A197484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197485
{
public static readonly long[] Value={ 3L,4L,0L,5L,4L,4L,9L,0L,9L,1L,2L,1L,4L,3L,7L,0L,0L,3L,0L,9L,2L,5L,2L,6L,4L,0L,8L,1L,6L,3L,9L,1L,4L,2L,6L,2L,4L,6L,2L,5L,9L,2L,9L,2L,8L,1L,2L,8L,7L,6L,1L,2L,7L,9L,8L,1L,1L,4L,8L,7L,9L,0L,7L,7L,4L,0L,6L,1L,7L,7L,1L,9L,6L,6L,4L,6L,4L,6L,4L,0L,7L,1L,1L,3L,2L,7L,6L,1L,3L,6L,8L,9L,3L,2L,9L,1L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197485Inst : IEnumerable<long>
{
public static readonly long[] Value=A197485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197485.Bytes);
public long this[int i]=>Value[i];

public static A197485Inst Instance=new A197485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197486
{
public static readonly long[] Value={ 2L,8L,4L,4L,3L,5L,9L,8L,3L,2L,2L,6L,3L,6L,3L,8L,8L,9L,4L,4L,7L,3L,6L,2L,4L,6L,5L,0L,1L,3L,7L,5L,2L,0L,8L,7L,3L,9L,6L,2L,0L,1L,0L,7L,2L,5L,8L,7L,3L,9L,3L,8L,1L,8L,0L,0L,3L,7L,9L,5L,6L,3L,1L,6L,8L,4L,0L,2L,4L,5L,8L,6L,8L,3L,6L,8L,1L,8L,0L,4L,4L,4L,9L,7L,0L,0L,8L,2L,0L,1L,2L,9L,4L,1L,1L,1L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197486Inst : IEnumerable<long>
{
public static readonly long[] Value=A197486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197486.Bytes);
public long this[int i]=>Value[i];

public static A197486Inst Instance=new A197486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197487
{
public static readonly long[] Value={ 2L,50L,12792L,30844560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197487Inst : IEnumerable<long>
{
public static readonly long[] Value=A197487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197487.Bytes);
public long this[int i]=>Value[i];

public static A197487Inst Instance=new A197487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197488
{
public static readonly long[] Value={ 9L,2L,1L,8L,8L,4L,0L,8L,8L,0L,1L,5L,8L,6L,0L,7L,8L,4L,8L,1L,9L,9L,6L,9L,2L,4L,8L,8L,6L,1L,8L,1L,0L,6L,3L,6L,5L,7L,2L,9L,9L,5L,6L,7L,5L,8L,2L,6L,9L,9L,6L,5L,4L,6L,6L,2L,7L,1L,3L,6L,1L,5L,3L,8L,1L,9L,1L,2L,2L,0L,6L,5L,0L,7L,6L,6L,6L,2L,6L,9L,4L,8L,7L,4L,9L,7L,0L,9L,4L,9L,5L,5L,1L,4L,9L,9L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197488Inst : IEnumerable<long>
{
public static readonly long[] Value=A197488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197488.Bytes);
public long this[int i]=>Value[i];

public static A197488Inst Instance=new A197488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197489
{
public static readonly long[] Value={ 2L,4L,1L,1L,9L,7L,5L,4L,9L,4L,0L,5L,5L,6L,3L,2L,8L,8L,6L,1L,5L,4L,5L,5L,6L,9L,7L,5L,1L,2L,2L,8L,2L,7L,2L,1L,4L,2L,1L,0L,3L,9L,3L,5L,7L,2L,4L,7L,6L,4L,8L,6L,4L,1L,5L,4L,9L,5L,6L,7L,6L,1L,9L,8L,2L,5L,7L,0L,4L,5L,5L,3L,2L,7L,2L,8L,0L,4L,8L,5L,6L,5L,8L,4L,0L,8L,6L,2L,4L,4L,9L,3L,8L,8L,4L,6L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197489Inst : IEnumerable<long>
{
public static readonly long[] Value=A197489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197489.Bytes);
public long this[int i]=>Value[i];

public static A197489Inst Instance=new A197489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197490
{
public static readonly long[] Value={ 5L,6L,4L,4L,2L,5L,4L,7L,6L,0L,6L,2L,6L,5L,9L,0L,9L,9L,3L,8L,4L,0L,0L,3L,2L,2L,8L,9L,3L,7L,7L,8L,8L,2L,9L,7L,6L,7L,7L,4L,9L,8L,5L,5L,2L,8L,2L,2L,8L,6L,1L,8L,0L,6L,1L,3L,5L,9L,1L,0L,5L,4L,9L,2L,1L,7L,4L,1L,1L,0L,3L,1L,7L,3L,3L,4L,6L,2L,5L,7L,9L,7L,5L,7L,0L,3L,5L,6L,1L,7L,0L,5L,0L,5L,5L,0L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197490Inst : IEnumerable<long>
{
public static readonly long[] Value=A197490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197490.Bytes);
public long this[int i]=>Value[i];

public static A197490Inst Instance=new A197490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197491
{
public static readonly long[] Value={ 5L,7L,8L,5L,4L,8L,9L,2L,5L,4L,2L,5L,7L,1L,8L,3L,8L,3L,2L,0L,4L,0L,7L,3L,6L,7L,3L,2L,4L,8L,8L,0L,2L,1L,1L,8L,2L,8L,6L,8L,1L,7L,0L,1L,7L,9L,2L,0L,6L,9L,1L,2L,1L,4L,6L,3L,7L,8L,2L,7L,3L,3L,1L,7L,8L,5L,0L,1L,2L,8L,6L,9L,6L,2L,4L,5L,6L,6L,9L,4L,3L,2L,0L,2L,7L,2L,4L,1L,7L,9L,2L,6L,8L,1L,8L,2L,6L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197491Inst : IEnumerable<long>
{
public static readonly long[] Value=A197491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197491.Bytes);
public long this[int i]=>Value[i];

public static A197491Inst Instance=new A197491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197492
{
public static readonly long[] Value={ 8L,1L,1L,4L,9L,3L,3L,2L,1L,5L,0L,2L,4L,9L,6L,4L,3L,0L,2L,3L,2L,1L,6L,9L,5L,5L,4L,1L,1L,6L,6L,1L,3L,8L,1L,0L,6L,4L,0L,0L,1L,9L,8L,7L,8L,3L,2L,4L,0L,9L,3L,7L,5L,1L,0L,6L,4L,1L,4L,0L,8L,0L,6L,9L,3L,2L,9L,2L,5L,7L,1L,3L,8L,8L,9L,0L,4L,4L,0L,1L,6L,0L,0L,9L,7L,1L,1L,4L,4L,6L,6L,4L,0L,1L,1L,5L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197492Inst : IEnumerable<long>
{
public static readonly long[] Value=A197492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197492.Bytes);
public long this[int i]=>Value[i];

public static A197492Inst Instance=new A197492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197493
{
public static readonly long[] Value={ 1L,3L,2L,6L,9L,8L,0L,0L,9L,2L,1L,1L,3L,2L,7L,4L,6L,4L,1L,5L,7L,9L,6L,7L,2L,3L,3L,3L,8L,3L,0L,3L,8L,0L,4L,2L,6L,6L,4L,3L,0L,0L,6L,5L,5L,9L,2L,9L,1L,7L,3L,6L,1L,2L,0L,1L,8L,7L,8L,5L,5L,7L,7L,6L,3L,4L,2L,1L,8L,6L,5L,6L,9L,5L,8L,4L,3L,8L,9L,3L,8L,4L,7L,3L,2L,9L,4L,3L,5L,3L,6L,8L,0L,5L,2L,7L,7L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197493Inst : IEnumerable<long>
{
public static readonly long[] Value=A197493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197493.Bytes);
public long this[int i]=>Value[i];

public static A197493Inst Instance=new A197493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197494
{
public static readonly long[] Value={ 1L,5L,6L,6L,0L,2L,3L,6L,1L,3L,6L,2L,2L,2L,8L,9L,7L,0L,2L,3L,0L,3L,8L,2L,0L,8L,2L,3L,9L,4L,8L,9L,4L,6L,1L,1L,0L,5L,0L,0L,2L,3L,7L,1L,8L,4L,2L,4L,8L,4L,9L,7L,1L,8L,2L,1L,8L,6L,5L,9L,9L,3L,4L,1L,5L,9L,8L,6L,8L,2L,4L,0L,3L,9L,2L,3L,5L,2L,3L,3L,2L,6L,4L,2L,1L,9L,4L,2L,2L,7L,2L,3L,3L,1L,9L,9L,4L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197494Inst : IEnumerable<long>
{
public static readonly long[] Value=A197494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197494.Bytes);
public long this[int i]=>Value[i];

public static A197494Inst Instance=new A197494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197495
{
public static readonly long[] Value={ 1L,2L,7L,8L,3L,9L,8L,3L,8L,5L,6L,7L,4L,4L,4L,9L,6L,8L,0L,8L,8L,7L,2L,9L,5L,7L,3L,2L,3L,0L,6L,8L,3L,6L,5L,7L,6L,6L,6L,8L,6L,4L,4L,2L,3L,6L,3L,9L,9L,7L,2L,8L,3L,4L,7L,5L,1L,2L,7L,9L,7L,8L,0L,9L,3L,3L,7L,8L,0L,5L,1L,8L,8L,6L,9L,9L,2L,4L,1L,1L,7L,0L,9L,4L,4L,9L,7L,8L,0L,2L,3L,2L,1L,9L,3L,7L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197495Inst : IEnumerable<long>
{
public static readonly long[] Value=A197495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197495.Bytes);
public long this[int i]=>Value[i];

public static A197495Inst Instance=new A197495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197496
{
public static readonly long[] Value={ 1L,1L,22L,181L,7845L,755338L,182232300L,122868970059L,214646199763320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197496Inst : IEnumerable<long>
{
public static readonly long[] Value=A197496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197496.Bytes);
public long this[int i]=>Value[i];

public static A197496Inst Instance=new A197496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197497
{
public static readonly long[] Value={ 1L,1L,9L,9L,19L,45L,73L,147L,291L,539L,1051L,2025L,3863L,7451L,14313L,27465L,52817L,101457L,194891L,374517L,719505L,1382347L,2655995L,5102835L,9804019L,18836497L,36190191L,69531891L,133591057L,256666833L,493131481L,947448537L,1820322627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197497Inst : IEnumerable<long>
{
public static readonly long[] Value=A197497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197497.Bytes);
public long this[int i]=>Value[i];

public static A197497Inst Instance=new A197497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197498
{
public static readonly long[] Value={ 1L,9L,22L,53L,162L,526L,1605L,5011L,15073L,46562L,143487L,440836L,1353988L,4162099L,12795741L,39330623L,120882310L,371559669L,1142099870L,3510484802L,10790188695L,33166049781L,101943428843L,313345715556L,963137000727L,2960415365620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197498Inst : IEnumerable<long>
{
public static readonly long[] Value=A197498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197498.Bytes);
public long this[int i]=>Value[i];

public static A197498Inst Instance=new A197498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197499
{
public static readonly long[] Value={ 1L,9L,53L,181L,967L,4447L,20411L,99367L,473509L,2249979L,10740561L,51245685L,244406613L,1165674879L,5559988993L,26520385505L,126494970513L,603345410731L,2877810161871L,13726438785461L,65471603280973L,312282907797439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197499Inst : IEnumerable<long>
{
public static readonly long[] Value=A197499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197499.Bytes);
public long this[int i]=>Value[i];

public static A197499Inst Instance=new A197499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197500
{
public static readonly long[] Value={ 1L,19L,162L,967L,7845L,58434L,462825L,3560859L,27478512L,213540131L,1655543599L,12828732416L,99455874997L,771029045491L,5977169558845L,46336520563805L,359215034469100L,2784731837712288L,21587977565996803L,167356072621226437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197500Inst : IEnumerable<long>
{
public static readonly long[] Value=A197500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197500.Bytes);
public long this[int i]=>Value[i];

public static A197500Inst Instance=new A197500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197501
{
public static readonly long[] Value={ 1L,45L,526L,4447L,58434L,755338L,9343735L,115041017L,1444324039L,18148792772L,226805049125L,2837702507896L,35532382009820L,444833549598339L,5568581339404147L,69708374269567517L,872630491310203892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197501Inst : IEnumerable<long>
{
public static readonly long[] Value=A197501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197501.Bytes);
public long this[int i]=>Value[i];

public static A197501Inst Instance=new A197501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197502
{
public static readonly BigInteger[] Value={ 1L,73L,1605L,20411L,462825L,9343735L,182232300L,3721024215L,75873083886L,1533554674879L,31095240897403L,631619193851873L,12815959990096973L,260019107905052450L,5276671977231304874L,BigInteger.Parse("107080511710187498485") };
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
public class A197502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197502Inst Instance=new A197502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197503
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,9L,1L,1L,9L,22L,9L,1L,1L,19L,53L,53L,19L,1L,1L,45L,162L,181L,162L,45L,1L,1L,73L,526L,967L,967L,526L,73L,1L,1L,147L,1605L,4447L,7845L,4447L,1605L,147L,1L,1L,291L,5011L,20411L,58434L,58434L,20411L,5011L,291L,1L,1L,539L,15073L,99367L,462825L,755338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197503Inst : IEnumerable<long>
{
public static readonly long[] Value=A197503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197503.Bytes);
public long this[int i]=>Value[i];

public static A197503Inst Instance=new A197503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197504
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,19L,23L,27L,31L,43L,47L,49L,59L,67L,71L,79L,81L,83L,103L,107L,121L,127L,131L,139L,151L,163L,167L,179L,191L,199L,211L,223L,227L,239L,243L,251L,263L,271L,283L,307L,311L,331L,343L,347L,359L,361L,367L,379L,383L,419L,431L,439L,443L,463L,467L,479L,487L,491L,499L,503L,523L,529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197504Inst : IEnumerable<long>
{
public static readonly long[] Value=A197504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197504.Bytes);
public long this[int i]=>Value[i];

public static A197504Inst Instance=new A197504Inst();

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