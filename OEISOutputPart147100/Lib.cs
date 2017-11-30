using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190664
{
public static readonly long[] Value={ 21L,55L,39L,51L,203L,87L,111L,123L,371L,183L,335L,395L,623L,267L,291L,327L,1703L,635L,411L,1043L,447L,815L,1211L,543L,591L,7223L,1055L,2951L,1115L,687L,771L,1883L,831L,843L,4043L,1535L,951L,1655L,1011L,1047L,12059L,1835L,2723L,1167L,1191L,1203L,4763L,1347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190664Inst : IEnumerable<long>
{
public static readonly long[] Value=A190664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190664.Bytes);
public long this[int i]=>Value[i];

public static A190664Inst Instance=new A190664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190665
{
public static readonly long[] Value={ 9L,10L,12L,15L,24L,26L,49L,56L,58L,69L,75L,76L,90L,95L,119L,122L,124L,133L,140L,143L,147L,153L,176L,194L,215L,243L,287L,332L,363L,386L,407L,429L,477L,495L,507L,511L,524L,527L,536L,551L,568L,575L,578L,688L,717L,738L,791L,794L,815L,867L,871L,892L,924L,935L,961L,963L,992L,1001L,1018L,1075L,1083L,1159L,1196L,1199L,1243L,1295L,1304L,1324L,1346L,1391L,1415L,1421L,1431L,1532L,1573L,1587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190665Inst : IEnumerable<long>
{
public static readonly long[] Value=A190665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190665.Bytes);
public long this[int i]=>Value[i];

public static A190665Inst Instance=new A190665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190666
{
public static readonly long[] Value={ 1L,9L,61L,377L,2241L,13073L,75517L,433905L,2485825L,14218905L,81270333L,464387817L,2653649025L,15167050785L,86716873725L,495998874593L,2838240338817L,16248650965289L,93065296937533L,533285164334169L,3057236753252161L,17534423944871729L,100609937775369981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190666Inst : IEnumerable<long>
{
public static readonly long[] Value=A190666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190666.Bytes);
public long this[int i]=>Value[i];

public static A190666Inst Instance=new A190666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190667
{
public static readonly long[] Value={ 1L,3L,5L,13L,30L,69L,160L,371L,859L,1990L,4610L,10679L,24738L,57306L,132750L,307517L,712367L,1650207L,3822725L,8855390L,20513621L,47520058L,110080805L,255003553L,590718900L,1368407674L,3169933385L,7343190086L,17010591104L,39405245720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190667Inst : IEnumerable<long>
{
public static readonly long[] Value=A190667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190667.Bytes);
public long this[int i]=>Value[i];

public static A190667Inst Instance=new A190667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190684
{
public static readonly long[] Value={ 11L,26L,37L,41L,52L,67L,82L,93L,97L,108L,123L,138L,149L,153L,164L,179L,194L,205L,220L,235L,246L,250L,261L,276L,291L,302L,306L,317L,332L,347L,358L,362L,373L,388L,399L,403L,414L,429L,444L,455L,459L,470L,485L,500L,511L,515L,526L,541L,556L,567L,571L,582L,597L,608L,612L,623L,638L,653L,664L,668L,679L,694L,709L,720L,724L,735L,750L,765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190684Inst : IEnumerable<long>
{
public static readonly long[] Value=A190684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190684.Bytes);
public long this[int i]=>Value[i];

public static A190684Inst Instance=new A190684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190685
{
public static readonly long[] Value={ 3L,6L,7L,10L,14L,18L,21L,22L,25L,29L,33L,36L,40L,44L,47L,48L,51L,55L,59L,62L,63L,66L,70L,74L,77L,78L,81L,85L,88L,89L,92L,96L,100L,103L,104L,107L,111L,115L,118L,119L,122L,126L,130L,133L,134L,137L,141L,144L,145L,148L,152L,156L,159L,160L,163L,167L,171L,174L,175L,178L,182L,186L,189L,190L,193L,197L,200L,201L,204L,208L,212L,215L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190685Inst : IEnumerable<long>
{
public static readonly long[] Value=A190685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190685.Bytes);
public long this[int i]=>Value[i];

public static A190685Inst Instance=new A190685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190686
{
public static readonly long[] Value={ 1L,2L,5L,9L,13L,16L,17L,20L,24L,28L,31L,32L,35L,39L,42L,43L,46L,50L,54L,57L,58L,61L,65L,69L,72L,73L,76L,80L,84L,87L,91L,95L,98L,99L,102L,106L,110L,113L,114L,117L,121L,125L,128L,129L,132L,136L,139L,140L,143L,147L,151L,154L,155L,158L,162L,166L,169L,170L,173L,177L,181L,184L,185L,188L,192L,195L,196L,199L,203L,207L,210L,211L,214L,218L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190686Inst : IEnumerable<long>
{
public static readonly long[] Value=A190686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190686.Bytes);
public long this[int i]=>Value[i];

public static A190686Inst Instance=new A190686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190687
{
public static readonly long[] Value={ 4L,8L,12L,15L,19L,23L,27L,30L,34L,38L,45L,49L,53L,56L,60L,64L,68L,71L,75L,79L,83L,86L,90L,94L,101L,105L,109L,112L,116L,120L,124L,127L,131L,135L,142L,146L,150L,157L,161L,165L,168L,172L,176L,180L,183L,187L,191L,198L,202L,206L,209L,213L,217L,221L,224L,228L,232L,236L,239L,243L,247L,254L,258L,262L,265L,269L,273L,277L,280L,284L,288L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190687Inst : IEnumerable<long>
{
public static readonly long[] Value=A190687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190687.Bytes);
public long this[int i]=>Value[i];

public static A190687Inst Instance=new A190687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190688
{
public static readonly long[] Value={ 2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190688Inst : IEnumerable<long>
{
public static readonly long[] Value=A190688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190688.Bytes);
public long this[int i]=>Value[i];

public static A190688Inst Instance=new A190688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190689
{
public static readonly long[] Value={ 7L,11L,18L,22L,26L,33L,37L,41L,48L,52L,63L,67L,74L,78L,82L,89L,93L,97L,104L,108L,119L,123L,130L,134L,138L,145L,149L,153L,160L,164L,175L,179L,186L,190L,194L,201L,205L,216L,220L,227L,231L,235L,242L,246L,250L,257L,261L,272L,276L,283L,287L,291L,298L,302L,306L,313L,317L,328L,332L,339L,343L,347L,354L,358L,362L,369L,373L,384L,388L,395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190689Inst : IEnumerable<long>
{
public static readonly long[] Value=A190689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190689.Bytes);
public long this[int i]=>Value[i];

public static A190689Inst Instance=new A190689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190690
{
public static readonly long[] Value={ 2L,3L,6L,10L,14L,17L,21L,25L,28L,29L,32L,36L,40L,43L,44L,47L,51L,55L,58L,59L,62L,66L,69L,70L,73L,77L,81L,84L,85L,88L,92L,96L,99L,100L,103L,107L,111L,114L,115L,118L,122L,125L,126L,129L,133L,137L,140L,141L,144L,148L,152L,155L,156L,159L,163L,167L,170L,171L,174L,178L,181L,182L,185L,189L,193L,196L,197L,200L,204L,208L,211L,212L,215L,219L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190690Inst : IEnumerable<long>
{
public static readonly long[] Value=A190690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190690.Bytes);
public long this[int i]=>Value[i];

public static A190690Inst Instance=new A190690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190691
{
public static readonly long[] Value={ 1L,5L,9L,12L,13L,16L,20L,23L,24L,27L,31L,35L,38L,39L,42L,46L,50L,53L,54L,57L,61L,65L,68L,72L,76L,79L,80L,83L,87L,91L,94L,95L,98L,102L,106L,109L,110L,113L,117L,121L,124L,128L,132L,135L,136L,139L,143L,147L,150L,151L,154L,158L,162L,165L,166L,169L,173L,176L,177L,180L,184L,188L,191L,192L,195L,199L,203L,206L,207L,210L,214L,218L,221L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190691Inst : IEnumerable<long>
{
public static readonly long[] Value=A190691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190691.Bytes);
public long this[int i]=>Value[i];

public static A190691Inst Instance=new A190691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190692
{
public static readonly long[] Value={ 4L,8L,15L,19L,30L,34L,45L,49L,56L,60L,64L,71L,75L,86L,90L,101L,105L,112L,116L,120L,127L,131L,142L,146L,157L,161L,168L,172L,183L,187L,198L,202L,209L,213L,217L,224L,228L,239L,243L,254L,258L,265L,269L,273L,280L,284L,295L,299L,310L,314L,321L,325L,336L,340L,351L,355L,366L,370L,377L,381L,392L,396L,407L,411L,418L,422L,426L,433L,437L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190692Inst : IEnumerable<long>
{
public static readonly long[] Value=A190692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190692.Bytes);
public long this[int i]=>Value[i];

public static A190692Inst Instance=new A190692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190693
{
public static readonly long[] Value={ 2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,0L,3L,2L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190693Inst : IEnumerable<long>
{
public static readonly long[] Value=A190693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190693.Bytes);
public long this[int i]=>Value[i];

public static A190693Inst Instance=new A190693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190694
{
public static readonly long[] Value={ 3L,7L,11L,14L,18L,22L,26L,29L,33L,37L,41L,44L,48L,52L,59L,63L,67L,70L,74L,78L,82L,85L,89L,93L,97L,100L,104L,108L,115L,119L,123L,126L,130L,134L,138L,141L,145L,149L,153L,156L,160L,164L,171L,175L,179L,182L,186L,190L,194L,197L,201L,205L,212L,216L,220L,223L,227L,231L,235L,238L,242L,246L,250L,253L,257L,261L,268L,272L,276L,279L,283L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190694Inst : IEnumerable<long>
{
public static readonly long[] Value=A190694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190694.Bytes);
public long this[int i]=>Value[i];

public static A190694Inst Instance=new A190694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190695
{
public static readonly long[] Value={ 2L,6L,10L,17L,21L,25L,28L,32L,36L,40L,43L,47L,51L,55L,58L,62L,66L,73L,77L,81L,84L,88L,92L,96L,99L,103L,107L,111L,114L,118L,122L,129L,133L,137L,140L,144L,148L,152L,155L,159L,163L,167L,170L,174L,178L,185L,189L,193L,196L,200L,204L,208L,211L,215L,219L,226L,230L,234L,237L,241L,245L,249L,252L,256L,260L,264L,267L,271L,275L,282L,286L,290L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190695Inst : IEnumerable<long>
{
public static readonly long[] Value=A190695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190695.Bytes);
public long this[int i]=>Value[i];

public static A190695Inst Instance=new A190695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190696
{
public static readonly long[] Value={ 1L,5L,9L,13L,16L,20L,24L,31L,35L,39L,42L,46L,50L,54L,57L,61L,65L,69L,72L,76L,80L,87L,91L,95L,98L,102L,106L,110L,113L,117L,121L,125L,128L,132L,136L,143L,147L,151L,154L,158L,162L,166L,169L,173L,177L,181L,184L,188L,192L,195L,199L,203L,207L,210L,214L,218L,222L,225L,229L,233L,240L,244L,248L,251L,255L,259L,263L,266L,270L,274L,278L,281L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190696Inst : IEnumerable<long>
{
public static readonly long[] Value=A190696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190696.Bytes);
public long this[int i]=>Value[i];

public static A190696Inst Instance=new A190696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190697
{
public static readonly long[] Value={ 4L,8L,12L,15L,19L,23L,27L,30L,34L,38L,45L,49L,53L,56L,60L,64L,68L,71L,75L,79L,83L,86L,90L,94L,101L,105L,109L,112L,116L,120L,124L,127L,131L,135L,139L,142L,146L,150L,157L,161L,165L,168L,172L,176L,180L,183L,187L,191L,198L,202L,206L,209L,213L,217L,221L,224L,228L,232L,236L,239L,243L,247L,254L,258L,262L,265L,269L,273L,277L,280L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190697Inst : IEnumerable<long>
{
public static readonly long[] Value=A190697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190697.Bytes);
public long this[int i]=>Value[i];

public static A190697Inst Instance=new A190697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190698
{
public static readonly long[] Value={ 3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190698Inst : IEnumerable<long>
{
public static readonly long[] Value=A190698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190698.Bytes);
public long this[int i]=>Value[i];

public static A190698Inst Instance=new A190698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190699
{
public static readonly long[] Value={ 11L,26L,41L,52L,67L,82L,97L,108L,123L,138L,153L,164L,179L,194L,220L,235L,250L,261L,276L,291L,306L,317L,332L,347L,362L,373L,388L,403L,429L,444L,459L,470L,485L,500L,515L,526L,541L,556L,571L,582L,597L,612L,638L,653L,668L,679L,694L,709L,724L,735L,750L,765L,791L,806L,821L,832L,847L,862L,877L,888L,903L,918L,933L,944L,959L,974L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190699Inst : IEnumerable<long>
{
public static readonly long[] Value=A190699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190699.Bytes);
public long this[int i]=>Value[i];

public static A190699Inst Instance=new A190699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190748
{
public static readonly long[] Value={ 4L,12L,20L,28L,34L,42L,49L,58L,64L,71L,78L,86L,93L,101L,109L,117L,123L,130L,139L,145L,153L,159L,167L,176L,183L,190L,197L,205L,212L,219L,226L,235L,241L,248L,257L,264L,273L,278L,285L,293L,301L,308L,315L,322L,331L,338L,345L,353L,359L,368L,374L,382L,390L,397L,403L,412L,419L,427L,433L,440L,449L,456L,464L,471L,478L,486L,493L,499L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190748Inst : IEnumerable<long>
{
public static readonly long[] Value=A190748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190748.Bytes);
public long this[int i]=>Value[i];

public static A190748Inst Instance=new A190748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190749
{
public static readonly long[] Value={ 8L,17L,27L,37L,46L,56L,66L,76L,85L,95L,104L,114L,124L,134L,143L,154L,162L,172L,182L,192L,202L,210L,221L,231L,240L,250L,259L,268L,280L,289L,298L,309L,317L,326L,337L,347L,357L,365L,376L,387L,396L,407L,415L,424L,435L,445L,454L,465L,473L,483L,492L,503L,513L,521L,531L,541L,550L,562L,570L,579L,590L,599L,610L,620L,628L,638L,647L,657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190749Inst : IEnumerable<long>
{
public static readonly long[] Value=A190749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190749.Bytes);
public long this[int i]=>Value[i];

public static A190749Inst Instance=new A190749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190750
{
public static readonly long[] Value={ 2L,7L,11L,16L,21L,26L,32L,36L,41L,44L,50L,54L,60L,65L,69L,74L,79L,84L,90L,92L,98L,102L,108L,112L,118L,122L,127L,132L,136L,141L,146L,150L,156L,160L,166L,170L,175L,180L,184L,189L,194L,199L,203L,208L,214L,218L,224L,227L,232L,237L,242L,247L,252L,256L,261L,266L,271L,275L,281L,284L,290L,294L,300L,305L,310L,314L,318L,323L,329L,333L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190750Inst : IEnumerable<long>
{
public static readonly long[] Value=A190750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190750.Bytes);
public long this[int i]=>Value[i];

public static A190750Inst Instance=new A190750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190751
{
public static readonly long[] Value={ 2L,4L,8L,10L,13L,18L,21L,24L,27L,29L,34L,38L,42L,44L,47L,51L,54L,58L,61L,63L,66L,70L,74L,78L,80L,84L,87L,91L,94L,97L,100L,104L,107L,111L,114L,118L,120L,125L,127L,129L,134L,136L,141L,143L,147L,150L,154L,158L,161L,163L,167L,170L,175L,177L,180L,184L,187L,191L,194L,197L,200L,203L,206L,211L,213L,217L,220L,224L,227L,231L,234L,237L,240L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190751Inst : IEnumerable<long>
{
public static readonly long[] Value=A190751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190751.Bytes);
public long this[int i]=>Value[i];

public static A190751Inst Instance=new A190751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190752
{
public static readonly long[] Value={ 1L,3L,7L,9L,12L,16L,20L,22L,25L,28L,31L,35L,37L,41L,43L,45L,49L,52L,56L,59L,62L,65L,67L,71L,73L,77L,79L,83L,86L,89L,92L,95L,99L,101L,105L,108L,110L,113L,116L,119L,122L,126L,128L,132L,135L,137L,142L,144L,146L,149L,153L,157L,160L,162L,165L,168L,171L,176L,178L,181L,183L,185L,190L,193L,196L,199L,202L,204L,207L,212L,214L,218L,219L,223L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190752Inst : IEnumerable<long>
{
public static readonly long[] Value=A190752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190752.Bytes);
public long this[int i]=>Value[i];

public static A190752Inst Instance=new A190752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190753
{
public static readonly long[] Value={ 6L,14L,23L,30L,39L,48L,57L,64L,72L,81L,90L,98L,106L,115L,123L,131L,140L,148L,156L,164L,172L,182L,188L,198L,205L,215L,222L,232L,239L,249L,255L,265L,273L,282L,289L,298L,306L,315L,322L,331L,339L,347L,356L,365L,373L,380L,389L,398L,407L,414L,423L,431L,440L,448L,457L,465L,473L,481L,490L,499L,506L,514L,523L,532L,540L,548L,557L,565L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190753Inst : IEnumerable<long>
{
public static readonly long[] Value=A190753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190753.Bytes);
public long this[int i]=>Value[i];

public static A190753Inst Instance=new A190753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190754
{
public static readonly long[] Value={ 15L,33L,50L,69L,85L,103L,121L,139L,155L,174L,192L,210L,226L,244L,261L,279L,297L,314L,332L,350L,368L,386L,402L,421L,437L,455L,471L,491L,508L,526L,544L,561L,578L,597L,614L,631L,648L,667L,684L,701L,719L,737L,754L,773L,789L,808L,825L,844L,859L,877L,895L,913L,930L,947L,967L,984L,1002L,1019L,1037L,1054L,1072L,1089L,1106L,1124L,1143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190754Inst : IEnumerable<long>
{
public static readonly long[] Value=A190754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190754.Bytes);
public long this[int i]=>Value[i];

public static A190754Inst Instance=new A190754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190755
{
public static readonly long[] Value={ 17L,36L,55L,75L,93L,112L,133L,151L,169L,189L,209L,228L,247L,267L,286L,304L,325L,343L,361L,381L,401L,420L,438L,459L,478L,497L,515L,535L,554L,574L,593L,611L,630L,652L,670L,688L,708L,727L,746L,765L,785L,803L,822L,843L,862L,880L,900L,920L,938L,957L,977L,996L,1014L,1033L,1053L,1073L,1092L,1111L,1130L,1150L,1169L,1188L,1206L,1226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190755Inst : IEnumerable<long>
{
public static readonly long[] Value=A190755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190755.Bytes);
public long this[int i]=>Value[i];

public static A190755Inst Instance=new A190755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190756
{
public static readonly long[] Value={ 5L,11L,19L,26L,32L,40L,46L,53L,60L,68L,76L,82L,88L,96L,102L,109L,117L,124L,130L,138L,145L,152L,159L,166L,173L,179L,186L,195L,201L,208L,216L,221L,229L,236L,242L,250L,258L,264L,271L,278L,285L,292L,299L,307L,312L,320L,328L,335L,341L,349L,355L,362L,369L,376L,384L,391L,397L,405L,411L,418L,426L,432L,439L,447L,453L,461L,468L,475L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190756Inst : IEnumerable<long>
{
public static readonly long[] Value=A190756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190756.Bytes);
public long this[int i]=>Value[i];

public static A190756Inst Instance=new A190756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190757
{
public static readonly long[] Value={ 1L,1L,101L,71L,181L,39161L,24571L,12301L,1158551L,87382901L,21211L,373270451L,28143378001L,32414581L,1322154751061L,9062194370461L,1550853481L,2819407321151L,265272771839851L,2366632711L,137083914639998701L,85417012034751151L,3455782010101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190757Inst : IEnumerable<long>
{
public static readonly long[] Value=A190757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190757.Bytes);
public long this[int i]=>Value[i];

public static A190757Inst Instance=new A190757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190758
{
public static readonly long[] Value={ 17467L,18287L,31817L,42641L,116359L,139483L,163673L,172283L,176383L,181549L,190979L,225829L,226813L,231323L,259531L,288313L,299137L,307009L,352109L,404507L,421891L,445097L,464777L,484621L,528163L,592861L,604997L,609179L,611393L,629843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190758Inst : IEnumerable<long>
{
public static readonly long[] Value=A190758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190758.Bytes);
public long this[int i]=>Value[i];

public static A190758Inst Instance=new A190758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190759
{
public static readonly long[] Value={ 1L,0L,4L,0L,16L,0L,136L,0L,1128L,384L,8120L,6912L,60904L,75136L,491960L,720640L,4023592L,6828928L,32819320L,63472640L,270471784L,574543744L,2256221368L,5119155712L,18940876712L,45266369152L,159625747960L,397949457408L,1350573713256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190759Inst : IEnumerable<long>
{
public static readonly long[] Value=A190759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190759.Bytes);
public long this[int i]=>Value[i];

public static A190759Inst Instance=new A190759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190760
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,34L,36L,38L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,52L,54L,56L,58L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L,74L,76L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,92L,94L,96L,98L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,113L,116L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190760Inst : IEnumerable<long>
{
public static readonly long[] Value=A190760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190760.Bytes);
public long this[int i]=>Value[i];

public static A190760Inst Instance=new A190760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190761
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,84L,592L,4670L,40108L,368670L,3586321L,36632763L,390694000L,4332131804L,49777965585L,591173511887L,7241437905916L,91331043654080L,1184322726542850L,15770586926609276L,215423253906689779L,3015794930248824111L,BigInteger.Parse("43233248160139146114") };
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
public class A190761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190761Inst Instance=new A190761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190762
{
public static readonly long[] Value={ 2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190762Inst : IEnumerable<long>
{
public static readonly long[] Value=A190762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190762.Bytes);
public long this[int i]=>Value[i];

public static A190762Inst Instance=new A190762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190763
{
public static readonly long[] Value={ 3L,10L,17L,20L,27L,34L,44L,51L,58L,61L,68L,75L,85L,92L,99L,102L,109L,116L,119L,126L,133L,143L,150L,157L,160L,167L,174L,184L,191L,198L,201L,208L,215L,225L,232L,242L,249L,256L,259L,266L,273L,283L,290L,297L,300L,307L,314L,324L,331L,338L,341L,348L,355L,358L,365L,372L,382L,389L,396L,399L,406L,413L,423L,430L,437L,440L,447L,454L,464L,471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190763Inst : IEnumerable<long>
{
public static readonly long[] Value=A190763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190763.Bytes);
public long this[int i]=>Value[i];

public static A190763Inst Instance=new A190763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190876
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,29L,39L,49L,59L,69L,79L,89L,99L,109L,119L,129L,139L,149L,159L,169L,179L,189L,199L,209L,219L,229L,239L,249L,259L,269L,279L,289L,299L,309L,319L,329L,339L,349L,359L,369L,379L,389L,399L,409L,419L,429L,439L,449L,459L,469L,479L,489L,499L,509L,519L,529L,539L,549L,559L,569L,579L,589L,599L,609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190876Inst : IEnumerable<long>
{
public static readonly long[] Value=A190876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190876.Bytes);
public long this[int i]=>Value[i];

public static A190876Inst Instance=new A190876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190877
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,121L,721L,2521L,6721L,15121L,1844641L,20013841L,119845441L,519072841L,1816454641L,223394731561L,3501661887361L,29675906201761L,177923109591361L,844925253766561L,104750282797418881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190877Inst : IEnumerable<long>
{
public static readonly long[] Value=A190877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190877.Bytes);
public long this[int i]=>Value[i];

public static A190877Inst Instance=new A190877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190878
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,73L,621L,6211L,70393L,884913L,12534553L,197772931L,3429365061L,64519103353L,1309062244933L,28518573321603L,664268130978481L,16466530506866401L,432644339697987633L,12007970879629419523UL,BigInteger.Parse("351062850914762411773"),BigInteger.Parse("10783262700644774606121") };
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
public class A190878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190878Inst Instance=new A190878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190879
{
public static readonly long[] Value={ 300L,600L,900L,980L,1008L,1200L,1500L,1575L,1800L,1960L,2016L,2400L,2700L,3000L,3024L,3600L,3920L,4032L,4212L,4500L,4725L,4800L,4851L,4900L,5200L,5400L,6000L,6048L,6860L,7056L,7200L,7436L,7500L,7840L,7875L,8064L,8100L,8424L,8448L,9000L,9072L,9600L,9800L,10400L,10800L,10944L,11025L,12000L,12096L,12636L,13500L,13720L,14112L,14175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190879Inst : IEnumerable<long>
{
public static readonly long[] Value=A190879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190879.Bytes);
public long this[int i]=>Value[i];

public static A190879Inst Instance=new A190879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190880
{
public static readonly BigInteger[] Value={ 300L,37026L,81900L,3719430L,60960900L,746876130L,37456118700L,1371798057630L,45093761813100L,1750692518344770L,72411562719475980L,4075432279946977950L,BigInteger.Parse("430815330651894087900") };
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
public class A190880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190880Inst Instance=new A190880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190881
{
public static readonly long[] Value={ 43L,45L,68L,93L,145L,341L,655L,3177L,3383L,3424L,4696L,5109L,5116L,5183L,5201L,5225L,7195L,7574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190881Inst : IEnumerable<long>
{
public static readonly long[] Value=A190881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190881.Bytes);
public long this[int i]=>Value[i];

public static A190881Inst Instance=new A190881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190882
{
public static readonly long[] Value={ 46206L,72105L,73346L,92412L,96096L,97440L,98098L,99528L,113883L,117040L,127680L,134805L,138618L,143520L,146692L,150024L,165880L,165886L,184824L,192192L,194880L,196196L,199056L,216315L,234080L,255360L,269192L,276640L,277236L,287040L,288288L,292320L,293384L,294216L,298584L,300048L,331760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190882Inst : IEnumerable<long>
{
public static readonly long[] Value=A190882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190882.Bytes);
public long this[int i]=>Value[i];

public static A190882Inst Instance=new A190882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190883
{
public static readonly long[] Value={ 2L,6L,10L,14L,19L,23L,27L,31L,35L,36L,40L,44L,48L,52L,57L,61L,65L,69L,74L,78L,82L,86L,91L,95L,99L,103L,107L,108L,112L,116L,120L,124L,129L,133L,137L,141L,146L,150L,154L,158L,163L,167L,171L,175L,179L,180L,184L,188L,192L,196L,201L,205L,209L,213L,218L,222L,226L,230L,235L,239L,243L,247L,251L,252L,256L,260L,264L,268L,273L,277L,281L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190883Inst : IEnumerable<long>
{
public static readonly long[] Value=A190883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190883.Bytes);
public long this[int i]=>Value[i];

public static A190883Inst Instance=new A190883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190884
{
public static readonly long[] Value={ 3L,7L,11L,15L,20L,24L,28L,32L,37L,41L,45L,49L,53L,54L,58L,62L,66L,70L,75L,79L,83L,87L,92L,96L,100L,104L,109L,113L,117L,121L,125L,126L,130L,134L,138L,142L,147L,151L,155L,159L,164L,168L,172L,176L,181L,185L,189L,193L,197L,198L,202L,206L,210L,214L,219L,223L,227L,231L,236L,240L,244L,248L,253L,257L,261L,265L,269L,270L,274L,278L,282L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190884Inst : IEnumerable<long>
{
public static readonly long[] Value=A190884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190884.Bytes);
public long this[int i]=>Value[i];

public static A190884Inst Instance=new A190884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190885
{
public static readonly long[] Value={ 4L,8L,12L,16L,21L,25L,29L,33L,38L,42L,46L,50L,55L,59L,63L,67L,71L,72L,76L,80L,84L,88L,93L,97L,101L,105L,110L,114L,118L,122L,127L,131L,135L,139L,143L,144L,148L,152L,156L,160L,165L,169L,173L,177L,182L,186L,190L,194L,199L,203L,207L,211L,215L,216L,220L,224L,228L,232L,237L,241L,245L,249L,254L,258L,262L,266L,271L,275L,279L,283L,287L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190885Inst : IEnumerable<long>
{
public static readonly long[] Value=A190885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190885.Bytes);
public long this[int i]=>Value[i];

public static A190885Inst Instance=new A190885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190886
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190886Inst : IEnumerable<long>
{
public static readonly long[] Value=A190886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190886.Bytes);
public long this[int i]=>Value[i];

public static A190886Inst Instance=new A190886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190887
{
public static readonly long[] Value={ 5L,9L,13L,17L,22L,26L,30L,34L,43L,47L,51L,60L,64L,68L,77L,81L,85L,89L,94L,98L,102L,106L,115L,119L,123L,132L,136L,140L,149L,153L,157L,161L,166L,170L,174L,178L,187L,191L,195L,204L,208L,212L,221L,225L,229L,233L,238L,242L,246L,250L,255L,259L,263L,267L,276L,280L,284L,293L,297L,301L,305L,310L,314L,318L,322L,327L,331L,335L,339L,348L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190887Inst : IEnumerable<long>
{
public static readonly long[] Value=A190887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190887.Bytes);
public long this[int i]=>Value[i];

public static A190887Inst Instance=new A190887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190888
{
public static readonly long[] Value={ 1L,10L,14L,18L,27L,31L,35L,39L,44L,48L,52L,56L,65L,69L,73L,82L,86L,90L,99L,103L,107L,111L,116L,120L,124L,128L,133L,137L,141L,145L,154L,158L,162L,171L,175L,179L,183L,188L,192L,196L,200L,205L,209L,213L,217L,226L,230L,234L,243L,247L,251L,260L,264L,268L,272L,277L,281L,285L,289L,298L,302L,306L,315L,319L,323L,332L,336L,340L,344L,349L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190888Inst : IEnumerable<long>
{
public static readonly long[] Value=A190888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190888.Bytes);
public long this[int i]=>Value[i];

public static A190888Inst Instance=new A190888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190889
{
public static readonly long[] Value={ 2L,6L,11L,15L,19L,23L,32L,36L,40L,49L,53L,57L,61L,66L,70L,74L,78L,83L,87L,91L,95L,104L,108L,112L,121L,125L,129L,138L,142L,146L,150L,155L,159L,163L,167L,176L,180L,184L,193L,197L,201L,210L,214L,218L,222L,227L,231L,235L,239L,248L,252L,256L,265L,269L,273L,282L,286L,290L,294L,299L,303L,307L,311L,316L,320L,324L,328L,337L,341L,345L,354L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190889Inst : IEnumerable<long>
{
public static readonly long[] Value=A190889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190889.Bytes);
public long this[int i]=>Value[i];

public static A190889Inst Instance=new A190889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190890
{
public static readonly long[] Value={ 3L,7L,16L,20L,24L,28L,33L,37L,41L,45L,54L,58L,62L,71L,75L,79L,88L,92L,96L,100L,105L,109L,113L,117L,126L,130L,134L,143L,147L,151L,160L,164L,168L,172L,177L,181L,185L,189L,194L,198L,202L,206L,215L,219L,223L,232L,236L,240L,244L,249L,253L,257L,261L,266L,270L,274L,278L,287L,291L,295L,304L,308L,312L,321L,325L,329L,333L,338L,342L,346L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190890Inst : IEnumerable<long>
{
public static readonly long[] Value=A190890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190890.Bytes);
public long this[int i]=>Value[i];

public static A190890Inst Instance=new A190890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190891
{
public static readonly long[] Value={ 4L,8L,12L,21L,25L,29L,38L,42L,46L,50L,55L,59L,63L,67L,72L,76L,80L,84L,93L,97L,101L,110L,114L,118L,122L,127L,131L,135L,139L,144L,148L,152L,156L,165L,169L,173L,182L,186L,190L,199L,203L,207L,211L,216L,220L,224L,228L,237L,241L,245L,254L,258L,262L,271L,275L,279L,283L,288L,292L,296L,300L,309L,313L,317L,326L,330L,334L,343L,347L,351L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190891Inst : IEnumerable<long>
{
public static readonly long[] Value=A190891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190891.Bytes);
public long this[int i]=>Value[i];

public static A190891Inst Instance=new A190891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190940
{
public static readonly long[] Value={ 0L,1L,2L,2L,6L,4L,12L,8L,16L,18L,48L,32L,96L,72L,64L,48L,240L,128L,480L,288L,320L,384L,960L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190940Inst : IEnumerable<long>
{
public static readonly long[] Value=A190940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190940.Bytes);
public long this[int i]=>Value[i];

public static A190940Inst Instance=new A190940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190941
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,9L,11L,13L,14L,15L,17L,18L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,46L,47L,49L,50L,51L,53L,55L,57L,59L,60L,61L,63L,64L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,139L,141L,143L,145L,146L,147L,149L,150L,151L,153L,155L,157L,159L,160L,161L,163L,164L,165L,167L,169L,171L,173L,175L,177L,179L,181L,183L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190941Inst : IEnumerable<long>
{
public static readonly long[] Value=A190941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190941.Bytes);
public long this[int i]=>Value[i];

public static A190941Inst Instance=new A190941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190942
{
public static readonly long[] Value={ 0L,3L,29L,83L,153L,327L,753L,879L,3333L,36977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190942Inst : IEnumerable<long>
{
public static readonly long[] Value=A190942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190942.Bytes);
public long this[int i]=>Value[i];

public static A190942Inst Instance=new A190942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190943
{
public static readonly long[] Value={ 0L,1L,8L,91L,944L,10009L,105560L,1114723L,11767904L,124240753L,1311659432L,13847775787L,146197010960L,1543466033929L,16295047567352L,172033963454899L,1816237991957696L,19174820948943841L,202436993374408520L,2137216112616751867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190943Inst : IEnumerable<long>
{
public static readonly long[] Value=A190943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190943.Bytes);
public long this[int i]=>Value[i];

public static A190943Inst Instance=new A190943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190944
{
public static readonly long[] Value={ 0L,11L,110L,1001L,1100L,1111L,10010L,10101L,11000L,11011L,11110L,100001L,100100L,100111L,101010L,101101L,110000L,110011L,110110L,111001L,111100L,111111L,1000010L,1000101L,1001000L,1001011L,1001110L,1010001L,1010100L,1010111L,1011010L,1011101L,1100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190944Inst : IEnumerable<long>
{
public static readonly long[] Value=A190944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190944.Bytes);
public long this[int i]=>Value[i];

public static A190944Inst Instance=new A190944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190945
{
public static readonly BigInteger[] Value={ 1L,1L,10L,1074L,1637124L,45156692400L,27230193578558160L,BigInteger.Parse("420296434943941609215120"),BigInteger.Parse("190200071567439616748736269178720"),BigInteger.Parse("2843464512159537301384360263178682136716160"),BigInteger.Parse("1562137388408002436396705025296003247844758163480828800") };
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
public class A190945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190945Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190945.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190945Inst Instance=new A190945Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190946
{
public static readonly BigInteger[] Value={ 1L,0L,0L,10L,13002L,235766334L,82210519761384L,BigInteger.Parse("695361269455212253944"),BigInteger.Parse("168167463535759034846785492680"),BigInteger.Parse("1325777080702697500591757770103358112608"),BigInteger.Parse("381104792645297511721802786471971556694067218792480") };
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
public class A190946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190946Inst Instance=new A190946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190947
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,13002L,11471355944L,101716608710405424L,BigInteger.Parse("18726065054096898027414348"),BigInteger.Parse("96678228204760902484487394741989088") };
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
public class A190947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190947.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190947Inst Instance=new A190947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190948
{
public static readonly BigInteger[] Value={ 1L,1L,1L,0L,-12L,-54L,-2628L,-77616L,-86688L,-3837456L,-6295968L,-5189982336L,-773398378368L,-60614059968L,-710855139456L,-274917009540096L,-70812306032928768L,-20799092342375424L,-53842565061863424L,BigInteger.Parse("-48391925819124400128"),BigInteger.Parse("-3845848802828440117248"),BigInteger.Parse("-64663161151688486424576"),BigInteger.Parse("-30966053952082739476783104") };
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
public class A190948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190948Inst Instance=new A190948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190949
{
public static readonly long[] Value={ 1L,5L,13L,89L,233L,1597L,4181L,28657L,75025L,514229L,1346269L,9227465L,24157817L,165580141L,433494437L,2971215073L,7778742049L,53316291173L,139583862445L,956722026041L,2504730781961L,17167680177565L,44945570212853L,308061521170129L,806515533049393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190949Inst : IEnumerable<long>
{
public static readonly long[] Value=A190949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190949.Bytes);
public long this[int i]=>Value[i];

public static A190949Inst Instance=new A190949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190950
{
public static readonly BigInteger[] Value={ 1L,2L,5L,1L,85L,221L,8177L,204425L,204425L,8381425L,13023445L,10327591885L,1497500823325L,115192371025L,1334876299525L,512859474277505L,131804884889318785L,38766142614505525L,100791970797714365L,BigInteger.Parse("91216733571931500325"),BigInteger.Parse("7315582032468906326065"),BigInteger.Parse("124364894551971407543105"),BigInteger.Parse("60316973857706132658405925"),BigInteger.Parse("3196799614458425030895514025") };
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
public class A190950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190950Inst Instance=new A190950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190951
{
public static readonly long[] Value={ 5L,9L,13L,17L,21L,26L,31L,36L,41L,46L,51L,56L,62L,67L,73L,79L,84L,90L,96L,102L,108L,114L,120L,126L,132L,138L,144L,150L,157L,163L,169L,176L,182L,189L,195L,202L,208L,215L,221L,228L,235L,241L,248L,255L,262L,268L,275L,282L,289L,296L,303L,310L,317L,324L,331L,338L,345L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190951Inst : IEnumerable<long>
{
public static readonly long[] Value=A190951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190951.Bytes);
public long this[int i]=>Value[i];

public static A190951Inst Instance=new A190951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190952
{
public static readonly long[] Value={ 4L,8L,12L,16L,21L,26L,30L,35L,40L,45L,51L,56L,61L,67L,72L,78L,84L,89L,95L,101L,107L,113L,119L,125L,131L,137L,144L,150L,156L,163L,169L,175L,182L,188L,195L,201L,208L,214L,221L,228L,234L,241L,248L,254L,261L,268L,275L,282L,288L,295L,302L,309L,316L,323L,330L,337L,344L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190952Inst : IEnumerable<long>
{
public static readonly long[] Value=A190952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190952.Bytes);
public long this[int i]=>Value[i];

public static A190952Inst Instance=new A190952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190953
{
public static readonly ulong[] Value={ 0L,1L,8L,74L,672L,6116L,55648L,506344L,4607232L,41921296L,381442688L,3470754464L,31580462592L,287351245376L,2614614588928L,23790429165184L,216469579210752L,1969660925337856L,17921983194810368L,163072474811861504L,1483799630442995712L,13501121791662580736UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190953Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A190953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190953.Bytes);
public ulong this[int i]=>Value[i];

public static A190953Inst Instance=new A190953Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190954
{
public static readonly BigInteger[] Value={ 0L,1L,10L,104L,1080L,11216L,116480L,1209664L,12562560L,130464256L,1354892800L,14070785024L,146127421440L,1517557354496L,15760083230720L,163671061725184L,1699750950174720L,17652193748647936L,183320941287178240L,1903818187866374144L,BigInteger.Parse("19771465643812454400") };
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
public class A190954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190954Inst Instance=new A190954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190955
{
public static readonly BigInteger[] Value={ 0L,1L,10L,105L,1100L,11525L,120750L,1265125L,13255000L,138875625L,1455031250L,15244690625L,159722062500L,1673444078125L,17533051093750L,183697731328125L,1924642568750000L,20164914344140625L,211272356285156250L,2213548134572265625L,BigInteger.Parse("23191843127148437500") };
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
public class A190955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190955Inst Instance=new A190955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190972
{
public static readonly long[] Value={ 0L,1L,7L,46L,301L,1969L,12880L,84253L,551131L,3605158L,23582713L,154263517L,1009096480L,6600884809L,43178904223L,282449675134L,1847611013269L,12085928067481L,79058663432560L,517152859825477L,3382894028480659L,22128799619888182L,144752915253775297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190972Inst : IEnumerable<long>
{
public static readonly long[] Value=A190972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190972.Bytes);
public long this[int i]=>Value[i];

public static A190972Inst Instance=new A190972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190973
{
public static readonly long[] Value={ 0L,1L,7L,45L,287L,1829L,11655L,74269L,473263L,3015765L,19217303L,122458061L,780337215L,4972528261L,31686348967L,201914329725L,1286654912207L,8198927066549L,52245869817015L,332925380452909L,2121494183902303L,13518757765504485L,86145327622922183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190973Inst : IEnumerable<long>
{
public static readonly long[] Value=A190973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190973.Bytes);
public long this[int i]=>Value[i];

public static A190973Inst Instance=new A190973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190974
{
public static readonly long[] Value={ 0L,1L,7L,44L,273L,1691L,10472L,64849L,401583L,2486836L,15399937L,95365379L,590557968L,3657078881L,22646762327L,140241941884L,868459781553L,5378008761451L,33303762422392L,206236293149489L,1277135239934463L,7908765213793796L,48975680296884257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190974Inst : IEnumerable<long>
{
public static readonly long[] Value=A190974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190974.Bytes);
public long this[int i]=>Value[i];

public static A190974Inst Instance=new A190974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190975
{
public static readonly long[] Value={ 0L,1L,8L,62L,480L,3716L,28768L,222712L,1724160L,13347856L,103334528L,799980512L,6193175040L,47945439296L,371177164288L,2873526435712L,22245857157120L,172219804385536L,1333266720770048L,10321694157389312L,79907019817574400L,618612770225816576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190975Inst : IEnumerable<long>
{
public static readonly long[] Value=A190975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190975.Bytes);
public long this[int i]=>Value[i];

public static A190975Inst Instance=new A190975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190976
{
public static readonly long[] Value={ 0L,1L,8L,61L,464L,3529L,26840L,204133L,1552544L,11807953L,89805992L,683024077L,5194774640L,39509124889L,300488675192L,2285382026869L,17381590189376L,132196575434401L,1005427832907080L,7646832936953437L,58158379996906256L,442326541164389737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190976Inst : IEnumerable<long>
{
public static readonly long[] Value=A190976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190976.Bytes);
public long this[int i]=>Value[i];

public static A190976Inst Instance=new A190976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190977
{
public static readonly long[] Value={ 0L,1L,8L,59L,432L,3161L,23128L,169219L,1238112L,9058801L,66279848L,484944779L,3548158992L,25960548041L,189943589368L,1389745974739L,10168249851072L,74397268934881L,544336902223688L,3982708873115099L,29139986473802352L,213206347424843321L,1559950847029734808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190977Inst : IEnumerable<long>
{
public static readonly long[] Value=A190977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190977.Bytes);
public long this[int i]=>Value[i];

public static A190977Inst Instance=new A190977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190978
{
public static readonly long[] Value={ 0L,1L,8L,58L,416L,2980L,21344L,152872L,1094912L,7842064L,56167040L,402283936L,2881269248L,20636450368L,147803987456L,1058613197440L,7582081654784L,54304974053632L,388947302500352L,2785748575681024L,19952304790446080L,142903946869482496L,1023517746213183488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190978Inst : IEnumerable<long>
{
public static readonly long[] Value=A190978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190978.Bytes);
public long this[int i]=>Value[i];

public static A190978Inst Instance=new A190978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190979
{
public static readonly long[] Value={ 0L,1L,9L,79L,693L,6079L,53325L,467767L,4103253L,35993743L,315737181L,2769647143L,24295349925L,213118855039L,1869478995501L,16399073249431L,143852701253877L,1261876164786031L,11069180080566525L,97098868395526663L,851751455398606917L,7471565361796408927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190979Inst : IEnumerable<long>
{
public static readonly long[] Value=A190979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190979.Bytes);
public long this[int i]=>Value[i];

public static A190979Inst Instance=new A190979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190980
{
public static readonly long[] Value={ 0L,1L,9L,78L,675L,5841L,50544L,437373L,3784725L,32750406L,283399479L,2452344093L,21220898400L,183631053321L,1589016784689L,13750257902238L,118985270766075L,1029616663187961L,8909594156393424L,77097497417976933L,667148694292612125L,5773045756379578326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190980Inst : IEnumerable<long>
{
public static readonly long[] Value=A190980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190980.Bytes);
public long this[int i]=>Value[i];

public static A190980Inst Instance=new A190980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190981
{
public static readonly long[] Value={ 0L,1L,9L,77L,657L,5605L,47817L,407933L,3480129L,29689429L,253284345L,2160801389L,18434075121L,157263470533L,1341634934313L,11445660526685L,97644405002913L,833017002919477L,7106575406263641L,60627110644694861L,517217694177199185L,4412450805016013221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190981Inst : IEnumerable<long>
{
public static readonly long[] Value=A190981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190981.Bytes);
public long this[int i]=>Value[i];

public static A190981Inst Instance=new A190981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190982
{
public static readonly long[] Value={ 0L,1L,9L,76L,639L,5371L,45144L,379441L,3189249L,26806036L,225308079L,1893742531L,15917142384L,133785568801L,1124484407289L,9451431821596L,79440464357919L,667707020113291L,5612160859230024L,47170912632503761L,396477409396383729L,3332442121404934756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190982Inst : IEnumerable<long>
{
public static readonly long[] Value=A190982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190982.Bytes);
public long this[int i]=>Value[i];

public static A190982Inst Instance=new A190982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190983
{
public static readonly long[] Value={ 0L,1L,9L,75L,621L,5139L,42525L,351891L,2911869L,24095475L,199388061L,1649919699L,13652948925L,112977022131L,934875505629L,7736017417875L,64014903727101L,529718029036659L,4383372838967325L,36272047376485971L,300148189354569789L,2483701419932212275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190983Inst : IEnumerable<long>
{
public static readonly long[] Value=A190983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190983.Bytes);
public long this[int i]=>Value[i];

public static A190983Inst Instance=new A190983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190984
{
public static readonly long[] Value={ 0L,1L,9L,74L,603L,4909L,39960L,325277L,2647773L,21553018L,175442751L,1428113633L,11624923440L,94627515529L,770273175681L,6270065972426L,51038681522067L,415457671891621L,3381848276370120L,27528430784089733L,224082939122216757L,1824047436611322682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190984Inst : IEnumerable<long>
{
public static readonly long[] Value=A190984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190984.Bytes);
public long this[int i]=>Value[i];

public static A190984Inst Instance=new A190984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190985
{
public static readonly BigInteger[] Value={ 0L,1L,10L,97L,940L,9109L,88270L,855373L,8288920L,80323081L,778364050L,7542671257L,73091620420L,708288190429L,6863607043030L,66511205859013L,644521237461040L,6245678757033361L,60523223857950490L,586495202308404817L,5683382351510196700L,BigInteger.Parse("55074337908176752549") };
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
public class A190985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190985.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190985Inst Instance=new A190985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190986
{
public static readonly BigInteger[] Value={ 0L,1L,10L,96L,920L,8816L,84480L,809536L,7757440L,74336256L,712332800L,6825982976L,65410498560L,626801053696L,6006368542720L,57556481212416L,551539337953280L,5285167454683136L,50645517195018240L,485314502131449856L,4650562952534425600L,BigInteger.Parse("44564371516818456576") };
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
public class A190986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190986Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190986.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190986.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190986Inst Instance=new A190986Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190987
{
public static readonly BigInteger[] Value={ 0L,1L,10L,95L,900L,8525L,80750L,764875L,7245000L,68625625L,650031250L,6157184375L,58321687500L,552430953125L,5232701093750L,49564856171875L,469485056250000L,4447026281640625L,42122837535156250L,398993243943359375L,3779318251757812500L,BigInteger.Parse("35798216297861328125") };
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
public class A190987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190987Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190987.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190987.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190987Inst Instance=new A190987Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191020
{
public static readonly long[] Value={ 13L,19L,23L,29L,31L,43L,47L,61L,71L,83L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,173L,191L,197L,199L,211L,223L,227L,257L,277L,283L,293L,307L,311L,313L,347L,349L,353L,367L,373L,383L,401L,433L,449L,461L,463L,487L,491L,521L,523L,541L,547L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191020Inst : IEnumerable<long>
{
public static readonly long[] Value=A191020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191020.Bytes);
public long this[int i]=>Value[i];

public static A191020Inst Instance=new A191020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191021
{
public static readonly long[] Value={ 2L,3L,13L,29L,31L,41L,47L,59L,71L,73L,101L,127L,131L,139L,151L,163L,167L,173L,179L,193L,197L,211L,223L,233L,239L,257L,269L,271L,277L,307L,311L,317L,331L,347L,349L,353L,397L,409L,439L,443L,449L,461L,463L,487L,491L,499L,509L,541L,547L,577L,587L,593L,599L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191021Inst : IEnumerable<long>
{
public static readonly long[] Value=A191021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191021.Bytes);
public long this[int i]=>Value[i];

public static A191021Inst Instance=new A191021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191022
{
public static readonly long[] Value={ 5L,7L,13L,23L,53L,59L,67L,71L,83L,103L,107L,109L,139L,149L,151L,167L,173L,179L,181L,197L,199L,223L,227L,233L,239L,241L,257L,277L,281L,283L,313L,347L,349L,353L,373L,383L,397L,401L,419L,431L,439L,457L,463L,487L,499L,509L,521L,523L,547L,557L,571L,587L,593L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191022Inst : IEnumerable<long>
{
public static readonly long[] Value=A191022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191022.Bytes);
public long this[int i]=>Value[i];

public static A191022Inst Instance=new A191022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191023
{
public static readonly long[] Value={ 11L,13L,17L,23L,29L,31L,37L,43L,47L,59L,67L,79L,101L,113L,131L,137L,149L,151L,157L,163L,167L,179L,199L,233L,241L,251L,257L,263L,269L,271L,277L,283L,307L,353L,373L,383L,389L,397L,409L,419L,439L,461L,491L,503L,509L,523L,547L,593L,601L,613L,617L,631L,643L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191023Inst : IEnumerable<long>
{
public static readonly long[] Value=A191023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191023.Bytes);
public long this[int i]=>Value[i];

public static A191023Inst Instance=new A191023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191024
{
public static readonly long[] Value={ 2L,5L,7L,19L,41L,47L,59L,67L,71L,97L,101L,103L,107L,109L,113L,131L,149L,157L,163L,173L,191L,193L,211L,227L,233L,257L,281L,283L,293L,307L,311L,317L,349L,359L,373L,379L,397L,419L,421L,431L,439L,443L,467L,479L,503L,521L,541L,547L,563L,577L,593L,599L,607L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191024Inst : IEnumerable<long>
{
public static readonly long[] Value=A191024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191024.Bytes);
public long this[int i]=>Value[i];

public static A191024Inst Instance=new A191024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191025
{
public static readonly long[] Value={ 3L,5L,11L,29L,37L,47L,61L,89L,103L,107L,109L,127L,131L,137L,139L,151L,163L,173L,181L,191L,197L,211L,223L,227L,239L,257L,263L,269L,271L,277L,281L,283L,317L,347L,353L,359L,379L,383L,397L,409L,419L,433L,457L,463L,499L,541L,547L,569L,571L,577L,593L,599L,619L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191025Inst : IEnumerable<long>
{
public static readonly long[] Value=A191025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191025.Bytes);
public long this[int i]=>Value[i];

public static A191025Inst Instance=new A191025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191026
{
public static readonly long[] Value={ 3L,11L,13L,17L,29L,47L,71L,73L,79L,83L,97L,103L,109L,149L,151L,157L,167L,173L,179L,191L,211L,223L,227L,239L,257L,281L,283L,293L,307L,313L,331L,353L,359L,367L,379L,383L,389L,397L,401L,421L,431L,433L,449L,467L,491L,499L,503L,523L,541L,563L,569L,571L,577L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191026Inst : IEnumerable<long>
{
public static readonly long[] Value=A191026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191026.Bytes);
public long this[int i]=>Value[i];

public static A191026Inst Instance=new A191026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191027
{
public static readonly long[] Value={ 3L,7L,11L,41L,47L,53L,67L,71L,73L,83L,101L,107L,127L,137L,139L,149L,151L,157L,173L,181L,197L,211L,223L,229L,233L,263L,269L,271L,293L,307L,317L,337L,349L,359L,367L,373L,379L,397L,419L,433L,443L,491L,509L,521L,571L,593L,599L,601L,613L,617L,619L,641L,659L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191027Inst : IEnumerable<long>
{
public static readonly long[] Value=A191027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191027.Bytes);
public long this[int i]=>Value[i];

public static A191027Inst Instance=new A191027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191028
{
public static readonly long[] Value={ 3L,7L,13L,17L,23L,29L,37L,47L,53L,59L,67L,73L,107L,109L,137L,173L,179L,181L,191L,199L,211L,227L,233L,239L,263L,269L,271L,293L,307L,311L,313L,317L,331L,353L,359L,367L,373L,379L,421L,457L,463L,479L,503L,509L,523L,547L,563L,577L,593L,617L,631L,647L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191028Inst : IEnumerable<long>
{
public static readonly long[] Value=A191028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191028.Bytes);
public long this[int i]=>Value[i];

public static A191028Inst Instance=new A191028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191029
{
public static readonly long[] Value={ 2L,5L,11L,41L,43L,47L,59L,61L,71L,79L,83L,89L,103L,127L,137L,139L,149L,157L,167L,181L,197L,199L,211L,227L,239L,277L,281L,283L,293L,313L,317L,337L,353L,359L,367L,373L,383L,401L,431L,433L,439L,449L,461L,479L,509L,523L,547L,557L,571L,587L,593L,601L,607L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191029Inst : IEnumerable<long>
{
public static readonly long[] Value=A191029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191029.Bytes);
public long this[int i]=>Value[i];

public static A191029Inst Instance=new A191029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191030
{
public static readonly long[] Value={ 2L,5L,23L,31L,37L,43L,59L,61L,73L,83L,103L,107L,113L,127L,131L,139L,163L,173L,197L,223L,241L,251L,269L,271L,277L,283L,307L,337L,349L,353L,359L,367L,373L,379L,389L,401L,409L,419L,431L,433L,443L,449L,461L,467L,487L,491L,523L,541L,569L,599L,607L,613L,617L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191030Inst : IEnumerable<long>
{
public static readonly long[] Value=A191030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191030.Bytes);
public long this[int i]=>Value[i];

public static A191030Inst Instance=new A191030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191031
{
public static readonly long[] Value={ 11L,13L,17L,23L,31L,41L,47L,53L,59L,67L,79L,83L,97L,101L,103L,107L,109L,127L,139L,167L,173L,181L,193L,197L,229L,239L,251L,269L,271L,281L,283L,293L,307L,311L,317L,337L,353L,359L,367L,379L,397L,401L,431L,439L,443L,461L,479L,487L,509L,541L,547L,557L,563L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191031Inst : IEnumerable<long>
{
public static readonly long[] Value=A191031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191031.Bytes);
public long this[int i]=>Value[i];

public static A191031Inst Instance=new A191031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191032
{
public static readonly long[] Value={ 5L,11L,19L,31L,37L,41L,43L,47L,53L,61L,67L,71L,73L,83L,107L,109L,127L,149L,151L,157L,167L,181L,193L,223L,227L,229L,233L,239L,251L,257L,271L,283L,293L,311L,353L,373L,379L,389L,409L,419L,421L,439L,449L,463L,467L,487L,523L,557L,563L,571L,577L,593L,599L,601L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191032Inst : IEnumerable<long>
{
public static readonly long[] Value=A191032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191032.Bytes);
public long this[int i]=>Value[i];

public static A191032Inst Instance=new A191032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191033
{
public static readonly long[] Value={ 2L,3L,7L,17L,37L,53L,59L,61L,71L,79L,83L,89L,97L,101L,103L,131L,149L,157L,173L,191L,197L,239L,241L,251L,263L,269L,271L,277L,283L,307L,331L,337L,347L,353L,379L,383L,397L,401L,431L,439L,457L,479L,487L,491L,521L,523L,541L,571L,601L,613L,617L,619L,643L,647L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191033Inst : IEnumerable<long>
{
public static readonly long[] Value=A191033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191033.Bytes);
public long this[int i]=>Value[i];

public static A191033Inst Instance=new A191033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191034
{
public static readonly long[] Value={ 5L,11L,13L,19L,23L,29L,41L,43L,67L,71L,103L,107L,113L,127L,131L,151L,157L,167L,173L,197L,223L,227L,229L,233L,269L,271L,307L,311L,317L,331L,347L,349L,373L,401L,409L,419L,421L,431L,433L,449L,457L,463L,479L,503L,521L,523L,577L,613L,617L,631L,641L,653L,661L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191034Inst : IEnumerable<long>
{
public static readonly long[] Value=A191034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191034.Bytes);
public long this[int i]=>Value[i];

public static A191034Inst Instance=new A191034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191035
{
public static readonly long[] Value={ 7L,11L,13L,17L,29L,37L,43L,47L,59L,89L,97L,107L,113L,131L,149L,163L,197L,199L,211L,223L,227L,229L,241L,269L,271L,281L,293L,307L,311L,317L,331L,347L,367L,409L,431L,433L,439L,449L,461L,467L,487L,521L,523L,541L,547L,577L,587L,593L,599L,607L,619L,643L,647L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191035Inst : IEnumerable<long>
{
public static readonly long[] Value=A191035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191035.Bytes);
public long this[int i]=>Value[i];

public static A191035Inst Instance=new A191035Inst();

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