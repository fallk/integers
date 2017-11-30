using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A057045
{
public static readonly long[] Value={ 2L,1L,2L,3L,4L,5L,6L,8L,10L,12L,16L,20L,25L,32L,41L,52L,66L,85L,107L,137L,174L,221L,281L,358L,455L,579L,737L,937L,1192L,1516L,1929L,2454L,3121L,3970L,5050L,6424L,8171L,10394L,13221L,16818L,21393L,27212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057045Inst : IEnumerable<long>
{
public static readonly long[] Value=A057045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057045.Bytes);
public long this[int i]=>Value[i];

public static A057045Inst Instance=new A057045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057046
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,9L,8L,3L,16L,34L,32L,1L,64L,94L,128L,195L,256L,418L,512L,948L,1024L,2344L,2048L,688L,4096L,8544L,8192L,22591L,16384L,20854L,32768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057046Inst : IEnumerable<long>
{
public static readonly long[] Value=A057046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057046.Bytes);
public long this[int i]=>Value[i];

public static A057046Inst Instance=new A057046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057047
{
public static readonly long[] Value={ 1L,2L,3L,3L,6L,5L,3L,9L,21L,17L,12L,33L,91L,65L,88L,129L,168L,257L,307L,513L,501L,1025L,553L,2049L,5106L,4097L,3042L,8193L,580L,16385L,25488L,32769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057047Inst : IEnumerable<long>
{
public static readonly long[] Value=A057047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057047.Bytes);
public long this[int i]=>Value[i];

public static A057047Inst Instance=new A057047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057048
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,16L,23L,32L,45L,64L,91L,128L,181L,256L,362L,512L,724L,1024L,1448L,2048L,2896L,4096L,5793L,8192L,11585L,16384L,23170L,32768L,46341L,65536L,92682L,131072L,185364L,262144L,370728L,524288L,741455L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057048Inst : IEnumerable<long>
{
public static readonly long[] Value=A057048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057048.Bytes);
public long this[int i]=>Value[i];

public static A057048Inst Instance=new A057048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057049
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,8L,4L,9L,3L,9L,1L,8L,16L,6L,15L,3L,13L,24L,10L,22L,6L,19L,1L,15L,30L,10L,26L,4L,21L,39L,15L,34L,8L,28L,49L,21L,43L,13L,36L,4L,28L,53L,19L,45L,9L,36L,64L,26L,55L,15L,45L,3L,34L,66L,22L,55L,9L,43L,78L,30L,66L,16L,53L,1L,39L,78L,24L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057049Inst : IEnumerable<long>
{
public static readonly long[] Value=A057049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057049.Bytes);
public long this[int i]=>Value[i];

public static A057049Inst Instance=new A057049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057050
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,1L,7L,3L,11L,6L,16L,10L,3L,15L,7L,21L,12L,2L,18L,7L,25L,13L,33L,20L,6L,28L,13L,37L,21L,4L,30L,12L,40L,21L,1L,31L,10L,42L,20L,54L,31L,7L,43L,18L,56L,30L,3L,43L,15L,57L,28L,72L,42L,11L,57L,25L,73L,40L,6L,56L,21L,73L,37L,91L,54L,16L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057050Inst : IEnumerable<long>
{
public static readonly long[] Value=A057050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057050.Bytes);
public long this[int i]=>Value[i];

public static A057050Inst Instance=new A057050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057051
{
public static readonly long[] Value={ 1L,1L,6L,18L,73L,255L,950L,3473L,13006L,48840L,185353L,706404L,2706608L,10404625L,40126430L,155133811L,601119492L,2333671638L,9075290555L,35345525798L,137847145330L,538258922839L,2104101413400L,8233434921693L,32247613423563L,126410623214720L,495918571702575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057051Inst : IEnumerable<long>
{
public static readonly long[] Value=A057051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057051.Bytes);
public long this[int i]=>Value[i];

public static A057051Inst Instance=new A057051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057052
{
public static readonly long[] Value={ 1L,2L,6L,9L,5L,6L,18L,16L,26L,10L,5L,17L,52L,43L,54L,1L,62L,54L,73L,125L,81L,63L,77L,129L,49L,185L,180L,7L,79L,204L,145L,128L,159L,244L,97L,296L,250L,257L,323L,97L,286L,168L,106L,106L,174L,316L,83L,377L,279L,250L,296L,423L,92L,384L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057052Inst : IEnumerable<long>
{
public static readonly long[] Value=A057052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057052.Bytes);
public long this[int i]=>Value[i];

public static A057052Inst Instance=new A057052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057053
{
public static readonly long[] Value={ 1L,3L,2L,3L,12L,16L,9L,17L,13L,36L,48L,43L,15L,32L,29L,91L,38L,55L,45L,2L,56L,84L,80L,38L,129L,3L,19L,204L,143L,29L,100L,129L,110L,37L,197L,10L,69L,75L,22L,262L,86L,218L,294L,308L,254L,126L,374L,94L,207L,251L,220L,108L,455L,178L,379L,506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057053Inst : IEnumerable<long>
{
public static readonly long[] Value=A057053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057053.Bytes);
public long this[int i]=>Value[i];

public static A057053Inst Instance=new A057053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057054
{
public static readonly long[] Value={ 1L,4L,7L,11L,16L,21L,26L,32L,38L,45L,52L,59L,66L,74L,82L,91L,99L,108L,117L,126L,136L,146L,156L,166L,177L,187L,198L,210L,221L,232L,244L,256L,268L,280L,293L,305L,318L,331L,344L,358L,371L,385L,399L,413L,427L,441L,456L,470L,485L,500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057054Inst : IEnumerable<long>
{
public static readonly long[] Value=A057054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057054.Bytes);
public long this[int i]=>Value[i];

public static A057054Inst Instance=new A057054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057055
{
public static readonly long[] Value={ 1L,1L,4L,5L,7L,1L,6L,15L,12L,10L,10L,13L,20L,32L,14L,36L,23L,12L,4L,55L,1L,8L,22L,44L,75L,36L,84L,55L,30L,10L,100L,98L,104L,119L,20L,51L,94L,10L,75L,4L,95L,41L,162L,129L,105L,91L,88L,97L,119L,155L,206L,51L,129L,225L,99L,228L,124L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057055Inst : IEnumerable<long>
{
public static readonly long[] Value=A057055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057055.Bytes);
public long this[int i]=>Value[i];

public static A057055Inst Instance=new A057055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057056
{
public static readonly long[] Value={ 1L,3L,1L,2L,2L,11L,8L,1L,7L,12L,15L,15L,11L,2L,24L,5L,22L,37L,49L,1L,60L,57L,47L,29L,2L,46L,2L,36L,66L,91L,5L,12L,11L,1L,106L,80L,42L,132L,72L,149L,63L,123L,7L,46L,76L,96L,105L,102L,86L,56L,11L,173L,101L,11L,144L,21L,132L,234L,57L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057056Inst : IEnumerable<long>
{
public static readonly long[] Value=A057056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057056.Bytes);
public long this[int i]=>Value[i];

public static A057056Inst Instance=new A057056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057057
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,11L,13L,15L,18L,21L,24L,27L,30L,33L,37L,40L,44L,48L,52L,55L,60L,64L,68L,72L,76L,81L,85L,90L,95L,100L,104L,109L,114L,119L,125L,130L,135L,141L,146L,152L,157L,163L,168L,174L,180L,186L,192L,198L,204L,210L,216L,223L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057057Inst : IEnumerable<long>
{
public static readonly long[] Value=A057057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057057.Bytes);
public long this[int i]=>Value[i];

public static A057057Inst Instance=new A057057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057058
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,2L,3L,1L,5L,2L,4L,3L,1L,6L,2L,5L,3L,4L,1L,7L,2L,6L,3L,5L,4L,1L,8L,2L,7L,3L,6L,4L,5L,1L,9L,2L,8L,3L,7L,4L,6L,5L,1L,10L,2L,9L,3L,8L,4L,7L,5L,6L,1L,11L,2L,10L,3L,9L,4L,8L,5L,7L,6L,1L,12L,2L,11L,3L,10L,4L,9L,5L,8L,6L,7L,1L,13L,2L,12L,3L,11L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057058Inst : IEnumerable<long>
{
public static readonly long[] Value=A057058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057058.Bytes);
public long this[int i]=>Value[i];

public static A057058Inst Instance=new A057058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057059
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,4L,1L,3L,2L,5L,1L,4L,2L,3L,6L,1L,5L,2L,4L,3L,7L,1L,6L,2L,5L,3L,4L,8L,1L,7L,2L,6L,3L,5L,4L,9L,1L,8L,2L,7L,3L,6L,4L,5L,10L,1L,9L,2L,8L,3L,7L,4L,6L,5L,11L,1L,10L,2L,9L,3L,8L,4L,7L,5L,6L,12L,1L,11L,2L,10L,3L,9L,4L,8L,5L,7L,6L,13L,1L,12L,2L,11L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057059Inst : IEnumerable<long>
{
public static readonly long[] Value=A057059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057059.Bytes);
public long this[int i]=>Value[i];

public static A057059Inst Instance=new A057059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057060
{
public static readonly long[] Value={ 1L,2L,2L,1L,1L,3L,2L,4L,2L,1L,3L,1L,5L,7L,2L,8L,4L,6L,1L,5L,7L,1L,5L,11L,6L,10L,12L,2L,4L,8L,7L,11L,1L,3L,13L,15L,4L,10L,14L,2L,8L,10L,1L,3L,7L,9L,1L,13L,17L,19L,2L,8L,10L,20L,4L,10L,16L,18L,1L,5L,7L,17L,7L,11L,13L,17L,6L,12L,22L,24L,2L,8L,16L,22L,1L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057060Inst : IEnumerable<long>
{
public static readonly long[] Value=A057060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057060.Bytes);
public long this[int i]=>Value[i];

public static A057060Inst Instance=new A057060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057061
{
public static readonly long[] Value={ 2L,1L,2L,4L,5L,3L,5L,3L,6L,8L,6L,9L,5L,3L,9L,3L,8L,6L,12L,8L,6L,13L,9L,3L,9L,5L,3L,14L,12L,8L,10L,6L,17L,15L,5L,3L,15L,9L,5L,18L,12L,10L,20L,18L,14L,12L,21L,9L,5L,3L,21L,15L,13L,3L,20L,14L,8L,6L,24L,20L,18L,8L,19L,15L,13L,9L,21L,15L,5L,3L,26L,20L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057061Inst : IEnumerable<long>
{
public static readonly long[] Value=A057061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057061.Bytes);
public long this[int i]=>Value[i];

public static A057061Inst Instance=new A057061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057062
{
public static readonly long[] Value={ 2L,2L,3L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,17L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057062Inst : IEnumerable<long>
{
public static readonly long[] Value=A057062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057062.Bytes);
public long this[int i]=>Value[i];

public static A057062Inst Instance=new A057062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057063
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,10L,12L,7L,16L,18L,11L,22L,13L,5L,28L,30L,19L,20L,36L,23L,40L,42L,9L,46L,29L,31L,52L,37L,35L,58L,60L,15L,44L,66L,43L,70L,72L,25L,54L,78L,8L,82L,61L,55L,88L,65L,59L,68L,96L,27L,100L,102L,38L,106L,108L,71L,112L,85L,33L,89L,94L,79L,48L,126L,83L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057063Inst : IEnumerable<long>
{
public static readonly long[] Value=A057063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057063.Bytes);
public long this[int i]=>Value[i];

public static A057063Inst Instance=new A057063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057064
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,7L,11L,9L,17L,16L,22L,13L,23L,15L,28L,29L,37L,19L,34L,21L,44L,36L,40L,25L,54L,35L,46L,47L,51L,31L,67L,33L,79L,53L,58L,56L,82L,39L,64L,60L,89L,43L,87L,45L,97L,88L,76L,49L,120L,65L,112L,77L,102L,55L,104L,80L,145L,84L,94L,61L,142L,63L,100L,114L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057064Inst : IEnumerable<long>
{
public static readonly long[] Value=A057064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057064.Bytes);
public long this[int i]=>Value[i];

public static A057064Inst Instance=new A057064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057065
{
public static readonly BigInteger[] Value={ 0L,0L,2L,13L,128L,1562L,23328L,411771L,8388608L,193710244L,5000000000L,142655835305L,4458050224128L,151437553296126L,5556003412779008L,218946945190429687L,9223372036854775808UL,BigInteger.Parse("413620130943168382088"),BigInteger.Parse("19673204037648268787712"),BigInteger.Parse("989209827830156794561989") };
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
public class A057065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057065Inst Instance=new A057065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057066
{
public static readonly long[] Value={ 256L,128L,85L,64L,51L,42L,36L,32L,28L,25L,23L,21L,19L,18L,17L,16L,15L,14L,13L,12L,12L,11L,11L,10L,10L,9L,9L,9L,8L,8L,8L,8L,7L,7L,7L,7L,6L,6L,6L,6L,6L,6L,5L,5L,5L,5L,5L,5L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057066Inst : IEnumerable<long>
{
public static readonly long[] Value=A057066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057066.Bytes);
public long this[int i]=>Value[i];

public static A057066Inst Instance=new A057066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057067
{
public static readonly long[] Value={ 3125L,1562L,1041L,781L,625L,520L,446L,390L,347L,312L,284L,260L,240L,223L,208L,195L,183L,173L,164L,156L,148L,142L,135L,130L,125L,120L,115L,111L,107L,104L,100L,97L,94L,91L,89L,86L,84L,82L,80L,78L,76L,74L,72L,71L,69L,67L,66L,65L,63L,62L,61L,60L,58L,57L,56L,55L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057067Inst : IEnumerable<long>
{
public static readonly long[] Value=A057067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057067.Bytes);
public long this[int i]=>Value[i];

public static A057067Inst Instance=new A057067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057068
{
public static readonly long[] Value={ 46656L,23328L,15552L,11664L,9331L,7776L,6665L,5832L,5184L,4665L,4241L,3888L,3588L,3332L,3110L,2916L,2744L,2592L,2455L,2332L,2221L,2120L,2028L,1944L,1866L,1794L,1728L,1666L,1608L,1555L,1505L,1458L,1413L,1372L,1333L,1296L,1260L,1227L,1196L,1166L,1137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057068Inst : IEnumerable<long>
{
public static readonly long[] Value=A057068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057068.Bytes);
public long this[int i]=>Value[i];

public static A057068Inst Instance=new A057068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057069
{
public static readonly long[] Value={ 823543L,411771L,274514L,205885L,164708L,137257L,117649L,102942L,91504L,82354L,74867L,68628L,63349L,58824L,54902L,51471L,48443L,45752L,43344L,41177L,39216L,37433L,35806L,34314L,32941L,31674L,30501L,29412L,28398L,27451L,26565L,25735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057069Inst : IEnumerable<long>
{
public static readonly long[] Value=A057069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057069.Bytes);
public long this[int i]=>Value[i];

public static A057069Inst Instance=new A057069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057070
{
public static readonly long[] Value={ 16777216L,8388608L,5592405L,4194304L,3355443L,2796202L,2396745L,2097152L,1864135L,1677721L,1525201L,1398101L,1290555L,1198372L,1118481L,1048576L,986895L,932067L,883011L,838860L,798915L,762600L,729444L,699050L,671088L,645277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057070Inst : IEnumerable<long>
{
public static readonly long[] Value=A057070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057070.Bytes);
public long this[int i]=>Value[i];

public static A057070Inst Instance=new A057070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057071
{
public static readonly long[] Value={ 387420489L,193710244L,129140163L,96855122L,77484097L,64570081L,55345784L,48427561L,43046721L,38742048L,35220044L,32285040L,29801576L,27672892L,25828032L,24213780L,22789440L,21523360L,20390552L,19371024L,18448594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057071Inst : IEnumerable<long>
{
public static readonly long[] Value=A057071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057071.Bytes);
public long this[int i]=>Value[i];

public static A057071Inst Instance=new A057071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057072
{
public static readonly long[] Value={ 10000000000L,5000000000L,3333333333L,2500000000L,2000000000L,1666666666L,1428571428L,1250000000L,1111111111L,1000000000L,909090909L,833333333L,769230769L,714285714L,666666666L,625000000L,588235294L,555555555L,526315789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057072Inst : IEnumerable<long>
{
public static readonly long[] Value=A057072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057072.Bytes);
public long this[int i]=>Value[i];

public static A057072Inst Instance=new A057072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057073
{
public static readonly long[] Value={ 285311670611L,142655835305L,95103890203L,71327917652L,57062334122L,47551945101L,40758810087L,35663958826L,31701296734L,28531167061L,25937424601L,23775972550L,21947051585L,20379405043L,19020778040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057073Inst : IEnumerable<long>
{
public static readonly long[] Value=A057073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057073.Bytes);
public long this[int i]=>Value[i];

public static A057073Inst Instance=new A057073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057074
{
public static readonly long[] Value={ 8916100448256L,4458050224128L,2972033482752L,2229025112064L,1783220089651L,1486016741376L,1273728635465L,1114512556032L,990677827584L,891610044825L,810554586205L,743008370688L,685853880635L,636864317732L,594406696550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057074Inst : IEnumerable<long>
{
public static readonly long[] Value=A057074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057074.Bytes);
public long this[int i]=>Value[i];

public static A057074Inst Instance=new A057074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057075
{
public static readonly long[] Value={ 1L,0L,4L,0L,2L,27L,0L,1L,13L,256L,0L,1L,9L,128L,3125L,0L,0L,6L,85L,1562L,46656L,0L,0L,5L,64L,1041L,23328L,823543L,0L,0L,4L,51L,781L,15552L,411771L,16777216L,0L,0L,3L,42L,625L,11664L,274514L,8388608L,387420489L,0L,0L,3L,36L,520L,9331L,205885L,5592405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057075Inst : IEnumerable<long>
{
public static readonly long[] Value=A057075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057075.Bytes);
public long this[int i]=>Value[i];

public static A057075Inst Instance=new A057075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057076
{
public static readonly long[] Value={ 2L,11L,119L,1298L,14159L,154451L,1684802L,18378371L,200477279L,2186871698L,23855111399L,260219353691L,2838557779202L,30963916217531L,337764520613639L,3684445810532498L,40191139395243839L,438418087537149731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057076Inst : IEnumerable<long>
{
public static readonly long[] Value=A057076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057076.Bytes);
public long this[int i]=>Value[i];

public static A057076Inst Instance=new A057076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057077
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057077Inst : IEnumerable<long>
{
public static readonly long[] Value=A057077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057077.Bytes);
public long this[int i]=>Value[i];

public static A057077Inst Instance=new A057077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057078
{
public static readonly long[] Value={ 1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057078Inst : IEnumerable<long>
{
public static readonly long[] Value=A057078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057078.Bytes);
public long this[int i]=>Value[i];

public static A057078Inst Instance=new A057078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057079
{
public static readonly long[] Value={ 1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057079Inst : IEnumerable<long>
{
public static readonly long[] Value=A057079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057079.Bytes);
public long this[int i]=>Value[i];

public static A057079Inst Instance=new A057079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057080
{
public static readonly long[] Value={ 1L,9L,71L,559L,4401L,34649L,272791L,2147679L,16908641L,133121449L,1048062951L,8251382159L,64962994321L,511452572409L,4026657584951L,31701808107199L,249587807272641L,1965000650073929L,15470417393318791L,121798338496476399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057080Inst : IEnumerable<long>
{
public static readonly long[] Value=A057080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057080.Bytes);
public long this[int i]=>Value[i];

public static A057080Inst Instance=new A057080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057081
{
public static readonly long[] Value={ 1L,10L,89L,791L,7030L,62479L,555281L,4935050L,43860169L,389806471L,3464398070L,30789776159L,273643587361L,2432002510090L,21614379003449L,192097408520951L,1707262297685110L,15173263270645039L,134852107138120241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057081Inst : IEnumerable<long>
{
public static readonly long[] Value=A057081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057081.Bytes);
public long this[int i]=>Value[i];

public static A057081Inst Instance=new A057081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057082
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,13L,4L,16L,5L,19L,6L,22L,7L,179L,57L,201L,64L,223L,71L,245L,78L,267L,85L,289L,92L,311L,99L,333L,106L,355L,113L,52163L,16604L,52518L,16717L,52873L,16830L,53228L,16943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057082Inst : IEnumerable<long>
{
public static readonly long[] Value=A057082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057082.Bytes);
public long this[int i]=>Value[i];

public static A057082Inst Instance=new A057082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057083
{
public static readonly long[] Value={ 1L,3L,6L,9L,9L,0L,-27L,-81L,-162L,-243L,-243L,0L,729L,2187L,4374L,6561L,6561L,0L,-19683L,-59049L,-118098L,-177147L,-177147L,0L,531441L,1594323L,3188646L,4782969L,4782969L,0L,-14348907L,-43046721L,-86093442L,-129140163L,-129140163L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057083Inst : IEnumerable<long>
{
public static readonly long[] Value=A057083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057083.Bytes);
public long this[int i]=>Value[i];

public static A057083Inst Instance=new A057083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057084
{
public static readonly long[] Value={ 1L,8L,56L,384L,2624L,17920L,122368L,835584L,5705728L,38961152L,266043392L,1816657920L,12404916224L,84706066432L,578409201664L,3949625081856L,26969727041536L,184160815677440L,1257528709087232L,8586943147278336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057084Inst : IEnumerable<long>
{
public static readonly long[] Value=A057084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057084.Bytes);
public long this[int i]=>Value[i];

public static A057084Inst Instance=new A057084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057085
{
public static readonly long[] Value={ 0L,1L,9L,72L,567L,4455L,34992L,274833L,2158569L,16953624L,133155495L,1045816839L,8213952096L,64513217313L,506693386953L,3979621526760L,31256353258263L,245490585583527L,1928108090927376L,15143557548094641L,118939045114505385L,934159388097696696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057085Inst : IEnumerable<long>
{
public static readonly long[] Value=A057085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057085.Bytes);
public long this[int i]=>Value[i];

public static A057085Inst Instance=new A057085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057086
{
public static readonly ulong[] Value={ 1L,10L,90L,800L,7100L,63000L,559000L,4960000L,44010000L,390500000L,3464900000L,30744000000L,272791000000L,2420470000000L,21476790000000L,190563200000000L,1690864100000000L,15003009000000000L,133121449000000000L,1181184400000000000L,10480629510000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057086Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A057086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057086.Bytes);
public ulong this[int i]=>Value[i];

public static A057086Inst Instance=new A057086Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057087
{
public static readonly long[] Value={ 1L,4L,20L,96L,464L,2240L,10816L,52224L,252160L,1217536L,5878784L,28385280L,137056256L,661766144L,3195289600L,15428222976L,74494050304L,359689093120L,1736732573696L,8385686667264L,40489676963840L,195501454524416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057087Inst : IEnumerable<long>
{
public static readonly long[] Value=A057087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057087.Bytes);
public long this[int i]=>Value[i];

public static A057087Inst Instance=new A057087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057088
{
public static readonly long[] Value={ 1L,5L,30L,175L,1025L,6000L,35125L,205625L,1203750L,7046875L,41253125L,241500000L,1413765625L,8276328125L,48450468750L,283633984375L,1660422265625L,9720281250000L,56903517578125L,333118994140625L,1950112558593750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057088Inst : IEnumerable<long>
{
public static readonly long[] Value=A057088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057088.Bytes);
public long this[int i]=>Value[i];

public static A057088Inst Instance=new A057088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057089
{
public static readonly long[] Value={ 1L,6L,42L,288L,1980L,13608L,93528L,642816L,4418064L,30365280L,208700064L,1434392064L,9858552768L,67757668992L,465697330560L,3200729997312L,21998563967232L,151195763787264L,1039165966526976L,7142170381885440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057089Inst : IEnumerable<long>
{
public static readonly long[] Value=A057089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057089.Bytes);
public long this[int i]=>Value[i];

public static A057089Inst Instance=new A057089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057090
{
public static readonly long[] Value={ 1L,7L,56L,441L,3479L,27440L,216433L,1707111L,13464808L,106203433L,837677687L,6607167840L,52113918689L,411047605703L,3242130670744L,25572247935129L,201700650241111L,1590910287233680L,12548276562323537L,98974307946900519L,780658091564568392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057090Inst : IEnumerable<long>
{
public static readonly long[] Value=A057090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057090.Bytes);
public long this[int i]=>Value[i];

public static A057090Inst Instance=new A057090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057091
{
public static readonly long[] Value={ 1L,8L,72L,640L,5696L,50688L,451072L,4014080L,35721216L,317882368L,2828828672L,25173688320L,224020135936L,1993550594048L,17740565839872L,157872931471360L,1404907978489856L,12502247279689728L,111257242065436672L,990075914761011200L,8810665254611582976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057091Inst : IEnumerable<long>
{
public static readonly long[] Value=A057091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057091.Bytes);
public long this[int i]=>Value[i];

public static A057091Inst Instance=new A057091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057092
{
public static readonly BigInteger[] Value={ 1L,9L,90L,891L,8829L,87480L,866781L,8588349L,85096170L,843160671L,8354311569L,82777250160L,820184055561L,8126651751489L,80521522263450L,797833566134451L,7905195795581109L,78327264255440040L,776092140459190341L,7689774642431673429L,BigInteger.Parse("76192801046017773930") };
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
public class A057092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057092Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057092.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057092.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057092Inst Instance=new A057092Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057093
{
public static readonly BigInteger[] Value={ 1L,10L,110L,1200L,13100L,143000L,1561000L,17040000L,186010000L,2030500000L,22165100000L,241956000000L,2641211000000L,28831670000000L,314728810000000L,3435604800000000L,37503336100000000L,409389409000000000L,4468927451000000000L,BigInteger.Parse("48783168600000000000") };
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
public class A057093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057093Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057093.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057093Inst Instance=new A057093Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057094
{
public static readonly long[] Value={ 0L,0L,-1L,0L,0L,-1L,0L,0L,1L,-1L,0L,0L,0L,2L,-1L,0L,0L,0L,-1L,3L,-1L,0L,0L,0L,0L,-3L,4L,-1L,0L,0L,0L,0L,1L,-6L,5L,-1L,0L,0L,0L,0L,0L,4L,-10L,6L,-1L,0L,0L,0L,0L,0L,-1L,10L,-15L,7L,-1L,0L,0L,0L,0L,0L,0L,-5L,20L,-21L,8L,-1L,0L,0L,0L,0L,0L,0L,1L,-15L,35L,-28L,9L,-1L,0L,0L,0L,0L,0L,0L,0L,6L,-35L,56L,-36L,10L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L,21L,-70L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057094Inst : IEnumerable<long>
{
public static readonly long[] Value=A057094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057094.Bytes);
public long this[int i]=>Value[i];

public static A057094Inst Instance=new A057094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057095
{
public static readonly long[] Value={ 2L,10L,238850L,315410L,927070L,2525870L,2828270L,3993070L,4794520L,5617160L,6173870L,6859310L,8146100L,8294290L,9267220L,10053410L,10515340L,12720460L,15074770L,16755190L,16788580L,17525470L,21740120L,26657060L,29633510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057095Inst : IEnumerable<long>
{
public static readonly long[] Value=A057095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057095.Bytes);
public long this[int i]=>Value[i];

public static A057095Inst Instance=new A057095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057096
{
public static readonly long[] Value={ 60L,480L,780L,1620L,2040L,3840L,4200L,6240L,7500L,12180L,12960L,14760L,15540L,16320L,20580L,21060L,30720L,33600L,40260L,43740L,49920L,55080L,60000L,65520L,66780L,79860L,92820L,97440L,97500L,103680L,113400L,118080L,120120L,124320L,130560L,131820L,164640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057096Inst : IEnumerable<long>
{
public static readonly long[] Value=A057096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057096.Bytes);
public long this[int i]=>Value[i];

public static A057096Inst Instance=new A057096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057097
{
public static readonly long[] Value={ 1L,8L,13L,27L,34L,64L,70L,104L,125L,203L,216L,246L,259L,272L,343L,351L,512L,560L,671L,729L,832L,918L,1000L,1092L,1113L,1331L,1547L,1624L,1625L,1728L,1890L,1968L,2002L,2072L,2176L,2197L,2744L,2808L,3164L,3212L,3333L,3375L,3927L,4096L,4250L,4459L,4480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057097Inst : IEnumerable<long>
{
public static readonly long[] Value=A057097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057097.Bytes);
public long this[int i]=>Value[i];

public static A057097Inst Instance=new A057097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057098
{
public static readonly long[] Value={ 3L,6L,5L,9L,8L,12L,7L,10L,15L,20L,18L,9L,12L,16L,21L,15L,24L,14L,11L,27L,20L,24L,30L,16L,28L,33L,13L,40L,25L,36L,21L,18L,33L,24L,32L,39L,42L,30L,15L,48L,20L,45L,36L,48L,40L,35L,28L,39L,51L,22L,60L,54L,17L,27L,40L,57L,36L,48L,65L,60L,24L,32L,35L,56L,63L,45L,60L,19L,66L,44L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057098Inst : IEnumerable<long>
{
public static readonly long[] Value=A057098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057098.Bytes);
public long this[int i]=>Value[i];

public static A057098Inst Instance=new A057098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057099
{
public static readonly long[] Value={ 4L,8L,12L,12L,15L,16L,24L,24L,20L,21L,24L,40L,35L,30L,28L,36L,32L,48L,60L,36L,48L,45L,40L,63L,45L,44L,84L,42L,60L,48L,72L,80L,56L,70L,60L,52L,56L,72L,112L,55L,99L,60L,77L,64L,75L,84L,96L,80L,68L,120L,63L,72L,144L,120L,96L,76L,105L,90L,72L,80L,143L,126L,120L,90L,84L,108L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057099Inst : IEnumerable<long>
{
public static readonly long[] Value=A057099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057099.Bytes);
public long this[int i]=>Value[i];

public static A057099Inst Instance=new A057099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057100
{
public static readonly long[] Value={ 5L,10L,13L,15L,17L,20L,25L,26L,25L,29L,30L,41L,37L,34L,35L,39L,40L,50L,61L,45L,52L,51L,50L,65L,53L,55L,85L,58L,65L,60L,75L,82L,65L,74L,68L,65L,70L,78L,113L,73L,101L,75L,85L,80L,85L,91L,100L,89L,85L,122L,87L,90L,145L,123L,104L,95L,111L,102L,97L,100L,145L,130L,125L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057100Inst : IEnumerable<long>
{
public static readonly long[] Value=A057100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057100.Bytes);
public long this[int i]=>Value[i];

public static A057100Inst Instance=new A057100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057101
{
public static readonly long[] Value={ 6L,24L,30L,54L,60L,96L,84L,120L,150L,210L,216L,180L,210L,240L,294L,270L,384L,336L,330L,486L,480L,540L,600L,504L,630L,726L,546L,840L,750L,864L,756L,720L,924L,840L,960L,1014L,1176L,1080L,840L,1320L,990L,1350L,1386L,1536L,1500L,1470L,1344L,1560L,1734L,1320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057101Inst : IEnumerable<long>
{
public static readonly long[] Value=A057101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057101.Bytes);
public long this[int i]=>Value[i];

public static A057101Inst Instance=new A057101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057102
{
public static readonly long[] Value={ 24L,96L,120L,240L,336L,384L,480L,720L,840L,960L,1320L,1344L,1536L,1920L,1944L,2016L,2184L,2520L,2880L,3360L,3696L,3840L,3960L,4896L,5280L,5376L,5544L,6144L,6240L,6840L,6864L,7680L,7776L,8064L,8736L,9240L,9360L,9720L,10080L,10296L,10920L,11520L,12144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057102Inst : IEnumerable<long>
{
public static readonly long[] Value=A057102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057102.Bytes);
public long this[int i]=>Value[i];

public static A057102Inst Instance=new A057102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057103
{
public static readonly long[] Value={ 24L,96L,120L,240L,384L,336L,480L,840L,960L,720L,840L,1536L,1944L,1920L,1320L,1344L,2520L,3360L,3696L,3360L,2184L,2016L,3840L,5280L,6144L,6240L,5376L,3360L,2880L,5544L,7776L,9360L,10080L,9720L,8064L,4896L,3960L,7680L,10920L,13440L,15000L,15360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057103Inst : IEnumerable<long>
{
public static readonly long[] Value=A057103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057103.Bytes);
public long this[int i]=>Value[i];

public static A057103Inst Instance=new A057103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057104
{
public static readonly long[] Value={ 8L,9L,18L,19L,28L,29L,38L,39L,48L,49L,58L,59L,68L,69L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,108L,109L,118L,119L,128L,129L,138L,139L,148L,149L,158L,159L,168L,169L,178L,179L,180L,181L,182L,183L,184L,185L,186L,187L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057104Inst : IEnumerable<long>
{
public static readonly long[] Value=A057104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057104.Bytes);
public long this[int i]=>Value[i];

public static A057104Inst Instance=new A057104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057105
{
public static readonly long[] Value={ 1L,-2L,7L,-7L,4L,17L,-14L,-1L,14L,31L,-23L,-8L,9L,28L,49L,-34L,-17L,2L,23L,46L,71L,-47L,-28L,-7L,16L,41L,68L,97L,-62L,-41L,-18L,7L,34L,63L,94L,127L,-79L,-56L,-31L,-4L,25L,56L,89L,124L,161L,-98L,-73L,-46L,-17L,14L,47L,82L,119L,158L,199L,-119L,-92L,-63L,-32L,1L,36L,73L,112L,153L,196L,241L,-142L,-113L,-82L,-49L,-14L,23L,62L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057105Inst : IEnumerable<long>
{
public static readonly long[] Value=A057105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057105.Bytes);
public long this[int i]=>Value[i];

public static A057105Inst Instance=new A057105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057106
{
public static readonly long[] Value={ 1L,2L,52L,6331L,6431L,7341L,7863L,426115L,453486L,1054067L,1054167L,1472746L,2017631L,42687015L,1050553507L,13175129925L,335038979077L,1400295262095L,5847307263801L,51722791547842L,78849864240621L,105802560494387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057106Inst : IEnumerable<long>
{
public static readonly long[] Value=A057106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057106.Bytes);
public long this[int i]=>Value[i];

public static A057106Inst Instance=new A057106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057107
{
public static readonly BigInteger[] Value={ 1L,8L,8008L,120232021L,124060421L,161656161L,185464581L,544721127445L,616947749616L,3333169613333L,3333802083333L,6506939396056L,12212500521221L,5466543663456645L,3310988011108890133L,BigInteger.Parse("520752145595541257025") };
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
public class A057107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057107Inst Instance=new A057107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057108
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,2L,3L,0L,0L,1L,0L,0L,0L,4L,0L,3L,0L,0L,0L,0L,0L,1L,5L,0L,6L,0L,0L,0L,0L,6L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,3L,7L,5L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,5L,0L,0L,0L,0L,1L,6L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,5L,0L,7L,0L,5L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057108Inst : IEnumerable<long>
{
public static readonly long[] Value=A057108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057108.Bytes);
public long this[int i]=>Value[i];

public static A057108Inst Instance=new A057108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057109
{
public static readonly long[] Value={ 4L,8L,9L,12L,16L,18L,24L,25L,27L,32L,36L,45L,48L,49L,50L,54L,64L,72L,75L,80L,81L,90L,96L,98L,100L,108L,121L,125L,128L,135L,144L,147L,150L,160L,162L,169L,175L,180L,189L,192L,196L,200L,216L,224L,225L,240L,242L,243L,245L,250L,256L,270L,288L,289L,294L,300L,320L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057109Inst : IEnumerable<long>
{
public static readonly long[] Value=A057109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057109.Bytes);
public long this[int i]=>Value[i];

public static A057109Inst Instance=new A057109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057110
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,4L,3L,0L,0L,0L,0L,0L,0L,10L,0L,3L,0L,0L,0L,0L,0L,4L,15L,0L,18L,0L,0L,0L,0L,24L,0L,0L,0L,3L,0L,0L,0L,3L,0L,0L,0L,0L,3L,0L,0L,10L,35L,15L,0L,0L,0L,18L,0L,1L,0L,0L,0L,0L,0L,0L,2L,56L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,15L,0L,0L,0L,0L,10L,72L,0L,0L,0L,0L,0L,0L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057110Inst : IEnumerable<long>
{
public static readonly long[] Value=A057110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057110.Bytes);
public long this[int i]=>Value[i];

public static A057110Inst Instance=new A057110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057111
{
public static readonly long[] Value={ 8L,9L,16L,18L,24L,25L,27L,32L,36L,40L,45L,48L,49L,50L,54L,56L,63L,64L,72L,75L,80L,81L,90L,96L,98L,100L,108L,112L,120L,121L,125L,126L,128L,135L,144L,147L,150L,160L,162L,168L,169L,175L,176L,180L,189L,192L,196L,200L,208L,216L,224L,225L,240L,242L,243L,245L,250L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057111Inst : IEnumerable<long>
{
public static readonly long[] Value=A057111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057111.Bytes);
public long this[int i]=>Value[i];

public static A057111Inst Instance=new A057111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057112
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,1L,3L,2L,3L,2L,3L,4L,1L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,1L,3L,2L,3L,2L,3L,4L,1L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,1L,3L,2L,3L,2L,3L,4L,1L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,1L,3L,2L,3L,2L,3L,4L,1L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,1L,3L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057112Inst : IEnumerable<long>
{
public static readonly long[] Value=A057112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057112.Bytes);
public long this[int i]=>Value[i];

public static A057112Inst Instance=new A057112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057113
{
public static readonly long[] Value={ 0L,1L,4L,5L,3L,2L,12L,13L,16L,22L,19L,18L,20L,10L,7L,6L,8L,14L,15L,9L,11L,21L,23L,17L,77L,76L,73L,72L,74L,75L,85L,84L,86L,80L,78L,79L,82L,92L,90L,91L,94L,88L,89L,95L,93L,83L,81L,87L,63L,62L,60L,61L,64L,65L,71L,70L,67L,53L,51L,50L,48L,54L,56L,57L,59L,69L,68L,58L,55L,49L,52L,66L,108L,109L,112L,113L,111L,110L,104L,105L,107L,117L,119L,118L,115L,101L,99L,98L,96L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057113Inst : IEnumerable<long>
{
public static readonly long[] Value=A057113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057113.Bytes);
public long this[int i]=>Value[i];

public static A057113Inst Instance=new A057113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057114
{
public static readonly long[] Value={ 3L,1L,7L,2L,6L,14L,15L,4L,5L,12L,13L,28L,29L,30L,31L,8L,9L,10L,11L,24L,25L,26L,27L,56L,57L,58L,59L,60L,61L,62L,63L,16L,17L,18L,19L,20L,21L,22L,23L,48L,49L,50L,51L,52L,53L,54L,55L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,96L,97L,98L,99L,100L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057114Inst : IEnumerable<long>
{
public static readonly long[] Value=A057114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057114.Bytes);
public long this[int i]=>Value[i];

public static A057114Inst Instance=new A057114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057115
{
public static readonly long[] Value={ 2L,4L,1L,8L,9L,5L,3L,16L,17L,18L,19L,10L,11L,6L,7L,32L,33L,34L,35L,36L,37L,38L,39L,20L,21L,22L,23L,12L,13L,14L,15L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,40L,41L,42L,43L,44L,45L,46L,47L,24L,25L,26L,27L,28L,29L,30L,31L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057115Inst : IEnumerable<long>
{
public static readonly long[] Value=A057115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057115.Bytes);
public long this[int i]=>Value[i];

public static A057115Inst Instance=new A057115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057116
{
public static readonly long[] Value={ 688L,12762L,149364L,263155L,1181565L,1677672L,2266852L,3410968L,7992868L,11253375L,12374428L,18227848L,37466244L,65726896L,68587492L,112129344L,112822564L,233965908L,251434872L,273026902L,592687408L,599873607L,907593975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057116Inst : IEnumerable<long>
{
public static readonly long[] Value=A057116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057116.Bytes);
public long this[int i]=>Value[i];

public static A057116Inst Instance=new A057116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057117
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,6L,9L,10L,12L,13L,11L,17L,18L,21L,22L,20L,14L,15L,16L,19L,23L,24L,26L,27L,25L,31L,32L,35L,36L,34L,28L,29L,30L,33L,45L,46L,49L,50L,48L,58L,59L,63L,64L,62L,54L,55L,57L,61L,37L,38L,40L,41L,39L,44L,47L,42L,43L,56L,60L,51L,52L,53L,65L,66L,68L,69L,67L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057117Inst : IEnumerable<long>
{
public static readonly long[] Value=A057117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057117.Bytes);
public long this[int i]=>Value[i];

public static A057117Inst Instance=new A057117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057118
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,6L,7L,9L,10L,13L,11L,12L,19L,20L,21L,14L,15L,22L,18L,16L,17L,23L,24L,27L,25L,26L,33L,34L,35L,28L,29L,36L,32L,30L,31L,51L,52L,55L,53L,54L,58L,59L,56L,37L,38L,57L,41L,39L,40L,62L,63L,64L,47L,48L,60L,49L,42L,43L,61L,50L,46L,44L,45L,65L,66L,69L,67L,68L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057118Inst : IEnumerable<long>
{
public static readonly long[] Value=A057118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057118.Bytes);
public long this[int i]=>Value[i];

public static A057118Inst Instance=new A057118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057119
{
public static readonly BigInteger[] Value={ 2L,10L,180L,47940L,3185189700L,13760582141553025860UL,BigInteger.Parse("254536428082497193743150874618461037380"),BigInteger.Parse("86730091025558229301371439971941296450524845723997443510460490068605668041540") };
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
public class A057119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057119Inst Instance=new A057119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057120
{
public static readonly BigInteger[] Value={ 1L,2L,12L,970L,21801077L,33006325301864331L,BigInteger.Parse("216010416087275256441802643730702446") };
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
public class A057120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057120Inst Instance=new A057120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057121
{
public static readonly BigInteger[] Value={ 0L,0L,3L,344L,8398380L,13286191841734681L,BigInteger.Parse("89262894246121771416347364297566757") };
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
public class A057121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057121Inst Instance=new A057121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057122
{
public static readonly long[] Value={ 0L,10L,180L,210L,2920L,2980L,3380L,3490L,3730L,46800L,46920L,47720L,47940L,48420L,54120L,54180L,55860L,56130L,56610L,59700L,59810L,60690L,62610L,748960L,749200L,750800L,751240L,752200L,763600L,763720L,767080L,767620L,768580L,774760L,774980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057122Inst : IEnumerable<long>
{
public static readonly long[] Value=A057122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057122.Bytes);
public long this[int i]=>Value[i];

public static A057122Inst Instance=new A057122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057123
{
public static readonly long[] Value={ 0L,2L,12L,16L,91L,99L,124L,140L,165L,868L,881L,944L,970L,1014L,1213L,1221L,1364L,1398L,1442L,1633L,1649L,1736L,1887L,9474L,9493L,9619L,9657L,9727L,10317L,10330L,10606L,10657L,10727L,11130L,11156L,11295L,11550L,13452L,13465L,13528L,13554L,13598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057123Inst : IEnumerable<long>
{
public static readonly long[] Value=A057123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057123.Bytes);
public long this[int i]=>Value[i];

public static A057123Inst Instance=new A057123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057124
{
public static readonly long[] Value={ 0L,0L,3L,7L,26L,34L,59L,75L,100L,242L,255L,318L,344L,388L,587L,595L,738L,772L,816L,1007L,1023L,1110L,1261L,2556L,2575L,2701L,2739L,2809L,3399L,3412L,3688L,3739L,3809L,4212L,4238L,4377L,4632L,6534L,6547L,6610L,6636L,6680L,8177L,8185L,8541L,8600L,8670L,9065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057124Inst : IEnumerable<long>
{
public static readonly long[] Value=A057124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057124.Bytes);
public long this[int i]=>Value[i];

public static A057124Inst Instance=new A057124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057125
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,13L,22L,23L,26L,33L,37L,39L,46L,47L,59L,61L,66L,69L,71L,73L,74L,78L,83L,94L,97L,107L,109L,111L,118L,121L,122L,131L,138L,141L,142L,143L,146L,157L,166L,167L,169L,177L,179L,181L,183L,191L,193L,194L,213L,214L,218L,219L,222L,227L,229L,239L,241L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057125Inst : IEnumerable<long>
{
public static readonly long[] Value=A057125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057125.Bytes);
public long this[int i]=>Value[i];

public static A057125Inst Instance=new A057125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057126
{
public static readonly long[] Value={ 1L,2L,7L,14L,17L,23L,31L,34L,41L,46L,47L,49L,62L,71L,73L,79L,82L,89L,94L,97L,98L,103L,113L,119L,127L,137L,142L,146L,151L,158L,161L,167L,178L,191L,193L,194L,199L,206L,217L,223L,226L,233L,238L,239L,241L,254L,257L,263L,271L,274L,281L,287L,289L,302L,311L,313L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057126Inst : IEnumerable<long>
{
public static readonly long[] Value=A057126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057126.Bytes);
public long this[int i]=>Value[i];

public static A057126Inst Instance=new A057126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057127
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,11L,17L,18L,19L,22L,27L,33L,34L,38L,41L,43L,51L,54L,57L,59L,66L,67L,73L,81L,82L,83L,86L,89L,97L,99L,102L,107L,113L,114L,118L,121L,123L,129L,131L,134L,137L,139L,146L,153L,162L,163L,166L,171L,177L,178L,179L,187L,193L,194L,198L,201L,209L,211L,214L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057127Inst : IEnumerable<long>
{
public static readonly long[] Value=A057127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057127.Bytes);
public long this[int i]=>Value[i];

public static A057127Inst Instance=new A057127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057128
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,12L,13L,14L,19L,21L,26L,28L,31L,37L,38L,39L,42L,43L,49L,52L,57L,61L,62L,67L,73L,74L,76L,78L,79L,84L,86L,91L,93L,97L,98L,103L,109L,111L,114L,122L,124L,127L,129L,133L,134L,139L,146L,147L,148L,151L,156L,157L,158L,163L,169L,172L,181L,182L,183L,186L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057128Inst : IEnumerable<long>
{
public static readonly long[] Value=A057128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057128.Bytes);
public long this[int i]=>Value[i];

public static A057128Inst Instance=new A057128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057129
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,13L,17L,20L,25L,26L,29L,34L,37L,40L,41L,50L,52L,53L,58L,61L,65L,68L,73L,74L,82L,85L,89L,97L,100L,101L,104L,106L,109L,113L,116L,122L,125L,130L,136L,137L,145L,146L,148L,149L,157L,164L,169L,170L,173L,178L,181L,185L,193L,194L,197L,200L,202L,205L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057129Inst : IEnumerable<long>
{
public static readonly long[] Value=A057129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057129.Bytes);
public long this[int i]=>Value[i];

public static A057129Inst Instance=new A057129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057130
{
public static readonly BigInteger[] Value={ 5L,55L,935L,21505L,623645L,25569445L,1201763915L,63693487495L,3757915762205L,266812019116555L,22145397586674065L,1970940385213991785L,BigInteger.Parse("199064978906613170285"),BigInteger.Parse("21299952743007609220495"),BigInteger.Parse("2406894659959859841915935"),BigInteger.Parse("315303200454741639290987485") };
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
public class A057130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057130Inst Instance=new A057130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057131
{
public static readonly BigInteger[] Value={ 29L,329L,5609L,129029L,3741869L,153416669L,7210583489L,382160924969L,22547494573229L,1600872114699329L,132872385520044389L,11825642311283950709UL,BigInteger.Parse("1194389873439679021709"),BigInteger.Parse("127799716458045655322969"),BigInteger.Parse("14441367959759159051495609"),BigInteger.Parse("1891819202728449835745924909") };
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
public class A057131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057131Inst Instance=new A057131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057132
{
public static readonly BigInteger[] Value={ 2L,2L,8L,32L,1088L,6385408L,3661265482403840L,BigInteger.Parse("8439542885406321273453577886433280"),BigInteger.Parse("319091956672498334572163381930897860393704528363200229220601489839357952") };
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
public class A057132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057132Inst Instance=new A057132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057133
{
public static readonly BigInteger[] Value={ 3L,18L,3645L,317831937966L,BigInteger.Parse("3695220735363494263609015164945808626"),BigInteger.Parse("121096725674945775281820931369251071805435386335925283528419283108512015348357219417301307065046229239236569208945") };
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
public class A057133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057133Inst Instance=new A057133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057134
{
public static readonly BigInteger[] Value={ 4L,128L,716353536L,BigInteger.Parse("14178431955039404875762272791942922240"),BigInteger.Parse("111731732749521642496450208318382051062328048504936611481207677617341443706047938314290688070835642649073892130179773602200265988880358130183392743915520") };
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
public class A057134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057134Inst Instance=new A057134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057135
{
public static readonly long[] Value={ 0L,1L,2L,3L,11L,22L,101L,111L,121L,202L,212L,1001L,1111L,2002L,10001L,10101L,10201L,11011L,11111L,11211L,20002L,20102L,100001L,101101L,110011L,111111L,200002L,1000001L,1001001L,1002001L,1010101L,1011101L,1012101L,1100011L,1101011L,1102011L,1110111L,1111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057135Inst : IEnumerable<long>
{
public static readonly long[] Value=A057135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057135.Bytes);
public long this[int i]=>Value[i];

public static A057135Inst Instance=new A057135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057136
{
public static readonly long[] Value={ 0L,1L,4L,9L,121L,484L,10201L,12321L,14641L,40804L,44944L,1002001L,1234321L,4008004L,100020001L,102030201L,104060401L,121242121L,123454321L,125686521L,400080004L,404090404L,10000200001L,10221412201L,12102420121L,12345654321L,40000800004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057136Inst : IEnumerable<long>
{
public static readonly long[] Value=A057136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057136.Bytes);
public long this[int i]=>Value[i];

public static A057136Inst Instance=new A057136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057137
{
public static readonly long[] Value={ 0L,1L,12L,123L,1234L,12345L,123456L,1234567L,12345678L,123456789L,1234567890L,12345678901L,123456789012L,1234567890123L,12345678901234L,123456789012345L,1234567890123456L,12345678901234567L,123456789012345678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057137Inst : IEnumerable<long>
{
public static readonly long[] Value=A057137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057137.Bytes);
public long this[int i]=>Value[i];

public static A057137Inst Instance=new A057137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057138
{
public static readonly long[] Value={ 0L,1L,21L,321L,4321L,54321L,654321L,7654321L,87654321L,987654321L,987654321L,10987654321L,210987654321L,3210987654321L,43210987654321L,543210987654321L,6543210987654321L,76543210987654321L,876543210987654321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057138Inst : IEnumerable<long>
{
public static readonly long[] Value=A057138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057138.Bytes);
public long this[int i]=>Value[i];

public static A057138Inst Instance=new A057138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057139
{
public static readonly BigInteger[] Value={ 1L,121L,12321L,1234321L,123454321L,12345654321L,1234567654321L,123456787654321L,12345678987654321L,1234567890987654321L,BigInteger.Parse("123456789010987654321"),BigInteger.Parse("12345678901210987654321") };
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
public class A057139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057139Inst Instance=new A057139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057140
{
public static readonly BigInteger[] Value={ 1L,4L,169L,3926427054L,BigInteger.Parse("15206669692893781237708064484944058"),BigInteger.Parse("166113478292106687629383993647806682871917942531896956843533578349271314189657277839057196220767581277199448858") };
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
public class A057140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057140Inst Instance=new A057140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057141
{
public static readonly BigInteger[] Value={ 1L,10L,11219012L,BigInteger.Parse("55384499824376217256962813110618112"),BigInteger.Parse("109113020263204729000439656560919971740554734868102159650138353883126645952577296311553839050398129021329284032263280840459408230233099699809693990912") };
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
public class A057141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A057141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A057141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A057141Inst Instance=new A057141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057142
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,16L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057142Inst : IEnumerable<long>
{
public static readonly long[] Value=A057142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057142.Bytes);
public long this[int i]=>Value[i];

public static A057142Inst Instance=new A057142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057143
{
public static readonly long[] Value={ 1L,2L,6L,4L,4L,12L,12L,24L,24L,40L,40L,24L,24L,24L,60L,60L,60L,36L,36L,60L,60L,60L,60L,120L,120L,120L,120L,168L,168L,120L,120L,120L,120L,120L,120L,180L,180L,180L,180L,120L,120L,120L,120L,120L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057143Inst : IEnumerable<long>
{
public static readonly long[] Value=A057143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057143.Bytes);
public long this[int i]=>Value[i];

public static A057143Inst Instance=new A057143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A057144
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,6L,6L,6L,6L,6L,6L,12L,12L,12L,12L,12L,12L,36L,36L,60L,60L,60L,60L,24L,24L,24L,24L,24L,24L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A057144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A057144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A057144Inst : IEnumerable<long>
{
public static readonly long[] Value=A057144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A057144.Bytes);
public long this[int i]=>Value[i];

public static A057144Inst Instance=new A057144Inst();

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