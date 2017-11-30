using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199405
{
public static readonly long[] Value={ 1L,14L,25L,155L,274L,1691L,2989L,18446L,32605L,201215L,355666L,2194919L,3879721L,23942894L,42321265L,261176915L,461654194L,2849003171L,5035874869L,31077857966L,54932969365L,339007434455L,599226788146L,3698003921039L,6536561700241L,40339035696974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199405Inst : IEnumerable<long>
{
public static readonly long[] Value=A199405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199405.Bytes);
public long this[int i]=>Value[i];

public static A199405Inst Instance=new A199405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199406
{
public static readonly long[] Value={ 1L,144L,12111L,358120L,5131650L,45528756L,288936634L,1433251296L,5887880415L,20842168600L,65402344161L,185788177224L,485443851256L,1181242399260L,2703252560100L,5864398969216L,12138503871789L,24101498435616L,46112016365155L,85335258695400L,153249227870046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199406Inst : IEnumerable<long>
{
public static readonly long[] Value=A199406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199406.Bytes);
public long this[int i]=>Value[i];

public static A199406Inst Instance=new A199406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199407
{
public static readonly long[] Value={ 3L,5L,9L,11L,15L,21L,23L,29L,33L,35L,39L,45L,51L,114L,183L,243L,4895L,5247L,9588L,12188L,48503L,48504L,89175L,179328L,290783L,4604093L,4775623L,7778968L,13711516L,56075700L,104257956L,165309438L,1913253201L,9905967078L,17096261103L,121153257533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199407Inst : IEnumerable<long>
{
public static readonly long[] Value=A199407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199407.Bytes);
public long this[int i]=>Value[i];

public static A199407Inst Instance=new A199407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199408
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,4L,6L,4L,5L,6L,7L,8L,5L,6L,6L,6L,8L,10L,6L,7L,8L,9L,10L,11L,12L,7L,8L,8L,10L,8L,12L,12L,14L,8L,9L,10L,9L,12L,13L,12L,15L,16L,9L,10L,10L,12L,12L,10L,14L,16L,16L,18L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,11L,12L,12L,12L,12L,16L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199408Inst : IEnumerable<long>
{
public static readonly long[] Value=A199408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199408.Bytes);
public long this[int i]=>Value[i];

public static A199408Inst Instance=new A199408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199409
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,37L,82L,184L,417L,954L,2200L,5109L,11937L,28040L,66179L,156857L,373205L,891034L,2134072L,5125944L,12344835L,29802478L,72109852L,174839832L,424742526L,1033697149L,2519947080L,6152807700L,15045156972L,36840289213L,90326900587L,221741403579L,544982530105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199409Inst : IEnumerable<long>
{
public static readonly long[] Value=A199409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199409.Bytes);
public long this[int i]=>Value[i];

public static A199409Inst Instance=new A199409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199410
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,50L,122L,303L,763L,1943L,4996L,12953L,33824L,88877L,234824L,623474L,1662618L,4451171L,11959159L,32235236L,87145035L,236226761L,641942519L,1748479813L,4772529625L,13052515077L,35763350619L,98158386548L,269844628977L,742940020480L,2048366903124L,5655092015428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199410Inst : IEnumerable<long>
{
public static readonly long[] Value=A199410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199410.Bytes);
public long this[int i]=>Value[i];

public static A199410Inst Instance=new A199410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199411
{
public static readonly long[] Value={ 9L,49L,289L,1729L,10369L,62209L,373249L,2239489L,13436929L,80621569L,483729409L,2902376449L,17414258689L,104485552129L,626913312769L,3761479876609L,22568879259649L,135413275557889L,812479653347329L,4874877920083969L,29249267520503809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199411Inst : IEnumerable<long>
{
public static readonly long[] Value=A199411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199411.Bytes);
public long this[int i]=>Value[i];

public static A199411Inst Instance=new A199411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199412
{
public static readonly long[] Value={ 2L,11L,65L,389L,2333L,13997L,83981L,503885L,3023309L,18139853L,108839117L,653034701L,3918208205L,23509249229L,141055495373L,846332972237L,5077997833421L,30467987000525L,182807922003149L,1096847532018893L,6581085192113357L,39486511152680141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199412Inst : IEnumerable<long>
{
public static readonly long[] Value=A199412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199412.Bytes);
public long this[int i]=>Value[i];

public static A199412Inst Instance=new A199412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199413
{
public static readonly long[] Value={ 10L,55L,325L,1945L,11665L,69985L,419905L,2519425L,15116545L,90699265L,544195585L,3265173505L,19591041025L,117546246145L,705277476865L,4231664861185L,25389989167105L,152339935002625L,914039610015745L,5484237660094465L,32905425960566785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199413Inst : IEnumerable<long>
{
public static readonly long[] Value=A199413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199413.Bytes);
public long this[int i]=>Value[i];

public static A199413Inst Instance=new A199413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199414
{
public static readonly long[] Value={ 11L,61L,361L,2161L,12961L,77761L,466561L,2799361L,16796161L,100776961L,604661761L,3627970561L,21767823361L,130606940161L,783641640961L,4701849845761L,28211099074561L,169266594447361L,1015599566684161L,6093597400104961L,36561584400629761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199414Inst : IEnumerable<long>
{
public static readonly long[] Value=A199414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199414.Bytes);
public long this[int i]=>Value[i];

public static A199414Inst Instance=new A199414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199415
{
public static readonly long[] Value={ 12L,67L,397L,2377L,14257L,85537L,513217L,3079297L,18475777L,110854657L,665127937L,3990767617L,23944605697L,143667634177L,862005805057L,5172034830337L,31032208982017L,186193253892097L,1117159523352577L,6702957140115457L,40217742840692737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199415Inst : IEnumerable<long>
{
public static readonly long[] Value=A199415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199415.Bytes);
public long this[int i]=>Value[i];

public static A199415Inst Instance=new A199415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199416
{
public static readonly long[] Value={ 3L,15L,99L,687L,4803L,33615L,235299L,1647087L,11529603L,80707215L,564950499L,3954653487L,27682574403L,193778020815L,1356446145699L,9495123019887L,66465861139203L,465261027974415L,3256827195820899L,22797790370746287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199416Inst : IEnumerable<long>
{
public static readonly long[] Value=A199416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199416.Bytes);
public long this[int i]=>Value[i];

public static A199416Inst Instance=new A199416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199417
{
public static readonly long[] Value={ 2L,11L,74L,515L,3602L,25211L,176474L,1235315L,8647202L,60530411L,423712874L,2965990115L,20761930802L,145333515611L,1017334609274L,7121342264915L,49849395854402L,348945770980811L,2442620396865674L,17098342778059715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199417Inst : IEnumerable<long>
{
public static readonly long[] Value=A199417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199417.Bytes);
public long this[int i]=>Value[i];

public static A199417Inst Instance=new A199417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199418
{
public static readonly long[] Value={ 4L,22L,148L,1030L,7204L,50422L,352948L,2470630L,17294404L,121060822L,847425748L,5931980230L,41523861604L,290667031222L,2034669218548L,14242684529830L,99698791708804L,697891541961622L,4885240793731348L,34196685556119430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199418Inst : IEnumerable<long>
{
public static readonly long[] Value=A199418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199418.Bytes);
public long this[int i]=>Value[i];

public static A199418Inst Instance=new A199418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199419
{
public static readonly long[] Value={ 5L,29L,197L,1373L,9605L,67229L,470597L,3294173L,23059205L,161414429L,1129900997L,7909306973L,55365148805L,387556041629L,2712892291397L,18990246039773L,132931722278405L,930522055948829L,6513654391641797L,45595580741492573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199419Inst : IEnumerable<long>
{
public static readonly long[] Value=A199419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199419.Bytes);
public long this[int i]=>Value[i];

public static A199419Inst Instance=new A199419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199420
{
public static readonly long[] Value={ 2L,12L,82L,572L,4002L,28012L,196082L,1372572L,9608002L,67256012L,470792082L,3295544572L,23068812002L,161481684012L,1130371788082L,7912602516572L,55388217616002L,387717523312012L,2714022663184082L,18998158642288572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199420Inst : IEnumerable<long>
{
public static readonly long[] Value=A199420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199420.Bytes);
public long this[int i]=>Value[i];

public static A199420Inst Instance=new A199420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199421
{
public static readonly long[] Value={ 3L,18L,123L,858L,6003L,42018L,294123L,2058858L,14412003L,100884018L,706188123L,4943316858L,34603218003L,242222526018L,1695557682123L,11868903774858L,83082326424003L,581576284968018L,4071033994776123L,28497237963432858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199421Inst : IEnumerable<long>
{
public static readonly long[] Value=A199421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199421.Bytes);
public long this[int i]=>Value[i];

public static A199421Inst Instance=new A199421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199422
{
public static readonly long[] Value={ 6L,36L,246L,1716L,12006L,84036L,588246L,4117716L,28824006L,201768036L,1412376246L,9886633716L,69206436006L,484445052036L,3391115364246L,23737807549716L,166164652848006L,1163152569936036L,8142067989552246L,56994475926865716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199422Inst : IEnumerable<long>
{
public static readonly long[] Value=A199422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199422.Bytes);
public long this[int i]=>Value[i];

public static A199422Inst Instance=new A199422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199423
{
public static readonly long[] Value={ 3L,5L,7L,3L,11L,13L,7L,17L,19L,7L,23L,5L,13L,29L,31L,11L,17L,37L,19L,41L,43L,11L,47L,7L,17L,53L,11L,19L,59L,61L,31L,13L,67L,23L,71L,73L,37L,19L,79L,5L,83L,17L,43L,89L,13L,31L,47L,97L,11L,101L,103L,13L,107L,109L,37L,113L,23L,29L,59L,11L,61L,31L,127L,43L,131L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199423Inst : IEnumerable<long>
{
public static readonly long[] Value=A199423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199423.Bytes);
public long this[int i]=>Value[i];

public static A199423Inst Instance=new A199423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199424
{
public static readonly long[] Value={ 2L,3L,4L,4L,6L,5L,8L,9L,6L,6L,12L,7L,14L,15L,16L,7L,18L,19L,20L,9L,22L,23L,24L,25L,8L,27L,28L,8L,30L,31L,11L,33L,34L,35L,36L,9L,12L,39L,40L,41L,42L,43L,13L,45L,46L,47L,9L,10L,50L,14L,52L,53L,54L,55L,56L,57L,58L,15L,60L,61L,62L,63L,64L,65L,66L,16L,11L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199424Inst : IEnumerable<long>
{
public static readonly long[] Value=A199424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199424.Bytes);
public long this[int i]=>Value[i];

public static A199424Inst Instance=new A199424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199425
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,5L,8L,10L,13L,17L,20L,24L,30L,35L,42L,49L,57L,63L,71L,80L,90L,99L,110L,121L,133L,145L,157L,170L,184L,197L,212L,227L,242L,258L,275L,292L,310L,327L,345L,364L,384L,404L,425L,446L,467L,489L,512L,535L,558L,581L,606L,630L,656L,682L,709L,736L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199425Inst : IEnumerable<long>
{
public static readonly long[] Value=A199425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199425.Bytes);
public long this[int i]=>Value[i];

public static A199425Inst Instance=new A199425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199426
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,9L,8L,11L,12L,13L,14L,15L,18L,17L,16L,19L,20L,21L,22L,23L,24L,25L,30L,29L,28L,27L,26L,31L,32L,33L,36L,35L,34L,37L,38L,39L,40L,41L,42L,43L,48L,47L,46L,45L,44L,49L,50L,51L,54L,53L,52L,55L,56L,57L,58L,59L,60L,61L,62L,63L,70L,69L,68L,67L,66L,65L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199426Inst : IEnumerable<long>
{
public static readonly long[] Value=A199426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199426.Bytes);
public long this[int i]=>Value[i];

public static A199426Inst Instance=new A199426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199427
{
public static readonly long[] Value={ 1L,7L,10L,13L,22L,28L,43L,58L,70L,73L,127L,148L,160L,163L,190L,202L,238L,253L,262L,307L,322L,352L,370L,400L,433L,472L,475L,493L,517L,532L,535L,568L,598L,637L,673L,685L,688L,742L,832L,847L,853L,862L,898L,940L,955L,1018L,1087L,1093L,1102L,1120L,1183L,1198L,1270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199427Inst : IEnumerable<long>
{
public static readonly long[] Value=A199427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199427.Bytes);
public long this[int i]=>Value[i];

public static A199427Inst Instance=new A199427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199428
{
public static readonly long[] Value={ 40144044691L,58058453543L,89797181359L,185113489357L,213022025663L,222498988079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199428Inst : IEnumerable<long>
{
public static readonly long[] Value=A199428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199428.Bytes);
public long this[int i]=>Value[i];

public static A199428Inst Instance=new A199428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199429
{
public static readonly long[] Value={ 6L,4L,3L,4L,3L,6L,3L,6L,4L,1L,3L,8L,0L,2L,6L,1L,5L,8L,6L,4L,2L,0L,9L,8L,9L,1L,4L,3L,0L,4L,0L,1L,3L,1L,8L,2L,6L,8L,7L,4L,4L,6L,7L,2L,4L,1L,9L,4L,5L,7L,8L,5L,1L,6L,3L,2L,3L,8L,7L,4L,9L,1L,9L,8L,5L,8L,8L,7L,5L,2L,2L,9L,2L,2L,2L,7L,2L,5L,9L,4L,1L,7L,6L,4L,1L,7L,8L,8L,8L,7L,0L,7L,8L,5L,2L,7L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199429Inst : IEnumerable<long>
{
public static readonly long[] Value=A199429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199429.Bytes);
public long this[int i]=>Value[i];

public static A199429Inst Instance=new A199429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199430
{
public static readonly long[] Value={ 8L,4L,0L,8L,5L,4L,5L,9L,1L,7L,1L,7L,3L,3L,2L,8L,3L,4L,5L,4L,4L,0L,8L,8L,1L,0L,8L,4L,9L,9L,8L,3L,6L,3L,3L,2L,7L,1L,4L,6L,7L,7L,0L,4L,4L,2L,2L,4L,1L,4L,9L,1L,2L,8L,3L,0L,8L,5L,4L,5L,0L,1L,9L,1L,4L,0L,6L,9L,5L,5L,9L,6L,1L,8L,0L,7L,7L,1L,7L,8L,4L,3L,4L,2L,2L,6L,1L,1L,6L,7L,5L,2L,1L,3L,2L,4L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199430Inst : IEnumerable<long>
{
public static readonly long[] Value=A199430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199430.Bytes);
public long this[int i]=>Value[i];

public static A199430Inst Instance=new A199430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199431
{
public static readonly long[] Value={ 9L,6L,2L,1L,7L,9L,5L,0L,5L,1L,0L,9L,3L,2L,7L,0L,9L,1L,3L,6L,7L,2L,6L,2L,7L,5L,4L,4L,1L,0L,8L,5L,1L,4L,7L,3L,3L,2L,1L,7L,9L,1L,7L,9L,2L,7L,5L,3L,1L,4L,6L,2L,3L,2L,0L,8L,9L,1L,7L,3L,6L,1L,0L,9L,6L,5L,9L,2L,9L,2L,6L,7L,6L,7L,3L,3L,9L,1L,6L,4L,7L,0L,7L,2L,3L,6L,8L,1L,3L,5L,7L,6L,6L,0L,3L,4L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199431Inst : IEnumerable<long>
{
public static readonly long[] Value=A199431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199431.Bytes);
public long this[int i]=>Value[i];

public static A199431Inst Instance=new A199431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199432
{
public static readonly long[] Value={ 5L,4L,3L,0L,4L,7L,6L,2L,4L,4L,0L,7L,4L,0L,1L,0L,3L,7L,9L,6L,0L,7L,3L,5L,5L,9L,0L,1L,4L,3L,7L,6L,5L,2L,9L,5L,6L,0L,7L,0L,7L,4L,5L,4L,3L,6L,8L,2L,9L,8L,9L,9L,8L,0L,8L,1L,3L,6L,3L,3L,6L,4L,1L,0L,3L,9L,8L,4L,8L,2L,0L,5L,8L,1L,0L,2L,1L,9L,5L,6L,8L,7L,9L,5L,4L,5L,8L,4L,9L,5L,2L,0L,3L,1L,5L,2L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199432Inst : IEnumerable<long>
{
public static readonly long[] Value=A199432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199432.Bytes);
public long this[int i]=>Value[i];

public static A199432Inst Instance=new A199432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199433
{
public static readonly long[] Value={ 7L,2L,6L,8L,9L,2L,4L,0L,7L,8L,5L,4L,3L,3L,6L,1L,9L,4L,4L,6L,0L,0L,2L,4L,4L,2L,9L,5L,3L,5L,9L,5L,5L,4L,1L,6L,7L,1L,9L,6L,6L,2L,1L,6L,2L,2L,0L,9L,2L,1L,9L,2L,4L,4L,9L,3L,6L,0L,6L,5L,3L,8L,0L,7L,7L,8L,3L,9L,8L,5L,4L,9L,1L,8L,8L,7L,6L,5L,2L,9L,7L,9L,1L,8L,1L,5L,7L,2L,9L,8L,1L,4L,5L,9L,1L,1L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199433Inst : IEnumerable<long>
{
public static readonly long[] Value=A199433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199433.Bytes);
public long this[int i]=>Value[i];

public static A199433Inst Instance=new A199433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199434
{
public static readonly long[] Value={ 8L,4L,6L,9L,9L,7L,5L,3L,0L,0L,4L,5L,2L,4L,5L,5L,8L,9L,4L,0L,0L,8L,1L,0L,6L,3L,7L,5L,7L,0L,2L,2L,8L,6L,7L,9L,5L,2L,5L,1L,7L,8L,6L,7L,7L,4L,2L,8L,1L,1L,7L,7L,3L,5L,3L,1L,0L,2L,2L,1L,4L,9L,1L,7L,2L,9L,1L,9L,7L,2L,9L,1L,9L,6L,2L,6L,5L,0L,3L,5L,1L,8L,5L,4L,7L,1L,9L,9L,4L,4L,4L,2L,9L,3L,5L,3L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199434Inst : IEnumerable<long>
{
public static readonly long[] Value=A199434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199434.Bytes);
public long this[int i]=>Value[i];

public static A199434Inst Instance=new A199434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199435
{
public static readonly long[] Value={ 4L,7L,7L,9L,4L,7L,5L,5L,4L,1L,2L,1L,6L,8L,7L,3L,5L,6L,5L,1L,9L,7L,2L,3L,3L,4L,5L,9L,4L,0L,4L,1L,4L,5L,3L,0L,7L,3L,8L,9L,7L,9L,5L,8L,2L,3L,4L,9L,4L,4L,2L,7L,6L,5L,2L,2L,0L,6L,4L,1L,4L,3L,8L,0L,0L,6L,5L,8L,9L,7L,3L,8L,7L,1L,7L,2L,3L,1L,9L,7L,8L,3L,0L,5L,1L,3L,0L,5L,2L,4L,2L,6L,6L,3L,6L,2L,4L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199435Inst : IEnumerable<long>
{
public static readonly long[] Value=A199435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199435.Bytes);
public long this[int i]=>Value[i];

public static A199435Inst Instance=new A199435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199436
{
public static readonly long[] Value={ 6L,4L,8L,2L,2L,1L,0L,3L,5L,8L,8L,3L,4L,3L,2L,4L,1L,0L,9L,8L,1L,7L,3L,0L,3L,9L,3L,9L,2L,1L,2L,7L,8L,5L,4L,3L,0L,6L,0L,1L,9L,0L,7L,2L,8L,5L,5L,2L,6L,9L,3L,0L,4L,4L,6L,3L,8L,9L,3L,4L,9L,2L,8L,4L,9L,8L,8L,4L,0L,7L,4L,9L,7L,7L,4L,6L,5L,1L,3L,1L,6L,8L,3L,3L,7L,6L,2L,7L,4L,9L,3L,8L,7L,2L,7L,0L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199436Inst : IEnumerable<long>
{
public static readonly long[] Value=A199436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199436.Bytes);
public long this[int i]=>Value[i];

public static A199436Inst Instance=new A199436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199437
{
public static readonly long[] Value={ 7L,6L,3L,5L,7L,5L,4L,4L,7L,3L,0L,8L,3L,7L,7L,0L,5L,4L,7L,7L,9L,3L,3L,8L,9L,0L,7L,5L,5L,9L,2L,8L,4L,4L,3L,4L,1L,0L,5L,1L,9L,0L,3L,6L,2L,8L,0L,6L,7L,1L,1L,5L,4L,4L,4L,5L,8L,7L,1L,1L,6L,3L,1L,2L,9L,9L,3L,1L,2L,1L,8L,0L,0L,5L,0L,0L,6L,8L,3L,0L,1L,0L,8L,1L,2L,9L,9L,9L,8L,7L,4L,3L,6L,7L,0L,1L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199437Inst : IEnumerable<long>
{
public static readonly long[] Value=A199437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199437.Bytes);
public long this[int i]=>Value[i];

public static A199437Inst Instance=new A199437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199438
{
public static readonly long[] Value={ 5L,3L,9L,1L,4L,3L,6L,0L,7L,0L,3L,1L,4L,0L,4L,1L,0L,6L,4L,8L,7L,9L,4L,6L,0L,7L,0L,9L,9L,5L,5L,2L,3L,7L,2L,1L,2L,7L,0L,6L,0L,6L,8L,1L,4L,6L,9L,8L,9L,7L,5L,3L,8L,4L,0L,5L,8L,1L,4L,4L,5L,3L,7L,7L,4L,9L,3L,8L,0L,5L,3L,0L,3L,9L,4L,5L,6L,7L,7L,4L,0L,0L,7L,3L,5L,7L,8L,1L,4L,2L,0L,5L,3L,3L,4L,9L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199438Inst : IEnumerable<long>
{
public static readonly long[] Value=A199438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199438.Bytes);
public long this[int i]=>Value[i];

public static A199438Inst Instance=new A199438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199439
{
public static readonly long[] Value={ 7L,1L,8L,5L,2L,7L,1L,4L,8L,7L,1L,1L,1L,8L,8L,8L,2L,1L,1L,4L,5L,3L,1L,2L,5L,7L,9L,7L,1L,8L,2L,6L,8L,8L,4L,7L,6L,3L,1L,0L,1L,6L,9L,4L,2L,9L,3L,9L,1L,3L,0L,8L,5L,1L,0L,4L,8L,5L,2L,5L,6L,4L,0L,5L,7L,1L,5L,5L,6L,0L,6L,3L,8L,0L,0L,9L,5L,5L,5L,5L,9L,1L,5L,1L,2L,3L,8L,8L,4L,6L,9L,0L,7L,1L,0L,9L,5L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199439Inst : IEnumerable<long>
{
public static readonly long[] Value=A199439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199439.Bytes);
public long this[int i]=>Value[i];

public static A199439Inst Instance=new A199439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199440
{
public static readonly long[] Value={ 8L,3L,5L,0L,1L,4L,6L,3L,2L,3L,2L,3L,7L,3L,2L,8L,8L,8L,3L,8L,6L,2L,0L,6L,1L,1L,2L,3L,1L,6L,9L,7L,4L,4L,2L,1L,8L,5L,3L,4L,3L,5L,9L,0L,1L,0L,7L,3L,3L,8L,3L,2L,1L,8L,0L,9L,7L,2L,5L,0L,1L,0L,3L,1L,8L,9L,3L,2L,9L,4L,0L,0L,1L,3L,3L,6L,0L,9L,5L,6L,6L,3L,5L,6L,8L,9L,4L,6L,6L,1L,4L,6L,7L,9L,2L,1L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199440Inst : IEnumerable<long>
{
public static readonly long[] Value=A199440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199440.Bytes);
public long this[int i]=>Value[i];

public static A199440Inst Instance=new A199440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199441
{
public static readonly long[] Value={ 4L,7L,5L,8L,6L,6L,7L,2L,9L,0L,6L,6L,6L,2L,1L,5L,0L,2L,4L,7L,2L,6L,1L,5L,9L,3L,5L,6L,1L,9L,9L,6L,7L,8L,8L,9L,6L,8L,0L,2L,4L,4L,2L,6L,3L,8L,8L,7L,0L,0L,4L,2L,3L,3L,5L,0L,8L,3L,9L,5L,3L,4L,2L,6L,5L,5L,1L,3L,6L,2L,4L,0L,7L,5L,2L,8L,5L,1L,4L,0L,3L,7L,9L,4L,5L,4L,5L,3L,1L,3L,0L,6L,4L,7L,2L,6L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199441Inst : IEnumerable<long>
{
public static readonly long[] Value=A199441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199441.Bytes);
public long this[int i]=>Value[i];

public static A199441Inst Instance=new A199441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199442
{
public static readonly long[] Value={ 7L,5L,6L,3L,2L,1L,4L,3L,2L,0L,9L,5L,2L,5L,4L,7L,4L,4L,3L,7L,8L,7L,9L,7L,4L,2L,5L,2L,5L,0L,7L,5L,4L,2L,5L,4L,9L,5L,3L,9L,8L,0L,4L,4L,8L,3L,7L,6L,1L,6L,3L,1L,2L,5L,4L,6L,4L,8L,6L,0L,0L,5L,0L,0L,8L,1L,7L,4L,1L,7L,7L,2L,2L,0L,3L,0L,1L,6L,9L,9L,9L,8L,4L,2L,9L,2L,7L,4L,2L,5L,0L,0L,5L,3L,6L,1L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199442Inst : IEnumerable<long>
{
public static readonly long[] Value=A199442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199442.Bytes);
public long this[int i]=>Value[i];

public static A199442Inst Instance=new A199442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199443
{
public static readonly long[] Value={ 4L,3L,0L,3L,0L,7L,4L,4L,1L,9L,2L,1L,5L,3L,5L,2L,9L,7L,9L,2L,1L,6L,4L,5L,9L,0L,1L,9L,0L,4L,2L,7L,5L,9L,0L,4L,5L,0L,1L,3L,7L,8L,7L,7L,7L,3L,6L,0L,7L,0L,8L,5L,0L,2L,8L,9L,8L,9L,6L,3L,5L,9L,6L,2L,9L,6L,3L,7L,0L,1L,6L,3L,0L,0L,9L,0L,4L,2L,3L,8L,5L,7L,6L,1L,4L,2L,2L,2L,2L,4L,1L,0L,0L,1L,5L,5L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199443Inst : IEnumerable<long>
{
public static readonly long[] Value=A199443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199443.Bytes);
public long this[int i]=>Value[i];

public static A199443Inst Instance=new A199443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199444
{
public static readonly long[] Value={ 5L,8L,7L,1L,0L,8L,8L,2L,9L,4L,7L,9L,1L,6L,5L,5L,3L,0L,5L,6L,0L,6L,1L,9L,9L,2L,5L,3L,0L,3L,2L,0L,0L,3L,5L,5L,8L,1L,1L,5L,8L,5L,2L,3L,3L,6L,9L,5L,9L,3L,2L,8L,8L,8L,3L,0L,8L,9L,7L,5L,8L,8L,4L,3L,9L,1L,3L,1L,8L,9L,8L,2L,0L,2L,9L,7L,1L,0L,2L,9L,6L,9L,9L,6L,6L,2L,0L,4L,7L,9L,2L,3L,6L,0L,2L,9L,9L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199444Inst : IEnumerable<long>
{
public static readonly long[] Value=A199444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199444.Bytes);
public long this[int i]=>Value[i];

public static A199444Inst Instance=new A199444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199445
{
public static readonly long[] Value={ 6L,9L,5L,3L,5L,3L,4L,7L,3L,9L,9L,3L,8L,2L,9L,9L,4L,0L,1L,2L,0L,3L,8L,1L,3L,8L,5L,2L,4L,6L,4L,8L,8L,6L,1L,9L,3L,2L,8L,9L,2L,6L,7L,7L,1L,6L,8L,1L,8L,4L,6L,9L,4L,6L,1L,2L,9L,3L,2L,9L,7L,7L,9L,6L,6L,6L,2L,5L,2L,9L,3L,7L,6L,5L,8L,5L,1L,6L,6L,9L,6L,1L,8L,0L,6L,1L,9L,2L,6L,4L,7L,0L,0L,7L,1L,0L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199445Inst : IEnumerable<long>
{
public static readonly long[] Value=A199445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199445.Bytes);
public long this[int i]=>Value[i];

public static A199445Inst Instance=new A199445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199446
{
public static readonly long[] Value={ 4L,7L,3L,8L,4L,7L,9L,7L,1L,2L,6L,3L,7L,7L,7L,4L,3L,0L,9L,9L,9L,8L,0L,1L,5L,8L,7L,1L,1L,4L,4L,2L,5L,9L,8L,5L,9L,1L,1L,6L,7L,1L,8L,0L,1L,2L,0L,4L,5L,3L,1L,8L,9L,1L,0L,6L,3L,0L,9L,0L,7L,5L,6L,5L,3L,7L,7L,8L,9L,0L,7L,4L,6L,2L,3L,3L,8L,7L,8L,0L,8L,9L,0L,8L,2L,9L,1L,7L,4L,3L,0L,2L,8L,8L,7L,9L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199446Inst : IEnumerable<long>
{
public static readonly long[] Value=A199446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199446.Bytes);
public long this[int i]=>Value[i];

public static A199446Inst Instance=new A199446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199447
{
public static readonly long[] Value={ 6L,3L,8L,8L,9L,0L,3L,0L,3L,9L,5L,0L,9L,5L,0L,8L,0L,9L,1L,6L,4L,7L,9L,2L,9L,1L,3L,6L,6L,3L,0L,6L,3L,4L,3L,6L,9L,0L,5L,9L,3L,9L,2L,3L,0L,0L,6L,9L,9L,8L,6L,1L,7L,0L,6L,8L,2L,8L,4L,0L,4L,4L,3L,9L,0L,8L,5L,1L,5L,8L,5L,4L,8L,0L,4L,3L,6L,7L,2L,4L,3L,8L,6L,4L,8L,3L,1L,5L,1L,4L,6L,7L,8L,6L,7L,0L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199447Inst : IEnumerable<long>
{
public static readonly long[] Value=A199447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199447.Bytes);
public long this[int i]=>Value[i];

public static A199447Inst Instance=new A199447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199448
{
public static readonly long[] Value={ 7L,4L,9L,5L,2L,8L,8L,3L,2L,5L,0L,9L,1L,1L,5L,4L,7L,8L,6L,4L,9L,5L,3L,7L,8L,3L,1L,0L,3L,3L,4L,6L,3L,1L,7L,1L,3L,6L,5L,2L,4L,9L,8L,5L,0L,3L,1L,1L,3L,0L,4L,2L,5L,7L,6L,8L,4L,2L,6L,4L,2L,7L,0L,0L,4L,6L,5L,2L,3L,5L,5L,0L,0L,5L,3L,2L,7L,0L,3L,9L,9L,2L,0L,8L,6L,6L,1L,6L,5L,7L,0L,7L,0L,3L,7L,6L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199448Inst : IEnumerable<long>
{
public static readonly long[] Value=A199448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199448.Bytes);
public long this[int i]=>Value[i];

public static A199448Inst Instance=new A199448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199449
{
public static readonly long[] Value={ 4L,2L,9L,0L,7L,9L,1L,0L,6L,0L,8L,7L,8L,3L,9L,2L,4L,1L,1L,8L,7L,9L,9L,4L,9L,9L,5L,0L,7L,0L,2L,2L,0L,1L,7L,4L,7L,0L,2L,3L,1L,8L,6L,4L,2L,1L,7L,4L,4L,6L,4L,3L,2L,1L,6L,4L,7L,4L,8L,7L,5L,3L,4L,6L,1L,9L,6L,5L,0L,4L,0L,8L,3L,3L,2L,8L,4L,8L,9L,7L,7L,1L,7L,7L,9L,3L,6L,3L,6L,5L,5L,8L,9L,1L,2L,9L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199449Inst : IEnumerable<long>
{
public static readonly long[] Value=A199449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199449.Bytes);
public long this[int i]=>Value[i];

public static A199449Inst Instance=new A199449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199450
{
public static readonly long[] Value={ 5L,8L,4L,2L,0L,4L,1L,8L,3L,7L,6L,3L,3L,2L,1L,1L,3L,9L,9L,0L,6L,5L,5L,9L,3L,7L,9L,9L,7L,4L,7L,1L,2L,6L,8L,1L,4L,8L,0L,4L,2L,0L,6L,1L,0L,9L,6L,9L,9L,9L,8L,8L,8L,6L,3L,9L,4L,0L,9L,4L,5L,9L,0L,8L,3L,3L,8L,4L,6L,3L,9L,4L,8L,7L,2L,4L,4L,0L,2L,6L,8L,3L,1L,6L,8L,1L,7L,8L,2L,0L,9L,2L,5L,4L,9L,5L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199450Inst : IEnumerable<long>
{
public static readonly long[] Value=A199450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199450.Bytes);
public long this[int i]=>Value[i];

public static A199450Inst Instance=new A199450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199451
{
public static readonly long[] Value={ 6L,9L,0L,8L,3L,6L,1L,8L,1L,2L,0L,5L,4L,2L,6L,4L,8L,1L,3L,6L,8L,3L,7L,1L,5L,5L,8L,7L,3L,1L,9L,7L,3L,1L,2L,7L,4L,9L,6L,3L,1L,7L,6L,2L,9L,0L,5L,1L,7L,7L,2L,6L,9L,6L,9L,9L,9L,9L,2L,6L,6L,9L,0L,0L,6L,5L,4L,7L,4L,7L,4L,8L,3L,7L,0L,3L,4L,7L,7L,9L,3L,0L,9L,1L,1L,6L,8L,6L,1L,4L,0L,5L,0L,8L,2L,7L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199451Inst : IEnumerable<long>
{
public static readonly long[] Value=A199451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199451.Bytes);
public long this[int i]=>Value[i];

public static A199451Inst Instance=new A199451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199452
{
public static readonly long[] Value={ 3L,9L,4L,7L,8L,4L,8L,4L,4L,9L,4L,1L,2L,8L,5L,9L,9L,7L,8L,1L,5L,2L,7L,3L,5L,3L,6L,2L,8L,9L,9L,5L,7L,0L,2L,5L,5L,3L,4L,7L,1L,7L,2L,2L,1L,1L,6L,4L,9L,7L,3L,5L,0L,5L,2L,6L,6L,8L,5L,5L,6L,4L,1L,3L,7L,6L,8L,4L,4L,6L,5L,8L,6L,5L,5L,8L,9L,7L,3L,3L,3L,9L,0L,7L,3L,6L,7L,8L,6L,9L,9L,1L,4L,1L,7L,4L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199452Inst : IEnumerable<long>
{
public static readonly long[] Value=A199452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199452.Bytes);
public long this[int i]=>Value[i];

public static A199452Inst Instance=new A199452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199453
{
public static readonly long[] Value={ 5L,4L,1L,0L,7L,0L,8L,3L,0L,7L,2L,2L,7L,3L,2L,2L,4L,3L,2L,7L,3L,6L,4L,5L,7L,3L,9L,1L,0L,9L,5L,1L,7L,7L,2L,9L,9L,2L,7L,9L,0L,2L,7L,8L,5L,3L,7L,8L,9L,3L,0L,7L,7L,8L,6L,2L,0L,3L,7L,6L,2L,3L,2L,0L,6L,0L,7L,7L,0L,4L,4L,8L,6L,7L,9L,0L,1L,2L,5L,4L,9L,1L,3L,9L,6L,1L,9L,8L,4L,5L,5L,8L,5L,1L,3L,6L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199453Inst : IEnumerable<long>
{
public static readonly long[] Value=A199453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199453.Bytes);
public long this[int i]=>Value[i];

public static A199453Inst Instance=new A199453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199454
{
public static readonly long[] Value={ 1L,2L,2L,0L,4L,6L,8L,4L,6L,5L,9L,1L,1L,2L,9L,9L,5L,8L,8L,6L,8L,2L,8L,1L,4L,3L,1L,2L,2L,1L,1L,2L,4L,4L,8L,2L,9L,8L,7L,5L,1L,6L,2L,5L,1L,9L,6L,7L,0L,1L,4L,4L,6L,3L,5L,8L,3L,2L,4L,1L,6L,1L,0L,3L,8L,3L,6L,4L,4L,7L,5L,8L,8L,3L,2L,1L,1L,9L,0L,4L,7L,3L,2L,1L,1L,2L,0L,0L,1L,3L,7L,5L,9L,7L,2L,5L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199454Inst : IEnumerable<long>
{
public static readonly long[] Value=A199454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199454.Bytes);
public long this[int i]=>Value[i];

public static A199454Inst Instance=new A199454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199455
{
public static readonly long[] Value={ 1L,3L,2L,9L,9L,0L,3L,2L,6L,8L,4L,6L,9L,0L,4L,8L,0L,2L,6L,9L,8L,8L,7L,7L,9L,6L,5L,8L,0L,8L,0L,4L,0L,6L,0L,8L,2L,5L,3L,7L,3L,3L,2L,0L,9L,4L,4L,6L,9L,6L,2L,1L,6L,6L,3L,3L,6L,6L,8L,3L,2L,7L,7L,4L,0L,2L,8L,2L,5L,2L,8L,7L,9L,9L,5L,4L,5L,8L,0L,5L,7L,4L,9L,0L,3L,8L,8L,7L,5L,3L,9L,9L,4L,7L,3L,3L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199455Inst : IEnumerable<long>
{
public static readonly long[] Value=A199455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199455.Bytes);
public long this[int i]=>Value[i];

public static A199455Inst Instance=new A199455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199456
{
public static readonly long[] Value={ 1L,3L,8L,4L,3L,5L,8L,2L,8L,9L,1L,3L,5L,1L,7L,5L,4L,3L,2L,1L,7L,1L,1L,4L,0L,9L,2L,1L,1L,2L,3L,7L,8L,6L,4L,7L,7L,9L,8L,9L,4L,3L,2L,7L,1L,7L,7L,2L,0L,4L,0L,1L,9L,5L,6L,2L,7L,5L,3L,6L,0L,1L,8L,6L,6L,4L,4L,5L,4L,4L,2L,0L,7L,7L,0L,4L,3L,4L,1L,4L,9L,3L,4L,2L,3L,3L,8L,3L,1L,6L,7L,3L,8L,6L,7L,7L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199456Inst : IEnumerable<long>
{
public static readonly long[] Value=A199456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199456.Bytes);
public long this[int i]=>Value[i];

public static A199456Inst Instance=new A199456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199457
{
public static readonly long[] Value={ 2L,3L,3L,3L,8L,5L,4L,8L,5L,0L,2L,8L,5L,2L,9L,2L,1L,2L,8L,3L,3L,0L,3L,7L,1L,0L,9L,9L,3L,1L,7L,4L,8L,0L,5L,3L,9L,2L,4L,4L,2L,0L,9L,2L,5L,7L,3L,8L,2L,2L,0L,6L,5L,2L,3L,3L,3L,0L,4L,2L,7L,0L,8L,2L,5L,6L,1L,6L,1L,8L,9L,6L,9L,1L,7L,1L,8L,1L,0L,8L,0L,6L,6L,3L,5L,9L,9L,8L,3L,8L,0L,0L,8L,5L,0L,5L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199457Inst : IEnumerable<long>
{
public static readonly long[] Value=A199457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199457.Bytes);
public long this[int i]=>Value[i];

public static A199457Inst Instance=new A199457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199458
{
public static readonly long[] Value={ 2L,1L,7L,0L,8L,5L,3L,3L,9L,9L,9L,4L,4L,2L,6L,8L,4L,6L,6L,1L,8L,2L,9L,6L,7L,7L,8L,9L,6L,2L,4L,5L,3L,8L,9L,9L,3L,1L,8L,7L,7L,3L,3L,2L,7L,6L,9L,0L,3L,4L,8L,5L,9L,1L,8L,0L,8L,0L,1L,0L,9L,5L,9L,7L,0L,0L,1L,5L,1L,5L,5L,8L,6L,4L,8L,0L,9L,7L,7L,9L,1L,2L,2L,0L,6L,3L,3L,3L,8L,1L,2L,6L,1L,1L,7L,3L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199458Inst : IEnumerable<long>
{
public static readonly long[] Value=A199458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199458.Bytes);
public long this[int i]=>Value[i];

public static A199458Inst Instance=new A199458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199459
{
public static readonly long[] Value={ 2L,0L,1L,7L,7L,4L,6L,7L,6L,0L,9L,2L,2L,1L,1L,8L,4L,5L,3L,5L,4L,7L,3L,0L,6L,4L,1L,9L,4L,0L,3L,2L,6L,0L,3L,7L,4L,4L,1L,3L,2L,6L,5L,9L,4L,0L,2L,6L,5L,5L,5L,1L,1L,3L,6L,9L,8L,7L,5L,6L,6L,2L,7L,3L,2L,5L,2L,1L,2L,0L,5L,9L,7L,9L,4L,3L,2L,3L,0L,1L,0L,7L,9L,6L,8L,1L,4L,3L,8L,5L,4L,2L,4L,7L,5L,5L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199459Inst : IEnumerable<long>
{
public static readonly long[] Value=A199459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199459.Bytes);
public long this[int i]=>Value[i];

public static A199459Inst Instance=new A199459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199460
{
public static readonly long[] Value={ 1L,8L,9L,5L,4L,9L,4L,2L,6L,7L,0L,3L,3L,9L,8L,0L,9L,4L,7L,1L,4L,4L,0L,3L,5L,7L,3L,8L,0L,9L,3L,6L,0L,1L,6L,9L,1L,7L,5L,1L,3L,4L,6L,6L,2L,7L,3L,8L,5L,4L,2L,3L,9L,6L,2L,0L,0L,0L,1L,7L,7L,4L,8L,9L,5L,9L,3L,2L,7L,8L,5L,4L,5L,3L,1L,8L,8L,7L,7L,2L,1L,5L,7L,8L,0L,4L,4L,5L,4L,5L,2L,9L,4L,0L,3L,7L,5L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199460Inst : IEnumerable<long>
{
public static readonly long[] Value=A199460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199460.Bytes);
public long this[int i]=>Value[i];

public static A199460Inst Instance=new A199460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199461
{
public static readonly long[] Value={ 1L,8L,1L,1L,1L,1L,0L,8L,1L,4L,2L,4L,8L,3L,1L,9L,7L,6L,2L,7L,9L,6L,5L,4L,9L,7L,0L,9L,7L,5L,6L,7L,2L,9L,6L,1L,7L,6L,9L,1L,0L,3L,1L,2L,5L,8L,1L,3L,5L,3L,4L,3L,1L,2L,9L,4L,9L,2L,7L,3L,5L,6L,4L,4L,6L,3L,4L,5L,4L,9L,8L,0L,6L,3L,7L,3L,5L,5L,8L,2L,7L,5L,1L,0L,0L,2L,7L,3L,9L,7L,7L,6L,1L,4L,2L,6L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199461Inst : IEnumerable<long>
{
public static readonly long[] Value=A199461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199461.Bytes);
public long this[int i]=>Value[i];

public static A199461Inst Instance=new A199461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199462
{
public static readonly long[] Value={ 1L,7L,5L,6L,0L,2L,6L,6L,9L,2L,4L,5L,9L,7L,0L,3L,4L,3L,2L,9L,4L,2L,5L,3L,3L,4L,8L,9L,2L,6L,4L,2L,3L,9L,2L,3L,5L,8L,1L,0L,8L,1L,2L,7L,8L,0L,7L,1L,8L,9L,9L,0L,8L,7L,2L,7L,0L,9L,2L,3L,9L,0L,3L,3L,7L,1L,8L,2L,4L,9L,9L,5L,0L,7L,4L,5L,3L,3L,0L,2L,3L,0L,8L,4L,1L,0L,3L,0L,8L,4L,9L,5L,1L,0L,5L,1L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199462Inst : IEnumerable<long>
{
public static readonly long[] Value=A199462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199462.Bytes);
public long this[int i]=>Value[i];

public static A199462Inst Instance=new A199462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199463
{
public static readonly long[] Value={ 1L,7L,1L,9L,4L,7L,9L,3L,6L,6L,6L,5L,1L,9L,3L,4L,7L,2L,7L,4L,8L,4L,2L,9L,8L,6L,8L,3L,7L,6L,4L,3L,2L,6L,5L,8L,7L,2L,0L,0L,7L,1L,1L,8L,4L,3L,8L,3L,2L,9L,8L,2L,1L,6L,7L,8L,0L,0L,7L,0L,5L,4L,3L,4L,0L,4L,3L,2L,7L,8L,6L,5L,9L,7L,4L,2L,4L,2L,8L,7L,1L,4L,9L,9L,3L,5L,7L,8L,6L,1L,4L,1L,7L,4L,0L,1L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199463Inst : IEnumerable<long>
{
public static readonly long[] Value=A199463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199463.Bytes);
public long this[int i]=>Value[i];

public static A199463Inst Instance=new A199463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199464
{
public static readonly long[] Value={ 1L,0L,2L,0L,6L,5L,1L,9L,4L,4L,5L,5L,0L,7L,1L,4L,2L,8L,1L,7L,9L,2L,0L,8L,0L,1L,0L,9L,8L,5L,8L,2L,5L,7L,4L,0L,9L,1L,6L,7L,9L,8L,4L,7L,5L,0L,6L,4L,8L,2L,8L,7L,3L,4L,9L,6L,3L,7L,4L,1L,3L,8L,6L,4L,8L,3L,0L,9L,7L,0L,7L,6L,4L,4L,0L,3L,8L,5L,2L,9L,0L,1L,1L,9L,7L,1L,9L,6L,8L,8L,0L,4L,5L,5L,8L,9L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199464Inst : IEnumerable<long>
{
public static readonly long[] Value=A199464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199464.Bytes);
public long this[int i]=>Value[i];

public static A199464Inst Instance=new A199464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199465
{
public static readonly long[] Value={ 2L,4L,7L,9L,8L,1L,6L,1L,6L,7L,5L,8L,0L,7L,5L,2L,6L,9L,9L,1L,5L,6L,8L,6L,7L,4L,4L,6L,0L,3L,4L,3L,4L,4L,2L,9L,3L,2L,3L,8L,5L,7L,1L,2L,5L,0L,4L,0L,5L,9L,8L,1L,6L,9L,3L,3L,8L,7L,5L,4L,6L,4L,0L,9L,5L,3L,5L,6L,6L,7L,0L,9L,3L,5L,5L,4L,0L,8L,7L,6L,2L,9L,5L,8L,9L,3L,1L,1L,9L,0L,5L,5L,3L,8L,6L,2L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199465Inst : IEnumerable<long>
{
public static readonly long[] Value=A199465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199465.Bytes);
public long this[int i]=>Value[i];

public static A199465Inst Instance=new A199465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199466
{
public static readonly long[] Value={ 2L,3L,7L,8L,1L,0L,9L,6L,9L,6L,1L,2L,0L,3L,2L,4L,8L,0L,6L,8L,2L,3L,0L,8L,7L,8L,4L,9L,8L,2L,6L,0L,8L,6L,3L,1L,8L,0L,9L,4L,7L,1L,5L,7L,4L,2L,2L,8L,8L,5L,5L,9L,6L,3L,5L,0L,6L,8L,0L,9L,8L,3L,4L,7L,7L,9L,1L,8L,0L,0L,4L,7L,7L,4L,9L,7L,1L,5L,9L,3L,6L,8L,2L,2L,3L,7L,3L,3L,3L,4L,2L,5L,1L,4L,1L,2L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199466Inst : IEnumerable<long>
{
public static readonly long[] Value=A199466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199466.Bytes);
public long this[int i]=>Value[i];

public static A199466Inst Instance=new A199466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199467
{
public static readonly long[] Value={ 2L,2L,7L,8L,8L,6L,2L,6L,6L,0L,0L,7L,5L,8L,2L,8L,3L,1L,2L,6L,9L,9L,9L,5L,1L,1L,0L,4L,5L,6L,1L,8L,8L,8L,6L,2L,8L,8L,1L,8L,2L,7L,4L,7L,4L,0L,7L,3L,9L,7L,7L,6L,5L,1L,6L,5L,2L,5L,5L,8L,5L,5L,2L,9L,2L,4L,8L,3L,4L,4L,4L,6L,4L,7L,0L,1L,8L,3L,9L,1L,8L,6L,2L,5L,6L,7L,8L,1L,3L,4L,0L,5L,8L,0L,1L,4L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199467Inst : IEnumerable<long>
{
public static readonly long[] Value=A199467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199467.Bytes);
public long this[int i]=>Value[i];

public static A199467Inst Instance=new A199467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199468
{
public static readonly long[] Value={ 2L,1L,8L,5L,9L,8L,5L,9L,9L,6L,7L,8L,6L,2L,2L,7L,3L,7L,3L,3L,4L,5L,4L,3L,3L,5L,9L,6L,3L,5L,7L,7L,0L,0L,1L,5L,7L,3L,3L,8L,5L,6L,4L,6L,1L,7L,1L,9L,8L,5L,6L,8L,9L,9L,3L,7L,5L,9L,8L,8L,2L,9L,6L,1L,5L,5L,6L,6L,1L,5L,2L,7L,3L,2L,9L,5L,3L,3L,0L,5L,1L,8L,9L,5L,6L,6L,8L,4L,6L,2L,2L,6L,4L,2L,4L,7L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199468Inst : IEnumerable<long>
{
public static readonly long[] Value=A199468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199468.Bytes);
public long this[int i]=>Value[i];

public static A199468Inst Instance=new A199468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199469
{
public static readonly long[] Value={ 2L,1L,0L,2L,8L,3L,6L,8L,6L,0L,9L,1L,4L,1L,0L,4L,7L,0L,1L,4L,7L,2L,7L,6L,8L,5L,1L,1L,8L,2L,4L,7L,0L,2L,2L,2L,9L,9L,9L,0L,3L,9L,3L,3L,8L,5L,4L,9L,9L,5L,6L,0L,5L,1L,0L,6L,5L,9L,1L,6L,7L,8L,9L,9L,6L,1L,1L,3L,4L,2L,1L,8L,0L,7L,9L,3L,0L,9L,6L,1L,6L,1L,0L,6L,8L,9L,3L,9L,1L,4L,1L,1L,3L,8L,0L,6L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199469Inst : IEnumerable<long>
{
public static readonly long[] Value=A199469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199469.Bytes);
public long this[int i]=>Value[i];

public static A199469Inst Instance=new A199469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199470
{
public static readonly long[] Value={ 2L,0L,3L,1L,2L,5L,7L,6L,4L,0L,3L,3L,3L,0L,7L,3L,1L,3L,5L,8L,3L,7L,7L,6L,4L,7L,6L,6L,2L,1L,1L,2L,0L,1L,5L,1L,8L,8L,0L,5L,1L,4L,2L,6L,5L,7L,7L,0L,3L,0L,6L,3L,6L,3L,9L,4L,9L,0L,3L,8L,0L,2L,4L,6L,0L,1L,8L,2L,5L,5L,9L,9L,7L,6L,6L,7L,8L,4L,7L,3L,5L,5L,5L,4L,6L,2L,7L,3L,0L,0L,1L,7L,3L,3L,8L,8L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199470Inst : IEnumerable<long>
{
public static readonly long[] Value=A199470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199470.Bytes);
public long this[int i]=>Value[i];

public static A199470Inst Instance=new A199470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199471
{
public static readonly long[] Value={ 7L,9L,6L,4L,3L,0L,4L,1L,6L,7L,9L,6L,3L,4L,3L,0L,7L,9L,6L,9L,6L,3L,5L,9L,0L,0L,2L,2L,9L,6L,5L,8L,8L,1L,1L,8L,0L,2L,1L,2L,7L,0L,7L,5L,2L,2L,7L,0L,7L,1L,0L,8L,5L,5L,1L,7L,3L,5L,2L,0L,8L,9L,5L,9L,9L,2L,9L,7L,7L,8L,0L,5L,4L,9L,8L,6L,0L,9L,3L,1L,0L,3L,9L,6L,6L,9L,6L,1L,4L,5L,4L,8L,1L,7L,2L,9L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199471Inst : IEnumerable<long>
{
public static readonly long[] Value=A199471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199471.Bytes);
public long this[int i]=>Value[i];

public static A199471Inst Instance=new A199471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199472
{
public static readonly long[] Value={ 9L,8L,1L,6L,9L,4L,7L,0L,9L,7L,8L,6L,9L,3L,6L,6L,7L,9L,9L,9L,4L,0L,7L,2L,2L,4L,2L,9L,8L,8L,2L,1L,1L,1L,6L,5L,4L,1L,3L,3L,7L,7L,7L,6L,7L,8L,4L,0L,4L,1L,5L,1L,8L,0L,5L,2L,1L,8L,3L,3L,9L,4L,1L,7L,9L,8L,6L,8L,2L,1L,4L,7L,8L,4L,8L,1L,7L,8L,9L,2L,1L,0L,5L,5L,4L,9L,0L,9L,7L,8L,5L,6L,7L,2L,2L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199472Inst : IEnumerable<long>
{
public static readonly long[] Value=A199472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199472.Bytes);
public long this[int i]=>Value[i];

public static A199472Inst Instance=new A199472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199473
{
public static readonly long[] Value={ 1L,0L,8L,6L,0L,2L,7L,2L,1L,1L,8L,4L,3L,7L,3L,0L,4L,0L,7L,8L,4L,5L,6L,6L,9L,7L,3L,4L,7L,7L,2L,0L,2L,7L,2L,0L,9L,3L,1L,6L,1L,2L,6L,5L,0L,0L,6L,0L,1L,5L,2L,1L,5L,7L,9L,1L,6L,7L,5L,1L,3L,1L,2L,6L,0L,7L,1L,8L,1L,6L,1L,2L,2L,6L,3L,1L,6L,6L,3L,3L,3L,8L,9L,6L,8L,8L,9L,7L,1L,1L,2L,8L,2L,2L,4L,2L,9L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199473Inst : IEnumerable<long>
{
public static readonly long[] Value=A199473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199473.Bytes);
public long this[int i]=>Value[i];

public static A199473Inst Instance=new A199473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199474
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,5L,4L,3L,6L,5L,4L,7L,6L,5L,4L,8L,7L,6L,5L,9L,8L,7L,6L,5L,10L,9L,8L,7L,6L,11L,10L,9L,8L,7L,6L,12L,11L,10L,9L,8L,7L,13L,12L,11L,10L,9L,8L,7L,14L,13L,12L,11L,10L,9L,8L,15L,14L,13L,12L,11L,10L,9L,8L,16L,15L,14L,13L,12L,11L,10L,9L,17L,16L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199474Inst : IEnumerable<long>
{
public static readonly long[] Value=A199474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199474.Bytes);
public long this[int i]=>Value[i];

public static A199474Inst Instance=new A199474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199475
{
public static readonly long[] Value={ 1L,2L,7L,34L,195L,1225L,8146L,56336L,401005L,2918308L,21614216L,162385693L,1234515922L,9479336440L,73410868630L,572719097908L,4496923141241L,35509806367132L,281814387290431L,2246608404455588L,17982234787607464L,144458551104066553L,1164342291135424494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199475Inst : IEnumerable<long>
{
public static readonly long[] Value=A199475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199475.Bytes);
public long this[int i]=>Value[i];

public static A199475Inst Instance=new A199475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199476
{
public static readonly long[] Value={ 2L,2L,6L,1L,5L,16L,1L,2L,12L,34L,1L,1L,6L,28L,77L,1L,1L,2L,14L,61L,157L,1L,1L,1L,6L,34L,133L,328L,1L,1L,1L,2L,15L,74L,277L,655L,1L,1L,1L,1L,6L,36L,165L,572L,1309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199476Inst : IEnumerable<long>
{
public static readonly long[] Value=A199476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199476.Bytes);
public long this[int i]=>Value[i];

public static A199476Inst Instance=new A199476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199477
{
public static readonly long[] Value={ 2L,6L,16L,34L,77L,157L,328L,655L,1309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199477Inst : IEnumerable<long>
{
public static readonly long[] Value=A199477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199477.Bytes);
public long this[int i]=>Value[i];

public static A199477Inst Instance=new A199477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199478
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,5L,2L,1L,7L,8L,1L,9L,18L,4L,1L,11L,32L,20L,1L,13L,50L,56L,8L,1L,15L,72L,120L,48L,1L,17L,98L,220L,160L,16L,1L,19L,128L,364L,400L,112L,1L,21L,162L,560L,840L,432L,32L,1L,23L,200L,816L,1568L,1232L,256L,1L,25L,242L,1140L,2688L,2912L,1120L,64L,1L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199478Inst : IEnumerable<long>
{
public static readonly long[] Value=A199478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199478.Bytes);
public long this[int i]=>Value[i];

public static A199478Inst Instance=new A199478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199479
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,5L,9L,5L,1L,7L,20L,27L,13L,1L,9L,35L,73L,80L,34L,1L,11L,54L,151L,252L,234L,89L,1L,13L,77L,269L,597L,837L,677L,233L,1L,15L,104L,435L,1199L,2225L,2702L,1941L,610L,1L,17L,135L,657L,2158L,4956L,7943L,8533L,5523L,1597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199479Inst : IEnumerable<long>
{
public static readonly long[] Value=A199479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199479.Bytes);
public long this[int i]=>Value[i];

public static A199479Inst Instance=new A199479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199480
{
public static readonly BigInteger[] Value={ 1L,1L,5L,19L,113L,701L,5269L,42883L,393441L,3887065L,42013381L,484389731L,6008730001L,78857557013L,1101462510485L,16168488228691L,250664264773825L,4061840593263921L,69116855497839109L,1223722811124319219L,BigInteger.Parse("22651504652950552241") };
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
public class A199480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199480Inst Instance=new A199480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199481
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,88L,369L,1600L,7122L,32370L,149612L,701046L,3322671L,15901030L,76729203L,372918345L,1823872039L,8969769017L,44330916829L,220062127756L,1096744496191L,5485585559684L,27526824797373L,138542038343946L,699184051431377L,3537456038149028L,17938918589386868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199481Inst : IEnumerable<long>
{
public static readonly long[] Value=A199481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199481.Bytes);
public long this[int i]=>Value[i];

public static A199481Inst Instance=new A199481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199482
{
public static readonly BigInteger[] Value={ 1L,1L,2L,-6L,-168L,-2600L,-10800L,727440L,43263360L,1032103296L,-228614400L,-3068098387200L,-194799891686400L,-9157262446126080L,406734380101969920L,BigInteger.Parse("68528048007234816000"),BigInteger.Parse("9942165414475886592000"),BigInteger.Parse("179947145139068340633600"),BigInteger.Parse("-678953675518129505894400") };
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
public class A199482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199482Inst Instance=new A199482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199483
{
public static readonly long[] Value={ 7L,43L,295L,2059L,14407L,100843L,705895L,4941259L,34588807L,242121643L,1694851495L,11863960459L,83047723207L,581334062443L,4069338437095L,28485369059659L,199397583417607L,1395783083923243L,9770481587462695L,68393371112238859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199483Inst : IEnumerable<long>
{
public static readonly long[] Value=A199483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199483.Bytes);
public long this[int i]=>Value[i];

public static A199483Inst Instance=new A199483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199484
{
public static readonly long[] Value={ 3L,19L,131L,915L,6403L,44819L,313731L,2196115L,15372803L,107609619L,753267331L,5272871315L,36910099203L,258370694419L,1808594860931L,12660164026515L,88621148185603L,620348037299219L,4342436261094531L,30397053827661715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199484Inst : IEnumerable<long>
{
public static readonly long[] Value=A199484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199484.Bytes);
public long this[int i]=>Value[i];

public static A199484Inst Instance=new A199484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199485
{
public static readonly long[] Value={ 9L,57L,393L,2745L,19209L,134457L,941193L,6588345L,46118409L,322828857L,2259801993L,15818613945L,110730297609L,775112083257L,5425784582793L,37980492079545L,265863444556809L,1861044111897657L,13027308783283593L,91191161482985145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199485Inst : IEnumerable<long>
{
public static readonly long[] Value=A199485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199485.Bytes);
public long this[int i]=>Value[i];

public static A199485Inst Instance=new A199485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199486
{
public static readonly long[] Value={ 5L,32L,221L,1544L,10805L,75632L,529421L,3705944L,25941605L,181591232L,1271138621L,8897970344L,62285792405L,436000546832L,3052003827821L,21364026794744L,149548187563205L,1046837312942432L,7327861190597021L,51295028334179144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199486Inst : IEnumerable<long>
{
public static readonly long[] Value=A199486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199486.Bytes);
public long this[int i]=>Value[i];

public static A199486Inst Instance=new A199486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199487
{
public static readonly long[] Value={ 10L,64L,442L,3088L,21610L,151264L,1058842L,7411888L,51883210L,363182464L,2542277242L,17795940688L,124571584810L,872001093664L,6104007655642L,42728053589488L,299096375126410L,2093674625884864L,14655722381194042L,102590056668358288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199487Inst : IEnumerable<long>
{
public static readonly long[] Value=A199487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199487.Bytes);
public long this[int i]=>Value[i];

public static A199487Inst Instance=new A199487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199488
{
public static readonly long[] Value={ 11L,71L,491L,3431L,24011L,168071L,1176491L,8235431L,57648011L,403536071L,2824752491L,19773267431L,138412872011L,968890104071L,6782230728491L,47475615099431L,332329305696011L,2326305139872071L,16284135979104491L,113988951853731431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199488Inst : IEnumerable<long>
{
public static readonly long[] Value=A199488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199488.Bytes);
public long this[int i]=>Value[i];

public static A199488Inst Instance=new A199488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199489
{
public static readonly long[] Value={ 2L,13L,90L,629L,4402L,30813L,215690L,1509829L,10568802L,73981613L,517871290L,3625099029L,25375693202L,177629852413L,1243408966890L,8703862768229L,60927039377602L,426489275643213L,2985424929502490L,20897974506517429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199489Inst : IEnumerable<long>
{
public static readonly long[] Value=A199489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199489.Bytes);
public long this[int i]=>Value[i];

public static A199489Inst Instance=new A199489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199490
{
public static readonly long[] Value={ 4L,26L,180L,1258L,8804L,61626L,431380L,3019658L,21137604L,147963226L,1035742580L,7250198058L,50751386404L,355259704826L,2486817933780L,17407725536458L,121854078755204L,852978551286426L,5970849859004980L,41795949013034858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199490Inst : IEnumerable<long>
{
public static readonly long[] Value=A199490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199490.Bytes);
public long this[int i]=>Value[i];

public static A199490Inst Instance=new A199490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199491
{
public static readonly long[] Value={ 6L,39L,270L,1887L,13206L,92439L,647070L,4529487L,31706406L,221944839L,1553613870L,10875297087L,76127079606L,532889557239L,3730226900670L,26111588304687L,182781118132806L,1279467826929639L,8956274788507470L,62693923519552287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199491Inst : IEnumerable<long>
{
public static readonly long[] Value=A199491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199491.Bytes);
public long this[int i]=>Value[i];

public static A199491Inst Instance=new A199491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199492
{
public static readonly long[] Value={ 12L,78L,540L,3774L,26412L,184878L,1294140L,9058974L,63412812L,443889678L,3107227740L,21750594174L,152254159212L,1065779114478L,7460453801340L,52223176609374L,365562236265612L,2558935653859278L,17912549577014940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199492Inst : IEnumerable<long>
{
public static readonly long[] Value=A199492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199492.Bytes);
public long this[int i]=>Value[i];

public static A199492Inst Instance=new A199492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199493
{
public static readonly long[] Value={ 3L,17L,129L,1025L,8193L,65537L,524289L,4194305L,33554433L,268435457L,2147483649L,17179869185L,137438953473L,1099511627777L,8796093022209L,70368744177665L,562949953421313L,4503599627370497L,36028797018963969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199493Inst : IEnumerable<long>
{
public static readonly long[] Value=A199493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199493.Bytes);
public long this[int i]=>Value[i];

public static A199493Inst Instance=new A199493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199494
{
public static readonly long[] Value={ 4L,25L,193L,1537L,12289L,98305L,786433L,6291457L,50331649L,402653185L,3221225473L,25769803777L,206158430209L,1649267441665L,13194139533313L,105553116266497L,844424930131969L,6755399441055745L,54043195528445953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199494Inst : IEnumerable<long>
{
public static readonly long[] Value=A199494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199494.Bytes);
public long this[int i]=>Value[i];

public static A199494Inst Instance=new A199494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199495
{
public static readonly BigInteger[] Value={ 0L,1L,0L,2L,4L,36L,144L,1440L,8640L,100800L,806400L,10886400L,108864000L,1676505600L,20118067200L,348713164800L,4881984307200L,94152554496000L,1506440871936000L,32011868528640000L,576213633515520000L,13380961044971520000UL,BigInteger.Parse("267619220899430400000") };
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
public class A199495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199495Inst Instance=new A199495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199496
{
public static readonly BigInteger[] Value={ 367806L,939787L,952764389446L,12438517260105L,35495694227489L,5853886516781223L,23415546067124892L,38115991067861271L,322001299796379844L,9870884617163518770UL,BigInteger.Parse("42532374580189966073"),BigInteger.Parse("51698891432429706382"),BigInteger.Parse("601724682280310364065") };
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
public class A199496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199496Inst Instance=new A199496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199497
{
public static readonly long[] Value={ 207L,307L,852135L,2767769L,5190544L,1641843L,105077952L,30032270L,548147655L,1651035656L,1878790553L,4101044247L,13027681441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199497Inst : IEnumerable<long>
{
public static readonly long[] Value=A199497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199497.Bytes);
public long this[int i]=>Value[i];

public static A199497Inst Instance=new A199497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199498
{
public static readonly BigInteger[] Value={ 223063347L,911054064L,929989991784733049L,BigInteger.Parse("43868513629203032816"),BigInteger.Parse("211477180624706647625"),BigInteger.Parse("447884928428402042307918"),BigInteger.Parse("3583079427427216338463344"),BigInteger.Parse("7441505802879036345061579"),BigInteger.Parse("182720147509505842286585077"),BigInteger.Parse("31012309752051601656131750312"),BigInteger.Parse("277382747164996776244709473092") };
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
public class A199498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199498Inst Instance=new A199498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199499
{
public static readonly long[] Value={ 2L,2L,4L,9L,6L,1L,1L,3L,7L,5L,5L,5L,2L,3L,6L,7L,4L,2L,4L,2L,4L,3L,2L,7L,0L,7L,1L,1L,5L,9L,0L,0L,7L,8L,6L,9L,5L,0L,5L,9L,9L,9L,2L,7L,5L,2L,9L,0L,8L,8L,8L,9L,2L,8L,6L,1L,2L,5L,0L,2L,9L,4L,7L,7L,4L,6L,4L,4L,7L,0L,2L,9L,1L,5L,0L,7L,3L,3L,8L,6L,3L,9L,7L,6L,4L,0L,6L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199499Inst : IEnumerable<long>
{
public static readonly long[] Value=A199499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199499.Bytes);
public long this[int i]=>Value[i];

public static A199499Inst Instance=new A199499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199500
{
public static readonly long[] Value={ 4L,4L,4L,5L,2L,1L,2L,2L,3L,0L,2L,8L,7L,8L,2L,4L,5L,2L,2L,6L,4L,2L,8L,1L,8L,5L,3L,9L,0L,1L,6L,6L,4L,0L,9L,5L,7L,8L,7L,4L,0L,7L,7L,6L,8L,9L,6L,4L,8L,2L,1L,3L,6L,9L,3L,3L,7L,5L,2L,2L,6L,0L,9L,3L,8L,0L,0L,7L,7L,8L,0L,8L,1L,0L,0L,7L,5L,9L,7L,4L,4L,2L,0L,3L,2L,1L,3L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199500Inst : IEnumerable<long>
{
public static readonly long[] Value=A199500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199500.Bytes);
public long this[int i]=>Value[i];

public static A199500Inst Instance=new A199500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199501
{
public static readonly long[] Value={ 2L,6L,1L,7L,3L,5L,5L,3L,7L,8L,1L,9L,4L,7L,7L,7L,7L,7L,7L,7L,9L,3L,5L,3L,5L,7L,2L,2L,8L,3L,0L,1L,9L,0L,8L,0L,2L,9L,2L,2L,7L,4L,4L,3L,7L,8L,0L,4L,8L,3L,2L,4L,9L,1L,8L,1L,0L,2L,4L,0L,8L,9L,8L,3L,3L,9L,1L,6L,4L,6L,2L,9L,9L,7L,9L,6L,3L,7L,2L,8L,4L,8L,7L,4L,1L,6L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199501Inst : IEnumerable<long>
{
public static readonly long[] Value=A199501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199501.Bytes);
public long this[int i]=>Value[i];

public static A199501Inst Instance=new A199501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199502
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,10L,11L,12L,13L,18L,19L,20L,21L,30L,31L,36L,37L,38L,39L,48L,49L,54L,55L,56L,57L,70L,71L,80L,81L,86L,87L,88L,89L,102L,103L,112L,113L,118L,119L,120L,121L,138L,139L,152L,153L,162L,163L,168L,169L,170L,171L,188L,189L,202L,203L,212L,213L,218L,219L,220L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199502Inst : IEnumerable<long>
{
public static readonly long[] Value=A199502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199502.Bytes);
public long this[int i]=>Value[i];

public static A199502Inst Instance=new A199502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199503
{
public static readonly long[] Value={ 1L,0L,9L,7L,7L,0L,6L,0L,7L,3L,0L,6L,5L,1L,9L,0L,4L,2L,9L,4L,0L,1L,6L,2L,8L,9L,5L,8L,2L,9L,1L,9L,3L,9L,0L,1L,3L,0L,0L,5L,9L,7L,8L,9L,1L,0L,4L,8L,2L,8L,7L,5L,8L,9L,8L,9L,3L,4L,7L,3L,6L,4L,0L,5L,3L,3L,8L,2L,8L,7L,7L,4L,1L,6L,6L,9L,5L,4L,6L,7L,6L,5L,2L,6L,0L,1L,1L,2L,4L,7L,4L,7L,6L,1L,7L,3L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199503Inst : IEnumerable<long>
{
public static readonly long[] Value=A199503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199503.Bytes);
public long this[int i]=>Value[i];

public static A199503Inst Instance=new A199503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199504
{
public static readonly long[] Value={ 1L,2L,8L,6L,6L,8L,5L,6L,4L,4L,8L,1L,2L,6L,8L,3L,7L,2L,1L,5L,4L,6L,8L,2L,1L,3L,9L,6L,1L,2L,0L,2L,6L,7L,9L,7L,6L,9L,1L,0L,3L,8L,6L,3L,7L,2L,6L,3L,9L,1L,3L,7L,9L,5L,6L,4L,1L,3L,3L,7L,1L,6L,3L,5L,8L,7L,8L,7L,3L,9L,4L,9L,5L,6L,3L,4L,5L,3L,7L,4L,1L,9L,7L,8L,0L,9L,8L,2L,9L,3L,0L,6L,0L,3L,8L,6L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199504Inst : IEnumerable<long>
{
public static readonly long[] Value=A199504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199504.Bytes);
public long this[int i]=>Value[i];

public static A199504Inst Instance=new A199504Inst();

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