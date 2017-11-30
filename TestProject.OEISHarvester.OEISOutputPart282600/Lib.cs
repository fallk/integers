using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A134215
{
public static readonly long[] Value={ 3L,314L,324L,344L,393L,730L,922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134215Inst : IEnumerable<long>
{
public static readonly long[] Value=A134215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134215.Bytes);
public long this[int i]=>Value[i];

public static A134215Inst Instance=new A134215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134248
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,1L,7L,15L,9L,1L,11L,34L,36L,14L,1L,16L,65L,100L,70L,20L,1L,22L,111L,225L,230L,120L,27L,129L,175L,441L,595L,455L,189L,35L,1L,37L,260L,784L,1316L,1330L,812L,280L,44L,1L,46L,369L,1296L,2604L,3276L,2646L,1344L,396L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134248Inst : IEnumerable<long>
{
public static readonly long[] Value=A134248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134248.Bytes);
public long this[int i]=>Value[i];

public static A134248Inst Instance=new A134248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134249
{
public static readonly long[] Value={ 1L,3L,1L,5L,7L,1L,8L,10L,13L,1L,12L,14L,17L,21L,1L,17L,19L,22L,26L,31L,1L,23L,25L,28L,32L,37L,43L,1L,30L,32L,35L,39L,44L,50L,57L,1L,38L,40L,43L,47L,52L,58L,65L,73L,1L,47L,49L,52L,56L,61L,67L,74L,82L,91L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134249Inst : IEnumerable<long>
{
public static readonly long[] Value=A134249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134249.Bytes);
public long this[int i]=>Value[i];

public static A134249Inst Instance=new A134249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134250
{
public static readonly long[] Value={ 4L,1L,7L,-14L,55L,-173L,580L,-1907L,6307L,-20822L,68779L,-227153L,750244L,-2477879L,8183887L,-27029534L,89272495L,-294847013L,973813540L,-3216287627L,10622676427L,-35084316902L,115875627139L,-382711198313L,1264009222084L,-4174738864559L,13788225815767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134250Inst : IEnumerable<long>
{
public static readonly long[] Value=A134250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134250.Bytes);
public long this[int i]=>Value[i];

public static A134250Inst Instance=new A134250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134251
{
public static readonly long[] Value={ 2L,10L,18L,41L,45L,50L,64L,65L,82L,97L,99L,101L,103L,113L,116L,133L,147L,170L,172L,175L,178L,191L,251L,252L,255L,265L,275L,285L,295L,297L,304L,329L,333L,340L,346L,350L,379L,385L,399L,410L,418L,432L,433L,443L,459L,473L,485L,493L,494L,509L,515L,519L,553L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134251Inst : IEnumerable<long>
{
public static readonly long[] Value=A134251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134251.Bytes);
public long this[int i]=>Value[i];

public static A134251Inst Instance=new A134251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134252
{
public static readonly long[] Value={ 26L,32L,35L,43L,51L,73L,85L,86L,93L,102L,125L,129L,130L,131L,146L,183L,204L,212L,218L,229L,233L,241L,242L,260L,276L,277L,284L,309L,331L,332L,351L,357L,359L,389L,393L,403L,409L,425L,438L,447L,448L,458L,479L,482L,505L,534L,540L,550L,562L,564L,577L,581L,612L,620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134252Inst : IEnumerable<long>
{
public static readonly long[] Value=A134252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134252.Bytes);
public long this[int i]=>Value[i];

public static A134252Inst Instance=new A134252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134253
{
public static readonly long[] Value={ 1L,4L,12L,20L,58L,59L,69L,78L,92L,111L,120L,126L,136L,143L,150L,151L,164L,165L,186L,193L,197L,206L,211L,213L,214L,225L,234L,247L,254L,261L,267L,271L,288L,319L,342L,352L,353L,354L,364L,370L,373L,378L,384L,386L,387L,416L,421L,436L,439L,449L,452L,455L,457L,462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134253Inst : IEnumerable<long>
{
public static readonly long[] Value=A134253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134253.Bytes);
public long this[int i]=>Value[i];

public static A134253Inst Instance=new A134253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134254
{
public static readonly long[] Value={ 29L,36L,46L,55L,60L,76L,104L,109L,144L,148L,157L,160L,168L,176L,181L,196L,198L,205L,207L,219L,223L,226L,227L,237L,244L,245L,253L,272L,278L,301L,302L,316L,320L,321L,325L,338L,347L,372L,380L,391L,401L,426L,437L,456L,475L,498L,513L,523L,524L,527L,537L,542L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134254Inst : IEnumerable<long>
{
public static readonly long[] Value=A134254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134254.Bytes);
public long this[int i]=>Value[i];

public static A134254Inst Instance=new A134254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134255
{
public static readonly long[] Value={ 19L,25L,30L,57L,70L,72L,77L,90L,91L,94L,105L,108L,110L,112L,114L,123L,134L,138L,140L,141L,158L,173L,174L,179L,180L,188L,192L,201L,210L,230L,246L,250L,270L,291L,299L,324L,343L,360L,375L,382L,429L,431L,440L,450L,454L,465L,484L,490L,512L,517L,518L,529L,530L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134255Inst : IEnumerable<long>
{
public static readonly long[] Value=A134255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134255.Bytes);
public long this[int i]=>Value[i];

public static A134255Inst Instance=new A134255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134256
{
public static readonly long[] Value={ 9L,16L,23L,27L,38L,61L,74L,88L,96L,106L,117L,127L,149L,154L,177L,190L,216L,235L,236L,239L,292L,303L,312L,322L,336L,337L,339L,344L,345L,361L,377L,406L,413L,417L,444L,446L,471L,487L,488L,492L,496L,508L,511L,522L,526L,532L,549L,555L,559L,568L,570L,576L,578L,589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134256Inst : IEnumerable<long>
{
public static readonly long[] Value=A134256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134256.Bytes);
public long this[int i]=>Value[i];

public static A134256Inst Instance=new A134256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134257
{
public static readonly long[] Value={ 13L,17L,21L,22L,24L,28L,34L,54L,66L,67L,80L,87L,98L,119L,121L,135L,139L,155L,161L,167L,184L,194L,195L,199L,202L,208L,217L,220L,228L,238L,262L,266L,273L,281L,287L,290L,296L,300L,318L,326L,334L,356L,369L,374L,376L,383L,395L,396L,400L,404L,408L,414L,415L,430L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134257Inst : IEnumerable<long>
{
public static readonly long[] Value=A134257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134257.Bytes);
public long this[int i]=>Value[i];

public static A134257Inst Instance=new A134257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134258
{
public static readonly long[] Value={ 3L,7L,8L,11L,33L,39L,47L,52L,62L,63L,75L,83L,107L,122L,124L,145L,156L,159L,166L,169L,171L,187L,200L,215L,221L,224L,231L,243L,256L,257L,263L,268L,282L,283L,286L,289L,293L,294L,307L,310L,311L,313L,327L,349L,366L,367L,390L,392L,402L,405L,420L,427L,428L,445L,477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134258Inst : IEnumerable<long>
{
public static readonly long[] Value=A134258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134258.Bytes);
public long this[int i]=>Value[i];

public static A134258Inst Instance=new A134258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134259
{
public static readonly long[] Value={ 6L,14L,40L,42L,44L,49L,53L,56L,68L,71L,100L,115L,128L,132L,142L,152L,153L,162L,163L,182L,185L,203L,209L,248L,249L,259L,274L,280L,305L,306L,308L,317L,323L,328L,330L,335L,341L,348L,355L,358L,363L,365L,368L,381L,388L,397L,398L,407L,411L,412L,419L,422L,423L,424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134259Inst : IEnumerable<long>
{
public static readonly long[] Value=A134259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134259.Bytes);
public long this[int i]=>Value[i];

public static A134259Inst Instance=new A134259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134260
{
public static readonly long[] Value={ 297L,459L,509L,519L,605L,860L,1105L,1149L,1172L,1198L,1295L,1663L,1814L,1822L,1826L,1998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134260Inst : IEnumerable<long>
{
public static readonly long[] Value=A134260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134260.Bytes);
public long this[int i]=>Value[i];

public static A134260Inst Instance=new A134260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134261
{
public static readonly BigInteger[] Value={ 0L,1L,2L,9L,68L,735L,10332L,178276L,3639680L,85750461L,2289322710L,68298539441L,2251768422840L,81301875813340L,3190478732975744L,135209859332836905L,6154229137942791184L,BigInteger.Parse("299422872446882413387"),BigInteger.Parse("15507211446546229257948") };
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
public class A134261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134261Inst Instance=new A134261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134262
{
public static readonly BigInteger[] Value={ 1L,10L,250L,22946L,8222576L,11168045764L,57451983566596L,1121231537486377866L,BigInteger.Parse("82999668877677132763564"),BigInteger.Parse("23304040481827726137141908956"),BigInteger.Parse("24817820869161647380317564563160782") };
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
public class A134262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134262Inst Instance=new A134262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134263
{
public static readonly long[] Value={ 1L,343L,10680L,11448L,11832L,12760L,12920L,13470L,14360L,14526L,15064L,15198L,15486L,15752L,16194L,16264L,16376L,16390L,16472L,16910L,17110L,18734L,20366L,20654L,20822L,21094L,21122L,21158L,21598L,21843L,22899L,23403L,23691L,24695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134263Inst : IEnumerable<long>
{
public static readonly long[] Value=A134263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134263.Bytes);
public long this[int i]=>Value[i];

public static A134263Inst Instance=new A134263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134296
{
public static readonly BigInteger[] Value={ 1L,2L,13L,259L,750371L,81566917L,2642791002353L,716984262871579L,BigInteger.Parse("102688143363690674087"),BigInteger.Parse("21841112114495269555043222069"),BigInteger.Parse("17727866746681961093761724283871") };
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
public class A134296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134296Inst Instance=new A134296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134297
{
public static readonly long[] Value={ 107L,214L,321L,428L,535L,642L,749L,856L,963L,1070L,1177L,1284L,1391L,1498L,1605L,1712L,1819L,1926L,2033L,2140L,2247L,2354L,2461L,2568L,2675L,2782L,2889L,2996L,3103L,3210L,3317L,3424L,3531L,3638L,3745L,3852L,3959L,4066L,4173L,4280L,4387L,4494L,4601L,4708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134297Inst : IEnumerable<long>
{
public static readonly long[] Value=A134297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134297.Bytes);
public long this[int i]=>Value[i];

public static A134297Inst Instance=new A134297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134298
{
public static readonly long[] Value={ 14025517307L,448816553824L,3408200705601L,14362129722368L,43829741584375L,109062422579232L,235726869378749L,459588151115776L,828192771461043L,1402551730700000L,2258823587809657L,3489997522535424L,5207576397467951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134298Inst : IEnumerable<long>
{
public static readonly long[] Value=A134298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134298.Bytes);
public long this[int i]=>Value[i];

public static A134298Inst Instance=new A134298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134299
{
public static readonly long[] Value={ 4L,5L,6L,5L,7L,6L,5L,8L,6L,7L,6L,6L,9L,6L,7L,8L,6L,7L,6L,7L,10L,6L,7L,8L,7L,9L,6L,7L,8L,7L,7L,8L,7L,11L,7L,7L,8L,7L,9L,8L,7L,10L,7L,7L,8L,7L,9L,8L,7L,8L,7L,9L,8L,7L,12L,8L,7L,8L,7L,9L,8L,7L,10L,8L,9L,8L,7L,11L,8L,7L,8L,8L,9L,8L,7L,10L,8L,9L,8L,8L,9L,8L,7L,10L,8L,9L,8L,8L,13L,8L,9L,8L,8L,9L,8L,8L,10L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134299Inst : IEnumerable<long>
{
public static readonly long[] Value=A134299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134299.Bytes);
public long this[int i]=>Value[i];

public static A134299Inst Instance=new A134299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134300
{
public static readonly long[] Value={ 6L,-4L,2L,-1L,2L,-4L,6L,-7L,6L,-4L,2L,-1L,2L,-4L,6L,-7L,6L,-4L,2L,-1L,2L,-4L,6L,-7L,6L,-4L,2L,-1L,2L,-4L,6L,-7L,6L,-4L,2L,-1L,2L,-4L,6L,-7L,6L,-4L,2L,-1L,2L,-4L,6L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134300Inst : IEnumerable<long>
{
public static readonly long[] Value=A134300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134300.Bytes);
public long this[int i]=>Value[i];

public static A134300Inst Instance=new A134300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134301
{
public static readonly long[] Value={ 0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L,0L,2L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134301Inst : IEnumerable<long>
{
public static readonly long[] Value=A134301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134301.Bytes);
public long this[int i]=>Value[i];

public static A134301Inst Instance=new A134301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134302
{
public static readonly long[] Value={ 7L,10L,14L,20L,21L,24L,26L,28L,30L,35L,40L,42L,43L,48L,49L,50L,52L,56L,57L,60L,63L,70L,72L,74L,76L,77L,78L,80L,84L,86L,90L,91L,96L,98L,100L,104L,105L,107L,110L,112L,114L,117L,119L,120L,126L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134302Inst : IEnumerable<long>
{
public static readonly long[] Value=A134302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134302.Bytes);
public long this[int i]=>Value[i];

public static A134302Inst Instance=new A134302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134303
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,3L,4L,2L,1L,1L,19L,15L,13L,9L,8L,4L,2L,1L,35L,29L,31L,26L,13L,12L,6L,3L,27L,25L,31L,20L,10L,5L,32L,16L,8L,4L,2L,1L,17L,9L,16L,8L,4L,2L,1L,5L,8L,4L,2L,1L,64L,32L,16L,8L,4L,2L,1L,29L,120L,60L,30L,15L,35L,41L,37L,60L,30L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134303Inst : IEnumerable<long>
{
public static readonly long[] Value=A134303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134303.Bytes);
public long this[int i]=>Value[i];

public static A134303Inst Instance=new A134303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134304
{
public static readonly long[] Value={ 2L,1L,2L,1L,11L,21L,57L,211L,141L,156L,78L,39L,140L,70L,35L,214L,107L,90L,45L,309L,330L,165L,120L,60L,30L,15L,435L,651L,420L,210L,105L,429L,1143L,576L,288L,144L,72L,36L,18L,9L,116L,58L,29L,2286L,1143L,1638L,819L,1071L,983L,1983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134304Inst : IEnumerable<long>
{
public static readonly long[] Value=A134304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134304.Bytes);
public long this[int i]=>Value[i];

public static A134304Inst Instance=new A134304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134305
{
public static readonly long[] Value={ 1L,2L,3L,4L,40L,59L,60L,61L,62L,241L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134305Inst : IEnumerable<long>
{
public static readonly long[] Value=A134305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134305.Bytes);
public long this[int i]=>Value[i];

public static A134305Inst Instance=new A134305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134306
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,4L,6L,4L,17L,32L,44L,60L,70L,184L,476L,872L,1553L,2720L,4288L,6312L,9004L,16088L,36900L,82984L,174374L,346048L,653096L,1199384L,2160732L,3812464L,6617304L,11307920L,18978577L,31327104L,50882720L,80963520L,125489856L,188637520L,273984664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134306Inst : IEnumerable<long>
{
public static readonly long[] Value=A134306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134306.Bytes);
public long this[int i]=>Value[i];

public static A134306Inst Instance=new A134306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134307
{
public static readonly long[] Value={ 11L,29L,37L,43L,59L,71L,79L,97L,103L,109L,113L,127L,131L,137L,151L,163L,181L,191L,197L,199L,211L,223L,229L,233L,241L,257L,263L,269L,281L,283L,293L,307L,313L,331L,347L,349L,353L,359L,367L,373L,379L,397L,401L,419L,421L,433L,439L,449L,461L,463L,487L,499L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134307Inst : IEnumerable<long>
{
public static readonly long[] Value=A134307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134307.Bytes);
public long this[int i]=>Value[i];

public static A134307Inst Instance=new A134307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134308
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,1L,8L,12L,12L,4L,16L,32L,48L,32L,8L,32L,80L,160L,160L,80L,16L,64L,192L,480L,640L,480L,192L,32128L,448L,1344L,2240L,2240L,1344L,448L,64256L,1024L,3584L,7168L,8960L,7168L,3584L,1024L,128L,512L,2304L,9216L,2150L,32256L,32256L,21504L,9216L,2304L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134308Inst : IEnumerable<long>
{
public static readonly long[] Value=A134308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134308.Bytes);
public long this[int i]=>Value[i];

public static A134308Inst Instance=new A134308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134309
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,32L,0L,0L,0L,0L,0L,0L,0L,64L,0L,0L,0L,0L,0L,0L,0L,0L,128L,0L,0L,0L,0L,0L,0L,0L,0L,0L,256L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,512L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1024L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2048L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134309Inst : IEnumerable<long>
{
public static readonly long[] Value=A134309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134309.Bytes);
public long this[int i]=>Value[i];

public static A134309Inst Instance=new A134309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134310
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,4L,5L,7L,8L,8L,9L,11L,15L,16L,16L,17L,19L,23L,31L,32L,32L,33L,35L,39L,47L,63L,64L,64L,65L,67L,71L,79L,95L,127L,128L,128L,129L,131L,135L,143L,159L,191L,255L,256L,256L,257L,259L,263L,271L,287L,319L,383L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134310Inst : IEnumerable<long>
{
public static readonly long[] Value=A134310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134310.Bytes);
public long this[int i]=>Value[i];

public static A134310Inst Instance=new A134310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134311
{
public static readonly long[] Value={ 1L,2L,7L,20L,51L,122L,281L,632L,1399L,3062L,6645L,14324L,30707L,65522L,139249L,294896L,622575L,1310702L,2752493L,5767148L,12058603L,25165802L,52428777L,109051880L,226492391L,469762022L,973078501L,2013265892L,4160749539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134311Inst : IEnumerable<long>
{
public static readonly long[] Value=A134311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134311.Bytes);
public long this[int i]=>Value[i];

public static A134311Inst Instance=new A134311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134360
{
public static readonly long[] Value={ 17L,20231L,83233L,3828719L,8519143L,39951841L,68916943L,76672279L,144326023L,721630111L,35915273857L,39392517233L,42845049953L,83709099119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134360Inst : IEnumerable<long>
{
public static readonly long[] Value=A134360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134360.Bytes);
public long this[int i]=>Value[i];

public static A134360Inst Instance=new A134360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134361
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,6L,8L,8L,9L,12L,12L,12L,16L,16L,16L,16L,18L,18L,24L,24L,24L,24L,24L,24L,27L,27L,27L,32L,32L,32L,32L,32L,36L,36L,36L,36L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,54L,54L,54L,54L,54L,54L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,72L,72L,72L,72L,72L,72L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134361Inst : IEnumerable<long>
{
public static readonly long[] Value=A134361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134361.Bytes);
public long this[int i]=>Value[i];

public static A134361Inst Instance=new A134361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134362
{
public static readonly BigInteger[] Value={ 1L,0L,0L,2L,30L,444L,7360L,138690L,2954364L,70469000L,1864204416L,54224221050L,1721080885480L,59217131089908L,2195990208122880L,87329597612123594L,3707783109757616400L,BigInteger.Parse("167411012044894728720"),BigInteger.Parse("8010372386879991018496"),BigInteger.Parse("404912918159552083622130") };
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
public class A134362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134362Inst Instance=new A134362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134363
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,0L,1L,1L,0L,0L,0L,0L,1L,3L,0L,2L,1L,-1L,1L,0L,0L,0L,0L,1L,2L,-1L,0L,0L,0L,0L,0L,1L,1L,-1L,0L,1L,0L,1L,0L,4L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,2L,-2L,1L,0L,1L,-1L,1L,1L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,-2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134363Inst : IEnumerable<long>
{
public static readonly long[] Value=A134363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134363.Bytes);
public long this[int i]=>Value[i];

public static A134363Inst Instance=new A134363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134364
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,2L,7L,8L,9L,30L,11L,12L,13L,42L,3L,16L,17L,6L,19L,180L,105L,66L,23L,72L,25L,78L,27L,252L,29L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134364Inst : IEnumerable<long>
{
public static readonly long[] Value=A134364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134364.Bytes);
public long this[int i]=>Value[i];

public static A134364Inst Instance=new A134364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134365
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,20L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134365Inst : IEnumerable<long>
{
public static readonly long[] Value=A134365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134365.Bytes);
public long this[int i]=>Value[i];

public static A134365Inst Instance=new A134365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134366
{
public static readonly BigInteger[] Value={ 1L,1L,2L,36L,13824L,207360000L,193491763200000L,BigInteger.Parse("16390160963076096000000"),BigInteger.Parse("173238200573946282828103680000000"),BigInteger.Parse("300679807141675805997423113304381849600000000") };
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
public class A134366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134366Inst Instance=new A134366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134367
{
public static readonly BigInteger[] Value={ 1L,1L,1L,6L,576L,1728000L,268738560000L,3252016064102400000L,BigInteger.Parse("4296582355504620109824000000"),BigInteger.Parse("828592942960967278432052230225920000000"),BigInteger.Parse("30067980714167580599742311330438184960000000000000000") };
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
public class A134367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134367Inst Instance=new A134367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134368
{
public static readonly BigInteger[] Value={ 1L,4L,13824L,268738560000L,BigInteger.Parse("106562062388507443200000"),BigInteger.Parse("2283380023591730815784976384000000000000"),BigInteger.Parse("5785737804304645733190746102656048717392091545600000000000000") };
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
public class A134368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134368Inst Instance=new A134368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134369
{
public static readonly BigInteger[] Value={ 1L,36L,1728000L,645241282560000L,BigInteger.Parse("6292383221978976013516800000"),BigInteger.Parse("4045146997974190235742848547815424000000000000"),BigInteger.Parse("363046466970952735968096996065196818096105852014637875200000000000000") };
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
public class A134369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134369Inst Instance=new A134369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134370
{
public static readonly BigInteger[] Value={ 1L,216L,207360000L,3252016064102400000L,BigInteger.Parse("2283380023591730815784976384000000"),BigInteger.Parse("161469323688736156802100136913438716723200000000000000"),BigInteger.Parse("226069790119463568269024813091549874237826753949687195333820416000000000000000") };
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
public class A134370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134370Inst Instance=new A134370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134371
{
public static readonly BigInteger[] Value={ 1L,2L,576L,373248000L,2642908293365760000L,BigInteger.Parse("629238322197897601351680000000000"),BigInteger.Parse("12078744213598964456884373878200091017216000000000000") };
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
public class A134371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134371Inst Instance=new A134371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134372
{
public static readonly BigInteger[] Value={ 1L,4L,576L,518400L,1625702400L,13168189440000L,229442532802560000L,BigInteger.Parse("7600054456551997440000"),BigInteger.Parse("437763136697395052544000000"),BigInteger.Parse("40990389067797283140009984000000"),BigInteger.Parse("5919012181389927685417441689600000000") };
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
public class A134372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134372Inst Instance=new A134372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134373
{
public static readonly BigInteger[] Value={ 1L,8L,13824L,373248000L,65548320768000L,BigInteger.Parse("47784725839872000000"),BigInteger.Parse("109903340320478724096000000"),BigInteger.Parse("662559760549147780765974528000000"),BigInteger.Parse("9159226129831418921308831875072000000000") };
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
public class A134373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134373Inst Instance=new A134373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134374
{
public static readonly BigInteger[] Value={ 1L,36L,14400L,25401600L,131681894400L,1593350922240000L,BigInteger.Parse("38775788043632640000"),BigInteger.Parse("1710012252724199424000000"),BigInteger.Parse("126513546505547170185216000000"),BigInteger.Parse("14797530453474819213543604224000000") };
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
public class A134374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134374Inst Instance=new A134374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134375
{
public static readonly BigInteger[] Value={ 1L,1L,16L,1296L,331776L,207360000L,268738560000L,645241282560000L,2642908293365760000L,BigInteger.Parse("17340121312772751360000"),BigInteger.Parse("173401213127727513600000000"),BigInteger.Parse("2538767161403058526617600000000"),BigInteger.Parse("52643875858853821607942553600000000"),BigInteger.Parse("1503561738404723998944447273369600000000") };
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
public class A134375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134375Inst Instance=new A134375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134392
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,8L,7L,4L,1L,15L,14L,10L,5L,1L,26L,25L,20L,13L,6L,142L,41L,35L,26L,16L,7L,164L,63L,56L,45L,32L,19L,8L,1L,93L,92L,84L,71L,55L,38L,22L,9L,1130L,129L,120L,105L,86L,65L,44L,25L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134392Inst : IEnumerable<long>
{
public static readonly long[] Value=A134392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134392.Bytes);
public long this[int i]=>Value[i];

public static A134392Inst Instance=new A134392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134393
{
public static readonly long[] Value={ 1L,3L,8L,20L,45L,91L,168L,288L,465L,715L,1056L,1508L,2093L,2835L,3760L,4896L,6273L,7923L,9880L,12180L,14861L,17963L,21528L,25600L,30225L,35451L,41328L,47908L,55245L,63395L,72416L,82368L,93313L,105315L,118440L,132756L,148333L,165243L,183560L,203360L,224721L,247723L,272448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134393Inst : IEnumerable<long>
{
public static readonly long[] Value=A134393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134393.Bytes);
public long this[int i]=>Value[i];

public static A134393Inst Instance=new A134393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134394
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,6L,4L,1L,5L,10L,9L,5L,1L,6L,15L,16L,12L,6L,1L,7L,21L,25L,22L,15L,7L,1L,8L,28L,36L,35L,28L,18L,8L,1L,9L,36L,49L,51L,45L,34L,21L,9L,1L,10L,45L,64L,70L,66L,55L,40L,24L,10L,1L,11L,55L,81L,92L,91L,81L,65L,46L,27L,11L,1L,12L,66L,100L,117L,120L,112L,96L,75L,52L,30L,12L,1L,13L,78L,121L,145L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134394Inst : IEnumerable<long>
{
public static readonly long[] Value=A134394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134394.Bytes);
public long this[int i]=>Value[i];

public static A134394Inst Instance=new A134394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134395
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,1L,8L,12L,6L,1L,16L,32L,23L,8L,1L,32L,80L,72L,37L,10L,1L,64L,192L,201L,132L,54L,12L,1L,128L,448L,522L,405L,216L,74L,14L,1L,256L,1024L,1291L,1128L,723L,328L,97L,16L,1L,512L,2304L,3084L,2941L,2154L,1191L,472L,123L,18L,1L,1024L,5120L,7181L,7316L,5920L,3788L,1850L,652L,152L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134395Inst : IEnumerable<long>
{
public static readonly long[] Value=A134395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134395.Bytes);
public long this[int i]=>Value[i];

public static A134395Inst Instance=new A134395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134396
{
public static readonly long[] Value={ 1L,3L,9L,27L,80L,232L,656L,1808L,4864L,12800L,33024L,83712L,208896L,514048L,1249280L,3002368L,7143424L,16842752L,39387136L,91422720L,210763776L,482869248L,1099956224L,2492465152L,5620367360L,12616466432L,28202500096L,62797119488L,139318001664L,308029685760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134396Inst : IEnumerable<long>
{
public static readonly long[] Value=A134396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134396.Bytes);
public long this[int i]=>Value[i];

public static A134396Inst Instance=new A134396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134397
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,1L,8L,12L,6L,1L,15L,30L,23L,8L,1L,26L,65L,68L,37L,10L,1L,42L,126L,168L,126L,54L,12L,1L,64L,224L,364L,350L,208L,74L,14L,1L,93L,372L,714L,840L,642L,318L,97L,16L,1L,130L,585L,1296L,1806L,1692L,1080L,460L,123L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134397Inst : IEnumerable<long>
{
public static readonly long[] Value=A134397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134397.Bytes);
public long this[int i]=>Value[i];

public static A134397Inst Instance=new A134397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134398
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,7L,10L,7L,1L,1L,9L,16L,16L,9L,1L,1L,11L,23L,29L,23L,11L,1L,1L,13L,31L,47L,47L,31L,13L,1L,1L,15L,40L,71L,86L,71L,40L,15L,1L,1L,17L,50L,102L,146L,146L,102L,50L,17L,1L,1L,19L,61L,141L,234L,277L,234L,141L,61L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134398Inst : IEnumerable<long>
{
public static readonly long[] Value=A134398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134398.Bytes);
public long this[int i]=>Value[i];

public static A134398Inst Instance=new A134398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134399
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,6L,3L,1L,4L,12L,12L,4L,1L,5L,20L,30L,20L,5L,1L,6L,30L,60L,60L,30L,6L,1L,7L,42L,105L,140L,105L,42L,7L,1L,8L,56L,168L,280L,280L,168L,56L,8L,1L,9L,72L,252L,504L,630L,504L,252L,72L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134399Inst : IEnumerable<long>
{
public static readonly long[] Value=A134399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134399.Bytes);
public long this[int i]=>Value[i];

public static A134399Inst Instance=new A134399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134400
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,3L,9L,9L,3L,4L,16L,24L,16L,4L,5L,25L,50L,50L,25L,5L,6L,36L,90L,120L,90L,36L,6L,7L,49L,147L,245L,245L,147L,49L,7L,8L,64L,224L,448L,560L,448L,224L,64L,8L,9L,81L,324L,756L,1134L,1134L,756L,324L,81L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134400Inst : IEnumerable<long>
{
public static readonly long[] Value=A134400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134400.Bytes);
public long this[int i]=>Value[i];

public static A134400Inst Instance=new A134400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134401
{
public static readonly long[] Value={ 1L,2L,8L,24L,64L,160L,384L,896L,2048L,4608L,10240L,22528L,49152L,106496L,229376L,491520L,1048576L,2228224L,4718592L,9961472L,20971520L,44040192L,92274688L,192937984L,402653184L,838860800L,1744830464L,3623878656L,7516192768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134401Inst : IEnumerable<long>
{
public static readonly long[] Value=A134401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134401.Bytes);
public long this[int i]=>Value[i];

public static A134401Inst Instance=new A134401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134402
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,0L,3L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134402Inst : IEnumerable<long>
{
public static readonly long[] Value=A134402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134402.Bytes);
public long this[int i]=>Value[i];

public static A134402Inst Instance=new A134402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134403
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,3L,4L,5L,4L,4L,5L,6L,7L,5L,5L,6L,7L,8L,9L,6L,6L,7L,8L,9L,10L,11L,7L,7L,8L,9L,10L,11L,12L,13L,8L,8L,9L,9L,10L,11L,12L,13L,14L,15L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134403Inst : IEnumerable<long>
{
public static readonly long[] Value=A134403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134403.Bytes);
public long this[int i]=>Value[i];

public static A134403Inst Instance=new A134403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134404
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,2L,1L,1L,0L,0L,1L,1L,2L,3L,2L,1L,1L,0L,0L,1L,1L,2L,3L,5L,3L,2L,1L,1L,0L,0L,1L,1L,2L,3L,5L,8L,5L,3L,2L,1L,1L,0L,0L,1L,1L,2L,3L,5L,8L,13L,8L,5L,3L,2L,1L,1L,0L,0L,1L,1L,2L,3L,5L,8L,13L,21L,13L,8L,5L,3L,2L,1L,1L,0L,0L,1L,1L,2L,3L,5L,8L,13L,21L,34L,21L,13L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134404Inst : IEnumerable<long>
{
public static readonly long[] Value=A134404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134404.Bytes);
public long this[int i]=>Value[i];

public static A134404Inst Instance=new A134404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134405
{
public static readonly long[] Value={ -1L,-1L,2L,0L,1L,-3L,4L,-2L,3L,-5L,6L,-4L,5L,-7L,8L,-6L,7L,-9L,10L,-8L,9L,-11L,12L,-10L,11L,-13L,14L,-12L,13L,-15L,16L,-14L,15L,-17L,18L,-16L,17L,-19L,20L,-18L,19L,-21L,22L,-20L,21L,-23L,24L,-22L,23L,-25L,26L,-24L,25L,-27L,28L,-26L,27L,-29L,30L,-28L,29L,-31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134405Inst : IEnumerable<long>
{
public static readonly long[] Value=A134405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134405.Bytes);
public long this[int i]=>Value[i];

public static A134405Inst Instance=new A134405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134406
{
public static readonly long[] Value={ 10L,26L,50L,65L,82L,122L,145L,170L,226L,290L,325L,362L,442L,485L,530L,626L,730L,785L,842L,901L,962L,1025L,1090L,1157L,1226L,1370L,1445L,1522L,1682L,1765L,1850L,1937L,2026L,2117L,2210L,2305L,2402L,2501L,2602L,2705L,2810L,3026L,3250L,3365L,3482L,3601L,3722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134406Inst : IEnumerable<long>
{
public static readonly long[] Value=A134406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134406.Bytes);
public long this[int i]=>Value[i];

public static A134406Inst Instance=new A134406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134407
{
public static readonly long[] Value={ 3L,5L,7L,8L,9L,11L,12L,13L,15L,17L,18L,19L,21L,22L,23L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134407Inst : IEnumerable<long>
{
public static readonly long[] Value=A134407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134407.Bytes);
public long this[int i]=>Value[i];

public static A134407Inst Instance=new A134407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134424
{
public static readonly long[] Value={ 0L,0L,1L,4L,21L,80L,316L,1152L,4186L,14812L,52020L,180616L,623338L,2138040L,7302035L,24842736L,84262609L,285052676L,962184359L,3241616628L,10903119167L,36619715860L,122837641530L,411588875136L,1377735161776L,4607695277512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134424Inst : IEnumerable<long>
{
public static readonly long[] Value=A134424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134424.Bytes);
public long this[int i]=>Value[i];

public static A134424Inst Instance=new A134424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134425
{
public static readonly long[] Value={ 1L,5L,27L,151L,861L,4969L,28911L,169187L,994329L,5862925L,34658691L,205305423L,1218183669L,7238062641L,43055682327L,256365292443L,1527728176305L,9110460044821L,54362600841963L,324557242893191L,1938584147698701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134425Inst : IEnumerable<long>
{
public static readonly long[] Value=A134425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134425.Bytes);
public long this[int i]=>Value[i];

public static A134425Inst Instance=new A134425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134426
{
public static readonly long[] Value={ 1L,3L,2L,11L,12L,4L,45L,62L,36L,8L,197L,312L,240L,96L,16L,903L,1570L,1440L,784L,240L,32L,4279L,7956L,8244L,5472L,2320L,576L,64L,20793L,40670L,46116L,35224L,18480L,6432L,1344L,128L,103049L,209712L,254912L,216384L,132320L,57600L,17024L,3072L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134426Inst : IEnumerable<long>
{
public static readonly long[] Value=A134426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134426.Bytes);
public long this[int i]=>Value[i];

public static A134426Inst Instance=new A134426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134427
{
public static readonly long[] Value={ 3L,5L,8L,9L,11L,12L,13L,15L,17L,19L,21L,22L,23L,25L,27L,28L,29L,30L,31L,33L,34L,35L,37L,39L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,58L,59L,60L,61L,62L,63L,64L,65L,67L,69L,71L,72L,73L,75L,76L,77L,78L,79L,80L,81L,83L,85L,86L,87L,88L,89L,91L,92L,95L,96L,97L,98L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134427Inst : IEnumerable<long>
{
public static readonly long[] Value=A134427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134427.Bytes);
public long this[int i]=>Value[i];

public static A134427Inst Instance=new A134427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134428
{
public static readonly long[] Value={ 23L,67L,1213L,3637L,4243L,7879L,9697L,102103L,108109L,126127L,138139L,150151L,156157L,180181L,192193L,270271L,276277L,312313L,330331L,378379L,420421L,432433L,438439L,456457L,522523L,540541L,546547L,576577L,600601L,606607L,612613L,618619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134428Inst : IEnumerable<long>
{
public static readonly long[] Value=A134428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134428.Bytes);
public long this[int i]=>Value[i];

public static A134428Inst Instance=new A134428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134429
{
public static readonly long[] Value={ 3L,-5L,3L,-5L,11L,-13L,11L,-13L,19L,-21L,19L,-21L,27L,-29L,27L,-29L,35L,-37L,35L,-37L,43L,-45L,43L,-45L,51L,-53L,51L,-53L,59L,-61L,59L,-61L,67L,-69L,67L,-69L,75L,-77L,75L,-77L,83L,-85L,83L,-85L,91L,-93L,91L,-93L,99L,-101L,99L,-101L,107L,-109L,107L,-109L,115L,-117L,115L,-117L,123L,-125L,123L,-125L,131L,-133L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134429Inst : IEnumerable<long>
{
public static readonly long[] Value=A134429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134429.Bytes);
public long this[int i]=>Value[i];

public static A134429Inst Instance=new A134429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134430
{
public static readonly long[] Value={ 1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L,-2L,1L,1L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134430Inst : IEnumerable<long>
{
public static readonly long[] Value=A134430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134430.Bytes);
public long this[int i]=>Value[i];

public static A134430Inst Instance=new A134430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134431
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,2L,6L,1L,1L,1L,3L,3L,4L,8L,8L,6L,6L,24L,1L,1L,1L,3L,3L,5L,10L,10L,14L,14L,36L,30L,30L,24L,24L,120L,1L,1L,1L,3L,3L,5L,11L,12L,16L,22L,44L,44L,66L,60L,78L,174L,168L,144L,144L,120L,120L,720L,1L,1L,1L,3L,3L,5L,11L,13L,18L,24L,52L,52L,80L,98L,120L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134431Inst : IEnumerable<long>
{
public static readonly long[] Value=A134431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134431.Bytes);
public long this[int i]=>Value[i];

public static A134431Inst Instance=new A134431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134432
{
public static readonly long[] Value={ 0L,1L,9L,66L,490L,3915L,34251L,328804L,3452436L,39456405L,488273005L,6510306726L,93097386174L,1421850988831L,23105078568495L,398118276872520L,7251440043035176L,139227648826275369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134432Inst : IEnumerable<long>
{
public static readonly long[] Value=A134432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134432.Bytes);
public long this[int i]=>Value[i];

public static A134432Inst Instance=new A134432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134433
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,5L,0L,2L,6L,16L,0L,6L,16L,33L,65L,0L,24L,60L,114L,196L,326L,0L,120L,288L,522L,848L,1305L,1957L,0L,720L,1680L,2952L,4632L,6850L,9786L,13700L,0L,5040L,11520L,19800L,30336L,43710L,60672L,82201L,109601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134433Inst : IEnumerable<long>
{
public static readonly long[] Value=A134433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134433.Bytes);
public long this[int i]=>Value[i];

public static A134433Inst Instance=new A134433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134434
{
public static readonly long[] Value={ 1L,1L,1L,4L,2L,4L,16L,4L,36L,72L,12L,36L,324L,324L,36L,576L,2592L,1728L,144L,576L,9216L,20736L,9216L,576L,14400L,115200L,172800L,57600L,2880L,14400L,360000L,1440000L,1440000L,360000L,14400L,518400L,6480000L,17280000L,12960000L,2592000L,86400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134434Inst : IEnumerable<long>
{
public static readonly long[] Value=A134434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134434.Bytes);
public long this[int i]=>Value[i];

public static A134434Inst Instance=new A134434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134435
{
public static readonly long[] Value={ 1L,2L,2L,4L,12L,12L,12L,72L,36L,144L,432L,144L,144L,1728L,2592L,576L,2880L,17280L,17280L,2880L,2880L,57600L,172800L,115200L,14400L,86400L,864000L,1728000L,864000L,86400L,86400L,2592000L,12960000L,17280000L,6480000L,518400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134435Inst : IEnumerable<long>
{
public static readonly long[] Value=A134435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134435.Bytes);
public long this[int i]=>Value[i];

public static A134435Inst Instance=new A134435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134436
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,7L,10L,6L,1L,16L,37L,42L,24L,1L,44L,125L,214L,216L,120L,1L,169L,465L,959L,1406L,1320L,720L,1L,895L,2199L,4469L,7880L,10476L,9360L,5040L,1L,5942L,13504L,24902L,44203L,70676L,87732L,75600L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134436Inst : IEnumerable<long>
{
public static readonly long[] Value=A134436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134436.Bytes);
public long this[int i]=>Value[i];

public static A134436Inst Instance=new A134436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134437
{
public static readonly long[] Value={ 0L,1L,7L,45L,312L,2400L,20520L,194040L,2016000L,22861440L,281232000L,3732220800L,53169177600L,809512704000L,13120332825600L,225573828480000L,4100866818048000L,78606921609216000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134437Inst : IEnumerable<long>
{
public static readonly long[] Value=A134437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134437.Bytes);
public long this[int i]=>Value[i];

public static A134437Inst Instance=new A134437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134438
{
public static readonly long[] Value={ 1L,1L,3L,10L,23L,62L,170L,441L,1173L,3127L,8266L,21937L,58234L,154390L,409573L,1086567L,2882021L,7645046L,20279829L,53794224L,142696606L,378522507L,1004078871L,2663452699L,7065162260L,18741269167L,49713692146L,131872134232L,349808216915L,927912454723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134438Inst : IEnumerable<long>
{
public static readonly long[] Value=A134438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134438.Bytes);
public long this[int i]=>Value[i];

public static A134438Inst Instance=new A134438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134439
{
public static readonly long[] Value={ 2536497816L,2536498167L,2536781649L,2536816497L,2573649816L,2573681649L,2578163649L,2578164936L,2581636497L,2581649367L,2581649736L,2581673649L,3625781649L,3625816497L,3649257816L,3649258167L,3649725816L,3649781625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134439Inst : IEnumerable<long>
{
public static readonly long[] Value=A134439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134439.Bytes);
public long this[int i]=>Value[i];

public static A134439Inst Instance=new A134439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134472
{
public static readonly long[] Value={ 1L,1L,2L,5L,7L,12L,103L,115L,678L,793L,1471L,2264L,28639L,145459L,174098L,319557L,1771883L,2091440L,26869163L,28960603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134472Inst : IEnumerable<long>
{
public static readonly long[] Value=A134472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134472.Bytes);
public long this[int i]=>Value[i];

public static A134472Inst Instance=new A134472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134473
{
public static readonly BigInteger[] Value={ 2L,10L,265L,186534L,39698716206L,BigInteger.Parse("9708281043219621795399"),BigInteger.Parse("485147416562376967927656482516055847985046599"),BigInteger.Parse("261312356099926248292437979417147998592741394591619008401746229884484893481820640113595606") };
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
public class A134473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134473Inst Instance=new A134473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134474
{
public static readonly BigInteger[] Value={ 1L,3L,32L,5969141L,19747269546873779L,BigInteger.Parse("63904014199087613123872206552133781224"),BigInteger.Parse("31002867396652810808343087989440323100946378567671674124759425791429267942552085359") };
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
public class A134474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134474Inst Instance=new A134474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134475
{
public static readonly BigInteger[] Value={ 2L,5L,53L,9886302L,32706124785400851L,BigInteger.Parse("105840083750427500921760353826840828183"),BigInteger.Parse("51348043200265516352304296553233166994035195487912155511387668758325728717007499617") };
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
public class A134475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134475Inst Instance=new A134475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134476
{
public static readonly BigInteger[] Value={ 2L,20L,2650L,32954340L,1308244991416034040L,BigInteger.Parse("317520251251282502765281061480522484549"),BigInteger.Parse("51348043200265516352304296553233166994035195487912155511387668758325728717007499617") };
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
public class A134476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134476Inst Instance=new A134476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134477
{
public static readonly BigInteger[] Value={ 3L,33L,4389L,54580141L,2166761528097045187L,BigInteger.Parse("525888246710053092756770266260096718495"),BigInteger.Parse("85044441430633398942448813011607889701451771024726384367542315571820259496552289000") };
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
public class A134477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134477Inst Instance=new A134477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134478
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,3L,4L,5L,6L,4L,5L,6L,7L,8L,5L,6L,7L,8L,9L,10L,6L,7L,8L,9L,10L,11L,12L,7L,8L,9L,10L,11L,12L,13L,14L,8L,9L,10L,11L,12L,13L,14L,15L,16L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134478Inst : IEnumerable<long>
{
public static readonly long[] Value=A134478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134478.Bytes);
public long this[int i]=>Value[i];

public static A134478Inst Instance=new A134478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134479
{
public static readonly long[] Value={ 1L,3L,9L,18L,30L,45L,63L,84L,108L,135L,165L,198L,234L,273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134479Inst : IEnumerable<long>
{
public static readonly long[] Value=A134479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134479.Bytes);
public long this[int i]=>Value[i];

public static A134479Inst Instance=new A134479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134480
{
public static readonly long[] Value={ 1L,3L,2L,9L,7L,4L,18L,15L,11L,6L,30L,26L,21L,15L,8L,45L,40L,34L,27L,19L,10L,63L,57L,50L,42L,33L,23L,12L,84L,77L,69L,60L,50L,39L,27L,14L,108L,100L,91L,81L,70L,58L,45L,31L,16L,135L,126L,116L,105L,93L,80L,66L,51L,35L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134480Inst : IEnumerable<long>
{
public static readonly long[] Value=A134480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134480.Bytes);
public long this[int i]=>Value[i];

public static A134480Inst Instance=new A134480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134481
{
public static readonly long[] Value={ 1L,5L,20L,50L,100L,175L,280L,420L,600L,825L,1100L,1430L,1820L,2275L,2800L,3400L,4080L,4845L,5700L,6650L,7700L,8855L,10120L,11500L,13000L,14625L,16380L,18270L,20300L,22475L,24800L,27280L,29920L,32725L,35700L,38850L,42180L,45695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134481Inst : IEnumerable<long>
{
public static readonly long[] Value=A134481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134481.Bytes);
public long this[int i]=>Value[i];

public static A134481Inst Instance=new A134481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134482
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,4L,5L,6L,5L,5L,6L,7L,8L,6L,6L,7L,8L,9L,10L,7L,7L,8L,9L,10L,11L,12L,8L,8L,9L,10L,11L,12L,13L,14L,9L,9L,10L,11L,12L,13L,14L,15L,16L,10L,10L,11L,12L,13L,14L,15L,16L,17L,18L,11L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,12L,12L,13L,14L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134482Inst : IEnumerable<long>
{
public static readonly long[] Value=A134482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134482.Bytes);
public long this[int i]=>Value[i];

public static A134482Inst Instance=new A134482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134483
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,7L,8L,9L,10L,9L,10L,11L,12L,13L,11L,12L,13L,14L,15L,16L,13L,14L,15L,16L,17L,18L,19L,15L,16L,17L,18L,19L,20L,21L,22L,17L,18L,19L,20L,21L,22L,23L,24L,25L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134483Inst : IEnumerable<long>
{
public static readonly long[] Value=A134483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134483.Bytes);
public long this[int i]=>Value[i];

public static A134483Inst Instance=new A134483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134484
{
public static readonly long[] Value={ 1L,1L,1L,4L,8L,1L,64L,192L,48L,1L,4096L,16384L,6144L,256L,1L,1048576L,5242880L,2621440L,163840L,1280L,1L,1073741824L,6442450944L,4026531840L,335544320L,3932160L,6144L,1L,4398046511104L,30786325577728L,23089744183296L,2405181685760L,37580963840L,88080384L,28672L,1L,72057594037927936L,576460752303423488L,504403158265495552L,63050394783186944L,1231453023109120L,3848290697216L,1879048192L,131072L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134484Inst : IEnumerable<long>
{
public static readonly long[] Value=A134484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134484.Bytes);
public long this[int i]=>Value[i];

public static A134484Inst Instance=new A134484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134485
{
public static readonly BigInteger[] Value={ 1L,2L,13L,305L,26881L,9078017L,11882207233L,60716967030785L,1217207202583019521L,BigInteger.Parse("96068905115897742032897"),BigInteger.Parse("29929069804525281689001787393"),BigInteger.Parse("36877162272858587692985585499111425") };
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
public class A134485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134485Inst Instance=new A134485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134486
{
public static readonly long[] Value={ 1L,2L,5L,2L,3L,2L,13L,23L,37L,167L,557L,383L,4597L,29881L,167L,179L,191L,29L,523L,4969L,211L,277L,53L,61L,293L,37L,107L,17L,53L,769L,23071L,661L,641L,1511L,137L,109L,157L,83L,631L,107L,1427L,14627L,122867L,103L,1511L,191L,101L,1187L,251L,41L,293L,467L,1619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134486Inst : IEnumerable<long>
{
public static readonly long[] Value=A134486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134486.Bytes);
public long this[int i]=>Value[i];

public static A134486Inst Instance=new A134486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134487
{
public static readonly long[] Value={ 1L,3L,5L,7L,3L,19L,67L,179L,31L,311L,59L,709L,419L,5867L,557L,2971L,61L,157L,373L,829L,1741L,38303L,2381L,1039L,191L,4967L,13411L,375509L,418837L,966547L,14981479L,16127L,16631L,149L,163L,5869L,15511L,829L,137L,29L,17L,13L,7L,103L,61L,401L,31L,1489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134487Inst : IEnumerable<long>
{
public static readonly long[] Value=A134487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134487.Bytes);
public long this[int i]=>Value[i];

public static A134487Inst Instance=new A134487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134536
{
public static readonly long[] Value={ 2L,3L,4L,3L,2L,3L,2L,1L,4L,2L,2L,3L,1L,6L,5L,2L,1L,4L,5L,1L,3L,1L,5L,4L,2L,1L,4L,6L,1L,3L,2L,8L,7L,1L,1L,2L,2L,1L,2L,1L,2L,5L,1L,7L,1L,1L,1L,4L,1L,7L,9L,2L,3L,1L,1L,3L,10L,9L,1L,2L,5L,2L,3L,8L,10L,1L,1L,3L,2L,1L,1L,1L,9L,4L,3L,2L,3L,1L,1L,1L,1L,4L,2L,1L,2L,1L,2L,1L,12L,11L,2L,1L,2L,1L,2L,2L,1L,10L,11L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134536Inst : IEnumerable<long>
{
public static readonly long[] Value=A134536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134536.Bytes);
public long this[int i]=>Value[i];

public static A134536Inst Instance=new A134536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134537
{
public static readonly long[] Value={ 9L,36L,100L,144L,324L,1024L,1600L,1764L,2304L,2916L,7056L,12996L,15876L,16900L,19044L,22500L,28900L,35344L,36864L,39204L,42436L,45796L,49284L,51984L,53824L,56644L,63504L,97344L,139876L,153664L,166464L,311364L,451584L,484416L,521284L,544644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134537Inst : IEnumerable<long>
{
public static readonly long[] Value=A134537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134537.Bytes);
public long this[int i]=>Value[i];

public static A134537Inst Instance=new A134537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134538
{
public static readonly long[] Value={ 4L,19L,44L,79L,124L,179L,244L,319L,404L,499L,604L,719L,844L,979L,1124L,1279L,1444L,1619L,1804L,1999L,2204L,2419L,2644L,2879L,3124L,3379L,3644L,3919L,4204L,4499L,4804L,5119L,5444L,5779L,6124L,6479L,6844L,7219L,7604L,7999L,8404L,8819L,9244L,9679L,10124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134538Inst : IEnumerable<long>
{
public static readonly long[] Value=A134538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134538.Bytes);
public long this[int i]=>Value[i];

public static A134538Inst Instance=new A134538Inst();

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