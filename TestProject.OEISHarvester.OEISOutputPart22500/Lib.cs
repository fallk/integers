using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A041013
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,61L,122L,221L,442L,884L,1768L,8671L,17342L,24371L,48742L,97484L,194968L,869491L,1738982L,2898371L,5796742L,11593484L,48439511L,96879022L,193758044L,440857391L,881714782L,1763429564L,4659243671L,9318487342L,18636974684L,48647963681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041013Inst : IEnumerable<long>
{
public static readonly long[] Value=A041013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041013.Bytes);
public long this[int i]=>Value[i];

public static A041013Inst Instance=new A041013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041012
{
public static readonly BigInteger[] Value={ 1L,2L,34L,BigInteger.Parse("35363738394041424344454647484950515253545556575859606162636465666768") };
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
public class A041012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041012.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041012Inst Instance=new A041012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041011
{
public static readonly long[] Value={ 0L,1L,1L,5L,6L,29L,35L,169L,204L,985L,1189L,5741L,6930L,33461L,40391L,195025L,235416L,1136689L,1372105L,6625109L,7997214L,38613965L,46611179L,225058681L,271669860L,1311738121L,1583407981L,7645370045L,9228778026L,44560482149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041011Inst : IEnumerable<long>
{
public static readonly long[] Value=A041011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041011.Bytes);
public long this[int i]=>Value[i];

public static A041011Inst Instance=new A041011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041010
{
public static readonly long[] Value={ 1L,2L,3L,14L,17L,82L,99L,478L,577L,2786L,3363L,16238L,19601L,94642L,114243L,551614L,665857L,3215042L,3880899L,18738638L,22619537L,109216786L,131836323L,636562078L,768398401L,3710155682L,4478554083L,21624372014L,26102926097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041010Inst : IEnumerable<long>
{
public static readonly long[] Value=A041010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041010.Bytes);
public long this[int i]=>Value[i];

public static A041010Inst Instance=new A041010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041009
{
public static readonly long[] Value={ 1L,1L,2L,3L,14L,17L,31L,48L,223L,271L,494L,765L,3554L,4319L,7873L,12192L,56641L,68833L,125474L,194307L,902702L,1097009L,1999711L,3096720L,14386591L,17483311L,31869902L,49353213L,229282754L,278635967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041009Inst : IEnumerable<long>
{
public static readonly long[] Value=A041009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041009.Bytes);
public long this[int i]=>Value[i];

public static A041009Inst Instance=new A041009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041008
{
public static readonly long[] Value={ 2L,3L,5L,8L,37L,45L,82L,127L,590L,717L,1307L,2024L,9403L,11427L,20830L,32257L,149858L,182115L,331973L,514088L,2388325L,2902413L,5290738L,8193151L,38063342L,46256493L,84319835L,130576328L,606625147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041008Inst : IEnumerable<long>
{
public static readonly long[] Value=A041008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041008.Bytes);
public long this[int i]=>Value[i];

public static A041008Inst Instance=new A041008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041007
{
public static readonly long[] Value={ 1L,2L,9L,20L,89L,198L,881L,1960L,8721L,19402L,86329L,192060L,854569L,1901198L,8459361L,18819920L,83739041L,186298002L,828931049L,1844160100L,8205571449L,18255302998L,81226783441L,180708869880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041007Inst : IEnumerable<long>
{
public static readonly long[] Value=A041007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041007.Bytes);
public long this[int i]=>Value[i];

public static A041007Inst Instance=new A041007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041006
{
public static readonly long[] Value={ 2L,5L,22L,49L,218L,485L,2158L,4801L,21362L,47525L,211462L,470449L,2093258L,4656965L,20721118L,46099201L,205117922L,456335045L,2030458102L,4517251249L,20099463098L,44716177445L,198964172878L,442644523201L,1969542265682L,4381729054565L,19496458483942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041006Inst : IEnumerable<long>
{
public static readonly long[] Value=A041006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041006.Bytes);
public long this[int i]=>Value[i];

public static A041006Inst Instance=new A041006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041005
{
public static readonly long[] Value={ 1L,16L,159L,1260L,8722L,55152L,326811L,1844084L,10015566L,52754624L,270976342L,1362986520L,6734927460L,32775704608L,157408497171L,747269225028L,3511471892470L,16351481223840L,75525932249922L,346305571781224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041005Inst : IEnumerable<long>
{
public static readonly long[] Value=A041005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041005.Bytes);
public long this[int i]=>Value[i];

public static A041005Inst Instance=new A041005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040988
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,193L,197L,199L,223L,227L,229L,233L,239L,241L,257L,263L,269L,277L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040988Inst : IEnumerable<long>
{
public static readonly long[] Value=A040988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040988.Bytes);
public long this[int i]=>Value[i];

public static A040988Inst Instance=new A040988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040987
{
public static readonly long[] Value={ 31L,41L,71L,101L,131L,151L,181L,191L,211L,241L,251L,271L,281L,311L,331L,401L,431L,491L,521L,541L,571L,701L,751L,761L,811L,821L,881L,911L,941L,971L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1181L,1201L,1291L,1301L,1321L,1361L,1381L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040987Inst : IEnumerable<long>
{
public static readonly long[] Value=A040987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040987.Bytes);
public long this[int i]=>Value[i];

public static A040987Inst Instance=new A040987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040986
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,61L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,193L,197L,199L,223L,227L,229L,233L,239L,257L,263L,269L,277L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040986Inst : IEnumerable<long>
{
public static readonly long[] Value=A040986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040986.Bytes);
public long this[int i]=>Value[i];

public static A040986Inst Instance=new A040986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040985
{
public static readonly long[] Value={ 11L,31L,41L,61L,101L,131L,151L,181L,191L,211L,241L,271L,281L,331L,431L,491L,521L,541L,571L,601L,631L,751L,761L,811L,821L,881L,911L,941L,971L,991L,1021L,1031L,1061L,1091L,1151L,1181L,1201L,1231L,1291L,1301L,1321L,1361L,1451L,1481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040985Inst : IEnumerable<long>
{
public static readonly long[] Value=A040985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040985.Bytes);
public long this[int i]=>Value[i];

public static A040985Inst Instance=new A040985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040984
{
public static readonly long[] Value={ 47L,139L,277L,461L,599L,691L,829L,967L,1013L,1151L,1289L,1381L,1427L,1657L,1933L,1979L,2347L,2393L,2531L,3037L,3083L,3221L,3313L,3359L,3727L,3911L,4003L,4049L,4463L,4831L,4877L,4969L,5107L,5521L,5659L,5843L,5981L,6073L,6211L,6257L,6763L,6947L,7039L,7177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040984Inst : IEnumerable<long>
{
public static readonly long[] Value=A040984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040984.Bytes);
public long this[int i]=>Value[i];

public static A040984Inst Instance=new A040984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040983
{
public static readonly long[] Value={ 11L,31L,41L,61L,71L,101L,191L,211L,251L,271L,281L,311L,331L,401L,421L,431L,461L,491L,521L,541L,571L,601L,631L,641L,661L,751L,761L,811L,821L,881L,911L,941L,971L,991L,1061L,1091L,1171L,1201L,1231L,1301L,1321L,1361L,1381L,1451L,1471L,1481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040983Inst : IEnumerable<long>
{
public static readonly long[] Value=A040983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040983.Bytes);
public long this[int i]=>Value[i];

public static A040983Inst Instance=new A040983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040982
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,193L,197L,199L,223L,227L,229L,233L,239L,241L,257L,263L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040982Inst : IEnumerable<long>
{
public static readonly long[] Value=A040982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040982.Bytes);
public long this[int i]=>Value[i];

public static A040982Inst Instance=new A040982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040981
{
public static readonly long[] Value={ 11L,31L,41L,61L,71L,101L,151L,181L,191L,211L,241L,251L,271L,281L,331L,401L,421L,461L,491L,541L,571L,641L,661L,691L,701L,751L,761L,811L,821L,881L,911L,941L,971L,1021L,1031L,1051L,1091L,1151L,1171L,1181L,1201L,1231L,1301L,1361L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040981Inst : IEnumerable<long>
{
public static readonly long[] Value=A040981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040981.Bytes);
public long this[int i]=>Value[i];

public static A040981Inst Instance=new A040981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040980
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,131L,137L,139L,149L,157L,163L,167L,173L,179L,193L,197L,199L,223L,227L,229L,233L,239L,257L,263L,269L,277L,283L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040980Inst : IEnumerable<long>
{
public static readonly long[] Value=A040980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040980.Bytes);
public long this[int i]=>Value[i];

public static A040980Inst Instance=new A040980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040979
{
public static readonly long[] Value={ 11L,31L,41L,61L,71L,131L,151L,191L,211L,241L,251L,271L,281L,311L,331L,401L,421L,431L,461L,521L,541L,571L,631L,641L,661L,691L,751L,761L,821L,881L,911L,941L,971L,1021L,1051L,1091L,1151L,1171L,1181L,1201L,1291L,1301L,1381L,1451L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040979Inst : IEnumerable<long>
{
public static readonly long[] Value=A040979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040979.Bytes);
public long this[int i]=>Value[i];

public static A040979Inst Instance=new A040979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040978
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,181L,193L,197L,199L,223L,227L,229L,233L,239L,257L,263L,269L,277L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040978Inst : IEnumerable<long>
{
public static readonly long[] Value=A040978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040978.Bytes);
public long this[int i]=>Value[i];

public static A040978Inst Instance=new A040978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040977
{
public static readonly long[] Value={ 1L,8L,35L,112L,294L,672L,1386L,2640L,4719L,8008L,13013L,20384L,30940L,45696L,65892L,93024L,128877L,175560L,235543L,311696L,407330L,526240L,672750L,851760L,1068795L,1330056L,1642473L,2013760L,2452472L,2968064L,3570952L,4272576L,5085465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040977Inst : IEnumerable<long>
{
public static readonly long[] Value=A040977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040977.Bytes);
public long this[int i]=>Value[i];

public static A040977Inst Instance=new A040977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040976
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,11L,15L,17L,21L,27L,29L,35L,39L,41L,45L,51L,57L,59L,65L,69L,71L,77L,81L,87L,95L,99L,101L,105L,107L,111L,125L,129L,135L,137L,147L,149L,155L,161L,165L,171L,177L,179L,189L,191L,195L,197L,209L,221L,225L,227L,231L,237L,239L,249L,255L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040976Inst : IEnumerable<long>
{
public static readonly long[] Value=A040976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040976.Bytes);
public long this[int i]=>Value[i];

public static A040976Inst Instance=new A040976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040975
{
public static readonly long[] Value={ 11L,31L,41L,61L,71L,101L,131L,151L,181L,191L,251L,271L,281L,331L,401L,421L,431L,461L,491L,521L,571L,601L,631L,641L,661L,691L,701L,751L,821L,881L,971L,991L,1021L,1051L,1061L,1171L,1181L,1231L,1291L,1301L,1321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040975Inst : IEnumerable<long>
{
public static readonly long[] Value=A040975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040975.Bytes);
public long this[int i]=>Value[i];

public static A040975Inst Instance=new A040975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040974
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,257L,263L,269L,277L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040974Inst : IEnumerable<long>
{
public static readonly long[] Value=A040974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040974.Bytes);
public long this[int i]=>Value[i];

public static A040974Inst Instance=new A040974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040973
{
public static readonly long[] Value={ 11L,31L,71L,131L,151L,181L,241L,251L,271L,281L,311L,331L,401L,421L,431L,521L,541L,571L,601L,631L,641L,661L,701L,751L,761L,811L,821L,881L,941L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1171L,1181L,1201L,1231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040973Inst : IEnumerable<long>
{
public static readonly long[] Value=A040973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040973.Bytes);
public long this[int i]=>Value[i];

public static A040973Inst Instance=new A040973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040956
{
public static readonly long[] Value={ 31L,2L,3L,4L,1L,20L,6L,1L,14L,1L,6L,20L,1L,4L,3L,2L,62L,2L,3L,4L,1L,20L,6L,1L,14L,1L,6L,20L,1L,4L,3L,2L,62L,2L,3L,4L,1L,20L,6L,1L,14L,1L,6L,20L,1L,4L,3L,2L,62L,2L,3L,4L,1L,20L,6L,1L,14L,1L,6L,20L,1L,4L,3L,2L,62L,2L,3L,4L,1L,20L,6L,1L,14L,1L,6L,20L,1L,4L,3L,2L,62L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040956Inst : IEnumerable<long>
{
public static readonly long[] Value=A040956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040956.Bytes);
public long this[int i]=>Value[i];

public static A040956Inst Instance=new A040956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040955
{
public static readonly long[] Value={ 31L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L,62L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040955Inst : IEnumerable<long>
{
public static readonly long[] Value=A040955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040955.Bytes);
public long this[int i]=>Value[i];

public static A040955Inst Instance=new A040955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040954
{
public static readonly long[] Value={ 31L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L,62L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040954Inst : IEnumerable<long>
{
public static readonly long[] Value=A040954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040954.Bytes);
public long this[int i]=>Value[i];

public static A040954Inst Instance=new A040954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040953
{
public static readonly long[] Value={ 31L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L,62L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040953Inst : IEnumerable<long>
{
public static readonly long[] Value=A040953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040953.Bytes);
public long this[int i]=>Value[i];

public static A040953Inst Instance=new A040953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040952
{
public static readonly long[] Value={ 31L,2L,1L,2L,2L,7L,2L,2L,1L,2L,62L,2L,1L,2L,2L,7L,2L,2L,1L,2L,62L,2L,1L,2L,2L,7L,2L,2L,1L,2L,62L,2L,1L,2L,2L,7L,2L,2L,1L,2L,62L,2L,1L,2L,2L,7L,2L,2L,1L,2L,62L,2L,1L,2L,2L,7L,2L,2L,1L,2L,62L,2L,1L,2L,2L,7L,2L,2L,1L,2L,62L,2L,1L,2L,2L,7L,2L,2L,1L,2L,62L,2L,1L,2L,2L,7L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040952Inst : IEnumerable<long>
{
public static readonly long[] Value=A040952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040952.Bytes);
public long this[int i]=>Value[i];

public static A040952Inst Instance=new A040952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040951
{
public static readonly long[] Value={ 31L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L,31L,5L,1L,2L,62L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040951Inst : IEnumerable<long>
{
public static readonly long[] Value=A040951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040951.Bytes);
public long this[int i]=>Value[i];

public static A040951Inst Instance=new A040951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040950
{
public static readonly long[] Value={ 31L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L,30L,1L,2L,62L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040950Inst : IEnumerable<long>
{
public static readonly long[] Value=A040950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040950.Bytes);
public long this[int i]=>Value[i];

public static A040950Inst Instance=new A040950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040949
{
public static readonly long[] Value={ 31L,3L,8L,1L,1L,1L,1L,1L,1L,2L,1L,1L,15L,12L,2L,6L,2L,12L,15L,1L,1L,2L,1L,1L,1L,1L,1L,1L,8L,3L,62L,3L,8L,1L,1L,1L,1L,1L,1L,2L,1L,1L,15L,12L,2L,6L,2L,12L,15L,1L,1L,2L,1L,1L,1L,1L,1L,1L,8L,3L,62L,3L,8L,1L,1L,1L,1L,1L,1L,2L,1L,1L,15L,12L,2L,6L,2L,12L,15L,1L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040949Inst : IEnumerable<long>
{
public static readonly long[] Value=A040949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040949.Bytes);
public long this[int i]=>Value[i];

public static A040949Inst Instance=new A040949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040948
{
public static readonly long[] Value={ 31L,3L,3L,1L,1L,2L,1L,1L,3L,3L,62L,3L,3L,1L,1L,2L,1L,1L,3L,3L,62L,3L,3L,1L,1L,2L,1L,1L,3L,3L,62L,3L,3L,1L,1L,2L,1L,1L,3L,3L,62L,3L,3L,1L,1L,2L,1L,1L,3L,3L,62L,3L,3L,1L,1L,2L,1L,1L,3L,3L,62L,3L,3L,1L,1L,2L,1L,1L,3L,3L,62L,3L,3L,1L,1L,2L,1L,1L,3L,3L,62L,3L,3L,1L,1L,2L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040948Inst : IEnumerable<long>
{
public static readonly long[] Value=A040948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040948.Bytes);
public long this[int i]=>Value[i];

public static A040948Inst Instance=new A040948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040947
{
public static readonly long[] Value={ 31L,3L,2L,5L,1L,4L,1L,5L,2L,3L,62L,3L,2L,5L,1L,4L,1L,5L,2L,3L,62L,3L,2L,5L,1L,4L,1L,5L,2L,3L,62L,3L,2L,5L,1L,4L,1L,5L,2L,3L,62L,3L,2L,5L,1L,4L,1L,5L,2L,3L,62L,3L,2L,5L,1L,4L,1L,5L,2L,3L,62L,3L,2L,5L,1L,4L,1L,5L,2L,3L,62L,3L,2L,5L,1L,4L,1L,5L,2L,3L,62L,3L,2L,5L,1L,4L,1L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040947Inst : IEnumerable<long>
{
public static readonly long[] Value=A040947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040947.Bytes);
public long this[int i]=>Value[i];

public static A040947Inst Instance=new A040947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040946
{
public static readonly long[] Value={ 31L,3L,1L,1L,1L,30L,1L,1L,1L,3L,62L,3L,1L,1L,1L,30L,1L,1L,1L,3L,62L,3L,1L,1L,1L,30L,1L,1L,1L,3L,62L,3L,1L,1L,1L,30L,1L,1L,1L,3L,62L,3L,1L,1L,1L,30L,1L,1L,1L,3L,62L,3L,1L,1L,1L,30L,1L,1L,1L,3L,62L,3L,1L,1L,1L,30L,1L,1L,1L,3L,62L,3L,1L,1L,1L,30L,1L,1L,1L,3L,62L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040946Inst : IEnumerable<long>
{
public static readonly long[] Value=A040946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040946.Bytes);
public long this[int i]=>Value[i];

public static A040946Inst Instance=new A040946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040945
{
public static readonly long[] Value={ 31L,3L,1L,8L,5L,1L,1L,3L,7L,1L,1L,7L,3L,1L,1L,5L,8L,1L,3L,62L,3L,1L,8L,5L,1L,1L,3L,7L,1L,1L,7L,3L,1L,1L,5L,8L,1L,3L,62L,3L,1L,8L,5L,1L,1L,3L,7L,1L,1L,7L,3L,1L,1L,5L,8L,1L,3L,62L,3L,1L,8L,5L,1L,1L,3L,7L,1L,1L,7L,3L,1L,1L,5L,8L,1L,3L,62L,3L,1L,8L,5L,1L,1L,3L,7L,1L,1L,7L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040945Inst : IEnumerable<long>
{
public static readonly long[] Value=A040945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040945.Bytes);
public long this[int i]=>Value[i];

public static A040945Inst Instance=new A040945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040944
{
public static readonly long[] Value={ 31L,4L,6L,1L,2L,3L,1L,4L,2L,3L,2L,4L,1L,3L,2L,1L,6L,4L,62L,4L,6L,1L,2L,3L,1L,4L,2L,3L,2L,4L,1L,3L,2L,1L,6L,4L,62L,4L,6L,1L,2L,3L,1L,4L,2L,3L,2L,4L,1L,3L,2L,1L,6L,4L,62L,4L,6L,1L,2L,3L,1L,4L,2L,3L,2L,4L,1L,3L,2L,1L,6L,4L,62L,4L,6L,1L,2L,3L,1L,4L,2L,3L,2L,4L,1L,3L,2L,1L,6L,4L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040944Inst : IEnumerable<long>
{
public static readonly long[] Value=A040944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040944.Bytes);
public long this[int i]=>Value[i];

public static A040944Inst Instance=new A040944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040943
{
public static readonly long[] Value={ 31L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L,62L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040943Inst : IEnumerable<long>
{
public static readonly long[] Value=A040943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040943.Bytes);
public long this[int i]=>Value[i];

public static A040943Inst Instance=new A040943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040942
{
public static readonly long[] Value={ 31L,4L,1L,3L,1L,1L,1L,11L,1L,5L,3L,8L,1L,1L,1L,1L,30L,1L,1L,1L,1L,8L,3L,5L,1L,11L,1L,1L,1L,3L,1L,4L,62L,4L,1L,3L,1L,1L,1L,11L,1L,5L,3L,8L,1L,1L,1L,1L,30L,1L,1L,1L,1L,8L,3L,5L,1L,11L,1L,1L,1L,3L,1L,4L,62L,4L,1L,3L,1L,1L,1L,11L,1L,5L,3L,8L,1L,1L,1L,1L,30L,1L,1L,1L,1L,8L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040942Inst : IEnumerable<long>
{
public static readonly long[] Value=A040942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040942.Bytes);
public long this[int i]=>Value[i];

public static A040942Inst Instance=new A040942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040941
{
public static readonly long[] Value={ 31L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L,62L,5L,5L,2L,8L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040941Inst : IEnumerable<long>
{
public static readonly long[] Value=A040941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040941.Bytes);
public long this[int i]=>Value[i];

public static A040941Inst Instance=new A040941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040924
{
public static readonly long[] Value={ 30L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040924Inst : IEnumerable<long>
{
public static readonly long[] Value=A040924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040924.Bytes);
public long this[int i]=>Value[i];

public static A040924Inst Instance=new A040924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040923
{
public static readonly long[] Value={ 30L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040923Inst : IEnumerable<long>
{
public static readonly long[] Value=A040923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040923.Bytes);
public long this[int i]=>Value[i];

public static A040923Inst Instance=new A040923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040922
{
public static readonly long[] Value={ 30L,1L,6L,1L,2L,1L,3L,8L,1L,1L,4L,4L,1L,1L,8L,3L,1L,2L,1L,6L,1L,60L,1L,6L,1L,2L,1L,3L,8L,1L,1L,4L,4L,1L,1L,8L,3L,1L,2L,1L,6L,1L,60L,1L,6L,1L,2L,1L,3L,8L,1L,1L,4L,4L,1L,1L,8L,3L,1L,2L,1L,6L,1L,60L,1L,6L,1L,2L,1L,3L,8L,1L,1L,4L,4L,1L,1L,8L,3L,1L,2L,1L,6L,1L,60L,1L,6L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040922Inst : IEnumerable<long>
{
public static readonly long[] Value=A040922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040922.Bytes);
public long this[int i]=>Value[i];

public static A040922Inst Instance=new A040922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040921
{
public static readonly long[] Value={ 30L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040921Inst : IEnumerable<long>
{
public static readonly long[] Value=A040921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040921.Bytes);
public long this[int i]=>Value[i];

public static A040921Inst Instance=new A040921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040920
{
public static readonly long[] Value={ 30L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040920Inst : IEnumerable<long>
{
public static readonly long[] Value=A040920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040920.Bytes);
public long this[int i]=>Value[i];

public static A040920Inst Instance=new A040920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040919
{
public static readonly long[] Value={ 30L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040919Inst : IEnumerable<long>
{
public static readonly long[] Value=A040919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040919.Bytes);
public long this[int i]=>Value[i];

public static A040919Inst Instance=new A040919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040918
{
public static readonly long[] Value={ 30L,1L,4L,6L,1L,1L,1L,4L,2L,14L,1L,19L,1L,1L,1L,1L,19L,1L,14L,2L,4L,1L,1L,1L,6L,4L,1L,60L,1L,4L,6L,1L,1L,1L,4L,2L,14L,1L,19L,1L,1L,1L,1L,19L,1L,14L,2L,4L,1L,1L,1L,6L,4L,1L,60L,1L,4L,6L,1L,1L,1L,4L,2L,14L,1L,19L,1L,1L,1L,1L,19L,1L,14L,2L,4L,1L,1L,1L,6L,4L,1L,60L,1L,4L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040918Inst : IEnumerable<long>
{
public static readonly long[] Value=A040918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040918.Bytes);
public long this[int i]=>Value[i];

public static A040918Inst Instance=new A040918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040917
{
public static readonly long[] Value={ 30L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040917Inst : IEnumerable<long>
{
public static readonly long[] Value=A040917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040917.Bytes);
public long this[int i]=>Value[i];

public static A040917Inst Instance=new A040917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040916
{
public static readonly long[] Value={ 30L,1L,3L,2L,2L,2L,1L,4L,1L,7L,1L,29L,1L,7L,1L,4L,1L,2L,2L,2L,3L,1L,60L,1L,3L,2L,2L,2L,1L,4L,1L,7L,1L,29L,1L,7L,1L,4L,1L,2L,2L,2L,3L,1L,60L,1L,3L,2L,2L,2L,1L,4L,1L,7L,1L,29L,1L,7L,1L,4L,1L,2L,2L,2L,3L,1L,60L,1L,3L,2L,2L,2L,1L,4L,1L,7L,1L,29L,1L,7L,1L,4L,1L,2L,2L,2L,3L,1L,60L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040916Inst : IEnumerable<long>
{
public static readonly long[] Value=A040916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040916.Bytes);
public long this[int i]=>Value[i];

public static A040916Inst Instance=new A040916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040915
{
public static readonly long[] Value={ 30L,1L,3L,8L,1L,1L,6L,3L,3L,1L,3L,1L,1L,1L,2L,30L,2L,1L,1L,1L,3L,1L,3L,3L,6L,1L,1L,8L,3L,1L,60L,1L,3L,8L,1L,1L,6L,3L,3L,1L,3L,1L,1L,1L,2L,30L,2L,1L,1L,1L,3L,1L,3L,3L,6L,1L,1L,8L,3L,1L,60L,1L,3L,8L,1L,1L,6L,3L,3L,1L,3L,1L,1L,1L,2L,30L,2L,1L,1L,1L,3L,1L,3L,3L,6L,1L,1L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040915Inst : IEnumerable<long>
{
public static readonly long[] Value=A040915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040915.Bytes);
public long this[int i]=>Value[i];

public static A040915Inst Instance=new A040915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040914
{
public static readonly long[] Value={ 30L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040914Inst : IEnumerable<long>
{
public static readonly long[] Value=A040914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040914.Bytes);
public long this[int i]=>Value[i];

public static A040914Inst Instance=new A040914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040913
{
public static readonly long[] Value={ 30L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040913Inst : IEnumerable<long>
{
public static readonly long[] Value=A040913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040913.Bytes);
public long this[int i]=>Value[i];

public static A040913Inst Instance=new A040913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040912
{
public static readonly long[] Value={ 30L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040912Inst : IEnumerable<long>
{
public static readonly long[] Value=A040912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040912.Bytes);
public long this[int i]=>Value[i];

public static A040912Inst Instance=new A040912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040911
{
public static readonly long[] Value={ 30L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040911Inst : IEnumerable<long>
{
public static readonly long[] Value=A040911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040911.Bytes);
public long this[int i]=>Value[i];

public static A040911Inst Instance=new A040911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040910
{
public static readonly long[] Value={ 30L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L,1L,11L,2L,1L,60L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L,1L,11L,2L,1L,60L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L,1L,11L,2L,1L,60L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L,1L,11L,2L,1L,60L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040910Inst : IEnumerable<long>
{
public static readonly long[] Value=A040910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040910.Bytes);
public long this[int i]=>Value[i];

public static A040910Inst Instance=new A040910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040909
{
public static readonly long[] Value={ 30L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040909Inst : IEnumerable<long>
{
public static readonly long[] Value=A040909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040909.Bytes);
public long this[int i]=>Value[i];

public static A040909Inst Instance=new A040909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040876
{
public static readonly long[] Value={ 30L,8L,1L,1L,2L,2L,1L,19L,2L,1L,2L,5L,9L,1L,5L,1L,3L,1L,3L,1L,1L,29L,1L,1L,3L,1L,3L,1L,5L,1L,9L,5L,2L,1L,2L,19L,1L,2L,2L,1L,1L,8L,60L,8L,1L,1L,2L,2L,1L,19L,2L,1L,2L,5L,9L,1L,5L,1L,3L,1L,3L,1L,1L,29L,1L,1L,3L,1L,3L,1L,5L,1L,9L,5L,2L,1L,2L,19L,1L,2L,2L,1L,1L,8L,60L,8L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040876Inst : IEnumerable<long>
{
public static readonly long[] Value=A040876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040876.Bytes);
public long this[int i]=>Value[i];

public static A040876Inst Instance=new A040876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040875
{
public static readonly long[] Value={ 30L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040875Inst : IEnumerable<long>
{
public static readonly long[] Value=A040875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040875.Bytes);
public long this[int i]=>Value[i];

public static A040875Inst Instance=new A040875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040874
{
public static readonly long[] Value={ 30L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040874Inst : IEnumerable<long>
{
public static readonly long[] Value=A040874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040874.Bytes);
public long this[int i]=>Value[i];

public static A040874Inst Instance=new A040874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040873
{
public static readonly long[] Value={ 30L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040873Inst : IEnumerable<long>
{
public static readonly long[] Value=A040873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040873.Bytes);
public long this[int i]=>Value[i];

public static A040873Inst Instance=new A040873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040872
{
public static readonly long[] Value={ 30L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040872Inst : IEnumerable<long>
{
public static readonly long[] Value=A040872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040872.Bytes);
public long this[int i]=>Value[i];

public static A040872Inst Instance=new A040872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040871
{
public static readonly long[] Value={ 30L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040871Inst : IEnumerable<long>
{
public static readonly long[] Value=A040871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040871.Bytes);
public long this[int i]=>Value[i];

public static A040871Inst Instance=new A040871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040870
{
public static readonly long[] Value={ 30L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040870Inst : IEnumerable<long>
{
public static readonly long[] Value=A040870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040870.Bytes);
public long this[int i]=>Value[i];

public static A040870Inst Instance=new A040870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040869
{
public static readonly long[] Value={ 29L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040869Inst : IEnumerable<long>
{
public static readonly long[] Value=A040869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040869.Bytes);
public long this[int i]=>Value[i];

public static A040869Inst Instance=new A040869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040868
{
public static readonly long[] Value={ 29L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040868Inst : IEnumerable<long>
{
public static readonly long[] Value=A040868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040868.Bytes);
public long this[int i]=>Value[i];

public static A040868Inst Instance=new A040868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040867
{
public static readonly long[] Value={ 29L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040867Inst : IEnumerable<long>
{
public static readonly long[] Value=A040867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040867.Bytes);
public long this[int i]=>Value[i];

public static A040867Inst Instance=new A040867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040866
{
public static readonly long[] Value={ 29L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040866Inst : IEnumerable<long>
{
public static readonly long[] Value=A040866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040866.Bytes);
public long this[int i]=>Value[i];

public static A040866Inst Instance=new A040866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040865
{
public static readonly long[] Value={ 29L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040865Inst : IEnumerable<long>
{
public static readonly long[] Value=A040865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040865.Bytes);
public long this[int i]=>Value[i];

public static A040865Inst Instance=new A040865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040864
{
public static readonly long[] Value={ 29L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040864Inst : IEnumerable<long>
{
public static readonly long[] Value=A040864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040864.Bytes);
public long this[int i]=>Value[i];

public static A040864Inst Instance=new A040864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040863
{
public static readonly long[] Value={ 29L,1L,7L,1L,1L,4L,14L,1L,2L,1L,1L,2L,1L,1L,2L,1L,14L,4L,1L,1L,7L,1L,58L,1L,7L,1L,1L,4L,14L,1L,2L,1L,1L,2L,1L,1L,2L,1L,14L,4L,1L,1L,7L,1L,58L,1L,7L,1L,1L,4L,14L,1L,2L,1L,1L,2L,1L,1L,2L,1L,14L,4L,1L,1L,7L,1L,58L,1L,7L,1L,1L,4L,14L,1L,2L,1L,1L,2L,1L,1L,2L,1L,14L,4L,1L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040863Inst : IEnumerable<long>
{
public static readonly long[] Value=A040863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040863.Bytes);
public long this[int i]=>Value[i];

public static A040863Inst Instance=new A040863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040862
{
public static readonly long[] Value={ 29L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040862Inst : IEnumerable<long>
{
public static readonly long[] Value=A040862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040862.Bytes);
public long this[int i]=>Value[i];

public static A040862Inst Instance=new A040862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040861
{
public static readonly long[] Value={ 29L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040861Inst : IEnumerable<long>
{
public static readonly long[] Value=A040861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040861.Bytes);
public long this[int i]=>Value[i];

public static A040861Inst Instance=new A040861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040828
{
public static readonly long[] Value={ 29L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040828Inst : IEnumerable<long>
{
public static readonly long[] Value=A040828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040828.Bytes);
public long this[int i]=>Value[i];

public static A040828Inst Instance=new A040828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040827
{
public static readonly long[] Value={ 29L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040827Inst : IEnumerable<long>
{
public static readonly long[] Value=A040827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040827.Bytes);
public long this[int i]=>Value[i];

public static A040827Inst Instance=new A040827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040826
{
public static readonly long[] Value={ 29L,3L,1L,7L,1L,1L,1L,1L,4L,3L,1L,2L,6L,7L,6L,2L,1L,3L,4L,1L,1L,1L,1L,7L,1L,3L,58L,3L,1L,7L,1L,1L,1L,1L,4L,3L,1L,2L,6L,7L,6L,2L,1L,3L,4L,1L,1L,1L,1L,7L,1L,3L,58L,3L,1L,7L,1L,1L,1L,1L,4L,3L,1L,2L,6L,7L,6L,2L,1L,3L,4L,1L,1L,1L,1L,7L,1L,3L,58L,3L,1L,7L,1L,1L,1L,1L,4L,3L,1L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040826Inst : IEnumerable<long>
{
public static readonly long[] Value=A040826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040826.Bytes);
public long this[int i]=>Value[i];

public static A040826Inst Instance=new A040826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040825
{
public static readonly long[] Value={ 29L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040825Inst : IEnumerable<long>
{
public static readonly long[] Value=A040825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040825.Bytes);
public long this[int i]=>Value[i];

public static A040825Inst Instance=new A040825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040824
{
public static readonly long[] Value={ 29L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040824Inst : IEnumerable<long>
{
public static readonly long[] Value=A040824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040824.Bytes);
public long this[int i]=>Value[i];

public static A040824Inst Instance=new A040824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040823
{
public static readonly long[] Value={ 29L,4L,1L,5L,1L,2L,4L,1L,1L,14L,19L,2L,2L,19L,14L,1L,1L,4L,2L,1L,5L,1L,4L,58L,4L,1L,5L,1L,2L,4L,1L,1L,14L,19L,2L,2L,19L,14L,1L,1L,4L,2L,1L,5L,1L,4L,58L,4L,1L,5L,1L,2L,4L,1L,1L,14L,19L,2L,2L,19L,14L,1L,1L,4L,2L,1L,5L,1L,4L,58L,4L,1L,5L,1L,2L,4L,1L,1L,14L,19L,2L,2L,19L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040823Inst : IEnumerable<long>
{
public static readonly long[] Value=A040823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040823.Bytes);
public long this[int i]=>Value[i];

public static A040823Inst Instance=new A040823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040822
{
public static readonly long[] Value={ 29L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040822Inst : IEnumerable<long>
{
public static readonly long[] Value=A040822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040822.Bytes);
public long this[int i]=>Value[i];

public static A040822Inst Instance=new A040822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040821
{
public static readonly long[] Value={ 29L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040821Inst : IEnumerable<long>
{
public static readonly long[] Value=A040821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040821.Bytes);
public long this[int i]=>Value[i];

public static A040821Inst Instance=new A040821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040820
{
public static readonly long[] Value={ 29L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040820Inst : IEnumerable<long>
{
public static readonly long[] Value=A040820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040820.Bytes);
public long this[int i]=>Value[i];

public static A040820Inst Instance=new A040820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040819
{
public static readonly long[] Value={ 29L,7L,3L,1L,2L,1L,7L,1L,1L,2L,4L,11L,2L,2L,1L,18L,1L,2L,2L,11L,4L,2L,1L,1L,7L,1L,2L,1L,3L,7L,58L,7L,3L,1L,2L,1L,7L,1L,1L,2L,4L,11L,2L,2L,1L,18L,1L,2L,2L,11L,4L,2L,1L,1L,7L,1L,2L,1L,3L,7L,58L,7L,3L,1L,2L,1L,7L,1L,1L,2L,4L,11L,2L,2L,1L,18L,1L,2L,2L,11L,4L,2L,1L,1L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040819Inst : IEnumerable<long>
{
public static readonly long[] Value=A040819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040819.Bytes);
public long this[int i]=>Value[i];

public static A040819Inst Instance=new A040819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040818
{
public static readonly long[] Value={ 29L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040818Inst : IEnumerable<long>
{
public static readonly long[] Value=A040818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040818.Bytes);
public long this[int i]=>Value[i];

public static A040818Inst Instance=new A040818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040817
{
public static readonly long[] Value={ 29L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040817Inst : IEnumerable<long>
{
public static readonly long[] Value=A040817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040817.Bytes);
public long this[int i]=>Value[i];

public static A040817Inst Instance=new A040817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040816
{
public static readonly long[] Value={ 29L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040816Inst : IEnumerable<long>
{
public static readonly long[] Value=A040816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040816.Bytes);
public long this[int i]=>Value[i];

public static A040816Inst Instance=new A040816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040815
{
public static readonly long[] Value={ 29L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040815Inst : IEnumerable<long>
{
public static readonly long[] Value=A040815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040815.Bytes);
public long this[int i]=>Value[i];

public static A040815Inst Instance=new A040815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040814
{
public static readonly long[] Value={ 29L,19L,2L,1L,5L,1L,3L,1L,1L,1L,1L,1L,2L,6L,1L,7L,2L,3L,2L,2L,11L,4L,1L,3L,14L,3L,1L,4L,11L,2L,2L,3L,2L,7L,1L,6L,2L,1L,1L,1L,1L,1L,3L,1L,5L,1L,2L,19L,58L,19L,2L,1L,5L,1L,3L,1L,1L,1L,1L,1L,2L,6L,1L,7L,2L,3L,2L,2L,11L,4L,1L,3L,14L,3L,1L,4L,11L,2L,2L,3L,2L,7L,1L,6L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040814Inst : IEnumerable<long>
{
public static readonly long[] Value=A040814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040814.Bytes);
public long this[int i]=>Value[i];

public static A040814Inst Instance=new A040814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040813
{
public static readonly long[] Value={ 29L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040813Inst : IEnumerable<long>
{
public static readonly long[] Value=A040813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040813.Bytes);
public long this[int i]=>Value[i];

public static A040813Inst Instance=new A040813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040796
{
public static readonly long[] Value={ 28L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040796Inst : IEnumerable<long>
{
public static readonly long[] Value=A040796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040796.Bytes);
public long this[int i]=>Value[i];

public static A040796Inst Instance=new A040796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040795
{
public static readonly long[] Value={ 28L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040795Inst : IEnumerable<long>
{
public static readonly long[] Value=A040795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040795.Bytes);
public long this[int i]=>Value[i];

public static A040795Inst Instance=new A040795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040794
{
public static readonly long[] Value={ 28L,1L,2L,4L,1L,7L,2L,1L,1L,1L,1L,8L,1L,18L,4L,2L,1L,3L,2L,2L,5L,1L,27L,1L,5L,2L,2L,3L,1L,2L,4L,18L,1L,8L,1L,1L,1L,1L,2L,7L,1L,4L,2L,1L,56L,1L,2L,4L,1L,7L,2L,1L,1L,1L,1L,8L,1L,18L,4L,2L,1L,3L,2L,2L,5L,1L,27L,1L,5L,2L,2L,3L,1L,2L,4L,18L,1L,8L,1L,1L,1L,1L,2L,7L,1L,4L,2L,1L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040794Inst : IEnumerable<long>
{
public static readonly long[] Value=A040794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040794.Bytes);
public long this[int i]=>Value[i];

public static A040794Inst Instance=new A040794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040793
{
public static readonly long[] Value={ 28L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040793Inst : IEnumerable<long>
{
public static readonly long[] Value=A040793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040793.Bytes);
public long this[int i]=>Value[i];

public static A040793Inst Instance=new A040793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040792
{
public static readonly long[] Value={ 28L,1L,1L,1L,7L,1L,1L,10L,1L,13L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,13L,1L,10L,1L,1L,7L,1L,1L,1L,56L,1L,1L,1L,7L,1L,1L,10L,1L,13L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,13L,1L,10L,1L,1L,7L,1L,1L,1L,56L,1L,1L,1L,7L,1L,1L,10L,1L,13L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,13L,1L,10L,1L,1L,7L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040792Inst : IEnumerable<long>
{
public static readonly long[] Value=A040792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040792.Bytes);
public long this[int i]=>Value[i];

public static A040792Inst Instance=new A040792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040791
{
public static readonly long[] Value={ 28L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040791Inst : IEnumerable<long>
{
public static readonly long[] Value=A040791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040791.Bytes);
public long this[int i]=>Value[i];

public static A040791Inst Instance=new A040791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040790
{
public static readonly long[] Value={ 28L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040790Inst : IEnumerable<long>
{
public static readonly long[] Value=A040790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040790.Bytes);
public long this[int i]=>Value[i];

public static A040790Inst Instance=new A040790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040789
{
public static readonly long[] Value={ 28L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040789Inst : IEnumerable<long>
{
public static readonly long[] Value=A040789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040789.Bytes);
public long this[int i]=>Value[i];

public static A040789Inst Instance=new A040789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040788
{
public static readonly long[] Value={ 28L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040788Inst : IEnumerable<long>
{
public static readonly long[] Value=A040788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040788.Bytes);
public long this[int i]=>Value[i];

public static A040788Inst Instance=new A040788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040787
{
public static readonly long[] Value={ 28L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040787Inst : IEnumerable<long>
{
public static readonly long[] Value=A040787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040787.Bytes);
public long this[int i]=>Value[i];

public static A040787Inst Instance=new A040787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040786
{
public static readonly long[] Value={ 28L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040786Inst : IEnumerable<long>
{
public static readonly long[] Value=A040786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040786.Bytes);
public long this[int i]=>Value[i];

public static A040786Inst Instance=new A040786Inst();

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