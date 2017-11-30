using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A155464
{
public static readonly long[] Value={ 0L,51L,340L,2023L,11832L,69003L,402220L,2344351L,13663920L,79639203L,464171332L,2705388823L,15768161640L,91903581051L,535653324700L,3122016367183L,18196444878432L,106056652903443L,618143472542260L,3602804182350151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155464Inst : IEnumerable<long>
{
public static readonly long[] Value=A155464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155464.Bytes);
public long this[int i]=>Value[i];

public static A155464Inst Instance=new A155464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155465
{
public static readonly long[] Value={ 7L,88L,555L,3276L,19135L,111568L,650307L,3790308L,22091575L,128759176L,750463515L,4374021948L,25493668207L,148587987328L,866034255795L,5047617547476L,29419671029095L,171470408627128L,999402780733707L,5824946275775148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155465Inst : IEnumerable<long>
{
public static readonly long[] Value=A155465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155465.Bytes);
public long this[int i]=>Value[i];

public static A155465Inst Instance=new A155465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155466
{
public static readonly long[] Value={ 28L,207L,1248L,7315L,42676L,248775L,1450008L,8451307L,49257868L,287095935L,1673317776L,9752810755L,56843546788L,331308470007L,1931007273288L,11254735169755L,65597403745276L,382329687301935L,2228380720066368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155466Inst : IEnumerable<long>
{
public static readonly long[] Value=A155466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155466.Bytes);
public long this[int i]=>Value[i];

public static A155466Inst Instance=new A155466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155467
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,22L,22L,1L,1L,65L,220L,65L,1L,1L,171L,1510L,1510L,171L,1L,1L,420L,8337L,21140L,8337L,420L,1L,1L,988L,40068L,218666L,218666L,40068L,988L,1L,1L,2259L,175296L,1852914L,3935988L,1852914L,175296L,2259L,1L,1L,5065L,717600L,13655760L,55034868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155467Inst : IEnumerable<long>
{
public static readonly long[] Value=A155467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155467.Bytes);
public long this[int i]=>Value[i];

public static A155467Inst Instance=new A155467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155468
{
public static readonly long[] Value={ 257L,6562L,6817L,65537L,65792L,72097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155468Inst : IEnumerable<long>
{
public static readonly long[] Value=A155468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155468.Bytes);
public long this[int i]=>Value[i];

public static A155468Inst Instance=new A155468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155469
{
public static readonly long[] Value={ 2L,5L,9L,10L,12L,17L,17L,24L,26L,28L,31L,33L,36L,37L,43L,44L,50L,52L,57L,63L,65L,65L,68L,72L,73L,76L,80L,82L,89L,89L,91L,100L,101L,108L,108L,113L,122L,126L,127L,128L,129L,129L,134L,141L,145L,145L,148L,150L,152L,161L,164L,170L,171L,174L,177L,185L,189L,196L,197L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155469Inst : IEnumerable<long>
{
public static readonly long[] Value=A155469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155469.Bytes);
public long this[int i]=>Value[i];

public static A155469Inst Instance=new A155469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155470
{
public static readonly long[] Value={ 5L,9L,10L,17L,17L,24L,26L,28L,31L,33L,37L,43L,44L,50L,52L,57L,63L,65L,65L,68L,72L,73L,76L,82L,89L,89L,91L,100L,101L,108L,108L,113L,122L,126L,127L,128L,129L,129L,134L,141L,145L,145L,148L,152L,161L,164L,170L,171L,174L,177L,185L,189L,196L,197L,204L,206L,208L,217L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155470Inst : IEnumerable<long>
{
public static readonly long[] Value=A155470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155470.Bytes);
public long this[int i]=>Value[i];

public static A155470Inst Instance=new A155470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155471
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,23L,29L,37L,43L,47L,53L,59L,61L,67L,71L,79L,83L,89L,97L,101L,103L,107L,109L,127L,131L,137L,139L,149L,151L,163L,173L,179L,181L,197L,223L,227L,229L,233L,239L,257L,263L,269L,277L,283L,293L,311L,313L,317L,337L,347L,349L,353L,359L,367L,373L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155471Inst : IEnumerable<long>
{
public static readonly long[] Value=A155471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155471.Bytes);
public long this[int i]=>Value[i];

public static A155471Inst Instance=new A155471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155472
{
public static readonly long[] Value={ 2L,9L,28L,33L,40L,59L,65L,96L,126L,157L,217L,244L,248L,251L,270L,307L,344L,368L,375L,459L,513L,544L,586L,730L,755L,761L,972L,1001L,1025L,1032L,1032L,1051L,1088L,1149L,1240L,1243L,1332L,1363L,1367L,1536L,1574L,1729L,1753L,1760L,1971L,2024L,2198L,2229L,2355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155472Inst : IEnumerable<long>
{
public static readonly long[] Value=A155472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155472.Bytes);
public long this[int i]=>Value[i];

public static A155472Inst Instance=new A155472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155473
{
public static readonly long[] Value={ 9L,28L,33L,59L,65L,96L,126L,157L,217L,244L,248L,251L,307L,344L,368L,375L,459L,513L,544L,586L,730L,755L,761L,972L,1001L,1025L,1032L,1032L,1051L,1149L,1240L,1243L,1332L,1363L,1367L,1536L,1574L,1729L,1753L,1760L,1971L,2024L,2198L,2229L,2355L,2440L,2745L,2752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155473Inst : IEnumerable<long>
{
public static readonly long[] Value=A155473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155473.Bytes);
public long this[int i]=>Value[i];

public static A155473Inst Instance=new A155473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155474
{
public static readonly long[] Value={ 1L,9L,15L,21L,25L,27L,33L,35L,39L,45L,49L,51L,55L,57L,63L,65L,69L,75L,77L,85L,87L,91L,93L,95L,99L,105L,111L,117L,119L,123L,129L,143L,145L,147L,153L,155L,159L,161L,165L,169L,171L,175L,177L,183L,185L,201L,203L,205L,207L,209L,213L,225L,235L,237L,243L,245L,247L,249L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155474Inst : IEnumerable<long>
{
public static readonly long[] Value=A155474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155474.Bytes);
public long this[int i]=>Value[i];

public static A155474Inst Instance=new A155474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155475
{
public static readonly long[] Value={ 4L,10L,12L,14L,16L,20L,22L,24L,30L,40L,50L,60L,70L,72L,90L,92L,100L,102L,104L,106L,108L,118L,120L,122L,124L,130L,132L,134L,136L,138L,144L,146L,148L,150L,154L,158L,160L,162L,166L,168L,190L,200L,202L,204L,206L,208L,210L,220L,230L,240L,250L,260L,270L,280L,290L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155475Inst : IEnumerable<long>
{
public static readonly long[] Value=A155475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155475.Bytes);
public long this[int i]=>Value[i];

public static A155475Inst Instance=new A155475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155476
{
public static readonly long[] Value={ 7L,29L,37L,73L,97L,109L,137L,139L,149L,181L,239L,271L,281L,283L,293L,307L,367L,379L,397L,419L,449L,499L,557L,577L,593L,599L,631L,659L,691L,733L,751L,839L,877L,881L,883L,911L,919L,971L,977L,1109L,1129L,1193L,1229L,1249L,1283L,1289L,1291L,1307L,1429L,1489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155476Inst : IEnumerable<long>
{
public static readonly long[] Value=A155476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155476.Bytes);
public long this[int i]=>Value[i];

public static A155476Inst Instance=new A155476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155477
{
public static readonly BigInteger[] Value={ 43L,79507L,147008443L,271818611107L,502592611936843L,929293739471222707L,BigInteger.Parse("1718264124282290785243"),BigInteger.Parse("3177070365797955661914307"),BigInteger.Parse("5874403106360420018879553643"),BigInteger.Parse("10861771343660416614908294685907"),BigInteger.Parse("20083415214428110320965436874242043") };
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
public class A155477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155477Inst Instance=new A155477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155478
{
public static readonly long[] Value={ 6L,8L,26L,28L,32L,34L,36L,38L,42L,44L,46L,48L,54L,56L,58L,64L,66L,68L,74L,76L,78L,82L,84L,86L,88L,94L,96L,98L,126L,172L,174L,176L,178L,182L,184L,186L,212L,214L,222L,224L,226L,228L,232L,234L,236L,238L,242L,244L,246L,248L,252L,254L,256L,258L,262L,264L,266L,268L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155478Inst : IEnumerable<long>
{
public static readonly long[] Value=A155478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155478.Bytes);
public long this[int i]=>Value[i];

public static A155478Inst Instance=new A155478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155479
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,23L,29L,31L,37L,43L,53L,61L,67L,71L,73L,79L,89L,101L,107L,109L,173L,179L,181L,193L,199L,223L,227L,281L,283L,293L,311L,317L,337L,347L,409L,419L,421L,433L,443L,457L,461L,463L,467L,479L,491L,503L,521L,523L,541L,547L,557L,569L,577L,593L,599L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155479Inst : IEnumerable<long>
{
public static readonly long[] Value=A155479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155479.Bytes);
public long this[int i]=>Value[i];

public static A155479Inst Instance=new A155479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155480
{
public static readonly long[] Value={ 14L,30L,32L,54L,56L,74L,92L,94L,95L,116L,138L,148L,159L,169L,189L,196L,208L,209L,213L,217L,224L,245L,247L,249L,261L,270L,272L,273L,275L,280L,282L,284L,285L,286L,287L,288L,289L,290L,291L,292L,294L,295L,296L,297L,298L,299L,309L,321L,324L,325L,326L,330L,334L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155480Inst : IEnumerable<long>
{
public static readonly long[] Value=A155480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155480.Bytes);
public long this[int i]=>Value[i];

public static A155480Inst Instance=new A155480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155481
{
public static readonly long[] Value={ 3L,1L,4L,2L,-4L,-1L,3L,-3L,-5L,4L,-4L,-1L,0L,-2L,-1L,3L,2L,4L,-2L,5L,-4L,3L,-4L,4L,3L,4L,-2L,3L,3L,-2L,0L,-5L,0L,3L,-1L,-2L,4L,2L,0L,-3L,2L,-3L,-1L,4L,0L,-1L,4L,-2L,-5L,1L,1L,-4L,-2L,2L,1L,0L,-3L,5L,-1L,4L,5L,-4L,-1L,2L,3L,1L,-2L,-2L,2L,-4L,4L,1L,-4L,3L,-1L,-4L,2L,1L,-1L,0L,0L,-1L,-4L,3L,-2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155481Inst : IEnumerable<long>
{
public static readonly long[] Value=A155481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155481.Bytes);
public long this[int i]=>Value[i];

public static A155481Inst Instance=new A155481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155482
{
public static readonly long[] Value={ 1L,0L,-1L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,1L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,1L,0L,-1L,1L,-1L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,-1L,0L,0L,1L,0L,-1L,1L,-1L,0L,1L,0L,-1L,0L,0L,1L,-1L,0L,1L,0L,-1L,0L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155482Inst : IEnumerable<long>
{
public static readonly long[] Value=A155482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155482.Bytes);
public long this[int i]=>Value[i];

public static A155482Inst Instance=new A155482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155483
{
public static readonly long[] Value={ 29L,71L,113L,173L,229L,281L,349L,409L,463L,547L,557L,563L,569L,571L,577L,587L,593L,599L,601L,659L,733L,809L,863L,941L,1013L,1069L,1151L,1229L,1231L,1237L,1249L,1259L,1277L,1279L,1283L,1289L,1291L,1373L,1451L,1511L,1583L,1657L,1733L,1811L,1889L,1993L,1997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155483Inst : IEnumerable<long>
{
public static readonly long[] Value=A155483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155483.Bytes);
public long this[int i]=>Value[i];

public static A155483Inst Instance=new A155483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155484
{
public static readonly BigInteger[] Value={ 3169L,31824875809L,319603256629306849L,BigInteger.Parse("3209635200498468418800289"),BigInteger.Parse("32232957288753099502375449100129"),BigInteger.Parse("323701439782697615691675092490440590369") };
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
public class A155484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155484Inst Instance=new A155484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155485
{
public static readonly long[] Value={ 1L,4L,20L,104L,540L,2784L,14260L,72664L,368780L,1865744L,9416100L,47430024L,238548220L,1198333504L,6014037140L,30159664184L,151156234860L,757212830064L,3791790773380L,18981860359144L,95000927764700L,475371142699424L,2378321729000820L,11897472707018904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155485Inst : IEnumerable<long>
{
public static readonly long[] Value=A155485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155485.Bytes);
public long this[int i]=>Value[i];

public static A155485Inst Instance=new A155485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155486
{
public static readonly long[] Value={ 10L,34L,58L,710L,914L,1116L,1320L,1522L,2130L,2738L,2940L,3144L,3346L,3954L,4156L,4358L,4562L,4764L,4966L,5372L,5980L,6182L,6790L,6992L,7194L,7396L,77102L,81108L,85114L,87116L,89118L,91120L,93122L,95124L,97126L,101132L,103134L,105136L,107140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155486Inst : IEnumerable<long>
{
public static readonly long[] Value=A155486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155486.Bytes);
public long this[int i]=>Value[i];

public static A155486Inst Instance=new A155486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155487
{
public static readonly long[] Value={ 0L,2L,4L,3L,6L,8L,10L,9L,12L,14L,16L,15L,18L,20L,15L,22L,21L,24L,26L,28L,27L,30L,25L,32L,34L,33L,36L,38L,40L,39L,42L,44L,35L,46L,45L,48L,50L,45L,52L,51L,54L,56L,58L,57L,60L,55L,62L,64L,63L,66L,68L,70L,69L,72L,63L,74L,76L,75L,78L,80L,75L,82L,81L,84L,86L,77L,88L,87L,90L,85L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155487Inst : IEnumerable<long>
{
public static readonly long[] Value=A155487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155487.Bytes);
public long this[int i]=>Value[i];

public static A155487Inst Instance=new A155487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155488
{
public static readonly long[] Value={ 7L,11L,13L,19L,23L,37L,41L,47L,53L,59L,89L,103L,127L,131L,139L,157L,167L,173L,179L,197L,211L,223L,241L,251L,263L,277L,281L,293L,317L,331L,367L,373L,379L,383L,397L,401L,409L,419L,449L,463L,487L,491L,499L,503L,521L,557L,569L,571L,601L,607L,613L,619L,641L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155488Inst : IEnumerable<long>
{
public static readonly long[] Value=A155488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155488.Bytes);
public long this[int i]=>Value[i];

public static A155488Inst Instance=new A155488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155489
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,29L,31L,37L,59L,67L,71L,73L,97L,101L,109L,113L,127L,131L,137L,139L,149L,157L,167L,173L,191L,193L,199L,223L,229L,233L,239L,251L,269L,271L,293L,307L,317L,337L,349L,359L,367L,373L,379L,397L,419L,439L,449L,457L,467L,479L,491L,499L,503L,509L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155489Inst : IEnumerable<long>
{
public static readonly long[] Value=A155489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155489.Bytes);
public long this[int i]=>Value[i];

public static A155489Inst Instance=new A155489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155490
{
public static readonly long[] Value={ 1L,6L,7L,1L,9L,5L,0L,0L,1L,6L,1L,7L,3L,0L,1L,0L,3L,4L,6L,8L,1L,3L,7L,2L,5L,2L,3L,5L,0L,2L,2L,1L,1L,0L,4L,2L,5L,1L,8L,0L,8L,7L,5L,0L,7L,2L,7L,3L,8L,8L,5L,4L,6L,5L,6L,2L,5L,9L,6L,8L,8L,8L,4L,6L,8L,9L,6L,6L,3L,5L,2L,1L,2L,1L,5L,7L,5L,8L,5L,2L,3L,7L,9L,7L,7L,9L,8L,5L,2L,9L,7L,3L,5L,5L,8L,0L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155490Inst : IEnumerable<long>
{
public static readonly long[] Value=A155490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155490.Bytes);
public long this[int i]=>Value[i];

public static A155490Inst Instance=new A155490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155491
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,78L,78L,1L,1L,415L,1820L,415L,1L,1L,2031L,27410L,27410L,2031L,1L,1L,9534L,330225L,959350L,330225L,9534L,1L,1L,43660L,3488884L,23935450L,23935450L,3488884L,43660L,1L,1L,196569L,33888576L,484631574L,1120179060L,484631574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155491Inst : IEnumerable<long>
{
public static readonly long[] Value=A155491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155491.Bytes);
public long this[int i]=>Value[i];

public static A155491Inst Instance=new A155491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155492
{
public static readonly long[] Value={ 21L,69L,1015L,1421L,2839L,3245L,4055L,4257L,4663L,4865L,6081L,6891L,7093L,7295L,86115L,88117L,90119L,92121L,94123L,96125L,102133L,104135L,108141L,110143L,112145L,114147L,118153L,120155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155492Inst : IEnumerable<long>
{
public static readonly long[] Value=A155492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155492.Bytes);
public long this[int i]=>Value[i];

public static A155492Inst Instance=new A155492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155493
{
public static readonly long[] Value={ 1L,1L,1L,1L,15L,1L,1L,118L,118L,1L,1L,770L,3540L,770L,1L,1L,4671L,67810L,67810L,4671L,1L,1L,27321L,1039689L,3085355L,1039689L,27321L,1L,1L,156220L,14006244L,99524810L,99524810L,14006244L,156220L,1L,1L,878868L,173788752L,2602528824L,6090918372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155493Inst : IEnumerable<long>
{
public static readonly long[] Value=A155493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155493.Bytes);
public long this[int i]=>Value[i];

public static A155493Inst Instance=new A155493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155494
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,18L,18L,1L,1L,32L,54L,32L,1L,1L,50L,120L,120L,50L,1L,1L,72L,225L,320L,225L,72L,1L,1L,98L,378L,700L,700L,378L,98L,1L,1L,128L,588L,1344L,1750L,1344L,588L,128L,1L,1L,162L,864L,2352L,3780L,3780L,2352L,864L,162L,1L,1L,200L,1215L,3840L,7350L,9072L,7350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155494Inst : IEnumerable<long>
{
public static readonly long[] Value=A155494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155494.Bytes);
public long this[int i]=>Value[i];

public static A155494Inst Instance=new A155494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155495
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,45L,45L,1L,1L,112L,420L,112L,1L,1L,225L,2100L,2100L,225L,1L,1L,396L,7425L,18480L,7425L,396L,1L,1L,637L,21021L,105105L,105105L,21021L,637L,1L,1L,960L,50960L,448448L,900900L,448448L,50960L,960L,1L,1L,1377L,110160L,1559376L,5513508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155495Inst : IEnumerable<long>
{
public static readonly long[] Value=A155495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155495.Bytes);
public long this[int i]=>Value[i];

public static A155495Inst Instance=new A155495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155496
{
public static readonly long[] Value={ 1L,5L,3L,9L,5L,0L,1L,8L,4L,9L,5L,6L,2L,9L,6L,0L,5L,0L,3L,3L,3L,2L,1L,0L,5L,6L,3L,9L,6L,4L,8L,1L,4L,9L,6L,7L,7L,4L,6L,3L,2L,0L,1L,6L,8L,5L,7L,1L,5L,2L,0L,8L,4L,2L,3L,3L,9L,5L,9L,1L,7L,3L,6L,8L,2L,4L,6L,7L,7L,9L,4L,5L,6L,9L,0L,7L,7L,1L,9L,4L,4L,6L,6L,3L,7L,3L,7L,2L,2L,2L,7L,3L,5L,2L,0L,5L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155496Inst : IEnumerable<long>
{
public static readonly long[] Value=A155496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155496.Bytes);
public long this[int i]=>Value[i];

public static A155496Inst Instance=new A155496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155497
{
public static readonly long[] Value={ 1L,1L,1L,1L,18L,1L,1L,90L,90L,1L,1L,280L,1400L,280L,1L,1L,675L,10500L,10500L,675L,1L,1L,1386L,51975L,161700L,51975L,1386L,1L,1L,2548L,196196L,1471470L,1471470L,196196L,2548L,1L,1L,4320L,611520L,9417408L,22702680L,9417408L,611520L,4320L,1L,1L,6885L,1652400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155497Inst : IEnumerable<long>
{
public static readonly long[] Value=A155497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155497.Bytes);
public long this[int i]=>Value[i];

public static A155497Inst Instance=new A155497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155498
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,9L,11L,12L,13L,15L,17L,18L,19L,20L,22L,24L,25L,26L,28L,30L,32L,33L,34L,36L,38L,40L,42L,44L,47L,49L,52L,55L,58L,60L,63L,66L,68L,70L,73L,76L,78L,81L,84L,87L,90L,92L,93L,94L,95L,97L,99L,100L,102L,104L,105L,106L,108L,110L,111L,112L,114L,116L,119L,122L,125L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155498Inst : IEnumerable<long>
{
public static readonly long[] Value=A155498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155498.Bytes);
public long this[int i]=>Value[i];

public static A155498Inst Instance=new A155498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155499
{
public static readonly BigInteger[] Value={ 1L,9L,83L,1027L,15629L,279941L,5764807L,134217735L,3486784409L,100000000009L,3138428376731L,106993205379083L,3937376385699301L,155568095557812237L,6568408355712890639L,BigInteger.Parse("295147905179352825871") };
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
public class A155499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155499Inst Instance=new A155499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155500
{
public static readonly long[] Value={ 41L,44L,49L,56L,65L,76L,89L,104L,121L,140L,161L,164L,169L,176L,184L,185L,196L,209L,224L,236L,241L,260L,265L,281L,296L,304L,329L,356L,361L,364L,369L,376L,385L,396L,401L,409L,416L,424L,440L,441L,449L,460L,481L,484L,504L,521L,524L,529L,556L,560L,569L,585L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155500Inst : IEnumerable<long>
{
public static readonly long[] Value=A155500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155500.Bytes);
public long this[int i]=>Value[i];

public static A155500Inst Instance=new A155500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155501
{
public static readonly long[] Value={ 7L,11L,13L,14L,19L,21L,22L,23L,26L,28L,33L,35L,37L,38L,39L,41L,42L,44L,46L,47L,49L,52L,53L,55L,56L,57L,59L,63L,65L,66L,69L,70L,74L,76L,77L,78L,82L,84L,88L,89L,91L,92L,94L,95L,98L,99L,103L,104L,105L,106L,110L,111L,112L,114L,115L,117L,118L,119L,121L,123L,126L,127L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155501Inst : IEnumerable<long>
{
public static readonly long[] Value=A155501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155501.Bytes);
public long this[int i]=>Value[i];

public static A155501Inst Instance=new A155501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155502
{
public static readonly long[] Value={ 1L,4L,4L,0L,6L,4L,2L,6L,9L,8L,2L,9L,5L,7L,8L,7L,4L,4L,9L,2L,9L,0L,1L,0L,6L,4L,7L,6L,4L,9L,6L,4L,6L,3L,3L,9L,1L,9L,5L,4L,9L,4L,3L,7L,9L,7L,6L,7L,4L,8L,6L,0L,2L,0L,4L,0L,1L,8L,2L,5L,2L,1L,3L,1L,9L,3L,8L,6L,4L,4L,9L,2L,5L,5L,3L,6L,2L,0L,8L,4L,0L,5L,2L,8L,3L,3L,7L,9L,9L,1L,4L,4L,5L,3L,1L,2L,3L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155502Inst : IEnumerable<long>
{
public static readonly long[] Value=A155502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155502.Bytes);
public long this[int i]=>Value[i];

public static A155502Inst Instance=new A155502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155503
{
public static readonly long[] Value={ 1L,3L,6L,3L,4L,1L,6L,5L,1L,3L,9L,3L,0L,4L,2L,1L,0L,2L,0L,6L,9L,8L,0L,4L,7L,3L,1L,8L,1L,8L,2L,0L,8L,1L,0L,5L,2L,4L,5L,3L,5L,5L,1L,8L,2L,3L,4L,6L,4L,9L,0L,5L,2L,7L,2L,3L,9L,7L,1L,0L,0L,1L,4L,1L,2L,3L,6L,4L,3L,1L,3L,3L,9L,4L,7L,6L,4L,2L,7L,7L,1L,6L,8L,8L,8L,9L,6L,9L,2L,4L,5L,4L,2L,9L,2L,1L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155503Inst : IEnumerable<long>
{
public static readonly long[] Value=A155503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155503.Bytes);
public long this[int i]=>Value[i];

public static A155503Inst Instance=new A155503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155504
{
public static readonly long[] Value={ 3L,9L,12L,21L,27L,30L,36L,39L,48L,57L,63L,66L,75L,81L,84L,90L,93L,102L,108L,111L,117L,120L,129L,138L,144L,147L,156L,165L,171L,174L,183L,189L,192L,198L,201L,210L,219L,225L,228L,237L,243L,246L,252L,255L,264L,270L,273L,279L,282L,291L,300L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155504Inst : IEnumerable<long>
{
public static readonly long[] Value=A155504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155504.Bytes);
public long this[int i]=>Value[i];

public static A155504Inst Instance=new A155504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155505
{
public static readonly long[] Value={ 14L,26L,41L,44L,46L,49L,56L,65L,74L,76L,89L,94L,104L,106L,110L,121L,126L,140L,154L,161L,164L,169L,176L,184L,185L,190L,196L,206L,209L,224L,234L,236L,241L,254L,260L,265L,266L,281L,286L,296L,304L,314L,329L,334L,346L,350L,356L,361L,364L,369L,376L,385L,394L,396L,401L,409L,410L,414L,416L,424L,440L,441L,446L,449L,460L,481L,484L,490L,494L,504L,506L,521L,524L,526L,529L,554L,556L,560L,569L,74L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155505Inst : IEnumerable<long>
{
public static readonly long[] Value=A155505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155505.Bytes);
public long this[int i]=>Value[i];

public static A155505Inst Instance=new A155505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155506
{
public static readonly long[] Value={ 2L,4L,8L,14L,22L,32L,42L,54L,68L,82L,98L,116L,134L,154L,176L,200L,224L,250L,278L,306L,336L,368L,400L,434L,470L,508L,546L,586L,628L,670L,714L,760L,808L,856L,906L,958L,1010L,1064L,1120L,1178L,1236L,1296L,1358L,1420L,1484L,1550L,1616L,1684L,1754L,1826L,1898L,1972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155506Inst : IEnumerable<long>
{
public static readonly long[] Value=A155506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155506.Bytes);
public long this[int i]=>Value[i];

public static A155506Inst Instance=new A155506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155507
{
public static readonly long[] Value={ 199L,991L,91199L,99119L,111119L,111919L,119191L,191911L,911111L,919111L,991999L,999199L,1191119L,1191191L,1191991L,1911911L,1991911L,9111911L,11111911L,11191991L,11911111L,11919991L,19111991L,19911191L,19919111L,19991911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155507Inst : IEnumerable<long>
{
public static readonly long[] Value=A155507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155507.Bytes);
public long this[int i]=>Value[i];

public static A155507Inst Instance=new A155507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155508
{
public static readonly long[] Value={ 199L,91199L,111119L,111919L,119191L,991999L,1191119L,1191191L,1191991L,11111911L,11191991L,11919991L,19111991L,91111199L,111111199L,111199199L,191111119L,199991999L,919919999L,1111111999L,1191111991L,1199111191L,1911199999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155508Inst : IEnumerable<long>
{
public static readonly long[] Value=A155508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155508.Bytes);
public long this[int i]=>Value[i];

public static A155508Inst Instance=new A155508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155509
{
public static readonly long[] Value={ 991L,99119L,191911L,911111L,919111L,999199L,1911911L,1991911L,9111911L,11911111L,19911191L,19919111L,19991911L,99111119L,911111191L,991111111L,991991111L,999199991L,999919919L,1911119911L,1919991191L,1991111911L,1991919191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155509Inst : IEnumerable<long>
{
public static readonly long[] Value=A155509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155509.Bytes);
public long this[int i]=>Value[i];

public static A155509Inst Instance=new A155509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155510
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,12L,16L,21L,24L,25L,36L,40L,45L,46L,56L,60L,80L,81L,96L,106L,120L,126L,145L,190L,225L,256L,270L,351L,400L,505L,576L,610L,666L,720L,721L,826L,855L,946L,1071L,1072L,1170L,1225L,1233L,1330L,1338L,1345L,1386L,1450L,1575L,1576L,1792L,1890L,2080L,2241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155510Inst : IEnumerable<long>
{
public static readonly long[] Value=A155510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155510.Bytes);
public long this[int i]=>Value[i];

public static A155510Inst Instance=new A155510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155511
{
public static readonly long[] Value={ 4841L,4843L,4847L,4849L,6401L,6403L,6407L,6409L,14801L,14803L,14807L,14809L,15941L,15943L,15947L,15949L,19091L,19093L,19097L,19099L,19511L,19513L,19517L,19519L,19631L,19633L,19637L,19639L,24581L,24583L,24587L,24589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155511Inst : IEnumerable<long>
{
public static readonly long[] Value=A155511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155511.Bytes);
public long this[int i]=>Value[i];

public static A155511Inst Instance=new A155511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155512
{
public static readonly long[] Value={ 10011101L,10111001L,100100111L,111001001L,1000110101L,1001001011L,1010001101L,1010011111L,1010110001L,1011000101L,1101001001L,1111100101L,10010100101L,10100000011L,10100000111L,10100101001L,10111001011L,11000000101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155512Inst : IEnumerable<long>
{
public static readonly long[] Value=A155512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155512.Bytes);
public long this[int i]=>Value[i];

public static A155512Inst Instance=new A155512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155513
{
public static readonly long[] Value={ 10011101L,100100111L,1000110101L,1001001011L,1010001101L,1010011111L,10010100101L,10100000011L,10100000111L,10111001011L,100000010101L,100000011011L,100101110111L,100101111001L,100110101011L,100110101111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155513Inst : IEnumerable<long>
{
public static readonly long[] Value=A155513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155513.Bytes);
public long this[int i]=>Value[i];

public static A155513Inst Instance=new A155513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155514
{
public static readonly long[] Value={ 10111001L,111001001L,1010110001L,1011000101L,1101001001L,1111100101L,10100101001L,11000000101L,11010011101L,11100000101L,100111101001L,101010000001L,101010111001L,110000000101L,110011010101L,110101011001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155514Inst : IEnumerable<long>
{
public static readonly long[] Value=A155514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155514.Bytes);
public long this[int i]=>Value[i];

public static A155514Inst Instance=new A155514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155515
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,3L,2L,3L,5L,4L,8L,12L,10L,15L,23L,22L,33L,42L,47L,64L,79L,90L,122L,147L,169L,219L,264L,312L,387L,465L,546L,679L,799L,950L,1151L,1365L,1599L,1937L,2270L,2678L,3181L,3735L,4374L,5192L,6046L,7082L,8318L,9684L,11281L,13208L,15313L,17798L,20702L,23951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155515Inst : IEnumerable<long>
{
public static readonly long[] Value=A155515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155515.Bytes);
public long this[int i]=>Value[i];

public static A155515Inst Instance=new A155515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155516
{
public static readonly long[] Value={ 1L,1L,1L,1L,20L,1L,1L,105L,105L,1L,1L,336L,1764L,336L,1L,1L,825L,13860L,13860L,825L,1L,1L,1716L,70785L,226512L,70785L,1716L,1L,1L,3185L,273273L,2147145L,2147145L,273273L,3185L,1L,1L,5440L,866320L,14158144L,34763300L,14158144L,866320L,5440L,1L,1L,8721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155516Inst : IEnumerable<long>
{
public static readonly long[] Value=A155516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155516.Bytes);
public long this[int i]=>Value[i];

public static A155516Inst Instance=new A155516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155517
{
public static readonly long[] Value={ 0L,1L,0L,2L,4L,0L,2L,16L,0L,8L,64L,48L,0L,8L,384L,288L,0L,48L,2880L,1536L,576L,0L,48L,23040L,12288L,4608L,0L,384L,208896L,115200L,30720L,7680L,0L,384L,2088960L,1152000L,307200L,76800L,0L,3840L,23193600L,12533760L,3456000L,614400L,115200L,0L,3840L,278323200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155517Inst : IEnumerable<long>
{
public static readonly long[] Value=A155517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155517.Bytes);
public long this[int i]=>Value[i];

public static A155517Inst Instance=new A155517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155518
{
public static readonly long[] Value={ 1L,0L,0L,4L,16L,64L,384L,2880L,23040L,208896L,2088960L,23193600L,278323200L,3640688640L,50969640960L,768126320640L,12290021130240L,209688566169600L,3774394191052800L,71921062285148160L,1438421245702963200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155518Inst : IEnumerable<long>
{
public static readonly long[] Value=A155518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155518.Bytes);
public long this[int i]=>Value[i];

public static A155518Inst Instance=new A155518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155519
{
public static readonly long[] Value={ 1L,2L,4L,16L,72L,432L,2880L,23040L,201600L,2016000L,21772800L,261273600L,3353011200L,46942156800L,697426329600L,11158821273600L,188305108992000L,3389491961856000L,64023737057280000L,1280474741145600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155519Inst : IEnumerable<long>
{
public static readonly long[] Value=A155519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155519.Bytes);
public long this[int i]=>Value[i];

public static A155519Inst Instance=new A155519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155520
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,6L,1L,1L,5L,2L,6L,9L,1L,4L,4L,4L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155520Inst : IEnumerable<long>
{
public static readonly long[] Value=A155520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155520.Bytes);
public long this[int i]=>Value[i];

public static A155520Inst Instance=new A155520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155521
{
public static readonly ulong[] Value={ 0L,1L,1L,7L,31L,191L,1331L,10655L,95887L,958879L,10547659L,126571919L,1645434935L,23036089103L,345541336531L,5528661384511L,93987243536671L,1691770383660095L,32143637289541787L,642872745790835759L,13500327661607550919UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155521Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A155521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155521.Bytes);
public ulong this[int i]=>Value[i];

public static A155521Inst Instance=new A155521Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155522
{
public static readonly long[] Value={ 1L,3L,0L,1L,0L,2L,9L,9L,9L,5L,6L,6L,3L,9L,8L,1L,1L,9L,5L,2L,1L,3L,7L,3L,8L,8L,9L,4L,7L,2L,4L,4L,9L,3L,0L,2L,6L,7L,6L,8L,1L,8L,9L,8L,8L,1L,4L,6L,2L,1L,0L,8L,5L,4L,1L,3L,1L,0L,4L,2L,7L,4L,6L,1L,1L,2L,7L,1L,0L,8L,1L,8L,9L,2L,7L,4L,4L,2L,4L,5L,0L,9L,4L,8L,6L,9L,2L,7L,2L,5L,2L,1L,1L,8L,1L,8L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155522Inst : IEnumerable<long>
{
public static readonly long[] Value=A155522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155522.Bytes);
public long this[int i]=>Value[i];

public static A155522Inst Instance=new A155522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155523
{
public static readonly long[] Value={ 1L,2L,4L,9L,3L,1L,7L,3L,9L,4L,1L,0L,7L,0L,1L,5L,3L,5L,6L,6L,7L,2L,3L,2L,2L,6L,5L,2L,7L,1L,9L,5L,2L,3L,9L,5L,5L,8L,6L,7L,5L,7L,4L,9L,3L,4L,3L,8L,4L,3L,9L,9L,8L,7L,6L,8L,4L,9L,5L,9L,2L,7L,5L,5L,4L,7L,0L,6L,1L,0L,0L,3L,2L,7L,6L,5L,3L,2L,0L,5L,7L,5L,0L,8L,5L,8L,8L,1L,2L,9L,7L,7L,0L,6L,8L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155523Inst : IEnumerable<long>
{
public static readonly long[] Value=A155523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155523.Bytes);
public long this[int i]=>Value[i];

public static A155523Inst Instance=new A155523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155524
{
public static readonly long[] Value={ 1L,2L,0L,5L,5L,7L,1L,3L,5L,3L,6L,8L,0L,2L,5L,6L,6L,5L,9L,3L,0L,4L,0L,3L,7L,5L,0L,9L,2L,0L,4L,9L,7L,8L,6L,0L,7L,1L,0L,6L,3L,3L,0L,2L,0L,0L,1L,3L,0L,4L,5L,4L,6L,2L,7L,5L,0L,4L,0L,5L,7L,0L,5L,2L,6L,7L,0L,7L,5L,8L,9L,9L,1L,0L,4L,3L,1L,4L,1L,8L,3L,4L,2L,9L,0L,3L,1L,6L,9L,3L,5L,3L,8L,5L,2L,2L,5L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155524Inst : IEnumerable<long>
{
public static readonly long[] Value=A155524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155524.Bytes);
public long this[int i]=>Value[i];

public static A155524Inst Instance=new A155524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155525
{
public static readonly long[] Value={ 1L,1L,6L,7L,9L,4L,9L,8L,7L,1L,9L,2L,9L,9L,4L,2L,8L,3L,4L,2L,1L,6L,5L,8L,5L,6L,9L,9L,7L,2L,5L,2L,0L,3L,0L,0L,6L,8L,8L,3L,6L,5L,4L,5L,2L,9L,6L,4L,6L,9L,0L,6L,1L,7L,5L,1L,2L,3L,1L,5L,0L,5L,6L,0L,2L,1L,3L,9L,8L,7L,8L,5L,5L,7L,8L,4L,0L,5L,9L,6L,3L,0L,9L,2L,4L,2L,3L,8L,2L,3L,0L,9L,3L,9L,6L,2L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155525Inst : IEnumerable<long>
{
public static readonly long[] Value=A155525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155525.Bytes);
public long this[int i]=>Value[i];

public static A155525Inst Instance=new A155525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155526
{
public static readonly long[] Value={ 1L,1L,3L,5L,1L,5L,2L,4L,0L,4L,5L,8L,6L,3L,4L,9L,4L,3L,8L,0L,0L,3L,2L,2L,6L,3L,0L,7L,1L,7L,8L,0L,3L,1L,6L,2L,3L,7L,0L,8L,2L,4L,9L,1L,2L,6L,7L,3L,8L,8L,1L,4L,4L,6L,5L,0L,5L,3L,6L,1L,7L,9L,6L,5L,8L,5L,4L,2L,8L,7L,6L,1L,4L,4L,0L,2L,1L,2L,0L,6L,1L,7L,4L,6L,9L,8L,4L,5L,1L,1L,9L,5L,3L,0L,6L,6L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155526Inst : IEnumerable<long>
{
public static readonly long[] Value=A155526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155526.Bytes);
public long this[int i]=>Value[i];

public static A155526Inst Instance=new A155526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155527
{
public static readonly long[] Value={ 1L,1L,0L,6L,2L,3L,2L,1L,7L,8L,5L,3L,7L,4L,1L,8L,0L,8L,4L,3L,9L,2L,4L,5L,0L,3L,6L,1L,1L,2L,8L,2L,1L,2L,0L,1L,1L,3L,1L,0L,0L,1L,5L,9L,8L,1L,2L,5L,1L,5L,2L,1L,8L,5L,7L,1L,1L,0L,6L,8L,3L,8L,3L,5L,6L,7L,8L,0L,6L,7L,2L,6L,6L,2L,5L,5L,2L,7L,2L,1L,9L,2L,6L,4L,8L,8L,4L,0L,3L,7L,6L,5L,9L,2L,3L,5L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155527Inst : IEnumerable<long>
{
public static readonly long[] Value=A155527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155527.Bytes);
public long this[int i]=>Value[i];

public static A155527Inst Instance=new A155527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155528
{
public static readonly long[] Value={ 1L,0L,8L,0L,4L,8L,2L,0L,2L,3L,7L,2L,1L,8L,4L,0L,5L,8L,6L,9L,6L,7L,5L,7L,9L,8L,5L,7L,3L,7L,2L,3L,4L,7L,5L,4L,3L,9L,6L,6L,2L,0L,7L,8L,4L,8L,2L,5L,6L,1L,4L,5L,1L,5L,3L,0L,1L,3L,6L,8L,9L,0L,9L,8L,9L,5L,3L,9L,8L,3L,6L,9L,4L,1L,5L,2L,1L,5L,6L,3L,0L,3L,9L,6L,2L,5L,3L,4L,9L,3L,5L,8L,3L,9L,8L,4L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155528Inst : IEnumerable<long>
{
public static readonly long[] Value=A155528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155528.Bytes);
public long this[int i]=>Value[i];

public static A155528Inst Instance=new A155528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155529
{
public static readonly long[] Value={ 1L,0L,5L,7L,3L,6L,2L,0L,5L,1L,4L,1L,0L,1L,8L,5L,0L,2L,9L,6L,4L,5L,3L,8L,3L,4L,8L,0L,9L,5L,8L,5L,7L,6L,1L,3L,9L,6L,8L,6L,0L,2L,3L,9L,9L,5L,5L,9L,3L,1L,6L,8L,6L,0L,6L,4L,9L,5L,2L,3L,2L,7L,4L,8L,6L,1L,2L,5L,9L,7L,9L,0L,2L,0L,3L,6L,8L,1L,8L,5L,0L,0L,5L,1L,0L,7L,1L,4L,9L,6L,4L,4L,0L,8L,2L,8L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155529Inst : IEnumerable<long>
{
public static readonly long[] Value=A155529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155529.Bytes);
public long this[int i]=>Value[i];

public static A155529Inst Instance=new A155529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155530
{
public static readonly long[] Value={ 1L,0L,3L,6L,4L,5L,2L,2L,3L,6L,7L,6L,5L,0L,4L,3L,6L,0L,9L,4L,7L,0L,4L,3L,1L,3L,9L,9L,9L,3L,0L,8L,9L,5L,7L,2L,5L,8L,8L,4L,1L,8L,4L,8L,4L,5L,0L,4L,6L,6L,6L,8L,7L,2L,6L,1L,5L,1L,0L,8L,2L,0L,2L,9L,6L,9L,6L,5L,7L,2L,2L,2L,9L,7L,8L,5L,9L,5L,1L,1L,6L,1L,2L,4L,8L,8L,5L,1L,8L,0L,1L,1L,5L,0L,3L,2L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155530Inst : IEnumerable<long>
{
public static readonly long[] Value=A155530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155530.Bytes);
public long this[int i]=>Value[i];

public static A155530Inst Instance=new A155530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155531
{
public static readonly long[] Value={ 1L,0L,1L,7L,4L,2L,0L,3L,9L,6L,4L,6L,6L,1L,7L,8L,9L,2L,2L,5L,0L,9L,3L,7L,5L,4L,9L,0L,9L,5L,2L,3L,5L,1L,1L,6L,1L,8L,7L,9L,2L,5L,0L,8L,0L,5L,8L,4L,8L,6L,8L,9L,1L,5L,2L,4L,7L,3L,6L,8L,3L,2L,1L,7L,8L,4L,2L,3L,2L,2L,9L,9L,9L,0L,8L,2L,0L,7L,8L,8L,2L,5L,1L,1L,9L,9L,4L,4L,3L,9L,3L,3L,3L,8L,6L,4L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155531Inst : IEnumerable<long>
{
public static readonly long[] Value=A155531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155531.Bytes);
public long this[int i]=>Value[i];

public static A155531Inst Instance=new A155531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155532
{
public static readonly long[] Value={ 9L,8L,3L,9L,7L,4L,4L,4L,4L,2L,1L,3L,3L,5L,4L,0L,6L,0L,6L,0L,0L,2L,0L,7L,1L,9L,7L,2L,6L,0L,9L,0L,1L,9L,0L,5L,3L,2L,1L,0L,9L,6L,3L,1L,3L,8L,1L,9L,3L,4L,6L,9L,7L,8L,7L,9L,3L,3L,2L,5L,5L,7L,4L,5L,0L,1L,6L,5L,5L,6L,5L,3L,6L,1L,5L,8L,3L,2L,0L,6L,0L,8L,5L,2L,7L,4L,9L,3L,6L,1L,9L,5L,4L,8L,3L,2L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155532Inst : IEnumerable<long>
{
public static readonly long[] Value=A155532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155532.Bytes);
public long this[int i]=>Value[i];

public static A155532Inst Instance=new A155532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155533
{
public static readonly long[] Value={ 9L,6L,9L,1L,6L,5L,6L,8L,3L,9L,9L,0L,9L,2L,2L,3L,8L,6L,7L,9L,5L,6L,0L,0L,2L,9L,0L,7L,6L,6L,2L,6L,2L,8L,7L,7L,8L,1L,9L,5L,3L,7L,4L,5L,0L,1L,6L,4L,2L,8L,8L,7L,9L,7L,6L,4L,8L,3L,2L,1L,8L,1L,2L,8L,7L,0L,2L,9L,1L,9L,8L,2L,0L,9L,0L,8L,6L,8L,8L,9L,4L,9L,8L,3L,3L,9L,2L,9L,2L,6L,0L,4L,8L,5L,6L,9L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155533Inst : IEnumerable<long>
{
public static readonly long[] Value=A155533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155533.Bytes);
public long this[int i]=>Value[i];

public static A155533Inst Instance=new A155533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155534
{
public static readonly long[] Value={ 9L,5L,5L,4L,2L,5L,8L,6L,5L,0L,3L,1L,0L,5L,9L,3L,3L,6L,9L,5L,7L,7L,7L,5L,3L,8L,8L,7L,3L,1L,8L,5L,4L,1L,5L,1L,9L,9L,9L,9L,2L,1L,2L,6L,3L,7L,6L,8L,4L,8L,0L,7L,2L,9L,2L,7L,7L,7L,9L,4L,8L,7L,1L,7L,7L,4L,1L,8L,9L,4L,6L,6L,3L,0L,2L,0L,6L,2L,8L,7L,1L,7L,3L,6L,2L,9L,0L,0L,0L,4L,3L,6L,5L,3L,9L,8L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155534Inst : IEnumerable<long>
{
public static readonly long[] Value=A155534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155534.Bytes);
public long this[int i]=>Value[i];

public static A155534Inst Instance=new A155534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155535
{
public static readonly long[] Value={ 9L,4L,2L,6L,3L,1L,0L,6L,7L,1L,4L,7L,7L,8L,5L,4L,2L,3L,9L,7L,3L,7L,7L,5L,0L,3L,2L,0L,9L,4L,3L,6L,4L,4L,0L,5L,2L,4L,6L,3L,4L,3L,3L,2L,7L,2L,7L,7L,1L,4L,8L,8L,2L,1L,5L,3L,8L,5L,0L,8L,3L,4L,1L,6L,4L,9L,2L,5L,9L,9L,3L,3L,4L,9L,0L,0L,0L,4L,0L,0L,8L,4L,5L,5L,2L,2L,9L,0L,8L,2L,1L,1L,4L,6L,8L,5L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155535Inst : IEnumerable<long>
{
public static readonly long[] Value=A155535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155535.Bytes);
public long this[int i]=>Value[i];

public static A155535Inst Instance=new A155535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155536
{
public static readonly long[] Value={ 4L,3L,9L,2L,3L,1L,7L,4L,2L,2L,7L,7L,8L,7L,6L,0L,2L,8L,8L,8L,9L,5L,7L,0L,8L,2L,6L,1L,1L,7L,9L,6L,4L,7L,3L,1L,7L,4L,0L,0L,8L,4L,1L,0L,3L,3L,6L,5L,8L,6L,2L,1L,8L,4L,4L,1L,3L,3L,0L,4L,4L,3L,7L,8L,6L,1L,1L,4L,1L,9L,0L,7L,6L,6L,5L,6L,5L,5L,1L,5L,4L,9L,0L,2L,0L,1L,4L,1L,4L,7L,4L,0L,8L,8L,2L,9L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155536Inst : IEnumerable<long>
{
public static readonly long[] Value=A155536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155536.Bytes);
public long this[int i]=>Value[i];

public static A155536Inst Instance=new A155536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155537
{
public static readonly long[] Value={ 3L,5L,5L,9L,27L,9L,17L,102L,102L,17L,33L,330L,660L,330L,33L,65L,975L,3250L,3250L,975L,65L,129L,2709L,13545L,22575L,13545L,2709L,129L,257L,7196L,50372L,125930L,125930L,50372L,7196L,257L,513L,18468L,172368L,603288L,904932L,603288L,172368L,18468L,513L,1025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155537Inst : IEnumerable<long>
{
public static readonly long[] Value=A155537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155537.Bytes);
public long this[int i]=>Value[i];

public static A155537Inst Instance=new A155537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155538
{
public static readonly BigInteger[] Value={ BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639936"),BigInteger.Parse("340282366920938463463374607431768211456"),BigInteger.Parse("18446744073709551616"),4294967296L,65536L,256L,16L,4L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A155538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155538Inst Instance=new A155538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155539
{
public static readonly BigInteger[] Value={ 1L,5L,57L,945L,18785L,423393L,10609137L,292475249L,8804293473L,287589316833L,10137858491849L,383799398752905L,15536767912476993L,669920208810550337L,BigInteger.Parse("30659724555890596833"),BigInteger.Parse("1484638520651877849057"),BigInteger.Parse("75846305139481944586817") };
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
public class A155539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155539Inst Instance=new A155539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155540
{
public static readonly long[] Value={ 3L,6L,5L,2L,4L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155540Inst : IEnumerable<long>
{
public static readonly long[] Value=A155540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155540.Bytes);
public long this[int i]=>Value[i];

public static A155540Inst Instance=new A155540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155541
{
public static readonly long[] Value={ 2L,7L,7L,1L,2L,4L,3L,7L,4L,9L,1L,6L,1L,4L,2L,2L,2L,6L,0L,0L,6L,7L,9L,2L,8L,3L,0L,7L,0L,8L,2L,4L,5L,7L,7L,1L,8L,0L,6L,6L,4L,7L,1L,3L,3L,4L,5L,9L,4L,2L,4L,3L,4L,7L,9L,3L,6L,8L,9L,9L,2L,5L,7L,7L,2L,7L,9L,8L,8L,6L,1L,9L,8L,7L,0L,2L,8L,1L,2L,2L,1L,0L,8L,3L,4L,3L,0L,0L,9L,8L,9L,3L,3L,7L,5L,0L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155541Inst : IEnumerable<long>
{
public static readonly long[] Value=A155541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155541.Bytes);
public long this[int i]=>Value[i];

public static A155541Inst Instance=new A155541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155542
{
public static readonly BigInteger[] Value={ 2L,18L,194L,2002L,20866L,216978L,2257474L,23484242L,244310786L,2541592338L,26440508354L,275063875282L,2861523711106L,29768786570898L,309688385344834L,3221726747031122L,33516023609869826L,348671357554736658L,3627271450684638914L,BigInteger.Parse("37734955544345527762") };
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
public class A155542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155542.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155542Inst Instance=new A155542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155543
{
public static readonly long[] Value={ 2L,4L,16L,64L,256L,1024L,4096L,16384L,65536L,262144L,1048576L,4194304L,16777216L,67108864L,268435456L,1073741824L,4294967296L,17179869184L,68719476736L,274877906944L,1099511627776L,4398046511104L,17592186044416L,70368744177664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155543Inst : IEnumerable<long>
{
public static readonly long[] Value=A155543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155543.Bytes);
public long this[int i]=>Value[i];

public static A155543Inst Instance=new A155543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155544
{
public static readonly long[] Value={ 187L,190L,193L,194L,240L,275L,280L,303L,318L,331L,345L,404L,430L,466L,468L,470L,471L,476L,481L,494L,521L,532L,566L,603L,604L,669L,706L,733L,859L,917L,935L,946L,962L,979L,981L,984L,995L,1020L,1107L,1117L,1140L,1224L,1227L,1230L,1231L,1242L,1245L,1246L,1251L,1253L,1268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155544Inst : IEnumerable<long>
{
public static readonly long[] Value=A155544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155544.Bytes);
public long this[int i]=>Value[i];

public static A155544Inst Instance=new A155544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155545
{
public static readonly long[] Value={ 2L,1L,9L,6L,1L,5L,8L,7L,1L,1L,3L,8L,9L,3L,8L,0L,1L,4L,4L,4L,4L,7L,8L,5L,4L,1L,3L,0L,5L,8L,9L,8L,2L,3L,6L,5L,8L,7L,0L,0L,4L,2L,0L,5L,1L,6L,8L,2L,9L,3L,1L,0L,9L,2L,2L,0L,6L,6L,5L,2L,2L,1L,8L,9L,3L,0L,5L,7L,0L,9L,5L,3L,8L,3L,2L,8L,2L,7L,5L,7L,7L,4L,5L,1L,0L,0L,7L,0L,7L,3L,7L,0L,4L,4L,1L,4L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155545Inst : IEnumerable<long>
{
public static readonly long[] Value=A155545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155545.Bytes);
public long this[int i]=>Value[i];

public static A155545Inst Instance=new A155545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155546
{
public static readonly long[] Value={ -1L,2L,7L,5L,12L,19L,8L,17L,26L,35L,11L,22L,33L,44L,55L,14L,27L,40L,53L,66L,79L,17L,32L,47L,62L,77L,92L,107L,20L,37L,54L,71L,88L,105L,122L,139L,23L,42L,61L,80L,99L,118L,137L,156L,175L,26L,47L,68L,89L,110L,131L,152L,173L,194L,215L,29L,52L,75L,98L,121L,144L,167L,190L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155546Inst : IEnumerable<long>
{
public static readonly long[] Value=A155546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155546.Bytes);
public long this[int i]=>Value[i];

public static A155546Inst Instance=new A155546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155547
{
public static readonly long[] Value={ 2L,7L,13L,19L,23L,29L,31L,43L,53L,61L,67L,173L,179L,193L,199L,223L,227L,281L,283L,311L,317L,337L,347L,409L,419L,433L,443L,457L,461L,463L,467L,491L,503L,521L,523L,541L,547L,569L,577L,593L,599L,601L,607L,619L,641L,647L,653L,809L,811L,827L,839L,857L,859L,941L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155547Inst : IEnumerable<long>
{
public static readonly long[] Value=A155547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155547.Bytes);
public long this[int i]=>Value[i];

public static A155547Inst Instance=new A155547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155548
{
public static readonly long[] Value={ 2L,3L,7L,17L,37L,47L,73L,83L,89L,97L,113L,163L,179L,193L,197L,251L,347L,359L,383L,397L,421L,431L,443L,487L,541L,547L,571L,593L,607L,617L,631L,653L,673L,677L,719L,727L,743L,751L,761L,787L,821L,829L,857L,877L,881L,883L,947L,971L,1009L,1013L,1019L,1021L,1051L,1087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155548Inst : IEnumerable<long>
{
public static readonly long[] Value=A155548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155548.Bytes);
public long this[int i]=>Value[i];

public static A155548Inst Instance=new A155548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155549
{
public static readonly long[] Value={ 16L,26L,49L,77L,91L,121L,169L,205L,209L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155549Inst : IEnumerable<long>
{
public static readonly long[] Value=A155549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155549.Bytes);
public long this[int i]=>Value[i];

public static A155549Inst Instance=new A155549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155550
{
public static readonly long[] Value={ -2L,1L,6L,4L,11L,18L,7L,16L,25L,34L,10L,21L,32L,43L,54L,13L,26L,39L,52L,65L,78L,16L,31L,46L,61L,76L,91L,106L,19L,36L,53L,70L,87L,104L,121L,138L,22L,41L,60L,79L,98L,117L,136L,155L,174L,25L,46L,67L,88L,109L,130L,151L,172L,193L,214L,28L,51L,74L,97L,120L,143L,166L,189L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155550Inst : IEnumerable<long>
{
public static readonly long[] Value=A155550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155550.Bytes);
public long this[int i]=>Value[i];

public static A155550Inst Instance=new A155550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155551
{
public static readonly long[] Value={ -5L,-2L,3L,1L,8L,15L,4L,13L,22L,31L,7L,18L,29L,40L,51L,10L,23L,36L,49L,62L,75L,13L,28L,43L,58L,73L,88L,103L,16L,33L,50L,67L,84L,101L,118L,135L,19L,38L,57L,76L,95L,114L,133L,152L,171L,22L,43L,64L,85L,106L,127L,148L,169L,190L,211L,25L,48L,71L,94L,117L,140L,163L,186L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155551Inst : IEnumerable<long>
{
public static readonly long[] Value=A155551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155551.Bytes);
public long this[int i]=>Value[i];

public static A155551Inst Instance=new A155551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155552
{
public static readonly long[] Value={ 5L,13L,23L,29L,43L,53L,79L,127L,157L,167L,173L,223L,227L,229L,233L,239L,257L,263L,271L,277L,283L,293L,313L,317L,337L,353L,373L,379L,433L,523L,557L,563L,577L,647L,757L,773L,797L,839L,853L,859L,863L,887L,977L,1103L,1117L,1123L,1153L,1171L,1187L,1193L,1217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155552Inst : IEnumerable<long>
{
public static readonly long[] Value=A155552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155552.Bytes);
public long this[int i]=>Value[i];

public static A155552Inst Instance=new A155552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155553
{
public static readonly long[] Value={ 1L,8L,9L,1L,6L,6L,8L,1L,4L,9L,6L,0L,8L,1L,5L,2L,8L,5L,1L,8L,9L,7L,8L,8L,2L,7L,0L,4L,8L,1L,8L,4L,1L,2L,3L,2L,4L,1L,4L,1L,2L,2L,5L,3L,2L,9L,5L,8L,4L,0L,0L,0L,3L,3L,8L,3L,6L,6L,2L,9L,2L,8L,9L,2L,3L,4L,6L,6L,2L,4L,3L,6L,3L,9L,2L,4L,4L,1L,3L,2L,6L,3L,9L,3L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155553Inst : IEnumerable<long>
{
public static readonly long[] Value=A155553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155553.Bytes);
public long this[int i]=>Value[i];

public static A155553Inst Instance=new A155553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155554
{
public static readonly long[] Value={ 1L,6L,9L,9L,1L,8L,0L,3L,2L,5L,2L,6L,7L,1L,5L,0L,2L,5L,6L,1L,1L,5L,7L,9L,5L,9L,1L,2L,4L,6L,0L,0L,0L,0L,4L,5L,6L,4L,5L,3L,6L,3L,9L,0L,9L,5L,7L,4L,4L,0L,8L,9L,5L,6L,6L,4L,9L,7L,6L,0L,7L,5L,3L,1L,4L,4L,9L,9L,5L,2L,6L,2L,7L,3L,3L,1L,4L,2L,2L,8L,4L,7L,1L,5L,8L,6L,8L,9L,3L,6L,0L,8L,9L,4L,3L,2L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155554Inst : IEnumerable<long>
{
public static readonly long[] Value=A155554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155554.Bytes);
public long this[int i]=>Value[i];

public static A155554Inst Instance=new A155554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155555
{
public static readonly long[] Value={ 11L,19L,31L,41L,59L,61L,67L,71L,101L,103L,107L,109L,131L,137L,139L,149L,151L,181L,191L,199L,211L,241L,269L,281L,307L,311L,331L,349L,367L,389L,401L,409L,419L,439L,449L,457L,461L,463L,467L,479L,491L,499L,503L,509L,521L,569L,587L,599L,601L,613L,619L,641L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155555Inst : IEnumerable<long>
{
public static readonly long[] Value=A155555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155555.Bytes);
public long this[int i]=>Value[i];

public static A155555Inst Instance=new A155555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155556
{
public static readonly long[] Value={ 1L,1L,4L,44L,1144L,1056L,65208L,53152L,7824960L,5450016L,4677376L,1932765120L,1119751776L,786197984L,970248090240L,457228062720L,253156757568L,204411475840L,982861315413120L,369853933363200L,156721804462080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155556Inst : IEnumerable<long>
{
public static readonly long[] Value=A155556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155556.Bytes);
public long this[int i]=>Value[i];

public static A155556Inst Instance=new A155556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155557
{
public static readonly long[] Value={ 53089L,53093L,53101L,53113L,53129L,53149L,53173L,53201L,53233L,53269L,53309L,53353L,53401L,53453L,53509L,53569L,53633L,53701L,53773L,53849L,53929L,54013L,54101L,54193L,54289L,54389L,54493L,54601L,54713L,54829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155557Inst : IEnumerable<long>
{
public static readonly long[] Value=A155557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155557.Bytes);
public long this[int i]=>Value[i];

public static A155557Inst Instance=new A155557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155558
{
public static readonly BigInteger[] Value={ 1L,1L,6L,138L,10488L,8280L,2485656L,1392696L,1794643632L,663449904L,448448112L,3910528474128L,904634615952L,375908525712L,25621782562486656L,3570752184568704L,852504801992064L,514242863174016L,BigInteger.Parse("504057328351799983488") };
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
public class A155558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155558Inst Instance=new A155558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155559
{
public static readonly long[] Value={ 0L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,134217728L,268435456L,536870912L,1073741824L,2147483648L,4294967296L,8589934592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155559Inst : IEnumerable<long>
{
public static readonly long[] Value=A155559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155559.Bytes);
public long this[int i]=>Value[i];

public static A155559Inst Instance=new A155559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155560
{
public static readonly long[] Value={ 13L,37L,52L,61L,73L,97L,100L,109L,117L,148L,157L,169L,181L,193L,208L,229L,241L,244L,277L,292L,313L,325L,333L,337L,349L,373L,388L,397L,400L,409L,421L,433L,436L,457L,468L,481L,541L,549L,577L,592L,601L,613L,628L,637L,657L,661L,673L,676L,709L,724L,733L,757L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155560Inst : IEnumerable<long>
{
public static readonly long[] Value=A155560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155560.Bytes);
public long this[int i]=>Value[i];

public static A155560Inst Instance=new A155560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155561
{
public static readonly long[] Value={ 17L,18L,34L,41L,68L,72L,73L,82L,89L,97L,113L,136L,137L,146L,153L,162L,164L,178L,193L,194L,225L,226L,233L,241L,242L,257L,272L,274L,281L,288L,289L,292L,306L,313L,328L,337L,353L,356L,369L,386L,388L,401L,409L,425L,433L,449L,450L,452L,457L,466L,482L,514L,521L,544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155561Inst : IEnumerable<long>
{
public static readonly long[] Value=A155561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155561.Bytes);
public long this[int i]=>Value[i];

public static A155561Inst Instance=new A155561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155562
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,9L,16L,17L,18L,25L,32L,34L,36L,41L,49L,50L,64L,68L,72L,73L,81L,82L,89L,97L,98L,100L,113L,121L,128L,136L,137L,144L,146L,153L,162L,164L,169L,178L,193L,194L,196L,200L,225L,226L,233L,241L,242L,256L,257L,272L,274L,281L,288L,289L,292L,306L,313L,324L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155562Inst : IEnumerable<long>
{
public static readonly long[] Value=A155562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155562.Bytes);
public long this[int i]=>Value[i];

public static A155562Inst Instance=new A155562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155563
{
public static readonly long[] Value={ 0L,1L,4L,9L,13L,16L,25L,36L,37L,49L,52L,61L,64L,73L,81L,97L,100L,109L,117L,121L,144L,148L,157L,169L,181L,193L,196L,208L,225L,229L,241L,244L,256L,277L,289L,292L,313L,324L,325L,333L,337L,349L,361L,373L,388L,397L,400L,409L,421L,433L,436L,441L,457L,468L,481L,484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155563Inst : IEnumerable<long>
{
public static readonly long[] Value=A155563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155563.Bytes);
public long this[int i]=>Value[i];

public static A155563Inst Instance=new A155563Inst();

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