using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A264882
{
public static readonly long[] Value={ 3L,0L,56L,36L,3613L,22400L,356692L,3303808L,37498613L,378705540L,3968118198L,40855251236L,419847061269L,4338625113664L,44432810271640L,458593963707000L,4699321892473274L,48406074363574612L,496575268524702592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264882Inst : IEnumerable<long>
{
public static readonly long[] Value=A264882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264882.Bytes);
public long this[int i]=>Value[i];

public static A264882Inst Instance=new A264882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264883
{
public static readonly long[] Value={ 4L,0L,137L,108L,19372L,207424L,4747695L,78535556L,1314624443L,22908798620L,367507064798L,6308520502938L,101920859207417L,1716067465404634L,28013671881647327L,465628347016848772L,7646941659349897210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264883Inst : IEnumerable<long>
{
public static readonly long[] Value=A264883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264883.Bytes);
public long this[int i]=>Value[i];

public static A264883Inst Instance=new A264883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264884
{
public static readonly BigInteger[] Value={ 5L,0L,295L,324L,103585L,1946752L,68488297L,1924357508L,50441933177L,1445554962912L,36992542484103L,1026445425096056L,26650424305406609L,720407685534768304L,BigInteger.Parse("18921801302926160029"),BigInteger.Parse("503810101426663743940") };
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
public class A264884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264884Inst Instance=new A264884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264885
{
public static readonly long[] Value={ 238L,874L,2914L,3266L,3638L,4438L,5117L,6601L,7982L,8582L,9854L,10191L,10538L,10887L,11966L,13101L,17283L,19113L,23069L,38238L,40313L,41741L,46191L,53342L,54998L,56690L,68341L,74139L,80189L,84341L,88585L,90763L,95165L,98534L,100838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264885Inst : IEnumerable<long>
{
public static readonly long[] Value=A264885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264885.Bytes);
public long this[int i]=>Value[i];

public static A264885Inst Instance=new A264885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264886
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,9L,15L,25L,36L,57L,80L,81L,133L,225L,281L,282L,288L,343L,632L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264886Inst : IEnumerable<long>
{
public static readonly long[] Value=A264886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264886.Bytes);
public long this[int i]=>Value[i];

public static A264886Inst Instance=new A264886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264887
{
public static readonly long[] Value={ 5830L,6870L,13490L,16401L,58406L,60146L,61910L,65534L,75130L,136114L,148827L,153178L,213538L,257358L,269074L,273054L,327198L,354102L,377310L,382038L,403611L,443685L,475323L,488774L,496905L,665130L,684510L,691026L,799846L,817563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264887Inst : IEnumerable<long>
{
public static readonly long[] Value=A264887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264887.Bytes);
public long this[int i]=>Value[i];

public static A264887Inst Instance=new A264887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264888
{
public static readonly long[] Value={ 0L,1L,16L,71L,205L,470L,931L,1666L,2766L,4335L,6490L,9361L,13091L,17836L,23765L,31060L,39916L,50541L,63156L,77995L,95305L,115346L,138391L,164726L,194650L,228475L,266526L,309141L,356671L,409480L,467945L,532456L,603416L,681241L,766360L,859215L,960261L,1069966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264888Inst : IEnumerable<long>
{
public static readonly long[] Value=A264888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264888.Bytes);
public long this[int i]=>Value[i];

public static A264888Inst Instance=new A264888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264889
{
public static readonly BigInteger[] Value={ 1L,2L,6L,114L,27762L,86427762L,4031164827762L,3319770429936027762L,BigInteger.Parse("55696441261496986915227762"),BigInteger.Parse("21577941278638297470665013744027762"),BigInteger.Parse("215779412250996503370318565758665013744027762"),BigInteger.Parse("61564384586850833363801728392684283449726665013744027762") };
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
public class A264889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264889Inst Instance=new A264889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264890
{
public static readonly long[] Value={ 0L,1L,4L,8L,11L,12L,17L,25L,26L,27L,28L,29L,37L,38L,41L,45L,48L,54L,60L,67L,71L,73L,75L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264890Inst : IEnumerable<long>
{
public static readonly long[] Value=A264890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264890.Bytes);
public long this[int i]=>Value[i];

public static A264890Inst Instance=new A264890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264891
{
public static readonly long[] Value={ 0L,1L,112L,783L,2839L,7480L,16281L,31192L,54538L,89019L,137710L,204061L,291897L,405418L,549199L,728190L,947716L,1213477L,1531548L,1908379L,2350795L,2865996L,3461557L,4145428L,4925934L,5811775L,6812026L,7936137L,9193933L,10595614L,12151755L,13873306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264891Inst : IEnumerable<long>
{
public static readonly long[] Value=A264891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264891.Bytes);
public long this[int i]=>Value[i];

public static A264891Inst Instance=new A264891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264892
{
public static readonly long[] Value={ 0L,1L,176L,1281L,4720L,12545L,27456L,52801L,92576L,151425L,234640L,348161L,498576L,693121L,939680L,1246785L,1623616L,2080001L,2626416L,3273985L,4034480L,4920321L,5944576L,7120961L,8463840L,9988225L,11709776L,13644801L,15810256L,18223745L,20903520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264892Inst : IEnumerable<long>
{
public static readonly long[] Value=A264892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264892.Bytes);
public long this[int i]=>Value[i];

public static A264892Inst Instance=new A264892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264893
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,-1L,2L,-1L,0L,0L,1L,-1L,2L,-1L,1L,0L,1L,-2L,3L,-2L,2L,-2L,3L,-2L,0L,0L,3L,-3L,4L,-4L,5L,-4L,4L,-4L,5L,-2L,3L,-5L,5L,-5L,6L,-6L,7L,-6L,5L,-5L,6L,-6L,1L,0L,6L,-6L,7L,-7L,7L,-7L,8L,-7L,8L,-9L,10L,-8L,7L,0L,2L,-9L,10L,-9L,9L,-9L,10L,-12L,13L,-10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264893Inst : IEnumerable<long>
{
public static readonly long[] Value=A264893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264893.Bytes);
public long this[int i]=>Value[i];

public static A264893Inst Instance=new A264893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264894
{
public static readonly long[] Value={ 0L,1L,261L,1956L,7291L,19500L,42846L,82621L,145146L,237771L,368875L,547866L,785181L,1092286L,1481676L,1966875L,2562436L,3283941L,4148001L,5172256L,6375375L,7777056L,9398026L,11260041L,13385886L,15799375L,18525351L,21589686L,25019281L,28842066L,33087000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264894Inst : IEnumerable<long>
{
public static readonly long[] Value=A264894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264894.Bytes);
public long this[int i]=>Value[i];

public static A264894Inst Instance=new A264894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264895
{
public static readonly long[] Value={ 0L,1L,370L,2835L,10660L,28645L,63126L,121975L,214600L,351945L,546490L,812251L,1164780L,1621165L,2200030L,2921535L,3807376L,4880785L,6166530L,7690915L,9481780L,11568501L,13981990L,16754695L,19920600L,23515225L,27575626L,32140395L,37249660L,42945085L,49269870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264895Inst : IEnumerable<long>
{
public static readonly long[] Value=A264895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264895.Bytes);
public long this[int i]=>Value[i];

public static A264895Inst Instance=new A264895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264896
{
public static readonly BigInteger[] Value={ 1L,12L,126L,1344L,15110L,180736L,2308548L,31481472L,457520055L,7068885600L,115808906178L,2006533573632L,36674815572540L,705453732298240L,14248697953325160L,301564509817810944L,6674811622886359005L,BigInteger.Parse("154228999030804811520"),BigInteger.Parse("3713903962096887036390") };
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
public class A264896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264896Inst Instance=new A264896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264897
{
public static readonly long[] Value={ 138L,163L,873L,1054L,1079L,1604L,1825L,1990L,2079L,2493L,2509L,2810L,2950L,3494L,3800L,3910L,4300L,4462L,4470L,4564L,4593L,4957L,5140L,5450L,5558L,5572L,5581L,5834L,6391L,6792L,6969L,7444L,7892L,8321L,8530L,8581L,9254L,9299L,9522L,9832L,9847L,10082L,10850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264897Inst : IEnumerable<long>
{
public static readonly long[] Value=A264897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264897.Bytes);
public long this[int i]=>Value[i];

public static A264897Inst Instance=new A264897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264898
{
public static readonly long[] Value={ 1L,3L,8L,9L,15L,24L,25L,49L,63L,81L,85L,121L,195L,229L,255L,361L,440L,442L,446L,451L,483L,528L,676L,729L,841L,1091L,1295L,1443L,1681L,1935L,2026L,2115L,2401L,2409L,2613L,2703L,3363L,3481L,3721L,3729L,3843L,3981L,3985L,3986L,3987L,4005L,4107L,4624L,4760L,4768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264898Inst : IEnumerable<long>
{
public static readonly long[] Value=A264898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264898.Bytes);
public long this[int i]=>Value[i];

public static A264898Inst Instance=new A264898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264899
{
public static readonly long[] Value={ 1L,2L,6L,23L,109L,630L,4329L,34458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264899Inst : IEnumerable<long>
{
public static readonly long[] Value=A264899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264899.Bytes);
public long this[int i]=>Value[i];

public static A264899Inst Instance=new A264899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264900
{
public static readonly long[] Value={ 1L,13L,43L,71L,101L,149L,163L,191L,233L,257L,259L,277L,307L,311L,373L,389L,421L,439L,463L,563L,571L,617L,647L,743L,751L,763L,871L,899L,907L,971L,1099L,1171L,1223L,1429L,1517L,1577L,1621L,1631L,1687L,1691L,1709L,1741L,1757L,1759L,1777L,1841L,1871L,1963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264900Inst : IEnumerable<long>
{
public static readonly long[] Value=A264900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264900.Bytes);
public long this[int i]=>Value[i];

public static A264900Inst Instance=new A264900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264901
{
public static readonly long[] Value={ 16L,32L,64L,64L,128L,128L,128L,243L,256L,256L,512L,512L,512L,512L,512L,512L,1024L,1024L,1024L,1024L,1024L,1024L,2048L,2048L,2048L,2744L,4096L,4096L,4096L,4096L,6561L,6561L,6561L,6561L,8192L,8192L,8192L,8192L,8192L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264901Inst : IEnumerable<long>
{
public static readonly long[] Value=A264901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264901.Bytes);
public long this[int i]=>Value[i];

public static A264901Inst Instance=new A264901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264902
{
public static readonly long[] Value={ 1L,1L,3L,1L,16L,10L,1L,125L,107L,23L,1L,1296L,1346L,436L,46L,1L,16807L,19917L,8402L,1442L,87L,1L,262144L,341986L,173860L,41070L,4320L,162L,1L,4782969L,6713975L,3924685L,1166083L,176843L,12357L,303L,1L,100000000L,148717762L,96920092L,34268902L,6768184L,710314L,34660L,574L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264902Inst : IEnumerable<long>
{
public static readonly long[] Value=A264902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264902.Bytes);
public long this[int i]=>Value[i];

public static A264902Inst Instance=new A264902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264903
{
public static readonly BigInteger[] Value={ 1L,1L,23L,1442L,176843L,36046214L,11023248678L,4719570364004L,2693983725947891L,1976997422623843358L,BigInteger.Parse("1813499364725872444178"),BigInteger.Parse("2033181299894696684493980"),BigInteger.Parse("2735368952738645928181452734"),BigInteger.Parse("4349180440965667221581315433212"),BigInteger.Parse("8067655677482008559181766540571948") };
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
public class A264903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264903Inst Instance=new A264903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264904
{
public static readonly long[] Value={ 5L,17L,37L,53L,101L,109L,197L,257L,293L,401L,409L,577L,677L,701L,733L,857L,1093L,1297L,1373L,1601L,1609L,1697L,2029L,2141L,2213L,2417L,2917L,3137L,3253L,3373L,3389L,3853L,4261L,4357L,4493L,4909L,5209L,5477L,5641L,5801L,6257L,7057L,7229L,7573L,7937L,8101L,8837L,9029L,9413L,9613L,10009L,10429L,10453L,10613L,12101L,12109L,12553L,13457L,13693L,14177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264904Inst : IEnumerable<long>
{
public static readonly long[] Value=A264904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264904.Bytes);
public long this[int i]=>Value[i];

public static A264904Inst Instance=new A264904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264905
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,4L,6L,7L,8L,13L,16L,18L,26L,29L,38L,49L,58L,68L,90L,101L,125L,156L,181L,214L,263L,304L,358L,435L,505L,589L,701L,812L,939L,1115L,1275L,1485L,1736L,1991L,2286L,2667L,3038L,3489L,4028L,4588L,5240L,6036L,6833L,7787L,8904L,10078L,11429L,13020L,14698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264905Inst : IEnumerable<long>
{
public static readonly long[] Value=A264905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264905.Bytes);
public long this[int i]=>Value[i];

public static A264905Inst Instance=new A264905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264906
{
public static readonly long[] Value={ 25L,36L,49L,64L,81L,100L,121L,72L,169L,196L,225L,256L,289L,324L,361L,100L,441L,484L,529L,576L,625L,676L,729L,392L,841L,900L,961L,1024L,1089L,1156L,1225L,324L,1369L,1444L,1521L,1600L,1681L,1764L,1849L,968L,2025L,2116L,2209L,2304L,2401L,2500L,2601L,676L,2809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264906Inst : IEnumerable<long>
{
public static readonly long[] Value=A264906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264906.Bytes);
public long this[int i]=>Value[i];

public static A264906Inst Instance=new A264906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264907
{
public static readonly long[] Value={ 2L,15L,255L,5865L,170085L,9014505L,1661569239L,117971415969L,494390700895L,42163217429333L,2571956263189313L,551363902358334637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264907Inst : IEnumerable<long>
{
public static readonly long[] Value=A264907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264907.Bytes);
public long this[int i]=>Value[i];

public static A264907Inst Instance=new A264907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264908
{
public static readonly long[] Value={ 13L,37L,41L,43L,73L,83L,97L,103L,137L,139L,151L,163L,167L,193L,199L,223L,521L,523L,547L,577L,607L,641L,643L,647L,769L,1033L,1063L,1091L,1103L,1153L,1283L,1543L,1567L,1663L,2053L,2081L,2083L,2087L,2113L,2143L,2179L,2207L,2239L,2311L,2591L,2687L,3079L,3583L,4129L,4231L,4639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264908Inst : IEnumerable<long>
{
public static readonly long[] Value=A264908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264908.Bytes);
public long this[int i]=>Value[i];

public static A264908Inst Instance=new A264908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264909
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,2L,0L,1L,1L,3L,6L,5L,0L,1L,1L,4L,12L,21L,16L,0L,1L,1L,5L,20L,54L,87L,61L,0L,1L,1L,6L,30L,110L,276L,413L,271L,0L,1L,1L,7L,42L,195L,670L,1574L,2213L,1372L,0L,1L,1L,8L,56L,315L,1380L,4470L,9916L,13205L,7795L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264909Inst : IEnumerable<long>
{
public static readonly long[] Value=A264909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264909.Bytes);
public long this[int i]=>Value[i];

public static A264909Inst Instance=new A264909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264910
{
public static readonly BigInteger[] Value={ 1L,1L,5L,30L,195L,1380L,10555L,86815L,764350L,7174420L,71532369L,755136887L,8415519048L,98744576456L,1216948265335L,15718032335081L,212330461568282L,2994374695258034L,44008250794756373L,672986694107199687L,10692604102273015636UL,BigInteger.Parse("176266660430175342285") };
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
public class A264910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264910.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264910Inst Instance=new A264910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264911
{
public static readonly BigInteger[] Value={ 1L,1L,6L,42L,315L,2541L,21931L,201761L,1971627L,20401115L,222886237L,2564378397L,30996823039L,392772620555L,5206946927601L,72084153595073L,1040323636265431L,15627180533214417L,243970019981427565L,3953119943277152705L,BigInteger.Parse("66394925299770846495"),BigInteger.Parse("1154518082416143179150") };
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
public class A264911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264911.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264911Inst Instance=new A264911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264912
{
public static readonly BigInteger[] Value={ 1L,1L,7L,56L,476L,4312L,41468L,422128L,4536140L,51328018L,610168496L,7604171722L,99154078394L,1350325442746L,19173655721912L,283420080801700L,4354942891383206L,69465537443190352L,1148784383085885884L,BigInteger.Parse("19673049517219904032"),BigInteger.Parse("348483690687062619926") };
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
public class A264912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264912Inst Instance=new A264912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264913
{
public static readonly BigInteger[] Value={ 1L,1L,8L,72L,684L,6876L,72924L,814056L,9544164L,117284766L,1507813722L,20243939784L,283383218358L,4129738188546L,62563457162916L,983985264479016L,16046556350152008L,271012423865891076L,4735104984115971090L,BigInteger.Parse("85496795448023574282"),BigInteger.Parse("1593757450233067980306") };
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
public class A264913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264913Inst Instance=new A264913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264914
{
public static readonly BigInteger[] Value={ 1L,1L,9L,90L,945L,10440L,121065L,1470855L,18688680L,247924425L,3428559573L,49353455856L,738477897552L,11471175099726L,184755890053173L,3081830366508444L,53182355345412138L,948482464405185843L,17465164002387664056UL,BigInteger.Parse("331740754587283644945"),BigInteger.Parse("6494261833979742949884") };
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
public class A264914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264914Inst Instance=new A264914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264915
{
public static readonly BigInteger[] Value={ 1L,1L,10L,110L,1265L,15235L,191785L,2519605L,34494625L,491432590L,7276062838L,111816814439L,1781492191281L,29392907305322L,501677394880530L,8849027884862077L,161155012811798819L,3027460412190175918L,BigInteger.Parse("58617635130507630386"),BigInteger.Parse("1168800382939975874066") };
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
public class A264915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264915Inst Instance=new A264915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264916
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,110L,1380L,21931L,422128L,9544164L,247924425L,7276062838L,238094692473L,8595519551905L,339369780700496L,14547197878632067L,672813893127964088L,BigInteger.Parse("33396560680565891888"),BigInteger.Parse("1770862858604836365591"),BigInteger.Parse("99902715110909008145856"),BigInteger.Parse("5974701996798223000294793") };
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
public class A264916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264916Inst Instance=new A264916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264917
{
public static readonly BigInteger[] Value={ 11L,21221L,3333322121L,0L,BigInteger.Parse("5555555555544444443332311223"),BigInteger.Parse("66666666666665555555555544444443333122321"),0L };
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
public class A264917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264917.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264917Inst Instance=new A264917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264918
{
public static readonly long[] Value={ 3L,9L,3L,1L,8L,8L,4L,7L,7L,0L,4L,9L,6L,4L,4L,3L,2L,4L,4L,9L,7L,2L,5L,8L,2L,1L,3L,1L,3L,8L,9L,0L,3L,8L,8L,5L,8L,5L,4L,8L,3L,9L,1L,4L,0L,7L,8L,8L,6L,6L,2L,8L,6L,9L,5L,3L,9L,2L,9L,3L,2L,4L,7L,5L,7L,5L,7L,8L,7L,7L,5L,8L,3L,3L,8L,9L,7L,4L,9L,8L,6L,6L,8L,1L,0L,9L,7L,6L,6L,6L,2L,0L,6L,1L,0L,1L,8L,5L,8L,8L,8L,0L,1L,3L,3L,3L,0L,0L,8L,0L,5L,9L,3L,2L,2L,6L,3L,1L,5L,3L,2L,6L,8L,0L,9L,0L,4L,7L,5L,0L,4L,9L,4L,2L,6L,6L,6L,1L,2L,1L,1L,4L,2L,4L,3L,3L,4L,9L,8L,4L,4L,3L,5L,8L,4L,7L,7L,5L,8L,5L,0L,6L,5L,5L,9L,3L,3L,7L,2L,5L,0L,9L,1L,4L,3L,2L,8L,8L,7L,7L,0L,5L,4L,3L,2L,2L,3L,1L,4L,0L,7L,7L,1L,7L,1L,7L,5L,9L,5L,3L,3L,3L,7L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264918Inst : IEnumerable<long>
{
public static readonly long[] Value=A264918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264918.Bytes);
public long this[int i]=>Value[i];

public static A264918Inst Instance=new A264918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264919
{
public static readonly long[] Value={ 7L,5L,5L,9L,4L,0L,2L,0L,4L,4L,8L,0L,1L,0L,6L,0L,6L,6L,4L,7L,1L,4L,4L,1L,0L,6L,8L,0L,4L,0L,6L,0L,0L,4L,7L,8L,1L,6L,8L,7L,0L,3L,9L,5L,1L,6L,3L,9L,6L,8L,7L,2L,3L,0L,4L,5L,3L,2L,6L,2L,7L,1L,5L,6L,6L,3L,3L,0L,5L,8L,9L,1L,2L,5L,6L,2L,8L,8L,1L,0L,4L,8L,6L,5L,0L,6L,4L,6L,5L,1L,7L,4L,9L,7L,6L,2L,9L,6L,9L,8L,3L,3L,1L,6L,9L,8L,4L,9L,3L,5L,8L,9L,1L,4L,0L,5L,4L,5L,1L,1L,7L,4L,5L,1L,7L,7L,7L,0L,3L,2L,1L,4L,1L,6L,6L,9L,2L,3L,2L,9L,1L,7L,3L,7L,0L,2L,6L,7L,0L,5L,9L,1L,4L,9L,2L,9L,4L,3L,2L,4L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264919Inst : IEnumerable<long>
{
public static readonly long[] Value=A264919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264919.Bytes);
public long this[int i]=>Value[i];

public static A264919Inst Instance=new A264919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264920
{
public static readonly long[] Value={ 2L,9L,0L,3L,6L,0L,5L,4L,1L,4L,6L,9L,8L,2L,2L,7L,7L,1L,3L,0L,8L,0L,9L,4L,6L,1L,0L,9L,2L,4L,3L,9L,5L,9L,9L,7L,0L,9L,2L,8L,3L,6L,2L,1L,8L,5L,8L,7L,0L,4L,9L,7L,8L,9L,8L,0L,2L,2L,7L,7L,7L,3L,9L,8L,2L,2L,9L,6L,0L,6L,2L,6L,0L,2L,7L,8L,4L,5L,1L,6L,3L,1L,4L,6L,4L,9L,0L,7L,9L,8L,3L,1L,1L,0L,1L,0L,9L,2L,3L,0L,0L,0L,9L,4L,1L,5L,4L,5L,3L,0L,1L,7L,1L,7L,5L,3L,6L,5L,4L,1L,1L,8L,4L,5L,4L,5L,0L,4L,1L,9L,2L,0L,2L,0L,9L,9L,3L,6L,1L,8L,4L,1L,4L,8L,2L,6L,6L,1L,9L,3L,4L,5L,5L,6L,0L,0L,6L,1L,2L,8L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264920Inst : IEnumerable<long>
{
public static readonly long[] Value=A264920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264920.Bytes);
public long this[int i]=>Value[i];

public static A264920Inst Instance=new A264920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264921
{
public static readonly long[] Value={ 1L,3L,6L,7L,4L,6L,1L,3L,7L,9L,3L,5L,3L,3L,2L,9L,2L,6L,9L,0L,2L,1L,3L,0L,0L,5L,2L,8L,2L,3L,7L,5L,4L,0L,8L,0L,4L,3L,4L,5L,9L,4L,5L,5L,1L,2L,8L,4L,8L,9L,9L,5L,3L,0L,8L,3L,7L,2L,0L,4L,7L,8L,1L,1L,2L,5L,6L,7L,4L,0L,4L,6L,8L,0L,2L,1L,0L,7L,3L,8L,6L,8L,3L,6L,3L,9L,2L,4L,7L,1L,7L,6L,6L,7L,7L,1L,9L,8L,5L,1L,0L,6L,6L,5L,7L,1L,2L,6L,3L,8L,2L,0L,9L,1L,4L,3L,0L,0L,9L,3L,2L,6L,2L,8L,0L,9L,3L,8L,9L,8L,7L,7L,0L,2L,2L,9L,6L,1L,1L,0L,1L,6L,8L,2L,1L,7L,2L,4L,9L,9L,0L,2L,2L,3L,8L,2L,5L,9L,3L,4L,1L,8L,1L,6L,5L,5L,4L,5L,9L,5L,0L,0L,8L,5L,3L,6L,4L,1L,9L,1L,0L,5L,7L,2L,4L,4L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264921Inst : IEnumerable<long>
{
public static readonly long[] Value=A264921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264921.Bytes);
public long this[int i]=>Value[i];

public static A264921Inst Instance=new A264921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264922
{
public static readonly long[] Value={ 4L,1L,2L,9L,2L,0L,7L,6L,8L,6L,7L,1L,4L,9L,7L,6L,9L,2L,3L,1L,8L,7L,6L,4L,4L,6L,3L,3L,9L,1L,6L,6L,0L,2L,2L,3L,2L,6L,6L,3L,6L,5L,8L,0L,8L,5L,5L,9L,1L,6L,1L,5L,0L,1L,7L,1L,2L,0L,8L,7L,3L,8L,0L,9L,6L,5L,2L,9L,3L,3L,4L,5L,5L,2L,2L,8L,4L,2L,3L,7L,1L,0L,8L,3L,2L,2L,4L,0L,6L,8L,1L,1L,8L,9L,3L,7L,5L,4L,2L,6L,7L,0L,9L,4L,4L,0L,9L,6L,8L,1L,5L,9L,1L,8L,6L,8L,4L,5L,2L,3L,9L,0L,6L,7L,6L,7L,3L,7L,4L,3L,9L,4L,7L,7L,8L,7L,6L,7L,4L,4L,6L,5L,5L,6L,7L,1L,1L,4L,7L,6L,1L,0L,7L,8L,0L,4L,6L,5L,5L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264922Inst : IEnumerable<long>
{
public static readonly long[] Value=A264922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264922.Bytes);
public long this[int i]=>Value[i];

public static A264922Inst Instance=new A264922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264923
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,6L,11L,18L,33L,57L,105L,183L,330L,567L,990L,1693L,2904L,4917L,8343L,14010L,23511L,39171L,65100L,107592L,177352L,290931L,475905L,775381L,1259637L,2039094L,3291613L,5296467L,8499339L,13599292L,21702795L,34541724L,54839894L,86847255L,137212197L,216274466L,340129773L,533726442L,835732774L,1305877914L,2036369010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264923Inst : IEnumerable<long>
{
public static readonly long[] Value=A264923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264923.Bytes);
public long this[int i]=>Value[i];

public static A264923Inst Instance=new A264923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264924
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,4L,10L,20L,36L,60L,104L,180L,336L,620L,1174L,2160L,3961L,7100L,12690L,22424L,39651L,69820L,122970L,215904L,378470L,660872L,1150740L,1996200L,3452685L,5952916L,10237576L,17559460L,30049285L,51301020L,87390872L,148534232L,251916041L,426329040L,720003646L,1213481344L,2041155052L,3426721080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264924Inst : IEnumerable<long>
{
public static readonly long[] Value=A264924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264924.Bytes);
public long this[int i]=>Value[i];

public static A264924Inst Instance=new A264924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264925
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,5L,15L,35L,70L,127L,215L,360L,605L,1080L,2003L,3890L,7570L,14715L,27960L,52255L,95705L,173295L,311060L,557400L,999032L,1795880L,3235130L,5835955L,10521060L,18931287L,33956485L,60692510L,108087835L,191883595L,339724144L,600203700L,1058605775L,1864535670L,3279862975L,5762287759L,10109925380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264925Inst : IEnumerable<long>
{
public static readonly long[] Value=A264925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264925.Bytes);
public long this[int i]=>Value[i];

public static A264925Inst Instance=new A264925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264926
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,6L,21L,56L,126L,252L,463L,798L,1329L,2184L,3696L,6552L,12405L,24486L,49524L,99722L,197967L,383796L,727609L,1350174L,2466534L,4457844L,8022819L,14448168L,26142810L,47603010L,87222576L,160522228L,295996791L,545445468L,1002392105L,1834644210L,3342375099L,6061611192L,10949981496L,19720143366L,35440268956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264926Inst : IEnumerable<long>
{
public static readonly long[] Value=A264926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264926.Bytes);
public long this[int i]=>Value[i];

public static A264926Inst Instance=new A264926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264927
{
public static readonly BigInteger[] Value={ 1L,1L,4L,18L,81L,396L,1936L,9416L,45796L,234972L,1205604L,6188328L,31764496L,162249168L,828748944L,4224034452L,21529399441L,113085801048L,593996986944L,3126735424128L,16458794619136L,86717178000000L,456890625000000L,2407551579000000L,12686416153856064L,66648950832253248L,350144800010358336L,1838080630013808960L,9648980656951105600UL,BigInteger.Parse("50559912359694495680") };
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
public class A264927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264927Inst Instance=new A264927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264928
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,-4L,-2L,1L,5L,8L,8L,6L,2L,-4L,-10L,-13L,-15L,-14L,-10L,-3L,5L,12L,18L,23L,25L,23L,17L,9L,1L,-9L,-19L,-28L,-34L,-37L,-35L,-30L,-24L,-15L,-3L,10L,24L,35L,43L,48L,50L,50L,46L,38L,26L,12L,-4L,-20L,-34L,-45L,-55L,-64L,-70L,-71L,-67L,-58L,-46L,-31L,-15L,2L,18L,35L,53L,68L,80L,89L,93L,91L,85L,75L,63L,49L,33L,15L,-7L,-31L,-53L,-72L,-88L,-101L,-109L,-114L,-114L,-111L,-105L,-96L,-82L,-63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264928Inst : IEnumerable<long>
{
public static readonly long[] Value=A264928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264928.Bytes);
public long this[int i]=>Value[i];

public static A264928Inst Instance=new A264928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264929
{
public static readonly long[] Value={ 3L,23L,25165823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264929Inst : IEnumerable<long>
{
public static readonly long[] Value=A264929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264929.Bytes);
public long this[int i]=>Value[i];

public static A264929Inst Instance=new A264929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264930
{
public static readonly BigInteger[] Value={ 1L,2L,4L,27L,BigInteger.Parse("340282366920938463463374607431768211456") };
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
public class A264930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264930Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264930.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264930.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264930Inst Instance=new A264930Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264931
{
public static readonly long[] Value={ 1L,3L,7L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264931Inst : IEnumerable<long>
{
public static readonly long[] Value=A264931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264931.Bytes);
public long this[int i]=>Value[i];

public static A264931Inst Instance=new A264931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264932
{
public static readonly long[] Value={ 1L,3L,3L,7625597484987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264932Inst : IEnumerable<long>
{
public static readonly long[] Value=A264932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264932.Bytes);
public long this[int i]=>Value[i];

public static A264932Inst Instance=new A264932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264933
{
public static readonly BigInteger[] Value={ 0L,1L,2L,2L,4L,256L,BigInteger.Parse("340282366920938463463374607431768211456") };
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
public class A264933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264933Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264933.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264933.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264933Inst Instance=new A264933Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264934
{
public static readonly long[] Value={ 9L,1L,6L,7L,2L,9L,1L,8L,1L,7L,8L,9L,0L,2L,4L,1L,6L,3L,6L,5L,6L,6L,3L,0L,7L,6L,7L,3L,5L,0L,3L,2L,5L,0L,1L,8L,9L,5L,1L,7L,5L,8L,9L,9L,9L,6L,2L,1L,9L,4L,2L,7L,2L,2L,9L,8L,1L,6L,3L,9L,6L,0L,2L,2L,4L,2L,6L,8L,7L,3L,3L,1L,2L,1L,0L,2L,0L,9L,2L,9L,2L,9L,0L,2L,5L,3L,4L,9L,4L,7L,5L,5L,2L,9L,2L,0L,6L,7L,9L,2L,5L,3L,4L,8L,9L,8L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264934Inst : IEnumerable<long>
{
public static readonly long[] Value=A264934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264934.Bytes);
public long this[int i]=>Value[i];

public static A264934Inst Instance=new A264934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264935
{
public static readonly long[] Value={ 6L,11L,14L,16L,17L,20L,23L,24L,34L,38L,39L,42L,48L,49L,58L,66L,74L,77L,83L,87L,102L,104L,110L,120L,136L,145L,156L,158L,172L,177L,178L,183L,195L,201L,233L,235L,250L,256L,260L,273L,277L,282L,288L,293L,306L,319L,325L,329L,373L,389L,399L,415L,458L,512L,589L,609L,695L,862L,989L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264935Inst : IEnumerable<long>
{
public static readonly long[] Value=A264935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264935.Bytes);
public long this[int i]=>Value[i];

public static A264935Inst Instance=new A264935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264936
{
public static readonly long[] Value={ 0L,4L,5L,5L,5L,5L,7L,0L,3L,6L,7L,0L,1L,9L,5L,8L,4L,2L,9L,0L,0L,4L,9L,5L,0L,0L,0L,4L,7L,0L,4L,0L,7L,0L,5L,7L,7L,0L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264936Inst : IEnumerable<long>
{
public static readonly long[] Value=A264936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264936.Bytes);
public long this[int i]=>Value[i];

public static A264936Inst Instance=new A264936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264937
{
public static readonly long[] Value={ 1L,3L,25L,37L,51L,105L,157L,351L,499L,1093L,1987L,8019L,23787L,42795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264937Inst : IEnumerable<long>
{
public static readonly long[] Value=A264937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264937.Bytes);
public long this[int i]=>Value[i];

public static A264937Inst Instance=new A264937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264938
{
public static readonly long[] Value={ 0L,1L,6L,16L,29L,46L,68L,93L,122L,156L,193L,234L,280L,329L,382L,440L,501L,566L,636L,709L,786L,868L,953L,1042L,1136L,1233L,1334L,1440L,1549L,1662L,1780L,1901L,2026L,2156L,2289L,2426L,2568L,2713L,2862L,3016L,3173L,3334L,3500L,3669L,3842L,4020L,4201L,4386L,4576L,4769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264938Inst : IEnumerable<long>
{
public static readonly long[] Value=A264938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264938.Bytes);
public long this[int i]=>Value[i];

public static A264938Inst Instance=new A264938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264939
{
public static readonly BigInteger[] Value={ 1L,2L,56L,184740L,137409486772L,BigInteger.Parse("36724170744914466520"),BigInteger.Parse("5395269899168064415277849230476") };
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
public class A264939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264939Inst Instance=new A264939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264940
{
public static readonly long[] Value={ 0L,2L,0L,2L,3L,2L,0L,2L,0L,2L,3L,2L,0L,2L,0L,2L,3L,2L,7L,2L,0L,2L,3L,2L,0L,2L,9L,2L,3L,2L,0L,2L,0L,2L,3L,2L,0L,2L,7L,2L,3L,2L,0L,2L,13L,2L,3L,2L,0L,2L,0L,2L,3L,2L,15L,2L,9L,2L,3L,2L,7L,2L,0L,2L,3L,2L,0L,2L,0L,2L,3L,2L,0L,2L,0L,2L,3L,2L,0L,2L,7L,2L,3L,2L,21L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264940Inst : IEnumerable<long>
{
public static readonly long[] Value=A264940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264940.Bytes);
public long this[int i]=>Value[i];

public static A264940Inst Instance=new A264940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264941
{
public static readonly BigInteger[] Value={ 0L,1L,56L,3201L,307016L,43200625L,8403205056L,2162875665601L,712215325718576L,292162814336854881L,BigInteger.Parse("146127700393451369000") };
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
public class A264941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264941Inst Instance=new A264941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264942
{
public static readonly BigInteger[] Value={ 0L,2L,332L,184740L,196389904L,368696849320L,1122409297218768L,5194172319787113488L,BigInteger.Parse("34756519036284839519360") };
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
public class A264942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264942.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264942Inst Instance=new A264942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264943
{
public static readonly BigInteger[] Value={ 0L,1L,2350L,11375145L,137409486772L,3537141103745065L,BigInteger.Parse("173357342638694530002"),BigInteger.Parse("14844736259829478729001905") };
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
public class A264943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264943.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264943Inst Instance=new A264943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264944
{
public static readonly BigInteger[] Value={ 0L,2L,16108L,730983420L,102117302729744L,BigInteger.Parse("36724170744914466520"),BigInteger.Parse("29526013062983124375791088") };
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
public class A264944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264944Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264944.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264944.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264944Inst Instance=new A264944Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264945
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,1L,8L,1L,0L,2L,56L,60L,1L,0L,1L,332L,3201L,544L,1L,0L,2L,2350L,184740L,307016L,6040L,1L,0L,1L,16108L,11375145L,196389904L,43200625L,79008L,1L,0L,2L,114148L,730983420L,137409486772L,368696849320L,8403205056L,1190672L,1L,0L,1L,817280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264945Inst : IEnumerable<long>
{
public static readonly long[] Value=A264945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264945.Bytes);
public long this[int i]=>Value[i];

public static A264945Inst Instance=new A264945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264946
{
public static readonly long[] Value={ 1L,8L,56L,332L,2350L,16108L,114148L,817280L,5918424L,43251920L,318428920L,2359455400L,17577965926L,131579085320L,989014916960L,7461197116280L,56471149527616L,428656384570808L,3262347081071272L,24887490475059512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264946Inst : IEnumerable<long>
{
public static readonly long[] Value=A264946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264946.Bytes);
public long this[int i]=>Value[i];

public static A264946Inst Instance=new A264946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264947
{
public static readonly BigInteger[] Value={ 1L,60L,3201L,184740L,11375145L,730983420L,48402531561L,3282992503164L,226854309720993L,15915758107113276L,1130694005695927761L,BigInteger.Parse("81177583723495750340"),BigInteger.Parse("5880587303767912833417"),BigInteger.Parse("429300706847441007321756") };
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
public class A264947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264947.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264947Inst Instance=new A264947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264948
{
public static readonly BigInteger[] Value={ 1L,544L,307016L,196389904L,137409486772L,102117302729744L,79300380540248536L,BigInteger.Parse("63677294433618454384") };
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
public class A264948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264948Inst Instance=new A264948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264949
{
public static readonly BigInteger[] Value={ 1L,6040L,43200625L,368696849320L,3537141103745065L,BigInteger.Parse("36724170744914466520") };
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
public class A264949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264949Inst Instance=new A264949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264950
{
public static readonly BigInteger[] Value={ 1L,79008L,8403205056L,1122409297218768L,BigInteger.Parse("173357342638694530002"),BigInteger.Parse("29526013062983124375791088"),BigInteger.Parse("5395269899168064415277849230476") };
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
public class A264950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264950Inst Instance=new A264950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264951
{
public static readonly BigInteger[] Value={ 136L,244L,919L,1459L,2178L,6514L,58618L,63804L,76438L,89883L,157596L,313625L,2755907L,6586433L,8139850L,9057586L,144839908L,277668893L,304162700L,344050075L,756738746L,1043820406L,4370652168L,11346057072L,21914086555935085L,37878721692554416L,187864919457180831L,375609204308055082L,13397885590701080090UL,BigInteger.Parse("40091536165423401387") };
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
public class A264951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264951.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264951Inst Instance=new A264951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264952
{
public static readonly BigInteger[] Value={ 0L,2L,12L,504L,22320L,1521360L,140394240L,17034433920L,2627788262400L,502511002156800L,116684130094963200L,BigInteger.Parse("32342603041381248000") };
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
public class A264952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264952Inst Instance=new A264952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264953
{
public static readonly long[] Value={ 0L,2L,36L,10728L,4857120L,4099655520L,5589688315680L,11532215497783680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264953Inst : IEnumerable<long>
{
public static readonly long[] Value=A264953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264953.Bytes);
public long this[int i]=>Value[i];

public static A264953Inst Instance=new A264953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264954
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,6L,0L,2L,12L,24L,0L,2L,36L,504L,120L,0L,2L,114L,10728L,22320L,720L,0L,2L,420L,269352L,4857120L,1521360L,5040L,0L,2L,1584L,7340712L,1286876160L,4099655520L,140394240L,40320L,0L,2L,6228L,212706840L,378296480400L,13998666435840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264954Inst : IEnumerable<long>
{
public static readonly long[] Value=A264954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264954.Bytes);
public long this[int i]=>Value[i];

public static A264954Inst Instance=new A264954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264955
{
public static readonly long[] Value={ 6L,12L,36L,114L,420L,1584L,6228L,24930L,101376L,417504L,1734876L,7271238L,30667068L,130119672L,554721564L,2375331042L,10209040920L,44027206416L,190434749196L,825936571446L,3590858184996L,15646265986056L,68311732725204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264955Inst : IEnumerable<long>
{
public static readonly long[] Value=A264955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264955.Bytes);
public long this[int i]=>Value[i];

public static A264955Inst Instance=new A264955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264956
{
public static readonly BigInteger[] Value={ 24L,504L,10728L,269352L,7340712L,212706840L,6427851432L,200437195992L,6401503898904L,208353728741064L,6885992401320264L,230473529137180056L,7796234052703001880L,BigInteger.Parse("266117752529540837544"),BigInteger.Parse("9154725401806039272072") };
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
public class A264956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264956Inst Instance=new A264956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264957
{
public static readonly ulong[] Value={ 120L,22320L,4857120L,1286876160L,378296480400L,119417031121560L,39653227389625800L,13674544263132249120UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264957Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A264957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264957.Bytes);
public ulong this[int i]=>Value[i];

public static A264957Inst Instance=new A264957Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264958
{
public static readonly BigInteger[] Value={ 136L,244L,919L,1459L,2178L,6514L,58618L,76438L,63804L,313625L,89883L,157596L,2755907L,6586433L,8139850L,9057586L,144839908L,1043820406L,277668893L,756738746L,304162700L,344050075L,4370652168L,11346057072L,21914086555935085L,37878721692554416L,187864919457180831L,375609204308055082L,13397885590701080090UL,BigInteger.Parse("40091536165423401387") };
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
public class A264958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264958Inst Instance=new A264958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264959
{
public static readonly long[] Value={ 1L,9L,27L,80L,216L,448L,1296L,2816L,6400L,13312L,30720L,62208L,139264L,311296L,688128L,1474560L,2985984L,6029312L,12845056L,30408704L,65011712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264959Inst : IEnumerable<long>
{
public static readonly long[] Value=A264959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264959.Bytes);
public long this[int i]=>Value[i];

public static A264959Inst Instance=new A264959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264960
{
public static readonly long[] Value={ 1L,2L,10L,32L,146L,512L,2248L,8192L,35218L,131072L,556040L,2097152L,8815496L,33554432L,140107040L,536870912L,2230302098L,8589934592L,35541690568L,137438953472L,566823203656L,2199023255552L,9044910175520L,35184372088832L,144393718191496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264960Inst : IEnumerable<long>
{
public static readonly long[] Value=A264960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264960.Bytes);
public long this[int i]=>Value[i];

public static A264960Inst Instance=new A264960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264961
{
public static readonly long[] Value={ 36L,45L,210L,315L,360L,630L,780L,990L,1260L,1386L,1540L,1800L,2850L,2970L,3510L,3570L,3780L,4095L,4788L,4851L,6300L,7920L,8415L,8550L,8778L,9450L,11700L,11781L,14850L,15400L,15561L,16380L,17640L,17955L,18018L,18648L,19110L,20790L,21420L,21450L,21528L,25116L,25200L,26565L,26775L,26796L,27720L,28980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264961Inst : IEnumerable<long>
{
public static readonly long[] Value=A264961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264961.Bytes);
public long this[int i]=>Value[i];

public static A264961Inst Instance=new A264961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264962
{
public static readonly long[] Value={ 4L,6L,3L,9L,12L,8L,10L,5L,15L,18L,14L,7L,21L,24L,16L,22L,11L,33L,36L,26L,13L,39L,42L,34L,17L,51L,54L,38L,19L,57L,60L,32L,46L,23L,69L,72L,58L,29L,87L,90L,62L,31L,93L,96L,74L,37L,111L,114L,82L,41L,123L,126L,86L,43L,129L,132L,94L,47L,141L,144L,106L,53L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264962Inst : IEnumerable<long>
{
public static readonly long[] Value=A264962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264962.Bytes);
public long this[int i]=>Value[i];

public static A264962Inst Instance=new A264962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264963
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,17L,104L,915L,8618L,104436L,1337282L,20709209L,336013996L,6343919118L,124736306407L,2780356513594L,64249797198125L,1651884203936474L,43874277964032394L,1278413274487999471L,BigInteger.Parse("38372024627757454128"),BigInteger.Parse("1249821733374560346851"),BigInteger.Parse("41835183404896657899658") };
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
public class A264963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264963Inst Instance=new A264963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264964
{
public static readonly long[] Value={ 0L,2L,6L,10L,12L,14L,18L,24L,30L,34L,38L,42L,44L,48L,52L,54L,58L,62L,66L,78L,84L,90L,96L,102L,108L,114L,126L,130L,138L,146L,150L,158L,164L,166L,170L,172L,178L,180L,184L,186L,192L,198L,200L,204L,206L,212L,214L,218L,220L,226L,234L,238L,246L,254L,258L,282L,294L,306L,318L,324L,330L,342L,348L,354L,360L,372L,378L,384L,390L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264964Inst : IEnumerable<long>
{
public static readonly long[] Value=A264964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264964.Bytes);
public long this[int i]=>Value[i];

public static A264964Inst Instance=new A264964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264965
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,8L,9L,10L,13L,12L,19L,22L,21L,16L,25L,18L,17L,20L,15L,26L,55L,24L,11L,14L,27L,28L,23L,30L,37L,64L,57L,46L,43L,36L,67L,70L,33L,40L,31L,66L,79L,52L,63L,38L,47L,48L,73L,58L,75L,76L,49L,54L,65L,56L,39L,34L,29L,60L,61L,74L,45L,32L,59L,42L,145L,68L,81L,226L,193L,72L,35L,82L,219L,100L,217L,174L,121L,80L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264965Inst : IEnumerable<long>
{
public static readonly long[] Value=A264965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264965.Bytes);
public long this[int i]=>Value[i];

public static A264965Inst Instance=new A264965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264966
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,8L,9L,10L,25L,12L,11L,26L,21L,16L,19L,18L,13L,20L,15L,14L,29L,24L,17L,22L,27L,28L,59L,30L,41L,64L,39L,58L,73L,36L,31L,46L,57L,40L,97L,66L,35L,100L,63L,34L,47L,48L,53L,98L,105L,44L,121L,54L,23L,56L,33L,50L,65L,60L,61L,82L,45L,32L,55L,42L,37L,68L,81L,38L,89L,72L,49L,62L,51L,52L,113L,114L,43L,80L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264966Inst : IEnumerable<long>
{
public static readonly long[] Value=A264966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264966.Bytes);
public long this[int i]=>Value[i];

public static A264966Inst Instance=new A264966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264967
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,8L,9L,10L,7L,12L,29L,14L,15L,32L,23L,18L,13L,20L,33L,38L,27L,24L,25L,22L,17L,28L,39L,30L,37L,16L,21L,34L,35L,36L,41L,26L,19L,40L,31L,42L,95L,68L,105L,54L,47L,96L,119L,98L,69L,116L,55L,86L,83L,56L,71L,78L,59L,60L,107L,74L,99L,92L,65L,114L,113L,44L,81L,50L,87L,72L,89L,82L,45L,104L,53L,110L,101L,80L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264967Inst : IEnumerable<long>
{
public static readonly long[] Value=A264967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264967.Bytes);
public long this[int i]=>Value[i];

public static A264967Inst Instance=new A264967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264968
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,8L,9L,10L,7L,12L,19L,14L,15L,32L,27L,18L,39L,20L,33L,26L,17L,24L,25L,38L,23L,28L,13L,30L,41L,16L,21L,34L,35L,36L,31L,22L,29L,40L,37L,42L,123L,68L,75L,86L,47L,96L,135L,70L,81L,152L,77L,46L,53L,56L,107L,110L,59L,60L,163L,82L,99L,108L,65L,142L,111L,44L,51L,134L,57L,72L,139L,62L,147L,156L,83L,58L,87L,80L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264968Inst : IEnumerable<long>
{
public static readonly long[] Value=A264968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264968.Bytes);
public long this[int i]=>Value[i];

public static A264968Inst Instance=new A264968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264969
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,5L,1L,5L,3L,2L,1L,5L,1L,5L,1L,2L,3L,5L,1L,5L,3L,1L,1L,5L,1L,22L,2L,3L,9L,7L,1L,22L,9L,3L,1L,22L,2L,7L,4L,2L,9L,1L,1L,7L,9L,4L,4L,7L,1L,5L,1L,3L,9L,5L,1L,1L,3L,2L,2L,5L,2L,22L,1L,2L,9L,18L,1L,7L,3L,4L,4L,18L,4L,7L,1L,2L,3L,18L,1L,3L,10L,3L,10L,18L,1L,3L,8L,6L,3L,22L,2L,22L,9L,4L,4L,18L,3L,17L,10L,4L,10L,6L,1L,3L,3L,6L,1L,18L,4L,17L,8L,3L,3L,10L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264969Inst : IEnumerable<long>
{
public static readonly long[] Value=A264969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264969.Bytes);
public long this[int i]=>Value[i];

public static A264969Inst Instance=new A264969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264970
{
public static readonly long[] Value={ 12L,2L,11L,2L,1L,1L,10L,0L,0L,3L,2L,2L,9L,0L,1L,5L,1L,4L,8L,0L,0L,3L,7L,2L,0L,0L,2L,1L,0L,1L,6L,6L,1L,0L,5L,5L,0L,0L,6L,4L,0L,1L,4L,0L,1L,3L,3L,2L,5L,0L,0L,1L,0L,2L,2L,0L,0L,1L,1L,4L,4L,3L,3L,0L,0L,2L,0L,0L,0L,1L,2L,3L,3L,2L,0L,0L,2L,1L,4L,0L,1L,1L,3L,3L,2L,0L,2L,2L,0L,4L,3L,1L,1L,3L,2L,5L,1L,4L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264970Inst : IEnumerable<long>
{
public static readonly long[] Value=A264970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264970.Bytes);
public long this[int i]=>Value[i];

public static A264970Inst Instance=new A264970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264971
{
public static readonly long[] Value={ 13L,3L,12L,3L,2L,2L,11L,1L,1L,4L,3L,3L,10L,1L,2L,6L,2L,5L,9L,1L,1L,4L,8L,3L,1L,1L,3L,2L,1L,2L,7L,7L,2L,1L,6L,6L,1L,1L,7L,5L,1L,2L,5L,1L,2L,4L,4L,3L,6L,1L,1L,2L,1L,3L,3L,1L,1L,2L,2L,5L,5L,4L,4L,1L,1L,3L,1L,1L,1L,2L,3L,4L,4L,3L,1L,1L,3L,2L,5L,1L,2L,2L,4L,4L,3L,1L,3L,3L,1L,5L,4L,2L,2L,4L,3L,6L,2L,5L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264971Inst : IEnumerable<long>
{
public static readonly long[] Value=A264971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264971.Bytes);
public long this[int i]=>Value[i];

public static A264971Inst Instance=new A264971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264972
{
public static readonly long[] Value={ 262L,670L,1450L,1690L,2158L,4246L,19522L,18410L,34678L,36926L,118882L,146998L,290566L,377966L,240038L,381466L,407054L,178898L,147146L,149714L,159458L,149378L,129242L,117958L,157822L,350014L,489878L,180770L,155930L,395686L,510386L,292426L,514294L,503114L,264490L,435670L,482882L,311674L,452774L,353570L,323374L,369638L,321926L,293726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264972Inst : IEnumerable<long>
{
public static readonly long[] Value=A264972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264972.Bytes);
public long this[int i]=>Value[i];

public static A264972Inst Instance=new A264972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264973
{
public static readonly long[] Value={ 262L,338L,850L,1058L,1238L,1838L,1786L,734L,1622L,1594L,710L,554L,818L,1118L,1574L,2014L,1834L,1306L,742L,1922L,1270L,838L,1018L,718L,334L,290L,802L,622L,322L,494L,650L,478L,266L,946L,550L,274L,458L,922L,766L,790L,1778L,1054L,826L,1418L,1358L,1982L,1606L,1954L,614L,674L,794L,1478L,1702L,986L,1526L,1870L,1714L,1090L,598L,298L,386L,970L,1370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264973Inst : IEnumerable<long>
{
public static readonly long[] Value=A264973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264973.Bytes);
public long this[int i]=>Value[i];

public static A264973Inst Instance=new A264973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264974
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,16L,9L,10L,19L,12L,13L,14L,15L,8L,17L,18L,11L,20L,21L,34L,43L,48L,25L,52L,27L,28L,55L,30L,37L,46L,57L,22L,49L,36L,31L,58L,39L,40L,41L,42L,23L,50L,45L,32L,59L,24L,35L,44L,51L,26L,53L,54L,29L,56L,33L,38L,47L,60L,61L,142L,63L,88L,169L,102L,115L,124L,129L,70L,151L,144L,97L,178L,75L,106L,133L,156L,79L,160L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264974Inst : IEnumerable<long>
{
public static readonly long[] Value=A264974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264974.Bytes);
public long this[int i]=>Value[i];

public static A264974Inst Instance=new A264974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264975
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,19L,16L,9L,10L,7L,12L,13L,14L,15L,46L,43L,18L,55L,20L,57L,58L,17L,48L,49L,52L,27L,28L,11L,30L,31L,8L,21L,22L,25L,36L,37L,34L,39L,40L,41L,42L,127L,124L,45L,136L,47L,138L,139L,44L,129L,130L,133L,54L,163L,56L,165L,166L,59L,60L,181L,178L,171L,172L,169L,174L,175L,50L,51L,154L,151L,144L,145L,142L,147L,148L,53L,156L,157L,160L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264975Inst : IEnumerable<long>
{
public static readonly long[] Value=A264975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264975.Bytes);
public long this[int i]=>Value[i];

public static A264975Inst Instance=new A264975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264976
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,32L,9L,10L,29L,12L,13L,14L,15L,8L,23L,18L,7L,20L,33L,34L,95L,96L,35L,104L,27L,28L,83L,30L,31L,86L,87L,38L,113L,36L,37L,110L,39L,40L,41L,42L,17L,50L,45L,16L,47L,24L,25L,68L,69L,26L,77L,54L,19L,56L,21L,22L,59L,60L,101L,302L,99L,100L,299L,102L,103L,284L,285L,98L,293L,288L,97L,290L,105L,106L,311L,312L,107L,320L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264976Inst : IEnumerable<long>
{
public static readonly long[] Value=A264976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264976.Bytes);
public long this[int i]=>Value[i];

public static A264976Inst Instance=new A264976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264977
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,6L,7L,8L,5L,2L,7L,12L,1L,14L,15L,16L,13L,10L,7L,4L,5L,14L,11L,24L,13L,2L,15L,28L,1L,30L,31L,32L,29L,26L,7L,20L,13L,14L,3L,8L,1L,10L,11L,28L,5L,22L,19L,48L,21L,26L,15L,4L,13L,30L,19L,56L,29L,2L,31L,60L,1L,62L,63L,64L,61L,58L,7L,52L,29L,14L,19L,40L,25L,26L,3L,28L,13L,6L,11L,16L,9L,2L,11L,20L,1L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264977Inst : IEnumerable<long>
{
public static readonly long[] Value=A264977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264977.Bytes);
public long this[int i]=>Value[i];

public static A264977Inst Instance=new A264977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264978
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,5L,6L,7L,4L,9L,10L,17L,24L,26L,14L,15L,23L,11L,18L,29L,20L,21L,25L,16L,12L,22L,13L,27L,28L,19L,30L,71L,44L,51L,62L,35L,72L,89L,53L,78L,80L,41L,42L,68L,32L,45L,86L,59L,69L,77L,50L,33L,65L,38L,54L,83L,56L,87L,74L,47L,60L,61L,34L,63L,88L,52L,75L,79L,43L,48L,70L,31L,36L,85L,58L,66L,76L,49L,39L,67L,40L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264978Inst : IEnumerable<long>
{
public static readonly long[] Value=A264978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264978.Bytes);
public long this[int i]=>Value[i];

public static A264978Inst Instance=new A264978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264979
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,19L,28L,37L,46L,55L,64L,73L,18L,11L,20L,29L,38L,47L,56L,65L,74L,27L,12L,21L,30L,39L,48L,57L,66L,75L,36L,13L,22L,31L,40L,49L,58L,67L,76L,45L,14L,23L,32L,41L,50L,59L,68L,77L,54L,15L,24L,33L,42L,51L,60L,69L,78L,63L,16L,25L,34L,43L,52L,61L,70L,79L,72L,17L,26L,35L,44L,53L,62L,71L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264979Inst : IEnumerable<long>
{
public static readonly long[] Value=A264979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264979.Bytes);
public long this[int i]=>Value[i];

public static A264979Inst Instance=new A264979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264980
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,64L,32L,184L,352L,704L,1408L,1880L,2824L,14032L,10328L,56128L,100576L,145784L,189472L,370304L,731752L,4388248L,2924096L,11175712L,15965704L,31930448L,63861880L,383165344L,255439712L,1021772344L,510875648L,2550188248L,5619691648L,9689861048L,17830350904L,79068724264L,34109913224L,192259976368L,133338241880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264980Inst : IEnumerable<long>
{
public static readonly long[] Value=A264980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264980.Bytes);
public long this[int i]=>Value[i];

public static A264980Inst Instance=new A264980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264981
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,81L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264981Inst : IEnumerable<long>
{
public static readonly long[] Value=A264981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264981.Bytes);
public long this[int i]=>Value[i];

public static A264981Inst Instance=new A264981Inst();

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