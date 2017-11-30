using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A189377
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,11L,14L,16L,18L,21L,22L,24L,27L,29L,31L,32L,35L,37L,39L,42L,43L,45L,48L,50L,52L,55L,56L,58L,60L,63L,65L,66L,69L,71L,73L,76L,77L,79L,82L,84L,86L,87L,90L,92L,94L,97L,99L,100L,103L,105L,107L,110L,111L,113L,115L,118L,120L,121L,124L,126L,128L,131L,132L,134L,137L,139L,141L,144L,145L,147L,149L,152L,154L,155L,158L,160L,162L,165L,166L,168L,171L,173L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189377Inst : IEnumerable<long>
{
public static readonly long[] Value=A189377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189377.Bytes);
public long this[int i]=>Value[i];

public static A189377Inst Instance=new A189377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189378
{
public static readonly long[] Value={ 6L,13L,19L,26L,34L,40L,47L,53L,61L,68L,74L,81L,89L,95L,102L,108L,116L,123L,129L,136L,142L,150L,157L,163L,170L,178L,184L,191L,197L,205L,212L,218L,225L,233L,239L,246L,252L,259L,267L,273L,280L,286L,294L,301L,307L,314L,322L,328L,335L,341L,349L,356L,362L,369L,375L,383L,390L,396L,403L,411L,417L,424L,430L,438L,445L,451L,458L,466L,472L,479L,485L,492L,500L,506L,513L,519L,527L,534L,540L,547L,555L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189378Inst : IEnumerable<long>
{
public static readonly long[] Value=A189378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189378.Bytes);
public long this[int i]=>Value[i];

public static A189378Inst Instance=new A189378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189379
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,15L,17L,20L,23L,25L,28L,30L,33L,36L,38L,41L,44L,46L,49L,51L,54L,57L,59L,62L,64L,67L,70L,72L,75L,78L,80L,83L,85L,88L,91L,93L,96L,98L,101L,104L,106L,109L,112L,114L,117L,119L,122L,125L,127L,130L,133L,135L,138L,140L,143L,146L,148L,151L,153L,156L,159L,161L,164L,167L,169L,172L,174L,177L,180L,182L,185L,187L,190L,193L,195L,198L,201L,203L,206L,208L,211L,214L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189379Inst : IEnumerable<long>
{
public static readonly long[] Value=A189379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189379.Bytes);
public long this[int i]=>Value[i];

public static A189379Inst Instance=new A189379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189380
{
public static readonly long[] Value={ 3L,6L,11L,14L,19L,22L,25L,30L,33L,38L,41L,44L,49L,52L,57L,60L,65L,68L,71L,76L,79L,84L,87L,90L,95L,98L,103L,106L,111L,114L,117L,122L,125L,130L,133L,136L,141L,144L,149L,152L,155L,160L,163L,168L,171L,176L,179L,182L,187L,190L,195L,198L,201L,206L,209L,214L,217L,222L,225L,228L,233L,236L,241L,244L,247L,252L,255L,260L,263L,266L,271L,274L,279L,282L,287L,290L,293L,298L,301L,306L,309L,312L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189380Inst : IEnumerable<long>
{
public static readonly long[] Value=A189380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189380.Bytes);
public long this[int i]=>Value[i];

public static A189380Inst Instance=new A189380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189381
{
public static readonly long[] Value={ 8L,17L,27L,36L,46L,54L,63L,73L,82L,92L,101L,109L,119L,128L,138L,147L,157L,165L,174L,184L,193L,203L,212L,220L,230L,239L,249L,258L,268L,276L,285L,295L,304L,314L,322L,331L,341L,350L,360L,369L,377L,387L,396L,406L,415L,425L,433L,442L,452L,461L,471L,480L,488L,498L,507L,517L,526L,536L,544L,553L,563L,572L,582L,591L,599L,609L,618L,628L,637L,645L,655L,664L,674L,683L,693L,701L,710L,720L,729L,739L,748L,756L,766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189381Inst : IEnumerable<long>
{
public static readonly long[] Value=A189381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189381.Bytes);
public long this[int i]=>Value[i];

public static A189381Inst Instance=new A189381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189382
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,10L,12L,13L,15L,16L,18L,20L,21L,23L,24L,26L,28L,29L,31L,32L,34L,35L,37L,39L,40L,42L,43L,45L,47L,48L,50L,51L,53L,55L,56L,58L,59L,61L,62L,64L,66L,67L,69L,70L,72L,74L,75L,77L,78L,80L,81L,83L,85L,86L,88L,89L,91L,93L,94L,96L,97L,99L,100L,102L,104L,105L,107L,108L,110L,112L,113L,115L,116L,118L,120L,121L,123L,124L,126L,127L,129L,131L,132L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189382Inst : IEnumerable<long>
{
public static readonly long[] Value=A189382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189382.Bytes);
public long this[int i]=>Value[i];

public static A189382Inst Instance=new A189382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189383
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,13L,15L,17L,20L,22L,24L,26L,29L,31L,33L,36L,38L,40L,42L,45L,47L,49L,52L,53L,56L,59L,61L,63L,65L,68L,69L,72L,75L,77L,79L,81L,84L,85L,88L,91L,92L,95L,97L,100L,101L,104L,107L,108L,111L,113L,116L,118L,120L,123L,124L,127L,129L,132L,134L,136L,139L,140L,143L,145L,147L,150L,152L,155L,156L,159L,161L,163L,166L,168L,171L,172L,175L,178L,179L,182L,184L,186L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189383Inst : IEnumerable<long>
{
public static readonly long[] Value=A189383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189383.Bytes);
public long this[int i]=>Value[i];

public static A189383Inst Instance=new A189383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189384
{
public static readonly long[] Value={ 2L,5L,9L,12L,16L,18L,21L,25L,28L,32L,34L,37L,41L,44L,48L,51L,54L,57L,60L,64L,67L,70L,73L,76L,80L,83L,87L,89L,93L,96L,99L,103L,105L,109L,112L,115L,119L,122L,125L,128L,131L,135L,138L,141L,144L,148L,151L,154L,158L,160L,164L,167L,170L,174L,176L,180L,183L,187L,190L,192L,196L,199L,203L,206L,209L,212L,215L,219L,222L,225L,228L,231L,235L,238L,242L,245L,247L,251L,254L,258L,261L,263L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189384Inst : IEnumerable<long>
{
public static readonly long[] Value=A189384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189384.Bytes);
public long this[int i]=>Value[i];

public static A189384Inst Instance=new A189384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189385
{
public static readonly long[] Value={ 3L,7L,11L,14L,19L,23L,27L,30L,35L,39L,43L,46L,50L,55L,58L,62L,66L,71L,74L,78L,82L,86L,90L,94L,98L,102L,106L,110L,114L,117L,121L,126L,130L,133L,137L,142L,146L,149L,153L,157L,162L,165L,169L,173L,177L,181L,185L,189L,193L,197L,201L,205L,208L,213L,217L,220L,224L,229L,233L,236L,240L,244L,249L,252L,256L,260L,265L,268L,272L,276L,279L,284L,288L,292L,295L,300L,304L,308L,311L,315L,320L,324L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189385Inst : IEnumerable<long>
{
public static readonly long[] Value=A189385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189385.Bytes);
public long this[int i]=>Value[i];

public static A189385Inst Instance=new A189385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189386
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,23L,26L,29L,32L,34L,38L,41L,44L,47L,50L,53L,55L,59L,62L,65L,68L,70L,74L,77L,80L,83L,86L,89L,91L,95L,98L,101L,104L,106L,110L,112L,116L,119L,121L,125L,127L,131L,133L,137L,140L,142L,146L,148L,152L,155L,157L,161L,163L,167L,169L,173L,176L,178L,182L,184L,188L,190L,193L,197L,199L,203L,205L,208L,211L,214L,218L,220L,224L,226L,229L,233L,235L,239L,241L,244L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189386Inst : IEnumerable<long>
{
public static readonly long[] Value=A189386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189386.Bytes);
public long this[int i]=>Value[i];

public static A189386Inst Instance=new A189386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189387
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,12L,13L,16L,18L,21L,22L,24L,27L,28L,31L,33L,35L,37L,39L,42L,43L,45L,48L,49L,52L,54L,57L,58L,60L,63L,64L,67L,69L,71L,73L,75L,78L,79L,81L,84L,85L,88L,90L,92L,94L,96L,99L,100L,103L,105L,107L,109L,111L,114L,115L,117L,120L,122L,124L,126L,128L,130L,132L,135L,136L,138L,141L,143L,145L,147L,149L,151L,153L,156L,158L,160L,162L,164L,166L,168L,171L,172L,174L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189387Inst : IEnumerable<long>
{
public static readonly long[] Value=A189387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189387.Bytes);
public long this[int i]=>Value[i];

public static A189387Inst Instance=new A189387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189452
{
public static readonly BigInteger[] Value={ 1L,34L,400L,7300L,118128L,2008890L,33735505L,569476049L,9601403672L,161963813841L,2731821630753L,46079554836082L,777248318344360L,13110321921956724L,221139603633268744L,3730094981047721690L,BigInteger.Parse("62917755232156271921") };
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
public class A189452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189452Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189452.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189452.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189452Inst Instance=new A189452Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189453
{
public static readonly BigInteger[] Value={ 1L,89L,2000L,80282L,2735828L,100047288L,3586575040L,129699382789L,4679106263313L,168988854344569L,6101461090647052L,220326773309617717L,7955866427871519329L,BigInteger.Parse("287286109553012636665"),BigInteger.Parse("10373859878107656627776"),BigInteger.Parse("374599289123263236521340") };
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
public class A189453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189453.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189453Inst Instance=new A189453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189454
{
public static readonly BigInteger[] Value={ 1L,233L,10000L,883049L,63367633L,4982424404L,381987110556L,29628810704689L,2291898956153380L,177547968807911516L,13750881831250357785UL,BigInteger.Parse("1065189200482251908097"),BigInteger.Parse("82511968595532627713640") };
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
public class A189454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189454Inst Instance=new A189454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189455
{
public static readonly BigInteger[] Value={ 1L,610L,50000L,9712873L,1467726607L,248187289625L,40668908306516L,6765736745152657L,1121551510151218844L,BigInteger.Parse("186316582712584278456"),BigInteger.Parse("30941586267382205903880"),BigInteger.Parse("5140131519113981931817620") };
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
public class A189455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189455Inst Instance=new A189455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189456
{
public static readonly BigInteger[] Value={ 1L,1597L,250000L,106834338L,33995627281L,12362821462925L,4329976369716644L,1544933702911323688L,BigInteger.Parse("548904049287782685569"),BigInteger.Parse("195559483332882314913741"),BigInteger.Parse("69650888604936997141340729"),BigInteger.Parse("24818320628803632672710482237") };
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
public class A189456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189456Inst Instance=new A189456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189457
{
public static readonly long[] Value={ 2L,5L,8L,10L,14L,17L,19L,22L,25L,29L,31L,34L,37L,39L,43L,46L,49L,51L,54L,58L,60L,63L,66L,68L,72L,75L,78L,80L,84L,87L,89L,92L,95L,99L,101L,104L,107L,109L,113L,116L,118L,121L,124L,128L,130L,133L,136L,138L,142L,145L,148L,150L,153L,157L,159L,162L,165L,169L,171L,174L,177L,179L,183L,186L,188L,191L,194L,198L,200L,203L,206L,208L,212L,215L,218L,220L,223L,227L,229L,232L,235L,237L,241L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189457Inst : IEnumerable<long>
{
public static readonly long[] Value=A189457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189457.Bytes);
public long this[int i]=>Value[i];

public static A189457Inst Instance=new A189457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189458
{
public static readonly long[] Value={ 3L,7L,12L,15L,20L,24L,27L,32L,36L,41L,44L,48L,53L,56L,61L,65L,70L,73L,77L,82L,85L,90L,94L,97L,102L,106L,111L,114L,119L,123L,126L,131L,135L,140L,143L,147L,152L,155L,160L,164L,167L,172L,176L,181L,184L,189L,193L,196L,201L,205L,210L,213L,217L,222L,225L,230L,234L,239L,242L,246L,251L,254L,259L,263L,266L,271L,275L,280L,283L,287L,292L,295L,300L,304L,309L,312L,316L,321L,324L,329L,333L,336L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189458Inst : IEnumerable<long>
{
public static readonly long[] Value=A189458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189458.Bytes);
public long this[int i]=>Value[i];

public static A189458Inst Instance=new A189458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189459
{
public static readonly long[] Value={ 4L,9L,15L,20L,26L,31L,36L,42L,47L,53L,58L,62L,68L,73L,79L,84L,90L,95L,100L,106L,111L,117L,122L,126L,132L,137L,143L,148L,154L,159L,164L,170L,175L,181L,185L,190L,196L,201L,207L,212L,217L,223L,228L,234L,239L,245L,249L,254L,260L,265L,271L,276L,281L,287L,292L,298L,303L,309L,313L,318L,324L,329L,335L,340L,345L,351L,356L,362L,367L,371L,377L,382L,388L,393L,399L,404L,409L,415L,420L,426L,431L,435L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189459Inst : IEnumerable<long>
{
public static readonly long[] Value=A189459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189459.Bytes);
public long this[int i]=>Value[i];

public static A189459Inst Instance=new A189459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189460
{
public static readonly long[] Value={ 3L,7L,10L,14L,18L,21L,25L,28L,33L,37L,40L,44L,48L,51L,55L,58L,63L,67L,70L,74L,77L,81L,85L,88L,92L,97L,100L,104L,107L,111L,115L,118L,122L,127L,130L,134L,137L,141L,145L,148L,152L,155L,160L,164L,167L,171L,175L,178L,182L,185L,190L,194L,197L,201L,204L,208L,212L,215L,219L,224L,227L,231L,234L,238L,242L,245L,249L,254L,257L,261L,264L,268L,272L,275L,279L,282L,287L,291L,294L,298L,302L,305L,309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189460Inst : IEnumerable<long>
{
public static readonly long[] Value=A189460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189460.Bytes);
public long this[int i]=>Value[i];

public static A189460Inst Instance=new A189460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189461
{
public static readonly long[] Value={ 2L,5L,9L,12L,16L,19L,23L,26L,30L,32L,35L,39L,42L,46L,49L,53L,56L,60L,62L,65L,69L,72L,76L,79L,83L,86L,90L,93L,95L,99L,102L,106L,109L,113L,116L,120L,123L,125L,129L,132L,136L,139L,143L,146L,150L,153L,157L,159L,162L,166L,169L,173L,176L,180L,183L,187L,189L,192L,196L,199L,203L,206L,210L,213L,217L,220L,222L,226L,229L,233L,236L,240L,243L,247L,250L,252L,256L,259L,263L,266L,270L,273L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189461Inst : IEnumerable<long>
{
public static readonly long[] Value=A189461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189461.Bytes);
public long this[int i]=>Value[i];

public static A189461Inst Instance=new A189461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189462
{
public static readonly long[] Value={ 1L,4L,6L,8L,11L,13L,15L,17L,20L,22L,24L,27L,29L,31L,34L,36L,38L,41L,43L,45L,47L,50L,52L,54L,57L,59L,61L,64L,66L,68L,71L,73L,75L,78L,80L,82L,84L,87L,89L,91L,94L,96L,98L,101L,103L,105L,108L,110L,112L,114L,117L,119L,121L,124L,126L,128L,131L,133L,135L,138L,140L,142L,144L,147L,149L,151L,154L,156L,158L,161L,163L,165L,168L,170L,172L,174L,177L,179L,181L,184L,186L,188L,191L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189462Inst : IEnumerable<long>
{
public static readonly long[] Value=A189462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189462.Bytes);
public long this[int i]=>Value[i];

public static A189462Inst Instance=new A189462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189463
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,1L,1L,2L,0L,1L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,1L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,1L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,1L,2L,0L,1L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,1L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189463Inst : IEnumerable<long>
{
public static readonly long[] Value=A189463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189463.Bytes);
public long this[int i]=>Value[i];

public static A189463Inst Instance=new A189463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189464
{
public static readonly long[] Value={ 1L,5L,9L,13L,14L,17L,18L,22L,26L,30L,31L,34L,35L,39L,43L,47L,48L,51L,52L,56L,60L,64L,68L,69L,73L,77L,81L,85L,86L,89L,90L,94L,98L,102L,103L,106L,107L,111L,115L,119L,120L,123L,124L,128L,132L,136L,140L,141L,145L,149L,153L,157L,158L,161L,162L,166L,170L,174L,175L,178L,179L,183L,187L,191L,192L,195L,196L,200L,204L,208L,212L,213L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189464Inst : IEnumerable<long>
{
public static readonly long[] Value=A189464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189464.Bytes);
public long this[int i]=>Value[i];

public static A189464Inst Instance=new A189464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189465
{
public static readonly long[] Value={ 2L,6L,7L,10L,11L,15L,19L,23L,24L,27L,28L,32L,36L,40L,44L,45L,49L,53L,57L,61L,62L,65L,66L,70L,74L,78L,79L,82L,83L,87L,91L,95L,96L,99L,100L,104L,108L,112L,116L,117L,121L,125L,129L,133L,134L,137L,138L,142L,146L,150L,151L,154L,155L,159L,163L,167L,168L,171L,172L,176L,180L,184L,188L,189L,193L,197L,201L,205L,206L,209L,210L,214L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189465Inst : IEnumerable<long>
{
public static readonly long[] Value=A189465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189465.Bytes);
public long this[int i]=>Value[i];

public static A189465Inst Instance=new A189465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189466
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,23L,24L,25L,25L,26L,27L,28L,28L,29L,30L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,38L,38L,39L,39L,40L,41L,41L,42L,42L,43L,43L,44L,44L,46L,46L,46L,47L,47L,48L,49L,49L,50L,50L,51L,51L,52L,52L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189466Inst : IEnumerable<long>
{
public static readonly long[] Value=A189466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189466.Bytes);
public long this[int i]=>Value[i];

public static A189466Inst Instance=new A189466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189467
{
public static readonly long[] Value={ 1L,3L,6L,8L,10L,12L,14L,17L,19L,21L,23L,25L,28L,30L,32L,34L,37L,39L,41L,43L,45L,48L,50L,52L,54L,56L,59L,61L,63L,65L,67L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,92L,94L,96L,98L,101L,103L,105L,107L,109L,112L,114L,116L,118L,120L,123L,125L,127L,129L,131L,134L,136L,138L,140L,142L,145L,147L,149L,151L,153L,156L,158L,160L,162L,165L,167L,169L,171L,173L,176L,178L,180L,182L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189467Inst : IEnumerable<long>
{
public static readonly long[] Value=A189467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189467.Bytes);
public long this[int i]=>Value[i];

public static A189467Inst Instance=new A189467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189500
{
public static readonly long[] Value={ 0L,42L,152L,462L,1088L,2128L,3850L,6474L,10126L,15224L,22180L,30900L,42164L,56514L,73816L,94984L,120700L,150836L,186756L,228696L,276618L,332204L,396444L,467948L,549504L,642000L,744978L,859846L,988550L,1129542L,1286278L,1458874L,1646896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189500Inst : IEnumerable<long>
{
public static readonly long[] Value=A189500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189500.Bytes);
public long this[int i]=>Value[i];

public static A189500Inst Instance=new A189500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189501
{
public static readonly long[] Value={ 12L,136L,928L,3388L,9394L,22088L,45892L,86416L,152136L,251964L,400562L,608572L,895302L,1288110L,1800136L,2460254L,3306706L,4375254L,5709802L,7332744L,9299616L,11690792L,14567750L,17952362L,21909788L,26581910L,32027018L,38302012L,45552824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189501Inst : IEnumerable<long>
{
public static readonly long[] Value=A189501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189501.Bytes);
public long this[int i]=>Value[i];

public static A189501Inst Instance=new A189501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189502
{
public static readonly long[] Value={ 0L,550L,4920L,24806L,85480L,238836L,567774L,1218778L,2397016L,4388664L,7630748L,12628448L,20067182L,30962660L,46263140L,67394664L,96114728L,134386478L,184598554L,249470222L,331776594L,436360316L,567697448L,729535354L,926393324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189502Inst : IEnumerable<long>
{
public static readonly long[] Value=A189502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189502.Bytes);
public long this[int i]=>Value[i];

public static A189502Inst Instance=new A189502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189503
{
public static readonly long[] Value={ 40L,1892L,27508L,182634L,787412L,2642358L,7269852L,17692662L,38791846L,78583484L,149461616L,269390980L,462294730L,765448244L,1224516760L,1898713570L,2870678078L,4243248920L,6141093956L,8731426052L,12179866066L,16758644852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189503Inst : IEnumerable<long>
{
public static readonly long[] Value=A189503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189503.Bytes);
public long this[int i]=>Value[i];

public static A189503Inst Instance=new A189503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189504
{
public static readonly long[] Value={ 0L,7384L,152358L,1350418L,7250142L,29261538L,93830584L,260746932L,640437244L,1434950142L,2985187290L,5855131794L,10847051914L,19293465580L,33015900952L,54518107984L,87418596734L,136633143572L,208413957692L,311534423834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189504Inst : IEnumerable<long>
{
public static readonly long[] Value=A189504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189504.Bytes);
public long this[int i]=>Value[i];

public static A189504Inst Instance=new A189504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189505
{
public static readonly long[] Value={ 140L,26816L,852940L,10077438L,67449574L,326423068L,1218634086L,3870426602L,10678039872L,26541186546L,60515390904L,129217908546L,258501393812L,493822993858L,903540678414L,1589111278140L,2702453254684L,4467233004764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189505Inst : IEnumerable<long>
{
public static readonly long[] Value=A189505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189505.Bytes);
public long this[int i]=>Value[i];

public static A189505Inst Instance=new A189505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189506
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,3L,4L,5L,6L,7L,8L,9L,3L,4L,5L,6L,7L,8L,9L,4L,5L,6L,7L,8L,9L,5L,6L,7L,8L,9L,6L,7L,8L,9L,7L,8L,9L,8L,9L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,30L,40L,50L,60L,70L,80L,90L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189506Inst : IEnumerable<long>
{
public static readonly long[] Value=A189506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189506.Bytes);
public long this[int i]=>Value[i];

public static A189506Inst Instance=new A189506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189507
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,1L,20L,21L,6L,1L,148L,160L,65L,10L,1L,1348L,1620L,701L,155L,15L,1L,15104L,19068L,9324L,2247L,315L,21L,1L,198144L,264420L,138016L,38029L,5908L,574L,28L,1L,2998656L,4166880L,2325740L,692088L,124029L,13524L,966L,36L,1L,51290496L,74011488L,43448940L,13945700L,2723469L,344961L,27930L,1530L,45L,1L,979732224L,1459381440L,897020784L,305142068L,64711856L,8996295L,850905L,53262L,2310L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189507Inst : IEnumerable<long>
{
public static readonly long[] Value=A189507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189507.Bytes);
public long this[int i]=>Value[i];

public static A189507Inst Instance=new A189507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189508
{
public static readonly long[] Value={ 1L,3L,21L,160L,1620L,19068L,264420L,4166880L,74011488L,1459381440L,31674232128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189508Inst : IEnumerable<long>
{
public static readonly long[] Value=A189508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189508.Bytes);
public long this[int i]=>Value[i];

public static A189508Inst Instance=new A189508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189509
{
public static readonly long[] Value={ 1L,6L,65L,701L,9324L,138016L,2325740L,43448940L,897020784L,20241273264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189509Inst : IEnumerable<long>
{
public static readonly long[] Value=A189509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189509.Bytes);
public long this[int i]=>Value[i];

public static A189509Inst Instance=new A189509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189510
{
public static readonly long[] Value={ 1L,1L,4L,9L,4L,2L,9L,7L,1L,9L,1L,5L,9L,4L,7L,9L,7L,8L,9L,1L,4L,9L,4L,2L,9L,7L,1L,9L,1L,5L,9L,4L,7L,9L,7L,8L,9L,1L,4L,9L,4L,2L,9L,7L,1L,9L,1L,5L,9L,4L,7L,9L,7L,8L,9L,1L,4L,9L,4L,2L,9L,7L,1L,9L,1L,5L,9L,4L,7L,9L,7L,8L,9L,1L,4L,9L,4L,2L,9L,7L,1L,9L,1L,5L,9L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189510Inst : IEnumerable<long>
{
public static readonly long[] Value=A189510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189510.Bytes);
public long this[int i]=>Value[i];

public static A189510Inst Instance=new A189510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189511
{
public static readonly long[] Value={ 2L,3L,2L,1L,0L,0L,9L,5L,8L,6L,7L,5L,6L,8L,0L,6L,9L,7L,9L,9L,6L,2L,8L,8L,8L,2L,1L,5L,8L,4L,9L,1L,6L,7L,7L,7L,9L,6L,6L,9L,2L,0L,3L,1L,6L,7L,0L,4L,8L,3L,2L,3L,2L,1L,0L,9L,0L,3L,4L,8L,2L,1L,0L,0L,8L,5L,8L,9L,1L,1L,6L,3L,2L,1L,6L,5L,8L,0L,3L,6L,3L,6L,7L,3L,0L,8L,2L,6L,2L,9L,0L,3L,4L,1L,1L,9L,0L,8L,3L,6L,8L,5L,9L,3L,9L,5L,6L,2L,3L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189511Inst : IEnumerable<long>
{
public static readonly long[] Value=A189511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189511.Bytes);
public long this[int i]=>Value[i];

public static A189511Inst Instance=new A189511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189512
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,23L,26L,30L,32L,35L,38L,41L,44L,47L,50L,53L,56L,60L,63L,65L,68L,71L,74L,77L,80L,83L,87L,90L,93L,95L,98L,101L,104L,107L,110L,113L,117L,120L,123L,126L,128L,131L,134L,137L,140L,143L,147L,150L,153L,156L,159L,161L,164L,167L,170L,174L,177L,180L,183L,186L,189L,191L,194L,197L,200L,204L,207L,210L,213L,216L,219L,222L,224L,227L,230L,234L,237L,240L,243L,246L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189512Inst : IEnumerable<long>
{
public static readonly long[] Value=A189512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189512.Bytes);
public long this[int i]=>Value[i];

public static A189512Inst Instance=new A189512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189513
{
public static readonly long[] Value={ 3L,6L,9L,12L,16L,19L,22L,25L,28L,33L,36L,39L,42L,46L,49L,52L,55L,58L,62L,66L,69L,72L,76L,79L,82L,85L,88L,92L,96L,99L,102L,105L,109L,112L,115L,118L,122L,125L,129L,132L,135L,139L,142L,145L,148L,152L,155L,158L,162L,165L,169L,172L,175L,178L,181L,185L,188L,192L,195L,199L,202L,205L,208L,211L,215L,218L,221L,225L,229L,232L,235L,238L,241L,245L,248L,251L,254L,259L,262L,265L,268L,271L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189513Inst : IEnumerable<long>
{
public static readonly long[] Value=A189513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189513.Bytes);
public long this[int i]=>Value[i];

public static A189513Inst Instance=new A189513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189514
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,15L,18L,21L,24L,27L,29L,31L,34L,37L,40L,43L,45L,48L,51L,54L,57L,59L,61L,64L,67L,70L,73L,75L,78L,81L,84L,86L,89L,91L,94L,97L,100L,103L,106L,108L,111L,114L,116L,119L,121L,124L,127L,130L,133L,136L,138L,141L,144L,146L,149L,151L,154L,157L,160L,163L,166L,168L,171L,173L,176L,179L,182L,184L,187L,190L,193L,196L,198L,201L,203L,206L,209L,212L,214L,217L,220L,223L,226L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189514Inst : IEnumerable<long>
{
public static readonly long[] Value=A189514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189514.Bytes);
public long this[int i]=>Value[i];

public static A189514Inst Instance=new A189514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189515
{
public static readonly long[] Value={ 2L,6L,8L,12L,15L,18L,21L,25L,28L,31L,35L,37L,41L,43L,47L,51L,53L,57L,60L,63L,66L,70L,73L,76L,79L,82L,86L,88L,92L,96L,98L,102L,105L,108L,111L,114L,118L,121L,124L,127L,131L,133L,137L,141L,143L,147L,149L,153L,156L,159L,163L,166L,169L,172L,176L,178L,182L,185L,188L,192L,194L,198L,201L,204L,208L,211L,214L,217L,220L,223L,227L,230L,233L,237L,239L,243L,246L,249L,253L,255L,259L,262L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189515Inst : IEnumerable<long>
{
public static readonly long[] Value=A189515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189515.Bytes);
public long this[int i]=>Value[i];

public static A189515Inst Instance=new A189515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189660
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,4L,4L,4L,4L,5L,5L,5L,6L,7L,8L,8L,9L,10L,10L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,16L,17L,17L,17L,17L,18L,18L,18L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,25L,25L,26L,27L,28L,28L,29L,30L,30L,30L,30L,31L,32L,33L,33L,34L,35L,35L,35L,35L,36L,36L,36L,37L,37L,37L,38L,39L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189660Inst : IEnumerable<long>
{
public static readonly long[] Value=A189660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189660.Bytes);
public long this[int i]=>Value[i];

public static A189660Inst Instance=new A189660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189661
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189661Inst : IEnumerable<long>
{
public static readonly long[] Value=A189661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189661.Bytes);
public long this[int i]=>Value[i];

public static A189661Inst Instance=new A189661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189662
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,10L,11L,13L,14L,16L,18L,19L,21L,23L,24L,26L,27L,29L,31L,32L,34L,35L,37L,39L,40L,42L,44L,45L,47L,48L,50L,52L,53L,55L,57L,58L,60L,61L,63L,65L,66L,68L,69L,71L,73L,74L,76L,78L,79L,81L,82L,84L,86L,87L,89L,90L,92L,94L,95L,97L,99L,100L,102L,103L,105L,107L,108L,110L,112L,113L,115L,116L,118L,120L,121L,123L,124L,126L,128L,129L,131L,133L,134L,136L,137L,139L,141L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189662Inst : IEnumerable<long>
{
public static readonly long[] Value=A189662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189662.Bytes);
public long this[int i]=>Value[i];

public static A189662Inst Instance=new A189662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189663
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,20L,20L,20L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,26L,26L,27L,27L,28L,28L,28L,29L,29L,30L,30L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189663Inst : IEnumerable<long>
{
public static readonly long[] Value=A189663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189663.Bytes);
public long this[int i]=>Value[i];

public static A189663Inst Instance=new A189663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189664
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189664Inst : IEnumerable<long>
{
public static readonly long[] Value=A189664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189664.Bytes);
public long this[int i]=>Value[i];

public static A189664Inst Instance=new A189664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189665
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,10L,12L,13L,15L,16L,17L,19L,21L,22L,23L,25L,27L,28L,30L,31L,32L,34L,36L,37L,39L,40L,41L,43L,45L,46L,48L,49L,51L,52L,53L,55L,57L,58L,59L,61L,63L,64L,66L,67L,69L,70L,71L,73L,75L,76L,77L,79L,81L,82L,84L,85L,86L,88L,90L,91L,93L,94L,96L,97L,98L,100L,102L,103L,104L,106L,108L,109L,111L,112L,113L,115L,117L,118L,120L,121L,123L,124L,125L,127L,129L,130L,131L,133L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189665Inst : IEnumerable<long>
{
public static readonly long[] Value=A189665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189665.Bytes);
public long this[int i]=>Value[i];

public static A189665Inst Instance=new A189665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189666
{
public static readonly long[] Value={ 2L,6L,8L,11L,14L,18L,20L,24L,26L,29L,33L,35L,38L,42L,44L,47L,50L,54L,56L,60L,62L,65L,68L,72L,74L,78L,80L,83L,87L,89L,92L,95L,99L,101L,105L,107L,110L,114L,116L,119L,122L,126L,128L,132L,134L,137L,141L,143L,146L,150L,152L,155L,158L,162L,164L,168L,170L,173L,176L,180L,182L,186L,188L,191L,195L,197L,200L,204L,206L,209L,212L,216L,218L,222L,224L,227L,230L,234L,236L,240L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189666Inst : IEnumerable<long>
{
public static readonly long[] Value=A189666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189666.Bytes);
public long this[int i]=>Value[i];

public static A189666Inst Instance=new A189666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189667
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,17L,18L,18L,19L,19L,19L,19L,20L,20L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,25L,25L,25L,25L,26L,26L,27L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189667Inst : IEnumerable<long>
{
public static readonly long[] Value=A189667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189667.Bytes);
public long this[int i]=>Value[i];

public static A189667Inst Instance=new A189667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189668
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189668Inst : IEnumerable<long>
{
public static readonly long[] Value=A189668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189668.Bytes);
public long this[int i]=>Value[i];

public static A189668Inst Instance=new A189668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189669
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,11L,12L,13L,15L,16L,18L,19L,21L,23L,24L,25L,27L,29L,30L,31L,33L,34L,36L,37L,39L,41L,42L,43L,45L,46L,48L,50L,51L,52L,54L,55L,57L,59L,60L,61L,63L,65L,66L,67L,69L,70L,72L,73L,75L,77L,78L,79L,81L,83L,84L,85L,87L,88L,90L,91L,93L,95L,96L,97L,99L,100L,102L,104L,105L,106L,108L,109L,111L,113L,114L,115L,117L,119L,120L,121L,123L,124L,126L,127L,129L,131L,132L,133L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189669Inst : IEnumerable<long>
{
public static readonly long[] Value=A189669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189669.Bytes);
public long this[int i]=>Value[i];

public static A189669Inst Instance=new A189669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189670
{
public static readonly long[] Value={ 2L,4L,8L,10L,14L,17L,20L,22L,26L,28L,32L,35L,38L,40L,44L,47L,49L,53L,56L,58L,62L,64L,68L,71L,74L,76L,80L,82L,86L,89L,92L,94L,98L,101L,103L,107L,110L,112L,116L,118L,122L,125L,128L,130L,134L,137L,139L,143L,145L,149L,152L,155L,157L,161L,164L,166L,170L,172L,176L,179L,182L,184L,188L,190L,194L,197L,200L,202L,206L,209L,211L,215L,218L,220L,224L,226L,230L,233L,236L,238L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189670Inst : IEnumerable<long>
{
public static readonly long[] Value=A189670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189670.Bytes);
public long this[int i]=>Value[i];

public static A189670Inst Instance=new A189670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189671
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,17L,17L,17L,17L,18L,18L,18L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,22L,22L,23L,23L,23L,24L,24L,24L,25L,25L,26L,26L,26L,26L,27L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189671Inst : IEnumerable<long>
{
public static readonly long[] Value=A189671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189671.Bytes);
public long this[int i]=>Value[i];

public static A189671Inst Instance=new A189671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189672
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,3L,4L,4L,4L,5L,5L,5L,6L,7L,7L,8L,9L,9L,10L,10L,10L,11L,12L,12L,13L,13L,13L,14L,14L,14L,15L,16L,16L,17L,17L,17L,18L,18L,18L,19L,20L,20L,21L,22L,22L,23L,23L,23L,24L,25L,25L,26L,27L,27L,28L,28L,28L,29L,30L,30L,31L,31L,31L,32L,32L,32L,33L,34L,34L,35L,36L,36L,37L,37L,37L,38L,39L,39L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189672Inst : IEnumerable<long>
{
public static readonly long[] Value=A189672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189672.Bytes);
public long this[int i]=>Value[i];

public static A189672Inst Instance=new A189672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189673
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189673Inst : IEnumerable<long>
{
public static readonly long[] Value=A189673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189673.Bytes);
public long this[int i]=>Value[i];

public static A189673Inst Instance=new A189673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189674
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,4L,4L,5L,6L,6L,7L,8L,8L,8L,9L,9L,9L,10L,10L,11L,12L,12L,12L,13L,13L,14L,15L,15L,16L,17L,17L,17L,18L,18L,19L,20L,20L,21L,22L,22L,22L,23L,23L,23L,24L,24L,25L,26L,26L,26L,27L,27L,27L,28L,28L,29L,30L,30L,30L,31L,31L,32L,33L,33L,34L,35L,35L,35L,36L,36L,36L,37L,37L,38L,39L,39L,39L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189674Inst : IEnumerable<long>
{
public static readonly long[] Value=A189674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189674.Bytes);
public long this[int i]=>Value[i];

public static A189674Inst Instance=new A189674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189675
{
public static readonly long[] Value={ 1L,-1L,2L,2L,-4L,3L,-5L,10L,-9L,5L,14L,-28L,27L,-20L,8L,-42L,84L,-84L,70L,-40L,13L,132L,-264L,270L,-240L,160L,-78L,21L,-429L,858L,-891L,825L,-600L,351L,-147L,34L,1430L,-2860L,3003L,-2860L,2200L,-1430L,735L,-272L,55L,-4862L,9724L,-10296L,10010L,-8008L,5577L,-3234L,1496L,-495L,89L,16796L,-33592L,35802L,-35360L,29120L,-21294L,13377L,-7072L,2970L,-890L,144L,-58786L,117572L,-125970L,125970L,-106080L,80444L,-53508L,30940L,-15015L,5785L,-1584L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189675Inst : IEnumerable<long>
{
public static readonly long[] Value=A189675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189675.Bytes);
public long this[int i]=>Value[i];

public static A189675Inst Instance=new A189675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189692
{
public static readonly long[] Value={ 32L,1024L,10327L,107720L,862652L,7174919L,55423132L,437257670L,3370409239L,26229648516L,202524248054L,1569866749149L,12134837088544L,93944044770612L,726545931663671L,5622258695272390L,43490662494731848L,336493987012953931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189692Inst : IEnumerable<long>
{
public static readonly long[] Value=A189692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189692.Bytes);
public long this[int i]=>Value[i];

public static A189692Inst Instance=new A189692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189693
{
public static readonly long[] Value={ 64L,4096L,61996L,997264L,11451149L,140346362L,1553640701L,17872674996L,198287096355L,2240961706438L,24972074224456L,280570140162495L,3134318411211896L,35138150310304642L,392994307064068970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189693Inst : IEnumerable<long>
{
public static readonly long[] Value=A189693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189693.Bytes);
public long this[int i]=>Value[i];

public static A189693Inst Instance=new A189693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189694
{
public static readonly BigInteger[] Value={ 128L,16384L,371641L,9205575L,151788273L,2748122586L,43645304766L,733660344149L,11722251157012L,192737455311869L,3101316117820858L,50582965637175513L,817179337255729430L,13284346442987716235UL,BigInteger.Parse("215031581266863776172") };
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
public class A189694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189694Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189694.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189694.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189694Inst Instance=new A189694Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189695
{
public static readonly BigInteger[] Value={ 256L,65536L,2227333L,84987637L,2010430729L,53801184855L,1226051976034L,30140493826752L,693472588394369L,16601078462607021L,385676526874164679L,9137625077782012475L,BigInteger.Parse("213472003223589754146"),BigInteger.Parse("5034772028641923262353") };
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
public class A189695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189695Inst Instance=new A189695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189696
{
public static readonly long[] Value={ 2L,4L,4L,8L,16L,7L,16L,64L,49L,12L,32L,256L,292L,144L,20L,64L,1024L,1723L,1298L,400L,33L,128L,4096L,10327L,11637L,5172L,1089L,54L,256L,16384L,61996L,107720L,65297L,20316L,2916L,88L,512L,65536L,371641L,997264L,862652L,370045L,77752L,7744L,143L,1024L,262144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189696Inst : IEnumerable<long>
{
public static readonly long[] Value=A189696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189696.Bytes);
public long this[int i]=>Value[i];

public static A189696Inst Instance=new A189696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189697
{
public static readonly long[] Value={ 12L,144L,1298L,11637L,107720L,997264L,9205575L,84987637L,784968276L,7250191247L,66962229085L,618461917882L,5712150826447L,52757783396467L,487273980078400L,4500491954718670L,41566823940472846L,383913783539151670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189697Inst : IEnumerable<long>
{
public static readonly long[] Value=A189697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189697.Bytes);
public long this[int i]=>Value[i];

public static A189697Inst Instance=new A189697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189698
{
public static readonly long[] Value={ 20L,400L,5172L,65297L,862652L,11451149L,151788273L,2010430729L,26638642226L,353018801580L,4678246752829L,61995665582140L,821565095555503L,10887399620742611L,144280214103179733L,1912006322548221320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189698Inst : IEnumerable<long>
{
public static readonly long[] Value=A189698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189698.Bytes);
public long this[int i]=>Value[i];

public static A189698Inst Instance=new A189698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189699
{
public static readonly BigInteger[] Value={ 33L,1089L,20316L,370045L,7174919L,140346362L,2748122586L,53801184855L,1053901033470L,20648231159172L,404572006660088L,7927242763654571L,155332036036173579L,3043718021008444561L,BigInteger.Parse("59641726902710453442") };
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
public class A189699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189699Inst Instance=new A189699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189700
{
public static readonly BigInteger[] Value={ 54L,2916L,77752L,1999150L,55423132L,1553640701L,43645304766L,1226051976034L,34463827972461L,968925997882076L,27242280161913994L,765954539776147015L,BigInteger.Parse("21536381951216338725"),BigInteger.Parse("605544975017743747314"),BigInteger.Parse("17026369106775648529847") };
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
public class A189700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189700Inst Instance=new A189700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189701
{
public static readonly BigInteger[] Value={ 88L,7744L,295720L,10867960L,437257670L,17872674996L,733660344149L,30140493826752L,1239562062347534L,50994136275721816L,2098158626051989039L,BigInteger.Parse("86335489832805005659"),BigInteger.Parse("3552764734604163177272"),BigInteger.Parse("146202547786505491839949") };
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
public class A189701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189701.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189701Inst Instance=new A189701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189702
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189702Inst : IEnumerable<long>
{
public static readonly long[] Value=A189702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189702.Bytes);
public long this[int i]=>Value[i];

public static A189702Inst Instance=new A189702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189703
{
public static readonly long[] Value={ 1L,5L,7L,9L,10L,14L,15L,19L,20L,23L,27L,29L,31L,32L,35L,39L,41L,43L,44L,47L,51L,53L,54L,58L,60L,62L,63L,67L,68L,72L,73L,76L,80L,82L,83L,87L,89L,91L,92L,96L,97L,101L,102L,105L,109L,111L,112L,116L,118L,120L,121L,125L,126L,129L,133L,135L,137L,138L,142L,143L,147L,148L,151L,155L,157L,159L,160L,163L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189703Inst : IEnumerable<long>
{
public static readonly long[] Value=A189703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189703.Bytes);
public long this[int i]=>Value[i];

public static A189703Inst Instance=new A189703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189704
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,11L,12L,13L,16L,17L,18L,21L,22L,24L,25L,26L,28L,30L,33L,34L,36L,37L,38L,40L,42L,45L,46L,48L,49L,50L,52L,55L,56L,57L,59L,61L,64L,65L,66L,69L,70L,71L,74L,75L,77L,78L,79L,81L,84L,85L,86L,88L,90L,93L,94L,95L,98L,99L,100L,103L,104L,106L,107L,108L,110L,113L,114L,115L,117L,119L,122L,123L,124L,127L,128L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189704Inst : IEnumerable<long>
{
public static readonly long[] Value=A189704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189704.Bytes);
public long this[int i]=>Value[i];

public static A189704Inst Instance=new A189704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189705
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,7L,8L,8L,8L,9L,10L,11L,11L,11L,12L,13L,13L,14L,15L,16L,16L,17L,17L,18L,18L,18L,19L,20L,20L,21L,22L,23L,23L,24L,24L,25L,25L,25L,26L,27L,27L,28L,29L,30L,30L,31L,31L,31L,32L,33L,34L,34L,35L,35L,36L,36L,36L,37L,38L,39L,39L,39L,40L,41L,42L,42L,42L,43L,44L,44L,45L,46L,47L,47L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189705Inst : IEnumerable<long>
{
public static readonly long[] Value=A189705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189705.Bytes);
public long this[int i]=>Value[i];

public static A189705Inst Instance=new A189705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189706
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189706Inst : IEnumerable<long>
{
public static readonly long[] Value=A189706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189706.Bytes);
public long this[int i]=>Value[i];

public static A189706Inst Instance=new A189706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189707
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,10L,13L,16L,17L,19L,22L,25L,26L,28L,31L,32L,34L,35L,37L,40L,41L,43L,44L,46L,49L,52L,53L,55L,58L,59L,61L,62L,64L,67L,68L,70L,71L,73L,76L,79L,80L,82L,85L,86L,88L,89L,91L,94L,97L,98L,100L,103L,106L,107L,109L,112L,113L,115L,116L,118L,121L,124L,125L,127L,130L,133L,134L,136L,139L,140L,142L,143L,145L,148L,149L,151L,152L,154L,157L,160L,161L,163L,166L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189707Inst : IEnumerable<long>
{
public static readonly long[] Value=A189707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189707.Bytes);
public long this[int i]=>Value[i];

public static A189707Inst Instance=new A189707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189724
{
public static readonly long[] Value={ 1L,5L,8L,11L,13L,17L,20L,22L,26L,29L,31L,35L,37L,41L,44L,47L,49L,53L,56L,58L,62L,64L,68L,71L,74L,76L,80L,83L,85L,89L,91L,95L,98L,101L,103L,107L,109L,113L,116L,119L,121L,125L,128L,130L,134L,137L,139L,143L,145L,149L,152L,155L,157L,161L,164L,166L,170L,172L,176L,179L,182L,184L,188L,190L,194L,197L,200L,202L,206L,209L,211L,215L,218L,220L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189724Inst : IEnumerable<long>
{
public static readonly long[] Value=A189724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189724.Bytes);
public long this[int i]=>Value[i];

public static A189724Inst Instance=new A189724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189725
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,9L,10L,12L,14L,15L,16L,18L,19L,21L,23L,24L,25L,27L,28L,30L,32L,33L,34L,36L,38L,39L,40L,42L,43L,45L,46L,48L,50L,51L,52L,54L,55L,57L,59L,60L,61L,63L,65L,66L,67L,69L,70L,72L,73L,75L,77L,78L,79L,81L,82L,84L,86L,87L,88L,90L,92L,93L,94L,96L,97L,99L,100L,102L,104L,105L,106L,108L,110L,111L,112L,114L,115L,117L,118L,120L,122L,123L,124L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189725Inst : IEnumerable<long>
{
public static readonly long[] Value=A189725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189725.Bytes);
public long this[int i]=>Value[i];

public static A189725Inst Instance=new A189725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189726
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,8L,9L,10L,11L,11L,12L,13L,13L,14L,14L,15L,16L,17L,17L,18L,19L,19L,20L,20L,21L,22L,23L,23L,24L,24L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,32L,33L,34L,35L,35L,36L,37L,37L,38L,38L,39L,40L,41L,41L,42L,42L,43L,44L,45L,45L,46L,47L,47L,48L,49L,49L,50L,50L,51L,52L,53L,53L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189726Inst : IEnumerable<long>
{
public static readonly long[] Value=A189726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189726.Bytes);
public long this[int i]=>Value[i];

public static A189726Inst Instance=new A189726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189727
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189727Inst : IEnumerable<long>
{
public static readonly long[] Value=A189727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189727.Bytes);
public long this[int i]=>Value[i];

public static A189727Inst Instance=new A189727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189728
{
public static readonly long[] Value={ 1L,6L,9L,12L,15L,16L,21L,24L,25L,30L,33L,34L,39L,42L,43L,46L,51L,54L,57L,60L,61L,66L,69L,70L,73L,78L,81L,84L,87L,88L,93L,96L,97L,100L,105L,108L,111L,114L,115L,120L,123L,124L,127L,132L,135L,136L,141L,144L,147L,150L,151L,156L,159L,160L,165L,168L,169L,174L,177L,178L,181L,186L,189L,192L,195L,196L,201L,204L,205L,208L,213L,216L,217L,222L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189728Inst : IEnumerable<long>
{
public static readonly long[] Value=A189728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189728.Bytes);
public long this[int i]=>Value[i];

public static A189728Inst Instance=new A189728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189729
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,10L,11L,13L,14L,17L,18L,19L,20L,22L,23L,26L,27L,28L,29L,31L,32L,35L,36L,37L,38L,40L,41L,44L,45L,47L,48L,49L,50L,52L,53L,55L,56L,58L,59L,62L,63L,64L,65L,67L,68L,71L,72L,74L,75L,76L,77L,79L,80L,82L,83L,85L,86L,89L,90L,91L,92L,94L,95L,98L,99L,101L,102L,103L,104L,106L,107L,109L,110L,112L,113L,116L,117L,118L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189729Inst : IEnumerable<long>
{
public static readonly long[] Value=A189729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189729.Bytes);
public long this[int i]=>Value[i];

public static A189729Inst Instance=new A189729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189730
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,10L,10L,10L,11L,12L,13L,14L,14L,15L,16L,16L,16L,17L,18L,19L,20L,20L,21L,22L,22L,22L,23L,24L,25L,26L,26L,27L,28L,28L,28L,29L,30L,30L,31L,32L,33L,34L,34L,35L,36L,36L,37L,38L,38L,39L,40L,40L,40L,41L,42L,43L,44L,44L,45L,46L,46L,46L,47L,48L,48L,49L,50L,51L,52L,52L,53L,54L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189730Inst : IEnumerable<long>
{
public static readonly long[] Value=A189730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189730.Bytes);
public long this[int i]=>Value[i];

public static A189730Inst Instance=new A189730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189731
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,17L,4L,23L,25L,61L,18L,107L,40L,421L,1363L,1103L,210L,5777L,492L,7563L,24475L,19801L,2786L,103681L,33552L,135721L,146401L,355323L,39650L,1860497L,97108L,2435423L,2627065L,6376021L,20633238L,11128427L,1459960L,43701901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189731Inst : IEnumerable<long>
{
public static readonly long[] Value=A189731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189731.Bytes);
public long this[int i]=>Value[i];

public static A189731Inst Instance=new A189731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189732
{
public static readonly long[] Value={ 1L,5L,10L,35L,85L,260L,685L,1985L,5410L,15335L,42385L,119060L,330985L,926285L,2581210L,7212635L,20118685L,56181860L,156775285L,437684585L,1221561010L,3409983935L,9517788985L,26567708660L,74156653585L,206995196885L,577778464810L,1612754449235L,4501646773285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189732Inst : IEnumerable<long>
{
public static readonly long[] Value=A189732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189732.Bytes);
public long this[int i]=>Value[i];

public static A189732Inst Instance=new A189732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189733
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,6L,1L,4L,3L,5L,1L,12L,1L,7L,5L,8L,1L,18L,1L,10L,7L,11L,1L,24L,1L,13L,9L,14L,1L,30L,1L,16L,11L,17L,1L,36L,1L,19L,13L,20L,1L,42L,1L,22L,15L,23L,1L,48L,1L,25L,17L,26L,1L,54L,1L,28L,19L,29L,1L,60L,1L,31L,21L,32L,1L,66L,1L,34L,23L,35L,1L,72L,1L,37L,25L,38L,1L,78L,1L,40L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189733Inst : IEnumerable<long>
{
public static readonly long[] Value=A189733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189733.Bytes);
public long this[int i]=>Value[i];

public static A189733Inst Instance=new A189733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189734
{
public static readonly long[] Value={ 2L,5L,20L,65L,230L,785L,2720L,9365L,32330L,111485L,384620L,1326665L,4576430L,15786185L,54454520L,187839965L,647952530L,2235104885L,7709972420L,26595469265L,91740800630L,316458947585L,1091621898320L,3765538534565L,12989186560730L,44806065794285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189734Inst : IEnumerable<long>
{
public static readonly long[] Value=A189734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189734.Bytes);
public long this[int i]=>Value[i];

public static A189734Inst Instance=new A189734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189735
{
public static readonly long[] Value={ 3L,1L,6L,19L,63L,208L,687L,2269L,7494L,24751L,81747L,269992L,891723L,2945161L,9727206L,32126779L,106107543L,350449408L,1157455767L,3822816709L,12625905894L,41700534391L,137727509067L,454883061592L,1502376693843L,4962013143121L,16388416123206L,54127261512739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189735Inst : IEnumerable<long>
{
public static readonly long[] Value=A189735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189735.Bytes);
public long this[int i]=>Value[i];

public static A189735Inst Instance=new A189735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189736
{
public static readonly long[] Value={ 3L,2L,12L,40L,144L,512L,1824L,6496L,23136L,82400L,293472L,1045216L,3722592L,13258208L,47219808L,168175840L,598967136L,2133253088L,7597693536L,27059586784L,96374147424L,343241615840L,1222473142368L,4353902658784L,15506654261088L,55227768100832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189736Inst : IEnumerable<long>
{
public static readonly long[] Value=A189736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189736.Bytes);
public long this[int i]=>Value[i];

public static A189736Inst Instance=new A189736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189737
{
public static readonly long[] Value={ 3L,3L,18L,63L,243L,918L,3483L,13203L,50058L,189783L,719523L,2727918L,10342323L,39210723L,148659138L,563609583L,2136806163L,8101247238L,30714160203L,116446222323L,441481147578L,1673782109703L,6345789771843L,24058715644638L,91213516249443L,345816695682243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189737Inst : IEnumerable<long>
{
public static readonly long[] Value=A189737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189737.Bytes);
public long this[int i]=>Value[i];

public static A189737Inst Instance=new A189737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189738
{
public static readonly long[] Value={ 3L,4L,24L,88L,360L,1432L,5736L,22936L,91752L,367000L,1468008L,5872024L,23488104L,93952408L,375809640L,1503238552L,6012954216L,24051816856L,96207267432L,384829069720L,1539316278888L,6157265115544L,24629060462184L,98516241848728L,394064967394920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189738Inst : IEnumerable<long>
{
public static readonly long[] Value=A189738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189738.Bytes);
public long this[int i]=>Value[i];

public static A189738Inst Instance=new A189738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189739
{
public static readonly long[] Value={ 3L,5L,30L,115L,495L,2060L,8655L,36265L,152070L,637535L,2672955L,11206540L,46984395L,196985885L,825879630L,3462568315L,14517103095L,60864150860L,255177968055L,1069854658465L,4485453815670L,18805634739335L,78844173296355L,330560693585740L,1385902947238995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189739Inst : IEnumerable<long>
{
public static readonly long[] Value=A189739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189739.Bytes);
public long this[int i]=>Value[i];

public static A189739Inst Instance=new A189739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189756
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,14L,15L,18L,20L,23L,25L,28L,30L,32L,35L,37L,40L,42L,44L,46L,49L,51L,54L,56L,59L,61L,63L,66L,68L,71L,73L,75L,77L,80L,82L,85L,87L,89L,92L,94L,97L,99L,102L,104L,106L,108L,111L,113L,116L,119L,120L,123L,125L,128L,130L,133L,134L,137L,139L,142L,144L,147L,150L,151L,154L,156L,159L,161L,164L,165L,168L,170L,173L,175L,178L,180L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189756Inst : IEnumerable<long>
{
public static readonly long[] Value=A189756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189756.Bytes);
public long this[int i]=>Value[i];

public static A189756Inst Instance=new A189756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189757
{
public static readonly long[] Value={ 2L,5L,7L,10L,13L,16L,19L,22L,24L,27L,31L,33L,36L,38L,41L,45L,47L,50L,53L,55L,58L,62L,64L,67L,70L,72L,76L,78L,81L,84L,86L,90L,93L,95L,98L,101L,103L,107L,110L,112L,115L,117L,121L,124L,126L,129L,132L,135L,138L,141L,143L,146L,149L,152L,155L,157L,160L,163L,166L,169L,172L,174L,177L,181L,183L,186L,189L,191L,194L,197L,200L,203L,205L,208L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189757Inst : IEnumerable<long>
{
public static readonly long[] Value=A189757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189757.Bytes);
public long this[int i]=>Value[i];

public static A189757Inst Instance=new A189757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189758
{
public static readonly long[] Value={ 3L,8L,12L,17L,21L,26L,29L,34L,39L,43L,48L,52L,57L,60L,65L,69L,74L,79L,83L,88L,91L,96L,100L,105L,109L,114L,118L,122L,127L,131L,136L,140L,145L,148L,153L,158L,162L,167L,171L,176L,179L,184L,188L,193L,198L,202L,206L,210L,215L,219L,224L,228L,233L,237L,241L,246L,250L,255L,259L,264L,268L,272L,277L,281L,286L,290L,295L,298L,303L,308L,312L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189758Inst : IEnumerable<long>
{
public static readonly long[] Value=A189758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189758.Bytes);
public long this[int i]=>Value[i];

public static A189758Inst Instance=new A189758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189759
{
public static readonly long[] Value={ 30L,42L,66L,70L,78L,105L,114L,130L,154L,165L,174L,182L,222L,231L,238L,246L,255L,273L,282L,285L,286L,310L,318L,345L,357L,366L,370L,385L,399L,418L,430L,434L,442L,455L,465L,474L,483L,494L,498L,518L,555L,561L,574L,582L,595L,602L,609L,618L,642L,645L,651L,663L,665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189759Inst : IEnumerable<long>
{
public static readonly long[] Value=A189759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189759.Bytes);
public long this[int i]=>Value[i];

public static A189759Inst Instance=new A189759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189760
{
public static readonly long[] Value={ 0L,1L,2L,6L,9L,14L,33L,62L,177L,414L,1155L,1719L,2625L,4018L,6849L,9770L,17675L,30206L,90609L,260343L,336006L,757995L,1290874L,2029875L,4059746L,7037655L,17594075L,50850483L,68589598L,186888243L,373659254L,1884639669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189760Inst : IEnumerable<long>
{
public static readonly long[] Value=A189760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189760.Bytes);
public long this[int i]=>Value[i];

public static A189760Inst Instance=new A189760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189761
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,11L,21L,29L,55L,76L,144L,199L,377L,521L,987L,1364L,2584L,3571L,6765L,9349L,17711L,24476L,46368L,64079L,121393L,167761L,317811L,439204L,832040L,1149851L,2178309L,3010349L,5702887L,7881196L,14930352L,20633239L,39088169L,54018521L,102334155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189761Inst : IEnumerable<long>
{
public static readonly long[] Value=A189761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189761.Bytes);
public long this[int i]=>Value[i];

public static A189761Inst Instance=new A189761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189762
{
public static readonly long[] Value={ 0L,6L,10L,14L,0L,22L,26L,0L,34L,38L,0L,46L,27L,0L,58L,62L,0L,0L,74L,42L,82L,86L,0L,94L,63L,0L,106L,0L,70L,118L,122L,0L,0L,134L,105L,142L,146L,98L,0L,158L,0L,166L,117L,0L,178L,0L,175L,0L,194L,130L,202L,206L,0L,214L,218L,154L,226L,0L,245L,138L,171L,0L,0L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189762Inst : IEnumerable<long>
{
public static readonly long[] Value=A189762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189762.Bytes);
public long this[int i]=>Value[i];

public static A189762Inst Instance=new A189762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189763
{
public static readonly long[] Value={ 12L,16L,24L,32L,44L,48L,56L,60L,68L,72L,80L,92L,96L,108L,112L,120L,124L,128L,140L,152L,156L,162L,164L,168L,176L,188L,192L,212L,216L,220L,236L,240L,244L,248L,252L,272L,284L,288L,296L,316L,318L,320L,324L,332L,336L,350L,356L,360L,368L,378L,380L,384L,392L,408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189763Inst : IEnumerable<long>
{
public static readonly long[] Value=A189763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189763.Bytes);
public long this[int i]=>Value[i];

public static A189763Inst Instance=new A189763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189764
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,8L,0L,12L,0L,0L,0L,20L,0L,0L,0L,28L,0L,0L,0L,0L,0L,24L,0L,44L,0L,0L,0L,52L,0L,36L,0L,0L,0L,40L,0L,68L,0L,0L,0L,76L,0L,0L,0L,0L,0L,60L,0L,92L,0L,0L,0L,0L,0L,81L,0L,48L,0L,0L,0L,116L,0L,84L,0L,124L,0L,0L,0L,0L,0L,100L,0L,0L,0L,0L,0L,148L,0L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189764Inst : IEnumerable<long>
{
public static readonly long[] Value=A189764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189764.Bytes);
public long this[int i]=>Value[i];

public static A189764Inst Instance=new A189764Inst();

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