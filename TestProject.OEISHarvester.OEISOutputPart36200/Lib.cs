using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A008338
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,288L,34560L,48L,241920L,6L,2177280L,7900913664000L,BigInteger.Parse("315379190543155200000"),658409472000L,BigInteger.Parse("4099929477061017600000"),47029248000L,BigInteger.Parse("61498942155915264000000"),2939328000L,BigInteger.Parse("1045482016650559488000000"),163296000L };
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
public class A008338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008338Inst Instance=new A008338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008337
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,15L,27L,40L,63L,91L,134L,188L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008337Inst : IEnumerable<long>
{
public static readonly long[] Value=A008337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008337.Bytes);
public long this[int i]=>Value[i];

public static A008337Inst Instance=new A008337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008336
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,20L,140L,1120L,10080L,1008L,11088L,924L,12012L,858L,12870L,205920L,3500640L,194480L,3695120L,184756L,3879876L,176358L,4056234L,97349616L,2433740400L,93605400L,2527345800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008336Inst : IEnumerable<long>
{
public static readonly long[] Value=A008336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008336.Bytes);
public long this[int i]=>Value[i];

public static A008336Inst Instance=new A008336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008335
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,2L,2L,3L,1L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,3L,3L,1L,3L,3L,3L,3L,2L,2L,2L,3L,3L,3L,3L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,2L,3L,2L,3L,3L,3L,2L,3L,2L,2L,3L,3L,3L,3L,2L,3L,3L,2L,4L,2L,3L,3L,4L,2L,2L,3L,3L,3L,3L,2L,4L,2L,3L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008335Inst : IEnumerable<long>
{
public static readonly long[] Value=A008335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008335.Bytes);
public long this[int i]=>Value[i];

public static A008335Inst Instance=new A008335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008334
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,1L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,3L,3L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,3L,2L,3L,3L,2L,2L,2L,2L,3L,3L,2L,2L,3L,4L,3L,2L,3L,2L,3L,3L,2L,1L,2L,2L,3L,3L,3L,3L,2L,3L,3L,3L,2L,4L,3L,2L,3L,2L,2L,3L,3L,3L,2L,2L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,2L,2L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008334Inst : IEnumerable<long>
{
public static readonly long[] Value=A008334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008334.Bytes);
public long this[int i]=>Value[i];

public static A008334Inst Instance=new A008334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008317
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,7L,20L,8L,27L,28L,8L,33L,110L,72L,16L,143L,182L,88L,16L,715L,2600L,2160L,832L,128L,3315L,4760L,2992L,960L,128L,4199L,16150L,15504L,7904L,2176L,256L,20349L,31654L,23408L,10080L,2432L,256L,52003L,208012L,220248L,133952L,50048L,10752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008317Inst : IEnumerable<long>
{
public static readonly long[] Value=A008317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008317.Bytes);
public long this[int i]=>Value[i];

