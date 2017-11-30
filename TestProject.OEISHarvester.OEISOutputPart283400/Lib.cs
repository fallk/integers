using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A138007
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,11L,13L,17L,19L,20L,23L,26L,28L,31L,34L,38L,40L,43L,46L,47L,50L,55L,56L,58L,61L,64L,68L,71L,76L,77L,80L,85L,86L,92L,94L,95L,98L,101L,103L,106L,109L,115L,118L,122L,124L,125L,128L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138007Inst : IEnumerable<long>
{
public static readonly long[] Value=A138007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138007.Bytes);
public long this[int i]=>Value[i];

public static A138007Inst Instance=new A138007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138056
{
public static readonly long[] Value={ 2L,2L,2L,9L,2L,2L,9L,4L,10L,6L,2L,2L,9L,4L,10L,6L,7L,16L,9L,30L,11L,24L,2L,2L,9L,4L,10L,6L,7L,16L,9L,30L,11L,24L,13L,28L,15L,48L,17L,36L,19L,20L,42L,22L,69L,2L,2L,9L,4L,10L,6L,7L,16L,9L,30L,11L,24L,13L,28L,15L,48L,17L,36L,19L,20L,42L,22L,69L,24L,50L,26L,81L,28L,58L,30L,31L,64L,33L,102L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138056Inst : IEnumerable<long>
{
public static readonly long[] Value=A138056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138056.Bytes);
public long this[int i]=>Value[i];

public static A138056Inst Instance=new A138056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138057
{
public static readonly long[] Value={ 0L,0L,-2L,0L,-3L,3L,0L,-4L,4L,-4L,0L,-5L,5L,-5L,5L,0L,-6L,6L,-6L,6L,-6L,0L,-7L,7L,-7L,7L,-7L,7L,0L,-8L,8L,-8L,8L,-8L,8L,-8L,0L,-9L,9L,-9L,9L,-9L,9L,-9L,9L,0L,-10L,10L,-10L,10L,-10L,10L,-10L,10L,-10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138057Inst : IEnumerable<long>
{
public static readonly long[] Value=A138057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138057.Bytes);
public long this[int i]=>Value[i];

public static A138057Inst Instance=new A138057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138058
{
public static readonly long[] Value={ 72546283L,77736383L,85706813L,98486567L,102765683L,112219883L,117611743L,135393509L,142414669L,148261577L,162551173L,162821917L,163175267L,163710121L,172005979L,172341509L,177110701L,178924853L,204020153L,211140343L,226770241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138058Inst : IEnumerable<long>
{
public static readonly long[] Value=A138058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138058.Bytes);
public long this[int i]=>Value[i];

public static A138058Inst Instance=new A138058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138059
{
public static readonly long[] Value={ 123L,135L,201L,363L,987L,1485L,1545L,1593L,1713L,1947L,2211L,2391L,2571L,2577L,2751L,3093L,3273L,3375L,3381L,3693L,3801L,4155L,4407L,4521L,4587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138059Inst : IEnumerable<long>
{
public static readonly long[] Value=A138059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138059.Bytes);
public long this[int i]=>Value[i];

public static A138059Inst Instance=new A138059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138060
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138060Inst : IEnumerable<long>
{
public static readonly long[] Value=A138060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138060.Bytes);
public long this[int i]=>Value[i];

public static A138060Inst Instance=new A138060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138061
{
public static readonly long[] Value={ 2L,2L,6L,2L,6L,12L,2L,6L,12L,4L,2L,6L,12L,4L,5L,12L,2L,6L,12L,4L,5L,12L,7L,16L,27L,2L,6L,12L,4L,5L,12L,7L,16L,27L,10L,22L,36L,52L,2L,6L,12L,4L,5L,12L,7L,16L,27L,10L,22L,36L,52L,14L,30L,48L,68L,18L,2L,6L,12L,4L,5L,12L,7L,16L,27L,10L,22L,36L,52L,14L,30L,48L,68L,18L,19L,40L,63L,88L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138061Inst : IEnumerable<long>
{
public static readonly long[] Value=A138061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138061.Bytes);
public long this[int i]=>Value[i];

public static A138061Inst Instance=new A138061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138062
{
public static readonly long[] Value={ 419L,521L,809L,1049L,1151L,1721L,1931L,1949L,2027L,2111L,2309L,2591L,2729L,2999L,3119L,3359L,3371L,3389L,3557L,3581L,3821L,4229L,4241L,4271L,4337L,4421L,4481L,4547L,5021L,5879L,6089L,6131L,6299L,6449L,6689L,6761L,6779L,6791L,6947L,7307L,7331L,7349L,7559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138062Inst : IEnumerable<long>
{
public static readonly long[] Value=A138062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138062.Bytes);
public long this[int i]=>Value[i];

public static A138062Inst Instance=new A138062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138063
{
public static readonly long[] Value={ 521L,1931L,1949L,2111L,2309L,2591L,3389L,4421L,4547L,6449L,6761L,7349L,7949L,9239L,9719L,9767L,10007L,10037L,10499L,10529L,10709L,11351L,11549L,11717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138063Inst : IEnumerable<long>
{
public static readonly long[] Value=A138063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138063.Bytes);
public long this[int i]=>Value[i];

public static A138063Inst Instance=new A138063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138064
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,0L,1L,-9L,3L,3L,-1L,96L,32L,-20L,-4L,1L,1250L,-125L,-250L,25L,10L,-1L,-19440L,-5184L,2592L,576L,-93L,-12L,1L,-352947L,16807L,50421L,-2401L,-2058L,98L,21L,-1L,7340032L,1572864L,-753664L,-147456L,24064L,3840L,-272L,-24L,1L,172186884L,-4782969L,-19131876L,531441L,708588L,-19683L,-9720L,270L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138064Inst : IEnumerable<long>
{
public static readonly long[] Value=A138064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138064.Bytes);
public long this[int i]=>Value[i];

public static A138064Inst Instance=new A138064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138065
{
public static readonly long[] Value={ 26L,36L,40L,96L,152L,178L,246L,262L,276L,310L,360L,496L,568L,572L,586L,646L,654L,694L,706L,738L,808L,822L,828L,852L,898L,976L,988L,1010L,1060L,1090L,1160L,1182L,1206L,1226L,1240L,1262L,1354L,1368L,1448L,1452L,1504L,1536L,1584L,1644L,1758L,1776L,1816L,1962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138065Inst : IEnumerable<long>
{
public static readonly long[] Value=A138065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138065.Bytes);
public long this[int i]=>Value[i];

public static A138065Inst Instance=new A138065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138066
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,11L,0L,1L,1L,0L,2L,1L,0L,1L,1L,0L,1L,113L,0L,1L,7L,0L,1L,1L,0L,3L,1L,0L,1L,1L,0L,12L,1L,0L,1L,3L,0L,1L,255L,0L,8L,1L,0L,1L,1L,0L,1L,1L,0L,1L,3L,0L,2L,15L,0L,2L,1L,0L,1L,23L,0L,1L,1L,0L,4L,3L,0L,1L,1L,0L,3L,1L,0L,136L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138066Inst : IEnumerable<long>
{
public static readonly long[] Value=A138066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138066.Bytes);
public long this[int i]=>Value[i];

public static A138066Inst Instance=new A138066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138067
{
public static readonly long[] Value={ 2L,2L,3L,0L,2L,5L,0L,2L,105L,0L,2L,11L,0L,5L,3L,0L,2L,15L,0L,2L,9L,0L,2L,113L,0L,5L,7L,0L,2L,27L,0L,3L,3L,0L,3L,3L,0L,12L,61L,0L,2L,3L,0L,4L,255L,0L,8L,63L,0L,2L,9L,0L,2L,3473L,0L,2L,3L,0L,2L,15L,0L,2L,87L,0L,3L,23L,0L,36L,1861L,0L,4L,3L,0L,2L,5L,0L,3L,7L,0L,136L,425L,0L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138067Inst : IEnumerable<long>
{
public static readonly long[] Value=A138067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138067.Bytes);
public long this[int i]=>Value[i];

public static A138067Inst Instance=new A138067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138068
{
public static readonly long[] Value={ 2L,2L,2L,2L,7L,2L,2L,7L,7L,2L,2L,7L,1L,7L,2L,2L,7L,1L,1L,7L,2L,2L,7L,1L,8L,1L,7L,2L,2L,7L,1L,8L,8L,1L,7L,2L,2L,7L,1L,8L,2L,8L,1L,7L,2L,2L,7L,1L,8L,2L,2L,8L,1L,7L,2L,2L,7L,1L,8L,2L,8L,2L,8L,1L,7L,2L,2L,7L,1L,8L,2L,8L,8L,2L,8L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138068Inst : IEnumerable<long>
{
public static readonly long[] Value=A138068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138068.Bytes);
public long this[int i]=>Value[i];

public static A138068Inst Instance=new A138068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138069
{
public static readonly long[] Value={ 2L,2L,7L,2L,2L,7L,1L,7L,2L,2L,7L,1L,8L,1L,7L,2L,2L,7L,1L,8L,2L,8L,1L,7L,2L,2L,7L,1L,8L,2L,8L,2L,8L,1L,7L,2L,2L,7L,1L,8L,2L,8L,1L,8L,2L,8L,1L,7L,2L,2L,7L,1L,8L,2L,8L,1L,8L,1L,8L,2L,8L,1L,7L,2L,2L,7L,1L,8L,2L,8L,1L,8L,2L,8L,1L,8L,2L,8L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138069Inst : IEnumerable<long>
{
public static readonly long[] Value=A138069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138069.Bytes);
public long this[int i]=>Value[i];

public static A138069Inst Instance=new A138069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138070
{
public static readonly long[] Value={ 3L,3L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,4L,1L,3L,3L,1L,4L,4L,1L,3L,3L,1L,4L,1L,4L,1L,3L,3L,1L,4L,1L,1L,4L,1L,3L,3L,1L,4L,1L,5L,1L,4L,1L,3L,3L,1L,4L,1L,5L,5L,1L,4L,1L,3L,3L,1L,4L,1L,5L,9L,5L,1L,4L,1L,3L,3L,1L,4L,1L,5L,9L,9L,5L,1L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138070Inst : IEnumerable<long>
{
public static readonly long[] Value=A138070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138070.Bytes);
public long this[int i]=>Value[i];

public static A138070Inst Instance=new A138070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138071
{
public static readonly long[] Value={ 3L,3L,1L,3L,3L,1L,4L,1L,3L,3L,1L,4L,1L,4L,1L,3L,3L,1L,4L,1L,5L,1L,4L,1L,3L,3L,1L,4L,1L,5L,9L,5L,1L,4L,1L,3L,3L,1L,4L,1L,5L,9L,2L,9L,5L,1L,4L,1L,3L,3L,1L,4L,1L,5L,9L,2L,6L,2L,9L,5L,1L,4L,1L,3L,3L,1L,4L,1L,5L,9L,2L,6L,5L,6L,2L,9L,5L,1L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138071Inst : IEnumerable<long>
{
public static readonly long[] Value=A138071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138071.Bytes);
public long this[int i]=>Value[i];

public static A138071Inst Instance=new A138071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138088
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,3L,0L,1L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138088Inst : IEnumerable<long>
{
public static readonly long[] Value=A138088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138088.Bytes);
public long this[int i]=>Value[i];

public static A138088Inst Instance=new A138088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138089
{
public static readonly long[] Value={ 2L,13L,42L,46L,57L,102L,104L,111L,167L,171L,182L,189L,191L,207L,244L,268L,298L,312L,322L,349L,366L,368L,371L,442L,466L,477L,508L,517L,553L,661L,674L,686L,728L,737L,748L,776L,829L,886L,921L,938L,946L,1053L,1109L,1117L,1134L,1152L,1171L,1172L,1186L,1197L,1211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138089Inst : IEnumerable<long>
{
public static readonly long[] Value=A138089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138089.Bytes);
public long this[int i]=>Value[i];

public static A138089Inst Instance=new A138089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138090
{
public static readonly long[] Value={ 1L,0L,2L,-2L,0L,4L,0L,-10L,0L,12L,8L,0L,-36L,0L,32L,0L,66L,0L,-140L,0L,80L,-48L,0L,348L,0L,-512L,0L,208L,0L,-558L,0L,1708L,0L,-1728L,0L,544L,384L,0L,-3900L,0L,7776L,0L,-5680L,0L,1408L,0L,5790L,0L,-23364L,0L,32496L,0L,-18304L,0L,3648L,-3840L,0L,50580L,0L,-126720L,0L,128624L,0L,-57600L,0L,9472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138090Inst : IEnumerable<long>
{
public static readonly long[] Value=A138090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138090.Bytes);
public long this[int i]=>Value[i];

public static A138090Inst Instance=new A138090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138091
{
public static readonly long[] Value={ 25L,43L,55L,109L,131L,379L,389L,587L,617L,649L,683L,697L,719L,971L,1013L,1279L,1291L,1727L,1735L,1823L,1853L,2005L,2059L,2087L,2167L,2395L,2399L,2561L,2647L,2783L,2957L,2983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138091Inst : IEnumerable<long>
{
public static readonly long[] Value=A138091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138091.Bytes);
public long this[int i]=>Value[i];

public static A138091Inst Instance=new A138091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138092
{
public static readonly long[] Value={ 1L,0L,2L,-2L,0L,4L,0L,-10L,0L,12L,-8L,0L,-36L,0L,32L,0L,-16L,0L,-140L,0L,80L,120L,0L,40L,0L,-512L,0L,208L,0L,842L,0L,440L,0L,-1728L,0L,544L,-448L,0L,3668L,0L,2864L,0L,-5680L,0L,1408L,0L,-7178L,0L,15196L,0L,14960L,0L,-18304L,0L,3648L,-7520L,0L,-55036L,0L,56320L,0L,67680L,0L,-57600L,0L,9472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138092Inst : IEnumerable<long>
{
public static readonly long[] Value=A138092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138092.Bytes);
public long this[int i]=>Value[i];

public static A138092Inst Instance=new A138092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138093
{
public static readonly long[] Value={ 1L,0L,2L,2L,0L,4L,0L,10L,0L,12L,24L,0L,36L,0L,32L,0L,148L,0L,140L,0L,86L,432L,0L,656L,0L,512L,0L,232L,0L,3076L,0L,2976L,0L,1782L,0L,616L,6016L,0L,15752L,0L,12688L,0L,6040L,0L,1648L,0L,58994L,0L,80104L,0L,51148L,0L,19888L,0L,4416L,127360L,0L,377108L,0L,382592L,0L,198688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138093Inst : IEnumerable<long>
{
public static readonly long[] Value=A138093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138093.Bytes);
public long this[int i]=>Value[i];

public static A138093Inst Instance=new A138093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138094
{
public static readonly long[] Value={ 1L,0L,2L,2L,0L,4L,0L,10L,0L,12L,24L,0L,36L,0L,32L,0L,148L,0L,140L,0L,86L,432L,0L,656L,0L,512L,0L,232L,0L,3076L,0L,2976L,0L,1782L,0L,624L,10112L,0L,15752L,0L,12688L,0L,6040L,0L,1680L,0L,80308L,0L,80104L,0L,51148L,0L,19976L,0L,4512L,188320L,0L,459736L,0L,382592L,0L,198688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138094Inst : IEnumerable<long>
{
public static readonly long[] Value=A138094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138094.Bytes);
public long this[int i]=>Value[i];

public static A138094Inst Instance=new A138094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138095
{
public static readonly long[] Value={ 1L,3L,3L,4L,6L,7L,7L,10L,10L,10L,13L,14L,14L,15L,15L,17L,18L,19L,20L,22L,22L,22L,24L,25L,25L,27L,29L,30L,32L,32L,31L,32L,34L,35L,38L,36L,39L,39L,41L,42L,44L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138095Inst : IEnumerable<long>
{
public static readonly long[] Value=A138095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138095.Bytes);
public long this[int i]=>Value[i];

public static A138095Inst Instance=new A138095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138096
{
public static readonly long[] Value={ 7L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,6L,6L,6L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138096Inst : IEnumerable<long>
{
public static readonly long[] Value=A138096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138096.Bytes);
public long this[int i]=>Value[i];

public static A138096Inst Instance=new A138096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138097
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,11L,13L,15L,17L,18L,20L,22L,23L,25L,28L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138097Inst : IEnumerable<long>
{
public static readonly long[] Value=A138097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138097.Bytes);
public long this[int i]=>Value[i];

public static A138097Inst Instance=new A138097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138098
{
public static readonly long[] Value={ 2L,1L,10L,9L,8L,7L,6L,5L,4L,3L,18L,17L,16L,15L,14L,13L,12L,11L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,86L,85L,84L,83L,82L,81L,80L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,118L,117L,116L,115L,114L,113L,112L,111L,110L,109L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138098Inst : IEnumerable<long>
{
public static readonly long[] Value=A138098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138098.Bytes);
public long this[int i]=>Value[i];

public static A138098Inst Instance=new A138098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138099
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,3L,4L,5L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,8L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,7L,8L,9L,10L,11L,12L,13L,8L,9L,10L,11L,12L,13L,14L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L,15L,16L,9L,10L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138099Inst : IEnumerable<long>
{
public static readonly long[] Value=A138099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138099.Bytes);
public long this[int i]=>Value[i];

public static A138099Inst Instance=new A138099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138100
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,8L,9L,10L,11L,12L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138100Inst : IEnumerable<long>
{
public static readonly long[] Value=A138100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138100.Bytes);
public long this[int i]=>Value[i];

public static A138100Inst Instance=new A138100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138101
{
public static readonly long[] Value={ 3L,4L,13L,14L,15L,16L,17L,18L,19L,20L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138101Inst : IEnumerable<long>
{
public static readonly long[] Value=A138101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138101.Bytes);
public long this[int i]=>Value[i];

public static A138101Inst Instance=new A138101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138102
{
public static readonly long[] Value={ 2L,2L,8L,8L,8L,8L,8L,8L,8L,8L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138102Inst : IEnumerable<long>
{
public static readonly long[] Value=A138102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138102.Bytes);
public long this[int i]=>Value[i];

public static A138102Inst Instance=new A138102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138103
{
public static readonly long[] Value={ 1L,6L,8L,9L,10L,11L,13L,19L,25L,31L,36L,38L,39L,40L,41L,43L,48L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,68L,69L,70L,71L,73L,78L,80L,81L,82L,83L,85L,91L,97L,103L,109L,114L,116L,117L,118L,119L,121L,127L,133L,139L,145L,150L,152L,153L,154L,155L,157L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138103Inst : IEnumerable<long>
{
public static readonly long[] Value=A138103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138103.Bytes);
public long this[int i]=>Value[i];

public static A138103Inst Instance=new A138103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138120
{
public static readonly BigInteger[] Value={ 101L,1100011L,11100000111L,111100000001111L,1111100000000011111L,BigInteger.Parse("11111100000000000111111"),BigInteger.Parse("111111100000000000001111111"),BigInteger.Parse("1111111100000000000000011111111"),BigInteger.Parse("11111111100000000000000000111111111") };
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
public class A138120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A138120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A138120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A138120Inst Instance=new A138120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138121
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,4L,2L,2L,1L,1L,1L,5L,3L,2L,1L,1L,1L,1L,1L,6L,3L,3L,4L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,7L,4L,3L,5L,2L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,4L,4L,5L,3L,6L,2L,3L,3L,2L,4L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,9L,5L,4L,6L,3L,3L,3L,3L,7L,2L,4L,3L,2L,5L,2L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138121Inst : IEnumerable<long>
{
public static readonly long[] Value=A138121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138121.Bytes);
public long this[int i]=>Value[i];

public static A138121Inst Instance=new A138121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138122
{
public static readonly long[] Value={ 7L,11L,37L,41L,67L,71L,97L,101L,127L,131L,277L,281L,307L,311L,397L,401L,457L,461L,487L,491L,757L,761L,877L,881L,907L,911L,937L,941L,967L,971L,1087L,1091L,1297L,1301L,1447L,1451L,1567L,1571L,1597L,1601L,1867L,1871L,2137L,2141L,2347L,2351L,2377L,2381L,2437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138122Inst : IEnumerable<long>
{
public static readonly long[] Value=A138122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138122.Bytes);
public long this[int i]=>Value[i];

public static A138122Inst Instance=new A138122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138123
{
public static readonly long[] Value={ 1L,1L,3L,0L,3L,0L,7L,1L,11L,0L,17L,0L,29L,1L,47L,0L,75L,0L,123L,1L,199L,0L,321L,0L,521L,1L,843L,0L,1363L,0L,2207L,1L,3571L,0L,5777L,0L,9349L,1L,15127L,0L,24475L,0L,39603L,1L,64079L,0L,103681L,0L,167761L,1L,271443L,0L,439203L,0L,710647L,1L,1149851L,0L,1860497L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138123Inst : IEnumerable<long>
{
public static readonly long[] Value=A138123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138123.Bytes);
public long this[int i]=>Value[i];

public static A138123Inst Instance=new A138123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138124
{
public static readonly long[] Value={ 2L,4L,1L,6L,4L,6L,2L,1L,1L,3L,8L,8L,3L,2L,5L,7L,2L,1L,9L,1L,2L,1L,1L,2L,2L,2L,4L,2L,2L,2L,3L,8L,6L,2L,4L,3L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138124Inst : IEnumerable<long>
{
public static readonly long[] Value=A138124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138124.Bytes);
public long this[int i]=>Value[i];

public static A138124Inst Instance=new A138124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138125
{
public static readonly long[] Value={ 2L,4L,6L,4L,6L,6L,4L,4L,6L,6L,4L,4L,6L,4L,4L,4L,6L,6L,6L,4L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,4L,4L,6L,4L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138125Inst : IEnumerable<long>
{
public static readonly long[] Value=A138125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138125.Bytes);
public long this[int i]=>Value[i];

public static A138125Inst Instance=new A138125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138126
{
public static readonly long[] Value={ 2L,14L,84L,86L,471L,481L,3570L,28674L,28743L,29448L,29457L,37293L,37299L,239128L,239793L,239800L,239852L,239864L,245780L,245859L,246469L,246541L,305733L,311548L,311615L,312235L,2108429L,2114208L,2114772L,2629825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138126Inst : IEnumerable<long>
{
public static readonly long[] Value=A138126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138126.Bytes);
public long this[int i]=>Value[i];

public static A138126Inst Instance=new A138126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138127
{
public static readonly long[] Value={ 0L,127L,254L,381L,508L,635L,762L,889L,1016L,1143L,1270L,1397L,1524L,1651L,1778L,1905L,2032L,2159L,2286L,2413L,2540L,2667L,2794L,2921L,3048L,3175L,3302L,3429L,3556L,3683L,3810L,3937L,4064L,4191L,4318L,4445L,4572L,4699L,4826L,4953L,5080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138127Inst : IEnumerable<long>
{
public static readonly long[] Value=A138127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138127.Bytes);
public long this[int i]=>Value[i];

public static A138127Inst Instance=new A138127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138128
{
public static readonly BigInteger[] Value={ 1L,127L,16129L,2048383L,260144641L,33038369407L,4195872914689L,532875860165503L,67675234241018881L,8594754748609397887L,BigInteger.Parse("1091533853073393531649"),BigInteger.Parse("138624799340320978519423") };
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
public class A138128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138128Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A138128.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A138128.Bytes);
public BigInteger this[int i]=>Value[i];

public static A138128Inst Instance=new A138128Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138129
{
public static readonly long[] Value={ 0L,1729L,3458L,5187L,6916L,8645L,10374L,12103L,13832L,15561L,17290L,19019L,20748L,22477L,24206L,25935L,27664L,29393L,31122L,32851L,34580L,36309L,38038L,39767L,41496L,43225L,44954L,46683L,48412L,50141L,51870L,53599L,55328L,57057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138129Inst : IEnumerable<long>
{
public static readonly long[] Value=A138129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138129.Bytes);
public long this[int i]=>Value[i];

public static A138129Inst Instance=new A138129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138130
{
public static readonly BigInteger[] Value={ 1L,1729L,2989441L,5168743489L,8936757492481L,15451653704499649L,BigInteger.Parse("26715909255079893121"),BigInteger.Parse("46191807102033135206209"),BigInteger.Parse("79865634479415290771535361"),BigInteger.Parse("138087682014909037743984639169") };
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
public class A138130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A138130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A138130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A138130Inst Instance=new A138130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138131
{
public static readonly long[] Value={ 0L,101L,202L,303L,404L,505L,606L,707L,808L,909L,11011L,12021L,13031L,14041L,15051L,16061L,17071L,18081L,19091L,21012L,22022L,23032L,24042L,25052L,26062L,27072L,28082L,29092L,31013L,32023L,33033L,34043L,35053L,36063L,37073L,38083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138131Inst : IEnumerable<long>
{
public static readonly long[] Value=A138131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138131.Bytes);
public long this[int i]=>Value[i];

public static A138131Inst Instance=new A138131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138132
{
public static readonly long[] Value={ 471L,3570L,28674L,28743L,13077233344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138132Inst : IEnumerable<long>
{
public static readonly long[] Value=A138132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138132.Bytes);
public long this[int i]=>Value[i];

public static A138132Inst Instance=new A138132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138133
{
public static readonly long[] Value={ 0L,2L,-4L,0L,-1L,6L,-6L,0L,0L,-8L,24L,-16L,0L,2L,0L,-60L,120L,-60L,0L,0L,48L,0L,-480L,720L,-288L,0L,-40L,0L,840L,0L,-4200L,5040L,-1680L,0L,0L,-1920L,0L,13440L,0L,-40320L,40320L,-11520L,0L,3024L,0L,-60480L,0L,211680L,0L,-423360L,362880L,-90720L,0L,0L,241920L,0L,-1612800L,0L,3386880L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138133Inst : IEnumerable<long>
{
public static readonly long[] Value=A138133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138133.Bytes);
public long this[int i]=>Value[i];

public static A138133Inst Instance=new A138133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138134
{
public static readonly long[] Value={ 0L,5L,60L,670L,7435L,82460L,914500L,10141965L,112476120L,1247379290L,13833648315L,153417510760L,1701426266680L,18869106444245L,209261597153380L,2320746675131430L,25737475023599115L,285432971934721700L,3165500166305537820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138134Inst : IEnumerable<long>
{
public static readonly long[] Value=A138134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138134.Bytes);
public long this[int i]=>Value[i];

public static A138134Inst Instance=new A138134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138135
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,8L,8L,17L,20L,34L,41L,68L,80L,123L,153L,219L,271L,382L,469L,642L,795L,1055L,1305L,1713L,2102L,2713L,3336L,4241L,5190L,6545L,7968L,9950L,12090L,14953L,18104L,22255L,26821L,32752L,39371L,47774L,57220L,69104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138135Inst : IEnumerable<long>
{
public static readonly long[] Value=A138135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138135.Bytes);
public long this[int i]=>Value[i];

public static A138135Inst Instance=new A138135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138168
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,9L,12L,20L,21L,22L,23L,26L,27L,29L,38L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,71L,78L,79L,87L,92L,93L,94L,95L,103L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138168Inst : IEnumerable<long>
{
public static readonly long[] Value=A138168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138168.Bytes);
public long this[int i]=>Value[i];

public static A138168Inst Instance=new A138168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138169
{
public static readonly long[] Value={ 1L,0L,-2L,2L,-1L,1L,6L,-12L,6L,0L,12L,-24L,-12L,72L,-72L,24L,24L,-52L,-88L,356L,-240L,-360L,720L,-480L,120L,0L,-720L,2280L,-1320L,-3720L,6360L,-1200L,-6000L,7200L,-3600L,720L,-3060L,10260L,2580L,-56340L,86760L,-12480L,-95760L,93240L,12600L,-88200L,75600L,-30240L,5040L,0L,171360L,-745920L,994560L,383040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138169Inst : IEnumerable<long>
{
public static readonly long[] Value=A138169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138169.Bytes);
public long this[int i]=>Value[i];

public static A138169Inst Instance=new A138169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138170
{
public static readonly long[] Value={ 2L,3L,5L,23L,31L,61L,83L,89L,149L,179L,239L,251L,263L,269L,353L,367L,419L,433L,449L,503L,557L,569L,571L,587L,653L,701L,733L,761L,839L,941L,983L,991L,1109L,1123L,1187L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138170Inst : IEnumerable<long>
{
public static readonly long[] Value=A138170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138170.Bytes);
public long this[int i]=>Value[i];

public static A138170Inst Instance=new A138170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138171
{
public static readonly long[] Value={ 45L,81L,105L,117L,165L,225L,261L,273L,297L,315L,325L,333L,345L,357L,385L,405L,435L,441L,465L,477L,495L,513L,525L,555L,561L,567L,585L,595L,621L,625L,627L,651L,675L,693L,705L,715L,765L,777L,795L,801L,825L,837L,855L,861L,885L,891L,897L,915L,925L,945L,957L,975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138171Inst : IEnumerable<long>
{
public static readonly long[] Value=A138171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138171.Bytes);
public long this[int i]=>Value[i];

public static A138171Inst Instance=new A138171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138172
{
public static readonly long[] Value={ 62L,74L,134L,146L,164L,188L,194L,206L,254L,274L,278L,284L,314L,356L,362L,386L,398L,404L,422L,428L,454L,458L,482L,494L,524L,538L,554L,566L,584L,614L,626L,662L,674L,692L,734L,746L,758L,764L,794L,818L,824L,854L,866L,890L,914L,926L,934L,944L,956L,974L,998L,1004L,1028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138172Inst : IEnumerable<long>
{
public static readonly long[] Value=A138172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138172.Bytes);
public long this[int i]=>Value[i];

public static A138172Inst Instance=new A138172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138173
{
public static readonly long[] Value={ 1L,16L,21L,55L,63L,154L,17L,4L,201L,10L,23L,113L,257L,27L,609L,295L,307L,148L,1535L,342L,164L,1692L,809L,1793L,397L,878L,9L,428L,944L,4482L,987L,1008L,1029L,4872L,107L,2349L,5154L,5247L,2478L,252L,552L,5609L,5697L,5785L,2726L,1284L,2806L,6131L,2885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138173Inst : IEnumerable<long>
{
public static readonly long[] Value=A138173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138173.Bytes);
public long this[int i]=>Value[i];

public static A138173Inst Instance=new A138173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138174
{
public static readonly long[] Value={ 1L,4096L,9261L,166375L,250047L,3652264L,4913L,64L,8120601L,1000L,12167L,1442897L,16974593L,19683L,225866529L,25672375L,28934443L,3241792L,3616805375L,40001688L,4410944L,4843965888L,529475129L,5764224257L,62570773L,676836152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138174Inst : IEnumerable<long>
{
public static readonly long[] Value=A138174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138174.Bytes);
public long this[int i]=>Value[i];

public static A138174Inst Instance=new A138174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138175
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,62L,156L,408L,1048L,2758L,7164L,18922L,49488L,131016L,344208L,912720L,2405496L,6385814L,16868604L,44818494L,118595064L,315299694L,835423164L,2222185344L,5894038944L,15684059112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138175Inst : IEnumerable<long>
{
public static readonly long[] Value=A138175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138175.Bytes);
public long this[int i]=>Value[i];

public static A138175Inst Instance=new A138175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138176
{
public static readonly BigInteger[] Value={ 1L,-4L,144L,-43264L,106832896L,-2155963622400L,354617391605760000L,BigInteger.Parse("-474686810341051524710400"),BigInteger.Parse("5166329306435680284163452174336"),BigInteger.Parse("-456900249341808231214942590547243565056") };
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
public class A138176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A138176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A138176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A138176Inst Instance=new A138176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138177
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,1L,7L,15L,10L,1L,10L,36L,52L,26L,1L,14L,74L,176L,190L,76L,1L,18L,132L,460L,810L,696L,232L,1L,23L,222L,1060L,2705L,3756L,2674L,764L,1L,28L,347L,2180L,7565L,15106L,17262L,10480L,2620L,1L,34L,525L,4204L,19013L,51162L,83440L,80816L,42732L,9496L,1L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138177Inst : IEnumerable<long>
{
public static readonly long[] Value=A138177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138177.Bytes);
public long this[int i]=>Value[i];

public static A138177Inst Instance=new A138177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138178
{
public static readonly long[] Value={ 1L,1L,3L,9L,33L,125L,531L,2349L,11205L,55589L,291423L,1583485L,8985813L,52661609L,319898103L,2000390153L,12898434825L,85374842121L,580479540219L,4041838056561L,28824970996809L,210092964771637L,1564766851282299L,11890096357039749L,92151199272181629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138178Inst : IEnumerable<long>
{
public static readonly long[] Value=A138178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138178.Bytes);
public long this[int i]=>Value[i];

public static A138178Inst Instance=new A138178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138179
{
public static readonly long[] Value={ 21L,48L,85L,144L,217L,320L,441L,600L,781L,1008L,1261L,1568L,1905L,2304L,2737L,3240L,3781L,4400L,5061L,5808L,6601L,7488L,8425L,9464L,10557L,11760L,13021L,14400L,15841L,17408L,19041L,20808L,22645L,24624L,26677L,28880L,31161L,33600L,36121L,38808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138179Inst : IEnumerable<long>
{
public static readonly long[] Value=A138179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138179.Bytes);
public long this[int i]=>Value[i];

public static A138179Inst Instance=new A138179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138180
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,1L,2L,3L,4L,5L,8L,9L,15L,24L,80L,1L,2L,3L,4L,5L,6L,7L,8L,9L,14L,15L,20L,24L,27L,35L,48L,49L,63L,80L,125L,224L,2400L,4374L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,14L,15L,20L,21L,24L,27L,32L,35L,44L,48L,49L,54L,55L,63L,80L,98L,99L,120L,125L,175L,224L,242L,384L,440L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138180Inst : IEnumerable<long>
{
public static readonly long[] Value=A138180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138180.Bytes);
public long this[int i]=>Value[i];

public static A138180Inst Instance=new A138180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138181
{
public static readonly long[] Value={ 2L,3L,5L,5L,8L,13L,13L,13L,21L,21L,21L,34L,34L,34L,34L,34L,55L,55L,55L,55L,55L,55L,55L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,233L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138181Inst : IEnumerable<long>
{
public static readonly long[] Value=A138181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138181.Bytes);
public long this[int i]=>Value[i];

public static A138181Inst Instance=new A138181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138182
{
public static readonly long[] Value={ 2L,3L,5L,2L,3L,13L,1L,1L,2L,8L,2L,3L,2L,1L,13L,1L,1L,1L,1L,3L,5L,3L,2L,89L,8L,1L,1L,5L,2L,3L,1L,8L,1L,3L,5L,2L,13L,1L,2L,8L,1L,3L,13L,2L,1L,55L,1L,3L,2L,1L,233L,1L,8L,5L,3L,1L,2L,1L,2L,1L,3L,5L,1L,2L,1L,8L,1L,2L,1L,1L,2L,3L,3L,1L,2L,1L,1L,2L,3L,3L,8L,2L,2L,1L,2L,3L,1L,1L,8L,2L,1L,13L,21L,1L,1L,3L,1L,144L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138182Inst : IEnumerable<long>
{
public static readonly long[] Value=A138182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138182.Bytes);
public long this[int i]=>Value[i];

public static A138182Inst Instance=new A138182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138183
{
public static readonly long[] Value={ 2L,3L,5L,8L,13L,13L,21L,21L,34L,34L,34L,55L,55L,55L,55L,55L,89L,89L,89L,89L,89L,89L,89L,89L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,377L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138183Inst : IEnumerable<long>
{
public static readonly long[] Value=A138183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138183.Bytes);
public long this[int i]=>Value[i];

public static A138183Inst Instance=new A138183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138248
{
public static readonly long[] Value={ 11L,29L,59L,71L,181L,199L,241L,251L,431L,491L,809L,991L,1051L,1109L,1151L,1231L,1249L,1289L,1319L,1459L,1571L,1931L,1949L,2099L,2411L,2729L,2909L,2939L,3301L,3461L,3499L,3511L,3881L,3889L,4201L,4231L,4651L,4679L,4721L,4889L,5011L,5081L,5209L,5639L,6299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138248Inst : IEnumerable<long>
{
public static readonly long[] Value=A138248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138248.Bytes);
public long this[int i]=>Value[i];

public static A138248Inst Instance=new A138248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138249
{
public static readonly long[] Value={ 3L,13L,43L,67L,113L,157L,283L,337L,503L,823L,883L,1123L,1217L,1327L,1483L,1583L,1597L,1607L,1613L,1753L,1973L,2017L,2027L,2083L,2383L,2423L,2467L,2803L,3067L,3203L,3343L,3797L,3917L,3923L,4057L,4217L,4337L,4397L,4903L,4987L,5387L,5443L,5477L,5807L,5953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138249Inst : IEnumerable<long>
{
public static readonly long[] Value=A138249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138249.Bytes);
public long this[int i]=>Value[i];

public static A138249Inst Instance=new A138249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138250
{
public static readonly long[] Value={ 2L,5L,19L,41L,43L,71L,113L,131L,167L,223L,229L,281L,331L,383L,457L,461L,467L,509L,541L,593L,797L,839L,937L,947L,971L,1009L,1013L,1087L,1097L,1153L,1231L,1289L,1471L,1553L,1559L,1699L,1787L,2003L,2099L,2113L,2617L,2683L,2689L,2731L,2749L,2861L,2879L,2917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138250Inst : IEnumerable<long>
{
public static readonly long[] Value=A138250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138250.Bytes);
public long this[int i]=>Value[i];

public static A138250Inst Instance=new A138250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138251
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,21L,23L,24L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,41L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,57L,58L,60L,61L,63L,64L,65L,67L,68L,70L,71L,73L,74L,76L,77L,79L,80L,82L,83L,85L,86L,87L,89L,90L,92L,93L,95L,96L,98L,99L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138251Inst : IEnumerable<long>
{
public static readonly long[] Value=A138251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138251.Bytes);
public long this[int i]=>Value[i];

public static A138251Inst Instance=new A138251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138252
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,18L,22L,25L,28L,31L,34L,37L,40L,44L,47L,50L,53L,56L,59L,62L,66L,69L,72L,75L,78L,81L,84L,88L,91L,94L,97L,100L,103L,107L,110L,113L,116L,119L,122L,125L,129L,132L,135L,138L,141L,144L,147L,151L,154L,157L,160L,163L,166L,169L,173L,176L,179L,182L,185L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138252Inst : IEnumerable<long>
{
public static readonly long[] Value=A138252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138252.Bytes);
public long this[int i]=>Value[i];

public static A138252Inst Instance=new A138252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138253
{
public static readonly long[] Value={ 1L,2L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,2L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,2L,1L,2L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138253Inst : IEnumerable<long>
{
public static readonly long[] Value=A138253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138253.Bytes);
public long this[int i]=>Value[i];

public static A138253Inst Instance=new A138253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138254
{
public static readonly long[] Value={ 10657L,15161L,422911L,691709L,735877L,816239L,1025267L,1030511L,1471891L,1618937L,1683497L,2125411L,2322367L,2448961L,2776157L,2856461L,2880949L,3027319L,3091409L,3114509L,3183337L,3642479L,3797539L,3858091L,3894181L,4752031L,5383387L,5832467L,6052927L,6077821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138254Inst : IEnumerable<long>
{
public static readonly long[] Value=A138254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138254.Bytes);
public long this[int i]=>Value[i];

public static A138254Inst Instance=new A138254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138255
{
public static readonly long[] Value={ 1L,1L,5L,4L,6L,5L,9L,8L,7L,6L,12L,15L,14L,9L,13L,8L,10L,7L,21L,28L,13L,24L,48L,15L,22L,14L,19L,9L,30L,13L,11L,8L,31L,10L,13L,21L,38L,21L,14L,39L,22L,13L,29L,63L,13L,67L,135L,65L,43L,22L,10L,15L,35L,19L,24L,9L,21L,30L,120L,28L,62L,11L,13L,16L,14L,31L,69L,20L,67L,13L,145L,21L,19L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138255Inst : IEnumerable<long>
{
public static readonly long[] Value=A138255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138255.Bytes);
public long this[int i]=>Value[i];

public static A138255Inst Instance=new A138255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138256
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,5L,13L,5L,3L,4L,6L,5L,7L,13L,13L,5L,16L,10L,15L,4L,13L,11L,15L,5L,22L,7L,9L,13L,30L,13L,33L,17L,11L,16L,13L,10L,19L,37L,7L,13L,8L,13L,55L,11L,14L,67L,35L,5L,43L,22L,82L,7L,108L,92L,20L,13L,37L,30L,120L,13L,11L,33L,26L,17L,14L,11L,23L,16L,24L,13L,72L,10L,13L,19L,22L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138256Inst : IEnumerable<long>
{
public static readonly long[] Value=A138256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138256.Bytes);
public long this[int i]=>Value[i];

public static A138256Inst Instance=new A138256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138257
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,5L,3L,2L,7L,7L,6L,5L,7L,13L,7L,4L,5L,7L,9L,7L,3L,6L,10L,22L,11L,7L,19L,13L,15L,7L,6L,4L,31L,5L,13L,7L,19L,20L,7L,22L,11L,13L,15L,31L,7L,24L,10L,69L,43L,11L,5L,7L,44L,19L,31L,26L,9L,15L,42L,7L,31L,6L,13L,4L,7L,31L,69L,5L,67L,13L,124L,26L,9L,19L,11L,20L,31L,7L,18L,69L,28L,11L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138257Inst : IEnumerable<long>
{
public static readonly long[] Value=A138257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138257.Bytes);
public long this[int i]=>Value[i];

public static A138257Inst Instance=new A138257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138258
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,2L,6L,7L,7L,7L,22L,2L,4L,6L,7L,13L,16L,7L,10L,7L,6L,31L,55L,7L,5L,4L,19L,6L,15L,7L,6L,17L,31L,16L,13L,7L,36L,10L,4L,7L,3L,6L,42L,31L,7L,55L,51L,13L,43L,26L,16L,4L,52L,19L,31L,13L,18L,15L,27L,7L,31L,6L,13L,17L,17L,31L,9L,16L,67L,13L,11L,7L,66L,36L,26L,18L,31L,4L,9L,13L,56L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138258Inst : IEnumerable<long>
{
public static readonly long[] Value=A138258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138258.Bytes);
public long this[int i]=>Value[i];

public static A138258Inst Instance=new A138258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138259
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,1L,11L,3L,2L,7L,21L,3L,20L,11L,7L,6L,40L,2L,10L,219L,11L,21L,20L,3L,11L,20L,4L,119L,15L,7L,7L,6L,31L,40L,11L,3L,13L,37L,33L,219L,42L,11L,7L,130L,38L,20L,33L,6L,15L,11L,57L,20L,79L,4L,21L,119L,10L,15L,60L,219L,62L,7L,38L,9L,37L,31L,50L,259L,49L,11L,211L,3L,37L,13L,11L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138259Inst : IEnumerable<long>
{
public static readonly long[] Value=A138259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138259.Bytes);
public long this[int i]=>Value[i];

public static A138259Inst Instance=new A138259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138260
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,1L,2L,13L,4L,20L,2L,12L,11L,4L,11L,16L,13L,3L,4L,11L,20L,67L,2L,4L,12L,19L,11L,43L,4L,60L,13L,20L,16L,13L,13L,9L,3L,12L,4L,10L,11L,6L,20L,13L,67L,66L,11L,7L,4L,16L,12L,79L,19L,20L,11L,3L,43L,78L,4L,51L,60L,13L,17L,12L,20L,75L,16L,67L,13L,52L,13L,24L,9L,4L,6L,31L,12L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138260Inst : IEnumerable<long>
{
public static readonly long[] Value=A138260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138260.Bytes);
public long this[int i]=>Value[i];

public static A138260Inst Instance=new A138260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138261
{
public static readonly long[] Value={ 1L,1L,10L,1L,3L,10L,7L,1L,11L,3L,21L,11L,9L,9L,13L,2L,3L,11L,13L,9L,11L,21L,15L,11L,21L,9L,13L,9L,10L,13L,11L,2L,21L,3L,9L,11L,13L,13L,17L,9L,21L,11L,10L,21L,13L,15L,92L,55L,29L,21L,20L,9L,58L,13L,21L,9L,13L,10L,22L,13L,21L,11L,11L,4L,9L,21L,23L,9L,67L,9L,46L,11L,13L,13L,21L,13L,31L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138261Inst : IEnumerable<long>
{
public static readonly long[] Value=A138261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138261.Bytes);
public long this[int i]=>Value[i];

public static A138261Inst Instance=new A138261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138262
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,11L,5L,2L,1L,2L,10L,11L,19L,13L,11L,11L,7L,11L,28L,2L,13L,10L,6L,11L,11L,19L,3L,13L,15L,11L,61L,13L,11L,8L,13L,11L,19L,28L,19L,2L,4L,13L,60L,10L,11L,12L,24L,11L,5L,11L,41L,19L,79L,82L,10L,13L,28L,15L,233L,11L,10L,61L,13L,17L,19L,11L,12L,8L,12L,13L,36L,11L,13L,19L,11L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138262Inst : IEnumerable<long>
{
public static readonly long[] Value=A138262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138262.Bytes);
public long this[int i]=>Value[i];

public static A138262Inst Instance=new A138262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138263
{
public static readonly long[] Value={ 1L,1L,3L,4L,1L,11L,13L,5L,3L,1L,13L,52L,19L,13L,11L,5L,24L,11L,37L,4L,13L,13L,45L,84L,2L,19L,13L,34L,94L,11L,12L,5L,13L,24L,13L,92L,3L,37L,19L,5L,11L,13L,96L,238L,11L,45L,51L,84L,43L,2L,33L,272L,76L,13L,13L,34L,37L,95L,36L,164L,181L,24L,13L,10L,19L,13L,39L,46L,67L,13L,82L,92L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138263Inst : IEnumerable<long>
{
public static readonly long[] Value=A138263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138263.Bytes);
public long this[int i]=>Value[i];

public static A138263Inst Instance=new A138263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138296
{
public static readonly long[] Value={ 5L,13L,7L,35L,29L,5L,97L,133L,13L,9L,275L,641L,35L,53L,8L,793L,3157L,97L,351L,34L,5L,2315L,15689L,275L,2417L,152L,13L,7L,6817L,78253L,793L,16839L,706L,35L,29L,10L,20195L,390881L,2315L,117713L,3368L,97L,133L,58L,13L,60073L,1953637L,6817L,823671L,16354L,275L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138296Inst : IEnumerable<long>
{
public static readonly long[] Value=A138296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138296.Bytes);
public long this[int i]=>Value[i];

public static A138296Inst Instance=new A138296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138297
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138297Inst : IEnumerable<long>
{
public static readonly long[] Value=A138297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138297.Bytes);
public long this[int i]=>Value[i];

public static A138297Inst Instance=new A138297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138298
{
public static readonly long[] Value={ 0L,2L,10L,21L,110L,233L,1220L,2584L,13530L,28657L,150050L,317811L,1664080L,3524578L,18454930L,39088169L,204668310L,433494437L,2269806340L,4807526976L,25172538050L,53316291173L,279167724890L,591286729879L,3096017511840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138298Inst : IEnumerable<long>
{
public static readonly long[] Value=A138298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138298.Bytes);
public long this[int i]=>Value[i];

public static A138298Inst Instance=new A138298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138299
{
public static readonly long[] Value={ 9L,12L,15L,16L,18L,20L,21L,24L,27L,28L,30L,32L,33L,35L,36L,40L,42L,44L,45L,48L,50L,54L,55L,60L,63L,66L,70L,77L,80L,88L,91L,93L,99L,121L,124L,129L,156L,171L,172L,182L,215L,219L,228L,242L,255L,273L,285L,292L,312L,333L,341L,342L,364L,365L,400L,438L,444L,455L,468L,511L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138299Inst : IEnumerable<long>
{
public static readonly long[] Value=A138299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138299.Bytes);
public long this[int i]=>Value[i];

public static A138299Inst Instance=new A138299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138300
{
public static readonly long[] Value={ 2L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138300Inst : IEnumerable<long>
{
public static readonly long[] Value=A138300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138300.Bytes);
public long this[int i]=>Value[i];

public static A138300Inst Instance=new A138300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138301
{
public static readonly long[] Value={ 1L,2L,4L,11L,37L,145L,673L,3748L,22875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138301Inst : IEnumerable<long>
{
public static readonly long[] Value=A138301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138301.Bytes);
public long this[int i]=>Value[i];

public static A138301Inst Instance=new A138301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138302
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,25L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138302Inst : IEnumerable<long>
{
public static readonly long[] Value=A138302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138302.Bytes);
public long this[int i]=>Value[i];

public static A138302Inst Instance=new A138302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138303
{
public static readonly long[] Value={ 3L,15L,495L,624L,1308L,1365L,1494L,1659L,1848L,6363L,8064L,12780L,13908L,14013L,16530L,18018L,18654L,28575L,30885L,31020L,38130L,43674L,48735L,50379L,57198L,60915L,61059L,62943L,75768L,76359L,76569L,80949L,81075L,83028L,84045L,86085L,88185L,104664L,105588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138303Inst : IEnumerable<long>
{
public static readonly long[] Value=A138303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138303.Bytes);
public long this[int i]=>Value[i];

public static A138303Inst Instance=new A138303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138304
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,4L,3L,5L,4L,4L,5L,6L,4L,9L,6L,8L,6L,7L,9L,8L,8L,11L,12L,11L,12L,7L,12L,9L,16L,11L,11L,17L,9L,18L,6L,11L,17L,23L,18L,20L,13L,20L,16L,19L,13L,12L,15L,24L,20L,28L,24L,17L,23L,28L,32L,29L,15L,24L,23L,13L,31L,20L,32L,23L,28L,15L,21L,32L,22L,28L,42L,27L,29L,21L,43L,40L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138304Inst : IEnumerable<long>
{
public static readonly long[] Value=A138304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138304.Bytes);
public long this[int i]=>Value[i];

public static A138304Inst Instance=new A138304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138305
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,2L,7L,2L,7L,11L,3L,5L,7L,11L,2L,3L,13L,5L,7L,11L,17L,19L,2L,3L,11L,19L,3L,11L,13L,17L,2L,5L,13L,17L,19L,7L,11L,13L,17L,19L,29L,3L,5L,19L,29L,5L,11L,13L,19L,23L,29L,31L,41L,43L,2L,3L,5L,19L,31L,41L,2L,11L,13L,23L,31L,37L,43L,47L,2L,7L,17L,31L,43L,59L,2L,7L,11L,13L,31L,41L,61L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138305Inst : IEnumerable<long>
{
public static readonly long[] Value=A138305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138305.Bytes);
public long this[int i]=>Value[i];

public static A138305Inst Instance=new A138305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138306
{
public static readonly long[] Value={ 0L,0L,0L,5L,7L,7L,0L,0L,11L,13L,17L,13L,0L,17L,23L,19L,23L,0L,0L,23L,23L,31L,43L,29L,37L,41L,37L,37L,41L,41L,43L,0L,47L,61L,41L,43L,67L,47L,47L,67L,59L,53L,73L,47L,47L,61L,53L,59L,67L,0L,59L,61L,59L,67L,97L,89L,97L,79L,71L,61L,79L,71L,73L,67L,71L,71L,97L,83L,71L,137L,113L,0L,103L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138306Inst : IEnumerable<long>
{
public static readonly long[] Value=A138306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138306.Bytes);
public long this[int i]=>Value[i];

public static A138306Inst Instance=new A138306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138307
{
public static readonly long[] Value={ 2L,4L,6L,14L,16L,26L,36L,38L,64L,100L,144L,196L,206L,256L,324L,332L,400L,484L,530L,576L,676L,784L,900L,1024L,1156L,1296L,1444L,1600L,1764L,1936L,2116L,2304L,2500L,2704L,2916L,3136L,3364L,3600L,3844L,4096L,4356L,4624L,4900L,5184L,5476L,5776L,6084L,6400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138307Inst : IEnumerable<long>
{
public static readonly long[] Value=A138307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138307.Bytes);
public long this[int i]=>Value[i];

public static A138307Inst Instance=new A138307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138308
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,11L,13L,17L,18L,19L,20L,23L,26L,27L,28L,29L,30L,31L,32L,35L,36L,37L,39L,41L,43L,45L,46L,47L,48L,49L,50L,53L,54L,55L,56L,59L,61L,67L,68L,71L,72L,73L,77L,79L,80L,83L,85L,87L,88L,89L,90L,91L,92L,95L,97L,99L,100L,101L,102L,103L,107L,109L,111L,113L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138308Inst : IEnumerable<long>
{
public static readonly long[] Value=A138308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138308.Bytes);
public long this[int i]=>Value[i];

public static A138308Inst Instance=new A138308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138309
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,51L,53L,54L,55L,57L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,75L,77L,78L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138309Inst : IEnumerable<long>
{
public static readonly long[] Value=A138309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138309.Bytes);
public long this[int i]=>Value[i];

public static A138309Inst Instance=new A138309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138310
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,7L,6L,11L,13L,9L,8L,17L,10L,15L,14L,19L,12L,23L,16L,21L,20L,25L,18L,29L,27L,31L,22L,33L,24L,37L,26L,39L,28L,35L,32L,41L,30L,43L,34L,47L,36L,53L,38L,45L,49L,51L,40L,55L,57L,59L,44L,61L,42L,65L,46L,67L,50L,63L,48L,71L,52L,69L,73L,77L,54L,79L,56L,75L,58L,81L,60L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138310Inst : IEnumerable<long>
{
public static readonly long[] Value=A138310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138310.Bytes);
public long this[int i]=>Value[i];

public static A138310Inst Instance=new A138310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138311
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,8L,9L,10L,11L,13L,12L,14L,15L,17L,16L,19L,18L,21L,20L,22L,23L,25L,27L,24L,26L,29L,28L,30L,31L,32L,33L,34L,35L,37L,36L,38L,39L,40L,41L,42L,43L,45L,47L,44L,46L,49L,51L,53L,48L,55L,50L,52L,54L,56L,57L,58L,59L,61L,60L,62L,63L,65L,64L,66L,67L,69L,68L,70L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138311Inst : IEnumerable<long>
{
public static readonly long[] Value=A138311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138311.Bytes);
public long this[int i]=>Value[i];

public static A138311Inst Instance=new A138311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138376
{
public static readonly long[] Value={ 0L,1L,3L,0L,4L,1L,7L,0L,8L,1L,2L,0L,3L,1L,6L,0L,7L,1L,10L,0L,2L,1L,5L,0L,6L,1L,9L,0L,10L,1L,4L,0L,5L,1L,8L,0L,9L,1L,12L,0L,4L,1L,7L,0L,8L,1L,11L,0L,12L,1L,6L,0L,7L,1L,10L,0L,11L,1L,14L,0L,6L,1L,9L,0L,10L,1L,13L,0L,14L,1L,8L,0L,9L,1L,12L,0L,13L,1L,16L,0L,8L,1L,11L,0L,12L,1L,15L,0L,16L,1L,10L,0L,11L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138376Inst : IEnumerable<long>
{
public static readonly long[] Value=A138376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138376.Bytes);
public long this[int i]=>Value[i];

public static A138376Inst Instance=new A138376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138377
{
public static readonly long[] Value={ 0L,1L,3L,2L,0L,-4L,-12L,-8L,0L,16L,48L,32L,0L,-64L,-192L,-128L,0L,256L,768L,512L,0L,-1024L,-3072L,-2048L,0L,4096L,12288L,8192L,0L,-16384L,-49152L,-32768L,0L,65536L,196608L,131072L,0L,-262144L,-786432L,-524288L,0L,1048576L,3145728L,2097152L,0L,-4194304L,-12582912L,-8388608L,0L,16777216L,50331648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138377Inst : IEnumerable<long>
{
public static readonly long[] Value=A138377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138377.Bytes);
public long this[int i]=>Value[i];

public static A138377Inst Instance=new A138377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A138378
{
public static readonly long[] Value={ 1L,3L,10L,37L,151L,674L,3263L,17007L,94828L,562595L,3535027L,23430840L,163254885L,1192059223L,9097183602L,72384727657L,599211936355L,5150665398898L,45891416030315L,423145657921379L,4031845922290572L,39645290116637023L,401806863439720943L,4192631462935194064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A138378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A138378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A138378Inst : IEnumerable<long>
{
public static readonly long[] Value=A138378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A138378.Bytes);
public long this[int i]=>Value[i];

public static A138378Inst Instance=new A138378Inst();

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