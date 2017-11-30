using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190439
{
public static readonly long[] Value={ 1L,3L,6L,11L,14L,16L,19L,22L,24L,27L,32L,35L,37L,40L,45L,48L,50L,53L,56L,58L,61L,66L,69L,71L,74L,77L,79L,82L,84L,87L,90L,92L,95L,100L,103L,105L,108L,111L,113L,116L,121L,124L,126L,129L,134L,137L,139L,142L,145L,147L,150L,155L,158L,160L,163L,166L,168L,171L,173L,176L,179L,181L,184L,189L,192L,194L,197L,200L,202L,205L,210L,213L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190439Inst : IEnumerable<long>
{
public static readonly long[] Value=A190439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190439.Bytes);
public long this[int i]=>Value[i];

public static A190439Inst Instance=new A190439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190440
{
public static readonly long[] Value={ 2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190440Inst : IEnumerable<long>
{
public static readonly long[] Value=A190440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190440.Bytes);
public long this[int i]=>Value[i];

public static A190440Inst Instance=new A190440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190441
{
public static readonly long[] Value={ 0L,1L,4L,55L,376L,3649L,29260L,259351L,2178544L,18828865L,160278676L,1375440439L,11752630120L,100652697601L,860963365084L,7369308666775L,63054805905376L,539622261625729L,4617626476812580L,39515774110653751L,338150529038305624L,2893717306468718785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190441Inst : IEnumerable<long>
{
public static readonly long[] Value=A190441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190441.Bytes);
public long this[int i]=>Value[i];

public static A190441Inst Instance=new A190441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190442
{
public static readonly long[] Value={ 4L,7L,12L,15L,20L,25L,28L,33L,38L,41L,46L,49L,54L,59L,62L,67L,70L,72L,75L,80L,83L,88L,93L,96L,101L,104L,109L,114L,117L,122L,125L,127L,130L,135L,138L,143L,148L,151L,156L,159L,164L,169L,172L,177L,182L,185L,190L,193L,198L,203L,206L,211L,214L,216L,219L,224L,227L,232L,237L,240L,245L,248L,253L,258L,261L,266L,269L,271L,274L,279L,282L,287L,292L,295L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190442Inst : IEnumerable<long>
{
public static readonly long[] Value=A190442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190442.Bytes);
public long this[int i]=>Value[i];

public static A190442Inst Instance=new A190442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190443
{
public static readonly long[] Value={ 1L,6L,9L,14L,17L,19L,22L,27L,30L,35L,40L,43L,48L,51L,56L,61L,64L,69L,74L,77L,82L,85L,90L,95L,98L,103L,106L,108L,111L,116L,119L,124L,129L,132L,137L,140L,145L,150L,153L,158L,161L,163L,166L,171L,174L,179L,184L,187L,192L,195L,200L,205L,208L,213L,218L,221L,226L,229L,234L,239L,242L,247L,250L,252L,255L,260L,263L,268L,273L,276L,281L,284L,289L,294L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190443Inst : IEnumerable<long>
{
public static readonly long[] Value=A190443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190443.Bytes);
public long this[int i]=>Value[i];

public static A190443Inst Instance=new A190443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190508
{
public static readonly long[] Value={ 8L,18L,26L,36L,47L,55L,65L,73L,84L,94L,102L,112L,123L,131L,141L,149L,160L,170L,178L,188L,196L,207L,217L,225L,235L,246L,254L,264L,272L,283L,293L,301L,311L,322L,330L,340L,348L,358L,369L,377L,387L,395L,406L,416L,424L,434L,445L,453L,463L,471L,482L,492L,500L,510L,518L,529L,539L,547L,557L,568L,576L,586L,594L,605L,615L,623L,633L,644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190508Inst : IEnumerable<long>
{
public static readonly long[] Value=A190508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190508.Bytes);
public long this[int i]=>Value[i];

public static A190508Inst Instance=new A190508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190509
{
public static readonly long[] Value={ 4L,11L,15L,22L,29L,33L,40L,44L,51L,58L,62L,69L,76L,80L,87L,91L,98L,105L,109L,116L,120L,127L,134L,138L,145L,152L,156L,163L,167L,174L,181L,185L,192L,199L,203L,210L,214L,221L,228L,232L,239L,243L,250L,257L,261L,268L,275L,279L,286L,290L,297L,304L,308L,315L,319L,326L,333L,337L,344L,351L,355L,362L,366L,373L,380L,384L,391L,398L,402L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190509Inst : IEnumerable<long>
{
public static readonly long[] Value=A190509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190509.Bytes);
public long this[int i]=>Value[i];

public static A190509Inst Instance=new A190509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190510
{
public static readonly long[] Value={ 0L,1L,8L,68L,576L,4880L,41344L,350272L,2967552L,25141504L,213002240L,1804583936L,15288680448L,129527779328L,1097376956416L,9297126768640L,78766521974784L,667320682872832L,5653631550881792L,47898335138545664L,405801207311892480L,3438002999049322496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190510Inst : IEnumerable<long>
{
public static readonly long[] Value=A190510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190510.Bytes);
public long this[int i]=>Value[i];

public static A190510Inst Instance=new A190510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190511
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,12L,14L,16L,19L,21L,23L,25L,28L,30L,32L,34L,37L,39L,41L,43L,45L,48L,50L,52L,54L,57L,59L,61L,63L,66L,68L,70L,72L,75L,77L,79L,81L,83L,86L,88L,90L,92L,95L,97L,99L,101L,104L,106L,108L,110L,113L,115L,117L,119L,121L,124L,126L,128L,130L,133L,135L,137L,139L,142L,144L,146L,148L,151L,153L,155L,157L,159L,162L,164L,166L,168L,171L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190511Inst : IEnumerable<long>
{
public static readonly long[] Value=A190511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190511.Bytes);
public long this[int i]=>Value[i];

public static A190511Inst Instance=new A190511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190512
{
public static readonly long[] Value={ 1L,2L,5L,11L,24L,53L,117L,258L,569L,1255L,2768L,6105L,13465L,29698L,65501L,144467L,318632L,702765L,1549997L,3418626L,7540017L,16630031L,36678688L,80897393L,178424817L,393528322L,867954037L,1914332891L,4222194104L,9312342245L,20539017381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190512Inst : IEnumerable<long>
{
public static readonly long[] Value=A190512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190512.Bytes);
public long this[int i]=>Value[i];

public static A190512Inst Instance=new A190512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190513
{
public static readonly long[] Value={ 9L,19L,31L,41L,52L,64L,74L,85L,97L,107L,118L,129L,140L,151L,162L,173L,184L,195L,205L,216L,227L,239L,249L,261L,271L,282L,294L,304L,313L,327L,337L,348L,359L,370L,381L,392L,402L,412L,425L,436L,447L,457L,469L,480L,490L,501L,513L,523L,534L,545L,557L,567L,578L,589L,599L,612L,621L,631L,644L,655L,665L,677L,687L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190513Inst : IEnumerable<long>
{
public static readonly long[] Value=A190513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190513.Bytes);
public long this[int i]=>Value[i];

public static A190513Inst Instance=new A190513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190514
{
public static readonly long[] Value={ 5L,14L,22L,29L,37L,46L,53L,61L,69L,78L,84L,93L,101L,109L,116L,125L,132L,141L,149L,157L,165L,172L,181L,188L,197L,204L,212L,220L,229L,236L,244L,252L,260L,267L,276L,285L,291L,300L,309L,317L,323L,332L,340L,347L,355L,364L,371L,379L,388L,396L,403L,411L,419L,427L,435L,443L,451L,459L,467L,475L,483L,491L,499L,506L,515L,522L,530L,538L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190514Inst : IEnumerable<long>
{
public static readonly long[] Value=A190514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190514.Bytes);
public long this[int i]=>Value[i];

public static A190514Inst Instance=new A190514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190515
{
public static readonly long[] Value={ 6L,15L,25L,33L,42L,51L,59L,68L,79L,87L,94L,104L,113L,121L,131L,139L,147L,158L,166L,175L,183L,192L,201L,210L,219L,228L,237L,246L,254L,264L,272L,280L,290L,298L,307L,318L,325L,333L,343L,352L,361L,369L,378L,387L,397L,406L,415L,422L,431L,441L,449L,458L,468L,476L,485L,495L,502L,510L,520L,529L,537L,548L,556L,564L,574L,583L,590L,600L,608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190515Inst : IEnumerable<long>
{
public static readonly long[] Value=A190515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190515.Bytes);
public long this[int i]=>Value[i];

public static A190515Inst Instance=new A190515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190516
{
public static readonly long[] Value={ 1L,4L,10L,12L,17L,20L,24L,27L,32L,36L,38L,43L,47L,50L,55L,57L,62L,66L,70L,73L,76L,80L,83L,89L,92L,96L,99L,103L,108L,111L,115L,119L,122L,126L,130L,135L,136L,142L,145L,150L,153L,155L,160L,163L,168L,171L,177L,178L,182L,187L,191L,194L,198L,202L,206L,209L,214L,217L,221L,224L,230L,233L,234L,240L,243L,247L,251L,256L,258L,262L,266L,270L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190516Inst : IEnumerable<long>
{
public static readonly long[] Value=A190516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190516.Bytes);
public long this[int i]=>Value[i];

public static A190516Inst Instance=new A190516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190517
{
public static readonly long[] Value={ 3L,8L,13L,18L,23L,28L,34L,39L,45L,49L,56L,60L,65L,71L,75L,81L,86L,91L,98L,102L,106L,112L,117L,123L,127L,133L,138L,144L,148L,154L,159L,164L,169L,174L,179L,186L,190L,196L,200L,207L,211L,215L,222L,225L,232L,238L,242L,248L,253L,257L,263L,268L,274L,279L,284L,289L,295L,299L,305L,310L,314L,321L,326L,331L,336L,341L,346L,351L,356L,362L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190517Inst : IEnumerable<long>
{
public static readonly long[] Value=A190517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190517.Bytes);
public long this[int i]=>Value[i];

public static A190517Inst Instance=new A190517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190518
{
public static readonly long[] Value={ 2L,7L,11L,16L,21L,26L,30L,35L,40L,44L,48L,54L,58L,63L,67L,72L,77L,82L,88L,90L,95L,100L,105L,110L,114L,120L,124L,128L,134L,137L,143L,146L,152L,156L,161L,167L,170L,176L,180L,185L,189L,193L,199L,203L,208L,213L,218L,223L,226L,231L,235L,241L,245L,250L,255L,259L,265L,269L,273L,278L,283L,287L,292L,297L,302L,306L,311L,316L,320L,324L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190518Inst : IEnumerable<long>
{
public static readonly long[] Value=A190518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190518.Bytes);
public long this[int i]=>Value[i];

public static A190518Inst Instance=new A190518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190519
{
public static readonly long[] Value={ 8L,16L,26L,35L,45L,54L,63L,72L,82L,93L,101L,110L,121L,129L,139L,148L,157L,167L,177L,186L,195L,205L,214L,223L,233L,242L,251L,261L,270L,281L,290L,298L,308L,318L,327L,336L,345L,355L,365L,374L,384L,392L,402L,412L,421L,429L,440L,450L,458L,469L,478L,486L,497L,505L,514L,525L,534L,543L,553L,563L,571L,581L,590L,599L,610L,618L,627L,639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190519Inst : IEnumerable<long>
{
public static readonly long[] Value=A190519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190519.Bytes);
public long this[int i]=>Value[i];

public static A190519Inst Instance=new A190519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190520
{
public static readonly long[] Value={ 27L,55L,85L,113L,143L,171L,200L,229L,258L,287L,316L,344L,375L,403L,433L,461L,490L,519L,547L,578L,606L,635L,664L,693L,721L,751L,779L,809L,837L,867L,895L,924L,953L,982L,1011L,1039L,1068L,1097L,1128L,1157L,1186L,1214L,1244L,1272L,1302L,1330L,1359L,1388L,1417L,1445L,1474L,1503L,1533L,1561L,1590L,1619L,1647L,1677L,1706L,1736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190520Inst : IEnumerable<long>
{
public static readonly long[] Value=A190520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190520.Bytes);
public long this[int i]=>Value[i];

public static A190520Inst Instance=new A190520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190521
{
public static readonly long[] Value={ 2L,4L,7L,10L,12L,15L,18L,20L,23L,28L,30L,33L,36L,38L,41L,43L,46L,49L,52L,57L,60L,62L,65L,68L,70L,73L,76L,78L,81L,86L,88L,90L,94L,96L,98L,102L,104L,107L,112L,115L,118L,120L,123L,126L,128L,131L,134L,137L,140L,144L,146L,149L,152L,154L,156L,160L,163L,165L,170L,173L,175L,179L,181L,183L,187L,189L,192L,196L,198L,201L,204L,207L,209L,212L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190521Inst : IEnumerable<long>
{
public static readonly long[] Value=A190521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190521.Bytes);
public long this[int i]=>Value[i];

public static A190521Inst Instance=new A190521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190522
{
public static readonly long[] Value={ 6L,14L,22L,32L,40L,48L,58L,66L,74L,83L,91L,99L,109L,117L,125L,133L,142L,151L,159L,168L,176L,184L,193L,202L,210L,220L,228L,236L,244L,253L,262L,269L,278L,286L,295L,304L,312L,321L,331L,339L,348L,354L,363L,371L,380L,389L,397L,406L,415L,423L,431L,442L,449L,457L,465L,474L,482L,491L,500L,508L,516L,526L,533L,541L,552L,560L,568L,577L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190522Inst : IEnumerable<long>
{
public static readonly long[] Value=A190522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190522.Bytes);
public long this[int i]=>Value[i];

public static A190522Inst Instance=new A190522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190523
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,13L,17L,19L,21L,25L,29L,31L,34L,37L,39L,42L,44L,47L,50L,53L,56L,59L,61L,64L,67L,69L,71L,75L,77L,80L,84L,87L,89L,92L,95L,97L,100L,103L,105L,108L,111L,114L,116L,119L,122L,124L,127L,130L,132L,136L,138L,141L,145L,147L,150L,153L,155L,158L,161L,164L,166L,169L,172L,174L,178L,180L,182L,185L,188L,191L,194L,197L,199L,203L,206L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190523Inst : IEnumerable<long>
{
public static readonly long[] Value=A190523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190523.Bytes);
public long this[int i]=>Value[i];

public static A190523Inst Instance=new A190523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190764
{
public static readonly long[] Value={ 2L,5L,6L,9L,12L,13L,15L,16L,19L,22L,23L,26L,29L,30L,32L,33L,36L,37L,39L,40L,43L,46L,47L,50L,53L,54L,56L,57L,60L,63L,64L,67L,70L,71L,73L,74L,77L,78L,80L,81L,84L,87L,88L,90L,91L,94L,95L,97L,98L,101L,104L,105L,108L,111L,112L,114L,115L,118L,121L,122L,125L,128L,129L,131L,132L,135L,136L,138L,139L,142L,145L,146L,149L,152L,153L,155L,156L,159L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190764Inst : IEnumerable<long>
{
public static readonly long[] Value=A190764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190764.Bytes);
public long this[int i]=>Value[i];

public static A190764Inst Instance=new A190764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190765
{
public static readonly long[] Value={ 1L,4L,7L,8L,11L,14L,18L,21L,24L,25L,28L,31L,35L,38L,41L,42L,45L,48L,49L,52L,55L,59L,62L,65L,66L,69L,72L,76L,79L,82L,83L,86L,89L,93L,96L,100L,103L,106L,107L,110L,113L,117L,120L,123L,124L,127L,130L,134L,137L,140L,141L,144L,147L,148L,151L,154L,158L,161L,164L,165L,168L,171L,175L,178L,181L,182L,185L,188L,192L,195L,199L,202L,205L,206L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190765Inst : IEnumerable<long>
{
public static readonly long[] Value=A190765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190765.Bytes);
public long this[int i]=>Value[i];

public static A190765Inst Instance=new A190765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190766
{
public static readonly long[] Value={ 2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190766Inst : IEnumerable<long>
{
public static readonly long[] Value=A190766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190766.Bytes);
public long this[int i]=>Value[i];

public static A190766Inst Instance=new A190766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190767
{
public static readonly long[] Value={ 3L,6L,10L,13L,16L,17L,20L,23L,27L,30L,34L,37L,40L,44L,47L,51L,54L,57L,58L,61L,64L,68L,71L,74L,75L,78L,81L,85L,88L,92L,95L,98L,99L,102L,105L,109L,112L,115L,116L,119L,122L,126L,129L,133L,136L,139L,143L,146L,150L,153L,156L,157L,160L,163L,167L,170L,173L,174L,177L,180L,184L,187L,191L,194L,197L,198L,201L,204L,208L,211L,214L,215L,218L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190767Inst : IEnumerable<long>
{
public static readonly long[] Value=A190767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190767.Bytes);
public long this[int i]=>Value[i];

public static A190767Inst Instance=new A190767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190768
{
public static readonly long[] Value={ 2L,5L,8L,9L,12L,15L,19L,22L,26L,29L,32L,33L,36L,39L,43L,46L,49L,50L,53L,56L,60L,63L,67L,70L,73L,77L,80L,84L,87L,90L,91L,94L,97L,101L,104L,107L,108L,111L,114L,118L,121L,125L,128L,131L,132L,135L,138L,142L,145L,148L,149L,152L,155L,159L,162L,166L,169L,172L,176L,179L,183L,186L,189L,190L,193L,196L,200L,203L,206L,207L,210L,213L,217L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190768Inst : IEnumerable<long>
{
public static readonly long[] Value=A190768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190768.Bytes);
public long this[int i]=>Value[i];

public static A190768Inst Instance=new A190768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190769
{
public static readonly long[] Value={ 1L,4L,7L,11L,14L,18L,21L,24L,25L,28L,31L,35L,38L,41L,42L,45L,48L,52L,55L,59L,62L,65L,66L,69L,72L,76L,79L,82L,83L,86L,89L,93L,96L,100L,103L,106L,110L,113L,117L,120L,123L,124L,127L,130L,134L,137L,140L,141L,144L,147L,151L,154L,158L,161L,164L,165L,168L,171L,175L,178L,181L,182L,185L,188L,192L,195L,199L,202L,205L,209L,212L,216L,219L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190769Inst : IEnumerable<long>
{
public static readonly long[] Value=A190769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190769.Bytes);
public long this[int i]=>Value[i];

public static A190769Inst Instance=new A190769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190770
{
public static readonly long[] Value={ 2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190770Inst : IEnumerable<long>
{
public static readonly long[] Value=A190770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190770.Bytes);
public long this[int i]=>Value[i];

public static A190770Inst Instance=new A190770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190771
{
public static readonly long[] Value={ 10L,17L,27L,34L,51L,58L,68L,75L,92L,99L,109L,116L,126L,133L,150L,157L,167L,174L,191L,198L,208L,215L,232L,249L,256L,266L,273L,290L,297L,307L,314L,331L,338L,348L,355L,365L,372L,389L,396L,406L,413L,430L,437L,447L,454L,464L,471L,488L,495L,505L,512L,529L,536L,546L,553L,570L,577L,587L,594L,604L,611L,628L,635L,645L,652L,669L,676L,686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190771Inst : IEnumerable<long>
{
public static readonly long[] Value=A190771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190771.Bytes);
public long this[int i]=>Value[i];

public static A190771Inst Instance=new A190771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190772
{
public static readonly long[] Value={ 2L,3L,6L,9L,13L,16L,20L,23L,26L,30L,33L,37L,40L,43L,44L,47L,50L,54L,57L,60L,61L,64L,67L,71L,74L,78L,81L,84L,85L,88L,91L,95L,98L,101L,102L,105L,108L,112L,115L,119L,122L,125L,129L,132L,136L,139L,142L,143L,146L,149L,153L,156L,159L,160L,163L,166L,170L,173L,177L,180L,183L,184L,187L,190L,194L,197L,200L,201L,204L,207L,211L,214L,218L,221L,224L,228L,231L,235L,238L,241L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190772Inst : IEnumerable<long>
{
public static readonly long[] Value=A190772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190772.Bytes);
public long this[int i]=>Value[i];

public static A190772Inst Instance=new A190772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190773
{
public static readonly long[] Value={ 1L,5L,8L,12L,15L,18L,19L,22L,25L,29L,32L,35L,36L,39L,42L,46L,49L,53L,56L,59L,63L,66L,70L,73L,76L,77L,80L,83L,87L,90L,93L,94L,97L,100L,104L,107L,111L,114L,117L,118L,121L,124L,128L,131L,134L,135L,138L,141L,145L,148L,152L,155L,158L,162L,165L,169L,172L,175L,176L,179L,182L,186L,189L,193L,196L,199L,203L,206L,210L,213L,216L,217L,220L,223L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190773Inst : IEnumerable<long>
{
public static readonly long[] Value=A190773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190773.Bytes);
public long this[int i]=>Value[i];

public static A190773Inst Instance=new A190773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190774
{
public static readonly long[] Value={ 4L,7L,11L,14L,21L,24L,28L,31L,38L,41L,45L,48L,52L,55L,62L,65L,69L,72L,79L,82L,86L,89L,96L,103L,106L,110L,113L,120L,123L,127L,130L,137L,140L,144L,147L,151L,154L,161L,164L,168L,171L,178L,181L,185L,188L,192L,195L,202L,205L,209L,212L,219L,222L,226L,229L,236L,239L,243L,246L,250L,253L,260L,263L,267L,270L,277L,280L,284L,287L,291L,294L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190774Inst : IEnumerable<long>
{
public static readonly long[] Value=A190774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190774.Bytes);
public long this[int i]=>Value[i];

public static A190774Inst Instance=new A190774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190775
{
public static readonly long[] Value={ 2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190775Inst : IEnumerable<long>
{
public static readonly long[] Value=A190775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190775.Bytes);
public long this[int i]=>Value[i];

public static A190775Inst Instance=new A190775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190776
{
public static readonly long[] Value={ 3L,10L,13L,17L,20L,27L,34L,37L,44L,51L,54L,58L,61L,68L,75L,78L,85L,92L,95L,99L,102L,109L,116L,119L,126L,133L,136L,143L,150L,153L,157L,160L,167L,174L,177L,184L,191L,194L,198L,201L,208L,215L,218L,225L,232L,235L,242L,249L,252L,256L,259L,266L,273L,276L,283L,290L,293L,297L,300L,307L,314L,317L,324L,331L,334L,338L,341L,348L,351L,355L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190776Inst : IEnumerable<long>
{
public static readonly long[] Value=A190776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190776.Bytes);
public long this[int i]=>Value[i];

public static A190776Inst Instance=new A190776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190777
{
public static readonly long[] Value={ 2L,6L,9L,12L,16L,19L,23L,26L,29L,30L,33L,36L,40L,43L,46L,47L,50L,53L,57L,60L,64L,67L,70L,71L,74L,77L,81L,84L,87L,88L,91L,94L,98L,101L,105L,108L,111L,112L,115L,118L,122L,125L,128L,129L,132L,135L,139L,142L,146L,149L,152L,156L,159L,163L,166L,169L,170L,173L,176L,180L,183L,186L,187L,190L,193L,197L,200L,204L,207L,210L,211L,214L,217L,221L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190777Inst : IEnumerable<long>
{
public static readonly long[] Value=A190777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190777.Bytes);
public long this[int i]=>Value[i];

public static A190777Inst Instance=new A190777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190778
{
public static readonly long[] Value={ 1L,4L,5L,8L,11L,15L,18L,21L,22L,25L,28L,32L,35L,39L,42L,45L,49L,52L,56L,59L,62L,63L,66L,69L,73L,76L,79L,80L,83L,86L,90L,93L,97L,100L,103L,104L,107L,110L,114L,117L,120L,121L,124L,127L,131L,134L,138L,141L,144L,145L,148L,151L,155L,158L,161L,162L,165L,168L,172L,175L,179L,182L,185L,189L,192L,196L,199L,202L,203L,206L,209L,213L,216L,219L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190778Inst : IEnumerable<long>
{
public static readonly long[] Value=A190778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190778.Bytes);
public long this[int i]=>Value[i];

public static A190778Inst Instance=new A190778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190779
{
public static readonly long[] Value={ 7L,14L,24L,31L,38L,41L,48L,55L,65L,72L,82L,89L,96L,106L,113L,123L,130L,137L,140L,147L,154L,164L,171L,178L,181L,188L,195L,205L,212L,222L,229L,236L,239L,246L,253L,263L,270L,277L,280L,287L,294L,304L,311L,321L,328L,335L,345L,352L,362L,369L,376L,379L,386L,393L,403L,410L,417L,420L,427L,434L,444L,451L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190779Inst : IEnumerable<long>
{
public static readonly long[] Value=A190779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190779.Bytes);
public long this[int i]=>Value[i];

public static A190779Inst Instance=new A190779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190844
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,19L,27L,29L,33L,35L,43L,45L,51L,53L,57L,59L,65L,67L,75L,81L,87L,89L,99L,101L,105L,107L,113L,115L,129L,131L,135L,139L,153L,159L,161L,171L,173L,177L,179L,195L,197L,201L,203L,209L,211L,225L,227L,235L,243L,257L,259L,261L,267L,269L,297L,299L,303L,305L,315L,317L,321L,323L,339L,341L,345L,347L,353L,355L,387L,389L,393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190844Inst : IEnumerable<long>
{
public static readonly long[] Value=A190844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190844.Bytes);
public long this[int i]=>Value[i];

public static A190844Inst Instance=new A190844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190845
{
public static readonly long[] Value={ 1L,4L,7L,13L,22L,25L,34L,40L,43L,49L,61L,67L,76L,79L,85L,97L,115L,121L,130L,133L,148L,151L,157L,169L,193L,196L,202L,223L,229L,238L,241L,256L,259L,265L,292L,295L,301L,304L,313L,337L,358L,364L,385L,391L,400L,403L,439L,445L,454L,457L,472L,475L,481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190845Inst : IEnumerable<long>
{
public static readonly long[] Value=A190845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190845.Bytes);
public long this[int i]=>Value[i];

public static A190845Inst Instance=new A190845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190846
{
public static readonly long[] Value={ 1L,2L,2L,2L,5L,6L,2L,1L,3L,10L,6L,6L,13L,14L,2L,2L,6L,6L,10L,10L,21L,22L,6L,1L,5L,3L,2L,14L,29L,30L,2L,2L,33L,34L,6L,6L,37L,38L,10L,10L,41L,42L,22L,7L,15L,46L,6L,1L,1L,10L,26L,26L,6L,6L,14L,14L,57L,58L,30L,30L,61L,21L,1L,2L,65L,66L,34L,34L,69L,70L,6L,6L,73L,15L,8L,38L,77L,78L,10L,0L,3L,82L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190846Inst : IEnumerable<long>
{
public static readonly long[] Value=A190846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190846.Bytes);
public long this[int i]=>Value[i];

public static A190846Inst Instance=new A190846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190847
{
public static readonly long[] Value={ 2L,3L,6L,7L,9L,10L,13L,14L,16L,17L,20L,21L,24L,27L,28L,31L,34L,35L,38L,39L,41L,42L,45L,46L,48L,49L,52L,53L,56L,59L,60L,63L,66L,67L,70L,73L,74L,77L,78L,80L,81L,84L,85L,87L,88L,91L,92L,95L,98L,99L,102L,105L,106L,109L,110L,112L,113L,116L,117L,119L,120L,123L,124L,127L,130L,131L,134L,137L,138L,141L,144L,145L,148L,149L,151L,152L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190847Inst : IEnumerable<long>
{
public static readonly long[] Value=A190847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190847.Bytes);
public long this[int i]=>Value[i];

public static A190847Inst Instance=new A190847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190848
{
public static readonly long[] Value={ 1L,5L,9L,17L,21L,29L,33L,37L,53L,57L,65L,69L,85L,89L,101L,105L,113L,117L,129L,133L,149L,161L,173L,177L,197L,201L,209L,213L,225L,229L,257L,261L,269L,277L,305L,317L,321L,341L,345L,353L,357L,389L,393L,401L,405L,417L,421L,449L,453L,469L,485L,513L,517L,521L,533L,537L,593L,597L,605L,609L,629L,633L,641L,645L,677L,681L,689L,693L,705L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190848Inst : IEnumerable<long>
{
public static readonly long[] Value=A190848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190848.Bytes);
public long this[int i]=>Value[i];

public static A190848Inst Instance=new A190848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190849
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,14L,16L,20L,22L,23L,28L,29L,32L,34L,40L,41L,43L,44L,46L,47L,56L,58L,59L,61L,64L,65L,68L,70L,80L,82L,83L,86L,88L,92L,94L,95L,97L,112L,116L,118L,119L,122L,124L,128L,130L,131L,136L,137L,140L,142L,160L,164L,166L,167L,172L,173L,176L,178L,184L,188L,190L,191L,194L,196L,203L,205L,224L,232L,236L,238L,239L,244L,245L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190849Inst : IEnumerable<long>
{
public static readonly long[] Value=A190849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190849.Bytes);
public long this[int i]=>Value[i];

public static A190849Inst Instance=new A190849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190850
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,10L,11L,14L,15L,16L,19L,20L,22L,23L,27L,28L,29L,31L,32L,39L,40L,41L,43L,44L,46L,47L,55L,56L,58L,59L,63L,64L,65L,68L,75L,79L,80L,82L,83L,86L,87L,88L,91L,92L,94L,95L,107L,111L,112L,115L,116L,118L,119L,122L,123L,127L,128L,130L,131L,136L,137L,140L,155L,159L,160L,163L,164L,166L,167L,171L,172L,173L,175L,176L,183L,184L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190850Inst : IEnumerable<long>
{
public static readonly long[] Value=A190850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190850.Bytes);
public long this[int i]=>Value[i];

public static A190850Inst Instance=new A190850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190851
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,13L,14L,16L,20L,22L,25L,26L,28L,32L,38L,40L,43L,44L,49L,50L,52L,56L,64L,65L,67L,74L,76L,79L,80L,85L,86L,88L,97L,98L,100L,101L,104L,112L,119L,121L,128L,130L,133L,134L,146L,148L,151L,152L,157L,158L,160L,169L,170L,172L,176L,182L,193L,194L,196L,200L,202L,208L,224L,227L,229L,236L,238L,241L,242L,254L,256L,259L,260L,265L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190851Inst : IEnumerable<long>
{
public static readonly long[] Value=A190851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190851.Bytes);
public long this[int i]=>Value[i];

public static A190851Inst Instance=new A190851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190852
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,9L,13L,14L,16L,17L,21L,22L,25L,26L,28L,29L,32L,33L,37L,40L,43L,44L,49L,50L,52L,53L,56L,57L,64L,65L,67L,69L,76L,79L,80L,85L,86L,88L,89L,97L,98L,100L,101L,104L,105L,112L,113L,117L,121L,128L,129L,130L,133L,134L,148L,149L,151L,152L,157L,158L,160L,161L,169L,170L,172L,173L,176L,177L,193L,194L,196L,197L,200L,201L,202L,208L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190852Inst : IEnumerable<long>
{
public static readonly long[] Value=A190852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190852.Bytes);
public long this[int i]=>Value[i];

public static A190852Inst Instance=new A190852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190853
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,13L,14L,16L,17L,20L,22L,25L,26L,28L,31L,32L,34L,40L,43L,44L,49L,50L,52L,53L,56L,61L,62L,64L,67L,68L,76L,79L,80L,85L,86L,88L,94L,97L,98L,100L,103L,104L,106L,112L,121L,122L,124L,128L,130L,133L,134L,136L,148L,151L,152L,157L,158L,160L,161L,169L,170L,172L,176L,184L,187L,188L,193L,194L,196L,200L,202L,205L,206L,208L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190853Inst : IEnumerable<long>
{
public static readonly long[] Value=A190853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190853.Bytes);
public long this[int i]=>Value[i];

public static A190853Inst Instance=new A190853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190854
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,10L,14L,16L,17L,18L,20L,22L,26L,28L,32L,34L,40L,42L,44L,50L,52L,53L,56L,58L,62L,64L,66L,68L,70L,74L,80L,82L,86L,88L,90L,98L,100L,104L,106L,112L,114L,122L,124L,128L,130L,134L,136L,138L,152L,158L,160L,161L,162L,170L,172L,176L,178L,188L,194L,196L,200L,202L,206L,208L,210L,212L,214L,224L,226L,234L,242L,244L,248L,250L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190854Inst : IEnumerable<long>
{
public static readonly long[] Value=A190854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190854.Bytes);
public long this[int i]=>Value[i];

public static A190854Inst Instance=new A190854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190855
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,11L,14L,15L,17L,20L,23L,29L,31L,32L,35L,41L,44L,47L,50L,59L,63L,65L,68L,71L,74L,83L,86L,89L,92L,95L,101L,104L,119L,122L,127L,128L,131L,137L,140L,143L,149L,155L,167L,173L,176L,179L,182L,185L,188L,191L,194L,203L,209L,212L,239L,245L,248L,255L,257L,263L,266L,275L,281L,284L,287L,290L,299L,302L,311L,317L,335L,347L,353L,356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190855Inst : IEnumerable<long>
{
public static readonly long[] Value=A190855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190855.Bytes);
public long this[int i]=>Value[i];

public static A190855Inst Instance=new A190855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190856
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,14L,15L,16L,17L,20L,22L,23L,24L,28L,29L,30L,31L,32L,34L,35L,40L,41L,44L,46L,47L,48L,50L,56L,58L,59L,60L,62L,63L,64L,65L,68L,70L,71L,80L,82L,83L,86L,88L,89L,92L,94L,95L,96L,100L,101L,104L,112L,116L,118L,119L,120L,122L,124L,126L,127L,128L,130L,131L,136L,137L,140L,142L,143L,149L,160L,164L,166L,167L,172L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190856Inst : IEnumerable<long>
{
public static readonly long[] Value=A190856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190856.Bytes);
public long this[int i]=>Value[i];

public static A190856Inst Instance=new A190856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190857
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,19L,21L,27L,29L,31L,37L,39L,43L,45L,53L,55L,57L,61L,63L,77L,79L,81L,85L,87L,91L,93L,109L,111L,115L,117L,125L,127L,129L,135L,149L,157L,159L,163L,165L,171L,173L,175L,181L,183L,187L,189L,213L,221L,223L,229L,231L,235L,237L,243L,245L,253L,255L,259L,261L,271L,273L,279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190857Inst : IEnumerable<long>
{
public static readonly long[] Value=A190857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190857.Bytes);
public long this[int i]=>Value[i];

public static A190857Inst Instance=new A190857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190858
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,13L,15L,19L,21L,22L,27L,28L,31L,33L,39L,40L,42L,43L,45L,46L,55L,57L,58L,60L,63L,64L,67L,69L,79L,81L,82L,85L,87L,91L,93L,94L,96L,111L,115L,117L,118L,121L,123L,127L,129L,130L,135L,136L,139L,141L,159L,163L,165L,166L,171L,172L,175L,177L,183L,187L,189L,190L,193L,195L,202L,204L,223L,231L,235L,237L,238L,243L,244L,247L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190858Inst : IEnumerable<long>
{
public static readonly long[] Value=A190858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190858.Bytes);
public long this[int i]=>Value[i];

public static A190858Inst Instance=new A190858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190859
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,10L,13L,14L,15L,18L,19L,21L,22L,26L,27L,28L,30L,31L,38L,39L,40L,42L,43L,45L,46L,54L,55L,57L,58L,62L,63L,64L,67L,74L,78L,79L,81L,82L,85L,86L,87L,90L,91L,93L,94L,106L,110L,111L,114L,115L,117L,118L,121L,122L,126L,127L,129L,130L,135L,136L,139L,154L,158L,159L,162L,163L,165L,166L,170L,171L,172L,174L,175L,182L,183L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190859Inst : IEnumerable<long>
{
public static readonly long[] Value=A190859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190859.Bytes);
public long this[int i]=>Value[i];

public static A190859Inst Instance=new A190859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190908
{
public static readonly long[] Value={ 1L,2L,5L,15L,49L,163L,549L,1875L,6477L,22571L,79213L,279631L,991985L,3533707L,12632909L,45301795L,162890781L,587091795L,2120442517L,7672891151L,27811187377L,100956896179L,366983328885L,1335662387699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190908Inst : IEnumerable<long>
{
public static readonly long[] Value=A190908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190908.Bytes);
public long this[int i]=>Value[i];

public static A190908Inst Instance=new A190908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190909
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,10L,6L,1L,10L,30L,42L,6L,1L,15L,70L,168L,54L,30L,1L,21L,140L,504L,270L,330L,20L,1L,28L,252L,1260L,990L,1980L,260L,140L,1L,36L,420L,2772L,2970L,8580L,1820L,2100L,70L,1L,45L,660L,5544L,7722L,30030L,9100L,16800L,1190L,630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190909Inst : IEnumerable<long>
{
public static readonly long[] Value=A190909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190909.Bytes);
public long this[int i]=>Value[i];

public static A190909Inst Instance=new A190909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190910
{
public static readonly long[] Value={ 1L,2L,6L,23L,89L,338L,1286L,4911L,18769L,71722L,273982L,1046119L,3991913L,15222986L,58013678L,220939711L,840883777L,3198349426L,12157775958L,46188298519L,175376312729L,665552754018L,2524513742262L,9571221986607L,36271175050321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190910Inst : IEnumerable<long>
{
public static readonly long[] Value=A190910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190910.Bytes);
public long this[int i]=>Value[i];

public static A190910Inst Instance=new A190910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190911
{
public static readonly long[] Value={ 3L,3L,5L,3L,3L,5L,3L,3L,5L,3L,3L,7L,3L,3L,7L,3L,3L,5L,3L,3L,5L,3L,3L,5L,3L,3L,7L,3L,3L,7L,3L,3L,5L,3L,3L,5L,3L,3L,5L,3L,3L,11L,3L,3L,7L,3L,3L,5L,3L,3L,5L,3L,3L,5L,3L,3L,7L,3L,3L,11L,3L,3L,5L,3L,3L,5L,3L,3L,5L,3L,3L,7L,3L,3L,7L,3L,3L,5L,3L,3L,5L,3L,3L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190911Inst : IEnumerable<long>
{
public static readonly long[] Value=A190911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190911.Bytes);
public long this[int i]=>Value[i];

public static A190911Inst Instance=new A190911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190912
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,10L,19L,36L,69L,134L,263L,516L,1013L,1990L,3911L,7688L,15113L,29710L,58407L,114824L,225737L,443786L,872459L,1715208L,3372009L,6629194L,13032651L,25621516L,50370573L,99025938L,194679867L,382730540L,752428429L,1479235342L,2908100111L,5717174284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190912Inst : IEnumerable<long>
{
public static readonly long[] Value=A190912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190912.Bytes);
public long this[int i]=>Value[i];

public static A190912Inst Instance=new A190912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190913
{
public static readonly long[] Value={ 5L,0L,2L,9L,2L,10L,29L,14L,50L,99L,82L,220L,365L,416L,926L,1429L,1954L,3842L,5825L,8778L,15922L,24299L,38414L,66240L,102533L,165560L,276954L,434745L,707394L,1163074L,1846069L,3008302L,4900546L,7839115L,12762378L,20694684L,33271421L,54081272L,87516358L,141133157L,229065490L,370410810L,598383689L,970090922L,1568482962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190913Inst : IEnumerable<long>
{
public static readonly long[] Value=A190913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190913.Bytes);
public long this[int i]=>Value[i];

public static A190913Inst Instance=new A190913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190914
{
public static readonly long[] Value={ 5L,0L,6L,3L,18L,10L,57L,42L,178L,165L,566L,616L,1821L,2236L,5914L,7963L,19362L,27982L,63813L,97394L,211458L,336633L,703786L,1157544L,2350597L,3964960L,7872702L,13541691L,26425522L,46147178L,88853297L,156994354L,299165378L,533410837L,1008343310L,1810544592L,3401446413L,6140811708L,11481472994L,20815538227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190914Inst : IEnumerable<long>
{
public static readonly long[] Value=A190914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190914.Bytes);
public long this[int i]=>Value[i];

public static A190914Inst Instance=new A190914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190915
{
public static readonly long[] Value={ 1L,1L,2L,6L,17L,57L,191L,678L,2443L,9029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190915Inst : IEnumerable<long>
{
public static readonly long[] Value=A190915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190915.Bytes);
public long this[int i]=>Value[i];

public static A190915Inst Instance=new A190915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190916
{
public static readonly long[] Value={ 1L,1L,9L,75L,1095L,18585L,401625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190916Inst : IEnumerable<long>
{
public static readonly long[] Value=A190916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190916.Bytes);
public long this[int i]=>Value[i];

public static A190916Inst Instance=new A190916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190917
{
public static readonly long[] Value={ 1L,5L,29L,182L,1198L,8142L,56620L,400598L,2872754L,20824778L,152303410L,1122149800L,8319825040L,62017475600L,464452683432L,3492568119566L,26358270711370L,199565061455634L,1515311001158482L,11535716330003876L,88025068713285476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190917Inst : IEnumerable<long>
{
public static readonly long[] Value=A190917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190917.Bytes);
public long this[int i]=>Value[i];

public static A190917Inst Instance=new A190917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190918
{
public static readonly BigInteger[] Value={ 1L,36L,1721L,94376L,5609649L,351574834L,22875971289L,1530622143864L,104650147201049L,7279277647839552L,513492654638478897L,BigInteger.Parse("36647810215955194122"),BigInteger.Parse("2641438793287744496337"),BigInteger.Parse("191996676519223794534702") };
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
public class A190918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190918Inst Instance=new A190918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190919
{
public static readonly long[] Value={ 1L,10L,109L,1277L,15743L,201562L,2655555L,35772051L,490468025L,6822301766L,96037376333L,1365601216463L,19585937393943L,283004879815278L,4115869618377271L,60201892791282135L,885032788096094565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190919Inst : IEnumerable<long>
{
public static readonly long[] Value=A190919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190919.Bytes);
public long this[int i]=>Value[i];

public static A190919Inst Instance=new A190919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190920
{
public static readonly BigInteger[] Value={ 1L,329L,163386L,98371884L,66218360625L,47940557125969L,36533294879349056L,BigInteger.Parse("28920026907938624194"),BigInteger.Parse("23575497690601916022516"),BigInteger.Parse("19672658572012343899666292"),BigInteger.Parse("16730974132035148942028759656"),BigInteger.Parse("14455459908454408519322566567054") };
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
public class A190920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190920.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190920Inst Instance=new A190920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190921
{
public static readonly BigInteger[] Value={ 1L,99L,12721L,1903102L,312841383L,54811120355L,10054355708671L,1909325866644096L,372521441486934113L,BigInteger.Parse("74275858248868186497"),BigInteger.Parse("15075586701977689855707"),BigInteger.Parse("3105668779830679872107622") };
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
public class A190921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190921.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190921Inst Instance=new A190921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190922
{
public static readonly BigInteger[] Value={ 1L,20L,436L,9993L,238856L,5904049L,149981369L,3897334810L,103211369665L,2777315286064L,75757347740370L,2090701163682622L,58284103429506565L,1639251621061033507L,BigInteger.Parse("46464491673819086074"),BigInteger.Parse("1326158666350163625126") };
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
public class A190922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190922.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190922Inst Instance=new A190922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190923
{
public static readonly BigInteger[] Value={ 1L,3655L,22831355L,182502973885L,1681287695542855L,16985819072511102549UL,BigInteger.Parse("183095824753841610373405"),BigInteger.Parse("2070756746775910218326948065"),BigInteger.Parse("24302858067615766089801166488125"),BigInteger.Parse("293736218147318801678882792470437721") };
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
public class A190923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190923.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190923Inst Instance=new A190923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190956
{
public static readonly BigInteger[] Value={ 0L,1L,10L,106L,1120L,11836L,125080L,1321816L,13968640L,147617296L,1559984800L,16485551776L,174215426560L,1841067576256L,19455968321920L,205606088676736L,2172796696698880L,22961603499049216L,242652815170685440L,2564297772701149696L,BigInteger.Parse("27098894618035609600") };
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
public class A190956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190956Inst Instance=new A190956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190957
{
public static readonly BigInteger[] Value={ 0L,1L,10L,108L,1160L,12464L,133920L,1438912L,15460480L,166116096L,1784844800L,19177376768L,206052526080L,2213944274944L,23787862958080L,255590183780352L,2746204741468160L,29506768884924416L,317037326780989440L,3406427418889289728L,BigInteger.Parse("36600572803140812800") };
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
public class A190957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190957Inst Instance=new A190957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190958
{
public static readonly long[] Value={ 0L,1L,2L,-6L,-32L,-4L,312L,664L,-1792L,-10224L,-2528L,97184L,219648L,-532544L,-3261568L,-1197696L,30220288L,72417536L,-157367808L,-1038910976L,-504143872L,9380822016L,23803082752L,-46202054656L,-330434936832L,-198849327104L,2906650714112L,7801794699264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190958Inst : IEnumerable<long>
{
public static readonly long[] Value=A190958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190958.Bytes);
public long this[int i]=>Value[i];

public static A190958Inst Instance=new A190958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190959
{
public static readonly long[] Value={ 0L,1L,3L,4L,-3L,-29L,-72L,-71L,147L,796L,1653L,979L,-5328L,-20879L,-35997L,-3596L,169197L,525571L,730728L,-435671L,-4960653L,-12703604L,-13307547L,23595379L,137323872L,293994721L,195364803L,-883879196L,-3628461603L,-6465988829L,-1255658472L,28562968729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190959Inst : IEnumerable<long>
{
public static readonly long[] Value=A190959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190959.Bytes);
public long this[int i]=>Value[i];

public static A190959Inst Instance=new A190959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190960
{
public static readonly long[] Value={ 0L,1L,3L,3L,-9L,-45L,-81L,27L,567L,1539L,1215L,-5589L,-24057L,-38637L,28431L,317115L,780759L,439587L,-3365793L,-12734901L,-18009945L,22379571L,175198383L,391317723L,122762871L,-1979617725L,-6675430401L,-8148584853L,15606827847L,95711992659L,193495010895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190960Inst : IEnumerable<long>
{
public static readonly long[] Value=A190960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190960.Bytes);
public long this[int i]=>Value[i];

public static A190960Inst Instance=new A190960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190961
{
public static readonly long[] Value={ 0L,1L,3L,2L,-15L,-59L,-72L,197L,1095L,1906L,-1947L,-19183L,-43920L,2521L,315003L,927362L,577065L,-4760339L,-18320472L,-21639043L,63326175L,341451826L,581072253L,-646946023L,-6008343840L,-13496409359L,1569178803L,99182401922L,286562954145L,165412048981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190961Inst : IEnumerable<long>
{
public static readonly long[] Value=A190961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190961.Bytes);
public long this[int i]=>Value[i];

public static A190961Inst Instance=new A190961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190962
{
public static readonly long[] Value={ 0L,1L,3L,1L,-21L,-71L,-45L,433L,1659L,1513L,-8733L,-38303L,-45045L,171289L,874227L,1252369L,-3236709L,-19729079L,-33293565L,57951937L,440204331L,856997497L,-950642157L,-9707906447L,-21518582085L,13107505321L,211471172643L,529553475361L,-103108955061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190962Inst : IEnumerable<long>
{
public static readonly long[] Value=A190962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190962.Bytes);
public long this[int i]=>Value[i];

public static A190962Inst Instance=new A190962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190963
{
public static readonly long[] Value={ 0L,1L,3L,0L,-27L,-81L,0L,729L,2187L,0L,-19683L,-59049L,0L,531441L,1594323L,0L,-14348907L,-43046721L,0L,387420489L,1162261467L,0L,-10460353203L,-31381059609L,0L,282429536481L,847288609443L,0L,-7625597484987L,-22876792454961L,0L,205891132094649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190963Inst : IEnumerable<long>
{
public static readonly long[] Value=A190963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190963.Bytes);
public long this[int i]=>Value[i];

public static A190963Inst Instance=new A190963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190964
{
public static readonly long[] Value={ 0L,1L,3L,-1L,-33L,-89L,63L,1079L,2607L,-2969L,-34977L,-75241L,124047L,1124551L,2133183L,-4845961L,-35869713L,-59149529L,181248543L,1135240919L,1593237327L,-6572697209L,-35650464897L,-41224422601L,232831381167L,1110738369511L,1003901296863L,-8095679804521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190964Inst : IEnumerable<long>
{
public static readonly long[] Value=A190964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190964.Bytes);
public long this[int i]=>Value[i];

public static A190964Inst Instance=new A190964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190965
{
public static readonly long[] Value={ 0L,1L,4L,10L,16L,4L,-80L,-344L,-896L,-1520L,-704L,6304L,29440L,79936L,143104L,92800L,-487424L,-2506496L,-7101440L,-13366784L,-10858496L,36766720L,212217856L,628271104L,1239777280L,1189482496L,-2680733696L,-17859829760L,-55354916864L,-114260688896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190965Inst : IEnumerable<long>
{
public static readonly long[] Value=A190965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190965.Bytes);
public long this[int i]=>Value[i];

public static A190965Inst Instance=new A190965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190966
{
public static readonly long[] Value={ 0L,1L,4L,8L,0L,-64L,-256L,-512L,0L,4096L,16384L,32768L,0L,-262144L,-1048576L,-2097152L,0L,16777216L,67108864L,134217728L,0L,-1073741824L,-4294967296L,-8589934592L,0L,68719476736L,274877906944L,549755813888L,0L,-4398046511104L,-17592186044416L,-35184372088832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190966Inst : IEnumerable<long>
{
public static readonly long[] Value=A190966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190966.Bytes);
public long this[int i]=>Value[i];

public static A190966Inst Instance=new A190966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190967
{
public static readonly long[] Value={ 0L,1L,4L,7L,-8L,-95L,-308L,-377L,1264L,8449L,22420L,13639L,-147224L,-711647L,-1521572L,318535L,14968288L,57006337L,93310756L,-139814009L,-1399052840L,-4337885279L,-4760065556L,20000705287L,122843411152L,311367297025L,139878487732L,-2242791722297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190967Inst : IEnumerable<long>
{
public static readonly long[] Value=A190967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190967.Bytes);
public long this[int i]=>Value[i];

public static A190967Inst Instance=new A190967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190968
{
public static readonly long[] Value={ 0L,1L,4L,6L,-16L,-124L,-336L,-104L,2944L,12816L,21824L,-40864L,-381696L,-1118144L,-655616L,8558976L,40792064L,77578496L,-97606656L,-1166211584L,-3688779776L,-3093003264L,24515784704L,128993171456L,270814838784L,-206672359424L,-3534837825536L,-12072627707904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190968Inst : IEnumerable<long>
{
public static readonly long[] Value=A190968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190968.Bytes);
public long this[int i]=>Value[i];

public static A190968Inst Instance=new A190968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190969
{
public static readonly long[] Value={ 0L,1L,5L,17L,45L,89L,85L,-287L,-2115L,-8279L,-24475L,-56143L,-84915L,24569L,802165L,3814273L,12654045L,32756041L,62547845L,50690897L,-246928275L,-1640168551L,-6225416555L,-18005734367L,-40225339395L,-57080822039L,36398604965L,638639601137L,2902009165965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190969Inst : IEnumerable<long>
{
public static readonly long[] Value=A190969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190969.Bytes);
public long this[int i]=>Value[i];

public static A190969Inst Instance=new A190969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190970
{
public static readonly long[] Value={ 0L,1L,5L,16L,35L,31L,-160L,-1079L,-3955L,-10064L,-14725L,16951L,217280L,933841L,2713685L,5163856L,1396115L,-39494129L,-210035680L,-694731239L,-1583335075L,-1664094224L,5929544555L,44624570791L,169756952960L,447163627681L,708005561765L,-484444840304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190970Inst : IEnumerable<long>
{
public static readonly long[] Value=A190970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190970.Bytes);
public long this[int i]=>Value[i];

public static A190970Inst Instance=new A190970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190971
{
public static readonly long[] Value={ 0L,1L,5L,15L,25L,-25L,-375L,-1625L,-4375L,-5625L,15625L,134375L,515625L,1234375L,1015625L,-7265625L,-46484375L,-159765625L,-333984375L,-72265625L,2978515625L,15615234375L,48291015625L,85302734375L,-56396484375L,-1135009765625L,-5111083984375L,-14205322265625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190971Inst : IEnumerable<long>
{
public static readonly long[] Value=A190971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190971.Bytes);
public long this[int i]=>Value[i];

public static A190971Inst Instance=new A190971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191004
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,2L,3L,3L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,4L,2L,2L,2L,2L,2L,2L,1L,1L,2L,4L,3L,5L,4L,1L,4L,1L,2L,3L,2L,2L,2L,3L,1L,4L,1L,2L,4L,2L,2L,3L,1L,2L,4L,5L,3L,3L,1L,4L,3L,2L,3L,5L,3L,4L,8L,2L,2L,7L,4L,4L,5L,2L,2L,6L,3L,3L,4L,4L,2L,4L,2L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191004Inst : IEnumerable<long>
{
public static readonly long[] Value=A191004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191004.Bytes);
public long this[int i]=>Value[i];

public static A191004Inst Instance=new A191004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191005
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,48L,325L,2640L,24997L,270592L,3295017L,44582400L,663532001L,10773295104L,189494874413L,3589475821568L,72849709631805L,1577078610001920L,36275031333172945L,883457851718762496L,BigInteger.Parse("22711455593084360761"),BigInteger.Parse("614582936996534026240") };
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
public class A191005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191005.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191005Inst Instance=new A191005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191006
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,144L,1296L,16848L,320112L,8963136L,367488576L,22049314560L,1940339681280L,250303818885120L,47307421769287680L,13104155830092687360UL,BigInteger.Parse("5320287267017631068160"),BigInteger.Parse("3165570923875490485555200") };
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
public class A191006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191006Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191006.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191006.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191006Inst Instance=new A191006Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191007
{
public static readonly long[] Value={ 3L,9L,27L,69L,171L,405L,939L,2133L,4779L,10581L,23211L,50517L,109227L,234837L,502443L,1070421L,2271915L,4805973L,10136235L,21321045L,44739243L,93672789L,195734187L,408245589L,850045611L,1767200085L,3668617899L,7605671253L,15748213419L,32570168661L,67287820971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191007Inst : IEnumerable<long>
{
public static readonly long[] Value=A191007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191007.Bytes);
public long this[int i]=>Value[i];

public static A191007Inst Instance=new A191007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191008
{
public static readonly long[] Value={ 1L,5L,22L,86L,319L,1139L,3964L,13532L,45517L,151313L,498226L,1627538L,5281195L,17039327L,54705208L,174877304L,556916953L,1767605981L,5593383310L,17651846030L,55570626391L,174557144075L,547207226932L,1712229064916L,5348509347109L,16680994498409L,51949382866474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191008Inst : IEnumerable<long>
{
public static readonly long[] Value=A191008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191008.Bytes);
public long this[int i]=>Value[i];

public static A191008Inst Instance=new A191008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191009
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,3L,1L,3L,0L,4L,0L,3L,4L,7L,0L,3L,0L,2L,4L,3L,0L,0L,1L,3L,4L,0L,0L,12L,0L,15L,4L,3L,6L,1L,0L,3L,4L,10L,0L,12L,0L,18L,3L,3L,0L,4L,1L,18L,4L,20L,0L,12L,6L,8L,4L,3L,0L,18L,0L,3L,20L,31L,6L,12L,0L,24L,4L,4L,0L,15L,0L,3L,24L,26L,8L,12L,0L,26L,13L,3L,0L,14L,6L,3L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191009Inst : IEnumerable<long>
{
public static readonly long[] Value=A191009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191009.Bytes);
public long this[int i]=>Value[i];

public static A191009Inst Instance=new A191009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191010
{
public static readonly long[] Value={ 1L,7L,41L,215L,1065L,5079L,23593L,107479L,482345L,2139095L,9395241L,40936407L,177167401L,762356695L,3264175145L,13915694039L,59098749993L,250138895319L,1055531162665L,4442026976215L,18647717207081L,78109306037207L,326510972984361L,1362338887279575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191010Inst : IEnumerable<long>
{
public static readonly long[] Value=A191010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191010.Bytes);
public long this[int i]=>Value[i];

public static A191010Inst Instance=new A191010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191011
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,6L,9L,-120L,-225L,5040L,11025L,-362880L,-893025L,39916800L,108056025L,-6227020800L,-18261468225L,1307674368000L,4108830350625L,-355687428096000L,-1187451971330625L,121645100408832000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191011Inst : IEnumerable<long>
{
public static readonly long[] Value=A191011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191011.Bytes);
public long this[int i]=>Value[i];

public static A191011Inst Instance=new A191011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191012
{
public static readonly long[] Value={ 0L,1L,22L,183L,820L,2605L,6666L,14707L,29128L,53145L,90910L,147631L,229692L,344773L,501970L,711915L,986896L,1340977L,1790118L,2352295L,3047620L,3898461L,4929562L,6168163L,7644120L,9390025L,11441326L,13836447L,16616908L,19827445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191012Inst : IEnumerable<long>
{
public static readonly long[] Value=A191012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191012.Bytes);
public long this[int i]=>Value[i];

public static A191012Inst Instance=new A191012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191013
{
public static readonly long[] Value={ 1L,5L,9L,29L,61L,119L,249L,507L,1017L,2045L,4047L,8181L,16381L,32765L,65521L,131069L,262137L,524277L,1048567L,2097145L,4194285L,8388597L,16777185L,33554421L,67108821L,134217725L,268435405L,536870909L,1073741811L,2147483619L,4294967275L,8589934569L,17179869177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191013Inst : IEnumerable<long>
{
public static readonly long[] Value=A191013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191013.Bytes);
public long this[int i]=>Value[i];

public static A191013Inst Instance=new A191013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191014
{
public static readonly ulong[] Value={ 0L,1L,10L,102L,1040L,10604L,108120L,1102408L,11240320L,114608016L,1168560800L,11914824032L,121485361920L,1238683267264L,12629803396480L,128775400499328L,1313013611786240L,13387686918861056L,136502896412183040L,1391804337959552512L,14191049172419891200UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191014Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A191014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191014.Bytes);
public ulong this[int i]=>Value[i];

public static A191014Inst Instance=new A191014Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191015
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,9L,12L,18L,25L,32L,47L,61L,79L,108L,143L,182L,246L,315L,404L,526L,674L,849L,1102L,1389L,1745L,2215L,2788L,3467L,4384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191015Inst : IEnumerable<long>
{
public static readonly long[] Value=A191015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191015.Bytes);
public long this[int i]=>Value[i];

public static A191015Inst Instance=new A191015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191016
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,38L,238L,1558L,10966L,106334L,1050974L,10295324L,114643744L,1426970188L,19128627772L,301484330492L,4785515966492L,75490216911932L,1287754035291964L,23735661951947896L,462001846720538656L,9472366452963142856UL,BigInteger.Parse("202869898263715663016"),BigInteger.Parse("4536294970208910412232"),BigInteger.Parse("107194755891965843670088"),BigInteger.Parse("2634562640821884269137768") };
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
public class A191016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191016.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191016Inst Instance=new A191016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191017
{
public static readonly long[] Value={ 3L,5L,13L,19L,23L,59L,61L,71L,79L,83L,101L,113L,127L,131L,137L,139L,151L,157L,173L,181L,191L,193L,227L,229L,233L,239L,251L,263L,269L,281L,283L,293L,307L,337L,349L,359L,397L,401L,419L,431L,449L,457L,461L,463L,467L,487L,509L,523L,563L,569L,587L,599L,617L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191017Inst : IEnumerable<long>
{
public static readonly long[] Value=A191017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191017.Bytes);
public long this[int i]=>Value[i];

public static A191017Inst Instance=new A191017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191018
{
public static readonly long[] Value={ 2L,17L,19L,23L,31L,47L,53L,61L,79L,83L,107L,109L,113L,137L,139L,151L,167L,173L,181L,197L,199L,211L,227L,229L,233L,241L,257L,263L,271L,293L,317L,331L,347L,349L,353L,379L,383L,409L,421L,439L,443L,467L,499L,503L,541L,557L,563L,571L,587L,593L,601L,617L,619L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191018Inst : IEnumerable<long>
{
public static readonly long[] Value=A191018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191018.Bytes);
public long this[int i]=>Value[i];

public static A191018Inst Instance=new A191018Inst();

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