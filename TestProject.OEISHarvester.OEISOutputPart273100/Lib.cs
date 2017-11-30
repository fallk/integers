using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A068391
{
public static readonly long[] Value={ 2L,15L,357L,3339L,5049L,10659L,12441L,24969L,99693L,124355L,132957L,145145L,353133L,423657L,596037L,655707L,734517L,745503L,894387L,1406427L,1641783L,1823877L,1936557L,3295047L,4108401L,4194183L,4776201L,5574699L,5842137L,5971251L,6132789L,6953765L,7649915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068391Inst : IEnumerable<long>
{
public static readonly long[] Value=A068391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068391.Bytes);
public long this[int i]=>Value[i];

public static A068391Inst Instance=new A068391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068392
{
public static readonly long[] Value={ 0L,2L,11L,92L,2100L,140834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068392Inst : IEnumerable<long>
{
public static readonly long[] Value=A068392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068392.Bytes);
public long this[int i]=>Value[i];

public static A068392Inst Instance=new A068392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068393
{
public static readonly BigInteger[] Value={ 2L,3L,7L,44L,494L,748827L,99987552L,23904291912L,23904291912L,14647978829979L,16186345621426754L,BigInteger.Parse("45843626565163628751"),BigInteger.Parse("235646717730827228414584"),BigInteger.Parse("3099290829556018890177304005") };
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
public class A068393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068393Inst Instance=new A068393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068394
{
public static readonly long[] Value={ 12L,16L,17L,20L,33L,39L,44L,55L,58L,69L,80L,94L,99L,142L,169L,205L,243L,262L,274L,278L,293L,323L,325L,330L,333L,360L,364L,387L,388L,395L,411L,419L,427L,428L,452L,459L,460L,461L,483L,493L,499L,500L,503L,506L,511L,522L,525L,547L,581L,590L,594L,595L,598L,602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068394Inst : IEnumerable<long>
{
public static readonly long[] Value=A068394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068394.Bytes);
public long this[int i]=>Value[i];

public static A068394Inst Instance=new A068394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068395
{
public static readonly long[] Value={ 0L,0L,0L,0L,9L,9L,9L,9L,18L,18L,27L,27L,36L,36L,36L,45L,45L,54L,54L,63L,63L,63L,72L,72L,81L,99L,99L,99L,99L,108L,117L,126L,126L,126L,135L,144L,144L,153L,153L,162L,162L,171L,180L,180L,180L,180L,207L,216L,216L,216L,225L,225L,234L,243L,243L,252L,252L,261L,261L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068395Inst : IEnumerable<long>
{
public static readonly long[] Value=A068395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068395.Bytes);
public long this[int i]=>Value[i];

public static A068395Inst Instance=new A068395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068396
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,-18L,-54L,-72L,-9L,-63L,18L,-36L,27L,9L,-27L,18L,-36L,45L,-9L,54L,36L,-18L,45L,-9L,18L,0L,-198L,-594L,-792L,-198L,-594L,0L,-594L,-792L,-792L,0L,-594L,-198L,-594L,-198L,-792L,0L,0L,-198L,-594L,-792L,99L,-99L,-495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068396Inst : IEnumerable<long>
{
public static readonly long[] Value=A068396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068396.Bytes);
public long this[int i]=>Value[i];

public static A068396Inst Instance=new A068396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068397
{
public static readonly long[] Value={ 1L,5L,4L,9L,11L,20L,29L,49L,76L,125L,199L,324L,521L,845L,1364L,2209L,3571L,5780L,9349L,15129L,24476L,39605L,64079L,103684L,167761L,271445L,439204L,710649L,1149851L,1860500L,3010349L,4870849L,7881196L,12752045L,20633239L,33385284L,54018521L,87403805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068397Inst : IEnumerable<long>
{
public static readonly long[] Value=A068397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068397.Bytes);
public long this[int i]=>Value[i];

public static A068397Inst Instance=new A068397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068398
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,27L,28L,30L,32L,33L,35L,37L,38L,40L,42L,44L,46L,47L,49L,51L,53L,55L,57L,59L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,103L,105L,107L,109L,111L,113L,115L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068398Inst : IEnumerable<long>
{
public static readonly long[] Value=A068398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068398.Bytes);
public long this[int i]=>Value[i];

public static A068398Inst Instance=new A068398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068399
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,4L,5L,6L,6L,9L,7L,11L,13L,13L,13L,20L,16L,21L,22L,23L,24L,28L,27L,30L,32L,34L,35L,43L,38L,42L,46L,44L,49L,55L,50L,53L,57L,61L,61L,67L,63L,70L,73L,73L,73L,81L,77L,83L,85L,87L,89L,97L,94L,100L,98L,102L,102L,113L,107L,110L,118L,117L,121L,126L,123L,128L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068399Inst : IEnumerable<long>
{
public static readonly long[] Value=A068399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068399.Bytes);
public long this[int i]=>Value[i];

public static A068399Inst Instance=new A068399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068400
{
public static readonly long[] Value={ 248L,357L,1045L,3596L,3956L,4064L,5396L,8636L,20026L,20320L,23374L,24871L,25714L,29029L,33915L,35074L,39585L,41656L,50065L,55154L,56134L,56536L,58435L,61344L,64285L,74613L,79000L,87087L,87685L,137885L,140335L,142240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068400Inst : IEnumerable<long>
{
public static readonly long[] Value=A068400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068400.Bytes);
public long this[int i]=>Value[i];

public static A068400Inst Instance=new A068400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068401
{
public static readonly long[] Value={ 2L,38L,62L,346L,1298L,7898L,22682L,24382L,93022L,108194L,143362L,171982L,192718L,264766L,587638L,986642L,1236898L,1441042L,1604422L,2228582L,4146434L,5070314L,5631718L,6687046L,10223918L,10695182L,12465158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068401Inst : IEnumerable<long>
{
public static readonly long[] Value=A068401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068401.Bytes);
public long this[int i]=>Value[i];

public static A068401Inst Instance=new A068401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068402
{
public static readonly long[] Value={ 4L,6L,32L,38L,54L,56L,84L,278L,2664L,10944L,15608L,20720L,84800L,179576L,209664L,6251904L,85505600L,125226624L,584003328L,19018936320L,20534891040L,79185129984L,87065548800L,191904215040L,964494300024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068402Inst : IEnumerable<long>
{
public static readonly long[] Value=A068402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068402.Bytes);
public long this[int i]=>Value[i];

public static A068402Inst Instance=new A068402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068403
{
public static readonly long[] Value={ 180L,240L,360L,420L,480L,504L,540L,600L,660L,720L,780L,840L,900L,960L,1008L,1080L,1200L,1260L,1320L,1344L,1440L,1512L,1560L,1584L,1620L,1680L,1800L,1848L,1872L,1890L,1920L,1980L,2016L,2040L,2100L,2160L,2184L,2280L,2340L,2352L,2376L,2400L,2520L,2640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068403Inst : IEnumerable<long>
{
public static readonly long[] Value=A068403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068403.Bytes);
public long this[int i]=>Value[i];

public static A068403Inst Instance=new A068403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068404
{
public static readonly long[] Value={ 27720L,50400L,55440L,60480L,65520L,75600L,83160L,85680L,90720L,95760L,98280L,100800L,105840L,110880L,115920L,120120L,120960L,128520L,131040L,138600L,141120L,143640L,151200L,163800L,166320L,171360L,176400L,180180L,181440L,184800L,191520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068404Inst : IEnumerable<long>
{
public static readonly long[] Value=A068404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068404.Bytes);
public long this[int i]=>Value[i];

public static A068404Inst Instance=new A068404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068405
{
public static readonly long[] Value={ 84L,90L,105L,110L,114L,132L,140L,154L,165L,182L,186L,204L,220L,234L,246L,252L,258L,264L,266L,273L,286L,290L,294L,300L,308L,318L,322L,340L,345L,354L,357L,364L,370L,380L,385L,402L,406L,410L,414L,426L,444L,450L,465L,468L,470L,480L,492L,504L,516L,518L,525L,532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068405Inst : IEnumerable<long>
{
public static readonly long[] Value=A068405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068405.Bytes);
public long this[int i]=>Value[i];

public static A068405Inst Instance=new A068405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068406
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,9L,10L,11L,13L,22L,23L,28L,29L,34L,38L,41L,45L,46L,53L,55L,57L,58L,72L,76L,77L,80L,81L,83L,85L,87L,88L,89L,91L,92L,93L,94L,100L,104L,106L,108L,112L,113L,117L,118L,121L,122L,123L,124L,125L,128L,129L,131L,133L,143L,145L,147L,148L,152L,159L,160L,161L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068406Inst : IEnumerable<long>
{
public static readonly long[] Value=A068406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068406.Bytes);
public long this[int i]=>Value[i];

public static A068406Inst Instance=new A068406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068407
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,24L,25L,32L,43L,49L,51L,57L,68L,75L,76L,93L,99L,125L,193L,249L,251L,307L,375L,376L,432L,443L,499L,501L,557L,568L,624L,625L,693L,749L,751L,807L,875L,943L,999L,1249L,1251L,1693L,1875L,2057L,2499L,2501L,2943L,3125L,3307L,3568L,3749L,3751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068407Inst : IEnumerable<long>
{
public static readonly long[] Value=A068407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068407.Bytes);
public long this[int i]=>Value[i];

public static A068407Inst Instance=new A068407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068408
{
public static readonly long[] Value={ 0L,1L,5L,6L,16L,21L,25L,36L,41L,56L,61L,76L,81L,96L,176L,201L,376L,401L,576L,601L,625L,776L,801L,976L,1376L,2001L,3376L,4001L,5376L,6001L,7376L,8001L,9376L,20001L,29376L,40001L,49376L,60001L,69376L,80001L,89376L,90625L,109376L,200001L,309376L,400001L,509376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068408Inst : IEnumerable<long>
{
public static readonly long[] Value=A068408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068408.Bytes);
public long this[int i]=>Value[i];

public static A068408Inst Instance=new A068408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068409
{
public static readonly BigInteger[] Value={ 1L,2L,15L,1140L,916895L,8137369800L,850423134076516L,BigInteger.Parse("1105964895591808388136"),BigInteger.Parse("18627853605123584223921210120"),BigInteger.Parse("4180709311038401636820646431913319660"),BigInteger.Parse("12767818425644517198178541333546326811326975100") };
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
public class A068409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068409Inst Instance=new A068409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068410
{
public static readonly long[] Value={ 64L,132L,528L,792L,1104L,1648L,1728L,2058L,2320L,2464L,2700L,2820L,4186L,5184L,6304L,6540L,6600L,6696L,6816L,7470L,7612L,8112L,8910L,10584L,10962L,11520L,13212L,13332L,13426L,14700L,14980L,15840L,18720L,19170L,19200L,19908L,21348L,21666L,22176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068410Inst : IEnumerable<long>
{
public static readonly long[] Value=A068410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068410.Bytes);
public long this[int i]=>Value[i];

public static A068410Inst Instance=new A068410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068411
{
public static readonly long[] Value={ 25L,33L,93L,165L,205L,217L,325L,341L,385L,425L,465L,561L,645L,697L,793L,825L,1023L,1025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068411Inst : IEnumerable<long>
{
public static readonly long[] Value=A068411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068411.Bytes);
public long this[int i]=>Value[i];

public static A068411Inst Instance=new A068411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068412
{
public static readonly long[] Value={ 6L,12L,28L,42L,60L,168L,456L,496L,828L,1080L,1242L,1530L,1560L,3360L,3672L,4560L,7320L,7584L,8128L,11400L,14784L,19488L,21648L,33462L,37536L,40608L,44856L,48024L,59520L,83904L,87648L,221088L,352704L,354384L,560664L,613440L,1288224L,1365984L,1420320L,1482480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068412Inst : IEnumerable<long>
{
public static readonly long[] Value=A068412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068412.Bytes);
public long this[int i]=>Value[i];

public static A068412Inst Instance=new A068412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068413
{
public static readonly BigInteger[] Value={ 1L,2L,5L,22L,231L,8349L,1741630L,4351078600L,365749566870782L,BigInteger.Parse("4453575699570940947378"),BigInteger.Parse("61847822068260244309086870983975"),BigInteger.Parse("18116048323611252751541173214616030020513022685"),BigInteger.Parse("6927233917602120527467409170319882882996950147283323368445315320451") };
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
public class A068413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068413Inst Instance=new A068413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068414
{
public static readonly long[] Value={ 1L,12L,56L,260L,992L,1976L,2156L,2754L,16256L,25232L,41072L,133984L,145888L,1100864L,1270208L,1439552L,2237888L,4729664L,67100672L,75398912L,171627376L,277060144L,473089984L,538178048L,558585344L,629225984L,1192258048L,1863840112L,2181070592L,4534854656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068414Inst : IEnumerable<long>
{
public static readonly long[] Value=A068414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068414.Bytes);
public long this[int i]=>Value[i];

public static A068414Inst Instance=new A068414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068415
{
public static readonly long[] Value={ 1L,3L,16L,36L,211L,971L,1546L,1619L,1676L,2781L,5016L,41282L,342476L,906352L,1023757L,1948794L,7848891L,13836275L,30581008L,38602286L,170598710L,379204788L,619298045L,725045787L,1682291679L,24640189358L,24751265017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068415Inst : IEnumerable<long>
{
public static readonly long[] Value=A068415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068415.Bytes);
public long this[int i]=>Value[i];

public static A068415Inst Instance=new A068415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068416
{
public static readonly BigInteger[] Value={ 0L,6L,53L,627L,16213L,1123743L,221984391L,127561384993L,215767063451331L,1082828220389781579L,BigInteger.Parse("16209089366362071416785"),BigInteger.Parse("726438398002211876667379681"),BigInteger.Parse("97741115155002465272674416929195"),BigInteger.Parse("39565596445488219947994403962984729307") };
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
public class A068416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068416Inst Instance=new A068416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068417
{
public static readonly BigInteger[] Value={ 0L,4L,258L,10830L,709351L,99699033L,34719687359L,32128580602967L,82102610820820733L,BigInteger.Parse("593301237469990370097") };
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
public class A068417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068417Inst Instance=new A068417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068418
{
public static readonly long[] Value={ 12L,56L,260L,992L,1320L,1976L,2156L,2754L,3696L,5520L,13800L,16256L,19872L,22560L,23688L,25232L,41072L,87000L,89964L,133984L,145888L,366720L,785808L,851760L,1100864L,1235052L,1270208L,1439552L,1470720L,2129400L,2237888L,4729664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068418Inst : IEnumerable<long>
{
public static readonly long[] Value=A068418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068418.Bytes);
public long this[int i]=>Value[i];

public static A068418Inst Instance=new A068418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068419
{
public static readonly long[] Value={ 5L,11L,7L,23L,11L,47L,79L,73L,67L,23L,191L,283L,383L,739L,47L,1459L,281L,607L,59L,1153L,1069L,3319L,83L,1801L,2671L,3517L,743L,107L,6679L,3529L,6619L,6143L,6271L,4153L,10169L,9817L,167L,6451L,179L,24097L,23539L,10369L,227L,263L,16369L,41203L,20809L,54919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068419Inst : IEnumerable<long>
{
public static readonly long[] Value=A068419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068419.Bytes);
public long this[int i]=>Value[i];

public static A068419Inst Instance=new A068419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068436
{
public static readonly long[] Value={ 3L,1L,6L,1L,5L,0L,7L,0L,2L,8L,6L,5L,10L,4L,8L,5L,2L,3L,5L,2L,1L,5L,2L,5L,9L,7L,7L,7L,5L,2L,9L,4L,1L,8L,3L,8L,6L,6L,8L,8L,4L,8L,8L,5L,3L,1L,6L,3L,10L,1L,10L,5L,4L,2L,1L,3L,0L,0L,4L,6L,5L,8L,0L,6L,5L,2L,2L,7L,3L,5L,0L,5L,3L,3L,7L,1L,5L,2L,7L,1L,7L,8L,1L,10L,6L,5L,6L,3L,7L,1L,5L,7L,8L,1L,3L,3L,4L,9L,2L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068436Inst : IEnumerable<long>
{
public static readonly long[] Value=A068436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068436.Bytes);
public long this[int i]=>Value[i];

public static A068436Inst Instance=new A068436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068437
{
public static readonly long[] Value={ 3L,1L,8L,4L,8L,0L,9L,4L,9L,3L,11L,9L,1L,8L,6L,6L,4L,5L,7L,3L,10L,6L,2L,1L,1L,11L,11L,1L,5L,1L,5L,5L,1L,10L,0L,5L,7L,2L,9L,2L,9L,0L,10L,7L,8L,0L,9L,10L,4L,9L,2L,7L,4L,2L,1L,4L,0L,10L,6L,0L,10L,5L,5L,2L,5L,6L,10L,0L,6L,6L,1L,10L,0L,3L,7L,5L,3L,10L,3L,10L,10L,5L,4L,8L,0L,5L,6L,4L,6L,8L,8L,0L,1L,8L,1L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068437Inst : IEnumerable<long>
{
public static readonly long[] Value=A068437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068437.Bytes);
public long this[int i]=>Value[i];

public static A068437Inst Instance=new A068437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068438
{
public static readonly long[] Value={ 3L,1L,10L,12L,1L,0L,4L,9L,0L,5L,2L,10L,2L,12L,7L,7L,3L,6L,9L,12L,0L,11L,11L,8L,9L,12L,12L,9L,8L,8L,3L,2L,7L,8L,2L,9L,8L,3L,5L,8L,11L,3L,7L,0L,1L,6L,0L,3L,0L,6L,1L,3L,3L,12L,10L,5L,10L,12L,11L,10L,5L,7L,6L,1L,4L,11L,6L,5L,11L,4L,1L,0L,0L,2L,0L,12L,2L,2L,11L,4L,12L,7L,1L,4L,5L,7L,10L,9L,5L,5L,10L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068438Inst : IEnumerable<long>
{
public static readonly long[] Value=A068438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068438.Bytes);
public long this[int i]=>Value[i];

public static A068438Inst Instance=new A068438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068439
{
public static readonly long[] Value={ 3L,1L,13L,10L,7L,5L,12L,13L,10L,8L,1L,3L,7L,5L,4L,2L,7L,10L,4L,0L,10L,11L,12L,11L,1L,11L,13L,4L,7L,5L,4L,9L,12L,8L,9L,11L,12L,11L,6L,8L,6L,1L,13L,3L,3L,2L,7L,12L,7L,4L,0L,12L,10L,11L,8L,0L,9L,10L,5L,2L,13L,0L,13L,13L,5L,1L,7L,1L,8L,7L,4L,5L,0L,4L,10L,5L,4L,8L,1L,12L,12L,9L,1L,5L,4L,9L,0L,11L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068439Inst : IEnumerable<long>
{
public static readonly long[] Value=A068439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068439.Bytes);
public long this[int i]=>Value[i];

public static A068439Inst Instance=new A068439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068440
{
public static readonly long[] Value={ 3L,2L,1L,12L,13L,1L,13L,12L,4L,6L,12L,2L,11L,7L,14L,5L,0L,8L,4L,8L,4L,7L,7L,3L,14L,0L,6L,9L,1L,9L,13L,1L,14L,5L,0L,9L,6L,3L,13L,11L,7L,9L,12L,6L,9L,7L,3L,9L,14L,10L,3L,7L,3L,1L,14L,7L,9L,12L,13L,14L,1L,0L,10L,8L,14L,13L,4L,12L,6L,3L,0L,10L,8L,3L,11L,9L,11L,5L,13L,10L,4L,6L,4L,10L,9L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068440Inst : IEnumerable<long>
{
public static readonly long[] Value=A068440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068440.Bytes);
public long this[int i]=>Value[i];

public static A068440Inst Instance=new A068440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068441
{
public static readonly long[] Value={ 2L,3L,5L,6L,11L,16L,17L,18L,22L,28L,30L,32L,33L,34L,35L,36L,41L,43L,44L,48L,49L,50L,52L,53L,54L,56L,58L,62L,63L,66L,68L,71L,72L,73L,76L,78L,79L,80L,83L,85L,86L,88L,90L,92L,96L,98L,99L,106L,107L,108L,109L,111L,112L,114L,115L,116L,117L,118L,119L,120L,122L,123L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068441Inst : IEnumerable<long>
{
public static readonly long[] Value=A068441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068441.Bytes);
public long this[int i]=>Value[i];

public static A068441Inst Instance=new A068441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068442
{
public static readonly long[] Value={ 6L,10L,11L,17L,18L,19L,21L,25L,30L,32L,34L,35L,39L,40L,41L,43L,45L,49L,57L,58L,61L,64L,65L,75L,78L,79L,80L,85L,88L,89L,95L,96L,98L,103L,109L,113L,115L,116L,119L,122L,123L,125L,126L,128L,134L,135L,139L,140L,141L,143L,145L,147L,148L,153L,155L,159L,163L,165L,166L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068442Inst : IEnumerable<long>
{
public static readonly long[] Value=A068442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068442.Bytes);
public long this[int i]=>Value[i];

public static A068442Inst Instance=new A068442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068443
{
public static readonly long[] Value={ 6L,10L,15L,21L,55L,91L,253L,703L,1081L,1711L,1891L,2701L,3403L,5671L,12403L,13861L,15931L,18721L,25651L,34453L,38503L,49141L,60031L,64261L,73153L,79003L,88831L,104653L,108811L,114481L,126253L,146611L,158203L,171991L,188191L,218791L,226801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068443Inst : IEnumerable<long>
{
public static readonly long[] Value=A068443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068443.Bytes);
public long this[int i]=>Value[i];

public static A068443Inst Instance=new A068443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068444
{
public static readonly long[] Value={ 10L,7L,10L,25L,94L,463L,2770L,19381L,155038L,1395331L,13953298L,153486265L,1841835166L,23943857143L,335213999986L,5028209999773L,80451359996350L,1367673119937931L,24618116158882738L,467744207018772001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068444Inst : IEnumerable<long>
{
public static readonly long[] Value=A068444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068444.Bytes);
public long this[int i]=>Value[i];

public static A068444Inst Instance=new A068444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068445
{
public static readonly long[] Value={ 101101L,129921L,1837381L,127665878878566721L,1037998220228997301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068445Inst : IEnumerable<long>
{
public static readonly long[] Value=A068445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068445.Bytes);
public long this[int i]=>Value[i];

public static A068445Inst Instance=new A068445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068446
{
public static readonly long[] Value={ 2L,0L,1L,1L,3L,1L,6L,6L,2L,3L,5L,2L,12L,1L,7L,1L,3L,10L,12L,19L,10L,18L,21L,6L,3L,10L,10L,26L,18L,0L,26L,30L,5L,21L,21L,5L,28L,34L,22L,9L,28L,32L,0L,9L,19L,20L,8L,9L,16L,43L,28L,22L,4L,40L,54L,17L,51L,55L,31L,18L,52L,37L,55L,0L,45L,61L,16L,41L,62L,53L,20L,31L,49L,63L,62L,20L,69L,1L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068446Inst : IEnumerable<long>
{
public static readonly long[] Value=A068446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068446.Bytes);
public long this[int i]=>Value[i];

public static A068446Inst Instance=new A068446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068447
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,5L,1L,7L,2L,4L,6L,0L,8L,8L,14L,14L,14L,12L,0L,14L,2L,5L,15L,9L,11L,25L,12L,9L,1L,21L,29L,29L,20L,22L,29L,21L,27L,10L,4L,13L,20L,20L,30L,11L,7L,18L,18L,15L,39L,8L,47L,41L,51L,36L,28L,50L,35L,32L,6L,38L,23L,41L,45L,49L,36L,11L,31L,60L,5L,50L,42L,61L,1L,61L,68L,43L,76L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068447Inst : IEnumerable<long>
{
public static readonly long[] Value=A068447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068447.Bytes);
public long this[int i]=>Value[i];

public static A068447Inst Instance=new A068447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068448
{
public static readonly long[] Value={ 1L,0L,0L,3L,2L,2L,1L,3L,4L,5L,8L,10L,11L,7L,13L,13L,3L,14L,11L,16L,6L,9L,3L,14L,0L,16L,22L,9L,8L,26L,5L,18L,6L,3L,13L,31L,4L,27L,25L,5L,12L,1L,17L,31L,2L,4L,16L,17L,39L,15L,15L,25L,52L,40L,50L,3L,27L,32L,54L,18L,55L,10L,29L,62L,38L,4L,17L,53L,13L,24L,22L,40L,23L,11L,74L,18L,74L,31L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068448Inst : IEnumerable<long>
{
public static readonly long[] Value=A068448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068448.Bytes);
public long this[int i]=>Value[i];

public static A068448Inst Instance=new A068448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068449
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,1L,0L,7L,7L,3L,3L,6L,4L,10L,9L,1L,15L,2L,8L,10L,14L,6L,4L,7L,3L,3L,2L,2L,7L,26L,3L,30L,3L,31L,9L,29L,23L,12L,29L,3L,0L,12L,1L,11L,4L,13L,22L,17L,24L,33L,40L,34L,48L,27L,15L,5L,33L,33L,51L,48L,42L,46L,47L,38L,35L,30L,27L,1L,51L,52L,28L,25L,13L,30L,51L,14L,39L,12L,9L,58L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068449Inst : IEnumerable<long>
{
public static readonly long[] Value=A068449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068449.Bytes);
public long this[int i]=>Value[i];

public static A068449Inst Instance=new A068449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068450
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,1L,1L,3L,0L,5L,10L,6L,8L,12L,0L,10L,0L,12L,9L,6L,12L,22L,21L,24L,3L,14L,21L,13L,24L,21L,11L,8L,22L,27L,3L,8L,1L,36L,21L,27L,15L,2L,41L,22L,34L,8L,0L,4L,8L,39L,48L,27L,38L,22L,0L,23L,49L,19L,27L,29L,28L,40L,33L,21L,62L,7L,67L,33L,8L,30L,18L,60L,73L,61L,72L,42L,59L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068450Inst : IEnumerable<long>
{
public static readonly long[] Value=A068450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068450.Bytes);
public long this[int i]=>Value[i];

public static A068450Inst Instance=new A068450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068451
{
public static readonly long[] Value={ 1L,1L,0L,2L,4L,0L,6L,7L,1L,1L,8L,1L,6L,0L,11L,0L,10L,5L,6L,9L,15L,20L,10L,15L,1L,18L,5L,13L,9L,0L,13L,15L,2L,27L,28L,2L,32L,36L,11L,4L,34L,37L,0L,4L,32L,10L,4L,4L,32L,46L,39L,37L,2L,20L,27L,8L,54L,27L,45L,9L,26L,18L,59L,0L,22L,63L,41L,54L,65L,61L,45L,51L,61L,31L,68L,48L,34L,39L,71L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068451Inst : IEnumerable<long>
{
public static readonly long[] Value=A068451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068451.Bytes);
public long this[int i]=>Value[i];

public static A068451Inst Instance=new A068451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068452
{
public static readonly long[] Value={ 9L,1L,2L,0L,4L,2L,0L,6L,4L,0L,4L,11L,6L,4L,14L,8L,12L,6L,18L,12L,12L,14L,13L,2L,7L,20L,12L,2L,16L,21L,25L,26L,29L,19L,7L,3L,20L,3L,38L,7L,12L,19L,37L,1L,23L,32L,19L,32L,38L,45L,45L,27L,44L,34L,14L,49L,35L,29L,30L,57L,57L,18L,56L,48L,33L,19L,44L,35L,12L,56L,28L,38L,64L,35L,10L,45L,35L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068452Inst : IEnumerable<long>
{
public static readonly long[] Value=A068452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068452.Bytes);
public long this[int i]=>Value[i];

public static A068452Inst Instance=new A068452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068453
{
public static readonly long[] Value={ 1L,1L,0L,3L,2L,5L,0L,4L,3L,9L,8L,2L,8L,0L,10L,15L,2L,10L,8L,19L,12L,4L,18L,23L,8L,4L,21L,15L,17L,1L,11L,19L,7L,25L,15L,3L,20L,5L,24L,25L,35L,9L,12L,25L,26L,22L,23L,11L,43L,46L,6L,0L,25L,27L,30L,6L,14L,20L,33L,5L,30L,23L,42L,4L,11L,19L,55L,63L,43L,12L,52L,51L,22L,29L,11L,8L,19L,35L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068453Inst : IEnumerable<long>
{
public static readonly long[] Value=A068453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068453.Bytes);
public long this[int i]=>Value[i];

public static A068453Inst Instance=new A068453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068454
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,2L,4L,0L,8L,3L,4L,9L,10L,5L,3L,12L,4L,1L,10L,0L,6L,19L,0L,19L,10L,21L,19L,16L,3L,27L,24L,12L,12L,14L,7L,33L,27L,15L,28L,15L,7L,15L,7L,21L,13L,29L,16L,44L,39L,27L,39L,17L,6L,18L,2L,21L,21L,35L,29L,12L,13L,6L,39L,14L,1L,23L,55L,34L,10L,42L,70L,14L,42L,26L,74L,64L,12L,42L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068454Inst : IEnumerable<long>
{
public static readonly long[] Value=A068454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068454.Bytes);
public long this[int i]=>Value[i];

public static A068454Inst Instance=new A068454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068455
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,3L,3L,2L,4L,5L,6L,5L,9L,14L,11L,3L,4L,0L,15L,5L,7L,10L,17L,11L,14L,12L,22L,4L,17L,21L,15L,26L,21L,9L,3L,23L,0L,4L,31L,39L,21L,13L,26L,16L,25L,27L,13L,27L,21L,19L,46L,17L,21L,25L,50L,21L,44L,55L,23L,20L,22L,10L,49L,37L,5L,55L,51L,39L,40L,63L,2L,6L,17L,61L,52L,9L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068455Inst : IEnumerable<long>
{
public static readonly long[] Value=A068455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068455.Bytes);
public long this[int i]=>Value[i];

public static A068455Inst Instance=new A068455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068456
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,5L,7L,9L,5L,2L,12L,13L,10L,10L,4L,4L,4L,14L,4L,10L,14L,12L,9L,22L,9L,11L,9L,8L,14L,26L,25L,28L,22L,35L,0L,24L,0L,20L,18L,13L,21L,31L,30L,22L,24L,19L,34L,16L,42L,36L,46L,35L,46L,32L,16L,34L,53L,11L,44L,45L,49L,36L,49L,13L,53L,67L,53L,63L,11L,9L,9L,16L,37L,59L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068456Inst : IEnumerable<long>
{
public static readonly long[] Value=A068456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068456.Bytes);
public long this[int i]=>Value[i];

public static A068456Inst Instance=new A068456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068457
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,2L,6L,4L,3L,5L,10L,0L,1L,11L,14L,4L,2L,1L,17L,12L,19L,18L,18L,6L,7L,24L,24L,7L,9L,14L,28L,27L,14L,4L,19L,33L,24L,4L,14L,29L,21L,38L,17L,20L,5L,22L,30L,7L,13L,44L,19L,4L,19L,19L,14L,7L,48L,9L,58L,49L,17L,26L,35L,33L,36L,9L,28L,36L,54L,36L,70L,0L,33L,29L,45L,14L,46L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068457Inst : IEnumerable<long>
{
public static readonly long[] Value=A068457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068457.Bytes);
public long this[int i]=>Value[i];

public static A068457Inst Instance=new A068457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068458
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,3L,0L,8L,8L,0L,7L,4L,12L,9L,8L,11L,11L,9L,16L,15L,11L,10L,11L,1L,16L,13L,25L,24L,0L,15L,23L,12L,32L,18L,21L,20L,15L,20L,19L,18L,1L,5L,18L,20L,13L,16L,35L,6L,46L,40L,28L,9L,3L,19L,34L,14L,6L,0L,26L,48L,45L,58L,10L,0L,36L,32L,21L,30L,42L,12L,65L,54L,26L,29L,15L,46L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068458Inst : IEnumerable<long>
{
public static readonly long[] Value=A068458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068458.Bytes);
public long this[int i]=>Value[i];

public static A068458Inst Instance=new A068458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068459
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,5L,0L,0L,9L,1L,3L,1L,0L,1L,11L,2L,15L,10L,18L,4L,16L,9L,20L,12L,6L,1L,23L,20L,14L,22L,0L,8L,9L,3L,26L,15L,6L,13L,11L,20L,32L,7L,12L,31L,39L,46L,36L,6L,49L,7L,10L,2L,5L,44L,11L,32L,41L,49L,21L,40L,17L,49L,62L,44L,13L,25L,67L,41L,57L,27L,13L,24L,35L,25L,43L,25L,27L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068459Inst : IEnumerable<long>
{
public static readonly long[] Value=A068459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068459.Bytes);
public long this[int i]=>Value[i];

public static A068459Inst Instance=new A068459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068460
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,0L,3L,0L,8L,8L,2L,11L,1L,5L,11L,1L,7L,1L,11L,16L,12L,12L,13L,5L,4L,26L,19L,12L,20L,0L,18L,14L,22L,6L,29L,0L,27L,16L,23L,23L,23L,34L,27L,4L,27L,18L,0L,10L,27L,42L,24L,9L,16L,6L,52L,2L,38L,44L,30L,51L,61L,7L,19L,0L,45L,18L,51L,43L,54L,7L,15L,69L,44L,51L,9L,74L,5L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068460Inst : IEnumerable<long>
{
public static readonly long[] Value=A068460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068460.Bytes);
public long this[int i]=>Value[i];

public static A068460Inst Instance=new A068460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068461
{
public static readonly long[] Value={ 2L,0L,2L,1L,2L,4L,3L,3L,1L,2L,4L,0L,3L,13L,1L,12L,12L,13L,1L,16L,16L,0L,16L,12L,10L,9L,1L,23L,3L,22L,0L,28L,11L,14L,23L,16L,0L,14L,6L,1L,1L,14L,4L,25L,43L,0L,29L,10L,41L,19L,47L,14L,0L,51L,10L,47L,37L,45L,46L,56L,57L,45L,10L,32L,61L,15L,9L,67L,5L,9L,22L,25L,65L,56L,24L,12L,71L,9L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068461Inst : IEnumerable<long>
{
public static readonly long[] Value=A068461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068461.Bytes);
public long this[int i]=>Value[i];

public static A068461Inst Instance=new A068461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068462
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,1L,1L,0L,0L,1L,5L,6L,10L,0L,11L,2L,13L,9L,9L,5L,15L,3L,1L,4L,18L,16L,3L,0L,27L,6L,8L,30L,7L,25L,31L,18L,9L,18L,9L,18L,38L,2L,2L,40L,26L,30L,41L,19L,9L,45L,39L,22L,28L,44L,20L,27L,33L,7L,3L,53L,6L,5L,4L,45L,44L,32L,4L,48L,53L,50L,15L,71L,53L,53L,1L,24L,23L,48L,56L,54L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068462Inst : IEnumerable<long>
{
public static readonly long[] Value=A068462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068462.Bytes);
public long this[int i]=>Value[i];

public static A068462Inst Instance=new A068462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068463
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,0L,2L,0L,7L,2L,1L,5L,1L,12L,12L,12L,12L,5L,7L,9L,4L,20L,10L,9L,6L,17L,20L,18L,7L,6L,11L,9L,24L,3L,22L,8L,24L,33L,35L,33L,31L,12L,0L,27L,6L,31L,37L,37L,27L,31L,6L,24L,7L,17L,12L,1L,39L,41L,51L,48L,21L,8L,15L,26L,46L,52L,43L,39L,7L,21L,60L,24L,58L,21L,57L,58L,36L,60L,25L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068463Inst : IEnumerable<long>
{
public static readonly long[] Value=A068463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068463.Bytes);
public long this[int i]=>Value[i];

public static A068463Inst Instance=new A068463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068464
{
public static readonly long[] Value={ 3L,1L,0L,3L,0L,0L,3L,0L,5L,3L,2L,7L,0L,2L,8L,9L,16L,3L,1L,15L,18L,8L,20L,7L,23L,8L,10L,11L,28L,29L,24L,30L,3L,16L,10L,8L,31L,11L,30L,35L,5L,5L,38L,32L,31L,42L,13L,17L,43L,3L,41L,27L,1L,14L,26L,52L,38L,22L,55L,46L,6L,35L,46L,34L,24L,52L,52L,64L,62L,25L,46L,56L,3L,71L,70L,22L,53L,63L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068464Inst : IEnumerable<long>
{
public static readonly long[] Value=A068464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068464.Bytes);
public long this[int i]=>Value[i];

public static A068464Inst Instance=new A068464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068465
{
public static readonly long[] Value={ 1L,2L,2L,5L,4L,1L,6L,7L,0L,2L,4L,6L,5L,1L,7L,7L,6L,4L,5L,1L,2L,9L,0L,9L,8L,3L,0L,3L,3L,6L,2L,8L,9L,0L,5L,2L,6L,8L,5L,1L,2L,3L,9L,2L,4L,8L,1L,0L,8L,0L,7L,0L,6L,1L,1L,2L,3L,0L,1L,1L,8L,9L,3L,8L,2L,8L,9L,8L,2L,2L,8L,8L,8L,4L,2L,6L,7L,9L,8L,3L,5L,7L,2L,3L,7L,1L,7L,2L,3L,7L,6L,2L,1L,4L,9L,1L,5L,0L,6L,6L,5L,8L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068465Inst : IEnumerable<long>
{
public static readonly long[] Value=A068465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068465.Bytes);
public long this[int i]=>Value[i];

public static A068465Inst Instance=new A068465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068466
{
public static readonly long[] Value={ 3L,6L,2L,5L,6L,0L,9L,9L,0L,8L,2L,2L,1L,9L,0L,8L,3L,1L,1L,9L,3L,0L,6L,8L,5L,1L,5L,5L,8L,6L,7L,6L,7L,2L,0L,0L,2L,9L,9L,5L,1L,6L,7L,6L,8L,2L,8L,8L,0L,0L,6L,5L,4L,6L,7L,4L,3L,3L,3L,7L,7L,9L,9L,9L,5L,6L,9L,9L,1L,9L,2L,4L,3L,5L,3L,8L,7L,2L,9L,1L,2L,1L,6L,1L,8L,3L,6L,0L,1L,3L,6L,7L,2L,3L,3L,8L,4L,3L,0L,0L,3L,6L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068466Inst : IEnumerable<long>
{
public static readonly long[] Value=A068466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068466.Bytes);
public long this[int i]=>Value[i];

public static A068466Inst Instance=new A068466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068467
{
public static readonly long[] Value={ 9L,0L,6L,4L,0L,2L,4L,7L,7L,0L,5L,5L,4L,7L,7L,0L,7L,7L,9L,8L,2L,6L,7L,1L,2L,8L,8L,9L,6L,6L,9L,1L,8L,0L,0L,0L,7L,4L,8L,7L,9L,1L,9L,2L,0L,7L,2L,0L,0L,1L,6L,3L,6L,6L,8L,5L,8L,3L,4L,4L,4L,9L,9L,8L,9L,2L,4L,7L,9L,8L,1L,0L,8L,8L,4L,6L,8L,2L,2L,8L,0L,4L,0L,4L,5L,9L,0L,0L,3L,4L,1L,8L,0L,8L,4L,6L,0L,7L,5L,0L,9L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068467Inst : IEnumerable<long>
{
public static readonly long[] Value=A068467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068467.Bytes);
public long this[int i]=>Value[i];

public static A068467Inst Instance=new A068467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068468
{
public static readonly long[] Value={ 5L,1L,4L,5L,1L,0L,1L,0L,1L,5L,0L,8L,3L,9L,3L,1L,2L,3L,0L,7L,3L,2L,8L,1L,1L,8L,6L,7L,7L,2L,7L,8L,9L,6L,1L,6L,5L,0L,6L,5L,6L,5L,7L,4L,6L,9L,0L,7L,1L,2L,8L,0L,1L,8L,3L,3L,7L,5L,4L,3L,4L,5L,7L,2L,2L,2L,4L,5L,5L,1L,4L,9L,4L,9L,3L,8L,2L,4L,9L,4L,6L,7L,7L,3L,2L,3L,8L,4L,2L,4L,7L,8L,6L,8L,7L,5L,9L,7L,4L,8L,0L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068468Inst : IEnumerable<long>
{
public static readonly long[] Value=A068468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068468.Bytes);
public long this[int i]=>Value[i];

public static A068468Inst Instance=new A068468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068469
{
public static readonly long[] Value={ 1L,1L,7L,6L,2L,4L,1L,7L,3L,8L,3L,8L,2L,5L,8L,2L,7L,5L,8L,8L,7L,2L,1L,5L,0L,4L,5L,1L,9L,3L,8L,0L,5L,2L,0L,9L,1L,1L,6L,9L,7L,3L,8L,9L,9L,0L,0L,2L,1L,6L,5L,5L,8L,3L,4L,9L,6L,0L,5L,0L,8L,3L,4L,6L,2L,3L,0L,4L,0L,8L,7L,2L,3L,7L,6L,8L,1L,5L,8L,6L,1L,8L,3L,3L,5L,7L,2L,0L,8L,3L,7L,3L,2L,5L,5L,7L,1L,8L,3L,1L,1L,3L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068469Inst : IEnumerable<long>
{
public static readonly long[] Value=A068469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068469.Bytes);
public long this[int i]=>Value[i];

public static A068469Inst Instance=new A068469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068470
{
public static readonly long[] Value={ 5L,8L,8L,5L,2L,7L,7L,2L,5L,0L,0L,1L,8L,0L,2L,8L,8L,7L,6L,6L,1L,1L,7L,6L,1L,8L,5L,3L,4L,0L,5L,7L,6L,9L,8L,0L,3L,9L,9L,0L,6L,9L,8L,6L,1L,8L,9L,8L,5L,9L,2L,4L,3L,3L,9L,3L,5L,1L,9L,8L,3L,4L,0L,7L,6L,2L,9L,3L,4L,2L,2L,5L,0L,2L,0L,2L,7L,1L,6L,2L,2L,1L,9L,4L,3L,3L,3L,8L,4L,5L,4L,4L,0L,2L,1L,8L,4L,1L,1L,0L,1L,0L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068470Inst : IEnumerable<long>
{
public static readonly long[] Value=A068470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068470.Bytes);
public long this[int i]=>Value[i];

public static A068470Inst Instance=new A068470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068471
{
public static readonly BigInteger[] Value={ 2L,16L,378L,30824L,8402216L,7664347268L,23371379782671L,238225926162821893L,BigInteger.Parse("8118262028301675826132"),BigInteger.Parse("924887563235974860108746534"),BigInteger.Parse("352261845112790535941917078458268") };
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
public class A068471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068471Inst Instance=new A068471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068472
{
public static readonly BigInteger[] Value={ 2L,16L,496L,58640L,26536192L,45851039232L,302758305892480L,7638804476736307712L,BigInteger.Parse("736437724731312162567680"),BigInteger.Parse("271287639195997221896855543808"),BigInteger.Parse("381862430868672544566361613406502912") };
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
public class A068472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068472Inst Instance=new A068472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068473
{
public static readonly long[] Value={ 31L,51L,77L,87L,158L,184L,297L,308L,573L,621L,766L,786L,799L,826L,1167L,1330L,1946L,2030L,2280L,3058L,3213L,5015L,5093L,5271L,5374L,8307L,8813L,9730L,10364L,10557L,11229L,12750L,13462L,14145L,15807L,20606L,23115L,24633L,24795L,26400L,28015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068473Inst : IEnumerable<long>
{
public static readonly long[] Value=A068473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068473.Bytes);
public long this[int i]=>Value[i];

public static A068473Inst Instance=new A068473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068474
{
public static readonly long[] Value={ 19L,47L,77L,79L,115L,177L,191L,267L,280L,297L,340L,398L,406L,446L,470L,639L,839L,917L,1240L,1655L,1713L,1778L,1836L,2140L,2157L,4715L,5110L,5269L,6585L,7089L,7965L,8517L,8844L,9785L,10281L,12586L,15279L,16100L,16468L,16732L,17724L,18145L,18256L,20728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068474Inst : IEnumerable<long>
{
public static readonly long[] Value=A068474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068474.Bytes);
public long this[int i]=>Value[i];

public static A068474Inst Instance=new A068474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068475
{
public static readonly BigInteger[] Value={ 0L,1L,5L,34L,313L,3711L,54121L,937924L,18831569L,429794605L,10987654321L,310989720966L,9652968253897L,326011399456939L,11901025061692313L,466937872906120456L,BigInteger.Parse("19594541482740368161"),BigInteger.Parse("875711370981239308953") };
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
public class A068475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068475Inst Instance=new A068475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068476
{
public static readonly BigInteger[] Value={ 0L,1L,20L,34L,5008L,3711L,1948356L,937924L,1205220416L,429794605L,1098765432100L,310989720966L,1390027428561168L,326011399456939L,2332600912091693348L,466937872906120456L,BigInteger.Parse("5016202619581534249216"),BigInteger.Parse("875711370981239308953") };
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
public class A068476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068476Inst Instance=new A068476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068477
{
public static readonly long[] Value={ 0L,1L,5L,9L,12L,15L,22L,10L,33L,45L,43L,60L,44L,79L,70L,72L,65L,90L,111L,91L,125L,117L,132L,168L,133L,127L,171L,189L,172L,195L,218L,232L,217L,234L,221L,243L,240L,280L,290L,261L,315L,348L,352L,325L,345L,351L,346L,303L,338L,367L,373L,396L,404L,414L,495L,424L,428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068477Inst : IEnumerable<long>
{
public static readonly long[] Value=A068477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068477.Bytes);
public long this[int i]=>Value[i];

public static A068477Inst Instance=new A068477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068478
{
public static readonly long[] Value={ 1L,5L,8L,60L,11640L,14881L,23098L,90040L,239883L,1631365L,2803282L,4276595L,4343763L,10834865L,50457394L,101387685L,349770616L,384832508L,1025023303L,1582124479L,7753484647L,14554741880L,110768341257L,246113848342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068478Inst : IEnumerable<long>
{
public static readonly long[] Value=A068478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068478.Bytes);
public long this[int i]=>Value[i];

public static A068478Inst Instance=new A068478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068479
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,205L,4009L,5523L,14063L,32669L,47704L,196620L,589791L,782889L,804393L,849445L,976320L,1256587L,1789793L,9067576L,17283444L,18567900L,24793858L,59704212L,60741675L,130071084L,216799081L,1518169585L,4849913556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068479Inst : IEnumerable<long>
{
public static readonly long[] Value=A068479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068479.Bytes);
public long this[int i]=>Value[i];

public static A068479Inst Instance=new A068479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068480
{
public static readonly long[] Value={ 1L,29L,41L,53L,69L,105L,125L,141L,153L,165L,189L,233L,249L,273L,293L,321L,329L,405L,413L,429L,441L,453L,485L,581L,585L,629L,641L,653L,713L,729L,741L,761L,765L,809L,813L,849L,893L,905L,989L,993L,1005L,1013L,1041L,1049L,1089L,1121L,1125L,1133L,1169L,1205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068480Inst : IEnumerable<long>
{
public static readonly long[] Value=A068480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068480.Bytes);
public long this[int i]=>Value[i];

public static A068480Inst Instance=new A068480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068481
{
public static readonly long[] Value={ 5L,9L,21L,33L,65L,81L,89L,113L,173L,209L,221L,245L,261L,281L,285L,309L,341L,345L,369L,393L,473L,509L,525L,545L,561L,593L,645L,725L,749L,785L,789L,833L,861L,873L,933L,953L,965L,1001L,1065L,1101L,1113L,1173L,1185L,1265L,1289L,1329L,1341L,1401L,1409L,1469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068481Inst : IEnumerable<long>
{
public static readonly long[] Value=A068481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068481.Bytes);
public long this[int i]=>Value[i];

public static A068481Inst Instance=new A068481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068482
{
public static readonly long[] Value={ 2L,3L,4L,6L,10L,12L,16L,18L,22L,23L,28L,30L,36L,39L,40L,42L,46L,51L,52L,58L,60L,63L,66L,70L,72L,78L,82L,88L,95L,96L,99L,100L,102L,106L,108L,112L,126L,130L,131L,135L,136L,138L,148L,150L,156L,162L,166L,172L,178L,180L,183L,190L,191L,192L,196L,198L,210L,215L,222L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068482Inst : IEnumerable<long>
{
public static readonly long[] Value=A068482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068482.Bytes);
public long this[int i]=>Value[i];

public static A068482Inst Instance=new A068482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068483
{
public static readonly long[] Value={ 11L,15L,35L,75L,83L,111L,119L,135L,155L,179L,219L,231L,243L,323L,359L,375L,455L,459L,483L,491L,515L,519L,525L,531L,551L,611L,615L,639L,651L,663L,699L,719L,723L,735L,771L,779L,783L,803L,879L,915L,923L,939L,999L,1043L,1103L,1119L,1175L,1199L,1271L,1323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068483Inst : IEnumerable<long>
{
public static readonly long[] Value=A068483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068483.Bytes);
public long this[int i]=>Value[i];

public static A068483Inst Instance=new A068483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068484
{
public static readonly long[] Value={ 1L,2L,10L,45L,65L,180L,212L,222L,369L,588L,810L,864L,1274L,1521L,1836L,2548L,2940L,3114L,3552L,4770L,5496L,5684L,6027L,6642L,8820L,9140L,10464L,10614L,13311L,14688L,15210L,20737L,21600L,22776L,26900L,27000L,27270L,28476L,28518L,42212L,42336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068484Inst : IEnumerable<long>
{
public static readonly long[] Value=A068484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068484.Bytes);
public long this[int i]=>Value[i];

public static A068484Inst Instance=new A068484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068485
{
public static readonly long[] Value={ 1L,3L,7L,29L,31L,42L,52L,85L,143L,161L,273L,330L,612L,1015L,1197L,1394L,1680L,1771L,2262L,2698L,2717L,3318L,3424L,3641L,4551L,4700L,5617L,6468L,7192L,8184L,8858L,8996L,9205L,9523L,9919L,10622L,11040L,11427L,11623L,15436L,17256L,17739L,18476L,18725L,19533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068485Inst : IEnumerable<long>
{
public static readonly long[] Value=A068485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068485.Bytes);
public long this[int i]=>Value[i];

public static A068485Inst Instance=new A068485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068486
{
public static readonly long[] Value={ 2L,5L,13L,17L,29L,37L,53L,73L,97L,101L,137L,193L,173L,197L,229L,257L,293L,349L,397L,401L,457L,509L,593L,577L,641L,677L,733L,809L,857L,1021L,977L,1033L,1093L,1181L,1229L,1297L,1373L,1453L,1621L,1601L,1697L,1789L,1913L,2017L,2029L,2141L,2213L,2473L,2417L,2549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068486Inst : IEnumerable<long>
{
public static readonly long[] Value=A068486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068486.Bytes);
public long this[int i]=>Value[i];

public static A068486Inst Instance=new A068486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068487
{
public static readonly long[] Value={ 5L,13L,73L,41L,61L,157L,113L,233L,181L,269L,317L,313L,569L,421L,709L,617L,613L,853L,761L,929L,1117L,1013L,1429L,1201L,1301L,1637L,1753L,1873L,1741L,1861L,2897L,2113L,2689L,2381L,2521L,3697L,2969L,3469L,3121L,3449L,3617L,3613L,4153L,4337L,4729L,4517L,4513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068487Inst : IEnumerable<long>
{
public static readonly long[] Value=A068487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068487.Bytes);
public long this[int i]=>Value[i];

public static A068487Inst Instance=new A068487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068488
{
public static readonly long[] Value={ 2L,4L,11L,47L,344L,17L,8L,69L,66L,67L,8028643011L,42L,18L,39L,162L,21L,59L,48L,2311331257L,179L,369L,2477L,23289L,32L,172011L,75668L,342L,35L,28757L,356411L,243L,297L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068488Inst : IEnumerable<long>
{
public static readonly long[] Value=A068488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068488.Bytes);
public long this[int i]=>Value[i];

public static A068488Inst Instance=new A068488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068489
{
public static readonly long[] Value={ 3L,10L,5L,343L,3248L,18L,16L,12L,22L,20324L,50L,9414916809095L,13120L,43L,8481L,1200361259L,196L,38L,10326732314L,65L,38L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068489Inst : IEnumerable<long>
{
public static readonly long[] Value=A068489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068489.Bytes);
public long this[int i]=>Value[i];

public static A068489Inst Instance=new A068489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068490
{
public static readonly BigInteger[] Value={ 1L,121L,12112121L,BigInteger.Parse("121121211211212112121"),BigInteger.Parse("1211212112112121121211211212112112121121211211212112121"),BigInteger.Parse("121121211211212112121121121211211212112121121121211212112112121121121211212112112121121121211212112112121121211211212112112121121211211212112121") };
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
public class A068490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068490Inst Instance=new A068490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068491
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,13L,17L,25L,31L,42L,52L,68L,81L,101L,119L,145L,168L,200L,229L,268L,303L,349L,392L,447L,497L,560L,619L,692L,760L,843L,921L,1015L,1103L,1208L,1308L,1426L,1537L,1667L,1791L,1935L,2072L,2230L,2381L,2554L,2719L,2907L,3088L,3293L,3489L,3710L,3923L,4162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068491Inst : IEnumerable<long>
{
public static readonly long[] Value=A068491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068491.Bytes);
public long this[int i]=>Value[i];

public static A068491Inst Instance=new A068491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068492
{
public static readonly long[] Value={ 11L,13L,17L,19L,71L,73L,89L,101L,103L,107L,131L,137L,149L,167L,173L,191L,197L,199L,223L,229L,233L,283L,307L,311L,313L,331L,337L,359L,383L,401L,433L,439L,461L,463L,491L,523L,569L,593L,631L,641L,647L,659L,709L,733L,743L,773L,809L,823L,859L,907L,911L,919L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068492Inst : IEnumerable<long>
{
public static readonly long[] Value=A068492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068492.Bytes);
public long this[int i]=>Value[i];

public static A068492Inst Instance=new A068492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068493
{
public static readonly long[] Value={ 11L,19L,41L,149L,181L,191L,199L,419L,449L,491L,499L,911L,919L,941L,991L,1181L,1259L,1289L,1361L,1481L,1499L,1811L,1949L,1999L,4111L,4259L,4289L,4441L,4481L,4649L,4729L,4919L,4999L,9161L,9181L,9199L,9419L,9491L,9649L,9811L,9941L,9949L,11119L,11149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068493Inst : IEnumerable<long>
{
public static readonly long[] Value=A068493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068493.Bytes);
public long this[int i]=>Value[i];

public static A068493Inst Instance=new A068493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068494
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,3L,2L,1L,0L,1L,2L,7L,0L,1L,0L,1L,4L,9L,2L,1L,0L,5L,2L,9L,4L,1L,6L,1L,0L,13L,2L,11L,0L,1L,2L,15L,8L,1L,6L,1L,4L,21L,2L,1L,0L,7L,10L,19L,4L,1L,0L,15L,8L,21L,2L,1L,12L,1L,2L,27L,0L,17L,6L,1L,4L,25L,22L,1L,0L,1L,2L,35L,4L,17L,6L,1L,16L,27L,2L,1L,12L,21L,2L,31L,8L,1L,18L,19L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068494Inst : IEnumerable<long>
{
public static readonly long[] Value=A068494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068494.Bytes);
public long this[int i]=>Value[i];

public static A068494Inst Instance=new A068494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068495
{
public static readonly long[] Value={ 6L,56L,260L,780L,992L,1976L,2156L,3696L,5520L,13800L,16256L,19872L,22560L,23688L,25232L,41072L,87000L,89964L,133984L,145888L,366720L,785808L,851760L,1100864L,1235052L,1270208L,1439552L,1470720L,2129400L,2237888L,4729664L,8690112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068495Inst : IEnumerable<long>
{
public static readonly long[] Value=A068495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068495.Bytes);
public long this[int i]=>Value[i];

public static A068495Inst Instance=new A068495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068496
{
public static readonly long[] Value={ 1L,2L,6L,8L,24L,16L,48L,128L,384L,768L,1280L,3072L,3072L,10240L,22528L,32768L,98304L,196608L,65536L,262144L,262144L,1572864L,6815744L,12582912L,29360128L,25165824L,8388608L,234881024L,369098752L,335544320L,738197504L,2147483648L,6442450944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068496Inst : IEnumerable<long>
{
public static readonly long[] Value=A068496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068496.Bytes);
public long this[int i]=>Value[i];

public static A068496Inst Instance=new A068496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068497
{
public static readonly long[] Value={ 13L,17L,43L,47L,59L,61L,67L,71L,73L,101L,103L,107L,109L,127L,137L,149L,151L,163L,167L,181L,193L,197L,223L,227L,241L,257L,263L,269L,277L,283L,311L,313L,317L,347L,349L,353L,373L,383L,389L,397L,401L,409L,421L,433L,449L,457L,461L,463L,467L,479L,487L,503L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068497Inst : IEnumerable<long>
{
public static readonly long[] Value=A068497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068497.Bytes);
public long this[int i]=>Value[i];

public static A068497Inst Instance=new A068497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068498
{
public static readonly long[] Value={ 8L,89L,377L,987L,1597L,2584L,6765L,28657L,46368L,196418L,3524578L,5702887L,39088169L,63245986L,267914296L,4807526976L,7778742049L,139583862445L,591286729879L,17167680177565L,27777890035288L,1304969544928657L,5527939700884757L,8944394323791464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068498Inst : IEnumerable<long>
{
public static readonly long[] Value=A068498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068498.Bytes);
public long this[int i]=>Value[i];

public static A068498Inst Instance=new A068498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068499
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,12L,16L,18L,22L,28L,30L,36L,40L,42L,46L,52L,58L,60L,66L,70L,72L,78L,82L,88L,96L,100L,102L,106L,108L,112L,126L,130L,136L,138L,148L,150L,156L,162L,166L,172L,178L,180L,190L,192L,196L,198L,210L,222L,226L,228L,232L,238L,240L,250L,256L,262L,268L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068499Inst : IEnumerable<long>
{
public static readonly long[] Value=A068499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068499.Bytes);
public long this[int i]=>Value[i];

public static A068499Inst Instance=new A068499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068580
{
public static readonly long[] Value={ 1L,5L,7L,15L,21L,22L,26L,40L,56L,66L,70L,78L,108L,120L,126L,168L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068580Inst : IEnumerable<long>
{
public static readonly long[] Value=A068580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068580.Bytes);
public long this[int i]=>Value[i];

public static A068580Inst Instance=new A068580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068581
{
public static readonly long[] Value={ 1L,17L,23L,29L,31L,37L,43L,51L,55L,65L,69L,77L,82L,87L,91L,93L,94L,95L,106L,111L,118L,122L,128L,129L,133L,134L,136L,142L,146L,158L,165L,170L,184L,195L,218L,230L,231L,232L,238L,243L,246L,248L,250L,254L,273L,282L,285L,286L,290L,296L,297L,310L,318L,322L,344L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068581Inst : IEnumerable<long>
{
public static readonly long[] Value=A068581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068581.Bytes);
public long this[int i]=>Value[i];

public static A068581Inst Instance=new A068581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068582
{
public static readonly long[] Value={ 1L,41L,47L,53L,59L,61L,67L,71L,73L,79L,85L,109L,115L,119L,123L,125L,127L,141L,143L,145L,155L,159L,161L,163L,166L,177L,178L,183L,185L,194L,201L,202L,203L,206L,209L,213L,214L,215L,217L,219L,226L,237L,247L,255L,259L,262L,278L,298L,301L,302L,314L,327L,328L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068582Inst : IEnumerable<long>
{
public static readonly long[] Value=A068582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068582.Bytes);
public long this[int i]=>Value[i];

public static A068582Inst Instance=new A068582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068583
{
public static readonly long[] Value={ 9L,25L,27L,81L,125L,5041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068583Inst : IEnumerable<long>
{
public static readonly long[] Value=A068583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068583.Bytes);
public long this[int i]=>Value[i];

public static A068583Inst Instance=new A068583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068584
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,15L,16L,17L,28L,29L,30L,31L,32L,49L,91L,92L,93L,94L,95L,96L,97L,98L,99L,125L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,243L,244L,245L,246L,247L,248L,249L,968L,969L,970L,971L,972L,973L,974L,975L,976L,977L,978L,979L,980L,981L,982L,983L,984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068584Inst : IEnumerable<long>
{
public static readonly long[] Value=A068584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068584.Bytes);
public long this[int i]=>Value[i];

public static A068584Inst Instance=new A068584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068585
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,10L,11L,12L,13L,14L,15L,16L,17L,27L,28L,29L,30L,31L,32L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,147L,289L,290L,291L,292L,293L,1004L,1005L,1006L,1007L,1008L,1009L,1010L,1011L,1012L,1013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068585Inst : IEnumerable<long>
{
public static readonly long[] Value=A068585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068585.Bytes);
public long this[int i]=>Value[i];

public static A068585Inst Instance=new A068585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068586
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,10L,11L,12L,13L,14L,15L,16L,17L,27L,28L,29L,30L,31L,32L,88L,89L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A068586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068586Inst : IEnumerable<long>
{
public static readonly long[] Value=A068586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A068586.Bytes);
public long this[int i]=>Value[i];

public static A068586Inst Instance=new A068586Inst();

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