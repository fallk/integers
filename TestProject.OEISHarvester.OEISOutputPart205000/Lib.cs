using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A243382
{
public static readonly long[] Value={ 7L,35L,158L,715L,3406L,17366L,94907L,553807L,3433490L,22512257L,155472029L,1126989053L,8548807676L,67679513141L,557899676487L,4778535406628L,42448208962613L,390404810629273L,3711893438414835L,36432789329793687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243382Inst : IEnumerable<long>
{
public static readonly long[] Value=A243382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243382.Bytes);
public long this[int i]=>Value[i];

public static A243382Inst Instance=new A243382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243383
{
public static readonly long[] Value={ 13L,35L,96L,265L,733L,2029L,5618L,15557L,43081L,119303L,330384L,914929L,2533705L,7016569L,19430930L,53809925L,149015413L,412667243L,1142796240L,3164736889L,8764081669L,24270304357L,67211568290L,186128482181L,515444182609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243383Inst : IEnumerable<long>
{
public static readonly long[] Value=A243383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243383.Bytes);
public long this[int i]=>Value[i];

public static A243383Inst Instance=new A243383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243384
{
public static readonly long[] Value={ 14L,45L,158L,579L,2165L,8173L,30991L,117755L,447850L,1704019L,6484899L,24681529L,93941906L,357565151L,1360989974L,5180318659L,19717818240L,75051888869L,285669958665L,1087345593405L,4138764004397L,15753379857391L,59962100096460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243384Inst : IEnumerable<long>
{
public static readonly long[] Value=A243384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243384.Bytes);
public long this[int i]=>Value[i];

public static A243384Inst Instance=new A243384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243385
{
public static readonly long[] Value={ 14L,46L,173L,715L,3145L,14384L,67346L,319672L,1529489L,7351421L,35426903L,170980301L,825907764L,3991445874L,19295275085L,93291388393L,451099271256L,2181351172153L,10548535213429L,51011281199382L,246686056919318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243385Inst : IEnumerable<long>
{
public static readonly long[] Value=A243385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243385.Bytes);
public long this[int i]=>Value[i];

public static A243385Inst Instance=new A243385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243386
{
public static readonly long[] Value={ 14L,46L,174L,736L,3406L,16910L,88473L,480524L,2677917L,15183903L,87081621L,503166559L,2921501848L,17016444696L,99315740914L,580419063740L,3394980926065L,19868915344505L,116323465551363L,681180045964207L,3989535214948663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243386Inst : IEnumerable<long>
{
public static readonly long[] Value=A243386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243386.Bytes);
public long this[int i]=>Value[i];

public static A243386Inst Instance=new A243386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243387
{
public static readonly long[] Value={ 14L,46L,174L,737L,3434L,17366L,94164L,541060L,3257286L,20333069L,130439432L,853756157L,5669606647L,38041540586L,257118895765L,1746784622435L,11909889453316L,81408594286227L,557440239347213L,3821747622458620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243387Inst : IEnumerable<long>
{
public static readonly long[] Value=A243387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243387.Bytes);
public long this[int i]=>Value[i];

public static A243387Inst Instance=new A243387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243388
{
public static readonly long[] Value={ 14L,46L,174L,737L,3435L,17402L,94907L,552660L,3409915L,22122613L,149763921L,1050072965L,7573195764L,55841366002L,418835322674L,3182422956259L,24417445081110L,188710025928915L,1466319454136469L,11439104238553624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243388Inst : IEnumerable<long>
{
public static readonly long[] Value=A243388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243388.Bytes);
public long this[int i]=>Value[i];

public static A243388Inst Instance=new A243388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243389
{
public static readonly long[] Value={ 7L,13L,12L,14L,35L,21L,14L,45L,96L,37L,14L,46L,158L,265L,65L,14L,46L,173L,579L,733L,114L,14L,46L,174L,715L,2165L,2029L,200L,14L,46L,174L,736L,3145L,8173L,5618L,351L,14L,46L,174L,737L,3406L,14384L,30991L,15557L,616L,14L,46L,174L,737L,3434L,16910L,67346L,117755L,43081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243389Inst : IEnumerable<long>
{
public static readonly long[] Value=A243389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243389.Bytes);
public long this[int i]=>Value[i];

public static A243389Inst Instance=new A243389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243390
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,9L,10L,12L,15L,16L,20L,22L,39L,44L,46L,48L,65L,66L,77L,87L,93L,99L,123L,134L,146L,154L,165L,230L,246L,430L,441L,446L,494L,522L,528L,552L,555L,566L,622L,662L,711L,737L,738L,740L,825L,855L,984L,1155L,1160L,1170L,1180L,1214L,2230L,5055L,8878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243390Inst : IEnumerable<long>
{
public static readonly long[] Value=A243390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243390.Bytes);
public long this[int i]=>Value[i];

public static A243390Inst Instance=new A243390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243391
{
public static readonly long[] Value={ 1L,3L,4L,12L,22L,68L,166L,534L,1589L,5464L,18579L,68320L,255424L,1000852L,4018156L,16671976L,70890940L,309439942L,1381815168L,6310880471L,29428287639L,140012980007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243391Inst : IEnumerable<long>
{
public static readonly long[] Value=A243391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243391.Bytes);
public long this[int i]=>Value[i];

public static A243391Inst Instance=new A243391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243392
{
public static readonly long[] Value={ 2L,3L,4L,12L,22L,68L,166L,534L,1589L,5464L,18579L,68320L,255424L,1000852L,4018156L,16671976L,70890940L,309439942L,1381815168L,6310880471L,29428287639L,140012980007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243392Inst : IEnumerable<long>
{
public static readonly long[] Value=A243392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243392.Bytes);
public long this[int i]=>Value[i];

public static A243392Inst Instance=new A243392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243393
{
public static readonly long[] Value={ 1L,1L,2L,6L,10L,29L,64L,194L,531L,1733L,5524L,19430L,69322L,262044L,1016740L,4101318L,16996157L,72556640L,317558689L,1424644848L,6536588420L,30647561117L,146647344812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243393Inst : IEnumerable<long>
{
public static readonly long[] Value=A243393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243393.Bytes);
public long this[int i]=>Value[i];

public static A243393Inst Instance=new A243393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243394
{
public static readonly long[] Value={ 2L,5L,7L,22L,43L,141L,373L,1270L,4053L,14671L,52826L,203289L,795581L,3241367L,13504130L,57904671L,253856990L,1139231977L,5219113084L,24401837085L,116278408069L,564380686932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243394Inst : IEnumerable<long>
{
public static readonly long[] Value=A243394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243394.Bytes);
public long this[int i]=>Value[i];

public static A243394Inst Instance=new A243394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243395
{
public static readonly long[] Value={ 1L,1L,5L,7L,4L,1L,9L,8L,0L,3L,8L,1L,9L,2L,8L,0L,2L,6L,4L,4L,8L,2L,6L,3L,5L,4L,5L,0L,8L,4L,0L,9L,4L,6L,2L,5L,4L,6L,8L,6L,4L,2L,8L,6L,2L,7L,9L,7L,0L,4L,1L,9L,4L,1L,3L,4L,2L,2L,0L,5L,2L,6L,8L,2L,4L,5L,2L,0L,2L,3L,9L,8L,7L,8L,5L,9L,4L,4L,2L,3L,7L,7L,0L,0L,3L,0L,4L,5L,7L,5L,5L,8L,4L,5L,0L,6L,6L,8L,4L,2L,3L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243395Inst : IEnumerable<long>
{
public static readonly long[] Value=A243395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243395.Bytes);
public long this[int i]=>Value[i];

public static A243395Inst Instance=new A243395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243396
{
public static readonly long[] Value={ 4L,6L,5L,6L,3L,8L,6L,4L,6L,7L,7L,9L,0L,7L,5L,7L,3L,7L,1L,0L,9L,9L,7L,5L,9L,1L,0L,2L,6L,4L,2L,9L,0L,5L,7L,4L,6L,3L,2L,5L,5L,0L,1L,4L,6L,1L,7L,4L,3L,4L,8L,3L,8L,9L,3L,5L,6L,0L,0L,9L,9L,0L,1L,9L,1L,7L,6L,5L,1L,3L,9L,2L,6L,1L,0L,8L,8L,0L,4L,7L,7L,5L,6L,9L,3L,4L,0L,6L,6L,6L,1L,8L,9L,8L,4L,9L,7L,3L,8L,8L,6L,1L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243396Inst : IEnumerable<long>
{
public static readonly long[] Value=A243396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243396.Bytes);
public long this[int i]=>Value[i];

public static A243396Inst Instance=new A243396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243397
{
public static readonly long[] Value={ 0L,1L,3L,21L,145L,273L,1425L,9613L,15711L,18445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243397Inst : IEnumerable<long>
{
public static readonly long[] Value=A243397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243397.Bytes);
public long this[int i]=>Value[i];

public static A243397Inst Instance=new A243397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243398
{
public static readonly long[] Value={ 1L,2L,6L,1L,0L,7L,0L,4L,8L,6L,8L,3L,0L,6L,7L,8L,9L,0L,5L,8L,3L,9L,6L,5L,5L,1L,4L,7L,9L,6L,2L,6L,1L,2L,8L,3L,1L,6L,3L,3L,8L,6L,5L,9L,6L,9L,6L,4L,4L,1L,6L,7L,3L,7L,8L,6L,9L,8L,5L,6L,2L,5L,8L,2L,0L,5L,5L,7L,6L,7L,2L,0L,3L,6L,1L,2L,8L,7L,5L,4L,2L,5L,4L,2L,2L,0L,3L,2L,1L,7L,6L,7L,0L,7L,2L,8L,9L,9L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243398Inst : IEnumerable<long>
{
public static readonly long[] Value=A243398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243398.Bytes);
public long this[int i]=>Value[i];

public static A243398Inst Instance=new A243398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243399
{
public static readonly BigInteger[] Value={ 1L,19L,362L,6897L,131405L,2503592L,47699653L,908796999L,17314842634L,329890807045L,6285240176489L,119749454160336L,2281524869222873L,43468721969394923L,828187242287726410L,15779026325436196713UL,BigInteger.Parse("300629687425575463957"),BigInteger.Parse("5727743087411370011896") };
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
public class A243399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243399Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243399.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243399Inst Instance=new A243399Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243400
{
public static readonly long[] Value={ 5L,7L,17L,37L,79L,157L,239L,269L,277L,359L,419L,449L,467L,557L,677L,739L,787L,829L,857L,977L,1319L,1399L,1597L,1657L,2069L,2269L,2297L,2377L,2437L,2459L,2819L,2969L,2999L,3019L,3137L,3299L,3389L,3407L,3967L,4007L,4099L,4357L,4547L,4729L,4987L,5179L,5419L,5569L,5779L,6637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243400Inst : IEnumerable<long>
{
public static readonly long[] Value=A243400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243400.Bytes);
public long this[int i]=>Value[i];

public static A243400Inst Instance=new A243400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243401
{
public static readonly long[] Value={ 5L,23L,41L,61L,73L,103L,109L,157L,167L,181L,307L,311L,347L,367L,467L,577L,593L,601L,677L,709L,739L,839L,863L,1039L,1181L,1201L,1279L,1381L,1399L,1621L,1627L,1789L,1847L,1861L,1871L,1913L,1997L,2063L,2287L,2347L,2371L,2657L,2699L,2797L,2887L,2963L,3209L,3343L,3359L,3623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243401Inst : IEnumerable<long>
{
public static readonly long[] Value=A243401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243401.Bytes);
public long this[int i]=>Value[i];

public static A243401Inst Instance=new A243401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243402
{
public static readonly long[] Value={ 449L,839L,857L,941L,977L,1109L,1289L,1607L,1901L,2591L,2711L,3041L,3299L,4007L,4349L,4721L,5531L,5849L,6311L,6779L,6911L,7451L,7829L,7907L,8369L,8597L,8999L,9419L,9767L,11351L,12917L,13421L,14321L,14969L,15077L,15131L,15227L,15551L,15809L,16649L,16979L,17021L,17291L,17417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243402Inst : IEnumerable<long>
{
public static readonly long[] Value=A243402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243402.Bytes);
public long this[int i]=>Value[i];

public static A243402Inst Instance=new A243402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243403
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,0L,3L,2L,3L,2L,1L,3L,3L,2L,3L,4L,4L,1L,4L,1L,2L,2L,5L,8L,5L,1L,1L,5L,3L,6L,6L,7L,6L,6L,4L,2L,4L,3L,6L,11L,6L,4L,3L,7L,6L,8L,3L,2L,10L,9L,6L,11L,2L,8L,9L,9L,5L,2L,5L,2L,3L,13L,5L,14L,8L,12L,7L,8L,9L,6L,13L,9L,4L,10L,3L,13L,12L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243403Inst : IEnumerable<long>
{
public static readonly long[] Value=A243403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243403.Bytes);
public long this[int i]=>Value[i];

public static A243403Inst Instance=new A243403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243404
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,564L,1L,10L,2L,2L,1L,14L,1L,2L,2L,8L,1L,2L,5L,2L,3L,2L,1L,2L,1L,252L,3L,20L,2L,6L,1L,2L,2L,4L,1L,24L,1L,2L,2L,2L,1L,2L,3L,2L,17L,24L,1L,2L,2L,2L,3L,4L,1L,2L,1L,4L,11L,2L,2L,2L,1L,2L,555L,2L,1L,8L,1L,12L,3L,2L,3L,6L,1L,4L,6L,680L,1L,6L,2L,2L,3L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243404Inst : IEnumerable<long>
{
public static readonly long[] Value=A243404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243404.Bytes);
public long this[int i]=>Value[i];

public static A243404Inst Instance=new A243404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243405
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,16L,27L,25L,11L,64L,13L,49L,125L,256L,17L,512L,19L,625L,343L,121L,23L,4096L,3125L,169L,19683L,2401L,29L,15625L,31L,65536L,1331L,289L,16807L,262144L,37L,361L,2197L,390625L,41L,117649L,43L,14641L,1953125L,529L,47L,16777216L,823543L,9765625L,4913L,28561L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243405Inst : IEnumerable<long>
{
public static readonly long[] Value=A243405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243405.Bytes);
public long this[int i]=>Value[i];

public static A243405Inst Instance=new A243405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243406
{
public static readonly long[] Value={ 2L,0L,8L,5L,8L,8L,5L,7L,9L,6L,7L,5L,9L,9L,0L,6L,5L,5L,2L,8L,8L,9L,0L,4L,0L,8L,7L,0L,1L,4L,2L,9L,7L,0L,4L,5L,6L,6L,5L,6L,0L,3L,3L,2L,0L,3L,6L,9L,5L,8L,3L,8L,5L,1L,2L,7L,1L,6L,0L,0L,6L,8L,4L,7L,2L,0L,0L,9L,4L,4L,0L,4L,0L,9L,4L,1L,1L,4L,4L,4L,9L,7L,9L,4L,4L,6L,9L,3L,9L,3L,6L,0L,4L,4L,3L,3L,8L,7L,5L,2L,2L,5L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243406Inst : IEnumerable<long>
{
public static readonly long[] Value=A243406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243406.Bytes);
public long this[int i]=>Value[i];

public static A243406Inst Instance=new A243406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243407
{
public static readonly long[] Value={ 3L,2L,4L,3L,9L,9L,1L,0L,5L,0L,5L,9L,5L,3L,1L,0L,2L,5L,9L,4L,1L,5L,4L,8L,4L,4L,5L,2L,5L,2L,3L,5L,6L,8L,8L,0L,2L,4L,1L,5L,6L,3L,0L,7L,6L,6L,9L,9L,6L,3L,6L,7L,7L,3L,6L,3L,4L,3L,3L,0L,4L,0L,2L,6L,2L,6L,3L,3L,7L,9L,6L,7L,0L,1L,1L,8L,9L,5L,3L,6L,7L,9L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243407Inst : IEnumerable<long>
{
public static readonly long[] Value=A243407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243407.Bytes);
public long this[int i]=>Value[i];

public static A243407Inst Instance=new A243407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243408
{
public static readonly long[] Value={ 2L,11L,83L,149L,347L,1301L,1607L,2531L,6299L,7727L,8273L,17117L,20183L,21737L,24371L,26669L,39227L,40277L,53951L,54917L,63347L,66359L,66467L,73637L,82217L,82373L,101537L,102251L,106397L,106871L,117203L,132971L,134033L,135221L,140237L,144701L,146141L,151433L,152597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243408Inst : IEnumerable<long>
{
public static readonly long[] Value=A243408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243408.Bytes);
public long this[int i]=>Value[i];

public static A243408Inst Instance=new A243408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243409
{
public static readonly long[] Value={ 2L,797L,1193L,6803L,15773L,28793L,35507L,41579L,53189L,53279L,57347L,60161L,70457L,77549L,81839L,140549L,143387L,150779L,151241L,164447L,170627L,201011L,255083L,285287L,293831L,300317L,316073L,336671L,343661L,449921L,470087L,486947L,488603L,518801L,556289L,569243L,602087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243409Inst : IEnumerable<long>
{
public static readonly long[] Value=A243409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243409.Bytes);
public long this[int i]=>Value[i];

public static A243409Inst Instance=new A243409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243410
{
public static readonly long[] Value={ 10193L,13217L,34457L,36767L,57773L,76631L,103043L,157823L,191033L,194813L,212243L,229799L,242273L,242867L,249377L,256889L,261563L,264071L,361511L,457871L,486293L,502841L,508517L,647837L,653621L,694409L,697511L,777437L,798143L,825611L,847031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243410Inst : IEnumerable<long>
{
public static readonly long[] Value=A243410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243410.Bytes);
public long this[int i]=>Value[i];

public static A243410Inst Instance=new A243410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243411
{
public static readonly long[] Value={ 2L,2L,10193L,24851L,20549L,719L,22133L,230471L,46679L,432449L,114689L,227603L,305297L,61463L,1866467L,866309L,1189403L,362081L,2615783L,493433L,966353L,4154363L,6562931L,9096203L,3701627L,3128813L,20983727L,303593L,24437537L,1068491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243411Inst : IEnumerable<long>
{
public static readonly long[] Value=A243411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243411.Bytes);
public long this[int i]=>Value[i];

public static A243411Inst Instance=new A243411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243412
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,37L,112L,352L,1136L,3742L,12529L,42513L,145868L,505234L,1764157L,6203370L,21947490L,78072209L,279062937L,1001803617L,3610366030L,13057141261L,47373444827L,172381857939L,628944880851L,2300410562946L,8433110899963L,30980398420830L,114034887644860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243412Inst : IEnumerable<long>
{
public static readonly long[] Value=A243412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243412.Bytes);
public long this[int i]=>Value[i];

public static A243412Inst Instance=new A243412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243413
{
public static readonly long[] Value={ 1L,5L,19L,70L,259L,962L,3585L,13399L,50201L,188481L,709001L,2671624L,10082895L,38107919L,144214978L,546413880L,2072553851L,7869081412L,29904874545L,113744129791L,432969825404L,1649313815911L,6287005845873L,23980562901849L,91523321091182L,349497990760012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243413Inst : IEnumerable<long>
{
public static readonly long[] Value=A243413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243413.Bytes);
public long this[int i]=>Value[i];

public static A243413Inst Instance=new A243413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243414
{
public static readonly long[] Value={ 1L,7L,34L,149L,627L,2584L,10529L,42606L,171563L,688255L,2752912L,10985005L,43747708L,173937910L,690592594L,2738547328L,10848121023L,42931655341L,169759128539L,670744883641L,2648384384709L,10450336782375L,41212385684767L,162440029038575L,639946101535124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243414Inst : IEnumerable<long>
{
public static readonly long[] Value=A243414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243414.Bytes);
public long this[int i]=>Value[i];

public static A243414Inst Instance=new A243414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243415
{
public static readonly long[] Value={ 1L,9L,54L,279L,1334L,6092L,27048L,117896L,507173L,2160151L,9128266L,38326830L,160063712L,665442560L,2755685897L,11372798741L,46794914849L,192029181971L,786126469079L,3211253947191L,13091799706905L,53277016211285L,216451122516387L,878040805034630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243415Inst : IEnumerable<long>
{
public static readonly long[] Value=A243415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243415.Bytes);
public long this[int i]=>Value[i];

public static A243415Inst Instance=new A243415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243416
{
public static readonly long[] Value={ 1L,11L,79L,474L,2561L,12937L,62524L,293146L,1344602L,6065734L,27007870L,118984043L,519589872L,2252141576L,9699519424L,41541816291L,177048628294L,751293699026L,3175665502731L,13376228005419L,56162636663430L,235124074987923L,981718571224412L,4088916793922566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243416Inst : IEnumerable<long>
{
public static readonly long[] Value=A243416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243416.Bytes);
public long this[int i]=>Value[i];

public static A243416Inst Instance=new A243416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243417
{
public static readonly long[] Value={ 1L,13L,109L,748L,4531L,25228L,132515L,667747L,3263146L,15576803L,72995158L,336986263L,1536565549L,6933515253L,31007787862L,137599702886L,606467289880L,2656919897648L,11577389890752L,50204031478108L,216750954307831L,932068704988570L,3993428974519241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243417Inst : IEnumerable<long>
{
public static readonly long[] Value=A243417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243417.Bytes);
public long this[int i]=>Value[i];

public static A243417Inst Instance=new A243417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243418
{
public static readonly long[] Value={ 1L,15L,144L,1115L,7509L,45864L,261185L,1412742L,7350116L,37106514L,182907585L,884290974L,4207172844L,19747711113L,91627676418L,420914259695L,1916722429108L,8660949017183L,38866735108620L,173341678278027L,768774806179919L,3392247359157876L,14899045118613987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243418Inst : IEnumerable<long>
{
public static readonly long[] Value=A243418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243418.Bytes);
public long this[int i]=>Value[i];

public static A243418Inst Instance=new A243418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243419
{
public static readonly long[] Value={ 1L,17L,184L,1589L,11802L,78666L,484163L,2806039L,15527186L,82851064L,429392845L,2173167944L,10783733773L,52629404231L,253233665755L,1203597734972L,5659518993517L,26361150741197L,121755788054172L,558129404726455L,2541096189931118L,11497990460196322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243419Inst : IEnumerable<long>
{
public static readonly long[] Value=A243419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243419.Bytes);
public long this[int i]=>Value[i];

public static A243419Inst Instance=new A243419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243420
{
public static readonly long[] Value={ 1L,19L,229L,2184L,17759L,128509L,851831L,5278129L,31020976L,174803309L,952033480L,5042006351L,26087126992L,132340281386L,660143136637L,3245280843311L,15751929981822L,75602686035094L,359256881535197L,1691965976395069L,7904617778358794L,36660673151053000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243420Inst : IEnumerable<long>
{
public static readonly long[] Value=A243420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243420.Bytes);
public long this[int i]=>Value[i];

public static A243420Inst Instance=new A243420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243421
{
public static readonly long[] Value={ 1L,21L,279L,2914L,25771L,201454L,1433041L,9469739L,59016909L,350829247L,2006522229L,11114963598L,59942608977L,316006164419L,1633786190804L,8305527032158L,41603804525306L,205707814621939L,1005426524364506L,4863626362504773L,23309223454202475L,110773290856066906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243421Inst : IEnumerable<long>
{
public static readonly long[] Value=A243421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243421.Bytes);
public long this[int i]=>Value[i];

public static A243421Inst Instance=new A243421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243422
{
public static readonly long[] Value={ 1L,23L,334L,3793L,36271L,304880L,2319261L,16302850L,107540243L,673544651L,4041910962L,23405090601L,131512656290L,720269482372L,3858780032696L,20281334280042L,104826233409130L,533858971182764L,2683369513323113L,13330082269584906L,65522957179453221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243422Inst : IEnumerable<long>
{
public static readonly long[] Value=A243422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243422.Bytes);
public long this[int i]=>Value[i];

public static A243422Inst Instance=new A243422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243423
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,2L,3L,4L,2L,4L,4L,4L,4L,4L,3L,4L,4L,6L,2L,6L,4L,6L,6L,6L,3L,6L,5L,4L,4L,6L,5L,6L,4L,6L,5L,6L,6L,3L,6L,4L,6L,8L,5L,4L,6L,4L,8L,8L,4L,4L,8L,5L,8L,8L,6L,6L,8L,5L,6L,8L,2L,8L,8L,6L,6L,9L,6L,4L,8L,6L,6L,6L,9L,6L,4L,9L,6L,8L,4L,10L,6L,6L,6L,9L,8L,2L,10L,8L,8L,12L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243423Inst : IEnumerable<long>
{
public static readonly long[] Value=A243423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243423.Bytes);
public long this[int i]=>Value[i];

public static A243423Inst Instance=new A243423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243424
{
public static readonly long[] Value={ 1L,1L,1L,6L,3L,1L,20L,110L,180L,58L,1L,42L,657L,4890L,18343L,33792L,27380L,7416L,280L,1L,72L,2172L,36028L,362643L,2307376L,9382388L,24121696L,37965171L,34431880L,16172160L,3219364L,170985L,1L,110L,5375L,154434L,2911226L,38049764L,355340561L,2408715568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243424Inst : IEnumerable<long>
{
public static readonly long[] Value=A243424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243424.Bytes);
public long this[int i]=>Value[i];

public static A243424Inst Instance=new A243424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243425
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,60L,417L,3430L,29927L,278316L,2693437L,26976407L,277394148L,2916106328L,31220964707L,339508802940L,3741551907530L,41714692453164L,469827584596185L,5339334757945439L,61165396353689573L,705720529604453193L,8195208178337460065L,BigInteger.Parse("95724512701573485819"),BigInteger.Parse("1124070800784913396731") };
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
public class A243425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243425Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243425.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243425Inst Instance=new A243425Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243426
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,215L,3019L,50750L,978792L,21118641L,501447228L,12954812178L,361153740034L,10796374169997L,344373435613191L,11672904804892441L,419017404782400368L,15881588444144243375UL,BigInteger.Parse("633896023527831462147"),BigInteger.Parse("26581090260348132921162"),BigInteger.Parse("1168473922210084561137995") };
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
public class A243426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243426Inst Instance=new A243426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243427
{
public static readonly long[] Value={ 4L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243427Inst : IEnumerable<long>
{
public static readonly long[] Value=A243427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243427.Bytes);
public long this[int i]=>Value[i];

public static A243427Inst Instance=new A243427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243428
{
public static readonly long[] Value={ 4L,6L,10L,14L,22L,25L,35L,39L,95L,123L,129L,177L,289L,309L,327L,355L,415L,445L,471L,497L,543L,689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243428Inst : IEnumerable<long>
{
public static readonly long[] Value=A243428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243428.Bytes);
public long this[int i]=>Value[i];

public static A243428Inst Instance=new A243428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243429
{
public static readonly BigInteger[] Value={ 41L,43L,47L,71L,103L,167L,1063L,2087L,8231L,131111L,536870951L,8589934631L,549755813927L,8796093022247L,BigInteger.Parse("154742504910672534362390567"),BigInteger.Parse("40564819207303340847894502572071"),BigInteger.Parse("162259276829213363391578010288167"),BigInteger.Parse("2722258935367507707706996859454145691687") };
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
public class A243429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243429Inst Instance=new A243429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243430
{
public static readonly BigInteger[] Value={ 47L,59L,107L,4139L,16427L,65579L,262187L,16777259L,BigInteger.Parse("302231454903657293676587"),BigInteger.Parse("4835703278458516698824747"),BigInteger.Parse("20769187434139310514121985316880427") };
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
public class A243430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243430.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243430Inst Instance=new A243430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243431
{
public static readonly BigInteger[] Value={ 47L,53L,61L,109L,173L,557L,1069L,8237L,65581L,134217773L,2147483693L,549755813933L,BigInteger.Parse("4835703278458516698824749"),BigInteger.Parse("19342813113834066795298861"),BigInteger.Parse("170141183460469231731687303715884105773"),BigInteger.Parse("2854495385411919762116571938898990272765493293") };
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
public class A243431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243431Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243431.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243431.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243431Inst Instance=new A243431Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243432
{
public static readonly BigInteger[] Value={ 79L,BigInteger.Parse("822752278660603021077484591278675252491367932816789931674304559") };
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
public class A243432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243432Inst Instance=new A243432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243433
{
public static readonly long[] Value={ 1L,0L,8L,2L,0L,8L,8L,4L,4L,9L,2L,7L,0L,3L,6L,3L,3L,9L,6L,9L,4L,5L,5L,1L,8L,6L,6L,0L,4L,8L,2L,9L,5L,4L,3L,7L,2L,7L,8L,1L,2L,0L,9L,3L,5L,3L,6L,5L,3L,6L,5L,1L,7L,7L,4L,9L,1L,2L,7L,0L,8L,4L,3L,3L,8L,1L,6L,8L,4L,1L,1L,1L,7L,5L,9L,6L,2L,9L,3L,9L,5L,0L,6L,2L,8L,7L,8L,3L,8L,2L,0L,4L,2L,6L,4L,5L,5L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243433Inst : IEnumerable<long>
{
public static readonly long[] Value=A243433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243433.Bytes);
public long this[int i]=>Value[i];

public static A243433Inst Instance=new A243433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243434
{
public static readonly long[] Value={ 1L,2L,6L,1L,5L,2L,2L,5L,1L,0L,1L,4L,8L,5L,0L,3L,9L,2L,9L,7L,0L,5L,0L,9L,1L,1L,0L,9L,1L,6L,2L,6L,9L,3L,9L,5L,3L,3L,8L,4L,0L,1L,2L,7L,4L,5L,4L,4L,3L,7L,1L,5L,4L,3L,0L,0L,1L,0L,7L,6L,9L,1L,3L,6L,3L,5L,3L,2L,0L,5L,5L,6L,9L,3L,4L,3L,6L,2L,4L,8L,4L,2L,5L,3L,8L,1L,0L,2L,4L,8L,6L,1L,0L,2L,0L,6L,0L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243434Inst : IEnumerable<long>
{
public static readonly long[] Value=A243434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243434.Bytes);
public long this[int i]=>Value[i];

public static A243434Inst Instance=new A243434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243435
{
public static readonly BigInteger[] Value={ 1L,1L,3L,29L,686L,30552L,2191262L,230356646L,33349943718L,6359939775042L,1545000640114242L,465750550069828422L,BigInteger.Parse("170603300462464687996"),BigInteger.Parse("74630981535308266499848"),BigInteger.Parse("38429419191031108995080412"),BigInteger.Parse("23008323194727484508595195772"),BigInteger.Parse("15848730592891024979096686043722"),BigInteger.Parse("12445298391963001703710163766096546") };
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
public class A243435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243435Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243435.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243435Inst Instance=new A243435Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243436
{
public static readonly long[] Value={ 8L,13L,15L,18L,19L,23L,24L,26L,28L,30L,33L,34L,35L,38L,41L,44L,50L,52L,58L,59L,62L,64L,68L,70L,72L,73L,74L,75L,76L,78L,79L,80L,82L,83L,88L,89L,91L,92L,96L,98L,99L,100L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,117L,119L,120L,122L,123L,124L,125L,128L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243436Inst : IEnumerable<long>
{
public static readonly long[] Value=A243436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243436.Bytes);
public long this[int i]=>Value[i];

public static A243436Inst Instance=new A243436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243437
{
public static readonly BigInteger[] Value={ 17L,19L,43L,97L,2203L,6577L,19699L,531457L,1594339L,14348923L,7625597485003L,617673396283963L,BigInteger.Parse("239299329230617529590099"),BigInteger.Parse("1570042899082081611640534579"),BigInteger.Parse("42391158275216203514294433217"),BigInteger.Parse("608266787713357709119683992618861323") };
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
public class A243437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243437Inst Instance=new A243437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243438
{
public static readonly BigInteger[] Value={ 23L,31L,103L,751L,4782991L,282429536503L,50031545098999729L,BigInteger.Parse("49269609804781974438694403402127765889") };
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
public class A243438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243438Inst Instance=new A243438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243439
{
public static readonly BigInteger[] Value={ 29L,53L,107L,269L,2213L,19709L,177173L,43046747L,282429536507L,22876792454987L,BigInteger.Parse("239299329230617529590109"),BigInteger.Parse("19383245667680019896796749"),BigInteger.Parse("1144561273430837494885949696453"),BigInteger.Parse("969773729787523602876821942164080815560187") };
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
public class A243439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243439Inst Instance=new A243439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243440
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,499L,18897L,1158175L,104287909L,12948389505L,2119204222647L,442024984454145L,114447363118335099L,BigInteger.Parse("36014003359662761889"),BigInteger.Parse("13536516384259740525435"),BigInteger.Parse("5989775500211255393302197"),BigInteger.Parse("3082008257212085146469317911"),BigInteger.Parse("1824650971940959528920159955650"),BigInteger.Parse("1231558332755627626667173051846452") };
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
public class A243440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243440Inst Instance=new A243440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243441
{
public static readonly long[] Value={ 2L,3L,5L,17L,43L,163L,277L,311L,347L,373L,461L,479L,571L,643L,673L,821L,853L,857L,881L,977L,983L,1013L,1093L,1103L,1117L,1181L,1223L,1297L,1427L,1433L,1439L,1481L,1523L,1607L,1613L,1621L,1823L,1861L,1871L,1873L,2003L,2083L,2281L,2333L,2393L,2417L,2467L,2549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243441Inst : IEnumerable<long>
{
public static readonly long[] Value=A243441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243441.Bytes);
public long this[int i]=>Value[i];

public static A243441Inst Instance=new A243441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243442
{
public static readonly long[] Value={ 5L,23L,71L,83L,101L,113L,197L,281L,317L,353L,359L,373L,401L,467L,599L,619L,683L,739L,751L,773L,977L,1091L,1097L,1103L,1217L,1223L,1229L,1237L,1283L,1303L,1307L,1429L,1433L,1489L,1553L,1559L,1601L,1607L,1613L,1619L,1699L,1873L,1879L,2039L,2347L,2357L,2389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243442Inst : IEnumerable<long>
{
public static readonly long[] Value=A243442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243442.Bytes);
public long this[int i]=>Value[i];

public static A243442Inst Instance=new A243442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243443
{
public static readonly long[] Value={ 2L,0L,8L,6L,4L,9L,3L,4L,9L,6L,3L,0L,9L,3L,6L,4L,4L,2L,3L,1L,9L,1L,0L,1L,2L,0L,7L,8L,3L,3L,1L,8L,7L,4L,6L,4L,4L,7L,5L,9L,9L,1L,7L,8L,7L,1L,1L,8L,2L,4L,7L,7L,0L,4L,4L,3L,1L,1L,4L,8L,3L,4L,0L,3L,0L,7L,7L,1L,7L,6L,2L,4L,6L,5L,9L,9L,9L,6L,9L,6L,8L,9L,1L,7L,8L,2L,2L,6L,9L,7L,7L,1L,8L,1L,3L,1L,8L,9L,5L,0L,7L,0L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243443Inst : IEnumerable<long>
{
public static readonly long[] Value=A243443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243443.Bytes);
public long this[int i]=>Value[i];

public static A243443Inst Instance=new A243443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243444
{
public static readonly long[] Value={ 2L,0L,7L,8L,1L,5L,9L,6L,9L,5L,3L,6L,1L,0L,3L,8L,3L,9L,8L,9L,4L,2L,1L,1L,7L,1L,5L,3L,7L,7L,4L,8L,3L,6L,2L,9L,1L,9L,3L,1L,6L,6L,5L,1L,4L,2L,2L,4L,0L,1L,8L,2L,6L,9L,4L,9L,4L,9L,6L,4L,0L,6L,3L,7L,9L,9L,4L,8L,9L,8L,1L,6L,8L,6L,1L,3L,9L,0L,3L,3L,3L,7L,3L,3L,6L,8L,5L,6L,5L,3L,7L,4L,4L,1L,1L,1L,0L,6L,1L,7L,8L,0L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243444Inst : IEnumerable<long>
{
public static readonly long[] Value=A243444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243444.Bytes);
public long this[int i]=>Value[i];

public static A243444Inst Instance=new A243444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243445
{
public static readonly long[] Value={ 1L,2L,0L,5L,9L,3L,2L,4L,9L,8L,6L,8L,1L,4L,1L,3L,4L,3L,7L,5L,0L,3L,9L,2L,3L,3L,6L,1L,7L,3L,3L,0L,9L,1L,0L,9L,4L,4L,0L,0L,3L,3L,1L,7L,4L,2L,6L,6L,3L,6L,9L,6L,0L,6L,5L,1L,3L,2L,9L,9L,7L,5L,5L,0L,4L,2L,2L,9L,9L,8L,7L,5L,3L,3L,0L,9L,7L,2L,0L,9L,2L,9L,9L,1L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243445Inst : IEnumerable<long>
{
public static readonly long[] Value=A243445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243445.Bytes);
public long this[int i]=>Value[i];

public static A243445Inst Instance=new A243445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243446
{
public static readonly long[] Value={ 8L,4L,6L,2L,8L,4L,3L,7L,5L,3L,2L,1L,6L,3L,4L,4L,3L,0L,4L,2L,2L,1L,1L,9L,1L,7L,7L,3L,4L,1L,1L,5L,8L,8L,7L,8L,7L,6L,6L,0L,7L,5L,9L,4L,3L,9L,9L,3L,4L,9L,8L,2L,8L,5L,2L,6L,6L,1L,2L,8L,5L,8L,2L,5L,6L,5L,9L,6L,3L,7L,0L,2L,6L,6L,2L,2L,4L,0L,1L,2L,1L,7L,3L,0L,1L,1L,5L,4L,9L,0L,3L,0L,3L,1L,6L,1L,0L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243446Inst : IEnumerable<long>
{
public static readonly long[] Value=A243446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243446.Bytes);
public long this[int i]=>Value[i];

public static A243446Inst Instance=new A243446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243447
{
public static readonly long[] Value={ 5L,5L,9L,4L,6L,7L,2L,0L,3L,7L,9L,7L,3L,6L,7L,0L,1L,3L,7L,9L,5L,6L,8L,6L,3L,1L,3L,9L,8L,0L,1L,7L,0L,0L,9L,1L,5L,4L,3L,6L,2L,4L,8L,3L,4L,3L,5L,1L,2L,6L,6L,3L,0L,7L,0L,3L,5L,1L,7L,9L,9L,6L,1L,8L,8L,0L,4L,7L,9L,5L,6L,2L,3L,8L,0L,6L,1L,5L,4L,8L,9L,5L,1L,4L,6L,7L,7L,9L,0L,1L,9L,6L,3L,4L,4L,6L,5L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243447Inst : IEnumerable<long>
{
public static readonly long[] Value=A243447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243447.Bytes);
public long this[int i]=>Value[i];

public static A243447Inst Instance=new A243447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243448
{
public static readonly long[] Value={ 1L,0L,2L,9L,3L,7L,5L,3L,7L,3L,0L,0L,3L,9L,6L,4L,1L,3L,2L,0L,5L,6L,9L,8L,6L,6L,4L,6L,9L,8L,0L,9L,7L,3L,1L,8L,3L,4L,8L,5L,3L,7L,3L,8L,7L,8L,3L,9L,2L,6L,6L,5L,2L,4L,7L,0L,9L,6L,1L,1L,9L,6L,2L,2L,0L,2L,7L,7L,4L,2L,8L,5L,7L,3L,4L,9L,1L,7L,3L,6L,1L,6L,0L,6L,6L,4L,8L,0L,2L,7L,1L,6L,2L,8L,3L,6L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243448Inst : IEnumerable<long>
{
public static readonly long[] Value=A243448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243448.Bytes);
public long this[int i]=>Value[i];

public static A243448Inst Instance=new A243448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243449
{
public static readonly long[] Value={ 23L,239L,743L,1103L,2039L,5639L,7583L,8663L,27239L,33503L,38039L,42863L,59063L,81239L,88223L,91823L,119039L,131783L,140639L,164039L,189239L,205223L,245039L,263183L,288383L,328343L,342239L,378239L,393143L,400703L,431663L,439583L,514103L,660983L,710663L,950639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243449Inst : IEnumerable<long>
{
public static readonly long[] Value=A243449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243449.Bytes);
public long this[int i]=>Value[i];

public static A243449Inst Instance=new A243449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243450
{
public static readonly long[] Value={ 19L,31L,79L,211L,271L,499L,691L,1039L,1171L,1459L,1951L,2131L,2719L,4111L,4639L,5791L,7411L,7759L,9619L,10831L,11251L,15391L,17971L,24979L,29599L,31699L,33871L,38431L,40819L,42451L,44959L,55711L,56659L,58579L,61519L,65551L,68659L,73999L,80671L,87631L,88819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243450Inst : IEnumerable<long>
{
public static readonly long[] Value=A243450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243450.Bytes);
public long this[int i]=>Value[i];

public static A243450Inst Instance=new A243450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243451
{
public static readonly long[] Value={ 17L,41L,97L,137L,241L,457L,641L,857L,977L,1697L,2417L,2617L,3041L,4241L,5641L,6257L,6577L,7937L,8297L,9041L,9817L,11897L,13241L,14177L,14657L,15641L,16657L,22817L,27241L,32057L,36497L,44537L,47977L,48857L,52457L,53377L,60041L,62017L,70241L,75641L,78977L,83537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243451Inst : IEnumerable<long>
{
public static readonly long[] Value=A243451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243451.Bytes);
public long this[int i]=>Value[i];

public static A243451Inst Instance=new A243451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243452
{
public static readonly long[] Value={ 4L,9L,1L,7L,1L,5L,2L,3L,6L,8L,7L,4L,7L,4L,1L,7L,6L,0L,6L,8L,1L,7L,4L,7L,0L,0L,9L,9L,8L,5L,8L,8L,7L,0L,2L,2L,9L,0L,5L,8L,9L,0L,6L,9L,1L,8L,2L,7L,1L,0L,1L,2L,5L,0L,1L,1L,7L,4L,9L,7L,9L,8L,7L,5L,0L,4L,9L,2L,4L,6L,6L,0L,5L,0L,1L,5L,2L,9L,3L,7L,1L,4L,1L,3L,8L,5L,8L,2L,8L,9L,8L,5L,1L,8L,6L,7L,2L,2L,5L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243452Inst : IEnumerable<long>
{
public static readonly long[] Value=A243452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243452.Bytes);
public long this[int i]=>Value[i];

public static A243452Inst Instance=new A243452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243453
{
public static readonly long[] Value={ 1L,1L,6L,2L,9L,6L,4L,4L,7L,3L,6L,4L,0L,5L,1L,9L,6L,1L,2L,7L,7L,2L,2L,6L,7L,9L,8L,8L,5L,5L,0L,5L,0L,1L,4L,9L,4L,1L,0L,3L,3L,0L,8L,1L,2L,2L,6L,5L,9L,1L,6L,5L,9L,7L,5L,6L,3L,0L,0L,8L,4L,7L,5L,0L,7L,9L,2L,7L,5L,0L,9L,7L,2L,2L,6L,9L,2L,0L,0L,5L,0L,3L,9L,4L,9L,3L,4L,1L,5L,2L,8L,5L,6L,5L,6L,3L,1L,8L,1L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243453Inst : IEnumerable<long>
{
public static readonly long[] Value=A243453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243453.Bytes);
public long this[int i]=>Value[i];

public static A243453Inst Instance=new A243453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243454
{
public static readonly long[] Value={ 4L,4L,7L,5L,3L,4L,0L,6L,9L,0L,2L,0L,6L,6L,1L,9L,8L,8L,7L,6L,5L,6L,8L,4L,6L,5L,7L,7L,3L,0L,9L,8L,2L,6L,8L,5L,5L,3L,5L,5L,6L,3L,8L,2L,1L,5L,6L,8L,5L,4L,0L,1L,7L,1L,7L,8L,4L,9L,2L,4L,7L,5L,2L,7L,9L,4L,6L,3L,7L,2L,9L,3L,8L,8L,2L,0L,5L,5L,9L,8L,4L,9L,2L,6L,7L,1L,7L,6L,4L,9L,5L,2L,6L,5L,3L,7L,9L,9L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243454Inst : IEnumerable<long>
{
public static readonly long[] Value=A243454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243454.Bytes);
public long this[int i]=>Value[i];

public static A243454Inst Instance=new A243454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243455
{
public static readonly long[] Value={ 6L,61L,2089L,3606L,18585L,28710L,70981L,121374L,176529L,520320L,970783L,62788800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243455Inst : IEnumerable<long>
{
public static readonly long[] Value=A243455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243455.Bytes);
public long this[int i]=>Value[i];

public static A243455Inst Instance=new A243455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243456
{
public static readonly long[] Value={ 8L,0L,9L,0L,8L,0L,4L,0L,0L,0L,16L,0L,128L,0L,576L,0L,2048L,0L,6400L,0L,18432L,0L,50176L,0L,131072L,0L,331776L,0L,819200L,0L,1982464L,0L,4718592L,0L,11075584L,0L,25690112L,0L,58982400L,0L,134217728L,0L,303038464L,0L,679477248L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243456Inst : IEnumerable<long>
{
public static readonly long[] Value=A243456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243456.Bytes);
public long this[int i]=>Value[i];

public static A243456Inst Instance=new A243456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243457
{
public static readonly long[] Value={ 5L,7L,13L,19L,31L,37L,127L,139L,151L,163L,181L,193L,307L,313L,331L,349L,367L,379L,547L,571L,577L,991L,997L,1009L,1033L,1051L,1117L,1123L,1129L,1171L,1201L,1213L,1231L,1249L,1279L,1297L,1321L,1327L,1399L,1429L,1453L,1459L,1489L,1543L,1567L,1579L,1597L,1609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243457Inst : IEnumerable<long>
{
public static readonly long[] Value=A243457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243457.Bytes);
public long this[int i]=>Value[i];

public static A243457Inst Instance=new A243457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243458
{
public static readonly long[] Value={ 5L,23L,29L,41L,43L,47L,61L,67L,211L,227L,229L,239L,241L,251L,263L,277L,281L,283L,293L,401L,419L,431L,433L,449L,457L,467L,479L,491L,499L,601L,613L,647L,653L,659L,661L,673L,677L,683L,691L,2003L,2029L,2053L,2111L,2113L,2129L,2137L,2141L,2161L,2203L,2207L,2213L,2239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243458Inst : IEnumerable<long>
{
public static readonly long[] Value=A243458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243458.Bytes);
public long this[int i]=>Value[i];

public static A243458Inst Instance=new A243458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243459
{
public static readonly long[] Value={ 7L,43L,61L,67L,211L,223L,241L,271L,439L,463L,601L,607L,613L,619L,631L,691L,811L,853L,859L,877L,883L,2011L,2083L,2131L,2137L,2143L,2161L,2221L,2287L,2293L,2341L,2377L,2557L,2593L,2647L,2677L,2689L,2713L,2731L,2749L,2857L,2887L,2917L,2971L,4003L,4051L,4057L,4111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243459Inst : IEnumerable<long>
{
public static readonly long[] Value=A243459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243459.Bytes);
public long this[int i]=>Value[i];

public static A243459Inst Instance=new A243459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243460
{
public static readonly long[] Value={ 41L,47L,83L,401L,419L,431L,443L,449L,461L,467L,479L,617L,641L,647L,653L,677L,683L,857L,881L,4001L,4007L,4049L,4073L,4079L,4127L,4133L,4157L,4211L,4253L,4289L,4373L,4397L,4421L,4457L,4463L,4583L,4643L,4703L,4751L,4787L,4793L,4799L,4817L,4871L,4919L,4967L,6029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243460Inst : IEnumerable<long>
{
public static readonly long[] Value=A243460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243460.Bytes);
public long this[int i]=>Value[i];

public static A243460Inst Instance=new A243460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243461
{
public static readonly long[] Value={ 11L,23L,29L,41L,61L,67L,83L,89L,211L,223L,257L,263L,269L,271L,281L,283L,293L,601L,613L,619L,631L,641L,643L,653L,659L,661L,673L,811L,827L,829L,839L,853L,863L,877L,881L,883L,2011L,2027L,2039L,2063L,2083L,2087L,2111L,2129L,2131L,2207L,2221L,2243L,2269L,2311L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243461Inst : IEnumerable<long>
{
public static readonly long[] Value=A243461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243461.Bytes);
public long this[int i]=>Value[i];

public static A243461Inst Instance=new A243461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243462
{
public static readonly long[] Value={ 51L,279L,326L,798L,810L,977L,1009L,1019L,1360L,1369L,1561L,1687L,1711L,1735L,1979L,2272L,2505L,2970L,3502L,4413L,4690L,5277L,5283L,5837L,6151L,6645L,6769L,6943L,7633L,8198L,8313L,8318L,10391L,10877L,11321L,15079L,16636L,17961L,18653L,18948L,19143L,20070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243462Inst : IEnumerable<long>
{
public static readonly long[] Value=A243462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243462.Bytes);
public long this[int i]=>Value[i];

public static A243462Inst Instance=new A243462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243463
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,29L,30L,31L,33L,37L,39L,41L,43L,44L,45L,46L,47L,48L,55L,59L,61L,65L,66L,67L,71L,72L,75L,77L,78L,79L,80L,83L,87L,89L,93L,95L,99L,101L,102L,103L,104L,105L,107L,109L,112L,115L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243463Inst : IEnumerable<long>
{
public static readonly long[] Value=A243463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243463.Bytes);
public long this[int i]=>Value[i];

public static A243463Inst Instance=new A243463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243464
{
public static readonly long[] Value={ 0L,0L,3L,110L,657L,2172L,5375L,11178L,20685L,35192L,56187L,85350L,124553L,175860L,241527L,324002L,425925L,550128L,699635L,877662L,1087617L,1333100L,1617903L,1946010L,2321597L,2749032L,3232875L,3777878L,4388985L,5071332L,5830247L,6671250L,7600053L,8622560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243464Inst : IEnumerable<long>
{
public static readonly long[] Value=A243464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243464.Bytes);
public long this[int i]=>Value[i];

public static A243464Inst Instance=new A243464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243465
{
public static readonly long[] Value={ 0L,0L,0L,180L,4890L,36028L,154434L,488660L,1271450L,2883900L,5907298L,11182644L,19877850L,33562620L,54291010L,84691668L,128065754L,188492540L,270942690L,381399220L,526986138L,716104764L,958577730L,1265800660L,1650901530L,2128907708L,2716920674L,3434298420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243465Inst : IEnumerable<long>
{
public static readonly long[] Value=A243465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243465.Bytes);
public long this[int i]=>Value[i];

public static A243465Inst Instance=new A243465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243466
{
public static readonly long[] Value={ 0L,0L,0L,58L,18343L,362643L,2911226L,14601844L,54738489L,168157793L,446728228L,1062085146L,2312934779L,4690690399L,8967633918L,16312226288L,28436620141L,47781858189L,77746670984L,122966217718L,189647543823L,285968959211L,422550971074L,613006835244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243466Inst : IEnumerable<long>
{
public static readonly long[] Value=A243466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243466.Bytes);
public long this[int i]=>Value[i];

public static A243466Inst Instance=new A243466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243467
{
public static readonly long[] Value={ 0L,0L,0L,0L,33792L,2307376L,38049764L,316687056L,1756247962L,7430841848L,25895095920L,77947547416L,209206118486L,511919916960L,1160763672124L,2468985096704L,4973232330258L,9557709330856L,17631022607048L,31372223986440L,54066152166478L,90552261553040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243467Inst : IEnumerable<long>
{
public static readonly long[] Value=A243467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243467.Bytes);
public long this[int i]=>Value[i];

public static A243467Inst Instance=new A243467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243468
{
public static readonly BigInteger[] Value={ 1L,1L,4L,32L,401L,6941L,154092L,4181124L,134128092L,4966119716L,208417559828L,9776282249324L,506839013285272L,28777453303699456L,1775899632802691548L,BigInteger.Parse("118352734502149514340"),BigInteger.Parse("8471167817556712646853"),BigInteger.Parse("648104081945726392459965"),BigInteger.Parse("52780511829697565513665400") };
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
public class A243468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243468Inst Instance=new A243468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243469
{
public static readonly long[] Value={ 1L,2L,15L,32L,239L,510L,3809L,8128L,60705L,129538L,967471L,2064480L,15418831L,32902142L,245733825L,524369792L,3916322369L,8357014530L,62415424079L,133187862688L,994730462895L,2122648788478L,15853271982241L,33829192752960L,252657621252961L,539144435258882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243469Inst : IEnumerable<long>
{
public static readonly long[] Value=A243469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243469.Bytes);
public long this[int i]=>Value[i];

public static A243469Inst Instance=new A243469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243470
{
public static readonly long[] Value={ 1L,7L,15L,112L,239L,1785L,3809L,28448L,60705L,453383L,967471L,7225680L,15418831L,115157497L,245733825L,1835294272L,3916322369L,29249550855L,62415424079L,466157519408L,994730462895L,7429270759673L,15853271982241L,118402174635360L,252657621252961L,1887005523406087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243470Inst : IEnumerable<long>
{
public static readonly long[] Value=A243470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243470.Bytes);
public long this[int i]=>Value[i];

public static A243470Inst Instance=new A243470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243471
{
public static readonly long[] Value={ 3L,31L,73L,181L,367L,373L,523L,631L,733L,1021L,1039L,1171L,1489L,1723L,1777L,2203L,2557L,2683L,3121L,3187L,3319L,4441L,4591L,4621L,4801L,4957L,5113L,5167L,5323L,5431L,5659L,5839L,5851L,5857L,6883L,7057L,7129L,7297L,7309L,7477L,7993L,8017L,8209L,8221L,8689L,8821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243471Inst : IEnumerable<long>
{
public static readonly long[] Value=A243471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243471.Bytes);
public long this[int i]=>Value[i];

public static A243471Inst Instance=new A243471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243472
{
public static readonly long[] Value={ 2L,31L,101L,151L,181L,199L,229L,277L,307L,317L,379L,439L,479L,491L,647L,691L,797L,911L,997L,1039L,1051L,1181L,1291L,1367L,1381L,1471L,1511L,1549L,1657L,1709L,1847L,1867L,1987L,2081L,2099L,2111L,2207L,2467L,2621L,2707L,3041L,3221L,3259L,3541L,3571L,3581L,3769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243472Inst : IEnumerable<long>
{
public static readonly long[] Value=A243472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243472.Bytes);
public long this[int i]=>Value[i];

public static A243472Inst Instance=new A243472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243473
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,1L,1L,7L,4L,4L,1L,4L,1L,5L,3L,15L,1L,7L,1L,11L,11L,7L,1L,3L,6L,8L,13L,1L,1L,7L,1L,31L,5L,10L,13L,55L,1L,11L,17L,5L,1L,9L,1L,10L,11L,13L,1L,19L,8L,43L,7L,23L,1L,11L,17L,8L,23L,16L,1L,9L,1L,17L,41L,63L,19L,13L,1L,29L,9L,37L,1L,41L,1L,20L,49L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243473Inst : IEnumerable<long>
{
public static readonly long[] Value=A243473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243473.Bytes);
public long this[int i]=>Value[i];

public static A243473Inst Instance=new A243473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243474
{
public static readonly long[] Value={ 1L,6L,29L,124L,499L,1933L,7307L,27166L,99841L,363980L,1319404L,4763927L,17155264L,61672791L,221499015L,795198010L,2854898575L,10253237150L,36846414395L,132518215788L,477049025009L,1719101735260L,6201858101192L,22399768386170L,80998670324341L,293244129636085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243474Inst : IEnumerable<long>
{
public static readonly long[] Value=A243474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243474.Bytes);
public long this[int i]=>Value[i];

public static A243474Inst Instance=new A243474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243475
{
public static readonly long[] Value={ 2L,28L,241L,1667L,10142L,56748L,299485L,1514445L,7415873L,35424718L,165963977L,765639729L,3488740303L,15739196772L,70434524941L,313136541466L,1384706596078L,6096641331963L,26747810596747L,117015840972949L,510745056446585L,2225207050547044L,9680854941464722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243475Inst : IEnumerable<long>
{
public static readonly long[] Value=A243475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243475.Bytes);
public long this[int i]=>Value[i];

public static A243475Inst Instance=new A243475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243476
{
public static readonly long[] Value={ 10L,216L,2765L,27214L,227847L,1708700L,11832896L,77170252L,480381209L,2881934792L,16782041642L,95373448420L,531211249132L,2909490548577L,15712454516343L,83849134367589L,442957532385072L,2319975180476948L,12061609189508662L,62313958408668146L,320192732763382270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243476Inst : IEnumerable<long>
{
public static readonly long[] Value=A243476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243476.Bytes);
public long this[int i]=>Value[i];

public static A243476Inst Instance=new A243476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243477
{
public static readonly long[] Value={ 1L,98L,2637L,44051L,563444L,6054955L,57523592L,498540949L,4024955854L,30719216646L,224034574434L,1573966189886L,10719427410360L,71119561115093L,461496506508538L,2938387657219301L,18406158143420637L,113681266064450777L,693570688210367081L,4186481577282095644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243477Inst : IEnumerable<long>
{
public static readonly long[] Value=A243477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243477.Bytes);
public long this[int i]=>Value[i];

public static A243477Inst Instance=new A243477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243478
{
public static readonly BigInteger[] Value={ 22L,1546L,46947L,944701L,14745521L,193273378L,2228848403L,23305050081L,225560761204L,2051114040040L,17719591217257L,146674616051322L,1171101886353096L,9067551569835697L,68378670584901547L,504001041740002317L,3641720452674969516L,BigInteger.Parse("25859746275607624792") };
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
public class A243478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243478Inst Instance=new A243478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243479
{
public static readonly BigInteger[] Value={ 2L,570L,34643L,1139465L,26298831L,479669603L,7386945631L,100099764774L,1227140160022L,13879804132399L,146957303797639L,1472647088474040L,14087369324642004L,129522280702233381L,1150891407181302417L,9927963973481921295UL,BigInteger.Parse("83454334937159452579") };
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
public class A243479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243479Inst Instance=new A243479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243480
{
public static readonly BigInteger[] Value={ 130L,18196L,1027497L,35855578L,920132845L,19024724767L,334824869566L,5199938158961L,73073359931844L,946309985456857L,11449696018832655L,130815643776548834L,1423250326223813866L,14845562100052915605UL,BigInteger.Parse("149281547622659687547"),BigInteger.Parse("1453772869428542126084") };
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
public class A243480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243480Inst Instance=new A243480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243481
{
public static readonly BigInteger[] Value={ 17L,6867L,710088L,38504985L,1409180462L,39390143719L,903369758170L,17794252503829L,310620860769359L,4914610198933595L,71670394607559276L,975829774811610622L,12530984703191609205UL,BigInteger.Parse("153000363388748917171"),BigInteger.Parse("1787972768823076763190"),BigInteger.Parse("20107368357857569858580") };
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
public class A243481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243481.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243481Inst Instance=new A243481Inst();

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