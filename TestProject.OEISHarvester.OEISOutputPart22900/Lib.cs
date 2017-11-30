using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A039509
{
public static readonly long[] Value={ 1L,6L,10L,11L,16L,18L,20L,30L,33L,53L,54L,118L,181L,596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039509Inst : IEnumerable<long>
{
public static readonly long[] Value=A039509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039509.Bytes);
public long this[int i]=>Value[i];

public static A039509Inst Instance=new A039509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039508
{
public static readonly long[] Value={ 1L,1L,6L,2L,1L,3L,10L,6L,3L,2L,2L,4L,8L,1L,5L,2L,3L,9L,4L,10L,2L,2L,6L,8L,3L,3L,2L,11L,2L,8L,3L,2L,16L,2L,4L,8L,4L,8L,5L,5L,1L,4L,9L,5L,2L,14L,2L,10L,3L,3L,8L,3L,9L,2L,2L,4L,2L,11L,10L,9L,5L,2L,12L,3L,2L,4L,5L,6L,6L,2L,8L,15L,13L,3L,3L,3L,3L,8L,2L,2L,9L,3L,11L,4L,12L,2L,3L,18L,8L,2L,4L,3L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039508Inst : IEnumerable<long>
{
public static readonly long[] Value=A039508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039508.Bytes);
public long this[int i]=>Value[i];

public static A039508Inst Instance=new A039508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039507
{
public static readonly long[] Value={ 0L,1L,68L,808L,7784L,70210L,624561L,5559246L,49787726L,449315793L,4086143347L,37425892724L,345004813781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039507Inst : IEnumerable<long>
{
public static readonly long[] Value=A039507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039507.Bytes);
public long this[int i]=>Value[i];

public static A039507Inst Instance=new A039507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039506
{
public static readonly long[] Value={ 3L,23L,99L,420L,1807L,8287L,40017L,202208L,1059807L,5736717L,31911465L,182019293L,1060723057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039506Inst : IEnumerable<long>
{
public static readonly long[] Value=A039506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039506.Bytes);
public long this[int i]=>Value[i];

public static A039506Inst Instance=new A039506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039505
{
public static readonly long[] Value={ 17L,21L,23L,25L,31L,33L,37L,41L,45L,49L,55L,61L,67L,73L,83L,91L,99L,109L,111L,117L,123L,131L,147L,153L,163L,165L,175L,179L,185L,195L,197L,209L,213L,219L,221L,225L,229L,233L,239L,243L,247L,257L,261L,263L,267L,277L,279L,291L,293L,295L,305L,311L,313L,319L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039505Inst : IEnumerable<long>
{
public static readonly long[] Value=A039505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039505.Bytes);
public long this[int i]=>Value[i];

public static A039505Inst Instance=new A039505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039504
{
public static readonly long[] Value={ 5L,7L,9L,13L,19L,27L,35L,47L,51L,63L,75L,81L,89L,93L,107L,119L,121L,125L,133L,139L,143L,149L,159L,161L,167L,177L,181L,187L,191L,199L,203L,215L,223L,237L,241L,251L,255L,265L,271L,281L,285L,287L,297L,299L,317L,323L,333L,335L,341L,353L,355L,357L,361L,371L,375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039504Inst : IEnumerable<long>
{
public static readonly long[] Value=A039504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039504.Bytes);
public long this[int i]=>Value[i];

public static A039504Inst Instance=new A039504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039503
{
public static readonly long[] Value={ 1L,3L,11L,15L,29L,39L,43L,53L,57L,59L,65L,69L,71L,77L,79L,85L,87L,95L,97L,101L,103L,105L,113L,115L,127L,129L,135L,137L,141L,145L,151L,155L,157L,169L,171L,173L,183L,189L,193L,201L,205L,207L,211L,217L,227L,231L,235L,245L,249L,253L,259L,269L,273L,275L,283L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039503Inst : IEnumerable<long>
{
public static readonly long[] Value=A039503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039503.Bytes);
public long this[int i]=>Value[i];

public static A039503Inst Instance=new A039503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039502
{
public static readonly long[] Value={ 17L,21L,23L,25L,31L,33L,34L,37L,41L,42L,45L,46L,49L,50L,55L,61L,62L,66L,67L,68L,73L,74L,82L,83L,84L,90L,91L,92L,98L,99L,100L,109L,110L,111L,117L,122L,123L,124L,131L,132L,134L,136L,146L,147L,148L,153L,163L,164L,165L,166L,168L,175L,179L,180L,182L,184L,185L,195L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039502Inst : IEnumerable<long>
{
public static readonly long[] Value=A039502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039502.Bytes);
public long this[int i]=>Value[i];

public static A039502Inst Instance=new A039502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039501
{
public static readonly long[] Value={ 5L,7L,9L,10L,13L,14L,18L,19L,20L,26L,27L,28L,35L,36L,38L,40L,47L,51L,52L,54L,56L,63L,70L,72L,75L,76L,80L,81L,89L,93L,94L,102L,104L,107L,108L,112L,119L,121L,125L,126L,133L,139L,140L,143L,144L,149L,150L,152L,159L,160L,161L,162L,167L,177L,178L,181L,186L,187L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039501Inst : IEnumerable<long>
{
public static readonly long[] Value=A039501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039501.Bytes);
public long this[int i]=>Value[i];

public static A039501Inst Instance=new A039501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039484
{
public static readonly long[] Value={ 74L,94L,195L,215L,316L,336L,437L,457L,558L,578L,679L,699L,734L,745L,756L,767L,778L,789L,811L,814L,815L,816L,817L,818L,819L,821L,823L,824L,833L,844L,921L,941L,974L,985L,996L,1007L,1018L,1029L,1034L,1035L,1036L,1037L,1038L,1039L,1041L,1043L,1044L,1051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039484Inst : IEnumerable<long>
{
public static readonly long[] Value=A039484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039484.Bytes);
public long this[int i]=>Value[i];

public static A039484Inst Instance=new A039484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039483
{
public static readonly long[] Value={ 73L,83L,194L,204L,315L,325L,436L,446L,557L,567L,678L,688L,733L,744L,755L,766L,777L,788L,803L,804L,805L,806L,807L,808L,811L,812L,813L,821L,832L,843L,853L,864L,875L,886L,897L,908L,913L,914L,915L,916L,917L,918L,921L,922L,923L,941L,952L,963L,1041L,1051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039483Inst : IEnumerable<long>
{
public static readonly long[] Value=A039483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039483.Bytes);
public long this[int i]=>Value[i];

public static A039483Inst Instance=new A039483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039482
{
public static readonly long[] Value={ 65L,115L,186L,236L,307L,357L,428L,478L,549L,599L,615L,626L,637L,648L,659L,681L,692L,703L,714L,715L,716L,717L,718L,719L,721L,722L,723L,724L,791L,841L,912L,962L,1033L,1083L,1154L,1204L,1215L,1226L,1237L,1248L,1259L,1265L,1266L,1267L,1268L,1269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039482Inst : IEnumerable<long>
{
public static readonly long[] Value=A039482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039482.Bytes);
public long this[int i]=>Value[i];

public static A039482Inst Instance=new A039482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039481
{
public static readonly long[] Value={ 64L,104L,185L,225L,306L,346L,427L,467L,548L,588L,614L,625L,636L,647L,658L,680L,691L,702L,704L,705L,706L,707L,708L,710L,711L,712L,714L,724L,790L,830L,911L,951L,1032L,1072L,1094L,1105L,1116L,1127L,1138L,1144L,1145L,1146L,1147L,1148L,1150L,1151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039481Inst : IEnumerable<long>
{
public static readonly long[] Value=A039481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039481.Bytes);
public long this[int i]=>Value[i];

public static A039481Inst Instance=new A039481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039480
{
public static readonly long[] Value={ 63L,93L,184L,214L,305L,335L,426L,456L,547L,577L,613L,624L,635L,646L,657L,679L,690L,693L,694L,695L,696L,697L,699L,700L,702L,703L,712L,723L,789L,819L,910L,940L,973L,984L,995L,1006L,1017L,1023L,1024L,1025L,1026L,1027L,1029L,1030L,1032L,1033L,1039L,1050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039480Inst : IEnumerable<long>
{
public static readonly long[] Value=A039480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039480.Bytes);
public long this[int i]=>Value[i];

public static A039480Inst Instance=new A039480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039479
{
public static readonly long[] Value={ 62L,82L,183L,203L,304L,324L,425L,445L,546L,566L,612L,623L,634L,645L,656L,678L,682L,683L,684L,685L,686L,688L,690L,691L,692L,700L,711L,722L,788L,808L,852L,863L,874L,885L,896L,902L,903L,904L,905L,906L,908L,910L,911L,912L,918L,940L,951L,962L,1030L,1050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039479Inst : IEnumerable<long>
{
public static readonly long[] Value=A039479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039479.Bytes);
public long this[int i]=>Value[i];

public static A039479Inst Instance=new A039479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039478
{
public static readonly long[] Value={ 61L,71L,182L,192L,303L,313L,424L,434L,545L,555L,611L,622L,633L,644L,655L,671L,672L,673L,674L,675L,678L,679L,680L,681L,688L,699L,710L,721L,731L,742L,753L,764L,775L,781L,782L,783L,784L,785L,788L,789L,790L,791L,808L,819L,830L,841L,908L,918L,1029L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039478Inst : IEnumerable<long>
{
public static readonly long[] Value=A039478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039478.Bytes);
public long this[int i]=>Value[i];

public static A039478Inst Instance=new A039478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039477
{
public static readonly long[] Value={ 54L,114L,175L,235L,296L,356L,417L,477L,494L,505L,516L,527L,549L,560L,571L,582L,593L,594L,595L,596L,597L,599L,600L,601L,602L,603L,659L,719L,780L,840L,901L,961L,1022L,1082L,1143L,1203L,1214L,1225L,1236L,1247L,1254L,1255L,1256L,1257L,1259L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039477Inst : IEnumerable<long>
{
public static readonly long[] Value=A039477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039477.Bytes);
public long this[int i]=>Value[i];

public static A039477Inst Instance=new A039477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039476
{
public static readonly long[] Value={ 53L,103L,174L,224L,295L,345L,416L,466L,493L,504L,515L,526L,548L,559L,570L,581L,583L,584L,585L,586L,588L,589L,590L,591L,593L,603L,658L,708L,779L,829L,900L,950L,1021L,1071L,1093L,1104L,1115L,1126L,1133L,1134L,1135L,1136L,1138L,1139L,1140L,1141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039476Inst : IEnumerable<long>
{
public static readonly long[] Value=A039476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039476.Bytes);
public long this[int i]=>Value[i];

public static A039476Inst Instance=new A039476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039475
{
public static readonly long[] Value={ 52L,92L,173L,213L,294L,334L,415L,455L,492L,503L,514L,525L,547L,558L,569L,572L,573L,574L,575L,577L,578L,579L,581L,582L,591L,602L,657L,697L,778L,818L,899L,939L,972L,983L,994L,1005L,1012L,1013L,1014L,1015L,1017L,1018L,1019L,1021L,1022L,1027L,1038L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039475Inst : IEnumerable<long>
{
public static readonly long[] Value=A039475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039475.Bytes);
public long this[int i]=>Value[i];

public static A039475Inst Instance=new A039475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039474
{
public static readonly long[] Value={ 51L,81L,172L,202L,293L,323L,414L,444L,491L,502L,513L,524L,546L,557L,561L,562L,563L,564L,566L,567L,569L,570L,571L,579L,590L,601L,656L,686L,777L,807L,851L,862L,873L,884L,891L,892L,893L,894L,896L,897L,899L,900L,901L,906L,917L,939L,950L,961L,1019L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039474Inst : IEnumerable<long>
{
public static readonly long[] Value=A039474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039474.Bytes);
public long this[int i]=>Value[i];

public static A039474Inst Instance=new A039474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039473
{
public static readonly long[] Value={ 50L,70L,171L,191L,292L,312L,413L,433L,490L,501L,512L,523L,545L,550L,551L,552L,553L,555L,557L,558L,559L,560L,567L,578L,589L,600L,655L,675L,730L,741L,752L,763L,770L,771L,772L,773L,775L,777L,778L,779L,780L,785L,807L,818L,829L,840L,897L,917L,1018L,1038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039473Inst : IEnumerable<long>
{
public static readonly long[] Value=A039473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039473.Bytes);
public long this[int i]=>Value[i];

public static A039473Inst Instance=new A039473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039472
{
public static readonly long[] Value={ 49L,59L,170L,180L,291L,301L,412L,422L,489L,500L,511L,522L,539L,540L,541L,542L,545L,546L,547L,548L,549L,555L,566L,577L,588L,599L,609L,620L,631L,642L,649L,650L,651L,652L,655L,656L,657L,658L,659L,675L,686L,697L,708L,719L,775L,785L,896L,906L,1017L,1027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039472Inst : IEnumerable<long>
{
public static readonly long[] Value=A039472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039472.Bytes);
public long this[int i]=>Value[i];

public static A039472Inst Instance=new A039472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039471
{
public static readonly long[] Value={ 43L,113L,164L,234L,285L,355L,373L,384L,395L,417L,428L,439L,450L,461L,472L,473L,474L,475L,477L,478L,479L,480L,481L,482L,527L,597L,648L,718L,769L,839L,890L,960L,1011L,1081L,1132L,1202L,1213L,1224L,1235L,1243L,1244L,1245L,1247L,1248L,1249L,1250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039471Inst : IEnumerable<long>
{
public static readonly long[] Value=A039471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039471.Bytes);
public long this[int i]=>Value[i];

public static A039471Inst Instance=new A039471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039470
{
public static readonly long[] Value={ 42L,102L,163L,223L,284L,344L,372L,383L,394L,416L,427L,438L,449L,460L,462L,463L,464L,466L,467L,468L,469L,470L,472L,482L,526L,586L,647L,707L,768L,828L,889L,949L,1010L,1070L,1092L,1103L,1114L,1122L,1123L,1124L,1126L,1127L,1128L,1129L,1130L,1132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039470Inst : IEnumerable<long>
{
public static readonly long[] Value=A039470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039470.Bytes);
public long this[int i]=>Value[i];

public static A039470Inst Instance=new A039470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039469
{
public static readonly long[] Value={ 41L,91L,162L,212L,283L,333L,371L,382L,393L,415L,426L,437L,448L,451L,452L,453L,455L,456L,457L,458L,460L,461L,470L,481L,525L,575L,646L,696L,767L,817L,888L,938L,971L,982L,993L,1001L,1002L,1003L,1005L,1006L,1007L,1008L,1010L,1011L,1015L,1026L,1037L,1048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039469Inst : IEnumerable<long>
{
public static readonly long[] Value=A039469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039469.Bytes);
public long this[int i]=>Value[i];

public static A039469Inst Instance=new A039469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039452
{
public static readonly long[] Value={ 17L,67L,127L,149L,160L,171L,182L,187L,189L,190L,191L,192L,194L,195L,196L,197L,204L,215L,226L,237L,259L,309L,380L,430L,501L,551L,622L,672L,727L,737L,739L,740L,741L,742L,744L,745L,746L,747L,749L,760L,771L,782L,804L,815L,826L,837L,864L,914L,985L,1035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039452Inst : IEnumerable<long>
{
public static readonly long[] Value=A039452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039452.Bytes);
public long this[int i]=>Value[i];

public static A039452Inst Instance=new A039452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039451
{
public static readonly long[] Value={ 16L,56L,126L,148L,159L,170L,176L,178L,179L,180L,182L,183L,184L,185L,186L,192L,203L,214L,225L,236L,258L,298L,379L,419L,500L,540L,606L,616L,618L,619L,620L,622L,623L,624L,625L,626L,628L,639L,650L,672L,683L,694L,705L,716L,742L,782L,863L,903L,984L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039451Inst : IEnumerable<long>
{
public static readonly long[] Value=A039451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039451.Bytes);
public long this[int i]=>Value[i];

public static A039451Inst Instance=new A039451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039450
{
public static readonly long[] Value={ 15L,45L,125L,147L,158L,165L,167L,168L,170L,171L,172L,173L,174L,175L,180L,191L,202L,213L,224L,235L,257L,287L,378L,408L,485L,495L,497L,498L,500L,501L,502L,503L,504L,505L,507L,518L,540L,551L,562L,573L,584L,595L,620L,650L,741L,771L,862L,892L,983L,1013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039450Inst : IEnumerable<long>
{
public static readonly long[] Value=A039450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039450.Bytes);
public long this[int i]=>Value[i];

public static A039450Inst Instance=new A039450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039449
{
public static readonly long[] Value={ 14L,34L,124L,146L,154L,156L,158L,159L,160L,161L,162L,163L,164L,168L,179L,190L,201L,212L,223L,234L,256L,276L,364L,374L,376L,378L,379L,380L,381L,382L,383L,384L,386L,408L,419L,430L,441L,452L,463L,474L,498L,518L,619L,639L,740L,760L,861L,881L,982L,1002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039449Inst : IEnumerable<long>
{
public static readonly long[] Value=A039449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039449.Bytes);
public long this[int i]=>Value[i];

public static A039449Inst Instance=new A039449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039448
{
public static readonly long[] Value={ 13L,23L,123L,143L,146L,147L,148L,149L,150L,151L,152L,153L,156L,167L,178L,189L,200L,211L,222L,233L,243L,253L,256L,257L,258L,259L,260L,261L,262L,263L,276L,287L,298L,309L,320L,331L,342L,353L,376L,386L,497L,507L,618L,628L,739L,749L,860L,870L,981L,991L,1102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039448Inst : IEnumerable<long>
{
public static readonly long[] Value=A039448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039448.Bytes);
public long this[int i]=>Value[i];

public static A039448Inst Instance=new A039448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039447
{
public static readonly long[] Value={ 110L,131L,231L,252L,352L,373L,473L,494L,594L,615L,715L,736L,836L,857L,957L,978L,1078L,1099L,1199L,1211L,1212L,1213L,1214L,1215L,1216L,1217L,1218L,1219L,1221L,1232L,1243L,1254L,1265L,1276L,1287L,1298L,1309L,1352L,1363L,1374L,1385L,1396L,1407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039447Inst : IEnumerable<long>
{
public static readonly long[] Value=A039447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039447.Bytes);
public long this[int i]=>Value[i];

public static A039447Inst Instance=new A039447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039446
{
public static readonly long[] Value={ 99L,130L,220L,251L,341L,372L,462L,493L,583L,614L,704L,735L,825L,856L,946L,977L,1067L,1090L,1091L,1092L,1093L,1094L,1095L,1096L,1097L,1099L,1100L,1111L,1122L,1133L,1144L,1155L,1166L,1177L,1199L,1219L,1309L,1351L,1362L,1373L,1384L,1395L,1406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039446Inst : IEnumerable<long>
{
public static readonly long[] Value=A039446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039446.Bytes);
public long this[int i]=>Value[i];

public static A039446Inst Instance=new A039446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039445
{
public static readonly long[] Value={ 88L,129L,209L,250L,330L,371L,451L,492L,572L,613L,693L,734L,814L,855L,935L,969L,970L,971L,972L,973L,974L,975L,977L,978L,979L,990L,1001L,1012L,1023L,1034L,1045L,1067L,1078L,1097L,1177L,1218L,1298L,1350L,1361L,1372L,1383L,1394L,1405L,1416L,1420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039445Inst : IEnumerable<long>
{
public static readonly long[] Value=A039445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039445.Bytes);
public long this[int i]=>Value[i];

public static A039445Inst Instance=new A039445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039444
{
public static readonly long[] Value={ 77L,128L,198L,249L,319L,370L,440L,491L,561L,612L,682L,733L,803L,848L,849L,850L,851L,852L,853L,855L,856L,857L,858L,869L,880L,891L,902L,913L,935L,946L,957L,975L,1045L,1096L,1166L,1217L,1287L,1349L,1360L,1371L,1382L,1393L,1404L,1409L,1410L,1411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039444Inst : IEnumerable<long>
{
public static readonly long[] Value=A039444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039444.Bytes);
public long this[int i]=>Value[i];

public static A039444Inst Instance=new A039444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039443
{
public static readonly long[] Value={ 66L,127L,187L,248L,308L,369L,429L,490L,550L,611L,671L,727L,728L,729L,730L,731L,733L,734L,735L,736L,737L,748L,759L,770L,781L,803L,814L,825L,836L,853L,913L,974L,1034L,1095L,1155L,1216L,1276L,1348L,1359L,1370L,1381L,1392L,1398L,1399L,1400L,1401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039443Inst : IEnumerable<long>
{
public static readonly long[] Value=A039443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039443.Bytes);
public long this[int i]=>Value[i];

public static A039443Inst Instance=new A039443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039442
{
public static readonly long[] Value={ 55L,126L,176L,247L,297L,368L,418L,489L,539L,606L,607L,608L,609L,611L,612L,613L,614L,615L,616L,627L,638L,649L,671L,682L,693L,704L,715L,731L,781L,852L,902L,973L,1023L,1094L,1144L,1215L,1265L,1347L,1358L,1369L,1380L,1387L,1388L,1389L,1390L,1392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039442Inst : IEnumerable<long>
{
public static readonly long[] Value=A039442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039442.Bytes);
public long this[int i]=>Value[i];

public static A039442Inst Instance=new A039442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039441
{
public static readonly long[] Value={ 44L,125L,165L,246L,286L,367L,407L,485L,486L,487L,489L,490L,491L,492L,493L,494L,495L,506L,517L,539L,550L,561L,572L,583L,594L,609L,649L,730L,770L,851L,891L,972L,1012L,1093L,1133L,1214L,1254L,1346L,1357L,1368L,1376L,1377L,1378L,1380L,1381L,1382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039441Inst : IEnumerable<long>
{
public static readonly long[] Value=A039441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039441.Bytes);
public long this[int i]=>Value[i];

public static A039441Inst Instance=new A039441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039440
{
public static readonly long[] Value={ 33L,124L,154L,245L,275L,364L,365L,367L,368L,369L,370L,371L,372L,373L,374L,385L,407L,418L,429L,440L,451L,462L,473L,487L,517L,608L,638L,729L,759L,850L,880L,971L,1001L,1092L,1122L,1213L,1243L,1345L,1356L,1365L,1366L,1368L,1369L,1370L,1371L,1372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039440Inst : IEnumerable<long>
{
public static readonly long[] Value=A039440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039440.Bytes);
public long this[int i]=>Value[i];

public static A039440Inst Instance=new A039440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039439
{
public static readonly long[] Value={ 22L,123L,143L,243L,245L,246L,247L,248L,249L,250L,251L,252L,253L,275L,286L,297L,308L,319L,330L,341L,352L,365L,385L,486L,506L,607L,627L,728L,748L,849L,869L,970L,990L,1091L,1111L,1212L,1232L,1344L,1354L,1356L,1357L,1358L,1359L,1360L,1361L,1362L,1363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039439Inst : IEnumerable<long>
{
public static readonly long[] Value=A039439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039439.Bytes);
public long this[int i]=>Value[i];

public static A039439Inst Instance=new A039439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039438
{
public static readonly long[] Value={ 11L,123L,124L,125L,126L,127L,128L,129L,130L,131L,143L,154L,165L,176L,187L,198L,209L,220L,231L,243L,253L,364L,374L,485L,495L,606L,616L,727L,737L,848L,858L,969L,979L,1090L,1100L,1211L,1221L,1332L,1342L,1355L,1356L,1357L,1358L,1359L,1360L,1361L,1362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039438Inst : IEnumerable<long>
{
public static readonly long[] Value=A039438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039438.Bytes);
public long this[int i]=>Value[i];

public static A039438Inst Instance=new A039438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039437
{
public static readonly long[] Value={ 89L,98L,189L,198L,289L,298L,389L,398L,489L,498L,589L,598L,689L,698L,789L,798L,809L,819L,829L,839L,849L,859L,869L,879L,890L,891L,892L,893L,894L,895L,896L,897L,908L,918L,928L,938L,948L,958L,968L,978L,980L,981L,982L,983L,984L,985L,986L,987L,1089L,1098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039437Inst : IEnumerable<long>
{
public static readonly long[] Value=A039437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039437.Bytes);
public long this[int i]=>Value[i];

public static A039437Inst Instance=new A039437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039388
{
public static readonly long[] Value={ 52L,68L,133L,149L,214L,230L,295L,311L,376L,392L,412L,421L,430L,439L,448L,466L,468L,469L,470L,471L,472L,474L,476L,484L,538L,554L,572L,581L,590L,599L,608L,612L,613L,614L,615L,616L,618L,620L,626L,644L,700L,716L,781L,797L,862L,878L,943L,959L,1024L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039388Inst : IEnumerable<long>
{
public static readonly long[] Value=A039388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039388.Bytes);
public long this[int i]=>Value[i];

public static A039388Inst Instance=new A039388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039387
{
public static readonly long[] Value={ 51L,59L,132L,140L,213L,221L,294L,302L,375L,383L,411L,420L,429L,438L,447L,459L,460L,461L,462L,463L,466L,467L,474L,483L,491L,500L,509L,518L,527L,531L,532L,533L,534L,535L,538L,539L,554L,563L,618L,626L,699L,707L,780L,788L,861L,869L,942L,950L,1023L,1031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039387Inst : IEnumerable<long>
{
public static readonly long[] Value=A039387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039387.Bytes);
public long this[int i]=>Value[i];

public static A039387Inst Instance=new A039387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039386
{
public static readonly long[] Value={ 44L,76L,125L,157L,206L,238L,287L,319L,332L,341L,350L,359L,377L,386L,395L,396L,397L,398L,399L,401L,402L,403L,449L,481L,530L,562L,611L,643L,652L,661L,670L,679L,684L,685L,686L,687L,689L,690L,691L,697L,706L,715L,773L,805L,854L,886L,935L,967L,1016L,1048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039386Inst : IEnumerable<long>
{
public static readonly long[] Value=A039386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039386.Bytes);
public long this[int i]=>Value[i];

public static A039386Inst Instance=new A039386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039385
{
public static readonly long[] Value={ 43L,67L,124L,148L,205L,229L,286L,310L,331L,340L,349L,358L,376L,385L,387L,388L,389L,390L,392L,393L,395L,403L,448L,472L,529L,553L,571L,580L,589L,598L,603L,604L,605L,606L,608L,609L,611L,616L,625L,643L,691L,715L,772L,796L,853L,877L,934L,958L,1015L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039385Inst : IEnumerable<long>
{
public static readonly long[] Value=A039385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039385.Bytes);
public long this[int i]=>Value[i];

public static A039385Inst Instance=new A039385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039384
{
public static readonly long[] Value={ 42L,58L,123L,139L,204L,220L,285L,301L,330L,339L,348L,357L,375L,378L,379L,380L,381L,383L,385L,386L,393L,402L,447L,463L,490L,499L,508L,517L,522L,523L,524L,525L,527L,529L,530L,535L,553L,562L,609L,625L,690L,706L,771L,787L,852L,868L,933L,949L,1014L,1030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039384Inst : IEnumerable<long>
{
public static readonly long[] Value=A039384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039384.Bytes);
public long this[int i]=>Value[i];

public static A039384Inst Instance=new A039384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039383
{
public static readonly long[] Value={ 41L,49L,122L,130L,203L,211L,284L,292L,329L,338L,347L,356L,369L,370L,371L,372L,375L,376L,377L,383L,392L,401L,409L,418L,427L,436L,441L,442L,443L,444L,447L,448L,449L,463L,472L,481L,527L,535L,608L,616L,689L,697L,770L,778L,851L,859L,932L,940L,1013L,1021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039383Inst : IEnumerable<long>
{
public static readonly long[] Value=A039383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039383.Bytes);
public long this[int i]=>Value[i];

public static A039383Inst Instance=new A039383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039382
{
public static readonly long[] Value={ 35L,75L,116L,156L,197L,237L,251L,260L,269L,287L,296L,305L,314L,315L,316L,317L,319L,320L,321L,322L,359L,399L,440L,480L,521L,561L,602L,642L,651L,660L,669L,675L,676L,677L,679L,680L,681L,682L,687L,696L,705L,714L,764L,804L,845L,885L,926L,966L,980L,989L,998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039382Inst : IEnumerable<long>
{
public static readonly long[] Value=A039382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039382.Bytes);
public long this[int i]=>Value[i];

public static A039382Inst Instance=new A039382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039381
{
public static readonly long[] Value={ 34L,66L,115L,147L,196L,228L,250L,259L,268L,286L,295L,304L,306L,307L,308L,310L,311L,312L,314L,322L,358L,390L,439L,471L,520L,552L,570L,579L,588L,594L,595L,596L,598L,599L,600L,602L,606L,615L,624L,642L,682L,714L,763L,795L,844L,876L,925L,957L,979L,988L,997L,1015L,1024L,1033L,1035L,1036L,1037L,1039L,1040L,1041L,1043L,1051L,1087L,1119L,1168L,1200L,1249L,1281L,1299L,1308L,1317L,1323L,1324L,1325L,1327L,1328L,1329L,1331L,1335L,1344L,1353L,1371L,1411L,1443L,1492L,1524L,1573L,1605L,1654L,1686L,1708L,1717L,1726L,1744L,1753L,1762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039381Inst : IEnumerable<long>
{
public static readonly long[] Value=A039381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039381.Bytes);
public long this[int i]=>Value[i];

public static A039381Inst Instance=new A039381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039380
{
public static readonly long[] Value={ 33L,57L,114L,138L,195L,219L,249L,258L,267L,285L,294L,297L,298L,299L,301L,302L,304L,305L,312L,321L,357L,381L,438L,462L,489L,498L,507L,513L,514L,515L,517L,518L,520L,521L,525L,534L,552L,561L,600L,624L,681L,705L,762L,786L,843L,867L,924L,948L,978L,987L,996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039380Inst : IEnumerable<long>
{
public static readonly long[] Value=A039380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039380.Bytes);
public long this[int i]=>Value[i];

public static A039380Inst Instance=new A039380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039379
{
public static readonly long[] Value={ 32L,48L,113L,129L,194L,210L,248L,257L,266L,284L,288L,289L,290L,292L,294L,295L,296L,302L,311L,320L,356L,372L,408L,417L,426L,432L,433L,434L,436L,438L,439L,440L,444L,462L,471L,480L,518L,534L,599L,615L,680L,696L,761L,777L,842L,858L,923L,939L,977L,986L,995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039379Inst : IEnumerable<long>
{
public static readonly long[] Value=A039379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039379.Bytes);
public long this[int i]=>Value[i];

public static A039379Inst Instance=new A039379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039378
{
public static readonly long[] Value={ 31L,39L,112L,120L,193L,201L,247L,256L,265L,279L,280L,281L,284L,285L,286L,287L,292L,301L,310L,319L,327L,336L,345L,351L,352L,353L,356L,357L,358L,359L,372L,381L,390L,399L,436L,444L,517L,525L,598L,606L,679L,687L,760L,768L,841L,849L,922L,930L,976L,985L,994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039378Inst : IEnumerable<long>
{
public static readonly long[] Value=A039378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039378.Bytes);
public long this[int i]=>Value[i];

public static A039378Inst Instance=new A039378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039377
{
public static readonly long[] Value={ 26L,74L,107L,155L,170L,179L,197L,206L,215L,224L,233L,234L,235L,237L,238L,239L,240L,241L,269L,317L,350L,398L,431L,479L,512L,560L,593L,641L,650L,659L,666L,667L,669L,670L,671L,672L,673L,677L,686L,695L,704L,713L,755L,803L,836L,884L,899L,908L,926L,935L,944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039377Inst : IEnumerable<long>
{
public static readonly long[] Value=A039377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039377.Bytes);
public long this[int i]=>Value[i];

public static A039377Inst Instance=new A039377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039376
{
public static readonly long[] Value={ 25L,65L,106L,146L,169L,178L,196L,205L,214L,223L,225L,226L,228L,229L,230L,231L,233L,241L,268L,308L,349L,389L,430L,470L,511L,551L,569L,578L,585L,586L,588L,589L,590L,591L,593L,596L,605L,614L,623L,641L,673L,713L,754L,794L,835L,875L,898L,907L,925L,934L,943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039376Inst : IEnumerable<long>
{
public static readonly long[] Value=A039376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039376.Bytes);
public long this[int i]=>Value[i];

public static A039376Inst Instance=new A039376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039375
{
public static readonly long[] Value={ 24L,56L,105L,137L,168L,177L,195L,204L,213L,216L,217L,219L,220L,221L,223L,224L,231L,240L,267L,299L,348L,380L,429L,461L,488L,497L,504L,505L,507L,508L,509L,511L,512L,515L,524L,533L,551L,560L,591L,623L,672L,704L,753L,785L,834L,866L,897L,906L,924L,933L,942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039375Inst : IEnumerable<long>
{
public static readonly long[] Value=A039375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039375.Bytes);
public long this[int i]=>Value[i];

public static A039375Inst Instance=new A039375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039374
{
public static readonly long[] Value={ 23L,47L,104L,128L,167L,176L,194L,203L,207L,208L,210L,211L,213L,214L,215L,221L,230L,239L,266L,290L,347L,371L,407L,416L,423L,424L,426L,427L,429L,430L,431L,434L,443L,461L,470L,479L,509L,533L,590L,614L,671L,695L,752L,776L,833L,857L,896L,905L,923L,932L,936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039374Inst : IEnumerable<long>
{
public static readonly long[] Value=A039374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039374.Bytes);
public long this[int i]=>Value[i];

public static A039374Inst Instance=new A039374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039373
{
public static readonly long[] Value={ 22L,38L,103L,119L,166L,175L,193L,198L,199L,201L,203L,204L,205L,206L,211L,220L,229L,238L,265L,281L,326L,335L,342L,343L,345L,347L,348L,349L,350L,353L,371L,380L,389L,398L,427L,443L,508L,524L,589L,605L,670L,686L,751L,767L,832L,848L,895L,904L,922L,927L,928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039373Inst : IEnumerable<long>
{
public static readonly long[] Value=A039373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039373.Bytes);
public long this[int i]=>Value[i];

public static A039373Inst Instance=new A039373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039356
{
public static readonly long[] Value={ 55L,62L,119L,126L,183L,190L,247L,254L,311L,318L,375L,382L,391L,399L,407L,415L,423L,431L,440L,441L,442L,443L,444L,445L,454L,462L,470L,478L,486L,494L,496L,497L,498L,499L,500L,501L,567L,574L,631L,638L,695L,702L,759L,766L,823L,830L,887L,894L,903L,911L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039356Inst : IEnumerable<long>
{
public static readonly long[] Value=A039356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039356.Bytes);
public long this[int i]=>Value[i];

public static A039356Inst Instance=new A039356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039355
{
public static readonly long[] Value={ 47L,61L,111L,125L,175L,189L,239L,253L,303L,317L,327L,335L,343L,351L,359L,375L,376L,377L,378L,379L,380L,382L,431L,445L,453L,461L,469L,477L,485L,488L,489L,490L,491L,492L,494L,501L,559L,573L,623L,637L,687L,701L,751L,765L,815L,829L,839L,847L,855L,863L,871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039355Inst : IEnumerable<long>
{
public static readonly long[] Value=A039355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039355.Bytes);
public long this[int i]=>Value[i];

public static A039355Inst Instance=new A039355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039354
{
public static readonly long[] Value={ 46L,53L,110L,117L,174L,181L,238L,245L,302L,309L,326L,334L,342L,350L,358L,368L,369L,370L,371L,372L,375L,382L,389L,397L,405L,413L,421L,424L,425L,426L,427L,428L,431L,445L,494L,501L,558L,565L,622L,629L,686L,693L,750L,757L,814L,821L,838L,846L,854L,862L,870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039354Inst : IEnumerable<long>
{
public static readonly long[] Value=A039354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039354.Bytes);
public long this[int i]=>Value[i];

public static A039354Inst Instance=new A039354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039353
{
public static readonly long[] Value={ 39L,60L,103L,124L,167L,188L,231L,252L,263L,271L,279L,287L,303L,311L,312L,313L,314L,315L,317L,318L,359L,380L,423L,444L,452L,460L,468L,476L,480L,481L,482L,483L,485L,486L,492L,500L,551L,572L,615L,636L,679L,700L,743L,764L,775L,783L,791L,799L,815L,823L,824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039353Inst : IEnumerable<long>
{
public static readonly long[] Value=A039353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039353.Bytes);
public long this[int i]=>Value[i];

public static A039353Inst Instance=new A039353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039352
{
public static readonly long[] Value={ 38L,52L,102L,116L,166L,180L,230L,244L,262L,270L,278L,286L,302L,304L,305L,306L,307L,309L,311L,318L,358L,372L,388L,396L,404L,412L,416L,417L,418L,419L,421L,423L,428L,444L,486L,500L,550L,564L,614L,628L,678L,692L,742L,756L,774L,782L,790L,798L,814L,816L,817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039352Inst : IEnumerable<long>
{
public static readonly long[] Value=A039352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039352.Bytes);
public long this[int i]=>Value[i];

public static A039352Inst Instance=new A039352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039351
{
public static readonly long[] Value={ 37L,44L,101L,108L,165L,172L,229L,236L,261L,269L,277L,285L,296L,297L,298L,299L,302L,303L,309L,317L,324L,332L,340L,348L,352L,353L,354L,355L,358L,359L,372L,380L,421L,428L,485L,492L,549L,556L,613L,620L,677L,684L,741L,748L,773L,781L,789L,797L,808L,809L,810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039351Inst : IEnumerable<long>
{
public static readonly long[] Value=A039351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039351.Bytes);
public long this[int i]=>Value[i];

public static A039351Inst Instance=new A039351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039350
{
public static readonly long[] Value={ 31L,59L,95L,123L,159L,187L,199L,207L,215L,231L,239L,247L,248L,249L,250L,252L,253L,254L,287L,315L,351L,379L,415L,443L,451L,459L,467L,472L,473L,474L,476L,477L,478L,483L,491L,499L,543L,571L,607L,635L,671L,699L,711L,719L,727L,743L,751L,759L,760L,761L,762L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039350Inst : IEnumerable<long>
{
public static readonly long[] Value=A039350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039350.Bytes);
public long this[int i]=>Value[i];

public static A039350Inst Instance=new A039350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039349
{
public static readonly long[] Value={ 30L,51L,94L,115L,158L,179L,198L,206L,214L,230L,238L,240L,241L,242L,244L,245L,247L,254L,286L,307L,350L,371L,387L,395L,403L,408L,409L,410L,412L,413L,415L,419L,427L,443L,478L,499L,542L,563L,606L,627L,670L,691L,710L,718L,726L,742L,750L,752L,753L,754L,756L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039349Inst : IEnumerable<long>
{
public static readonly long[] Value=A039349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039349.Bytes);
public long this[int i]=>Value[i];

public static A039349Inst Instance=new A039349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039348
{
public static readonly long[] Value={ 29L,43L,93L,107L,157L,171L,197L,205L,213L,229L,232L,233L,234L,236L,238L,239L,245L,253L,285L,299L,323L,331L,339L,344L,345L,346L,348L,350L,351L,355L,371L,379L,413L,427L,477L,491L,541L,555L,605L,619L,669L,683L,709L,717L,725L,741L,744L,745L,746L,748L,750L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039348Inst : IEnumerable<long>
{
public static readonly long[] Value=A039348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039348.Bytes);
public long this[int i]=>Value[i];

public static A039348Inst Instance=new A039348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039347
{
public static readonly long[] Value={ 28L,35L,92L,99L,156L,163L,196L,204L,212L,224L,225L,226L,229L,230L,231L,236L,244L,252L,259L,267L,275L,280L,281L,282L,285L,286L,287L,299L,307L,315L,348L,355L,412L,419L,476L,483L,540L,547L,604L,611L,668L,675L,708L,716L,724L,736L,737L,738L,741L,742L,743L,748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039347Inst : IEnumerable<long>
{
public static readonly long[] Value=A039347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039347.Bytes);
public long this[int i]=>Value[i];

public static A039347Inst Instance=new A039347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039346
{
public static readonly long[] Value={ 23L,58L,87L,122L,135L,143L,159L,167L,175L,183L,184L,185L,187L,188L,189L,190L,215L,250L,279L,314L,343L,378L,407L,442L,450L,458L,464L,465L,467L,468L,469L,470L,474L,482L,490L,498L,535L,570L,599L,634L,647L,655L,671L,679L,687L,695L,696L,697L,699L,700L,701L,702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039346Inst : IEnumerable<long>
{
public static readonly long[] Value=A039346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039346.Bytes);
public long this[int i]=>Value[i];

public static A039346Inst Instance=new A039346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039345
{
public static readonly long[] Value={ 22L,50L,86L,114L,134L,142L,158L,166L,174L,176L,177L,179L,180L,181L,183L,190L,214L,242L,278L,306L,342L,370L,386L,394L,400L,401L,403L,404L,405L,407L,410L,418L,426L,442L,470L,498L,534L,562L,598L,626L,646L,654L,670L,678L,686L,688L,689L,691L,692L,693L,695L,702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039345Inst : IEnumerable<long>
{
public static readonly long[] Value=A039345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039345.Bytes);
public long this[int i]=>Value[i];

public static A039345Inst Instance=new A039345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039344
{
public static readonly long[] Value={ 21L,42L,85L,106L,133L,141L,157L,165L,168L,169L,171L,172L,174L,175L,181L,189L,213L,234L,277L,298L,322L,330L,336L,337L,339L,340L,342L,343L,346L,354L,370L,378L,405L,426L,469L,490L,533L,554L,597L,618L,645L,653L,669L,677L,680L,681L,683L,684L,686L,687L,693L,701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039344Inst : IEnumerable<long>
{
public static readonly long[] Value=A039344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039344.Bytes);
public long this[int i]=>Value[i];

public static A039344Inst Instance=new A039344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039343
{
public static readonly long[] Value={ 20L,34L,84L,98L,132L,140L,156L,160L,161L,163L,165L,166L,167L,172L,180L,188L,212L,226L,258L,266L,272L,273L,275L,277L,278L,279L,282L,298L,306L,314L,340L,354L,404L,418L,468L,482L,532L,546L,596L,610L,644L,652L,668L,672L,673L,675L,677L,678L,679L,684L,692L,700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039343Inst : IEnumerable<long>
{
public static readonly long[] Value=A039343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039343.Bytes);
public long this[int i]=>Value[i];

public static A039343Inst Instance=new A039343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039342
{
public static readonly long[] Value={ 19L,26L,83L,90L,131L,139L,152L,153L,156L,157L,158L,159L,163L,171L,179L,187L,194L,202L,208L,209L,212L,213L,214L,215L,226L,234L,242L,250L,275L,282L,339L,346L,403L,410L,467L,474L,531L,538L,595L,602L,643L,651L,664L,665L,668L,669L,670L,671L,675L,683L,691L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039342Inst : IEnumerable<long>
{
public static readonly long[] Value=A039342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039342.Bytes);
public long this[int i]=>Value[i];

public static A039342Inst Instance=new A039342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039341
{
public static readonly long[] Value={ 15L,57L,71L,87L,95L,103L,111L,119L,120L,122L,123L,124L,125L,126L,143L,185L,207L,249L,271L,313L,335L,377L,399L,441L,449L,456L,458L,459L,460L,461L,462L,465L,473L,481L,489L,497L,519L,535L,543L,551L,559L,567L,568L,570L,571L,572L,573L,574L,639L,647L,663L,671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039341Inst : IEnumerable<long>
{
public static readonly long[] Value=A039341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039341.Bytes);
public long this[int i]=>Value[i];

public static A039341Inst Instance=new A039341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039324
{
public static readonly long[] Value={ 26L,38L,75L,87L,124L,136L,152L,159L,166L,180L,182L,183L,184L,186L,188L,194L,222L,234L,248L,255L,262L,266L,267L,268L,270L,272L,276L,290L,320L,332L,369L,381L,418L,430L,467L,479L,495L,502L,509L,523L,525L,526L,527L,529L,531L,537L,565L,577L,591L,598L,605L,609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039324Inst : IEnumerable<long>
{
public static readonly long[] Value=A039324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039324.Bytes);
public long this[int i]=>Value[i];

public static A039324Inst Instance=new A039324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039323
{
public static readonly long[] Value={ 25L,31L,74L,80L,123L,129L,151L,158L,165L,175L,176L,177L,180L,181L,186L,193L,199L,206L,213L,217L,218L,219L,222L,223L,234L,241L,270L,276L,319L,325L,368L,374L,417L,423L,466L,472L,494L,501L,508L,518L,519L,520L,523L,524L,529L,536L,542L,549L,556L,560L,561L,562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039323Inst : IEnumerable<long>
{
public static readonly long[] Value=A039323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039323.Bytes);
public long this[int i]=>Value[i];

public static A039323Inst Instance=new A039323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039322
{
public static readonly long[] Value={ 20L,44L,69L,93L,104L,111L,125L,132L,139L,140L,141L,143L,144L,145L,167L,191L,216L,240L,265L,289L,296L,303L,308L,309L,311L,312L,313L,317L,324L,331L,363L,387L,412L,436L,447L,454L,468L,475L,482L,483L,484L,486L,487L,488L,510L,534L,559L,583L,608L,632L,639L,646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039322Inst : IEnumerable<long>
{
public static readonly long[] Value=A039322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039322.Bytes);
public long this[int i]=>Value[i];

public static A039322Inst Instance=new A039322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039321
{
public static readonly long[] Value={ 19L,37L,68L,86L,103L,110L,124L,131L,133L,134L,136L,137L,139L,145L,166L,184L,215L,233L,247L,254L,259L,260L,262L,263L,265L,268L,275L,289L,313L,331L,362L,380L,411L,429L,446L,453L,467L,474L,476L,477L,479L,480L,482L,488L,509L,527L,558L,576L,590L,597L,602L,603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039321Inst : IEnumerable<long>
{
public static readonly long[] Value=A039321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039321.Bytes);
public long this[int i]=>Value[i];

public static A039321Inst Instance=new A039321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039320
{
public static readonly long[] Value={ 18L,30L,67L,79L,102L,109L,123L,126L,127L,129L,131L,132L,137L,144L,165L,177L,198L,205L,210L,211L,213L,215L,216L,219L,233L,240L,263L,275L,312L,324L,361L,373L,410L,422L,445L,452L,466L,469L,470L,472L,474L,475L,480L,487L,508L,520L,541L,548L,553L,554L,556L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039320Inst : IEnumerable<long>
{
public static readonly long[] Value=A039320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039320.Bytes);
public long this[int i]=>Value[i];

public static A039320Inst Instance=new A039320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039319
{
public static readonly long[] Value={ 17L,23L,66L,72L,101L,108L,119L,120L,123L,124L,125L,129L,136L,143L,149L,156L,161L,162L,165L,166L,167L,177L,184L,191L,213L,219L,262L,268L,311L,317L,360L,366L,409L,415L,444L,451L,462L,463L,466L,467L,468L,472L,479L,486L,492L,499L,504L,505L,508L,509L,510L,520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039319Inst : IEnumerable<long>
{
public static readonly long[] Value=A039319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039319.Bytes);
public long this[int i]=>Value[i];

public static A039319Inst Instance=new A039319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039318
{
public static readonly long[] Value={ 13L,43L,55L,69L,76L,83L,90L,91L,93L,94L,95L,96L,111L,141L,160L,190L,209L,239L,258L,288L,295L,301L,303L,304L,305L,306L,309L,316L,323L,330L,349L,363L,370L,377L,384L,385L,387L,388L,389L,390L,440L,447L,461L,468L,475L,482L,483L,485L,486L,487L,488L,496L,510L,517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039318Inst : IEnumerable<long>
{
public static readonly long[] Value=A039318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039318.Bytes);
public long this[int i]=>Value[i];

public static A039318Inst Instance=new A039318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039317
{
public static readonly long[] Value={ 12L,36L,54L,68L,75L,82L,84L,86L,87L,88L,90L,96L,110L,134L,159L,183L,208L,232L,246L,252L,254L,255L,256L,258L,260L,267L,274L,288L,306L,330L,348L,362L,369L,376L,378L,380L,381L,382L,384L,390L,432L,446L,460L,467L,474L,476L,478L,479L,480L,482L,488L,495L,509L,516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039317Inst : IEnumerable<long>
{
public static readonly long[] Value=A039317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039317.Bytes);
public long this[int i]=>Value[i];

public static A039317Inst Instance=new A039317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039316
{
public static readonly long[] Value={ 11L,29L,53L,67L,74L,77L,79L,80L,82L,83L,88L,95L,109L,127L,158L,176L,197L,203L,205L,206L,208L,209L,211L,218L,232L,239L,256L,274L,305L,323L,347L,361L,368L,371L,373L,374L,376L,377L,382L,389L,424L,445L,459L,466L,469L,471L,472L,474L,475L,480L,487L,494L,508L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039316Inst : IEnumerable<long>
{
public static readonly long[] Value=A039316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039316.Bytes);
public long this[int i]=>Value[i];

public static A039316Inst Instance=new A039316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039315
{
public static readonly long[] Value={ 10L,22L,52L,66L,70L,72L,74L,75L,76L,80L,87L,94L,108L,120L,148L,154L,156L,158L,159L,160L,162L,176L,183L,190L,206L,218L,255L,267L,304L,316L,346L,360L,364L,366L,368L,369L,370L,374L,381L,388L,416L,444L,458L,462L,464L,466L,467L,468L,472L,479L,486L,490L,492L,494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039315Inst : IEnumerable<long>
{
public static readonly long[] Value=A039315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039315.Bytes);
public long this[int i]=>Value[i];

public static A039315Inst Instance=new A039315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039314
{
public static readonly long[] Value={ 9L,15L,51L,63L,66L,67L,68L,69L,72L,79L,86L,93L,99L,105L,108L,109L,110L,111L,120L,127L,134L,141L,156L,162L,205L,211L,254L,260L,303L,309L,345L,357L,360L,361L,362L,363L,366L,373L,380L,387L,408L,441L,444L,445L,446L,447L,450L,456L,462L,465L,466L,467L,468L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039314Inst : IEnumerable<long>
{
public static readonly long[] Value=A039314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039314.Bytes);
public long this[int i]=>Value[i];

public static A039314Inst Instance=new A039314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039313
{
public static readonly long[] Value={ 42L,55L,91L,104L,140L,153L,189L,202L,238L,251L,287L,295L,296L,297L,298L,299L,301L,308L,315L,322L,329L,356L,363L,370L,377L,384L,386L,387L,388L,389L,390L,398L,434L,447L,483L,496L,532L,545L,581L,594L,630L,638L,639L,640L,641L,642L,644L,651L,658L,665L,672L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039313Inst : IEnumerable<long>
{
public static readonly long[] Value=A039313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039313.Bytes);
public long this[int i]=>Value[i];

public static A039313Inst Instance=new A039313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039312
{
public static readonly long[] Value={ 35L,54L,84L,103L,133L,152L,182L,201L,231L,246L,247L,248L,249L,251L,252L,259L,266L,273L,287L,299L,329L,355L,362L,369L,376L,379L,380L,381L,382L,384L,390L,397L,427L,446L,476L,495L,525L,544L,574L,589L,590L,591L,592L,594L,595L,602L,609L,616L,630L,642L,672L,698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039312Inst : IEnumerable<long>
{
public static readonly long[] Value=A039312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039312.Bytes);
public long this[int i]=>Value[i];

public static A039312Inst Instance=new A039312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039311
{
public static readonly long[] Value={ 28L,53L,77L,102L,126L,151L,175L,197L,198L,199L,201L,202L,203L,210L,217L,231L,238L,249L,273L,298L,322L,354L,361L,368L,372L,373L,374L,376L,377L,382L,389L,396L,420L,445L,469L,494L,518L,540L,541L,542L,544L,545L,546L,553L,560L,574L,581L,592L,616L,641L,665L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039311Inst : IEnumerable<long>
{
public static readonly long[] Value=A039311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039311.Bytes);
public long this[int i]=>Value[i];

public static A039311Inst Instance=new A039311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039310
{
public static readonly long[] Value={ 21L,52L,70L,101L,119L,148L,149L,151L,152L,153L,154L,161L,175L,182L,189L,199L,217L,248L,266L,297L,315L,353L,360L,365L,366L,368L,369L,370L,374L,381L,388L,395L,413L,444L,462L,491L,492L,494L,495L,496L,497L,504L,518L,525L,532L,542L,560L,591L,609L,640L,658L,696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039310Inst : IEnumerable<long>
{
public static readonly long[] Value=A039310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039310.Bytes);
public long this[int i]=>Value[i];

public static A039310Inst Instance=new A039310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039309
{
public static readonly long[] Value={ 14L,51L,63L,99L,101L,102L,103L,104L,105L,119L,126L,133L,140L,149L,161L,198L,210L,247L,259L,296L,308L,352L,358L,360L,361L,362L,363L,366L,373L,380L,387L,394L,406L,442L,444L,445L,446L,447L,448L,462L,469L,476L,483L,492L,504L,541L,553L,590L,602L,639L,651L,688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039309Inst : IEnumerable<long>
{
public static readonly long[] Value=A039309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039309.Bytes);
public long this[int i]=>Value[i];

public static A039309Inst Instance=new A039309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039228
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,24L,26L,27L,28L,29L,30L,31L,32L,33L,35L,36L,38L,39L,40L,41L,42L,43L,44L,45L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,62L,63L,64L,65L,66L,67L,68L,69L,71L,72L,74L,75L,76L,77L,78L,79L,80L,81L,83L,84L,86L,87L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039228Inst : IEnumerable<long>
{
public static readonly long[] Value=A039228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039228.Bytes);
public long this[int i]=>Value[i];

public static A039228Inst Instance=new A039228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039227
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,10L,11L,21L,24L,26L,27L,28L,29L,30L,31L,32L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,62L,63L,64L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L,82L,83L,84L,86L,87L,88L,89L,90L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039227Inst : IEnumerable<long>
{
public static readonly long[] Value=A039227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039227.Bytes);
public long this[int i]=>Value[i];

public static A039227Inst Instance=new A039227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039226
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,9L,10L,11L,20L,24L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,86L,87L,88L,89L,90L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039226Inst : IEnumerable<long>
{
public static readonly long[] Value=A039226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039226.Bytes);
public long this[int i]=>Value[i];

public static A039226Inst Instance=new A039226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039225
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,8L,9L,10L,11L,19L,24L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,80L,81L,82L,83L,85L,96L,98L,99L,100L,101L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039225Inst : IEnumerable<long>
{
public static readonly long[] Value=A039225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039225.Bytes);
public long this[int i]=>Value[i];

public static A039225Inst Instance=new A039225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039224
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,8L,9L,10L,11L,18L,24L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,67L,68L,69L,70L,71L,73L,84L,86L,87L,88L,89L,91L,92L,93L,94L,95L,96L,98L,99L,100L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039224Inst : IEnumerable<long>
{
public static readonly long[] Value=A039224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039224.Bytes);
public long this[int i]=>Value[i];

public static A039224Inst Instance=new A039224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039223
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,8L,9L,10L,11L,17L,24L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,54L,55L,56L,57L,58L,59L,61L,72L,74L,75L,76L,78L,79L,80L,81L,82L,83L,84L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039223Inst : IEnumerable<long>
{
public static readonly long[] Value=A039223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039223.Bytes);
public long this[int i]=>Value[i];

public static A039223Inst Instance=new A039223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039222
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,7L,8L,9L,10L,11L,16L,24L,26L,27L,29L,30L,31L,32L,33L,34L,35L,36L,38L,39L,41L,42L,43L,44L,45L,46L,47L,49L,60L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,74L,75L,77L,78L,79L,80L,81L,82L,83L,84L,86L,87L,89L,90L,91L,92L,93L,94L,95L,96L,98L,99L,101L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039222Inst : IEnumerable<long>
{
public static readonly long[] Value=A039222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039222.Bytes);
public long this[int i]=>Value[i];

public static A039222Inst Instance=new A039222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039221
{
public static readonly long[] Value={ 0L,2L,4L,5L,6L,7L,8L,9L,10L,11L,15L,24L,26L,28L,29L,30L,31L,32L,33L,34L,35L,37L,48L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,74L,76L,77L,78L,79L,80L,81L,82L,83L,84L,86L,88L,89L,90L,91L,92L,93L,94L,95L,96L,98L,100L,101L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039221Inst : IEnumerable<long>
{
public static readonly long[] Value=A039221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039221.Bytes);
public long this[int i]=>Value[i];

public static A039221Inst Instance=new A039221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039220
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,8L,9L,10L,11L,14L,25L,36L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,99L,100L,101L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039220Inst : IEnumerable<long>
{
public static readonly long[] Value=A039220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039220.Bytes);
public long this[int i]=>Value[i];

public static A039220Inst Instance=new A039220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039219
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039219Inst : IEnumerable<long>
{
public static readonly long[] Value=A039219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039219.Bytes);
public long this[int i]=>Value[i];

public static A039219Inst Instance=new A039219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039218
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039218Inst : IEnumerable<long>
{
public static readonly long[] Value=A039218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039218.Bytes);
public long this[int i]=>Value[i];

public static A039218Inst Instance=new A039218Inst();

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