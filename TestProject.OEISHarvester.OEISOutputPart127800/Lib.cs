using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A157105
{
public static readonly long[] Value={ 106846L,244688L,382530L,520372L,658214L,796056L,933898L,1071740L,1209582L,1347424L,1485266L,1623108L,1760950L,1898792L,2036634L,2174476L,2312318L,2450160L,2588002L,2725844L,2863686L,3001528L,3139370L,3277212L,3415054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157105Inst : IEnumerable<long>
{
public static readonly long[] Value=A157105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157105.Bytes);
public long this[int i]=>Value[i];

public static A157105Inst Instance=new A157105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157106
{
public static readonly long[] Value={ 3395619L,17808513L,43524451L,80543433L,128865459L,188490529L,259418643L,341649801L,435184003L,540021249L,656161539L,783604873L,922351251L,1072400673L,1233753139L,1406408649L,1590367203L,1785628801L,1992193443L,2210061129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157106Inst : IEnumerable<long>
{
public static readonly long[] Value=A157106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157106.Bytes);
public long this[int i]=>Value[i];

public static A157106Inst Instance=new A157106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157107
{
public static readonly long[] Value={ 220L,440L,661L,881L,1105L,1325L,1546L,1766L,1991L,2211L,2432L,2652L,2876L,3096L,3317L,3537L,3771L,3991L,4212L,4432L,4656L,4876L,5097L,5317L,5542L,5762L,5983L,6203L,6427L,6647L,6868L,7088L,7326L,7546L,7767L,7987L,8211L,8431L,8652L,8872L,9097L,9317L,9538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157107Inst : IEnumerable<long>
{
public static readonly long[] Value=A157107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157107.Bytes);
public long this[int i]=>Value[i];

public static A157107Inst Instance=new A157107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157108
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,36L,1L,1L,16L,276L,560L,1L,1L,25L,1225L,19600L,12650L,1L,1L,36L,4005L,280840L,2555190L,376992L,1L,1L,49L,10731L,2421090L,146475945L,534017484L,13983816L,1L,1L,64L,24976L,14885696L,4053946260L,147055790784L,163995687856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157108Inst : IEnumerable<long>
{
public static readonly long[] Value=A157108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157108.Bytes);
public long this[int i]=>Value[i];

public static A157108Inst Instance=new A157108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157109
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,9L,3L,1L,1L,16L,120L,4L,1L,1L,50L,300L,2300L,5L,1L,1L,90L,4005L,7140L,58905L,6L,1L,1L,245L,10731L,518665L,211876L,1906884L,7L,1L,1L,448L,100128L,1848224L,102114376L,7624512L,74974368L,8L,1L,1L,1134L,285390L,71728020L,450710001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157109Inst : IEnumerable<long>
{
public static readonly long[] Value=A157109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157109.Bytes);
public long this[int i]=>Value[i];

public static A157109Inst Instance=new A157109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157110
{
public static readonly long[] Value={ 85L,2522L,8321L,17482L,30005L,45890L,65137L,87746L,113717L,143050L,175745L,211802L,251221L,294002L,340145L,389650L,442517L,498746L,558337L,621290L,687605L,757282L,830321L,906722L,986485L,1069610L,1156097L,1245946L,1339157L,1435730L,1535665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157110Inst : IEnumerable<long>
{
public static readonly long[] Value=A157110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157110.Bytes);
public long this[int i]=>Value[i];

public static A157110Inst Instance=new A157110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157111
{
public static readonly long[] Value={ 30996L,168838L,306680L,444522L,582364L,720206L,858048L,995890L,1133732L,1271574L,1409416L,1547258L,1685100L,1822942L,1960784L,2098626L,2236468L,2374310L,2512152L,2649994L,2787836L,2925678L,3063520L,3201362L,3339204L,3477046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157111Inst : IEnumerable<long>
{
public static readonly long[] Value=A157111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157111.Bytes);
public long this[int i]=>Value[i];

public static A157111Inst Instance=new A157111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157112
{
public static readonly long[] Value={ 285769L,8478963L,27975201L,58774483L,100876809L,154282179L,218990593L,295002051L,382316553L,480934099L,590854689L,712078323L,844605001L,988434723L,1143567489L,1310003299L,1487742153L,1676784051L,1877128993L,2088776979L,2311728009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157112Inst : IEnumerable<long>
{
public static readonly long[] Value=A157112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157112.Bytes);
public long this[int i]=>Value[i];

public static A157112Inst Instance=new A157112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157113
{
public static readonly long[] Value={ 2L,1L,1L,1L,4L,1L,1L,21L,21L,1L,1L,232L,240L,232L,1L,1L,4865L,4495L,4495L,4865L,1L,1L,142536L,195708L,49608L,195708L,142536L,1L,1L,5245828L,12105429L,2024785L,2024785L,12105429L,5245828L,1L,1L,231917456L,927052864L,190858864L,21336000L,190858864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157113Inst : IEnumerable<long>
{
public static readonly long[] Value=A157113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157113.Bytes);
public long this[int i]=>Value[i];

public static A157113Inst Instance=new A157113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157114
{
public static readonly long[] Value={ 2L,1L,1L,1L,4L,1L,1L,9L,9L,1L,1L,16L,56L,16L,1L,1L,25L,225L,225L,25L,1L,1L,36L,771L,1632L,771L,36L,1L,1L,49L,2597L,9261L,9261L,2597L,49L,1L,1L,64L,9136L,52384L,71920L,52384L,9136L,64L,1L,1L,81L,33777L,320814L,525987L,525987L,320814L,33777L,81L,1L,1L,100L,129130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157114Inst : IEnumerable<long>
{
public static readonly long[] Value=A157114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157114.Bytes);
public long this[int i]=>Value[i];

public static A157114Inst Instance=new A157114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157115
{
public static readonly long[] Value={ 17L,3L,5L,7L,41L,11L,13L,23L,73L,19L,29L,31L,89L,43L,37L,47L,97L,59L,53L,71L,113L,67L,61L,79L,137L,83L,101L,103L,193L,107L,109L,127L,233L,131L,149L,151L,241L,139L,157L,167L,257L,163L,173L,191L,281L,179L,181L,199L,313L,211L,197L,223L,337L,227L,229L,239L,353L,251L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157115Inst : IEnumerable<long>
{
public static readonly long[] Value=A157115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157115.Bytes);
public long this[int i]=>Value[i];

public static A157115Inst Instance=new A157115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157116
{
public static readonly long[] Value={ 378L,1303L,2059L,2984L,3740L,4665L,5421L,6346L,7102L,8027L,8783L,9708L,10464L,11389L,12145L,13070L,13826L,14751L,15507L,16432L,17188L,18113L,18869L,19794L,20550L,21475L,22231L,23156L,23912L,24837L,25593L,26518L,27274L,28199L,28955L,29880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157116Inst : IEnumerable<long>
{
public static readonly long[] Value=A157116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157116.Bytes);
public long this[int i]=>Value[i];

public static A157116Inst Instance=new A157116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157117
{
public static readonly long[] Value={ 2L,1L,1L,1L,8L,1L,1L,131L,131L,1L,1L,8204L,29216L,8204L,1L,1L,2097187L,44136233L,44136233L,2097187L,1L,1L,2147483736L,846839476071L,503464582368L,846839476071L,2147483736L,1L,1L,8796093022411L,150092195453359483L,288159195861579519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157117Inst : IEnumerable<long>
{
public static readonly long[] Value=A157117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157117.Bytes);
public long this[int i]=>Value[i];

public static A157117Inst Instance=new A157117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157118
{
public static readonly long[] Value={ 2L,1L,1L,1L,6L,1L,1L,27L,27L,1L,1L,88L,672L,88L,1L,1L,225L,9150L,9150L,225L,1L,1L,486L,98385L,395352L,98385L,486L,1L,1L,931L,1126951L,11748681L,11748681L,1126951L,931L,1L,1L,1632L,14600320L,402703120L,588593280L,402703120L,14600320L,1632L,1L,1L,2673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157118Inst : IEnumerable<long>
{
public static readonly long[] Value=A157118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157118.Bytes);
public long this[int i]=>Value[i];

public static A157118Inst Instance=new A157118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157119
{
public static readonly long[] Value={ 0L,84L,105L,309L,765L,884L,2060L,4712L,5405L,12257L,27713L,31752L,71688L,161772L,185313L,418077L,943125L,1080332L,2436980L,5497184L,6296885L,14204009L,32040185L,36701184L,82787280L,186744132L,213910425L,482519877L,1088424813L,1246761572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157119Inst : IEnumerable<long>
{
public static readonly long[] Value=A157119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157119.Bytes);
public long this[int i]=>Value[i];

public static A157119Inst Instance=new A157119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157120
{
public static readonly long[] Value={ 73L,103L,205L,233L,515L,1157L,1325L,2987L,6737L,7717L,17407L,39265L,44977L,101455L,228853L,262145L,591323L,1333853L,1527893L,3446483L,7774265L,8905213L,20087575L,45311737L,51903385L,117078967L,264096157L,302515097L,682386227L,1539265205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157120Inst : IEnumerable<long>
{
public static readonly long[] Value=A157120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157120.Bytes);
public long this[int i]=>Value[i];

public static A157120Inst Instance=new A157120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157121
{
public static readonly long[] Value={ 1L,5L,2L,4L,2L,6L,4L,0L,6L,8L,7L,1L,1L,9L,2L,8L,5L,1L,4L,6L,4L,0L,5L,0L,6L,6L,1L,7L,2L,6L,2L,9L,0L,9L,4L,2L,3L,5L,7L,0L,9L,0L,1L,5L,6L,2L,6L,1L,3L,0L,8L,4L,4L,2L,1L,9L,5L,3L,0L,0L,3L,9L,2L,1L,3L,9L,7L,2L,1L,9L,7L,4L,3L,5L,3L,8L,6L,3L,2L,1L,1L,1L,6L,5L,5L,1L,1L,6L,2L,6L,0L,2L,9L,8L,2L,9L,2L,4L,7L,1L,8L,2L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157121Inst : IEnumerable<long>
{
public static readonly long[] Value=A157121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157121.Bytes);
public long this[int i]=>Value[i];

public static A157121Inst Instance=new A157121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157122
{
public static readonly long[] Value={ 6L,7L,5L,7L,3L,5L,9L,3L,1L,2L,8L,8L,0L,7L,1L,4L,8L,5L,3L,5L,9L,4L,9L,3L,3L,8L,2L,7L,3L,7L,0L,9L,0L,5L,7L,6L,4L,2L,9L,0L,9L,8L,4L,3L,7L,3L,8L,6L,9L,1L,5L,5L,7L,8L,0L,4L,6L,9L,9L,6L,0L,7L,8L,6L,0L,2L,7L,8L,0L,2L,5L,6L,4L,6L,1L,3L,6L,7L,8L,8L,8L,3L,4L,4L,8L,8L,3L,7L,3L,9L,7L,0L,1L,7L,0L,7L,5L,2L,8L,1L,7L,9L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157122Inst : IEnumerable<long>
{
public static readonly long[] Value=A157122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157122.Bytes);
public long this[int i]=>Value[i];

public static A157122Inst Instance=new A157122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157123
{
public static readonly long[] Value={ 2L,2L,5L,5L,7L,0L,9L,6L,6L,1L,3L,2L,6L,4L,4L,9L,2L,5L,4L,5L,7L,1L,9L,5L,5L,8L,8L,1L,5L,3L,2L,4L,2L,7L,8L,9L,5L,0L,0L,5L,8L,0L,9L,1L,6L,2L,8L,6L,2L,8L,9L,8L,7L,6L,5L,3L,3L,6L,5L,1L,3L,2L,3L,0L,1L,6L,8L,8L,1L,8L,8L,6L,9L,6L,9L,4L,1L,6L,5L,6L,7L,5L,3L,7L,9L,8L,5L,9L,9L,7L,3L,4L,5L,2L,6L,6L,3L,5L,3L,2L,0L,4L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157123Inst : IEnumerable<long>
{
public static readonly long[] Value=A157123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157123.Bytes);
public long this[int i]=>Value[i];

public static A157123Inst Instance=new A157123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157124
{
public static readonly long[] Value={ 1L,1L,4L,6L,9L,12L,15L,18L,21L,25L,28L,31L,34L,37L,41L,44L,47L,51L,54L,57L,61L,64L,68L,71L,75L,78L,82L,85L,89L,92L,96L,99L,103L,106L,110L,113L,117L,120L,124L,128L,131L,135L,138L,142L,146L,149L,153L,157L,160L,164L,168L,171L,175L,179L,182L,186L,190L,193L,197L,201L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157124Inst : IEnumerable<long>
{
public static readonly long[] Value=A157124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157124.Bytes);
public long this[int i]=>Value[i];

public static A157124Inst Instance=new A157124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157125
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,2L,1L,-1L,-4L,-2L,4L,12L,4L,-20L,-39L,3L,92L,118L,-84L,-388L,-308L,596L,1528L,508L,-3292L,-5556L,1154L,16034L,17940L,-18160L,-71243L,-45913L,127124L,290278L,46128L,-710864L,-1067564L,485108L,3504680L,3362756L,-4957812L,-15669148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157125Inst : IEnumerable<long>
{
public static readonly long[] Value=A157125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157125.Bytes);
public long this[int i]=>Value[i];

public static A157125Inst Instance=new A157125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157126
{
public static readonly long[] Value={ 1L,-2L,-3L,-3L,8L,11L,11L,-30L,-41L,-41L,112L,153L,153L,-418L,-571L,-571L,1560L,2131L,2131L,-5822L,-7953L,-7953L,21728L,29681L,29681L,-81090L,-110771L,-110771L,302632L,413403L,413403L,-1129438L,-1542841L,-1542841L,4215120L,5757961L,5757961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157126Inst : IEnumerable<long>
{
public static readonly long[] Value=A157126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157126.Bytes);
public long this[int i]=>Value[i];

public static A157126Inst Instance=new A157126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157127
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,1L,2L,1L,-3L,-5L,-1L,11L,15L,-5L,-44L,-41L,51L,169L,85L,-303L,-611L,-15L,1513L,2021L,-1271L,-6827L,-5673L,10361L,28301L,10141L,-61102L,-107015L,20109L,310387L,356515L,-354349L,-1421913L,-936805L,2567875L,5930631L,972819L,-14696329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157127Inst : IEnumerable<long>
{
public static readonly long[] Value=A157127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157127.Bytes);
public long this[int i]=>Value[i];

public static A157127Inst Instance=new A157127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157128
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,2L,1L,1L,-3L,-1L,-1L,4L,1L,1L,-5L,-1L,-1L,6L,1L,1L,-7L,-1L,-1L,8L,1L,1L,-9L,-1L,-1L,10L,1L,1L,-11L,-1L,-1L,12L,1L,1L,-13L,-1L,-1L,14L,1L,1L,-15L,-1L,-1L,16L,1L,1L,-17L,-1L,-1L,18L,1L,1L,-19L,-1L,-1L,20L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157128Inst : IEnumerable<long>
{
public static readonly long[] Value=A157128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157128.Bytes);
public long this[int i]=>Value[i];

public static A157128Inst Instance=new A157128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157129
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157129Inst : IEnumerable<long>
{
public static readonly long[] Value=A157129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157129.Bytes);
public long this[int i]=>Value[i];

public static A157129Inst Instance=new A157129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157130
{
public static readonly long[] Value={ 1L,4L,8L,13L,20L,29L,40L,53L,68L,84L,101L,120L,141L,164L,189L,216L,245L,276L,309L,344L,380L,417L,456L,497L,540L,585L,632L,681L,732L,785L,840L,897L,956L,1017L,1080L,1144L,1209L,1276L,1345L,1416L,1489L,1564L,1641L,1720L,1801L,1884L,1969L,2056L,2145L,2236L,2329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157130Inst : IEnumerable<long>
{
public static readonly long[] Value=A157130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157130.Bytes);
public long this[int i]=>Value[i];

public static A157130Inst Instance=new A157130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157131
{
public static readonly long[] Value={ 58831L,69539L,79757L,143053L,162109L,175103L,180907L,186917L,190403L,191339L,204233L,206749L,212353L,212701L,232207L,247141L,250501L,256211L,273433L,283303L,286243L,287437L,293507L,302317L,307711L,313409L,337121L,338017L,355211L,361111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157131Inst : IEnumerable<long>
{
public static readonly long[] Value=A157131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157131.Bytes);
public long this[int i]=>Value[i];

public static A157131Inst Instance=new A157131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157132
{
public static readonly BigInteger[] Value={ 2L,3L,40L,1260L,7983360L,1037836800L,50812489728000L,15205637551104000L,BigInteger.Parse("2872446304320552960000"),BigInteger.Parse("884176199373970195454361600000"),BigInteger.Parse("747530786743447528884142080000000") };
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
public class A157132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157132Inst Instance=new A157132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157133
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,7L,14L,30L,62L,129L,278L,604L,1313L,2883L,6386L,14203L,31733L,71272L,160725L,363670L,825653L,1880351L,4293985L,9830499L,22558939L,51880565L,119552907L,276012657L,638348123L,1478749229L,3430799333L,7971134523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157133Inst : IEnumerable<long>
{
public static readonly long[] Value=A157133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157133.Bytes);
public long this[int i]=>Value[i];

public static A157133Inst Instance=new A157133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157134
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,7L,11L,18L,33L,63L,117L,211L,383L,713L,1348L,2547L,4793L,9039L,17165L,32785L,62761L,120243L,230768L,444119L,857015L,1656931L,3207990L,6219994L,12079544L,23496417L,45767352L,89256038L,174269488L,340646238L,666604642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157134Inst : IEnumerable<long>
{
public static readonly long[] Value=A157134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157134.Bytes);
public long this[int i]=>Value[i];

public static A157134Inst Instance=new A157134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157135
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,50L,177L,649L,2437L,9322L,36214L,142546L,567409L,2280246L,9238883L,37699021L,154783906L,638983998L,2650697658L,11043733080L,46192300706L,193892210528L,816486626337L,3448376227978L,14603301098654L,61996178908151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157135Inst : IEnumerable<long>
{
public static readonly long[] Value=A157135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157135.Bytes);
public long this[int i]=>Value[i];

public static A157135Inst Instance=new A157135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157136
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,6L,16L,36L,75L,164L,401L,1046L,2718L,6878L,17200L,43486L,112202L,293540L,770535L,2019891L,5296670L,13942944L,36902130L,98097968L,261456388L,697970447L,1866383507L,5001333169L,13432923544L,36154294520L,97475330092L,263188299372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157136Inst : IEnumerable<long>
{
public static readonly long[] Value=A157136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157136.Bytes);
public long this[int i]=>Value[i];

public static A157136Inst Instance=new A157136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157137
{
public static readonly long[] Value={ 15L,33L,39L,45L,75L,81L,85L,93L,115L,117L,123L,133L,141L,145L,169L,183L,185L,187L,195L,205L,207L,209L,213L,231L,243L,247L,259L,261L,273L,275L,287L,289L,295L,299L,301L,315L,321L,325L,333L,335L,339L,343L,363L,365L,385L,387L,391L,395L,427L,477L,505L,517L,527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157137Inst : IEnumerable<long>
{
public static readonly long[] Value=A157137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157137.Bytes);
public long this[int i]=>Value[i];

public static A157137Inst Instance=new A157137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157138
{
public static readonly long[] Value={ 10L,14L,18L,38L,48L,52L,54L,58L,60L,70L,76L,80L,82L,86L,92L,94L,96L,98L,112L,114L,124L,132L,136L,138L,140L,142L,144L,158L,170L,174L,180L,192L,194L,198L,234L,236L,252L,254L,258L,290L,306L,318L,320L,324L,326L,342L,348L,350L,352L,356L,364L,366L,368L,370L,374L,376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157138Inst : IEnumerable<long>
{
public static readonly long[] Value=A157138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157138.Bytes);
public long this[int i]=>Value[i];

public static A157138Inst Instance=new A157138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157139
{
public static readonly long[] Value={ 3L,9L,11L,17L,23L,31L,35L,39L,49L,51L,55L,59L,61L,73L,77L,87L,89L,95L,97L,99L,101L,103L,107L,123L,125L,127L,129L,131L,133L,137L,139L,141L,147L,149L,157L,159L,161L,163L,169L,171L,173L,175L,177L,181L,195L,199L,235L,237L,253L,257L,279L,305L,309L,319L,323L,341L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157139Inst : IEnumerable<long>
{
public static readonly long[] Value=A157139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157139.Bytes);
public long this[int i]=>Value[i];

public static A157139Inst Instance=new A157139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157140
{
public static readonly long[] Value={ 9L,19L,19L,47L,47L,47L,47L,98L,98L,98L,98L,98L,98L,98L,98L,220L,220L,220L,220L,220L,220L,220L,220L,220L,220L,220L,220L,220L,220L,220L,220L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157140Inst : IEnumerable<long>
{
public static readonly long[] Value=A157140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157140.Bytes);
public long this[int i]=>Value[i];

public static A157140Inst Instance=new A157140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157141
{
public static readonly long[] Value={ 29L,41L,61L,89L,127L,163L,167L,239L,251L,271L,293L,349L,389L,401L,409L,431L,439L,479L,521L,541L,569L,601L,613L,617L,631L,659L,761L,769L,809L,839L,859L,947L,967L,983L,1063L,1087L,1229L,1237L,1249L,1277L,1289L,1327L,1367L,1429L,1433L,1453L,1481L,1489L,1523L,1543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157141Inst : IEnumerable<long>
{
public static readonly long[] Value=A157141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157141.Bytes);
public long this[int i]=>Value[i];

public static A157141Inst Instance=new A157141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157142
{
public static readonly long[] Value={ 1L,-3L,5L,-7L,9L,-11L,13L,-15L,17L,-19L,21L,-23L,25L,-27L,29L,-31L,33L,-35L,37L,-39L,41L,-43L,45L,-47L,49L,-51L,53L,-55L,57L,-59L,61L,-63L,65L,-67L,69L,-71L,73L,-75L,77L,-79L,81L,-83L,85L,-87L,89L,-91L,93L,-95L,97L,-99L,101L,-103L,105L,-107L,109L,-111L,113L,-115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157142Inst : IEnumerable<long>
{
public static readonly long[] Value=A157142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157142.Bytes);
public long this[int i]=>Value[i];

public static A157142Inst Instance=new A157142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157143
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,2L,1L,-1L,-4L,-2L,5L,11L,0L,-21L,-24L,18L,68L,42L,-100L,-203L,-17L,428L,521L,-340L,-1544L,-1019L,2252L,4892L,606L,-10297L,-13331L,7821L,39310L,28028L,-56893L,-130394L,-22239L,272991L,370641L,-193874L,-1081694L,-821669L,1536026L,3707766L,798376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157143Inst : IEnumerable<long>
{
public static readonly long[] Value=A157143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157143.Bytes);
public long this[int i]=>Value[i];

public static A157143Inst Instance=new A157143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157144
{
public static readonly long[] Value={ 1L,-2L,-3L,-3L,8L,0L,0L,-8L,21L,21L,-34L,-55L,-55L,144L,0L,0L,-144L,377L,377L,-610L,-987L,-987L,2584L,0L,0L,-2584L,6765L,6765L,-10946L,-17711L,-17711L,46368L,0L,0L,-46368L,121393L,121393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157144Inst : IEnumerable<long>
{
public static readonly long[] Value=A157144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157144.Bytes);
public long this[int i]=>Value[i];

public static A157144Inst Instance=new A157144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157145
{
public static readonly long[] Value={ 29L,127L,239L,241L,251L,269L,271L,281L,293L,421L,521L,821L,829L,1229L,1237L,1277L,1283L,1327L,1423L,1427L,1523L,1627L,1723L,1823L,2017L,2039L,2069L,2081L,2089L,2129L,2137L,2143L,2153L,2309L,2339L,2341L,2351L,2371L,2381L,2389L,2393L,2417L,2441L,2459L,2531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157145Inst : IEnumerable<long>
{
public static readonly long[] Value=A157145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157145.Bytes);
public long this[int i]=>Value[i];

public static A157145Inst Instance=new A157145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157146
{
public static readonly long[] Value={ 23L,127L,239L,251L,263L,271L,283L,293L,521L,823L,827L,1123L,1213L,1217L,1231L,1259L,1279L,1283L,1297L,1321L,1423L,1427L,1627L,1721L,1823L,2003L,2017L,2039L,2063L,2083L,2087L,2113L,2131L,2143L,2179L,2237L,2273L,2309L,2311L,2341L,2381L,2389L,2399L,2417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157146Inst : IEnumerable<long>
{
public static readonly long[] Value=A157146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157146.Bytes);
public long this[int i]=>Value[i];

public static A157146Inst Instance=new A157146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157147
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,15L,15L,1L,1L,37L,110L,37L,1L,1L,83L,568L,568L,83L,1L,1L,177L,2415L,5534L,2415L,177L,1L,1L,367L,9137L,41027L,41027L,9137L,367L,1L,1L,749L,32104L,255155L,498814L,255155L,32104L,749L,1L,1L,1515L,107442L,1409814L,4845540L,4845540L,1409814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157147Inst : IEnumerable<long>
{
public static readonly long[] Value=A157147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157147.Bytes);
public long this[int i]=>Value[i];

public static A157147Inst Instance=new A157147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157148
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,33L,33L,1L,1L,112L,394L,112L,1L,1L,353L,3150L,3150L,353L,1L,1L,1080L,20719L,51192L,20719L,1080L,1L,1L,3265L,122535L,620415L,620415L,122535L,3265L,1L,1L,9824L,681040L,6312360L,12805614L,6312360L,681040L,9824L,1L,1L,29505L,3643980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157148Inst : IEnumerable<long>
{
public static readonly long[] Value=A157148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157148.Bytes);
public long this[int i]=>Value[i];

public static A157148Inst Instance=new A157148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157149
{
public static readonly long[] Value={ 1L,1L,1L,1L,11L,1L,1L,57L,57L,1L,1L,247L,930L,247L,1L,1L,1013L,10006L,10006L,1013L,1L,1L,4083L,89139L,225230L,89139L,4083L,1L,1L,16369L,719691L,3771323L,3771323L,719691L,16369L,1L,1L,65519L,5495836L,53239541L,108865438L,53239541L,5495836L,65519L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157149Inst : IEnumerable<long>
{
public static readonly long[] Value=A157149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157149.Bytes);
public long this[int i]=>Value[i];

public static A157149Inst Instance=new A157149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157150
{
public static readonly long[] Value={ 1L,1L,1L,1L,14L,1L,1L,87L,87L,1L,1L,460L,1790L,460L,1L,1L,2333L,24178L,24178L,2333L,1L,1L,11706L,271983L,693068L,271983L,11706L,1L,1L,58579L,2786993L,14794139L,14794139L,2786993L,58579L,1L,1L,292952L,27109300L,267169640L,547357078L,267169640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157150Inst : IEnumerable<long>
{
public static readonly long[] Value=A157150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157150.Bytes);
public long this[int i]=>Value[i];

public static A157150Inst Instance=new A157150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157151
{
public static readonly long[] Value={ 1L,1L,1L,1L,17L,1L,1L,123L,123L,1L,1L,769L,3046L,769L,1L,1L,4655L,49500L,49500L,4655L,1L,1L,27981L,673015L,1721070L,673015L,27981L,1L,1L,167947L,8363421L,44640435L,44640435L,8363421L,167947L,1L,1L,1007753L,98882848L,982172031L,2012583870L,982172031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157151Inst : IEnumerable<long>
{
public static readonly long[] Value=A157151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157151.Bytes);
public long this[int i]=>Value[i];

public static A157151Inst Instance=new A157151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157152
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,7L,1L,1L,15L,30L,15L,1L,1L,31L,108L,108L,31L,1L,1L,63L,359L,594L,359L,63L,1L,1L,127L,1145L,2875L,2875L,1145L,127L,1L,1L,255L,3568L,12985L,19246L,12985L,3568L,255L,1L,1L,511L,10966L,56306L,116640L,116640L,56306L,10966L,511L,1L,1L,1023L,33417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157152Inst : IEnumerable<long>
{
public static readonly long[] Value=A157152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157152.Bytes);
public long this[int i]=>Value[i];

public static A157152Inst Instance=new A157152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157153
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,13L,13L,1L,1L,40L,98L,40L,1L,1L,121L,614L,614L,121L,1L,1L,364L,3519L,6832L,3519L,364L,1L,1L,1093L,19179L,64759L,64759L,19179L,1093L,1L,1L,3280L,101368L,558712L,947038L,558712L,101368L,3280L,1L,1L,9841L,525436L,4538324L,12078814L,12078814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157153Inst : IEnumerable<long>
{
public static readonly long[] Value=A157153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157153.Bytes);
public long this[int i]=>Value[i];

public static A157153Inst Instance=new A157153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157154
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,21L,21L,1L,1L,85L,234L,85L,1L,1L,341L,2110L,2110L,341L,1L,1L,1365L,17163L,35882L,17163L,1365L,1L,1L,5461L,131751L,505979L,505979L,131751L,5461L,1L,1L,21845L,976876L,6395471L,11433118L,6395471L,976876L,21845L,1L,1L,87381L,7089360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157154Inst : IEnumerable<long>
{
public static readonly long[] Value=A157154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157154.Bytes);
public long this[int i]=>Value[i];

public static A157154Inst Instance=new A157154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157155
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,31L,31L,1L,1L,156L,462L,156L,1L,1L,781L,5442L,5442L,781L,1L,1L,3906L,57263L,124860L,57263L,3906L,1L,1L,19531L,566153L,2335435L,2335435L,566153L,19531L,1L,1L,97656L,5396164L,38814088L,71413750L,38814088L,5396164L,97656L,1L,1L,488281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157155Inst : IEnumerable<long>
{
public static readonly long[] Value=A157155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157155.Bytes);
public long this[int i]=>Value[i];

public static A157155Inst Instance=new A157155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157156
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,43L,43L,1L,1L,259L,806L,259L,1L,1L,1555L,11720L,11720L,1555L,1L,1L,9331L,151215L,338770L,151215L,9331L,1L,1L,55987L,1828221L,7892635L,7892635L,1828221L,55987L,1L,1L,335923L,21286168L,162474781L,304389070L,162474781L,21286168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157156Inst : IEnumerable<long>
{
public static readonly long[] Value=A157156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157156.Bytes);
public long this[int i]=>Value[i];

public static A157156Inst Instance=new A157156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157157
{
public static readonly long[] Value={ 12L,21L,92L,102L,120L,123L,124L,125L,126L,128L,132L,142L,152L,162L,172L,182L,201L,209L,210L,213L,214L,215L,216L,217L,218L,231L,249L,259L,261L,279L,289L,290L,294L,295L,296L,297L,298L,312L,321L,329L,392L,412L,429L,492L,512L,529L,592L,612L,621L,629L,692L,712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157157Inst : IEnumerable<long>
{
public static readonly long[] Value=A157157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157157.Bytes);
public long this[int i]=>Value[i];

public static A157157Inst Instance=new A157157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157158
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,31L,41L,43L,53L,61L,71L,73L,83L,97L,101L,211L,311L,313L,331L,401L,421L,431L,433L,443L,503L,521L,523L,541L,601L,613L,631L,641L,643L,653L,661L,701L,727L,733L,743L,751L,757L,761L,773L,811L,821L,823L,827L,853L,857L,863L,877L,881L,883L,887L,907L,911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157158Inst : IEnumerable<long>
{
public static readonly long[] Value=A157158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157158.Bytes);
public long this[int i]=>Value[i];

public static A157158Inst Instance=new A157158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157159
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,10L,-16L,126L,-526L,10312L,-30024L,453840L,-2805408L,45779328L,-374664720L,7932770496L,-67692115440L,2432120198016L,-16610113920768L,437275706750208L,-5110200130727808L,159305381515284480L,-1931470594025607936L,BigInteger.Parse("63854116254680514048") };
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
public class A157159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157159Inst Instance=new A157159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157160
{
public static readonly BigInteger[] Value={ 1L,-13L,-140L,13117L,121660L,-9817093L,-268814420L,121991670749L,1111523321020L,-162217232869003L,-7388763771739700L,2636056932878001607L,BigInteger.Parse("72039647608863423580"),BigInteger.Parse("-15187209495903645536713"),BigInteger.Parse("-968435134391577371468180"),BigInteger.Parse("1884582433009049601394557133") };
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
public class A157160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157160Inst Instance=new A157160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157161
{
public static readonly long[] Value={ 1L,2L,3L,11L,25L,79L,245L,869L,2692L,9544L,32065L,115381L,400023L,1462730L,5165327L,19165035L,68635477L,255546242L,930138521L,3491772737L,12810761323L,48334512920L,178987624513L,678272753284L,2528210175630L,9616904064021L,36047930953482L,137654448221760L,518401146543811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157161Inst : IEnumerable<long>
{
public static readonly long[] Value=A157161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157161.Bytes);
public long this[int i]=>Value[i];

public static A157161Inst Instance=new A157161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157162
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,4L,5L,8L,10L,18L,24L,40L,52L,88L,125L,210L,286L,492L,702L,1144L,1638L,2786L,3986L,6704L,9640L,16096L,23964L,39650L,57794L,97108L,144245L,236880L,353010L,589298L,880828L,1459960L,2179068L,3604880L,5471094L,9030450L,13561742L,22542396L,34277634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157162Inst : IEnumerable<long>
{
public static readonly long[] Value=A157162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157162.Bytes);
public long this[int i]=>Value[i];

public static A157162Inst Instance=new A157162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157163
{
public static readonly long[] Value={ 1L,3L,4L,27L,48L,156L,576L,2955L,7168L,27792L,95232L,352188L,1290240L,5105856L,17743872L,77010795L,252641280L,1000224768L,3616800768L,14484040464L,52102692864L,208963943424L,764877471744L,3025006038012L,11258183024640L,44968060784640L,166308918329344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157163Inst : IEnumerable<long>
{
public static readonly long[] Value=A157163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157163.Bytes);
public long this[int i]=>Value[i];

public static A157163Inst Instance=new A157163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157164
{
public static readonly long[] Value={ 1L,-1L,-1L,-8L,-16L,-74L,-526L,-6768L,-30024L,-291072L,-2805408L,-29134896L,-374664720L,-5276228736L,-67692115440L,-1404936248064L,-16610113920768L,-301439595923712L,-5110200130727808L,-103584959322338304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157164Inst : IEnumerable<long>
{
public static readonly long[] Value=A157164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157164.Bytes);
public long this[int i]=>Value[i];

public static A157164Inst Instance=new A157164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157165
{
public static readonly BigInteger[] Value={ 1L,19L,734L,16294L,557407L,81759221L,1083213812L,3737624804L,1221606572113L,4687376819963L,543445163726882L,314646975551939566L,4747879086124761619L,BigInteger.Parse("415213127253949396153"),BigInteger.Parse("374983405094739446762072"),BigInteger.Parse("11671625151617599366571432"),BigInteger.Parse("11713911632041456348356827") };
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
public class A157165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157165Inst Instance=new A157165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157166
{
public static readonly BigInteger[] Value={ 1L,15L,525L,11025L,363825L,52026975L,676350675L,2299592295L,742768311285L,2822519582883L,324589752031545L,186639107418138375L,2799586611272075625L,BigInteger.Parse("243564035180670579375"),BigInteger.Parse("218964067627422850858125"),BigInteger.Parse("6787886096450108376601875"),BigInteger.Parse("6787886096450108376601875") };
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
public class A157166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157166Inst Instance=new A157166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157167
{
public static readonly BigInteger[] Value={ 23L,33073L,55943738L,77064019958L,15226093370063L,31370562345762421L,BigInteger.Parse("241905492960111168964"),BigInteger.Parse("1683591136668277300660676"),BigInteger.Parse("48935652383592600478507247"),BigInteger.Parse("713289082617826259771761324613"),BigInteger.Parse("143961819529547244077111055694498"),BigInteger.Parse("2460282354560331257420364974778935366") };
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
public class A157167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157167Inst Instance=new A157167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157168
{
public static readonly BigInteger[] Value={ 1L,1155L,1786785L,2342475135L,448349740839L,903424727790585L,6852476560291587225L,BigInteger.Parse("47086107436387612457865"),BigInteger.Parse("1354734576812637878430573"),BigInteger.Parse("19582688307826680532713932715"),BigInteger.Parse("3924930242268690398199663942735"),BigInteger.Parse("66681761294543429372270719198537125"),BigInteger.Parse("102223140064535077227691012531357412625") };
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
public class A157168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157168Inst Instance=new A157168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157169
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,9L,9L,1L,1L,13L,26L,13L,1L,1L,17L,52L,52L,17L,1L,1L,21L,87L,134L,87L,21L,1L,1L,25L,131L,275L,275L,131L,25L,1L,1L,29L,184L,491L,670L,491L,184L,29L,1L,1L,33L,246L,798L,1386L,1386L,798L,246L,33L,1L,1L,37L,317L,1212L,2562L,3262L,2562L,1212L,317L,37L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157169Inst : IEnumerable<long>
{
public static readonly long[] Value=A157169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157169.Bytes);
public long this[int i]=>Value[i];

public static A157169Inst Instance=new A157169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157170
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,15L,15L,1L,1L,22L,46L,22L,1L,1L,29L,94L,94L,29L,1L,1L,36L,159L,248L,159L,36L,1L,1L,43L,241L,515L,515L,241L,43L,1L,1L,50L,340L,926L,1270L,926L,340L,50L,1L,1L,57L,456L,1512L,2646L,2646L,1512L,456L,57L,1L,1L,64L,589L,2304L,4914L,6272L,4914L,2304L,589L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157170Inst : IEnumerable<long>
{
public static readonly long[] Value=A157170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157170.Bytes);
public long this[int i]=>Value[i];

public static A157170Inst Instance=new A157170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157171
{
public static readonly long[] Value={ 1L,1L,1L,1L,11L,1L,1L,21L,21L,1L,1L,31L,66L,31L,1L,1L,41L,136L,136L,41L,1L,1L,51L,231L,362L,231L,51L,1L,1L,61L,351L,755L,755L,351L,61L,1L,1L,71L,496L,1361L,1870L,1361L,496L,71L,1L,1L,81L,666L,2226L,3906L,3906L,2226L,666L,81L,1L,1L,91L,861L,3396L,7266L,9282L,7266L,3396L,861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157171Inst : IEnumerable<long>
{
public static readonly long[] Value=A157171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157171.Bytes);
public long this[int i]=>Value[i];

public static A157171Inst Instance=new A157171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157172
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,7L,7L,1L,1L,10L,14L,10L,1L,1L,13L,22L,22L,13L,1L,1L,16L,31L,32L,31L,16L,1L,1L,19L,41L,35L,35L,41L,19L,1L,1L,22L,52L,26L,-10L,26L,52L,22L,1L,1L,25L,64L,0L,-154L,-154L,0L,64L,25L,1L,1L,28L,77L,-48L,-462L,-728L,-462L,-48L,77L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157172Inst : IEnumerable<long>
{
public static readonly long[] Value=A157172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157172.Bytes);
public long this[int i]=>Value[i];

public static A157172Inst Instance=new A157172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157173
{
public static readonly long[] Value={ 11L,23L,29L,31L,41L,47L,61L,67L,71L,89L,103L,107L,131L,151L,181L,191L,211L,223L,229L,233L,239L,241L,251L,263L,269L,271L,281L,283L,293L,307L,311L,331L,421L,431L,449L,457L,461L,467L,479L,487L,491L,499L,503L,521L,523L,541L,547L,571L,607L,631L,641L,647L,661L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157173Inst : IEnumerable<long>
{
public static readonly long[] Value=A157173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157173.Bytes);
public long this[int i]=>Value[i];

public static A157173Inst Instance=new A157173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157174
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,9L,9L,1L,1L,13L,18L,13L,1L,1L,17L,28L,28L,17L,1L,1L,21L,39L,38L,39L,21L,1L,1L,25L,51L,35L,35L,51L,25L,1L,1L,29L,64L,11L,-50L,11L,64L,29L,1L,1L,33L,78L,-42L,-294L,-294L,-42L,78L,33L,1L,1L,37L,93L,-132L,-798L,-1218L,-798L,-132L,93L,37L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157174Inst : IEnumerable<long>
{
public static readonly long[] Value=A157174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157174.Bytes);
public long this[int i]=>Value[i];

public static A157174Inst Instance=new A157174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157175
{
public static readonly long[] Value={ 11L,13L,17L,19L,41L,43L,61L,83L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,241L,251L,271L,281L,307L,419L,421L,431L,433L,439L,443L,461L,463L,491L,503L,509L,523L,613L,617L,619L,631L,641L,659L,661L,691L,701L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157175Inst : IEnumerable<long>
{
public static readonly long[] Value=A157175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157175.Bytes);
public long this[int i]=>Value[i];

public static A157175Inst Instance=new A157175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157176
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,8L,8L,16L,16L,24L,40L,64L,64L,128L,128L,192L,320L,512L,512L,1024L,1024L,1536L,2560L,4096L,4096L,8192L,8192L,12288L,20480L,32768L,32768L,65536L,65536L,98304L,163840L,262144L,262144L,524288L,524288L,786432L,1310720L,2097152L,2097152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157176Inst : IEnumerable<long>
{
public static readonly long[] Value=A157176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157176.Bytes);
public long this[int i]=>Value[i];

public static A157176Inst Instance=new A157176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157177
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,13L,13L,1L,1L,29L,82L,29L,1L,1L,61L,368L,368L,61L,1L,1L,125L,1399L,3010L,1399L,125L,1L,1L,253L,4863L,19243L,19243L,4863L,253L,1L,1L,509L,16048L,106099L,194846L,106099L,16048L,509L,1L,1L,1021L,51298L,532466L,1622734L,1622734L,532466L,51298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157177Inst : IEnumerable<long>
{
public static readonly long[] Value=A157177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157177.Bytes);
public long this[int i]=>Value[i];

public static A157177Inst Instance=new A157177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157178
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,21L,21L,1L,1L,46L,142L,46L,1L,1L,95L,644L,644L,95L,1L,1L,192L,2439L,5416L,2439L,192L,1L,1L,385L,8415L,34879L,34879L,8415L,385L,1L,1L,770L,27556L,192286L,358454L,192286L,27556L,770L,1L,1L,1539L,87486L,962090L,3001044L,3001044L,962090L,87486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157178Inst : IEnumerable<long>
{
public static readonly long[] Value=A157178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157178.Bytes);
public long this[int i]=>Value[i];

public static A157178Inst Instance=new A157178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157179
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,9L,9L,1L,1L,23L,50L,23L,1L,1L,53L,236L,236L,53L,1L,1L,115L,983L,1822L,983L,115L,1L,1L,241L,3723L,11995L,11995L,3723L,241L,1L,1L,495L,13168L,70369L,117534L,70369L,13168L,495L,1L,1L,1005L,44382L,377918L,997974L,997974L,377918L,44382L,1005L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157179Inst : IEnumerable<long>
{
public static readonly long[] Value=A157179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157179.Bytes);
public long this[int i]=>Value[i];

public static A157179Inst Instance=new A157179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157180
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,13L,13L,1L,1L,34L,78L,34L,1L,1L,79L,380L,380L,79L,1L,1L,172L,1607L,3040L,1607L,172L,1L,1L,361L,6135L,20383L,20383L,6135L,361L,1L,1L,742L,21796L,120826L,203830L,120826L,21796L,742L,1L,1L,1507L,73654L,652994L,1751524L,1751524L,652994L,73654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157180Inst : IEnumerable<long>
{
public static readonly long[] Value=A157180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157180.Bytes);
public long this[int i]=>Value[i];

public static A157180Inst Instance=new A157180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157181
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,17L,17L,1L,1L,45L,106L,45L,1L,1L,105L,524L,524L,105L,1L,1L,229L,2231L,4258L,2231L,229L,1L,1L,481L,8547L,28771L,28771L,8547L,481L,1L,1L,989L,30424L,171283L,290126L,171283L,30424L,989L,1L,1L,2009L,102926L,928070L,2505074L,2505074L,928070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157181Inst : IEnumerable<long>
{
public static readonly long[] Value=A157181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157181.Bytes);
public long this[int i]=>Value[i];

public static A157181Inst Instance=new A157181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157182
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,7L,8L,10L,22L,6L,5L,21L,19L,25L,11L,12L,26L,40L,18L,36L,20L,17L,35L,27L,13L,23L,47L,33L,14L,24L,32L,16L,30L,50L,56L,28L,15L,29L,65L,51L,31L,53L,57L,45L,39L,38L,44L,42L,62L,52L,48L,74L,82L,34L,58L,41L,59L,95L,89L,75L,49L,83L,99L,55L,69L,43L,60L,68L,54L,78L,92L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157182Inst : IEnumerable<long>
{
public static readonly long[] Value=A157182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157182.Bytes);
public long this[int i]=>Value[i];

public static A157182Inst Instance=new A157182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157183
{
public static readonly long[] Value={ 2909L,4349L,8093L,24329L,57593L,72893L,93629L,224669L,324893L,331769L,404489L,562493L,608393L,1166393L,1742393L,1822493L,4137149L,4639709L,5788829L,7289993L,7617593L,10265609L,10497593L,10929629L,12110393L,12362249L,14107529L,14243069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157183Inst : IEnumerable<long>
{
public static readonly long[] Value=A157183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157183.Bytes);
public long this[int i]=>Value[i];

public static A157183Inst Instance=new A157183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157184
{
public static readonly long[] Value={ 29L,109L,193L,541L,673L,709L,3257L,4201L,6217L,8269L,9109L,10957L,12637L,18013L,22717L,23557L,23689L,27329L,33413L,45553L,47737L,48889L,48953L,55001L,55117L,56473L,56737L,59509L,59921L,62297L,65393L,67061L,68909L,75577L,83477L,84221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157184Inst : IEnumerable<long>
{
public static readonly long[] Value=A157184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157184.Bytes);
public long this[int i]=>Value[i];

public static A157184Inst Instance=new A157184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157185
{
public static readonly long[] Value={ 2L,13L,41L,83L,83L,167L,227L,227L,2273L,2273L,2273L,5297L,340007L,837077L,837077L,837077L,837077L,837077L,2004917L,2004917L,2004917L,208305767L,208305767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157185Inst : IEnumerable<long>
{
public static readonly long[] Value=A157185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157185.Bytes);
public long this[int i]=>Value[i];

public static A157185Inst Instance=new A157185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157186
{
public static readonly BigInteger[] Value={ 1L,-11L,-152L,11363L,133912L,-8537771L,-296377352L,106148386531L,1225722005272L,-141158254631141L,-8148059173623752L,2293860659646093593L,BigInteger.Parse("79442878131955167832"),BigInteger.Parse("-13215711883429465710311"),BigInteger.Parse("-1067957666892168027721352"),BigInteger.Parse("1639939224889449015090659507") };
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
public class A157186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157186.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157186Inst Instance=new A157186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157187
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,3L,0L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,3L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,4L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,2L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157187Inst : IEnumerable<long>
{
public static readonly long[] Value=A157187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157187.Bytes);
public long this[int i]=>Value[i];

public static A157187Inst Instance=new A157187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157188
{
public static readonly long[] Value={ 0L,2L,1L,1L,2L,0L,1L,1L,2L,1L,1L,0L,1L,1L,1L,0L,3L,0L,0L,4L,0L,1L,1L,0L,0L,1L,1L,2L,0L,0L,0L,2L,1L,1L,1L,0L,0L,1L,2L,0L,3L,0L,3L,0L,1L,1L,1L,1L,1L,0L,0L,3L,0L,2L,0L,2L,1L,1L,0L,1L,0L,0L,0L,4L,0L,0L,1L,0L,2L,0L,0L,4L,0L,0L,1L,2L,0L,0L,0L,0L,4L,0L,4L,0L,0L,1L,0L,0L,1L,1L,1L,3L,0L,1L,1L,3L,0L,1L,1L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157188Inst : IEnumerable<long>
{
public static readonly long[] Value=A157188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157188.Bytes);
public long this[int i]=>Value[i];

public static A157188Inst Instance=new A157188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157189
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,9L,10L,11L,12L,14L,16L,17L,19L,20L,22L,23L,25L,26L,27L,31L,32L,33L,34L,37L,42L,45L,46L,54L,58L,61L,65L,70L,71L,73L,76L,77L,78L,87L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157189Inst : IEnumerable<long>
{
public static readonly long[] Value=A157189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157189.Bytes);
public long this[int i]=>Value[i];

public static A157189Inst Instance=new A157189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157190
{
public static readonly long[] Value={ 2L,3L,59L,71L,1151L,2399L,7559L,42839L,110879L,181439L,241919L,262079L,453599L,665279L,1713599L,2827439L,6425999L,11309759L,12700799L,14137199L,16707599L,37837799L,45239039L,64864799L,82162079L,86486399L,93562559L,260124479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157190Inst : IEnumerable<long>
{
public static readonly long[] Value=A157190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157190.Bytes);
public long this[int i]=>Value[i];

public static A157190Inst Instance=new A157190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157191
{
public static readonly long[] Value={ 1L,2L,17L,20L,190L,357L,959L,4479L,10522L,16447L,21383L,22993L,37977L,53972L,129076L,205244L,440069L,745584L,830983L,918422L,1073653L,2309722L,2731757L,3833005L,4788328L,5025102L,5411333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157191Inst : IEnumerable<long>
{
public static readonly long[] Value=A157191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157191.Bytes);
public long this[int i]=>Value[i];

public static A157191Inst Instance=new A157191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157192
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,9L,1L,1L,16L,48L,16L,1L,1L,33L,97L,97L,33L,1L,1L,64L,192L,640L,192L,64L,1L,1L,129L,385L,1281L,1281L,385L,129L,1L,1L,256L,768L,2560L,7168L,2560L,768L,256L,1L,1L,513L,1537L,5121L,14337L,14337L,5121L,1537L,513L,1L,1L,1024L,3072L,10240L,28672L,90112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157192Inst : IEnumerable<long>
{
public static readonly long[] Value=A157192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157192.Bytes);
public long this[int i]=>Value[i];

public static A157192Inst Instance=new A157192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157193
{
public static readonly BigInteger[] Value={ 1L,4L,44L,1953L,4179942L,42836179578838L,BigInteger.Parse("3958573977160882295479936105"),BigInteger.Parse("36328295343356352083453782833218820307659379901717630389") };
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
public class A157193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157193Inst Instance=new A157193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157194
{
public static readonly long[] Value={ 41L,43L,84L,127L,211L,338L,549L,887L,1436L,2323L,3759L,6082L,9841L,15923L,25764L,41687L,67451L,109138L,176589L,285727L,462316L,748043L,1210359L,1958402L,3168761L,5127163L,8295924L,13423087L,21719011L,35142098L,56861109L,92003207L,148864316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157194Inst : IEnumerable<long>
{
public static readonly long[] Value=A157194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157194.Bytes);
public long this[int i]=>Value[i];

public static A157194Inst Instance=new A157194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157195
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,6L,0L,8L,3L,10L,0L,144L,0L,14L,15L,64L,0L,324L,0L,400L,21L,22L,0L,13824L,5L,26L,27L,784L,0L,27000L,0L,1024L,33L,34L,35L,279936L,0L,38L,39L,64000L,0L,74088L,0L,1936L,2025L,46L,0L,5308416L,7L,2500L,51L,2704L,0L,157464L,55L,175616L,57L,58L,0L,777600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157195Inst : IEnumerable<long>
{
public static readonly long[] Value=A157195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157195.Bytes);
public long this[int i]=>Value[i];

public static A157195Inst Instance=new A157195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157196
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157196Inst : IEnumerable<long>
{
public static readonly long[] Value=A157196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157196.Bytes);
public long this[int i]=>Value[i];

public static A157196Inst Instance=new A157196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157197
{
public static readonly long[] Value={ 3L,6L,85L,20877L,52086501L,10988577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157197Inst : IEnumerable<long>
{
public static readonly long[] Value=A157197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157197.Bytes);
public long this[int i]=>Value[i];

public static A157197Inst Instance=new A157197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157198
{
public static readonly long[] Value={ 736L,2502L,2592L,11664L,15613L,15617L,15618L,15622L,15624L,15632L,15642L,15645L,15656L,15662L,15667L,15698L,16875L,17536L,19453L,26364L,27639L,32785L,34425L,35721L,39283L,39343L,39363L,39369L,45947L,46630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157198Inst : IEnumerable<long>
{
public static readonly long[] Value=A157198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157198.Bytes);
public long this[int i]=>Value[i];

public static A157198Inst Instance=new A157198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157199
{
public static readonly long[] Value={ 9L,13L,22L,26L,44L,50L,25L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157199Inst : IEnumerable<long>
{
public static readonly long[] Value=A157199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157199.Bytes);
public long this[int i]=>Value[i];

public static A157199Inst Instance=new A157199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157200
{
public static readonly long[] Value={ 2L,3L,6L,7L,12L,21L,113L,404L,735L,1944L,4973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157200Inst : IEnumerable<long>
{
public static readonly long[] Value=A157200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157200.Bytes);
public long this[int i]=>Value[i];

public static A157200Inst Instance=new A157200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157201
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,10L,11L,13L,15L,17L,20L,22L,27L,32L,33L,35L,36L,41L,45L,46L,48L,50L,52L,53L,55L,56L,61L,62L,63L,66L,67L,70L,75L,80L,81L,82L,83L,87L,91L,92L,95L,96L,98L,102L,106L,108L,112L,113L,115L,117L,118L,122L,126L,130L,131L,132L,133L,137L,138L,140L,143L,148L,150L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157201Inst : IEnumerable<long>
{
public static readonly long[] Value=A157201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157201.Bytes);
public long this[int i]=>Value[i];

public static A157201Inst Instance=new A157201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157202
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,9L,12L,13L,14L,16L,18L,19L,23L,26L,27L,36L,37L,39L,41L,42L,43L,44L,46L,51L,56L,57L,58L,64L,68L,71L,74L,76L,77L,78L,81L,82L,83L,88L,89L,91L,93L,98L,102L,103L,104L,106L,111L,114L,117L,118L,123L,127L,133L,134L,141L,142L,149L,152L,153L,154L,156L,158L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157202Inst : IEnumerable<long>
{
public static readonly long[] Value=A157202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157202.Bytes);
public long this[int i]=>Value[i];

public static A157202Inst Instance=new A157202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157203
{
public static readonly BigInteger[] Value={ 1L,-7L,-170L,7483L,152830L,-5657407L,-339152210L,70397285651L,1403066848510L,-93625354848697L,-9327302363164850L,1521455855885449393L,BigInteger.Parse("90940761258235221790"),BigInteger.Parse("-8765636585104940011387"),BigInteger.Parse("-1222525274786161585523090"),BigInteger.Parse("1087729024572727259488366867"),BigInteger.Parse("21671894670036853665509988670") };
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
public class A157203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157203Inst Instance=new A157203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157204
{
public static readonly BigInteger[] Value={ 1L,-5L,-176L,5405L,159280L,-4095125L,-353797136L,50972827165L,1463820262960L,-67794227594075L,-9731307072426896L,1101692770767192935L,BigInteger.Parse("94879929252769701040"),BigInteger.Parse("-6347238532568267099225"),BigInteger.Parse("-1275480095230570717968656"),BigInteger.Parse("787629728021848746752571725"),BigInteger.Parse("22610633381796277823039433520") };
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
public class A157204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157204Inst Instance=new A157204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}