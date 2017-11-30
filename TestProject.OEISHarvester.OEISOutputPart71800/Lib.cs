using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A187817
{
public static readonly long[] Value={ 1L,1L,2L,6L,4L,4L,4L,4L,8L,12L,20L,32L,52L,104L,188L,344L,616L,1116L,2232L,4236L,8084L,15212L,28760L,57520L,111512L,216804L,417560L,806440L,1612880L,3162132L,6209192L,12113136L,23670168L,47340336L,93411704L,184494460L,362693224L,713767712L,1427535424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187817Inst : IEnumerable<long>
{
public static readonly long[] Value=A187817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187817.Bytes);
public long this[int i]=>Value[i];

public static A187817Inst Instance=new A187817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187818
{
public static readonly long[] Value={ 1L,3L,1L,7L,3L,1L,1L,15L,7L,3L,3L,1L,1L,1L,1L,31L,15L,7L,7L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,63L,31L,15L,15L,7L,7L,7L,7L,3L,3L,3L,3L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,127L,63L,31L,31L,15L,15L,15L,15L,7L,7L,7L,7L,7L,7L,7L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187818Inst : IEnumerable<long>
{
public static readonly long[] Value=A187818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187818.Bytes);
public long this[int i]=>Value[i];

public static A187818Inst Instance=new A187818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187819
{
public static readonly long[] Value={ 3L,7L,13L,19L,307L,619L,2089L,7297L,75571L,76103L,98897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187819Inst : IEnumerable<long>
{
public static readonly long[] Value=A187819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187819.Bytes);
public long this[int i]=>Value[i];

public static A187819Inst Instance=new A187819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187836
{
public static readonly long[] Value={ 2L,5L,6L,9L,11L,13L,16L,18L,20L,22L,24L,27L,29L,31L,33L,35L,38L,40L,42L,45L,46L,49L,51L,53L,55L,58L,60L,62L,64L,67L,69L,71L,73L,75L,78L,80L,82L,84L,86L,89L,91L,93L,95L,97L,100L,102L,104L,107L,108L,111L,113L,115L,118L,120L,122L,124L,126L,129L,130L,133L,135L,137L,140L,142L,144L,146L,148L,151L,153L,155L,157L,160L,162L,164L,166L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187836Inst : IEnumerable<long>
{
public static readonly long[] Value=A187836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187836.Bytes);
public long this[int i]=>Value[i];

public static A187836Inst Instance=new A187836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187837
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,10L,12L,14L,16L,18L,20L,21L,23L,26L,27L,29L,31L,33L,35L,36L,38L,40L,42L,44L,46L,48L,50L,51L,53L,55L,57L,59L,61L,63L,65L,66L,68L,70L,72L,74L,75L,78L,80L,81L,83L,85L,87L,89L,90L,92L,95L,96L,98L,100L,102L,104L,106L,108L,109L,111L,113L,115L,117L,119L,120L,122L,124L,126L,128L,130L,132L,133L,135L,137L,139L,141L,143L,145L,147L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187837Inst : IEnumerable<long>
{
public static readonly long[] Value=A187837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187837.Bytes);
public long this[int i]=>Value[i];

public static A187837Inst Instance=new A187837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187838
{
public static readonly long[] Value={ 2L,4L,7L,8L,11L,13L,15L,17L,19L,22L,24L,25L,28L,30L,32L,34L,37L,39L,41L,43L,45L,47L,49L,52L,54L,56L,58L,60L,62L,64L,67L,69L,71L,73L,76L,77L,79L,82L,84L,86L,88L,91L,93L,94L,97L,99L,101L,103L,105L,107L,110L,112L,114L,116L,118L,121L,123L,125L,127L,129L,131L,134L,136L,138L,140L,142L,144L,146L,149L,151L,153L,155L,157L,159L,161L,164L,166L,168L,170L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187838Inst : IEnumerable<long>
{
public static readonly long[] Value=A187838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187838.Bytes);
public long this[int i]=>Value[i];

public static A187838Inst Instance=new A187838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187839
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,9L,12L,14L,15L,17L,19L,21L,22L,24L,26L,28L,30L,31L,33L,35L,37L,38L,41L,42L,44L,46L,47L,50L,51L,52L,55L,56L,58L,60L,62L,63L,65L,68L,69L,71L,73L,74L,76L,78L,80L,82L,83L,85L,86L,89L,90L,92L,94L,96L,98L,99L,101L,103L,104L,107L,108L,111L,112L,114L,116L,117L,119L,121L,123L,124L,126L,128L,130L,132L,134L,135L,137L,139L,140L,142L,144L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187839Inst : IEnumerable<long>
{
public static readonly long[] Value=A187839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187839.Bytes);
public long this[int i]=>Value[i];

public static A187839Inst Instance=new A187839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187840
{
public static readonly long[] Value={ 2L,5L,6L,10L,11L,13L,16L,18L,20L,23L,25L,27L,29L,32L,34L,36L,39L,40L,43L,45L,48L,49L,53L,54L,57L,59L,61L,64L,66L,67L,70L,72L,75L,77L,79L,81L,84L,87L,88L,91L,93L,95L,97L,100L,102L,105L,106L,109L,110L,113L,115L,118L,120L,122L,125L,127L,129L,131L,133L,136L,138L,141L,143L,145L,148L,149L,152L,154L,157L,158L,161L,163L,165L,168L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187840Inst : IEnumerable<long>
{
public static readonly long[] Value=A187840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187840.Bytes);
public long this[int i]=>Value[i];

public static A187840Inst Instance=new A187840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187841
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,16L,17L,19L,21L,23L,25L,26L,28L,30L,31L,34L,35L,37L,39L,41L,42L,44L,46L,48L,50L,51L,53L,55L,57L,59L,60L,62L,64L,66L,68L,69L,71L,73L,74L,77L,78L,80L,82L,83L,85L,87L,89L,91L,93L,95L,96L,98L,100L,102L,103L,105L,107L,109L,111L,112L,114L,116L,117L,119L,121L,123L,125L,126L,128L,130L,132L,134L,135L,137L,139L,141L,143L,145L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187841Inst : IEnumerable<long>
{
public static readonly long[] Value=A187841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187841.Bytes);
public long this[int i]=>Value[i];

public static A187841Inst Instance=new A187841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187842
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,13L,15L,18L,20L,22L,24L,27L,29L,32L,33L,36L,38L,40L,43L,45L,47L,49L,52L,54L,56L,58L,61L,63L,65L,67L,70L,72L,75L,76L,79L,81L,84L,86L,88L,90L,92L,94L,97L,99L,101L,104L,106L,108L,110L,113L,115L,118L,120L,122L,124L,127L,129L,131L,133L,136L,138L,140L,142L,144L,147L,149L,151L,153L,156L,158L,160L,162L,165L,167L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187842Inst : IEnumerable<long>
{
public static readonly long[] Value=A187842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187842.Bytes);
public long this[int i]=>Value[i];

public static A187842Inst Instance=new A187842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187843
{
public static readonly long[] Value={ 0L,5L,6L,8L,9L,14L,15L,17L,27L,31L,32L,36L,38L,42L,43L,51L,65L,73L,74L,82L,89L,100L,101L,107L,109L,123L,152L,154L,165L,174L,177L,179L,190L,198L,211L,216L,220L,227L,233L,236L,260L,319L,328L,335L,336L,356L,361L,362L,370L,373L,406L,433L,444L,453L,465L,468L,470L,481L,490L,517L,521L,523L,528L,540L,541L,546L,562L,616L,696L,733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187843Inst : IEnumerable<long>
{
public static readonly long[] Value=A187843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187843.Bytes);
public long this[int i]=>Value[i];

public static A187843Inst Instance=new A187843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187844
{
public static readonly long[] Value={ 0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,3L,6L,9L,12L,15L,18L,21L,24L,27L,0L,4L,8L,12L,16L,20L,24L,28L,32L,36L,0L,5L,10L,15L,20L,25L,30L,35L,40L,45L,0L,6L,12L,18L,24L,30L,36L,42L,48L,54L,0L,7L,14L,21L,28L,35L,42L,49L,56L,63L,0L,8L,16L,24L,32L,40L,48L,56L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187844Inst : IEnumerable<long>
{
public static readonly long[] Value=A187844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187844.Bytes);
public long this[int i]=>Value[i];

public static A187844Inst Instance=new A187844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187845
{
public static readonly long[] Value={ 0L,-1L,-3L,-6L,-10L,-15L,-21L,-28L,-36L,-45L,-45L,-44L,-42L,-39L,-35L,-30L,-24L,-17L,-9L,0L,0L,2L,6L,12L,20L,30L,42L,56L,72L,90L,90L,93L,99L,108L,120L,135L,153L,174L,198L,225L,225L,229L,237L,249L,265L,285L,309L,337L,369L,405L,405L,410L,420L,435L,455L,480L,510L,545L,585L,630L,630L,636L,648L,666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187845Inst : IEnumerable<long>
{
public static readonly long[] Value=A187845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187845.Bytes);
public long this[int i]=>Value[i];

public static A187845Inst Instance=new A187845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187846
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-2L,-1L,-1L,3L,1L,2L,4L,-1L,-2L,1L,-2L,-1L,-6L,-1L,4L,2L,-1L,-4L,0L,3L,-1L,2L,1L,1L,-2L,2L,0L,-5L,4L,6L,2L,-1L,6L,-4L,-2L,-6L,2L,1L,-4L,-4L,-2L,0L,0L,-1L,1L,1L,-6L,2L,6L,-1L,-8L,-3L,4L,2L,12L,2L,-2L,0L,-1L,7L,4L,-4L,4L,6L,0L,-2L,0L,3L,-6L,-6L,-1L,-4L,-4L,2L,-16L,2L,1L,-2L,-12L,1L,12L,4L,-2L,12L,-14L,2L,2L,0L,0L,0L,-8L,-5L,18L,-1L,4L,1L,14L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187846Inst : IEnumerable<long>
{
public static readonly long[] Value=A187846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187846.Bytes);
public long this[int i]=>Value[i];

public static A187846Inst Instance=new A187846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187847
{
public static readonly BigInteger[] Value={ 1L,0L,1L,4L,14L,78L,504L,3720L,30960L,256320L,2656080L,30078720L,369774720L,4906137600L,69894316800L,1064341555200L,16190733081600L,279499828608000L,5100017213491200L,98087346669312000L,1983334021853184000L,BigInteger.Parse("42063950934061056000"),BigInteger.Parse("933754193111900160000") };
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
public class A187847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187847Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187847.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187847.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187847Inst Instance=new A187847Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187848
{
public static readonly BigInteger[] Value={ 1L,4L,20L,120L,836L,6608L,58324L,568296L,6060340L,70245856L,879937892L,11853424536L,170963881892L,2629912684784L,42995842035316L,744683072665416L,13624184625098644L,262594854417561856L,5319099368762699012L,BigInteger.Parse("112977659152942035192"),BigInteger.Parse("2511041582408699358980") };
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
public class A187848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187848Inst Instance=new A187848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187849
{
public static readonly long[] Value={ 563L,1291L,1733L,1907L,2477L,2609L,2693L,2837L,3533L,3677L,4157L,4517L,5693L,12809L,15077L,19997L,25603L,28517L,29573L,29837L,31517L,32237L,32717L,34949L,37277L,43613L,43973L,44453L,50333L,52253L,62477L,68213L,69197L,72893L,74717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187849Inst : IEnumerable<long>
{
public static readonly long[] Value=A187849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187849.Bytes);
public long this[int i]=>Value[i];

public static A187849Inst Instance=new A187849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187850
{
public static readonly long[] Value={ 1L,4L,0L,9L,12L,0L,16L,56L,24L,0L,25L,132L,304L,24L,0L,36L,240L,1056L,1400L,0L,0L,49L,380L,2312L,7620L,5328L,0L,0L,64L,552L,4048L,20952L,49776L,16032L,0L,0L,81L,756L,6264L,41652L,177040L,292776L,35328L,0L,0L,100L,992L,8960L,69456L,408048L,1400168L,1533064L,49536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187850Inst : IEnumerable<long>
{
public static readonly long[] Value=A187850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187850.Bytes);
public long this[int i]=>Value[i];

public static A187850Inst Instance=new A187850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187851
{
public static readonly long[] Value={ 0L,24L,304L,1056L,2312L,4048L,6264L,8960L,12136L,15792L,19928L,24544L,29640L,35216L,41272L,47808L,54824L,62320L,70296L,78752L,87688L,97104L,107000L,117376L,128232L,139568L,151384L,163680L,176456L,189712L,203448L,217664L,232360L,247536L,263192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187851Inst : IEnumerable<long>
{
public static readonly long[] Value=A187851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187851.Bytes);
public long this[int i]=>Value[i];

public static A187851Inst Instance=new A187851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187868
{
public static readonly long[] Value={ 9901L,99990001L,999999000001L,9999999900000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187868Inst : IEnumerable<long>
{
public static readonly long[] Value=A187868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187868.Bytes);
public long this[int i]=>Value[i];

public static A187868Inst Instance=new A187868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187869
{
public static readonly BigInteger[] Value={ 1L,12L,123L,1234L,14325L,143256L,1432567L,12347658L,123476589L,12347658910L,1234710985611L,123471098561112L,12347651211891013L,1234761310981112514L,BigInteger.Parse("123476131098111251415"),BigInteger.Parse("12347651211815149101316"),BigInteger.Parse("1234765121189101316151417"),BigInteger.Parse("123476589101316151417121118") };
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
public class A187869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187869Inst Instance=new A187869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187870
{
public static readonly BigInteger[] Value={ 4L,44L,428L,10196L,10719068L,25865068L,5472607916L,74185965772L,264698472181028L,2290048394728148L,BigInteger.Parse("19435959308462817284"),2753151578548809148L,BigInteger.Parse("20586893910854623222436"),BigInteger.Parse("134344844535611780572028924") };
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
public class A187870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187870Inst Instance=new A187870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187871
{
public static readonly long[] Value={ 1L,12L,123L,1234L,14325L,143256L,1234765L,12347658L,123476589L,10123476589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187871Inst : IEnumerable<long>
{
public static readonly long[] Value=A187871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187871.Bytes);
public long this[int i]=>Value[i];

public static A187871Inst Instance=new A187871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187872
{
public static readonly long[] Value={ 3L,5L,7L,13L,19L,41L,71L,137L,263L,523L,1033L,2063L,4111L,8219L,16417L,32779L,65539L,131111L,262151L,524341L,1048589L,2097211L,4194329L,8388619L,16777289L,33554473L,67108913L,134217773L,268435463L,536870951L,1073741831L,2147483693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187872Inst : IEnumerable<long>
{
public static readonly long[] Value=A187872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187872.Bytes);
public long this[int i]=>Value[i];

public static A187872Inst Instance=new A187872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187873
{
public static readonly long[] Value={ 3L,3L,7L,13L,19L,31L,41L,59L,71L,89L,103L,131L,151L,179L,199L,229L,263L,307L,337L,373L,409L,449L,491L,547L,587L,641L,683L,739L,797L,857L,911L,971L,1033L,1093L,1171L,1231L,1301L,1381L,1451L,1531L,1607L,1697L,1783L,1867L,1951L,2029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187873Inst : IEnumerable<long>
{
public static readonly long[] Value=A187873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187873.Bytes);
public long this[int i]=>Value[i];

public static A187873Inst Instance=new A187873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187874
{
public static readonly BigInteger[] Value={ 3L,3L,5L,11L,31L,131L,733L,5059L,40351L,362903L,3628819L,39916817L,479001643L,6227020873L,87178291241L,1307674368149L,20922789888041L,355687428096053L,6402373705728061L,121645100408832109L,2432902008176640037L,BigInteger.Parse("51090942171709440037") };
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
public class A187874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187874.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187874Inst Instance=new A187874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187875
{
public static readonly long[] Value={ 5L,2L,10L,8L,9L,4L,7L,6L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187875Inst : IEnumerable<long>
{
public static readonly long[] Value=A187875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187875.Bytes);
public long this[int i]=>Value[i];

public static A187875Inst Instance=new A187875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187876
{
public static readonly long[] Value={ 5L,2L,8L,9L,4L,7L,6L,3L,1L,0L,50L,55L,52L,51L,58L,59L,54L,57L,56L,53L,10L,18L,19L,17L,12L,11L,40L,45L,42L,41L,48L,49L,44L,47L,46L,43L,14L,85L,82L,90L,98L,99L,97L,92L,88L,89L,91L,94L,84L,95L,80L,96L,87L,86L,93L,83L,81L,15L,16L,60L,65L,62L,70L,78L,79L,77L,72L,71L,61L,68L,69L,74L,64L,75L,76L,67L,66L,73L,63L,13L,30L,35L,32L,31L,38L,39L,34L,37L,36L,33L,20L,25L,22L,21L,28L,29L,24L,27L,26L,23L,100L,105L,150L,155L,152L,151L,158L,159L,157L,156L,153L,102L,110L,118L,119L,117L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187876Inst : IEnumerable<long>
{
public static readonly long[] Value=A187876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187876.Bytes);
public long this[int i]=>Value[i];

public static A187876Inst Instance=new A187876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187877
{
public static readonly long[] Value={ 1L,5L,10L,45L,60L,128L,231L,308L,470L,847L,1846L,3570L,4284L,4740L,5126L,5688L,6171L,6650L,7473L,7980L,8687L,9310L,9964L,10640L,11172L,12896L,17877L,19716L,22011L,22736L,23280L,23836L,24823L,33480L,34335L,36384L,37260L,41202L,42315L,43761L,44480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187877Inst : IEnumerable<long>
{
public static readonly long[] Value=A187877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187877.Bytes);
public long this[int i]=>Value[i];

public static A187877Inst Instance=new A187877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187878
{
public static readonly long[] Value={ 5L,8L,10L,125L,231L,250L,470L,1846L,2844L,2856L,3570L,5126L,5320L,7473L,8687L,12555L,12573L,16740L,16764L,17877L,18630L,20601L,21620L,22011L,24823L,27468L,28861L,31941L,33120L,37053L,42315L,42588L,43761L,49404L,58078L,61072L,67728L,68320L,75042L,79947L,84660L,86427L,92432L,97723L,98802L,99580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187878Inst : IEnumerable<long>
{
public static readonly long[] Value=A187878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187878.Bytes);
public long this[int i]=>Value[i];

public static A187878Inst Instance=new A187878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187879
{
public static readonly BigInteger[] Value={ 1L,3L,6561L,7625597484987L,BigInteger.Parse("3433683820292512484657849089281"),BigInteger.Parse("436673502879206784130402698570834024654748577491697818855443") };
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
public class A187879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187879.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187879Inst Instance=new A187879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187880
{
public static readonly BigInteger[] Value={ 0L,2L,120L,18624L,9876480L,20135116800L,163839423283200L,5348052945894113280L,BigInteger.Parse("699612285096273924587520"),BigInteger.Parse("366440137172271078986848665600"),BigInteger.Parse("768105432116827516249785005978419200"),BigInteger.Parse("6441762292785726797799215491828242028953600") };
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
public class A187880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187880Inst Instance=new A187880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187881
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,3L,0L,0L,3L,4L,0L,0L,3L,4L,5L,0L,0L,0L,4L,5L,6L,0L,0L,0L,4L,5L,6L,7L,0L,0L,0L,0L,5L,6L,7L,8L,0L,0L,0L,0L,5L,6L,7L,8L,9L,0L,0L,0L,0L,0L,6L,7L,8L,9L,10L,0L,0L,0L,0L,0L,6L,7L,8L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187881Inst : IEnumerable<long>
{
public static readonly long[] Value=A187881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187881.Bytes);
public long this[int i]=>Value[i];

public static A187881Inst Instance=new A187881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187882
{
public static readonly long[] Value={ 103L,101L,97L,197L,229L,109L,281L,233L,167L,607L,233L,349L,821L,307L,631L,1093L,853L,373L,1597L,1009L,439L,643L,503L,2111L,983L,769L,1811L,569L,2423L,3823L,3581L,2027L,941L,677L,997L,691L,1753L,3539L,1193L,5381L,4289L,2411L,2063L,1307L,919L,8311L,2719L,3187L,6373L,1459L,3331L,9431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187882Inst : IEnumerable<long>
{
public static readonly long[] Value=A187882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187882.Bytes);
public long this[int i]=>Value[i];

public static A187882Inst Instance=new A187882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187883
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,6L,5L,3L,1L,9L,8L,6L,3L,1L,12L,11L,9L,6L,3L,1L,16L,15L,13L,10L,6L,3L,1L,20L,19L,17L,14L,10L,6L,3L,1L,25L,24L,22L,19L,15L,10L,6L,3L,1L,30L,29L,27L,24L,20L,15L,10L,6L,3L,1L,36L,35L,33L,30L,26L,21L,15L,10L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187883Inst : IEnumerable<long>
{
public static readonly long[] Value=A187883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187883.Bytes);
public long this[int i]=>Value[i];

public static A187883Inst Instance=new A187883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187900
{
public static readonly long[] Value={ 4L,7L,9L,14L,16L,21L,25L,28L,31L,33L,38L,42L,45L,48L,50L,55L,57L,60L,65L,67L,72L,74L,79L,83L,86L,89L,91L,96L,98L,101L,106L,108L,113L,115L,120L,124L,127L,130L,132L,137L,141L,144L,148L,151L,154L,156L,161L,165L,168L,171L,173L,178L,182L,185L,188L,190L,195L,197L,200L,205L,207L,212L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187900Inst : IEnumerable<long>
{
public static readonly long[] Value=A187900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187900.Bytes);
public long this[int i]=>Value[i];

public static A187900Inst Instance=new A187900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187901
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,9L,11L,14L,15L,17L,18L,20L,22L,23L,26L,27L,29L,30L,33L,34L,35L,37L,39L,41L,43L,44L,46L,48L,50L,52L,53L,55L,56L,58L,60L,62L,63L,65L,67L,68L,70L,72L,74L,75L,78L,79L,81L,82L,84L,86L,88L,89L,91L,93L,95L,97L,98L,100L,101L,104L,105L,106L,108L,110L,112L,114L,115L,117L,119L,120L,123L,124L,126L,127L,129L,131L,132L,134L,136L,138L,140L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187901Inst : IEnumerable<long>
{
public static readonly long[] Value=A187901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187901.Bytes);
public long this[int i]=>Value[i];

public static A187901Inst Instance=new A187901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187902
{
public static readonly long[] Value={ 2L,5L,6L,10L,12L,13L,16L,19L,21L,24L,25L,28L,31L,32L,36L,38L,40L,42L,45L,47L,49L,51L,54L,57L,59L,61L,64L,66L,69L,71L,73L,76L,77L,80L,83L,85L,87L,90L,92L,94L,96L,99L,102L,103L,107L,109L,111L,113L,116L,118L,121L,122L,125L,128L,130L,133L,135L,137L,139L,142L,144L,146L,148L,151L,154L,156L,158L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187902Inst : IEnumerable<long>
{
public static readonly long[] Value=A187902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187902.Bytes);
public long this[int i]=>Value[i];

public static A187902Inst Instance=new A187902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187903
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,9L,12L,14L,15L,16L,18L,20L,22L,24L,26L,27L,29L,31L,32L,34L,36L,38L,39L,41L,43L,45L,46L,48L,50L,51L,54L,55L,57L,58L,60L,62L,64L,66L,67L,69L,71L,72L,74L,76L,78L,80L,81L,83L,85L,86L,88L,90L,92L,93L,95L,97L,99L,100L,102L,104L,105L,107L,109L,111L,113L,114L,116L,118L,120L,121L,123L,125L,127L,128L,130L,132L,133L,135L,137L,139L,140L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187903Inst : IEnumerable<long>
{
public static readonly long[] Value=A187903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187903.Bytes);
public long this[int i]=>Value[i];

public static A187903Inst Instance=new A187903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187904
{
public static readonly long[] Value={ 2L,5L,6L,10L,11L,13L,17L,19L,21L,23L,25L,28L,30L,33L,35L,37L,40L,42L,44L,47L,49L,52L,53L,56L,59L,61L,63L,65L,68L,70L,73L,75L,77L,79L,82L,84L,87L,89L,91L,94L,96L,98L,101L,103L,106L,108L,110L,112L,115L,117L,119L,122L,124L,126L,129L,131L,134L,136L,138L,141L,142L,145L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187904Inst : IEnumerable<long>
{
public static readonly long[] Value=A187904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187904.Bytes);
public long this[int i]=>Value[i];

public static A187904Inst Instance=new A187904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187905
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,10L,11L,12L,14L,16L,18L,19L,20L,22L,24L,25L,27L,28L,30L,31L,32L,34L,35L,37L,38L,40L,42L,43L,44L,46L,47L,49L,50L,52L,53L,55L,57L,58L,59L,61L,63L,64L,66L,67L,69L,70L,72L,73L,75L,76L,78L,79L,81L,82L,83L,85L,87L,89L,90L,91L,93L,95L,96L,97L,99L,101L,102L,103L,105L,107L,108L,109L,111L,112L,114L,115L,117L,119L,120L,121L,123L,124L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187905Inst : IEnumerable<long>
{
public static readonly long[] Value=A187905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187905.Bytes);
public long this[int i]=>Value[i];

public static A187905Inst Instance=new A187905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187906
{
public static readonly long[] Value={ 3L,5L,9L,13L,15L,17L,21L,23L,26L,29L,33L,36L,39L,41L,45L,48L,51L,54L,56L,60L,62L,65L,68L,71L,74L,77L,80L,84L,86L,88L,92L,94L,98L,100L,104L,106L,110L,113L,116L,118L,122L,125L,128L,131L,134L,137L,139L,143L,145L,149L,151L,155L,157L,161L,163L,165L,169L,173L,176L,179L,181L,185L,188L,190L,193L,196L,200L,202L,205L,208L,212L,214L,216L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187906Inst : IEnumerable<long>
{
public static readonly long[] Value=A187906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187906.Bytes);
public long this[int i]=>Value[i];

public static A187906Inst Instance=new A187906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187907
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,16L,19L,20L,23L,24L,26L,28L,30L,32L,34L,36L,38L,40L,41L,43L,46L,48L,49L,51L,53L,55L,57L,59L,61L,63L,64L,66L,68L,71L,73L,74L,76L,78L,80L,82L,84L,86L,88L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L,139L,141L,143L,145L,147L,149L,151L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187907Inst : IEnumerable<long>
{
public static readonly long[] Value=A187907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187907.Bytes);
public long this[int i]=>Value[i];

public static A187907Inst Instance=new A187907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187908
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,17L,18L,21L,22L,25L,27L,29L,31L,33L,35L,37L,39L,42L,44L,45L,47L,50L,52L,54L,56L,58L,60L,62L,65L,67L,69L,70L,72L,75L,77L,79L,81L,83L,85L,87L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,140L,142L,144L,146L,148L,150L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187908Inst : IEnumerable<long>
{
public static readonly long[] Value=A187908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187908.Bytes);
public long this[int i]=>Value[i];

public static A187908Inst Instance=new A187908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187909
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,10L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,25L,26L,28L,29L,31L,32L,33L,35L,37L,38L,40L,41L,42L,44L,45L,47L,48L,49L,51L,52L,54L,56L,57L,58L,59L,61L,63L,64L,65L,67L,68L,70L,71L,72L,74L,75L,77L,78L,80L,81L,82L,84L,85L,86L,88L,89L,91L,92L,93L,95L,97L,98L,100L,101L,102L,104L,105L,107L,108L,109L,111L,112L,114L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187909Inst : IEnumerable<long>
{
public static readonly long[] Value=A187909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187909.Bytes);
public long this[int i]=>Value[i];

public static A187909Inst Instance=new A187909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187910
{
public static readonly long[] Value={ 4L,6L,9L,13L,17L,20L,24L,27L,30L,34L,36L,39L,43L,46L,50L,53L,55L,60L,62L,66L,69L,73L,76L,79L,83L,87L,90L,94L,96L,99L,103L,106L,110L,113L,115L,120L,122L,126L,131L,133L,136L,139L,143L,147L,150L,152L,157L,159L,163L,166L,169L,173L,175L,180L,182L,187L,189L,192L,196L,199L,201L,206L,208L,212L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187910Inst : IEnumerable<long>
{
public static readonly long[] Value=A187910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187910.Bytes);
public long this[int i]=>Value[i];

public static A187910Inst Instance=new A187910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187911
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,10L,11L,13L,14L,15L,17L,19L,20L,21L,22L,24L,26L,27L,28L,29L,31L,33L,34L,36L,37L,38L,40L,41L,42L,44L,45L,47L,49L,50L,52L,53L,54L,56L,57L,58L,59L,61L,63L,64L,66L,68L,69L,70L,71L,73L,74L,75L,77L,78L,80L,81L,82L,84L,86L,87L,89L,90L,91L,93L,94L,96L,98L,99L,100L,101L,103L,105L,106L,107L,108L,110L,111L,112L,114L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187911Inst : IEnumerable<long>
{
public static readonly long[] Value=A187911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187911.Bytes);
public long this[int i]=>Value[i];

public static A187911Inst Instance=new A187911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187912
{
public static readonly long[] Value={ 2L,6L,9L,12L,16L,18L,23L,25L,30L,32L,35L,39L,43L,46L,48L,51L,55L,60L,62L,65L,67L,72L,76L,79L,83L,85L,88L,92L,95L,97L,102L,104L,109L,113L,115L,120L,122L,125L,129L,132L,134L,137L,141L,145L,148L,152L,157L,159L,162L,164L,169L,171L,174L,178L,181L,185L,188L,190L,194L,199L,201L,206L,208L,211L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187912Inst : IEnumerable<long>
{
public static readonly long[] Value=A187912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187912.Bytes);
public long this[int i]=>Value[i];

public static A187912Inst Instance=new A187912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187913
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,4L,1L,1L,6L,10L,5L,2L,1L,18L,32L,13L,9L,2L,1L,57L,100L,44L,28L,10L,3L,1L,186L,329L,142L,100L,32L,15L,3L,1L,622L,1101L,480L,344L,119L,55L,16L,4L,1L,2120L,3761L,1640L,1214L,420L,216L,60L,22L,4L,1L,7338L,13035L,5698L,4300L,1517L,810L,243L,92L,23L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187913Inst : IEnumerable<long>
{
public static readonly long[] Value=A187913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187913.Bytes);
public long this[int i]=>Value[i];

public static A187913Inst Instance=new A187913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187914
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,6L,10L,4L,1L,21L,36L,15L,6L,1L,79L,137L,58L,29L,7L,1L,311L,543L,232L,132L,37L,9L,1L,1265L,2219L,954L,590L,179L,57L,10L,1L,5275L,9285L,4010L,2628L,837L,315L,68L,12L,1L,22431L,39587L,17156L,11732L,3861L,1629L,396L,94L,13L,1L,96900L,171369L,74469L,52608L,17726L,8127L,2133L,612L,108L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187914Inst : IEnumerable<long>
{
public static readonly long[] Value=A187914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187914.Bytes);
public long this[int i]=>Value[i];

public static A187914Inst Instance=new A187914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187915
{
public static readonly long[] Value={ 3L,13L,45L,141L,419L,1201L,3357L,9209L,24899L,66549L,176205L,462917L,1208163L,3135449L,8097597L,20823921L,53350531L,136228445L,346819437L,880594813L,2230476067L,5637208449L,14218682973L,35797815913L,89974587843L,225790779205L,565803994509L,1415938252341L,3539007315683L,8835146000809L,22033012367997L,54889789955297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187915Inst : IEnumerable<long>
{
public static readonly long[] Value=A187915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187915.Bytes);
public long this[int i]=>Value[i];

public static A187915Inst Instance=new A187915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187948
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187948Inst : IEnumerable<long>
{
public static readonly long[] Value=A187948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187948.Bytes);
public long this[int i]=>Value[i];

public static A187948Inst Instance=new A187948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187949
{
public static readonly long[] Value={ 2L,5L,10L,13L,15L,18L,23L,26L,31L,34L,36L,39L,44L,47L,49L,52L,57L,60L,65L,68L,70L,73L,78L,81L,86L,89L,91L,94L,99L,102L,104L,107L,112L,115L,120L,123L,125L,128L,133L,136L,138L,141L,146L,149L,154L,157L,159L,162L,167L,170L,175L,178L,180L,183L,188L,191L,193L,196L,201L,204L,209L,212L,214L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187949Inst : IEnumerable<long>
{
public static readonly long[] Value=A187949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187949.Bytes);
public long this[int i]=>Value[i];

public static A187949Inst Instance=new A187949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187950
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187950Inst : IEnumerable<long>
{
public static readonly long[] Value=A187950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187950.Bytes);
public long this[int i]=>Value[i];

public static A187950Inst Instance=new A187950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187951
{
public static readonly long[] Value={ 2L,4L,5L,7L,10L,12L,13L,15L,17L,18L,20L,23L,25L,26L,28L,31L,33L,34L,36L,38L,39L,41L,44L,46L,47L,49L,51L,52L,54L,57L,59L,60L,62L,65L,67L,68L,70L,72L,73L,75L,78L,80L,81L,83L,86L,88L,89L,91L,93L,94L,96L,99L,101L,102L,104L,106L,107L,109L,112L,114L,115L,117L,120L,122L,123L,125L,127L,128L,130L,133L,135L,136L,138L,140L,141L,143L,146L,148L,149L,151L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187951Inst : IEnumerable<long>
{
public static readonly long[] Value=A187951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187951.Bytes);
public long this[int i]=>Value[i];

public static A187951Inst Instance=new A187951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187952
{
public static readonly long[] Value={ 1L,3L,6L,8L,9L,11L,14L,16L,19L,21L,22L,24L,27L,29L,30L,32L,35L,37L,40L,42L,43L,45L,48L,50L,53L,55L,56L,58L,61L,63L,64L,66L,69L,71L,74L,76L,77L,79L,82L,84L,85L,87L,90L,92L,95L,97L,98L,100L,103L,105L,108L,110L,111L,113L,116L,118L,119L,121L,124L,126L,129L,131L,132L,134L,137L,139L,142L,144L,145L,147L,150L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187952Inst : IEnumerable<long>
{
public static readonly long[] Value=A187952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187952.Bytes);
public long this[int i]=>Value[i];

public static A187952Inst Instance=new A187952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187953
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,9L,11L,12L,14L,16L,17L,19L,20L,21L,22L,24L,25L,27L,28L,29L,30L,32L,33L,35L,37L,38L,40L,41L,42L,43L,45L,46L,48L,50L,51L,53L,54L,55L,56L,58L,59L,61L,62L,63L,64L,66L,67L,69L,71L,72L,74L,75L,76L,77L,79L,80L,82L,83L,84L,85L,87L,88L,90L,92L,93L,95L,96L,97L,98L,100L,101L,103L,105L,106L,108L,109L,110L,111L,113L,114L,116L,117L,118L,119L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187953Inst : IEnumerable<long>
{
public static readonly long[] Value=A187953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187953.Bytes);
public long this[int i]=>Value[i];

public static A187953Inst Instance=new A187953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187954
{
public static readonly long[] Value={ 1L,1L,3L,1L,0L,5L,1L,0L,0L,7L,1L,3L,0L,0L,9L,1L,0L,0L,0L,0L,11L,1L,0L,0L,0L,0L,0L,13L,1L,3L,5L,0L,0L,0L,0L,15L,1L,0L,0L,0L,0L,0L,0L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,19L,1L,3L,0L,7L,0L,0L,0L,0L,0L,0L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187954Inst : IEnumerable<long>
{
public static readonly long[] Value=A187954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187954.Bytes);
public long this[int i]=>Value[i];

public static A187954Inst Instance=new A187954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187955
{
public static readonly long[] Value={ 256L,8768L,359488L,15189800L,1218772461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187955Inst : IEnumerable<long>
{
public static readonly long[] Value=A187955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187955.Bytes);
public long this[int i]=>Value[i];

public static A187955Inst Instance=new A187955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187956
{
public static readonly long[] Value={ 256L,1408L,7744L,42592L,240064L,1353088L,7626496L,42683776L,238891456L,1337021536L,7498109248L,42049915264L,235818833152L,1321724569984L,7408042078528L,41520819604576L,232755657125056L,1304771833495936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187956Inst : IEnumerable<long>
{
public static readonly long[] Value=A187956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187956.Bytes);
public long this[int i]=>Value[i];

public static A187956Inst Instance=new A187956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187957
{
public static readonly long[] Value={ 1408L,8768L,53728L,322128L,2092928L,13520976L,86157696L,548059536L,3471855360L,21859425872L,139526151616L,888660941136L,5639390386304L,35875799655952L,227944117135296L,1445770705741904L,9197000455294016L,58463779006676944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187957Inst : IEnumerable<long>
{
public static readonly long[] Value=A187957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187957.Bytes);
public long this[int i]=>Value[i];

public static A187957Inst Instance=new A187957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187958
{
public static readonly long[] Value={ 7744L,53728L,359488L,2292560L,16890700L,122812784L,860108472L,6116839902L,43092481644L,298860635764L,2133759439896L,15149745081538L,106412240118540L,754706717902846L,5335690343354458L,37525816010840830L,265952713606425686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187958Inst : IEnumerable<long>
{
public static readonly long[] Value=A187958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187958.Bytes);
public long this[int i]=>Value[i];

public static A187958Inst Instance=new A187958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187959
{
public static readonly long[] Value={ 42592L,322128L,2292560L,15189800L,124421880L,993918272L,7359939574L,57445906202L,440377678798L,3253135013018L,25486986699010L,197366974577896L,1485391626845718L,11512660838008050L,88561258735158018L,669899830762918568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187959Inst : IEnumerable<long>
{
public static readonly long[] Value=A187959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187959.Bytes);
public long this[int i]=>Value[i];

public static A187959Inst Instance=new A187959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187960
{
public static readonly long[] Value={ 240064L,2092928L,16890700L,124421880L,1218772461L,11568061339L,98476432408L,907622916436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187960Inst : IEnumerable<long>
{
public static readonly long[] Value=A187960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187960.Bytes);
public long this[int i]=>Value[i];

public static A187960Inst Instance=new A187960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187961
{
public static readonly long[] Value={ 1353088L,13520976L,122812784L,993918272L,11568061339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187961Inst : IEnumerable<long>
{
public static readonly long[] Value=A187961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187961.Bytes);
public long this[int i]=>Value[i];

public static A187961Inst Instance=new A187961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187962
{
public static readonly long[] Value={ 7626496L,86157696L,860108472L,7359939574L,98476432408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187962Inst : IEnumerable<long>
{
public static readonly long[] Value=A187962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187962.Bytes);
public long this[int i]=>Value[i];

public static A187962Inst Instance=new A187962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187963
{
public static readonly long[] Value={ 42683776L,548059536L,6116839902L,57445906202L,907622916436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187963Inst : IEnumerable<long>
{
public static readonly long[] Value=A187963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187963.Bytes);
public long this[int i]=>Value[i];

public static A187963Inst Instance=new A187963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187996
{
public static readonly long[] Value={ 1L,4L,5L,25L,64L,286L,1055L,5191L,24135L,122238L,626982L,3324754L,17890884L,98093994L,544680909L,3062711643L,17400096265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187996Inst : IEnumerable<long>
{
public static readonly long[] Value=A187996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187996.Bytes);
public long this[int i]=>Value[i];

public static A187996Inst Instance=new A187996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187997
{
public static readonly long[] Value={ 1L,5L,8L,34L,88L,421L,1696L,8373L,40681L,211234L,1111148L,5987390L,32752144L,181900825L,1022304310L,5807285713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187997Inst : IEnumerable<long>
{
public static readonly long[] Value=A187997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187997.Bytes);
public long this[int i]=>Value[i];

public static A187997Inst Instance=new A187997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187998
{
public static readonly long[] Value={ 1L,6L,9L,46L,117L,636L,2596L,13343L,66452L,354806L,1898800L,10452050L,58080269L,327389928L,1863061322L,10707246833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187998Inst : IEnumerable<long>
{
public static readonly long[] Value=A187998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187998.Bytes);
public long this[int i]=>Value[i];

public static A187998Inst Instance=new A187998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187999
{
public static readonly long[] Value={ 1L,7L,10L,57L,159L,862L,3796L,20224L,105208L,573982L,3155734L,17684829L,100137017L,572950408L,3306528276L,19236540159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187999Inst : IEnumerable<long>
{
public static readonly long[] Value=A187999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187999.Bytes);
public long this[int i]=>Value[i];

public static A187999Inst Instance=new A187999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188000
{
public static readonly long[] Value={ 1L,8L,11L,75L,216L,1206L,5443L,30358L,160866L,907542L,5096859L,29196613L,168131646L,978358588L,5726901772L,33757032775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188000Inst : IEnumerable<long>
{
public static readonly long[] Value=A188000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188000.Bytes);
public long this[int i]=>Value[i];

public static A188000Inst Instance=new A188000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188001
{
public static readonly long[] Value={ 1L,9L,12L,88L,270L,1587L,7674L,43750L,242128L,1393159L,8045324L,46987016L,275921190L,1631855528L,9700469624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188001Inst : IEnumerable<long>
{
public static readonly long[] Value=A188001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188001.Bytes);
public long this[int i]=>Value[i];

public static A188001Inst Instance=new A188001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188002
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,4L,12L,1L,5L,5L,17L,25L,1L,6L,8L,25L,45L,106L,1L,7L,9L,34L,64L,176L,376L,1L,8L,10L,46L,88L,286L,644L,1670L,1L,9L,11L,57L,117L,421L,1055L,2983L,7315L,1L,10L,12L,75L,159L,636L,1696L,5191L,13675L,35808L,1L,11L,15L,88L,216L,862L,2596L,8373L,24135L,67487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188002Inst : IEnumerable<long>
{
public static readonly long[] Value=A188002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188002.Bytes);
public long this[int i]=>Value[i];

public static A188002Inst Instance=new A188002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188003
{
public static readonly long[] Value={ 3L,4L,5L,8L,9L,10L,11L,12L,15L,16L,17L,20L,21L,24L,25L,28L,29L,30L,33L,34L,35L,36L,37L,42L,45L,46L,47L,50L,53L,54L,55L,56L,59L,62L,63L,66L,67L,70L,73L,76L,77L,78L,79L,82L,83L,84L,85L,86L,91L,94L,97L,100L,101L,104L,105L,106L,109L,110L,113L,116L,117L,118L,119L,128L,129L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188003Inst : IEnumerable<long>
{
public static readonly long[] Value=A188003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188003.Bytes);
public long this[int i]=>Value[i];

public static A188003Inst Instance=new A188003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188004
{
public static readonly long[] Value={ 12L,17L,25L,34L,46L,57L,75L,88L,108L,125L,147L,170L,196L,217L,249L,280L,316L,345L,387L,422L,466L,501L,545L,588L,644L,687L,743L,792L,850L,901L,973L,1034L,1100L,1157L,1227L,1294L,1374L,1435L,1519L,1594L,1682L,1757L,1847L,1930L,2026L,2103L,2205L,2294L,2404L,2491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188004Inst : IEnumerable<long>
{
public static readonly long[] Value=A188004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188004.Bytes);
public long this[int i]=>Value[i];

public static A188004Inst Instance=new A188004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188005
{
public static readonly long[] Value={ 25L,45L,64L,88L,117L,159L,216L,270L,333L,421L,500L,628L,731L,869L,1000L,1156L,1349L,1545L,1718L,1940L,2163L,2525L,2806L,3116L,3405L,3785L,4208L,4608L,4983L,5443L,5888L,6510L,7011L,7627L,8142L,8832L,9537L,10287L,10954L,11730L,12405L,13437L,14180L,15098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188005Inst : IEnumerable<long>
{
public static readonly long[] Value=A188005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188005.Bytes);
public long this[int i]=>Value[i];

public static A188005Inst Instance=new A188005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188006
{
public static readonly long[] Value={ 106L,176L,286L,421L,636L,862L,1206L,1587L,2114L,2698L,3450L,4255L,5356L,6522L,8026L,9451L,11468L,13434L,15970L,18457L,21512L,24652L,28728L,32569L,37426L,42000L,47824L,53393L,60688L,67492L,75464L,83349L,93086L,102446L,113894L,123963L,137198L,149672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188006Inst : IEnumerable<long>
{
public static readonly long[] Value=A188006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188006.Bytes);
public long this[int i]=>Value[i];

public static A188006Inst Instance=new A188006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188007
{
public static readonly long[] Value={ 376L,644L,1055L,1696L,2596L,3796L,5443L,7674L,10392L,14198L,18641L,24416L,31116L,39648L,49989L,62572L,76306L,93562L,113133L,138192L,164244L,195934L,230445L,272084L,318416L,371618L,428815L,496774L,567422L,655234L,745671L,851342L,959446L,1088018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188007Inst : IEnumerable<long>
{
public static readonly long[] Value=A188007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188007.Bytes);
public long this[int i]=>Value[i];

public static A188007Inst Instance=new A188007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188008
{
public static readonly long[] Value={ 1670L,2983L,5191L,8373L,13343L,20224L,30358L,43750L,62354L,86173L,118859L,159445L,213459L,277174L,362216L,461894L,590268L,739245L,924861L,1139511L,1409109L,1712354L,2087342L,2501092L,3011962L,3576355L,4267359L,5020859L,5914551L,6899802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188008Inst : IEnumerable<long>
{
public static readonly long[] Value=A188008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188008.Bytes);
public long this[int i]=>Value[i];

public static A188008Inst Instance=new A188008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188009
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188009Inst : IEnumerable<long>
{
public static readonly long[] Value=A188009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188009.Bytes);
public long this[int i]=>Value[i];

public static A188009Inst Instance=new A188009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188010
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,14L,15L,16L,17L,19L,20L,21L,22L,24L,25L,27L,28L,29L,30L,32L,33L,35L,36L,37L,38L,40L,41L,42L,43L,45L,46L,48L,49L,50L,51L,53L,54L,55L,56L,58L,59L,61L,62L,63L,64L,66L,67L,69L,70L,71L,72L,74L,75L,76L,77L,79L,80L,82L,83L,84L,85L,87L,88L,90L,91L,92L,93L,95L,96L,97L,98L,100L,101L,103L,104L,105L,106L,108L,109L,110L,111L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188010Inst : IEnumerable<long>
{
public static readonly long[] Value=A188010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188010.Bytes);
public long this[int i]=>Value[i];

public static A188010Inst Instance=new A188010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188011
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188011Inst : IEnumerable<long>
{
public static readonly long[] Value=A188011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188011.Bytes);
public long this[int i]=>Value[i];

public static A188011Inst Instance=new A188011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188028
{
public static readonly long[] Value={ 1L,3L,6L,8L,9L,11L,14L,16L,19L,21L,22L,24L,27L,29L,32L,35L,37L,40L,42L,43L,45L,48L,50L,53L,55L,56L,58L,61L,63L,66L,69L,71L,74L,76L,77L,79L,82L,84L,87L,90L,92L,95L,97L,98L,100L,103L,105L,108L,110L,111L,113L,116L,118L,121L,124L,126L,129L,131L,132L,134L,137L,139L,142L,144L,145L,147L,150L,152L,155L,158L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188028Inst : IEnumerable<long>
{
public static readonly long[] Value=A188028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188028.Bytes);
public long this[int i]=>Value[i];

public static A188028Inst Instance=new A188028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188029
{
public static readonly long[] Value={ 2L,4L,5L,7L,10L,12L,13L,15L,17L,18L,20L,23L,25L,26L,28L,30L,31L,33L,34L,36L,38L,39L,41L,44L,46L,47L,49L,51L,52L,54L,57L,59L,60L,62L,64L,65L,67L,68L,70L,72L,73L,75L,78L,80L,81L,83L,85L,86L,88L,89L,91L,93L,94L,96L,99L,101L,102L,104L,106L,107L,109L,112L,114L,115L,117L,119L,120L,122L,123L,125L,127L,128L,130L,133L,135L,136L,138L,140L,141L,143L,146L,148L,149L,151L,153L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188029Inst : IEnumerable<long>
{
public static readonly long[] Value=A188029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188029.Bytes);
public long this[int i]=>Value[i];

public static A188029Inst Instance=new A188029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188030
{
public static readonly long[] Value={ 5L,13L,18L,26L,31L,34L,39L,47L,52L,60L,65L,68L,73L,81L,86L,89L,94L,102L,107L,115L,120L,123L,128L,136L,141L,149L,154L,157L,162L,170L,175L,178L,183L,191L,196L,204L,209L,212L,217L,225L,230L,233L,238L,246L,251L,259L,264L,267L,272L,280L,285L,293L,298L,301L,306L,314L,319L,322L,327L,335L,340L,348L,353L,356L,361L,369L,374L,382L,387L,390L,395L,403L,408L,411L,416L,424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188030Inst : IEnumerable<long>
{
public static readonly long[] Value=A188030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188030.Bytes);
public long this[int i]=>Value[i];

public static A188030Inst Instance=new A188030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188031
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188031Inst : IEnumerable<long>
{
public static readonly long[] Value=A188031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188031.Bytes);
public long this[int i]=>Value[i];

public static A188031Inst Instance=new A188031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188032
{
public static readonly long[] Value={ 3L,8L,11L,16L,21L,24L,29L,37L,42L,45L,50L,55L,58L,63L,71L,76L,79L,84L,92L,97L,100L,105L,110L,113L,118L,126L,131L,134L,139L,144L,147L,152L,160L,165L,168L,173L,181L,186L,189L,194L,199L,202L,207L,215L,220L,223L,228L,236L,241L,244L,249L,254L,257L,262L,270L,275L,278L,283L,288L,291L,296L,304L,309L,312L,317L,325L,330L,333L,338L,343L,346L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188032Inst : IEnumerable<long>
{
public static readonly long[] Value=A188032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188032.Bytes);
public long this[int i]=>Value[i];

public static A188032Inst Instance=new A188032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188033
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,9L,10L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,77L,78L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L,91L,93L,94L,95L,96L,98L,99L,101L,102L,103L,104L,106L,107L,108L,109L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188033Inst : IEnumerable<long>
{
public static readonly long[] Value=A188033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188033.Bytes);
public long this[int i]=>Value[i];

public static A188033Inst Instance=new A188033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188034
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188034Inst : IEnumerable<long>
{
public static readonly long[] Value=A188034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188034.Bytes);
public long this[int i]=>Value[i];

public static A188034Inst Instance=new A188034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188035
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,11L,12L,14L,16L,17L,19L,21L,22L,24L,25L,27L,29L,30L,32L,35L,37L,38L,40L,42L,43L,45L,46L,48L,50L,51L,53L,55L,56L,58L,59L,61L,63L,64L,66L,69L,71L,72L,74L,76L,77L,79L,80L,82L,84L,85L,87L,90L,92L,93L,95L,97L,98L,100L,101L,103L,105L,106L,108L,110L,111L,113L,114L,116L,118L,119L,121L,124L,126L,127L,129L,131L,132L,134L,135L,137L,139L,140L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188035Inst : IEnumerable<long>
{
public static readonly long[] Value=A188035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188035.Bytes);
public long this[int i]=>Value[i];

public static A188035Inst Instance=new A188035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188036
{
public static readonly long[] Value={ 2L,5L,7L,10L,13L,15L,18L,20L,23L,26L,28L,31L,33L,34L,36L,39L,41L,44L,47L,49L,52L,54L,57L,60L,62L,65L,67L,68L,70L,73L,75L,78L,81L,83L,86L,88L,89L,91L,94L,96L,99L,102L,104L,107L,109L,112L,115L,117L,120L,122L,123L,125L,128L,130L,133L,136L,138L,141L,143L,146L,149L,151L,154L,156L,157L,159L,162L,164L,167L,170L,172L,175L,177L,178L,180L,183L,185L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188036Inst : IEnumerable<long>
{
public static readonly long[] Value=A188036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188036.Bytes);
public long this[int i]=>Value[i];

public static A188036Inst Instance=new A188036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188037
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188037Inst : IEnumerable<long>
{
public static readonly long[] Value=A188037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188037.Bytes);
public long this[int i]=>Value[i];

public static A188037Inst Instance=new A188037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188038
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188038Inst : IEnumerable<long>
{
public static readonly long[] Value=A188038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188038.Bytes);
public long this[int i]=>Value[i];

public static A188038Inst Instance=new A188038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188039
{
public static readonly long[] Value={ 2L,7L,12L,19L,24L,31L,36L,41L,48L,53L,60L,65L,70L,77L,82L,89L,94L,101L,106L,111L,118L,123L,130L,135L,140L,147L,152L,159L,164L,171L,176L,181L,188L,193L,200L,205L,210L,217L,222L,229L,234L,239L,246L,251L,258L,263L,270L,275L,280L,287L,292L,299L,304L,309L,316L,321L,328L,333L,340L,345L,350L,357L,362L,369L,374L,379L,386L,391L,398L,403L,408L,415L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188039Inst : IEnumerable<long>
{
public static readonly long[] Value=A188039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188039.Bytes);
public long this[int i]=>Value[i];

public static A188039Inst Instance=new A188039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188040
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,66L,67L,68L,69L,71L,72L,73L,74L,75L,76L,78L,79L,80L,81L,83L,84L,85L,86L,87L,88L,90L,91L,92L,93L,95L,96L,97L,98L,99L,100L,102L,103L,104L,105L,107L,108L,109L,110L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188040Inst : IEnumerable<long>
{
public static readonly long[] Value=A188040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188040.Bytes);
public long this[int i]=>Value[i];

public static A188040Inst Instance=new A188040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188041
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188041Inst : IEnumerable<long>
{
public static readonly long[] Value=A188041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188041.Bytes);
public long this[int i]=>Value[i];

public static A188041Inst Instance=new A188041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188042
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,16L,18L,19L,20L,21L,23L,24L,25L,26L,28L,30L,31L,32L,33L,35L,36L,37L,38L,40L,41L,42L,43L,45L,47L,48L,49L,50L,52L,53L,54L,55L,57L,59L,60L,61L,62L,64L,65L,66L,67L,69L,70L,71L,72L,74L,76L,77L,78L,79L,81L,82L,83L,84L,86L,88L,89L,90L,91L,93L,94L,95L,96L,98L,100L,101L,102L,103L,105L,106L,107L,108L,110L,111L,112L,113L,115L,117L,118L,119L,120L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188042Inst : IEnumerable<long>
{
public static readonly long[] Value=A188042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188042.Bytes);
public long this[int i]=>Value[i];

public static A188042Inst Instance=new A188042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188043
{
public static readonly long[] Value={ 5L,10L,15L,17L,22L,27L,29L,34L,39L,44L,46L,51L,56L,58L,63L,68L,73L,75L,80L,85L,87L,92L,97L,99L,104L,109L,114L,116L,121L,126L,128L,133L,138L,143L,145L,150L,155L,157L,162L,167L,169L,174L,179L,184L,186L,191L,196L,198L,203L,208L,213L,215L,220L,225L,227L,232L,237L,242L,244L,249L,254L,256L,261L,266L,268L,273L,278L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188043Inst : IEnumerable<long>
{
public static readonly long[] Value=A188043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188043.Bytes);
public long this[int i]=>Value[i];

public static A188043Inst Instance=new A188043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188060
{
public static readonly BigInteger[] Value={ 8L,128L,4096L,32768L,1048576L,11593056256L,536870912L,7767448354816L,3014517285978112L,191986824837595136L,2733227576976736256L,BigInteger.Parse("66530577009460375453696"),BigInteger.Parse("5926115612870995607552"),BigInteger.Parse("488951148984934932554973184"),BigInteger.Parse("7946710949908368748447692488704"),BigInteger.Parse("71105936114697022329949662478336") };
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
public class A188060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188060.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188060Inst Instance=new A188060Inst();

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