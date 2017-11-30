using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A110579
{
public static readonly long[] Value={ 1L,4L,11L,29L,87L,317L,1367L,6644L,35257L,201152L,1224225L,7906794L,53961576L,387673853L,2921972174L,23036161619L,189459483913L,1621711095618L,14416893342727L,132860397599808L,1267097654903284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110579Inst : IEnumerable<long>
{
public static readonly long[] Value=A110579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110579.Bytes);
public long this[int i]=>Value[i];

public static A110579Inst Instance=new A110579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110580
{
public static readonly long[] Value={ 1L,5L,16L,45L,132L,449L,1816L,8460L,43717L,244869L,1469094L,9375888L,63337464L,451011317L,3372983491L,26409145110L,215868629023L,1837579724641L,16254473067368L,149114870667176L,1416212525570460L,13902957827280263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110580Inst : IEnumerable<long>
{
public static readonly long[] Value=A110580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110580.Bytes);
public long this[int i]=>Value[i];

public static A110580Inst Instance=new A110580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110581
{
public static readonly long[] Value={ 3L,7L,31L,37L,97L,139L,157L,199L,211L,229L,271L,307L,337L,367L,379L,547L,577L,601L,607L,661L,691L,727L,811L,877L,937L,967L,997L,1009L,1171L,1237L,1297L,1399L,1429L,1459L,1609L,1627L,1657L,1759L,1867L,2011L,2029L,2137L,2221L,2281L,2467L,2539L,2551L,2557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110581Inst : IEnumerable<long>
{
public static readonly long[] Value=A110581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110581.Bytes);
public long this[int i]=>Value[i];

public static A110581Inst Instance=new A110581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110582
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,4L,3L,4L,1L,4L,7L,4L,5L,1L,6L,10L,10L,5L,6L,1L,6L,14L,16L,13L,6L,7L,1L,8L,18L,26L,22L,16L,7L,8L,1L,8L,25L,34L,38L,28L,19L,8L,9L,1L,10L,29L,52L,55L,50L,34L,22L,9L,10L,1L,10L,37L,66L,84L,76L,62L,40L,25L,10L,11L,1L,12L,44L,90L,116L,122L,97L,74L,46L,28L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110582Inst : IEnumerable<long>
{
public static readonly long[] Value=A110582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110582.Bytes);
public long this[int i]=>Value[i];

public static A110582Inst Instance=new A110582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110583
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,43L,53L,61L,67L,73L,83L,97L,103L,109L,133L,143L,157L,161L,163L,179L,203L,211L,247L,257L,263L,271L,287L,313L,319L,323L,359L,361L,373L,389L,397L,409L,413L,427L,431L,443L,451L,457L,469L,479L,493L,499L,533L,541L,557L,623L,631L,637L,653L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110583Inst : IEnumerable<long>
{
public static readonly long[] Value=A110583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110583.Bytes);
public long this[int i]=>Value[i];

public static A110583Inst Instance=new A110583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110584
{
public static readonly long[] Value={ 23L,29L,61L,71L,89L,91L,101L,133L,149L,169L,181L,199L,217L,221L,233L,239L,269L,287L,307L,329L,331L,359L,371L,377L,389L,431L,433L,437L,451L,491L,499L,521L,529L,541L,553L,563L,599L,611L,613L,623L,631L,653L,667L,671L,683L,721L,727L,749L,763L,769L,773L,809L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110584Inst : IEnumerable<long>
{
public static readonly long[] Value=A110584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110584.Bytes);
public long this[int i]=>Value[i];

public static A110584Inst Instance=new A110584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110585
{
public static readonly long[] Value={ 1L,3L,7L,16L,29L,44L,65L,89L,120L,155L,192L,236L,282L,332L,390L,453L,520L,589L,666L,746L,832L,927L,1026L,1131L,1239L,1350L,1467L,1592L,1725L,1867L,2017L,2161L,2313L,2469L,2634L,2800L,2975L,3155L,3339L,3532L,3729L,3931L,4143L,4356L,4579L,4809L,5051L,5291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110585Inst : IEnumerable<long>
{
public static readonly long[] Value=A110585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110585.Bytes);
public long this[int i]=>Value[i];

public static A110585Inst Instance=new A110585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110586
{
public static readonly long[] Value={ 25L,49L,121L,289L,361L,841L,1369L,1849L,2209L,2809L,3721L,5041L,5329L,6241L,7921L,9409L,10201L,11449L,11881L,16129L,29929L,36481L,39601L,49729L,58081L,63001L,69169L,73441L,78961L,100489L,134689L,151321L,157609L,187489L,192721L,196249L,201601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110586Inst : IEnumerable<long>
{
public static readonly long[] Value=A110586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110586.Bytes);
public long this[int i]=>Value[i];

public static A110586Inst Instance=new A110586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110587
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,29L,37L,43L,47L,53L,61L,71L,73L,79L,89L,97L,101L,107L,109L,127L,173L,191L,199L,223L,241L,251L,263L,271L,281L,317L,367L,389L,397L,433L,439L,443L,449L,457L,461L,479L,523L,541L,569L,577L,587L,613L,631L,647L,659L,677L,683L,691L,701L,739L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110587Inst : IEnumerable<long>
{
public static readonly long[] Value=A110587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110587.Bytes);
public long this[int i]=>Value[i];

public static A110587Inst Instance=new A110587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110588
{
public static readonly long[] Value={ 9L,25L,49L,121L,169L,361L,529L,841L,961L,1369L,1681L,2209L,4489L,5329L,6241L,9409L,10201L,10609L,11881L,22801L,24649L,38809L,44521L,51529L,54289L,57121L,66049L,69169L,85849L,94249L,109561L,113569L,121801L,124609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110588Inst : IEnumerable<long>
{
public static readonly long[] Value=A110588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110588.Bytes);
public long this[int i]=>Value[i];

public static A110588Inst Instance=new A110588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110589
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,23L,29L,31L,37L,41L,47L,67L,73L,79L,97L,101L,103L,109L,151L,157L,197L,211L,227L,233L,239L,257L,263L,293L,307L,331L,337L,349L,353L,359L,367L,389L,397L,409L,443L,449L,463L,487L,491L,509L,521L,547L,569L,571L,587L,613L,619L,653L,661L,673L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110589Inst : IEnumerable<long>
{
public static readonly long[] Value=A110589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110589.Bytes);
public long this[int i]=>Value[i];

public static A110589Inst Instance=new A110589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110590
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,14L,15L,30L,264L,3828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110590Inst : IEnumerable<long>
{
public static readonly long[] Value=A110590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110590.Bytes);
public long this[int i]=>Value[i];

public static A110590Inst Instance=new A110590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110591
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110591Inst : IEnumerable<long>
{
public static readonly long[] Value=A110591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110591.Bytes);
public long this[int i]=>Value[i];

public static A110591Inst Instance=new A110591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110592
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110592Inst : IEnumerable<long>
{
public static readonly long[] Value=A110592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110592.Bytes);
public long this[int i]=>Value[i];

public static A110592Inst Instance=new A110592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110593
{
public static readonly long[] Value={ 3L,6L,18L,54L,162L,486L,1458L,4374L,13122L,39366L,118098L,354294L,1062882L,3188646L,9565938L,28697814L,86093442L,258280326L,774840978L,2324522934L,6973568802L,20920706406L,62762119218L,188286357654L,564859072962L,1694577218886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110593Inst : IEnumerable<long>
{
public static readonly long[] Value=A110593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110593.Bytes);
public long this[int i]=>Value[i];

public static A110593Inst Instance=new A110593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110594
{
public static readonly long[] Value={ 4L,12L,48L,192L,768L,3072L,12288L,49152L,196608L,786432L,3145728L,12582912L,50331648L,201326592L,805306368L,3221225472L,12884901888L,51539607552L,206158430208L,824633720832L,3298534883328L,13194139533312L,52776558133248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110594Inst : IEnumerable<long>
{
public static readonly long[] Value=A110594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110594.Bytes);
public long this[int i]=>Value[i];

public static A110594Inst Instance=new A110594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110595
{
public static readonly long[] Value={ 5L,20L,100L,500L,2500L,12500L,62500L,312500L,1562500L,7812500L,39062500L,195312500L,976562500L,4882812500L,24414062500L,122070312500L,610351562500L,3051757812500L,15258789062500L,76293945312500L,381469726562500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110595Inst : IEnumerable<long>
{
public static readonly long[] Value=A110595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110595.Bytes);
public long this[int i]=>Value[i];

public static A110595Inst Instance=new A110595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110596
{
public static readonly long[] Value={ 35L,124355L,1739507L,3281663L,3852155L,7649915L,9815195L,10434515L,13321295L,19154135L,19296035L,32807555L,36664595L,41523911L,50329955L,60668135L,69664595L,83338199L,107008811L,123543695L,145960451L,275361359L,321198059L,365269355L,393656879L,407002211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110596Inst : IEnumerable<long>
{
public static readonly long[] Value=A110596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110596.Bytes);
public long this[int i]=>Value[i];

public static A110596Inst Instance=new A110596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110597
{
public static readonly long[] Value={ 1L,1045L,29029L,50065L,64285L,87685L,1390753L,2011009L,3189625L,7711405L,39298441L,53238625L,68393065L,75416341L,96345613L,225938245L,228404605L,231562825L,233591605L,279999445L,458406445L,462027565L,470527057L,491291125L,513574369L,663605761L,666373825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110597Inst : IEnumerable<long>
{
public static readonly long[] Value=A110597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110597.Bytes);
public long this[int i]=>Value[i];

public static A110597Inst Instance=new A110597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110598
{
public static readonly long[] Value={ 137885L,145145L,3501605L,6605945L,6953765L,8409305L,10055045L,11413205L,11569805L,16540205L,18545285L,19648805L,21902705L,22806905L,25965005L,26655005L,29811665L,45680921L,71569745L,79989845L,91681289L,196492205L,214218389L,223086125L,229554941L,233601641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110598Inst : IEnumerable<long>
{
public static readonly long[] Value=A110598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110598.Bytes);
public long this[int i]=>Value[i];

public static A110598Inst Instance=new A110598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110599
{
public static readonly long[] Value={ 24871L,58435L,140335L,1529983L,2086903L,3722875L,3830827L,8697535L,13932919L,16408315L,21578755L,27882595L,76319155L,126245119L,183531439L,192871987L,198394675L,207619555L,229523371L,337800463L,361504507L,416690995L,440127655L,535044055L,693298315L,729802255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110599Inst : IEnumerable<long>
{
public static readonly long[] Value=A110599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110599.Bytes);
public long this[int i]=>Value[i];

public static A110599Inst Instance=new A110599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110600
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,73L,97L,109L,577L,1489L,7537L,17401L,226201L,1097113L,32555521L,388177921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110600Inst : IEnumerable<long>
{
public static readonly long[] Value=A110600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110600.Bytes);
public long this[int i]=>Value[i];

public static A110600Inst Instance=new A110600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110601
{
public static readonly long[] Value={ 1L,4L,8L,18L,16L,32L,24L,64L,54L,64L,40L,144L,48L,96L,128L,200L,64L,216L,72L,288L,192L,160L,88L,512L,180L,192L,288L,432L,112L,512L,120L,576L,320L,256L,384L,972L,144L,288L,384L,1024L,160L,768L,168L,720L,864L,352L,184L,1600L,378L,720L,512L,864L,208L,1152L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110601Inst : IEnumerable<long>
{
public static readonly long[] Value=A110601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110601.Bytes);
public long this[int i]=>Value[i];

public static A110601Inst Instance=new A110601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110602
{
public static readonly long[] Value={ 4L,9L,10L,15L,21L,25L,26L,27L,31L,33L,34L,35L,39L,41L,49L,50L,51L,57L,59L,67L,69L,81L,85L,89L,95L,98L,99L,101L,119L,122L,127L,137L,141L,143L,145L,146L,147L,154L,155L,161L,173L,178L,185L,187L,199L,202L,205L,209L,211L,215L,221L,223L,226L,235L,239L,257L,259L,265L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110602Inst : IEnumerable<long>
{
public static readonly long[] Value=A110602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110602.Bytes);
public long this[int i]=>Value[i];

public static A110602Inst Instance=new A110602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110603
{
public static readonly long[] Value={ 4L,5L,9L,11L,12L,18L,19L,31L,36L,37L,38L,43L,44L,46L,47L,48L,51L,52L,53L,58L,59L,61L,76L,77L,78L,84L,86L,88L,94L,96L,103L,106L,108L,112L,128L,131L,146L,147L,148L,151L,156L,159L,161L,168L,171L,172L,177L,178L,181L,184L,194L,196L,198L,208L,212L,218L,223L,226L,227L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110603Inst : IEnumerable<long>
{
public static readonly long[] Value=A110603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110603.Bytes);
public long this[int i]=>Value[i];

public static A110603Inst Instance=new A110603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110604
{
public static readonly long[] Value={ 4L,6L,10L,11L,13L,14L,17L,21L,22L,23L,31L,35L,43L,47L,49L,50L,51L,57L,58L,61L,62L,63L,65L,71L,73L,74L,75L,77L,81L,82L,83L,85L,95L,105L,106L,109L,110L,111L,113L,118L,121L,123L,130L,131L,133L,143L,147L,151L,153L,155L,158L,173L,175L,177L,178L,181L,182L,185L,187L,190L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110604Inst : IEnumerable<long>
{
public static readonly long[] Value=A110604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110604.Bytes);
public long this[int i]=>Value[i];

public static A110604Inst Instance=new A110604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110605
{
public static readonly long[] Value={ 4L,6L,7L,11L,12L,15L,16L,19L,20L,24L,25L,26L,34L,36L,40L,44L,47L,55L,57L,61L,64L,65L,66L,73L,74L,78L,79L,80L,82L,83L,89L,92L,97L,99L,100L,101L,103L,104L,108L,109L,110L,113L,118L,124L,136L,137L,142L,145L,148L,149L,150L,152L,158L,162L,164L,167L,172L,173L,176L,181L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110605Inst : IEnumerable<long>
{
public static readonly long[] Value=A110605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110605.Bytes);
public long this[int i]=>Value[i];

public static A110605Inst Instance=new A110605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110606
{
public static readonly long[] Value={ 4L,6L,8L,12L,13L,17L,18L,21L,22L,27L,28L,29L,38L,41L,45L,47L,50L,53L,60L,63L,70L,73L,77L,81L,82L,83L,91L,92L,97L,98L,99L,101L,102L,109L,113L,118L,127L,129L,130L,131L,133L,134L,139L,140L,141L,143L,145L,150L,157L,159L,167L,171L,172L,178L,181L,183L,188L,193L,194L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110606Inst : IEnumerable<long>
{
public static readonly long[] Value=A110606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110606.Bytes);
public long this[int i]=>Value[i];

public static A110606Inst Instance=new A110606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110607
{
public static readonly long[] Value={ 4L,6L,9L,13L,14L,19L,20L,23L,24L,30L,31L,32L,35L,42L,46L,50L,52L,53L,56L,59L,67L,70L,74L,77L,78L,79L,87L,91L,95L,98L,100L,101L,102L,111L,112L,118L,119L,120L,122L,123L,131L,134L,136L,141L,151L,152L,156L,158L,160L,163L,164L,165L,167L,168L,174L,175L,176L,178L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110607Inst : IEnumerable<long>
{
public static readonly long[] Value=A110607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110607.Bytes);
public long this[int i]=>Value[i];

public static A110607Inst Instance=new A110607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110608
{
public static readonly long[] Value={ 1L,2L,1L,6L,8L,1L,20L,45L,18L,1L,70L,224L,168L,32L,1L,252L,1050L,1200L,450L,50L,1L,924L,4752L,7425L,4400L,990L,72L,1L,3432L,21021L,42042L,35035L,12740L,1911L,98L,1L,12870L,91520L,224224L,244608L,127400L,31360L,3360L,128L,1L,48620L,393822L,1145664L,1559376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110608Inst : IEnumerable<long>
{
public static readonly long[] Value=A110608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110608.Bytes);
public long this[int i]=>Value[i];

public static A110608Inst Instance=new A110608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110609
{
public static readonly long[] Value={ 0L,1L,8L,45L,224L,1050L,4752L,21021L,91520L,393822L,1679600L,7113106L,29953728L,125550100L,524190240L,2181340125L,9051563520L,37467344310L,154754938800L,637982011590L,2625648168000L,10789623755820L,44277560801760L,181478535620850L,742984788858624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110609Inst : IEnumerable<long>
{
public static readonly long[] Value=A110609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110609.Bytes);
public long this[int i]=>Value[i];

public static A110609Inst Instance=new A110609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110610
{
public static readonly long[] Value={ 1L,4L,11L,25L,48L,82L,129L,191L,270L,368L,487L,629L,796L,990L,1213L,1467L,1754L,2076L,2435L,2833L,3272L,3754L,4281L,4855L,5478L,6152L,6879L,7661L,8500L,9398L,10357L,11379L,12466L,13620L,14843L,16137L,17504L,18946L,20465L,22063L,23742L,25504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110610Inst : IEnumerable<long>
{
public static readonly long[] Value=A110610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110610.Bytes);
public long this[int i]=>Value[i];

public static A110610Inst Instance=new A110610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110611
{
public static readonly long[] Value={ 1L,4L,11L,21L,37L,58L,87L,123L,169L,224L,291L,369L,461L,566L,687L,823L,977L,1148L,1339L,1549L,1781L,2034L,2311L,2611L,2937L,3288L,3667L,4073L,4509L,4974L,5471L,5999L,6561L,7156L,7787L,8453L,9157L,9898L,10679L,11499L,12361L,13264L,14211L,15201L,16237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110611Inst : IEnumerable<long>
{
public static readonly long[] Value=A110611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110611.Bytes);
public long this[int i]=>Value[i];

public static A110611Inst Instance=new A110611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110612
{
public static readonly long[] Value={ 30L,420L,27720L,1531530L,58198140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110612Inst : IEnumerable<long>
{
public static readonly long[] Value=A110612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110612.Bytes);
public long this[int i]=>Value[i];

public static A110612Inst Instance=new A110612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110613
{
public static readonly long[] Value={ 1L,0L,3L,7L,29L,107L,421L,1659L,6597L,26299L,105029L,419771L,1678405L,6712251L,26846277L,107379643L,429507653L,1718008763L,6871991365L,27487878075L,109951337541L,439805000635L,1759219303493L,7036875815867L,28147500467269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110613Inst : IEnumerable<long>
{
public static readonly long[] Value=A110613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110613.Bytes);
public long this[int i]=>Value[i];

public static A110613Inst Instance=new A110613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110614
{
public static readonly long[] Value={ 1L,5L,15L,57L,215L,841L,3319L,13193L,52599L,210057L,839543L,3356809L,13424503L,53692553L,214759287L,859015305L,3436017527L,13743982729L,54975756151L,219902675081L,879610001271L,3518438606985L,14073751631735L,56295000934537L,225179992553335L,900719947843721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110614Inst : IEnumerable<long>
{
public static readonly long[] Value=A110614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110614.Bytes);
public long this[int i]=>Value[i];

public static A110614Inst Instance=new A110614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110615
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,24L,25L,26L,27L,35L,36L,38L,39L,60L,62L,63L,65L,84L,85L,86L,87L,91L,95L,132L,133L,134L,135L,143L,161L,205L,215L,355L,377L,445L,451L,455L,493L,1651L,1673L,1885L,1891L,1895L,8797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110615Inst : IEnumerable<long>
{
public static readonly long[] Value=A110615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110615.Bytes);
public long this[int i]=>Value[i];

public static A110615Inst Instance=new A110615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110616
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,12L,7L,3L,1L,55L,30L,12L,4L,1L,273L,143L,55L,18L,5L,1L,1428L,728L,273L,88L,25L,6L,1L,7752L,3876L,1428L,455L,130L,33L,7L,1L,43263L,21318L,7752L,2448L,700L,182L,42L,8L,1L,246675L,120175L,43263L,13566L,3876L,1020L,245L,52L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110616Inst : IEnumerable<long>
{
public static readonly long[] Value=A110616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110616.Bytes);
public long this[int i]=>Value[i];

public static A110616Inst Instance=new A110616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110617
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,5L,4L,9L,6L,1L,8L,7L,9L,3L,7L,7L,6L,7L,3L,0L,9L,2L,4L,1L,9L,2L,6L,4L,8L,6L,0L,8L,4L,4L,2L,3L,2L,3L,1L,8L,8L,4L,9L,5L,6L,3L,0L,0L,7L,5L,0L,0L,1L,5L,4L,9L,6L,1L,8L,7L,9L,3L,7L,7L,6L,7L,3L,0L,9L,2L,4L,1L,9L,2L,6L,4L,8L,6L,0L,8L,4L,4L,2L,3L,2L,3L,1L,8L,8L,4L,9L,5L,6L,3L,0L,0L,7L,5L,0L,0L,1L,5L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110617Inst : IEnumerable<long>
{
public static readonly long[] Value=A110617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110617.Bytes);
public long this[int i]=>Value[i];

public static A110617Inst Instance=new A110617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110618
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,3L,7L,8L,15L,18L,30L,37L,58L,71L,105L,131L,186L,230L,318L,393L,530L,653L,863L,1060L,1380L,1686L,2164L,2637L,3345L,4057L,5096L,6158L,7665L,9228L,11395L,13671L,16765L,20040L,24418L,29098L,35251L,41869L,50460L,59755L,71669L,84626L,101050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110618Inst : IEnumerable<long>
{
public static readonly long[] Value=A110618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110618.Bytes);
public long this[int i]=>Value[i];

public static A110618Inst Instance=new A110618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110619
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,5L,3L,1L,1L,7L,3L,1L,1L,1L,11L,7L,4L,1L,1L,1L,15L,8L,4L,1L,1L,1L,1L,22L,15L,5L,5L,1L,1L,1L,1L,30L,18L,12L,5L,1L,1L,1L,1L,1L,42L,30L,14L,6L,6L,1L,1L,1L,1L,1L,56L,37L,16L,6L,6L,1L,1L,1L,1L,1L,1L,77L,58L,34L,19L,7L,7L,1L,1L,1L,1L,1L,1L,101L,71L,39L,21L,7L,7L,1L,1L,1L,1L,1L,1L,1L,135L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110619Inst : IEnumerable<long>
{
public static readonly long[] Value=A110619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110619.Bytes);
public long this[int i]=>Value[i];

public static A110619Inst Instance=new A110619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110620
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,6L,8L,0L,4L,0L,3L,4L,6L,0L,0L,6L,0L,5L,4L,0L,0L,8L,0L,4L,4L,4L,3L,4L,4L,5L,4L,4L,0L,6L,1L,2L,8L,2L,0L,6L,4L,8L,2L,2L,1L,6L,4L,6L,7L,3L,0L,0L,1L,4L,6L,4L,2L,12L,1L,0L,2L,4L,0L,6L,2L,0L,12L,1L,6L,4L,1L,8L,0L,2L,1L,6L,2L,0L,0L,1L,3L,16L,4L,3L,0L,2L,0L,8L,0L,6L,11L,4L,1L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110620Inst : IEnumerable<long>
{
public static readonly long[] Value=A110620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110620.Bytes);
public long this[int i]=>Value[i];

public static A110620Inst Instance=new A110620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110621
{
public static readonly long[] Value={ 1L,4L,18L,33L,42L,44L,50L,55L,90L,98L,195L,288L,311L,395L,457L,521L,859L,891L,898L,1848L,1876L,2717L,3688L,3757L,3796L,4733L,5243L,5301L,5321L,6295L,6389L,6434L,6526L,6556L,6634L,6650L,6690L,7318L,7938L,8027L,9013L,9293L,9327L,9409L,9462L,9883L,10053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110621Inst : IEnumerable<long>
{
public static readonly long[] Value=A110621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110621.Bytes);
public long this[int i]=>Value[i];

public static A110621Inst Instance=new A110621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110622
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,8L,16L,9L,3L,27L,81L,16L,4L,64L,256L,25L,5L,125L,625L,36L,6L,216L,1296L,49L,7L,343L,2401L,64L,8L,512L,4096L,81L,9L,729L,6561L,100L,10L,1000L,10000L,121L,11L,1331L,14641L,144L,12L,1728L,20736L,169L,13L,2197L,28561L,196L,14L,2744L,38416L,225L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110622Inst : IEnumerable<long>
{
public static readonly long[] Value=A110622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110622.Bytes);
public long this[int i]=>Value[i];

public static A110622Inst Instance=new A110622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110623
{
public static readonly long[] Value={ 1L,13L,16L,20L,25L,31L,38L,46L,55L,65L,76L,197L,511L,526L,687L,758L,839L,1759L,1761L,1883L,1906L,1930L,2182L,2244L,2316L,2398L,3328L,3641L,3874L,3908L,3943L,3979L,4016L,4399L,5339L,5380L,5422L,5465L,5509L,5554L,6018L,6092L,6176L,7126L,7177L,7229L,7282L,7336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110623Inst : IEnumerable<long>
{
public static readonly long[] Value=A110623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110623.Bytes);
public long this[int i]=>Value[i];

public static A110623Inst Instance=new A110623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110624
{
public static readonly long[] Value={ 2L,148L,2159L,16746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110624Inst : IEnumerable<long>
{
public static readonly long[] Value=A110624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110624.Bytes);
public long this[int i]=>Value[i];

public static A110624Inst Instance=new A110624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110625
{
public static readonly long[] Value={ 1L,1L,3L,101L,5807L,77801L,82949L,170636L,170636L,170636L,363113L,363113L,84848L,710567L,22435781L,3901243741L,27210449083L,1003538672911L,248595095590537L,10165684261926701L,438167567023512863L,439119040574907047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110625Inst : IEnumerable<long>
{
public static readonly long[] Value=A110625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110625.Bytes);
public long this[int i]=>Value[i];

public static A110625Inst Instance=new A110625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110626
{
public static readonly long[] Value={ 6L,6L,14L,504L,27720L,360360L,360360L,765765L,765765L,765765L,1601145L,1601145L,369495L,3061530L,94907430L,16703707680L,116925953760L,4326260289120L,1068586291412640L,43812037947918240L,1883917631760484320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110626Inst : IEnumerable<long>
{
public static readonly long[] Value=A110626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110626.Bytes);
public long this[int i]=>Value[i];

public static A110626Inst Instance=new A110626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110627
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110627Inst : IEnumerable<long>
{
public static readonly long[] Value=A110627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110627.Bytes);
public long this[int i]=>Value[i];

public static A110627Inst Instance=new A110627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110628
{
public static readonly long[] Value={ 1L,1L,3L,3L,1L,2L,2L,1L,2L,3L,2L,3L,3L,2L,2L,3L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,3L,1L,2L,1L,3L,1L,3L,1L,1L,1L,2L,2L,3L,3L,2L,3L,1L,2L,1L,3L,3L,2L,3L,3L,1L,2L,3L,3L,1L,3L,3L,2L,2L,2L,1L,2L,3L,3L,3L,3L,1L,2L,2L,3L,2L,1L,2L,2L,1L,2L,3L,3L,2L,2L,1L,1L,2L,1L,3L,2L,2L,2L,1L,3L,2L,2L,3L,3L,2L,3L,1L,1L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110628Inst : IEnumerable<long>
{
public static readonly long[] Value=A110628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110628.Bytes);
public long this[int i]=>Value[i];

public static A110628Inst Instance=new A110628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110629
{
public static readonly long[] Value={ 1L,3L,1L,3L,3L,2L,4L,3L,2L,3L,3L,4L,2L,2L,2L,1L,1L,4L,1L,3L,4L,3L,2L,2L,1L,1L,3L,4L,1L,1L,2L,3L,2L,2L,3L,4L,4L,1L,4L,4L,1L,4L,2L,3L,1L,2L,1L,4L,3L,3L,1L,4L,3L,3L,2L,3L,4L,2L,3L,4L,1L,2L,1L,3L,4L,3L,4L,1L,4L,2L,2L,3L,1L,4L,3L,2L,1L,4L,3L,4L,4L,2L,1L,4L,1L,4L,4L,2L,4L,4L,1L,3L,3L,4L,1L,1L,1L,4L,3L,2L,1L,3L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110629Inst : IEnumerable<long>
{
public static readonly long[] Value=A110629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110629.Bytes);
public long this[int i]=>Value[i];

public static A110629Inst Instance=new A110629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110630
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,4L,3L,4L,3L,4L,2L,2L,4L,4L,3L,2L,2L,2L,3L,2L,3L,2L,4L,2L,2L,4L,2L,4L,2L,2L,1L,4L,1L,2L,4L,4L,1L,2L,3L,4L,4L,4L,3L,4L,2L,2L,2L,2L,1L,4L,1L,2L,3L,2L,4L,4L,1L,4L,1L,4L,2L,2L,3L,4L,2L,4L,2L,4L,3L,4L,4L,2L,4L,2L,1L,2L,4L,4L,4L,4L,1L,2L,4L,4L,2L,2L,3L,4L,1L,2L,2L,4L,1L,2L,4L,4L,3L,2L,3L,4L,1L,4L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110630Inst : IEnumerable<long>
{
public static readonly long[] Value=A110630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110630.Bytes);
public long this[int i]=>Value[i];

public static A110630Inst Instance=new A110630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110631
{
public static readonly long[] Value={ 1L,1L,4L,3L,2L,4L,4L,2L,1L,5L,2L,1L,5L,1L,3L,2L,5L,3L,4L,4L,5L,4L,5L,2L,1L,5L,4L,1L,2L,5L,1L,5L,1L,1L,1L,2L,3L,4L,2L,2L,4L,3L,2L,5L,2L,3L,5L,1L,1L,2L,3L,3L,1L,1L,2L,2L,3L,4L,4L,1L,2L,1L,3L,4L,1L,4L,2L,3L,5L,4L,4L,3L,5L,3L,4L,2L,2L,4L,2L,2L,5L,3L,2L,4L,2L,5L,5L,5L,3L,5L,4L,4L,1L,3L,5L,1L,5L,5L,4L,3L,5L,2L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110631Inst : IEnumerable<long>
{
public static readonly long[] Value=A110631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110631.Bytes);
public long this[int i]=>Value[i];

public static A110631Inst Instance=new A110631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110632
{
public static readonly long[] Value={ 1L,6L,6L,3L,6L,2L,6L,4L,4L,6L,3L,2L,1L,2L,3L,1L,6L,6L,1L,2L,6L,4L,2L,4L,2L,6L,2L,4L,2L,6L,5L,2L,2L,1L,5L,3L,6L,6L,2L,5L,3L,1L,4L,5L,4L,6L,2L,4L,3L,1L,6L,2L,3L,3L,6L,4L,1L,6L,3L,2L,5L,3L,3L,3L,6L,6L,5L,4L,2L,5L,3L,2L,4L,3L,3L,2L,6L,6L,3L,1L,5L,3L,6L,2L,4L,2L,6L,5L,4L,3L,3L,1L,4L,2L,4L,3L,3L,6L,3L,5L,5L,4L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110632Inst : IEnumerable<long>
{
public static readonly long[] Value=A110632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110632.Bytes);
public long this[int i]=>Value[i];

public static A110632Inst Instance=new A110632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110633
{
public static readonly long[] Value={ 1L,2L,6L,4L,6L,4L,3L,2L,6L,4L,2L,6L,6L,4L,4L,2L,4L,2L,6L,4L,3L,4L,2L,6L,1L,4L,2L,2L,3L,4L,1L,6L,6L,2L,6L,6L,1L,6L,2L,6L,6L,2L,4L,6L,2L,4L,4L,4L,2L,6L,6L,2L,2L,6L,4L,4L,2L,6L,6L,4L,5L,4L,2L,6L,2L,4L,1L,2L,5L,2L,3L,4L,6L,6L,6L,6L,2L,4L,5L,2L,3L,2L,1L,2L,4L,2L,5L,2L,4L,2L,6L,2L,2L,4L,4L,4L,3L,2L,1L,2L,6L,6L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110633Inst : IEnumerable<long>
{
public static readonly long[] Value=A110633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110633.Bytes);
public long this[int i]=>Value[i];

public static A110633Inst Instance=new A110633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110634
{
public static readonly long[] Value={ 1L,3L,3L,6L,3L,6L,6L,3L,6L,3L,6L,3L,6L,3L,6L,2L,6L,6L,6L,3L,6L,4L,6L,6L,4L,3L,3L,6L,3L,3L,3L,3L,6L,2L,3L,3L,1L,6L,6L,2L,6L,6L,3L,3L,6L,1L,6L,6L,6L,3L,6L,6L,3L,6L,1L,6L,6L,2L,3L,6L,6L,3L,3L,4L,6L,6L,2L,3L,6L,4L,3L,6L,2L,6L,3L,6L,3L,6L,2L,6L,6L,4L,3L,3L,2L,3L,3L,6L,3L,3L,5L,3L,3L,2L,6L,6L,2L,3L,6L,1L,3L,3L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110634Inst : IEnumerable<long>
{
public static readonly long[] Value=A110634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110634.Bytes);
public long this[int i]=>Value[i];

public static A110634Inst Instance=new A110634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110635
{
public static readonly long[] Value={ 1L,1L,5L,1L,1L,4L,2L,1L,1L,3L,5L,1L,2L,5L,1L,7L,6L,4L,4L,6L,4L,5L,7L,3L,4L,2L,4L,3L,3L,2L,7L,4L,6L,6L,3L,1L,1L,6L,5L,6L,6L,3L,1L,2L,5L,7L,3L,3L,7L,5L,5L,6L,4L,6L,3L,4L,2L,5L,4L,4L,7L,3L,4L,1L,5L,6L,7L,2L,2L,5L,4L,1L,4L,4L,1L,1L,4L,3L,6L,7L,6L,2L,6L,6L,2L,1L,6L,6L,1L,5L,2L,2L,5L,5L,4L,2L,3L,7L,4L,5L,1L,3L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110635Inst : IEnumerable<long>
{
public static readonly long[] Value=A110635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110635.Bytes);
public long this[int i]=>Value[i];

public static A110635Inst Instance=new A110635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110636
{
public static readonly long[] Value={ 1L,7L,3L,1L,6L,6L,4L,8L,7L,8L,8L,7L,3L,3L,3L,1L,4L,3L,6L,5L,1L,6L,6L,1L,1L,5L,4L,8L,5L,5L,4L,6L,5L,8L,7L,6L,5L,6L,6L,5L,8L,4L,7L,4L,1L,3L,7L,7L,4L,6L,8L,7L,4L,8L,8L,1L,5L,3L,5L,5L,6L,2L,4L,4L,7L,2L,6L,2L,1L,4L,3L,5L,5L,3L,5L,1L,5L,3L,7L,8L,6L,5L,1L,2L,1L,1L,2L,4L,6L,1L,6L,3L,5L,1L,7L,3L,4L,2L,6L,7L,1L,3L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110636Inst : IEnumerable<long>
{
public static readonly long[] Value=A110636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110636.Bytes);
public long this[int i]=>Value[i];

public static A110636Inst Instance=new A110636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110637
{
public static readonly long[] Value={ 1L,2L,7L,4L,3L,2L,1L,8L,6L,6L,6L,4L,4L,2L,8L,8L,7L,6L,8L,6L,8L,6L,7L,8L,3L,4L,3L,6L,3L,8L,1L,4L,4L,8L,3L,6L,6L,2L,5L,8L,1L,4L,6L,4L,6L,6L,1L,8L,1L,6L,5L,8L,4L,4L,8L,4L,5L,8L,5L,2L,4L,8L,6L,4L,5L,2L,8L,8L,7L,4L,6L,4L,5L,8L,6L,8L,6L,4L,5L,4L,8L,4L,4L,4L,7L,8L,4L,2L,1L,8L,3L,4L,7L,2L,7L,8L,4L,6L,6L,4L,8L,6L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110637Inst : IEnumerable<long>
{
public static readonly long[] Value=A110637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110637.Bytes);
public long this[int i]=>Value[i];

public static A110637Inst Instance=new A110637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110638
{
public static readonly long[] Value={ 1L,4L,2L,4L,7L,8L,4L,8L,3L,8L,2L,8L,1L,8L,8L,8L,6L,4L,6L,4L,6L,8L,4L,8L,4L,8L,2L,8L,8L,8L,8L,8L,7L,8L,6L,8L,8L,4L,6L,4L,8L,8L,6L,8L,7L,4L,8L,4L,3L,4L,4L,4L,3L,8L,6L,8L,3L,8L,8L,8L,1L,8L,4L,8L,4L,8L,8L,8L,3L,8L,6L,8L,6L,8L,2L,8L,5L,8L,8L,8L,1L,8L,4L,8L,6L,4L,4L,4L,6L,8L,6L,8L,1L,4L,8L,4L,1L,8L,6L,8L,5L,4L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110638Inst : IEnumerable<long>
{
public static readonly long[] Value=A110638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110638.Bytes);
public long this[int i]=>Value[i];

public static A110638Inst Instance=new A110638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110639
{
public static readonly long[] Value={ 1L,1L,9L,9L,2L,7L,5L,3L,5L,3L,1L,7L,3L,5L,5L,9L,9L,2L,8L,3L,1L,7L,1L,1L,4L,8L,5L,1L,1L,2L,9L,2L,7L,6L,8L,6L,6L,7L,2L,2L,5L,6L,5L,9L,6L,1L,6L,7L,4L,5L,6L,4L,9L,8L,4L,1L,4L,9L,9L,2L,3L,1L,9L,4L,2L,6L,6L,8L,2L,5L,3L,2L,5L,2L,8L,2L,4L,6L,4L,8L,6L,2L,5L,2L,8L,9L,8L,1L,2L,3L,3L,2L,9L,1L,1L,1L,4L,8L,5L,5L,7L,8L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110639Inst : IEnumerable<long>
{
public static readonly long[] Value=A110639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110639.Bytes);
public long this[int i]=>Value[i];

public static A110639Inst Instance=new A110639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110640
{
public static readonly long[] Value={ 1L,3L,3L,1L,6L,6L,9L,6L,6L,9L,3L,3L,2L,6L,6L,7L,9L,9L,5L,9L,9L,3L,6L,6L,5L,9L,9L,3L,9L,9L,1L,6L,6L,7L,6L,6L,3L,9L,9L,5L,3L,3L,5L,9L,9L,9L,9L,9L,9L,6L,6L,2L,9L,9L,8L,3L,3L,3L,3L,3L,1L,3L,3L,7L,9L,9L,1L,6L,6L,1L,9L,9L,4L,3L,3L,8L,9L,9L,5L,3L,3L,1L,6L,6L,1L,6L,6L,2L,9L,9L,9L,9L,9L,2L,6L,6L,7L,3L,3L,6L,6L,6L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110640Inst : IEnumerable<long>
{
public static readonly long[] Value=A110640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110640.Bytes);
public long this[int i]=>Value[i];

public static A110640Inst Instance=new A110640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110641
{
public static readonly long[] Value={ 1L,3L,5L,8L,7L,7L,7L,9L,8L,8L,5L,6L,10L,1L,5L,5L,4L,6L,8L,2L,3L,6L,2L,2L,6L,2L,4L,4L,3L,6L,4L,3L,10L,3L,10L,6L,5L,6L,10L,2L,8L,10L,9L,1L,5L,9L,2L,10L,7L,2L,10L,3L,5L,2L,7L,3L,2L,7L,7L,7L,10L,5L,5L,9L,1L,4L,4L,9L,9L,2L,7L,4L,2L,2L,7L,7L,5L,10L,4L,5L,2L,8L,2L,7L,1L,2L,3L,6L,6L,4L,4L,10L,5L,1L,2L,10L,1L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110641Inst : IEnumerable<long>
{
public static readonly long[] Value=A110641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110641.Bytes);
public long this[int i]=>Value[i];

public static A110641Inst Instance=new A110641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110642
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,8L,8L,4L,7L,2L,7L,4L,7L,2L,9L,6L,8L,8L,8L,8L,5L,8L,6L,2L,10L,4L,1L,4L,5L,6L,5L,10L,4L,4L,6L,10L,8L,4L,2L,8L,3L,10L,6L,10L,2L,8L,2L,6L,6L,4L,2L,10L,4L,8L,4L,10L,3L,2L,6L,2L,4L,2L,3L,8L,10L,10L,3L,6L,10L,10L,6L,8L,5L,8L,6L,4L,10L,2L,2L,4L,8L,2L,10L,4L,9L,6L,1L,6L,5L,10L,9L,8L,2L,8L,10L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110642Inst : IEnumerable<long>
{
public static readonly long[] Value=A110642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110642.Bytes);
public long this[int i]=>Value[i];

public static A110642Inst Instance=new A110642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110643
{
public static readonly long[] Value={ 1L,5L,10L,5L,10L,3L,5L,10L,10L,10L,5L,5L,5L,5L,5L,8L,10L,10L,5L,10L,7L,10L,5L,10L,5L,7L,5L,5L,10L,10L,7L,10L,10L,5L,5L,9L,5L,5L,5L,10L,8L,10L,10L,10L,10L,8L,5L,5L,10L,10L,5L,10L,10L,10L,5L,6L,5L,5L,10L,5L,10L,10L,5L,10L,10L,1L,5L,5L,10L,10L,5L,5L,5L,10L,5L,5L,10L,5L,5L,10L,4L,10L,10L,5L,5L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110643Inst : IEnumerable<long>
{
public static readonly long[] Value=A110643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110643.Bytes);
public long this[int i]=>Value[i];

public static A110643Inst Instance=new A110643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110644
{
public static readonly long[] Value={ 1L,1L,7L,4L,9L,5L,5L,1L,5L,5L,11L,11L,9L,5L,11L,4L,8L,10L,10L,8L,10L,5L,11L,6L,1L,7L,1L,11L,5L,10L,1L,9L,4L,3L,9L,6L,8L,1L,6L,3L,4L,8L,2L,4L,4L,8L,10L,2L,4L,11L,1L,7L,11L,9L,11L,5L,2L,1L,4L,7L,9L,3L,2L,5L,8L,1L,8L,7L,4L,3L,2L,3L,5L,9L,1L,9L,5L,4L,1L,4L,6L,8L,5L,6L,9L,7L,4L,4L,5L,4L,6L,4L,10L,6L,6L,9L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110644Inst : IEnumerable<long>
{
public static readonly long[] Value=A110644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110644.Bytes);
public long this[int i]=>Value[i];

public static A110644Inst Instance=new A110644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110645
{
public static readonly long[] Value={ 1L,6L,12L,2L,8L,9L,2L,7L,12L,2L,3L,4L,9L,10L,12L,9L,2L,5L,12L,9L,8L,10L,1L,9L,7L,2L,9L,4L,11L,1L,10L,5L,4L,1L,12L,2L,9L,4L,5L,11L,12L,12L,9L,5L,12L,5L,3L,12L,1L,4L,6L,2L,10L,11L,5L,1L,6L,10L,12L,9L,11L,9L,9L,5L,3L,3L,7L,2L,6L,7L,5L,9L,5L,10L,12L,5L,5L,4L,4L,2L,1L,8L,7L,11L,7L,6L,1L,2L,5L,10L,9L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110645Inst : IEnumerable<long>
{
public static readonly long[] Value=A110645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110645.Bytes);
public long this[int i]=>Value[i];

public static A110645Inst Instance=new A110645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110646
{
public static readonly long[] Value={ 1L,4L,6L,8L,12L,10L,2L,12L,8L,4L,9L,4L,2L,6L,7L,8L,12L,12L,2L,2L,3L,4L,4L,2L,9L,6L,10L,6L,12L,2L,9L,10L,2L,2L,5L,6L,12L,2L,9L,8L,8L,8L,10L,8L,1L,4L,9L,10L,7L,10L,2L,6L,9L,10L,4L,8L,11L,2L,1L,4L,10L,2L,5L,2L,4L,2L,1L,8L,12L,2L,2L,12L,9L,2L,4L,4L,5L,8L,11L,4L,12L,4L,12L,6L,9L,12L,5L,6L,12L,10L,5L,12L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110646Inst : IEnumerable<long>
{
public static readonly long[] Value=A110646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110646.Bytes);
public long this[int i]=>Value[i];

public static A110646Inst Instance=new A110646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110647
{
public static readonly long[] Value={ 1L,9L,12L,6L,12L,9L,12L,6L,6L,2L,6L,12L,8L,3L,12L,9L,6L,12L,2L,3L,3L,7L,9L,9L,12L,3L,3L,2L,12L,6L,3L,9L,3L,4L,6L,3L,9L,6L,3L,10L,6L,9L,12L,9L,12L,9L,9L,6L,2L,9L,12L,5L,3L,6L,12L,9L,6L,9L,12L,6L,8L,6L,12L,10L,9L,12L,1L,9L,3L,9L,12L,6L,7L,12L,12L,2L,9L,3L,9L,12L,12L,4L,9L,9L,11L,6L,6L,1L,9L,6L,10L,3L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110647Inst : IEnumerable<long>
{
public static readonly long[] Value=A110647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110647.Bytes);
public long this[int i]=>Value[i];

public static A110647Inst Instance=new A110647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110648
{
public static readonly long[] Value={ 1L,4L,4L,8L,6L,12L,8L,12L,12L,12L,10L,12L,2L,8L,12L,4L,8L,8L,4L,4L,9L,4L,4L,12L,2L,12L,6L,8L,7L,4L,8L,12L,12L,8L,12L,8L,2L,8L,2L,8L,3L,12L,4L,12L,4L,12L,2L,12L,9L,12L,6L,12L,10L,8L,6L,12L,12L,12L,2L,8L,9L,12L,10L,12L,2L,8L,2L,4L,5L,4L,6L,12L,12L,8L,2L,12L,9L,4L,8L,4L,8L,12L,8L,4L,10L,8L,8L,12L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110648Inst : IEnumerable<long>
{
public static readonly long[] Value=A110648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110648.Bytes);
public long this[int i]=>Value[i];

public static A110648Inst Instance=new A110648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110649
{
public static readonly long[] Value={ 1L,6L,9L,4L,12L,6L,6L,12L,12L,8L,9L,12L,12L,6L,6L,10L,6L,12L,2L,6L,6L,12L,12L,12L,8L,12L,3L,4L,12L,12L,9L,6L,6L,4L,12L,12L,2L,6L,3L,6L,3L,6L,7L,6L,9L,8L,9L,12L,12L,12L,3L,12L,3L,6L,2L,6L,12L,2L,6L,6L,3L,12L,9L,4L,3L,12L,4L,12L,6L,2L,3L,12L,9L,6L,6L,6L,3L,6L,10L,6L,6L,6L,9L,6L,12L,12L,9L,2L,12L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110649Inst : IEnumerable<long>
{
public static readonly long[] Value=A110649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110649.Bytes);
public long this[int i]=>Value[i];

public static A110649Inst Instance=new A110649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110650
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,16L,2L,8L,9L,81L,3L,27L,16L,256L,4L,64L,25L,625L,5L,125L,36L,1296L,6L,216L,49L,2401L,7L,343L,64L,4096L,8L,512L,81L,6561L,9L,729L,100L,10000L,10L,1000L,121L,14641L,11L,1331L,144L,20736L,12L,1728L,169L,28561L,13L,2197L,196L,38416L,14L,2744L,225L,50625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110650Inst : IEnumerable<long>
{
public static readonly long[] Value=A110650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110650.Bytes);
public long this[int i]=>Value[i];

public static A110650Inst Instance=new A110650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110651
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,16L,8L,2L,9L,81L,27L,3L,16L,256L,64L,4L,25L,625L,125L,5L,36L,1296L,216L,6L,49L,2401L,343L,7L,64L,4096L,512L,8L,81L,6561L,729L,9L,100L,10000L,1000L,10L,121L,14641L,1331L,11L,144L,20736L,1728L,12L,169L,28561L,2197L,13L,196L,38416L,2744L,14L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110651Inst : IEnumerable<long>
{
public static readonly long[] Value=A110651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110651.Bytes);
public long this[int i]=>Value[i];

public static A110651Inst Instance=new A110651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110652
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,8L,16L,2L,9L,27L,81L,3L,16L,64L,256L,4L,25L,125L,625L,5L,36L,216L,1296L,6L,49L,343L,2401L,7L,64L,512L,4096L,8L,81L,729L,6561L,9L,100L,1000L,10000L,10L,121L,1331L,14641L,11L,144L,1728L,20736L,12L,169L,2197L,28561L,13L,196L,2744L,38416L,14L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110652Inst : IEnumerable<long>
{
public static readonly long[] Value=A110652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110652.Bytes);
public long this[int i]=>Value[i];

public static A110652Inst Instance=new A110652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110653
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,8L,2L,16L,9L,27L,3L,81L,16L,64L,4L,256L,25L,125L,5L,625L,36L,216L,6L,1296L,49L,343L,7L,2401L,64L,512L,8L,4096L,81L,729L,9L,6561L,100L,1000L,10L,10000L,121L,1331L,11L,14641L,144L,1728L,12L,20736L,169L,2197L,13L,28561L,196L,2744L,14L,38416L,225L,3375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110653Inst : IEnumerable<long>
{
public static readonly long[] Value=A110653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110653.Bytes);
public long this[int i]=>Value[i];

public static A110653Inst Instance=new A110653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110654
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110654Inst : IEnumerable<long>
{
public static readonly long[] Value=A110654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110654.Bytes);
public long this[int i]=>Value[i];

public static A110654Inst Instance=new A110654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110655
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110655Inst : IEnumerable<long>
{
public static readonly long[] Value=A110655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110655.Bytes);
public long this[int i]=>Value[i];

public static A110655Inst Instance=new A110655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110656
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110656Inst : IEnumerable<long>
{
public static readonly long[] Value=A110656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110656.Bytes);
public long this[int i]=>Value[i];

public static A110656Inst Instance=new A110656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110657
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,10L,8L,9L,10L,11L,9L,10L,11L,12L,10L,11L,12L,13L,11L,12L,13L,14L,12L,13L,14L,15L,13L,14L,15L,16L,14L,15L,16L,17L,15L,16L,17L,18L,16L,17L,18L,19L,17L,18L,19L,20L,18L,19L,20L,21L,19L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110657Inst : IEnumerable<long>
{
public static readonly long[] Value=A110657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110657.Bytes);
public long this[int i]=>Value[i];

public static A110657Inst Instance=new A110657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110658
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,2L,4L,3L,5L,4L,3L,5L,4L,3L,5L,4L,6L,5L,4L,6L,5L,4L,6L,5L,7L,6L,5L,7L,6L,5L,7L,6L,8L,7L,6L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,7L,9L,8L,10L,9L,8L,10L,9L,8L,10L,9L,11L,10L,9L,11L,10L,9L,11L,10L,12L,11L,10L,12L,11L,10L,12L,11L,13L,12L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110658Inst : IEnumerable<long>
{
public static readonly long[] Value=A110658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110658.Bytes);
public long this[int i]=>Value[i];

public static A110658Inst Instance=new A110658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110659
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,1L,1L,3L,3L,2L,2L,4L,4L,3L,3L,5L,5L,4L,4L,6L,6L,5L,5L,7L,7L,6L,6L,8L,8L,7L,7L,9L,9L,8L,8L,10L,10L,9L,9L,11L,11L,10L,10L,12L,12L,11L,11L,13L,13L,12L,12L,14L,14L,13L,13L,15L,15L,14L,14L,16L,16L,15L,15L,17L,17L,16L,16L,18L,18L,17L,17L,19L,19L,18L,18L,20L,20L,19L,19L,21L,21L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110659Inst : IEnumerable<long>
{
public static readonly long[] Value=A110659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110659.Bytes);
public long this[int i]=>Value[i];

public static A110659Inst Instance=new A110659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110660
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,6L,12L,12L,20L,20L,30L,30L,42L,42L,56L,56L,72L,72L,90L,90L,110L,110L,132L,132L,156L,156L,182L,182L,210L,210L,240L,240L,272L,272L,306L,306L,342L,342L,380L,380L,420L,420L,462L,462L,506L,506L,552L,552L,600L,600L,650L,650L,702L,702L,756L,756L,812L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110660Inst : IEnumerable<long>
{
public static readonly long[] Value=A110660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110660.Bytes);
public long this[int i]=>Value[i];

public static A110660Inst Instance=new A110660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110661
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,2L,8L,7L,5L,3L,10L,9L,7L,5L,2L,14L,13L,11L,9L,6L,4L,16L,15L,13L,11L,8L,6L,2L,20L,19L,17L,15L,12L,10L,6L,4L,23L,22L,20L,18L,15L,13L,9L,7L,3L,27L,26L,24L,22L,19L,17L,13L,11L,7L,4L,29L,28L,26L,24L,21L,19L,15L,13L,9L,6L,2L,35L,34L,32L,30L,27L,25L,21L,19L,15L,12L,8L,6L,37L,36L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110661Inst : IEnumerable<long>
{
public static readonly long[] Value=A110661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110661.Bytes);
public long this[int i]=>Value[i];

public static A110661Inst Instance=new A110661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110662
{
public static readonly long[] Value={ 1L,4L,3L,8L,7L,4L,15L,14L,11L,7L,21L,20L,17L,13L,6L,33L,32L,29L,25L,18L,12L,41L,40L,37L,33L,26L,20L,8L,56L,55L,52L,48L,41L,35L,23L,15L,69L,68L,65L,61L,54L,48L,36L,28L,13L,87L,86L,83L,79L,72L,66L,54L,46L,31L,18L,99L,98L,95L,91L,84L,78L,66L,58L,43L,30L,12L,127L,126L,123L,119L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110662Inst : IEnumerable<long>
{
public static readonly long[] Value=A110662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110662.Bytes);
public long this[int i]=>Value[i];

public static A110662Inst Instance=new A110662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110663
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,2L,6L,5L,4L,2L,10L,9L,8L,6L,4L,12L,11L,10L,8L,6L,2L,18L,17L,16L,14L,12L,8L,6L,22L,21L,20L,18L,16L,12L,10L,4L,28L,27L,26L,24L,22L,18L,16L,10L,6L,32L,31L,30L,28L,26L,22L,20L,14L,10L,4L,42L,41L,40L,38L,36L,32L,30L,24L,20L,14L,10L,46L,45L,44L,42L,40L,36L,34L,28L,24L,18L,14L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110663Inst : IEnumerable<long>
{
public static readonly long[] Value=A110663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110663.Bytes);
public long this[int i]=>Value[i];

public static A110663Inst Instance=new A110663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110664
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,4L,4L,3L,2L,5L,5L,4L,3L,1L,7L,7L,6L,5L,3L,2L,8L,8L,7L,6L,4L,3L,1L,11L,11L,10L,9L,7L,6L,4L,3L,13L,13L,12L,11L,9L,8L,6L,5L,2L,15L,15L,14L,13L,11L,10L,8L,7L,4L,2L,16L,16L,15L,14L,12L,11L,9L,8L,5L,3L,1L,19L,19L,18L,17L,15L,14L,12L,11L,8L,6L,4L,3L,20L,20L,19L,18L,16L,15L,13L,12L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110664Inst : IEnumerable<long>
{
public static readonly long[] Value=A110664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110664.Bytes);
public long this[int i]=>Value[i];

public static A110664Inst Instance=new A110664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110665
{
public static readonly long[] Value={ 0L,1L,0L,-3L,-4L,0L,6L,7L,0L,-9L,-10L,0L,12L,13L,0L,-15L,-16L,0L,18L,19L,0L,-21L,-22L,0L,24L,25L,0L,-27L,-28L,0L,30L,31L,0L,-33L,-34L,0L,36L,37L,0L,-39L,-40L,0L,42L,43L,0L,-45L,-46L,0L,48L,49L,0L,-51L,-52L,0L,54L,55L,0L,-57L,-58L,0L,60L,61L,0L,-63L,-64L,0L,66L,67L,0L,-69L,-70L,0L,72L,73L,0L,-75L,-76L,0L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110665Inst : IEnumerable<long>
{
public static readonly long[] Value=A110665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110665.Bytes);
public long this[int i]=>Value[i];

public static A110665Inst Instance=new A110665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110666
{
public static readonly long[] Value={ 0L,1L,1L,-2L,-6L,-6L,0L,7L,7L,-2L,-12L,-12L,0L,13L,13L,-2L,-18L,-18L,0L,19L,19L,-2L,-24L,-24L,0L,25L,25L,-2L,-30L,-30L,0L,31L,31L,-2L,-36L,-36L,0L,37L,37L,-2L,-42L,-42L,0L,43L,43L,-2L,-48L,-48L,0L,49L,49L,-2L,-54L,-54L,0L,55L,55L,-2L,-60L,-60L,0L,61L,61L,-2L,-66L,-66L,0L,67L,67L,-2L,-72L,-72L,0L,73L,73L,-2L,-78L,-78L,0L,79L,79L,-2L,-84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110666Inst : IEnumerable<long>
{
public static readonly long[] Value=A110666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110666.Bytes);
public long this[int i]=>Value[i];

public static A110666Inst Instance=new A110666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110667
{
public static readonly long[] Value={ 0L,1L,2L,0L,-6L,-12L,-12L,-5L,2L,0L,-12L,-24L,-24L,-11L,2L,0L,-18L,-36L,-36L,-17L,2L,0L,-24L,-48L,-48L,-23L,2L,0L,-30L,-60L,-60L,-29L,2L,0L,-36L,-72L,-72L,-35L,2L,0L,-42L,-84L,-84L,-41L,2L,0L,-48L,-96L,-96L,-47L,2L,0L,-54L,-108L,-108L,-53L,2L,0L,-60L,-120L,-120L,-59L,2L,0L,-66L,-132L,-132L,-65L,2L,0L,-72L,-144L,-144L,-71L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110667Inst : IEnumerable<long>
{
public static readonly long[] Value=A110667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110667.Bytes);
public long this[int i]=>Value[i];

public static A110667Inst Instance=new A110667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110668
{
public static readonly long[] Value={ 0L,1L,3L,3L,-3L,-15L,-27L,-32L,-30L,-30L,-42L,-66L,-90L,-101L,-99L,-99L,-117L,-153L,-189L,-206L,-204L,-204L,-228L,-276L,-324L,-347L,-345L,-345L,-375L,-435L,-495L,-524L,-522L,-522L,-558L,-630L,-702L,-737L,-735L,-735L,-777L,-861L,-945L,-986L,-984L,-984L,-1032L,-1128L,-1224L,-1271L,-1269L,-1269L,-1323L,-1431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110668Inst : IEnumerable<long>
{
public static readonly long[] Value=A110668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110668.Bytes);
public long this[int i]=>Value[i];

public static A110668Inst Instance=new A110668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110669
{
public static readonly long[] Value={ 0L,1L,4L,7L,4L,-11L,-38L,-70L,-100L,-130L,-172L,-238L,-328L,-429L,-528L,-627L,-744L,-897L,-1086L,-1292L,-1496L,-1700L,-1928L,-2204L,-2528L,-2875L,-3220L,-3565L,-3940L,-4375L,-4870L,-5394L,-5916L,-6438L,-6996L,-7626L,-8328L,-9065L,-9800L,-10535L,-11312L,-12173L,-13118L,-14104L,-15088L,-16072L,-17104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110669Inst : IEnumerable<long>
{
public static readonly long[] Value=A110669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110669.Bytes);
public long this[int i]=>Value[i];

public static A110669Inst Instance=new A110669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110670
{
public static readonly long[] Value={ 0L,1L,5L,12L,16L,5L,-33L,-103L,-203L,-333L,-505L,-743L,-1071L,-1500L,-2028L,-2655L,-3399L,-4296L,-5382L,-6674L,-8170L,-9870L,-11798L,-14002L,-16530L,-19405L,-22625L,-26190L,-30130L,-34505L,-39375L,-44769L,-50685L,-57123L,-64119L,-71745L,-80073L,-89138L,-98938L,-109473L,-120785L,-132958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110670Inst : IEnumerable<long>
{
public static readonly long[] Value=A110670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110670.Bytes);
public long this[int i]=>Value[i];

public static A110670Inst Instance=new A110670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110671
{
public static readonly long[] Value={ 0L,1L,6L,18L,34L,39L,6L,-97L,-300L,-633L,-1138L,-1881L,-2952L,-4452L,-6480L,-9135L,-12534L,-16830L,-22212L,-28886L,-37056L,-46926L,-58724L,-72726L,-89256L,-108661L,-131286L,-157476L,-187606L,-222111L,-261486L,-306255L,-356940L,-414063L,-478182L,-549927L,-630000L,-719138L,-818076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110671Inst : IEnumerable<long>
{
public static readonly long[] Value=A110671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110671.Bytes);
public long this[int i]=>Value[i];

public static A110671Inst Instance=new A110671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110672
{
public static readonly long[] Value={ 0L,1L,7L,25L,59L,98L,104L,7L,-293L,-926L,-2064L,-3945L,-6897L,-11349L,-17829L,-26964L,-39498L,-56328L,-78540L,-107426L,-144482L,-191408L,-250132L,-322858L,-412114L,-520775L,-652061L,-809537L,-997143L,-1219254L,-1480740L,-1786995L,-2143935L,-2557998L,-3036180L,-3586107L,-4216107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110672Inst : IEnumerable<long>
{
public static readonly long[] Value=A110672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110672.Bytes);
public long this[int i]=>Value[i];

public static A110672Inst Instance=new A110672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110673
{
public static readonly long[] Value={ 23L,37L,47L,53L,67L,79L,83L,89L,93L,97L,113L,117L,119L,121L,123L,127L,131L,143L,145L,157L,163L,167L,173L,185L,187L,203L,205L,207L,211L,215L,217L,219L,223L,233L,245L,247L,251L,257L,263L,277L,287L,289L,293L,297L,299L,301L,303L,307L,317L,321L,323L,325L,327L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110673Inst : IEnumerable<long>
{
public static readonly long[] Value=A110673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110673.Bytes);
public long this[int i]=>Value[i];

public static A110673Inst Instance=new A110673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110674
{
public static readonly long[] Value={ 3L,7L,9L,19L,21L,27L,43L,49L,87L,91L,151L,157L,169L,181L,183L,189L,211L,213L,219L,247L,259L,283L,289L,301L,333L,339L,351L,361L,379L,393L,399L,423L,427L,433L,447L,457L,489L,493L,499L,531L,543L,547L,553L,559L,573L,577L,637L,639L,651L,661L,667L,673L,687L,703L,711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110674Inst : IEnumerable<long>
{
public static readonly long[] Value=A110674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110674.Bytes);
public long this[int i]=>Value[i];

public static A110674Inst Instance=new A110674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110675
{
public static readonly long[] Value={ 9L,47L,69L,89L,93L,123L,141L,147L,167L,177L,203L,219L,239L,243L,249L,251L,263L,273L,281L,287L,293L,309L,317L,321L,327L,333L,351L,377L,383L,387L,443L,477L,501L,503L,509L,527L,533L,537L,543L,567L,573L,579L,593L,599L,611L,617L,621L,629L,653L,659L,663L,683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110675Inst : IEnumerable<long>
{
public static readonly long[] Value=A110675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110675.Bytes);
public long this[int i]=>Value[i];

public static A110675Inst Instance=new A110675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110676
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,3L,6L,3L,5L,4L,5L,5L,9L,3L,4L,9L,3L,6L,10L,6L,7L,6L,11L,5L,11L,10L,5L,10L,9L,3L,12L,6L,10L,9L,5L,6L,13L,9L,6L,11L,6L,10L,16L,4L,4L,6L,9L,6L,11L,8L,4L,10L,10L,5L,13L,10L,7L,11L,6L,6L,21L,4L,23L,8L,6L,8L,15L,15L,7L,12L,7L,8L,19L,8L,13L,14L,5L,6L,20L,6L,10L,13L,12L,7L,9L,9L,6L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110676Inst : IEnumerable<long>
{
public static readonly long[] Value=A110676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110676.Bytes);
public long this[int i]=>Value[i];

public static A110676Inst Instance=new A110676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110677
{
public static readonly long[] Value={ 1L,23L,31L,37L,41L,49L,67L,83L,97L,103L,119L,131L,133L,163L,199L,203L,217L,221L,233L,251L,257L,263L,277L,283L,301L,307L,311L,313L,331L,373L,383L,391L,397L,401L,419L,427L,431L,433L,439L,469L,481L,497L,509L,511L,527L,593L,601L,611L,619L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110677Inst : IEnumerable<long>
{
public static readonly long[] Value=A110677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110677.Bytes);
public long this[int i]=>Value[i];

public static A110677Inst Instance=new A110677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110678
{
public static readonly long[] Value={ 72L,70L,66L,60L,52L,42L,30L,16L,0L,-18L,-38L,-60L,-84L,-110L,-138L,-168L,-200L,-234L,-270L,-308L,-348L,-390L,-434L,-480L,-528L,-578L,-630L,-684L,-740L,-798L,-858L,-920L,-984L,-1050L,-1118L,-1188L,-1260L,-1334L,-1410L,-1488L,-1568L,-1650L,-1734L,-1820L,-1908L,-1998L,-2090L,-2184L,-2280L,-2378L,-2478L,-2580L,-2684L,-2790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110678Inst : IEnumerable<long>
{
public static readonly long[] Value=A110678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110678.Bytes);
public long this[int i]=>Value[i];

public static A110678Inst Instance=new A110678Inst();

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