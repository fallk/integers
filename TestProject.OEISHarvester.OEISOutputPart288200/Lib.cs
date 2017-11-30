using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A239951
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,6L,10L,14L,22L,30L,44L,59L,84L,109L,151L,195L,261L,335L,440L,558L,723L,909L,1160L,1452L,1829L,2272L,2839L,3503L,4336L,5326L,6542L,7984L,9756L,11842L,14376L,17382L,20985L,25255L,30355L,36372L,43528L,51960L,61925L,73645L,87460L,103648L,122650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239951Inst : IEnumerable<long>
{
public static readonly long[] Value=A239951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239951.Bytes);
public long this[int i]=>Value[i];

public static A239951Inst Instance=new A239951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240000
{
public static readonly long[] Value={ 2L,3L,5L,4L,13L,12L,5L,25L,61L,28L,6L,42L,190L,256L,66L,7L,65L,526L,1372L,1117L,156L,8L,95L,1262L,6527L,10405L,5012L,368L,9L,133L,2766L,27415L,86360L,83029L,22592L,868L,10L,180L,5647L,104291L,635873L,1225281L,685898L,102336L,2048L,11L,237L,10878L,363859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240000Inst : IEnumerable<long>
{
public static readonly long[] Value=A240000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240000.Bytes);
public long this[int i]=>Value[i];

public static A240000Inst Instance=new A240000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240001
{
public static readonly long[] Value={ 5L,13L,25L,42L,65L,95L,133L,180L,237L,305L,385L,478L,585L,707L,845L,1000L,1173L,1365L,1577L,1810L,2065L,2343L,2645L,2972L,3325L,3705L,4113L,4550L,5017L,5515L,6045L,6608L,7205L,7837L,8505L,9210L,9953L,10735L,11557L,12420L,13325L,14273L,15265L,16302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240001Inst : IEnumerable<long>
{
public static readonly long[] Value=A240001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240001.Bytes);
public long this[int i]=>Value[i];

public static A240001Inst Instance=new A240001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240002
{
public static readonly long[] Value={ 12L,61L,190L,526L,1262L,2766L,5647L,10878L,19971L,35180L,59780L,98414L,157524L,245879L,375214L,560995L,823326L,1188015L,1687817L,2363873L,3267365L,4461408L,6023201L,8046460L,10644157L,13951590L,18129810L,23369432L,29894858L,37968941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240002Inst : IEnumerable<long>
{
public static readonly long[] Value=A240002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240002.Bytes);
public long this[int i]=>Value[i];

public static A240002Inst Instance=new A240002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240003
{
public static readonly long[] Value={ 28L,256L,1372L,6527L,27415L,104291L,363859L,1173141L,3539402L,10055917L,27072084L,69433880L,170442542L,402042194L,914489241L,2012051851L,4293710454L,8908363984L,18007433696L,35530979384L,68546844725L,129490989279L,239852605993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240003Inst : IEnumerable<long>
{
public static readonly long[] Value=A240003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240003.Bytes);
public long this[int i]=>Value[i];

public static A240003Inst Instance=new A240003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240004
{
public static readonly long[] Value={ 66L,1117L,10405L,86360L,635873L,4267171L,26152051L,147439332L,775122753L,3821059149L,17769229031L,78356711183L,328981383567L,1319877073978L,5076715532082L,18776009861766L,66950026301586L,230700526217982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240004Inst : IEnumerable<long>
{
public static readonly long[] Value=A240004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240004.Bytes);
public long this[int i]=>Value[i];

public static A240004Inst Instance=new A240004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240005
{
public static readonly long[] Value={ 156L,5012L,83029L,1225281L,15981219L,191691132L,2090236137L,20967693050L,195664738888L,1709973352188L,14072972956499L,109646306877457L,811882008990473L,5734156428747664L,38755892651094582L,251427858506122705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240005Inst : IEnumerable<long>
{
public static readonly long[] Value=A240005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240005.Bytes);
public long this[int i]=>Value[i];

public static A240005Inst Instance=new A240005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240006
{
public static readonly long[] Value={ 368L,22592L,685898L,18392485L,429788876L,9314138750L,182333502325L,3306340714115L,55641031584148L,875242526758630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240006Inst : IEnumerable<long>
{
public static readonly long[] Value=A240006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240006.Bytes);
public long this[int i]=>Value[i];

public static A240006Inst Instance=new A240006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240007
{
public static readonly long[] Value={ 4L,75L,8L,375L,140L,56L,675L,1029L,294L,1380L,0L,180L,420L,112L,120L,656L,6875L,312L,243L,3660L,0L,3612L,0L,4140L,6498L,0L,0L,0L,0L,810L,0L,1260L,792L,0L,0L,0L,0L,0L,1936L,0L,1456L,1320L,0L,0L,144L,1000L,1368L,0L,1404L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240007Inst : IEnumerable<long>
{
public static readonly long[] Value=A240007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240007.Bytes);
public long this[int i]=>Value[i];

public static A240007Inst Instance=new A240007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240008
{
public static readonly long[] Value={ 1L,1L,3L,14L,65L,301L,1419L,6786L,32749L,159108L,777224L,3813745L,18783934L,92811389L,459832745L,2283628771L,11364500644L,56659024320L,282939657220L,1414980598167L,7085590965083L,35523567248527L,178289298823240L,895697952270827L,4503912366189604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240008Inst : IEnumerable<long>
{
public static readonly long[] Value=A240008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240008.Bytes);
public long this[int i]=>Value[i];

public static A240008Inst Instance=new A240008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240009
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,2L,1L,1L,0L,1L,1L,2L,3L,2L,2L,2L,1L,1L,0L,1L,1L,1L,2L,2L,2L,4L,3L,2L,2L,1L,1L,0L,1L,1L,2L,4L,5L,3L,4L,4L,2L,2L,1L,1L,0L,1L,1L,1L,2L,3L,3L,5L,7L,5L,4L,4L,2L,2L,1L,1L,0L,1L,1L,2L,4L,7L,7L,6L,8L,6L,4L,4L,2L,2L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240009Inst : IEnumerable<long>
{
public static readonly long[] Value=A240009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240009.Bytes);
public long this[int i]=>Value[i];

public static A240009Inst Instance=new A240009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240010
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,4L,3L,7L,6L,11L,11L,17L,19L,27L,31L,41L,51L,62L,79L,95L,121L,142L,182L,212L,269L,314L,393L,459L,570L,665L,816L,958L,1160L,1364L,1639L,1928L,2297L,2706L,3200L,3768L,4434L,5212L,6105L,7170L,8361L,9799L,11396L,13322L,15450L,18022L,20850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240010Inst : IEnumerable<long>
{
public static readonly long[] Value=A240010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240010.Bytes);
public long this[int i]=>Value[i];

public static A240010Inst Instance=new A240010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240011
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,3L,4L,5L,8L,8L,13L,14L,21L,23L,34L,37L,52L,60L,79L,93L,120L,143L,178L,216L,263L,321L,386L,470L,560L,684L,806L,980L,1154L,1395L,1636L,1969L,2304L,2758L,3225L,3835L,4480L,5305L,6186L,7288L,8495L,9961L,11594L,13545L,15742L,18325L,21269L,24675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240011Inst : IEnumerable<long>
{
public static readonly long[] Value=A240011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240011.Bytes);
public long this[int i]=>Value[i];

public static A240011Inst Instance=new A240011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240012
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,6L,8L,10L,14L,17L,23L,27L,38L,43L,59L,69L,91L,106L,139L,162L,207L,245L,306L,364L,449L,534L,650L,778L,934L,1117L,1334L,1592L,1887L,2251L,2652L,3155L,3705L,4391L,5139L,6075L,7086L,8347L,9720L,11406L,13252L,15505L,17978L,20965L,24272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240012Inst : IEnumerable<long>
{
public static readonly long[] Value=A240012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240012.Bytes);
public long this[int i]=>Value[i];

public static A240012Inst Instance=new A240012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240013
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,11L,14L,19L,24L,30L,40L,48L,63L,76L,98L,117L,151L,178L,227L,269L,337L,399L,496L,586L,720L,854L,1036L,1228L,1481L,1752L,2096L,2480L,2946L,3481L,4115L,4850L,5707L,6717L,7868L,9237L,10789L,12632L,14707L,17181L,19947L,23243L,26925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240013Inst : IEnumerable<long>
{
public static readonly long[] Value=A240013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240013.Bytes);
public long this[int i]=>Value[i];

public static A240013Inst Instance=new A240013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240014
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,12L,14L,20L,24L,32L,41L,51L,65L,81L,102L,125L,158L,190L,239L,287L,357L,426L,528L,626L,769L,913L,1110L,1314L,1590L,1877L,2255L,2660L,3174L,3738L,4439L,5215L,6162L,7230L,8502L,9954L,11666L,13626L,15911L,18551L,21590L,25118L,29154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240014Inst : IEnumerable<long>
{
public static readonly long[] Value=A240014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240014.Bytes);
public long this[int i]=>Value[i];

public static A240014Inst Instance=new A240014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240015
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,12L,14L,21L,24L,33L,41L,53L,66L,84L,104L,130L,162L,198L,246L,300L,369L,445L,548L,655L,801L,956L,1160L,1378L,1666L,1970L,2368L,2796L,3340L,3933L,4679L,5494L,6505L,7626L,8987L,10511L,12346L,14404L,16856L,19631L,22893L,26606L,30939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240015Inst : IEnumerable<long>
{
public static readonly long[] Value=A240015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240015.Bytes);
public long this[int i]=>Value[i];

public static A240015Inst Instance=new A240015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240064
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,5L,6L,8L,11L,16L,20L,26L,33L,43L,56L,71L,89L,112L,140L,177L,219L,271L,333L,411L,505L,617L,750L,912L,1105L,1339L,1612L,1940L,2327L,2789L,3334L,3978L,4733L,5625L,6670L,7903L,9338L,11021L,12980L,15273L,17940L,21043L,24640L,28822L,33661L,39273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240064Inst : IEnumerable<long>
{
public static readonly long[] Value=A240064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240064.Bytes);
public long this[int i]=>Value[i];

public static A240064Inst Instance=new A240064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240065
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,4L,6L,9L,12L,17L,23L,33L,43L,59L,76L,102L,132L,173L,221L,285L,361L,462L,580L,733L,913L,1144L,1418L,1761L,2168L,2673L,3273L,4012L,4885L,5952L,7212L,8741L,10546L,12719L,15279L,18344L,21949L,26247L,31287L,37268L,44267L,52541L,62207L,73584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240065Inst : IEnumerable<long>
{
public static readonly long[] Value=A240065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240065.Bytes);
public long this[int i]=>Value[i];

public static A240065Inst Instance=new A240065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240066
{
public static readonly long[] Value={ 2L,2L,0L,0L,0L,0L,0L,0L,2L,1L,1L,1L,1L,0L,0L,0L,2L,1L,1L,1L,0L,1L,0L,0L,2L,1L,1L,1L,0L,0L,1L,0L,2L,1L,1L,1L,0L,0L,0L,1L,2L,1L,1L,0L,1L,1L,0L,0L,2L,1L,1L,0L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,0L,1L,2L,1L,1L,0L,0L,1L,1L,0L,2L,1L,1L,0L,0L,1L,0L,1L,2L,1L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240066Inst : IEnumerable<long>
{
public static readonly long[] Value=A240066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240066.Bytes);
public long this[int i]=>Value[i];

public static A240066Inst Instance=new A240066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240067
{
public static readonly long[] Value={ 2L,2L,0L,0L,0L,0L,0L,0L,2L,1L,1L,1L,1L,0L,0L,0L,2L,1L,1L,1L,0L,1L,0L,0L,2L,1L,1L,1L,0L,0L,1L,0L,2L,1L,1L,1L,0L,0L,0L,1L,2L,1L,1L,1L,0L,0L,0L,-1L,2L,1L,1L,1L,0L,0L,-1L,0L,2L,1L,1L,1L,0L,-1L,0L,0L,2L,1L,1L,1L,-1L,0L,0L,0L,2L,1L,1L,0L,1L,1L,0L,0L,2L,1L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240067Inst : IEnumerable<long>
{
public static readonly long[] Value=A240067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240067.Bytes);
public long this[int i]=>Value[i];

public static A240067Inst Instance=new A240067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240068
{
public static readonly long[] Value={ 24L,32L,48L,64L,96L,112L,144L,160L,192L,240L,256L,304L,336L,352L,384L,432L,480L,496L,544L,576L,592L,640L,672L,720L,784L,816L,832L,864L,880L,912L,1024L,1056L,1104L,1120L,1200L,1216L,1264L,1312L,1344L,1392L,1440L,1456L,1536L,1552L,1584L,1600L,1696L,1792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240068Inst : IEnumerable<long>
{
public static readonly long[] Value=A240068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240068.Bytes);
public long this[int i]=>Value[i];

public static A240068Inst Instance=new A240068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240069
{
public static readonly long[] Value={ 0L,169L,107L,85L,66L,65L,62L,57L,54L,0L,42L,52L,38L,35L,35L,43L,28L,26L,45L,169L,30L,25L,51L,24L,30L,32L,29L,29L,46L,107L,29L,19L,25L,35L,19L,33L,26L,18L,42L,85L,24L,20L,21L,30L,40L,33L,16L,30L,17L,66L,30L,30L,31L,19L,18L,34L,20L,32L,28L,65L,27L,20L,25L,29L,18L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240069Inst : IEnumerable<long>
{
public static readonly long[] Value=A240069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240069.Bytes);
public long this[int i]=>Value[i];

public static A240069Inst Instance=new A240069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240070
{
public static readonly long[] Value={ 3L,5L,13L,23L,35L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240070Inst : IEnumerable<long>
{
public static readonly long[] Value=A240070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240070.Bytes);
public long this[int i]=>Value[i];

public static A240070Inst Instance=new A240070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240071
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,2L,4L,2L,2L,4L,2L,1L,1L,1L,4L,2L,1L,4L,3L,3L,6L,3L,3L,6L,3L,2L,6L,3L,1L,1L,1L,1L,6L,3L,1L,2L,1L,6L,3L,1L,6L,4L,4L,8L,4L,4L,8L,4L,2L,1L,3L,1L,2L,8L,4L,2L,8L,4L,1L,1L,2L,1L,1L,8L,4L,1L,2L,4L,2L,1L,8L,4L,1L,3L,1L,8L,4L,1L,8L,5L,5L,10L,5L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240071Inst : IEnumerable<long>
{
public static readonly long[] Value=A240071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240071.Bytes);
public long this[int i]=>Value[i];

public static A240071Inst Instance=new A240071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240072
{
public static readonly long[] Value={ 3L,7L,19L,31L,43L,46L,134L,94L,139L,151L,166L,271L,211L,334L,379L,463L,331L,478L,619L,526L,571L,604L,694L,631L,1051L,751L,886L,1039L,1141L,919L,1291L,1324L,1699L,1879L,1366L,2476L,2038L,1516L,1894L,1759L,2164L,1831L,2179L,1726L,2851L,2461L,2011L,2311L,4603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240072Inst : IEnumerable<long>
{
public static readonly long[] Value=A240072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240072.Bytes);
public long this[int i]=>Value[i];

public static A240072Inst Instance=new A240072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240073
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,10L,14L,16L,21L,22L,26L,32L,44L,50L,52L,63L,64L,76L,92L,98L,105L,110L,124L,128L,136L,152L,170L,182L,184L,212L,225L,230L,232L,248L,256L,290L,296L,310L,315L,328L,344L,370L,376L,405L,410L,424L,470L,472L,484L,495L,512L,568L,584L,592L,632L,656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240073Inst : IEnumerable<long>
{
public static readonly long[] Value=A240073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240073.Bytes);
public long this[int i]=>Value[i];

public static A240073Inst Instance=new A240073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240074
{
public static readonly long[] Value={ 1L,4L,11L,23L,43L,82L,149L,278L,471L,853L,1378L,2594L,4474L,7999L,15747L,27458L,48615L,84320L,166806L,297146L,544525L,973799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240074Inst : IEnumerable<long>
{
public static readonly long[] Value=A240074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240074.Bytes);
public long this[int i]=>Value[i];

public static A240074Inst Instance=new A240074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240075
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,15L,16L,17L,20L,44L,51L,52L,53L,56L,58L,64L,78L,166L,167L,192L,195L,196L,200L,202L,203L,206L,217L,226L,248L,249L,276L,312L,649L,657L,678L,681L,682L,715L,726L,740L,743L,747L,750L,771L,790L,830L,833L,836L,838L,842L,854L,875L,908L,911L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240075Inst : IEnumerable<long>
{
public static readonly long[] Value=A240075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240075.Bytes);
public long this[int i]=>Value[i];

public static A240075Inst Instance=new A240075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240076
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,6L,8L,13L,18L,27L,35L,52L,67L,93L,121L,164L,209L,279L,353L,461L,582L,748L,935L,1191L,1480L,1861L,2302L,2870L,3526L,4365L,5335L,6554L,7976L,9736L,11789L,14316L,17259L,20844L,25032L,30092L,35992L,43086L,51347L,61215L,72710L,86361L,102235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240076Inst : IEnumerable<long>
{
public static readonly long[] Value=A240076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240076.Bytes);
public long this[int i]=>Value[i];

public static A240076Inst Instance=new A240076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240077
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,7L,9L,14L,19L,28L,36L,53L,68L,94L,122L,165L,210L,280L,354L,462L,583L,749L,936L,1192L,1481L,1862L,2303L,2871L,3527L,4366L,5336L,6555L,7977L,9737L,11790L,14317L,17260L,20845L,25033L,30093L,35993L,43087L,51348L,61216L,72711L,86362L,102236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240077Inst : IEnumerable<long>
{
public static readonly long[] Value=A240077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240077.Bytes);
public long this[int i]=>Value[i];

public static A240077Inst Instance=new A240077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240078
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,4L,3L,6L,6L,10L,9L,18L,16L,27L,29L,44L,46L,71L,75L,109L,122L,167L,188L,257L,290L,382L,442L,569L,657L,840L,971L,1220L,1423L,1761L,2054L,2528L,2944L,3586L,4189L,5061L,5901L,7095L,8262L,9869L,11496L,13652L,15875L,18786L,21805L,25685L,29790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240078Inst : IEnumerable<long>
{
public static readonly long[] Value=A240078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240078.Bytes);
public long this[int i]=>Value[i];

public static A240078Inst Instance=new A240078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240079
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,6L,9L,13L,17L,24L,31L,43L,56L,73L,98L,126L,157L,212L,263L,329L,431L,531L,649L,850L,1033L,1255L,1575L,1961L,2357L,2917L,3497L,4328L,5272L,6281L,7493L,9360L,11079L,13091L,15650L,19226L,22596L,26802L,31423L,37930L,45259L,52829L,61570L,74181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240079Inst : IEnumerable<long>
{
public static readonly long[] Value=A240079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240079.Bytes);
public long this[int i]=>Value[i];

public static A240079Inst Instance=new A240079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240112
{
public static readonly long[] Value={ 4L,9L,12L,16L,18L,20L,25L,28L,36L,44L,45L,48L,49L,50L,52L,60L,63L,64L,68L,75L,76L,80L,81L,84L,90L,92L,98L,99L,100L,108L,112L,116L,117L,121L,124L,126L,132L,140L,144L,147L,148L,150L,153L,156L,162L,164L,169L,171L,172L,175L,176L,180L,188L,192L,196L,198L,204L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240112Inst : IEnumerable<long>
{
public static readonly long[] Value=A240112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240112.Bytes);
public long this[int i]=>Value[i];

public static A240112Inst Instance=new A240112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240113
{
public static readonly long[] Value={ 1L,13L,23L,43L,59L,88L,127L,148L,659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240113Inst : IEnumerable<long>
{
public static readonly long[] Value=A240113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240113.Bytes);
public long this[int i]=>Value[i];

public static A240113Inst Instance=new A240113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240114
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,14L,17L,20L,22L,25L,28L,31L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240114Inst : IEnumerable<long>
{
public static readonly long[] Value=A240114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240114.Bytes);
public long this[int i]=>Value[i];

public static A240114Inst Instance=new A240114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240115
{
public static readonly long[] Value={ 1L,3L,3L,4L,6L,7L,8L,11L,12L,13L,18L,19L,20L,26L,27L,29L,35L,37L,39L,46L,48L,50L,59L,61L,63L,73L,75L,78L,88L,91L,94L,105L,108L,111L,124L,127L,130L,144L,147L,151L,165L,169L,173L,188L,192L,196L,213L,217L,221L,239L,243L,248L,266L,271L,276L,295L,300L,305L,326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240115Inst : IEnumerable<long>
{
public static readonly long[] Value=A240115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240115.Bytes);
public long this[int i]=>Value[i];

public static A240115Inst Instance=new A240115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240116
{
public static readonly long[] Value={ 1L,3L,3L,4L,4L,6L,7L,8L,8L,12L,12L,13L,14L,18L,19L,20L,21L,27L,28L,29L,30L,37L,38L,40L,41L,48L,50L,52L,53L,62L,63L,65L,67L,76L,78L,80L,82L,93L,95L,97L,99L,111L,113L,116L,118L,130L,133L,136L,138L,152L,154L,157L,160L,174L,177L,180L,183L,199L,202L,205L,208L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240116Inst : IEnumerable<long>
{
public static readonly long[] Value=A240116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240116.Bytes);
public long this[int i]=>Value[i];

public static A240116Inst Instance=new A240116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240117
{
public static readonly long[] Value={ 1L,3L,3L,3L,4L,4L,6L,7L,7L,8L,8L,12L,12L,13L,14L,14L,19L,20L,20L,21L,22L,27L,28L,29L,30L,31L,38L,39L,40L,41L,42L,50L,51L,52L,54L,55L,63L,65L,66L,68L,69L,79L,80L,82L,84L,85L,96L,98L,99L,101L,103L,114L,116L,118L,120L,122L,135L,137L,139L,141L,143L,157L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240117Inst : IEnumerable<long>
{
public static readonly long[] Value=A240117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240117.Bytes);
public long this[int i]=>Value[i];

public static A240117Inst Instance=new A240117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240118
{
public static readonly long[] Value={ 1L,4L,5L,7L,11L,14L,18L,27L,32L,37L,54L,61L,68L,94L,103L,116L,147L,163L,180L,221L,240L,260L,319L,342L,366L,438L,465L,500L,581L,619L,658L,756L,800L,844L,968L,1016L,1066L,1210L,1265L,1329L,1485L,1555L,1627L,1805L,1882L,1960L,2173L,2257L,2343L,2582L,2673L,2778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240118Inst : IEnumerable<long>
{
public static readonly long[] Value=A240118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240118.Bytes);
public long this[int i]=>Value[i];

public static A240118Inst Instance=new A240118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240119
{
public static readonly long[] Value={ 1L,4L,4L,6L,7L,11L,14L,18L,19L,30L,32L,37L,42L,57L,64L,70L,77L,104L,112L,121L,130L,167L,178L,194L,205L,248L,267L,286L,301L,362L,378L,401L,425L,494L,520L,547L,574L,667L,697L,728L,759L,870L,904L,948L,984L,1105L,1153L,1202L,1242L,1394L,1438L,1492L,1547L,1711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240119Inst : IEnumerable<long>
{
public static readonly long[] Value=A240119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240119.Bytes);
public long this[int i]=>Value[i];

public static A240119Inst Instance=new A240119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240120
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,9L,19L,121L,275L,2489L,7217L,86775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240120Inst : IEnumerable<long>
{
public static readonly long[] Value=A240120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240120.Bytes);
public long this[int i]=>Value[i];

public static A240120Inst Instance=new A240120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240121
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,13L,5L,183L,75L,4408L,1501L,180324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240121Inst : IEnumerable<long>
{
public static readonly long[] Value=A240121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240121.Bytes);
public long this[int i]=>Value[i];

public static A240121Inst Instance=new A240121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240122
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,12L,40L,154L,760L,3260L,22730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240122Inst : IEnumerable<long>
{
public static readonly long[] Value=A240122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240122.Bytes);
public long this[int i]=>Value[i];

public static A240122Inst Instance=new A240122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240123
{
public static readonly long[] Value={ 0L,0L,1L,3L,19L,107L,847L,8647L,119835L,2255123L,58125783L,2050662011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240123Inst : IEnumerable<long>
{
public static readonly long[] Value=A240123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240123.Bytes);
public long this[int i]=>Value[i];

public static A240123Inst Instance=new A240123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240124
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,19L,109L,1781L,13660L,397689L,5368943L,289864745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240124Inst : IEnumerable<long>
{
public static readonly long[] Value=A240124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240124.Bytes);
public long this[int i]=>Value[i];

public static A240124Inst Instance=new A240124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240125
{
public static readonly long[] Value={ 0L,0L,0L,3L,5L,138L,201L,13032L,19990L,4095612L,7026883L,4451051502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240125Inst : IEnumerable<long>
{
public static readonly long[] Value=A240125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240125.Bytes);
public long this[int i]=>Value[i];

public static A240125Inst Instance=new A240125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240126
{
public static readonly long[] Value={ 19L,31L,109L,151L,241L,619L,859L,1489L,1951L,2131L,2791L,2971L,3559L,4129L,4651L,4789L,4801L,5659L,6661L,6781L,7591L,8221L,8629L,8821L,8971L,9241L,9721L,9931L,10891L,11971L,12109L,12541L,13831L,14011L,15271L,15289L,15331L,16831L,17029L,17419L,17839L,17989L,18121L,18541L,20149L,20899L,21019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240126Inst : IEnumerable<long>
{
public static readonly long[] Value=A240126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240126.Bytes);
public long this[int i]=>Value[i];

public static A240126Inst Instance=new A240126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240127
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,3L,3L,5L,5L,6L,10L,9L,10L,17L,20L,18L,31L,34L,38L,52L,62L,65L,98L,108L,113L,160L,190L,204L,271L,322L,352L,448L,533L,572L,757L,863L,956L,1208L,1401L,1555L,1931L,2242L,2499L,3034L,3527L,3938L,4772L,5529L,6108L,7368L,8524L,9478L,11301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240127Inst : IEnumerable<long>
{
public static readonly long[] Value=A240127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240127.Bytes);
public long this[int i]=>Value[i];

public static A240127Inst Instance=new A240127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240176
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,3L,3L,5L,5L,8L,10L,13L,15L,21L,25L,31L,39L,50L,59L,75L,89L,111L,134L,164L,194L,240L,285L,344L,410L,493L,582L,699L,824L,981L,1157L,1369L,1606L,1901L,2223L,2613L,3054L,3579L,4166L,4871L,5658L,6590L,7645L,8877L,10264L,11900L,13733L,15868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240176Inst : IEnumerable<long>
{
public static readonly long[] Value=A240176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240176.Bytes);
public long this[int i]=>Value[i];

public static A240176Inst Instance=new A240176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240177
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,8L,10L,14L,18L,24L,30L,41L,51L,66L,83L,106L,131L,167L,204L,257L,315L,391L,475L,587L,710L,869L,1049L,1275L,1529L,1852L,2213L,2662L,3173L,3796L,4506L,5373L,6356L,7544L,8900L,10523L,12373L,14585L,17101L,20085L,23494L,27508L,32087L,37471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240177Inst : IEnumerable<long>
{
public static readonly long[] Value=A240177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240177.Bytes);
public long this[int i]=>Value[i];

public static A240177Inst Instance=new A240177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240178
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,4L,5L,7L,9L,13L,16L,22L,27L,36L,44L,59L,71L,93L,114L,144L,176L,223L,268L,336L,407L,502L,605L,744L,891L,1088L,1301L,1574L,1879L,2265L,2687L,3224L,3822L,4557L,5384L,6399L,7535L,8921L,10481L,12354L,14481L,17022L,19888L,23307L,27178L,31745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240178Inst : IEnumerable<long>
{
public static readonly long[] Value=A240178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240178.Bytes);
public long this[int i]=>Value[i];

public static A240178Inst Instance=new A240178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240179
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,5L,8L,11L,17L,23L,33L,43L,61L,79L,108L,140L,187L,238L,314L,397L,513L,648L,826L,1032L,1307L,1622L,2029L,2508L,3113L,3821L,4713L,5754L,7048L,8569L,10431L,12618L,15290L,18413L,22193L,26628L,31954L,38184L,45639L,54340L,64694L,76780L,91077L,107732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240179Inst : IEnumerable<long>
{
public static readonly long[] Value=A240179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240179.Bytes);
public long this[int i]=>Value[i];

public static A240179Inst Instance=new A240179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240180
{
public static readonly long[] Value={ 0L,1L,0L,1L,3L,3L,5L,7L,12L,16L,24L,30L,45L,57L,81L,104L,143L,179L,243L,304L,399L,504L,650L,809L,1039L,1286L,1622L,2006L,2508L,3077L,3822L,4666L,5747L,6995L,8552L,10353L,12603L,15189L,18371L,22071L,26570L,31785L,38104L,45419L,54213L,64426L,76596L,90710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240180Inst : IEnumerable<long>
{
public static readonly long[] Value=A240180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240180.Bytes);
public long this[int i]=>Value[i];

public static A240180Inst Instance=new A240180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240181
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,1L,2L,3L,2L,4L,1L,4L,6L,0L,1L,4L,8L,3L,8L,8L,5L,1L,10L,9L,11L,10L,22L,8L,1L,1L,14L,22L,17L,3L,18L,34L,19L,5L,1L,18L,50L,21L,12L,26L,60L,34L,13L,2L,30L,74L,52L,19L,0L,1L,36L,105L,57L,29L,4L,44L,120L,93L,34L,5L,1L,60L,144L,128L,40L,13L,64L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240181Inst : IEnumerable<long>
{
public static readonly long[] Value=A240181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240181.Bytes);
public long this[int i]=>Value[i];

public static A240181Inst Instance=new A240181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240182
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,5L,4L,8L,10L,13L,15L,25L,25L,37L,46L,61L,70L,97L,112L,150L,177L,224L,270L,347L,407L,508L,611L,754L,895L,1106L,1304L,1594L,1892L,2283L,2708L,3262L,3835L,4595L,5421L,6452L,7574L,8993L,10530L,12445L,14564L,17123L,19992L,23465L,27302L,31931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240182Inst : IEnumerable<long>
{
public static readonly long[] Value=A240182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240182.Bytes);
public long this[int i]=>Value[i];

public static A240182Inst Instance=new A240182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240183
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,2L,0L,3L,3L,4L,2L,9L,3L,10L,10L,17L,11L,26L,19L,36L,33L,48L,47L,79L,71L,101L,109L,149L,151L,215L,216L,293L,318L,404L,443L,575L,611L,773L,864L,1068L,1175L,1458L,1609L,1964L,2210L,2642L,2970L,3577L,3995L,4753L,5369L,6332L,7138L,8414L,9476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240183Inst : IEnumerable<long>
{
public static readonly long[] Value=A240183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240183.Bytes);
public long this[int i]=>Value[i];

public static A240183Inst Instance=new A240183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240184
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,5L,6L,11L,14L,20L,29L,41L,52L,76L,98L,130L,170L,227L,288L,378L,477L,615L,778L,985L,1228L,1551L,1928L,2399L,2964L,3670L,4498L,5538L,6755L,8251L,10027L,12175L,14715L,17802L,21420L,25764L,30886L,37009L,44181L,52731L,62730L,74570L,88435L,104762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240184Inst : IEnumerable<long>
{
public static readonly long[] Value=A240184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240184.Bytes);
public long this[int i]=>Value[i];

public static A240184Inst Instance=new A240184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240185
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,1L,5L,1L,1L,7L,2L,1L,1L,8L,3L,2L,1L,1L,10L,6L,2L,2L,1L,1L,13L,5L,6L,2L,2L,1L,1L,15L,10L,6L,5L,2L,2L,1L,1L,18L,12L,9L,6L,5L,2L,2L,1L,1L,23L,16L,12L,10L,5L,5L,2L,2L,1L,1L,26L,21L,16L,12L,10L,5L,5L,2L,2L,1L,1L,31L,28L,22L,16L,13L,9L,5L,5L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240185Inst : IEnumerable<long>
{
public static readonly long[] Value=A240185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240185.Bytes);
public long this[int i]=>Value[i];

public static A240185Inst Instance=new A240185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240186
{
public static readonly long[] Value={ 1L,5L,37L,771L,91879L,28061567L,43398047802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240186Inst : IEnumerable<long>
{
public static readonly long[] Value=A240186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240186.Bytes);
public long this[int i]=>Value[i];

public static A240186Inst Instance=new A240186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240187
{
public static readonly long[] Value={ 1L,5L,12L,27L,73L,154L,358L,872L,1871L,4438L,10338L,22880L,54100L,123711L,279854L,655190L,1491102L,3413413L,7919449L,18045604L,41514375L,95741087L,218782546L,503899032L,1158409848L,2653808377L,6109601340L,14027233372L,32187863462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240187Inst : IEnumerable<long>
{
public static readonly long[] Value=A240187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240187.Bytes);
public long this[int i]=>Value[i];

public static A240187Inst Instance=new A240187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240188
{
public static readonly long[] Value={ 1L,8L,37L,138L,680L,2413L,10017L,43956L,159668L,681760L,2806434L,10675575L,45462460L,181764269L,715963401L,3000804172L,11895218236L,47847647772L,197325296591L,783759057127L,3182984036915L,12972975259195L,51820141213238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240188Inst : IEnumerable<long>
{
public static readonly long[] Value=A240188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240188.Bytes);
public long this[int i]=>Value[i];

public static A240188Inst Instance=new A240188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240189
{
public static readonly long[] Value={ 1L,14L,129L,771L,7170L,44594L,333607L,2715035L,17332017L,134735700L,1005601984L,6796746485L,52922791645L,379298005594L,2679740305873L,20445193269447L,144861185356798L,1052585343798258L,7856125918090405L,55861298280154250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240189Inst : IEnumerable<long>
{
public static readonly long[] Value=A240189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240189.Bytes);
public long this[int i]=>Value[i];

public static A240189Inst Instance=new A240189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240190
{
public static readonly long[] Value={ 1L,26L,478L,5240L,91879L,1005029L,14022582L,206345434L,2336659626L,33576330306L,449366013476L,5493251593060L,78352851554194L,1004322433621964L,12914862745129353L,179013685774367710L,2278292415139416158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240190Inst : IEnumerable<long>
{
public static readonly long[] Value=A240190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240190.Bytes);
public long this[int i]=>Value[i];

public static A240190Inst Instance=new A240190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240191
{
public static readonly BigInteger[] Value={ 1L,50L,1908L,40765L,1399773L,28061567L,733907809L,19388521135L,394134037392L,10503093361772L,254148197056864L,5694113978673887L,149969038048214610L,3469042519947752022L,BigInteger.Parse("82120588801140926261"),BigInteger.Parse("2085283919698276811475") };
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
public class A240191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240191Inst Instance=new A240191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240208
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,4L,6L,7L,11L,14L,19L,26L,35L,44L,59L,74L,97L,120L,158L,192L,247L,304L,383L,470L,587L,714L,885L,1074L,1317L,1593L,1943L,2334L,2831L,3396L,4086L,4883L,5859L,6966L,8319L,9870L,11726L,13864L,16422L,19345L,22834L,26830L,31548L,36969L,43354L,50651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240208Inst : IEnumerable<long>
{
public static readonly long[] Value=A240208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240208.Bytes);
public long this[int i]=>Value[i];

public static A240208Inst Instance=new A240208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240209
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,3L,3L,4L,7L,9L,13L,18L,24L,30L,41L,50L,70L,85L,117L,140L,182L,225L,287L,348L,442L,537L,672L,818L,1010L,1225L,1509L,1810L,2208L,2655L,3210L,3834L,4629L,5508L,6605L,7851L,9364L,11086L,13188L,15553L,18422L,21682L,25568L,29999L,35285L,41279L,48378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240209Inst : IEnumerable<long>
{
public static readonly long[] Value=A240209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240209.Bytes);
public long this[int i]=>Value[i];

public static A240209Inst Instance=new A240209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240210
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,5L,8L,11L,16L,23L,30L,42L,57L,76L,102L,134L,177L,227L,298L,380L,488L,619L,785L,988L,1244L,1551L,1936L,2401L,2972L,3661L,4508L,5518L,6747L,8224L,10000L,12118L,14671L,17696L,21315L,25612L,30719L,36752L,43916L,52341L,62304L,74010L,87785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240210Inst : IEnumerable<long>
{
public static readonly long[] Value=A240210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240210.Bytes);
public long this[int i]=>Value[i];

public static A240210Inst Instance=new A240210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240211
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,6L,8L,12L,18L,25L,36L,48L,66L,87L,117L,152L,204L,262L,344L,438L,562L,713L,906L,1133L,1430L,1781L,2223L,2754L,3411L,4197L,5170L,6318L,7726L,9402L,11434L,13834L,16747L,20179L,24301L,29166L,34976L,41805L,49940L,59469L,70763L,83986L,99578L,117784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240211Inst : IEnumerable<long>
{
public static readonly long[] Value=A240211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240211.Bytes);
public long this[int i]=>Value[i];

public static A240211Inst Instance=new A240211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240212
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,6L,7L,10L,14L,19L,26L,37L,48L,65L,87L,115L,150L,194L,250L,322L,407L,518L,653L,823L,1029L,1287L,1598L,1984L,2449L,3021L,3706L,4540L,5540L,6752L,8197L,9933L,12004L,14482L,17421L,20924L,25070L,29992L,35797L,42661L,50735L,60254L,71421L,84536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240212Inst : IEnumerable<long>
{
public static readonly long[] Value=A240212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240212.Bytes);
public long this[int i]=>Value[i];

public static A240212Inst Instance=new A240212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240213
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,3L,6L,8L,13L,18L,24L,31L,45L,57L,78L,102L,136L,174L,230L,291L,379L,478L,608L,761L,965L,1196L,1497L,1852L,2299L,2822L,3487L,4258L,5222L,6350L,7737L,9370L,11362L,13687L,16512L,19825L,23806L,28460L,34041L,40552L,48312L,57365L,68081L,80578L,95334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240213Inst : IEnumerable<long>
{
public static readonly long[] Value=A240213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240213.Bytes);
public long this[int i]=>Value[i];

public static A240213Inst Instance=new A240213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240214
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,1L,3L,4L,5L,5L,8L,9L,13L,15L,21L,24L,36L,41L,57L,71L,90L,108L,142L,167L,210L,254L,315L,373L,466L,552L,682L,810L,985L,1173L,1429L,1683L,2030L,2404L,2882L,3390L,4049L,4755L,5651L,6630L,7827L,9157L,10798L,12593L,14788L,17224L,20154L,23420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240214Inst : IEnumerable<long>
{
public static readonly long[] Value=A240214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240214.Bytes);
public long this[int i]=>Value[i];

public static A240214Inst Instance=new A240214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240215
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,4L,5L,7L,9L,12L,18L,25L,32L,44L,57L,74L,95L,123L,155L,199L,248L,314L,394L,494L,610L,762L,939L,1158L,1419L,1743L,2117L,2584L,3127L,3793L,4573L,5513L,6615L,7950L,9503L,11360L,13532L,16123L,19133L,22709L,26863L,31769L,37477L,44176L,51939L,61048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240215Inst : IEnumerable<long>
{
public static readonly long[] Value=A240215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240215.Bytes);
public long this[int i]=>Value[i];

public static A240215Inst Instance=new A240215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240216
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,5L,8L,12L,16L,23L,30L,40L,53L,70L,89L,116L,147L,191L,240L,305L,385L,484L,602L,752L,929L,1149L,1412L,1734L,2116L,2583L,3136L,3809L,4603L,5558L,6686L,8044L,9633L,11533L,13764L,16414L,19513L,23182L,27464L,32514L,38399L,45304L,53333L,62737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240216Inst : IEnumerable<long>
{
public static readonly long[] Value=A240216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240216.Bytes);
public long this[int i]=>Value[i];

public static A240216Inst Instance=new A240216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240217
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,8L,10L,16L,24L,38L,46L,74L,90L,123L,175L,234L,280L,391L,470L,632L,831L,1039L,1243L,1639L,2029L,2477L,3112L,3955L,4704L,6010L,7136L,8709L,10661L,12711L,15578L,19595L,23114L,27336L,32805L,39960L,46834L,56831L,66451L,79684L,96813L,113243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240217Inst : IEnumerable<long>
{
public static readonly long[] Value=A240217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240217.Bytes);
public long this[int i]=>Value[i];

public static A240217Inst Instance=new A240217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240218
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,13L,19L,26L,38L,45L,70L,82L,112L,154L,203L,244L,336L,402L,541L,700L,878L,1052L,1386L,1708L,2095L,2624L,3328L,3971L,5071L,6027L,7377L,9013L,10783L,13220L,16597L,19615L,23277L,27939L,34043L,39982L,48546L,56854L,68240L,82828L,97099L,113268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240218Inst : IEnumerable<long>
{
public static readonly long[] Value=A240218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240218.Bytes);
public long this[int i]=>Value[i];

public static A240218Inst Instance=new A240218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240219
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,8L,5L,9L,10L,14L,7L,24L,8L,22L,31L,28L,10L,56L,11L,71L,68L,47L,13L,143L,69L,66L,147L,216L,16L,367L,17L,241L,304L,122L,509L,1019L,20L,163L,603L,1238L,22L,1712L,23L,1789L,3144L,286L,25L,3956L,1581L,2481L,2101L,4638L,28L,7739L,7357L,9209L,3737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240219Inst : IEnumerable<long>
{
public static readonly long[] Value=A240219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240219.Bytes);
public long this[int i]=>Value[i];

public static A240219Inst Instance=new A240219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240220
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,3L,4L,4L,11L,7L,19L,23L,22L,28L,53L,49L,88L,86L,92L,124L,203L,189L,250L,341L,386L,390L,594L,533L,815L,972L,1130L,1527L,1663L,1380L,2022L,2738L,3246L,3295L,4601L,4628L,6407L,6935L,6306L,8459L,11486L,11493L,13904L,16214L,19615L,21423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240220Inst : IEnumerable<long>
{
public static readonly long[] Value=A240220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240220.Bytes);
public long this[int i]=>Value[i];

public static A240220Inst Instance=new A240220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240221
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,12L,14L,18L,18L,31L,27L,45L,53L,56L,63L,105L,99L,157L,160L,171L,216L,332L,319L,407L,533L,606L,610L,900L,832L,1213L,1434L,1649L,2172L,2399L,2042L,2901L,3849L,4533L,4623L,6340L,6430L,8724L,9450L,8745L,11511L,15449L,15485L,18695L,21716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240221Inst : IEnumerable<long>
{
public static readonly long[] Value=A240221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240221.Bytes);
public long this[int i]=>Value[i];

public static A240221Inst Instance=new A240221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240222
{
public static readonly long[] Value={ 1L,3L,1L,5L,9L,1L,7L,17L,33L,1L,9L,25L,65L,129L,1L,11L,33L,97L,257L,513L,1L,13L,41L,129L,385L,1025L,2049L,1L,15L,49L,161L,513L,1537L,4097L,8193L,1L,17L,57L,193L,641L,2049L,6145L,16385L,32769L,1L,19L,65L,225L,769L,2561L,8193L,24577L,65537L,131073L,1L,21L,73L,257L,897L,3073L,10241L,32769L,98305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240222Inst : IEnumerable<long>
{
public static readonly long[] Value=A240222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240222.Bytes);
public long this[int i]=>Value[i];

public static A240222Inst Instance=new A240222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240223
{
public static readonly long[] Value={ 2L,5L,2L,8L,11L,2L,11L,20L,29L,2L,14L,29L,56L,83L,2L,17L,38L,83L,164L,245L,2L,20L,47L,110L,245L,488L,731L,2L,23L,56L,137L,326L,731L,1460L,2189L,2L,26L,65L,164L,407L,974L,2189L,4376L,6563L,2L,29L,74L,191L,488L,1217L,2918L,6563L,13124L,19685L,2L,32L,83L,218L,569L,1460L,3647L,8750L,19685L,39368L,59051L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240223Inst : IEnumerable<long>
{
public static readonly long[] Value=A240223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240223.Bytes);
public long this[int i]=>Value[i];

public static A240223Inst Instance=new A240223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240544
{
public static readonly long[] Value={ 6L,8L,60L,72L,84L,90L,96L,840L,7560L,9240L,83160L,98280L,720720L,831600L,942480L,982800L,997920L,8648640L,73513440L,82162080L,86486400L,91891800L,98017920L,99459360L,735134400L,821620800L,931170240L,994593600L,6983776800L,8454045600L,9311702400L,9448639200L,9777287520L,97772875200L,963761198400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240544Inst : IEnumerable<long>
{
public static readonly long[] Value=A240544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240544.Bytes);
public long this[int i]=>Value[i];

public static A240544Inst Instance=new A240544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240545
{
public static readonly long[] Value={ 2L,1L,1L,2L,1L,2L,1L,8L,3L,2L,1L,2L,1L,9L,3L,2L,1L,2L,1L,8L,3L,2L,1L,9L,4L,8L,3L,2L,1L,2L,1L,8L,4L,11L,3L,2L,1L,8L,3L,2L,1L,2L,1L,9L,3L,2L,1L,10L,4L,8L,3L,2L,1L,9L,4L,10L,3L,2L,1L,2L,1L,8L,4L,15L,3L,2L,1L,8L,3L,2L,1L,2L,1L,9L,4L,8L,3L,2L,1L,8L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240545Inst : IEnumerable<long>
{
public static readonly long[] Value=A240545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240545.Bytes);
public long this[int i]=>Value[i];

public static A240545Inst Instance=new A240545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240546
{
public static readonly long[] Value={ 1L,1L,3L,4L,10L,1L,9L,5L,16L,9L,26L,10L,33L,1L,2L,49L,33L,3L,35L,48L,3L,32L,62L,64L,4L,20L,8L,62L,93L,83L,64L,41L,68L,79L,138L,125L,88L,56L,4L,169L,72L,36L,40L,144L,73L,140L,63L,120L,24L,218L,67L,48L,58L,194L,126L,54L,74L,223L,74L,59L,176L,161L,280L,208L,215L,236L,82L,141L,139L,344L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240546Inst : IEnumerable<long>
{
public static readonly long[] Value=A240546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240546.Bytes);
public long this[int i]=>Value[i];

public static A240546Inst Instance=new A240546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240547
{
public static readonly long[] Value={ 1L,8L,33L,32L,145L,264L,385L,128L,945L,1160L,1441L,1056L,2353L,3080L,4785L,512L,5185L,7560L,7201L,4640L,12705L,11528L,12673L,4224L,18625L,18824L,26001L,12320L,25201L,38280L,30721L,2048L,47553L,41480L,55825L,30240L,51985L,57608L,77649L,18560L,70561L,101640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240547Inst : IEnumerable<long>
{
public static readonly long[] Value=A240547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240547.Bytes);
public long this[int i]=>Value[i];

public static A240547Inst Instance=new A240547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240548
{
public static readonly long[] Value={ 2L,11L,61L,41L,521L,101L,191L,331L,1181L,9091L,13421L,19141L,2411L,101L,1531L,61681L,101L,9041L,2251L,152381L,185641L,224071L,211L,5791L,9161L,1021L,271L,53951L,401L,71261L,21821L,4051L,1151041L,259631L,132631L,6781L,1824841L,2031671L,41011L,20641L,4111L,23201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240548Inst : IEnumerable<long>
{
public static readonly long[] Value=A240548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240548.Bytes);
public long this[int i]=>Value[i];

public static A240548Inst Instance=new A240548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240549
{
public static readonly long[] Value={ 2L,13L,73L,241L,601L,97L,181L,109L,6481L,9901L,1117L,20593L,28393L,1033L,3877L,673L,83233L,457L,769L,12277L,3181L,1489L,7549L,577L,390001L,2521L,530713L,47221L,421L,809101L,922561L,1321L,91141L,1249L,5413L,1678321L,144061L,2083693L,2311921L,41941L,1993L,4621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240549Inst : IEnumerable<long>
{
public static readonly long[] Value=A240549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240549.Bytes);
public long this[int i]=>Value[i];

public static A240549Inst Instance=new A240549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240550
{
public static readonly long[] Value={ 2L,43L,547L,113L,449L,197L,911L,5419L,16493L,909091L,1623931L,13063L,22079L,7027567L,10678711L,15790321L,22796593L,32222107L,226871L,10529L,81867661L,86969L,2969L,183458857L,234750601L,59011L,2269L,35771L,574995877L,1118041L,71821L,86171L,219409L,104119L,11831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240550Inst : IEnumerable<long>
{
public static readonly long[] Value=A240550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240550.Bytes);
public long this[int i]=>Value[i];

public static A240550Inst Instance=new A240550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240551
{
public static readonly long[] Value={ 2L,257L,193L,65537L,11489L,98801L,169553L,673L,21523361L,5882353L,6304673L,260753L,407865361L,16097L,179953L,6700417L,184417L,113607841L,563377L,1505882353L,300673L,3227992561L,623009L,2311681L,29423041L,57734881L,769L,22223646961L,561377L,4855073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240551Inst : IEnumerable<long>
{
public static readonly long[] Value=A240551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240551.Bytes);
public long this[int i]=>Value[i];

public static A240551Inst Instance=new A240551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240552
{
public static readonly long[] Value={ 2L,19L,37L,109L,5167L,46441L,117307L,87211L,530713L,52579L,590077L,1801L,937L,132049L,811L,38737L,5653L,465841L,236377L,69481L,613L,5966803L,1117L,7561L,6597973L,102966067L,19927L,102547L,10435069L,120871L,1538083L,18837001L,221401L,745903L,612740917L,55117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240552Inst : IEnumerable<long>
{
public static readonly long[] Value=A240552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240552.Bytes);
public long this[int i]=>Value[i];

public static A240552Inst Instance=new A240552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240553
{
public static readonly long[] Value={ 2L,41L,1181L,61681L,9161L,6781L,4021L,1321L,42521761L,27961L,212601841L,85403261L,641L,1383881L,131381L,4278255361L,63541L,145501L,16936647121L,222361L,920421641L,150901L,272341L,1801385941L,632133361L,208518605101L,47763361L,84961L,470925821L,12109381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240553Inst : IEnumerable<long>
{
public static readonly long[] Value=A240553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240553.Bytes);
public long this[int i]=>Value[i];

public static A240553Inst Instance=new A240553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240554
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,2L,5L,2L,1L,5L,5L,3L,2L,1L,3L,17L,7L,17L,2L,1L,7L,13L,13L,41L,11L,2L,1L,2L,37L,7L,257L,61L,13L,2L,1L,3L,5L,31L,313L,41L,73L,43L,2L,1L,5L,13L,43L,1297L,521L,241L,547L,257L,2L,1L,11L,41L,19L,1201L,101L,601L,113L,193L,19L,2L,1L,3L,101L,73L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240554Inst : IEnumerable<long>
{
public static readonly long[] Value=A240554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240554.Bytes);
public long this[int i]=>Value[i];

public static A240554Inst Instance=new A240554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240555
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,16L,17L,18L,21L,45L,52L,53L,54L,57L,59L,65L,79L,167L,168L,193L,196L,197L,201L,203L,204L,207L,218L,227L,249L,250L,277L,313L,650L,658L,679L,682L,683L,716L,727L,741L,744L,748L,751L,772L,791L,831L,834L,837L,839L,843L,855L,876L,909L,912L,972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240555Inst : IEnumerable<long>
{
public static readonly long[] Value=A240555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240555.Bytes);
public long this[int i]=>Value[i];

public static A240555Inst Instance=new A240555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240556
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,11L,15L,16L,27L,47L,48L,64L,95L,175L,196L,211L,212L,214L,247L,249L,252L,398L,839L,1002L,1014L,1016L,1035L,1036L,1037L,1051L,1054L,1072L,1121L,1143L,1146L,1172L,1258L,4271L,4282L,4284L,4336L,4571L,4578L,4582L,4598L,4613L,4622L,4628L,4646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240556Inst : IEnumerable<long>
{
public static readonly long[] Value=A240556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240556.Bytes);
public long this[int i]=>Value[i];

public static A240556Inst Instance=new A240556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240557
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,16L,17L,28L,48L,49L,65L,96L,176L,197L,212L,213L,215L,248L,250L,253L,399L,840L,1003L,1015L,1017L,1036L,1037L,1038L,1052L,1055L,1073L,1122L,1144L,1147L,1173L,1259L,4272L,4283L,4285L,4337L,4572L,4579L,4583L,4599L,4614L,4623L,4629L,4647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240557Inst : IEnumerable<long>
{
public static readonly long[] Value=A240557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240557.Bytes);
public long this[int i]=>Value[i];

public static A240557Inst Instance=new A240557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240558
{
public static readonly long[] Value={ 1L,2L,4L,24L,32L,320L,320L,4480L,3584L,64512L,43008L,946176L,540672L,14057472L,7028736L,210862080L,93716480L,3186360320L,1274544128L,48432676864L,17611882496L,739699064832L,246566354944L,11342052327424L,3489862254592L,174493112729600L,49855175065600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240558Inst : IEnumerable<long>
{
public static readonly long[] Value=A240558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240558.Bytes);
public long this[int i]=>Value[i];

public static A240558Inst Instance=new A240558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240559
{
public static readonly BigInteger[] Value={ 0L,0L,1L,-3L,-5L,45L,61L,-1113L,-1385L,42585L,50521L,-2348973L,-2702765L,176992725L,199360981L,-17487754833L,-19391512145L,2195014332465L,2404879675441L,-341282303124693L,-370371188237525L,64397376340013805L,69348874393137901L,BigInteger.Parse("-14499110277050234553") };
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
public class A240559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240559.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240559Inst Instance=new A240559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240672
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,2L,0L,3L,0L,1L,0L,0L,4L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,2L,0L,1L,2L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,0L,1L,1L,0L,2L,0L,2L,0L,0L,1L,1L,0L,2L,0L,0L,0L,9L,2L,0L,1L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,0L,2L,1L,0L,2L,0L,3L,0L,0L,1L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240672Inst : IEnumerable<long>
{
public static readonly long[] Value=A240672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240672.Bytes);
public long this[int i]=>Value[i];

public static A240672Inst Instance=new A240672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240673
{
public static readonly long[] Value={ 1L,3L,4L,15L,10L,6L,105L,70L,126L,120L,1155L,1540L,1386L,330L,210L,15015L,20020L,6006L,25740L,16380L,6930L,255255L,170170L,306306L,145860L,46410L,157080L,450450L,4849845L,3233230L,3879876L,8314020L,6172530L,3730650L,9129120L,9189180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240673Inst : IEnumerable<long>
{
public static readonly long[] Value=A240673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240673.Bytes);
public long this[int i]=>Value[i];

public static A240673Inst Instance=new A240673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240674
{
public static readonly long[] Value={ 0L,2L,2L,2L,2L,4L,4L,8L,10L,10L,14L,18L,18L,26L,30L,36L,44L,60L,64L,82L,96L,114L,130L,164L,176L,222L,248L,296L,338L,406L,450L,550L,620L,726L,816L,968L,1074L,1270L,1418L,1648L,1836L,2150L,2382L,2758L,3080L,3534L,3942L,4538L,5034L,5778L,6416L,7312L,8136L,9258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240674Inst : IEnumerable<long>
{
public static readonly long[] Value=A240674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240674.Bytes);
public long this[int i]=>Value[i];

public static A240674Inst Instance=new A240674Inst();

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