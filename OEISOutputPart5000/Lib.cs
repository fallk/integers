using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A184915
{
public static readonly long[] Value={ 1L,5L,8L,12L,15L,18L,22L,25L,27L,31L,35L,38L,41L,45L,48L,51L,54L,57L,61L,65L,67L,71L,75L,77L,80L,84L,87L,91L,94L,97L,100L,104L,107L,110L,114L,117L,121L,124L,126L,130L,134L,136L,140L,144L,147L,150L,153L,156L,160L,162L,166L,170L,173L,176L,179L,182L,186L,189L,192L,196L,200L,201L,205L,209L,212L,216L,219L,222L,226L,229L,231L,235L,239L,242L,245L,249L,252L,255L,258L,261L,265L,269L,271L,275L,278L,281L,284L,288L,291L,295L,298L,301L,304L,308L,310L,314L,317L,321L,325L,327L,330L,334L,337L,340L,344L,347L,351L,354L,356L,360L,364L,366L,370L,374L,377L,379L,383L,386L,390L,393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184915Inst : IEnumerable<long>
{
public static readonly long[] Value=A184915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184915.Bytes);
public long this[int i]=>Value[i];

public static A184915Inst Instance=new A184915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184914
{
public static readonly long[] Value={ 2L,6L,10L,14L,17L,21L,26L,29L,32L,36L,40L,44L,47L,52L,56L,59L,62L,66L,70L,74L,78L,82L,86L,89L,92L,96L,101L,105L,108L,112L,115L,119L,123L,127L,131L,135L,139L,142L,145L,149L,154L,157L,161L,165L,169L,172L,175L,180L,184L,187L,191L,195L,199L,203L,206L,210L,214L,217L,221L,225L,230L,232L,236L,240L,244L,248L,251L,256L,260L,263L,266L,270L,274L,279L,282L,286L,290L,293L,296L,300L,305L,309L,312L,316L,319L,323L,326L,331L,335L,339L,342L,346L,349L,353L,357L,361L,365L,369L,373L,376L,380L,384L,388L,391L,395L,399L,403L,407L,410L,414L,418L,421L,425L,429L,434L,436L,440L,444L,448L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184914Inst : IEnumerable<long>
{
public static readonly long[] Value=A184914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184914.Bytes);
public long this[int i]=>Value[i];

public static A184914Inst Instance=new A184914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184913
{
public static readonly long[] Value={ 3L,7L,11L,16L,20L,24L,30L,33L,37L,42L,46L,50L,55L,60L,64L,68L,72L,76L,81L,85L,90L,95L,99L,102L,106L,111L,116L,120L,125L,129L,132L,137L,141L,146L,151L,155L,159L,164L,167L,171L,177L,181L,185L,190L,194L,198L,202L,207L,211L,215L,220L,224L,228L,234L,237L,241L,246L,250L,254L,259L,264L,267L,272L,276L,280L,285L,289L,294L,299L,302L,306L,311L,315L,320L,324L,329L,333L,336L,341L,345L,350L,355L,359L,363L,367L,371L,375L,381L,385L,389L,394L,398L,401L,406L,411L,415L,419L,424L,428L,432L,437L,441L,445L,450L,454L,458L,463L,468L,471L,476L,480L,484L,489L,493L,498L,502L,506L,510L,515L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184913Inst : IEnumerable<long>
{
public static readonly long[] Value=A184913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184913.Bytes);
public long this[int i]=>Value[i];

public static A184913Inst Instance=new A184913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184912
{
public static readonly long[] Value={ 4L,9L,13L,19L,23L,28L,34L,39L,43L,49L,53L,58L,63L,69L,73L,79L,83L,88L,93L,98L,103L,109L,113L,118L,122L,128L,133L,138L,143L,148L,152L,158L,163L,168L,174L,178L,183L,188L,193L,197L,204L,208L,213L,218L,223L,227L,233L,238L,243L,247L,253L,257L,262L,268L,273L,277L,283L,287L,292L,297L,303L,307L,313L,318L,322L,328L,332L,338L,343L,348L,352L,358L,362L,368L,372L,378L,382L,387L,392L,397L,402L,408L,412L,417L,422L,427L,431L,438L,442L,447L,452L,457L,461L,467L,472L,477L,482L,487L,492L,496L,503L,507L,512L,517L,522L,526L,532L,537L,542L,547L,552L,556L,562L,566L,572L,577L,582L,586L,592L,596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184912Inst : IEnumerable<long>
{
public static readonly long[] Value=A184912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184912.Bytes);
public long this[int i]=>Value[i];

public static A184912Inst Instance=new A184912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184911
{
public static readonly long[] Value={ 1L,4L,7L,10L,12L,15L,18L,20L,22L,25L,28L,31L,33L,36L,39L,41L,43L,46L,49L,52L,54L,57L,60L,62L,64L,67L,70L,73L,75L,78L,80L,83L,86L,88L,91L,94L,97L,99L,101L,104L,107L,109L,112L,115L,118L,120L,122L,125L,128L,130L,133L,136L,139L,141L,143L,146L,149L,151L,154L,157L,160L,161L,164L,167L,170L,173L,175L,178L,181L,183L,185L,188L,191L,194L,196L,199L,202L,204L,206L,209L,212L,215L,217L,220L,222L,225L,227L,230L,233L,236L,238L,241L,243L,246L,248L,251L,254L,257L,260L,262L,264L,267L,270L,272L,275L,278L,281L,283L,285L,288L,291L,293L,296L,299L,302L,303L,306L,309L,312L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184911Inst : IEnumerable<long>
{
public static readonly long[] Value=A184911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184911.Bytes);
public long this[int i]=>Value[i];

public static A184911Inst Instance=new A184911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184910
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,21L,23L,26L,29L,32L,35L,38L,42L,45L,47L,50L,53L,56L,59L,63L,66L,69L,71L,74L,77L,81L,84L,87L,90L,92L,95L,98L,102L,105L,108L,111L,114L,116L,119L,123L,126L,129L,132L,135L,138L,140L,144L,147L,150L,153L,156L,159L,163L,165L,168L,171L,174L,177L,180L,184L,186L,189L,192L,195L,198L,201L,205L,208L,210L,213L,216L,219L,223L,226L,229L,232L,234L,237L,240L,244L,247L,250L,253L,255L,258L,261L,265L,268L,271L,274L,277L,279L,282L,286L,289L,292L,295L,298L,301L,304L,307L,310L,313L,316L,319L,322L,326L,328L,331L,334L,337L,340L,343L,347L,349L,352L,355L,358L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184910Inst : IEnumerable<long>
{
public static readonly long[] Value=A184910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184910.Bytes);
public long this[int i]=>Value[i];

public static A184910Inst Instance=new A184910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184909
{
public static readonly long[] Value={ 3L,6L,9L,13L,16L,19L,24L,27L,30L,34L,37L,40L,44L,48L,51L,55L,58L,61L,65L,68L,72L,76L,79L,82L,85L,89L,93L,96L,100L,103L,106L,110L,113L,117L,121L,124L,127L,131L,134L,137L,142L,145L,148L,152L,155L,158L,162L,166L,169L,172L,176L,179L,182L,187L,190L,193L,197L,200L,203L,207L,211L,214L,218L,221L,224L,228L,231L,235L,239L,242L,245L,249L,252L,256L,259L,263L,266L,269L,273L,276L,280L,284L,287L,290L,294L,297L,300L,305L,308L,311L,315L,318L,321L,325L,329L,332L,335L,339L,342L,345L,350L,353L,356L,360L,363L,366L,370L,374L,377L,381L,384L,387L,391L,394L,398L,402L,405L,408L,412L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184909Inst : IEnumerable<long>
{
public static readonly long[] Value=A184909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184909.Bytes);
public long this[int i]=>Value[i];

public static A184909Inst Instance=new A184909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184908
{
public static readonly long[] Value={ 1L,7L,5L,0L,7L,5L,0L,7L,10L,0L,6L,3L,0L,5L,9L,0L,7L,7L,0L,7L,9L,0L,5L,6L,0L,6L,7L,0L,10L,7L,0L,4L,5L,0L,11L,7L,0L,10L,9L,0L,9L,4L,0L,4L,8L,0L,2L,6L,0L,9L,5L,0L,10L,9L,0L,8L,6L,0L,4L,3L,0L,4L,11L,0L,9L,3L,0L,5L,8L,0L,6L,3L,0L,11L,7L,0L,6L,8L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184908Inst : IEnumerable<long>
{
public static readonly long[] Value=A184908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184908.Bytes);
public long this[int i]=>Value[i];

public static A184908Inst Instance=new A184908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184859
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,19L,23L,29L,31L,37L,47L,53L,61L,71L,73L,79L,83L,89L,97L,107L,113L,131L,139L,149L,157L,163L,167L,173L,181L,191L,193L,197L,199L,223L,227L,233L,239L,241L,251L,257L,269L,277L,283L,293L,307L,311L,317L,337L,349L,353L,359L,367L,379L,383L,401L,409L,419L,421L,443L,461L,463L,479L,487L,503L,521L,523L,547L,557L,563L,571L,587L,599L,607L,613L,631L,641L,647L,659L,673L,683L,691L,701L,709L,733L,739L,743L,751L,757L,769L,773L,809L,811L,827L,853L,859L,877L,883L,887L,911L,919L,929L,937L,947L,953L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184859Inst : IEnumerable<long>
{
public static readonly long[] Value=A184859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184859.Bytes);
public long this[int i]=>Value[i];

public static A184859Inst Instance=new A184859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184858
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,11L,12L,13L,15L,16L,18L,20L,22L,23L,26L,28L,29L,30L,32L,33L,34L,36L,39L,42L,43L,44L,45L,46L,47L,48L,49L,50L,54L,55L,60L,61L,64L,65L,66L,70L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,92L,93L,94L,95L,96L,97L,99L,100L,101L,103L,104L,105L,106L,108L,109L,110L,111L,112L,115L,117L,118L,119L,120L,121L,122L,123L,124L,125L,128L,129L,132L,133L,134L,137L,138L,139L,140L,141L,142L,144L,148L,149L,150L,151L,152L,154L,156L,157L,160L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184858Inst : IEnumerable<long>
{
public static readonly long[] Value=A184858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184858.Bytes);
public long this[int i]=>Value[i];

public static A184858Inst Instance=new A184858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184857
{
public static readonly long[] Value={ 2L,5L,7L,11L,15L,20L,24L,26L,30L,34L,39L,45L,50L,53L,64L,68L,69L,72L,83L,87L,88L,96L,106L,115L,121L,122L,125L,126L,134L,141L,144L,145L,159L,163L,178L,179L,197L,198L,201L,221L,227L,232L,236L,240L,246L,251L,254L,259L,265L,273L,274L,278L,284L,289L,292L,293L,303L,308L,311L,316L,318L,322L,331L,342L,346L,356L,360L,361L,365L,375L,379L,380L,384L,388L,399L,407L,409L,413L,417L,418L,426L,428L,432L,437L,455L,460L,470L,475L,479L,489L,498L,504L,512L,513L,519L,523L,542L,543L,546L,555L,557L,561L,576L,581L,595L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184857Inst : IEnumerable<long>
{
public static readonly long[] Value=A184857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184857.Bytes);
public long this[int i]=>Value[i];

public static A184857Inst Instance=new A184857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184856
{
public static readonly long[] Value={ 3L,7L,11L,17L,23L,31L,37L,41L,47L,53L,61L,71L,79L,83L,101L,107L,109L,113L,131L,137L,139L,151L,167L,181L,191L,193L,197L,199L,211L,223L,227L,229L,251L,257L,281L,283L,311L,313L,317L,349L,359L,367L,373L,379L,389L,397L,401L,409L,419L,431L,433L,439L,449L,457L,461L,463L,479L,487L,491L,499L,503L,509L,523L,541L,547L,563L,569L,571L,577L,593L,599L,601L,607L,613L,631L,643L,647L,653L,659L,661L,673L,677L,683L,691L,719L,727L,743L,751L,757L,773L,787L,797L,809L,811L,821L,827L,857L,859L,863L,877L,881L,887L,911L,919L,941L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184856Inst : IEnumerable<long>
{
public static readonly long[] Value=A184856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184856.Bytes);
public long this[int i]=>Value[i];

public static A184856Inst Instance=new A184856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184855
{
public static readonly long[] Value={ 1L,3L,6L,8L,10L,14L,17L,19L,21L,24L,25L,27L,31L,35L,37L,38L,40L,41L,51L,52L,53L,56L,57L,58L,59L,62L,63L,67L,68L,69L,71L,76L,82L,86L,91L,98L,102L,107L,113L,114L,116L,126L,127L,130L,131L,135L,136L,143L,145L,146L,147L,153L,155L,158L,159L,163L,168L,170L,171L,176L,177L,181L,185L,186L,187L,192L,193L,195L,196L,197L,199L,200L,202L,206L,208L,210L,214L,216L,218L,219L,222L,225L,226L,230L,232L,234L,237L,240L,243L,244L,248L,249L,252L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184855Inst : IEnumerable<long>
{
public static readonly long[] Value=A184855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184855.Bytes);
public long this[int i]=>Value[i];

public static A184855Inst Instance=new A184855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184854
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,5L,3L,3L,2L,8L,1L,4L,9L,0L,9L,0L,6L,4L,7L,9L,4L,6L,8L,3L,7L,2L,2L,2L,8L,9L,2L,3L,7L,0L,6L,5L,3L,0L,2L,9L,5L,9L,8L,5L,3L,7L,7L,4L,1L,6L,6L,7L,6L,4L,3L,0L,3L,8L,4L,0L,2L,0L,8L,7L,1L,4L,3L,5L,3L,0L,0L,9L,0L,2L,4L,0L,7L,1L,0L,6L,9L,1L,7L,5L,1L,9L,8L,4L,9L,6L,0L,5L,1L,0L,6L,0L,9L,0L,2L,8L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184854Inst : IEnumerable<long>
{
public static readonly long[] Value=A184854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184854.Bytes);
public long this[int i]=>Value[i];

public static A184854Inst Instance=new A184854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184853
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,4L,3L,9L,4L,7L,7L,4L,4L,1L,8L,0L,8L,8L,0L,4L,8L,1L,7L,7L,9L,1L,4L,6L,2L,3L,7L,9L,8L,2L,2L,7L,3L,9L,0L,6L,2L,0L,7L,8L,9L,5L,3L,8L,5L,9L,4L,4L,4L,1L,6L,2L,9L,7L,5L,9L,2L,9L,1L,9L,0L,4L,8L,4L,3L,1L,5L,0L,1L,0L,3L,3L,4L,4L,4L,6L,1L,5L,2L,8L,3L,7L,0L,9L,5L,7L,5L,4L,3L,8L,9L,3L,4L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184853Inst : IEnumerable<long>
{
public static readonly long[] Value=A184853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184853.Bytes);
public long this[int i]=>Value[i];

public static A184853Inst Instance=new A184853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184852
{
public static readonly long[] Value={ 6L,25L,45L,113L,183L,388L,476L,810L,1300L,1671L,2367L,3609L,3980L,5198L,7471L,8576L,10419L,14992L,15210L,18919L,25028L,27560L,31199L,41822L,42799L,50603L,65284L,66683L,74594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184852Inst : IEnumerable<long>
{
public static readonly long[] Value=A184852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184852.Bytes);
public long this[int i]=>Value[i];

public static A184852Inst Instance=new A184852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184851
{
public static readonly long[] Value={ 5L,13L,17L,33L,33L,76L,76L,137L,138L,196L,240L,398L,287L,495L,460L,765L,720L,968L,957L,1160L,1261L,1706L,1629L,2183L,1777L,2655L,2562L,3371L,3159L,3228L,3888L,4875L,4450L,5435L,4462L,6573L,6179L,7659L,6664L,7520L,8348L,9781L,9377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184851Inst : IEnumerable<long>
{
public static readonly long[] Value=A184851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184851.Bytes);
public long this[int i]=>Value[i];

public static A184851Inst Instance=new A184851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184850
{
public static readonly long[] Value={ 4L,7L,10L,13L,8L,16L,19L,34L,54L,22L,31L,55L,55L,92L,47L,75L,92L,126L,117L,73L,121L,124L,149L,201L,83L,198L,256L,261L,250L,162L,265L,316L,324L,333L,194L,404L,336L,396L,551L,244L,401L,581L,466L,540L,372L,553L,604L,669L,634L,326L,785L,783L,764L,951L,408L,845L,951L,829L,908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184850Inst : IEnumerable<long>
{
public static readonly long[] Value=A184850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184850.Bytes);
public long this[int i]=>Value[i];

public static A184850Inst Instance=new A184850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184849
{
public static readonly long[] Value={ 3L,3L,6L,3L,3L,6L,3L,3L,15L,3L,6L,6L,6L,3L,8L,3L,10L,15L,15L,3L,14L,6L,9L,6L,11L,6L,27L,3L,10L,8L,17L,3L,22L,10L,22L,15L,15L,15L,28L,3L,22L,14L,20L,6L,45L,9L,21L,6L,17L,11L,37L,6L,15L,27L,15L,3L,37L,10L,29L,8L,18L,17L,49L,3L,22L,22L,25L,10L,39L,22L,26L,15L,28L,15L,45L,15L,33L,28L,25L,3L,60L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184849Inst : IEnumerable<long>
{
public static readonly long[] Value=A184849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184849.Bytes);
public long this[int i]=>Value[i];

public static A184849Inst Instance=new A184849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184848
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,3L,1L,1L,2L,2L,3L,4L,1L,1L,2L,2L,6L,7L,5L,1L,1L,2L,2L,3L,10L,13L,6L,1L,1L,2L,2L,3L,13L,17L,25L,8L,1L,1L,2L,2L,6L,8L,33L,45L,54L,10L,1L,1L,2L,2L,3L,16L,33L,113L,153L,122L,12L,1L,1L,2L,2L,3L,19L,76L,183L,433L,561L,253L,15L,1L,1L,2L,2L,15L,34L,76L,388L,1136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184848Inst : IEnumerable<long>
{
public static readonly long[] Value=A184848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184848.Bytes);
public long this[int i]=>Value[i];

public static A184848Inst Instance=new A184848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184847
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,34L,137L,810L,6367L,66564L,448091L,2895361L,21050917L,147976680L,1131808944L,7785436438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184847Inst : IEnumerable<long>
{
public static readonly long[] Value=A184847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184847.Bytes);
public long this[int i]=>Value[i];

public static A184847Inst Instance=new A184847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184846
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,19L,76L,476L,3627L,30780L,191122L,1143877L,7374982L,46220204L,305794362L,1874323984L,11217509631L,68193471721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184846Inst : IEnumerable<long>
{
public static readonly long[] Value=A184846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184846.Bytes);
public long this[int i]=>Value[i];

public static A184846Inst Instance=new A184846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184845
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,16L,76L,388L,2152L,13887L,76684L,402552L,2246308L,12383123L,70009515L,374562273L,1971133886L,10420025889L,54379325900L,283582422717L,1451108174772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184845Inst : IEnumerable<long>
{
public static readonly long[] Value=A184845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184845.Bytes);
public long this[int i]=>Value[i];

public static A184845Inst Instance=new A184845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184844
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,8L,33L,183L,1136L,5506L,24282L,117926L,569254L,2774987L,13031733L,58087202L,261738519L,1186540784L,5337900539L,23545839048L,102301482654L,442231758905L,1901120041905L,8113101102305L,34276506444563L,143502353379187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184844Inst : IEnumerable<long>
{
public static readonly long[] Value=A184844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184844.Bytes);
public long this[int i]=>Value[i];

public static A184844Inst Instance=new A184844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184779
{
public static readonly long[] Value={ 2L,6L,7L,9L,12L,15L,18L,20L,29L,34L,37L,38L,39L,43L,47L,57L,61L,62L,63L,66L,67L,77L,80L,81L,84L,86L,88L,91L,94L,103L,106L,107L,111L,113L,115L,116L,129L,133L,134L,135L,140L,145L,146L,147L,150L,151L,154L,156L,166L,173L,177L,178L,186L,188L,193L,194L,197L,201L,204L,205L,208L,211L,214L,216L,222L,224L,225L,227L,229L,230L,233L,234L,243L,245L,247L,251L,252L,257L,263L,264L,271L,278L,281L,283L,285L,288L,291L,296L,298L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184779Inst : IEnumerable<long>
{
public static readonly long[] Value=A184779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184779.Bytes);
public long this[int i]=>Value[i];

public static A184779Inst Instance=new A184779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184778
{
public static readonly long[] Value={ 1L,4L,5L,7L,11L,14L,18L,21L,32L,41L,46L,48L,49L,56L,62L,79L,83L,86L,90L,93L,97L,114L,120L,123L,127L,130L,134L,137L,144L,165L,169L,172L,178L,181L,185L,188L,213L,220L,222L,223L,237L,243L,246L,250L,253L,257L,260L,267L,288L,302L,308L,311L,325L,329L,343L,346L,352L,360L,366L,369L,376L,380L,383L,387L,410L,417L,418L,420L,424L,425L,431L,434L,452L,455L,459L,468L,469L,475L,489L,496L,510L,524L,534L,541L,547L,550L,557L,571L,578L,582L,584L,585L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184778Inst : IEnumerable<long>
{
public static readonly long[] Value=A184778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184778.Bytes);
public long this[int i]=>Value[i];

public static A184778Inst Instance=new A184778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184777
{
public static readonly long[] Value={ 3L,13L,17L,23L,37L,47L,61L,71L,109L,139L,157L,163L,167L,191L,211L,269L,283L,293L,307L,317L,331L,389L,409L,419L,433L,443L,457L,467L,491L,563L,577L,587L,607L,617L,631L,641L,727L,751L,757L,761L,809L,829L,839L,853L,863L,877L,887L,911L,983L,1031L,1051L,1061L,1109L,1123L,1171L,1181L,1201L,1229L,1249L,1259L,1283L,1297L,1307L,1321L,1399L,1423L,1427L,1433L,1447L,1451L,1471L,1481L,1543L,1553L,1567L,1597L,1601L,1621L,1669L,1693L,1741L,1789L,1823L,1847L,1867L,1877L,1901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184777Inst : IEnumerable<long>
{
public static readonly long[] Value=A184777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184777.Bytes);
public long this[int i]=>Value[i];

public static A184777Inst Instance=new A184777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184776
{
public static readonly long[] Value={ 1L,3L,4L,5L,8L,10L,11L,13L,14L,16L,17L,19L,21L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,35L,36L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,64L,65L,68L,69L,70L,71L,72L,73L,74L,75L,76L,78L,79L,82L,83L,85L,87L,89L,90L,92L,93L,95L,96L,97L,98L,99L,100L,101L,102L,104L,105L,108L,109L,110L,112L,114L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,128L,130L,131L,132L,136L,137L,138L,139L,141L,142L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184776Inst : IEnumerable<long>
{
public static readonly long[] Value=A184776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184776.Bytes);
public long this[int i]=>Value[i];

public static A184776Inst Instance=new A184776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184775
{
public static readonly long[] Value={ 2L,4L,5L,8L,14L,21L,22L,29L,31L,38L,42L,48L,52L,56L,59L,63L,69L,72L,73L,76L,80L,90L,93L,97L,106L,107L,123L,127L,128L,137L,140L,141L,158L,161L,162L,165L,169L,171L,178L,182L,186L,192L,196L,199L,220L,222L,239L,246L,247L,250L,254L,260L,264L,268L,271L,281L,284L,298L,305L,311L,318L,326L,328L,339L,345L,353L,356L,360L,369L,370L,383L,387L,394L,403L,404L,420L,424L,425L,434L,438L,455L,458L,462L,466L,468L,476L,479L,483L,489L,496L,502L,509L,519L,523L,526L,544L,547L,557L,564L,574L,581L,582L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184775Inst : IEnumerable<long>
{
public static readonly long[] Value=A184775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184775.Bytes);
public long this[int i]=>Value[i];

public static A184775Inst Instance=new A184775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184774
{
public static readonly long[] Value={ 2L,5L,7L,11L,19L,29L,31L,41L,43L,53L,59L,67L,73L,79L,83L,89L,97L,101L,103L,107L,113L,127L,131L,137L,149L,151L,173L,179L,181L,193L,197L,199L,223L,227L,229L,233L,239L,241L,251L,257L,263L,271L,277L,281L,311L,313L,337L,347L,349L,353L,359L,367L,373L,379L,383L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184774Inst : IEnumerable<long>
{
public static readonly long[] Value=A184774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184774.Bytes);
public long this[int i]=>Value[i];

public static A184774Inst Instance=new A184774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184773
{
public static readonly long[] Value={ 64L,424L,424L,2248L,8272L,2248L,13096L,108496L,108496L,13096L,73288L,1792144L,1967440L,1792144L,73288L,417256L,27993232L,62051344L,62051344L,27993232L,417256L,2358280L,454774672L,1444491280L,4975179472L,1444491280L,454774672L,2358280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184773Inst : IEnumerable<long>
{
public static readonly long[] Value=A184773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184773.Bytes);
public long this[int i]=>Value[i];

public static A184773Inst Instance=new A184773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184772
{
public static readonly BigInteger[] Value={ 13370536L,119205236368L,26695990774288L,77441892454241488L,BigInteger.Parse("38088784754633618128"),BigInteger.Parse("65125066574894542587856"),BigInteger.Parse("49227749118673440429632464"),BigInteger.Parse("65871504288847215551031759568") };
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
public class A184772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184772Inst Instance=new A184772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184771
{
public static readonly BigInteger[] Value={ 2358280L,7339536784L,1005763454224L,1156853256240592L,308462363918463952L,BigInteger.Parse("225203116583181557968"),BigInteger.Parse("83362210743024650511568"),BigInteger.Parse("49227749118673440429632464"),BigInteger.Parse("21277949728043116377816749008") };
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
public class A184771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184771Inst Instance=new A184771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184770
{
public static readonly BigInteger[] Value={ 417256L,454774672L,39939558160L,18492329456080L,3063406967117776L,1004331937875999952L,BigInteger.Parse("225203116583181557968"),BigInteger.Parse("65125066574894542587856"),BigInteger.Parse("16551036919295881635106768"),BigInteger.Parse("4596125898531178643947012816") };
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
public class A184770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184770Inst Instance=new A184770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184769
{
public static readonly BigInteger[] Value={ 73288L,27993232L,1444491280L,267277851856L,22101775999696L,3063406967117776L,308462363918463952L,BigInteger.Parse("38088784754633618128"),BigInteger.Parse("4147681118591532446416"),BigInteger.Parse("489192384756554775330256"),BigInteger.Parse("54923301389754187275076048") };
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
public class A184769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184769Inst Instance=new A184769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184768
{
public static readonly BigInteger[] Value={ 13096L,1792144L,62051344L,4975179472L,267277851856L,18492329456080L,1156853256240592L,77441892454241488L,5064538742140130512L,BigInteger.Parse("336992694113719404496"),BigInteger.Parse("22308222687181070310352"),BigInteger.Parse("1483254308363737851935440") };
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
public class A184768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184768Inst Instance=new A184768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184767
{
public static readonly BigInteger[] Value={ 2248L,108496L,1967440L,62051344L,1444491280L,39939558160L,1005763454224L,26695990774288L,688562611427344L,18047210235975952L,468881159345732368L,12241663779855722512UL,BigInteger.Parse("318750682398626741776"),BigInteger.Parse("8312086512859451766544") };
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
public class A184767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184767Inst Instance=new A184767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184766
{
public static readonly BigInteger[] Value={ 424L,8272L,108496L,1792144L,27993232L,454774672L,7339536784L,119205236368L,1934859805840L,31437977902480L,510797840746384L,8300795694017680L,134894624057920144L,2192213833325394832L,BigInteger.Parse("35626484733088902544") };
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
public class A184766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184766Inst Instance=new A184766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184765
{
public static readonly long[] Value={ 64L,424L,2248L,13096L,73288L,417256L,2358280L,13370536L,75704776L,428889448L,2429192584L,13760163880L,77941013320L,441485755624L,2500712951560L,14164866483112L,80234377893064L,454473710492776L,2574286780013704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184765Inst : IEnumerable<long>
{
public static readonly long[] Value=A184765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184765.Bytes);
public long this[int i]=>Value[i];

public static A184765Inst Instance=new A184765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184764
{
public static readonly BigInteger[] Value={ 64L,8272L,1967440L,4975179472L,22101775999696L,1004331937875999952L,BigInteger.Parse("83362210743024650511568"),BigInteger.Parse("65871504288847215551031759568") };
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
public class A184764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184764Inst Instance=new A184764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184731
{
public static readonly BigInteger[] Value={ 1L,2L,6L,38L,490L,14152L,969444L,140621476L,46041241698L,36363843928316L,62022250535177416L,BigInteger.Parse("236043875222171125276"),BigInteger.Parse("2205302277098968939256248"),BigInteger.Parse("45728754995013679582534494332"),BigInteger.Parse("2070631745797418828103776968679204") };
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
public class A184731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184731Inst Instance=new A184731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184730
{
public static readonly BigInteger[] Value={ 1L,2L,5L,20L,159L,3152L,168036L,20428850L,5796209814L,4052041564524L,6210335115944263L,BigInteger.Parse("21470958882165989854"),BigInteger.Parse("183818137919395949397148"),BigInteger.Parse("3517964195874870876682733562"),BigInteger.Parse("147909303669340763210833833705995") };
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
public class A184730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184730Inst Instance=new A184730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184729
{
public static readonly long[] Value={ 0L,0L,4L,1L,1L,1L,10L,1L,12L,1L,16L,11L,8L,1L,4L,1L,1L,1L,1L,28L,9L,1L,1L,8L,1L,12L,1L,42L,17L,1L,1L,46L,31L,7L,1L,1L,28L,39L,39L,60L,11L,13L,25L,66L,1L,70L,47L,47L,72L,1L,38L,1L,1L,26L,1L,7L,88L,1L,1L,61L,20L,17L,100L,67L,67L,102L,29L,41L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184729Inst : IEnumerable<long>
{
public static readonly long[] Value=A184729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184729.Bytes);
public long this[int i]=>Value[i];

public static A184729Inst Instance=new A184729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184728
{
public static readonly long[] Value={ 0L,0L,8L,6L,13L,9L,20L,19L,24L,19L,32L,33L,32L,37L,32L,43L,47L,47L,53L,56L,54L,59L,61L,64L,71L,72L,79L,84L,85L,83L,89L,92L,93L,84L,101L,107L,112L,117L,117L,120L,121L,117L,125L,132L,127L,140L,141L,141L,144L,137L,152L,157L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184728Inst : IEnumerable<long>
{
public static readonly long[] Value=A184728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184728.Bytes);
public long this[int i]=>Value[i];

public static A184728Inst Instance=new A184728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184727
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,4L,2L,4L,6L,5L,2L,8L,2L,7L,10L,8L,2L,12L,2L,10L,14L,11L,2L,16L,10L,13L,18L,14L,2L,20L,2L,16L,22L,17L,14L,24L,2L,19L,26L,20L,2L,28L,2L,22L,30L,23L,2L,32L,14L,25L,34L,26L,2L,36L,22L,28L,38L,29L,2L,40L,2L,31L,42L,32L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184727Inst : IEnumerable<long>
{
public static readonly long[] Value=A184727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184727.Bytes);
public long this[int i]=>Value[i];

public static A184727Inst Instance=new A184727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184726
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,3L,1L,1L,5L,1L,1L,7L,1L,5L,9L,1L,1L,11L,7L,1L,13L,1L,1L,15L,1L,7L,17L,1L,11L,19L,1L,1L,21L,13L,1L,23L,1L,1L,25L,11L,1L,27L,1L,17L,29L,1L,13L,31L,19L,1L,33L,1L,1L,35L,1L,1L,37L,1L,23L,39L,17L,11L,41L,25L,1L,43L,1L,19L,45L,1L,1L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184726Inst : IEnumerable<long>
{
public static readonly long[] Value=A184726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184726.Bytes);
public long this[int i]=>Value[i];

public static A184726Inst Instance=new A184726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184725
{
public static readonly long[] Value={ 6L,47L,120L,467L,947L,1958L,3604L,6939L,11333L,18282L,27796L,40692L,57628L,81302L,111670L,150145L,198248L,259843L,333599L,426333L,531093L,668121L,818444L,1003797L,1214530L,1464395L,1753048L,2090590L,2464415L,2907699L,3396888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184725Inst : IEnumerable<long>
{
public static readonly long[] Value=A184725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184725.Bytes);
public long this[int i]=>Value[i];

public static A184725Inst Instance=new A184725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184724
{
public static readonly long[] Value={ 5L,22L,39L,125L,209L,356L,560L,929L,1348L,2003L,2791L,3848L,4842L,6474L,8186L,10319L,13169L,16049L,19588L,24134L,28755L,34513L,40850L,47285L,55523L,63884L,73472L,85289L,97062L,110655L,124751L,140892L,157697L,178616L,197986L,221249L,245802L,272785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184724Inst : IEnumerable<long>
{
public static readonly long[] Value=A184724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184724.Bytes);
public long this[int i]=>Value[i];

public static A184724Inst Instance=new A184724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184723
{
public static readonly long[] Value={ 4L,9L,19L,22L,39L,65L,76L,114L,170L,192L,253L,315L,430L,488L,568L,678L,786L,988L,1176L,1284L,1476L,1732L,1948L,2178L,2465L,2753L,2892L,3339L,3691L,3989L,4422L,4817L,5310L,5740L,6312L,6881L,7393L,7830L,8759L,9214L,9887L,10657L,11192L,12196L,12944L,13633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184723Inst : IEnumerable<long>
{
public static readonly long[] Value=A184723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184723.Bytes);
public long this[int i]=>Value[i];

public static A184723Inst Instance=new A184723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184722
{
public static readonly long[] Value={ 3L,5L,7L,6L,6L,20L,15L,18L,29L,20L,22L,41L,33L,49L,43L,51L,47L,71L,70L,77L,96L,77L,84L,121L,112L,121L,152L,162L,130L,162L,159L,177L,184L,184L,212L,219L,214L,216L,251L,255L,286L,329L,279L,304L,339L,317L,322L,371L,359L,373L,385L,429L,435L,502L,495L,499L,528L,500L,546L,551L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184722Inst : IEnumerable<long>
{
public static readonly long[] Value=A184722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184722.Bytes);
public long this[int i]=>Value[i];

public static A184722Inst Instance=new A184722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184721
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,2L,3L,3L,4L,4L,5L,4L,4L,6L,5L,6L,3L,5L,4L,6L,6L,2L,7L,7L,5L,6L,5L,7L,8L,6L,7L,15L,10L,6L,8L,7L,9L,9L,8L,9L,10L,9L,9L,13L,4L,8L,14L,8L,14L,10L,6L,5L,11L,11L,12L,12L,13L,16L,16L,14L,11L,16L,8L,9L,22L,13L,14L,14L,15L,8L,17L,17L,11L,20L,20L,15L,20L,15L,15L,17L,16L,12L,21L,11L,11L,18L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184721Inst : IEnumerable<long>
{
public static readonly long[] Value=A184721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184721.Bytes);
public long this[int i]=>Value[i];

public static A184721Inst Instance=new A184721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184720
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,3L,1L,1L,2L,2L,5L,4L,1L,1L,2L,2L,7L,9L,5L,1L,1L,2L,3L,6L,19L,22L,6L,1L,1L,2L,2L,6L,22L,39L,47L,8L,1L,1L,2L,2L,20L,39L,125L,120L,95L,10L,1L,1L,2L,3L,15L,65L,209L,467L,411L,197L,12L,1L,1L,2L,3L,18L,76L,356L,947L,1669L,1310L,394L,15L,1L,1L,2L,4L,29L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184720Inst : IEnumerable<long>
{
public static readonly long[] Value=A184720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184720.Bytes);
public long this[int i]=>Value[i];

public static A184720Inst Instance=new A184720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184719
{
public static readonly long[] Value={ 1L,1L,2L,3L,18L,114L,929L,6939L,49405L,343061L,2349749L,15744977L,103294333L,664143853L,4191000242L,25991406059L,158554966581L,952308975542L,5636023020692L,32891357753442L,189405665405678L,1076880550812387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184719Inst : IEnumerable<long>
{
public static readonly long[] Value=A184719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184719.Bytes);
public long this[int i]=>Value[i];

public static A184719Inst Instance=new A184719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184718
{
public static readonly long[] Value={ 1L,1L,2L,2L,15L,76L,560L,3604L,24327L,152952L,925232L,5495907L,31966719L,182331659L,1021217701L,5622236708L,30456148470L,162478306805L,854327762047L,4430787907798L,22680031606293L,114649453836280L,572666511225162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184718Inst : IEnumerable<long>
{
public static readonly long[] Value=A184718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184718.Bytes);
public long this[int i]=>Value[i];

public static A184718Inst Instance=new A184718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184717
{
public static readonly long[] Value={ 1L,1L,2L,2L,20L,65L,356L,1958L,11206L,61215L,322965L,1666746L,8471382L,42144511L,206062493L,990942629L,4690125830L,21869723804L,100547402432L,456094690719L,2042617816297L,9036778212037L,39515366452359L,170866409817131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184717Inst : IEnumerable<long>
{
public static readonly long[] Value=A184717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184717.Bytes);
public long this[int i]=>Value[i];

public static A184717Inst Instance=new A184717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184716
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,39L,209L,947L,4403L,20825L,95461L,420312L,1824610L,7767715L,32447127L,133426790L,540454735L,2157136063L,8491433827L,32994222337L,126618582468L,480170037501L,1800457116471L,6678324836291L,24515228772443L,89097534819082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184716Inst : IEnumerable<long>
{
public static readonly long[] Value=A184716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184716.Bytes);
public long this[int i]=>Value[i];

public static A184716Inst Instance=new A184716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184667
{
public static readonly BigInteger[] Value={ 19269L,2405797L,266060160L,30765364899L,3509487618613L,402221585928132L,46028365937520330L,5269979734803579913L,BigInteger.Parse("603279614829234560146"),BigInteger.Parse("69064202595023175071177"),BigInteger.Parse("7906407074804511304606829") };
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
public class A184667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184667Inst Instance=new A184667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184666
{
public static readonly BigInteger[] Value={ 1740L,67330L,2405797L,88458672L,3225439429L,117938741095L,4308670152724L,157454260497016L,5753418267657560L,210237556594325891L,7682287249431007868L,BigInteger.Parse("280719194120503850605"),BigInteger.Parse("10257776899125672523995"),BigInteger.Parse("374830158857789457998588") };
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
public class A184666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184666Inst Instance=new A184666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184665
{
public static readonly long[] Value={ 150L,1740L,19269L,216912L,2430631L,27278035L,305991368L,3432961182L,38513146024L,432071200891L,4847297854288L,54380688812185L,610083824961241L,6844384156411424L,76785501492801006L,861438105302681684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184665Inst : IEnumerable<long>
{
public static readonly long[] Value=A184665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184665.Bytes);
public long this[int i]=>Value[i];

public static A184665Inst Instance=new A184665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184664
{
public static readonly BigInteger[] Value={ 150L,67330L,266060160L,11348244616180L,4705518067315949795L,BigInteger.Parse("19869188673828370548366580"),BigInteger.Parse("837185450907978354702239657652981") };
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
public class A184664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184664Inst Instance=new A184664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184663
{
public static readonly long[] Value={ 49246L,1352770L,1352770L,35802874L,119805310L,35802874L,742295518L,10047874534L,10047874534L,742295518L,17984702194L,564143008386L,2738040689182L,564143008386L,17984702194L,426536161750L,42151760266070L,452748537865658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184663Inst : IEnumerable<long>
{
public static readonly long[] Value=A184663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184663.Bytes);
public long this[int i]=>Value[i];

public static A184663Inst Instance=new A184663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184662
{
public static readonly long[] Value={ 35802874L,10047874534L,2738040689182L,452748537865658L,113762289821953494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184662Inst : IEnumerable<long>
{
public static readonly long[] Value=A184662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184662.Bytes);
public long this[int i]=>Value[i];

public static A184662Inst Instance=new A184662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184661
{
public static readonly BigInteger[] Value={ 1352770L,119805310L,10047874534L,564143008386L,42151760266070L,3068818942252922L,213876509386388262L,15511761707358612866UL,BigInteger.Parse("1118945141084512520558"),BigInteger.Parse("80408360347124360370778") };
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
public class A184661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184661Inst Instance=new A184661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184660
{
public static readonly BigInteger[] Value={ 49246L,1352770L,35802874L,742295518L,17984702194L,426536161750L,9789497534962L,230620412950366L,5400694882775818L,125973364404722134L,2950593093864039562L,BigInteger.Parse("69018872882507417134"),BigInteger.Parse("1613797015382550341674"),BigInteger.Parse("37757644419274785266902") };
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
public class A184660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184660Inst Instance=new A184660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184659
{
public static readonly long[] Value={ 3L,5L,8L,11L,13L,16L,18L,21L,24L,26L,29L,31L,34L,37L,39L,42L,45L,47L,50L,52L,55L,58L,60L,63L,65L,68L,71L,73L,76L,79L,81L,84L,86L,89L,92L,94L,97L,100L,102L,105L,107L,110L,113L,115L,118L,120L,123L,126L,128L,131L,134L,136L,139L,141L,144L,147L,149L,152L,155L,157L,160L,162L,165L,168L,170L,173L,175L,178L,181L,183L,186L,189L,191L,194L,196L,199L,202L,204L,207L,209L,212L,215L,217L,220L,223L,225L,228L,230L,233L,236L,238L,241L,244L,246L,249L,251L,254L,257L,259L,262L,264L,267L,270L,272L,275L,278L,280L,283L,285L,288L,291L,293L,296L,298L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184659Inst : IEnumerable<long>
{
public static readonly long[] Value=A184659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184659.Bytes);
public long this[int i]=>Value[i];

public static A184659Inst Instance=new A184659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184658
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,12L,14L,15L,17L,19L,20L,22L,23L,25L,27L,28L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,46L,48L,49L,51L,53L,54L,56L,57L,59L,61L,62L,64L,66L,67L,69L,70L,72L,74L,75L,77L,78L,80L,82L,83L,85L,87L,88L,90L,91L,93L,95L,96L,98L,99L,101L,103L,104L,106L,108L,109L,111L,112L,114L,116L,117L,119L,121L,122L,124L,125L,127L,129L,130L,132L,133L,135L,137L,138L,140L,142L,143L,145L,146L,148L,150L,151L,153L,154L,156L,158L,159L,161L,163L,164L,166L,167L,169L,171L,172L,174L,176L,177L,179L,180L,182L,184L,185L,187L,188L,190L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184658Inst : IEnumerable<long>
{
public static readonly long[] Value=A184658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184658.Bytes);
public long this[int i]=>Value[i];

public static A184658Inst Instance=new A184658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184657
{
public static readonly long[] Value={ 3L,6L,8L,11L,13L,16L,19L,21L,24L,26L,29L,32L,34L,37L,40L,42L,45L,47L,50L,53L,55L,58L,61L,63L,66L,68L,71L,74L,76L,79L,81L,84L,87L,89L,92L,95L,97L,100L,102L,105L,108L,110L,113L,116L,118L,121L,123L,126L,129L,131L,134L,136L,139L,142L,144L,147L,150L,152L,155L,157L,160L,163L,165L,168L,170L,173L,176L,178L,181L,184L,186L,189L,191L,194L,197L,199L,202L,205L,207L,210L,212L,215L,218L,220L,223L,225L,228L,231L,233L,236L,239L,241L,244L,246L,249L,252L,254L,257L,259L,262L,265L,267L,270L,273L,275L,278L,280L,283L,286L,288L,291L,294L,296L,299L,301L,304L,307L,309L,312L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184657Inst : IEnumerable<long>
{
public static readonly long[] Value=A184657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184657.Bytes);
public long this[int i]=>Value[i];

public static A184657Inst Instance=new A184657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184656
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,10L,12L,14L,15L,17L,18L,20L,22L,23L,25L,27L,28L,30L,31L,33L,35L,36L,38L,39L,41L,43L,44L,46L,48L,49L,51L,52L,54L,56L,57L,59L,60L,62L,64L,65L,67L,69L,70L,72L,73L,75L,77L,78L,80L,82L,83L,85L,86L,88L,90L,91L,93L,94L,96L,98L,99L,101L,103L,104L,106L,107L,109L,111L,112L,114L,115L,117L,119L,120L,122L,124L,125L,127L,128L,130L,132L,133L,135L,137L,138L,140L,141L,143L,145L,146L,148L,149L,151L,153L,154L,156L,158L,159L,161L,162L,164L,166L,167L,169L,171L,172L,174L,175L,177L,179L,180L,182L,183L,185L,187L,188L,190L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184656Inst : IEnumerable<long>
{
public static readonly long[] Value=A184656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184656.Bytes);
public long this[int i]=>Value[i];

public static A184656Inst Instance=new A184656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184655
{
public static readonly long[] Value={ 3L,5L,8L,10L,12L,15L,17L,19L,22L,24L,26L,29L,31L,34L,36L,38L,41L,43L,45L,48L,50L,52L,55L,57L,60L,62L,64L,67L,69L,71L,74L,76L,78L,81L,83L,86L,88L,90L,93L,95L,97L,100L,102L,105L,107L,109L,112L,114L,116L,119L,121L,123L,126L,128L,131L,133L,135L,138L,140L,142L,145L,147L,149L,152L,154L,157L,159L,161L,164L,166L,168L,171L,173L,175L,178L,180L,183L,185L,187L,190L,192L,194L,197L,199L,202L,204L,206L,209L,211L,213L,216L,218L,220L,223L,225L,228L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184655Inst : IEnumerable<long>
{
public static readonly long[] Value=A184655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184655.Bytes);
public long this[int i]=>Value[i];

public static A184655Inst Instance=new A184655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184654
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,11L,13L,14L,16L,18L,20L,21L,23L,25L,27L,28L,30L,32L,33L,35L,37L,39L,40L,42L,44L,46L,47L,49L,51L,53L,54L,56L,58L,59L,61L,63L,65L,66L,68L,70L,72L,73L,75L,77L,79L,80L,82L,84L,85L,87L,89L,91L,92L,94L,96L,98L,99L,101L,103L,104L,106L,108L,110L,111L,113L,115L,117L,118L,120L,122L,124L,125L,127L,129L,130L,132L,134L,136L,137L,139L,141L,143L,144L,146L,148L,150L,151L,153L,155L,156L,158L,160L,162L,163L,165L,167L,169L,170L,172L,174L,176L,177L,179L,181L,182L,184L,186L,188L,189L,191L,193L,195L,196L,198L,200L,201L,203L,205L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184654Inst : IEnumerable<long>
{
public static readonly long[] Value=A184654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184654.Bytes);
public long this[int i]=>Value[i];

public static A184654Inst Instance=new A184654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184653
{
public static readonly long[] Value={ 3L,5L,7L,10L,12L,14L,17L,19L,21L,24L,26L,29L,31L,33L,36L,38L,40L,43L,45L,48L,50L,52L,55L,57L,59L,62L,64L,66L,69L,71L,74L,76L,78L,81L,83L,85L,88L,90L,92L,95L,97L,100L,102L,104L,107L,109L,111L,114L,116L,118L,121L,123L,126L,128L,130L,133L,135L,137L,140L,142L,145L,147L,149L,152L,154L,156L,159L,161L,163L,166L,168L,171L,173L,175L,178L,180L,182L,185L,187L,189L,192L,194L,197L,199L,201L,204L,206L,208L,211L,213L,215L,218L,220L,223L,225L,227L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184653Inst : IEnumerable<long>
{
public static readonly long[] Value=A184653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184653.Bytes);
public long this[int i]=>Value[i];

public static A184653Inst Instance=new A184653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184652
{
public static readonly long[] Value={ 212898L,11826498L,11826498L,657272274L,2393686398L,657272274L,36516002466L,484872198498L,484872198498L,36516002466L,2028771948738L,98159708768710L,358095672726522L,98159708768710L,2028771948738L,112716440618754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184652Inst : IEnumerable<long>
{
public static readonly long[] Value=A184652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184652.Bytes);
public long this[int i]=>Value[i];

public static A184652Inst Instance=new A184652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184603
{
public static readonly BigInteger[] Value={ 10704L,3333345L,1339793447L,586441134417L,266823559411796L,124201308194651058L,BigInteger.Parse("58705095126108291860"),BigInteger.Parse("28056029360014523631654"),BigInteger.Parse("13521010840482176059922831"),BigInteger.Parse("6558986191129563851102130327") };
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
public class A184603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184603Inst Instance=new A184603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184602
{
public static readonly BigInteger[] Value={ 2880L,446426L,89538170L,19597196907L,4461217004146L,1038876920232926L,245608218357699105L,BigInteger.Parse("58705095126108291860"),BigInteger.Parse("14148602810460027001369"),BigInteger.Parse("3432240397744170829576350"),BigInteger.Parse("836984055384644047944565034") };
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
public class A184602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184602Inst Instance=new A184602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184601
{
public static readonly BigInteger[] Value={ 784L,60569L,6045460L,661355087L,75369979530L,8783684627835L,1038876920232926L,124201308194651058L,14971003403040041129UL,BigInteger.Parse("1816251101842544994491"),BigInteger.Parse("221492117754765269030948"),BigInteger.Parse("27126817151861700072792723") };
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
public class A184601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184601Inst Instance=new A184601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184600
{
public static readonly BigInteger[] Value={ 214L,8268L,411825L,22581061L,1291076970L,75369979530L,4461217004146L,266823559411796L,16087490826015621L,976144514798586404L,BigInteger.Parse("59534845819156963374"),BigInteger.Parse("3646426116234905396563"),BigInteger.Parse("224132828382262166503511") };
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
public class A184600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184600Inst Instance=new A184600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184599
{
public static readonly BigInteger[] Value={ 58L,1123L,28192L,782948L,22581061L,661355087L,19597196907L,586441134417L,17688240987365L,536871796215114L,16377770252298658L,501706560946729804L,15422847845337959631UL,BigInteger.Parse("475525543795160585979"),BigInteger.Parse("14699379057329857140441") };
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
public class A184599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184599Inst Instance=new A184599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184598
{
public static readonly long[] Value={ 16L,156L,1986L,28192L,411825L,6045460L,89538170L,1339793447L,20215904926L,306972320468L,4684471214542L,71777709052696L,1103593885196101L,17017816693554841L,263086943851348011L,4076187315351054647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184598Inst : IEnumerable<long>
{
public static readonly long[] Value=A184598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184598.Bytes);
public long this[int i]=>Value[i];

public static A184598Inst Instance=new A184598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184597
{
public static readonly long[] Value={ 5L,24L,156L,1123L,8268L,60569L,446426L,3333345L,25146354L,190958245L,1457049922L,11161985897L,85804483994L,661561762629L,5113755311738L,39616036230913L,307500608317658L,2390939974122621L,18619094389326362L,145193529732807545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184597Inst : IEnumerable<long>
{
public static readonly long[] Value=A184597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184597.Bytes);
public long this[int i]=>Value[i];

public static A184597Inst Instance=new A184597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184596
{
public static readonly long[] Value={ 2L,5L,16L,58L,214L,784L,2880L,10704L,40264L,152728L,582424L,2229856L,8566528L,33011680L,127553920L,493989568L,1916920384L,7451582080L,29011376256L,113108257920L,441536615296L,1725575305600L,6750738252160L,26435046548992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184596Inst : IEnumerable<long>
{
public static readonly long[] Value=A184596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184596.Bytes);
public long this[int i]=>Value[i];

public static A184596Inst Instance=new A184596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184595
{
public static readonly BigInteger[] Value={ 2L,24L,1986L,782948L,1291076970L,8783684627835L,245608218357699105L,BigInteger.Parse("28056029360014523631654"),BigInteger.Parse("13030390694954764597618159782") };
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
public class A184595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184595Inst Instance=new A184595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184594
{
public static readonly long[] Value={ 1L,2L,5L,6L,20L,21L,35L,62L,64L,65L,67L,97L,159L,198L,267L,444L,449L,499L,761L,764L,800L,801L,802L,803L,804L,810L,886L,1413L,1435L,1613L,1614L,1615L,1634L,2566L,2568L,4162L,4653L,6115L,6118L,6120L,6121L,6124L,6136L,7063L,7070L,7071L,7075L,7076L,7118L,7119L,7424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184594Inst : IEnumerable<long>
{
public static readonly long[] Value=A184594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184594.Bytes);
public long this[int i]=>Value[i];

public static A184594Inst Instance=new A184594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184593
{
public static readonly long[] Value={ 3L,5L,5L,3L,7L,9L,7L,3L,5L,1L,5L,3L,7L,9L,7L,9L,5L,9L,7L,11L,13L,9L,11L,7L,5L,9L,11L,9L,5L,7L,5L,9L,7L,3L,-1L,3L,1L,3L,1L,3L,-1L,3L,7L,9L,7L,3L,7L,9L,7L,3L,5L,1L,5L,9L,7L,9L,5L,9L,7L,11L,13L,15L,13L,17L,19L,17L,21L,19L,17L,13L,15L,11L,9L,11L,7L,9L,5L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184593Inst : IEnumerable<long>
{
public static readonly long[] Value=A184593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184593.Bytes);
public long this[int i]=>Value[i];

public static A184593Inst Instance=new A184593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184592
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,15L,17L,19L,21L,23L,25L,27L,29L,30L,32L,34L,36L,38L,40L,42L,44L,45L,47L,49L,51L,53L,55L,57L,59L,60L,62L,64L,66L,68L,70L,72L,74L,75L,77L,79L,81L,83L,85L,87L,89L,90L,92L,94L,96L,98L,100L,102L,104L,105L,107L,109L,111L,113L,115L,117L,119L,120L,122L,124L,126L,128L,130L,132L,134L,135L,137L,139L,141L,143L,145L,147L,149L,150L,152L,154L,156L,158L,160L,162L,164L,165L,167L,169L,171L,173L,175L,177L,179L,180L,182L,184L,186L,188L,190L,192L,194L,195L,197L,199L,201L,203L,205L,207L,209L,210L,212L,214L,216L,218L,220L,222L,224L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184592Inst : IEnumerable<long>
{
public static readonly long[] Value=A184592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184592.Bytes);
public long this[int i]=>Value[i];

public static A184592Inst Instance=new A184592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184591
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,16L,18L,20L,22L,24L,26L,28L,31L,33L,35L,37L,39L,41L,43L,46L,48L,50L,52L,54L,56L,58L,61L,63L,65L,67L,69L,71L,73L,76L,78L,80L,82L,84L,86L,88L,91L,93L,95L,97L,99L,101L,103L,106L,108L,110L,112L,114L,116L,118L,121L,123L,125L,127L,129L,131L,133L,136L,138L,140L,142L,144L,146L,148L,151L,153L,155L,157L,159L,161L,163L,166L,168L,170L,172L,174L,176L,178L,181L,183L,185L,187L,189L,191L,193L,196L,198L,200L,202L,204L,206L,208L,211L,213L,215L,217L,219L,221L,223L,226L,228L,230L,232L,234L,236L,238L,240L,243L,245L,247L,249L,251L,253L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184591Inst : IEnumerable<long>
{
public static readonly long[] Value=A184591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184591.Bytes);
public long this[int i]=>Value[i];

public static A184591Inst Instance=new A184591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184590
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,10L,11L,13L,14L,16L,17L,19L,21L,22L,24L,25L,27L,29L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,46L,48L,49L,51L,52L,54L,55L,57L,59L,60L,62L,63L,65L,67L,68L,70L,71L,73L,74L,76L,78L,79L,81L,82L,84L,86L,87L,89L,90L,92L,93L,95L,97L,98L,100L,101L,103L,104L,106L,108L,109L,111L,112L,114L,116L,117L,119L,120L,122L,123L,125L,127L,128L,130L,131L,133L,135L,136L,138L,139L,141L,142L,144L,146L,147L,149L,150L,152L,154L,155L,157L,158L,160L,161L,163L,165L,166L,168L,169L,171L,173L,174L,176L,177L,179L,180L,182L,184L,185L,187L,188L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184590Inst : IEnumerable<long>
{
public static readonly long[] Value=A184590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184590.Bytes);
public long this[int i]=>Value[i];

public static A184590Inst Instance=new A184590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184589
{
public static readonly long[] Value={ 1L,4L,7L,9L,12L,15L,18L,20L,23L,26L,28L,31L,34L,37L,39L,42L,45L,47L,50L,53L,56L,58L,61L,64L,66L,69L,72L,75L,77L,80L,83L,85L,88L,91L,94L,96L,99L,102L,105L,107L,110L,113L,115L,118L,121L,124L,126L,129L,132L,134L,137L,140L,143L,145L,148L,151L,153L,156L,159L,162L,164L,167L,170L,172L,175L,178L,181L,183L,186L,189L,191L,194L,197L,200L,202L,205L,208L,211L,213L,216L,219L,221L,224L,227L,230L,232L,235L,238L,240L,243L,246L,249L,251L,254L,257L,259L,262L,265L,268L,270L,273L,276L,278L,281L,284L,287L,289L,292L,295L,298L,300L,303L,306L,308L,311L,314L,317L,319L,322L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184589Inst : IEnumerable<long>
{
public static readonly long[] Value=A184589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184589.Bytes);
public long this[int i]=>Value[i];

public static A184589Inst Instance=new A184589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184588
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,11L,13L,15L,16L,18L,19L,21L,22L,24L,26L,27L,29L,30L,32L,34L,35L,37L,38L,40L,41L,43L,45L,46L,48L,49L,51L,52L,54L,56L,57L,59L,60L,62L,64L,65L,67L,68L,70L,71L,73L,75L,76L,78L,79L,81L,83L,84L,86L,87L,89L,90L,92L,94L,95L,97L,98L,100L,102L,103L,105L,106L,108L,109L,111L,113L,114L,116L,117L,119L,121L,122L,124L,125L,127L,128L,130L,132L,133L,135L,136L,138L,140L,141L,143L,144L,146L,147L,149L,151L,152L,154L,155L,157L,158L,160L,162L,163L,165L,166L,168L,170L,171L,173L,174L,176L,177L,179L,181L,182L,184L,185L,187L,189L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184588Inst : IEnumerable<long>
{
public static readonly long[] Value=A184588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184588.Bytes);
public long this[int i]=>Value[i];

public static A184588Inst Instance=new A184588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184427
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,93L,94L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184427Inst : IEnumerable<long>
{
public static readonly long[] Value=A184427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184427.Bytes);
public long this[int i]=>Value[i];

public static A184427Inst Instance=new A184427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184426
{
public static readonly long[] Value={ 2L,6L,10L,15L,22L,29L,37L,47L,57L,68L,80L,94L,108L,123L,139L,156L,174L,194L,214L,235L,257L,280L,304L,330L,356L,383L,411L,440L,470L,501L,534L,567L,601L,636L,672L,709L,747L,786L,826L,868L,910L,953L,997L,1042L,1088L,1135L,1183L,1232L,1283L,1334L,1386L,1439L,1493L,1548L,1604L,1661L,1719L,1778L,1839L,1900L,1962L,2025L,2089L,2154L,2220L,2287L,2355L,2424L,2494L,2566L,2638L,2711L,2785L,2860L,2936L,3013L,3091L,3170L,3250L,3331L,3413L,3496L,3581L,3666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184426Inst : IEnumerable<long>
{
public static readonly long[] Value=A184426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184426.Bytes);
public long this[int i]=>Value[i];

public static A184426Inst Instance=new A184426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184425
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184425Inst : IEnumerable<long>
{
public static readonly long[] Value=A184425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184425.Bytes);
public long this[int i]=>Value[i];

public static A184425Inst Instance=new A184425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184424
{
public static readonly BigInteger[] Value={ 1L,6L,252L,15288L,1089270L,84963060L,7023612960L,604604070720L,53620823521980L,4865593245513000L,449580815885401200L,BigInteger.Parse("42156561463105471200"),BigInteger.Parse("4001360292206427641400"),BigInteger.Parse("383704407665664889683600") };
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
public class A184424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184424.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184424Inst Instance=new A184424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184423
{
public static readonly BigInteger[] Value={ 1L,12L,540L,33600L,2425500L,190702512L,15849497664L,1369618398720L,121821136479900L,11079206239530000L,1025579963180813040L,BigInteger.Parse("96310511463483233280"),BigInteger.Parse("9152842704012278107200"),BigInteger.Parse("878622906816654279840000") };
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
public class A184423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184423Inst Instance=new A184423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184422
{
public static readonly long[] Value={ 3L,7L,11L,15L,19L,23L,27L,30L,35L,39L,42L,47L,51L,54L,59L,62L,66L,71L,74L,78L,82L,86L,91L,94L,98L,102L,106L,110L,113L,118L,122L,126L,130L,134L,137L,142L,145L,149L,154L,157L,162L,165L,169L,173L,177L,181L,186L,189L,193L,197L,201L,205L,208L,213L,216L,221L,225L,228L,233L,237L,240L,245L,248L,252L,257L,260L,264L,268L,272L,276L,280L,284L,288L,292L,296L,299L,304L,308L,311L,316L,320L,323L,328L,331L,336L,340L,343L,347L,352L,355L,359L,363L,367L,371L,375L,379L,382L,387L,391L,394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184422Inst : IEnumerable<long>
{
public static readonly long[] Value=A184422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184422.Bytes);
public long this[int i]=>Value[i];

public static A184422Inst Instance=new A184422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184421
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,33L,34L,36L,37L,38L,40L,41L,43L,44L,45L,46L,48L,49L,50L,52L,53L,55L,56L,57L,58L,60L,61L,63L,64L,65L,67L,68L,69L,70L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,92L,93L,95L,96L,97L,99L,100L,101L,103L,104L,105L,107L,108L,109L,111L,112L,114L,115L,116L,117L,119L,120L,121L,123L,124L,125L,127L,128L,129L,131L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184421Inst : IEnumerable<long>
{
public static readonly long[] Value=A184421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184421.Bytes);
public long this[int i]=>Value[i];

public static A184421Inst Instance=new A184421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184420
{
public static readonly long[] Value={ 2L,6L,8L,11L,15L,18L,21L,24L,27L,30L,33L,36L,40L,42L,46L,48L,52L,55L,58L,61L,64L,67L,71L,73L,77L,80L,82L,86L,89L,92L,95L,98L,102L,105L,107L,111L,113L,117L,120L,123L,126L,129L,132L,136L,138L,142L,145L,147L,151L,154L,157L,160L,163L,166L,169L,173L,176L,178L,182L,185L,188L,191L,194L,197L,201L,203L,207L,210L,212L,216L,218L,222L,226L,228L,231L,234L,238L,241L,243L,247L,250L,253L,256L,259L,262L,266L,268L,272L,275L,278L,281L,283L,287L,291L,293L,296L,299L,302L,306L,309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184420Inst : IEnumerable<long>
{
public static readonly long[] Value=A184420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184420.Bytes);
public long this[int i]=>Value[i];

public static A184420Inst Instance=new A184420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184419
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,10L,12L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,34L,35L,37L,38L,39L,41L,43L,44L,45L,47L,49L,50L,51L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,70L,72L,74L,75L,76L,78L,79L,81L,83L,84L,85L,87L,88L,90L,91L,93L,94L,96L,97L,99L,100L,101L,103L,104L,106L,108L,109L,110L,112L,114L,115L,116L,118L,119L,121L,122L,124L,125L,127L,128L,130L,131L,133L,134L,135L,137L,139L,140L,141L,143L,144L,146L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184419Inst : IEnumerable<long>
{
public static readonly long[] Value=A184419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184419.Bytes);
public long this[int i]=>Value[i];

public static A184419Inst Instance=new A184419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184418
{
public static readonly long[] Value={ 1L,2L,5L,6L,10L,10L,15L,14L,20L,18L,25L,22L,30L,26L,35L,30L,40L,34L,45L,38L,50L,42L,55L,46L,60L,50L,65L,54L,70L,58L,75L,62L,80L,66L,85L,70L,90L,74L,95L,78L,100L,82L,105L,86L,110L,90L,115L,94L,120L,98L,125L,102L,130L,106L,135L,110L,140L,114L,145L,118L,150L,122L,155L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184418Inst : IEnumerable<long>
{
public static readonly long[] Value=A184418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184418.Bytes);
public long this[int i]=>Value[i];

public static A184418Inst Instance=new A184418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184417
{
public static readonly long[] Value={ 33L,73L,289L,649L,1801L,3529L,7201L,10369L,20809L,23329L,38089L,45001L,64801L,73729L,78409L,103969L,115201L,145801L,159049L,194689L,242209L,352801L,373249L,426889L,544969L,649801L,720001L,763849L,824329L,871201L,1312201L,1351369L,1371169L,1472329L,1555849L,2080801L,2130049L,2205001L,2255689L,2384929L,2654209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184417Inst : IEnumerable<long>
{
public static readonly long[] Value=A184417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184417.Bytes);
public long this[int i]=>Value[i];

public static A184417Inst Instance=new A184417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184416
{
public static readonly long[] Value={ 2L,4L,6L,9L,10L,13L,15L,17L,19L,22L,24L,25L,28L,31L,32L,35L,36L,39L,41L,44L,45L,48L,50L,51L,55L,56L,58L,62L,63L,64L,68L,70L,71L,73L,77L,78L,80L,82L,85L,88L,89L,90L,94L,96L,98L,100L,102L,103L,108L,109L,110L,113L,115L,117L,120L,123L,124L,126L,127L,131L,133L,135L,137L,140L,141L,143L,145L,148L,151L,153L,154L,156L,159L,161L,163L,165L,168L,170L,173L,174L,176L,178L,180L,183L,186L,187L,189L,192L,194L,196L,198L,200L,202L,204L,207L,209L,212L,214L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184416Inst : IEnumerable<long>
{
public static readonly long[] Value=A184416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184416.Bytes);
public long this[int i]=>Value[i];

public static A184416Inst Instance=new A184416Inst();

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