using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A269916
{
public static readonly long[] Value={ 1L,5L,21L,81L,296L,1043L,3585L,12095L,40221L,132225L,430633L,1391623L,4467689L,14262766L,45311977L,143343279L,451768405L,1419092951L,4444424613L,13882255419L,43256925753L,134492621659L,417322590000L,1292554593007L,3996626787973L,12338508959035L,38037021764053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269916Inst : IEnumerable<long>
{
public static readonly long[] Value=A269916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269916.Bytes);
public long this[int i]=>Value[i];

public static A269916Inst Instance=new A269916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269917
{
public static readonly long[] Value={ 1L,5L,21L,81L,297L,1052L,3635L,12333L,41255L,136449L,447147L,1454091L,4697983L,15094393L,48264551L,153678185L,487510286L,1541427097L,4859385039L,15278735029L,47923821239L,149992151725L,468512665975L,1460770946689L,4546890238683L,14131055304241L,43854326838403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269917Inst : IEnumerable<long>
{
public static readonly long[] Value=A269917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269917.Bytes);
public long this[int i]=>Value[i];

public static A269917Inst Instance=new A269917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269918
{
public static readonly long[] Value={ 1L,5L,9L,25L,37L,49L,57L,105L,117L,153L,161L,229L,253L,297L,289L,417L,397L,545L,585L,661L,709L,745L,737L,949L,909L,1073L,1033L,1309L,1285L,1425L,1289L,1657L,1509L,1881L,1985L,2269L,2237L,2449L,2537L,2725L,2693L,2953L,2929L,3245L,3277L,3409L,3241L,3805L,3445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269918Inst : IEnumerable<long>
{
public static readonly long[] Value=A269918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269918.Bytes);
public long this[int i]=>Value[i];

public static A269918Inst Instance=new A269918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269919
{
public static readonly long[] Value={ 1L,2L,9L,1L,54L,20L,378L,307L,21L,2916L,4280L,966L,24057L,56914L,27954L,1485L,208494L,736568L,650076L,113256L,1876446L,9370183L,13271982L,5008230L,225225L,17399772L,117822512L,248371380L,167808024L,24635754L,165297834L,1469283166L,4366441128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269919Inst : IEnumerable<long>
{
public static readonly long[] Value=A269919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269919.Bytes);
public long this[int i]=>Value[i];

public static A269919Inst Instance=new A269919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269920
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,5L,22L,22L,5L,14L,93L,164L,93L,14L,42L,386L,1030L,1030L,386L,42L,132L,1586L,5868L,8885L,5868L,1586L,132L,429L,6476L,31388L,65954L,65954L,31388L,6476L,429L,1430L,26333L,160648L,442610L,614404L,442610L,160648L,26333L,1430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269920Inst : IEnumerable<long>
{
public static readonly long[] Value=A269920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269920.Bytes);
public long this[int i]=>Value[i];

public static A269920Inst Instance=new A269920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269921
{
public static readonly long[] Value={ 1L,10L,10L,70L,167L,70L,420L,1720L,1720L,420L,2310L,14065L,24164L,14065L,2310L,12012L,100156L,256116L,256116L,100156L,12012L,60060L,649950L,2278660L,3392843L,2278660L,649950L,60060L,291720L,3944928L,17970784L,36703824L,36703824L,17970784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269921Inst : IEnumerable<long>
{
public static readonly long[] Value=A269921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269921.Bytes);
public long this[int i]=>Value[i];

public static A269921Inst Instance=new A269921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269922
{
public static readonly long[] Value={ 21L,483L,483L,6468L,15018L,6468L,66066L,258972L,258972L,66066L,570570L,3288327L,5554188L,3288327L,570570L,4390386L,34374186L,85421118L,85421118L,34374186L,4390386L,31039008L,313530000L,1059255456L,1558792200L,1059255456L,313530000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269922Inst : IEnumerable<long>
{
public static readonly long[] Value=A269922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269922.Bytes);
public long this[int i]=>Value[i];

public static A269922Inst Instance=new A269922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269923
{
public static readonly long[] Value={ 1485L,56628L,56628L,1169740L,2668750L,1169740L,17454580L,66449432L,66449432L,17454580L,211083730L,1171704435L,1955808460L,1171704435L,211083730L,2198596400L,16476937840L,40121261136L,40121261136L,16476937840L,2198596400L,20465052608L,196924458720L,647739636160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269923Inst : IEnumerable<long>
{
public static readonly long[] Value=A269923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269923.Bytes);
public long this[int i]=>Value[i];

public static A269923Inst Instance=new A269923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269972
{
public static readonly long[] Value={ 2L,2L,1L,1L,2L,1L,1L,1L,4L,2L,1L,3L,3L,2L,1L,1L,3L,2L,1L,2L,3L,2L,1L,1L,3L,1L,3L,1L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,2L,3L,2L,3L,4L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,2L,1L,5L,3L,2L,1L,1L,3L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,4L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269972Inst : IEnumerable<long>
{
public static readonly long[] Value=A269972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269972.Bytes);
public long this[int i]=>Value[i];

public static A269972Inst Instance=new A269972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269973
{
public static readonly long[] Value={ 3L,1L,1L,2L,3L,2L,1L,2L,1L,1L,1L,4L,2L,3L,2L,2L,1L,3L,1L,4L,2L,1L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,3L,2L,4L,1L,1L,1L,3L,3L,2L,1L,1L,4L,2L,1L,3L,2L,1L,1L,3L,2L,2L,1L,1L,1L,1L,1L,2L,6L,2L,1L,2L,3L,1L,1L,2L,2L,2L,3L,3L,1L,1L,1L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269973Inst : IEnumerable<long>
{
public static readonly long[] Value=A269973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269973.Bytes);
public long this[int i]=>Value[i];

public static A269973Inst Instance=new A269973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269974
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,1L,1L,1L,2L,2L,1L,2L,2L,1L,3L,2L,1L,1L,2L,3L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,4L,2L,2L,1L,1L,1L,2L,1L,2L,3L,1L,3L,3L,1L,2L,1L,2L,1L,1L,3L,2L,2L,2L,1L,1L,1L,1L,2L,1L,3L,2L,1L,1L,1L,1L,1L,1L,5L,2L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269974Inst : IEnumerable<long>
{
public static readonly long[] Value=A269974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269974.Bytes);
public long this[int i]=>Value[i];

public static A269974Inst Instance=new A269974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269975
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,1L,1L,2L,2L,1L,2L,2L,1L,3L,2L,1L,1L,2L,3L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,4L,2L,2L,1L,1L,1L,2L,1L,2L,3L,1L,3L,3L,1L,2L,1L,2L,1L,1L,3L,2L,2L,2L,1L,1L,1L,1L,2L,1L,3L,2L,1L,1L,1L,1L,1L,1L,5L,2L,2L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269975Inst : IEnumerable<long>
{
public static readonly long[] Value=A269975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269975.Bytes);
public long this[int i]=>Value[i];

public static A269975Inst Instance=new A269975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269976
{
public static readonly long[] Value={ 1L,3L,1L,1L,1L,2L,2L,3L,1L,3L,3L,2L,1L,1L,3L,2L,1L,4L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,4L,2L,2L,1L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,2L,2L,3L,1L,1L,1L,5L,1L,2L,2L,1L,1L,2L,3L,2L,1L,1L,2L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269976Inst : IEnumerable<long>
{
public static readonly long[] Value=A269976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269976.Bytes);
public long this[int i]=>Value[i];

public static A269976Inst Instance=new A269976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269977
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,3L,1L,1L,3L,2L,1L,1L,2L,2L,1L,3L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,2L,1L,3L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,3L,1L,2L,3L,3L,1L,1L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269977Inst : IEnumerable<long>
{
public static readonly long[] Value=A269977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269977.Bytes);
public long this[int i]=>Value[i];

public static A269977Inst Instance=new A269977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269978
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,2L,2L,1L,1L,1L,1L,3L,1L,4L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,2L,3L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,2L,2L,4L,3L,3L,1L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,3L,2L,2L,1L,3L,1L,1L,3L,2L,3L,1L,2L,1L,2L,1L,2L,1L,3L,2L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269978Inst : IEnumerable<long>
{
public static readonly long[] Value=A269978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269978.Bytes);
public long this[int i]=>Value[i];

public static A269978Inst Instance=new A269978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269979
{
public static readonly long[] Value={ 5L,9L,0L,4L,5L,2L,3L,5L,4L,3L,5L,2L,0L,5L,5L,4L,8L,1L,6L,8L,1L,2L,4L,3L,2L,8L,1L,0L,1L,3L,5L,0L,2L,4L,2L,7L,9L,7L,1L,0L,4L,3L,5L,7L,7L,1L,7L,7L,7L,3L,5L,0L,0L,6L,3L,9L,6L,4L,8L,3L,9L,1L,0L,6L,9L,9L,8L,9L,2L,0L,1L,5L,6L,0L,3L,8L,8L,8L,9L,8L,9L,4L,6L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269979Inst : IEnumerable<long>
{
public static readonly long[] Value=A269979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269979.Bytes);
public long this[int i]=>Value[i];

public static A269979Inst Instance=new A269979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269980
{
public static readonly long[] Value={ 5L,2L,0L,9L,2L,0L,1L,4L,9L,6L,5L,3L,4L,8L,7L,4L,7L,5L,7L,6L,2L,2L,8L,1L,9L,8L,9L,1L,1L,8L,7L,4L,3L,3L,7L,5L,4L,8L,1L,4L,5L,7L,9L,0L,7L,6L,5L,4L,9L,6L,8L,3L,6L,7L,1L,8L,3L,5L,7L,1L,7L,3L,6L,0L,5L,6L,5L,6L,3L,6L,0L,0L,1L,4L,3L,3L,2L,3L,4L,6L,3L,9L,4L,6L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269980Inst : IEnumerable<long>
{
public static readonly long[] Value=A269980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269980.Bytes);
public long this[int i]=>Value[i];

public static A269980Inst Instance=new A269980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269981
{
public static readonly long[] Value={ 1L,6L,9L,4L,4L,6L,6L,4L,9L,0L,6L,6L,4L,3L,3L,8L,5L,1L,0L,7L,6L,1L,9L,5L,9L,6L,5L,9L,7L,9L,6L,9L,0L,2L,4L,1L,7L,5L,8L,6L,9L,5L,6L,0L,5L,1L,9L,2L,6L,9L,9L,2L,4L,2L,8L,4L,1L,9L,7L,8L,2L,4L,9L,4L,2L,4L,3L,0L,9L,5L,1L,0L,1L,3L,4L,7L,0L,6L,1L,8L,1L,0L,9L,9L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269981Inst : IEnumerable<long>
{
public static readonly long[] Value=A269981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269981.Bytes);
public long this[int i]=>Value[i];

public static A269981Inst Instance=new A269981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269982
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,2L,3L,1L,2L,1L,2L,3L,2L,3L,2L,1L,4L,3L,2L,2L,2L,3L,2L,2L,4L,1L,3L,1L,2L,2L,4L,4L,3L,2L,2L,2L,4L,3L,3L,1L,3L,4L,4L,4L,2L,2L,4L,4L,3L,2L,2L,3L,4L,2L,2L,1L,4L,2L,3L,4L,2L,4L,2L,1L,5L,4L,5L,5L,3L,1L,3L,4L,3L,4L,2L,1L,4L,2L,4L,2L,4L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269982Inst : IEnumerable<long>
{
public static readonly long[] Value=A269982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269982.Bytes);
public long this[int i]=>Value[i];

public static A269982Inst Instance=new A269982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269983
{
public static readonly long[] Value={ 2L,3L,6L,7L,11L,13L,19L,29L,31L,43L,59L,67L,73L,79L,89L,109L,151L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269983Inst : IEnumerable<long>
{
public static readonly long[] Value=A269983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269983.Bytes);
public long this[int i]=>Value[i];

public static A269983Inst Instance=new A269983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269984
{
public static readonly long[] Value={ 4L,5L,8L,9L,12L,14L,16L,18L,22L,23L,24L,26L,27L,32L,33L,37L,38L,39L,48L,49L,53L,54L,57L,58L,61L,64L,66L,78L,81L,83L,86L,87L,96L,97L,101L,107L,113L,114L,121L,129L,131L,139L,163L,169L,174L,178L,181L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269984Inst : IEnumerable<long>
{
public static readonly long[] Value=A269984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269984.Bytes);
public long this[int i]=>Value[i];

public static A269984Inst Instance=new A269984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269985
{
public static readonly long[] Value={ 10L,15L,17L,21L,25L,30L,36L,41L,42L,44L,52L,55L,62L,72L,74L,76L,88L,93L,98L,99L,103L,104L,106L,108L,111L,118L,122L,125L,128L,132L,134L,137L,146L,149L,155L,158L,162L,166L,173L,176L,177L,179L,183L,186L,192L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269985Inst : IEnumerable<long>
{
public static readonly long[] Value=A269985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269985.Bytes);
public long this[int i]=>Value[i];

public static A269985Inst Instance=new A269985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269986
{
public static readonly long[] Value={ 20L,28L,34L,35L,40L,45L,46L,47L,50L,51L,56L,60L,63L,65L,69L,75L,77L,80L,82L,84L,90L,91L,102L,110L,112L,116L,117L,120L,123L,124L,133L,135L,144L,147L,148L,150L,152L,156L,159L,160L,165L,167L,171L,172L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269986Inst : IEnumerable<long>
{
public static readonly long[] Value=A269986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269986.Bytes);
public long this[int i]=>Value[i];

public static A269986Inst Instance=new A269986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269987
{
public static readonly long[] Value={ 68L,70L,71L,85L,92L,100L,126L,127L,130L,136L,138L,145L,154L,157L,161L,164L,168L,180L,185L,195L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269987Inst : IEnumerable<long>
{
public static readonly long[] Value=A269987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269987.Bytes);
public long this[int i]=>Value[i];

public static A269987Inst Instance=new A269987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270068
{
public static readonly BigInteger[] Value={ 1L,13L,4287L,940916L,204383373L,44538604036L,9756894398324L,2133436326533143L,466326405037190729L,BigInteger.Parse("101965922336345576219"),BigInteger.Parse("22294594753523459270694"),BigInteger.Parse("4874505512330163994345181"),BigInteger.Parse("1065778806957316983452583926"),BigInteger.Parse("233025803338941141247495062594") };
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
public class A270068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270068.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270068Inst Instance=new A270068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270069
{
public static readonly BigInteger[] Value={ 1L,19L,13413L,5952243L,2626057921L,1162378878394L,517174361985073L,229681994753502100L,BigInteger.Parse("101965922336345576219"),BigInteger.Parse("45283517791861200639757"),BigInteger.Parse("20109634299824273864511862"),BigInteger.Parse("8930062817269356408791188106"),BigInteger.Parse("3965614916098256915340694883017"),BigInteger.Parse("1761030770921730133912679646624228") };
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
public class A270069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270069.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270069Inst Instance=new A270069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270070
{
public static readonly BigInteger[] Value={ 1L,28L,41956L,37655502L,33738191906L,30334909910156L,27412100990502042L,BigInteger.Parse("24725866354382952217"),BigInteger.Parse("22294594753523459270694"),BigInteger.Parse("20109634299824273864511862"),BigInteger.Parse("18137923612752525595542410804"),BigInteger.Parse("16359025960283827167827032525174"),BigInteger.Parse("14754787194922572653415156965320636") };
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
public class A270070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270070Inst Instance=new A270070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270071
{
public static readonly BigInteger[] Value={ 1L,1L,5L,93L,7517L,2501946L,3473827027L,19823918037604L,466326405037190729L,BigInteger.Parse("45283517791861200639757"),BigInteger.Parse("18137923612752525595542410804"),BigInteger.Parse("29967243098804386765778629249653298"),BigInteger.Parse("204247259656641635611144023845458294818885") };
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
public class A270071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270071Inst Instance=new A270071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270072
{
public static readonly long[] Value={ 15L,33L,231L,561L,3735L,8673L,58407L,146673L,951831L,2200161L,15007527L,37618161L,243401751L,562961505L,3835839783L,9654230001L,62277025815L,1438881404513L,981400027431L,2471753680881L,15945066090519L,38848671944801L,251274914238759L,633024492828657L,4081389310836759L,589338770407521L,6431706870343299L,161989104772314217L,1044976403211096087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270072Inst : IEnumerable<long>
{
public static readonly long[] Value=A270072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270072.Bytes);
public long this[int i]=>Value[i];

public static A270072Inst Instance=new A270072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270073
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,3L,2L,2L,2L,4L,3L,1L,2L,3L,1L,1L,2L,4L,4L,2L,4L,4L,2L,1L,2L,5L,4L,3L,2L,3L,3L,2L,2L,4L,3L,1L,4L,4L,3L,4L,3L,4L,3L,1L,2L,7L,2L,3L,2L,4L,5L,2L,4L,4L,6L,4L,1L,3L,2L,2L,3L,6L,1L,4L,2L,8L,4L,1L,5L,7L,4L,3L,4L,7L,3L,4L,2L,3L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270073Inst : IEnumerable<long>
{
public static readonly long[] Value=A270073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270073.Bytes);
public long this[int i]=>Value[i];

public static A270073Inst Instance=new A270073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270074
{
public static readonly long[] Value={ 1L,21L,33L,77L,9L,27L,39L,111L,301L,703L,91L,707L,93L,711L,99L,729L,737L,309L,741L,303L,713L,913L,117L,319L,119L,341L,731L,339L,129L,747L,333L,147L,901L,749L,371L,351L,357L,343L,717L,909L,753L,153L,159L,141L,903L,759L,171L,363L,767L,133L,183L,189L,177L,361L,763L,917L,143L,931L,779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270074Inst : IEnumerable<long>
{
public static readonly long[] Value=A270074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270074.Bytes);
public long this[int i]=>Value[i];

public static A270074Inst Instance=new A270074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270075
{
public static readonly long[] Value={ 1L,4L,5L,32L,13L,84L,29L,168L,45L,288L,69L,424L,65L,644L,93L,792L,153L,1040L,169L,1280L,185L,1612L,237L,1908L,285L,2196L,405L,2520L,513L,2904L,565L,3332L,629L,3796L,617L,4320L,633L,4924L,812L,5188L,933L,5864L,1025L,6452L,957L,7152L,1157L,7688L,1269L,8340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270075Inst : IEnumerable<long>
{
public static readonly long[] Value=A270075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270075.Bytes);
public long this[int i]=>Value[i];

public static A270075Inst Instance=new A270075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270076
{
public static readonly long[] Value={ 1L,4L,32L,168L,792L,3332L,13860L,56296L,227953L,914357L,3661428L,14658441L,58664072L,234685300L,938870324L,3755727409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270076Inst : IEnumerable<long>
{
public static readonly long[] Value=A270076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270076.Bytes);
public long this[int i]=>Value[i];

public static A270076Inst Instance=new A270076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270077
{
public static readonly long[] Value={ 1L,5L,10L,42L,55L,139L,168L,336L,381L,669L,738L,1162L,1227L,1871L,1964L,2756L,2909L,3949L,4118L,5398L,5583L,7195L,7432L,9340L,9625L,11821L,12226L,14746L,15259L,18163L,18728L,22060L,22689L,26485L,27102L,31422L,32055L,36979L,37791L,42979L,43912L,49776L,50801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270077Inst : IEnumerable<long>
{
public static readonly long[] Value=A270077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270077.Bytes);
public long this[int i]=>Value[i];

public static A270077Inst Instance=new A270077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270078
{
public static readonly long[] Value={ 3L,1L,27L,-19L,71L,-55L,139L,-123L,243L,-219L,355L,-359L,579L,-551L,699L,-639L,887L,-871L,1111L,-1095L,1427L,-1375L,1671L,-1623L,1911L,-1791L,2115L,-2007L,2391L,-2339L,2767L,-2703L,3167L,-3179L,3703L,-3687L,4291L,-4112L,4376L,-4255L,4931L,-4839L,5427L,-5495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270078Inst : IEnumerable<long>
{
public static readonly long[] Value=A270078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270078.Bytes);
public long this[int i]=>Value[i];

public static A270078Inst Instance=new A270078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270079
{
public static readonly long[] Value={ 1L,5L,12L,20L,32L,44L,68L,72L,100L,112L,156L,160L,204L,216L,276L,280L,340L,352L,428L,432L,508L,520L,612L,616L,708L,720L,828L,832L,940L,952L,1076L,1080L,1204L,1216L,1356L,1360L,1500L,1512L,1668L,1672L,1828L,1840L,2012L,2016L,2188L,2200L,2388L,2392L,2580L,2592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270079Inst : IEnumerable<long>
{
public static readonly long[] Value=A270079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270079.Bytes);
public long this[int i]=>Value[i];

public static A270079Inst Instance=new A270079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270080
{
public static readonly long[] Value={ 1L,5L,20L,72L,280L,1080L,4216L,16632L,66040L,263160L,1050616L,4198392L,16785400L,67125240L,268468216L,1073807352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270080Inst : IEnumerable<long>
{
public static readonly long[] Value=A270080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270080.Bytes);
public long this[int i]=>Value[i];

public static A270080Inst Instance=new A270080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270081
{
public static readonly long[] Value={ 1L,6L,18L,38L,70L,114L,182L,254L,354L,466L,622L,782L,986L,1202L,1478L,1758L,2098L,2450L,2878L,3310L,3818L,4338L,4950L,5566L,6274L,6994L,7822L,8654L,9594L,10546L,11622L,12702L,13906L,15122L,16478L,17838L,19338L,20850L,22518L,24190L,26018L,27858L,29870L,31886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270081Inst : IEnumerable<long>
{
public static readonly long[] Value=A270081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270081.Bytes);
public long this[int i]=>Value[i];

public static A270081Inst Instance=new A270081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270082
{
public static readonly long[] Value={ 4L,7L,8L,12L,12L,24L,4L,28L,12L,44L,4L,44L,12L,60L,4L,60L,12L,76L,4L,76L,12L,92L,4L,92L,12L,108L,4L,108L,12L,124L,4L,124L,12L,140L,4L,140L,12L,156L,4L,156L,12L,172L,4L,172L,12L,188L,4L,188L,12L,204L,4L,204L,12L,220L,4L,220L,12L,236L,4L,236L,12L,252L,4L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270082Inst : IEnumerable<long>
{
public static readonly long[] Value=A270082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270082.Bytes);
public long this[int i]=>Value[i];

public static A270082Inst Instance=new A270082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270083
{
public static readonly long[] Value={ 19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,101L,103L,107L,127L,149L,157L,163L,173L,181L,191L,271L,277L,307L,313L,317L,331L,359L,367L,379L,397L,419L,479L,491L,571L,577L,593L,617L,631L,673L,701L,709L,727L,739L,757L,761L,787L,797L,811L,839L,877L,907L,911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270083Inst : IEnumerable<long>
{
public static readonly long[] Value=A270083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270083.Bytes);
public long this[int i]=>Value[i];

public static A270083Inst Instance=new A270083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270132
{
public static readonly long[] Value={ 3L,1L,39L,-44L,121L,-121L,225L,-225L,361L,-361L,529L,-529L,729L,-729L,961L,-961L,1225L,-1225L,1521L,-1521L,1849L,-1849L,2209L,-2209L,2601L,-2601L,3025L,-3025L,3481L,-3481L,3969L,-3969L,4489L,-4489L,5041L,-5041L,5625L,-5625L,6241L,-6241L,6889L,-6889L,7569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270132Inst : IEnumerable<long>
{
public static readonly long[] Value=A270132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270132.Bytes);
public long this[int i]=>Value[i];

public static A270132Inst Instance=new A270132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270133
{
public static readonly long[] Value={ 1L,5L,12L,16L,36L,24L,60L,44L,116L,52L,148L,96L,244L,76L,228L,180L,420L,120L,308L,232L,556L,248L,548L,368L,812L,308L,556L,548L,936L,640L,832L,836L,1176L,884L,888L,948L,1500L,1092L,1336L,1368L,1864L,1232L,1584L,1692L,2136L,1768L,1912L,1984L,2676L,1828L,2172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270133Inst : IEnumerable<long>
{
public static readonly long[] Value=A270133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270133.Bytes);
public long this[int i]=>Value[i];

public static A270133Inst Instance=new A270133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270134
{
public static readonly long[] Value={ 1L,5L,16L,44L,180L,836L,3280L,14596L,59624L,243376L,980952L,3931724L,15775124L,63215616L,253124460L,1012979592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270134Inst : IEnumerable<long>
{
public static readonly long[] Value=A270134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270134.Bytes);
public long this[int i]=>Value[i];

public static A270134Inst Instance=new A270134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270135
{
public static readonly long[] Value={ 1L,6L,18L,34L,70L,94L,154L,198L,314L,366L,514L,610L,854L,930L,1158L,1338L,1758L,1878L,2186L,2418L,2974L,3222L,3770L,4138L,4950L,5258L,5814L,6362L,7298L,7938L,8770L,9606L,10782L,11666L,12554L,13502L,15002L,16094L,17430L,18798L,20662L,21894L,23478L,25170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270135Inst : IEnumerable<long>
{
public static readonly long[] Value=A270135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270135.Bytes);
public long this[int i]=>Value[i];

public static A270135Inst Instance=new A270135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270136
{
public static readonly long[] Value={ 4L,7L,4L,20L,-12L,36L,-16L,72L,-64L,96L,-52L,148L,-168L,152L,-48L,240L,-300L,188L,-76L,324L,-308L,300L,-180L,444L,-504L,248L,-8L,388L,-296L,192L,4L,340L,-292L,4L,60L,552L,-408L,244L,32L,496L,-632L,352L,108L,444L,-368L,144L,72L,692L,-848L,344L,256L,512L,-476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270136Inst : IEnumerable<long>
{
public static readonly long[] Value=A270136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270136.Bytes);
public long this[int i]=>Value[i];

public static A270136Inst Instance=new A270136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270137
{
public static readonly long[] Value={ 0L,8L,6L,6L,0L,7L,3L,9L,0L,8L,7L,3L,0L,1L,5L,9L,2L,9L,9L,7L,1L,2L,6L,4L,1L,4L,0L,6L,8L,5L,8L,4L,8L,0L,6L,4L,2L,8L,6L,6L,3L,1L,1L,5L,2L,3L,8L,6L,2L,7L,3L,2L,1L,1L,6L,0L,0L,9L,7L,3L,3L,8L,6L,5L,9L,3L,2L,8L,1L,9L,3L,5L,3L,8L,1L,8L,9L,1L,4L,0L,6L,7L,4L,4L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270137Inst : IEnumerable<long>
{
public static readonly long[] Value=A270137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270137.Bytes);
public long this[int i]=>Value[i];

public static A270137Inst Instance=new A270137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270138
{
public static readonly long[] Value={ 0L,1L,6L,2L,7L,32L,112L,10800L,403200L,17418254400L,1755760043520000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270138Inst : IEnumerable<long>
{
public static readonly long[] Value=A270138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270138.Bytes);
public long this[int i]=>Value[i];

public static A270138Inst Instance=new A270138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270139
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,12L,15L,10L,5L,20L,25L,30L,35L,14L,7L,21L,28L,18L,4L,8L,16L,22L,24L,26L,32L,34L,36L,38L,40L,42L,44L,33L,11L,55L,66L,45L,27L,39L,48L,51L,54L,57L,60L,63L,56L,49L,70L,77L,84L,88L,46L,50L,52L,58L,62L,64L,68L,72L,74L,76L,78L,80L,65L,75L,85L,90L,95L,100L,105L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270139Inst : IEnumerable<long>
{
public static readonly long[] Value=A270139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270139.Bytes);
public long this[int i]=>Value[i];

public static A270139Inst Instance=new A270139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270140
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,16L,18L,20L,24L,32L,42L,45L,54L,64L,72L,96L,100L,128L,162L,216L,256L,272L,288L,294L,320L,342L,352L,384L,486L,500L,512L,600L,648L,720L,832L,850L,864L,1024L,1120L,1125L,1152L,1320L,1350L,1458L,1512L,1536L,1600L,1620L,1806L,1944L,2048L,2058L,2500L,2592L,2688L,3321L,3456L,3645L,3872L,4096L,4176L,4225L,4374L,4608L,4624L,5120L,5256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270140Inst : IEnumerable<long>
{
public static readonly long[] Value=A270140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270140.Bytes);
public long this[int i]=>Value[i];

public static A270140Inst Instance=new A270140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270141
{
public static readonly long[] Value={ 1L,2L,6L,42L,720L,1806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270141Inst : IEnumerable<long>
{
public static readonly long[] Value=A270141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270141.Bytes);
public long this[int i]=>Value[i];

public static A270141Inst Instance=new A270141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270142
{
public static readonly long[] Value={ 4L,16L,64L,256L,1024L,4096L,16384L,65536L,262144L,4L,24L,144L,864L,5184L,31104L,186624L,1119744L,6718464L,40310784L,16L,96L,576L,3456L,20736L,124416L,746496L,4478976L,26873856L,161243136L,64L,384L,2304L,13824L,82944L,497664L,2985984L,17915904L,107495424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270142Inst : IEnumerable<long>
{
public static readonly long[] Value=A270142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270142.Bytes);
public long this[int i]=>Value[i];

public static A270142Inst Instance=new A270142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270143
{
public static readonly long[] Value={ 0L,1L,-1L,3L,-2L,6L,-3L,11L,-4L,19L,-4L,31L,-2L,50L,3L,79L,15L,122L,38L,187L,78L,284L,146L,426L,257L,635L,431L,939L,701L,1377L,1110L,2007L,1718L,2906L,2613L,4178L,3914L,5971L,5781L,8482L,8440L,11976L,12191L,16816L,17438L,23483L,24730L,32615L,34794L,45070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270143Inst : IEnumerable<long>
{
public static readonly long[] Value=A270143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270143.Bytes);
public long this[int i]=>Value[i];

public static A270143Inst Instance=new A270143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270144
{
public static readonly long[] Value={ 0L,1L,-1L,2L,-1L,2L,0L,2L,1L,2L,3L,2L,5L,3L,7L,5L,10L,7L,14L,11L,18L,17L,24L,24L,32L,34L,42L,47L,56L,63L,74L,85L,96L,113L,126L,147L,165L,191L,213L,247L,275L,316L,353L,404L,449L,514L,571L,648L,723L,816L,909L,1024L,1140L,1278L,1424L,1592L,1770L,1976L,2195L,2442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270144Inst : IEnumerable<long>
{
public static readonly long[] Value=A270144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270144.Bytes);
public long this[int i]=>Value[i];

public static A270144Inst Instance=new A270144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270145
{
public static readonly BigInteger[] Value={ 8L,1440L,85056L,4126368L,182257536L,7623445344L,307704553920L,12111206870304L,467855602824192L,17813625850002144L,670485480935347776L,BigInteger.Parse("25000461221001205920"),BigInteger.Parse("924950147066819934336"),BigInteger.Parse("33996076829066361534048") };
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
public class A270145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270145Inst Instance=new A270145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270146
{
public static readonly BigInteger[] Value={ 112L,85056L,24250368L,5750902944L,1246566350496L,256330155581328L,50909823129746016L,9865341820791957984UL,BigInteger.Parse("1876922088531822540288"),BigInteger.Parse("352046674014022502244432"),BigInteger.Parse("65286683791880565255135360") };
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
public class A270146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270146Inst Instance=new A270146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270147
{
public static readonly BigInteger[] Value={ 1176L,4126368L,5750902944L,6697695002208L,7142783643783792L,7232246139319438944L,BigInteger.Parse("7076007579749239522560"),BigInteger.Parse("6756572506861579320074976"),BigInteger.Parse("6335222052939240175011338736"),BigInteger.Parse("5856894219696861529450357235808") };
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
public class A270147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270147Inst Instance=new A270147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270196
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,5L,8L,13L,14L,15L,12L,17L,10L,25L,16L,11L,26L,9L,28L,21L,30L,27L,24L,57L,34L,53L,20L,31L,50L,49L,32L,101L,22L,35L,52L,65L,18L,29L,56L,51L,42L,105L,60L,69L,54L,23L,48L,85L,114L,97L,68L,19L,106L,121L,40L,37L,62L,43L,100L,33L,98L,229L,64L,55L,202L,197L,44L,405L,70L,115L,104L,89L,130L,209L,36L,107L,58L,261L,112L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270196Inst : IEnumerable<long>
{
public static readonly long[] Value=A270196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270196.Bytes);
public long this[int i]=>Value[i];

public static A270196Inst Instance=new A270196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270197
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,7L,6L,11L,14L,19L,8L,17L,22L,9L,34L,29L,12L,21L,10L,53L,18L,13L,28L,47L,106L,81L,42L,23L,16L,123L,94L,83L,246L,15L,44L,59L,166L,39L,38L,155L,68L,27L,118L,35L,162L,103L,24L,137L,54L,375L,274L,239L,20L,49L,70L,65L,78L,61L,36L,365L,58L,333L,750L,245L,56L,403L,666L,41L,806L,55L,212L,173L,82L,585L,346L,113L,84L,57L,1170L,461L,26L,73L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270197Inst : IEnumerable<long>
{
public static readonly long[] Value=A270197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270197.Bytes);
public long this[int i]=>Value[i];

public static A270197Inst Instance=new A270197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270198
{
public static readonly long[] Value={ 3L,5L,6L,9L,10L,11L,14L,17L,18L,19L,20L,23L,26L,27L,30L,33L,34L,35L,36L,37L,40L,43L,44L,47L,50L,51L,52L,55L,58L,59L,62L,65L,66L,67L,68L,69L,70L,73L,76L,77L,80L,83L,84L,85L,88L,91L,92L,95L,98L,99L,100L,101L,104L,107L,108L,111L,114L,115L,116L,119L,122L,123L,126L,129L,130L,131L,132L,133L,134L,135L,138L,141L,142L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270198Inst : IEnumerable<long>
{
public static readonly long[] Value=A270198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270198.Bytes);
public long this[int i]=>Value[i];

public static A270198Inst Instance=new A270198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270199
{
public static readonly long[] Value={ 1L,3L,2L,9L,6L,5L,30L,15L,4L,16L,12L,11L,93L,45L,8L,10L,46L,48L,34L,33L,266L,124L,26L,31L,127L,23L,154L,99L,97L,7L,24L,727L,20L,19L,352L,80L,94L,357L,68L,141L,69L,446L,278L,272L,14L,17L,70L,18L,71L,73L,1902L,54L,61L,52L,946L,232L,267L,957L,197L,408L,53L,199L,1174L,763L,407L,751L,186L,39L,41L,47L,49L,202L,50L,204L,210L,4724L,164L,192L,182L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270199Inst : IEnumerable<long>
{
public static readonly long[] Value=A270199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270199.Bytes);
public long this[int i]=>Value[i];

public static A270199Inst Instance=new A270199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270200
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,8L,12L,13L,15L,16L,21L,22L,24L,25L,28L,29L,31L,32L,38L,39L,41L,42L,45L,46L,48L,49L,53L,54L,56L,57L,60L,61L,63L,64L,71L,72L,74L,75L,78L,79L,81L,82L,86L,87L,89L,90L,93L,94L,96L,97L,102L,103L,105L,106L,109L,110L,112L,113L,117L,118L,120L,121L,124L,125L,127L,128L,136L,137L,139L,140L,143L,144L,146L,147L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270200Inst : IEnumerable<long>
{
public static readonly long[] Value=A270200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270200.Bytes);
public long this[int i]=>Value[i];

public static A270200Inst Instance=new A270200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270201
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,3L,256L,5L,6L,512L,10L,9L,17L,12L,33L,1024L,20L,65L,18L,129L,34L,24L,66L,2048L,40L,130L,36L,258L,257L,68L,48L,132L,7L,513L,4096L,11L,13L,80L,260L,72L,516L,514L,1025L,21L,136L,96L,264L,19L,14L,1026L,35L,25L,67L,8192L,2049L,22L,26L,160L,520L,144L,1032L,1028L,2050L,41L,42L,272L,192L,131L,528L,37L,259L,38L,69L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270201Inst : IEnumerable<long>
{
public static readonly long[] Value=A270201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270201.Bytes);
public long this[int i]=>Value[i];

public static A270201Inst Instance=new A270201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270202
{
public static readonly long[] Value={ 1L,2L,9L,3L,11L,12L,36L,4L,15L,14L,39L,17L,40L,52L,108L,5L,16L,22L,51L,20L,47L,59L,114L,25L,55L,60L,118L,77L,167L,156L,312L,6L,18L,24L,54L,30L,73L,75L,165L,28L,67L,68L,139L,85L,185L,166L,339L,34L,84L,80L,174L,87L,187L,173L,347L,117L,227L,254L,496L,236L,461L,475L,852L,7L,21L,26L,56L,33L,76L,79L,170L,43L,99L,112L,216L,115L,219L,251L,490L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270202Inst : IEnumerable<long>
{
public static readonly long[] Value=A270202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270202.Bytes);
public long this[int i]=>Value[i];

public static A270202Inst Instance=new A270202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270203
{
public static readonly long[] Value={ 163L,15667L,234067L,607093L,671353L,1447153L,1457857L,2162323L,5772097L,7717873L,9139453L,9549373L,11170933L,12039883L,13243063L,16442407L,16836163L,17784253L,18116473L,19433863L,21960577L,28209703L,29175283L,32380177L,33890803L,34613287L,34682113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270203Inst : IEnumerable<long>
{
public static readonly long[] Value=A270203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270203.Bytes);
public long this[int i]=>Value[i];

public static A270203Inst Instance=new A270203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270204
{
public static readonly long[] Value={ 1L,1L,3277L,478297L,15790321L,234750601L,2117950381L,13564461457L,67662254017L,278985273841L,990099009901L,3112703553961L,8854610100337L,23161037562937L,56406126018061L,129172239050401L,280379743338241L,580613195032417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270204Inst : IEnumerable<long>
{
public static readonly long[] Value=A270204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270204.Bytes);
public long this[int i]=>Value[i];

public static A270204Inst Instance=new A270204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270205
{
public static readonly long[] Value={ 0L,0L,6L,36L,108L,240L,450L,756L,1176L,1728L,2430L,3300L,4356L,5616L,7098L,8820L,10800L,13056L,15606L,18468L,21660L,25200L,29106L,33396L,38088L,43200L,48750L,54756L,61236L,68208L,75690L,83700L,92256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270205Inst : IEnumerable<long>
{
public static readonly long[] Value=A270205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270205.Bytes);
public long this[int i]=>Value[i];

public static A270205Inst Instance=new A270205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270206
{
public static readonly long[] Value={ 1L,4L,9L,32L,17L,100L,40L,164L,41L,300L,89L,440L,76L,636L,133L,800L,173L,1088L,193L,1288L,265L,1600L,348L,1880L,373L,2324L,344L,2649L,564L,2985L,564L,3505L,640L,3953L,756L,4349L,716L,5053L,716L,5497L,808L,6149L,980L,6645L,1112L,7305L,1300L,7885L,1416L,8489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270206Inst : IEnumerable<long>
{
public static readonly long[] Value=A270206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270206.Bytes);
public long this[int i]=>Value[i];

public static A270206Inst Instance=new A270206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270207
{
public static readonly long[] Value={ 1L,4L,32L,164L,800L,3505L,14413L,57732L,232124L,928469L,3723528L,14911100L,59687737L,238828205L,955470060L,3822006173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270207Inst : IEnumerable<long>
{
public static readonly long[] Value=A270207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270207.Bytes);
public long this[int i]=>Value[i];

public static A270207Inst Instance=new A270207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270208
{
public static readonly long[] Value={ 1L,5L,14L,46L,63L,163L,203L,367L,408L,708L,797L,1237L,1313L,1949L,2082L,2882L,3055L,4143L,4336L,5624L,5889L,7489L,7837L,9717L,10090L,12414L,12758L,15407L,15971L,18956L,19520L,23025L,23665L,27618L,28374L,32723L,33439L,38492L,39208L,44705L,45513L,51662L,52642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270208Inst : IEnumerable<long>
{
public static readonly long[] Value=A270208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270208.Bytes);
public long this[int i]=>Value[i];

public static A270208Inst Instance=new A270208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270209
{
public static readonly long[] Value={ 3L,5L,23L,-15L,83L,-60L,124L,-123L,259L,-211L,351L,-364L,560L,-503L,667L,-627L,915L,-895L,1095L,-1023L,1335L,-1252L,1532L,-1507L,1951L,-1980L,2305L,-2085L,2421L,-2421L,2941L,-2865L,3313L,-3197L,3593L,-3633L,4337L,-4337L,4781L,-4689L,5341L,-5169L,5665L,-5533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270209Inst : IEnumerable<long>
{
public static readonly long[] Value=A270209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270209.Bytes);
public long this[int i]=>Value[i];

public static A270209Inst Instance=new A270209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270210
{
public static readonly long[] Value={ 1L,5L,5L,41L,12L,109L,16L,209L,20L,337L,28L,501L,28L,689L,52L,913L,60L,1161L,68L,1457L,56L,1757L,120L,2085L,168L,2429L,216L,2841L,224L,3249L,312L,3697L,324L,4193L,332L,4753L,296L,5277L,436L,5821L,564L,6361L,668L,6997L,712L,7613L,852L,8257L,932L,8945L,972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270210Inst : IEnumerable<long>
{
public static readonly long[] Value=A270210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270210.Bytes);
public long this[int i]=>Value[i];

public static A270210Inst Instance=new A270210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270211
{
public static readonly long[] Value={ 1L,5L,41L,209L,913L,3697L,14809L,59201L,236233L,941057L,3747049L,14924321L,59479753L,237213377L,946629289L,3779628641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270211Inst : IEnumerable<long>
{
public static readonly long[] Value=A270211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270211.Bytes);
public long this[int i]=>Value[i];

public static A270211Inst Instance=new A270211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270308
{
public static readonly long[] Value={ 72L,96L,120L,144L,192L,216L,240L,288L,336L,360L,384L,432L,480L,504L,540L,576L,600L,648L,672L,720L,768L,840L,864L,960L,1008L,1080L,1152L,1200L,1260L,1296L,1344L,1440L,1512L,1536L,1584L,1620L,1680L,1728L,1800L,1872L,1920L,1944L,2016L,2112L,2160L,2240L,2304L,2400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270308Inst : IEnumerable<long>
{
public static readonly long[] Value=A270308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270308.Bytes);
public long this[int i]=>Value[i];

public static A270308Inst Instance=new A270308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270309
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,9L,4L,1L,1L,4L,9L,4L,1L,1L,4L,4L,1L,1L,4L,25L,4L,9L,16L,1L,1L,16L,9L,4L,25L,9L,1L,4L,4L,1L,9L,9L,1L,4L,4L,1L,9L,49L,4L,25L,16L,9L,36L,1L,1L,36L,9L,16L,25L,4L,49L,16L,1L,9L,4L,4L,9L,1L,16L,16L,1L,9L,4L,4L,9L,1L,16L,81L,4L,49L,16L,25L,36L,9L,64L,1L,1L,64L,9L,36L,25L,16L,49L,4L,81L,25L,1L,16L,4L,9L,9L,4L,16L,1L,25L,25L,1L,16L,4L,9L,9L,4L,16L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270309Inst : IEnumerable<long>
{
public static readonly long[] Value=A270309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270309.Bytes);
public long this[int i]=>Value[i];

public static A270309Inst Instance=new A270309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270310
{
public static readonly long[] Value={ 139L,149L,181L,191L,241L,251L,283L,293L,337L,347L,409L,419L,421L,431L,547L,557L,577L,587L,631L,641L,691L,701L,709L,719L,787L,797L,811L,821L,829L,839L,887L,907L,919L,929L,1021L,1031L,1039L,1049L,1051L,1061L,1153L,1163L,1171L,1181L,1249L,1259L,1399L,1409L,1471L,1481L,1627L,1637L,1657L,1699L,1709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270310Inst : IEnumerable<long>
{
public static readonly long[] Value=A270310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270310.Bytes);
public long this[int i]=>Value[i];

public static A270310Inst Instance=new A270310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270311
{
public static readonly long[] Value={ 34L,35L,42L,43L,53L,54L,61L,62L,68L,69L,80L,81L,82L,83L,101L,102L,106L,107L,115L,116L,125L,126L,127L,128L,138L,139L,141L,142L,145L,146L,154L,155L,157L,158L,172L,173L,175L,176L,177L,178L,191L,192L,193L,194L,204L,205L,222L,223L,233L,234L,258L,259L,260L,266L,267L,269L,270L,279L,280L,289L,290L,306L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270311Inst : IEnumerable<long>
{
public static readonly long[] Value=A270311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270311.Bytes);
public long this[int i]=>Value[i];

public static A270311Inst Instance=new A270311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270312
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,13L,21L,34L,11L,89L,12L,233L,377L,122L,987L,1597L,1292L,4181L,1353L,10946L,17711L,28657L,1932L,3001L,121393L,196418L,317811L,514229L,83204L,1346269L,2178309L,3524578L,5702887L,1845493L,414732L,24157817L,39088169L,63245986L,20466831L,165580141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270312Inst : IEnumerable<long>
{
public static readonly long[] Value=A270312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270312.Bytes);
public long this[int i]=>Value[i];

public static A270312Inst Instance=new A270312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270313
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,3L,7L,8L,9L,2L,11L,1L,13L,14L,3L,16L,17L,9L,19L,4L,21L,22L,23L,1L,1L,26L,27L,28L,29L,3L,31L,32L,33L,34L,7L,1L,37L,38L,39L,8L,41L,21L,43L,44L,9L,46L,47L,1L,49L,2L,51L,52L,53L,27L,11L,8L,57L,58L,59L,1L,61L,62L,63L,64L,13L,33L,67L,68L,69L,14L,71L,1L,73L,74L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270313Inst : IEnumerable<long>
{
public static readonly long[] Value=A270313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270313.Bytes);
public long this[int i]=>Value[i];

public static A270313Inst Instance=new A270313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270314
{
public static readonly BigInteger[] Value={ 2L,3L,13L,298L,355823L,306479173303L,BigInteger.Parse("85372761970827958806466"),BigInteger.Parse("16575976283809775714654644103484953548013865676"),BigInteger.Parse("269025959411335919672976939610798847100114463059537709191005089031919232139117472577538965440") };
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
public class A270314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270314Inst Instance=new A270314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270315
{
public static readonly BigInteger[] Value={ 2L,7L,58L,6256L,37041488L,3283456941510566L,BigInteger.Parse("87990824525320083189557345568930"),BigInteger.Parse("6787481189341615675664690311149906782682845820114751821172918190") };
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
public class A270315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270315Inst Instance=new A270315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270316
{
public static readonly BigInteger[] Value={ 2L,2L,8L,123L,149367L,19877572990L,BigInteger.Parse("3398650153657920854371"),BigInteger.Parse("38501744904404393452660892011327652171148221"),BigInteger.Parse("1751742507912624184333715455628345093210972368514121272905550101268413741408122585972087") };
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
public class A270316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270316Inst Instance=new A270316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270317
{
public static readonly long[] Value={ 1L,8L,4L,44L,5L,116L,12L,209L,12L,348L,25L,492L,37L,696L,57L,892L,60L,1165L,88L,1436L,89L,1756L,112L,2089L,152L,2465L,136L,2888L,225L,3264L,236L,3749L,240L,4293L,256L,4757L,316L,5373L,300L,5933L,340L,6548L,505L,7116L,529L,7788L,525L,8456L,641L,9276L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270317Inst : IEnumerable<long>
{
public static readonly long[] Value=A270317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270317.Bytes);
public long this[int i]=>Value[i];

public static A270317Inst Instance=new A270317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270318
{
public static readonly long[] Value={ 1L,8L,44L,209L,892L,3749L,15160L,61205L,245509L,985328L,3942373L,15778036L,63142628L,252596776L,1010495385L,4042114757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270318Inst : IEnumerable<long>
{
public static readonly long[] Value=A270318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270318.Bytes);
public long this[int i]=>Value[i];

public static A270318Inst Instance=new A270318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270319
{
public static readonly long[] Value={ 1L,9L,13L,57L,62L,178L,190L,399L,411L,759L,784L,1276L,1313L,2009L,2066L,2958L,3018L,4183L,4271L,5707L,5796L,7552L,7664L,9753L,9905L,12370L,12506L,15394L,15619L,18883L,19119L,22868L,23108L,27401L,27657L,32414L,32730L,38103L,38403L,44336L,44676L,51224L,51729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270319Inst : IEnumerable<long>
{
public static readonly long[] Value=A270319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270319.Bytes);
public long this[int i]=>Value[i];

public static A270319Inst Instance=new A270319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270320
{
public static readonly long[] Value={ 7L,-4L,40L,-39L,111L,-104L,197L,-197L,336L,-323L,467L,-455L,659L,-639L,835L,-832L,1105L,-1077L,1348L,-1347L,1667L,-1644L,1977L,-1937L,2313L,-2329L,2752L,-2663L,3039L,-3028L,3513L,-3509L,4053L,-4037L,4501L,-4441L,5057L,-5073L,5633L,-5593L,6208L,-6043L,6611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270320Inst : IEnumerable<long>
{
public static readonly long[] Value=A270320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270320.Bytes);
public long this[int i]=>Value[i];

public static A270320Inst Instance=new A270320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270321
{
public static readonly long[] Value={ 1L,5L,8L,20L,20L,44L,32L,84L,44L,100L,68L,188L,72L,192L,132L,304L,140L,344L,172L,516L,132L,384L,276L,700L,232L,612L,388L,928L,356L,900L,440L,1196L,404L,1072L,612L,1564L,432L,1340L,648L,1816L,644L,1544L,808L,2052L,748L,2068L,984L,2588L,884L,2240L,1196L,3052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270321Inst : IEnumerable<long>
{
public static readonly long[] Value=A270321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270321.Bytes);
public long this[int i]=>Value[i];

public static A270321Inst Instance=new A270321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270322
{
public static readonly long[] Value={ 1L,5L,20L,84L,304L,1196L,4280L,16908L,67604L,265124L,1058244L,4212368L,16820404L,67170488L,268817820L,1074835228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270322Inst : IEnumerable<long>
{
public static readonly long[] Value=A270322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270322.Bytes);
public long this[int i]=>Value[i];

public static A270322Inst Instance=new A270322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270323
{
public static readonly long[] Value={ 1L,6L,14L,34L,54L,98L,130L,214L,258L,358L,426L,614L,686L,878L,1010L,1314L,1454L,1798L,1970L,2486L,2618L,3002L,3278L,3978L,4210L,4822L,5210L,6138L,6494L,7394L,7834L,9030L,9434L,10506L,11118L,12682L,13114L,14454L,15102L,16918L,17562L,19106L,19914L,21966L,22714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270323Inst : IEnumerable<long>
{
public static readonly long[] Value=A270323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270323.Bytes);
public long this[int i]=>Value[i];

public static A270323Inst Instance=new A270323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270964
{
public static readonly BigInteger[] Value={ 1L,281L,13297L,348523L,6807872L,113042841L,1709159987L,24469725009L,339634663517L,4638106688642L,62916588549562L,853199404241913L,11616795214297568L,159290998975659690L,2204454156023259166L,BigInteger.Parse("30838108887627521579"),BigInteger.Parse("436552647970998600862"),BigInteger.Parse("6258905749718943712307") };
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
public class A270964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270964Inst Instance=new A270964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270965
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1L,10L,127L,1650L,23258L,361154L,6131236L,113042841L,2248848796L,47985568177L,1092290052791L,26397613960112L,674479517926073L,18153075875657428L,512977569857121559L,15176209471995304906UL,BigInteger.Parse("468847646698743759887"),BigInteger.Parse("15090613008931715532300") };
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
public class A270965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270965Inst Instance=new A270965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270966
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,3L,2L,3L,3L,5L,3L,2L,4L,2L,3L,3L,2L,4L,3L,5L,4L,2L,4L,4L,5L,2L,3L,2L,4L,5L,4L,5L,3L,6L,6L,4L,4L,4L,3L,4L,5L,1L,3L,5L,8L,5L,3L,6L,3L,4L,4L,4L,4L,4L,5L,3L,3L,6L,5L,8L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270966Inst : IEnumerable<long>
{
public static readonly long[] Value=A270966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270966.Bytes);
public long this[int i]=>Value[i];

public static A270966Inst Instance=new A270966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270967
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,3L,1L,21L,10L,4L,1L,76L,36L,15L,5L,1L,281L,133L,57L,21L,6L,1L,1052L,499L,218L,85L,28L,7L,1L,3974L,1890L,838L,339L,121L,36L,8L,1L,15113L,7207L,3233L,1343L,505L,166L,45L,9L,1L,57774L,27622L,12509L,5302L,2069L,726L,221L,55L,10L,1L,221781L,106289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270967Inst : IEnumerable<long>
{
public static readonly long[] Value=A270967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270967.Bytes);
public long this[int i]=>Value[i];

public static A270967Inst Instance=new A270967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270968
{
public static readonly long[] Value={ 3L,1L,13L,9L,23L,7L,33L,19L,43L,3L,53L,29L,63L,17L,73L,39L,83L,11L,93L,49L,103L,27L,113L,59L,123L,1L,133L,69L,143L,37L,153L,79L,163L,21L,173L,89L,183L,47L,193L,99L,203L,13L,213L,109L,223L,57L,233L,119L,243L,31L,253L,129L,263L,67L,273L,139L,283L,9L,293L,149L,303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270968Inst : IEnumerable<long>
{
public static readonly long[] Value=A270968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270968.Bytes);
public long this[int i]=>Value[i];

public static A270968Inst Instance=new A270968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270969
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,1L,1L,3L,3L,2L,2L,2L,2L,1L,2L,4L,5L,4L,3L,3L,3L,1L,2L,5L,5L,5L,3L,3L,4L,1L,2L,5L,6L,4L,4L,4L,4L,2L,2L,6L,6L,4L,2L,5L,4L,1L,2L,5L,7L,6L,5L,4L,7L,3L,2L,6L,4L,4L,3L,4L,5L,2L,2L,6L,9L,6L,4L,6L,6L,1L,3L,6L,6L,7L,3L,5L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270969Inst : IEnumerable<long>
{
public static readonly long[] Value=A270969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270969.Bytes);
public long this[int i]=>Value[i];

public static A270969Inst Instance=new A270969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270970
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,11L,14L,16L,17L,21L,22L,24L,28L,31L,32L,37L,38L,53L,56L,57L,58L,71L,72L,73L,77L,85L,86L,131L,132L,138L,141L,142L,143L,163L,164L,165L,167L,289L,290L,310L,311L,316L,403L,404L,405L,454L,455L,458L,460L,463L,464L,478L,479L,557L,559L,560L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270970Inst : IEnumerable<long>
{
public static readonly long[] Value=A270970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270970.Bytes);
public long this[int i]=>Value[i];

public static A270970Inst Instance=new A270970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270971
{
public static readonly long[] Value={ 192572L,448L,50946L,5216L,154980L,92322L,28672L,300270L,30926L,30522L,294348L,30898L,228104L,105316L,15362L,138154L,353430L,56L,60432L,318646L,31424L,34488L,355678L,224L,151732L,14336L,457534L,52658L,458752L,28856L,478140L,881790L,386158L,292716L,896L,422284L,119078L,1792L,63774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270971Inst : IEnumerable<long>
{
public static readonly long[] Value=A270971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270971.Bytes);
public long this[int i]=>Value[i];

public static A270971Inst Instance=new A270971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270972
{
public static readonly long[] Value={ 19L,8629L,9721L,12109L,13831L,15331L,17029L,17989L,25849L,33151L,56209L,70999L,73039L,78541L,92461L,97369L,97609L,103069L,103969L,147139L,174469L,179719L,203341L,217369L,221401L,242059L,249541L,269431L,277549L,283009L,285559L,324619L,333451L,346669L,393079L,404269L,409261L,424891L,440551L,488689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270972Inst : IEnumerable<long>
{
public static readonly long[] Value=A270972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270972.Bytes);
public long this[int i]=>Value[i];

public static A270972Inst Instance=new A270972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270973
{
public static readonly long[] Value={ 161038L,215326L,209665666L,4783964626L,1656670046626L,1202870727916606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270973Inst : IEnumerable<long>
{
public static readonly long[] Value=A270973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270973.Bytes);
public long this[int i]=>Value[i];

public static A270973Inst Instance=new A270973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270974
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,12L,14L,19L,21L,27L,33L,60L,61L,91L,102L,535L,549L,614L,695L,709L,1014L,2448L,2519L,3464L,3511L,6348L,6841L,11009L,11177L,20754L,26610L,30651L,39246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270974Inst : IEnumerable<long>
{
public static readonly long[] Value=A270974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270974.Bytes);
public long this[int i]=>Value[i];

public static A270974Inst Instance=new A270974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270975
{
public static readonly long[] Value={ 4L,5L,897L,898L,899L,900L,901L,902L,903L,904L,905L,906L,907L,908L,909L,910L,911L,912L,913L,914L,915L,916L,917L,918L,919L,920L,921L,922L,923L,924L,925L,926L,927L,928L,929L,930L,931L,932L,933L,934L,935L,936L,937L,938L,939L,940L,941L,942L,1105L,1106L,1107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270975Inst : IEnumerable<long>
{
public static readonly long[] Value=A270975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270975.Bytes);
public long this[int i]=>Value[i];

public static A270975Inst Instance=new A270975Inst();

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