using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A240825
{
public static readonly long[] Value={ 7L,0L,14L,163L,30L,21L,0L,0L,72L,28L,57L,30L,35L,36L,29L,2350L,25L,0L,29L,55L,42L,277L,51L,47L,45L,35L,56L,41L,1301L,0L,35L,0L,38L,69L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240825Inst : IEnumerable<long>
{
public static readonly long[] Value=A240825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240825.Bytes);
public long this[int i]=>Value[i];

public static A240825Inst Instance=new A240825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240826
{
public static readonly long[] Value={ 0L,35L,969L,7770L,35990L,121485L,333375L,790244L,1679580L,3280455L,5989445L,10349790L,17083794L,27128465L,41674395L,62207880L,90556280L,128936619L,180007425L,246923810L,333395790L,443749845L,582993719L,756884460L,971999700L,1235812175L,1556767485L,1944365094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240826Inst : IEnumerable<long>
{
public static readonly long[] Value=A240826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240826.Bytes);
public long this[int i]=>Value[i];

public static A240826Inst Instance=new A240826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240827
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,9L,9L,7L,8L,9L,10L,11L,12L,15L,15L,15L,13L,14L,15L,18L,18L,18L,18L,18L,18L,14L,16L,18L,25L,26L,24L,23L,22L,24L,20L,24L,24L,29L,28L,30L,29L,29L,27L,30L,28L,30L,27L,33L,33L,36L,32L,33L,27L,36L,36L,43L,36L,36L,38L,36L,36L,33L,32L,36L,39L,50L,48L,45L,39L,42L,37L,40L,42L,49L,44L,48L,48L,53L,48L,47L,42L,48L,44L,53L,48L,57L,52L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240827Inst : IEnumerable<long>
{
public static readonly long[] Value=A240827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240827.Bytes);
public long this[int i]=>Value[i];

public static A240827Inst Instance=new A240827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240828
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,2L,6L,4L,8L,4L,10L,6L,12L,6L,14L,8L,16L,8L,18L,10L,20L,10L,22L,12L,24L,12L,26L,14L,28L,14L,30L,16L,32L,16L,34L,18L,36L,18L,38L,20L,40L,20L,42L,22L,44L,22L,46L,24L,48L,24L,50L,26L,52L,26L,54L,28L,56L,28L,58L,30L,60L,30L,62L,32L,64L,32L,66L,34L,68L,34L,70L,36L,72L,36L,74L,38L,76L,38L,78L,40L,80L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240828Inst : IEnumerable<long>
{
public static readonly long[] Value=A240828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240828.Bytes);
public long this[int i]=>Value[i];

public static A240828Inst Instance=new A240828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240829
{
public static readonly long[] Value={ -1L,0L,1L,3L,2L,4L,4L,7L,4L,7L,7L,9L,8L,9L,11L,10L,10L,13L,15L,13L,13L,13L,18L,15L,18L,18L,18L,18L,18L,23L,23L,20L,19L,23L,28L,27L,23L,25L,27L,28L,25L,26L,28L,30L,31L,32L,33L,33L,32L,34L,33L,38L,36L,39L,34L,36L,36L,39L,39L,39L,39L,44L,46L,46L,43L,46L,46L,44L,44L,49L,49L,49L,46L,51L,48L,51L,51L,54L,54L,54L,54L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240829Inst : IEnumerable<long>
{
public static readonly long[] Value=A240829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240829.Bytes);
public long this[int i]=>Value[i];

public static A240829Inst Instance=new A240829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240830
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,7L,7L,7L,7L,7L,7L,7L,13L,13L,13L,13L,13L,13L,19L,13L,19L,19L,19L,19L,25L,19L,25L,19L,25L,25L,31L,25L,31L,25L,31L,25L,31L,31L,37L,31L,37L,31L,37L,37L,37L,37L,43L,37L,43L,43L,43L,43L,43L,43L,49L,49L,49L,49L,49L,49L,49L,55L,55L,55L,55L,55L,55L,61L,55L,61L,61L,61L,61L,67L,61L,67L,61L,67L,67L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240830Inst : IEnumerable<long>
{
public static readonly long[] Value=A240830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240830.Bytes);
public long this[int i]=>Value[i];

public static A240830Inst Instance=new A240830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240831
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,7L,1L,7L,1L,1L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,7L,7L,1L,7L,1L,7L,7L,7L,7L,7L,1L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,13L,7L,7L,7L,7L,7L,13L,7L,13L,7L,7L,7L,13L,7L,13L,7L,13L,7L,13L,7L,13L,7L,13L,7L,19L,7L,13L,7L,13L,7L,19L,7L,19L,7L,13L,7L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240831Inst : IEnumerable<long>
{
public static readonly long[] Value=A240831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240831.Bytes);
public long this[int i]=>Value[i];

public static A240831Inst Instance=new A240831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240864
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,2L,1L,2L,2L,3L,3L,4L,5L,6L,8L,8L,11L,10L,17L,15L,23L,19L,32L,26L,42L,35L,57L,49L,73L,66L,95L,90L,119L,121L,153L,161L,191L,214L,239L,280L,298L,365L,373L,470L,462L,603L,576L,763L,714L,963L,889L,1205L,1102L,1502L,1371L,1857L,1696L,2289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240864Inst : IEnumerable<long>
{
public static readonly long[] Value=A240864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240864.Bytes);
public long this[int i]=>Value[i];

public static A240864Inst Instance=new A240864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240865
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,2L,2L,3L,4L,6L,7L,8L,10L,12L,17L,16L,23L,23L,35L,32L,49L,45L,68L,62L,92L,85L,125L,119L,164L,159L,216L,216L,281L,288L,364L,384L,468L,502L,600L,660L,763L,852L,969L,1101L,1227L,1407L,1544L,1793L,1941L,2262L,2433L,2853L,3038L,3567L,3787L,4448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240865Inst : IEnumerable<long>
{
public static readonly long[] Value=A240865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240865.Bytes);
public long this[int i]=>Value[i];

public static A240865Inst Instance=new A240865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240866
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,2L,1L,3L,2L,4L,3L,5L,6L,6L,8L,8L,13L,10L,18L,14L,26L,19L,34L,26L,47L,37L,59L,50L,77L,70L,98L,95L,125L,129L,157L,171L,198L,230L,247L,299L,310L,391L,388L,503L,483L,647L,604L,816L,754L,1034L,939L,1291L,1172L,1610L,1458L,1989L,1813L,2454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240866Inst : IEnumerable<long>
{
public static readonly long[] Value=A240866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240866.Bytes);
public long this[int i]=>Value[i];

public static A240866Inst Instance=new A240866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240867
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,1L,3L,2L,5L,2L,7L,4L,12L,5L,16L,8L,23L,11L,32L,17L,43L,25L,56L,36L,73L,51L,93L,74L,118L,102L,150L,140L,188L,191L,236L,255L,294L,337L,369L,442L,458L,570L,574L,732L,716L,930L,894L,1174L,1113L,1467L,1389L,1830L,1727L,2259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240867Inst : IEnumerable<long>
{
public static readonly long[] Value=A240867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240867.Bytes);
public long this[int i]=>Value[i];

public static A240867Inst Instance=new A240867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240868
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,7L,8L,10L,10L,16L,15L,23L,19L,32L,27L,44L,36L,60L,50L,80L,67L,103L,92L,137L,124L,174L,167L,224L,221L,284L,292L,362L,382L,453L,497L,574L,641L,715L,821L,897L,1046L,1117L,1323L,1396L,1664L,1729L,2082L,2151L,2591L,2660L,3213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240868Inst : IEnumerable<long>
{
public static readonly long[] Value=A240868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240868.Bytes);
public long this[int i]=>Value[i];

public static A240868Inst Instance=new A240868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240869
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,3L,3L,5L,5L,7L,8L,11L,12L,15L,18L,22L,27L,31L,37L,43L,52L,59L,71L,82L,97L,110L,128L,148L,173L,197L,225L,260L,298L,339L,386L,442L,502L,570L,644L,733L,829L,935L,1052L,1190L,1339L,1504L,1687L,1897L,2128L,2380L,2659L,2976L,3325L,3704L,4127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240869Inst : IEnumerable<long>
{
public static readonly long[] Value=A240869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240869.Bytes);
public long this[int i]=>Value[i];

public static A240869Inst Instance=new A240869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240870
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,5L,5L,7L,7L,11L,11L,15L,16L,22L,23L,31L,32L,42L,45L,58L,62L,79L,84L,106L,114L,140L,151L,187L,201L,244L,265L,319L,346L,413L,449L,533L,580L,683L,744L,873L,951L,1106L,1209L,1400L,1529L,1764L,1927L,2212L,2418L,2763L,3021L,3442L,3763L,4270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240870Inst : IEnumerable<long>
{
public static readonly long[] Value=A240870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240870.Bytes);
public long this[int i]=>Value[i];

public static A240870Inst Instance=new A240870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240871
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,2L,2L,0L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,0L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,0L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,0L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,0L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,0L,2L,2L,1L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240871Inst : IEnumerable<long>
{
public static readonly long[] Value=A240871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240871.Bytes);
public long this[int i]=>Value[i];

public static A240871Inst Instance=new A240871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240872
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,2L,1L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,4L,2L,2L,2L,3L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,3L,2L,2L,2L,4L,2L,2L,2L,3L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,3L,2L,2L,2L,4L,2L,2L,2L,3L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,3L,2L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240872Inst : IEnumerable<long>
{
public static readonly long[] Value=A240872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240872.Bytes);
public long this[int i]=>Value[i];

public static A240872Inst Instance=new A240872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240873
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,1L,2L,3L,3L,3L,4L,4L,4L,5L,4L,3L,6L,4L,4L,5L,3L,4L,6L,4L,4L,4L,4L,4L,6L,4L,3L,5L,4L,4L,6L,3L,4L,5L,4L,4L,5L,4L,4L,5L,4L,3L,6L,4L,4L,5L,3L,4L,6L,4L,4L,4L,4L,4L,6L,4L,3L,5L,4L,4L,6L,3L,4L,5L,4L,4L,5L,4L,4L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240873Inst : IEnumerable<long>
{
public static readonly long[] Value=A240873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240873.Bytes);
public long this[int i]=>Value[i];

public static A240873Inst Instance=new A240873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240874
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,5L,4L,5L,6L,6L,7L,7L,7L,8L,9L,10L,10L,11L,11L,12L,14L,14L,15L,17L,17L,18L,19L,20L,23L,24L,25L,26L,28L,29L,31L,34L,35L,37L,40L,42L,44L,46L,48L,51L,55L,58L,61L,64L,67L,70L,75L,77L,82L,87L,90L,96L,101L,105L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240874Inst : IEnumerable<long>
{
public static readonly long[] Value=A240874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240874.Bytes);
public long this[int i]=>Value[i];

public static A240874Inst Instance=new A240874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240875
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,3L,4L,4L,8L,8L,11L,16L,20L,20L,32L,32L,44L,53L,66L,68L,89L,105L,127L,146L,172L,179L,253L,269L,306L,352L,403L,481L,577L,616L,694L,793L,965L,1028L,1243L,1334L,1482L,1811L,2008L,2143L,2468L,2765L,3208L,3629L,4021L,4311L,4905L,5493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240875Inst : IEnumerable<long>
{
public static readonly long[] Value=A240875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240875.Bytes);
public long this[int i]=>Value[i];

public static A240875Inst Instance=new A240875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240876
{
public static readonly long[] Value={ 1L,23L,265L,2047L,11969L,56695L,227305L,795455L,2485825L,7059735L,18474633L,45046719L,103274625L,224298231L,464387817L,921406335L,1759885185L,3248227095L,5812626185L,10113604735L,17152640321L,28418229623L,46082942185L,73265596607L,114375683009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240876Inst : IEnumerable<long>
{
public static readonly long[] Value=A240876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240876.Bytes);
public long this[int i]=>Value[i];

public static A240876Inst Instance=new A240876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240877
{
public static readonly long[] Value={ 1L,2L,4L,10L,18L,38L,50L,92L,124L,178L,218L,328L,376L,532L,616L,736L,864L,1136L,1244L,1586L,1746L,1998L,2218L,2724L,2916L,3416L,3728L,4214L,4550L,5362L,5602L,6532L,7044L,7704L,8248L,9088L,9520L,10852L,11536L,12472L,13112L,14752L,15256L,17062L,17942L,19022L,20034L,22196L,22964L,25022L,26022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240877Inst : IEnumerable<long>
{
public static readonly long[] Value=A240877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240877.Bytes);
public long this[int i]=>Value[i];

public static A240877Inst Instance=new A240877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240878
{
public static readonly long[] Value={ 2L,7L,11L,17L,29L,35L,37L,43L,53L,55L,65L,73L,79L,83L,97L,115L,119L,125L,133L,137L,155L,161L,169L,187L,191L,205L,209L,233L,251L,263L,269L,271L,277L,281L,287L,295L,335L,343L,359L,361L,379L,385L,389L,395L,407L,413L,425L,433L,451L,461L,475L,479L,493L,505L,511L,521L,529L,541L,559L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240878Inst : IEnumerable<long>
{
public static readonly long[] Value=A240878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240878.Bytes);
public long this[int i]=>Value[i];

public static A240878Inst Instance=new A240878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240879
{
public static readonly long[] Value={ 1L,6L,31L,150L,699L,3178L,14198L,62604L,273235L,1182786L,5085666L,21743956L,92522206L,392066340L,1655432524L,6967724312L,29245179267L,122442487474L,511487386730L,2132341655556L,8873167793578L,36861311739308L,152895342950196L,633290273209000L,2619653638855214L,10823294835350388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240879Inst : IEnumerable<long>
{
public static readonly long[] Value=A240879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240879.Bytes);
public long this[int i]=>Value[i];

public static A240879Inst Instance=new A240879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240928
{
public static readonly long[] Value={ 35L,750L,6174L,31025L,114961L,346193L,896876L,2072694L,4379055L,8606312L,15936426L,28073487L,47400509L,77164915L,121695128L,186650684L,279308283L,408886194L,586909430L,827618109L,1148421417L,1570399589L,2118856324L,2823924050L,3721224455L,4852586700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240928Inst : IEnumerable<long>
{
public static readonly long[] Value=A240928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240928.Bytes);
public long this[int i]=>Value[i];

public static A240928Inst Instance=new A240928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240929
{
public static readonly long[] Value={ 126L,6046L,88428L,694360L,3705741L,15192604L,51418473L,150420187L,392406145L,933294637L,2056947827L,4253047045L,8329101326L,15566783605L,27934647638L,48371293570L,81155221112L,132379936520L,210555362990L,327359243694L,498565022483L,745175639274L,1094795785319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240929Inst : IEnumerable<long>
{
public static readonly long[] Value=A240929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240929.Bytes);
public long this[int i]=>Value[i];

public static A240929Inst Instance=new A240929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240930
{
public static readonly long[] Value={ 0L,0L,64L,1458L,12288L,62500L,233280L,705894L,1835008L,4251528L,9000000L,17715610L,32845824L,57921708L,97883968L,159468750L,251658240L,386201104L,578207808L,846825858L,1216000000L,1715322420L,2380977984L,3256789558L,4395368448L,5859375000L,7722894400L,10072932714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240930Inst : IEnumerable<long>
{
public static readonly long[] Value=A240930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240930.Bytes);
public long this[int i]=>Value[i];

public static A240930Inst Instance=new A240930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240931
{
public static readonly long[] Value={ 0L,0L,128L,4374L,49152L,312500L,1399680L,4941258L,14680064L,38263752L,90000000L,194871710L,394149888L,752982204L,1370375552L,2392031250L,4026531840L,6565418768L,10407740544L,16089691302L,24320000000L,36021770820L,52381515648L,74906159834L,105488842752L,146484375000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240931Inst : IEnumerable<long>
{
public static readonly long[] Value=A240931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240931.Bytes);
public long this[int i]=>Value[i];

public static A240931Inst Instance=new A240931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240932
{
public static readonly long[] Value={ 0L,0L,256L,13122L,196608L,1562500L,8398080L,34588806L,117440512L,344373768L,900000000L,2143588810L,4729798656L,9788768652L,19185257728L,35880468750L,64424509440L,111612119056L,187339329792L,305704134738L,486400000000L,756457187220L,1152393344256L,1722841676182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240932Inst : IEnumerable<long>
{
public static readonly long[] Value=A240932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240932.Bytes);
public long this[int i]=>Value[i];

public static A240932Inst Instance=new A240932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240933
{
public static readonly long[] Value={ 0L,0L,512L,39366L,786432L,7812500L,50388480L,242121642L,939524096L,3099363912L,9000000000L,23579476910L,56757583872L,127253992476L,268593608192L,538207031250L,1030792151040L,1897406023952L,3372107936256L,5808378560022L,9728000000000L,15885600931620L,25352653573632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240933Inst : IEnumerable<long>
{
public static readonly long[] Value=A240933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240933.Bytes);
public long this[int i]=>Value[i];

public static A240933Inst Instance=new A240933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240934
{
public static readonly long[] Value={ 120L,7196L,162554L,1341957L,9255603L,40532530L,168302117L,523421602L,1637895896L,4129547423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240934Inst : IEnumerable<long>
{
public static readonly long[] Value=A240934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240934.Bytes);
public long this[int i]=>Value[i];

public static A240934Inst Instance=new A240934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240935
{
public static readonly long[] Value={ 4L,1L,3L,4L,9L,6L,6L,7L,1L,5L,6L,6L,3L,4L,4L,0L,3L,7L,1L,3L,3L,4L,9L,4L,8L,7L,3L,7L,3L,4L,7L,2L,7L,0L,8L,1L,0L,4L,8L,0L,3L,9L,8L,6L,0L,2L,7L,4L,9L,8L,0L,4L,8L,9L,5L,9L,9L,5L,2L,4L,5L,1L,5L,2L,1L,8L,2L,7L,2L,7L,2L,7L,6L,0L,1L,9L,5L,2L,3L,4L,6L,1L,3L,0L,2L,8L,5L,0L,2L,1L,6L,1L,7L,3L,7L,8L,1L,6L,6L,9L,0L,5L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240935Inst : IEnumerable<long>
{
public static readonly long[] Value=A240935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240935.Bytes);
public long this[int i]=>Value[i];

public static A240935Inst Instance=new A240935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240936
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,337L,11985L,930241L,155643329L,55638770689L,42200814258433L,67536939792143361L,BigInteger.Parse("227017234854393949185"),BigInteger.Parse("1596674435594864988020737"),BigInteger.Parse("23421099407847007850007154689"),BigInteger.Parse("714530983411175509576743561314305"),BigInteger.Parse("45227689798343820164634911814524846081") };
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
public class A240936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240936Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240936.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240936.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240936Inst Instance=new A240936Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240937
{
public static readonly long[] Value={ 0L,6L,2L,3L,5L,9L,792L,2555L,10368L,23464L,84888L,1047087L,2483200L,54721675L,228537856L,1394007616L,5090444477L,51286309703L,608427634303L,3260058995493L,11314112766137L,51848285189219L,1034026438223449L,11075640379838488L,181108172062981288L,1566869630866485093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240937Inst : IEnumerable<long>
{
public static readonly long[] Value=A240937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240937.Bytes);
public long this[int i]=>Value[i];

public static A240937Inst Instance=new A240937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240938
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,10L,14L,15L,21L,22L,25L,26L,30L,33L,34L,35L,36L,38L,39L,42L,46L,49L,51L,55L,57L,58L,60L,62L,65L,66L,69L,70L,74L,77L,78L,82L,84L,85L,86L,87L,90L,91L,93L,94L,95L,100L,102L,105L,106L,110L,111L,114L,115L,118L,119L,120L,121L,122L,123L,126L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240938Inst : IEnumerable<long>
{
public static readonly long[] Value=A240938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240938.Bytes);
public long this[int i]=>Value[i];

public static A240938Inst Instance=new A240938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240939
{
public static readonly long[] Value={ 0L,2L,2L,1L,1L,9L,1L,81L,729L,225L,324L,39169L,82944L,176400L,215296L,3444736L,26167684L,114349225L,255004929L,1158920361L,11638526761L,42128246889L,191052974116L,97216010329L,2430400258225L,1553580508516L,4666092737476L,565986718738441L,2137864362693921L,5112360635841936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240939Inst : IEnumerable<long>
{
public static readonly long[] Value=A240939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240939.Bytes);
public long this[int i]=>Value[i];

public static A240939Inst Instance=new A240939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240940
{
public static readonly long[] Value={ 0L,1L,2L,8L,20L,44L,127L,320L,476L,3584L,12311L,4604L,74879L,414119L,2071775L,5703551L,11551671L,45680444L,442548224L,1960632176L,2657058876L,24923993276L,130518272975L,1478154932316L,5446454455004L,38610655379975L,204033398880671L,538347188396016L,3809155729331900L,27460809907547975L,52607402757814775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240940Inst : IEnumerable<long>
{
public static readonly long[] Value=A240940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240940.Bytes);
public long this[int i]=>Value[i];

public static A240940Inst Instance=new A240940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240941
{
public static readonly long[] Value={ 1L,3L,15L,75L,6308237L,871506915L,2465425275L,2937864075L,2948967789L,83313712623L,195392257275L,11126651718075L,45237726869109L,2920008144904215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240941Inst : IEnumerable<long>
{
public static readonly long[] Value=A240941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240941.Bytes);
public long this[int i]=>Value[i];

public static A240941Inst Instance=new A240941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240942
{
public static readonly long[] Value={ 1L,11L,121L,323L,117283L,432091L,4132384531L,15516834659L,15941429747L,98953554491L,3272831195051L,7362974489179L,26306805687881L,33869035218491L,280980898827691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240942Inst : IEnumerable<long>
{
public static readonly long[] Value=A240942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240942.Bytes);
public long this[int i]=>Value[i];

public static A240942Inst Instance=new A240942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240943
{
public static readonly long[] Value={ 4L,0L,2L,6L,9L,7L,5L,0L,3L,6L,7L,1L,4L,4L,1L,2L,9L,0L,9L,6L,9L,0L,4L,5L,3L,4L,8L,6L,5L,1L,0L,8L,3L,8L,0L,3L,4L,1L,7L,5L,5L,6L,7L,2L,1L,6L,2L,4L,9L,7L,2L,6L,5L,9L,2L,9L,1L,0L,5L,3L,4L,6L,4L,6L,0L,7L,6L,4L,2L,7L,2L,8L,9L,6L,6L,5L,2L,4L,2L,5L,8L,4L,1L,6L,4L,1L,6L,0L,9L,6L,0L,2L,6L,2L,1L,7L,2L,0L,5L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240943Inst : IEnumerable<long>
{
public static readonly long[] Value=A240943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240943.Bytes);
public long this[int i]=>Value[i];

public static A240943Inst Instance=new A240943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240960
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,15L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240960Inst : IEnumerable<long>
{
public static readonly long[] Value=A240960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240960.Bytes);
public long this[int i]=>Value[i];

public static A240960Inst Instance=new A240960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240961
{
public static readonly long[] Value={ 2L,7L,9L,2L,2L,9L,2L,5L,0L,9L,2L,7L,7L,4L,5L,1L,8L,9L,2L,2L,8L,4L,0L,9L,8L,8L,0L,4L,5L,1L,9L,5L,5L,3L,5L,9L,2L,8L,3L,4L,9L,2L,6L,3L,7L,4L,0L,5L,5L,6L,1L,2L,9L,3L,5L,9L,4L,7L,2L,7L,0L,0L,9L,3L,7L,1L,3L,2L,7L,3L,1L,9L,2L,9L,1L,9L,9L,6L,3L,0L,5L,0L,7L,8L,8L,1L,6L,8L,2L,2L,5L,7L,8L,1L,9L,3L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240961Inst : IEnumerable<long>
{
public static readonly long[] Value=A240961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240961.Bytes);
public long this[int i]=>Value[i];

public static A240961Inst Instance=new A240961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240962
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,10L,1L,2L,2L,3L,2L,2L,1L,2L,1L,21L,1L,0L,5L,2L,3L,6L,3L,1L,1L,32L,6L,5L,7L,7L,3L,3L,6L,8L,6L,42L,5L,6L,10L,10L,5L,11L,4L,12L,11L,53L,5L,6L,12L,10L,8L,11L,15L,9L,5L,64L,12L,15L,14L,16L,13L,12L,13L,9L,16L,79L,12L,16L,15L,12L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240962Inst : IEnumerable<long>
{
public static readonly long[] Value=A240962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240962.Bytes);
public long this[int i]=>Value[i];

public static A240962Inst Instance=new A240962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240963
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240963Inst : IEnumerable<long>
{
public static readonly long[] Value=A240963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240963.Bytes);
public long this[int i]=>Value[i];

public static A240963Inst Instance=new A240963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240964
{
public static readonly long[] Value={ 0L,9L,4L,5L,7L,3L,0L,1L,9L,6L,6L,4L,7L,6L,1L,9L,3L,9L,5L,1L,3L,5L,8L,8L,9L,0L,0L,8L,5L,4L,4L,1L,3L,8L,4L,9L,3L,1L,4L,9L,5L,5L,3L,2L,9L,3L,1L,9L,2L,2L,4L,0L,1L,0L,4L,9L,7L,9L,5L,1L,5L,3L,1L,9L,5L,5L,5L,9L,2L,1L,0L,2L,7L,5L,4L,7L,6L,6L,3L,1L,1L,2L,8L,9L,7L,7L,4L,0L,1L,4L,8L,4L,9L,0L,9L,9L,6L,5L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240964Inst : IEnumerable<long>
{
public static readonly long[] Value=A240964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240964.Bytes);
public long this[int i]=>Value[i];

public static A240964Inst Instance=new A240964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240965
{
public static readonly long[] Value={ 2L,3L,6L,3L,4L,0L,9L,0L,0L,1L,6L,1L,5L,4L,2L,3L,1L,5L,3L,6L,6L,3L,2L,6L,7L,4L,5L,6L,6L,8L,6L,5L,1L,6L,4L,1L,7L,4L,8L,4L,1L,3L,9L,5L,1L,5L,8L,8L,6L,1L,3L,9L,3L,2L,8L,8L,5L,2L,9L,0L,5L,2L,6L,8L,0L,3L,8L,1L,9L,4L,8L,7L,8L,2L,6L,2L,0L,5L,9L,5L,9L,1L,2L,0L,8L,1L,5L,2L,0L,7L,9L,6L,6L,3L,0L,5L,8L,8L,1L,1L,6L,7L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240965Inst : IEnumerable<long>
{
public static readonly long[] Value=A240965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240965.Bytes);
public long this[int i]=>Value[i];

public static A240965Inst Instance=new A240965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240966
{
public static readonly long[] Value={ 0L,3L,0L,4L,4L,8L,4L,5L,7L,0L,5L,8L,3L,9L,3L,2L,7L,0L,7L,8L,0L,2L,5L,1L,5L,3L,0L,4L,7L,1L,1L,5L,4L,7L,7L,6L,6L,4L,7L,0L,0L,0L,4L,8L,3L,5L,4L,4L,9L,7L,3L,9L,3L,6L,2L,5L,2L,9L,7L,1L,8L,8L,9L,8L,5L,9L,0L,3L,7L,8L,1L,7L,9L,4L,4L,9L,3L,6L,8L,9L,8L,6L,7L,7L,7L,9L,4L,5L,8L,4L,8L,8L,0L,8L,7L,4L,4L,9L,5L,9L,7L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240966Inst : IEnumerable<long>
{
public static readonly long[] Value=A240966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240966.Bytes);
public long this[int i]=>Value[i];

public static A240966Inst Instance=new A240966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240967
{
public static readonly long[] Value={ 248L,418L,681L,733L,871L,1288L,1448L,1828L,2188L,2248L,2428L,2614L,2622L,2641L,2818L,3414L,3422L,3441L,3773L,4148L,4228L,4314L,4322L,4341L,4418L,4891L,4981L,6214L,6222L,6241L,6681L,6861L,7373L,7733L,7881L,8128L,8218L,8491L,8661L,8781L,8871L,8941L,9481L,9841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240967Inst : IEnumerable<long>
{
public static readonly long[] Value=A240967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240967.Bytes);
public long this[int i]=>Value[i];

public static A240967Inst Instance=new A240967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240968
{
public static readonly long[] Value={ 5L,8L,10L,41L,206L,1066L,2412L,3281L,8086L,11570L,29525L,57012L,73728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240968Inst : IEnumerable<long>
{
public static readonly long[] Value=A240968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240968.Bytes);
public long this[int i]=>Value[i];

public static A240968Inst Instance=new A240968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240969
{
public static readonly long[] Value={ 4L,3L,8L,9L,2L,5L,3L,6L,9L,2L,5L,9L,4L,6L,6L,4L,5L,6L,7L,4L,0L,8L,8L,5L,2L,6L,1L,1L,5L,8L,5L,2L,3L,7L,7L,4L,2L,1L,9L,1L,4L,9L,3L,8L,6L,5L,1L,4L,3L,8L,8L,7L,2L,6L,8L,3L,0L,1L,0L,7L,5L,9L,7L,5L,2L,9L,2L,6L,0L,4L,4L,2L,0L,4L,9L,2L,6L,6L,8L,7L,2L,4L,6L,0L,3L,3L,0L,0L,4L,1L,3L,7L,5L,7L,9L,1L,4L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240969Inst : IEnumerable<long>
{
public static readonly long[] Value=A240969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240969.Bytes);
public long this[int i]=>Value[i];

public static A240969Inst Instance=new A240969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240970
{
public static readonly long[] Value={ 1L,3L,4L,20L,25L,49L,64L,99L,125L,153L,288L,343L,512L,1000L,1331L,1849L,2197L,2744L,4096L,4913L,6591L,6859L,8000L,10200L,10648L,12167L,13923L,14161L,15625L,17576L,19220L,21456L,21952L,24389L,25201L,29791L,32768L,33124L,39304L,42875L,49776L,50653L,54872L,63001L,64000L,68921L,79507L,85184L,97336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240970Inst : IEnumerable<long>
{
public static readonly long[] Value=A240970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240970.Bytes);
public long this[int i]=>Value[i];

public static A240970Inst Instance=new A240970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240971
{
public static readonly long[] Value={ 7L,13L,19L,31L,43L,73L,97L,103L,127L,157L,199L,223L,241L,271L,409L,421L,661L,673L,727L,859L,883L,937L,1021L,1039L,1051L,1063L,1093L,1447L,1483L,1609L,1657L,1669L,1723L,1753L,1861L,1879L,1993L,2029L,2203L,2437L,2539L,2677L,2719L,2803L,2833L,2953L,3079L,3121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240971Inst : IEnumerable<long>
{
public static readonly long[] Value=A240971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240971.Bytes);
public long this[int i]=>Value[i];

public static A240971Inst Instance=new A240971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240972
{
public static readonly long[] Value={ 1L,6L,10L,28L,72L,352L,240L,832L,672L,2432L,17408L,12800L,47104L,55296L,41984L,126976L,950272L,2162688L,2424832L,3211264L,18350080L,5111808L,90177536L,377487360L,55574528L,394264576L,247463936L,3422552064L,578813952L,14763950080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240972Inst : IEnumerable<long>
{
public static readonly long[] Value=A240972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240972.Bytes);
public long this[int i]=>Value[i];

public static A240972Inst Instance=new A240972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240973
{
public static readonly long[] Value={ 2L,4L,14L,120L,3222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240973Inst : IEnumerable<long>
{
public static readonly long[] Value=A240973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240973.Bytes);
public long this[int i]=>Value[i];

public static A240973Inst Instance=new A240973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240974
{
public static readonly long[] Value={ 0L,2L,3L,8L,15L,18L,22L,24L,35L,48L,52L,63L,69L,80L,99L,110L,114L,120L,143L,168L,195L,198L,224L,228L,240L,255L,288L,322L,323L,360L,399L,440L,483L,488L,494L,528L,575L,605L,624L,675L,702L,711L,728L,783L,840L,899L,960L,970L,1004L,1023L,1088L,1155L,1224L,1272L,1295L,1298L,1368L,1443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240974Inst : IEnumerable<long>
{
public static readonly long[] Value=A240974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240974.Bytes);
public long this[int i]=>Value[i];

public static A240974Inst Instance=new A240974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240975
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,4L,2L,2L,3L,2L,3L,3L,4L,2L,4L,3L,3L,2L,4L,3L,4L,3L,2L,3L,4L,4L,4L,2L,4L,3L,3L,3L,4L,3L,4L,4L,4L,3L,4L,2L,4L,3L,4L,2L,4L,4L,3L,4L,3L,3L,5L,2L,4L,4L,3L,3L,5L,3L,3L,3L,4L,3L,3L,4L,3L,3L,3L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240975Inst : IEnumerable<long>
{
public static readonly long[] Value=A240975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240975.Bytes);
public long this[int i]=>Value[i];

public static A240975Inst Instance=new A240975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241008
{
public static readonly long[] Value={ 3L,5L,7L,10L,11L,13L,14L,17L,19L,21L,22L,23L,26L,27L,29L,31L,33L,34L,37L,38L,39L,41L,43L,44L,46L,47L,51L,52L,53L,55L,57L,58L,59L,61L,62L,65L,67L,68L,69L,71L,73L,74L,76L,79L,82L,83L,85L,86L,87L,89L,92L,93L,94L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241008Inst : IEnumerable<long>
{
public static readonly long[] Value=A241008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241008.Bytes);
public long this[int i]=>Value[i];

public static A241008Inst Instance=new A241008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241009
{
public static readonly long[] Value={ 1L,7L,7L,1L,0L,1L,1L,9L,6L,0L,9L,5L,6L,0L,9L,3L,9L,4L,2L,8L,7L,3L,9L,8L,0L,2L,3L,3L,5L,3L,6L,0L,5L,2L,9L,0L,8L,0L,1L,6L,6L,5L,0L,3L,9L,4L,5L,6L,8L,7L,2L,0L,8L,6L,1L,0L,2L,2L,8L,7L,0L,9L,0L,5L,2L,9L,5L,5L,9L,1L,1L,1L,1L,9L,4L,7L,4L,4L,5L,7L,9L,0L,6L,2L,0L,1L,6L,5L,2L,5L,1L,5L,4L,2L,4L,6L,4L,0L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241009Inst : IEnumerable<long>
{
public static readonly long[] Value=A241009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241009.Bytes);
public long this[int i]=>Value[i];

public static A241009Inst Instance=new A241009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241010
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,16L,25L,32L,49L,50L,64L,81L,98L,121L,128L,169L,242L,256L,289L,338L,361L,484L,512L,529L,578L,625L,676L,722L,729L,841L,961L,1024L,1058L,1156L,1250L,1369L,1444L,1681L,1682L,1849L,1922L,2048L,2116L,2209L,2312L,2401L,2738L,2809L,2888L,3025L,3249L,3362L,3364L,3481L,3698L,3721L,3844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241010Inst : IEnumerable<long>
{
public static readonly long[] Value=A241010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241010.Bytes);
public long this[int i]=>Value[i];

public static A241010Inst Instance=new A241010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241011
{
public static readonly long[] Value={ 2L,0L,1L,6L,6L,2L,1L,5L,4L,5L,7L,3L,3L,4L,0L,8L,1L,1L,5L,2L,6L,2L,7L,9L,6L,8L,5L,9L,7L,1L,5L,1L,1L,5L,4L,2L,6L,4L,5L,0L,1L,8L,4L,1L,7L,7L,5L,2L,3L,6L,4L,7L,4L,8L,0L,6L,1L,0L,9L,1L,9L,2L,8L,3L,4L,4L,7L,8L,1L,4L,3L,4L,1L,6L,1L,6L,1L,8L,2L,7L,8L,7L,2L,5L,5L,4L,1L,3L,5L,1L,3L,9L,8L,3L,0L,6L,1L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241011Inst : IEnumerable<long>
{
public static readonly long[] Value=A241011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241011.Bytes);
public long this[int i]=>Value[i];

public static A241011Inst Instance=new A241011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241012
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,3L,10L,12L,14L,5L,16L,7L,18L,9L,11L,20L,22L,13L,24L,15L,17L,19L,26L,21L,28L,23L,30L,25L,32L,27L,34L,36L,29L,31L,33L,35L,38L,37L,39L,41L,40L,42L,43L,44L,46L,48L,45L,50L,47L,52L,54L,56L,49L,58L,60L,62L,64L,66L,51L,53L,55L,68L,70L,57L,72L,59L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241012Inst : IEnumerable<long>
{
public static readonly long[] Value=A241012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241012.Bytes);
public long this[int i]=>Value[i];

public static A241012Inst Instance=new A241012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241013
{
public static readonly long[] Value={ 4L,6L,9L,14L,21L,22L,26L,34L,39L,46L,49L,51L,57L,62L,69L,74L,77L,82L,86L,87L,91L,94L,106L,111L,119L,121L,122L,129L,134L,141L,142L,146L,159L,161L,166L,169L,177L,187L,194L,201L,202L,206L,209L,214L,217L,219L,221L,226L,237L,247L,249L,254L,259L,262L,267L,274L,287L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241013Inst : IEnumerable<long>
{
public static readonly long[] Value=A241013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241013.Bytes);
public long this[int i]=>Value[i];

public static A241013Inst Instance=new A241013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241014
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,-1L,3L,-8L,-3L,-6L,13L,-2L,-4L,16L,-25L,10L,-13L,7L,-16L,-15L,-30L,21L,5L,37L,-4L,22L,24L,26L,-53L,13L,64L,58L,-22L,-29L,60L,44L,-3L,44L,-43L,-5L,-50L,94L,31L,-56L,5L,-99L,3L,-73L,18L,29L,5L,-59L,-1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241014Inst : IEnumerable<long>
{
public static readonly long[] Value=A241014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241014.Bytes);
public long this[int i]=>Value[i];

public static A241014Inst Instance=new A241014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241015
{
public static readonly BigInteger[] Value={ 1L,1L,6L,141L,6184L,387545L,33404256L,3891981205L,592320594048L,113184611671473L,26327424526220800L,7302855260707822541L,BigInteger.Parse("2381136881374877847552"),BigInteger.Parse("901709366369630531857417"),BigInteger.Parse("392234247731566637785780224"),BigInteger.Parse("194028806625479344354551301125") };
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
public class A241015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241015Inst Instance=new A241015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241016
{
public static readonly long[] Value={ 1L,3L,7L,6L,15L,24L,10L,26L,42L,58L,15L,40L,65L,90L,115L,21L,57L,93L,129L,165L,201L,28L,77L,126L,175L,224L,273L,322L,36L,100L,164L,228L,292L,356L,420L,484L,45L,126L,207L,288L,369L,450L,531L,612L,693L,55L,155L,255L,355L,455L,555L,655L,755L,855L,955L,66L,187L,308L,429L,550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241016Inst : IEnumerable<long>
{
public static readonly long[] Value=A241016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241016.Bytes);
public long this[int i]=>Value[i];

public static A241016Inst Instance=new A241016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241017
{
public static readonly long[] Value={ 8L,2L,2L,8L,2L,5L,2L,4L,9L,6L,7L,8L,8L,4L,7L,0L,3L,2L,9L,9L,5L,3L,2L,8L,7L,1L,6L,2L,6L,1L,4L,6L,4L,9L,4L,9L,4L,7L,5L,6L,9L,3L,1L,1L,8L,8L,9L,4L,8L,5L,0L,2L,1L,8L,3L,9L,3L,8L,1L,5L,6L,1L,3L,0L,3L,7L,0L,9L,0L,9L,5L,6L,4L,4L,6L,4L,0L,1L,6L,6L,7L,5L,7L,2L,1L,9L,5L,3L,2L,5L,7L,3L,2L,3L,4L,4L,5L,3L,2L,4L,7L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241017Inst : IEnumerable<long>
{
public static readonly long[] Value=A241017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241017.Bytes);
public long this[int i]=>Value[i];

public static A241017Inst Instance=new A241017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241018
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,7L,1L,0L,2L,6L,3L,3L,11L,2L,14L,4L,0L,4L,6L,0L,4L,20L,6L,7L,18L,1L,1L,23L,8L,8L,23L,7L,0L,0L,0L,26L,33L,0L,11L,8L,5L,8L,13L,12L,44L,2L,2L,0L,11L,31L,17L,39L,1L,51L,5L,7L,4L,29L,9L,16L,0L,0L,26L,14L,26L,10L,13L,0L,0L,34L,40L,0L,15L,3L,14L,32L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241018Inst : IEnumerable<long>
{
public static readonly long[] Value=A241018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241018.Bytes);
public long this[int i]=>Value[i];

public static A241018Inst Instance=new A241018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241019
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,4L,2L,6L,5L,5L,5L,0L,3L,8L,1L,11L,7L,6L,4L,5L,11L,5L,0L,0L,9L,11L,0L,5L,5L,0L,4L,5L,17L,19L,19L,6L,0L,3L,9L,35L,1L,27L,24L,32L,0L,36L,14L,11L,34L,14L,22L,0L,17L,53L,0L,47L,11L,0L,16L,3L,0L,15L,0L,39L,22L,40L,27L,39L,0L,19L,2L,19L,48L,2L,43L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241019Inst : IEnumerable<long>
{
public static readonly long[] Value=A241019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241019.Bytes);
public long this[int i]=>Value[i];

public static A241019Inst Instance=new A241019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241020
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,0L,6L,0L,1L,2L,0L,2L,1L,0L,3L,0L,0L,5L,2L,0L,6L,4L,0L,7L,4L,0L,12L,0L,0L,19L,8L,0L,26L,5L,0L,0L,33L,0L,6L,11L,0L,1L,23L,0L,18L,34L,0L,15L,0L,0L,1L,22L,0L,1L,50L,0L,32L,15L,0L,15L,25L,0L,21L,10L,0L,29L,47L,0L,0L,11L,0L,56L,14L,0L,2L,0L,0L,54L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241020Inst : IEnumerable<long>
{
public static readonly long[] Value=A241020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241020.Bytes);
public long this[int i]=>Value[i];

public static A241020Inst Instance=new A241020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241021
{
public static readonly BigInteger[] Value={ 19L,199L,1999L,99991L,199999L,9999991L,19999999L,0L,9199999999L,99999199999L,991999999999L,9919999999999L,99999999991999L,919999999999999L,9999999999999199L,99919999999999999L,0L,9991999999999999999UL,BigInteger.Parse("99999199999999999999"),0L,BigInteger.Parse("9991999999999999999999") };
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
public class A241021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241021Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241021.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241021.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241021Inst Instance=new A241021Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241022
{
public static readonly BigInteger[] Value={ 13L,313L,3313L,31333L,313333L,3331333L,31333333L,333331333L,3333133333L,33331333333L,333313333333L,0L,33133333333333L,333333313333333L,1333333333333333L,33333333331333333L,333333133333333333L,3333313333333333333L,BigInteger.Parse("33313333333333333333"),BigInteger.Parse("333313333333333333333") };
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
public class A241022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241022Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241022.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241022.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241022Inst Instance=new A241022Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241023
{
public static readonly long[] Value={ 1L,4L,16L,76L,384L,2004L,10672L,57628L,314368L,1728292L,9560016L,53144172L,296642688L,1661529588L,9333781872L,52566230076L,296697618432L,1677889961028L,9505151782288L,53928746972812L,306393243712384L,1742920028025364L,9925790375394096L,56584659163097436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241023Inst : IEnumerable<long>
{
public static readonly long[] Value=A241023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241023.Bytes);
public long this[int i]=>Value[i];

public static A241023Inst Instance=new A241023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241056
{
public static readonly long[] Value={ 4L,4L,3L,24L,60L,93L,297L,507L,1264L,2850L,6180L,15453L,33463L,81394L,185671L,428769L,1005669L,2301449L,5384371L,12403537L,28828484L,66828140L,154614938L,359224400L,831157978L,1928175521L,4468984943L,10355201708L,24011010277L,55638167866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241056Inst : IEnumerable<long>
{
public static readonly long[] Value=A241056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241056.Bytes);
public long this[int i]=>Value[i];

public static A241056Inst Instance=new A241056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241057
{
public static readonly long[] Value={ 6L,6L,6L,64L,163L,280L,1423L,4167L,13389L,46605L,146031L,518568L,1559943L,5448063L,18661041L,57879161L,201222626L,664132824L,2176050370L,7339658200L,24139869513L,80786317859L,267972379590L,888853920796L,2971967179489L,9838548423147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241057Inst : IEnumerable<long>
{
public static readonly long[] Value=A241057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241057.Bytes);
public long this[int i]=>Value[i];

public static A241057Inst Instance=new A241057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241058
{
public static readonly long[] Value={ 8L,8L,6L,132L,598L,1392L,10921L,72769L,370453L,1671155L,9384164L,51783699L,208252518L,1150802650L,6121081737L,27887287923L,140605229939L,756558481056L,3755762723973L,18153596088044L,90862001756655L,469665600883273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241058Inst : IEnumerable<long>
{
public static readonly long[] Value=A241058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241058.Bytes);
public long this[int i]=>Value[i];

public static A241058Inst Instance=new A241058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241059
{
public static readonly long[] Value={ 13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,1013L,1019L,1033L,1039L,1049L,1063L,1069L,1087L,1093L,1097L,1103L,1109L,1123L,1129L,1153L,1163L,1187L,1193L,1213L,1217L,1237L,1249L,1259L,1277L,1279L,1283L,1289L,1297L,1303L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241059Inst : IEnumerable<long>
{
public static readonly long[] Value=A241059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241059.Bytes);
public long this[int i]=>Value[i];

public static A241059Inst Instance=new A241059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241060
{
public static readonly long[] Value={ 201658L,563866L,1213162L,2229322L,4627534L,13593838L,29982262L,127004446L,318134506L,641966518L,948880006L,1340689846L,1671022954L,1827766126L,4241032018L,6055076206L,8775783286L,14009110642L,19917191062L,32482037662L,36682577026L,43862470342L,64900170418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241060Inst : IEnumerable<long>
{
public static readonly long[] Value=A241060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241060.Bytes);
public long this[int i]=>Value[i];

public static A241060Inst Instance=new A241060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241061
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,2L,2L,4L,2L,3L,4L,4L,4L,5L,4L,6L,7L,6L,6L,8L,8L,9L,10L,10L,10L,12L,12L,14L,16L,14L,16L,18L,18L,20L,22L,23L,24L,26L,26L,28L,32L,32L,35L,38L,38L,40L,44L,45L,48L,52L,54L,58L,62L,62L,66L,71L,74L,78L,84L,86L,92L,98L,100L,106L,112L,116L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241061Inst : IEnumerable<long>
{
public static readonly long[] Value=A241061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241061.Bytes);
public long this[int i]=>Value[i];

public static A241061Inst Instance=new A241061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241062
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,1L,2L,0L,1L,3L,2L,2L,2L,1L,2L,4L,4L,2L,3L,2L,3L,6L,4L,4L,6L,4L,4L,5L,6L,8L,8L,7L,6L,8L,7L,8L,12L,10L,10L,13L,12L,11L,12L,12L,14L,18L,18L,17L,18L,18L,18L,22L,20L,22L,26L,25L,28L,30L,29L,30L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241062Inst : IEnumerable<long>
{
public static readonly long[] Value=A241062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241062.Bytes);
public long this[int i]=>Value[i];

public static A241062Inst Instance=new A241062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241063
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,2L,1L,0L,1L,3L,2L,1L,1L,3L,2L,2L,3L,4L,3L,3L,5L,4L,5L,5L,7L,7L,7L,7L,7L,9L,10L,10L,11L,13L,14L,14L,14L,15L,17L,19L,22L,24L,23L,24L,28L,28L,31L,32L,36L,39L,42L,43L,46L,49L,53L,56L,59L,65L,68L,73L,77L,81L,87L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241063Inst : IEnumerable<long>
{
public static readonly long[] Value=A241063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241063.Bytes);
public long this[int i]=>Value[i];

public static A241063Inst Instance=new A241063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241064
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,4L,4L,6L,8L,11L,13L,16L,21L,26L,32L,38L,45L,56L,66L,79L,94L,110L,128L,151L,178L,207L,240L,277L,320L,370L,426L,488L,561L,642L,732L,834L,948L,1079L,1225L,1388L,1570L,1774L,2002L,2254L,2540L,2856L,3206L,3598L,4034L,4516L,5050L,5642L,6298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241064Inst : IEnumerable<long>
{
public static readonly long[] Value=A241064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241064.Bytes);
public long this[int i]=>Value[i];

public static A241064Inst Instance=new A241064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241065
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,4L,3L,3L,4L,5L,4L,5L,5L,6L,6L,7L,7L,8L,8L,8L,10L,11L,10L,12L,12L,13L,14L,15L,16L,17L,19L,18L,20L,22L,22L,25L,26L,27L,29L,30L,32L,34L,36L,37L,41L,43L,44L,47L,50L,51L,55L,58L,60L,65L,68L,70L,75L,78L,82L,85L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241065Inst : IEnumerable<long>
{
public static readonly long[] Value=A241065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241065.Bytes);
public long this[int i]=>Value[i];

public static A241065Inst Instance=new A241065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241066
{
public static readonly long[] Value={ 1L,2L,6L,16L,54L,20L,272L,2106L,544L,50L,7936L,179334L,66560L,3250L,105L,353792L,26414586L,17895424L,968750L,13986L,196L,22368256L,5957217414L,8329625600L,635781250L,8637840L,48020L,336L,1903757312L,1906398972666L,5937093935104L,722480468750L,11754617616L,54925276L,139776L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241066Inst : IEnumerable<long>
{
public static readonly long[] Value=A241066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241066.Bytes);
public long this[int i]=>Value[i];

public static A241066Inst Instance=new A241066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241067
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,2L,0L,0L,2L,1L,2L,1L,1L,1L,2L,2L,2L,3L,1L,1L,4L,2L,3L,4L,3L,3L,3L,3L,4L,6L,5L,4L,6L,4L,5L,7L,6L,7L,8L,8L,8L,9L,7L,8L,11L,11L,11L,13L,12L,12L,15L,12L,14L,17L,15L,18L,19L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241067Inst : IEnumerable<long>
{
public static readonly long[] Value=A241067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241067.Bytes);
public long this[int i]=>Value[i];

public static A241067Inst Instance=new A241067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241068
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,3L,3L,5L,6L,8L,10L,13L,15L,20L,23L,29L,35L,42L,49L,60L,71L,84L,98L,116L,135L,158L,184L,214L,248L,286L,329L,380L,436L,500L,572L,654L,745L,848L,965L,1094L,1242L,1406L,1588L,1794L,2023L,2278L,2563L,2881L,3234L,3626L,4063L,4546L,5083L,5677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241068Inst : IEnumerable<long>
{
public static readonly long[] Value=A241068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241068.Bytes);
public long this[int i]=>Value[i];

public static A241068Inst Instance=new A241068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241069
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,2L,0L,0L,1L,1L,2L,1L,2L,1L,3L,4L,3L,3L,3L,4L,6L,6L,4L,6L,5L,8L,8L,9L,9L,10L,13L,11L,13L,15L,17L,20L,21L,21L,24L,25L,29L,30L,33L,35L,40L,44L,44L,49L,51L,56L,61L,66L,69L,77L,82L,91L,95L,102L,106L,116L,127L,134L,147L,157L,168L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241069Inst : IEnumerable<long>
{
public static readonly long[] Value=A241069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241069.Bytes);
public long this[int i]=>Value[i];

public static A241069Inst Instance=new A241069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241070
{
public static readonly long[] Value={ 2L,3L,0L,3L,0L,4L,0L,4L,0L,7L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241070Inst : IEnumerable<long>
{
public static readonly long[] Value=A241070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241070.Bytes);
public long this[int i]=>Value[i];

public static A241070Inst Instance=new A241070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241071
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241071Inst : IEnumerable<long>
{
public static readonly long[] Value=A241071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241071.Bytes);
public long this[int i]=>Value[i];

public static A241071Inst Instance=new A241071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241104
{
public static readonly long[] Value={ 4L,36L,294L,2436L,19814L,162776L,1333934L,10937316L,89651534L,734979136L,6025149574L,49393306556L,404916355574L,3319433387656L,27212098788254L,223079838087956L,1828767624421854L,14991902921730896L,122900877847563254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241104Inst : IEnumerable<long>
{
public static readonly long[] Value=A241104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241104.Bytes);
public long this[int i]=>Value[i];

public static A241104Inst Instance=new A241104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241105
{
public static readonly long[] Value={ 8L,116L,1522L,19814L,259388L,3374086L,44030862L,574246744L,7489718098L,97685897406L,1274061880332L,16617079770494L,216729255718838L,2826706576812536L,36867513064014682L,480847045785788134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241105Inst : IEnumerable<long>
{
public static readonly long[] Value=A241105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241105.Bytes);
public long this[int i]=>Value[i];

public static A241105Inst Instance=new A241105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241106
{
public static readonly BigInteger[] Value={ 16L,376L,7846L,162776L,3374086L,70145916L,1454236806L,30189380016L,626548445696L,13004327687556L,269904513767276L,5601924832399656L,116268494681555446L,2413172096267222836L,BigInteger.Parse("50085748850277170776"),BigInteger.Parse("1039537719846439186376") };
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
public class A241106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241106Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241106.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241106.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241106Inst Instance=new A241106Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241107
{
public static readonly BigInteger[] Value={ 32L,1216L,40418L,1333934L,44030862L,1454236806L,48054344508L,1586763763374L,52415988665902L,1731396543937826L,57192293520907518L,1889201414043365704L,BigInteger.Parse("62405079297467322902"),BigInteger.Parse("2061398474689109752446"),BigInteger.Parse("68093252520609897541958") };
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
public class A241107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241107Inst Instance=new A241107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241108
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,4L,11L,11L,4L,8L,36L,58L,36L,8L,16L,116L,294L,294L,116L,16L,32L,376L,1522L,2436L,1522L,376L,32L,64L,1216L,7846L,19814L,19814L,7846L,1216L,64L,128L,3936L,40418L,162776L,259388L,162776L,40418L,3936L,128L,256L,12736L,208374L,1333934L,3374086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241108Inst : IEnumerable<long>
{
public static readonly long[] Value=A241108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241108.Bytes);
public long this[int i]=>Value[i];

public static A241108Inst Instance=new A241108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241109
{
public static readonly BigInteger[] Value={ 5L,113L,2612L,60340L,1394492L,32228144L,744822776L,17213554688L,397821442776L,9194027810904L,212482632363880L,4910673535536216L,113490285320567816L,2622867264324958968L,BigInteger.Parse("60616930046792933096"),BigInteger.Parse("1400914281204947257016") };
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
public class A241109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241109Inst Instance=new A241109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241110
{
public static readonly BigInteger[] Value={ 14L,953L,60340L,3829419L,242964166L,15415566961L,978087593971L,62057748267728L,3937442921908646L,249823063157133762L,15850785425018320234UL,BigInteger.Parse("1005701376869763009802"),BigInteger.Parse("63809788115736016913149") };
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
public class A241110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241110Inst Instance=new A241110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241111
{
public static readonly BigInteger[] Value={ 41L,8037L,1394492L,242964166L,42319480270L,7371117761274L,1283885768594047L,223624580792359221L,BigInteger.Parse("38950469229517445774"),BigInteger.Parse("6784312567672435500159"),BigInteger.Parse("1181677600537166135068174"),BigInteger.Parse("205822172500862145456368325") };
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
public class A241111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241111Inst Instance=new A241111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241112
{
public static readonly BigInteger[] Value={ 122L,67774L,32228144L,15415566961L,7371117761274L,3524558549098471L,1685292182142705704L,BigInteger.Parse("805834184979759771929"),BigInteger.Parse("385315225693559139835717"),BigInteger.Parse("184241158047029288125024239"),BigInteger.Parse("88096192562308932636636937713") };
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
public class A241112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241112Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241112.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241112Inst Instance=new A241112Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241113
{
public static readonly BigInteger[] Value={ 365L,571530L,744822776L,978087593971L,1283885768594047L,1685292182142705704L,BigInteger.Parse("2212193554836290644824"),BigInteger.Parse("2903828647417685566144097"),BigInteger.Parse("3811701111661594456829457851"),BigInteger.Parse("5003416917134104852934943460035") };
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
public class A241113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241113Inst Instance=new A241113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241114
{
public static readonly long[] Value={ 1L,2L,2L,5L,14L,5L,14L,113L,113L,14L,41L,953L,2612L,953L,41L,122L,8037L,60340L,60340L,8037L,122L,365L,67774L,1394492L,3829419L,1394492L,67774L,365L,1094L,571530L,32228144L,242964166L,242964166L,32228144L,571530L,1094L,3281L,4819638L,744822776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241114Inst : IEnumerable<long>
{
public static readonly long[] Value=A241114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241114.Bytes);
public long this[int i]=>Value[i];

public static A241114Inst Instance=new A241114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241115
{
public static readonly BigInteger[] Value={ 5L,178L,9918L,587555L,35000157L,2085879115L,124315318217L,7409032909403L,441568937568818L,26316947602316573L,1568456640467509976L,BigInteger.Parse("93478023005207665450"),BigInteger.Parse("5571171404819117025366"),BigInteger.Parse("332034737407500793137773") };
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
public class A241115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241115Inst Instance=new A241115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241116
{
public static readonly BigInteger[] Value={ 15L,2614L,587555L,134229632L,30679522712L,7012241396116L,1602748583683541L,366331237082570675L,BigInteger.Parse("83730272300093086129"),BigInteger.Parse("19137757826895828304001"),BigInteger.Parse("4374209764040662469308200"),BigInteger.Parse("999788545392696494568265298") };
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
public class A241116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241116Inst Instance=new A241116Inst();

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