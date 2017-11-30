using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A111341
{
public static readonly long[] Value={ 0L,0L,0L,50L,396L,6120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111341Inst : IEnumerable<long>
{
public static readonly long[] Value=A111341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111341.Bytes);
public long this[int i]=>Value[i];

public static A111341Inst Instance=new A111341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111342
{
public static readonly BigInteger[] Value={ 1L,2L,6L,28L,191L,1758L,20552L,292336L,4902711L,94682414L,2068050286L,50376290220L,1353408261849L,39741665020434L,1266001712189172L,43477659901096872L,1601086339395521724L,BigInteger.Parse("62931760277350226040"),BigInteger.Parse("2629518833911705359016"),BigInteger.Parse("116382349367962203872528"),BigInteger.Parse("5439115134893599838307636") };
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
public class A111342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111342Inst Instance=new A111342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111343
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,163L,1567L,18794L,271784L,4610375L,89779703L,1973367872L,48308239934L,1303031971629L,38388256758585L,1226260047168738L,42211658188907700L,1557608679494424852L,BigInteger.Parse("61330673937954704316"),BigInteger.Parse("2566587073634355132976"),BigInteger.Parse("113752830534050498513512"),BigInteger.Parse("5322732785525637634435108") };
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
public class A111343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111343Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111343.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111343Inst Instance=new A111343Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111344
{
public static readonly long[] Value={ 513L,13825L,32769L,59050L,110593L,157465L,177148L,186625L,262145L,279937L,497665L,1259713L,1327105L,2097153L,2125765L,2519425L,4718593L,4782970L,5668705L,6718465L,17915905L,18874369L,22674817L,33554433L,38263753L,56623105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111344Inst : IEnumerable<long>
{
public static readonly long[] Value=A111344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111344.Bytes);
public long this[int i]=>Value[i];

public static A111344Inst Instance=new A111344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111345
{
public static readonly long[] Value={ 4375L,19684L,7077889L,7962625L,34012225L,100663297L,129140164L,452984833L,459165025L,544195585L,644972545L,918330049L,5159780353L,7346640385L,8589934593L,13947137605L,14495514625L,23219011585L,27518828545L,28991029249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111345Inst : IEnumerable<long>
{
public static readonly long[] Value=A111345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111345.Bytes);
public long this[int i]=>Value[i];

public static A111345Inst Instance=new A111345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111346
{
public static readonly long[] Value={ 14348908L,134217729L,1073741825L,139314069505L,231928233985L,264479053825L,282429536482L,618475290625L,705277476865L,3570467226625L,4398046511105L,8349416423425L,21134460321793L,35664401793025L,91507169819845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111346Inst : IEnumerable<long>
{
public static readonly long[] Value=A111346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111346.Bytes);
public long this[int i]=>Value[i];

public static A111346Inst Instance=new A111346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111347
{
public static readonly long[] Value={ 11L,13L,14L,16L,17L,20L,30L,31L,32L,34L,35L,37L,38L,50L,70L,71L,73L,74L,76L,79L,91L,92L,95L,97L,98L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111347Inst : IEnumerable<long>
{
public static readonly long[] Value=A111347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111347.Bytes);
public long this[int i]=>Value[i];

public static A111347Inst Instance=new A111347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111348
{
public static readonly long[] Value={ 101L,104L,106L,107L,110L,112L,113L,118L,119L,124L,125L,128L,130L,131L,133L,134L,136L,140L,142L,145L,146L,149L,151L,152L,157L,160L,164L,166L,167L,170L,172L,175L,179L,181L,182L,188L,191L,194L,196L,199L,200L,300L,301L,305L,310L,311L,313L,316L,320L,322L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111348Inst : IEnumerable<long>
{
public static readonly long[] Value=A111348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111348.Bytes);
public long this[int i]=>Value[i];

public static A111348Inst Instance=new A111348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111349
{
public static readonly long[] Value={ 1003L,1004L,1007L,1009L,1010L,1012L,1013L,1015L,1016L,1018L,1019L,1021L,1024L,1025L,1030L,1031L,1040L,1043L,1049L,1051L,1054L,1055L,1060L,1061L,1063L,1070L,1082L,1085L,1088L,1091L,1094L,1096L,1099L,1100L,1105L,1106L,1108L,1112L,1114L,1118L,1123L,1126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111349Inst : IEnumerable<long>
{
public static readonly long[] Value=A111349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111349.Bytes);
public long this[int i]=>Value[i];

public static A111349Inst Instance=new A111349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111350
{
public static readonly long[] Value={ 4L,16L,25L,64L,100L,144L,169L,196L,225L,289L,324L,361L,529L,784L,961L,1024L,1521L,1936L,2304L,2401L,2500L,2809L,2916L,3025L,3249L,3364L,3600L,3969L,4096L,4624L,4761L,5041L,5776L,6084L,6561L,6724L,7056L,7225L,7396L,7921L,8100L,8281L,10816L,11664L,12321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111350Inst : IEnumerable<long>
{
public static readonly long[] Value=A111350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111350.Bytes);
public long this[int i]=>Value[i];

public static A111350Inst Instance=new A111350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111351
{
public static readonly long[] Value={ 9L,33L,51L,129L,201L,289L,339L,393L,451L,579L,649L,723L,1059L,1569L,1923L,2049L,3043L,3873L,4609L,4803L,5001L,5619L,5833L,6051L,6499L,6729L,7201L,7939L,8193L,9249L,9523L,10083L,11553L,12169L,13123L,13449L,14113L,14451L,14793L,15843L,16201L,16563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111351Inst : IEnumerable<long>
{
public static readonly long[] Value=A111351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111351.Bytes);
public long this[int i]=>Value[i];

public static A111351Inst Instance=new A111351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111352
{
public static readonly long[] Value={ 1L,-1L,2L,0L,5L,7L,22L,48L,121L,287L,698L,1680L,4061L,9799L,23662L,57120L,137905L,332927L,803762L,1940448L,4684661L,11309767L,27304198L,65918160L,159140521L,384199199L,927538922L,2239277040L,5406093005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111352Inst : IEnumerable<long>
{
public static readonly long[] Value=A111352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111352.Bytes);
public long this[int i]=>Value[i];

public static A111352Inst Instance=new A111352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111353
{
public static readonly long[] Value={ 2L,1L,3L,3L,3L,3L,3L,3L,4L,5L,2L,3L,4L,2L,3L,7L,4L,5L,5L,2L,4L,4L,3L,5L,3L,1L,4L,3L,3L,2L,4L,5L,3L,3L,5L,3L,6L,4L,2L,2L,3L,4L,5L,4L,4L,3L,4L,4L,4L,3L,5L,3L,5L,5L,6L,3L,4L,4L,3L,3L,3L,5L,6L,3L,4L,6L,4L,4L,4L,4L,4L,3L,6L,7L,3L,4L,4L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111353Inst : IEnumerable<long>
{
public static readonly long[] Value=A111353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111353.Bytes);
public long this[int i]=>Value[i];

public static A111353Inst Instance=new A111353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111354
{
public static readonly long[] Value={ 2L,7L,13L,19L,121L,188L,252L,368L,605L,745L,1085L,1127L,1406L,1743L,1774L,2042L,2087L,2936L,3196L,3207L,3457L,4045L,7584L,10307L,12603L,12632L,14438L,14526L,14641L,15662L,15950L,16261L,18084L,18937L,19676L,40984L,45531L,46009L,48292L,48590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111354Inst : IEnumerable<long>
{
public static readonly long[] Value=A111354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111354.Bytes);
public long this[int i]=>Value[i];

public static A111354Inst Instance=new A111354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111355
{
public static readonly long[] Value={ 2L,4L,222L,154L,754L,204L,14L,246L,1300L,3642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111355Inst : IEnumerable<long>
{
public static readonly long[] Value=A111355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111355.Bytes);
public long this[int i]=>Value[i];

public static A111355Inst Instance=new A111355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111356
{
public static readonly long[] Value={ 21L,24L,27L,36L,39L,57L,60L,64L,66L,75L,77L,84L,90L,93L,95L,100L,102L,105L,111L,129L,130L,132L,138L,144L,145L,150L,160L,162L,165L,168L,174L,175L,180L,183L,196L,201L,204L,210L,216L,219L,221L,230L,237L,246L,255L,256L,270L,275L,276L,282L,291L,295L,297L,309L,312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111356Inst : IEnumerable<long>
{
public static readonly long[] Value=A111356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111356.Bytes);
public long this[int i]=>Value[i];

public static A111356Inst Instance=new A111356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111357
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,4L,12L,23L,73L,191L,649L,2054L,7209L,24963L,89376L,320133L,1160752L,4218225L,15414908L,56474453L,207586410L,764855802L,2825168619L,10458049611L,38795658003L,144203518881L,537031911877L,2003618333624L,7488436558647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111357Inst : IEnumerable<long>
{
public static readonly long[] Value=A111357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111357.Bytes);
public long this[int i]=>Value[i];

public static A111357Inst Instance=new A111357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111358
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,4L,12L,23L,71L,187L,627L,1970L,6833L,23384L,82625L,292164L,1045329L,3750277L,13532724L,48977625L,177919099L,648145255L,2368046117L,8674199554L,31854078139L,117252592450L,432576302286L,1599320144703L,5925181102878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111358Inst : IEnumerable<long>
{
public static readonly long[] Value=A111358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111358.Bytes);
public long this[int i]=>Value[i];

public static A111358Inst Instance=new A111358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111359
{
public static readonly long[] Value={ 3L,6L,9L,10L,13L,42L,73L,184L,511L,690L,3275L,18918L,20574L,21340L,44140L,116669L,543214L,567016L,637321L,688792L,878649L,2582446L,27067133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111359Inst : IEnumerable<long>
{
public static readonly long[] Value=A111359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111359.Bytes);
public long this[int i]=>Value[i];

public static A111359Inst Instance=new A111359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111360
{
public static readonly long[] Value={ 1L,2L,3L,9L,21L,129L,5663L,40087L,184971L,246901L,251737L,1610143L,3098384123L,19819945093L,21323898091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111360Inst : IEnumerable<long>
{
public static readonly long[] Value=A111360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111360.Bytes);
public long this[int i]=>Value[i];

public static A111360Inst Instance=new A111360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111361
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,5L,2L,8L,5L,12L,8L,25L,13L,30L,23L,51L,33L,76L,51L,109L,78L,144L,106L,218L,150L,274L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111361Inst : IEnumerable<long>
{
public static readonly long[] Value=A111361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111361.Bytes);
public long this[int i]=>Value[i];

public static A111361Inst Instance=new A111361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111362
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,0L,3L,7L,8L,7L,6L,4L,0L,1L,9L,2L,9L,0L,0L,0L,9L,5L,2L,3L,0L,8L,8L,7L,5L,0L,7L,2L,6L,0L,9L,9L,8L,5L,6L,0L,6L,7L,9L,8L,7L,4L,6L,4L,3L,3L,8L,9L,8L,6L,0L,3L,5L,0L,1L,8L,8L,6L,1L,7L,8L,9L,4L,0L,8L,7L,3L,2L,1L,4L,0L,6L,9L,7L,4L,5L,0L,0L,4L,5L,7L,8L,5L,8L,8L,2L,5L,5L,2L,7L,6L,0L,4L,9L,3L,0L,1L,0L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111362Inst : IEnumerable<long>
{
public static readonly long[] Value=A111362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111362.Bytes);
public long this[int i]=>Value[i];

public static A111362Inst Instance=new A111362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111363
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,27L,31L,33L,37L,51L,53L,57L,61L,63L,127L,131L,133L,137L,151L,153L,161L,165L,167L,171L,173L,175L,177L,181L,185L,193L,195L,199L,201L,203L,215L,217L,221L,227L,229L,231L,235L,237L,241L,243L,245L,261L,263L,265L,273L,275L,279L,283L,287L,289L,291L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111363Inst : IEnumerable<long>
{
public static readonly long[] Value=A111363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111363.Bytes);
public long this[int i]=>Value[i];

public static A111363Inst Instance=new A111363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111364
{
public static readonly long[] Value={ 1L,2L,5L,4L,22L,8L,12L,27L,16L,18L,50L,32L,54L,36L,66L,64L,100L,84L,72L,132L,128L,200L,168L,280L,144L,252L,270L,264L,300L,288L,360L,528L,600L,504L,780L,1040L,540L,1026L,1092L,840L,720L,1152L,900L,1320L,1296L,2184L,1260L,1080L,1680L,2376L,2340L,3150L,2304L,1800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111364Inst : IEnumerable<long>
{
public static readonly long[] Value=A111364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111364.Bytes);
public long this[int i]=>Value[i];

public static A111364Inst Instance=new A111364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111365
{
public static readonly long[] Value={ 1L,1L,8L,43L,239L,1324L,7337L,40657L,225296L,1248451L,6918143L,38336068L,212434769L,1177182049L,6523214552L,36147618907L,200307738191L,1109981547676L,6150830952953L,34084099407793L,188872989897824L,1046617247712499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111365Inst : IEnumerable<long>
{
public static readonly long[] Value=A111365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111365.Bytes);
public long this[int i]=>Value[i];

public static A111365Inst Instance=new A111365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111366
{
public static readonly long[] Value={ 1L,6L,13L,61L,73L,92L,97L,198L,212L,217L,222L,270L,349L,380L,404L,438L,524L,630L,649L,836L,937L,1446L,1477L,1513L,1532L,1729L,2005L,2046L,2060L,2077L,2209L,2348L,2660L,2862L,2934L,3265L,3649L,3889L,4093L,4609L,4686L,4945L,5180L,5444L,5497L,5749L,5929L,6102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111366Inst : IEnumerable<long>
{
public static readonly long[] Value=A111366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111366.Bytes);
public long this[int i]=>Value[i];

public static A111366Inst Instance=new A111366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111367
{
public static readonly long[] Value={ 0L,2L,6L,8L,12L,14L,18L,24L,32L,36L,38L,44L,54L,56L,62L,66L,72L,74L,84L,86L,96L,98L,102L,104L,108L,122L,126L,132L,138L,144L,152L,156L,164L,168L,174L,176L,182L,186L,188L,204L,206L,212L,218L,222L,228L,236L,242L,248L,254L,258L,266L,278L,282L,284L,294L,308L,314L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111367Inst : IEnumerable<long>
{
public static readonly long[] Value=A111367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111367.Bytes);
public long this[int i]=>Value[i];

public static A111367Inst Instance=new A111367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111368
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,5L,3L,3L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111368Inst : IEnumerable<long>
{
public static readonly long[] Value=A111368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111368.Bytes);
public long this[int i]=>Value[i];

public static A111368Inst Instance=new A111368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111369
{
public static readonly long[] Value={ 0L,2L,6L,12L,14L,20L,26L,30L,36L,42L,50L,56L,72L,80L,84L,86L,90L,96L,114L,120L,122L,134L,140L,152L,156L,164L,170L,174L,180L,182L,204L,206L,210L,212L,216L,222L,230L,236L,246L,254L,260L,266L,272L,282L,294L,300L,306L,314L,332L,342L,344L,350L,356L,360L,380L,384L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111369Inst : IEnumerable<long>
{
public static readonly long[] Value=A111369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111369.Bytes);
public long this[int i]=>Value[i];

public static A111369Inst Instance=new A111369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111370
{
public static readonly long[] Value={ 15L,101L,490L,1958L,6842L,21637L,63261L,173525L,451276L,1121505L,2679689L,6185689L,13848650L,30167357L,64112359L,133230930L,271248950L,541946240L,1064144451L,2056148051L,3913864295L,7346629512L,13610949895L,24908858009L,45060624582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111370Inst : IEnumerable<long>
{
public static readonly long[] Value=A111370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111370.Bytes);
public long this[int i]=>Value[i];

public static A111370Inst Instance=new A111370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111371
{
public static readonly long[] Value={ 4L,12L,18L,20L,24L,27L,28L,36L,44L,50L,52L,54L,60L,68L,72L,76L,84L,90L,92L,98L,100L,108L,116L,120L,124L,126L,132L,135L,140L,144L,148L,150L,156L,160L,164L,168L,172L,180L,188L,189L,196L,198L,200L,204L,212L,216L,220L,228L,234L,236L,242L,244L,252L,260L,264L,268L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111371Inst : IEnumerable<long>
{
public static readonly long[] Value=A111371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111371.Bytes);
public long this[int i]=>Value[i];

public static A111371Inst Instance=new A111371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111372
{
public static readonly long[] Value={ 6L,0L,198L,170L,384L,992L,542L,648L,762L,5070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111372Inst : IEnumerable<long>
{
public static readonly long[] Value=A111372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111372.Bytes);
public long this[int i]=>Value[i];

public static A111372Inst Instance=new A111372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111373
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,3L,0L,0L,1L,3L,0L,0L,4L,0L,0L,1L,0L,7L,0L,0L,5L,0L,0L,1L,0L,0L,12L,0L,0L,6L,0L,0L,1L,12L,0L,0L,18L,0L,0L,7L,0L,0L,1L,0L,30L,0L,0L,25L,0L,0L,8L,0L,0L,1L,0L,0L,55L,0L,0L,33L,0L,0L,9L,0L,0L,1L,55L,0L,0L,88L,0L,0L,42L,0L,0L,10L,0L,0L,1L,0L,143L,0L,0L,130L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111373Inst : IEnumerable<long>
{
public static readonly long[] Value=A111373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111373.Bytes);
public long this[int i]=>Value[i];

public static A111373Inst Instance=new A111373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111374
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,0L,1L,2L,1L,0L,-2L,-3L,-2L,0L,3L,4L,4L,0L,-4L,-6L,-5L,0L,5L,9L,6L,0L,-8L,-12L,-9L,0L,12L,16L,13L,0L,-14L,-22L,-17L,0L,18L,29L,21L,0L,-26L,-38L,-28L,0L,34L,50L,39L,0L,-42L,-64L,-49L,0L,53L,82L,60L,0L,-70L,-105L,-78L,0L,90L,132L,101L,0L,-110L,-166L,-125L,0L,137L,208L,153L,0L,-174L,-258L,-192L,0L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111374Inst : IEnumerable<long>
{
public static readonly long[] Value=A111374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111374.Bytes);
public long this[int i]=>Value[i];

public static A111374Inst Instance=new A111374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111375
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,-2L,1L,3L,-5L,0L,3L,-1L,0L,3L,-2L,-8L,9L,1L,-7L,10L,-6L,-5L,3L,3L,3L,-6L,9L,-9L,-8L,10L,2L,8L,-13L,6L,-7L,-17L,34L,-1L,-10L,-5L,2L,-8L,-11L,50L,-20L,-21L,16L,-16L,-5L,5L,56L,-37L,-31L,35L,-40L,12L,29L,40L,-56L,-40L,62L,-58L,29L,52L,11L,-73L,-41L,99L,-98L,56L,98L,-66L,-73L,-24L,114L,-120L,100L,125L,-179L,-33L,-10L,117L,-111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111375Inst : IEnumerable<long>
{
public static readonly long[] Value=A111375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111375.Bytes);
public long this[int i]=>Value[i];

public static A111375Inst Instance=new A111375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111376
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,-1L,3L,1L,3L,1L,4L,2L,-1L,-1L,1L,3L,1L,4L,6L,1L,-1L,-4L,5L,-3L,6L,4L,9L,-4L,-5L,0L,-3L,4L,4L,18L,1L,-3L,-4L,-7L,0L,-3L,25L,1L,5L,-11L,-4L,-12L,-7L,32L,11L,15L,-15L,4L,-24L,-21L,27L,21L,31L,-24L,17L,-41L,-31L,4L,38L,50L,-18L,36L,-46L,-41L,-36L,45L,67L,-12L,57L,-50L,-38L,-95L,51L,73L,14L,82L,-32L,-27L,-171L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111376Inst : IEnumerable<long>
{
public static readonly long[] Value=A111376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111376.Bytes);
public long this[int i]=>Value[i];

public static A111376Inst Instance=new A111376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111377
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,6L,3L,4L,1L,6L,9L,4L,5L,1L,14L,18L,12L,5L,6L,1L,14L,30L,24L,15L,6L,7L,1L,30L,48L,56L,30L,18L,7L,8L,1L,30L,99L,80L,70L,36L,21L,8L,9L,1L,62L,135L,180L,125L,84L,42L,24L,9L,10L,1L,62L,237L,276L,250L,150L,98L,48L,27L,10L,11L,1L,126L,390L,540L,420L,336L,175L,112L,54L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111377Inst : IEnumerable<long>
{
public static readonly long[] Value=A111377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111377.Bytes);
public long this[int i]=>Value[i];

public static A111377Inst Instance=new A111377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111378
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,36L,144L,1600L,14930496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111378Inst : IEnumerable<long>
{
public static readonly long[] Value=A111378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111378.Bytes);
public long this[int i]=>Value[i];

public static A111378Inst Instance=new A111378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111379
{
public static readonly long[] Value={ 68L,126L,140L,162L,164L,174L,204L,258L,290L,294L,316L,322L,392L,410L,444L,456L,488L,496L,516L,550L,558L,624L,654L,676L,678L,688L,704L,710L,732L,772L,784L,790L,804L,820L,824L,830L,856L,868L,908L,920L,942L,948L,966L,978L,984L,1030L,1038L,1060L,1068L,1098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111379Inst : IEnumerable<long>
{
public static readonly long[] Value=A111379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111379.Bytes);
public long this[int i]=>Value[i];

public static A111379Inst Instance=new A111379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111380
{
public static readonly long[] Value={ 13L,17L,19L,59L,79L,389L,499L,997L,1889L,1999L,6899L,17989L,8999L,39989L,49999L,98999L,199999L,598999L,599999L,799999L,2998999L,2999999L,4999999L,9899999L,19999999L,29999999L,59999999L,189997999L,389999999L,689899999L,699899999L,998999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111380Inst : IEnumerable<long>
{
public static readonly long[] Value=A111380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111380.Bytes);
public long this[int i]=>Value[i];

public static A111380Inst Instance=new A111380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111381
{
public static readonly long[] Value={ 10L,10L,12L,12L,10L,12L,21L,32L,45L,910L,1617L,1716L,65L,56L,45L,32L,34L,54L,76L,1920L,1617L,1716L,1817L,1920L,2425L,78L,54L,56L,87L,1110L,2728L,1312L,1617L,3332L,910L,3132L,1110L,76L,78L,1920L,1312L,3738L,2021L,1716L,4140L,4140L,2021L,1920L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111381Inst : IEnumerable<long>
{
public static readonly long[] Value=A111381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111381.Bytes);
public long this[int i]=>Value[i];

public static A111381Inst Instance=new A111381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111382
{
public static readonly long[] Value={ 3L,1L,1L,21L,11L,43L,47L,157L,753L,51L,917L,273L,2409L,703L,413L,3729L,1153L,6243L,8789L,2307L,4477L,137L,403L,10649L,4617L,4533L,6133L,4721L,877L,2469L,5967L,1557L,1047L,38931L,15533L,6877L,23987L,4767L,18049L,1463L,118333L,27897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111382Inst : IEnumerable<long>
{
public static readonly long[] Value=A111382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111382.Bytes);
public long this[int i]=>Value[i];

public static A111382Inst Instance=new A111382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111383
{
public static readonly long[] Value={ 3L,7L,3L,3L,79L,701L,157L,1103L,11959L,1901L,10273L,92753L,17047L,11909L,144973L,327251L,99289L,92831L,90373L,309671L,1149619L,745397L,1232083L,94793L,18481L,76607L,186649L,181421L,1657561L,3746111L,7067239L,324143L,3185263L,9457181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111383Inst : IEnumerable<long>
{
public static readonly long[] Value=A111383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111383.Bytes);
public long this[int i]=>Value[i];

public static A111383Inst Instance=new A111383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111384
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,9L,18L,30L,48L,70L,100L,135L,180L,231L,294L,364L,448L,540L,648L,765L,900L,1045L,1210L,1386L,1584L,1794L,2028L,2275L,2548L,2835L,3150L,3480L,3840L,4216L,4624L,5049L,5508L,5985L,6498L,7030L,7600L,8190L,8820L,9471L,10164L,10879L,11638L,12420L,13248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111384Inst : IEnumerable<long>
{
public static readonly long[] Value=A111384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111384.Bytes);
public long this[int i]=>Value[i];

public static A111384Inst Instance=new A111384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111385
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,5L,15L,34L,68L,120L,200L,310L,465L,665L,931L,1260L,1680L,2184L,2808L,3540L,4425L,5445L,6655L,8030L,9636L,11440L,13520L,15834L,18473L,21385L,24675L,28280L,32320L,36720L,41616L,46920L,52785L,59109L,66063L,73530L,81700L,90440L,99960L,110110L,121121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111385Inst : IEnumerable<long>
{
public static readonly long[] Value=A111385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111385.Bytes);
public long this[int i]=>Value[i];

public static A111385Inst Instance=new A111385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111386
{
public static readonly long[] Value={ 1L,3L,5L,15L,25L,75L,125L,375L,625L,1875L,3125L,9375L,15625L,46875L,78125L,234375L,390625L,1171875L,1953125L,5859375L,9765625L,29296875L,48828125L,146484375L,244140625L,732421875L,1220703125L,3662109375L,6103515625L,18310546875L,30517578125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111386Inst : IEnumerable<long>
{
public static readonly long[] Value=A111386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111386.Bytes);
public long this[int i]=>Value[i];

public static A111386Inst Instance=new A111386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111387
{
public static readonly long[] Value={ 5L,63L,35L,63L,335L,603L,335L,6003L,3335L,6003L,33335L,60003L,33335L,600003L,333335L,6000003L,3333335L,6000003L,3333335L,60000003L,33333335L,600000003L,333333335L,600000003L,3333333335L,6000000003L,3333333335L,60000000003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111387Inst : IEnumerable<long>
{
public static readonly long[] Value=A111387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111387.Bytes);
public long this[int i]=>Value[i];

public static A111387Inst Instance=new A111387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111388
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,3L,5L,8L,12L,17L,26L,38L,56L,82L,120L,176L,258L,379L,556L,815L,1194L,1751L,2566L,3761L,5512L,8079L,11840L,17353L,25432L,37272L,54625L,80057L,117330L,171955L,252013L,369343L,541298L,793311L,1162654L,1703953L,2497265L,3659920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111388Inst : IEnumerable<long>
{
public static readonly long[] Value=A111388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111388.Bytes);
public long this[int i]=>Value[i];

public static A111388Inst Instance=new A111388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111389
{
public static readonly long[] Value={ 1L,2L,12L,44L,56L,62L,72L,122L,139L,166L,175L,182L,245L,251L,275L,362L,432L,526L,712L,831L,834L,836L,856L,909L,957L,1009L,1056L,1114L,1554L,2266L,2486L,2816L,3967L,4340L,5416L,6092L,6837L,6959L,7215L,7255L,7439L,7734L,9655L,10200L,11080L,11324L,11361L,12819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111389Inst : IEnumerable<long>
{
public static readonly long[] Value=A111389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111389.Bytes);
public long this[int i]=>Value[i];

public static A111389Inst Instance=new A111389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111390
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,5L,25L,6L,16L,8L,49L,7L,121L,10L,81L,12L,64L,18L,625L,14L,169L,11L,289L,13L,361L,15L,529L,17L,841L,19L,961L,21L,1369L,22L,1681L,23L,1849L,26L,2209L,27L,2401L,20L,729L,24L,36L,30L,100L,40L,196L,42L,225L,48L,256L,54L,441L,56L,484L,66L,676L,70L,1089L,78L,1156L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111390Inst : IEnumerable<long>
{
public static readonly long[] Value=A111390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111390.Bytes);
public long this[int i]=>Value[i];

public static A111390Inst Instance=new A111390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111391
{
public static readonly long[] Value={ 1L,9L,11L,17L,22L,29L,36L,37L,52L,166L,448L,2011L,3489L,4871L,6982L,10024L,16974L,33287L,47364L,58873L,126160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111391Inst : IEnumerable<long>
{
public static readonly long[] Value=A111391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111391.Bytes);
public long this[int i]=>Value[i];

public static A111391Inst Instance=new A111391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111392
{
public static readonly BigInteger[] Value={ 2L,5L,187L,162319L,10697595389L,63619487169453143L,BigInteger.Parse("74365399061678006800073593"),BigInteger.Parse("11864736003419293844093922527852416537"),BigInteger.Parse("601642845102734414280661105098046392912578705726003") };
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
public class A111392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111392Inst Instance=new A111392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111393
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111393Inst : IEnumerable<long>
{
public static readonly long[] Value=A111393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111393.Bytes);
public long this[int i]=>Value[i];

public static A111393Inst Instance=new A111393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111394
{
public static readonly BigInteger[] Value={ 1L,2L,8L,40L,280L,2240L,22400L,246400L,3203200L,44844800L,717516800L,12197785600L,231757926400L,4635158528000L,101973487616000L,2345390215168000L,58634755379200000L,1524503639859200000L,BigInteger.Parse("42686101916057600000"),BigInteger.Parse("1237896955565670400000"),BigInteger.Parse("38374805622535782400000") };
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
public class A111394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111394Inst Instance=new A111394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111395
{
public static readonly long[] Value={ 1L,5L,2L,1L,6L,3L,1L,7L,3L,1L,9L,4L,2L,1L,6L,3L,1L,7L,3L,1L,9L,4L,2L,1L,5L,2L,1L,7L,3L,1L,9L,4L,2L,1L,5L,2L,1L,7L,3L,1L,9L,4L,2L,1L,5L,2L,1L,7L,3L,1L,8L,4L,2L,1L,5L,2L,1L,6L,3L,1L,8L,4L,2L,1L,5L,2L,1L,6L,3L,1L,8L,4L,2L,1L,5L,2L,1L,6L,3L,1L,8L,4L,2L,1L,5L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111395Inst : IEnumerable<long>
{
public static readonly long[] Value=A111395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111395.Bytes);
public long this[int i]=>Value[i];

public static A111395Inst Instance=new A111395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111396
{
public static readonly long[] Value={ 0L,12L,30L,55L,88L,130L,182L,245L,320L,408L,510L,627L,760L,910L,1078L,1265L,1472L,1700L,1950L,2223L,2520L,2842L,3190L,3565L,3968L,4400L,4862L,5355L,5880L,6438L,7030L,7657L,8320L,9020L,9758L,10535L,11352L,12210L,13110L,14053L,15040L,16072L,17150L,18275L,19448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111396Inst : IEnumerable<long>
{
public static readonly long[] Value=A111396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111396.Bytes);
public long this[int i]=>Value[i];

public static A111396Inst Instance=new A111396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111397
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,2L,0L,1L,0L,2L,0L,1L,2L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,2L,0L,1L,2L,0L,2L,0L,1L,0L,2L,0L,1L,2L,0L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,2L,0L,1L,0L,1L,2L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111397Inst : IEnumerable<long>
{
public static readonly long[] Value=A111397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111397.Bytes);
public long this[int i]=>Value[i];

public static A111397Inst Instance=new A111397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111398
{
public static readonly long[] Value={ 1L,24L,30L,40L,42L,54L,56L,66L,70L,78L,88L,102L,104L,105L,110L,114L,128L,130L,135L,136L,138L,152L,154L,165L,170L,174L,182L,184L,186L,189L,190L,195L,222L,230L,231L,232L,238L,246L,248L,250L,255L,258L,266L,273L,282L,285L,286L,290L,296L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111398Inst : IEnumerable<long>
{
public static readonly long[] Value=A111398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111398.Bytes);
public long this[int i]=>Value[i];

public static A111398Inst Instance=new A111398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111399
{
public static readonly long[] Value={ 120L,168L,210L,216L,256L,264L,270L,280L,312L,330L,360L,378L,384L,390L,408L,420L,440L,456L,462L,480L,504L,510L,520L,540L,546L,552L,570L,594L,600L,616L,630L,640L,660L,672L,680L,690L,696L,702L,714L,728L,744L,750L,756L,760L,770L,780L,792L,798L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111399Inst : IEnumerable<long>
{
public static readonly long[] Value=A111399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111399.Bytes);
public long this[int i]=>Value[i];

public static A111399Inst Instance=new A111399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111400
{
public static readonly long[] Value={ 0L,3L,31L,251L,1485L,6665L,24073L,73486L,196626L,473595L,1047255L,2157793L,4189991L,7736001L,13676705L,23285020L,38354788L,61359171L,95642751L,145651815L,217207585L,317827433L,457099401L,647115626L,902970550L,1243330075L,1691078103L,2274047181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111400Inst : IEnumerable<long>
{
public static readonly long[] Value=A111400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111400.Bytes);
public long this[int i]=>Value[i];

public static A111400Inst Instance=new A111400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111401
{
public static readonly BigInteger[] Value={ 0L,1L,40L,2674398L,BigInteger.Parse("39044429911904441284800"),BigInteger.Parse("10934377152170553993439479038404269881062854488806451946716107868799042109068") };
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
public class A111401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111401Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111401.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111401.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111401Inst Instance=new A111401Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111402
{
public static readonly BigInteger[] Value={ 0L,1L,50L,1382958493L,BigInteger.Parse("58205338024195872785464627063218599149502589167918") };
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
public class A111402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111402Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111402.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111402Inst Instance=new A111402Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111403
{
public static readonly BigInteger[] Value={ 2L,12L,240L,65280L,4294901760L,18446744069414584320UL,BigInteger.Parse("340282366920938463444927863358058659840"),BigInteger.Parse("115792089237316195423570985008687907852929702298719625575994209400481361428480") };
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
public class A111403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111403Inst Instance=new A111403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111404
{
public static readonly BigInteger[] Value={ 24L,19656L,7625597465304L,BigInteger.Parse("443426488243037769948249622993552407816"),BigInteger.Parse("87189642485960958202911070585860771696964072404731750085525219437990967093722996516987306869061734867160436075772824") };
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
public class A111404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111404Inst Instance=new A111404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111405
{
public static readonly long[] Value={ 0L,0L,0L,1L,-1L,1L,-1L,1L,0L,0L,-1L,1L,-1L,1L,0L,1L,-2L,1L,-1L,1L,0L,0L,-1L,2L,-1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,1L,-2L,1L,0L,1L,-2L,1L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,0L,-1L,2L,-1L,1L,-1L,0L,-1L,2L,-2L,1L,0L,1L,-1L,0L,-1L,1L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,0L,-1L,1L,1L,-1L,-1L,2L,-1L,0L,0L,1L,-2L,2L,-1L,0L,0L,0L,0L,1L,-2L,1L,0L,1L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111405Inst : IEnumerable<long>
{
public static readonly long[] Value=A111405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111405.Bytes);
public long this[int i]=>Value[i];

public static A111405Inst Instance=new A111405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111406
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111406Inst : IEnumerable<long>
{
public static readonly long[] Value=A111406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111406.Bytes);
public long this[int i]=>Value[i];

public static A111406Inst Instance=new A111406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111407
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,2L,-2L,1L,0L,-1L,0L,2L,-2L,2L,-1L,0L,-1L,2L,-2L,1L,0L,1L,-2L,2L,-2L,2L,-1L,0L,0L,0L,-1L,1L,0L,1L,-2L,2L,-2L,2L,0L,-1L,-1L,2L,-2L,2L,-1L,1L,-2L,2L,-1L,1L,-1L,0L,-1L,4L,-4L,1L,1L,-2L,1L,1L,-2L,2L,-1L,1L,-2L,4L,-4L,1L,1L,0L,-1L,1L,-2L,2L,-2L,1L,-1L,4L,-3L,0L,0L,1L,-2L,4L,-3L,1L,-1L,0L,0L,3L,-4L,2L,0L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111407Inst : IEnumerable<long>
{
public static readonly long[] Value=A111407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111407.Bytes);
public long this[int i]=>Value[i];

public static A111407Inst Instance=new A111407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111408
{
public static readonly long[] Value={ 1L,3L,3L,1L,4L,16L,-13L,9L,-10L,25L,-11L,28L,-32L,36L,0L,-28L,7L,17L,-14L,54L,-33L,28L,-31L,108L,-136L,64L,-6L,30L,-48L,123L,-132L,41L,20L,-4L,4L,-12L,-52L,108L,-48L,114L,-138L,156L,-168L,140L,-56L,27L,-71L,100L,-144L,48L,67L,-24L,-51L,240L,-165L,165L,-174L,48L,-66L,312L,-384L,156L,-42L,-82L,96L,179L,-277L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111408Inst : IEnumerable<long>
{
public static readonly long[] Value=A111408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111408.Bytes);
public long this[int i]=>Value[i];

public static A111408Inst Instance=new A111408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111409
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,-1L,1L,0L,0L,0L,2L,-2L,2L,-2L,2L,0L,4L,-6L,4L,-2L,0L,0L,6L,-6L,4L,-4L,2L,-2L,8L,-8L,4L,0L,0L,0L,0L,-4L,8L,-6L,2L,0L,8L,-12L,8L,-4L,0L,2L,12L,-14L,4L,-4L,8L,-8L,16L,-18L,10L,-8L,4L,0L,16L,-20L,8L,-8L,4L,4L,0L,-8L,12L,-4L,4L,-12L,16L,-16L,16L,-12L,4L,-4L,4L,-8L,16L,-8L,2L,-2L,24L,-32L,24L,-20L,12L,-8L,24L,-32L,16L,-4L,-4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111409Inst : IEnumerable<long>
{
public static readonly long[] Value=A111409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111409.Bytes);
public long this[int i]=>Value[i];

public static A111409Inst Instance=new A111409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111410
{
public static readonly long[] Value={ 2L,6L,6L,18L,6L,18L,10L,18L,24L,18L,32L,18L,12L,30L,28L,30L,12L,44L,22L,14L,36L,24L,30L,58L,36L,12L,24L,8L,18L,100L,24L,44L,22L,54L,18L,48L,42L,26L,36L,36L,22L,72L,18L,32L,10L,78L,122L,16L,12L,30L,30L,20L,70L,26L,66L,40L,14L,42L,42L,30L,70L,98L,40L,14L,28L,126L,36L,74L,10L,26L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111410Inst : IEnumerable<long>
{
public static readonly long[] Value=A111410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111410.Bytes);
public long this[int i]=>Value[i];

public static A111410Inst Instance=new A111410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111411
{
public static readonly BigInteger[] Value={ 0L,1L,1L,4L,8L,41L,120L,826L,4602L,47570L,473649L,10093040L,203861263L,8821354950L,467680021214L,51343335981422L,7427745026671872L,2637938775610253117L,BigInteger.Parse("1315874983271581469522"),BigInteger.Parse("1773440184382265096424766"),BigInteger.Parse("4023316751814245493054773044"),BigInteger.Parse("26037772294065481552999203782248") };
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
public class A111411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111411Inst Instance=new A111411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111412
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,1L,0L,-1L,0L,0L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,1L,0L,0L,-1L,0L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,1L,0L,0L,-1L,1L,0L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111412Inst : IEnumerable<long>
{
public static readonly long[] Value=A111412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111412.Bytes);
public long this[int i]=>Value[i];

public static A111412Inst Instance=new A111412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111413
{
public static readonly BigInteger[] Value={ 0L,0L,0L,15L,19391512129L,BigInteger.Parse("703237958001393736999896827714634659411015090272684227831001142371615151") };
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
public class A111413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111413Inst Instance=new A111413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111414
{
public static readonly long[] Value={ 2L,6L,10L,40L,80L,250L,510L,1890L,4270L,13738L,30630L,101960L,234864L,705046L,1580578L,5136840L,11991928L,36095322L,82990606L,255579576L,595920680L,1719038038L,3926998938L,11665004238L,26978093154L,75938910058L,172678519950L,489262646480L,1114189211016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111414Inst : IEnumerable<long>
{
public static readonly long[] Value=A111414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111414.Bytes);
public long this[int i]=>Value[i];

public static A111414Inst Instance=new A111414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111415
{
public static readonly BigInteger[] Value={ 1L,1L,27L,13831L,44560468289L,BigInteger.Parse("220167382952941205430116129"),BigInteger.Parse("17280083176824678419775054525017769508688140582155308813842797363") };
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
public class A111415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111415Inst Instance=new A111415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111416
{
public static readonly BigInteger[] Value={ 0L,1L,718L,BigInteger.Parse("620448401733239439359280") };
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
public class A111416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111416Inst Instance=new A111416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111417
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,0L,0L,10L,0L,0L,0L,0L,0L,0L,0L,35L,0L,0L,0L,0L,0L,0L,0L,0L,0L,126L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,462L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1716L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6435L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,24310L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111417Inst : IEnumerable<long>
{
public static readonly long[] Value=A111417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111417.Bytes);
public long this[int i]=>Value[i];

public static A111417Inst Instance=new A111417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111418
{
public static readonly long[] Value={ 1L,3L,1L,10L,5L,1L,35L,21L,7L,1L,126L,84L,36L,9L,1L,462L,330L,165L,55L,11L,1L,1716L,1287L,715L,286L,78L,13L,1L,6435L,5005L,3003L,1365L,455L,105L,15L,1L,24310L,19448L,12376L,6188L,2380L,680L,136L,17L,1L,92378L,75582L,50388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111418Inst : IEnumerable<long>
{
public static readonly long[] Value=A111418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111418.Bytes);
public long this[int i]=>Value[i];

public static A111418Inst Instance=new A111418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111419
{
public static readonly long[] Value={ 1L,2L,2L,6L,5L,15L,2L,9L,6L,10L,1L,12L,2L,9L,10L,24L,2L,24L,1L,5L,6L,7L,2L,12L,25L,15L,18L,48L,1L,15L,1L,11L,14L,19L,10L,12L,2L,15L,34L,60L,1L,15L,2L,30L,30L,25L,2L,12L,14L,50L,42L,78L,2L,24L,10L,24L,30L,13L,1L,60L,1L,27L,18L,96L,10L,120L,2L,36L,6L,25L,1L,12L,2L,39L,50L,18L,6L,39L,1L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111419Inst : IEnumerable<long>
{
public static readonly long[] Value=A111419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111419.Bytes);
public long this[int i]=>Value[i];

public static A111419Inst Instance=new A111419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111420
{
public static readonly BigInteger[] Value={ 0L,1L,19L,315L,6601L,178923L,6161065L,262268499L,13470911521L,818285112123L,57836073876505L,4693152951066099L,432360761046527041L,BigInteger.Parse("44794795435021490043"),BigInteger.Parse("5176959026638375267225"),BigInteger.Parse("662704551819559746282579"),BigInteger.Parse("93384393940399990403502241"),BigInteger.Parse("14406589076081640590750974203") };
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
public class A111420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111420Inst Instance=new A111420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111421
{
public static readonly long[] Value={ 5L,4L,7L,8L,3L,2L,7L,5L,4L,2L,4L,9L,9L,1L,5L,3L,8L,5L,0L,4L,2L,5L,3L,1L,5L,2L,9L,7L,5L,0L,9L,9L,2L,5L,4L,5L,1L,9L,5L,2L,1L,3L,9L,7L,4L,3L,4L,8L,5L,8L,7L,7L,3L,6L,1L,2L,3L,4L,2L,4L,8L,5L,5L,8L,8L,5L,4L,7L,0L,7L,2L,3L,2L,0L,9L,0L,5L,3L,0L,0L,4L,6L,7L,0L,1L,5L,0L,4L,9L,7L,0L,7L,4L,7L,5L,3L,7L,4L,6L,0L,4L,8L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111421Inst : IEnumerable<long>
{
public static readonly long[] Value=A111421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111421.Bytes);
public long this[int i]=>Value[i];

public static A111421Inst Instance=new A111421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111422
{
public static readonly long[] Value={ 2L,4L,9L,9L,8L,4L,5L,4L,9L,6L,9L,5L,7L,2L,4L,0L,4L,5L,0L,0L,6L,3L,7L,8L,4L,6L,7L,9L,3L,6L,7L,7L,8L,2L,5L,9L,0L,6L,1L,8L,8L,8L,3L,9L,1L,6L,6L,9L,9L,9L,4L,4L,3L,7L,7L,2L,4L,4L,7L,6L,7L,1L,8L,4L,6L,6L,9L,0L,6L,5L,7L,9L,8L,9L,7L,5L,2L,4L,5L,1L,7L,0L,9L,4L,7L,0L,6L,3L,1L,7L,3L,9L,3L,7L,0L,9L,4L,0L,9L,7L,0L,9L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111422Inst : IEnumerable<long>
{
public static readonly long[] Value=A111422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111422.Bytes);
public long this[int i]=>Value[i];

public static A111422Inst Instance=new A111422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111423
{
public static readonly long[] Value={ 1L,1L,5L,5L,6L,8L,1L,2L,3L,1L,7L,9L,2L,1L,5L,5L,0L,3L,4L,3L,4L,7L,5L,0L,1L,3L,4L,4L,5L,0L,8L,1L,1L,0L,3L,1L,3L,6L,6L,0L,9L,0L,9L,4L,8L,6L,4L,0L,8L,1L,0L,1L,7L,7L,2L,9L,9L,6L,9L,5L,6L,0L,6L,1L,1L,1L,1L,4L,4L,0L,6L,9L,9L,4L,6L,6L,3L,9L,2L,4L,8L,9L,3L,5L,2L,5L,0L,7L,8L,4L,8L,8L,6L,2L,8L,6L,0L,6L,9L,0L,6L,1L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111423Inst : IEnumerable<long>
{
public static readonly long[] Value=A111423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111423.Bytes);
public long this[int i]=>Value[i];

public static A111423Inst Instance=new A111423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111424
{
public static readonly BigInteger[] Value={ 2L,14L,134L,1814L,32054L,697334L,17994614L,536913014L,18180138614L,688622711414L,28847210769014L,1324142261418614L,66088894793898614L,3563385531547818614L,BigInteger.Parse("206406590463275178614"),BigInteger.Parse("12782685296230371498614"),BigInteger.Parse("842817079876858728618614") };
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
public class A111424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111424.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111424Inst Instance=new A111424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111425
{
public static readonly BigInteger[] Value={ 0L,0L,1L,1L,4L,24L,504L,66012L,181997601L,65720971788709L,BigInteger.Parse("65431225571591367370292"),BigInteger.Parse("23523635785731871586396890786299881280"),BigInteger.Parse("8419860898569880503664421048610377961601349941695806840602396") };
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
public class A111425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111425Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111425.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111425Inst Instance=new A111425Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111426
{
public static readonly long[] Value={ 0L,1L,0L,0L,3L,1L,5L,2L,0L,1L,3L,4L,9L,1L,0L,11L,0L,5L,3L,0L,8L,15L,2L,1L,17L,10L,3L,5L,9L,2L,21L,1L,0L,3L,14L,11L,1L,6L,5L,16L,27L,3L,29L,4L,0L,8L,9L,15L,20L,5L,1L,35L,2L,17L,4L,11L,3L,0L,39L,5L,12L,41L,26L,9L,3L,6L,21L,28L,45L,14L,1L,5L,8L,3L,15L,11L,4L,51L,1L,9L,34L,5L,17L,18L,27L,10L,57L,10L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111426Inst : IEnumerable<long>
{
public static readonly long[] Value=A111426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111426.Bytes);
public long this[int i]=>Value[i];

public static A111426Inst Instance=new A111426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111427
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,1L,2L,24L,1705L,8646064L,120879712950776L,BigInteger.Parse("6984325661199418257711189170"),BigInteger.Parse("2037364946117781220616409939151494028465982215442078400") };
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
public class A111427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111427Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111427.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111427Inst Instance=new A111427Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111428
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,24L,3136L,29249425L,2544489349890656L,BigInteger.Parse("10469303814509319059584520878072"),BigInteger.Parse("52390584919058211443518140875804297526718993867687450278537778") };
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
public class A111428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111428Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111428.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111428.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111428Inst Instance=new A111428Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111429
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,24L,3136L,53798080L,8607945812375585L,BigInteger.Parse("220376367601372354229355484029120"),BigInteger.Parse("78531983922879942351416192215114163135375656803468317366190276600") };
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
public class A111429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111429Inst Instance=new A111429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111430
{
public static readonly BigInteger[] Value={ 0L,0L,1L,2L,24L,3136L,53798080L,15832480722303616L,BigInteger.Parse("745527911414639917440582097294401"),BigInteger.Parse("1653079675982713719400420113305863285438472194540328413077493166464") };
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
public class A111430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111430.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111430Inst Instance=new A111430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111431
{
public static readonly BigInteger[] Value={ 0L,0L,1L,1L,1L,3L,13L,233L,46368L,701408733L,37889062373143906L,BigInteger.Parse("6161314747715278029583501626149"),BigInteger.Parse("818706854228831001753880637535093596811413714795418360007") };
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
public class A111431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111431Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111431.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111431.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111431Inst Instance=new A111431Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111432
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,1L,1L,3L,21L,610L,514229L,225851433717L,BigInteger.Parse("16641027750620563662096"),BigInteger.Parse("13180872826374098837632191485015125807374171"),BigInteger.Parse("284812298108489611757988937681460995615380088782304890986477195645969271404032323901") };
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
public class A111432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111432Inst Instance=new A111432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111433
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,1L,1L,3L,21L,987L,1346269L,2504730781961L,BigInteger.Parse("5358359254990966640871840"),BigInteger.Parse("9366947731425726508977331996039353971111632790877"),BigInteger.Parse("4176188314410464025148116525118839856571907649518456624120477965205524606115754507996484677228773") };
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
public class A111433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111433Inst Instance=new A111433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111434
{
public static readonly long[] Value={ 0L,1L,10L,100L,468L,585L,1000L,4680L,5850L,5851L,5868L,10000L,28845L,46800L,58500L,58510L,58680L,58968L,100000L,288450L,468000L,585000L,585100L,586800L,589680L,1000000L,2884500L,4680000L,5850000L,5851000L,5868000L,5896800L,10000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111434Inst : IEnumerable<long>
{
public static readonly long[] Value=A111434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111434.Bytes);
public long this[int i]=>Value[i];

public static A111434Inst Instance=new A111434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111435
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,3L,21L,987L,2178309L,6557470319842L,BigInteger.Parse("59425114757512643212875125"),BigInteger.Parse("3016128079338728432528443992613633888712980904400501") };
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
public class A111435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111435Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111435.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111435Inst Instance=new A111435Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111436
{
public static readonly long[] Value={ 1L,8L,3L,4L,5L,78L,28L,32L,36L,40L,176L,528L,624L,280L,30L,144L,1088L,432L,1273L,120L,1869L,440L,3427L,1632L,2000L,2080L,1701L,2268L,10179L,480L,5270L,2464L,660L,1632L,4970L,1044L,222L,2242L,351L,3120L,5576L,798L,1032L,5896L,630L,230L,1081L,8064L,9261L,9500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111436Inst : IEnumerable<long>
{
public static readonly long[] Value=A111436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111436.Bytes);
public long this[int i]=>Value[i];

public static A111436Inst Instance=new A111436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111437
{
public static readonly long[] Value={ 1L,6L,6L,36L,30L,60L,105L,120L,207L,40L,33L,24L,104L,1246L,285L,192L,476L,450L,228L,100L,294L,660L,483L,2232L,3275L,3120L,2025L,1876L,2204L,1590L,4557L,2560L,2574L,680L,6160L,432L,444L,5814L,7371L,2520L,1230L,2772L,6536L,103708L,4815L,1886L,11374L,1392L,5390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111437Inst : IEnumerable<long>
{
public static readonly long[] Value=A111437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111437.Bytes);
public long this[int i]=>Value[i];

public static A111437Inst Instance=new A111437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111438
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,21L,987L,2178309L,10610209857723L,BigInteger.Parse("155576970220531065681649693"),BigInteger.Parse("33449372971981195681356806732944396691005381570580873") };
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
public class A111438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111438Inst Instance=new A111438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111439
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,3L,4L,5L,6L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,10L,11L,12L,11L,12L,13L,12L,13L,12L,13L,12L,13L,12L,13L,14L,15L,14L,15L,14L,15L,14L,15L,14L,15L,14L,15L,16L,15L,16L,17L,16L,17L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111439Inst : IEnumerable<long>
{
public static readonly long[] Value=A111439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111439.Bytes);
public long this[int i]=>Value[i];

public static A111439Inst Instance=new A111439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111440
{
public static readonly long[] Value={ 9L,25L,64L,81L,400L,576L,1024L,1296L,2304L,2704L,4096L,7225L,7744L,10816L,14884L,15376L,19044L,20736L,22500L,25600L,26244L,28900L,33124L,35344L,39601L,41616L,46656L,47961L,48400L,52900L,55225L,89401L,91204L,96100L,99856L,114921L,136900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111440Inst : IEnumerable<long>
{
public static readonly long[] Value=A111440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111440.Bytes);
public long this[int i]=>Value[i];

public static A111440Inst Instance=new A111440Inst();

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