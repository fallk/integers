using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A189999
{
public static readonly long[] Value={ 3L,7L,10L,14L,17L,22L,25L,29L,32L,36L,39L,44L,48L,51L,55L,58L,62L,66L,70L,73L,77L,80L,85L,89L,92L,96L,99L,103L,107L,111L,114L,118L,121L,125L,130L,133L,137L,140L,144L,148L,152L,155L,159L,162L,166L,170L,174L,178L,181L,185L,188L,193L,196L,200L,203L,207L,210L,215L,219L,222L,226L,229L,234L,237L,241L,244L,248L,251L,256L,260L,263L,267L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189999Inst : IEnumerable<long>
{
public static readonly long[] Value=A189999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189999.Bytes);
public long this[int i]=>Value[i];

public static A189999Inst Instance=new A189999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190000
{
public static readonly long[] Value={ 2L,5L,8L,12L,15L,18L,21L,24L,27L,31L,34L,37L,41L,43L,46L,50L,53L,56L,59L,63L,65L,68L,72L,75L,78L,82L,84L,87L,91L,94L,97L,101L,104L,106L,109L,113L,116L,119L,123L,126L,128L,132L,135L,138L,142L,145L,147L,151L,154L,157L,160L,164L,167L,169L,173L,176L,179L,183L,186L,189L,192L,195L,198L,202L,205L,208L,211L,214L,217L,220L,224L,227L,230L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190000Inst : IEnumerable<long>
{
public static readonly long[] Value=A190000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190000.Bytes);
public long this[int i]=>Value[i];

public static A190000Inst Instance=new A190000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190001
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,13L,16L,19L,20L,23L,26L,28L,30L,33L,35L,38L,40L,42L,45L,47L,49L,52L,54L,57L,60L,61L,64L,67L,69L,71L,74L,76L,79L,81L,83L,86L,88L,90L,93L,95L,98L,100L,102L,105L,108L,110L,112L,115L,117L,120L,122L,124L,127L,129L,131L,134L,136L,139L,141L,143L,146L,149L,150L,153L,156L,158L,161L,163L,165L,168L,171L,172L,175L,177L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190001Inst : IEnumerable<long>
{
public static readonly long[] Value=A190001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190001.Bytes);
public long this[int i]=>Value[i];

public static A190001Inst Instance=new A190001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190002
{
public static readonly long[] Value={ 4L,8L,14L,18L,22L,28L,32L,38L,42L,46L,52L,56L,60L,66L,70L,76L,80L,84L,90L,94L,100L,104L,108L,114L,118L,122L,128L,132L,138L,142L,146L,152L,156L,160L,166L,170L,176L,180L,184L,190L,194L,200L,204L,208L,214L,218L,222L,228L,232L,238L,242L,246L,252L,256L,260L,266L,270L,276L,280L,284L,290L,294L,300L,304L,308L,314L,318L,322L,328L,332L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190002Inst : IEnumerable<long>
{
public static readonly long[] Value=A190002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190002.Bytes);
public long this[int i]=>Value[i];

public static A190002Inst Instance=new A190002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190003
{
public static readonly long[] Value={ 2L,6L,10L,12L,16L,20L,24L,26L,30L,34L,36L,40L,44L,48L,50L,54L,58L,62L,64L,68L,72L,74L,78L,82L,86L,88L,92L,96L,98L,102L,106L,110L,112L,116L,120L,124L,126L,130L,134L,136L,140L,144L,148L,150L,154L,158L,162L,164L,168L,172L,174L,178L,182L,186L,188L,192L,196L,198L,202L,206L,210L,212L,216L,220L,224L,226L,230L,234L,236L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190003Inst : IEnumerable<long>
{
public static readonly long[] Value=A190003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190003.Bytes);
public long this[int i]=>Value[i];

public static A190003Inst Instance=new A190003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190004
{
public static readonly long[] Value={ 2L,4L,7L,9L,11L,14L,16L,19L,21L,23L,26L,28L,30L,33L,35L,38L,40L,42L,45L,47L,50L,52L,54L,57L,59L,61L,64L,66L,69L,71L,73L,76L,78L,80L,83L,85L,88L,90L,92L,95L,97L,100L,102L,104L,107L,109L,111L,114L,116L,119L,121L,123L,126L,128L,130L,133L,135L,138L,140L,142L,145L,147L,150L,152L,154L,157L,159L,161L,164L,166L,169L,171L,173L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190004Inst : IEnumerable<long>
{
public static readonly long[] Value=A190004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190004.Bytes);
public long this[int i]=>Value[i];

public static A190004Inst Instance=new A190004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190005
{
public static readonly long[] Value={ 0L,1L,6L,46L,336L,2476L,18216L,134056L,986496L,7259536L,53422176L,393128416L,2892992256L,21289237696L,156665348736L,1152884469376L,8483960303616L,62432606515456L,459435242128896L,3380937517927936L,24879977528856576L,183089240352418816L,1347335217403078656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190005Inst : IEnumerable<long>
{
public static readonly long[] Value=A190005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190005.Bytes);
public long this[int i]=>Value[i];

public static A190005Inst Instance=new A190005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190006
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,21L,23L,26L,29L,32L,35L,39L,42L,44L,47L,50L,53L,56L,60L,63L,66L,68L,71L,74L,78L,81L,84L,87L,89L,92L,95L,99L,102L,105L,108L,111L,113L,117L,120L,123L,126L,129L,132L,134L,138L,141L,144L,147L,150L,153L,157L,159L,162L,165L,168L,171L,174L,178L,180L,183L,186L,189L,192L,196L,199L,202L,204L,207L,210L,213L,217L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190006Inst : IEnumerable<long>
{
public static readonly long[] Value=A190006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190006.Bytes);
public long this[int i]=>Value[i];

public static A190006Inst Instance=new A190006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190007
{
public static readonly long[] Value={ 3L,6L,10L,13L,16L,20L,24L,27L,31L,34L,37L,41L,45L,48L,52L,55L,58L,62L,65L,69L,73L,76L,79L,83L,86L,90L,94L,97L,100L,104L,107L,110L,115L,118L,121L,125L,128L,131L,136L,139L,142L,146L,149L,152L,156L,160L,163L,167L,170L,173L,177L,181L,184L,188L,191L,194L,198L,201L,205L,209L,212L,215L,219L,222L,226L,230L,233L,236L,240L,243L,246L,251L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190007Inst : IEnumerable<long>
{
public static readonly long[] Value=A190007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190007.Bytes);
public long this[int i]=>Value[i];

public static A190007Inst Instance=new A190007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190008
{
public static readonly long[] Value={ 1L,4L,7L,10L,12L,15L,18L,20L,22L,25L,28L,31L,33L,36L,38L,41L,43L,46L,49L,52L,54L,57L,59L,62L,64L,67L,70L,73L,75L,77L,80L,83L,85L,88L,91L,94L,96L,98L,101L,104L,106L,109L,112L,115L,116L,119L,122L,125L,127L,130L,133L,136L,137L,140L,143L,146L,148L,151L,154L,156L,158L,161L,164L,167L,169L,172L,175L,177L,179L,182L,185L,188L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190008Inst : IEnumerable<long>
{
public static readonly long[] Value=A190008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190008.Bytes);
public long this[int i]=>Value[i];

public static A190008Inst Instance=new A190008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190009
{
public static readonly long[] Value={ 1L,1L,3L,9L,49L,237L,1739L,11557L,105313L,886201L,9596211L,97408641L,1218112465L,14446293669L,204461028347L,2769624924637L,43702453433281L,664858164527089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190009Inst : IEnumerable<long>
{
public static readonly long[] Value=A190009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190009.Bytes);
public long this[int i]=>Value[i];

public static A190009Inst Instance=new A190009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190010
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,73L,537L,3899L,35623L,345553L,3767185L,44993331L,575013087L,8040614041L,118459611753L,1883371991531L,31449522256183L,558550869727393L,10410156829764769L,204093418753532259L,4191381846930998319L,BigInteger.Parse("89889103856588434921") };
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
public class A190010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190010Inst Instance=new A190010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190011
{
public static readonly long[] Value={ 4320L,6048L,9504L,9720L,11232L,12000L,13608L,14688L,16416L,19872L,21384L,25056L,25272L,26784L,28000L,31968L,32928L,33048L,35424L,36936L,37152L,40608L,44000L,44712L,45792L,50976L,52000L,52704L,54880L,56376L,57888L,60264L,60750L,61344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190011Inst : IEnumerable<long>
{
public static readonly long[] Value=A190011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190011.Bytes);
public long this[int i]=>Value[i];

public static A190011Inst Instance=new A190011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190060
{
public static readonly long[] Value={ 4L,10L,16L,21L,27L,33L,38L,44L,50L,55L,60L,66L,72L,77L,83L,89L,94L,100L,105L,111L,116L,122L,128L,133L,139L,145L,150L,156L,161L,167L,172L,178L,184L,189L,195L,201L,206L,211L,217L,223L,228L,234L,240L,245L,251L,257L,262L,267L,273L,279L,284L,290L,296L,301L,307L,313L,317L,323L,329L,335L,340L,346L,352L,357L,363L,369L,373L,379L,385L,391L,396L,402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190060Inst : IEnumerable<long>
{
public static readonly long[] Value=A190060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190060.Bytes);
public long this[int i]=>Value[i];

public static A190060Inst Instance=new A190060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190061
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,11L,13L,14L,17L,18L,20L,23L,24L,26L,28L,30L,31L,34L,36L,37L,40L,41L,43L,46L,47L,49L,51L,53L,56L,57L,59L,61L,63L,64L,67L,69L,70L,73L,74L,76L,79L,80L,82L,84L,86L,88L,90L,92L,93L,96L,97L,99L,102L,103L,106L,107L,109L,112L,113L,115L,117L,119L,121L,123L,125L,126L,129L,130L,132L,135L,136L,138L,140L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190061Inst : IEnumerable<long>
{
public static readonly long[] Value=A190061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190061.Bytes);
public long this[int i]=>Value[i];

public static A190061Inst Instance=new A190061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190062
{
public static readonly long[] Value={ 0L,1L,1L,4L,8L,18L,36L,71L,135L,252L,462L,836L,1496L,2653L,4669L,8164L,14196L,24566L,42332L,72675L,124355L,212156L,360986L,612744L,1037808L,1754233L,2959801L,4985476L,8384480L,14080602L,23614932L,39556031L,66181311L,110608188L,184670694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190062Inst : IEnumerable<long>
{
public static readonly long[] Value=A190062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190062.Bytes);
public long this[int i]=>Value[i];

public static A190062Inst Instance=new A190062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190063
{
public static readonly BigInteger[] Value={ 0L,12L,166L,3481L,88509L,2783714L,101530262L,4232955454L,198636188057L,10408538943146L,603033909983829L,38103929980500423L,2608648993698684772L,BigInteger.Parse("193359775333060165517"),BigInteger.Parse("15364574547397697984616"),BigInteger.Parse("1301880431718317296701496") };
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
public class A190063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190063.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190063Inst Instance=new A190063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190064
{
public static readonly long[] Value={ 2L,12L,40L,144L,550L,1896L,7584L,27328L,105348L,398760L,1538696L,5872800L,22646862L,87492676L,339055650L,1313842904L,5104724558L,19873572892L,77470783406L,302258087616L,1180840902336L,4618922848536L,18083348822516L,70852652846320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190064Inst : IEnumerable<long>
{
public static readonly long[] Value=A190064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190064.Bytes);
public long this[int i]=>Value[i];

public static A190064Inst Instance=new A190064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190065
{
public static readonly long[] Value={ 6L,36L,166L,922L,5136L,28656L,162028L,910716L,5162308L,29554964L,169886511L,978214225L,5650347932L,32745824773L,190185910978L,1106505067832L,6449387884888L,37654438607875L,220148079884339L,1288689800220653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190065Inst : IEnumerable<long>
{
public static readonly long[] Value=A190065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190065.Bytes);
public long this[int i]=>Value[i];

public static A190065Inst Instance=new A190065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190066
{
public static readonly long[] Value={ 12L,76L,483L,3481L,25306L,191456L,1436962L,10802667L,81709584L,622881909L,4769974211L,36631166224L,282173132213L,2179898773167L,16878487835945L,130935467642770L,1017555976447868L,7920656405513158L,61741451812499715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190066Inst : IEnumerable<long>
{
public static readonly long[] Value=A190066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190066.Bytes);
public long this[int i]=>Value[i];

public static A190066Inst Instance=new A190066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190067
{
public static readonly long[] Value={ 20L,143L,1126L,9904L,88509L,834717L,7843113L,73725405L,697624797L,6644826507L,63556636483L,609902716100L,5871497904831L,56683948490522L,548487091412193L,5317814454716839L,51651465543152430L,502495332741155890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190067Inst : IEnumerable<long>
{
public static readonly long[] Value=A190067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190067.Bytes);
public long this[int i]=>Value[i];

public static A190067Inst Instance=new A190067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190068
{
public static readonly long[] Value={ 30L,233L,2276L,23400L,249119L,2783714L,31391655L,353856100L,4017545773L,45918810745L,526830982562L,6064138473938L,70033913982429L,811112118405079L,9415846493673903L,109526722276860886L,1276368965090149581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190068Inst : IEnumerable<long>
{
public static readonly long[] Value=A190068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190068.Bytes);
public long this[int i]=>Value[i];

public static A190068Inst Instance=new A190068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190069
{
public static readonly long[] Value={ 42L,366L,4150L,48491L,599181L,7737762L,101530262L,1333341624L,17643516841L,235162515839L,3146321736755L,42232649776342L,568807797004946L,7683091138249061L,104022021281511319L,1411291383524511348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190069Inst : IEnumerable<long>
{
public static readonly long[] Value=A190069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190069.Bytes);
public long this[int i]=>Value[i];

public static A190069Inst Instance=new A190069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190070
{
public static readonly ulong[] Value={ 56L,536L,6946L,92478L,1291797L,18951546L,282859251L,4232955454L,63898862902L,972408511316L,14859125421285L,227805216299376L,3504714306481893L,54079878634478640L,836480995724826396L,12965711458798193610UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190070Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A190070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190070.Bytes);
public ulong this[int i]=>Value[i];

public static A190070Inst Instance=new A190070Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190071
{
public static readonly long[] Value={ 0L,2L,4L,6L,12L,0L,12L,36L,40L,12L,20L,76L,166L,144L,0L,30L,143L,483L,922L,550L,40L,42L,233L,1126L,3481L,5136L,1896L,0L,56L,366L,2276L,9904L,25306L,28656L,7584L,140L,72L,536L,4150L,23400L,88509L,191456L,162028L,27328L,0L,90L,760L,6946L,48491L,249119L,834717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190071Inst : IEnumerable<long>
{
public static readonly long[] Value=A190071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190071.Bytes);
public long this[int i]=>Value[i];

public static A190071Inst Instance=new A190071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190072
{
public static readonly long[] Value={ 4L,12L,36L,76L,143L,233L,366L,536L,760L,1028L,1363L,1751L,2221L,2758L,3387L,4096L,4907L,5804L,6819L,7931L,9174L,10525L,12021L,13631L,15401L,17299L,19366L,21572L,23959L,26490L,29220L,32114L,35210L,38476L,41963L,45629L,49527L,53618L,57953L,62489L,67285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190072Inst : IEnumerable<long>
{
public static readonly long[] Value=A190072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190072.Bytes);
public long this[int i]=>Value[i];

public static A190072Inst Instance=new A190072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190073
{
public static readonly long[] Value={ 0L,40L,166L,483L,1126L,2276L,4150L,6946L,10909L,16353L,23728L,33290L,45591L,61100L,80161L,103121L,130833L,163649L,202441L,247746L,300269L,360694L,430361L,508989L,598090L,698534L,811133L,936287L,1075989L,1230312L,1401309L,1589246L,1795222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190073Inst : IEnumerable<long>
{
public static readonly long[] Value=A190073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190073.Bytes);
public long this[int i]=>Value[i];

public static A190073Inst Instance=new A190073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190074
{
public static readonly long[] Value={ 12L,144L,922L,3481L,9904L,23400L,48491L,92478L,162599L,270267L,430274L,655974L,965098L,1390174L,1947527L,2667906L,3590889L,4753865L,6198717L,7979654L,10128692L,12732119L,15867500L,19571053L,23904927L,29021539L,34967650L,41839570L,49768153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190074Inst : IEnumerable<long>
{
public static readonly long[] Value=A190074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190074.Bytes);
public long this[int i]=>Value[i];

public static A190074Inst Instance=new A190074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190075
{
public static readonly long[] Value={ 0L,550L,5136L,25306L,88509L,249119L,599181L,1291797L,2542771L,4665542L,8142317L,13502963L,21463807L,33185295L,49745019L,72458535L,103375585L,144707600L,199040665L,269251217L,358360590L,471257436L,613624162L,789275327L,1002980959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190075Inst : IEnumerable<long>
{
public static readonly long[] Value=A190075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190075.Bytes);
public long this[int i]=>Value[i];

public static A190075Inst Instance=new A190075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190108
{
public static readonly long[] Value={ 7560L,11880L,14040L,16632L,18360L,19656L,20520L,21000L,24840L,25704L,28728L,30888L,31320L,33000L,33480L,34776L,39000L,39960L,40392L,41160L,43848L,44280L,45144L,46440L,46872L,47250L,47736L,50760L,51000L,53352L,54648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190108Inst : IEnumerable<long>
{
public static readonly long[] Value=A190108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190108.Bytes);
public long this[int i]=>Value[i];

public static A190108Inst Instance=new A190108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190109
{
public static readonly long[] Value={ 12600L,17640L,18900L,19800L,23400L,26460L,29400L,29700L,30600L,31500L,34200L,35100L,38808L,41400L,43560L,45864L,45900L,49500L,51300L,52200L,55800L,58212L,58500L,59976L,60840L,60984L,61740L,62100L,65340L,66150L,66600L,67032L,68796L,72600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190109Inst : IEnumerable<long>
{
public static readonly long[] Value=A190109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190109.Bytes);
public long this[int i]=>Value[i];

public static A190109Inst Instance=new A190109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190110
{
public static readonly long[] Value={ 18480L,21840L,28560L,31920L,34320L,38640L,44880L,48048L,48720L,50160L,52080L,53040L,59280L,60720L,62160L,62370L,62832L,68880L,70224L,71760L,72240L,73710L,74256L,76560L,77520L,78960L,80080L,81840L,82992L,85008L,89040L,90480L,93840L,96390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190110Inst : IEnumerable<long>
{
public static readonly long[] Value=A190110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190110.Bytes);
public long this[int i]=>Value[i];

public static A190110Inst Instance=new A190110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190111
{
public static readonly long[] Value={ 27720L,32760L,41580L,42840L,46200L,47880L,49140L,51480L,54600L,57960L,64260L,64680L,67320L,71400L,71820L,72072L,73080L,75240L,76440L,77220L,78120L,79560L,79800L,85800L,86940L,88920L,91080L,93240L,94248L,96600L,99960L,100980L,101640L,103320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190111Inst : IEnumerable<long>
{
public static readonly long[] Value=A190111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190111.Bytes);
public long this[int i]=>Value[i];

public static A190111Inst Instance=new A190111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190112
{
public static readonly long[] Value={ 0L,0L,16L,48L,120L,248L,440L,736L,1152L,1720L,2464L,3440L,4672L,6192L,8080L,10344L,13040L,16264L,20024L,24376L,29456L,35248L,41832L,49360L,57808L,67280L,77936L,89760L,102840L,117392L,133376L,150888L,170184L,191200L,214048L,239016L,266024L,295184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190112Inst : IEnumerable<long>
{
public static readonly long[] Value=A190112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190112.Bytes);
public long this[int i]=>Value[i];

public static A190112Inst Instance=new A190112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190113
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,4L,4L,0L,0L,8L,16L,8L,0L,0L,12L,28L,28L,12L,0L,0L,16L,44L,48L,44L,16L,0L,0L,20L,60L,76L,76L,60L,20L,0L,0L,24L,76L,108L,120L,108L,76L,24L,0L,0L,28L,92L,140L,172L,172L,140L,92L,28L,0L,0L,32L,108L,176L,224L,248L,224L,176L,108L,32L,0L,0L,36L,124L,212L,284L,328L,328L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190113Inst : IEnumerable<long>
{
public static readonly long[] Value=A190113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190113.Bytes);
public long this[int i]=>Value[i];

public static A190113Inst Instance=new A190113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190114
{
public static readonly long[] Value={ 7200L,14112L,24300L,34848L,39200L,47628L,48672L,83232L,96800L,103968L,112500L,117612L,135200L,152352L,164268L,189728L,231200L,242208L,264992L,276768L,280908L,288800L,297675L,350892L,394272L,423200L,453152L,484128L,514188L,532512L,566048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190114Inst : IEnumerable<long>
{
public static readonly long[] Value=A190114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190114.Bytes);
public long this[int i]=>Value[i];

public static A190114Inst Instance=new A190114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190115
{
public static readonly long[] Value={ 10800L,16200L,18000L,21168L,31752L,40500L,45000L,49392L,52272L,67500L,73008L,78408L,98000L,109512L,111132L,124848L,137200L,155952L,172872L,187272L,191664L,228528L,233928L,242000L,245000L,259308L,316368L,338000L,342792L,363312L,415152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190115Inst : IEnumerable<long>
{
public static readonly long[] Value=A190115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190115.Bytes);
public long this[int i]=>Value[i];

public static A190115Inst Instance=new A190115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190116
{
public static readonly long[] Value={ 0L,2L,3L,16L,5L,30L,7L,96L,54L,70L,11L,192L,13L,126L,120L,512L,17L,378L,19L,480L,210L,286L,23L,1056L,250L,390L,729L,896L,29L,930L,31L,2560L,462L,646L,420L,2160L,37L,798L,624L,2720L,41L,1722L,43L,2112L,1755L,1150L,47L,5376L,686L,2250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190116Inst : IEnumerable<long>
{
public static readonly long[] Value=A190116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190116.Bytes);
public long this[int i]=>Value[i];

public static A190116Inst Instance=new A190116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190117
{
public static readonly long[] Value={ 0L,2L,5L,21L,26L,56L,63L,159L,213L,283L,294L,486L,499L,625L,745L,1257L,1274L,1652L,1671L,2151L,2361L,2647L,2670L,3726L,3976L,4366L,5095L,5991L,6020L,6950L,6981L,9541L,10003L,10649L,11069L,13229L,13266L,14064L,14688L,17408L,17449L,19171L,19214L,21326L,23081L,24231L,24278L,29654L,30340L,32590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190117Inst : IEnumerable<long>
{
public static readonly long[] Value=A190117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190117.Bytes);
public long this[int i]=>Value[i];

public static A190117Inst Instance=new A190117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190118
{
public static readonly long[] Value={ 1L,3L,6L,7L,12L,18L,25L,27L,30L,40L,51L,54L,67L,81L,96L,97L,114L,120L,139L,144L,165L,187L,210L,216L,221L,247L,248L,255L,284L,314L,345L,347L,380L,414L,449L,452L,489L,527L,566L,576L,617L,659L,702L,713L,728L,774L,821L,824L,831L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190118Inst : IEnumerable<long>
{
public static readonly long[] Value=A190118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190118.Bytes);
public long this[int i]=>Value[i];

public static A190118Inst Instance=new A190118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190119
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,10L,13L,15L,22L,23L,27L,28L,37L,45L,47L,48L,55L,56L,62L,72L,85L,86L,97L,99L,114L,115L,123L,124L,155L,156L,161L,175L,194L,206L,211L,212L,233L,249L,266L,267L,308L,309L,321L,334L,359L,360L,367L,369L,378L,398L,412L,413L,416L,432L,455L,477L,508L,509L,532L,533L,566L,583L,586L,604L,665L,666L,684L,710L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190119Inst : IEnumerable<long>
{
public static readonly long[] Value=A190119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190119.Bytes);
public long this[int i]=>Value[i];

public static A190119Inst Instance=new A190119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190120
{
public static readonly long[] Value={ 0L,2L,5L,6L,11L,41L,48L,54L,60L,130L,141L,153L,166L,292L,412L,414L,431L,473L,492L,522L,732L,1018L,1041L,1107L,1117L,1507L,1508L,1564L,1593L,2523L,2554L,2564L,3026L,3672L,4092L,4107L,4144L,4942L,5566L,5736L,5777L,7499L,7542L,7674L,7869L,9019L,9066L,9087L,9101L,9191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190120Inst : IEnumerable<long>
{
public static readonly long[] Value=A190120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190120.Bytes);
public long this[int i]=>Value[i];

public static A190120Inst Instance=new A190120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190121
{
public static readonly long[] Value={ 0L,1L,2L,6L,7L,12L,13L,25L,31L,38L,39L,55L,56L,65L,73L,105L,106L,127L,128L,152L,162L,175L,176L,220L,230L,245L,272L,304L,305L,336L,337L,417L,431L,450L,462L,522L,523L,544L,560L,628L,629L,670L,671L,719L,758L,783L,784L,896L,910L,955L,975L,1031L,1032L,1113L,1129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190121Inst : IEnumerable<long>
{
public static readonly long[] Value=A190121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190121.Bytes);
public long this[int i]=>Value[i];

public static A190121Inst Instance=new A190121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190122
{
public static readonly long[] Value={ 0L,4L,13L,17L,42L,222L,271L,319L,373L,1073L,1194L,1338L,1507L,3271L,5071L,5103L,5392L,6148L,6509L,7109L,11519L,17811L,18340L,19924L,20174L,30314L,30341L,31909L,32750L,60650L,61611L,61931L,77177L,99141L,113841L,114381L,115750L,146074L,170410L,177210L,178891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190122Inst : IEnumerable<long>
{
public static readonly long[] Value=A190122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190122.Bytes);
public long this[int i]=>Value[i];

public static A190122Inst Instance=new A190122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190123
{
public static readonly long[] Value={ 1L,1L,2L,7L,32L,177L,1184L,9175L,81280L,810081L,8967168L,109200551L,1450641408L,20876239633L,323542851584L,5372445971063L,95157141241856L,1790769169786049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190123Inst : IEnumerable<long>
{
public static readonly long[] Value=A190123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190123.Bytes);
public long this[int i]=>Value[i];

public static A190123Inst Instance=new A190123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190188
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190188Inst : IEnumerable<long>
{
public static readonly long[] Value=A190188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190188.Bytes);
public long this[int i]=>Value[i];

public static A190188Inst Instance=new A190188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190189
{
public static readonly long[] Value={ 3L,6L,7L,9L,10L,11L,14L,17L,20L,21L,22L,23L,28L,30L,31L,33L,34L,39L,41L,42L,44L,45L,46L,49L,52L,53L,55L,56L,58L,60L,63L,66L,67L,68L,69L,74L,77L,78L,79L,80L,81L,85L,87L,88L,90L,91L,92L,98L,99L,101L,102L,104L,109L,110L,112L,113L,115L,116L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190189Inst : IEnumerable<long>
{
public static readonly long[] Value=A190189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190189.Bytes);
public long this[int i]=>Value[i];

public static A190189Inst Instance=new A190189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190190
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,12L,13L,15L,16L,18L,19L,24L,25L,26L,27L,29L,32L,35L,36L,37L,38L,40L,43L,47L,48L,50L,51L,54L,57L,59L,61L,62L,64L,65L,70L,71L,72L,73L,75L,76L,82L,83L,84L,86L,89L,93L,94L,95L,96L,97L,100L,103L,105L,106L,107L,108L,111L,114L,118L,119L,121L,122L,125L,128L,129L,130L,132L,133L,135L,140L,141L,142L,143L,144L,146L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190190Inst : IEnumerable<long>
{
public static readonly long[] Value=A190190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190190.Bytes);
public long this[int i]=>Value[i];

public static A190190Inst Instance=new A190190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190191
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190191Inst : IEnumerable<long>
{
public static readonly long[] Value=A190191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190191.Bytes);
public long this[int i]=>Value[i];

public static A190191Inst Instance=new A190191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190192
{
public static readonly long[] Value={ 3L,5L,6L,8L,10L,13L,15L,16L,17L,20L,22L,23L,27L,29L,30L,32L,34L,37L,39L,40L,44L,46L,47L,49L,51L,54L,56L,57L,58L,61L,63L,64L,68L,71L,73L,74L,75L,78L,80L,81L,85L,87L,88L,90L,92L,95L,97L,98L,99L,102L,104L,105L,107L,109L,112L,114L,115L,116L,119L,121L,122L,126L,128L,129L,131L,133L,136L,138L,139L,143L,145L,146L,148L,150L,153L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190192Inst : IEnumerable<long>
{
public static readonly long[] Value=A190192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190192.Bytes);
public long this[int i]=>Value[i];

public static A190192Inst Instance=new A190192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190193
{
public static readonly long[] Value={ 1L,2L,4L,7L,9L,11L,12L,14L,18L,19L,21L,24L,25L,26L,28L,31L,33L,35L,36L,38L,41L,42L,43L,45L,48L,50L,52L,53L,55L,59L,60L,62L,65L,66L,67L,69L,70L,72L,76L,77L,79L,82L,83L,84L,86L,89L,91L,93L,94L,96L,100L,101L,103L,106L,108L,110L,111L,113L,117L,118L,120L,123L,124L,125L,127L,130L,132L,134L,135L,137L,140L,141L,142L,144L,147L,149L,151L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190193Inst : IEnumerable<long>
{
public static readonly long[] Value=A190193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190193.Bytes);
public long this[int i]=>Value[i];

public static A190193Inst Instance=new A190193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190194
{
public static readonly BigInteger[] Value={ 0L,1L,4L,20L,116L,776L,5912L,50648L,482552L,5065016L,58099832L,723315128L,9715154552L,140051879096L,2157103991672L,35355232693688L,614453167841912L,11287370521073336L,218535622980161912L,4447889360078673848L,BigInteger.Parse("94944254697268017272"),BigInteger.Parse("2120984032794061422776"),BigInteger.Parse("49489160848954807154552"),BigInteger.Parse("1203943675008917425902008"),BigInteger.Parse("30486416629523244528307832") };
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
public class A190194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190194Inst Instance=new A190194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190195
{
public static readonly BigInteger[] Value={ 1L,-1L,7L,-139L,5473L,-51103L,34988647L,-4784061619L,17782347217L,-203906055033841L,4586025046220899L,-234038275571853889L,BigInteger.Parse("9127322584507530151393"),BigInteger.Parse("-4621897483978366951337161"),BigInteger.Parse("390009953658229908025520161"),BigInteger.Parse("-1860452328661957054823447670979"),BigInteger.Parse("111446346975327291562408943638981"),BigInteger.Parse("-14050053632877769956552601074149491"),BigInteger.Parse("1269258883676324618437848731917951368967"),BigInteger.Parse("-1408182090109327874242950762763137949746859") };
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
public class A190195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190195Inst Instance=new A190195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190196
{
public static readonly BigInteger[] Value={ 1L,4L,96L,5760L,645120L,16588800L,30656102400L,11158821273600L,109310902272000L,3278015337332736000L,BigInteger.Parse("191637819720990720000"),BigInteger.Parse("25296192203170775040000"),BigInteger.Parse("2541356653499348743618560000"),BigInteger.Parse("3303763649549153366704128000000"),BigInteger.Parse("713612948302617127208091648000000") };
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
public class A190196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190196Inst Instance=new A190196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190197
{
public static readonly long[] Value={ 2L,3L,5L,11L,29L,89L,313L,1259L,5669L,28349L,155921L,935531L,6080957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190197Inst : IEnumerable<long>
{
public static readonly long[] Value=A190197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190197.Bytes);
public long this[int i]=>Value[i];

public static A190197Inst Instance=new A190197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190198
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190198Inst : IEnumerable<long>
{
public static readonly long[] Value=A190198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190198.Bytes);
public long this[int i]=>Value[i];

public static A190198Inst Instance=new A190198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190199
{
public static readonly long[] Value={ 2L,3L,6L,7L,9L,11L,14L,16L,18L,21L,22L,25L,26L,28L,29L,32L,33L,35L,37L,40L,41L,42L,44L,47L,48L,51L,52L,54L,58L,59L,61L,63L,66L,67L,70L,73L,74L,77L,78L,80L,82L,84L,85L,87L,89L,92L,93L,96L,97L,99L,100L,103L,104L,106L,108L,111L,113L,115L,118L,119L,122L,123L,125L,126L,129L,130L,132L,134L,137L,138L,141L,144L,145L,148L,149L,151L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190199Inst : IEnumerable<long>
{
public static readonly long[] Value=A190199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190199.Bytes);
public long this[int i]=>Value[i];

public static A190199Inst Instance=new A190199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190200
{
public static readonly long[] Value={ 1L,4L,5L,8L,10L,12L,13L,15L,17L,19L,20L,23L,24L,27L,30L,31L,34L,36L,38L,39L,43L,45L,46L,49L,50L,53L,55L,56L,57L,60L,62L,64L,65L,68L,69L,71L,72L,75L,76L,79L,81L,83L,86L,88L,90L,91L,94L,95L,98L,101L,102L,105L,107L,109L,110L,112L,114L,116L,117L,120L,121L,124L,127L,128L,131L,133L,135L,136L,139L,140L,142L,143L,146L,147L,150L,152L,154L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190200Inst : IEnumerable<long>
{
public static readonly long[] Value=A190200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190200.Bytes);
public long this[int i]=>Value[i];

public static A190200Inst Instance=new A190200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190201
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190201Inst : IEnumerable<long>
{
public static readonly long[] Value=A190201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190201.Bytes);
public long this[int i]=>Value[i];

public static A190201Inst Instance=new A190201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190202
{
public static readonly long[] Value={ 1L,5L,7L,9L,10L,13L,14L,16L,17L,18L,19L,23L,26L,27L,30L,32L,34L,35L,36L,39L,43L,45L,47L,48L,51L,52L,54L,56L,57L,60L,61L,64L,65L,68L,70L,73L,74L,77L,79L,81L,83L,85L,86L,89L,90L,92L,94L,95L,98L,99L,102L,103L,106L,108L,111L,112L,115L,117L,119L,120L,121L,123L,124L,128L,130L,132L,133L,136L,137L,139L,140L,141L,146L,149L,150L,153L,155L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190202Inst : IEnumerable<long>
{
public static readonly long[] Value=A190202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190202.Bytes);
public long this[int i]=>Value[i];

public static A190202Inst Instance=new A190202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190203
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,11L,12L,15L,20L,21L,22L,24L,25L,28L,29L,31L,33L,37L,38L,40L,41L,42L,44L,46L,49L,50L,53L,55L,58L,59L,62L,63L,66L,67L,69L,71L,72L,75L,76L,78L,80L,82L,84L,87L,88L,91L,93L,96L,97L,100L,101L,104L,105L,107L,109L,110L,113L,114L,116L,118L,122L,125L,126L,127L,129L,131L,134L,135L,138L,142L,143L,144L,145L,147L,148L,151L,152L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190203Inst : IEnumerable<long>
{
public static readonly long[] Value=A190203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190203.Bytes);
public long this[int i]=>Value[i];

public static A190203Inst Instance=new A190203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190268
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,3L,5L,5L,5L,3L,3L,13L,3L,5L,1L,3L,7L,9L,5L,7L,1L,15L,5L,7L,3L,9L,9L,3L,7L,13L,11L,3L,3L,7L,9L,13L,3L,23L,13L,15L,7L,13L,5L,21L,11L,9L,9L,13L,9L,5L,3L,15L,3L,9L,11L,9L,9L,9L,17L,15L,5L,7L,9L,7L,7L,21L,19L,7L,11L,43L,35L,11L,25L,11L,5L,7L,7L,37L,27L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190268Inst : IEnumerable<long>
{
public static readonly long[] Value=A190268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190268.Bytes);
public long this[int i]=>Value[i];

public static A190268Inst Instance=new A190268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190269
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,9L,12L,15L,18L,21L,25L,29L,33L,37L,42L,47L,52L,57L,63L,69L,76L,83L,90L,97L,106L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190269Inst : IEnumerable<long>
{
public static readonly long[] Value=A190269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190269.Bytes);
public long this[int i]=>Value[i];

public static A190269Inst Instance=new A190269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190270
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,49L,169L,605L,2226L,8364L,31956L,123770L,484862L,1917800L,7648470L,30722318L,124180334L,504720369L,2061489396L,8457050387L,34831589583L,143972841512L,597034531410L,2483173470124L,10356092457386L,43298360910159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190270Inst : IEnumerable<long>
{
public static readonly long[] Value=A190270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190270.Bytes);
public long this[int i]=>Value[i];

public static A190270Inst Instance=new A190270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190271
{
public static readonly long[] Value={ 1L,1L,4L,22L,141L,986L,7295L,56145L,444900L,3605429L,29742671L,248933630L,2108590305L,18042013096L,155711676129L,1353913728412L,11849013783676L,104293377329508L,922643326714355L,8199321046129671L,73162599757076951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190271Inst : IEnumerable<long>
{
public static readonly long[] Value=A190271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190271.Bytes);
public long this[int i]=>Value[i];

public static A190271Inst Instance=new A190271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190272
{
public static readonly long[] Value={ 6L,14L,15L,22L,33L,38L,46L,51L,62L,86L,87L,91L,95L,118L,141L,142L,145L,158L,159L,166L,206L,249L,262L,267L,278L,287L,295L,321L,326L,382L,395L,398L,411L,422L,445L,446L,473L,502L,519L,537L,542L,545L,581L,591L,622L,662L,695L,699L,703L,718L,745L,758L,766L,789L,838L,886L,895L,926L,951L,958L,995L,998L,1046L,1126L,1139L,1145L,1167L,1199L,1238L,1262L,1318L,1329L,1347L,1382L,1401L,1441L,1486L,1678L,1707L,1717L,1718L,1726L,1745L,1757L,1761L,1766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190272Inst : IEnumerable<long>
{
public static readonly long[] Value=A190272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190272.Bytes);
public long this[int i]=>Value[i];

public static A190272Inst Instance=new A190272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190273
{
public static readonly long[] Value={ 6L,10L,21L,26L,39L,55L,57L,74L,93L,111L,122L,146L,155L,201L,203L,253L,301L,305L,314L,327L,381L,386L,417L,471L,497L,543L,554L,597L,626L,633L,689L,737L,755L,791L,794L,842L,889L,905L,914L,921L,1011L,1027L,1055L,1081L,1082L,1137L,1226L,1227L,1322L,1346L,1379L,1461L,1466L,1477L,1497L,1514L,1623L,1655L,1703L,1711L,1713L,1731L,1751L,1754L,1893L,1967L,1994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190273Inst : IEnumerable<long>
{
public static readonly long[] Value=A190273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190273.Bytes);
public long this[int i]=>Value[i];

public static A190273Inst Instance=new A190273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190274
{
public static readonly long[] Value={ 15L,95L,287L,1199L,4607L,23519L,28799L,101567L,223199L,296207L,352799L,903167L,1019999L,2032127L,2230799L,2666159L,3285599L,5896799L,7606367L,13939199L,19392479L,28839887L,36154799L,46139039L,54295919L,62412767L,68250239L,73384079L,74440799L,90316799L,95234687L,109672319L,115263647L,118129199L,214562399L,223279487L,234503807L,236792879L,262963199L,270420767L,309829727L,355897439L,422999999L,486823247L,589884959L,628687487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190274Inst : IEnumerable<long>
{
public static readonly long[] Value=A190274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190274.Bytes);
public long this[int i]=>Value[i];

public static A190274Inst Instance=new A190274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190275
{
public static readonly long[] Value={ 6L,21L,301L,2041L,296341L,486877L,2666437L,3420301L,4304341L,7152001L,38159521L,42387097L,54296677L,95235601L,158048281L,229971241L,265434901L,383712781L,454166017L,775307917L,972261181L,1063290841L,1304557801L,1392422041L,1730882401L,1863895261L,2631883561L,2879450461L,3714274297L,3845297341L,4070454361L,4256780041L,4849695001L,5328809461L,5722533337L,5838483601L,7218898681L,7841065621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190275Inst : IEnumerable<long>
{
public static readonly long[] Value=A190275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190275.Bytes);
public long this[int i]=>Value[i];

public static A190275Inst Instance=new A190275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190276
{
public static readonly long[] Value={ 2L,3L,6L,9L,15L,17L,21L,28L,30L,36L,43L,46L,47L,51L,54L,62L,69L,71L,72L,75L,80L,90L,92L,93L,96L,99L,101L,102L,107L,108L,109L,110L,114L,118L,120L,122L,124L,133L,135L,141L,150L,151L,152L,156L,160L,161L,164L,170L,171L,174L,196L,197L,206L,207L,208L,210L,212L,216L,223L,226L,231L,235L,236L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190276Inst : IEnumerable<long>
{
public static readonly long[] Value=A190276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190276.Bytes);
public long this[int i]=>Value[i];

public static A190276Inst Instance=new A190276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190277
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,23L,62L,174L,497L,1433L,4150L,12044L,34989L,101695L,295642L,859566L,2499277L,7267081L,21130538L,61441732L,178655937L,519483767L,1510520966L,4392195390L,12771343961L,37135696841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190277Inst : IEnumerable<long>
{
public static readonly long[] Value=A190277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190277.Bytes);
public long this[int i]=>Value[i];

public static A190277Inst Instance=new A190277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190278
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,15L,17L,20L,21L,25L,27L,29L,31L,36L,38L,42L,44L,48L,51L,56L,58L,64L,67L,72L,75L,80L,83L,90L,94L,99L,103L,111L,113L,122L,126L,131L,136L,145L,149L,157L,162L,168L,173L,184L,188L,196L,201L,209L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190278Inst : IEnumerable<long>
{
public static readonly long[] Value=A190278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190278.Bytes);
public long this[int i]=>Value[i];

public static A190278Inst Instance=new A190278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190279
{
public static readonly long[] Value={ 2L,4L,7L,10L,13L,15L,18L,21L,23L,27L,29L,32L,35L,37L,40L,43L,46L,48L,51L,54L,56L,59L,62L,65L,67L,71L,73L,75L,79L,81L,84L,87L,90L,92L,94L,98L,100L,103L,106L,109L,111L,114L,117L,119L,123L,125L,127L,131L,133L,136L,138L,142L,144L,146L,150L,152L,155L,158L,161L,163L,166L,169L,171L,175L,177L,180L,182L,185L,188L,190L,194L,196L,199L,202L,204L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190279Inst : IEnumerable<long>
{
public static readonly long[] Value=A190279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190279.Bytes);
public long this[int i]=>Value[i];

public static A190279Inst Instance=new A190279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190280
{
public static readonly long[] Value={ 1L,3L,5L,8L,9L,11L,14L,16L,17L,20L,22L,24L,26L,28L,30L,33L,34L,36L,39L,41L,42L,45L,47L,49L,52L,53L,55L,58L,60L,61L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,85L,86L,88L,91L,93L,95L,97L,99L,101L,104L,105L,107L,110L,112L,113L,116L,118L,120L,122L,124L,126L,129L,130L,132L,135L,137L,139L,141L,143L,145L,148L,149L,151L,153L,156L,157L,159L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190280Inst : IEnumerable<long>
{
public static readonly long[] Value=A190280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190280.Bytes);
public long this[int i]=>Value[i];

public static A190280Inst Instance=new A190280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190281
{
public static readonly long[] Value={ 1L,8L,0L,5L,7L,9L,0L,8L,9L,4L,6L,5L,4L,3L,5L,7L,4L,9L,0L,4L,4L,0L,6L,4L,5L,5L,5L,7L,3L,4L,5L,5L,2L,7L,4L,1L,7L,8L,2L,9L,2L,2L,9L,0L,5L,8L,6L,1L,5L,6L,3L,1L,7L,8L,0L,3L,3L,2L,7L,5L,1L,4L,4L,7L,8L,3L,8L,2L,4L,1L,2L,9L,2L,7L,8L,6L,3L,3L,8L,3L,3L,0L,5L,6L,1L,7L,2L,9L,8L,3L,3L,5L,2L,0L,2L,3L,6L,7L,1L,1L,8L,6L,6L,4L,1L,2L,8L,4L,3L,8L,9L,2L,1L,9L,0L,2L,6L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190281Inst : IEnumerable<long>
{
public static readonly long[] Value=A190281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190281.Bytes);
public long this[int i]=>Value[i];

public static A190281Inst Instance=new A190281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190282
{
public static readonly long[] Value={ 1L,1L,4L,6L,1L,2L,2L,2L,1L,1L,6L,1L,179L,46L,1L,1L,3L,2L,1L,1L,3L,6L,3L,1L,1L,1L,1L,2L,1L,1L,56L,1L,1L,1L,1L,66L,1L,1L,2L,17L,8L,2L,7L,12L,1L,1L,8L,1L,2L,2L,1L,1L,2L,1L,12L,1L,2L,2L,2L,2L,1L,1L,1L,8L,1L,1L,1L,1L,2L,1L,2L,5L,1L,6L,8L,1L,1L,1L,2L,7L,1L,9L,1L,2L,5L,7L,1L,6L,1L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190282Inst : IEnumerable<long>
{
public static readonly long[] Value=A190282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190282.Bytes);
public long this[int i]=>Value[i];

public static A190282Inst Instance=new A190282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190283
{
public static readonly long[] Value={ 2L,5L,5L,3L,7L,7L,3L,9L,7L,4L,0L,3L,0L,0L,3L,7L,3L,0L,7L,3L,4L,4L,1L,5L,8L,9L,5L,3L,0L,6L,3L,1L,4L,6L,9L,4L,8L,1L,6L,4L,5L,8L,3L,4L,9L,9L,4L,1L,0L,3L,0L,7L,8L,3L,6L,3L,3L,2L,6L,7L,1L,1L,4L,8L,3L,3L,3L,6L,7L,5L,2L,5L,6L,7L,8L,8L,7L,3L,3L,1L,0L,2L,7L,2L,7L,9L,3L,7L,8L,8L,6L,1L,1L,7L,4L,3L,6L,7L,7L,4L,4L,9L,2L,8L,8L,3L,7L,3L,3L,5L,4L,3L,6L,6L,6L,6L,6L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190283Inst : IEnumerable<long>
{
public static readonly long[] Value=A190283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190283.Bytes);
public long this[int i]=>Value[i];

public static A190283Inst Instance=new A190283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190348
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,13L,16L,18L,20L,23L,25L,28L,30L,32L,35L,37L,40L,41L,44L,47L,49L,52L,53L,56L,59L,61L,63L,65L,68L,71L,73L,75L,77L,80L,83L,84L,87L,89L,92L,94L,96L,99L,101L,104L,106L,108L,111L,113L,115L,118L,120L,123L,125L,127L,130L,132L,135L,136L,139L,142L,144L,147L,148L,151L,154L,156L,158L,160L,163L,166L,167L,170L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190348Inst : IEnumerable<long>
{
public static readonly long[] Value=A190348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190348.Bytes);
public long this[int i]=>Value[i];

public static A190348Inst Instance=new A190348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190349
{
public static readonly long[] Value={ 3L,7L,11L,15L,19L,23L,27L,31L,35L,38L,43L,47L,50L,55L,59L,62L,66L,71L,74L,78L,83L,86L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,130L,133L,138L,142L,145L,150L,154L,157L,161L,166L,169L,173L,178L,181L,185L,189L,193L,197L,201L,205L,209L,213L,217L,221L,225L,228L,233L,237L,240L,245L,249L,252L,256L,261L,264L,268L,273L,276L,280L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190349Inst : IEnumerable<long>
{
public static readonly long[] Value=A190349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190349.Bytes);
public long this[int i]=>Value[i];

public static A190349Inst Instance=new A190349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190350
{
public static readonly BigInteger[] Value={ 1L,5L,877L,3349607L,BigInteger.Parse("21942759935479332971926241"),BigInteger.Parse("180761188752879910424934681877493335110381106645501751786955912877") };
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
public class A190350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190350Inst Instance=new A190350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190351
{
public static readonly BigInteger[] Value={ 1L,6L,1092L,4218760L,BigInteger.Parse("27765973216255750329906360"),BigInteger.Parse("229254309739144896253372216696442967123093789661296276592384463520") };
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
public class A190351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190351Inst Instance=new A190351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190352
{
public static readonly long[] Value={ 1L,1L,268L,1073L,15290L,16363L,48016L,64379L,176774L,417927L,594701L,1607329L,5416688L,44940833L,140239187L,185180020L,1066139287L,4449737168L,5515876455L,81672007538L,822235951835L,903907959373L,18900395139295L,719118923252583L,738019318391878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190352Inst : IEnumerable<long>
{
public static readonly long[] Value=A190352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190352.Bytes);
public long this[int i]=>Value[i];

public static A190352Inst Instance=new A190352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190353
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,1L,2L,2L,2L,2L,3L,2L,3L,2L,4L,3L,4L,3L,5L,3L,6L,2L,7L,3L,6L,2L,8L,4L,7L,4L,9L,2L,10L,3L,10L,4L,10L,3L,11L,4L,12L,5L,12L,4L,14L,3L,16L,5L,14L,3L,16L,4L,16L,6L,16L,3L,18L,5L,20L,6L,20L,2L,20L,5L,21L,6L,21L,5L,21L,5L,27L,7L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190353Inst : IEnumerable<long>
{
public static readonly long[] Value=A190353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190353.Bytes);
public long this[int i]=>Value[i];

public static A190353Inst Instance=new A190353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190354
{
public static readonly long[] Value={ 887L,907L,4211L,6569L,8447L,23339L,23357L,30809L,33427L,33937L,38839L,57529L,57557L,57859L,70271L,77621L,77641L,77647L,77659L,80747L,86587L,87691L,109537L,115769L,116041L,117251L,160681L,192781L,207797L,217387L,228257L,228281L,232457L,244339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190354Inst : IEnumerable<long>
{
public static readonly long[] Value=A190354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190354.Bytes);
public long this[int i]=>Value[i];

public static A190354Inst Instance=new A190354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190355
{
public static readonly long[] Value={ 199L,307L,341L,349L,351L,415L,491L,737L,739L,851L,949L,1013L,1061L,1149L,1205L,1211L,1275L,1277L,1313L,1315L,1421L,1667L,1695L,1747L,1925L,2049L,2149L,2276L,2357L,2365L,2683L,2717L,2827L,2889L,2891L,2949L,3051L,3115L,3173L,3259L,3475L,3581L,3651L,3797L,4013L,4045L,4149L,4193L,4449L,4597L,4627L,4654L,4843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190355Inst : IEnumerable<long>
{
public static readonly long[] Value=A190355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190355.Bytes);
public long this[int i]=>Value[i];

public static A190355Inst Instance=new A190355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190356
{
public static readonly long[] Value={ 1L,37L,2L,2L,89L,7L,683L,18L,3L,19L,25469L,3L,3L,163L,137L,1853L,631L,3L,4L,449L,7L,11L,23417L,730511L,1872L,28747L,5L,11L,4L,4L,5353L,2538163L,15409L,53L,197L,17351L,5563L,13L,433L,2570129L,13L,1176498611L,53L,1241L,4L,25903L,15642626656646177L,14L,5L,592L,4033L,165889L,90L,181L,9109L,5266097L,5L,184223499139L,5L,5L,7L,52954777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190356Inst : IEnumerable<long>
{
public static readonly long[] Value=A190356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190356.Bytes);
public long this[int i]=>Value[i];

public static A190356Inst Instance=new A190356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190357
{
public static readonly long[] Value={ 0L,4L,7L,3L,5L,7L,6L,3L,2L,7L,1L,5L,3L,2L,4L,4L,5L,7L,1L,1L,2L,2L,4L,1L,0L,7L,3L,5L,8L,0L,5L,4L,4L,7L,2L,2L,1L,9L,1L,2L,8L,2L,4L,5L,0L,6L,5L,5L,5L,0L,6L,9L,0L,2L,3L,0L,8L,7L,8L,1L,9L,3L,6L,2L,1L,1L,6L,5L,3L,7L,5L,8L,0L,7L,5L,5L,2L,9L,1L,1L,7L,6L,1L,7L,5L,8L,1L,4L,5L,2L,1L,4L,8L,7L,5L,6L,3L,2L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190357Inst : IEnumerable<long>
{
public static readonly long[] Value=A190357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190357.Bytes);
public long this[int i]=>Value[i];

public static A190357Inst Instance=new A190357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190358
{
public static readonly long[] Value={ 15L,21L,33L,57L,185L,201L,393L,1841L,5753L,7217L,10265L,12297L,139553L,607577L,98313L,196617L,3801929L,786441L,27790073L,7340081L,35651873L,281022857L,92274809L,721422137L,1375733393L,6509569217L,3892314953L,805306377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190358Inst : IEnumerable<long>
{
public static readonly long[] Value=A190358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190358.Bytes);
public long this[int i]=>Value[i];

public static A190358Inst Instance=new A190358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190359
{
public static readonly long[] Value={ 5L,7L,11L,19L,37L,67L,131L,263L,523L,1031L,2053L,4099L,8209L,16421L,32771L,65539L,131101L,262147L,524341L,1048583L,2097169L,4194371L,8388619L,16777259L,33554473L,67108961L,13417757L,268435459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190359Inst : IEnumerable<long>
{
public static readonly long[] Value=A190359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190359.Bytes);
public long this[int i]=>Value[i];

public static A190359Inst Instance=new A190359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190360
{
public static readonly long[] Value={ 1L,3L,7L,17L,40L,96L,229L,547L,1306L,3119L,7448L,17786L,42473L,101426L,242206L,578390L,1381200L,3298317L,7876408L,18808927L,44915872L,107259471L,256136497L,611656057L,1460639684L,3488019553L,8329419319L,19890721694L,47499206650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190360Inst : IEnumerable<long>
{
public static readonly long[] Value=A190360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190360.Bytes);
public long this[int i]=>Value[i];

public static A190360Inst Instance=new A190360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190361
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,23L,27L,29L,32L,35L,38L,41L,44L,47L,51L,54L,56L,59L,62L,65L,68L,71L,74L,78L,81L,84L,86L,89L,92L,95L,98L,102L,105L,108L,111L,113L,116L,119L,122L,125L,129L,132L,135L,138L,141L,143L,146L,149L,153L,156L,159L,162L,165L,168L,170L,173L,176L,180L,183L,186L,189L,192L,195L,198L,200L,204L,207L,210L,213L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190361Inst : IEnumerable<long>
{
public static readonly long[] Value=A190361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190361.Bytes);
public long this[int i]=>Value[i];

public static A190361Inst Instance=new A190361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190362
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,15L,18L,21L,24L,26L,28L,31L,34L,37L,40L,42L,45L,48L,50L,53L,55L,58L,61L,64L,67L,69L,72L,75L,77L,80L,82L,85L,88L,91L,94L,96L,99L,101L,104L,107L,109L,112L,115L,118L,121L,123L,126L,128L,131L,134L,136L,139L,142L,145L,148L,150L,152L,155L,158L,161L,163L,166L,169L,172L,175L,177L,179L,182L,185L,188L,190L,193L,196L,199L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190362Inst : IEnumerable<long>
{
public static readonly long[] Value=A190362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190362.Bytes);
public long this[int i]=>Value[i];

public static A190362Inst Instance=new A190362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190363
{
public static readonly long[] Value={ 3L,6L,9L,13L,16L,19L,22L,26L,30L,33L,36L,40L,43L,46L,49L,53L,57L,60L,63L,67L,70L,73L,76L,80L,83L,87L,90L,94L,97L,100L,103L,107L,110L,114L,117L,121L,124L,127L,130L,134L,137L,140L,144L,148L,151L,154L,157L,161L,164L,167L,171L,175L,178L,181L,184L,188L,191L,194L,197L,202L,205L,208L,211L,215L,218L,221L,224L,229L,232L,235L,238L,242L,245L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190363Inst : IEnumerable<long>
{
public static readonly long[] Value=A190363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190363.Bytes);
public long this[int i]=>Value[i];

public static A190363Inst Instance=new A190363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190412
{
public static readonly long[] Value={ 8L,5L,6L,3L,5L,0L,3L,9L,5L,6L,0L,9L,7L,7L,9L,5L,7L,3L,9L,8L,1L,4L,6L,1L,8L,2L,3L,9L,9L,1L,4L,2L,4L,5L,4L,4L,8L,9L,9L,2L,9L,3L,9L,9L,9L,7L,1L,4L,3L,7L,9L,7L,5L,3L,2L,6L,2L,7L,5L,2L,1L,0L,4L,0L,3L,7L,2L,3L,4L,0L,7L,0L,1L,8L,5L,0L,2L,9L,5L,7L,7L,2L,2L,8L,7L,3L,0L,4L,3L,7L,1L,8L,1L,0L,9L,5L,6L,1L,1L,8L,8L,7L,1L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190412Inst : IEnumerable<long>
{
public static readonly long[] Value=A190412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190412.Bytes);
public long this[int i]=>Value[i];

public static A190412Inst Instance=new A190412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190413
{
public static readonly long[] Value={ 1L,1245L,189L,189L,85L,85L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190413Inst : IEnumerable<long>
{
public static readonly long[] Value=A190413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190413.Bytes);
public long this[int i]=>Value[i];

public static A190413Inst Instance=new A190413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190414
{
public static readonly long[] Value={ 1L,2490L,567L,756L,425L,510L,70L,80L,90L,100L,110L,120L,130L,140L,150L,160L,170L,180L,190L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190414Inst : IEnumerable<long>
{
public static readonly long[] Value=A190414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190414.Bytes);
public long this[int i]=>Value[i];

public static A190414Inst Instance=new A190414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190415
{
public static readonly long[] Value={ 1L,4L,3L,6L,4L,9L,6L,0L,4L,3L,9L,0L,2L,2L,0L,4L,2L,6L,0L,1L,8L,5L,3L,8L,1L,7L,6L,0L,0L,8L,5L,7L,5L,4L,5L,5L,1L,0L,0L,7L,0L,6L,0L,0L,0L,2L,8L,5L,6L,2L,0L,2L,4L,6L,7L,3L,7L,2L,4L,7L,8L,9L,5L,9L,6L,2L,7L,6L,5L,9L,2L,9L,8L,1L,4L,9L,7L,0L,4L,2L,2L,7L,7L,1L,2L,6L,9L,5L,6L,2L,8L,1L,8L,9L,0L,4L,3L,8L,8L,1L,1L,2L,8L,0L,7L,2L,6L,7L,8L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190415Inst : IEnumerable<long>
{
public static readonly long[] Value=A190415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190415.Bytes);
public long this[int i]=>Value[i];

public static A190415Inst Instance=new A190415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190416
{
public static readonly BigInteger[] Value={ 48L,432L,7776L,279936L,18475776L,2235568896L,491825157120L,196730062848000L,145580246507520000L,BigInteger.Parse("199299357468794880000"),BigInteger.Parse("501437183391487918080000"),BigInteger.Parse("2318645536002240133201920000"),BigInteger.Parse("19708487056019041132216320000000") };
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
public class A190416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190416Inst Instance=new A190416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190417
{
public static readonly BigInteger[] Value={ 45L,497L,9580L,319760L,18980021L,1980733945L,363632891784L,117655174702396L,67024501865532719L,BigInteger.Parse("67232893079939036305"),BigInteger.Parse("118774251891797912665388"),BigInteger.Parse("369496334618903888548799176"),BigInteger.Parse("2024200318811320542229843621759") };
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
public class A190417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190417Inst Instance=new A190417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190418
{
public static readonly BigInteger[] Value={ 37L,290L,4174L,103218L,4268160L,302857233L,36530501839L,7448773789365L,2604518117252310L,1552614799946248963L,BigInteger.Parse("1570623177380821866672"),BigInteger.Parse("2710542814101229129928033"),BigInteger.Parse("7970415278138699394079102815") };
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
public class A190418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190418Inst Instance=new A190418Inst();

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