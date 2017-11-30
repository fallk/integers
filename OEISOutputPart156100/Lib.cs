using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199205
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,17L,30L,50L,77L,113L,156L,212L,279L,355L,447L,560L,684L,822L,985L,1171L,1375L,1599L,1856L,2134L,2445L,2769L,3125L,3519L,3939L,4376L,4857L,5372L,5914L,6484L,7083L,7717L,8411L,9130L,9882L,10683L,11524L,12393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199205Inst : IEnumerable<long>
{
public static readonly long[] Value=A199205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199205.Bytes);
public long this[int i]=>Value[i];

public static A199205Inst Instance=new A199205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199206
{
public static readonly long[] Value={ 1L,1L,2L,26L,53L,365L,73L,13369L,31226L,40193L,1346393L,10982633L,59784881L,12459674L,197301737L,4044371993L,16335212753L,165277755905L,33055551181L,627510050434L,2556360882389L,25830314642530L,5166062928506L,433477841994649L,1561599571802482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199206Inst : IEnumerable<long>
{
public static readonly long[] Value=A199206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199206.Bytes);
public long this[int i]=>Value[i];

public static A199206Inst Instance=new A199206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199207
{
public static readonly long[] Value={ 8L,29L,113L,449L,1793L,7169L,28673L,114689L,458753L,1835009L,7340033L,29360129L,117440513L,469762049L,1879048193L,7516192769L,30064771073L,120259084289L,481036337153L,1924145348609L,7696581394433L,30786325577729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199207Inst : IEnumerable<long>
{
public static readonly long[] Value=A199207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199207.Bytes);
public long this[int i]=>Value[i];

public static A199207Inst Instance=new A199207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199208
{
public static readonly long[] Value={ 10L,37L,145L,577L,2305L,9217L,36865L,147457L,589825L,2359297L,9437185L,37748737L,150994945L,603979777L,2415919105L,9663676417L,38654705665L,154618822657L,618475290625L,2473901162497L,9895604649985L,39582418599937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199208Inst : IEnumerable<long>
{
public static readonly long[] Value=A199208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199208.Bytes);
public long this[int i]=>Value[i];

public static A199208Inst Instance=new A199208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199209
{
public static readonly long[] Value={ 11L,41L,161L,641L,2561L,10241L,40961L,163841L,655361L,2621441L,10485761L,41943041L,167772161L,671088641L,2684354561L,10737418241L,42949672961L,171798691841L,687194767361L,2748779069441L,10995116277761L,43980465111041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199209Inst : IEnumerable<long>
{
public static readonly long[] Value=A199209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199209.Bytes);
public long this[int i]=>Value[i];

public static A199209Inst Instance=new A199209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199210
{
public static readonly long[] Value={ 4L,15L,59L,235L,939L,3755L,15019L,60075L,240299L,961195L,3844779L,15379115L,61516459L,246065835L,984263339L,3937053355L,15748213419L,62992853675L,251971414699L,1007885658795L,4031542635179L,16126170540715L,64504682162859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199210Inst : IEnumerable<long>
{
public static readonly long[] Value=A199210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199210.Bytes);
public long this[int i]=>Value[i];

public static A199210Inst Instance=new A199210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199211
{
public static readonly long[] Value={ 12L,45L,177L,705L,2817L,11265L,45057L,180225L,720897L,2883585L,11534337L,46137345L,184549377L,738197505L,2952790017L,11811160065L,47244640257L,188978561025L,755914244097L,3023656976385L,12094627905537L,48378511622145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199211Inst : IEnumerable<long>
{
public static readonly long[] Value=A199211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199211.Bytes);
public long this[int i]=>Value[i];

public static A199211Inst Instance=new A199211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199212
{
public static readonly long[] Value={ 3L,11L,51L,251L,1251L,6251L,31251L,156251L,781251L,3906251L,19531251L,97656251L,488281251L,2441406251L,12207031251L,61035156251L,305175781251L,1525878906251L,7629394531251L,38146972656251L,190734863281251L,953674316406251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199212Inst : IEnumerable<long>
{
public static readonly long[] Value=A199212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199212.Bytes);
public long this[int i]=>Value[i];

public static A199212Inst Instance=new A199212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199213
{
public static readonly long[] Value={ 2L,8L,38L,188L,938L,4688L,23438L,117188L,585938L,2929688L,14648438L,73242188L,366210938L,1831054688L,9155273438L,45776367188L,228881835938L,1144409179688L,5722045898438L,28610229492188L,143051147460938L,715255737304688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199213Inst : IEnumerable<long>
{
public static readonly long[] Value=A199213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199213.Bytes);
public long this[int i]=>Value[i];

public static A199213Inst Instance=new A199213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199214
{
public static readonly long[] Value={ 4L,16L,76L,376L,1876L,9376L,46876L,234376L,1171876L,5859376L,29296876L,146484376L,732421876L,3662109376L,18310546876L,91552734376L,457763671876L,2288818359376L,11444091796876L,57220458984376L,286102294921876L,1430511474609376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199214Inst : IEnumerable<long>
{
public static readonly long[] Value=A199214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199214.Bytes);
public long this[int i]=>Value[i];

public static A199214Inst Instance=new A199214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199215
{
public static readonly long[] Value={ 5L,21L,101L,501L,2501L,12501L,62501L,312501L,1562501L,7812501L,39062501L,195312501L,976562501L,4882812501L,24414062501L,122070312501L,610351562501L,3051757812501L,15258789062501L,76293945312501L,381469726562501L,1907348632812501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199215Inst : IEnumerable<long>
{
public static readonly long[] Value=A199215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199215.Bytes);
public long this[int i]=>Value[i];

public static A199215Inst Instance=new A199215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199216
{
public static readonly long[] Value={ 7L,31L,151L,751L,3751L,18751L,93751L,468751L,2343751L,11718751L,58593751L,292968751L,1464843751L,7324218751L,36621093751L,183105468751L,915527343751L,4577636718751L,22888183593751L,114440917968751L,572204589843751L,2861022949218751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199216Inst : IEnumerable<long>
{
public static readonly long[] Value=A199216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199216.Bytes);
public long this[int i]=>Value[i];

public static A199216Inst Instance=new A199216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199217
{
public static readonly long[] Value={ 3L,5L,11L,17L,19L,37L,43L,79L,83L,89L,151L,157L,173L,191L,269L,277L,281L,307L,311L,337L,347L,349L,359L,367L,379L,523L,569L,599L,607L,617L,653L,659L,673L,677L,683L,709L,727L,739L,1033L,1061L,1069L,1093L,1123L,1171L,1193L,1201L,1249L,1283L,1289L,1319L,1373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199217Inst : IEnumerable<long>
{
public static readonly long[] Value=A199217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199217.Bytes);
public long this[int i]=>Value[i];

public static A199217Inst Instance=new A199217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199218
{
public static readonly long[] Value={ 3L,7L,13L,31L,29L,59L,53L,113L,109L,103L,233L,227L,211L,193L,499L,491L,487L,461L,457L,431L,421L,419L,409L,401L,389L,1013L,967L,937L,929L,919L,883L,877L,863L,859L,853L,827L,809L,797L,2039L,2011L,2003L,1979L,1949L,1901L,1879L,1871L,1823L,1789L,1783L,1753L,1699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199218Inst : IEnumerable<long>
{
public static readonly long[] Value=A199218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199218.Bytes);
public long this[int i]=>Value[i];

public static A199218Inst Instance=new A199218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199219
{
public static readonly long[] Value={ 23L,41L,47L,61L,67L,71L,73L,97L,101L,107L,127L,131L,137L,139L,149L,163L,167L,179L,181L,197L,199L,223L,229L,239L,241L,251L,257L,263L,271L,283L,293L,313L,317L,331L,353L,373L,383L,397L,433L,439L,443L,449L,463L,467L,479L,503L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199219Inst : IEnumerable<long>
{
public static readonly long[] Value=A199219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199219.Bytes);
public long this[int i]=>Value[i];

public static A199219Inst Instance=new A199219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199220
{
public static readonly long[] Value={ -1L,0L,-1L,1L,0L,-2L,2L,6L,0L,-6L,3L,20L,35L,0L,-24L,4L,45L,170L,225L,0L,-120L,5L,84L,525L,1470L,1624L,0L,-720L,6L,140L,1288L,5880L,13538L,13132L,0L,-5040L,7L,216L,2730L,18144L,67347L,134568L,118124L,0L,-40320L,8L,315L,5220L,47250L,253092L,807975L,1447360L,1172700L,0L,-362880L,9L,440L,9240L,108900L,788865L,3608220L,10250790L,16819000L,12753576L,0L,-3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199220Inst : IEnumerable<long>
{
public static readonly long[] Value=A199220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199220.Bytes);
public long this[int i]=>Value[i];

public static A199220Inst Instance=new A199220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199221
{
public static readonly long[] Value={ -1L,0L,1L,1L,4L,2L,2L,12L,18L,6L,3L,28L,83L,88L,24L,4L,55L,270L,575L,500L,120L,5L,96L,705L,2490L,4324L,3288L,720L,6L,154L,1582L,8330L,23828L,35868L,24696L,5040L,7L,232L,3178L,23296L,98707L,242872L,328236L,209088L,40320L,8L,333L,5868L,57078L,334740L,1212057L,2658472L,3298932L,1972512L,362880L,9L,460L,10140L,126300L,977865L,4873680L,15637290L,31292600L,36207576L,20531520L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199221Inst : IEnumerable<long>
{
public static readonly long[] Value=A199221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199221.Bytes);
public long this[int i]=>Value[i];

public static A199221Inst Instance=new A199221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199222
{
public static readonly long[] Value={ 1L,6L,110L,55956L,49412210L,70698654245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199222Inst : IEnumerable<long>
{
public static readonly long[] Value=A199222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199222.Bytes);
public long this[int i]=>Value[i];

public static A199222Inst Instance=new A199222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199223
{
public static readonly long[] Value={ 1L,1L,1L,6L,15L,15L,90L,226L,219L,1436L,3671L,3514L,24039L,62130L,58962L,415608L,1082718L,1021368L,7354732L,19274263L,18101068L,132456534L,348731568L,326374830L,2418406938L,6390767156L,5964605638L,44643259798L,118329627186L,110190867844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199223Inst : IEnumerable<long>
{
public static readonly long[] Value=A199223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199223.Bytes);
public long this[int i]=>Value[i];

public static A199223Inst Instance=new A199223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199224
{
public static readonly long[] Value={ 1L,6L,15L,148L,739L,1538L,19458L,99290L,199245L,2737170L,14308328L,28263858L,406132996L,2157586976L,4223483322L,62496247170L,335699045124L,653268735784L,9869313704764L,53437060321924L,103559574448252L,1588892060781914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199224Inst : IEnumerable<long>
{
public static readonly long[] Value=A199224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199224.Bytes);
public long this[int i]=>Value[i];

public static A199224Inst Instance=new A199224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199225
{
public static readonly long[] Value={ 1L,15L,110L,1114L,10790L,108608L,1114424L,11614563L,122555420L,1306096140L,14036296174L,151900593514L,1653715009450L,18096656251093L,198923288701426L,2195264844234822L,24311220765553010L,270073032889614065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199225Inst : IEnumerable<long>
{
public static readonly long[] Value=A199225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199225.Bytes);
public long this[int i]=>Value[i];

public static A199225Inst Instance=new A199225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199226
{
public static readonly BigInteger[] Value={ 6L,148L,1114L,55956L,1167274L,9196334L,530601540L,11633434848L,92326218546L,5690918294602L,127860411550976L,1019724611977366L,65238218370369084L,1488224431249789464L,11906181377018139524UL,BigInteger.Parse("780082724283681110224") };
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
public class A199226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199226Inst Instance=new A199226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199227
{
public static readonly BigInteger[] Value={ 15L,739L,10790L,1167274L,49412210L,792389959L,96560931821L,4344228334421L,70560352612852L,9143396401034088L,423459039709699782L,6930757850616949157L,BigInteger.Parse("929406888198274113203"),BigInteger.Parse("43797877181608849827451"),BigInteger.Parse("720360643744861532076328") };
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
public class A199227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199227Inst Instance=new A199227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199228
{
public static readonly long[] Value={ 15L,1538L,108608L,9196334L,792389959L,70698654245L,6443389324257L,597038658964877L,56047378745263409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199228Inst : IEnumerable<long>
{
public static readonly long[] Value=A199228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199228.Bytes);
public long this[int i]=>Value[i];

public static A199228Inst Instance=new A199228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199229
{
public static readonly long[] Value={ 90L,19458L,1114424L,530601540L,96560931821L,6443389324257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199229Inst : IEnumerable<long>
{
public static readonly long[] Value=A199229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199229.Bytes);
public long this[int i]=>Value[i];

public static A199229Inst Instance=new A199229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199230
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,6L,15L,15L,6L,15L,148L,110L,148L,15L,15L,739L,1114L,1114L,739L,15L,90L,1538L,10790L,55956L,10790L,1538L,90L,226L,19458L,108608L,1167274L,1167274L,108608L,19458L,226L,219L,99290L,1114424L,9196334L,49412210L,9196334L,1114424L,99290L,219L,1436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199230Inst : IEnumerable<long>
{
public static readonly long[] Value=A199230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199230.Bytes);
public long this[int i]=>Value[i];

public static A199230Inst Instance=new A199230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199231
{
public static readonly long[] Value={ 0L,0L,3L,12L,31L,143L,1183L,5068L,11594L,133430L,632580L,1198596L,16002429L,78638190L,139661368L,1990115356L,9953302579L,17313999205L,254272220438L,1284820132294L,2223104240738L,33166493583372L,168734504757571L,291907971810015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199231Inst : IEnumerable<long>
{
public static readonly long[] Value=A199231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199231.Bytes);
public long this[int i]=>Value[i];

public static A199231Inst Instance=new A199231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199232
{
public static readonly long[] Value={ 0L,3L,10L,134L,1162L,14159L,157598L,1893418L,22549653L,273912278L,3343968014L,41175336250L,509775461915L,6345933759165L,79347706998224L,996146776785323L,12549773566364371L,158605269941072464L,2010125063939318784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199232Inst : IEnumerable<long>
{
public static readonly long[] Value=A199232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199232.Bytes);
public long this[int i]=>Value[i];

public static A199232Inst Instance=new A199232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199233
{
public static readonly BigInteger[] Value={ 0L,12L,134L,7772L,233185L,2350573L,198168342L,5945464970L,61459551305L,5513397881816L,170180145113452L,1793698349077584L,165352227478417900L,5196360663854340690L,BigInteger.Parse("55445845644254306328"),BigInteger.Parse("5198278149707750425296") };
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
public class A199233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199233Inst Instance=new A199233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199234
{
public static readonly long[] Value={ 0L,31L,1162L,233185L,16467051L,410003607L,88764401434L,6694765030353L,173658860616275L,39468698299166073L,3071783011857585339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199234Inst : IEnumerable<long>
{
public static readonly long[] Value=A199234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199234.Bytes);
public long this[int i]=>Value[i];

public static A199234Inst Instance=new A199234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199235
{
public static readonly long[] Value={ 1L,143L,14159L,2350573L,410003607L,74737706829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199235Inst : IEnumerable<long>
{
public static readonly long[] Value=A199235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199235.Bytes);
public long this[int i]=>Value[i];

public static A199235Inst Instance=new A199235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199236
{
public static readonly long[] Value={ 3L,1183L,157598L,198168342L,88764401434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199236Inst : IEnumerable<long>
{
public static readonly long[] Value=A199236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199236.Bytes);
public long this[int i]=>Value[i];

public static A199236Inst Instance=new A199236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199237
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,12L,10L,12L,0L,1L,31L,134L,134L,31L,1L,3L,143L,1162L,7772L,1162L,143L,3L,3L,1183L,14159L,233185L,233185L,14159L,1183L,3L,1L,5068L,157598L,2350573L,16467051L,2350573L,157598L,5068L,1L,6L,11594L,1893418L,198168342L,410003607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199237Inst : IEnumerable<long>
{
public static readonly long[] Value=A199237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199237.Bytes);
public long this[int i]=>Value[i];

public static A199237Inst Instance=new A199237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199238
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,2L,3L,0L,1L,0L,1L,0L,0L,1L,3L,0L,1L,2L,3L,1L,1L,2L,1L,0L,1L,0L,2L,0L,1L,2L,3L,0L,2L,0L,3L,2L,1L,2L,2L,0L,1L,2L,3L,1L,1L,2L,0L,2L,1L,2L,4L,0L,1L,2L,3L,0L,1L,0L,1L,0L,0L,1L,3L,0L,1L,2L,3L,1L,1L,2L,4L,0L,0L,1L,3L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199238Inst : IEnumerable<long>
{
public static readonly long[] Value=A199238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199238.Bytes);
public long this[int i]=>Value[i];

public static A199238Inst Instance=new A199238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199239
{
public static readonly long[] Value={ 1L,2L,6L,440L,29227L,1682457L,2013526831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199239Inst : IEnumerable<long>
{
public static readonly long[] Value=A199239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199239.Bytes);
public long this[int i]=>Value[i];

public static A199239Inst Instance=new A199239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199240
{
public static readonly long[] Value={ 1L,2L,2L,12L,36L,39L,288L,836L,888L,7380L,22149L,23706L,201515L,611372L,654468L,5704006L,17499974L,18760333L,166063522L,513160156L,550594928L,4932198432L,15327377362L,16456851660L,148765279666L,464332349724L,498808175988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199240Inst : IEnumerable<long>
{
public static readonly long[] Value=A199240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199240.Bytes);
public long this[int i]=>Value[i];

public static A199240Inst Instance=new A199240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199241
{
public static readonly long[] Value={ 1L,2L,6L,25L,110L,472L,2080L,9279L,41704L,187500L,853012L,3919309L,18163022L,84589504L,395762792L,1858908001L,8762833946L,41439737234L,196527899276L,934460643457L,4453641597888L,21271612632536L,101795771318046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199241Inst : IEnumerable<long>
{
public static readonly long[] Value=A199241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199241.Bytes);
public long this[int i]=>Value[i];

public static A199241Inst Instance=new A199241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199242
{
public static readonly long[] Value={ 3L,12L,25L,440L,2907L,7100L,134821L,934004L,2277108L,46296108L,330908530L,820702285L,17258404593L,125752465794L,315014793177L,6765057712760L,49918706666467L,125910537922412L,2743415189299833L,20425391744058298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199242Inst : IEnumerable<long>
{
public static readonly long[] Value=A199242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199242.Bytes);
public long this[int i]=>Value[i];

public static A199242Inst Instance=new A199242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199243
{
public static readonly long[] Value={ 6L,36L,110L,2907L,29227L,106134L,3190670L,34188947L,128653588L,4104988637L,45715625760L,175247135865L,5792733542191L,65791526001202L,255708129900506L,8623880506094423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199243Inst : IEnumerable<long>
{
public static readonly long[] Value=A199243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199243.Bytes);
public long this[int i]=>Value[i];

public static A199243Inst Instance=new A199243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199244
{
public static readonly long[] Value={ 5L,39L,472L,7100L,106134L,1682457L,27337776L,454364514L,7678775057L,131559174015L,2279099028427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199244Inst : IEnumerable<long>
{
public static readonly long[] Value=A199244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199244.Bytes);
public long this[int i]=>Value[i];

public static A199244Inst Instance=new A199244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199245
{
public static readonly long[] Value={ 19L,288L,2080L,134821L,3190670L,27337776L,2013526831L,52332203186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199245Inst : IEnumerable<long>
{
public static readonly long[] Value=A199245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199245.Bytes);
public long this[int i]=>Value[i];

public static A199245Inst Instance=new A199245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199246
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,2L,3L,6L,12L,6L,12L,6L,5L,36L,25L,25L,36L,5L,19L,39L,110L,440L,110L,39L,19L,37L,288L,472L,2907L,2907L,472L,288L,37L,29L,836L,2080L,7100L,29227L,7100L,2080L,836L,29L,124L,888L,9279L,134821L,106134L,106134L,134821L,9279L,888L,124L,240L,7380L,41704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199246Inst : IEnumerable<long>
{
public static readonly long[] Value=A199246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199246.Bytes);
public long this[int i]=>Value[i];

public static A199246Inst Instance=new A199246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199247
{
public static readonly long[] Value={ 1L,1L,2L,7L,25L,92L,359L,1453L,6018L,25411L,109032L,473942L,2082550L,9235675L,41284297L,185819487L,841433773L,3830604764L,17521832924L,80490034307L,371169646860L,1717567062240L,7973153760616L,37119622029816L,173272771061677L,810810134833720L,3802675087749650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199247Inst : IEnumerable<long>
{
public static readonly long[] Value=A199247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199247.Bytes);
public long this[int i]=>Value[i];

public static A199247Inst Instance=new A199247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199248
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,69L,248L,923L,3523L,13706L,54152L,216710L,876607L,3578405L,14722432L,60986158L,254145337L,1064712328L,4481577078L,18943753140L,80381689202L,342254333393L,1461864544896L,6262021627055L,26894816382199L,115792035533779L,499648608539714L,2160504474956390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199248Inst : IEnumerable<long>
{
public static readonly long[] Value=A199248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199248.Bytes);
public long this[int i]=>Value[i];

public static A199248Inst Instance=new A199248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199249
{
public static readonly long[] Value={ 1L,1L,114L,11223L,68639138L,208100267703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199249Inst : IEnumerable<long>
{
public static readonly long[] Value=A199249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199249.Bytes);
public long this[int i]=>Value[i];

public static A199249Inst Instance=new A199249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199250
{
public static readonly long[] Value={ 1L,1L,14L,21L,424L,571L,14160L,18157L,508802L,635901L,19257756L,23709063L,756845422L,922808863L,30595342532L,37055004573L,1264116241990L,1523501274001L,53146116905514L,63810625823521L,2266270709962148L,2712945090726795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199250Inst : IEnumerable<long>
{
public static readonly long[] Value=A199250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199250.Bytes);
public long this[int i]=>Value[i];

public static A199250Inst Instance=new A199250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199251
{
public static readonly long[] Value={ 1L,14L,114L,447L,16898L,311216L,2913528L,11312517L,551973865L,11307744507L,111458340272L,438326135133L,23492069994614L,506092203408916L,5117349646825383L,20296888647373122L,1141664017876511539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199251Inst : IEnumerable<long>
{
public static readonly long[] Value=A199251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199251.Bytes);
public long this[int i]=>Value[i];

public static A199251Inst Instance=new A199251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199252
{
public static readonly BigInteger[] Value={ 1L,21L,447L,11223L,305863L,8862785L,267827143L,8351549833L,266729329121L,8681405364211L,286916350055011L,9603063714049169L,324843085529291745L,11088239688730868231UL,BigInteger.Parse("381446891741918303003"),BigInteger.Parse("13211448568439934521121") };
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
public class A199252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199252Inst Instance=new A199252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199253
{
public static readonly ulong[] Value={ 6L,424L,16898L,305863L,68639138L,6888550898L,340245592285L,6769314291049L,1887110314847070L,212296762860857040L,11206162997839745779UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199253Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199253.Bytes);
public ulong this[int i]=>Value[i];

public static A199253Inst Instance=new A199253Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199254
{
public static readonly long[] Value={ 21L,571L,311216L,8862785L,6888550898L,208100267703L,186725016600685L,5831222792322854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199254Inst : IEnumerable<long>
{
public static readonly long[] Value=A199254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199254.Bytes);
public long this[int i]=>Value[i];

public static A199254Inst Instance=new A199254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199255
{
public static readonly long[] Value={ 41L,14160L,2913528L,267827143L,340245592285L,186725016600685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199255Inst : IEnumerable<long>
{
public static readonly long[] Value=A199255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199255.Bytes);
public long this[int i]=>Value[i];

public static A199255Inst Instance=new A199255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199256
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,14L,14L,1L,6L,21L,114L,21L,6L,21L,424L,447L,447L,424L,21L,41L,571L,16898L,11223L,16898L,571L,41L,36L,14160L,311216L,305863L,305863L,311216L,14160L,36L,281L,18157L,2913528L,8862785L,68639138L,8862785L,2913528L,18157L,281L,1051L,508802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199256Inst : IEnumerable<long>
{
public static readonly long[] Value=A199256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199256.Bytes);
public long this[int i]=>Value[i];

public static A199256Inst Instance=new A199256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199257
{
public static readonly long[] Value={ 1L,1L,5L,18L,86L,408L,2075L,10787L,57655L,313643L,1733450L,9700574L,54867895L,313145033L,1801150861L,10430094658L,60758092753L,355795743385L,2093295146379L,12367548160650L,73346850194969L,436486017193373L,2605656191324094L,15599323024019360L,93634195155551584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199257Inst : IEnumerable<long>
{
public static readonly long[] Value=A199257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199257.Bytes);
public long this[int i]=>Value[i];

public static A199257Inst Instance=new A199257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199258
{
public static readonly ulong[] Value={ 3L,36L,449L,6024L,83890L,1203424L,17634348L,262690636L,3964097574L,60448089272L,929736185578L,14403575178424L,224514368663504L,3518109050510528L,55381725681044520L,875329086340050012L,13884232495508832254UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199258Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199258.Bytes);
public ulong this[int i]=>Value[i];

public static A199258Inst Instance=new A199258Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199259
{
public static readonly long[] Value={ 3L,18L,114L,713L,4508L,28652L,183442L,1182513L,7674706L,50149664L,329879020L,2183961009L,14549033194L,97499792198L,657083735088L,4451886557217L,30312912452386L,207359582690700L,1424583104395390L,9826011131492859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199259Inst : IEnumerable<long>
{
public static readonly long[] Value=A199259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199259.Bytes);
public long this[int i]=>Value[i];

public static A199259Inst Instance=new A199259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199260
{
public static readonly long[] Value={ 1L,36L,114L,1240L,5381L,54588L,278570L,2397792L,14900001L,116469925L,780649269L,6006347346L,41989064859L,319129583349L,2307295438172L,17428815517107L,128586800958736L,972215152349757L,7260589438120238L,55045255657803475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199260Inst : IEnumerable<long>
{
public static readonly long[] Value=A199260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199260.Bytes);
public long this[int i]=>Value[i];

public static A199260Inst Instance=new A199260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199261
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,0L,0L,1L,0L,18L,18L,0L,1L,0L,36L,0L,0L,0L,36L,0L,0L,0L,114L,0L,0L,114L,0L,0L,0L,0L,0L,1240L,0L,1240L,0L,0L,0L,0L,449L,713L,0L,5381L,5381L,0L,713L,449L,0L,0L,0L,0L,0L,0L,54588L,0L,0L,0L,0L,0L,5L,0L,4508L,73456L,0L,278570L,278570L,0L,73456L,4508L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199261Inst : IEnumerable<long>
{
public static readonly long[] Value=A199261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199261.Bytes);
public long this[int i]=>Value[i];

public static A199261Inst Instance=new A199261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199262
{
public static readonly long[] Value={ 1L,3L,11L,15L,59L,95L,223L,255L,1007L,1919L,4091L,6143L,16379L,28671L,61439L,65535L,261119L,516095L,1048571L,1966079L,4128767L,8380415L,16769023L,25165823L,67108799L,134184959L,268434431L,469762047L,1073741819L,2013265919L,4160749567L,4294967295L,17163091967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199262Inst : IEnumerable<long>
{
public static readonly long[] Value=A199262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199262.Bytes);
public long this[int i]=>Value[i];

public static A199262Inst Instance=new A199262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199263
{
public static readonly long[] Value={ 2L,3L,1L,2L,4L,3L,8L,7L,5L,4L,10L,2L,5L,3L,1L,10L,12L,3L,4L,3L,15L,11L,12L,8L,18L,17L,3L,17L,7L,10L,20L,18L,11L,9L,10L,22L,12L,0L,1L,24L,26L,18L,2L,20L,4L,10L,18L,9L,30L,28L,27L,8L,9L,1L,23L,28L,8L,30L,11L,26L,13L,8L,28L,32L,3L,20L,26L,22L,21L,23L,33L,28L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199263Inst : IEnumerable<long>
{
public static readonly long[] Value=A199263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199263.Bytes);
public long this[int i]=>Value[i];

public static A199263Inst Instance=new A199263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199264
{
public static readonly long[] Value={ 9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199264Inst : IEnumerable<long>
{
public static readonly long[] Value=A199264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199264.Bytes);
public long this[int i]=>Value[i];

public static A199264Inst Instance=new A199264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199265
{
public static readonly long[] Value={ 1L,1L,1L,5L,8L,6L,5L,4L,7L,4L,1L,7L,7L,8L,0L,0L,9L,2L,0L,0L,2L,5L,9L,0L,5L,3L,5L,2L,5L,3L,5L,8L,5L,5L,7L,9L,2L,7L,3L,6L,1L,2L,8L,0L,6L,6L,4L,8L,7L,3L,9L,7L,8L,1L,7L,4L,4L,6L,2L,5L,9L,3L,7L,6L,5L,1L,2L,5L,1L,1L,5L,6L,7L,6L,9L,2L,4L,1L,6L,1L,0L,9L,0L,2L,1L,6L,0L,9L,2L,7L,8L,4L,4L,7L,0L,8L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199265Inst : IEnumerable<long>
{
public static readonly long[] Value=A199265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199265.Bytes);
public long this[int i]=>Value[i];

public static A199265Inst Instance=new A199265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199266
{
public static readonly long[] Value={ 8L,4L,8L,2L,4L,9L,6L,4L,9L,0L,6L,6L,0L,3L,3L,5L,6L,4L,4L,9L,3L,0L,0L,1L,6L,7L,1L,3L,6L,5L,3L,6L,0L,1L,0L,5L,1L,5L,8L,7L,0L,8L,7L,3L,5L,3L,8L,3L,3L,5L,2L,5L,3L,4L,6L,7L,8L,2L,7L,4L,0L,3L,0L,2L,5L,6L,9L,7L,0L,7L,8L,0L,7L,5L,7L,1L,7L,7L,8L,1L,7L,4L,4L,8L,9L,5L,2L,7L,7L,9L,5L,8L,5L,6L,5L,4L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199266Inst : IEnumerable<long>
{
public static readonly long[] Value=A199266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199266.Bytes);
public long this[int i]=>Value[i];

public static A199266Inst Instance=new A199266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199267
{
public static readonly long[] Value={ 1L,2L,9L,4L,7L,7L,1L,7L,6L,5L,5L,1L,0L,2L,7L,0L,5L,4L,1L,9L,0L,0L,6L,8L,1L,0L,3L,1L,4L,7L,0L,2L,1L,8L,5L,6L,1L,4L,4L,2L,6L,6L,2L,1L,5L,3L,7L,0L,6L,5L,4L,5L,4L,3L,4L,4L,6L,0L,7L,2L,0L,1L,7L,0L,6L,5L,9L,4L,4L,5L,0L,0L,9L,8L,6L,3L,5L,1L,4L,4L,3L,2L,5L,3L,4L,0L,2L,1L,4L,0L,8L,1L,6L,2L,0L,7L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199267Inst : IEnumerable<long>
{
public static readonly long[] Value=A199267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199267.Bytes);
public long this[int i]=>Value[i];

public static A199267Inst Instance=new A199267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199268
{
public static readonly long[] Value={ 1L,1L,2L,0L,8L,2L,7L,8L,9L,9L,0L,7L,2L,4L,6L,4L,1L,0L,5L,0L,1L,0L,8L,0L,2L,6L,5L,5L,1L,2L,3L,8L,2L,4L,4L,1L,4L,8L,4L,1L,5L,4L,0L,8L,0L,2L,6L,3L,1L,7L,7L,8L,5L,0L,7L,9L,0L,8L,7L,2L,0L,2L,4L,4L,4L,0L,8L,1L,6L,1L,3L,3L,0L,6L,8L,0L,5L,0L,0L,7L,0L,6L,7L,6L,8L,3L,8L,6L,1L,2L,6L,1L,6L,1L,9L,2L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199268Inst : IEnumerable<long>
{
public static readonly long[] Value=A199268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199268.Bytes);
public long this[int i]=>Value[i];

public static A199268Inst Instance=new A199268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199269
{
public static readonly long[] Value={ 1L,0L,1L,7L,2L,4L,0L,7L,9L,8L,3L,4L,2L,4L,5L,5L,5L,6L,6L,5L,6L,0L,3L,5L,0L,0L,7L,0L,5L,4L,5L,3L,4L,6L,1L,7L,6L,0L,1L,7L,4L,1L,1L,4L,3L,2L,0L,8L,0L,3L,7L,3L,2L,1L,9L,3L,7L,7L,8L,9L,5L,6L,5L,4L,8L,8L,6L,6L,5L,8L,0L,6L,3L,8L,8L,8L,7L,4L,9L,9L,0L,9L,7L,6L,3L,7L,3L,1L,6L,8L,2L,8L,8L,1L,9L,1L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199269Inst : IEnumerable<long>
{
public static readonly long[] Value=A199269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199269.Bytes);
public long this[int i]=>Value[i];

public static A199269Inst Instance=new A199269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199270
{
public static readonly long[] Value={ 3L,8L,1L,7L,4L,8L,4L,2L,0L,9L,9L,2L,9L,8L,5L,9L,5L,7L,9L,1L,8L,5L,2L,1L,6L,1L,1L,8L,2L,3L,4L,8L,6L,6L,4L,5L,5L,9L,3L,3L,4L,1L,8L,5L,5L,0L,7L,6L,7L,1L,7L,8L,3L,1L,6L,0L,6L,3L,2L,9L,9L,1L,9L,0L,3L,7L,7L,0L,9L,1L,5L,4L,0L,8L,1L,6L,0L,9L,0L,2L,1L,1L,1L,5L,3L,4L,5L,2L,9L,4L,7L,9L,7L,3L,1L,8L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199270Inst : IEnumerable<long>
{
public static readonly long[] Value=A199270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199270.Bytes);
public long this[int i]=>Value[i];

public static A199270Inst Instance=new A199270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199271
{
public static readonly long[] Value={ 1L,3L,4L,2L,9L,0L,5L,1L,2L,2L,3L,2L,9L,3L,5L,6L,1L,5L,7L,7L,9L,5L,6L,2L,9L,2L,5L,8L,3L,8L,2L,8L,2L,5L,8L,2L,5L,1L,7L,0L,3L,3L,5L,1L,8L,8L,6L,9L,9L,2L,5L,8L,8L,4L,3L,2L,8L,6L,4L,6L,8L,6L,8L,3L,2L,9L,8L,0L,6L,6L,7L,4L,7L,5L,6L,5L,6L,3L,3L,0L,0L,9L,2L,1L,8L,5L,3L,7L,1L,2L,7L,1L,9L,2L,1L,4L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199271Inst : IEnumerable<long>
{
public static readonly long[] Value=A199271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199271.Bytes);
public long this[int i]=>Value[i];

public static A199271Inst Instance=new A199271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199272
{
public static readonly long[] Value={ 9L,7L,6L,3L,1L,2L,2L,7L,3L,6L,1L,5L,1L,3L,0L,1L,2L,3L,0L,7L,6L,4L,7L,0L,1L,4L,1L,3L,3L,5L,0L,9L,1L,5L,6L,7L,9L,6L,7L,9L,5L,3L,4L,3L,8L,0L,9L,3L,0L,7L,2L,6L,9L,5L,0L,4L,9L,1L,0L,7L,1L,7L,6L,4L,3L,2L,7L,7L,0L,7L,7L,1L,5L,4L,3L,2L,7L,9L,7L,2L,8L,5L,0L,0L,3L,9L,9L,2L,7L,6L,7L,2L,6L,5L,1L,8L,8L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199272Inst : IEnumerable<long>
{
public static readonly long[] Value=A199272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199272.Bytes);
public long this[int i]=>Value[i];

public static A199272Inst Instance=new A199272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199273
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,0L,7L,1L,6L,1L,2L,2L,3L,2L,1L,9L,3L,9L,2L,1L,0L,5L,2L,6L,0L,4L,3L,8L,8L,8L,3L,5L,1L,3L,3L,0L,9L,1L,0L,3L,3L,7L,9L,6L,2L,3L,1L,2L,5L,2L,5L,1L,2L,7L,4L,0L,7L,4L,6L,5L,6L,5L,6L,5L,3L,3L,4L,2L,3L,4L,6L,5L,8L,4L,2L,7L,1L,2L,8L,1L,2L,2L,5L,3L,6L,9L,0L,4L,5L,1L,5L,0L,4L,0L,8L,9L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199273Inst : IEnumerable<long>
{
public static readonly long[] Value=A199273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199273.Bytes);
public long this[int i]=>Value[i];

public static A199273Inst Instance=new A199273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199274
{
public static readonly long[] Value={ 2L,8L,9L,5L,0L,5L,4L,4L,8L,3L,8L,5L,8L,6L,7L,4L,1L,5L,5L,9L,2L,1L,7L,9L,4L,8L,3L,1L,9L,8L,9L,8L,2L,4L,5L,2L,3L,8L,1L,3L,1L,4L,3L,3L,8L,6L,3L,2L,2L,5L,8L,1L,1L,4L,5L,6L,8L,0L,7L,2L,4L,0L,2L,8L,2L,3L,6L,7L,2L,1L,2L,5L,7L,1L,2L,9L,9L,1L,1L,0L,3L,1L,6L,6L,7L,0L,2L,8L,3L,6L,5L,7L,4L,5L,9L,6L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199274Inst : IEnumerable<long>
{
public static readonly long[] Value=A199274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199274.Bytes);
public long this[int i]=>Value[i];

public static A199274Inst Instance=new A199274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199275
{
public static readonly long[] Value={ 1L,2L,5L,7L,5L,0L,7L,4L,8L,2L,6L,9L,6L,7L,9L,7L,8L,1L,2L,6L,2L,4L,5L,2L,2L,8L,2L,0L,0L,6L,8L,6L,6L,9L,2L,1L,0L,2L,2L,7L,8L,5L,6L,0L,1L,9L,8L,0L,6L,8L,6L,4L,9L,7L,2L,4L,3L,9L,0L,1L,1L,4L,7L,9L,5L,7L,1L,4L,7L,4L,6L,4L,0L,9L,9L,8L,8L,2L,2L,6L,4L,4L,7L,6L,8L,9L,8L,5L,8L,2L,2L,3L,6L,0L,9L,1L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199275Inst : IEnumerable<long>
{
public static readonly long[] Value=A199275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199275.Bytes);
public long this[int i]=>Value[i];

public static A199275Inst Instance=new A199275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199276
{
public static readonly long[] Value={ 5L,4L,7L,0L,0L,5L,7L,4L,0L,5L,4L,6L,8L,8L,9L,5L,7L,6L,4L,3L,6L,9L,2L,3L,2L,4L,7L,1L,5L,0L,7L,5L,5L,7L,2L,5L,0L,8L,7L,7L,5L,8L,0L,3L,0L,4L,0L,5L,9L,8L,1L,9L,6L,3L,2L,2L,3L,5L,5L,7L,5L,8L,3L,7L,7L,8L,5L,7L,5L,3L,9L,8L,1L,3L,5L,2L,1L,6L,9L,9L,0L,8L,4L,6L,8L,6L,5L,7L,4L,8L,2L,5L,2L,6L,1L,5L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199276Inst : IEnumerable<long>
{
public static readonly long[] Value=A199276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199276.Bytes);
public long this[int i]=>Value[i];

public static A199276Inst Instance=new A199276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199277
{
public static readonly long[] Value={ 1L,3L,7L,7L,3L,6L,8L,6L,7L,1L,8L,3L,8L,8L,2L,5L,1L,5L,7L,0L,6L,2L,9L,9L,6L,3L,8L,0L,5L,2L,9L,3L,3L,3L,5L,3L,5L,2L,4L,4L,4L,6L,4L,1L,9L,3L,8L,5L,9L,2L,8L,6L,9L,9L,6L,5L,0L,5L,3L,5L,0L,5L,9L,9L,5L,1L,6L,7L,1L,5L,2L,2L,5L,2L,9L,5L,3L,0L,9L,3L,0L,3L,0L,8L,3L,0L,1L,1L,8L,3L,8L,8L,2L,0L,2L,3L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199277Inst : IEnumerable<long>
{
public static readonly long[] Value=A199277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199277.Bytes);
public long this[int i]=>Value[i];

public static A199277Inst Instance=new A199277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199278
{
public static readonly long[] Value={ 8L,1L,3L,4L,7L,5L,0L,2L,3L,5L,5L,4L,2L,9L,3L,5L,5L,1L,0L,8L,9L,8L,9L,9L,3L,4L,1L,1L,6L,9L,3L,0L,4L,5L,9L,9L,8L,5L,1L,3L,2L,2L,5L,1L,0L,7L,6L,4L,4L,5L,2L,9L,3L,6L,4L,0L,3L,3L,1L,6L,7L,2L,4L,5L,3L,7L,1L,2L,1L,6L,3L,1L,0L,6L,1L,9L,5L,6L,3L,7L,8L,8L,5L,9L,1L,7L,3L,2L,4L,5L,3L,5L,4L,6L,6L,1L,7L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199278Inst : IEnumerable<long>
{
public static readonly long[] Value=A199278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199278.Bytes);
public long this[int i]=>Value[i];

public static A199278Inst Instance=new A199278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199279
{
public static readonly long[] Value={ 7L,1L,6L,5L,5L,0L,3L,8L,3L,9L,0L,6L,1L,7L,8L,2L,0L,2L,3L,9L,2L,3L,8L,8L,0L,3L,0L,1L,8L,3L,5L,5L,1L,3L,5L,8L,0L,8L,2L,7L,4L,0L,2L,7L,3L,3L,1L,9L,5L,4L,2L,4L,7L,5L,3L,8L,0L,7L,3L,4L,7L,0L,9L,9L,7L,2L,4L,7L,7L,5L,8L,3L,4L,8L,7L,4L,5L,5L,3L,6L,0L,6L,5L,1L,6L,7L,2L,6L,6L,9L,3L,5L,5L,4L,1L,7L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199279Inst : IEnumerable<long>
{
public static readonly long[] Value=A199279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199279.Bytes);
public long this[int i]=>Value[i];

public static A199279Inst Instance=new A199279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199280
{
public static readonly long[] Value={ 4L,4L,6L,2L,5L,9L,8L,1L,1L,7L,7L,1L,7L,6L,5L,9L,5L,6L,2L,9L,6L,1L,7L,0L,1L,2L,1L,1L,9L,9L,0L,9L,2L,3L,2L,6L,4L,4L,6L,9L,3L,5L,0L,9L,1L,3L,3L,4L,1L,2L,7L,9L,6L,9L,8L,5L,4L,2L,0L,8L,6L,8L,5L,2L,6L,6L,8L,9L,8L,0L,6L,4L,5L,2L,4L,2L,4L,1L,6L,3L,6L,5L,8L,4L,1L,9L,3L,0L,5L,1L,1L,2L,4L,0L,2L,6L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199280Inst : IEnumerable<long>
{
public static readonly long[] Value=A199280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199280.Bytes);
public long this[int i]=>Value[i];

public static A199280Inst Instance=new A199280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199281
{
public static readonly long[] Value={ 9L,2L,3L,2L,0L,7L,9L,6L,7L,0L,2L,2L,2L,7L,2L,9L,1L,8L,0L,8L,5L,3L,7L,0L,5L,6L,2L,9L,4L,6L,3L,7L,2L,1L,7L,0L,1L,6L,4L,4L,8L,2L,0L,9L,3L,2L,9L,4L,4L,3L,1L,7L,0L,9L,0L,4L,3L,6L,2L,4L,2L,7L,9L,0L,1L,9L,7L,8L,8L,8L,9L,4L,8L,0L,1L,9L,7L,0L,6L,4L,8L,4L,7L,0L,2L,7L,4L,3L,6L,3L,2L,1L,4L,8L,8L,1L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199281Inst : IEnumerable<long>
{
public static readonly long[] Value=A199281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199281.Bytes);
public long this[int i]=>Value[i];

public static A199281Inst Instance=new A199281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199282
{
public static readonly long[] Value={ 6L,9L,8L,8L,0L,5L,3L,5L,1L,4L,9L,4L,5L,8L,2L,6L,3L,7L,8L,9L,0L,7L,2L,5L,1L,1L,9L,2L,0L,9L,6L,7L,4L,0L,3L,9L,3L,2L,8L,2L,9L,9L,9L,9L,4L,1L,5L,5L,1L,8L,0L,8L,2L,6L,4L,3L,7L,3L,2L,6L,0L,9L,0L,6L,5L,1L,6L,4L,7L,6L,2L,9L,2L,7L,0L,4L,1L,9L,7L,3L,2L,8L,4L,0L,9L,9L,8L,7L,0L,3L,8L,8L,6L,6L,7L,0L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199282Inst : IEnumerable<long>
{
public static readonly long[] Value=A199282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199282.Bytes);
public long this[int i]=>Value[i];

public static A199282Inst Instance=new A199282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199283
{
public static readonly long[] Value={ 1L,0L,8L,1L,4L,1L,1L,5L,9L,7L,1L,9L,4L,6L,7L,7L,5L,4L,8L,2L,8L,5L,1L,5L,3L,7L,5L,1L,5L,9L,2L,1L,6L,4L,2L,7L,8L,8L,2L,0L,0L,2L,3L,6L,3L,6L,9L,7L,1L,5L,3L,4L,4L,8L,5L,9L,6L,8L,1L,5L,6L,9L,3L,7L,6L,7L,4L,4L,3L,9L,4L,4L,9L,9L,4L,3L,7L,2L,3L,9L,6L,5L,5L,2L,2L,4L,7L,1L,4L,5L,7L,7L,2L,9L,1L,9L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199283Inst : IEnumerable<long>
{
public static readonly long[] Value=A199283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199283.Bytes);
public long this[int i]=>Value[i];

public static A199283Inst Instance=new A199283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199284
{
public static readonly long[] Value={ 9L,0L,1L,9L,8L,3L,1L,0L,6L,0L,0L,2L,4L,1L,7L,9L,6L,4L,4L,9L,5L,8L,2L,1L,5L,3L,6L,5L,7L,7L,0L,9L,7L,8L,7L,4L,6L,7L,7L,4L,7L,3L,8L,1L,9L,3L,2L,2L,4L,4L,7L,5L,1L,4L,4L,3L,8L,6L,9L,1L,0L,5L,5L,5L,2L,9L,0L,4L,7L,2L,5L,0L,3L,6L,6L,9L,0L,2L,9L,7L,1L,3L,7L,3L,0L,3L,5L,1L,7L,8L,5L,7L,0L,8L,7L,4L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199284Inst : IEnumerable<long>
{
public static readonly long[] Value=A199284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199284.Bytes);
public long this[int i]=>Value[i];

public static A199284Inst Instance=new A199284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199285
{
public static readonly long[] Value={ 8L,4L,0L,9L,1L,4L,7L,0L,0L,0L,5L,5L,4L,7L,4L,4L,9L,2L,7L,0L,4L,3L,9L,9L,0L,2L,0L,0L,5L,3L,6L,1L,5L,8L,5L,2L,6L,0L,0L,0L,4L,1L,6L,9L,9L,7L,9L,6L,6L,6L,6L,3L,6L,6L,1L,0L,3L,4L,0L,7L,3L,0L,2L,2L,8L,3L,3L,6L,6L,1L,0L,3L,6L,4L,8L,3L,6L,3L,1L,4L,4L,7L,0L,9L,7L,0L,2L,2L,4L,8L,0L,8L,0L,7L,1L,2L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199285Inst : IEnumerable<long>
{
public static readonly long[] Value=A199285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199285.Bytes);
public long this[int i]=>Value[i];

public static A199285Inst Instance=new A199285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199286
{
public static readonly long[] Value={ 3L,4L,3L,2L,7L,2L,8L,1L,9L,6L,2L,7L,0L,0L,0L,4L,2L,6L,4L,7L,8L,6L,9L,7L,0L,2L,7L,5L,0L,9L,7L,0L,2L,6L,9L,5L,3L,1L,9L,3L,1L,1L,0L,4L,5L,2L,6L,1L,0L,3L,2L,9L,0L,4L,8L,1L,3L,0L,3L,7L,5L,1L,5L,8L,9L,1L,1L,2L,9L,5L,4L,7L,8L,8L,9L,4L,9L,5L,1L,5L,5L,3L,0L,5L,6L,4L,0L,7L,8L,5L,8L,3L,0L,2L,6L,1L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199286Inst : IEnumerable<long>
{
public static readonly long[] Value=A199286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199286.Bytes);
public long this[int i]=>Value[i];

public static A199286Inst Instance=new A199286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199287
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,9L,2L,7L,3L,8L,8L,7L,2L,2L,8L,9L,4L,3L,4L,0L,7L,4L,6L,5L,4L,2L,6L,8L,7L,2L,4L,3L,6L,8L,8L,1L,7L,3L,5L,1L,2L,9L,8L,6L,4L,9L,6L,2L,2L,0L,0L,1L,0L,3L,0L,3L,5L,6L,2L,5L,9L,1L,0L,5L,4L,6L,4L,8L,4L,0L,6L,6L,2L,0L,0L,5L,4L,2L,3L,2L,6L,8L,8L,3L,6L,1L,6L,4L,6L,3L,4L,4L,6L,7L,8L,3L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199287Inst : IEnumerable<long>
{
public static readonly long[] Value=A199287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199287.Bytes);
public long this[int i]=>Value[i];

public static A199287Inst Instance=new A199287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199288
{
public static readonly long[] Value={ 5L,8L,4L,5L,3L,2L,4L,9L,0L,7L,9L,0L,4L,0L,6L,3L,0L,4L,5L,3L,3L,6L,9L,6L,6L,4L,0L,0L,1L,1L,1L,7L,9L,3L,3L,7L,1L,1L,3L,1L,3L,9L,0L,9L,0L,0L,5L,1L,8L,3L,4L,6L,3L,7L,3L,0L,5L,7L,6L,4L,4L,5L,2L,8L,6L,3L,8L,7L,6L,3L,9L,6L,3L,3L,7L,4L,7L,9L,4L,2L,2L,9L,4L,7L,5L,9L,2L,2L,1L,3L,1L,0L,8L,2L,4L,3L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199288Inst : IEnumerable<long>
{
public static readonly long[] Value=A199288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199288.Bytes);
public long this[int i]=>Value[i];

public static A199288Inst Instance=new A199288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199289
{
public static readonly long[] Value={ 1L,1L,4L,6L,5L,7L,2L,9L,9L,3L,9L,3L,1L,2L,4L,4L,6L,6L,5L,9L,0L,5L,1L,0L,9L,4L,9L,1L,4L,1L,6L,2L,0L,6L,5L,8L,2L,5L,9L,8L,6L,7L,6L,3L,1L,6L,6L,2L,9L,4L,2L,9L,0L,2L,9L,9L,1L,1L,9L,2L,6L,0L,6L,8L,6L,4L,4L,6L,7L,0L,6L,8L,1L,0L,6L,1L,5L,3L,9L,1L,0L,2L,6L,0L,1L,7L,6L,0L,7L,3L,7L,8L,8L,5L,1L,5L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199289Inst : IEnumerable<long>
{
public static readonly long[] Value=A199289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199289.Bytes);
public long this[int i]=>Value[i];

public static A199289Inst Instance=new A199289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199290
{
public static readonly long[] Value={ 7L,9L,3L,1L,0L,7L,1L,6L,5L,1L,2L,2L,0L,9L,2L,0L,1L,3L,0L,8L,4L,6L,9L,6L,6L,9L,8L,6L,7L,1L,6L,6L,6L,8L,9L,3L,8L,6L,3L,1L,0L,9L,4L,6L,7L,3L,5L,4L,9L,4L,7L,5L,9L,1L,6L,0L,7L,6L,9L,0L,7L,5L,2L,1L,1L,6L,4L,6L,1L,1L,1L,6L,3L,3L,2L,0L,6L,2L,4L,6L,3L,0L,5L,5L,8L,8L,2L,3L,7L,3L,3L,0L,5L,2L,0L,0L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199290Inst : IEnumerable<long>
{
public static readonly long[] Value=A199290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199290.Bytes);
public long this[int i]=>Value[i];

public static A199290Inst Instance=new A199290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199291
{
public static readonly long[] Value={ 9L,4L,2L,0L,1L,3L,1L,7L,1L,7L,4L,5L,9L,2L,5L,4L,7L,0L,2L,7L,8L,3L,8L,5L,4L,7L,8L,8L,1L,6L,3L,3L,3L,9L,0L,3L,0L,6L,4L,8L,6L,9L,2L,9L,1L,2L,9L,9L,0L,4L,0L,5L,4L,1L,8L,0L,5L,3L,8L,2L,4L,1L,4L,7L,3L,2L,3L,5L,1L,2L,6L,9L,1L,1L,5L,1L,8L,2L,2L,1L,7L,9L,0L,8L,7L,1L,5L,2L,9L,8L,1L,8L,6L,1L,5L,6L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199291Inst : IEnumerable<long>
{
public static readonly long[] Value=A199291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199291.Bytes);
public long this[int i]=>Value[i];

public static A199291Inst Instance=new A199291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199292
{
public static readonly long[] Value={ 2L,7L,0L,1L,5L,0L,2L,8L,9L,6L,3L,1L,8L,0L,3L,2L,5L,8L,0L,2L,0L,9L,7L,7L,8L,4L,6L,1L,2L,6L,9L,8L,6L,0L,4L,4L,6L,0L,7L,8L,8L,6L,9L,5L,1L,4L,6L,6L,2L,3L,2L,3L,5L,2L,8L,3L,8L,1L,5L,8L,4L,6L,7L,7L,6L,1L,8L,7L,5L,8L,8L,2L,1L,3L,0L,7L,1L,2L,3L,6L,4L,2L,1L,7L,1L,3L,3L,4L,7L,2L,5L,8L,6L,4L,3L,8L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199292Inst : IEnumerable<long>
{
public static readonly long[] Value=A199292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199292.Bytes);
public long this[int i]=>Value[i];

public static A199292Inst Instance=new A199292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199293
{
public static readonly long[] Value={ 1L,0L,8L,3L,5L,1L,1L,6L,6L,1L,0L,2L,1L,9L,2L,8L,9L,8L,8L,3L,3L,0L,4L,7L,4L,9L,1L,0L,3L,8L,2L,1L,2L,5L,5L,8L,3L,1L,2L,5L,4L,1L,8L,9L,2L,0L,1L,6L,8L,0L,8L,4L,8L,2L,7L,8L,3L,4L,5L,3L,7L,5L,8L,7L,4L,4L,4L,2L,9L,2L,4L,6L,1L,7L,9L,3L,3L,4L,3L,9L,2L,9L,5L,4L,0L,9L,0L,6L,8L,6L,8L,0L,9L,5L,1L,7L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199293Inst : IEnumerable<long>
{
public static readonly long[] Value=A199293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199293.Bytes);
public long this[int i]=>Value[i];

public static A199293Inst Instance=new A199293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199294
{
public static readonly long[] Value={ 4L,8L,6L,4L,5L,7L,5L,0L,4L,6L,1L,6L,8L,6L,6L,3L,7L,4L,5L,7L,5L,4L,4L,1L,2L,8L,4L,4L,9L,3L,7L,5L,2L,8L,5L,2L,6L,3L,6L,2L,0L,3L,2L,2L,6L,0L,8L,4L,6L,7L,9L,6L,1L,3L,5L,3L,1L,3L,7L,5L,2L,5L,6L,4L,5L,2L,2L,8L,3L,1L,9L,3L,2L,1L,1L,4L,5L,1L,8L,1L,0L,3L,3L,7L,9L,3L,7L,0L,6L,9L,2L,4L,2L,7L,5L,5L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199294Inst : IEnumerable<long>
{
public static readonly long[] Value=A199294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199294.Bytes);
public long this[int i]=>Value[i];

public static A199294Inst Instance=new A199294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199295
{
public static readonly long[] Value={ 2L,17L,2L,2424833L,2L,769L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199295Inst : IEnumerable<long>
{
public static readonly long[] Value=A199295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199295.Bytes);
public long this[int i]=>Value[i];

public static A199295Inst Instance=new A199295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199296
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,20L,45L,92L,182L,342L,601L,982L,1499L,2169L,2970L,3994L,5297L,6834L,8635L,10714L,13121L,16104L,19674L,23868L,28453L,33637L,39630L,46730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199296Inst : IEnumerable<long>
{
public static readonly long[] Value=A199296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199296.Bytes);
public long this[int i]=>Value[i];

public static A199296Inst Instance=new A199296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199297
{
public static readonly long[] Value={ 1L,3L,13L,59L,257L,1088L,4547L,18906L,78448L,325210L,1347552L,5582415L,23122986L,95771842L,396659584L,1642825239L,6803957409L,28179306468L,116707377067L,483354745392L,2001859113304L,8290886288280L,34337476313478L,142211844759126L,588983541662827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199297Inst : IEnumerable<long>
{
public static readonly long[] Value=A199297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199297.Bytes);
public long this[int i]=>Value[i];

public static A199297Inst Instance=new A199297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199298
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,9L,34L,0L,0L,710L,5564L,0L,0L,703040L,11214400L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199298Inst : IEnumerable<long>
{
public static readonly long[] Value=A199298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199298.Bytes);
public long this[int i]=>Value[i];

public static A199298Inst Instance=new A199298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199299
{
public static readonly long[] Value={ 1L,18L,180L,1512L,11664L,85536L,606528L,4199040L,28553472L,191476224L,1269789696L,8344332288L,54419558400L,352638738432L,2272560758784L,14575734521856L,93096626946048L,592433080565760L,3757718396731392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199299Inst : IEnumerable<long>
{
public static readonly long[] Value=A199299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199299.Bytes);
public long this[int i]=>Value[i];

public static A199299Inst Instance=new A199299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199300
{
public static readonly long[] Value={ 1L,21L,245L,2401L,21609L,184877L,1529437L,12353145L,98001617L,766718533L,5931980229L,45478515089L,346032180025L,2616003280989L,19668469112621L,147174406808233L,1096686708796833L,8142067989552245L,60251303122686613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199300Inst : IEnumerable<long>
{
public static readonly long[] Value=A199300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199300.Bytes);
public long this[int i]=>Value[i];

public static A199300Inst Instance=new A199300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199301
{
public static readonly long[] Value={ 1L,24L,320L,3584L,36864L,360448L,3407872L,31457280L,285212672L,2550136832L,22548578304L,197568495616L,1717986918400L,14843406974976L,127543348822016L,1090715534753792L,9288674231451648L,78812993478983680L,666532744850833408L,5620492334958379008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199301Inst : IEnumerable<long>
{
public static readonly long[] Value=A199301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199301.Bytes);
public long this[int i]=>Value[i];

public static A199301Inst Instance=new A199301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199302
{
public static readonly long[] Value={ 2L,11L,101L,1021L,1201L,110221L,111211L,112111L,120121L,121021L,122011L,1000211L,1010201L,1020101L,1022011L,1022201L,1101211L,1102111L,1102201L,1111021L,1112011L,1120001L,1120121L,1120211L,1121011L,1201021L,1201111L,1210211L,1212121L,1221221L,10002121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199302Inst : IEnumerable<long>
{
public static readonly long[] Value=A199302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199302.Bytes);
public long this[int i]=>Value[i];

public static A199302Inst Instance=new A199302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199303
{
public static readonly long[] Value={ 3L,11L,13L,31L,101L,113L,131L,311L,313L,1031L,1033L,1103L,1301L,3011L,3301L,10301L,10333L,11003L,11311L,13331L,30011L,30103L,31013L,31033L,33013L,33301L,101333L,110311L,113011L,113131L,131311L,133033L,133103L,301331L,301333L,330331L,333101L,333103L,1000033L,1001003L,1001303L,1003001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199303Inst : IEnumerable<long>
{
public static readonly long[] Value=A199303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199303.Bytes);
public long this[int i]=>Value[i];

public static A199303Inst Instance=new A199303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199304
{
public static readonly long[] Value={ 11L,101L,11411L,100411L,101141L,114001L,114041L,140411L,141101L,1004141L,1010411L,1040141L,1041041L,1100441L,1114111L,1140101L,1144441L,1401401L,1410401L,1411141L,1414001L,1440011L,1444411L,1444441L,10010411L,10011101L,10041011L,10044011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199304Inst : IEnumerable<long>
{
public static readonly long[] Value=A199304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199304.Bytes);
public long this[int i]=>Value[i];

public static A199304Inst Instance=new A199304Inst();

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