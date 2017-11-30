using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A016841
{
public static readonly long[] Value={ 243L,16807L,161051L,759375L,2476099L,6436343L,14348907L,28629151L,52521875L,90224199L,147008443L,229345007L,345025251L,503284375L,714924299L,992436543L,1350125107L,1804229351L,2373046875L,3077056399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016841Inst : IEnumerable<long>
{
public static readonly long[] Value=A016841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016841.Bytes);
public long this[int i]=>Value[i];

public static A016841Inst Instance=new A016841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016840
{
public static readonly long[] Value={ 81L,2401L,14641L,50625L,130321L,279841L,531441L,923521L,1500625L,2313441L,3418801L,4879681L,6765201L,9150625L,12117361L,15752961L,20151121L,25411681L,31640625L,38950081L,47458321L,57289761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016840Inst : IEnumerable<long>
{
public static readonly long[] Value=A016840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016840.Bytes);
public long this[int i]=>Value[i];

public static A016840Inst Instance=new A016840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016839
{
public static readonly long[] Value={ 27L,343L,1331L,3375L,6859L,12167L,19683L,29791L,42875L,59319L,79507L,103823L,132651L,166375L,205379L,250047L,300763L,357911L,421875L,493039L,571787L,658503L,753571L,857375L,970299L,1092727L,1225043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016839Inst : IEnumerable<long>
{
public static readonly long[] Value=A016839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016839.Bytes);
public long this[int i]=>Value[i];

public static A016839Inst Instance=new A016839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016838
{
public static readonly long[] Value={ 9L,49L,121L,225L,361L,529L,729L,961L,1225L,1521L,1849L,2209L,2601L,3025L,3481L,3969L,4489L,5041L,5625L,6241L,6889L,7569L,8281L,9025L,9801L,10609L,11449L,12321L,13225L,14161L,15129L,16129L,17161L,18225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016838Inst : IEnumerable<long>
{
public static readonly long[] Value=A016838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016838.Bytes);
public long this[int i]=>Value[i];

public static A016838Inst Instance=new A016838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016837
{
public static readonly long[] Value={ 23L,11L,23L,17L,11L,23L,23L,23L,17L,47L,19L,41L,23L,23L,47L,53L,41L,59L,29L,31L,47L,71L,47L,47L,41L,71L,71L,89L,71L,167L,83L,47L,53L,47L,71L,113L,59L,71L,71L,269L,83L,131L,59L,167L,71L,167L,59L,149L,167L,71L,167L,191L,83L,71L,167L,79L,89L,179L,251L,227L,167L,149L,149L,83L,269L,239L,89L,167L,251L,263L,251L,251L,113L,239L,149L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016837Inst : IEnumerable<long>
{
public static readonly long[] Value=A016837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016837.Bytes);
public long this[int i]=>Value[i];

public static A016837Inst Instance=new A016837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016836
{
public static readonly BigInteger[] Value={ 4096L,2176782336L,1000000000000L,56693912375296L,1156831381426176L,12855002631049216L,95428956661682176L,531441000000000000L,2386420683693101056L,9065737908494995456L,BigInteger.Parse("30129469486639681536") };
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
public class A016836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016836Inst Instance=new A016836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016835
{
public static readonly long[] Value={ 2048L,362797056L,100000000000L,4049565169664L,64268410079232L,584318301411328L,3670344486987776L,17714700000000000L,70188843638032384L,238572050223552512L,717368321110468608L,1951354384207722496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016835Inst : IEnumerable<long>
{
public static readonly long[] Value=A016835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016835.Bytes);
public long this[int i]=>Value[i];

public static A016835Inst Instance=new A016835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016834
{
public static readonly long[] Value={ 1024L,60466176L,10000000000L,289254654976L,3570467226624L,26559922791424L,141167095653376L,590490000000000L,2064377754059776L,6278211847988224L,17080198121677824L,42420747482776576L,97656250000000000L,210832519264920576L,430804206899405824L,839299365868340224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016834Inst : IEnumerable<long>
{
public static readonly long[] Value=A016834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016834.Bytes);
public long this[int i]=>Value[i];

public static A016834Inst Instance=new A016834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016833
{
public static readonly long[] Value={ 512L,10077696L,1000000000L,20661046784L,198359290368L,1207269217792L,5429503678976L,19683000000000L,60716992766464L,165216101262848L,406671383849472L,922190162669056L,1953125000000000L,3904305912313344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016833Inst : IEnumerable<long>
{
public static readonly long[] Value=A016833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016833.Bytes);
public long this[int i]=>Value[i];

public static A016833Inst Instance=new A016833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016832
{
public static readonly long[] Value={ 256L,1679616L,100000000L,1475789056L,11019960576L,54875873536L,208827064576L,656100000000L,1785793904896L,4347792138496L,9682651996416L,20047612231936L,39062500000000L,72301961339136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016832Inst : IEnumerable<long>
{
public static readonly long[] Value=A016832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016832.Bytes);
public long this[int i]=>Value[i];

public static A016832Inst Instance=new A016832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016831
{
public static readonly long[] Value={ 128L,279936L,10000000L,105413504L,612220032L,2494357888L,8031810176L,21870000000L,52523350144L,114415582592L,230539333248L,435817657216L,781250000000L,1338925209984L,2207984167552L,3521614606208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016831Inst : IEnumerable<long>
{
public static readonly long[] Value=A016831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016831.Bytes);
public long this[int i]=>Value[i];

public static A016831Inst Instance=new A016831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016830
{
public static readonly long[] Value={ 64L,46656L,1000000L,7529536L,34012224L,113379904L,308915776L,729000000L,1544804416L,3010936384L,5489031744L,9474296896L,15625000000L,24794911296L,38068692544L,56800235584L,82653950016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016830Inst : IEnumerable<long>
{
public static readonly long[] Value=A016830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016830.Bytes);
public long this[int i]=>Value[i];

public static A016830Inst Instance=new A016830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016829
{
public static readonly long[] Value={ 32L,7776L,100000L,537824L,1889568L,5153632L,11881376L,24300000L,45435424L,79235168L,130691232L,205962976L,312500000L,459165024L,656356768L,916132832L,1252332576L,1680700000L,2219006624L,2887174368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016829Inst : IEnumerable<long>
{
public static readonly long[] Value=A016829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016829.Bytes);
public long this[int i]=>Value[i];

public static A016829Inst Instance=new A016829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016828
{
public static readonly long[] Value={ 16L,1296L,10000L,38416L,104976L,234256L,456976L,810000L,1336336L,2085136L,3111696L,4477456L,6250000L,8503056L,11316496L,14776336L,18974736L,24010000L,29986576L,37015056L,45212176L,54700816L,65610000L,78074896L,92236816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016828Inst : IEnumerable<long>
{
public static readonly long[] Value=A016828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016828.Bytes);
public long this[int i]=>Value[i];

public static A016828Inst Instance=new A016828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016827
{
public static readonly long[] Value={ 8L,216L,1000L,2744L,5832L,10648L,17576L,27000L,39304L,54872L,74088L,97336L,125000L,157464L,195112L,238328L,287496L,343000L,405224L,474552L,551368L,636056L,729000L,830584L,941192L,1061208L,1191016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016827Inst : IEnumerable<long>
{
public static readonly long[] Value=A016827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016827.Bytes);
public long this[int i]=>Value[i];

public static A016827Inst Instance=new A016827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016826
{
public static readonly long[] Value={ 4L,36L,100L,196L,324L,484L,676L,900L,1156L,1444L,1764L,2116L,2500L,2916L,3364L,3844L,4356L,4900L,5476L,6084L,6724L,7396L,8100L,8836L,9604L,10404L,11236L,12100L,12996L,13924L,14884L,15876L,16900L,17956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016826Inst : IEnumerable<long>
{
public static readonly long[] Value=A016826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016826.Bytes);
public long this[int i]=>Value[i];

public static A016826Inst Instance=new A016826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016825
{
public static readonly long[] Value={ 2L,6L,10L,14L,18L,22L,26L,30L,34L,38L,42L,46L,50L,54L,58L,62L,66L,70L,74L,78L,82L,86L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,130L,134L,138L,142L,146L,150L,154L,158L,162L,166L,170L,174L,178L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,222L,226L,230L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016825Inst : IEnumerable<long>
{
public static readonly long[] Value=A016825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016825.Bytes);
public long this[int i]=>Value[i];

public static A016825Inst Instance=new A016825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016824
{
public static readonly BigInteger[] Value={ 1L,244140625L,282429536481L,23298085122481L,582622237229761L,7355827511386641L,59604644775390625L,353814783205469041L,1667889514952984961L,6582952005840035281L,BigInteger.Parse("22563490300366186081") };
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
public class A016824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016824Inst Instance=new A016824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016823
{
public static readonly BigInteger[] Value={ 1L,48828125L,31381059609L,1792160394037L,34271896307633L,350277500542221L,2384185791015625L,12200509765705829L,50542106513726817L,177917621779460413L,550329031716248441L,1532278301220703125L,3909821048582988049L,9269035929372191597UL,BigInteger.Parse("20635899893042801193") };
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
public class A016823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016823Inst Instance=new A016823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016822
{
public static readonly long[] Value={ 1L,9765625L,3486784401L,137858491849L,2015993900449L,16679880978201L,95367431640625L,420707233300201L,1531578985264449L,4808584372417849L,13422659310152401L,34050628916015625L,79792266297612001L,174887470365513049L,362033331456891249L,713342911662882601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016822Inst : IEnumerable<long>
{
public static readonly long[] Value=A016822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016822.Bytes);
public long this[int i]=>Value[i];

public static A016822Inst Instance=new A016822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016821
{
public static readonly long[] Value={ 1L,1953125L,387420489L,10604499373L,118587876497L,794280046581L,3814697265625L,14507145975869L,46411484401953L,129961739795077L,327381934393961L,756680642578125L,1628413597910449L,3299763591802133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016821Inst : IEnumerable<long>
{
public static readonly long[] Value=A016821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016821.Bytes);
public long this[int i]=>Value[i];

public static A016821Inst Instance=new A016821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016820
{
public static readonly long[] Value={ 1L,390625L,43046721L,815730721L,6975757441L,37822859361L,152587890625L,500246412961L,1406408618241L,3512479453921L,7984925229121L,16815125390625L,33232930569601L,62259690411361L,111429157112001L,191707312997281L,318644812890625L,513798374428641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016820Inst : IEnumerable<long>
{
public static readonly long[] Value=A016820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016820.Bytes);
public long this[int i]=>Value[i];

public static A016820Inst Instance=new A016820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016819
{
public static readonly long[] Value={ 1L,78125L,4782969L,62748517L,410338673L,1801088541L,6103515625L,17249876309L,42618442977L,94931877133L,194754273881L,373669453125L,678223072849L,1174711139837L,1954897493193L,3142742836021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016819Inst : IEnumerable<long>
{
public static readonly long[] Value=A016819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016819.Bytes);
public long this[int i]=>Value[i];

public static A016819Inst Instance=new A016819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016818
{
public static readonly long[] Value={ 1L,15625L,531441L,4826809L,24137569L,85766121L,244140625L,594823321L,1291467969L,2565726409L,4750104241L,8303765625L,13841287201L,22164361129L,34296447249L,51520374361L,75418890625L,107918163081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016818Inst : IEnumerable<long>
{
public static readonly long[] Value=A016818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016818.Bytes);
public long this[int i]=>Value[i];

public static A016818Inst Instance=new A016818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016817
{
public static readonly long[] Value={ 1L,3125L,59049L,371293L,1419857L,4084101L,9765625L,20511149L,39135393L,69343957L,115856201L,184528125L,282475249L,418195493L,601692057L,844596301L,1160290625L,1564031349L,2073071593L,2706784157L,3486784401L,4437053125L,5584059449L,6956883693L,8587340257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016817Inst : IEnumerable<long>
{
public static readonly long[] Value=A016817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016817.Bytes);
public long this[int i]=>Value[i];

public static A016817Inst Instance=new A016817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016816
{
public static readonly long[] Value={ 1L,625L,6561L,28561L,83521L,194481L,390625L,707281L,1185921L,1874161L,2825761L,4100625L,5764801L,7890481L,10556001L,13845841L,17850625L,22667121L,28398241L,35153041L,43046721L,52200625L,62742241L,74805201L,88529281L,104060401L,121550625L,141158161L,163047361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016816Inst : IEnumerable<long>
{
public static readonly long[] Value=A016816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016816.Bytes);
public long this[int i]=>Value[i];

public static A016816Inst Instance=new A016816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016815
{
public static readonly long[] Value={ 1L,125L,729L,2197L,4913L,9261L,15625L,24389L,35937L,50653L,68921L,91125L,117649L,148877L,185193L,226981L,274625L,328509L,389017L,456533L,531441L,614125L,704969L,804357L,912673L,1030301L,1157625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016815Inst : IEnumerable<long>
{
public static readonly long[] Value=A016815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016815.Bytes);
public long this[int i]=>Value[i];

public static A016815Inst Instance=new A016815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016814
{
public static readonly long[] Value={ 1L,25L,81L,169L,289L,441L,625L,841L,1089L,1369L,1681L,2025L,2401L,2809L,3249L,3721L,4225L,4761L,5329L,5929L,6561L,7225L,7921L,8649L,9409L,10201L,11025L,11881L,12769L,13689L,14641L,15625L,16641L,17689L,18769L,19881L,21025L,22201L,23409L,24649L,25921L,27225L,28561L,29929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016814Inst : IEnumerable<long>
{
public static readonly long[] Value=A016814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016814.Bytes);
public long this[int i]=>Value[i];

public static A016814Inst Instance=new A016814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016797
{
public static readonly long[] Value={ 512L,1953125L,134217728L,2357947691L,20661046784L,118587876497L,512000000000L,1801152661463L,5429503678976L,14507145975869L,35184372088832L,78815638671875L,165216101262848L,327381934393961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016797Inst : IEnumerable<long>
{
public static readonly long[] Value=A016797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016797.Bytes);
public long this[int i]=>Value[i];

public static A016797Inst Instance=new A016797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016796
{
public static readonly long[] Value={ 256L,390625L,16777216L,214358881L,1475789056L,6975757441L,25600000000L,78310985281L,208827064576L,500246412961L,1099511627776L,2251875390625L,4347792138496L,7984925229121L,14048223625216L,23811286661761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016796Inst : IEnumerable<long>
{
public static readonly long[] Value=A016796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016796.Bytes);
public long this[int i]=>Value[i];

public static A016796Inst Instance=new A016796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016795
{
public static readonly long[] Value={ 128L,78125L,2097152L,19487171L,105413504L,410338673L,1280000000L,3404825447L,8031810176L,17249876309L,34359738368L,64339296875L,114415582592L,194754273881L,319277809664L,506623120463L,781250000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016795Inst : IEnumerable<long>
{
public static readonly long[] Value=A016795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016795.Bytes);
public long this[int i]=>Value[i];

public static A016795Inst Instance=new A016795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016794
{
public static readonly long[] Value={ 64L,15625L,262144L,1771561L,7529536L,24137569L,64000000L,148035889L,308915776L,594823321L,1073741824L,1838265625L,3010936384L,4750104241L,7256313856L,10779215329L,15625000000L,22164361129L,30840979456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016794Inst : IEnumerable<long>
{
public static readonly long[] Value=A016794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016794.Bytes);
public long this[int i]=>Value[i];

public static A016794Inst Instance=new A016794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016793
{
public static readonly long[] Value={ 32L,3125L,32768L,161051L,537824L,1419857L,3200000L,6436343L,11881376L,20511149L,33554432L,52521875L,79235168L,115856201L,164916224L,229345007L,312500000L,418195493L,550731776L,714924299L,916132832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016793Inst : IEnumerable<long>
{
public static readonly long[] Value=A016793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016793.Bytes);
public long this[int i]=>Value[i];

public static A016793Inst Instance=new A016793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016792
{
public static readonly long[] Value={ 16L,625L,4096L,14641L,38416L,83521L,160000L,279841L,456976L,707281L,1048576L,1500625L,2085136L,2825761L,3748096L,4879681L,6250000L,7890481L,9834496L,12117361L,14776336L,17850625L,21381376L,25411681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016792Inst : IEnumerable<long>
{
public static readonly long[] Value=A016792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016792.Bytes);
public long this[int i]=>Value[i];

public static A016792Inst Instance=new A016792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016791
{
public static readonly long[] Value={ 8L,125L,512L,1331L,2744L,4913L,8000L,12167L,17576L,24389L,32768L,42875L,54872L,68921L,85184L,103823L,125000L,148877L,175616L,205379L,238328L,274625L,314432L,357911L,405224L,456533L,512000L,571787L,636056L,704969L,778688L,857375L,941192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016791Inst : IEnumerable<long>
{
public static readonly long[] Value=A016791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016791.Bytes);
public long this[int i]=>Value[i];

public static A016791Inst Instance=new A016791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016790
{
public static readonly long[] Value={ 4L,25L,64L,121L,196L,289L,400L,529L,676L,841L,1024L,1225L,1444L,1681L,1936L,2209L,2500L,2809L,3136L,3481L,3844L,4225L,4624L,5041L,5476L,5929L,6400L,6889L,7396L,7921L,8464L,9025L,9604L,10201L,10816L,11449L,12100L,12769L,13456L,14161L,14884L,15625L,16384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016790Inst : IEnumerable<long>
{
public static readonly long[] Value=A016790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016790.Bytes);
public long this[int i]=>Value[i];

public static A016790Inst Instance=new A016790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016789
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,23L,26L,29L,32L,35L,38L,41L,44L,47L,50L,53L,56L,59L,62L,65L,68L,71L,74L,77L,80L,83L,86L,89L,92L,95L,98L,101L,104L,107L,110L,113L,116L,119L,122L,125L,128L,131L,134L,137L,140L,143L,146L,149L,152L,155L,158L,161L,164L,167L,170L,173L,176L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016789Inst : IEnumerable<long>
{
public static readonly long[] Value=A016789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016789.Bytes);
public long this[int i]=>Value[i];

public static A016789Inst Instance=new A016789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016788
{
public static readonly long[] Value={ 1L,16777216L,13841287201L,1000000000000L,23298085122481L,281474976710656L,2213314919066161L,12855002631049216L,59604644775390625L,232218265089212416L,787662783788549761L,2386420683693101056L,6582952005840035281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016788Inst : IEnumerable<long>
{
public static readonly long[] Value=A016788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016788.Bytes);
public long this[int i]=>Value[i];

public static A016788Inst Instance=new A016788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016787
{
public static readonly long[] Value={ 1L,4194304L,1977326743L,100000000000L,1792160394037L,17592186044416L,116490258898219L,584318301411328L,2384185791015625L,8293509467471872L,25408476896404831L,70188843638032384L,177917621779460413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016787Inst : IEnumerable<long>
{
public static readonly long[] Value=A016787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016787.Bytes);
public long this[int i]=>Value[i];

public static A016787Inst Instance=new A016787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016786
{
public static readonly long[] Value={ 1L,1048576L,282475249L,10000000000L,137858491849L,1099511627776L,6131066257801L,26559922791424L,95367431640625L,296196766695424L,819628286980801L,2064377754059776L,4808584372417849L,10485760000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016786Inst : IEnumerable<long>
{
public static readonly long[] Value=A016786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016786.Bytes);
public long this[int i]=>Value[i];

public static A016786Inst Instance=new A016786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016785
{
public static readonly long[] Value={ 1L,262144L,40353607L,1000000000L,10604499373L,68719476736L,322687697779L,1207269217792L,3814697265625L,10578455953408L,26439622160671L,60716992766464L,129961739795077L,262144000000000L,502592611936843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016785Inst : IEnumerable<long>
{
public static readonly long[] Value=A016785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016785.Bytes);
public long this[int i]=>Value[i];

public static A016785Inst Instance=new A016785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016784
{
public static readonly long[] Value={ 1L,65536L,5764801L,100000000L,815730721L,4294967296L,16983563041L,54875873536L,152587890625L,377801998336L,852891037441L,1785793904896L,3512479453921L,6553600000000L,11688200277601L,20047612231936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016784Inst : IEnumerable<long>
{
public static readonly long[] Value=A016784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016784.Bytes);
public long this[int i]=>Value[i];

public static A016784Inst Instance=new A016784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016783
{
public static readonly long[] Value={ 1L,16384L,823543L,10000000L,62748517L,268435456L,893871739L,2494357888L,6103515625L,13492928512L,27512614111L,52523350144L,94931877133L,163840000000L,271818611107L,435817657216L,678223072849L,1028071702528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016783Inst : IEnumerable<long>
{
public static readonly long[] Value=A016783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016783.Bytes);
public long this[int i]=>Value[i];

public static A016783Inst Instance=new A016783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016782
{
public static readonly long[] Value={ 1L,4096L,117649L,1000000L,4826809L,16777216L,47045881L,113379904L,244140625L,481890304L,887503681L,1544804416L,2565726409L,4096000000L,6321363049L,9474296896L,13841287201L,19770609664L,27680640625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016782Inst : IEnumerable<long>
{
public static readonly long[] Value=A016782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016782.Bytes);
public long this[int i]=>Value[i];

public static A016782Inst Instance=new A016782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016765
{
public static readonly long[] Value={ 1L,13L,115L,865L,5971L,39193L,249355L,1555105L,9573091L,58428073L,354585595L,2143759345L,12928070611L,77832076153L,468051849835L,2812563019585L,16892428846531L,101422905135433L,608811146458075L,3653962903591825L,21928165007708851L,131586550851237913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016765Inst : IEnumerable<long>
{
public static readonly long[] Value=A016765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016765.Bytes);
public long this[int i]=>Value[i];

public static A016765Inst Instance=new A016765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016764
{
public static readonly long[] Value={ 1L,531441L,244140625L,13841287201L,282429536481L,3138428376721L,23298085122481L,129746337890625L,582622237229761L,2213314919066161L,7355827511386641L,21914624432020321L,59604644775390625L,150094635296999121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016764Inst : IEnumerable<long>
{
public static readonly long[] Value=A016764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016764.Bytes);
public long this[int i]=>Value[i];

public static A016764Inst Instance=new A016764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016763
{
public static readonly long[] Value={ 1L,177147L,48828125L,1977326743L,31381059609L,285311670611L,1792160394037L,8649755859375L,34271896307633L,116490258898219L,350277500542221L,952809757913927L,2384185791015625L,5559060566555523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016763Inst : IEnumerable<long>
{
public static readonly long[] Value=A016763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016763.Bytes);
public long this[int i]=>Value[i];

public static A016763Inst Instance=new A016763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016762
{
public static readonly long[] Value={ 1L,59049L,9765625L,282475249L,3486784401L,25937424601L,137858491849L,576650390625L,2015993900449L,6131066257801L,16679880978201L,41426511213649L,95367431640625L,205891132094649L,420707233300201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016762Inst : IEnumerable<long>
{
public static readonly long[] Value=A016762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016762.Bytes);
public long this[int i]=>Value[i];

public static A016762Inst Instance=new A016762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016761
{
public static readonly long[] Value={ 1L,19683L,1953125L,40353607L,387420489L,2357947691L,10604499373L,38443359375L,118587876497L,322687697779L,794280046581L,1801152661463L,3814697265625L,7625597484987L,14507145975869L,26439622160671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016761Inst : IEnumerable<long>
{
public static readonly long[] Value=A016761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016761.Bytes);
public long this[int i]=>Value[i];

public static A016761Inst Instance=new A016761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016760
{
public static readonly long[] Value={ 1L,6561L,390625L,5764801L,43046721L,214358881L,815730721L,2562890625L,6975757441L,16983563041L,37822859361L,78310985281L,152587890625L,282429536481L,500246412961L,852891037441L,1406408618241L,2251875390625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016760Inst : IEnumerable<long>
{
public static readonly long[] Value=A016760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016760.Bytes);
public long this[int i]=>Value[i];

public static A016760Inst Instance=new A016760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016759
{
public static readonly long[] Value={ 1L,2187L,78125L,823543L,4782969L,19487171L,62748517L,170859375L,410338673L,893871739L,1801088541L,3404825447L,6103515625L,10460353203L,17249876309L,27512614111L,42618442977L,64339296875L,94931877133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016759Inst : IEnumerable<long>
{
public static readonly long[] Value=A016759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016759.Bytes);
public long this[int i]=>Value[i];

public static A016759Inst Instance=new A016759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016758
{
public static readonly long[] Value={ 1L,729L,15625L,117649L,531441L,1771561L,4826809L,11390625L,24137569L,47045881L,85766121L,148035889L,244140625L,387420489L,594823321L,887503681L,1291467969L,1838265625L,2565726409L,3518743761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016758Inst : IEnumerable<long>
{
public static readonly long[] Value=A016758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016758.Bytes);
public long this[int i]=>Value[i];

public static A016758Inst Instance=new A016758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016757
{
public static readonly long[] Value={ 1L,243L,3125L,16807L,59049L,161051L,371293L,759375L,1419857L,2476099L,4084101L,6436343L,9765625L,14348907L,20511149L,28629151L,39135393L,52521875L,69343957L,90224199L,115856201L,147008443L,184528125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016757Inst : IEnumerable<long>
{
public static readonly long[] Value=A016757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016757.Bytes);
public long this[int i]=>Value[i];

public static A016757Inst Instance=new A016757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016756
{
public static readonly long[] Value={ 1L,81L,625L,2401L,6561L,14641L,28561L,50625L,83521L,130321L,194481L,279841L,390625L,531441L,707281L,923521L,1185921L,1500625L,1874161L,2313441L,2825761L,3418801L,4100625L,4879681L,5764801L,6765201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016756Inst : IEnumerable<long>
{
public static readonly long[] Value=A016756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016756.Bytes);
public long this[int i]=>Value[i];

public static A016756Inst Instance=new A016756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016755
{
public static readonly long[] Value={ 1L,27L,125L,343L,729L,1331L,2197L,3375L,4913L,6859L,9261L,12167L,15625L,19683L,24389L,29791L,35937L,42875L,50653L,59319L,68921L,79507L,91125L,103823L,117649L,132651L,148877L,166375L,185193L,205379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016755Inst : IEnumerable<long>
{
public static readonly long[] Value=A016755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016755.Bytes);
public long this[int i]=>Value[i];

public static A016755Inst Instance=new A016755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016754
{
public static readonly long[] Value={ 1L,9L,25L,49L,81L,121L,169L,225L,289L,361L,441L,529L,625L,729L,841L,961L,1089L,1225L,1369L,1521L,1681L,1849L,2025L,2209L,2401L,2601L,2809L,3025L,3249L,3481L,3721L,3969L,4225L,4489L,4761L,5041L,5329L,5625L,5929L,6241L,6561L,6889L,7225L,7569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016754Inst : IEnumerable<long>
{
public static readonly long[] Value=A016754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016754.Bytes);
public long this[int i]=>Value[i];

public static A016754Inst Instance=new A016754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016753
{
public static readonly long[] Value={ 1L,12L,97L,660L,4081L,23772L,133057L,724260L,3863761L,20308332L,105558817L,544039860L,2785713841L,14192221692L,72020501377L,364354427460L,1838822866321L,9262446387852L,46585947584737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016753Inst : IEnumerable<long>
{
public static readonly long[] Value=A016753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016753.Bytes);
public long this[int i]=>Value[i];

public static A016753Inst Instance=new A016753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016752
{
public static readonly long[] Value={ 0L,4096L,16777216L,2176782336L,68719476736L,1000000000000L,8916100448256L,56693912375296L,281474976710656L,1156831381426176L,4096000000000000L,12855002631049216L,36520347436056576L,95428956661682176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016752Inst : IEnumerable<long>
{
public static readonly long[] Value=A016752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016752.Bytes);
public long this[int i]=>Value[i];

public static A016752Inst Instance=new A016752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016751
{
public static readonly long[] Value={ 0L,2048L,4194304L,362797056L,8589934592L,100000000000L,743008370688L,4049565169664L,17592186044416L,64268410079232L,204800000000000L,584318301411328L,1521681143169024L,3670344486987776L,8293509467471872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016751Inst : IEnumerable<long>
{
public static readonly long[] Value=A016751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016751.Bytes);
public long this[int i]=>Value[i];

public static A016751Inst Instance=new A016751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016750
{
public static readonly long[] Value={ 0L,1024L,1048576L,60466176L,1073741824L,10000000000L,61917364224L,289254654976L,1099511627776L,3570467226624L,10240000000000L,26559922791424L,63403380965376L,141167095653376L,296196766695424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016750Inst : IEnumerable<long>
{
public static readonly long[] Value=A016750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016750.Bytes);
public long this[int i]=>Value[i];

public static A016750Inst Instance=new A016750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016733
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,4L,6L,94L,1L,3L,4L,40L,1L,5L,2L,2L,1L,1L,7L,7L,8L,39L,4L,3L,4L,1L,9L,1L,1L,2L,1L,7L,1L,6L,2L,18L,1L,1L,1L,12L,1L,1L,3L,1L,1L,4L,16L,16L,3L,3L,2L,1L,17L,1L,8L,1L,20L,1L,15L,15L,10L,2L,13L,1L,1L,34L,1L,32L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016733Inst : IEnumerable<long>
{
public static readonly long[] Value=A016733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016733.Bytes);
public long this[int i]=>Value[i];

public static A016733Inst Instance=new A016733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016732
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,7L,6L,4L,1L,1L,21L,3L,1L,3L,3L,1L,1L,2L,1L,1L,2L,6L,1L,1L,3L,9L,3L,3L,1L,2L,1L,1L,1L,3L,1L,10L,7L,2L,5L,2L,2L,4L,9L,7L,1L,1L,1L,13L,1L,14L,1L,1L,1L,1L,2L,6L,1L,1L,1L,2L,2L,9L,1L,1L,3L,3L,1L,34L,1L,1L,5L,16L,3L,3L,1L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016732Inst : IEnumerable<long>
{
public static readonly long[] Value=A016732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016732.Bytes);
public long this[int i]=>Value[i];

public static A016732Inst Instance=new A016732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016731
{
public static readonly long[] Value={ 1L,10L,7L,9L,2L,2L,1L,3L,1L,32L,2L,17L,1L,15L,1L,1L,7L,3L,1L,35L,1L,1L,1L,2L,5L,3L,2L,1L,4L,2L,1L,3L,1L,5L,3L,13L,1L,1L,1L,6L,2L,3L,1L,152L,1L,2L,3L,1L,7L,9L,2L,1L,3L,19L,2L,2L,2L,3L,2L,5L,1L,1L,4L,1L,19L,5L,4L,2L,1L,2L,7L,4L,2L,1L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016731Inst : IEnumerable<long>
{
public static readonly long[] Value=A016731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016731.Bytes);
public long this[int i]=>Value[i];

public static A016731Inst Instance=new A016731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016730
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,6L,3L,1L,1L,2L,1L,1L,1L,1L,3L,10L,1L,1L,1L,2L,1L,1L,1L,1L,3L,2L,3L,1L,13L,7L,4L,1L,1L,1L,7L,2L,4L,1L,1L,2L,5L,14L,1L,10L,1L,4L,2L,18L,3L,1L,4L,1L,6L,2L,7L,3L,3L,1L,13L,3L,1L,4L,4L,1L,3L,1L,1L,1L,1L,2L,17L,3L,1L,2L,32L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016730Inst : IEnumerable<long>
{
public static readonly long[] Value=A016730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016730.Bytes);
public long this[int i]=>Value[i];

public static A016730Inst Instance=new A016730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016729
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,3L,4L,4L,4L,5L,6L,5L,6L,6L,6L,7L,8L,7L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016729Inst : IEnumerable<long>
{
public static readonly long[] Value=A016729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016729.Bytes);
public long this[int i]=>Value[i];

public static A016729Inst Instance=new A016729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016728
{
public static readonly long[] Value={ 1L,18L,62L,98L,210L,350L,450L,602L,762L,1142L,1250L,1458L,1814L,2178L,2498L,2622L,3338L,3722L,4170L,4358L,5034L,5714L,5982L,6602L,7130L,8034L,8606L,9066L,9962L,10550L,11226L,12146L,12606L,13802L,14754L,15194L,16454L,17154L,18266L,18750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016728Inst : IEnumerable<long>
{
public static readonly long[] Value=A016728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016728.Bytes);
public long this[int i]=>Value[i];

public static A016728Inst Instance=new A016728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016727
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,1L,4L,2L,3L,2L,3L,2L,5L,1L,4L,4L,4L,2L,7L,3L,4L,2L,5L,3L,9L,2L,5L,5L,5L,1L,11L,4L,7L,4L,6L,4L,10L,2L,7L,7L,7L,3L,13L,4L,7L,2L,9L,5L,14L,3L,8L,9L,10L,2L,16L,5L,9L,5L,9L,5L,21L,1L,11L,11L,10L,4L,17L,7L,10L,4L,11L,6L,18L,4L,16L,10L,11L,2L,23L,7L,12L,7L,14L,7L,20L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016727Inst : IEnumerable<long>
{
public static readonly long[] Value=A016727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016727.Bytes);
public long this[int i]=>Value[i];

public static A016727Inst Instance=new A016727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016726
{
public static readonly long[] Value={ 1L,2L,6L,9L,10L,13L,14L,17L,19L,22L,22L,26L,26L,29L,31L,34L,34L,37L,38L,41L,43L,46L,46L,53L,53L,53L,58L,58L,58L,61L,62L,67L,67L,71L,71L,73L,74L,79L,79L,82L,82L,86L,86L,89L,94L,94L,94L,97L,101L,101L,103L,106L,106L,109L,113L,113L,118L,118L,118L,122L,122L,127L,127L,131L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016726Inst : IEnumerable<long>
{
public static readonly long[] Value=A016726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016726.Bytes);
public long this[int i]=>Value[i];

public static A016726Inst Instance=new A016726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016725
{
public static readonly long[] Value={ 1L,6L,6L,30L,6L,30L,30L,54L,6L,102L,30L,78L,30L,78L,54L,150L,6L,102L,102L,126L,30L,270L,78L,150L,30L,150L,78L,318L,54L,174L,150L,198L,6L,390L,102L,270L,102L,222L,126L,390L,30L,246L,270L,270L,78L,510L,150L,294L,30L,390L,150L,510L,78L,318L,318L,390L,54L,630L,174L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016725Inst : IEnumerable<long>
{
public static readonly long[] Value=A016725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016725.Bytes);
public long this[int i]=>Value[i];

public static A016725Inst Instance=new A016725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016724
{
public static readonly long[] Value={ 2L,2L,5L,4L,9L,6L,15L,8L,25L,10L,43L,12L,77L,14L,143L,16L,273L,18L,531L,20L,1045L,22L,2071L,24L,4121L,26L,8219L,28L,16413L,30L,32799L,32L,65569L,34L,131107L,36L,262181L,38L,524327L,40L,1048617L,42L,2097195L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016724Inst : IEnumerable<long>
{
public static readonly long[] Value=A016724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016724.Bytes);
public long this[int i]=>Value[i];

public static A016724Inst Instance=new A016724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016723
{
public static readonly long[] Value={ 4L,6L,0L,5L,1L,7L,0L,1L,8L,5L,9L,8L,8L,0L,9L,1L,3L,6L,8L,0L,3L,5L,9L,8L,2L,9L,0L,9L,3L,6L,8L,7L,2L,8L,4L,1L,5L,2L,0L,2L,2L,0L,2L,9L,7L,7L,2L,5L,7L,5L,4L,5L,9L,5L,2L,0L,6L,6L,6L,5L,5L,8L,0L,1L,9L,3L,5L,1L,4L,5L,2L,1L,9L,3L,5L,4L,7L,0L,4L,9L,6L,0L,4L,7L,1L,9L,9L,4L,4L,1L,0L,1L,7L,9L,1L,9L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016723Inst : IEnumerable<long>
{
public static readonly long[] Value=A016723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016723.Bytes);
public long this[int i]=>Value[i];

public static A016723Inst Instance=new A016723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016722
{
public static readonly long[] Value={ 4L,5L,9L,5L,1L,1L,9L,8L,5L,0L,1L,3L,4L,5L,8L,9L,9L,2L,6L,8L,5L,2L,4L,3L,4L,0L,5L,1L,8L,1L,0L,1L,8L,0L,7L,0L,9L,1L,1L,6L,6L,8L,7L,9L,6L,9L,5L,8L,2L,9L,1L,6L,0L,7L,8L,6L,8L,7L,9L,5L,6L,3L,7L,6L,4L,0L,5L,5L,6L,2L,2L,1L,0L,3L,5L,0L,4L,5L,4L,6L,4L,6L,8L,2L,2L,2L,8L,6L,2L,1L,7L,6L,3L,0L,0L,9L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016722Inst : IEnumerable<long>
{
public static readonly long[] Value=A016722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016722.Bytes);
public long this[int i]=>Value[i];

public static A016722Inst Instance=new A016722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016721
{
public static readonly long[] Value={ 4L,5L,8L,4L,9L,6L,7L,4L,7L,8L,6L,7L,0L,5L,7L,1L,9L,1L,9L,6L,2L,7L,9L,3L,7L,6L,0L,8L,3L,4L,4L,5L,3L,6L,0L,2L,7L,3L,4L,9L,6L,6L,9L,5L,9L,3L,5L,2L,3L,9L,7L,7L,6L,3L,1L,0L,3L,9L,4L,6L,0L,3L,0L,9L,3L,6L,8L,5L,5L,3L,3L,4L,7L,4L,7L,3L,8L,3L,3L,2L,5L,1L,1L,8L,1L,1L,8L,0L,3L,2L,4L,1L,7L,2L,1L,6L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016721Inst : IEnumerable<long>
{
public static readonly long[] Value=A016721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016721.Bytes);
public long this[int i]=>Value[i];

public static A016721Inst Instance=new A016721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016720
{
public static readonly long[] Value={ 4L,5L,7L,4L,7L,1L,0L,9L,7L,8L,5L,0L,3L,3L,8L,2L,8L,2L,2L,1L,1L,6L,7L,2L,1L,6L,2L,1L,7L,0L,3L,9L,6L,1L,7L,1L,3L,8L,0L,8L,9L,1L,4L,9L,0L,2L,6L,5L,8L,7L,8L,1L,3L,5L,5L,9L,7L,6L,2L,3L,4L,3L,6L,8L,7L,6L,0L,1L,7L,7L,2L,9L,1L,7L,7L,8L,1L,8L,7L,1L,2L,5L,3L,4L,2L,2L,8L,2L,7L,4L,5L,0L,3L,4L,2L,7L,4L,5L,4L,9L,9L,2L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016720Inst : IEnumerable<long>
{
public static readonly long[] Value=A016720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016720.Bytes);
public long this[int i]=>Value[i];

public static A016720Inst Instance=new A016720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016719
{
public static readonly long[] Value={ 4L,5L,6L,4L,3L,4L,8L,1L,9L,1L,4L,6L,7L,8L,3L,6L,2L,3L,8L,4L,8L,1L,4L,0L,5L,8L,4L,4L,2L,1L,3L,4L,0L,8L,5L,4L,5L,0L,2L,4L,9L,9L,1L,2L,2L,9L,6L,2L,4L,0L,2L,5L,7L,2L,2L,3L,3L,8L,0L,9L,4L,3L,8L,1L,1L,0L,4L,4L,6L,2L,4L,0L,3L,0L,6L,7L,0L,8L,2L,5L,4L,4L,9L,0L,2L,9L,3L,2L,3L,8L,9L,7L,9L,5L,8L,2L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016719Inst : IEnumerable<long>
{
public static readonly long[] Value=A016719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016719.Bytes);
public long this[int i]=>Value[i];

public static A016719Inst Instance=new A016719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016718
{
public static readonly long[] Value={ 4L,5L,5L,3L,8L,7L,6L,8L,9L,1L,6L,0L,0L,5L,4L,0L,8L,3L,4L,6L,0L,9L,7L,8L,6L,7L,6L,5L,1L,1L,4L,0L,4L,1L,1L,7L,6L,7L,6L,2L,9L,8L,0L,6L,1L,5L,5L,6L,7L,6L,4L,6L,5L,4L,0L,4L,5L,0L,6L,0L,8L,1L,2L,7L,8L,8L,3L,4L,7L,1L,6L,8L,9L,7L,7L,1L,8L,5L,5L,0L,5L,3L,3L,4L,4L,2L,9L,2L,2L,6L,1L,9L,0L,8L,9L,1L,9L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016718Inst : IEnumerable<long>
{
public static readonly long[] Value=A016718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016718.Bytes);
public long this[int i]=>Value[i];

public static A016718Inst Instance=new A016718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016701
{
public static readonly long[] Value={ 4L,3L,5L,6L,7L,0L,8L,8L,2L,6L,6L,8L,9L,5L,9L,1L,7L,3L,6L,8L,6L,5L,9L,6L,4L,7L,9L,9L,9L,4L,6L,0L,2L,0L,8L,7L,7L,5L,2L,8L,2L,5L,8L,6L,3L,6L,9L,4L,3L,2L,1L,1L,8L,2L,2L,2L,7L,4L,4L,1L,9L,8L,5L,3L,7L,9L,4L,3L,5L,2L,5L,8L,2L,5L,1L,2L,7L,1L,3L,8L,6L,1L,8L,7L,9L,0L,5L,3L,7L,4L,5L,2L,5L,0L,6L,4L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016701Inst : IEnumerable<long>
{
public static readonly long[] Value=A016701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016701.Bytes);
public long this[int i]=>Value[i];

public static A016701Inst Instance=new A016701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016700
{
public static readonly long[] Value={ 4L,3L,4L,3L,8L,0L,5L,4L,2L,1L,8L,5L,3L,6L,8L,3L,8L,4L,9L,1L,6L,7L,2L,9L,6L,3L,2L,1L,4L,0L,8L,3L,0L,9L,0L,2L,9L,4L,5L,8L,7L,9L,1L,5L,8L,3L,5L,1L,9L,2L,7L,8L,3L,6L,3L,6L,7L,7L,9L,5L,7L,8L,5L,9L,0L,6L,8L,1L,5L,3L,4L,8L,6L,6L,6L,5L,3L,0L,5L,9L,8L,0L,8L,6L,2L,7L,1L,3L,2L,0L,6L,5L,9L,0L,5L,0L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016700Inst : IEnumerable<long>
{
public static readonly long[] Value=A016700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016700.Bytes);
public long this[int i]=>Value[i];

public static A016700Inst Instance=new A016700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016699
{
public static readonly long[] Value={ 4L,3L,3L,0L,7L,3L,3L,3L,4L,0L,2L,8L,6L,3L,3L,1L,0L,7L,8L,8L,4L,3L,4L,9L,1L,6L,7L,4L,8L,0L,4L,2L,0L,6L,6L,7L,3L,3L,8L,8L,3L,7L,9L,5L,3L,0L,0L,1L,9L,6L,3L,9L,3L,2L,6L,7L,7L,9L,3L,2L,0L,2L,5L,5L,3L,9L,6L,0L,7L,9L,9L,4L,6L,0L,0L,3L,5L,8L,6L,7L,1L,9L,9L,2L,5L,8L,8L,5L,0L,3L,7L,8L,0L,8L,5L,7L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016699Inst : IEnumerable<long>
{
public static readonly long[] Value=A016699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016699.Bytes);
public long this[int i]=>Value[i];

public static A016699Inst Instance=new A016699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016698
{
public static readonly long[] Value={ 4L,3L,1L,7L,4L,8L,8L,1L,1L,3L,5L,3L,6L,3L,1L,0L,4L,4L,0L,5L,9L,6L,7L,6L,3L,9L,0L,3L,3L,7L,4L,9L,0L,0L,9L,8L,3L,6L,9L,8L,6L,9L,3L,2L,6L,6L,3L,5L,9L,7L,8L,4L,8L,9L,5L,5L,5L,9L,9L,9L,0L,1L,1L,6L,5L,8L,5L,8L,5L,2L,2L,6L,8L,6L,3L,3L,9L,2L,4L,4L,9L,6L,1L,3L,3L,8L,8L,3L,5L,1L,1L,0L,0L,0L,0L,9L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016698Inst : IEnumerable<long>
{
public static readonly long[] Value=A016698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016698.Bytes);
public long this[int i]=>Value[i];

public static A016698Inst Instance=new A016698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016697
{
public static readonly long[] Value={ 4L,3L,0L,4L,0L,6L,5L,0L,9L,3L,2L,0L,4L,1L,6L,9L,7L,5L,3L,7L,8L,5L,3L,2L,7L,7L,9L,2L,4L,8L,9L,6L,2L,3L,7L,3L,1L,9L,7L,5L,5L,7L,7L,7L,2L,1L,5L,2L,7L,8L,9L,1L,4L,1L,7L,7L,6L,5L,5L,9L,2L,6L,9L,0L,6L,8L,6L,3L,8L,3L,3L,6L,8L,9L,6L,0L,0L,5L,5L,7L,8L,1L,0L,0L,4L,8L,8L,4L,8L,6L,0L,6L,6L,8L,5L,8L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016697Inst : IEnumerable<long>
{
public static readonly long[] Value=A016697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016697.Bytes);
public long this[int i]=>Value[i];

public static A016697Inst Instance=new A016697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016696
{
public static readonly long[] Value={ 4L,2L,9L,0L,4L,5L,9L,4L,4L,1L,1L,4L,8L,3L,9L,1L,1L,2L,9L,0L,9L,2L,1L,0L,8L,8L,5L,7L,4L,3L,8L,5L,4L,2L,5L,7L,0L,9L,0L,4L,7L,5L,2L,8L,4L,4L,8L,7L,1L,5L,9L,7L,6L,6L,4L,5L,9L,5L,6L,9L,8L,8L,5L,7L,1L,6L,1L,7L,8L,9L,9L,7L,5L,9L,2L,0L,5L,9L,7L,2L,9L,3L,2L,7L,6L,3L,2L,9L,3L,2L,2L,8L,3L,4L,8L,5L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016696Inst : IEnumerable<long>
{
public static readonly long[] Value=A016696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016696.Bytes);
public long this[int i]=>Value[i];

public static A016696Inst Instance=new A016696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016695
{
public static readonly long[] Value={ 4L,2L,7L,6L,6L,6L,6L,1L,1L,9L,0L,1L,6L,0L,5L,5L,3L,1L,1L,0L,4L,2L,1L,8L,6L,8L,3L,8L,2L,1L,9L,5L,8L,1L,1L,1L,3L,5L,2L,1L,4L,8L,1L,5L,1L,8L,7L,2L,6L,2L,6L,4L,6L,6L,5L,8L,3L,1L,4L,2L,8L,6L,9L,5L,7L,5L,5L,1L,6L,9L,4L,5L,2L,3L,4L,6L,3L,0L,2L,0L,8L,0L,5L,6L,4L,8L,2L,1L,4L,9L,0L,6L,1L,6L,7L,2L,0L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016695Inst : IEnumerable<long>
{
public static readonly long[] Value=A016695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016695.Bytes);
public long this[int i]=>Value[i];

public static A016695Inst Instance=new A016695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016694
{
public static readonly long[] Value={ 4L,2L,6L,2L,6L,7L,9L,8L,7L,7L,0L,4L,1L,3L,1L,5L,4L,2L,1L,3L,2L,9L,4L,5L,4L,5L,3L,2L,5L,1L,3L,0L,3L,4L,0L,9L,6L,7L,5L,9L,5L,7L,6L,5L,2L,6L,7L,1L,0L,5L,6L,6L,1L,0L,8L,1L,2L,1L,4L,2L,5L,8L,0L,2L,0L,2L,7L,3L,5L,1L,5L,0L,6L,8L,2L,4L,2L,3L,0L,3L,6L,5L,9L,6L,6L,2L,4L,3L,3L,2L,4L,2L,7L,2L,6L,3L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016694Inst : IEnumerable<long>
{
public static readonly long[] Value=A016694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016694.Bytes);
public long this[int i]=>Value[i];

public static A016694Inst Instance=new A016694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016693
{
public static readonly long[] Value={ 4L,2L,4L,8L,4L,9L,5L,2L,4L,2L,0L,4L,9L,3L,5L,8L,9L,8L,9L,1L,2L,3L,3L,4L,4L,1L,9L,8L,1L,2L,7L,5L,4L,3L,9L,3L,7L,2L,3L,8L,1L,8L,6L,2L,1L,8L,2L,1L,0L,6L,3L,4L,1L,6L,4L,4L,9L,2L,7L,1L,8L,0L,5L,0L,9L,0L,5L,1L,5L,2L,4L,7L,2L,4L,2L,9L,4L,2L,1L,7L,4L,8L,0L,2L,3L,6L,5L,5L,7L,0L,3L,6L,7L,7L,4L,6L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016693Inst : IEnumerable<long>
{
public static readonly long[] Value=A016693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016693.Bytes);
public long this[int i]=>Value[i];

public static A016693Inst Instance=new A016693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016692
{
public static readonly long[] Value={ 4L,2L,3L,4L,1L,0L,6L,5L,0L,4L,5L,9L,7L,2L,5L,9L,3L,8L,2L,2L,0L,1L,9L,9L,8L,0L,6L,8L,7L,3L,2L,7L,2L,1L,8L,2L,3L,0L,8L,9L,8L,7L,0L,8L,7L,2L,6L,6L,3L,1L,8L,5L,1L,9L,3L,7L,3L,3L,3L,2L,9L,7L,1L,1L,1L,2L,0L,4L,8L,7L,5L,3L,9L,2L,0L,3L,4L,0L,7L,2L,6L,5L,0L,7L,2L,0L,1L,6L,8L,4L,6L,9L,6L,6L,7L,2L,6L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016692Inst : IEnumerable<long>
{
public static readonly long[] Value=A016692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016692.Bytes);
public long this[int i]=>Value[i];

public static A016692Inst Instance=new A016692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016691
{
public static readonly long[] Value={ 4L,2L,1L,9L,5L,0L,7L,7L,0L,5L,1L,7L,6L,1L,0L,6L,6L,9L,9L,0L,8L,3L,9L,9L,8L,8L,6L,0L,7L,8L,9L,4L,7L,9L,6L,7L,1L,7L,3L,9L,2L,0L,3L,2L,8L,1L,3L,0L,6L,2L,5L,5L,2L,9L,5L,5L,3L,8L,5L,9L,7L,7L,5L,6L,8L,6L,9L,0L,7L,9L,8L,1L,9L,7L,4L,0L,3L,2L,0L,7L,1L,2L,1L,2L,3L,8L,2L,1L,5L,2L,2L,0L,3L,0L,3L,4L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016691Inst : IEnumerable<long>
{
public static readonly long[] Value=A016691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016691.Bytes);
public long this[int i]=>Value[i];

public static A016691Inst Instance=new A016691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016690
{
public static readonly long[] Value={ 4L,2L,0L,4L,6L,9L,2L,6L,1L,9L,3L,9L,0L,9L,6L,6L,0L,5L,9L,6L,7L,0L,0L,7L,1L,9L,9L,6L,3L,6L,3L,7L,2L,2L,7L,5L,0L,5L,6L,6L,9L,3L,2L,9L,0L,3L,2L,2L,1L,8L,9L,5L,3L,3L,7L,1L,3L,7L,7L,8L,4L,1L,3L,0L,7L,7L,5L,2L,6L,8L,5L,0L,5L,5L,2L,8L,0L,8L,6L,8L,9L,6L,6L,3L,8L,9L,1L,4L,1L,8L,7L,8L,2L,1L,0L,2L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016690Inst : IEnumerable<long>
{
public static readonly long[] Value=A016690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016690.Bytes);
public long this[int i]=>Value[i];

public static A016690Inst Instance=new A016690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016689
{
public static readonly long[] Value={ 4L,1L,8L,9L,6L,5L,4L,7L,4L,2L,0L,2L,6L,4L,2L,5L,5L,4L,4L,8L,7L,4L,4L,2L,0L,9L,3L,6L,3L,4L,5L,8L,3L,1L,5L,7L,2L,5L,4L,4L,6L,9L,7L,5L,4L,6L,1L,2L,0L,4L,2L,1L,8L,8L,1L,0L,7L,3L,9L,4L,2L,0L,5L,2L,2L,6L,1L,4L,6L,1L,5L,3L,9L,1L,0L,1L,5L,4L,0L,3L,9L,5L,5L,5L,4L,5L,3L,3L,7L,8L,9L,8L,1L,2L,7L,8L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016689Inst : IEnumerable<long>
{
public static readonly long[] Value=A016689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016689.Bytes);
public long this[int i]=>Value[i];

public static A016689Inst Instance=new A016689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016688
{
public static readonly long[] Value={ 4L,1L,7L,4L,3L,8L,7L,2L,6L,9L,8L,9L,5L,6L,3L,7L,1L,1L,0L,6L,5L,4L,2L,4L,6L,7L,7L,4L,7L,9L,1L,5L,0L,6L,2L,4L,4L,3L,3L,0L,8L,6L,9L,2L,9L,9L,0L,2L,8L,7L,2L,4L,8L,3L,8L,3L,3L,1L,6L,9L,3L,4L,0L,2L,1L,3L,7L,6L,4L,3L,6L,5L,5L,0L,3L,2L,0L,6L,7L,9L,4L,4L,0L,2L,9L,7L,0L,8L,5L,4L,1L,5L,3L,3L,6L,6L,9L,0L,9L,9L,5L,6L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016688Inst : IEnumerable<long>
{
public static readonly long[] Value=A016688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016688.Bytes);
public long this[int i]=>Value[i];

public static A016688Inst Instance=new A016688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016687
{
public static readonly long[] Value={ 4L,1L,5L,8L,8L,8L,3L,0L,8L,3L,3L,5L,9L,6L,7L,1L,8L,5L,6L,5L,0L,3L,3L,9L,2L,7L,2L,8L,7L,4L,9L,0L,5L,9L,4L,0L,8L,4L,5L,3L,0L,0L,0L,8L,0L,6L,1L,6L,1L,5L,3L,1L,5L,2L,4L,7L,2L,4L,0L,8L,0L,0L,5L,6L,9L,6L,0L,3L,6L,1L,7L,3L,1L,8L,1L,8L,1L,6L,8L,2L,9L,3L,6L,3L,5L,1L,7L,9L,9L,6L,1L,9L,7L,8L,5L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016687Inst : IEnumerable<long>
{
public static readonly long[] Value=A016687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016687.Bytes);
public long this[int i]=>Value[i];

public static A016687Inst Instance=new A016687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016686
{
public static readonly long[] Value={ 4L,1L,4L,3L,1L,3L,4L,7L,2L,6L,3L,9L,1L,5L,3L,2L,6L,8L,7L,8L,9L,5L,8L,4L,3L,2L,1L,7L,2L,8L,8L,2L,3L,1L,1L,3L,8L,9L,3L,2L,0L,6L,5L,8L,4L,5L,2L,2L,7L,3L,6L,0L,0L,9L,1L,9L,2L,8L,7L,7L,8L,8L,1L,7L,2L,1L,2L,5L,6L,8L,4L,4L,9L,1L,8L,9L,2L,8L,7L,2L,0L,1L,5L,3L,4L,8L,9L,0L,0L,0L,8L,2L,1L,5L,3L,3L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016686Inst : IEnumerable<long>
{
public static readonly long[] Value=A016686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016686.Bytes);
public long this[int i]=>Value[i];

public static A016686Inst Instance=new A016686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016685
{
public static readonly long[] Value={ 4L,1L,2L,7L,1L,3L,4L,3L,8L,5L,0L,4L,5L,0L,9L,1L,5L,5L,5L,3L,4L,6L,3L,9L,6L,4L,4L,6L,0L,0L,0L,5L,3L,3L,7L,7L,8L,5L,2L,5L,4L,3L,9L,0L,6L,4L,8L,4L,0L,8L,4L,7L,2L,2L,5L,8L,7L,7L,3L,9L,8L,0L,8L,1L,9L,6L,8L,3L,7L,5L,0L,3L,8L,5L,6L,7L,2L,4L,5L,9L,4L,7L,8L,1L,9L,7L,2L,8L,1L,5L,8L,3L,3L,2L,5L,0L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016685Inst : IEnumerable<long>
{
public static readonly long[] Value=A016685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016685.Bytes);
public long this[int i]=>Value[i];

public static A016685Inst Instance=new A016685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016684
{
public static readonly long[] Value={ 4L,1L,1L,0L,8L,7L,3L,8L,6L,4L,1L,7L,3L,3L,1L,1L,2L,4L,8L,7L,5L,1L,3L,8L,9L,1L,0L,3L,4L,2L,5L,6L,1L,4L,7L,4L,6L,3L,1L,5L,6L,8L,1L,7L,4L,3L,0L,8L,1L,2L,6L,1L,0L,6L,2L,9L,3L,7L,3L,8L,3L,6L,4L,6L,4L,1L,9L,4L,3L,9L,8L,0L,6L,8L,4L,4L,9L,4L,8L,7L,3L,1L,1L,8L,5L,4L,2L,9L,2L,0L,6L,1L,0L,0L,1L,0L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016684Inst : IEnumerable<long>
{
public static readonly long[] Value=A016684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016684.Bytes);
public long this[int i]=>Value[i];

public static A016684Inst Instance=new A016684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016683
{
public static readonly long[] Value={ 4L,0L,9L,4L,3L,4L,4L,5L,6L,2L,2L,2L,2L,1L,0L,0L,6L,8L,4L,8L,3L,0L,4L,6L,8L,8L,1L,3L,0L,6L,5L,0L,6L,6L,4L,8L,0L,3L,2L,4L,0L,9L,2L,1L,8L,0L,8L,1L,1L,7L,7L,7L,6L,8L,1L,8L,8L,8L,7L,0L,2L,2L,4L,4L,0L,9L,8L,4L,6L,0L,5L,2L,4L,8L,6L,5L,6L,5L,6L,1L,6L,2L,7L,1L,5L,4L,7L,6L,2L,8L,6L,8L,9L,9L,7L,4L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016683Inst : IEnumerable<long>
{
public static readonly long[] Value=A016683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016683.Bytes);
public long this[int i]=>Value[i];

public static A016683Inst Instance=new A016683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016682
{
public static readonly long[] Value={ 4L,0L,7L,7L,5L,3L,7L,4L,4L,3L,9L,0L,5L,7L,1L,9L,4L,5L,0L,6L,1L,6L,0L,5L,0L,3L,7L,3L,7L,1L,9L,6L,9L,7L,6L,2L,4L,0L,6L,3L,3L,4L,6L,7L,8L,9L,3L,3L,0L,4L,5L,4L,5L,2L,9L,5L,1L,2L,0L,3L,6L,6L,9L,7L,0L,5L,9L,2L,0L,0L,1L,1L,4L,2L,6L,5L,4L,2L,7L,4L,7L,7L,3L,5L,9L,3L,3L,9L,9L,5L,9L,8L,0L,2L,6L,3L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016682Inst : IEnumerable<long>
{
public static readonly long[] Value=A016682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016682.Bytes);
public long this[int i]=>Value[i];

public static A016682Inst Instance=new A016682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016681
{
public static readonly long[] Value={ 4L,0L,6L,0L,4L,4L,3L,0L,1L,0L,5L,4L,6L,4L,1L,9L,3L,3L,6L,6L,0L,0L,5L,0L,4L,1L,5L,3L,8L,2L,0L,0L,8L,8L,1L,7L,3L,5L,7L,0L,0L,1L,3L,0L,4L,8L,2L,8L,2L,9L,9L,9L,3L,3L,3L,0L,4L,2L,3L,5L,0L,3L,6L,1L,1L,3L,6L,1L,7L,4L,4L,0L,3L,1L,0L,7L,5L,4L,7L,0L,4L,8L,8L,9L,9L,2L,3L,0L,4L,4L,1L,8L,1L,4L,2L,7L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016681Inst : IEnumerable<long>
{
public static readonly long[] Value=A016681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016681.Bytes);
public long this[int i]=>Value[i];

public static A016681Inst Instance=new A016681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016680
{
public static readonly long[] Value={ 4L,0L,4L,3L,0L,5L,1L,2L,6L,7L,8L,3L,4L,5L,5L,0L,1L,5L,1L,4L,0L,4L,2L,7L,2L,6L,6L,8L,8L,1L,0L,3L,7L,9L,2L,4L,1L,8L,8L,4L,8L,6L,9L,8L,1L,9L,1L,2L,1L,8L,7L,8L,2L,7L,0L,2L,7L,2L,6L,5L,4L,5L,7L,0L,0L,4L,6L,7L,8L,6L,9L,9L,5L,2L,8L,2L,8L,0L,6L,2L,5L,5L,5L,8L,7L,7L,7L,4L,1L,3L,8L,6L,2L,9L,4L,7L,1L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016680Inst : IEnumerable<long>
{
public static readonly long[] Value=A016680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016680.Bytes);
public long this[int i]=>Value[i];

public static A016680Inst Instance=new A016680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016679
{
public static readonly long[] Value={ 4L,0L,2L,5L,3L,5L,1L,6L,9L,0L,7L,3L,5L,1L,4L,9L,2L,3L,3L,3L,5L,7L,0L,4L,9L,1L,0L,7L,8L,1L,7L,7L,0L,9L,4L,3L,3L,8L,6L,3L,5L,8L,5L,1L,3L,2L,6L,6L,2L,6L,2L,6L,9L,5L,0L,8L,2L,1L,4L,3L,0L,1L,7L,8L,4L,1L,7L,7L,6L,0L,7L,2L,8L,6L,6L,1L,1L,5L,3L,4L,1L,4L,6L,0L,5L,2L,4L,8L,4L,7L,9L,5L,7L,7L,1L,2L,7L,5L,8L,9L,6L,1L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016679Inst : IEnumerable<long>
{
public static readonly long[] Value=A016679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016679.Bytes);
public long this[int i]=>Value[i];

public static A016679Inst Instance=new A016679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016678
{
public static readonly long[] Value={ 4L,0L,0L,7L,3L,3L,3L,1L,8L,5L,2L,3L,2L,4L,7L,0L,9L,1L,8L,6L,6L,2L,7L,0L,2L,9L,1L,1L,1L,9L,1L,3L,1L,6L,9L,3L,9L,3L,4L,7L,3L,0L,8L,2L,0L,8L,2L,0L,5L,9L,3L,4L,8L,9L,7L,1L,3L,1L,2L,1L,5L,6L,0L,0L,6L,0L,4L,7L,5L,2L,6L,1L,1L,6L,2L,0L,8L,9L,4L,4L,7L,7L,7L,0L,5L,1L,8L,8L,5L,8L,6L,0L,9L,5L,8L,1L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016678Inst : IEnumerable<long>
{
public static readonly long[] Value=A016678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016678.Bytes);
public long this[int i]=>Value[i];

public static A016678Inst Instance=new A016678Inst();

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