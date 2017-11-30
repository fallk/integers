using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A210557
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,1L,4L,10L,12L,1L,5L,16L,30L,29L,1L,6L,23L,56L,87L,70L,1L,7L,31L,91L,185L,245L,169L,1L,8L,40L,136L,334L,584L,676L,408L,1L,9L,50L,192L,546L,1158L,1784L,1836L,985L,1L,10L,61L,260L,834L,2052L,3850L,5312L,4925L,2378L,1L,11L,73L,341L,1212L,3366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210557Inst : IEnumerable<long>
{
public static readonly long[] Value=A210557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210557.Bytes);
public long this[int i]=>Value[i];

public static A210557Inst Instance=new A210557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210558
{
public static readonly long[] Value={ 1L,2L,3L,3L,7L,7L,4L,12L,20L,17L,5L,18L,40L,57L,41L,6L,25L,68L,129L,158L,99L,7L,33L,105L,243L,399L,431L,239L,8L,42L,152L,410L,824L,1200L,1160L,577L,9L,52L,210L,642L,1506L,2692L,3528L,3089L,1393L,10L,63L,280L,952L,2532L,5290L,8536L,10185L,8154L,3363L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210558Inst : IEnumerable<long>
{
public static readonly long[] Value=A210558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210558.Bytes);
public long this[int i]=>Value[i];

public static A210558Inst Instance=new A210558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210559
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,1L,6L,8L,5L,1L,8L,15L,17L,8L,1L,10L,24L,38L,33L,13L,1L,12L,35L,70L,86L,63L,21L,1L,14L,48L,115L,180L,187L,117L,34L,1L,16L,63L,175L,330L,437L,390L,214L,55L,1L,18L,80L,252L,553L,882L,1007L,791L,386L,89L,1L,20L,99L,348L,868L,1610L,2219L,2235L,1567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210559Inst : IEnumerable<long>
{
public static readonly long[] Value=A210559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210559.Bytes);
public long this[int i]=>Value[i];

public static A210559Inst Instance=new A210559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210560
{
public static readonly long[] Value={ 1L,3L,1L,5L,4L,2L,7L,9L,9L,3L,9L,16L,23L,16L,5L,11L,25L,46L,48L,30L,8L,13L,36L,80L,110L,101L,54L,13L,15L,49L,127L,215L,257L,203L,97L,21L,17L,64L,189L,378L,552L,570L,401L,172L,34L,19L,81L,268L,616L,1057L,1337L,1228L,776L,303L,55L,21L,100L,366L,948L,1862L,2772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210560Inst : IEnumerable<long>
{
public static readonly long[] Value=A210560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210560.Bytes);
public long this[int i]=>Value[i];

public static A210560Inst Instance=new A210560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210561
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,1L,3L,8L,8L,1L,3L,9L,20L,16L,1L,3L,9L,26L,48L,32L,1L,3L,9L,27L,72L,112L,64L,1L,3L,9L,27L,80L,192L,256L,128L,1L,3L,9L,27L,81L,232L,496L,576L,256L,1L,3L,9L,27L,81L,242L,656L,1248L,1280L,512L,1L,3L,9L,27L,81L,243L,716L,1808L,3072L,2816L,1024L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210561Inst : IEnumerable<long>
{
public static readonly long[] Value=A210561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210561.Bytes);
public long this[int i]=>Value[i];

public static A210561Inst Instance=new A210561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210562
{
public static readonly long[] Value={ 1L,2L,2L,2L,5L,4L,2L,6L,12L,8L,2L,6L,17L,28L,16L,2L,6L,18L,46L,64L,32L,2L,6L,18L,53L,120L,144L,64L,2L,6L,18L,54L,152L,304L,320L,128L,2L,6L,18L,54L,161L,424L,752L,704L,256L,2L,6L,18L,54L,162L,474L,1152L,1824L,1536L,512L,2L,6L,18L,54L,162L,485L,1372L,3056L,4352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210562Inst : IEnumerable<long>
{
public static readonly long[] Value=A210562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210562.Bytes);
public long this[int i]=>Value[i];

public static A210562Inst Instance=new A210562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210563
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,1L,3L,10L,13L,1L,3L,11L,32L,34L,1L,3L,11L,40L,99L,89L,1L,3L,11L,41L,141L,299L,233L,1L,3L,11L,41L,152L,482L,887L,610L,1L,3L,11L,41L,153L,556L,1604L,2595L,1597L,1L,3L,11L,41L,153L,570L,1998L,5217L,7508L,4181L,1L,3L,11L,41L,153L,571L,2113L,7042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210563Inst : IEnumerable<long>
{
public static readonly long[] Value=A210563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210563.Bytes);
public long this[int i]=>Value[i];

public static A210563Inst Instance=new A210563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210564
{
public static readonly long[] Value={ 1L,2L,3L,2L,7L,8L,2L,8L,22L,21L,2L,8L,29L,67L,55L,2L,8L,30L,101L,200L,144L,2L,8L,30L,111L,341L,588L,377L,2L,8L,30L,112L,404L,1122L,1708L,987L,2L,8L,30L,112L,417L,1442L,3613L,4913L,2584L,2L,8L,30L,112L,418L,1543L,5044L,11425L,14018L,6765L,2L,8L,30L,112L,418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210564Inst : IEnumerable<long>
{
public static readonly long[] Value=A210564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210564.Bytes);
public long this[int i]=>Value[i];

public static A210564Inst Instance=new A210564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210565
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,9L,10L,5L,5L,14L,22L,20L,8L,6L,20L,40L,51L,38L,13L,7L,27L,65L,105L,111L,71L,21L,8L,35L,98L,190L,256L,233L,130L,34L,9L,44L,140L,315L,511L,594L,474L,235L,55L,10L,54L,192L,490L,924L,1295L,1324L,942L,420L,89L,11L,65L,255L,726L,1554L,2534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210565Inst : IEnumerable<long>
{
public static readonly long[] Value=A210565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210565.Bytes);
public long this[int i]=>Value[i];

public static A210565Inst Instance=new A210565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210566
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,37L,53L,101L,103L,131L,149L,151L,167L,181L,229L,257L,263L,277L,293L,311L,359L,373L,389L,421L,439L,487L,503L,599L,613L,631L,641L,643L,647L,661L,677L,727L,743L,757L,769L,773L,821L,823L,853L,887L,919L,983L,997L,1013L,1031L,1061L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210566Inst : IEnumerable<long>
{
public static readonly long[] Value=A210566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210566.Bytes);
public long this[int i]=>Value[i];

public static A210566Inst Instance=new A210566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210567
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9158L,28178L,76539L,240370L,665129L,2123439L,5964691L,19302316L,54898416L,179696557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210567Inst : IEnumerable<long>
{
public static readonly long[] Value=A210567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210567.Bytes);
public long this[int i]=>Value[i];

public static A210567Inst Instance=new A210567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210568
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,4L,4L,5L,5L,5L,5L,5L,4L,4L,4L,6L,6L,6L,6L,6L,6L,5L,5L,5L,6L,6L,6L,6L,6L,6L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210568Inst : IEnumerable<long>
{
public static readonly long[] Value=A210568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210568.Bytes);
public long this[int i]=>Value[i];

public static A210568Inst Instance=new A210568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210569
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,24L,84L,224L,504L,1008L,1848L,3168L,5148L,8008L,12012L,17472L,24752L,34272L,46512L,62016L,81396L,105336L,134596L,170016L,212520L,263120L,322920L,393120L,475020L,570024L,679644L,805504L,949344L,1113024L,1298528L,1507968L,1743588L,2007768L,2303028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210569Inst : IEnumerable<long>
{
public static readonly long[] Value=A210569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210569.Bytes);
public long this[int i]=>Value[i];

public static A210569Inst Instance=new A210569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210570
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,13L,16L,18L,21L,23L,35L,38L,43L,48L,53L,58L,66L,68L,71L,73L,81L,86L,92L,97L,102L,107L,112L,118L,120L,125L,131L,133L,138L,144L,146L,151L,157L,159L,164L,189L,199L,203L,206L,208L,219L,223L,236L,242L,248L,253L,258L,263L,266L,269L,283L,285L,288L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210570Inst : IEnumerable<long>
{
public static readonly long[] Value=A210570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210570.Bytes);
public long this[int i]=>Value[i];

public static A210570Inst Instance=new A210570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210571
{
public static readonly long[] Value={ 6L,8L,10L,20L,26L,48L,42L,64L,66L,144L,178L,452L,428L,576L,514L,1072L,1442L,2864L,2534L,4608L,6402L,12448L,9350L,16648L,16522L,32768L,36866L,82496L,77186L,132352L,148170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210571Inst : IEnumerable<long>
{
public static readonly long[] Value=A210571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210571.Bytes);
public long this[int i]=>Value[i];

public static A210571Inst Instance=new A210571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210572
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,2L,0L,1L,3L,0L,0L,0L,1L,4L,2L,0L,0L,1L,5L,5L,0L,0L,0L,0L,1L,9L,6L,2L,0L,0L,0L,1L,7L,14L,7L,0L,0L,0L,0L,0L,1L,16L,20L,8L,2L,0L,0L,0L,0L,1L,9L,30L,27L,9L,0L,0L,0L,0L,0L,0L,1L,25L,50L,35L,10L,2L,0L,0L,0L,0L,0L,1L,11L,55L,77L,44L,11L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210572Inst : IEnumerable<long>
{
public static readonly long[] Value=A210572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210572.Bytes);
public long this[int i]=>Value[i];

public static A210572Inst Instance=new A210572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210573
{
public static readonly BigInteger[] Value={ 1L,1L,4L,16L,112L,736L,6736L,62224L,709696L,8345152L,113821696L,1616855296L,25666630144L,425795339776L,7709938772992L,145932375110656L,2967668449939456L,63007297970212864L,1421410453435334656L,BigInteger.Parse("33414017254605586432"),BigInteger.Parse("827901013304217174016"),BigInteger.Parse("21329003914034382831616"),BigInteger.Parse("575635583592563020201984") };
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
public class A210573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210573Inst Instance=new A210573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210574
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,12L,1L,1L,15L,50L,264L,1L,1L,31L,180L,1920L,11970L,1L,1L,63L,602L,11760L,146160L,1689600L,1L,1L,127L,1932L,66024L,1477980L,34214400L,603233280L,1L,1L,255L,6050L,353304L,13556970L,568656000L,20043279360L,586244602944L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210574Inst : IEnumerable<long>
{
public static readonly long[] Value=A210574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210574.Bytes);
public long this[int i]=>Value[i];

public static A210574Inst Instance=new A210574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210575
{
public static readonly BigInteger[] Value={ 1L,2L,5L,21L,331L,14103L,1848187L,638993745L,606870454885L,1521631967792571L,10133757998339247871UL,BigInteger.Parse("177538293441952184724981"),BigInteger.Parse("8181221174058066834888078985"),BigInteger.Parse("989142108001368363428245746236127"),BigInteger.Parse("313604410227075233969169122734730463619") };
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
public class A210575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210575Inst Instance=new A210575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210576
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,14L,17L,19L,23L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210576Inst : IEnumerable<long>
{
public static readonly long[] Value=A210576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210576.Bytes);
public long this[int i]=>Value[i];

public static A210576Inst Instance=new A210576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210577
{
public static readonly long[] Value={ 12L,16L,20L,21L,25L,26L,27L,30L,31L,34L,35L,36L,38L,40L,41L,42L,43L,45L,46L,48L,49L,50L,51L,55L,56L,57L,60L,61L,62L,63L,64L,65L,66L,70L,71L,72L,73L,75L,76L,77L,80L,81L,83L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,97L,98L,99L,100L,101L,102L,104L,105L,106L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210577Inst : IEnumerable<long>
{
public static readonly long[] Value=A210577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210577.Bytes);
public long this[int i]=>Value[i];

public static A210577Inst Instance=new A210577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210578
{
public static readonly long[] Value={ 6L,10L,12L,15L,16L,20L,21L,25L,26L,27L,28L,30L,31L,34L,35L,36L,38L,40L,41L,42L,43L,45L,46L,48L,49L,50L,51L,55L,56L,57L,60L,61L,62L,63L,64L,65L,66L,70L,71L,72L,73L,75L,76L,77L,78L,80L,81L,83L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210578Inst : IEnumerable<long>
{
public static readonly long[] Value=A210578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210578.Bytes);
public long this[int i]=>Value[i];

public static A210578Inst Instance=new A210578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210579
{
public static readonly long[] Value={ 2L,4L,16L,16L,96L,96L,576L,5184L,31104L,279936L,1679616L,8398080L,58786560L,352719360L,1763596800L,1763596800L,14108774400L,56435097600L,169305292800L,169305292800L,169305292800L,1693052928000L,6772211712000L,13544423424000L,94810963968000L,853298675712000L,7679688081408000L,23039064244224000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210579Inst : IEnumerable<long>
{
public static readonly long[] Value=A210579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210579.Bytes);
public long this[int i]=>Value[i];

public static A210579Inst Instance=new A210579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210580
{
public static readonly long[] Value={ 2L,2L,1L,2L,1L,0L,2L,1L,2L,2L,1L,0L,1L,2L,1L,2L,0L,2L,1L,2L,2L,2L,1L,0L,1L,1L,2L,1L,2L,0L,0L,2L,1L,2L,0L,2L,2L,1L,2L,2L,1L,2L,1L,0L,1L,1L,0L,2L,1L,0L,1L,1L,2L,2L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,0L,2L,1L,2L,0L,2L,2L,2L,1L,2L,2L,1L,1L,2L,1L,0L,1L,1L,0L,0L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210580Inst : IEnumerable<long>
{
public static readonly long[] Value=A210580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210580.Bytes);
public long this[int i]=>Value[i];

public static A210580Inst Instance=new A210580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210581
{
public static readonly long[] Value={ 1L,2L,7L,23L,68L,200L,615L,1764L,5060L,14626L,41785L,117573L,332475L,933891L,2609832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210581Inst : IEnumerable<long>
{
public static readonly long[] Value=A210581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210581.Bytes);
public long this[int i]=>Value[i];

public static A210581Inst Instance=new A210581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210582
{
public static readonly long[] Value={ 13L,19L,23L,26L,29L,39L,46L,49L,59L,69L,79L,89L,103L,109L,127L,133L,163L,193L,197L,199L,203L,206L,209L,214L,218L,233L,234L,236L,247L,254L,258L,263L,266L,274L,293L,294L,296L,298L,299L,309L,367L,399L,406L,409L,417L,428L,436L,466L,468L,487L,496L,499L,509L,537L,599L,609L,638L,657L,678L,699L,709L,799L,809L,899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210582Inst : IEnumerable<long>
{
public static readonly long[] Value=A210582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210582.Bytes);
public long this[int i]=>Value[i];

public static A210582Inst Instance=new A210582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210583
{
public static readonly long[] Value={ 1L,4L,1L,3L,7L,1L,6L,6L,9L,4L,1L,1L,5L,4L,0L,6L,9L,5L,7L,3L,0L,8L,1L,8L,9L,5L,2L,2L,4L,7L,5L,7L,7L,6L,2L,9L,7L,8L,8L,8L,7L,2L,6L,2L,2L,9L,7L,1L,8L,7L,9L,7L,6L,1L,9L,4L,3L,8L,7L,2L,5L,0L,6L,6L,5L,3L,8L,5L,1L,7L,3L,8L,2L,8L,2L,8L,7L,9L,4L,0L,4L,9L,3L,8L,2L,6L,1L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210583Inst : IEnumerable<long>
{
public static readonly long[] Value=A210583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210583.Bytes);
public long this[int i]=>Value[i];

public static A210583Inst Instance=new A210583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210584
{
public static readonly long[] Value={ 1L,2L,3L,4L,12L,13L,14L,23L,24L,34L,112L,113L,114L,122L,123L,124L,132L,133L,134L,142L,143L,144L,223L,224L,233L,234L,243L,244L,334L,344L,1112L,1113L,1114L,1122L,1123L,1124L,1132L,1133L,1134L,1142L,1143L,1144L,1213L,1214L,1222L,1223L,1224L,1232L,1233L,1234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210584Inst : IEnumerable<long>
{
public static readonly long[] Value=A210584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210584.Bytes);
public long this[int i]=>Value[i];

public static A210584Inst Instance=new A210584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210585
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,12L,13L,14L,15L,16L,17L,18L,23L,24L,25L,26L,27L,28L,34L,35L,36L,37L,38L,45L,46L,47L,48L,56L,57L,58L,67L,68L,78L,112L,113L,114L,115L,116L,117L,118L,122L,123L,124L,125L,126L,127L,128L,132L,133L,134L,135L,136L,137L,138L,142L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210585Inst : IEnumerable<long>
{
public static readonly long[] Value=A210585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210585.Bytes);
public long this[int i]=>Value[i];

public static A210585Inst Instance=new A210585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210586
{
public static readonly long[] Value={ 2L,3L,9L,4L,48L,64L,5L,175L,750L,625L,6L,540L,5400L,12960L,7776L,7L,1519L,30870L,156065L,252105L,117649L,8L,4032L,154112L,1433600L,4587520L,5505024L,2097152L,9L,10287L,704214L,11160261L,62001450L,141363306L,133923132L,43046721L,10L,25500L,3025000L,77700000L,695100000L,2646000000L,4620000000L,3600000000L,1000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210586Inst : IEnumerable<long>
{
public static readonly long[] Value=A210586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210586.Bytes);
public long this[int i]=>Value[i];

public static A210586Inst Instance=new A210586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210587
{
public static readonly long[] Value={ 1L,1L,3L,1L,12L,16L,1L,35L,150L,125L,1L,90L,900L,2160L,1296L,1L,217L,4410L,22295L,36015L,16807L,1L,504L,19264L,179200L,573440L,688128L,262144L,1L,1143L,78246L,1240029L,6889050L,15707034L,14880348L,4782969L,1L,2550L,302500L,7770000L,69510000L,264600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210587Inst : IEnumerable<long>
{
public static readonly long[] Value=A210587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210587.Bytes);
public long this[int i]=>Value[i];

public static A210587Inst Instance=new A210587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210588
{
public static readonly long[] Value={ 6597606223981L,3474749660383L,5792018372251L,307768373641L,3477707481751L,1362242655901L,3461715915661L,4341937413061L,5537838510751L,10710604680091L,2273312197621L,602248359169L,10087771603687L,3343433905957L,2366338900801L,8006855187361L,457453568161L,11377272352951L,118670087467L,354864744877L,2152302898747L,528929554561L,546348519181L,315962312077L,3215031751L,4777422165601L,1871186716981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210588Inst : IEnumerable<long>
{
public static readonly long[] Value=A210588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210588.Bytes);
public long this[int i]=>Value[i];

public static A210588Inst Instance=new A210588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210589
{
public static readonly long[] Value={ 10L,20L,21L,30L,31L,32L,40L,41L,42L,43L,50L,51L,52L,53L,54L,60L,61L,62L,63L,64L,65L,70L,71L,72L,73L,74L,75L,76L,80L,81L,82L,83L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L,96L,97L,98L,100L,110L,120L,130L,140L,150L,160L,170L,180L,190L,200L,201L,210L,211L,220L,221L,230L,231L,240L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210589Inst : IEnumerable<long>
{
public static readonly long[] Value=A210589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210589.Bytes);
public long this[int i]=>Value[i];

public static A210589Inst Instance=new A210589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210590
{
public static readonly long[] Value={ 1L,1L,1L,4L,5L,1L,18L,29L,12L,1L,120L,218L,119L,22L,1L,840L,1814L,1285L,345L,35L,1L,7920L,18144L,14674L,5205L,805L,51L,1L,75600L,196356L,185080L,79219L,16450L,1624L,70L,1L,887040L,2427312L,2515036L,1258628L,324569L,43568L,2954L,92L,1L,10886400L,32304240L,37012572L,21034376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210590Inst : IEnumerable<long>
{
public static readonly long[] Value=A210590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210590.Bytes);
public long this[int i]=>Value[i];

public static A210590Inst Instance=new A210590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210591
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,116L,636L,3823L,24729L,170187L,1236536L,9431875L,75202833L,624669675L,5390981898L,48229922730L,446459295023L,4269397134669L,42117578374712L,428090022559608L,4478159536973989L,48163581285504612L,532096844251876645L,6033134642314812383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210591Inst : IEnumerable<long>
{
public static readonly long[] Value=A210591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210591.Bytes);
public long this[int i]=>Value[i];

public static A210591Inst Instance=new A210591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210592
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9158L,28178L,76539L,240370L,665129L,2123439L,5964691L,19302316L,54898417L,179696558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210592Inst : IEnumerable<long>
{
public static readonly long[] Value=A210592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210592.Bytes);
public long this[int i]=>Value[i];

public static A210592Inst Instance=new A210592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210593
{
public static readonly long[] Value={ 1L,0L,1L,3L,1L,6L,5L,7L,8L,1L,6L,3L,5L,0L,4L,5L,0L,1L,8L,8L,6L,0L,0L,2L,8L,8L,2L,2L,1L,2L,2L,4L,2L,1L,8L,3L,6L,5L,9L,3L,8L,4L,7L,7L,6L,3L,7L,4L,9L,1L,1L,1L,6L,3L,3L,3L,4L,2L,9L,4L,2L,4L,7L,1L,9L,6L,2L,0L,4L,5L,3L,0L,9L,2L,0L,5L,4L,3L,6L,3L,2L,4L,9L,5L,3L,1L,7L,8L,0L,1L,2L,5L,3L,1L,9L,0L,3L,5L,6L,3L,9L,8L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210593Inst : IEnumerable<long>
{
public static readonly long[] Value=A210593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210593.Bytes);
public long this[int i]=>Value[i];

public static A210593Inst Instance=new A210593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210594
{
public static readonly long[] Value={ 2L,6L,12L,24L,36L,48L,60L,120L,180L,240L,360L,720L,840L,1260L,1680L,2520L,5040L,7560L,10080L,15120L,20160L,25200L,27720L,50400L,55440L,83160L,110880L,166320L,221760L,277200L,332640L,498960L,554400L,665280L,720720L,1081080L,1441440L,2162160L,2882880L,3603600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210594Inst : IEnumerable<long>
{
public static readonly long[] Value=A210594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210594.Bytes);
public long this[int i]=>Value[i];

public static A210594Inst Instance=new A210594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210595
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,4L,6L,7L,3L,5L,10L,16L,13L,5L,6L,15L,30L,35L,25L,8L,7L,21L,50L,75L,76L,46L,13L,8L,28L,77L,140L,181L,157L,84L,21L,9L,36L,112L,238L,371L,413L,317L,151L,34L,10L,45L,156L,378L,686L,924L,911L,625L,269L,55L,11L,55L,210L,570L,1176L,1848L,2206L,1949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210595Inst : IEnumerable<long>
{
public static readonly long[] Value=A210595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210595.Bytes);
public long this[int i]=>Value[i];

public static A210595Inst Instance=new A210595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210596
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,4L,3L,6L,4L,8L,5L,10L,16L,8L,16L,8L,20L,28L,40L,16L,32L,13L,36L,64L,72L,96L,32L,64L,21L,66L,124L,184L,176L,224L,64L,128L,34L,118L,248L,376L,496L,416L,512L,128L,256L,55L,210L,476L,808L,1056L,1280L,960L,1152L,256L,512L,89L,370L,908L,1640L,2416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210596Inst : IEnumerable<long>
{
public static readonly long[] Value=A210596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210596.Bytes);
public long this[int i]=>Value[i];

public static A210596Inst Instance=new A210596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210597
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,4L,7L,13L,12L,8L,12L,28L,37L,28L,16L,20L,58L,92L,98L,64L,32L,33L,114L,217L,273L,248L,144L,64L,54L,218L,479L,713L,760L,608L,320L,128L,88L,407L,1018L,1727L,2161L,2024L,1456L,704L,256L,143L,747L,2093L,3997L,5662L,6194L,5216L,3424L,1536L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210597Inst : IEnumerable<long>
{
public static readonly long[] Value=A210597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210597.Bytes);
public long this[int i]=>Value[i];

public static A210597Inst Instance=new A210597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210598
{
public static readonly long[] Value={ 1L,2L,2L,3L,7L,5L,4L,14L,23L,13L,5L,24L,58L,72L,34L,6L,36L,119L,219L,219L,89L,7L,51L,209L,521L,777L,653L,233L,8L,68L,338L,1048L,2101L,2639L,1918L,610L,9L,88L,508L,1902L,4754L,7989L,8679L,5567L,1597L,10L,110L,730L,3180L,9565L,20055L,29062L,27844L,16003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210598Inst : IEnumerable<long>
{
public static readonly long[] Value=A210598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210598.Bytes);
public long this[int i]=>Value[i];

public static A210598Inst Instance=new A210598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210599
{
public static readonly long[] Value={ 1L,2L,3L,3L,8L,8L,4L,16L,28L,21L,5L,26L,69L,92L,55L,6L,39L,134L,268L,290L,144L,7L,54L,233L,606L,974L,888L,377L,8L,72L,368L,1196L,2510L,3378L,2662L,987L,9L,92L,550L,2122L,5541L,9760L,11313L,7852L,2584L,10L,115L,780L,3510L,10900L,23825L,36188L,36872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210599Inst : IEnumerable<long>
{
public static readonly long[] Value=A210599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210599.Bytes);
public long this[int i]=>Value[i];

public static A210599Inst Instance=new A210599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210600
{
public static readonly long[] Value={ 1L,2L,2L,4L,7L,4L,7L,19L,20L,8L,12L,44L,69L,52L,16L,20L,94L,196L,218L,128L,32L,33L,190L,497L,731L,632L,304L,64L,54L,370L,1167L,2139L,2440L,1728L,704L,128L,88L,701L,2594L,5701L,8081L,7544L,4528L,1600L,256L,143L,1301L,5533L,14195L,24062L,27874L,22048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210600Inst : IEnumerable<long>
{
public static readonly long[] Value=A210600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210600.Bytes);
public long this[int i]=>Value[i];

public static A210600Inst Instance=new A210600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210601
{
public static readonly long[] Value={ 1L,3L,2L,6L,9L,4L,11L,26L,24L,8L,19L,63L,89L,60L,16L,32L,138L,265L,270L,144L,32L,53L,284L,693L,949L,760L,336L,64L,87L,560L,1664L,2870L,3072L,2032L,768L,128L,142L,1071L,3761L,7840L,10521L,9272L,5232L,1728L,256L,231L,2002L,8127L,19896L,32143L,35418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210601Inst : IEnumerable<long>
{
public static readonly long[] Value=A210601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210601.Bytes);
public long this[int i]=>Value[i];

public static A210601Inst Instance=new A210601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210602
{
public static readonly long[] Value={ 1L,3L,1L,6L,5L,2L,11L,14L,11L,4L,19L,34L,36L,24L,8L,32L,74L,101L,89L,52L,16L,53L,152L,251L,279L,214L,112L,32L,87L,299L,582L,769L,735L,504L,240L,64L,142L,571L,1279L,1961L,2208L,1872L,1168L,512L,128L,231L,1066L,2704L,4706L,6096L,6057L,4648L,2672L,1088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210602Inst : IEnumerable<long>
{
public static readonly long[] Value=A210602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210602.Bytes);
public long this[int i]=>Value[i];

public static A210602Inst Instance=new A210602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210603
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,4L,7L,17L,16L,8L,12L,39L,57L,40L,16L,20L,84L,159L,169L,96L,32L,33L,170L,405L,551L,465L,224L,64L,54L,332L,950L,1608L,1727L,1217L,512L,128L,88L,630L,2115L,4264L,5655L,5055L,3073L,1152L,256L,143L,1171L,4515L,10603L,16666L,18294L,14079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210603Inst : IEnumerable<long>
{
public static readonly long[] Value=A210603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210603.Bytes);
public long this[int i]=>Value[i];

public static A210603Inst Instance=new A210603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210604
{
public static readonly long[] Value={ 0L,3L,2L,13L,12L,11L,10L,9L,8L,43L,42L,41L,42L,43L,44L,45L,46L,113L,114L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,157L,156L,155L,154L,153L,152L,153L,154L,155L,156L,157L,158L,159L,160L,161L,162L,163L,164L,367L,368L,369L,370L,151L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210604Inst : IEnumerable<long>
{
public static readonly long[] Value=A210604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210604.Bytes);
public long this[int i]=>Value[i];

public static A210604Inst Instance=new A210604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210605
{
public static readonly long[] Value={ 1L,6L,7L,20L,21L,22L,23L,24L,25L,62L,63L,18L,17L,16L,15L,14L,79L,78L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,224L,225L,226L,227L,228L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,265L,264L,263L,262L,261L,40L,265L,494L,495L,258L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210605Inst : IEnumerable<long>
{
public static readonly long[] Value=A210605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210605.Bytes);
public long this[int i]=>Value[i];

public static A210605Inst Instance=new A210605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210606
{
public static readonly long[] Value={ 1L,3L,5L,3L,4L,4L,5L,11L,13L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210606Inst : IEnumerable<long>
{
public static readonly long[] Value=A210606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210606.Bytes);
public long this[int i]=>Value[i];

public static A210606Inst Instance=new A210606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210607
{
public static readonly long[] Value={ 0L,1L,4L,9L,12L,16L,20L,25L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210607Inst : IEnumerable<long>
{
public static readonly long[] Value=A210607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210607.Bytes);
public long this[int i]=>Value[i];

public static A210607Inst Instance=new A210607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210608
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,6L,6L,7L,7L,8L,14L,22L,28L,36L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210608Inst : IEnumerable<long>
{
public static readonly long[] Value=A210608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210608.Bytes);
public long this[int i]=>Value[i];

public static A210608Inst Instance=new A210608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210609
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,6L,6L,7L,7L,8L,14L,21L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210609Inst : IEnumerable<long>
{
public static readonly long[] Value=A210609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210609.Bytes);
public long this[int i]=>Value[i];

public static A210609Inst Instance=new A210609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210610
{
public static readonly long[] Value={ 3L,11L,4L,10L,4L,28L,10L,24L,8L,2L,4L,9L,4L,2L,36L,12L,4L,2L,3L,28L,10L,52L,18L,32L,12L,15L,38L,14L,32L,12L,44L,16L,148L,50L,7L,22L,8L,3L,4L,2L,70L,24L,114L,42L,200L,68L,6L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210610Inst : IEnumerable<long>
{
public static readonly long[] Value=A210610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210610.Bytes);
public long this[int i]=>Value[i];

public static A210610Inst Instance=new A210610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210611
{
public static readonly long[] Value={ 1L,3L,11L,28L,36L,52L,148L,200L,286L,736L,1050L,1442L,1624L,1666L,1854L,2422L,5256L,6374L,12028L,14702L,26290L,31892L,41578L,43626L,47948L,104540L,138640L,177862L,217282L,327804L,564396L,832032L,961848L,994408L,1192870L,1549322L,1689140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210611Inst : IEnumerable<long>
{
public static readonly long[] Value=A210611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210611.Bytes);
public long this[int i]=>Value[i];

public static A210611Inst Instance=new A210611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210612
{
public static readonly long[] Value={ 0L,1L,3L,2L,2L,7L,13L,12L,12L,11L,11L,10L,10L,9L,9L,8L,8L,25L,43L,42L,42L,41L,40L,40L,39L,39L,38L,37L,36L,35L,34L,33L,48L,81L,80L,80L,79L,78L,78L,77L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,95L,161L,160L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210612Inst : IEnumerable<long>
{
public static readonly long[] Value=A210612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210612.Bytes);
public long this[int i]=>Value[i];

public static A210612Inst Instance=new A210612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210613
{
public static readonly long[] Value={ 0L,1L,3L,7L,13L,25L,43L,48L,81L,95L,161L,173L,274L,276L,390L,474L,661L,841L,896L,978L,994L,1446L,1524L,1762L,1787L,1793L,1828L,2673L,2869L,3212L,4488L,4553L,5116L,5396L,5400L,7465L,7474L,8218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210613Inst : IEnumerable<long>
{
public static readonly long[] Value=A210613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210613.Bytes);
public long this[int i]=>Value[i];

public static A210613Inst Instance=new A210613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210614
{
public static readonly long[] Value={ 69L,78L,87L,96L,98L,169L,178L,187L,196L,619L,696L,718L,787L,817L,872L,873L,878L,916L,961L,962L,969L,1169L,1178L,1691L,1781L,2987L,6911L,6916L,6961L,6962L,6969L,7817L,7872L,7873L,7878L,8117L,8787L,9116L,9696L,9878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210614Inst : IEnumerable<long>
{
public static readonly long[] Value=A210614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210614.Bytes);
public long this[int i]=>Value[i];

public static A210614Inst Instance=new A210614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210615
{
public static readonly long[] Value={ 0L,0L,0L,4L,0L,6L,0L,4L,9L,10L,0L,4L,0L,14L,15L,4L,0L,6L,0L,4L,21L,22L,0L,4L,25L,26L,9L,4L,0L,6L,0L,4L,33L,34L,35L,4L,0L,38L,39L,4L,0L,6L,0L,4L,9L,46L,0L,4L,49L,10L,51L,4L,0L,6L,55L,4L,57L,58L,0L,4L,0L,62L,9L,4L,65L,6L,0L,4L,69L,10L,0L,4L,0L,74L,15L,4L,77L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210615Inst : IEnumerable<long>
{
public static readonly long[] Value=A210615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210615.Bytes);
public long this[int i]=>Value[i];

public static A210615Inst Instance=new A210615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210616
{
public static readonly long[] Value={ 4L,6L,9L,1L,41L,51L,12L,22L,52L,62L,33L,43L,53L,83L,93L,64L,94L,15L,55L,75L,85L,26L,56L,96L,47L,77L,28L,58L,68L,78L,19L,39L,49L,59L,601L,111L,511L,811L,911L,121L,221L,321L,921L,331L,431L,141L,241L,341L,541L,641L,551L,851L,951L,161L,661L,961L,771L,871L,381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210616Inst : IEnumerable<long>
{
public static readonly long[] Value=A210616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210616.Bytes);
public long this[int i]=>Value[i];

public static A210616Inst Instance=new A210616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210617
{
public static readonly long[] Value={ 4L,7L,9L,0L,8L,8L,2L,5L,7L,2L,7L,6L,5L,5L,2L,3L,4L,2L,6L,9L,1L,0L,6L,9L,6L,0L,2L,9L,5L,0L,5L,4L,7L,5L,7L,3L,3L,4L,3L,6L,6L,5L,5L,0L,1L,6L,2L,6L,7L,1L,1L,4L,6L,1L,8L,1L,0L,6L,2L,3L,3L,9L,8L,7L,6L,1L,6L,8L,9L,6L,5L,0L,0L,2L,8L,7L,8L,8L,0L,4L,2L,8L,3L,2L,8L,7L,1L,4L,9L,1L,6L,0L,4L,0L,6L,0L,9L,6L,1L,5L,2L,8L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210617Inst : IEnumerable<long>
{
public static readonly long[] Value=A210617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210617.Bytes);
public long this[int i]=>Value[i];

public static A210617Inst Instance=new A210617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210618
{
public static readonly BigInteger[] Value={ 45360L,43243200L,735134400L,2205403200L,73329656400L,97772875200L,146659312800L,293318625600L,13492656777600L,26985313555200L,391287046550400L,782574093100800L,4488062423933088000L,8976124847866176000L,BigInteger.Parse("184010559381256608000"),BigInteger.Parse("368021118762513216000") };
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
public class A210618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210618Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210618.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210618Inst Instance=new A210618Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210619
{
public static readonly long[] Value={ 2L,6L,7L,17L,19L,20L,46L,51L,53L,54L,122L,135L,140L,142L,143L,321L,355L,368L,373L,375L,376L,842L,931L,965L,978L,983L,985L,986L,2206L,2439L,2528L,2562L,2575L,2580L,2582L,2583L,5777L,6387L,6620L,6709L,6743L,6756L,6761L,6763L,6764L,15126L,16723L,17333L,17566L,17655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210619Inst : IEnumerable<long>
{
public static readonly long[] Value=A210619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210619.Bytes);
public long this[int i]=>Value[i];

public static A210619Inst Instance=new A210619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210620
{
public static readonly BigInteger[] Value={ 7L,37L,937L,5937L,35937L,335937L,9335937L,19335937L,319335937L,7319335937L,77319335937L,877319335937L,9877319335937L,89877319335937L,389877319335937L,4389877319335937L,84389877319335937L,384389877319335937L,8384389877319335937L,BigInteger.Parse("88384389877319335937") };
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
public class A210620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210620.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210620Inst Instance=new A210620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210621
{
public static readonly long[] Value={ 3L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L,7L,1L,6L,0L,4L,9L,3L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210621Inst : IEnumerable<long>
{
public static readonly long[] Value=A210621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210621.Bytes);
public long this[int i]=>Value[i];

public static A210621Inst Instance=new A210621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210622
{
public static readonly long[] Value={ 3L,1L,4L,1L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210622Inst : IEnumerable<long>
{
public static readonly long[] Value=A210622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210622.Bytes);
public long this[int i]=>Value[i];

public static A210622Inst Instance=new A210622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210623
{
public static readonly long[] Value={ 5L,7L,7L,3L,5L,0L,2L,6L,7L,7L,4L,6L,2L,5L,0L,0L,8L,6L,1L,2L,2L,4L,2L,5L,5L,6L,4L,0L,0L,2L,5L,0L,0L,8L,9L,8L,7L,4L,1L,6L,0L,8L,1L,0L,1L,9L,5L,9L,7L,5L,7L,1L,6L,4L,5L,8L,1L,8L,7L,1L,0L,6L,4L,6L,3L,4L,0L,5L,1L,1L,6L,7L,1L,0L,4L,7L,2L,2L,3L,0L,2L,8L,1L,5L,9L,2L,1L,9L,3L,8L,1L,3L,9L,6L,1L,7L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210623Inst : IEnumerable<long>
{
public static readonly long[] Value=A210623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210623.Bytes);
public long this[int i]=>Value[i];

public static A210623Inst Instance=new A210623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210624
{
public static readonly long[] Value={ 5L,7L,7L,2L,1L,5L,2L,0L,9L,5L,0L,1L,1L,4L,3L,4L,6L,4L,0L,1L,2L,4L,2L,7L,9L,1L,9L,4L,6L,1L,6L,1L,8L,4L,8L,4L,5L,4L,2L,8L,5L,3L,9L,5L,3L,3L,9L,1L,2L,1L,5L,9L,7L,4L,0L,3L,8L,5L,8L,4L,5L,4L,4L,5L,6L,0L,7L,6L,6L,0L,3L,9L,7L,1L,4L,7L,3L,0L,9L,9L,8L,1L,2L,5L,0L,2L,2L,9L,3L,7L,6L,7L,3L,7L,4L,1L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210624Inst : IEnumerable<long>
{
public static readonly long[] Value=A210624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210624.Bytes);
public long this[int i]=>Value[i];

public static A210624Inst Instance=new A210624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210625
{
public static readonly long[] Value={ 0L,0L,0L,4L,0L,6L,0L,4L,9L,0L,0L,21L,0L,0L,51L,0L,0L,9L,91L,0L,4L,22L,4L,6L,4L,62L,4L,82L,4L,0L,0L,0L,33L,0L,0L,9L,0L,0L,93L,4L,14L,4L,34L,4L,6L,4L,74L,4L,94L,0L,15L,25L,35L,9L,55L,65L,15L,85L,95L,6L,4L,26L,4L,46L,4L,6L,4L,86L,4L,0L,0L,9L,0L,0L,57L,0L,77L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210625Inst : IEnumerable<long>
{
public static readonly long[] Value=A210625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210625.Bytes);
public long this[int i]=>Value[i];

public static A210625Inst Instance=new A210625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210626
{
public static readonly long[] Value={ 3449L,3169L,2897L,2633L,2377L,2129L,1889L,1657L,1433L,1217L,1009L,809L,617L,433L,257L,89L,-71L,-223L,-367L,-503L,-631L,-751L,-863L,-967L,-1063L,-1151L,-1231L,-1303L,-1367L,-1423L,-1471L,-1511L,-1543L,-1567L,-1583L,-1591L,-1591L,-1583L,-1567L,-1543L,-1511L,-1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210626Inst : IEnumerable<long>
{
public static readonly long[] Value=A210626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210626.Bytes);
public long this[int i]=>Value[i];

public static A210626Inst Instance=new A210626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210627
{
public static readonly BigInteger[] Value={ 72L,896L,14400L,283392L,6598144L,177373184L,5406289920L,184223744000L,6939874934784L,286375842938880L,12846564299505664L,622448445155704832L,BigInteger.Parse("32395710363284275200"),BigInteger.Parse("1802446793652649852928"),BigInteger.Parse("106760825994912064339968"),BigInteger.Parse("6707088257932303257305088"),BigInteger.Parse("445456559121345605093294080"),BigInteger.Parse("31185504805980142781333504000") };
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
public class A210627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210627Inst Instance=new A210627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210628
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,0L,-2L,0L,-5L,0L,-14L,0L,-42L,0L,-132L,0L,-429L,0L,-1430L,0L,-4862L,0L,-16796L,0L,-58786L,0L,-208012L,0L,-742900L,0L,-2674440L,0L,-9694845L,0L,-35357670L,0L,-129644790L,0L,-477638700L,0L,-1767263190L,0L,-6564120420L,0L,-24466267020L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210628Inst : IEnumerable<long>
{
public static readonly long[] Value=A210628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210628.Bytes);
public long this[int i]=>Value[i];

public static A210628Inst Instance=new A210628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210629
{
public static readonly long[] Value={ 1442173L,2288509L,2660183L,2805773L,3830891L,4137473L,4951073L,5216137L,5517173L,5521819L,5521891L,5914591L,6474119L,6518173L,7118519L,7570273L,8508473L,8584273L,8689573L,8912591L,9383053L,9958519L,10116373L,10204391L,11418193L,11878873L,11890873L,12948773L,13738163L,13873073L,14377157L,14436391L,14677573L,14732191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210629Inst : IEnumerable<long>
{
public static readonly long[] Value=A210629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210629.Bytes);
public long this[int i]=>Value[i];

public static A210629Inst Instance=new A210629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210630
{
public static readonly long[] Value={ 8L,8L,3L,0L,7L,1L,0L,0L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210630Inst : IEnumerable<long>
{
public static readonly long[] Value=A210630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210630.Bytes);
public long this[int i]=>Value[i];

public static A210630Inst Instance=new A210630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210631
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,3L,4L,8L,10L,17L,21L,32L,39L,55L,66L,89L,105L,136L,159L,200L,231L,284L,325L,392L,445L,528L,595L,697L,780L,903L,1005L,1152L,1275L,1449L,1596L,1800L,1974L,2211L,2415L,2689L,2926L,3240L,3514L,3872L,4186L,4592L,4950L,5408L,5814L,6328L,6786L,7361L,7875L,8515L,9090L,9800L,10440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210631Inst : IEnumerable<long>
{
public static readonly long[] Value=A210631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210631.Bytes);
public long this[int i]=>Value[i];

public static A210631Inst Instance=new A210631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210632
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,4L,6L,14L,21L,41L,60L,104L,150L,239L,337L,509L,701L,1014L,1371L,1916L,2544L,3461L,4520L,6011L,7738L,10092L,12821L,16449L,20646L,26108L,32418L,40474L,49760L,61430L,74840L,91461L,110507L,133818L,160452L,192699L,229422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210632Inst : IEnumerable<long>
{
public static readonly long[] Value=A210632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210632.Bytes);
public long this[int i]=>Value[i];

public static A210632Inst Instance=new A210632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210633
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,6L,12L,25L,44L,79L,128L,208L,318L,483L,704L,1019L,1430L,1992L,2712L,3664L,4862L,6407L,8320L,10735L,13686L,17344L,21760L,27153L,33592L,41353L,50532L,61468L,74290L,89415L,107008L,127576L,151332L,178882L,210496L,246898L,288420L,335920L,389808L,451088L,520260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210633Inst : IEnumerable<long>
{
public static readonly long[] Value=A210633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210633.Bytes);
public long this[int i]=>Value[i];

public static A210633Inst Instance=new A210633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210634
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,9L,20L,42L,78L,139L,231L,372L,573L,861L,1254L,1791L,2499L,3432L,4629L,6162L,8085L,10492L,13455L,17094L,21503L,26832L,33201L,40795L,49764L,60333L,72687L,87096L,103785L,123075L,145236L,170646L,199626L,232617L,269997L,312277L,359898L,413448L,473438L,540540L,615342L,698608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210634Inst : IEnumerable<long>
{
public static readonly long[] Value=A210634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210634.Bytes);
public long this[int i]=>Value[i];

public static A210634Inst Instance=new A210634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210635
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,3L,1L,3L,3L,4L,2L,0L,2L,4L,5L,3L,1L,5L,5L,5L,6L,4L,2L,0L,4L,4L,6L,7L,5L,3L,1L,7L,3L,7L,7L,8L,6L,4L,2L,0L,6L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210635Inst : IEnumerable<long>
{
public static readonly long[] Value=A210635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210635.Bytes);
public long this[int i]=>Value[i];

public static A210635Inst Instance=new A210635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210636
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,7L,13L,7L,1L,17L,40L,32L,10L,1L,41L,117L,124L,60L,13L,1L,99L,332L,437L,286L,97L,16L,1L,239L,921L,1447L,1193L,553L,143L,19L,1L,577L,2512L,4584L,4556L,2682L,952L,198L,22L,1L,1393L,6761L,14048L,16336L,11666L,5282L,1510L,262L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210636Inst : IEnumerable<long>
{
public static readonly long[] Value=A210636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210636.Bytes);
public long this[int i]=>Value[i];

public static A210636Inst Instance=new A210636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210637
{
public static readonly long[] Value={ 1L,2L,2L,5L,8L,3L,12L,27L,20L,5L,29L,84L,91L,44L,8L,70L,248L,352L,251L,90L,13L,169L,708L,1240L,1164L,618L,176L,21L,408L,1973L,4106L,4771L,3344L,1414L,334L,34L,985L,5400L,13010L,18000L,15645L,8748L,3073L,620L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210637Inst : IEnumerable<long>
{
public static readonly long[] Value=A210637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210637.Bytes);
public long this[int i]=>Value[i];

public static A210637Inst Instance=new A210637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210638
{
public static readonly long[] Value={ -1L,1L,-1L,1L,-1L,-1L,1L,-1L,0L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,2L,0L,1L,-1L,1L,-1L,3L,-4L,-2L,-2L,-1L,1L,-1L,4L,-11L,8L,2L,-9L,-1L,1L,-1L,5L,-21L,49L,-14L,9L,-9L,-1L,1L,-1L,6L,-34L,139L,-255L,13L,-24L,50L,-1L,1L,-1L,7L,-50L,296L,-1106L,1508L,45L,-80L,267L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210638Inst : IEnumerable<long>
{
public static readonly long[] Value=A210638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210638.Bytes);
public long this[int i]=>Value[i];

public static A210638Inst Instance=new A210638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210639
{
public static readonly long[] Value={ 0L,4L,12L,22L,34L,47L,62L,78L,95L,113L,132L,153L,174L,196L,219L,243L,268L,294L,320L,347L,375L,403L,432L,462L,492L,524L,555L,588L,621L,654L,688L,723L,758L,794L,830L,867L,905L,943L,981L,1020L,1060L,1100L,1140L,1181L,1223L,1264L,1307L,1350L,1393L,1437L,1481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210639Inst : IEnumerable<long>
{
public static readonly long[] Value=A210639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210639.Bytes);
public long this[int i]=>Value[i];

public static A210639Inst Instance=new A210639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210640
{
public static readonly long[] Value={ 2L,4L,9L,13L,17L,28L,37L,37L,37L,37L,37L,61L,61L,61L,151L,151L,151L,151L,151L,151L,151L,227L,227L,227L,227L,227L,307L,307L,307L,337L,433L,433L,433L,433L,433L,433L,433L,433L,433L,433L,433L,509L,509L,509L,509L,509L,643L,727L,727L,761L,761L,761L,971L,971L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210640Inst : IEnumerable<long>
{
public static readonly long[] Value=A210640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210640.Bytes);
public long this[int i]=>Value[i];

public static A210640Inst Instance=new A210640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210641
{
public static readonly long[] Value={ 1L,3L,7L,5L,-1L,10L,19L,3L,-2L,10L,15L,18L,5L,7L,32L,8L,-11L,11L,21L,18L,14L,34L,29L,-1L,-7L,-9L,32L,31L,-2L,37L,51L,16L,-7L,5L,17L,28L,20L,6L,40L,1L,-15L,41L,49L,32L,14L,45L,50L,7L,-28L,-18L,22L,25L,4L,31L,81L,34L,36L,36L,13L,37L,-12L,11L,58L,8L,-36L,10L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210641Inst : IEnumerable<long>
{
public static readonly long[] Value=A210641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210641.Bytes);
public long this[int i]=>Value[i];

public static A210641Inst Instance=new A210641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210642
{
public static readonly long[] Value={ 2L,2L,3L,4L,5L,9L,7L,13L,17L,17L,11L,13L,13L,19L,23L,17L,17L,29L,19L,23L,31L,31L,23L,41L,31L,29L,31L,37L,29L,31L,31L,37L,41L,41L,59L,37L,37L,59L,43L,41L,41L,59L,43L,67L,53L,53L,47L,53L,67L,59L,61L,53L,53L,79L,59L,59L,67L,73L,59L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210642Inst : IEnumerable<long>
{
public static readonly long[] Value=A210642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210642.Bytes);
public long this[int i]=>Value[i];

public static A210642Inst Instance=new A210642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210643
{
public static readonly long[] Value={ 150L,300L,600L,1050L,1200L,1350L,2400L,2700L,3750L,4200L,4800L,5070L,5400L,7350L,7500L,9450L,9600L,10140L,10800L,12150L,14700L,15000L,16800L,17340L,18150L,19200L,20280L,21600L,24300L,25350L,26250L,29400L,30000L,33750L,34680L,36300L,37800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210643Inst : IEnumerable<long>
{
public static readonly long[] Value=A210643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210643.Bytes);
public long this[int i]=>Value[i];

public static A210643Inst Instance=new A210643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210644
{
public static readonly long[] Value={ 9L,3L,2L,4L,7L,2L,2L,2L,9L,4L,0L,4L,3L,5L,5L,8L,0L,4L,5L,7L,3L,1L,1L,5L,8L,9L,1L,8L,2L,1L,5L,6L,3L,3L,8L,6L,2L,6L,2L,5L,8L,7L,7L,7L,7L,9L,4L,5L,1L,1L,6L,9L,2L,8L,2L,4L,8L,3L,5L,0L,0L,1L,1L,8L,6L,0L,5L,3L,6L,0L,4L,6L,5L,6L,9L,6L,4L,4L,4L,9L,8L,1L,2L,8L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210644Inst : IEnumerable<long>
{
public static readonly long[] Value=A210644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210644.Bytes);
public long this[int i]=>Value[i];

public static A210644Inst Instance=new A210644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210645
{
public static readonly long[] Value={ 84L,336L,756L,1344L,2100L,3024L,4116L,5376L,6804L,8400L,10164L,12096L,14196L,16464L,18900L,21504L,24276L,27216L,30324L,33600L,37044L,40656L,44436L,48384L,52500L,56784L,61236L,65856L,70644L,75600L,80724L,86016L,91476L,97104L,102900L,108864L,114996L,121296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210645Inst : IEnumerable<long>
{
public static readonly long[] Value=A210645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210645.Bytes);
public long this[int i]=>Value[i];

public static A210645Inst Instance=new A210645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210646
{
public static readonly long[] Value={ 2L,11L,59L,149L,197L,233L,607L,829L,929L,1283L,1619L,1879L,2459L,2917L,3251L,3299L,3359L,3947L,4523L,5821L,5843L,5869L,6043L,6143L,6269L,6833L,7229L,8573L,8597L,9479L,9619L,11699L,11783L,11789L,12379L,14639L,15881L,16477L,18869L,19121L,20849L,21149L,21617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210646Inst : IEnumerable<long>
{
public static readonly long[] Value=A210646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210646.Bytes);
public long this[int i]=>Value[i];

public static A210646Inst Instance=new A210646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210647
{
public static readonly long[] Value={ 0L,1L,22L,2L,142L,1L,2L,10L,22L,1L,34L,10L,2L,37L,46L,6L,10L,1L,6L,46L,46L,1L,10L,106L,6L,1L,58L,2L,22L,7L,2L,58L,94L,3L,22L,10L,2L,1L,22L,2L,10L,16L,6L,82L,118L,4L,82L,10L,18L,1L,10L,2L,22L,1L,2L,10L,10L,4L,22L,58L,2L,19L,10L,2L,46L,1L,10L,70L,82L,3L,22L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210647Inst : IEnumerable<long>
{
public static readonly long[] Value=A210647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210647.Bytes);
public long this[int i]=>Value[i];

public static A210647Inst Instance=new A210647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210648
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,32L,2L,3L,3L,1L,3L,2L,3L,6L,1L,3L,1L,3L,6L,8L,1L,4L,17L,1L,2L,3L,3L,1L,2L,2L,3L,5L,15L,1L,1L,5L,1L,1L,3L,2L,1L,1L,1L,3L,1L,2L,2L,2L,1L,1L,1L,25L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210648Inst : IEnumerable<long>
{
public static readonly long[] Value=A210648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210648.Bytes);
public long this[int i]=>Value[i];

public static A210648Inst Instance=new A210648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210649
{
public static readonly long[] Value={ 9L,8L,2L,9L,7L,3L,0L,9L,9L,6L,8L,3L,9L,0L,1L,7L,7L,8L,2L,8L,1L,9L,4L,8L,8L,4L,4L,8L,5L,5L,1L,9L,8L,7L,1L,6L,0L,9L,8L,7L,2L,2L,8L,7L,5L,0L,6L,5L,6L,3L,2L,8L,7L,5L,9L,9L,7L,3L,8L,0L,4L,5L,9L,2L,0L,3L,9L,0L,7L,8L,5L,2L,5L,5L,2L,2L,4L,4L,2L,1L,7L,4L,2L,9L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210649Inst : IEnumerable<long>
{
public static readonly long[] Value=A210649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210649.Bytes);
public long this[int i]=>Value[i];

public static A210649Inst Instance=new A210649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210650
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,3L,5L,5L,7L,2L,3L,4L,5L,3L,1L,1L,2L,3L,1L,5L,1L,4L,1L,2L,8L,1L,3L,1L,4L,3L,5L,5L,2L,17L,3L,4L,3L,21L,2L,1L,5L,8L,10L,7L,4L,1L,12L,3L,1L,3L,1L,3L,5L,8L,10L,8L,2L,4L,20L,2L,1L,11L,4L,14L,4L,3L,4L,17L,12L,2L,8L,13L,7L,1L,13L,5L,3L,5L,1L,8L,4L,13L,6L,3L,21L,10L,5L,1L,12L,7L,5L,1L,12L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210650Inst : IEnumerable<long>
{
public static readonly long[] Value=A210650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210650.Bytes);
public long this[int i]=>Value[i];

public static A210650Inst Instance=new A210650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210651
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,9L,15L,5L,1L,29L,3L,5L,3L,15L,5L,1L,17L,19L,3L,11L,23L,13L,19L,19L,7L,9L,15L,71L,5L,19L,49L,1L,11L,15L,7L,1L,21L,39L,5L,11L,1L,19L,55L,11L,71L,39L,23L,29L,7L,61L,49L,15L,1L,11L,17L,37L,15L,31L,23L,19L,3L,1L,33L,21L,37L,21L,17L,9L,41L,43L,5L,7L,25L,1L,19L,37L,23L,5L,27L,5L,37L,31L,15L,85L,67L,43L,79L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210651Inst : IEnumerable<long>
{
public static readonly long[] Value=A210651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210651.Bytes);
public long this[int i]=>Value[i];

public static A210651Inst Instance=new A210651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210652
{
public static readonly long[] Value={ 10L,15L,20L,25L,30L,35L,40L,45L,50L,51L,52L,53L,54L,55L,56L,57L,58L,60L,65L,69L,70L,75L,78L,80L,85L,87L,90L,95L,96L,98L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,115L,120L,125L,130L,135L,140L,145L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,165L,169L,170L,175L,178L,180L,185L,187L,190L,196L,200L,201L,202L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210652Inst : IEnumerable<long>
{
public static readonly long[] Value=A210652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210652.Bytes);
public long this[int i]=>Value[i];

public static A210652Inst Instance=new A210652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210653
{
public static readonly long[] Value={ 59L,195L,295L,395L,475L,495L,519L,533L,534L,536L,537L,538L,539L,547L,549L,566L,568L,572L,573L,574L,576L,577L,578L,579L,586L,588L,589L,591L,592L,593L,594L,596L,597L,598L,599L,665L,675L,685L,745L,759L,775L,795L,895L,935L,945L,957L,959L,975L,1175L,1195L,1245L,1275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210653Inst : IEnumerable<long>
{
public static readonly long[] Value=A210653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210653.Bytes);
public long this[int i]=>Value[i];

public static A210653Inst Instance=new A210653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210654
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,15L,1L,14L,48L,184L,1L,30L,165L,680L,2945L,1L,62L,558L,2664L,13080L,63756L,1L,126L,1827L,11032L,59605L,320292L,1748803L,1L,254L,5820L,46904L,281440L,1663248L,9791824L,58746304L,1L,510L,18177L,200232L,1379745L,8906544L,56499849L,361679040L,2361347073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210654Inst : IEnumerable<long>
{
public static readonly long[] Value=A210654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210654.Bytes);
public long this[int i]=>Value[i];

public static A210654Inst Instance=new A210654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210655
{
public static readonly BigInteger[] Value={ 1L,2L,15L,184L,2945L,63756L,1748803L,58746304L,2361347073L,111310111900L,6059192459771L,376064819659728L,26330615879623393L,2061099487899901372L,BigInteger.Parse("178985517944285956275"),BigInteger.Parse("17127853895338704829696"),BigInteger.Parse("1795558477562697433148417"),BigInteger.Parse("205139946486547987323752124") };
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
public class A210655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210655Inst Instance=new A210655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210656
{
public static readonly long[] Value={ 1L,8L,36L,130L,412L,1176L,3105L,7712L,18192L,41098L,89476L,188592L,386322L,771528L,1506036L,2879688L,5403628L,9966408L,18092599L,32366288L,57117660L,99526362L,171378512L,291841464L,491812740L,820684904L,1356794820L,2223458146L,3613417008L,5825889936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210656Inst : IEnumerable<long>
{
public static readonly long[] Value=A210656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210656.Bytes);
public long this[int i]=>Value[i];

public static A210656Inst Instance=new A210656Inst();

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