public static A008317Inst Instance=new A008317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008316
{
public static readonly long[] Value={ 1L,1L,-1L,3L,-3L,5L,3L,-30L,35L,15L,-70L,63L,-5L,105L,-315L,231L,-35L,315L,-693L,429L,35L,-1260L,6930L,-12012L,6435L,315L,-4620L,18018L,-25740L,12155L,-63L,3465L,-30030L,90090L,-109395L,46189L,-693L,15015L,-90090L,218790L,-230945L,88179L,231L,-18018L,225225L,-1021020L,2078505L,-1939938L,676039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008316Inst : IEnumerable<long>
{
public static readonly long[] Value=A008316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008316.Bytes);
public long this[int i]=>Value[i];

public static A008316Inst Instance=new A008316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008315
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,1L,4L,5L,1L,5L,9L,5L,1L,6L,14L,14L,1L,7L,20L,28L,14L,1L,8L,27L,48L,42L,1L,9L,35L,75L,90L,42L,1L,10L,44L,110L,165L,132L,1L,11L,54L,154L,275L,297L,132L,1L,12L,65L,208L,429L,572L,429L,1L,13L,77L,273L,637L,1001L,1001L,429L,1L,14L,90L,350L,910L,1638L,2002L,1430L,1L,15L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008315Inst : IEnumerable<long>
{
public static readonly long[] Value=A008315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008315.Bytes);
public long this[int i]=>Value[i];

public static A008315Inst Instance=new A008315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008314
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,4L,3L,1L,5L,10L,1L,6L,15L,10L,1L,7L,21L,35L,1L,8L,28L,56L,35L,1L,9L,36L,84L,126L,1L,10L,45L,120L,210L,126L,1L,11L,55L,165L,330L,462L,1L,12L,66L,220L,495L,792L,462L,1L,13L,78L,286L,715L,1287L,1716L,1L,14L,91L,364L,1001L,2002L,3003L,1716L,1L,15L,105L,455L,1365L,3003L,5005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008314Inst : IEnumerable<long>
{
public static readonly long[] Value=A008314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008314.Bytes);
public long this[int i]=>Value[i];

public static A008314Inst Instance=new A008314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008313
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,1L,5L,4L,1L,5L,9L,5L,1L,14L,14L,6L,1L,14L,28L,20L,7L,1L,42L,48L,27L,8L,1L,42L,90L,75L,35L,9L,1L,132L,165L,110L,44L,10L,1L,132L,297L,275L,154L,54L,11L,1L,429L,572L,429L,208L,65L,12L,1L,429L,1001L,1001L,637L,273L,77L,13L,1L,1430L,2002L,1638L,910L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008313Inst : IEnumerable<long>
{
public static readonly long[] Value=A008313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008313.Bytes);
public long this[int i]=>Value[i];

public static A008313Inst Instance=new A008313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008312
{
public static readonly long[] Value={ 1L,2L,-1L,4L,-4L,8L,1L,-12L,16L,6L,-32L,32L,-1L,24L,-80L,64L,-8L,80L,-192L,128L,1L,-40L,240L,-448L,256L,10L,-160L,672L,-1024L,512L,-1L,60L,-560L,1792L,-2304L,1024L,-12L,280L,-1792L,4608L,-5120L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008312Inst : IEnumerable<long>
{
public static readonly long[] Value=A008312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008312.Bytes);
public long this[int i]=>Value[i];

public static A008312Inst Instance=new A008312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008311
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,3L,4L,1L,10L,5L,1L,10L,15L,6L,1L,35L,21L,7L,1L,35L,56L,28L,8L,1L,126L,84L,36L,9L,1L,126L,210L,120L,45L,10L,1L,462L,330L,165L,55L,11L,1L,462L,792L,495L,220L,66L,12L,1L,1716L,1287L,715L,286L,78L,13L,1L,1716L,3003L,2002L,1001L,364L,91L,14L,1L,6435L,5005L,3003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008311Inst : IEnumerable<long>
{
public static readonly long[] Value=A008311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008311.Bytes);
public long this[int i]=>Value[i];

public static A008311Inst Instance=new A008311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008310
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-3L,4L,1L,-8L,8L,5L,-20L,16L,-1L,18L,-48L,32L,-7L,56L,-112L,64L,1L,-32L,160L,-256L,128L,9L,-120L,432L,-576L,256L,-1L,50L,-400L,1120L,-1280L,512L,-11L,220L,-1232L,2816L,-2816L,1024L,1L,-72L,840L,-3584L,6912L,-6144L,2048L,13L,-364L,2912L,-9984L,16640L,-13312L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008310Inst : IEnumerable<long>
{
public static readonly long[] Value=A008310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008310.Bytes);
public long this[int i]=>Value[i];

public static A008310Inst Instance=new A008310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008309
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-8L,1L,24L,-20L,1L,184L,-40L,1L,-720L,784L,-70L,1L,-8448L,2464L,-112L,1L,40320L,-52352L,6384L,-168L,1L,648576L,-229760L,14448L,-240L,1L,-3628800L,5360256L,-804320L,29568L,-330L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008309Inst : IEnumerable<long>
{
public static readonly long[] Value=A008309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008309.Bytes);
public long this[int i]=>Value[i];

public static A008309Inst Instance=new A008309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008308
{
public static readonly long[] Value={ 1L,1L,2L,1L,8L,1L,16L,20L,1L,136L,40L,1L,272L,616L,70L,1L,3968L,2016L,112L,1L,7936L,28160L,5376L,168L,1L,176896L,135680L,12432L,240L,1L,353792L,1805056L,508640L,25872L,330L,1L,11184128L,11977856L,1595264L,49632L,440L,1L,22368256L,154918400L,59835776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008308Inst : IEnumerable<long>
{
public static readonly long[] Value=A008308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008308.Bytes);
public long this[int i]=>Value[i];

public static A008308Inst Instance=new A008308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008307
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,1L,1L,1L,10L,3L,2L,1L,1L,26L,9L,4L,1L,1L,1L,76L,21L,16L,1L,2L,1L,1L,232L,81L,56L,1L,6L,1L,1L,1L,764L,351L,256L,25L,18L,1L,2L,1L,1L,2620L,1233L,1072L,145L,66L,1L,4L,1L,1L,1L,9496L,5769L,6224L,505L,396L,1L,16L,3L,2L,1L,1L,35696L,31041L,33616L,1345L,2052L,1L,56L,9L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008307Inst : IEnumerable<long>
{
public static readonly long[] Value=A008307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008307.Bytes);
public long this[int i]=>Value[i];

public static A008307Inst Instance=new A008307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008306
{
public static readonly long[] Value={ 1L,2L,6L,3L,24L,20L,120L,130L,15L,720L,924L,210L,5040L,7308L,2380L,105L,40320L,64224L,26432L,2520L,362880L,623376L,303660L,44100L,945L,3628800L,6636960L,3678840L,705320L,34650L,39916800L,76998240L,47324376L,11098780L,866250L,10395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008306Inst : IEnumerable<long>
{
public static readonly long[] Value=A008306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008306.Bytes);
public long this[int i]=>Value[i];

public static A008306Inst Instance=new A008306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008305
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,6L,1L,2L,9L,24L,1L,2L,13L,44L,120L,1L,2L,20L,80L,265L,720L,1L,2L,31L,144L,579L,1854L,5040L,1L,2L,49L,264L,1265L,4738L,14833L,40320L,1L,2L,78L,484L,2783L,12072L,43387L,133496L,362880L,1L,2L,125L,888L,6208L,30818L,126565L,439792L,1334961L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008305Inst : IEnumerable<long>
{
public static readonly long[] Value=A008305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008305.Bytes);
public long this[int i]=>Value[i];

public static A008305Inst Instance=new A008305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008304
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,16L,6L,1L,1L,69L,41L,8L,1L,1L,348L,293L,67L,10L,1L,1L,2016L,2309L,602L,99L,12L,1L,1L,13357L,19975L,5811L,1024L,137L,14L,1L,1L,99376L,189524L,60875L,11304L,1602L,181L,16L,1L,1L,822040L,1960041L,690729L,133669L,19710L,2360L,231L,18L,1L,1L,7477161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008304Inst : IEnumerable<long>
{
public static readonly long[] Value=A008304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008304.Bytes);
public long this[int i]=>Value[i];

public static A008304Inst Instance=new A008304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008303
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,16L,16L,88L,16L,32L,416L,272L,64L,1824L,2880L,272L,128L,7680L,24576L,7936L,256L,31616L,185856L,137216L,7936L,512L,128512L,1304832L,1841152L,353792L,1024L,518656L,8728576L,21253376L,9061376L,353792L,2048L,2084864L,56520704L,222398464L,175627264L,22368256L,4096L,8361984L,357888000L,2174832640L,2868264960L,795300864L,22368256L,8192L,33497088L,2230947840L,20261765120L,41731645440L,21016670208L,1903757312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008303Inst : IEnumerable<long>
{
public static readonly long[] Value=A008303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008303.Bytes);
public long this[int i]=>Value[i];

public static A008303Inst Instance=new A008303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008302
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,3L,5L,6L,5L,3L,1L,1L,4L,9L,15L,20L,22L,20L,15L,9L,4L,1L,1L,5L,14L,29L,49L,71L,90L,101L,101L,90L,71L,49L,29L,14L,5L,1L,1L,6L,20L,49L,98L,169L,259L,359L,455L,531L,573L,573L,531L,455L,359L,259L,169L,98L,49L,20L,6L,1L,1L,7L,27L,76L,174L,343L,602L,961L,1415L,1940L,2493L,3017L,3450L,3736L,3836L,3736L,3450L,3017L,2493L,1940L,1415L,961L,602L,343L,174L,76L,27L,7L,1L,1L,8L,35L,111L,285L,628L,1230L,2191L,3606L,5545L,8031L,11021L,14395L,17957L,21450L,24584L,27073L,28675L,29228L,28675L,27073L,24584L,21450L,17957L,14395L,11021L,8031L,5545L,3606L,2191L,1230L,628L,285L,111L,35L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008302Inst : IEnumerable<long>
{
public static readonly long[] Value=A008302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008302.Bytes);
public long this[int i]=>Value[i];

public static A008302Inst Instance=new A008302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008301
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,8L,10L,8L,4L,34L,68L,94L,104L,94L,68L,34L,496L,992L,1420L,1712L,1816L,1712L,1420L,992L,496L,11056L,22112L,32176L,40256L,45496L,47312L,45496L,40256L,32176L,22112L,11056L,349504L,699008L,1026400L,1309568L,1528384L,1666688L,1714000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008301Inst : IEnumerable<long>
{
public static readonly long[] Value=A008301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008301.Bytes);
public long this[int i]=>Value[i];

public static A008301Inst Instance=new A008301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008300
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,6L,1L,1L,24L,90L,24L,1L,1L,120L,2040L,2040L,120L,1L,1L,720L,67950L,297200L,67950L,720L,1L,1L,5040L,3110940L,68938800L,68938800L,3110940L,5040L,1L,1L,40320L,187530840L,24046189440L,116963796250L,24046189440L,187530840L,40320L,1L,1L,362880L,14398171200L,12025780892160L,315031400802720L,315031400802720L,12025780892160L,14398171200L,362880L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008300Inst : IEnumerable<long>
{
public static readonly long[] Value=A008300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008300.Bytes);
public long this[int i]=>Value[i];

public static A008300Inst Instance=new A008300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008299
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,10L,1L,25L,15L,1L,56L,105L,1L,119L,490L,105L,1L,246L,1918L,1260L,1L,501L,6825L,9450L,945L,1L,1012L,22935L,56980L,17325L,1L,2035L,74316L,302995L,190575L,10395L,1L,4082L,235092L,1487200L,1636635L,270270L,1L,8177L,731731L,6914908L,12122110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008299Inst : IEnumerable<long>
{
public static readonly long[] Value=A008299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008299.Bytes);
public long this[int i]=>Value[i];

public static A008299Inst Instance=new A008299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008298
{
public static readonly long[] Value={ 1L,3L,1L,8L,9L,1L,42L,59L,18L,1L,144L,450L,215L,30L,1L,1440L,3394L,2475L,565L,45L,1L,5760L,30912L,28294L,9345L,1225L,63L,1L,75600L,293292L,340116L,147889L,27720L,2338L,84L,1L,524160L,3032208L,4335596L,2341332L,579369L,69552L,4074L,108L,1L,6531840L,36290736L,57773700L,38049920L,11744775L,1857513L,154350L,6630L,135L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008298Inst : IEnumerable<long>
{
public static readonly long[] Value=A008298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008298.Bytes);
public long this[int i]=>Value[i];

public static A008298Inst Instance=new A008298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008297
{
public static readonly long[] Value={ -1L,2L,1L,-6L,-6L,-1L,24L,36L,12L,1L,-120L,-240L,-120L,-20L,-1L,720L,1800L,1200L,300L,30L,1L,-5040L,-15120L,-12600L,-4200L,-630L,-42L,-1L,40320L,141120L,141120L,58800L,11760L,1176L,56L,1L,-362880L,-1451520L,-1693440L,-846720L,-211680L,-28224L,-2016L,-72L,-1L,3628800L,16329600L,21772800L,12700800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008297Inst : IEnumerable<long>
{
public static readonly long[] Value=A008297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008297.Bytes);
public long this[int i]=>Value[i];

public static A008297Inst Instance=new A008297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008296
{
public static readonly long[] Value={ 1L,1L,1L,-1L,3L,1L,2L,-1L,6L,1L,-6L,0L,5L,10L,1L,24L,4L,-15L,25L,15L,1L,-120L,-28L,49L,-35L,70L,21L,1L,720L,188L,-196L,49L,0L,154L,28L,1L,-5040L,-1368L,944L,0L,-231L,252L,294L,36L,1L,40320L,11016L,-5340L,-820L,1365L,-987L,1050L,510L,45L,1L,-362880L,-98208L,34716L,9020L,-7645L,3003L,-1617L,2970L,825L,55L,1L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008296Inst : IEnumerable<long>
{
public static readonly long[] Value=A008296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008296.Bytes);
public long this[int i]=>Value[i];

public static A008296Inst Instance=new A008296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008295
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,5L,9L,9L,4L,13L,34L,64L,64L,9L,35L,119L,326L,625L,625L,20L,95L,401L,1433L,4016L,7776L,7776L,48L,262L,1316L,5799L,21256L,60387L,117649L,117649L,115L,727L,4247L,22224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008295Inst : IEnumerable<long>
{
public static readonly long[] Value=A008295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008295.Bytes);
public long this[int i]=>Value[i];

public static A008295Inst Instance=new A008295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008294
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,6L,5L,28L,24L,61L,180L,120L,61L,662L,1320L,720L,1385L,7266L,10920L,5040L,1385L,24568L,83664L,100800L,40320L,50521L,408360L,1023120L,1028160L,362880L,50521L,1326122L,6749040L,13335840L,11491200L,3628800L,2702765L,30974526L,113760240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008294Inst : IEnumerable<long>
{
public static readonly long[] Value=A008294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008294.Bytes);
public long this[int i]=>Value[i];

public static A008294Inst Instance=new A008294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008293
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,8L,6L,16L,40L,24L,16L,136L,240L,120L,272L,1232L,1680L,720L,272L,3968L,12096L,13440L,5040L,7936L,56320L,129024L,120960L,40320L,7936L,176896L,814080L,1491840L,1209600L,362880L,353792L,3610112L,12207360L,18627840L,13305600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008293Inst : IEnumerable<long>
{
public static readonly long[] Value=A008293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008293.Bytes);
public long this[int i]=>Value[i];

public static A008293Inst Instance=new A008293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008292
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,11L,11L,1L,1L,26L,66L,26L,1L,1L,57L,302L,302L,57L,1L,1L,120L,1191L,2416L,1191L,120L,1L,1L,247L,4293L,15619L,15619L,4293L,247L,1L,1L,502L,14608L,88234L,156190L,88234L,14608L,502L,1L,1L,1013L,47840L,455192L,1310354L,1310354L,455192L,47840L,1013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008292Inst : IEnumerable<long>
{
public static readonly long[] Value=A008292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008292.Bytes);
public long this[int i]=>Value[i];

public static A008292Inst Instance=new A008292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008291
{
public static readonly long[] Value={ 1L,2L,3L,9L,8L,6L,44L,45L,20L,10L,265L,264L,135L,40L,15L,1854L,1855L,924L,315L,70L,21L,14833L,14832L,7420L,2464L,630L,112L,28L,133496L,133497L,66744L,22260L,5544L,1134L,168L,36L,1334961L,1334960L,667485L,222480L,55650L,11088L,1890L,240L,45L,14684570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008291Inst : IEnumerable<long>
{
public static readonly long[] Value=A008291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008291.Bytes);
public long this[int i]=>Value[i];

public static A008291Inst Instance=new A008291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008290
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,3L,0L,1L,9L,8L,6L,0L,1L,44L,45L,20L,10L,0L,1L,265L,264L,135L,40L,15L,0L,1L,1854L,1855L,924L,315L,70L,21L,0L,1L,14833L,14832L,7420L,2464L,630L,112L,28L,0L,1L,133496L,133497L,66744L,22260L,5544L,1134L,168L,36L,0L,1L,1334961L,1334960L,667485L,222480L,55650L,11088L,1890L,240L,45L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008290Inst : IEnumerable<long>
{
public static readonly long[] Value=A008290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008290.Bytes);
public long this[int i]=>Value[i];

public static A008290Inst Instance=new A008290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008289
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,3L,2L,1L,4L,3L,1L,4L,4L,1L,1L,5L,5L,1L,1L,5L,7L,2L,1L,6L,8L,3L,1L,6L,10L,5L,1L,7L,12L,6L,1L,1L,7L,14L,9L,1L,1L,8L,16L,11L,2L,1L,8L,19L,15L,3L,1L,9L,21L,18L,5L,1L,9L,24L,23L,7L,1L,10L,27L,27L,10L,1L,1L,10L,30L,34L,13L,1L,1L,11L,33L,39L,18L,2L,1L,11L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008289Inst : IEnumerable<long>
{
public static readonly long[] Value=A008289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008289.Bytes);
public long this[int i]=>Value[i];

public static A008289Inst Instance=new A008289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008288
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,7L,13L,7L,1L,1L,9L,25L,25L,9L,1L,1L,11L,41L,63L,41L,11L,1L,1L,13L,61L,129L,129L,61L,13L,1L,1L,15L,85L,231L,321L,231L,85L,15L,1L,1L,17L,113L,377L,681L,681L,377L,113L,17L,1L,1L,19L,145L,575L,1289L,1683L,1289L,575L,145L,19L,1L,1L,21L,181L,833L,2241L,3653L,3653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008288Inst : IEnumerable<long>
{
public static readonly long[] Value=A008288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008288.Bytes);
public long this[int i]=>Value[i];

public static A008288Inst Instance=new A008288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008287
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,4L,3L,2L,1L,1L,3L,6L,10L,12L,12L,10L,6L,3L,1L,1L,4L,10L,20L,31L,40L,44L,40L,31L,20L,10L,4L,1L,1L,5L,15L,35L,65L,101L,135L,155L,155L,135L,101L,65L,35L,15L,5L,1L,1L,6L,21L,56L,120L,216L,336L,456L,546L,580L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008287Inst : IEnumerable<long>
{
public static readonly long[] Value=A008287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008287.Bytes);
public long this[int i]=>Value[i];

public static A008287Inst Instance=new A008287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008286
{
public static readonly long[] Value={ 1L,2L,5L,14L,61L,320L,3037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008286Inst : IEnumerable<long>
{
public static readonly long[] Value=A008286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008286.Bytes);
public long this[int i]=>Value[i];

public static A008286Inst Instance=new A008286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008269
{
public static readonly BigInteger[] Value={ 1L,2L,9L,112L,2921L,126966L,8204497L,735944084L,87394386417L,13265365173706L,2504688393449081L,575664638548522392L,BigInteger.Parse("158222202503521622809"),BigInteger.Parse("51242608446417388426622"),BigInteger.Parse("19312113111034490954560641") };
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
public class A008269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008269Inst Instance=new A008269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008268
{
public static readonly long[] Value={ 1L,4L,10L,23L,47L,83L,127L,174L,221L,276L,356L,428L,494L,603L,698L,781L,912L,1035L,1131L,1289L,1435L,1542L,1735L,1903L,2014L,2245L,2435L,2556L,2817L,3032L,3160L,3459L,3694L,3824L,4166L,4426L,4551L,4937L,5222L,5345L,5771L,6083L,6204L,6675L,7004L,7125L,7645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008268Inst : IEnumerable<long>
{
public static readonly long[] Value=A008268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008268.Bytes);
public long this[int i]=>Value[i];

public static A008268Inst Instance=new A008268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008267
{
public static readonly long[] Value={ 1L,4L,10L,22L,47L,83L,125L,171L,215L,288L,349L,415L,518L,591L,674L,816L,904L,1002L,1177L,1271L,1388L,1617L,1710L,1840L,2112L,2204L,2358L,2684L,2769L,2939L,3314L,3391L,3581L,4023L,4084L,4287L,4791L,4833L,5054L,5633L,5655L,5893L,6533L,6526L,6788L,7513L,7479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008267Inst : IEnumerable<long>
{
public static readonly long[] Value=A008267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008267.Bytes);
public long this[int i]=>Value[i];

public static A008267Inst Instance=new A008267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008266
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,48L,67L,92L,120L,150L,185L,224L,266L,312L,361L,414L,472L,532L,595L,664L,736L,810L,889L,972L,1058L,1148L,1241L,1338L,1440L,1544L,1651L,1764L,1880L,1998L,2121L,2248L,2378L,2512L,2649L,2790L,2936L,3084L,3235L,3392L,3552L,3714L,3881L,4052L,4226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008266Inst : IEnumerable<long>
{
public static readonly long[] Value=A008266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008266.Bytes);
public long this[int i]=>Value[i];

public static A008266Inst Instance=new A008266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008265
{
public static readonly long[] Value={ 1L,4L,11L,22L,37L,59L,85L,114L,147L,184L,230L,280L,331L,386L,445L,515L,589L,662L,739L,820L,914L,1012L,1107L,1206L,1309L,1427L,1549L,1666L,1787L,1912L,2054L,2200L,2339L,2482L,2629L,2795L,2965L,3126L,3291L,3460L,3650L,3844L,4027L,4214L,4405L,4619L,4837L,5042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008265Inst : IEnumerable<long>
{
public static readonly long[] Value=A008265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008265.Bytes);
public long this[int i]=>Value[i];

public static A008265Inst Instance=new A008265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008264
{
public static readonly long[] Value={ 1L,4L,12L,25L,44L,67L,96L,130L,170L,214L,264L,319L,380L,445L,516L,592L,674L,760L,852L,949L,1052L,1159L,1272L,1390L,1514L,1642L,1776L,1915L,2060L,2209L,2364L,2524L,2690L,2860L,3036L,3217L,3404L,3595L,3792L,3994L,4202L,4414L,4632L,4855L,5084L,5317L,5556L,5800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008264Inst : IEnumerable<long>
{
public static readonly long[] Value=A008264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008264.Bytes);
public long this[int i]=>Value[i];

public static A008264Inst Instance=new A008264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008263
{
public static readonly long[] Value={ 1L,4L,11L,26L,43L,58L,90L,132L,159L,196L,257L,308L,352L,418L,495L,568L,637L,712L,810L,910L,993L,1092L,1213L,1324L,1432L,1550L,1681L,1830L,1961L,2076L,2238L,2416L,2547L,2692L,2887L,3068L,3224L,3394L,3595L,3808L,3987L,4160L,4396L,4632L,4811L,5022L,5281L,5514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008263Inst : IEnumerable<long>
{
public static readonly long[] Value=A008263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008263.Bytes);
public long this[int i]=>Value[i];

public static A008263Inst Instance=new A008263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008262
{
public static readonly long[] Value={ 1L,4L,11L,20L,40L,68L,93L,120L,157L,206L,254L,299L,355L,430L,495L,549L,633L,735L,813L,886L,995L,1111L,1207L,1306L,1434L,1573L,1687L,1798L,1949L,2114L,2243L,2377L,2552L,2727L,2879L,3036L,3224L,3426L,3604L,3766L,3977L,4212L,4397L,4578L,4819L,5067L,5270L,5478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008262Inst : IEnumerable<long>
{
public static readonly long[] Value=A008262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008262.Bytes);
public long this[int i]=>Value[i];

public static A008262Inst Instance=new A008262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008261
{
public static readonly long[] Value={ 1L,4L,12L,30L,52L,80L,116L,156L,204L,258L,318L,384L,458L,536L,622L,714L,812L,916L,1028L,1144L,1268L,1398L,1534L,1676L,1826L,1980L,2142L,2310L,2484L,2664L,2852L,3044L,3244L,3450L,3662L,3880L,4106L,4336L,4574L,4818L,5068L,5324L,5588L,5856L,6132L,6414L,6702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008261Inst : IEnumerable<long>
{
public static readonly long[] Value=A008261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008261.Bytes);
public long this[int i]=>Value[i];

public static A008261Inst Instance=new A008261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008260
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,57L,81L,109L,142L,180L,222L,268L,318L,373L,433L,497L,565L,637L,714L,796L,882L,972L,1066L,1165L,1269L,1377L,1489L,1605L,1726L,1852L,1982L,2116L,2254L,2397L,2545L,2697L,2853L,3013L,3178L,3348L,3522L,3700L,3882L,4069L,4261L,4457L,4657L,4861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008260Inst : IEnumerable<long>
{
public static readonly long[] Value=A008260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008260.Bytes);
public long this[int i]=>Value[i];

public static A008260Inst Instance=new A008260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008259
{
public static readonly long[] Value={ 1L,4L,11L,24L,41L,62L,90L,122L,157L,200L,247L,296L,354L,416L,479L,552L,629L,706L,794L,886L,977L,1080L,1187L,1292L,1410L,1532L,1651L,1784L,1921L,2054L,2202L,2354L,2501L,2664L,2831L,2992L,3170L,3352L,3527L,3720L,3917L,4106L,4314L,4526L,4729L,4952L,5179L,5396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008259Inst : IEnumerable<long>
{
public static readonly long[] Value=A008259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008259.Bytes);
public long this[int i]=>Value[i];

public static A008259Inst Instance=new A008259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008258
{
public static readonly long[] Value={ 1L,4L,10L,24L,40L,64L,90L,120L,160L,200L,244L,300L,354L,412L,484L,552L,624L,712L,794L,880L,984L,1080L,1180L,1300L,1410L,1524L,1660L,1784L,1912L,2064L,2202L,2344L,2512L,2664L,2820L,3004L,3170L,3340L,3540L,3720L,3904L,4120L,4314L,4512L,4744L,4952L,5164L,5412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008258Inst : IEnumerable<long>
{
public static readonly long[] Value=A008258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008258.Bytes);
public long this[int i]=>Value[i];

public static A008258Inst Instance=new A008258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008257
{
public static readonly long[] Value={ 1L,4L,12L,22L,36L,58L,94L,136L,164L,194L,248L,320L,382L,440L,500L,568L,664L,760L,844L,936L,1030L,1134L,1268L,1384L,1498L,1618L,1758L,1898L,2048L,2184L,2344L,2504L,2680L,2830L,3014L,3190L,3390L,3572L,3776L,3950L,4178L,4384L,4624L,4828L,5060L,5260L,5540L,5772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008257Inst : IEnumerable<long>
{
public static readonly long[] Value=A008257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008257.Bytes);
public long this[int i]=>Value[i];

public static A008257Inst Instance=new A008257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008256
{
public static readonly long[] Value={ 1L,4L,10L,22L,43L,69L,95L,123L,162L,215L,269L,319L,372L,435L,513L,597L,675L,754L,843L,943L,1052L,1162L,1268L,1381L,1507L,1640L,1776L,1912L,2052L,2204L,2362L,2520L,2682L,2854L,3034L,3216L,3399L,3585L,3782L,3992L,4202L,4411L,4623L,4842L,5077L,5319L,5555L,5791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008256Inst : IEnumerable<long>
{
public static readonly long[] Value=A008256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008256.Bytes);
public long this[int i]=>Value[i];

public static A008256Inst Instance=new A008256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008255
{
public static readonly long[] Value={ 1L,4L,10L,22L,38L,56L,82L,112L,142L,182L,226L,268L,322L,380L,434L,502L,574L,640L,722L,808L,886L,982L,1082L,1172L,1282L,1396L,1498L,1622L,1750L,1864L,2002L,2144L,2270L,2422L,2578L,2716L,2882L,3052L,3202L,3382L,3566L,3728L,3922L,4120L,4294L,4502L,4714L,4900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008255Inst : IEnumerable<long>
{
public static readonly long[] Value=A008255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008255.Bytes);
public long this[int i]=>Value[i];

public static A008255Inst Instance=new A008255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008254
{
public static readonly long[] Value={ 1L,4L,10L,20L,38L,58L,80L,112L,144L,180L,226L,270L,320L,380L,436L,500L,574L,642L,720L,808L,888L,980L,1082L,1174L,1280L,1396L,1500L,1620L,1750L,1866L,2000L,2144L,2272L,2420L,2578L,2718L,2880L,3052L,3204L,3380L,3566L,3730L,3920L,4120L,4296L,4500L,4714L,4902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008254Inst : IEnumerable<long>
{
public static readonly long[] Value=A008254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008254.Bytes);
public long this[int i]=>Value[i];

public static A008254Inst Instance=new A008254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008205
{
public static readonly long[] Value={ 1L,4L,11L,21L,36L,58L,89L,123L,157L,187L,237L,298L,355L,418L,476L,539L,627L,718L,793L,878L,975L,1086L,1200L,1310L,1405L,1511L,1656L,1794L,1935L,2063L,2196L,2354L,2517L,2685L,2836L,2996L,3176L,3359L,3553L,3731L,3916L,4132L,4331L,4538L,4759L,4955L,5190L,5433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008205Inst : IEnumerable<long>
{
public static readonly long[] Value=A008205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008205.Bytes);
public long this[int i]=>Value[i];

public static A008205Inst Instance=new A008205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008204
{
public static readonly long[] Value={ 1L,4L,8L,18L,36L,56L,66L,116L,140L,154L,232L,264L,294L,392L,432L,478L,588L,620L,718L,816L,868L,962L,1112L,1140L,1278L,1396L,1500L,1594L,1772L,1832L,2010L,2140L,2268L,2382L,2628L,2672L,2878L,3056L,3208L,3334L,3620L,3668L,3942L,4120L,4284L,4458L,4784L,4828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008204Inst : IEnumerable<long>
{
public static readonly long[] Value=A008204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008204.Bytes);
public long this[int i]=>Value[i];

public static A008204Inst Instance=new A008204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008203
{
public static readonly long[] Value={ 1L,4L,9L,19L,35L,52L,78L,106L,139L,179L,213L,266L,318L,366L,439L,501L,553L,648L,718L,790L,895L,977L,1063L,1184L,1272L,1378L,1511L,1617L,1727L,1876L,1998L,2122L,2281L,2421L,2551L,2732L,2878L,3022L,3223L,3381L,3529L,3752L,3918L,4086L,4319L,4497L,4679L,4928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008203Inst : IEnumerable<long>
{
public static readonly long[] Value=A008203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008203.Bytes);
public long this[int i]=>Value[i];

public static A008203Inst Instance=new A008203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008202
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,59L,83L,115L,155L,192L,233L,271L,328L,409L,475L,529L,572L,647L,772L,881L,941L,1006L,1085L,1220L,1397L,1485L,1553L,1676L,1796L,1961L,2152L,2251L,2374L,2525L,2635L,2833L,3094L,3236L,3338L,3505L,3660L,3931L,4214L,4319L,4448L,4702L,4886L,5116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008202Inst : IEnumerable<long>
{
public static readonly long[] Value=A008202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008202.Bytes);
public long this[int i]=>Value[i];

public static A008202Inst Instance=new A008202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008201
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,55L,85L,122L,156L,188L,225L,280L,347L,404L,463L,512L,585L,675L,763L,858L,946L,1008L,1109L,1235L,1349L,1493L,1594L,1650L,1790L,1963L,2131L,2300L,2379L,2460L,2669L,2883L,3053L,3230L,3361L,3472L,3694L,3924L,4144L,4384L,4527L,4609L,4852L,5184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008201Inst : IEnumerable<long>
{
public static readonly long[] Value=A008201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008201.Bytes);
public long this[int i]=>Value[i];

public static A008201Inst Instance=new A008201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008200
{
public static readonly long[] Value={ 1L,4L,12L,21L,37L,58L,87L,119L,154L,182L,227L,287L,346L,404L,450L,519L,585L,679L,767L,846L,927L,1029L,1120L,1226L,1367L,1455L,1579L,1695L,1788L,1943L,2142L,2274L,2381L,2528L,2619L,2848L,3090L,3220L,3354L,3517L,3651L,3889L,4227L,4357L,4484L,4658L,4815L,5151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008200Inst : IEnumerable<long>
{
public static readonly long[] Value=A008200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008200.Bytes);
public long this[int i]=>Value[i];

public static A008200Inst Instance=new A008200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008199
{
public static readonly long[] Value={ 1L,4L,12L,23L,37L,59L,85L,120L,154L,184L,231L,288L,343L,400L,444L,514L,611L,694L,746L,822L,930L,1045L,1154L,1218L,1312L,1464L,1598L,1703L,1814L,1952L,2090L,2254L,2397L,2518L,2704L,2863L,2994L,3191L,3378L,3545L,3732L,3898L,4068L,4348L,4562L,4672L,4903L,5140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008199Inst : IEnumerable<long>
{
public static readonly long[] Value=A008199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008199.Bytes);
public long this[int i]=>Value[i];

public static A008199Inst Instance=new A008199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008198
{
public static readonly long[] Value={ 1L,4L,12L,21L,37L,62L,84L,119L,147L,188L,239L,286L,326L,391L,477L,524L,595L,657L,753L,869L,946L,998L,1106L,1259L,1352L,1466L,1556L,1672L,1855L,1987L,2067L,2229L,2404L,2529L,2700L,2844L,2999L,3216L,3390L,3491L,3726L,3953L,4101L,4316L,4476L,4683L,4981L,5195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008198Inst : IEnumerable<long>
{
public static readonly long[] Value=A008198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008198.Bytes);
public long this[int i]=>Value[i];

public static A008198Inst Instance=new A008198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008197
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,60L,86L,115L,147L,191L,238L,289L,339L,383L,447L,530L,621L,679L,753L,811L,908L,1070L,1159L,1230L,1324L,1405L,1568L,1773L,1859L,1929L,2061L,2184L,2397L,2642L,2703L,2802L,2995L,3143L,3387L,3622L,3738L,3868L,4100L,4245L,4491L,4848L,4954L,5090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008197Inst : IEnumerable<long>
{
public static readonly long[] Value=A008197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008197.Bytes);
public long this[int i]=>Value[i];

public static A008197Inst Instance=new A008197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008196
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,60L,88L,113L,147L,190L,243L,290L,328L,382L,458L,540L,603L,681L,742L,831L,935L,1021L,1154L,1259L,1316L,1415L,1569L,1733L,1887L,1963L,2011L,2195L,2433L,2585L,2731L,2823L,2943L,3189L,3396L,3566L,3750L,3933L,4044L,4255L,4524L,4748L,5033L,5162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008196Inst : IEnumerable<long>
{
public static readonly long[] Value=A008196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008196.Bytes);
public long this[int i]=>Value[i];

public static A008196Inst Instance=new A008196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008195
{
public static readonly long[] Value={ 1L,4L,12L,24L,44L,66L,88L,132L,174L,214L,258L,318L,394L,448L,510L,608L,650L,776L,878L,958L,1038L,1138L,1328L,1428L,1500L,1644L,1770L,1908L,2136L,2236L,2354L,2486L,2748L,3006L,2970L,3202L,3438L,3678L,3854L,3980L,4240L,4370L,4720L,5056L,5056L,5236L,5576L,5968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008195Inst : IEnumerable<long>
{
public static readonly long[] Value=A008195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008195.Bytes);
public long this[int i]=>Value[i];

public static A008195Inst Instance=new A008195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008194
{
public static readonly long[] Value={ 1L,4L,12L,22L,42L,66L,94L,126L,164L,220L,270L,312L,370L,450L,544L,600L,652L,734L,888L,986L,1056L,1110L,1258L,1470L,1560L,1620L,1712L,1958L,2148L,2262L,2310L,2458L,2788L,2950L,3068L,3138L,3342L,3740L,3950L,3950L,4136L,4436L,4786L,4994L,5018L,5268L,5608L,5954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008194Inst : IEnumerable<long>
{
public static readonly long[] Value=A008194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008194.Bytes);
public long this[int i]=>Value[i];

public static A008194Inst Instance=new A008194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008193
{
public static readonly long[] Value={ 1L,4L,12L,24L,41L,62L,97L,129L,170L,212L,262L,322L,386L,446L,516L,575L,695L,772L,862L,944L,1041L,1186L,1286L,1403L,1525L,1629L,1785L,1963L,2062L,2225L,2370L,2562L,2735L,2849L,3088L,3212L,3453L,3630L,3818L,4032L,4176L,4494L,4707L,4875L,5138L,5330L,5614L,5873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008193Inst : IEnumerable<long>
{
public static readonly long[] Value=A008193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008193.Bytes);
public long this[int i]=>Value[i];

public static A008193Inst Instance=new A008193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008192
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,65L,98L,132L,159L,206L,278L,318L,379L,440L,510L,603L,683L,766L,844L,945L,1088L,1156L,1266L,1392L,1521L,1680L,1773L,1931L,2080L,2190L,2419L,2566L,2674L,2873L,3047L,3267L,3456L,3580L,3827L,3982L,4272L,4513L,4649L,4824L,5078L,5478L,5651L,5791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008192Inst : IEnumerable<long>
{
public static readonly long[] Value=A008192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008192.Bytes);
public long this[int i]=>Value[i];

public static A008192Inst Instance=new A008192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008191
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,67L,97L,124L,165L,219L,265L,318L,367L,449L,530L,597L,674L,742L,843L,1002L,1057L,1142L,1254L,1411L,1577L,1623L,1766L,1921L,2101L,2258L,2347L,2518L,2693L,2936L,3093L,3159L,3389L,3681L,3854L,4052L,4135L,4459L,4739L,4877L,5158L,5281L,5589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008191Inst : IEnumerable<long>
{
public static readonly long[] Value=A008191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008191.Bytes);
public long this[int i]=>Value[i];

public static A008191Inst Instance=new A008191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008190
{
public static readonly long[] Value={ 1L,4L,12L,24L,40L,64L,96L,136L,167L,207L,258L,331L,389L,444L,500L,598L,689L,786L,843L,929L,1065L,1199L,1288L,1369L,1492L,1673L,1849L,1923L,2025L,2205L,2424L,2595L,2691L,2811L,3056L,3340L,3429L,3592L,3767L,4028L,4336L,4467L,4596L,4855L,5143L,5442L,5637L,5758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008190Inst : IEnumerable<long>
{
public static readonly long[] Value=A008190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008190.Bytes);
public long this[int i]=>Value[i];

public static A008190Inst Instance=new A008190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008189
{
public static readonly long[] Value={ 1L,4L,12L,23L,43L,66L,92L,130L,170L,213L,261L,316L,387L,442L,514L,607L,675L,755L,857L,948L,1064L,1171L,1281L,1386L,1502L,1691L,1807L,1907L,2050L,2225L,2414L,2525L,2701L,2879L,3034L,3280L,3470L,3586L,3770L,4031L,4315L,4442L,4592L,4894L,5127L,5409L,5638L,5806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008189Inst : IEnumerable<long>
{
public static readonly long[] Value=A008189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008189.Bytes);
public long this[int i]=>Value[i];

public static A008189Inst Instance=new A008189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008188
{
public static readonly long[] Value={ 1L,4L,12L,24L,36L,64L,112L,132L,156L,222L,264L,340L,424L,456L,492L,640L,740L,778L,876L,1020L,1084L,1216L,1440L,1416L,1464L,1818L,1924L,1972L,2172L,2316L,2464L,2696L,2956L,2946L,3024L,3544L,3664L,3708L,4044L,4140L,4380L,4786L,5008L,5052L,5148L,5752L,6032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008188Inst : IEnumerable<long>
{
public static readonly long[] Value=A008188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008188.Bytes);
public long this[int i]=>Value[i];

public static A008188Inst Instance=new A008188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008187
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,66L,103L,130L,168L,216L,274L,334L,405L,459L,528L,631L,719L,784L,891L,999L,1098L,1228L,1357L,1449L,1566L,1741L,1909L,1998L,2157L,2334L,2467L,2699L,2869L,2961L,3186L,3417L,3643L,3781L,3954L,4233L,4411L,4702L,4950L,5040L,5352L,5653L,5921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008187Inst : IEnumerable<long>
{
public static readonly long[] Value=A008187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008187.Bytes);
public long this[int i]=>Value[i];

public static A008187Inst Instance=new A008187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008186
{
public static readonly long[] Value={ 1L,4L,12L,25L,43L,68L,95L,133L,177L,223L,274L,334L,398L,471L,546L,627L,709L,797L,899L,1002L,1105L,1226L,1344L,1469L,1601L,1736L,1874L,2021L,2181L,2338L,2490L,2668L,2849L,3028L,3212L,3401L,3591L,3804L,4022L,4228L,4439L,4663L,4904L,5145L,5378L,5631L,5866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008186Inst : IEnumerable<long>
{
public static readonly long[] Value=A008186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008186.Bytes);
public long this[int i]=>Value[i];

public static A008186Inst Instance=new A008186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008185
{
public static readonly long[] Value={ 1L,4L,11L,24L,39L,60L,92L,122L,148L,195L,250L,293L,342L,403L,472L,551L,621L,690L,786L,879L,954L,1047L,1168L,1293L,1397L,1484L,1622L,1773L,1880L,2007L,2181L,2336L,2456L,2606L,2783L,2966L,3122L,3278L,3468L,3672L,3855L,4037L,4253L,4466L,4664L,4853L,5081L,5338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008185Inst : IEnumerable<long>
{
public static readonly long[] Value=A008185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008185.Bytes);
public long this[int i]=>Value[i];

public static A008185Inst Instance=new A008185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008184
{
public static readonly long[] Value={ 1L,4L,11L,24L,39L,54L,86L,126L,156L,195L,242L,289L,342L,407L,486L,557L,605L,672L,776L,883L,978L,1061L,1162L,1271L,1369L,1494L,1648L,1797L,1892L,1979L,2139L,2324L,2478L,2626L,2797L,2962L,3100L,3256L,3484L,3708L,3863L,4023L,4221L,4450L,4664L,4867L,5105L,5338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008184Inst : IEnumerable<long>
{
public static readonly long[] Value=A008184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008184.Bytes);
public long this[int i]=>Value[i];

public static A008184Inst Instance=new A008184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008183
{
public static readonly long[] Value={ 1L,4L,12L,20L,37L,64L,87L,114L,154L,198L,241L,289L,342L,410L,471L,537L,613L,707L,778L,855L,957L,1071L,1169L,1264L,1377L,1516L,1624L,1727L,1887L,2045L,2166L,2294L,2459L,2630L,2783L,2929L,3113L,3303L,3474L,3638L,3840L,4067L,4249L,4431L,4644L,4884L,5089L,5298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008183Inst : IEnumerable<long>
{
public static readonly long[] Value=A008183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008183.Bytes);
public long this[int i]=>Value[i];

public static A008183Inst Instance=new A008183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008182
{
public static readonly long[] Value={ 1L,4L,12L,22L,38L,60L,88L,115L,155L,204L,242L,286L,347L,416L,475L,531L,618L,703L,773L,862L,969L,1077L,1166L,1256L,1383L,1515L,1632L,1753L,1886L,2037L,2165L,2287L,2461L,2640L,2794L,2930L,3112L,3323L,3480L,3638L,3853L,4061L,4242L,4428L,4655L,4902L,5094L,5296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008182Inst : IEnumerable<long>
{
public static readonly long[] Value=A008182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008182.Bytes);
public long this[int i]=>Value[i];

public static A008182Inst Instance=new A008182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008181
{
public static readonly long[] Value={ 1L,4L,11L,23L,44L,67L,95L,134L,168L,215L,271L,320L,380L,454L,520L,599L,682L,764L,866L,965L,1052L,1175L,1297L,1399L,1529L,1667L,1792L,1943L,2084L,2225L,2405L,2560L,2700L,2903L,3087L,3242L,3446L,3644L,3828L,4055L,4250L,4450L,4712L,4919L,5112L,5399L,5641L,5849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008181Inst : IEnumerable<long>
{
public static readonly long[] Value=A008181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008181.Bytes);
public long this[int i]=>Value[i];

public static A008181Inst Instance=new A008181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008180
{
public static readonly long[] Value={ 1L,4L,12L,24L,38L,66L,100L,118L,162L,220L,262L,300L,376L,456L,516L,566L,648L,774L,848L,936L,1024L,1126L,1300L,1366L,1500L,1628L,1726L,1916L,2016L,2218L,2348L,2428L,2694L,2874L,3020L,3120L,3322L,3624L,3804L,3924L,4088L,4372L,4624L,4852L,5016L,5214L,5506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008180Inst : IEnumerable<long>
{
public static readonly long[] Value=A008180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008180.Bytes);
public long this[int i]=>Value[i];

public static A008180Inst Instance=new A008180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008179
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,62L,92L,138L,160L,196L,262L,332L,386L,420L,486L,606L,680L,744L,818L,936L,1084L,1136L,1250L,1362L,1460L,1662L,1782L,1910L,1998L,2132L,2400L,2534L,2656L,2756L,2960L,3302L,3408L,3504L,3662L,3942L,4300L,4372L,4534L,4750L,4980L,5382L,5536L,5738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008179Inst : IEnumerable<long>
{
public static readonly long[] Value=A008179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008179.Bytes);
public long this[int i]=>Value[i];

public static A008179Inst Instance=new A008179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008178
{
public static readonly long[] Value={ 1L,4L,10L,22L,36L,64L,98L,124L,158L,213L,260L,306L,368L,453L,508L,571L,664L,753L,856L,929L,1018L,1168L,1246L,1373L,1490L,1616L,1800L,1856L,2030L,2218L,2310L,2510L,2620L,2865L,3042L,3104L,3400L,3563L,3758L,3963L,4084L,4433L,4590L,4769L,5044L,5232L,5556L,5705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008178Inst : IEnumerable<long>
{
public static readonly long[] Value=A008178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008178.Bytes);
public long this[int i]=>Value[i];

public static A008178Inst Instance=new A008178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008177
{
public static readonly long[] Value={ 1L,4L,12L,19L,35L,64L,96L,123L,155L,207L,272L,311L,367L,439L,501L,580L,666L,747L,853L,924L,1048L,1172L,1225L,1352L,1482L,1650L,1812L,1829L,2021L,2212L,2346L,2527L,2599L,2817L,3034L,3167L,3419L,3527L,3701L,3970L,4180L,4437L,4547L,4684L,5052L,5350L,5551L,5664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008177Inst : IEnumerable<long>
{
public static readonly long[] Value=A008177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008177.Bytes);
public long this[int i]=>Value[i];

public static A008177Inst Instance=new A008177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008176
{
public static readonly long[] Value={ 1L,4L,12L,26L,40L,60L,94L,136L,168L,200L,259L,332L,379L,421L,506L,598L,678L,745L,829L,952L,1040L,1148L,1263L,1369L,1502L,1604L,1780L,1919L,2011L,2174L,2331L,2558L,2662L,2762L,3020L,3202L,3414L,3526L,3708L,4004L,4146L,4398L,4568L,4776L,5064L,5220L,5568L,5754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008176Inst : IEnumerable<long>
{
public static readonly long[] Value=A008176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008176.Bytes);
public long this[int i]=>Value[i];

public static A008176Inst Instance=new A008176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008175
{
public static readonly long[] Value={ 1L,4L,12L,24L,42L,64L,90L,131L,168L,206L,259L,313L,383L,441L,506L,583L,656L,766L,841L,933L,1034L,1139L,1279L,1376L,1496L,1617L,1744L,1911L,2041L,2179L,2329L,2494L,2686L,2837L,2988L,3178L,3352L,3588L,3768L,3926L,4152L,4344L,4630L,4822L,5010L,5262L,5458L,5795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008175Inst : IEnumerable<long>
{
public static readonly long[] Value=A008175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008175.Bytes);
public long this[int i]=>Value[i];

public static A008175Inst Instance=new A008175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008174
{
public static readonly long[] Value={ 1L,4L,11L,20L,39L,66L,92L,124L,163L,215L,257L,304L,373L,447L,514L,571L,657L,763L,852L,924L,1031L,1150L,1262L,1364L,1493L,1642L,1748L,1882L,2044L,2196L,2341L,2458L,2668L,2863L,2999L,3164L,3344L,3594L,3770L,3910L,4162L,4372L,4601L,4792L,5006L,5306L,5471L,5726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008174Inst : IEnumerable<long>
{
public static readonly long[] Value=A008174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008174.Bytes);
public long this[int i]=>Value[i];

public static A008174Inst Instance=new A008174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008157
{
public static readonly long[] Value={ 1L,4L,12L,25L,42L,69L,100L,129L,176L,229L,277L,338L,404L,481L,556L,647L,731L,812L,930L,1036L,1120L,1255L,1388L,1501L,1640L,1796L,1919L,2071L,2254L,2389L,2564L,2764L,2919L,3096L,3310L,3508L,3676L,3915L,4141L,4325L,4581L,4821L,5030L,5281L,5546L,5782L,6026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008157Inst : IEnumerable<long>
{
public static readonly long[] Value=A008157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008157.Bytes);
public long this[int i]=>Value[i];

public static A008157Inst Instance=new A008157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008156
{
public static readonly long[] Value={ 1L,4L,12L,21L,40L,63L,83L,124L,155L,197L,244L,289L,352L,410L,484L,544L,618L,697L,800L,872L,962L,1072L,1168L,1300L,1397L,1518L,1628L,1768L,1910L,2050L,2179L,2318L,2486L,2638L,2828L,2968L,3136L,3321L,3510L,3696L,3872L,4064L,4276L,4507L,4702L,4926L,5112L,5342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008156Inst : IEnumerable<long>
{
public static readonly long[] Value=A008156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008156.Bytes);
public long this[int i]=>Value[i];

public static A008156Inst Instance=new A008156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008155
{
public static readonly long[] Value={ 1L,4L,11L,23L,38L,57L,88L,126L,158L,191L,236L,299L,363L,410L,462L,536L,621L,705L,790L,879L,976L,1076L,1169L,1266L,1383L,1521L,1660L,1786L,1902L,2017L,2159L,2342L,2511L,2646L,2792L,2959L,3146L,3327L,3497L,3684L,3882L,4096L,4295L,4471L,4680L,4907L,5140L,5374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008155Inst : IEnumerable<long>
{
public static readonly long[] Value=A008155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008155.Bytes);
public long this[int i]=>Value[i];

public static A008155Inst Instance=new A008155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008154
{
public static readonly long[] Value={ 1L,4L,11L,22L,36L,57L,90L,127L,157L,194L,244L,299L,353L,403L,465L,552L,642L,707L,768L,854L,975L,1101L,1194L,1275L,1370L,1503L,1659L,1786L,1896L,2023L,2185L,2367L,2507L,2614L,2758L,2960L,3185L,3365L,3492L,3649L,3867L,4111L,4324L,4476L,4649L,4888L,5156L,5406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008154Inst : IEnumerable<long>
{
public static readonly long[] Value=A008154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008154.Bytes);
public long this[int i]=>Value[i];

public static A008154Inst Instance=new A008154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008153
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,59L,87L,122L,158L,198L,243L,292L,352L,412L,473L,548L,624L,705L,789L,871L,965L,1073L,1184L,1291L,1392L,1509L,1644L,1768L,1906L,2043L,2182L,2337L,2486L,2644L,2800L,2966L,3146L,3330L,3507L,3690L,3879L,4076L,4290L,4484L,4693L,4909L,5131L,5372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008153Inst : IEnumerable<long>
{
public static readonly long[] Value=A008153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008153.Bytes);
public long this[int i]=>Value[i];

public static A008153Inst Instance=new A008153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008152
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,62L,91L,116L,155L,203L,244L,291L,344L,417L,482L,546L,615L,704L,796L,878L,962L,1057L,1181L,1293L,1413L,1517L,1623L,1759L,1910L,2057L,2188L,2318L,2470L,2651L,2823L,2981L,3127L,3310L,3519L,3703L,3876L,4065L,4265L,4495L,4722L,4921L,5125L,5336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008152Inst : IEnumerable<long>
{
public static readonly long[] Value=A008152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008152.Bytes);
public long this[int i]=>Value[i];

public static A008152Inst Instance=new A008152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008151
{
public static readonly long[] Value={ 1L,4L,11L,23L,38L,61L,93L,121L,153L,198L,246L,296L,350L,412L,480L,544L,619L,706L,787L,880L,973L,1068L,1179L,1283L,1396L,1517L,1643L,1776L,1902L,2040L,2186L,2329L,2484L,2648L,2809L,2970L,3144L,3323L,3506L,3694L,3877L,4079L,4286L,4489L,4701L,4907L,5134L,5362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008151Inst : IEnumerable<long>
{
public static readonly long[] Value=A008151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008151.Bytes);
public long this[int i]=>Value[i];

public static A008151Inst Instance=new A008151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008150
{
public static readonly long[] Value={ 1L,4L,12L,21L,36L,63L,88L,121L,153L,192L,249L,299L,354L,405L,467L,543L,629L,706L,789L,866L,969L,1088L,1170L,1280L,1379L,1514L,1668L,1781L,1890L,2017L,2178L,2355L,2501L,2633L,2788L,2956L,3164L,3349L,3492L,3664L,3873L,4092L,4312L,4486L,4668L,4899L,5142L,5387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008150Inst : IEnumerable<long>
{
public static readonly long[] Value=A008150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008150.Bytes);
public long this[int i]=>Value[i];

public static A008150Inst Instance=new A008150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008149
{
public static readonly long[] Value={ 1L,4L,9L,18L,30L,39L,67L,98L,121L,147L,189L,234L,279L,319L,356L,412L,498L,555L,600L,678L,766L,836L,904L,1002L,1116L,1188L,1254L,1372L,1502L,1588L,1677L,1809L,1941L,2070L,2197L,2315L,2455L,2589L,2724L,2877L,3024L,3175L,3353L,3511L,3651L,3819L,4011L,4176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008149Inst : IEnumerable<long>
{
public static readonly long[] Value=A008149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008149.Bytes);
public long this[int i]=>Value[i];

public static A008149Inst Instance=new A008149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008148
{
public static readonly long[] Value={ 1L,4L,10L,16L,26L,46L,66L,94L,114L,158L,194L,222L,262L,334L,384L,404L,464L,564L,634L,670L,748L,826L,934L,1002L,1092L,1160L,1280L,1378L,1504L,1566L,1710L,1816L,1956L,2024L,2206L,2328L,2464L,2542L,2748L,2876L,3052L,3132L,3364L,3492L,3688L,3798L,4028L,4152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008148Inst : IEnumerable<long>
{
public static readonly long[] Value=A008148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008148.Bytes);
public long this[int i]=>Value[i];

public static A008148Inst Instance=new A008148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008147
{
public static readonly long[] Value={ 1L,4L,10L,17L,30L,46L,67L,91L,123L,153L,190L,226L,274L,319L,373L,424L,480L,544L,616L,689L,752L,834L,917L,1005L,1081L,1179L,1277L,1388L,1475L,1590L,1702L,1823L,1933L,2061L,2181L,2317L,2452L,2591L,2727L,2876L,3022L,3180L,3340L,3497L,3667L,3827L,4001L,4172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008147Inst : IEnumerable<long>
{
public static readonly long[] Value=A008147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008147.Bytes);
public long this[int i]=>Value[i];

public static A008147Inst Instance=new A008147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008146
{
public static readonly long[] Value={ 1L,4L,9L,18L,30L,46L,63L,94L,125L,152L,183L,232L,277L,315L,363L,433L,484L,536L,616L,688L,757L,829L,918L,1003L,1087L,1177L,1289L,1371L,1475L,1595L,1710L,1798L,1939L,2071L,2184L,2307L,2449L,2600L,2739L,2853L,3023L,3198L,3334L,3489L,3671L,3834L,3987L,4176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008146Inst : IEnumerable<long>
{
public static readonly long[] Value=A008146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008146.Bytes);
public long this[int i]=>Value[i];

public static A008146Inst Instance=new A008146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008145
{
public static readonly long[] Value={ 1L,4L,10L,21L,36L,53L,74L,104L,138L,174L,212L,255L,302L,349L,408L,474L,542L,610L,680L,755L,836L,923L,1014L,1110L,1206L,1308L,1410L,1521L,1644L,1767L,1892L,2016L,2142L,2270L,2408L,2559L,2716L,2871L,3026L,3186L,3346L,3512L,3688L,3871L,4056L,4237L,4420L,4612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008145Inst : IEnumerable<long>
{
public static readonly long[] Value=A008145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008145.Bytes);
public long this[int i]=>Value[i];

public static A008145Inst Instance=new A008145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008144
{
public static readonly long[] Value={ 1L,4L,10L,20L,35L,54L,78L,104L,134L,171L,210L,255L,303L,355L,413L,472L,535L,605L,680L,758L,838L,923L,1016L,1107L,1202L,1311L,1418L,1525L,1640L,1759L,1883L,2009L,2143L,2284L,2420L,2563L,2714L,2860L,3017L,3185L,3348L,3516L,3691L,3869L,4048L,4232L,4432L,4627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008144Inst : IEnumerable<long>
{
public static readonly long[] Value=A008144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008144.Bytes);
public long this[int i]=>Value[i];

public static A008144Inst Instance=new A008144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008143
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,49L,72L,97L,125L,158L,197L,242L,291L,342L,398L,462L,532L,602L,669L,739L,816L,899L,988L,1082L,1181L,1283L,1388L,1499L,1615L,1737L,1867L,2006L,2150L,2293L,2434L,2574L,2715L,2856L,2999L,3150L,3312L,3484L,3661L,3842L,4027L,4214L,4403L,4597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008143Inst : IEnumerable<long>
{
public static readonly long[] Value=A008143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008143.Bytes);
public long this[int i]=>Value[i];

public static A008143Inst Instance=new A008143Inst();

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