using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A186543
{
public static readonly long[] Value={ 2L,4L,7L,8L,12L,13L,15L,18L,21L,22L,25L,26L,29L,31L,34L,36L,38L,41L,43L,45L,47L,50L,51L,54L,56L,59L,61L,63L,66L,68L,70L,73L,74L,77L,79L,81L,83L,86L,88L,90L,92L,95L,97L,99L,102L,104L,107L,108L,111L,113L,116L,118L,120L,122L,125L,127L,129L,131L,133L,135L,138L,140L,142L,145L,147L,149L,151L,154L,156L,158L,160L,163L,165L,168L,170L,172L,174L,176L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186543Inst : IEnumerable<long>
{
public static readonly long[] Value=A186543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186543.Bytes);
public long this[int i]=>Value[i];

public static A186543Inst Instance=new A186543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186542
{
public static readonly long[] Value={ 1L,5L,7L,10L,13L,16L,19L,21L,24L,27L,29L,32L,35L,38L,40L,43L,46L,49L,51L,54L,57L,60L,62L,65L,68L,71L,73L,76L,79L,81L,84L,87L,90L,92L,95L,98L,101L,103L,106L,109L,111L,114L,117L,120L,122L,125L,128L,131L,133L,136L,139L,142L,144L,147L,150L,152L,155L,158L,161L,163L,166L,169L,172L,174L,177L,180L,183L,185L,188L,191L,193L,196L,199L,202L,204L,207L,210L,213L,215L,218L,221L,224L,226L,229L,232L,234L,237L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186542Inst : IEnumerable<long>
{
public static readonly long[] Value=A186542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186542.Bytes);
public long this[int i]=>Value[i];

public static A186542Inst Instance=new A186542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186541
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,9L,11L,12L,14L,15L,17L,18L,20L,22L,23L,25L,26L,28L,30L,31L,33L,34L,36L,37L,39L,41L,42L,44L,45L,47L,48L,50L,52L,53L,55L,56L,58L,59L,61L,63L,64L,66L,67L,69L,70L,72L,74L,75L,77L,78L,80L,82L,83L,85L,86L,88L,89L,91L,93L,94L,96L,97L,99L,100L,102L,104L,105L,107L,108L,110L,112L,113L,115L,116L,118L,119L,121L,123L,124L,126L,127L,129L,130L,132L,134L,135L,137L,138L,140L,141L,143L,145L,146L,148L,149L,151L,153L,154L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186541Inst : IEnumerable<long>
{
public static readonly long[] Value=A186541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186541.Bytes);
public long this[int i]=>Value[i];

public static A186541Inst Instance=new A186541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186540
{
public static readonly long[] Value={ 2L,5L,8L,10L,13L,16L,19L,21L,24L,27L,30L,32L,35L,38L,40L,43L,46L,49L,51L,54L,57L,60L,62L,65L,68L,71L,73L,76L,79L,81L,84L,87L,90L,92L,95L,98L,101L,103L,106L,109L,112L,114L,117L,120L,122L,125L,128L,131L,133L,136L,139L,142L,144L,147L,150L,152L,155L,158L,161L,163L,166L,169L,172L,174L,177L,180L,183L,185L,188L,191L,193L,196L,199L,202L,204L,207L,210L,213L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186540Inst : IEnumerable<long>
{
public static readonly long[] Value=A186540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186540.Bytes);
public long this[int i]=>Value[i];

public static A186540Inst Instance=new A186540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186491
{
public static readonly BigInteger[] Value={ 1L,2L,28L,1112L,87568L,11447072L,2239273408L,612359887232L,223061763490048L,104399900177326592L,BigInteger.Parse("61049165415292607488"),BigInteger.Parse("43617245341775265585152"),BigInteger.Parse("37385513306142843500105728"),BigInteger.Parse("37862584188750782065354022912") };
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
public class A186491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186491Inst Instance=new A186491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186490
{
public static readonly long[] Value={ 4096L,1709L,1709L,33182L,4834L,33182L,23215L,9789L,9789L,23215L,275175L,49867L,269126L,49867L,275175L,217601L,91096L,144828L,144828L,91096L,217601L,2199713L,383152L,2196353L,1024481L,2196353L,383152L,2199713L,1960451L,740408L,1359050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186490Inst : IEnumerable<long>
{
public static readonly long[] Value=A186490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186490.Bytes);
public long this[int i]=>Value[i];

public static A186490Inst Instance=new A186490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186489
{
public static readonly long[] Value={ 4096L,4834L,269126L,1024481L,21122896L,70300633L,1381305433L,5019710665L,92758821369L,358905890921L,6225263778969L,25517863738777L,418350075763113L,1809120677086713L,28157232600156937L,127921801557860825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186489Inst : IEnumerable<long>
{
public static readonly long[] Value=A186489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186489.Bytes);
public long this[int i]=>Value[i];

public static A186489Inst Instance=new A186489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186488
{
public static readonly long[] Value={ 2401L,1169L,1169L,17119L,2923L,17119L,13411L,5947L,5947L,13411L,125368L,26982L,122034L,26982L,125368L,110155L,48875L,75899L,75899L,48875L,110155L,878507L,181792L,877068L,464292L,877068L,181792L,878507L,868467L,349085L,617557L,696553L,696553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186488Inst : IEnumerable<long>
{
public static readonly long[] Value=A186488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186488.Bytes);
public long this[int i]=>Value[i];

public static A186488Inst Instance=new A186488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186487
{
public static readonly long[] Value={ 2401L,2923L,122034L,464292L,7513081L,24490909L,378414577L,1358113549L,19707528913L,75371432509L,1024871726713L,4153219862605L,53385123138265L,228131841095293L,2786244049366297L,12494376047174653L,145674143950067833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186487Inst : IEnumerable<long>
{
public static readonly long[] Value=A186487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186487.Bytes);
public long this[int i]=>Value[i];

public static A186487Inst Instance=new A186487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186486
{
public static readonly long[] Value={ 1296L,713L,713L,7988L,1638L,7988L,7147L,3343L,3343L,7147L,50755L,13342L,49225L,13342L,50755L,50359L,23790L,36032L,36032L,23790L,50359L,306067L,77358L,306279L,187120L,306279L,77358L,306067L,340221L,146406L,248504L,285899L,285899L,248504L,146406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186486Inst : IEnumerable<long>
{
public static readonly long[] Value=A186486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186486.Bytes);
public long this[int i]=>Value[i];

public static A186486Inst Instance=new A186486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186485
{
public static readonly long[] Value={ 1296L,1638L,49225L,187120L,2297416L,7285701L,85779021L,302363961L,3344266701L,12548833941L,129972246981L,515938724421L,5061186988761L,21139419297501L,197573066244141L,863365403630181L,7729201644744621L,35162376035723961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186485Inst : IEnumerable<long>
{
public static readonly long[] Value=A186485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186485.Bytes);
public long this[int i]=>Value[i];

public static A186485Inst Instance=new A186485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186484
{
public static readonly long[] Value={ 625L,419L,419L,3265L,839L,3265L,3335L,1715L,1715L,3335L,17608L,5879L,17015L,5879L,17608L,19617L,10259L,15061L,15061L,10259L,19617L,89163L,28628L,89650L,64680L,89650L,28628L,89163L,110707L,53045L,85269L,100789L,100789L,85269L,53045L,110707L,459455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186484Inst : IEnumerable<long>
{
public static readonly long[] Value=A186484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186484.Bytes);
public long this[int i]=>Value[i];

public static A186484Inst Instance=new A186484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186483
{
public static readonly long[] Value={ 625L,839L,17015L,64680L,575344L,1759744L,15145144L,52024944L,422063944L,1535037344L,11681382744L,44716060144L,324000643944L,1297964842944L,9013961908344L,37548525033744L,251396274363144L,1083126105726944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186483Inst : IEnumerable<long>
{
public static readonly long[] Value=A186483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186483.Bytes);
public long this[int i]=>Value[i];

public static A186483Inst Instance=new A186483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186482
{
public static readonly long[] Value={ 256L,205L,205L,1098L,362L,1098L,1251L,701L,701L,1251L,4895L,2049L,4686L,2049L,4895L,5955L,3442L,4810L,4810L,3442L,5955L,20079L,8223L,20224L,16762L,20224L,8223L,20079L,27101L,14492L,21760L,25633L,25633L,21760L,14492L,27101L,84228L,35081L,82632L,67714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186482Inst : IEnumerable<long>
{
public static readonly long[] Value=A186482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186482.Bytes);
public long this[int i]=>Value[i];

public static A186482Inst Instance=new A186482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186481
{
public static readonly long[] Value={ 27101L,35081L,101108L,286290L,479785L,1286113L,1894849L,5977657L,8078233L,25049545L,34600393L,103930809L,154520201L,437740901L,693356465L,1854858401L,3085313121L,7883094433L,13654582357L,33612555865L,60183013369L,143706271561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186481Inst : IEnumerable<long>
{
public static readonly long[] Value=A186481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186481.Bytes);
public long this[int i]=>Value[i];

public static A186481Inst Instance=new A186481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186480
{
public static readonly long[] Value={ 20079L,14492L,82632L,101305L,433513L,418177L,1849873L,1894849L,7687009L,8602033L,31645329L,39574001L,131802797L,181420169L,553069145L,820669641L,2331052105L,3678141757L,9868524241L,16371829777L,41936161201L,72480530737L,178779125389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186480Inst : IEnumerable<long>
{
public static readonly long[] Value=A186480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186480.Bytes);
public long this[int i]=>Value[i];

public static A186480Inst Instance=new A186480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186479
{
public static readonly long[] Value={ 5955L,8223L,21760L,67714L,108025L,305089L,418177L,1286113L,1812049L,5368065L,8100785L,22640045L,36286649L,96020681L,161275017L,408409609L,713044957L,1742523169L,3140266657L,7453942513L,13786320241L,31954929709L,60372875257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186479Inst : IEnumerable<long>
{
public static readonly long[] Value=A186479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186479.Bytes);
public long this[int i]=>Value[i];

public static A186479Inst Instance=new A186479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186478
{
public static readonly long[] Value={ 4895L,3442L,20224L,25633L,107353L,108025L,433513L,479785L,1793817L,2226665L,7478693L,10225073L,31371137L,46298817L,132181633L,207648469L,559418905L,924724441L,2376589225L,4095459817L,10129319461L,18060113137L,43291468321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186478Inst : IEnumerable<long>
{
public static readonly long[] Value=A186478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186478.Bytes);
public long this[int i]=>Value[i];

public static A186478Inst Instance=new A186478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186477
{
public static readonly long[] Value={ 1251L,2049L,4810L,16762L,25633L,67714L,101305L,286290L,456113L,1219034L,2037173L,5189546L,9017049L,22136029L,39734818L,94665157L,174517432L,405721297L,764487337L,1742099164L,3341954341L,7491958474L,14584990777L,32261305429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186477Inst : IEnumerable<long>
{
public static readonly long[] Value=A186477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186477.Bytes);
public long this[int i]=>Value[i];

public static A186477Inst Instance=new A186477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186476
{
public static readonly long[] Value={ 1098L,701L,4686L,4810L,20224L,21760L,82632L,101108L,344804L,465884L,1445243L,2112183L,6085048L,9483898L,25738600L,42272077L,109291705L,187344208L,465619270L,826593388L,1989294067L,3634249423L,8519209648L,15933856258L,36556619512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186476Inst : IEnumerable<long>
{
public static readonly long[] Value=A186476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186476.Bytes);
public long this[int i]=>Value[i];

public static A186476Inst Instance=new A186476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186427
{
public static readonly long[] Value={ 0L,9L,13L,16L,22L,31L,33L,43L,47L,55L,56L,66L,71L,91L,96L,102L,119L,139L,164L,167L,175L,199L,200L,242L,247L,258L,259L,271L,293L,302L,310L,340L,352L,356L,366L,368L,385L,392L,413L,419L,452L,491L,507L,522L,527L,543L,547L,598L,658L,667L,688L,722L,746L,772L,801L,810L,811L,816L,832L,837L,895L,906L,909L,935L,971L,975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186427Inst : IEnumerable<long>
{
public static readonly long[] Value=A186427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186427.Bytes);
public long this[int i]=>Value[i];

public static A186427Inst Instance=new A186427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186426
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,3L,4L,6L,10L,15L,23L,36L,57L,90L,142L,225L,358L,571L,912L,1458L,2334L,3742L,6006L,9648L,15510L,24951L,40164L,64689L,104241L,168048L,271015L,437221L,705571L,1138934L,1838916L,2969746L,4796900L,7749561L,12521629L,20235080L,32704173L,52862781L,85455587L,138156111L,223375201L,361186480L,584058718L,944511360L,1527499074L,2470446924L,3995662918L,6462775233L,10453566628L,16909223601L,27352387053L,44246403940L,71576559073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186426Inst : IEnumerable<long>
{
public static readonly long[] Value=A186426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186426.Bytes);
public long this[int i]=>Value[i];

public static A186426Inst Instance=new A186426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186425
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,7L,10L,14L,20L,30L,45L,68L,104L,161L,251L,393L,618L,976L,1547L,2459L,3917L,6251L,9993L,15999L,25647L,41157L,66108L,106272L,170961L,275202L,443250L,714265L,1151486L,1857057L,2995991L,4834907L,7804653L,12601553L,20351114L,32872743L,53107823L,85811996L,138674777L,224130364L,362286475L,585661676L,946848156L,1530906874L,2475418234L,4002917308L,6473364232L,10469027150L,16931802383L,27385369011L,44294592612L,71646979665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186425Inst : IEnumerable<long>
{
public static readonly long[] Value=A186425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186425.Bytes);
public long this[int i]=>Value[i];

public static A186425Inst Instance=new A186425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186424
{
public static readonly long[] Value={ 1L,3L,11L,17L,33L,43L,67L,81L,113L,131L,171L,193L,241L,267L,323L,353L,417L,451L,523L,561L,641L,683L,771L,817L,913L,963L,1067L,1121L,1233L,1291L,1411L,1473L,1601L,1667L,1803L,1873L,2017L,2091L,2243L,2321L,2481L,2563L,2731L,2817L,2993L,3083L,3267L,3361L,3553L,3651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186424Inst : IEnumerable<long>
{
public static readonly long[] Value=A186424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186424.Bytes);
public long this[int i]=>Value[i];

public static A186424Inst Instance=new A186424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186423
{
public static readonly long[] Value={ 0L,1L,3L,4L,8L,11L,17L,20L,28L,33L,43L,48L,60L,67L,81L,88L,104L,113L,131L,140L,160L,171L,193L,204L,228L,241L,267L,280L,308L,323L,353L,368L,400L,417L,451L,468L,504L,523L,561L,580L,620L,641L,683L,704L,748L,771L,817L,840L,888L,913L,963L,988L,1040L,1067L,1121L,1148L,1204L,1233L,1291L,1320L,1380L,1411L,1473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186423Inst : IEnumerable<long>
{
public static readonly long[] Value=A186423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186423.Bytes);
public long this[int i]=>Value[i];

public static A186423Inst Instance=new A186423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186422
{
public static readonly long[] Value={ 1L,1L,-1L,3L,-1L,3L,-3L,5L,-3L,5L,-5L,7L,-5L,7L,-7L,9L,-7L,9L,-9L,11L,-9L,11L,-11L,13L,-11L,13L,-13L,15L,-13L,15L,-15L,17L,-15L,17L,-17L,19L,-17L,19L,-19L,21L,-19L,21L,-21L,23L,-21L,23L,-23L,25L,-23L,25L,-25L,27L,-25L,27L,-27L,29L,-27L,29L,-29L,31L,-29L,31L,-31L,33L,-31L,33L,-33L,35L,-33L,35L,-35L,37L,-35L,37L,-37L,39L,-37L,39L,-39L,41L,-39L,41L,-41L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186422Inst : IEnumerable<long>
{
public static readonly long[] Value=A186422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186422.Bytes);
public long this[int i]=>Value[i];

public static A186422Inst Instance=new A186422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186421
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,3L,6L,3L,8L,5L,10L,5L,12L,7L,14L,7L,16L,9L,18L,9L,20L,11L,22L,11L,24L,13L,26L,13L,28L,15L,30L,15L,32L,17L,34L,17L,36L,19L,38L,19L,40L,21L,42L,21L,44L,23L,46L,23L,48L,25L,50L,25L,52L,27L,54L,27L,56L,29L,58L,29L,60L,31L,62L,31L,64L,33L,66L,33L,68L,35L,70L,35L,72L,37L,74L,37L,76L,39L,78L,39L,80L,41L,82L,41L,84L,43L,86L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186421Inst : IEnumerable<long>
{
public static readonly long[] Value=A186421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186421.Bytes);
public long this[int i]=>Value[i];

public static A186421Inst Instance=new A186421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186420
{
public static readonly BigInteger[] Value={ 1L,16L,1296L,160000L,24010000L,4032758016L,728933458176L,138735983333376L,27435582641610000L,5588044012339360000L,BigInteger.Parse("1165183173971324375296"),BigInteger.Parse("247639903129149250277376"),BigInteger.Parse("53472066459540320483696896"),BigInteger.Parse("11701285507234585729600000000"),BigInteger.Parse("2589980371199606611713600000000") };
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
public class A186420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186420Inst Instance=new A186420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186419
{
public static readonly BigInteger[] Value={ 1L,8L,432L,40000L,4802000L,672126336L,104133351168L,17341997916672L,3048398071290000L,558804401233936000L,BigInteger.Parse("105925743088302215936"),BigInteger.Parse("20636658594095770856448"),BigInteger.Parse("4113235881503101575668992"),BigInteger.Parse("835806107659613266400000000"),BigInteger.Parse("172665358079973774114240000000") };
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
public class A186419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186419Inst Instance=new A186419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186418
{
public static readonly BigInteger[] Value={ 1L,4L,144L,10000L,960400L,112021056L,14876193024L,2167749739584L,338710896810000L,55880440123393600L,9629613008027474176UL,BigInteger.Parse("1719721549507980904704"),BigInteger.Parse("316402760115623198128384"),BigInteger.Parse("59700436261400947600000000") };
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
public class A186418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186418Inst Instance=new A186418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186417
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,8L,10L,17L,24L,36L,50L,76L,102L,148L,204L,285L,386L,537L,718L,980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186417Inst : IEnumerable<long>
{
public static readonly long[] Value=A186417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186417.Bytes);
public long this[int i]=>Value[i];

public static A186417Inst Instance=new A186417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186416
{
public static readonly BigInteger[] Value={ 1L,2L,48L,2500L,192080L,18670176L,2125170432L,270968717448L,37634544090000L,5588044012339360L,875419364366134016L,BigInteger.Parse("143310129125665075392"),BigInteger.Parse("24338673855047938317568"),BigInteger.Parse("4264316875814353400000000"),BigInteger.Parse("767401591466550107174400000"),BigInteger.Parse("141345980472409642279275210000"),BigInteger.Parse("26569505644587874058090478570000") };
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
public class A186416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186416Inst Instance=new A186416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186415
{
public static readonly BigInteger[] Value={ 1L,4L,72L,2000L,68600L,2667168L,112698432L,5053029696L,236860767000L,11493303192800L,573327757086656L,29253930349198464L,1521079361361956032L,BigInteger.Parse("80361335659444000000"),BigInteger.Parse("4304087536829486400000"),BigInteger.Parse("233271979857187430688000"),BigInteger.Parse("12774642558686527109607000"),BigInteger.Parse("706008965215713532853436000"),BigInteger.Parse("39337406606398593529683000000") };
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
public class A186415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186415Inst Instance=new A186415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186414
{
public static readonly BigInteger[] Value={ 1L,2L,24L,500L,13720L,444528L,16099776L,631628712L,26317863000L,1149330319280L,52120705189696L,2437827529099872L,117006104720150464L,5740095404246000000L,BigInteger.Parse("286939169121965760000"),BigInteger.Parse("14579498741074214418000") };
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
public class A186414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186414Inst Instance=new A186414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186413
{
public static readonly long[] Value={ 1L,2L,5L,8L,16L,18L,20L,28L,25L,30L,40L,46L,41L,53L,56L,73L,62L,66L,81L,93L,85L,84L,89L,97L,101L,127L,121L,122L,119L,128L,150L,141L,144L,152L,150L,143L,174L,203L,197L,195L,196L,194L,213L,213L,218L,223L,230L,235L,249L,258L,256L,244L,264L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186413Inst : IEnumerable<long>
{
public static readonly long[] Value=A186413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186413.Bytes);
public long this[int i]=>Value[i];

public static A186413Inst Instance=new A186413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186412
{
public static readonly long[] Value={ 1L,3L,5L,2L,9L,3L,12L,2L,6L,3L,20L,3L,7L,4L,25L,2L,6L,3L,13L,5L,4L,38L,3L,7L,4L,14L,3L,9L,5L,49L,2L,6L,3L,13L,5L,4L,23L,4L,10L,6L,5L,69L,3L,7L,4L,14L,3L,9L,5L,27L,5L,4L,15L,7L,6L,87L,2L,6L,3L,13L,5L,4L,23L,4L,10L,6L,5L,39L,3L,9L,5L,19L,4L,12L,7L,6L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186412Inst : IEnumerable<long>
{
public static readonly long[] Value=A186412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186412.Bytes);
public long this[int i]=>Value[i];

public static A186412Inst Instance=new A186412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186363
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,3L,0L,1L,5L,4L,6L,0L,1L,15L,25L,10L,10L,0L,1L,71L,90L,75L,20L,15L,0L,1L,341L,497L,315L,175L,35L,21L,0L,1L,1945L,2728L,1988L,840L,350L,56L,28L,0L,1L,12135L,17505L,12276L,5964L,1890L,630L,84L,36L,0L,1L,84091L,121350L,87525L,40920L,14910L,3780L,1050L,120L,45L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186363Inst : IEnumerable<long>
{
public static readonly long[] Value=A186363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186363.Bytes);
public long this[int i]=>Value[i];

public static A186363Inst Instance=new A186363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186362
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,8L,59L,458L,3865L,35688L,360127L,3956214L,47096633L,604722604L,8337692687L,122932350162L,1930964182649L,32201197533072L,568323756438079L,10585305178638446L,207520767220183033L,4272031355927379828L,BigInteger.Parse("92145190111463378863"),BigInteger.Parse("2078280173125850650890") };
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
public class A186362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186362Inst Instance=new A186362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186361
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,16L,8L,61L,59L,272L,438L,10L,1385L,3445L,210L,7936L,29080L,3304L,50521L,264871L,47208L,280L,353792L,2605002L,658806L,11200L,2702765L,27634817L,9275838L,303380L,22368256L,315591124L,134010580L,7016240L,15400L,199360981L,3870632947L,2005021876L,151003996L,1001000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186361Inst : IEnumerable<long>
{
public static readonly long[] Value=A186361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186361.Bytes);
public long this[int i]=>Value[i];

public static A186361Inst Instance=new A186361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186360
{
public static readonly BigInteger[] Value={ 0L,1L,3L,10L,42L,215L,1306L,9203L,73896L,666449L,6672426L,73447207L,881720276L,11465066353L,160533297198L,2408198818951L,38533084860528L,655081834141121L,11791682879883154L,224044379597455367L,4480916680834220172L,BigInteger.Parse("94099620668706861137"),BigInteger.Parse("2070196606209604069110") };
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
public class A186360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186360Inst Instance=new A186360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186359
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1L,4L,19L,114L,799L,6392L,57527L,575270L,6327971L,75935652L,987163475L,13820288650L,207304329751L,3316869276016L,56386777692271L,1014961998460878L,19284277970756683L,385685559415133660L,8099396747717806859L,BigInteger.Parse("178186728449791750898") };
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
public class A186359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186359Inst Instance=new A186359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186358
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,3L,1L,4L,6L,7L,6L,1L,19L,35L,30L,25L,10L,1L,114L,210L,190L,125L,65L,15L,1L,799L,1468L,1351L,840L,420L,140L,21L,1L,6392L,11760L,10820L,6692L,3185L,1176L,266L,28L,1L,57527L,105905L,97458L,60058L,28098L,10479L,2856L,462L,36L,1L,575270L,1059306L,975140L,599640L,278500L,103593L,30345L,6210L,750L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186358Inst : IEnumerable<long>
{
public static readonly long[] Value=A186358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186358.Bytes);
public long this[int i]=>Value[i];

public static A186358Inst Instance=new A186358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186357
{
public static readonly long[] Value={ 1L,2L,4L,7L,9L,12L,16L,19L,23L,28L,32L,37L,43L,48L,54L,61L,67L,74L,82L,89L,97L,106L,114L,123L,133L,142L,152L,163L,173L,184L,196L,207L,219L,232L,244L,257L,271L,284L,298L,313L,327L,342L,358L,373L,389L,406L,422L,439L,457L,474L,492L,511L,529L,548L,568L,587L,607L,628L,648L,669L,691L,712L,734L,757L,779L,802L,826L,849L,873L,898L,922L,947L,973L,998L,1024L,1051L,1077L,1104L,1132L,1159L,1187L,1216L,1244L,1273L,1303L,1332L,1362L,1393L,1423L,1454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186357Inst : IEnumerable<long>
{
public static readonly long[] Value=A186357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186357.Bytes);
public long this[int i]=>Value[i];

public static A186357Inst Instance=new A186357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186356
{
public static readonly long[] Value={ 3L,5L,6L,8L,10L,11L,13L,14L,15L,17L,18L,20L,21L,22L,24L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,101L,102L,103L,104L,105L,107L,108L,109L,110L,111L,112L,113L,115L,116L,117L,118L,119L,120L,121L,122L,124L,125L,126L,127L,128L,129L,130L,131L,132L,134L,135L,136L,137L,138L,139L,140L,141L,143L,144L,145L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186356Inst : IEnumerable<long>
{
public static readonly long[] Value=A186356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186356.Bytes);
public long this[int i]=>Value[i];

public static A186356Inst Instance=new A186356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186355
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,13L,16L,20L,24L,28L,33L,38L,43L,49L,55L,61L,68L,75L,82L,90L,98L,106L,115L,124L,133L,143L,153L,163L,174L,185L,196L,208L,220L,232L,245L,258L,271L,285L,299L,313L,328L,343L,358L,374L,390L,406L,423L,440L,457L,475L,493L,511L,530L,549L,568L,588L,608L,628L,649L,670L,691L,713L,735L,757L,780L,803L,826L,850L,874L,898L,923L,948L,973L,999L,1025L,1051L,1078L,1105L,1132L,1160L,1188L,1216L,1245L,1274L,1303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186355Inst : IEnumerable<long>
{
public static readonly long[] Value=A186355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186355.Bytes);
public long this[int i]=>Value[i];

public static A186355Inst Instance=new A186355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186354
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,11L,12L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,96L,97L,99L,100L,101L,102L,103L,104L,105L,107L,108L,109L,110L,111L,112L,113L,114L,116L,117L,118L,119L,120L,121L,122L,123L,125L,126L,127L,128L,129L,130L,131L,132L,134L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186354Inst : IEnumerable<long>
{
public static readonly long[] Value=A186354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186354.Bytes);
public long this[int i]=>Value[i];

public static A186354Inst Instance=new A186354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186353
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,16L,21L,26L,31L,37L,44L,51L,58L,66L,75L,84L,93L,103L,114L,125L,136L,148L,161L,174L,187L,201L,216L,231L,246L,262L,279L,296L,313L,331L,350L,369L,388L,408L,429L,450L,471L,493L,516L,539L,562L,586L,611L,636L,661L,687L,714L,741L,768L,796L,825L,854L,883L,913L,944L,975L,1006L,1038L,1071L,1104L,1137L,1171L,1206L,1241L,1276L,1312L,1349L,1386L,1423L,1461L,1500L,1539L,1578L,1618L,1659L,1700L,1741L,1783L,1826L,1869L,1912L,1956L,2001L,2046L,2091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186353Inst : IEnumerable<long>
{
public static readonly long[] Value=A186353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186353.Bytes);
public long this[int i]=>Value[i];

public static A186353Inst Instance=new A186353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186352
{
public static readonly long[] Value={ 2L,4L,5L,7L,8L,10L,11L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L,91L,92L,94L,95L,96L,97L,98L,99L,100L,101L,102L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,137L,138L,139L,140L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186352Inst : IEnumerable<long>
{
public static readonly long[] Value=A186352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186352.Bytes);
public long this[int i]=>Value[i];

public static A186352Inst Instance=new A186352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186351
{
public static readonly long[] Value={ 2L,4L,6L,9L,13L,17L,21L,26L,32L,38L,44L,51L,59L,67L,75L,84L,94L,104L,114L,125L,137L,149L,161L,174L,188L,202L,216L,231L,247L,263L,279L,296L,314L,332L,350L,369L,389L,409L,429L,450L,472L,494L,516L,539L,563L,587L,611L,636L,662L,688L,714L,741L,769L,797L,825L,854L,884L,914L,944L,975L,1007L,1039L,1071L,1104L,1138L,1172L,1206L,1241L,1277L,1313L,1349L,1386L,1424L,1462L,1500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186351Inst : IEnumerable<long>
{
public static readonly long[] Value=A186351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186351.Bytes);
public long this[int i]=>Value[i];

public static A186351Inst Instance=new A186351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186350
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,11L,12L,14L,15L,16L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L,91L,92L,93L,95L,96L,97L,98L,99L,100L,101L,102L,103L,105L,106L,107L,108L,109L,110L,111L,112L,113L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,136L,138L,139L,140L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186350Inst : IEnumerable<long>
{
public static readonly long[] Value=A186350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186350.Bytes);
public long this[int i]=>Value[i];

public static A186350Inst Instance=new A186350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186349
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,13L,15L,19L,22L,26L,29L,34L,38L,43L,47L,53L,58L,64L,69L,76L,82L,89L,95L,103L,110L,118L,125L,134L,142L,151L,159L,169L,178L,188L,197L,208L,218L,229L,239L,251L,262L,274L,285L,298L,310L,323L,335L,349L,362L,376L,389L,404L,418L,433L,447L,463L,478L,494L,509L,526L,542L,559L,575L,593L,610L,628L,645L,664L,682L,701L,719L,739L,758L,778L,797L,818L,838L,859L,879L,901L,922L,944L,965L,988L,1010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186349Inst : IEnumerable<long>
{
public static readonly long[] Value=A186349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186349.Bytes);
public long this[int i]=>Value[i];

public static A186349Inst Instance=new A186349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186348
{
public static readonly long[] Value={ 3L,6L,7L,9L,11L,12L,14L,16L,17L,18L,20L,21L,23L,24L,25L,27L,28L,30L,31L,32L,33L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186348Inst : IEnumerable<long>
{
public static readonly long[] Value=A186348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186348.Bytes);
public long this[int i]=>Value[i];

public static A186348Inst Instance=new A186348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186283
{
public static readonly long[] Value={ 1L,2L,1L,6L,1L,18L,2L,8L,1L,2L,1L,630L,3L,2L,1L,7710L,1L,27594L,2L,6L,1L,2L,10L,24L,105L,9728L,1L,8L,1L,69273666L,8L,18166L,1285L,2L,1L,6L,4599L,2L,1L,326L,1L,10L,2L,14L,1L,50L,2L,90462791808L,5L,2L,1L,120L,1615L,16L,2L,568L,1L,3050L,1L,37800705069076950L,11545611L,2L,4L,126L,1L,2891160L,2L,145690999102L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186283Inst : IEnumerable<long>
{
public static readonly long[] Value=A186283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186283.Bytes);
public long this[int i]=>Value[i];

public static A186283Inst Instance=new A186283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186282
{
public static readonly long[] Value={ 1L,1L,0L,6L,7L,6L,6L,7L,2L,5L,2L,3L,0L,0L,7L,1L,1L,8L,6L,2L,9L,1L,9L,7L,5L,2L,4L,0L,3L,3L,8L,6L,5L,8L,7L,0L,8L,0L,5L,4L,8L,8L,6L,7L,1L,8L,6L,5L,1L,6L,2L,4L,0L,5L,4L,8L,9L,9L,0L,7L,3L,8L,9L,5L,3L,5L,0L,7L,7L,2L,9L,7L,6L,8L,1L,5L,5L,9L,6L,6L,8L,5L,3L,4L,8L,5L,2L,2L,5L,2L,5L,3L,4L,9L,5L,3L,1L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186282Inst : IEnumerable<long>
{
public static readonly long[] Value=A186282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186282.Bytes);
public long this[int i]=>Value[i];

public static A186282Inst Instance=new A186282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186281
{
public static readonly long[] Value={ 37L,43L,73L,79L,109L,127L,139L,181L,229L,241L,271L,277L,313L,331L,349L,367L,397L,421L,433L,457L,487L,547L,571L,577L,607L,613L,673L,691L,727L,733L,751L,757L,769L,823L,829L,853L,907L,919L,991L,1009L,1063L,1087L,1093L,1117L,1123L,1171L,1231L,1249L,1279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186281Inst : IEnumerable<long>
{
public static readonly long[] Value=A186281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186281.Bytes);
public long this[int i]=>Value[i];

public static A186281Inst Instance=new A186281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186280
{
public static readonly long[] Value={ 41L,47L,89L,131L,167L,233L,257L,269L,293L,311L,317L,359L,401L,431L,449L,521L,593L,617L,647L,653L,701L,773L,797L,809L,941L,953L,971L,977L,983L,1097L,1151L,1187L,1229L,1259L,1283L,1319L,1409L,1427L,1481L,1493L,1571L,1583L,1607L,1619L,1667L,1871L,1877L,1889L,1907L,1913L,1931L,1949L,1979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186280Inst : IEnumerable<long>
{
public static readonly long[] Value=A186280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186280.Bytes);
public long this[int i]=>Value[i];

public static A186280Inst Instance=new A186280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186279
{
public static readonly long[] Value={ 1L,10L,26L,41L,44L,47L,62L,68L,89L,100L,104L,119L,125L,128L,131L,134L,143L,146L,155L,161L,167L,182L,188L,215L,224L,233L,242L,257L,260L,269L,275L,293L,311L,317L,323L,359L,368L,371L,377L,386L,401L,404L,410L,422L,431L,437L,440L,449L,452L,470L,494L,518L,521L,527L,545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186279Inst : IEnumerable<long>
{
public static readonly long[] Value=A186279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186279.Bytes);
public long this[int i]=>Value[i];

public static A186279Inst Instance=new A186279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186278
{
public static readonly long[] Value={ 1L,4L,10L,28L,37L,40L,43L,58L,64L,73L,79L,82L,85L,91L,100L,109L,118L,124L,127L,139L,148L,154L,175L,181L,187L,208L,226L,229L,232L,235L,241L,247L,253L,265L,271L,277L,280L,286L,298L,304L,313L,316L,319L,322L,325L,331L,334L,349L,352L,355L,367L,370L,397L,400L,403L,415L,421L,424L,430L,433L,448L,454L,457L,469L,478L,481L,487L,505L,517L,526L,529L,532L,538L,544L,547L,571L,574L,577L,580L,586L,589L,598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186278Inst : IEnumerable<long>
{
public static readonly long[] Value=A186278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186278.Bytes);
public long this[int i]=>Value[i];

public static A186278Inst Instance=new A186278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186277
{
public static readonly long[] Value={ 1L,2L,5L,7L,8L,9L,10L,8L,7L,8L,12L,11L,10L,10L,6L,8L,6L,14L,10L,10L,16L,10L,6L,10L,14L,11L,10L,6L,14L,12L,15L,10L,10L,10L,8L,14L,14L,12L,6L,8L,6L,20L,10L,16L,11L,14L,18L,10L,6L,14L,10L,10L,22L,10L,15L,6L,8L,18L,14L,18L,10L,8L,15L,10L,18L,8L,18L,22L,6L,14L,14L,6L,10L,14L,18L,6L,8L,20L,17L,18L,10L,26L,10L,22L,10L,10L,16L,18L,14L,18L,6L,6L,14L,14L,10L,6L,8L,18L,14L,26L,18L,8L,6L,10L,18L,23L,6L,12L,10L,26L,10L,20L,18L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186277Inst : IEnumerable<long>
{
public static readonly long[] Value=A186277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186277.Bytes);
public long this[int i]=>Value[i];

public static A186277Inst Instance=new A186277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186276
{
public static readonly long[] Value={ 1L,5L,8L,12L,15L,19L,22L,26L,29L,33L,36L,40L,43L,46L,50L,53L,57L,60L,64L,67L,71L,74L,78L,81L,84L,88L,91L,95L,98L,102L,105L,109L,112L,115L,119L,122L,126L,129L,133L,136L,140L,143L,147L,150L,153L,157L,160L,164L,167L,171L,174L,178L,181L,184L,188L,191L,195L,198L,202L,205L,209L,212L,215L,219L,222L,226L,229L,233L,236L,240L,243L,247L,250L,253L,257L,260L,264L,267L,271L,274L,278L,281L,284L,288L,291L,295L,298L,302L,305L,309L,312L,316L,319L,322L,326L,329L,333L,336L,340L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186276Inst : IEnumerable<long>
{
public static readonly long[] Value=A186276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186276.Bytes);
public long this[int i]=>Value[i];

public static A186276Inst Instance=new A186276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186275
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,9L,10L,11L,13L,14L,16L,17L,18L,20L,21L,23L,24L,25L,27L,28L,30L,31L,32L,34L,35L,37L,38L,39L,41L,42L,44L,45L,47L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,63L,65L,66L,68L,69L,70L,72L,73L,75L,76L,77L,79L,80L,82L,83L,85L,86L,87L,89L,90L,92L,93L,94L,96L,97L,99L,100L,101L,103L,104L,106L,107L,108L,110L,111L,113L,114L,116L,117L,118L,120L,121L,123L,124L,125L,127L,128L,130L,131L,132L,134L,135L,137L,138L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186275Inst : IEnumerable<long>
{
public static readonly long[] Value=A186275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186275.Bytes);
public long this[int i]=>Value[i];

public static A186275Inst Instance=new A186275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186274
{
public static readonly long[] Value={ 2L,5L,9L,12L,15L,19L,22L,26L,29L,33L,36L,40L,43L,46L,50L,53L,57L,60L,64L,67L,71L,74L,78L,81L,84L,88L,91L,95L,98L,102L,105L,109L,112L,115L,119L,122L,126L,129L,133L,136L,140L,143L,147L,150L,153L,157L,160L,164L,167L,171L,174L,178L,181L,184L,188L,191L,195L,198L,202L,205L,209L,212L,216L,219L,222L,226L,229L,233L,236L,240L,243L,247L,250L,253L,257L,260L,264L,267L,271L,274L,278L,281L,284L,288L,291L,295L,298L,302L,305L,309L,312L,316L,319L,322L,326L,329L,333L,336L,340L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186274Inst : IEnumerable<long>
{
public static readonly long[] Value=A186274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186274.Bytes);
public long this[int i]=>Value[i];

public static A186274Inst Instance=new A186274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186273
{
public static readonly long[] Value={ 2L,11L,95L,3623L,2363L,6143L,21263L,89303L,202703L,472973L,493763L,1013513L,3986483L,3306713L,2364863L,21283763L,19932413L,29391863L,74887313L,98679263L,87499913L,134797163L,201013313L,267843713L,560472413L,775337063L,361823963L,673985813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186273Inst : IEnumerable<long>
{
public static readonly long[] Value=A186273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186273.Bytes);
public long this[int i]=>Value[i];

public static A186273Inst Instance=new A186273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186272
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,8L,13L,22L,38L,65L,112L,194L,337L,588L,1030L,1811L,3196L,5660L,10057L,17926L,32046L,57445L,103236L,185962L,335697L,607184L,1100186L,1996699L,3629044L,6604536L,12033861L,21949630L,40073798L,73225249L,133902408L,245023146L,448626225L,821848892L,1506270798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186272Inst : IEnumerable<long>
{
public static readonly long[] Value=A186272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186272.Bytes);
public long this[int i]=>Value[i];

public static A186272Inst Instance=new A186272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186271
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,357L,14637L,1449063L,346326057L,199830134889L,278363377900377L,936136039878967851L,BigInteger.Parse("7600488507777339982269"),BigInteger.Parse("148977175240943640992454669"),BigInteger.Parse("7049748909576694035403947391749"),BigInteger.Parse("805384464676770256686653161875581007") };
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
public class A186271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186271Inst Instance=new A186271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186270
{
public static readonly BigInteger[] Value={ 1L,1L,10L,280L,38080L,18887680L,39286374400L,319319651123200L,10504339243348787200UL,BigInteger.Parse("1374135642457914946355200"),BigInteger.Parse("721146385161913763847208960000"),BigInteger.Parse("1511615130036671973985522422906880000"),BigInteger.Parse("12683442560532981918553467630898150113280000"),BigInteger.Parse("425533759542581882449393472981756918078982062080000") };
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
public class A186270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186270Inst Instance=new A186270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186269
{
public static readonly BigInteger[] Value={ 1L,1L,6L,96L,5376L,946176L,544997376L,1011515129856L,6085275021213696L,BigInteger.Parse("118395110812733669376"),BigInteger.Parse("7456050498542715562622976"),BigInteger.Parse("1519364146391040406489059557376"),BigInteger.Parse("1001953802522449942301649259468947456"),BigInteger.Parse("2138185445843748536070796346094885374263296"),BigInteger.Parse("14766000790292725890315725371457440731168428261376") };
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
public class A186269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186269Inst Instance=new A186269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186268
{
public static readonly long[] Value={ 1L,2L,10L,64L,442L,3166L,23164L,171884L,1288404L,9731818L,73951550L,564689040L,4329242164L,33302459936L,256913334792L,1986880768892L,15399049701698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186268Inst : IEnumerable<long>
{
public static readonly long[] Value=A186268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186268.Bytes);
public long this[int i]=>Value[i];

public static A186268Inst Instance=new A186268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186251
{
public static readonly BigInteger[] Value={ 1L,1L,11L,196L,6621L,331816L,23484911L,2215289896L,268265691081L,40520069205136L,7462406090362331L,1645244324233761736L,BigInteger.Parse("427705624174427756061"),BigInteger.Parse("129446242864616486729896"),BigInteger.Parse("45117167155416556090204871"),BigInteger.Parse("17939982317115194446562110816"),BigInteger.Parse("8071743191485825080634857996561") };
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
public class A186251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186251Inst Instance=new A186251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186250
{
public static readonly BigInteger[] Value={ 1L,-1L,11L,-256L,10541L,-672136L,61001951L,-7445096296L,1172998147241L,-231333927486736L,55747918840676411L,BigInteger.Parse("-16100914826854576456"),BigInteger.Parse("5485174647349481371661"),BigInteger.Parse("-2175023364205612725532456"),BigInteger.Parse("992565740287786208277022391"),BigInteger.Parse("-516241740263310751317668520736") };
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
public class A186250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186250Inst Instance=new A186250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186249
{
public static readonly BigInteger[] Value={ 1L,1L,11L,256L,10541L,672136L,61001951L,7445096296L,1172998147241L,231333927486736L,55747918840676411L,16100914826854576456UL,BigInteger.Parse("5485174647349481371661"),BigInteger.Parse("2175023364205612725532456"),BigInteger.Parse("992565740287786208277022391"),BigInteger.Parse("516241740263310751317668520736") };
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
public class A186249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186249Inst Instance=new A186249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186248
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-44L,-211L,9136L,118799L,-9894884L,-368001271L,3949758496L,-1062959453221L,-352302017500124L,-54987975498787651L,BigInteger.Parse("-11177493084346370144"),BigInteger.Parse("-3145848334837840227961"),BigInteger.Parse("-988952736939184411495964"),BigInteger.Parse("-349477151478120199840810351"),BigInteger.Parse("-141758901275895434356815281984") };
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
public class A186248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186248Inst Instance=new A186248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186247
{
public static readonly BigInteger[] Value={ 1L,0L,0L,3L,0L,10L,90L,112L,1680L,10008L,52920L,503096L,3750120L,32707376L,317212896L,3115701240L,33444028800L,378122087104L,4501793066688L,56612612281984L,746976298243200L,10328059310335872L,149410872069250176L,2255298661460780288L,BigInteger.Parse("35481940129572393600"),BigInteger.Parse("580614509996338380800") };
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
public class A186247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186247Inst Instance=new A186247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186246
{
public static readonly BigInteger[] Value={ -1L,2L,-24L,720L,-40320L,3628800L,-479001600L,87178291200L,-20922789888000L,6402373705728000L,-2432902008176640000L,BigInteger.Parse("1124000727777607680000"),BigInteger.Parse("-620448401733239439360000"),BigInteger.Parse("403291461126605635584000000"),BigInteger.Parse("-304888344611713860501504000000"),BigInteger.Parse("265252859812191058636308480000000") };
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
public class A186246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186246Inst Instance=new A186246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186245
{
public static readonly BigInteger[] Value={ 1L,84L,12870L,3268760L,1251677700L,675248872536L,488526937079580L,456703981505085600L,BigInteger.Parse("535983370403809682970"),BigInteger.Parse("771629762387959506903300"),BigInteger.Parse("1337261858854117218288723600"),BigInteger.Parse("2746379593275133584459064976784"),BigInteger.Parse("6596095888094645606758451183394760") };
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
public class A186245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186245Inst Instance=new A186245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186244
{
public static readonly long[] Value={ 0L,0L,1L,5L,21L,79L,281L,963L,3217L,10547L,34089L,108955L,345137L,1085331L,3392377L,10549739L,32667201L,100782787L,309946697L,950599131L,2908512145L,8880484019L,27064776729L,82350874699L,250212362465L,759269653155L,2301393567721L,6968615051195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186244Inst : IEnumerable<long>
{
public static readonly long[] Value=A186244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186244.Bytes);
public long this[int i]=>Value[i];

public static A186244Inst Instance=new A186244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186243
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,12L,14L,17L,18L,19L,22L,28L,33L,38L,39L,47L,52L,53L,59L,64L,67L,74L,77L,78L,82L,84L,103L,108L,113L,124L,127L,129L,138L,143L,144L,147L,148L,152L,157L,162L,169L,182L,183L,203L,214L,217L,218L,238L,239L,242L,248L,249L,259L,262L,264L,267L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186243Inst : IEnumerable<long>
{
public static readonly long[] Value=A186243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186243.Bytes);
public long this[int i]=>Value[i];

public static A186243Inst Instance=new A186243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186242
{
public static readonly long[] Value={ 1L,1L,3L,13L,62L,317L,1707L,9529L,54634L,319838L,1903895L,11488985L,70122538L,432126645L,2685003765L,16802798157L,105811579002L,670008272170L,4263402119458L,27248174904238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186242Inst : IEnumerable<long>
{
public static readonly long[] Value=A186242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186242.Bytes);
public long this[int i]=>Value[i];

public static A186242Inst Instance=new A186242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186241
{
public static readonly long[] Value={ 1L,1L,3L,12L,54L,262L,1337L,7072L,38426L,213197L,1202795L,6879160L,39794416L,232429030L,1368806610L,8118934656L,48458809586L,290832756606L,1754059333738L,10625545472716L,64620970743082L,394409682103262L,2415084675723048L,14832185219521152L,91339478577683664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186241Inst : IEnumerable<long>
{
public static readonly long[] Value=A186241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186241.Bytes);
public long this[int i]=>Value[i];

public static A186241Inst Instance=new A186241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186240
{
public static readonly long[] Value={ 1L,1L,2L,7L,21L,66L,228L,799L,2843L,10357L,38278L,143012L,539980L,2056848L,7892496L,30483351L,118416903L,462348219L,1813410078L,7141608015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186240Inst : IEnumerable<long>
{
public static readonly long[] Value=A186240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186240.Bytes);
public long this[int i]=>Value[i];

public static A186240Inst Instance=new A186240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186239
{
public static readonly long[] Value={ 1L,1L,2L,6L,17L,51L,163L,533L,1779L,6055L,20908L,73052L,257863L,918139L,3293538L,11891778L,43183835L,157616827L,577902846L,2127539802L,7861397403L,29145629141L,108385383175L,404184619545L,1511132059333L,5663069529201L,21269203639596L,80044555061812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186239Inst : IEnumerable<long>
{
public static readonly long[] Value=A186239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186239.Bytes);
public long this[int i]=>Value[i];

public static A186239Inst Instance=new A186239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186238
{
public static readonly long[] Value={ 1L,5L,8L,11L,14L,18L,21L,24L,27L,31L,34L,37L,40L,44L,47L,50L,53L,57L,60L,63L,66L,70L,73L,76L,79L,82L,86L,89L,92L,95L,99L,102L,105L,108L,112L,115L,118L,121L,125L,128L,131L,134L,137L,141L,144L,147L,150L,154L,157L,160L,163L,167L,170L,173L,176L,180L,183L,186L,189L,192L,196L,199L,202L,205L,209L,212L,215L,218L,222L,225L,228L,231L,235L,238L,241L,244L,248L,251L,254L,257L,260L,264L,267L,270L,273L,277L,280L,283L,286L,290L,293L,296L,299L,303L,306L,309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186238Inst : IEnumerable<long>
{
public static readonly long[] Value=A186238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186238.Bytes);
public long this[int i]=>Value[i];

public static A186238Inst Instance=new A186238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186237
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,9L,10L,12L,13L,15L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,30L,32L,33L,35L,36L,38L,39L,41L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,84L,85L,87L,88L,90L,91L,93L,94L,96L,97L,98L,100L,101L,103L,104L,106L,107L,109L,110L,111L,113L,114L,116L,117L,119L,120L,122L,123L,124L,126L,127L,129L,130L,132L,133L,135L,136L,138L,139L,140L,142L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186237Inst : IEnumerable<long>
{
public static readonly long[] Value=A186237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186237.Bytes);
public long this[int i]=>Value[i];

public static A186237Inst Instance=new A186237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186236
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,34L,93L,262L,753L,2198L,6502L,19449L,58724L,178739L,547836L,1689407L,5237939L,16318137L,51056027L,160363129L,505456920L,1598263936L,5068483189L,16116397411L,51371962474L,164123564499L,525447953073L,1685534207788L,5416719384326L,17437073203711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186236Inst : IEnumerable<long>
{
public static readonly long[] Value=A186236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186236.Bytes);
public long this[int i]=>Value[i];

public static A186236Inst Instance=new A186236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186187
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186187Inst : IEnumerable<long>
{
public static readonly long[] Value=A186187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186187.Bytes);
public long this[int i]=>Value[i];

public static A186187Inst Instance=new A186187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186186
{
public static readonly long[] Value={ 1L,1L,3L,12L,63L,403L,2919L,22833L,187799L,1599718L,13984383L,124717327L,1130144932L,10375309228L,96290993853L,901915801437L,8514822062757L,80939662475426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186186Inst : IEnumerable<long>
{
public static readonly long[] Value=A186186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186186.Bytes);
public long this[int i]=>Value[i];

public static A186186Inst Instance=new A186186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186185
{
public static readonly long[] Value={ 1L,1L,3L,11L,48L,239L,1306L,7612L,46436L,292875L,1894365L,12496864L,83753165L,568628232L,3902600850L,27031069848L,188709211952L,1326456525471L,9379857716098L,66680723764051L,476269444919163L,3416178576731504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186185Inst : IEnumerable<long>
{
public static readonly long[] Value=A186185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186185.Bytes);
public long this[int i]=>Value[i];

public static A186185Inst Instance=new A186185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186184
{
public static readonly long[] Value={ 1L,1L,2L,10L,89L,1002L,12592L,168805L,2363241L,34138860L,505042286L,7612594936L,116492572621L,1804984878387L,28260999959595L,446441276449715L,7106718529937710L,113886198966545724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186184Inst : IEnumerable<long>
{
public static readonly long[] Value=A186184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186184.Bytes);
public long this[int i]=>Value[i];

public static A186184Inst Instance=new A186184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186183
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,68L,646L,6857L,77695L,919642L,11233858L,140544189L,1791614714L,23187320736L,303861373679L,4023883823059L,53762917329659L,723854999871943L,9811154512175468L,133762940465746744L,1833187046654598058L,BigInteger.Parse("25239961633188882896") };
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
public class A186183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186183Inst Instance=new A186183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186182
{
public static readonly long[] Value={ 1L,1L,2L,8L,50L,388L,3363L,31132L,301156L,3007000L,30753169L,320492869L,3391067666L,36331532588L,393353506931L,4296895624750L,47300050998991L,524168531729460L,5842914510975105L,65470405191871331L,737008925038212059L,8331166456981245521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186182Inst : IEnumerable<long>
{
public static readonly long[] Value=A186182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186182.Bytes);
public long this[int i]=>Value[i];

public static A186182Inst Instance=new A186182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186181
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186181Inst : IEnumerable<long>
{
public static readonly long[] Value=A186181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186181.Bytes);
public long this[int i]=>Value[i];

public static A186181Inst Instance=new A186181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186180
{
public static readonly long[] Value={ 520017L,10084236L,10084236L,143369699L,311128593L,143369699L,1662436696L,6520730198L,6520730198L,1662436696L,16382439469L,105970767207L,188034884094L,105970767207L,16382439469L,140871930232L,1414199542732L,4041778238254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186180Inst : IEnumerable<long>
{
public static readonly long[] Value=A186180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186180.Bytes);
public long this[int i]=>Value[i];

public static A186180Inst Instance=new A186180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186179
{
public static readonly BigInteger[] Value={ 7459396065112L,1400823449171621L,132151619698400257L,8143852416376007571L,BigInteger.Parse("366735655207529538678"),BigInteger.Parse("12873752982804494965778"),BigInteger.Parse("367664080675457084952938"),BigInteger.Parse("8806300375583656355791730"),BigInteger.Parse("180948530569018142116132834") };
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
public class A186179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186179Inst Instance=new A186179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186178
{
public static readonly BigInteger[] Value={ 1078197169699L,159099595031390L,12251749347425002L,629512200937395977L,BigInteger.Parse("23974440869491730184"),BigInteger.Parse("719176668433423037034"),BigInteger.Parse("17695100284866122677270"),BigInteger.Parse("367664080675457084952938"),BigInteger.Parse("6594122451689240367926243") };
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
public class A186178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186178Inst Instance=new A186178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186177
{
public static readonly BigInteger[] Value={ 140871930232L,16059530994398L,995828085723859L,42174821764604242L,1345005095452611398L,BigInteger.Parse("34184079614729409659"),BigInteger.Parse("719176668433423037034"),BigInteger.Parse("12873752982804494965778"),BigInteger.Parse("200226675186485305381447") };
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
public class A186177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186177Inst Instance=new A186177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186176
{
public static readonly BigInteger[] Value={ 16382439469L,1414199542732L,69471558136868L,2391923493659465L,63117570540037053L,1345005095452611398L,BigInteger.Parse("23974440869491730184"),BigInteger.Parse("366735655207529538678"),BigInteger.Parse("4909755021412940860546"),BigInteger.Parse("58427464010453596260035") };
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
public class A186176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186176Inst Instance=new A186176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186175
{
public static readonly BigInteger[] Value={ 1662436696L,105970767207L,4041778238254L,111203560772547L,2391923493659465L,42174821764604242L,629512200937395977L,8143852416376007571L,BigInteger.Parse("92981285763140685886"),BigInteger.Parse("950506396177707075676"),BigInteger.Parse("8802483321307673371982") };
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
public class A186175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186175Inst Instance=new A186175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186174
{
public static readonly BigInteger[] Value={ 143369699L,6520730198L,188034884094L,4041778238254L,69471558136868L,995828085723859L,12251749347425002L,132151619698400257L,1270399513311212137L,11027904404610778911UL,BigInteger.Parse("87373338782676104482") };
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
public class A186174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186174Inst Instance=new A186174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186173
{
public static readonly BigInteger[] Value={ 10084236L,311128593L,6520730198L,105970767207L,1414199542732L,16059530994398L,159099595031390L,1400823449171621L,11121210203531892L,80539662788823416L,537137318447864717L,3325230272014630746L,BigInteger.Parse("19236676772755037673") };
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
public class A186173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186173Inst Instance=new A186173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186172
{
public static readonly long[] Value={ 520017L,10084236L,143369699L,1662436696L,16382439469L,140871930232L,1078197169699L,7459396065112L,47221234070168L,276218909139304L,1504985434117375L,7689047974774610L,37044742671636217L,169120726715615719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186172Inst : IEnumerable<long>
{
public static readonly long[] Value=A186172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186172.Bytes);
public long this[int i]=>Value[i];

public static A186172Inst Instance=new A186172Inst();

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