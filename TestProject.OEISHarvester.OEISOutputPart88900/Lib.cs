using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A108541
{
public static readonly long[] Value={ 2L,3L,7L,11L,19L,23L,29L,37L,41L,67L,79L,97L,101L,103L,107L,131L,149L,163L,167L,181L,193L,227L,241L,271L,277L,283L,311L,353L,367L,379L,383L,397L,409L,419L,433L,449L,457L,487L,509L,563L,607L,613L,631L,661L,719L,733L,761L,797L,853L,883L,919L,941L,971L,997L,1031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108541Inst : IEnumerable<long>
{
public static readonly long[] Value=A108541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108541.Bytes);
public long this[int i]=>Value[i];

public static A108541Inst Instance=new A108541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108542
{
public static readonly long[] Value={ 3L,5L,11L,17L,31L,37L,47L,59L,67L,109L,127L,157L,163L,167L,173L,211L,241L,263L,271L,293L,313L,367L,389L,439L,449L,457L,503L,571L,593L,613L,619L,643L,661L,677L,701L,727L,739L,787L,823L,911L,983L,991L,1021L,1069L,1163L,1187L,1231L,1289L,1381L,1429L,1487L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108542Inst : IEnumerable<long>
{
public static readonly long[] Value=A108542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108542.Bytes);
public long this[int i]=>Value[i];

public static A108542Inst Instance=new A108542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108543
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,19L,23L,29L,31L,37L,41L,47L,59L,67L,79L,97L,101L,103L,107L,109L,127L,131L,149L,157L,163L,167L,173L,181L,193L,211L,227L,241L,263L,271L,277L,283L,293L,311L,313L,353L,367L,379L,383L,389L,397L,409L,419L,433L,439L,449L,457L,487L,503L,509L,563L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108543Inst : IEnumerable<long>
{
public static readonly long[] Value=A108543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108543.Bytes);
public long this[int i]=>Value[i];

public static A108543Inst Instance=new A108543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108544
{
public static readonly long[] Value={ 3L,11L,37L,67L,163L,167L,241L,271L,367L,449L,457L,613L,661L,1613L,1979L,2069L,2137L,2221L,2347L,2351L,2381L,2399L,2477L,2633L,2749L,2837L,3011L,3449L,3593L,3671L,3797L,3911L,3943L,4001L,4049L,4079L,4241L,4999L,5147L,5261L,5711L,5981L,6337L,6379L,6619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108544Inst : IEnumerable<long>
{
public static readonly long[] Value=A108544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108544.Bytes);
public long this[int i]=>Value[i];

public static A108544Inst Instance=new A108544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108545
{
public static readonly long[] Value={ 13L,43L,53L,61L,71L,73L,83L,89L,113L,137L,139L,151L,179L,191L,197L,199L,223L,229L,233L,239L,251L,257L,269L,281L,307L,317L,331L,337L,347L,349L,359L,373L,401L,421L,431L,443L,461L,463L,467L,479L,491L,499L,521L,523L,541L,547L,557L,569L,577L,587L,599L,601L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108545Inst : IEnumerable<long>
{
public static readonly long[] Value=A108545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108545.Bytes);
public long this[int i]=>Value[i];

public static A108545Inst Instance=new A108545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108546
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,11L,17L,19L,29L,23L,37L,31L,41L,43L,53L,47L,61L,59L,73L,67L,89L,71L,97L,79L,101L,83L,109L,103L,113L,107L,137L,127L,149L,131L,157L,139L,173L,151L,181L,163L,193L,167L,197L,179L,229L,191L,233L,199L,241L,211L,257L,223L,269L,227L,277L,239L,281L,251L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108546Inst : IEnumerable<long>
{
public static readonly long[] Value=A108546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108546.Bytes);
public long this[int i]=>Value[i];

public static A108546Inst Instance=new A108546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108547
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,41L,43L,461L,463L,26833L,26839L,26849L,26879L,26881L,26891L,26893L,26903L,26921L,26927L,616769L,616783L,616793L,616799L,616829L,617039L,617257L,617471L,617473L,617479L,617509L,617587L,617681L,617723L,618437L,618439L,618521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108547Inst : IEnumerable<long>
{
public static readonly long[] Value=A108547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108547.Bytes);
public long this[int i]=>Value[i];

public static A108547Inst Instance=new A108547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108548
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,13L,12L,11L,14L,15L,16L,17L,18L,19L,20L,21L,26L,29L,24L,25L,22L,27L,28L,23L,30L,37L,32L,39L,34L,35L,36L,31L,38L,33L,40L,41L,42L,43L,52L,45L,58L,53L,48L,49L,50L,51L,44L,47L,54L,65L,56L,57L,46L,61L,60L,59L,74L,63L,64L,55L,78L,73L,68L,87L,70L,67L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108548Inst : IEnumerable<long>
{
public static readonly long[] Value=A108548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108548.Bytes);
public long this[int i]=>Value[i];

public static A108548Inst Instance=new A108548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108549
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,17L,18L,19L,20L,21L,24L,25L,27L,28L,30L,32L,34L,35L,36L,38L,40L,41L,42L,43L,45L,48L,49L,50L,51L,54L,56L,57L,60L,63L,64L,68L,70L,72L,75L,76L,80L,81L,82L,84L,85L,86L,90L,95L,96L,98L,100L,102L,105L,108L,112L,114L,119L,120L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108549Inst : IEnumerable<long>
{
public static readonly long[] Value=A108549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108549.Bytes);
public long this[int i]=>Value[i];

public static A108549Inst Instance=new A108549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108550
{
public static readonly long[] Value={ 2L,18L,160L,1530L,14800L,143386L,1389432L,13464130L,130472968L,1264337250L,12251953552L,118726523722L,1150509376512L,11148914193898L,108037613809384L,1046929395512082L,10145181113692600L,98311022950389682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108550Inst : IEnumerable<long>
{
public static readonly long[] Value=A108550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108550.Bytes);
public long this[int i]=>Value[i];

public static A108550Inst Instance=new A108550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108551
{
public static readonly ulong[] Value={ 100L,136L,1425L,389305L,8946176L,225331713L,6210001000L,186492227801L,6073061476032L,213404945384449L,8054585122464440L,325144322753909625L,13983676842985394176UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108551Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A108551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108551.Bytes);
public ulong this[int i]=>Value[i];

public static A108551Inst Instance=new A108551Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108552
{
public static readonly BigInteger[] Value={ 1L,1L,8L,180L,1120L,8064L,604800L,68428800L,830269440L,10897286400L,2324754432000L,640237370572800L,11585247657984000L,221172909834240000L,BigInteger.Parse("93666727314800640000"),BigInteger.Parse("2068161339110798131200"),BigInteger.Parse("47726800133326110720000") };
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
public class A108552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108552Inst Instance=new A108552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108553
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,13L,13L,7L,1L,1L,25L,55L,25L,9L,1L,1L,41L,169L,147L,41L,11L,1L,1L,61L,411L,625L,309L,61L,13L,1L,1L,85L,853L,2051L,1681L,561L,85L,15L,1L,1L,113L,1583L,5577L,6981L,3721L,923L,113L,17L,1L,1L,145L,2705L,13203L,23673L,18733L,7225L,1415L,145L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108553Inst : IEnumerable<long>
{
public static readonly long[] Value=A108553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108553.Bytes);
public long this[int i]=>Value[i];

public static A108553Inst Instance=new A108553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108554
{
public static readonly long[] Value={ 1L,3L,13L,147L,1681L,18733L,204205L,2195399L,23429185L,249258777L,2650436845L,28209301211L,300745906449L,3212758605189L,34392151363021L,368908132170511L,3964622452867329L,42682164804034609L,460242445806795853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108554Inst : IEnumerable<long>
{
public static readonly long[] Value=A108554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108554.Bytes);
public long this[int i]=>Value[i];

public static A108554Inst Instance=new A108554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108555
{
public static readonly long[] Value={ 1L,2L,5L,12L,35L,116L,411L,1482L,5333L,19030L,67265L,235704L,819863L,2834600L,9752951L,33428054L,114228713L,389419114L,1325155261L,4503031332L,15285291851L,51842203804L,175719341971L,595316455842L,2016131645245L,6826076021310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108555Inst : IEnumerable<long>
{
public static readonly long[] Value=A108555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108555.Bytes);
public long this[int i]=>Value[i];

public static A108555Inst Instance=new A108555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108556
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,1L,12L,30L,20L,1L,24L,120L,192L,96L,1L,40L,330L,940L,1080L,432L,1L,60L,732L,3200L,6240L,5568L,1856L,1L,84L,1414L,8708L,25200L,37184L,27104L,7744L,1L,112L,2480L,20352L,80960L,173824L,206080L,126976L,31744L,1L,144L,4050L,42588L,221544L,643824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108556Inst : IEnumerable<long>
{
public static readonly long[] Value=A108556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108556.Bytes);
public long this[int i]=>Value[i];

public static A108556Inst Instance=new A108556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108557
{
public static readonly long[] Value={ 1L,3L,9L,63L,433L,2823L,17657L,107439L,642529L,3802167L,22357097L,130970271L,765564049L,4469342439L,26073165401L,152043343119L,886424978881L,5167271805207L,30119654732489L,175558462395135L,1023255914549617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108557Inst : IEnumerable<long>
{
public static readonly long[] Value=A108557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108557.Bytes);
public long this[int i]=>Value[i];

public static A108557Inst Instance=new A108557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108558
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,9L,9L,1L,1L,20L,54L,20L,1L,1L,35L,180L,180L,35L,1L,1L,54L,447L,852L,447L,54L,1L,1L,77L,931L,2863L,2863L,931L,77L,1L,1L,104L,1724L,7768L,12550L,7768L,1724L,104L,1L,1L,135L,2934L,18186L,43128L,43128L,18186L,2934L,135L,1L,1L,170L,4685L,38200L,124850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108558Inst : IEnumerable<long>
{
public static readonly long[] Value=A108558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108558.Bytes);
public long this[int i]=>Value[i];

public static A108558Inst Instance=new A108558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108559
{
public static readonly long[] Value={ 4L,30L,36L,41L,45L,56L,60L,73L,84L,89L,95L,127L,128L,134L,156L,183L,193L,194L,201L,239L,244L,251L,284L,302L,323L,331L,348L,360L,368L,372L,387L,391L,409L,413L,431L,432L,442L,454L,463L,496L,514L,516L,546L,565L,568L,620L,629L,636L,646L,667L,684L,696L,703L,705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108559Inst : IEnumerable<long>
{
public static readonly long[] Value=A108559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108559.Bytes);
public long this[int i]=>Value[i];

public static A108559Inst Instance=new A108559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108560
{
public static readonly long[] Value={ 1L,13L,17L,20L,22L,29L,31L,40L,47L,50L,54L,76L,77L,81L,97L,116L,124L,125L,130L,158L,163L,168L,195L,209L,224L,232L,245L,253L,261L,265L,278L,280L,292L,296L,312L,313L,321L,333L,342L,367L,381L,383L,407L,424L,427L,473L,480L,487L,495L,514L,527L,539L,546L,548L,549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108560Inst : IEnumerable<long>
{
public static readonly long[] Value=A108560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108560.Bytes);
public long this[int i]=>Value[i];

public static A108560Inst Instance=new A108560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108561
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,1L,1L,1L,1L,-1L,1L,2L,2L,0L,1L,1L,3L,4L,2L,1L,-1L,1L,4L,7L,6L,3L,0L,1L,1L,5L,11L,13L,9L,3L,1L,-1L,1L,6L,16L,24L,22L,12L,4L,0L,1L,1L,7L,22L,40L,46L,34L,16L,4L,1L,-1L,1L,8L,29L,62L,86L,80L,50L,20L,5L,0L,1L,1L,9L,37L,91L,148L,166L,130L,70L,25L,5L,1L,-1L,1L,10L,46L,128L,239L,314L,296L,200L,95L,30L,6L,0L,1L,1L,11L,56L,174L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108561Inst : IEnumerable<long>
{
public static readonly long[] Value=A108561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108561.Bytes);
public long this[int i]=>Value[i];

public static A108561Inst Instance=new A108561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108562
{
public static readonly long[] Value={ 2L,3L,5L,13L,17L,53L,61L,79L,103L,109L,137L,151L,163L,179L,229L,271L,277L,317L,353L,409L,419L,431L,439L,443L,491L,499L,547L,557L,569L,593L,619L,631L,641L,677L,719L,811L,887L,937L,997L,1009L,1021L,1051L,1063L,1091L,1201L,1229L,1249L,1259L,1307L,1327L,1367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108562Inst : IEnumerable<long>
{
public static readonly long[] Value=A108562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108562.Bytes);
public long this[int i]=>Value[i];

public static A108562Inst Instance=new A108562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108563
{
public static readonly long[] Value={ 1L,0L,2L,2L,0L,4L,0L,0L,2L,0L,0L,4L,2L,0L,4L,0L,0L,0L,2L,0L,4L,4L,0L,0L,0L,0L,0L,2L,0L,4L,4L,0L,2L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,4L,4L,0L,0L,2L,0L,6L,0L,0L,4L,0L,0L,4L,0L,0L,4L,0L,0L,4L,0L,0L,0L,4L,0L,0L,0L,0L,0L,2L,0L,0L,6L,0L,8L,0L,0L,4L,0L,0L,4L,4L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,6L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108563Inst : IEnumerable<long>
{
public static readonly long[] Value=A108563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108563.Bytes);
public long this[int i]=>Value[i];

public static A108563Inst Instance=new A108563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108564
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,8L,15L,29L,56L,18L,118L,122L,134L,239L,136L,136L,456L,679L,147L,1148L,234L,228L,1577L,1378L,1347L,345L,4467L,3577L,3679L,1268L,11299L,12389L,23568L,24458L,11477L,12789L,22279L,137L,24668L,35789L,23788L,23488L,13377L,24469L,12258L,23579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108564Inst : IEnumerable<long>
{
public static readonly long[] Value=A108564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108564.Bytes);
public long this[int i]=>Value[i];

public static A108564Inst Instance=new A108564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108565
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,8L,16L,13L,34L,57L,128L,248L,48L,155L,366L,459L,1267L,2259L,456L,478L,1499L,5599L,1129L,1169L,4789L,11458L,12444L,3899L,33579L,16669L,4789L,1378L,1346L,15677L,35899L,5899L,1699L,256L,3459L,12247L,2356L,127L,14458L,23467L,25556L,45669L,12779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108565Inst : IEnumerable<long>
{
public static readonly long[] Value=A108565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108565.Bytes);
public long this[int i]=>Value[i];

public static A108565Inst Instance=new A108565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108566
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,8L,16L,23L,45L,89L,158L,339L,67L,127L,258L,138L,178L,117L,588L,146L,1245L,1224L,3489L,689L,1378L,1178L,239L,1789L,2678L,1579L,1488L,1589L,2369L,11249L,2259L,2335L,12289L,239L,347L,12788L,2357L,3355L,13357L,23344L,45558L,1579L,5589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108566Inst : IEnumerable<long>
{
public static readonly long[] Value=A108566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108566.Bytes);
public long this[int i]=>Value[i];

public static A108566Inst Instance=new A108566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108567
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,8L,16L,23L,55L,19L,127L,225L,347L,128L,249L,115L,112L,133L,139L,1223L,299L,227L,2248L,1348L,1567L,157L,679L,2556L,2788L,11334L,2249L,1233L,2699L,23358L,12467L,12568L,5689L,2366L,368L,15559L,23577L,24579L,4678L,16678L,5788L,12279L,11338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108567Inst : IEnumerable<long>
{
public static readonly long[] Value=A108567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108567.Bytes);
public long this[int i]=>Value[i];

public static A108567Inst Instance=new A108567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108568
{
public static readonly long[] Value={ 2L,3L,5L,9L,13L,17L,21L,25L,33L,39L,45L,53L,57L,61L,69L,79L,85L,91L,99L,103L,109L,117L,125L,137L,147L,151L,155L,159L,163L,179L,195L,203L,209L,219L,229L,235L,245L,253L,261L,271L,277L,287L,297L,301L,305L,317L,339L,353L,357L,361L,369L,375L,385L,399L,409L,419L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108568Inst : IEnumerable<long>
{
public static readonly long[] Value=A108568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108568.Bytes);
public long this[int i]=>Value[i];

public static A108568Inst Instance=new A108568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108569
{
public static readonly long[] Value={ 1L,4L,8L,16L,32L,64L,110L,128L,220L,256L,440L,506L,512L,550L,880L,1012L,1024L,1100L,1760L,1830L,2024L,2048L,2162L,2200L,2750L,3422L,3520L,3660L,4048L,4096L,4114L,4324L,4400L,4746L,5490L,5500L,5566L,6806L,6844L,7040L,7320L,7782L,8096L,8192L,8228L,8648L,8800L,9150L,9492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108569Inst : IEnumerable<long>
{
public static readonly long[] Value=A108569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108569.Bytes);
public long this[int i]=>Value[i];

public static A108569Inst Instance=new A108569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108570
{
public static readonly long[] Value={ 9L,25L,121L,289L,841L,1681L,3481L,5041L,10201L,11449L,18769L,22201L,32041L,36481L,38809L,51529L,57121L,72361L,78961L,96721L,120409L,175561L,185761L,212521L,271441L,323761L,358801L,380689L,410881L,434281L,654481L,674041L,683929L,734449L,776161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108570Inst : IEnumerable<long>
{
public static readonly long[] Value=A108570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108570.Bytes);
public long this[int i]=>Value[i];

public static A108570Inst Instance=new A108570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108571
{
public static readonly long[] Value={ 1L,22L,122L,212L,221L,333L,1333L,3133L,3313L,3331L,4444L,14444L,22333L,23233L,23323L,23332L,32233L,32323L,32332L,33223L,33232L,33322L,41444L,44144L,44414L,44441L,55555L,122333L,123233L,123323L,123332L,132233L,132323L,132332L,133223L,133232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108571Inst : IEnumerable<long>
{
public static readonly long[] Value=A108571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108571.Bytes);
public long this[int i]=>Value[i];

public static A108571Inst Instance=new A108571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108572
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,3L,0L,4L,2L,7L,0L,13L,0L,15L,8L,21L,0L,37L,0L,44L,16L,56L,0L,93L,6L,101L,29L,137L,0L,217L,0L,230L,57L,297L,20L,450L,0L,490L,102L,643L,0L,918L,0L,1004L,202L,1255L,0L,1783L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108572Inst : IEnumerable<long>
{
public static readonly long[] Value=A108572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108572.Bytes);
public long this[int i]=>Value[i];

public static A108572Inst Instance=new A108572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108573
{
public static readonly long[] Value={ 390L,1334L,136L,2058L,2710L,2082L,748L,2388L,3588L,1902L,988L,9170L,5076L,28778L,2112L,1800L,3082L,1238L,12916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108573Inst : IEnumerable<long>
{
public static readonly long[] Value=A108573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108573.Bytes);
public long this[int i]=>Value[i];

public static A108573Inst Instance=new A108573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108574
{
public static readonly long[] Value={ 4L,6L,9L,10L,14L,15L,21L,22L,25L,26L,33L,34L,38L,39L,46L,49L,51L,57L,58L,62L,65L,69L,74L,82L,85L,86L,87L,91L,93L,94L,106L,111L,118L,121L,122L,123L,129L,133L,134L,141L,142L,145L,146L,158L,159L,166L,169L,177L,178L,183L,185L,194L,201L,202L,205L,206L,213L,214L,217L,218L,219L,226L,237L,249L,254L,259L,262L,265L,267L,274L,278L,289L,291L,298L,301L,302L,303L,305L,309L,314L,321L,326L,327L,334L,339L,341L,346L,358L,361L,362L,365L,381L,382L,386L,393L,394L,398L,411L,417L,422L,427L,445L,446L,447L,451L,453L,454L,458L,466L,469L,471L,478L,481L,482L,485L,489L,501L,502L,505L,511L,514L,519L,526L,529L,537L,538L,542L,543L,545L,553L,554L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108574Inst : IEnumerable<long>
{
public static readonly long[] Value=A108574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108574.Bytes);
public long this[int i]=>Value[i];

public static A108574Inst Instance=new A108574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108575
{
public static readonly long[] Value={ 3L,7L,8L,13L,14L,15L,22L,23L,24L,32L,33L,34L,35L,44L,47L,48L,58L,59L,60L,62L,63L,74L,75L,78L,79L,80L,95L,96L,98L,99L,114L,119L,120L,135L,136L,138L,140L,141L,142L,143L,160L,162L,164L,167L,168L,185L,187L,189L,192L,194L,195L,215L,219L,220L,222L,223L,224L,248L,252L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108575Inst : IEnumerable<long>
{
public static readonly long[] Value=A108575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108575.Bytes);
public long this[int i]=>Value[i];

public static A108575Inst Instance=new A108575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108576
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,16L,40L,64L,96L,128L,184L,240L,320L,400L,504L,608L,744L,880L,1056L,1232L,1440L,1648L,1904L,2160L,2464L,2768L,3120L,3472L,3880L,4288L,4760L,5232L,5760L,6288L,6888L,7488L,8160L,8832L,9576L,10320L,11144L,11968L,12880L,13792L,14784L,15776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108576Inst : IEnumerable<long>
{
public static readonly long[] Value=A108576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108576.Bytes);
public long this[int i]=>Value[i];

public static A108576Inst Instance=new A108576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108577
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,5L,8L,12L,16L,23L,30L,40L,50L,63L,76L,93L,110L,132L,154L,180L,206L,238L,270L,308L,346L,390L,434L,485L,536L,595L,654L,720L,786L,861L,936L,1020L,1104L,1197L,1290L,1393L,1496L,1610L,1724L,1848L,1972L,2108L,2244L,2392L,2540L,2700L,2860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108577Inst : IEnumerable<long>
{
public static readonly long[] Value=A108577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108577.Bytes);
public long this[int i]=>Value[i];

public static A108577Inst Instance=new A108577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108578
{
public static readonly long[] Value={ 0L,0L,0L,0L,8L,24L,32L,56L,80L,104L,136L,176L,208L,256L,304L,352L,408L,472L,528L,600L,672L,744L,824L,912L,992L,1088L,1184L,1280L,1384L,1496L,1600L,1720L,1840L,1960L,2088L,2224L,2352L,2496L,2640L,2784L,2936L,3096L,3248L,3416L,3584L,3752L,3928L,4112L,4288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108578Inst : IEnumerable<long>
{
public static readonly long[] Value=A108578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108578.Bytes);
public long this[int i]=>Value[i];

public static A108578Inst Instance=new A108578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108579
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,4L,7L,10L,13L,17L,22L,26L,32L,38L,44L,51L,59L,66L,75L,84L,93L,103L,114L,124L,136L,148L,160L,173L,187L,200L,215L,230L,245L,261L,278L,294L,312L,330L,348L,367L,387L,406L,427L,448L,469L,491L,514L,536L,560L,584L,608L,633L,659L,684L,711L,738L,765L,793L,822L,850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108579Inst : IEnumerable<long>
{
public static readonly long[] Value=A108579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108579.Bytes);
public long this[int i]=>Value[i];

public static A108579Inst Instance=new A108579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108580
{
public static readonly long[] Value={ 10L,11L,30L,31L,100L,101L,102L,103L,110L,111L,120L,121L,200L,201L,210L,211L,220L,221L,300L,301L,310L,311L,500L,501L,510L,511L,1000L,1001L,1002L,1003L,1004L,1005L,1006L,1007L,1010L,1012L,1013L,1014L,1015L,1020L,1021L,1022L,1023L,1100L,1101L,1102L,1103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108580Inst : IEnumerable<long>
{
public static readonly long[] Value=A108580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108580.Bytes);
public long this[int i]=>Value[i];

public static A108580Inst Instance=new A108580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108581
{
public static readonly long[] Value={ 1L,3L,3L,3L,6L,6L,6L,6L,6L,6L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108581Inst : IEnumerable<long>
{
public static readonly long[] Value=A108581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108581.Bytes);
public long this[int i]=>Value[i];

public static A108581Inst Instance=new A108581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108582
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108582Inst : IEnumerable<long>
{
public static readonly long[] Value=A108582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108582.Bytes);
public long this[int i]=>Value[i];

public static A108582Inst Instance=new A108582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108583
{
public static readonly long[] Value={ 3L,13L,2593L,2426113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108583Inst : IEnumerable<long>
{
public static readonly long[] Value=A108583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108583.Bytes);
public long this[int i]=>Value[i];

public static A108583Inst Instance=new A108583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108584
{
public static readonly long[] Value={ 10L,11L,12L,14L,15L,17L,18L,20L,21L,26L,27L,29L,32L,33L,36L,38L,39L,41L,45L,47L,48L,53L,54L,56L,60L,62L,66L,69L,71L,74L,75L,77L,78L,83L,84L,87L,92L,95L,96L,98L,105L,108L,111L,113L,116L,119L,120L,122L,125L,126L,129L,131L,132L,138L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108584Inst : IEnumerable<long>
{
public static readonly long[] Value=A108584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108584.Bytes);
public long this[int i]=>Value[i];

public static A108584Inst Instance=new A108584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108585
{
public static readonly long[] Value={ 2L,6L,12L,18L,26L,36L,46L,58L,70L,82L,98L,114L,130L,150L,168L,188L,210L,232L,256L,280L,304L,328L,360L,388L,416L,448L,480L,512L,544L,584L,618L,652L,692L,734L,772L,812L,856L,898L,942L,988L,1034L,1082L,1130L,1178L,1226L,1274L,1338L,1386L,1436L,1496L,1552L,1604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108585Inst : IEnumerable<long>
{
public static readonly long[] Value=A108585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108585.Bytes);
public long this[int i]=>Value[i];

public static A108585Inst Instance=new A108585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108586
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108586Inst : IEnumerable<long>
{
public static readonly long[] Value=A108586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108586.Bytes);
public long this[int i]=>Value[i];

public static A108586Inst Instance=new A108586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108587
{
public static readonly long[] Value={ 6L,12L,18L,25L,31L,37L,44L,50L,56L,63L,69L,75L,82L,88L,94L,100L,107L,113L,119L,126L,132L,138L,145L,151L,157L,164L,170L,176L,182L,189L,195L,201L,208L,214L,220L,227L,233L,239L,246L,252L,258L,264L,271L,277L,283L,290L,296L,302L,309L,315L,321L,328L,334L,340L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108587Inst : IEnumerable<long>
{
public static readonly long[] Value=A108587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108587.Bytes);
public long this[int i]=>Value[i];

public static A108587Inst Instance=new A108587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108588
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,10L,13L,16L,18L,21L,22L,24L,25L,27L,30L,36L,37L,39L,45L,46L,48L,49L,51L,52L,55L,58L,63L,66L,69L,70L,73L,76L,78L,79L,81L,84L,85L,87L,88L,90L,99L,100L,102L,109L,112L,114L,118L,120L,121L,123L,127L,133L,135L,139L,147L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108588Inst : IEnumerable<long>
{
public static readonly long[] Value=A108588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108588.Bytes);
public long this[int i]=>Value[i];

public static A108588Inst Instance=new A108588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108589
{
public static readonly long[] Value={ 2L,5L,8L,11L,13L,16L,19L,22L,24L,27L,30L,33L,35L,38L,41L,44L,46L,49L,52L,55L,57L,60L,63L,66L,68L,71L,74L,77L,79L,82L,85L,88L,90L,93L,96L,99L,101L,104L,107L,110L,112L,115L,118L,121L,123L,126L,129L,132L,134L,137L,140L,143L,145L,148L,151L,154L,156L,159L,162L,165L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108589Inst : IEnumerable<long>
{
public static readonly long[] Value=A108589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108589.Bytes);
public long this[int i]=>Value[i];

public static A108589Inst Instance=new A108589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108590
{
public static readonly long[] Value={ 2L,1L,5L,8L,3L,11L,13L,4L,16L,19L,6L,22L,7L,24L,27L,9L,30L,33L,10L,35L,38L,12L,41L,14L,44L,46L,15L,49L,52L,17L,55L,57L,18L,60L,20L,63L,66L,21L,68L,71L,23L,74L,77L,25L,79L,26L,82L,85L,28L,88L,90L,29L,93L,96L,31L,99L,32L,101L,104L,34L,107L,110L,36L,112L,115L,37L,118L,39L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108590Inst : IEnumerable<long>
{
public static readonly long[] Value=A108590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108590.Bytes);
public long this[int i]=>Value[i];

public static A108590Inst Instance=new A108590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108591
{
public static readonly long[] Value={ 3L,6L,1L,9L,12L,2L,15L,18L,4L,21L,25L,5L,28L,31L,7L,34L,37L,8L,40L,43L,10L,47L,50L,53L,11L,56L,59L,13L,62L,65L,14L,69L,72L,16L,75L,78L,17L,81L,84L,19L,87L,91L,20L,94L,97L,100L,22L,103L,106L,23L,109L,113L,2L,4L,116L,119L,26L,122L,125L,27L,128L,131L,29L,135L,138L,30L,141L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108591Inst : IEnumerable<long>
{
public static readonly long[] Value=A108591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108591.Bytes);
public long this[int i]=>Value[i];

public static A108591Inst Instance=new A108591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108592
{
public static readonly long[] Value={ 6L,12L,18L,25L,31L,1L,37L,43L,50L,56L,62L,2L,69L,75L,81L,87L,94L,3L,100L,106L,113L,119L,125L,13L,1L,4L,138L,144L,150L,157L,163L,5L,169L,175L,182L,188L,194L,7L,201L,207L,213L,219L,226L,8L,232L,238L,24L,5L,251L,257L,263L,9L,270L,276L,282L,289L,295L,10L,301L,307L,314L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108592Inst : IEnumerable<long>
{
public static readonly long[] Value=A108592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108592.Bytes);
public long this[int i]=>Value[i];

public static A108592Inst Instance=new A108592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108593
{
public static readonly long[] Value={ 6L,12L,18L,25L,31L,1L,37L,44L,50L,56L,63L,2L,69L,75L,82L,88L,94L,3L,100L,107L,113L,119L,126L,132L,4L,138L,145L,151L,157L,164L,5L,170L,176L,182L,189L,195L,7L,201L,208L,214L,220L,227L,233L,8L,239L,246L,252L,258L,264L,9L,271L,277L,283L,290L,296L,10L,302L,309L,315L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108593Inst : IEnumerable<long>
{
public static readonly long[] Value=A108593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108593.Bytes);
public long this[int i]=>Value[i];

public static A108593Inst Instance=new A108593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108594
{
public static readonly long[] Value={ 0L,3L,5L,8L,9L,11L,14L,15L,17L,18L,21L,23L,30L,32L,33L,36L,39L,42L,44L,47L,50L,53L,54L,56L,59L,60L,65L,66L,71L,72L,78L,81L,84L,87L,89L,92L,93L,95L,96L,99L,105L,107L,108L,110L,113L,119L,120L,122L,126L,128L,135L,137L,138L,141L,143L,147L,150L,152L,162L,164L,170L,171L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108594Inst : IEnumerable<long>
{
public static readonly long[] Value=A108594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108594.Bytes);
public long this[int i]=>Value[i];

public static A108594Inst Instance=new A108594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108595
{
public static readonly long[] Value={ 0L,1L,6L,7L,9L,12L,13L,16L,18L,19L,21L,25L,27L,28L,33L,34L,36L,40L,42L,46L,49L,51L,54L,55L,57L,58L,63L,64L,67L,72L,75L,76L,78L,85L,88L,91L,93L,96L,99L,100L,102L,105L,106L,109L,111L,112L,118L,120L,127L,132L,133L,135L,138L,139L,142L,144L,145L,148L,151L,156L,159L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108595Inst : IEnumerable<long>
{
public static readonly long[] Value=A108595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108595.Bytes);
public long this[int i]=>Value[i];

public static A108595Inst Instance=new A108595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108596
{
public static readonly long[] Value={ 4L,10L,36L,40L,48L,94L,120L,130L,138L,160L,174L,180L,198L,216L,226L,250L,268L,270L,274L,276L,286L,298L,328L,330L,346L,348L,360L,366L,396L,400L,414L,450L,454L,456L,460L,466L,474L,478L,480L,498L,510L,528L,538L,550L,558L,580L,598L,606L,648L,676L,678L,688L,690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108596Inst : IEnumerable<long>
{
public static readonly long[] Value=A108596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108596.Bytes);
public long this[int i]=>Value[i];

public static A108596Inst Instance=new A108596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108597
{
public static readonly long[] Value={ 2L,14L,38L,48L,72L,80L,108L,114L,138L,140L,152L,162L,164L,192L,204L,210L,222L,230L,240L,252L,272L,278L,290L,300L,314L,320L,324L,342L,344L,378L,380L,384L,402L,428L,432L,458L,474L,488L,498L,500L,530L,552L,554L,558L,612L,614L,618L,624L,650L,672L,678L,698L,702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108597Inst : IEnumerable<long>
{
public static readonly long[] Value=A108597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108597.Bytes);
public long this[int i]=>Value[i];

public static A108597Inst Instance=new A108597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108598
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,12L,14L,16L,18L,19L,21L,23L,25L,27L,28L,30L,32L,34L,36L,37L,39L,41L,43L,45L,47L,48L,50L,52L,54L,56L,57L,59L,61L,63L,65L,66L,68L,70L,72L,74L,75L,77L,79L,81L,83L,85L,86L,88L,90L,92L,94L,95L,97L,99L,101L,103L,104L,106L,108L,110L,112L,113L,115L,117L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108598Inst : IEnumerable<long>
{
public static readonly long[] Value=A108598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108598.Bytes);
public long this[int i]=>Value[i];

public static A108598Inst Instance=new A108598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108599
{
public static readonly long[] Value={ 2L,1L,5L,8L,3L,10L,13L,4L,16L,6L,19L,21L,7L,24L,27L,9L,29L,32L,11L,35L,12L,38L,40L,14L,43L,46L,15L,48L,17L,51L,54L,18L,57L,59L,20L,62L,65L,22L,67L,23L,70L,73L,25L,76L,78L,26L,81L,28L,84L,86L,30L,89L,92L,31L,95L,97L,33L,100L,34L,103L,106L,36L,108L,111L,37L,114L,39L,116L,119L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108599Inst : IEnumerable<long>
{
public static readonly long[] Value=A108599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108599.Bytes);
public long this[int i]=>Value[i];

public static A108599Inst Instance=new A108599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108600
{
public static readonly long[] Value={ 1L,2L,6L,20L,71L,260L,971L,3674L,14032L,53968L,208692L,810492L,3158760L,12346628L,48377494L,189952216L,747180999L,2943648824L,11612917815L,45869337526L,181372345723L,717856746216L,2843678131629L,11273602645942L,44725291921541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108600Inst : IEnumerable<long>
{
public static readonly long[] Value=A108600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108600.Bytes);
public long this[int i]=>Value[i];

public static A108600Inst Instance=new A108600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108601
{
public static readonly long[] Value={ 132L,136L,142L,144L,150L,154L,156L,162L,166L,172L,174L,180L,190L,192L,196L,202L,214L,216L,222L,234L,240L,244L,246L,250L,252L,256L,264L,276L,280L,282L,286L,304L,306L,310L,316L,330L,334L,342L,346L,352L,354L,360L,364L,372L,376L,384L,394L,396L,400L,406L,412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108601Inst : IEnumerable<long>
{
public static readonly long[] Value=A108601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108601.Bytes);
public long this[int i]=>Value[i];

public static A108601Inst Instance=new A108601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108602
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,7L,7L,8L,8L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,8L,9L,8L,9L,8L,9L,9L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108602Inst : IEnumerable<long>
{
public static readonly long[] Value=A108602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108602.Bytes);
public long this[int i]=>Value[i];

public static A108602Inst Instance=new A108602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108603
{
public static readonly long[] Value={ 10L,720L,1440L,17280L,34560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108603Inst : IEnumerable<long>
{
public static readonly long[] Value=A108603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108603.Bytes);
public long this[int i]=>Value[i];

public static A108603Inst Instance=new A108603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108604
{
public static readonly long[] Value={ 25L,49L,169L,361L,961L,1849L,3721L,5329L,10609L,11881L,19321L,22801L,32761L,37249L,39601L,52441L,58081L,73441L,80089L,97969L,121801L,177241L,187489L,214369L,273529L,326041L,361201L,383161L,413449L,436921L,657721L,677329L,687241L,737881L,779689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108604Inst : IEnumerable<long>
{
public static readonly long[] Value=A108604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108604.Bytes);
public long this[int i]=>Value[i];

public static A108604Inst Instance=new A108604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108605
{
public static readonly long[] Value={ 6L,10L,22L,34L,58L,82L,118L,142L,202L,214L,274L,298L,358L,382L,394L,454L,478L,538L,562L,622L,694L,838L,862L,922L,1042L,1138L,1198L,1234L,1282L,1318L,1618L,1642L,1654L,1714L,1762L,2038L,2062L,2098L,2122L,2182L,2302L,2458L,2554L,2578L,2602L,2638L,2854L,2902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108605Inst : IEnumerable<long>
{
public static readonly long[] Value=A108605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108605.Bytes);
public long this[int i]=>Value[i];

public static A108605Inst Instance=new A108605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108606
{
public static readonly long[] Value={ 14L,21L,25L,34L,38L,49L,58L,65L,74L,85L,94L,106L,111L,115L,119L,122L,133L,142L,146L,155L,166L,201L,203L,205L,209L,214L,218L,221L,247L,254L,265L,274L,278L,287L,289L,298L,302L,319L,326L,335L,346L,355L,362L,371L,377L,382L,386L,391L,395L,403L,407L,427L,445L,454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108606Inst : IEnumerable<long>
{
public static readonly long[] Value=A108606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108606.Bytes);
public long this[int i]=>Value[i];

public static A108606Inst Instance=new A108606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108607
{
public static readonly long[] Value={ 40L,54L,56L,88L,90L,104L,136L,184L,198L,210L,248L,250L,294L,296L,328L,350L,376L,390L,414L,424L,462L,488L,522L,536L,550L,570L,584L,664L,686L,714L,776L,798L,808L,824L,850L,856L,858L,930L,950L,954L,1014L,1048L,1062L,1110L,1190L,1208L,1210L,1218L,1256L,1274L,1278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108607Inst : IEnumerable<long>
{
public static readonly long[] Value=A108607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108607.Bytes);
public long this[int i]=>Value[i];

public static A108607Inst Instance=new A108607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108608
{
public static readonly long[] Value={ 48L,80L,108L,176L,252L,300L,368L,405L,420L,464L,468L,500L,567L,660L,675L,684L,848L,891L,944L,980L,1020L,1116L,1136L,1140L,1323L,1332L,1377L,1424L,1428L,1452L,1539L,1548L,1575L,1616L,1700L,1716L,1740L,1820L,1860L,1875L,1932L,2096L,2156L,2196L,2295L,2300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108608Inst : IEnumerable<long>
{
public static readonly long[] Value=A108608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108608.Bytes);
public long this[int i]=>Value[i];

public static A108608Inst Instance=new A108608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108609
{
public static readonly long[] Value={ 96L,224L,360L,416L,486L,504L,600L,608L,792L,810L,992L,1176L,1184L,1224L,1368L,1376L,1400L,1890L,1952L,2040L,2088L,2184L,2232L,2250L,2336L,2528L,2600L,2754L,2760L,2904L,2952L,3080L,3104L,3296L,3384L,3480L,3510L,3640L,3726L,4064L,4158L,4248L,4312L,4392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108609Inst : IEnumerable<long>
{
public static readonly long[] Value=A108609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108609.Bytes);
public long this[int i]=>Value[i];

public static A108609Inst Instance=new A108609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108610
{
public static readonly long[] Value={ 34L,58L,142L,214L,274L,298L,382L,454L,478L,562L,694L,838L,922L,1042L,1138L,1198L,1282L,1318L,1642L,1714L,2038L,2098L,2122L,2182L,2302L,2458L,2638L,2854L,2902L,2962L,3334L,3394L,3442L,3574L,3754L,3862L,4054L,4162L,4258L,4474L,4618L,4762L,5314L,5374L,5422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108610Inst : IEnumerable<long>
{
public static readonly long[] Value=A108610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108610.Bytes);
public long this[int i]=>Value[i];

public static A108610Inst Instance=new A108610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108611
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108611Inst : IEnumerable<long>
{
public static readonly long[] Value=A108611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108611.Bytes);
public long this[int i]=>Value[i];

public static A108611Inst Instance=new A108611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108612
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,42L,56L,72L,90L,110L,143L,168L,195L,224L,255L,304L,340L,378L,418L,460L,504L,572L,621L,672L,725L,780L,864L,924L,986L,1050L,1116L,1216L,1287L,1360L,1435L,1512L,1591L,1710L,1794L,1880L,1968L,2058L,2193L,2288L,2385L,2484L,2585L,2736L,2842L,2950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108612Inst : IEnumerable<long>
{
public static readonly long[] Value=A108612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108612.Bytes);
public long this[int i]=>Value[i];

public static A108612Inst Instance=new A108612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108613
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,6L,7L,8L,9L,10L,22L,24L,26L,28L,30L,48L,51L,54L,57L,60L,63L,88L,92L,96L,100L,104L,135L,140L,145L,150L,155L,192L,198L,204L,210L,216L,222L,266L,273L,280L,287L,294L,344L,352L,360L,368L,376L,432L,441L,450L,459L,468L,477L,540L,550L,560L,570L,580L,649L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108613Inst : IEnumerable<long>
{
public static readonly long[] Value=A108613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108613.Bytes);
public long this[int i]=>Value[i];

public static A108613Inst Instance=new A108613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108614
{
public static readonly long[] Value={ 10L,15L,21L,22L,25L,33L,35L,38L,51L,55L,57L,58L,77L,82L,85L,87L,111L,115L,118L,121L,122L,123L,133L,155L,158L,177L,178L,183L,185L,187L,201L,202L,203L,205L,213L,215L,217L,218L,221L,235L,237L,253L,278L,287L,301L,302L,303L,305L,321L,323L,327L,335L,355L,358L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108614Inst : IEnumerable<long>
{
public static readonly long[] Value=A108614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108614.Bytes);
public long this[int i]=>Value[i];

public static A108614Inst Instance=new A108614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108615
{
public static readonly long[] Value={ 4L,7L,8L,8L,9L,12L,7L,11L,13L,6L,17L,18L,11L,13L,17L,10L,15L,18L,9L,19L,21L,14L,17L,22L,13L,19L,23L,17L,21L,27L,16L,23L,28L,8L,31L,32L,11L,29L,31L,15L,26L,30L,20L,25L,32L,14L,31L,34L,19L,27L,33L,17L,34L,38L,23L,29L,37L,22L,31L,38L,13L,41L,43L,16L,41L,44L,26L,33L,42L,25L,35L,43L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108615Inst : IEnumerable<long>
{
public static readonly long[] Value=A108615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108615.Bytes);
public long this[int i]=>Value[i];

public static A108615Inst Instance=new A108615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108616
{
public static readonly long[] Value={ 4L,8L,9L,6L,18L,19L,8L,32L,33L,18L,30L,35L,10L,50L,51L,22L,46L,51L,34L,38L,51L,12L,72L,73L,28L,76L,81L,44L,68L,81L,14L,98L,99L,32L,100L,105L,68L,80L,105L,16L,128L,129L,64L,112L,129L,38L,142L,147L,60L,132L,145L,18L,162L,163L,82L,122L,147L,72L,144L,161L,42L,174L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108616Inst : IEnumerable<long>
{
public static readonly long[] Value=A108616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108616.Bytes);
public long this[int i]=>Value[i];

public static A108616Inst Instance=new A108616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108617
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,3L,3L,2L,3L,5L,6L,5L,3L,5L,8L,11L,11L,8L,5L,8L,13L,19L,22L,19L,13L,8L,13L,21L,32L,41L,41L,32L,21L,13L,21L,34L,53L,73L,82L,73L,53L,34L,21L,34L,55L,87L,126L,155L,155L,126L,87L,55L,34L,55L,89L,142L,213L,281L,310L,281L,213L,142L,89L,55L,89L,144L,231L,355L,494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108617Inst : IEnumerable<long>
{
public static readonly long[] Value=A108617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108617.Bytes);
public long this[int i]=>Value[i];

public static A108617Inst Instance=new A108617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108618
{
public static readonly long[] Value={ 1L,2L,-1L,-2L,-3L,-6L,-6L,1L,4L,3L,0L,-5L,-10L,-8L,3L,8L,5L,-2L,-9L,-12L,-6L,7L,16L,10L,-9L,-18L,-11L,4L,15L,14L,-2L,-16L,-20L,-3L,14L,17L,6L,-12L,-24L,-11L,10L,21L,14L,-8L,-22L,-20L,3L,20L,17L,-2L,-21L,-24L,-6L,19L,28L,10L,-21L,-36L,-18L,19L,40L,22L,-21L,-42L,-23L,16L,39L,26L,-14L,-40L,-32L,9L,38L,29L,-8L,-39L,-36L,2L,36L,38L,-1L,-38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108618Inst : IEnumerable<long>
{
public static readonly long[] Value=A108618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108618.Bytes);
public long this[int i]=>Value[i];

public static A108618Inst Instance=new A108618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108619
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,0L,-2L,-3L,0L,3L,4L,3L,0L,-4L,-5L,0L,5L,6L,3L,-2L,-6L,-5L,2L,10L,11L,2L,-7L,-8L,-1L,8L,12L,6L,-4L,-11L,-6L,5L,12L,10L,0L,-11L,-10L,1L,12L,14L,4L,-8L,-13L,-4L,9L,14L,7L,-6L,-14L,-9L,6L,18L,15L,-2L,-18L,-17L,2L,22L,23L,2L,-19L,-20L,-1L,20L,24L,6L,-16L,-23L,-6L,17L,24L,9L,-14L,-24L,-10L,14L,27L,14L,-11L,-24L,-14L,10L,27L,18L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108619Inst : IEnumerable<long>
{
public static readonly long[] Value=A108619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108619.Bytes);
public long this[int i]=>Value[i];

public static A108619Inst Instance=new A108619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108620
{
public static readonly long[] Value={ 2L,4L,4L,2L,0L,-3L,-6L,-4L,2L,6L,6L,2L,-5L,-10L,-6L,4L,10L,8L,0L,-9L,-12L,-4L,11L,20L,12L,-6L,-16L,-10L,6L,19L,17L,1L,-16L,-18L,-2L,16L,21L,9L,-12L,-22L,-10L,12L,25L,17L,-5L,-22L,-18L,4L,22L,20L,0L,-21L,-24L,-4L,23L,32L,12L,-21L,-36L,-16L,23L,44L,24L,-18L,-40L,-22L,18L,43L,29L,-11L,-40L,-30L,10L,40L,32L,-6L,-39L,-35L,3L,40L,40L,2L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108620Inst : IEnumerable<long>
{
public static readonly long[] Value=A108620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108620.Bytes);
public long this[int i]=>Value[i];

public static A108620Inst Instance=new A108620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108621
{
public static readonly long[] Value={ 3L,1L,4L,9L,2L,6L,5L,8L,9L,7L,9L,3L,4L,6L,2L,3L,3L,5L,0L,1L,9L,6L,9L,3L,9L,9L,3L,1L,5L,9L,7L,4L,4L,5L,2L,3L,7L,0L,6L,2L,0L,8L,6L,8L,0L,4L,8L,2L,4L,2L,0L,2L,1L,4L,8L,6L,5L,1L,2L,2L,3L,7L,9L,3L,4L,4L,6L,9L,5L,5L,2L,3L,1L,3L,8L,1L,2L,8L,1L,1L,5L,2L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108621Inst : IEnumerable<long>
{
public static readonly long[] Value=A108621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108621.Bytes);
public long this[int i]=>Value[i];

public static A108621Inst Instance=new A108621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108622
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108622Inst : IEnumerable<long>
{
public static readonly long[] Value=A108622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108622.Bytes);
public long this[int i]=>Value[i];

public static A108622Inst Instance=new A108622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108623
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,1L,4L,3L,-8L,-23L,-10L,67L,153L,9L,-586L,-1081L,439L,5249L,7734L,-7941L,-47501L,-53791L,105314L,430119L,343044L,-1249799L,-3866556L,-1730017L,13996097L,34243897L,1947204L,-150962373L,-296101864L,121857185L,1582561870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108623Inst : IEnumerable<long>
{
public static readonly long[] Value=A108623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108623.Bytes);
public long this[int i]=>Value[i];

public static A108623Inst Instance=new A108623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108624
{
public static readonly long[] Value={ 1L,0L,-1L,1L,1L,-4L,3L,8L,-23L,10L,67L,-153L,9L,586L,-1081L,-439L,5249L,-7734L,-7941L,47501L,-53791L,-105314L,430119L,-343044L,-1249799L,3866556L,-1730017L,-13996097L,34243897L,-1947204L,-150962373L,296101864L,121857185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108624Inst : IEnumerable<long>
{
public static readonly long[] Value=A108624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108624.Bytes);
public long this[int i]=>Value[i];

public static A108624Inst Instance=new A108624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108625
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,5L,1L,1L,13L,19L,7L,1L,1L,21L,55L,37L,9L,1L,1L,31L,131L,147L,61L,11L,1L,1L,43L,271L,471L,309L,91L,13L,1L,1L,57L,505L,1281L,1251L,561L,127L,15L,1L,1L,73L,869L,3067L,4251L,2751L,923L,169L,17L,1L,1L,91L,1405L,6637L,12559L,11253L,5321L,1415L,217L,19L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108625Inst : IEnumerable<long>
{
public static readonly long[] Value=A108625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108625.Bytes);
public long this[int i]=>Value[i];

public static A108625Inst Instance=new A108625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108626
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,124L,383L,1200L,3799L,12122L,38919L,125578L,406865L,1322772L,4313155L,14099524L,46192483L,151628090L,498578411L,1641921014L,5414619739L,17878144968L,59097039545L,195548471268L,647665451911L,2146947613286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108626Inst : IEnumerable<long>
{
public static readonly long[] Value=A108626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108626.Bytes);
public long this[int i]=>Value[i];

public static A108626Inst Instance=new A108626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108627
{
public static readonly long[] Value={ 2L,6L,20L,66L,222L,750L,2536L,8578L,29018L,98166L,332092L,1123458L,3800630L,12857438L,43496400L,147147266L,497795634L,1684030566L,5697034596L,19272929986L,65199855118L,220569529934L,746181374904L,2524313509762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108627Inst : IEnumerable<long>
{
public static readonly long[] Value=A108627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108627.Bytes);
public long this[int i]=>Value[i];

public static A108627Inst Instance=new A108627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108628
{
public static readonly long[] Value={ 1L,7L,55L,471L,4251L,39733L,380731L,3716695L,36808723L,368750757L,3728940249L,38003358693L,389866749975L,4022124746409L,41697566691555L,434124925278807L,4536783726146499L,47569453938399445L,500266519237489357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108628Inst : IEnumerable<long>
{
public static readonly long[] Value=A108628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108628.Bytes);
public long this[int i]=>Value[i];

public static A108628Inst Instance=new A108628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108629
{
public static readonly long[] Value={ 1L,0L,1L,2L,4L,11L,28L,75L,207L,579L,1647L,4744L,13807L,40550L,120016L,357613L,1071916L,3229870L,9777767L,29724593L,90705886L,277744244L,853123473L,2627968236L,8116487286L,25128482223L,77971354506L,242439732171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108629Inst : IEnumerable<long>
{
public static readonly long[] Value=A108629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108629.Bytes);
public long this[int i]=>Value[i];

public static A108629Inst Instance=new A108629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108630
{
public static readonly long[] Value={ 1L,1L,2L,6L,17L,54L,178L,606L,2116L,7533L,27242L,99799L,369583L,1381309L,5203599L,19737935L,75321337L,288968031L,1113893815L,4312073256L,16756934181L,65345024968L,255625711296L,1002888257745L,3945055462020L,15556613282788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108630Inst : IEnumerable<long>
{
public static readonly long[] Value=A108630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108630.Bytes);
public long this[int i]=>Value[i];

public static A108630Inst Instance=new A108630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108631
{
public static readonly long[] Value={ 4L,6L,9L,10L,14L,46L,49L,69L,86L,91L,94L,106L,111L,118L,119L,141L,146L,161L,166L,169L,194L,411L,446L,466L,469L,481L,489L,611L,614L,649L,669L,681L,689L,694L,698L,699L,818L,841L,849L,866L,869L,886L,889L,898L,899L,901L,914L,949L,961L,989L,998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108631Inst : IEnumerable<long>
{
public static readonly long[] Value=A108631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108631.Bytes);
public long this[int i]=>Value[i];

public static A108631Inst Instance=new A108631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108632
{
public static readonly long[] Value={ 22L,25L,33L,35L,55L,57L,77L,235L,237L,253L,323L,327L,335L,355L,377L,527L,533L,535L,537L,553L,573L,723L,737L,753L,755L,2227L,2253L,2257L,2323L,2327L,2335L,2353L,2533L,2537L,2573L,2577L,2722L,2723L,2733L,2735L,2757L,2773L,3223L,3227L,3233L,3235L,3273L,3277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108632Inst : IEnumerable<long>
{
public static readonly long[] Value=A108632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108632.Bytes);
public long this[int i]=>Value[i];

public static A108632Inst Instance=new A108632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108633
{
public static readonly long[] Value={ 14L,21L,26L,33L,38L,46L,57L,62L,69L,74L,85L,93L,94L,106L,129L,133L,134L,145L,166L,177L,178L,205L,213L,217L,218L,226L,237L,249L,253L,254L,262L,265L,278L,309L,314L,334L,362L,393L,398L,417L,422L,445L,466L,469L,489L,493L,502L,505L,514L,517L,526L,553L,565L,573L,586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108633Inst : IEnumerable<long>
{
public static readonly long[] Value=A108633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108633.Bytes);
public long this[int i]=>Value[i];

public static A108633Inst Instance=new A108633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108634
{
public static readonly long[] Value={ 4L,6L,9L,14L,15L,22L,25L,26L,33L,34L,35L,38L,39L,46L,49L,55L,57L,58L,69L,77L,111L,115L,118L,119L,122L,123L,129L,133L,134L,145L,146L,155L,158L,159L,166L,169L,177L,178L,226L,235L,237L,247L,249L,259L,267L,278L,289L,299L,334L,335L,339L,346L,355L,358L,377L,445L,446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108634Inst : IEnumerable<long>
{
public static readonly long[] Value=A108634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108634.Bytes);
public long this[int i]=>Value[i];

public static A108634Inst Instance=new A108634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108635
{
public static readonly long[] Value={ 4L,6L,9L,10L,21L,22L,33L,51L,55L,62L,65L,74L,77L,82L,85L,86L,87L,91L,93L,94L,95L,111L,221L,321L,411L,422L,511L,533L,542L,543L,551L,553L,554L,611L,622L,633L,655L,662L,721L,731L,753L,755L,763L,766L,771L,831L,841L,842L,843L,851L,862L,865L,866L,871L,886L,921L,922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108635Inst : IEnumerable<long>
{
public static readonly long[] Value=A108635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108635.Bytes);
public long this[int i]=>Value[i];

public static A108635Inst Instance=new A108635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108636
{
public static readonly long[] Value={ 4L,6L,22L,26L,46L,62L,82L,86L,202L,206L,226L,262L,422L,446L,466L,482L,622L,626L,662L,802L,842L,862L,866L,886L,2026L,2042L,2062L,2066L,2206L,2246L,2402L,2426L,2446L,2462L,2602L,2606L,2642L,2846L,2866L,4006L,4022L,4222L,4226L,4262L,4282L,4286L,4406L,4426L,4442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108636Inst : IEnumerable<long>
{
public static readonly long[] Value=A108636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108636.Bytes);
public long this[int i]=>Value[i];

public static A108636Inst Instance=new A108636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108637
{
public static readonly long[] Value={ 9L,15L,33L,35L,39L,51L,55L,57L,77L,91L,93L,95L,111L,115L,119L,133L,155L,159L,177L,319L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108637Inst : IEnumerable<long>
{
public static readonly long[] Value=A108637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108637.Bytes);
public long this[int i]=>Value[i];

public static A108637Inst Instance=new A108637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108638
{
public static readonly long[] Value={ 15L,22L,26L,33L,38L,39L,49L,51L,55L,57L,74L,77L,115L,123L,129L,134L,145L,155L,161L,169L,178L,187L,202L,206L,213L,214L,221L,237L,254L,265L,274L,278L,291L,299L,301L,303L,309L,321L,327L,335L,361L,371L,377L,381L,382L,386L,411L,437L,445L,466L,478L,485L,497L,505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108638Inst : IEnumerable<long>
{
public static readonly long[] Value=A108638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108638.Bytes);
public long this[int i]=>Value[i];

public static A108638Inst Instance=new A108638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108639
{
public static readonly long[] Value={ 1L,3L,6L,13L,29L,77L,229L,771L,2863L,11573L,50365L,234161L,1156039L,6031751L,33130187L,190929778L,1151198268L,7243777234L,47462906927L,323188163753L,2282922216819L,16701529748621L,126359471558613L,987316752551419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108639Inst : IEnumerable<long>
{
public static readonly long[] Value=A108639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108639.Bytes);
public long this[int i]=>Value[i];

public static A108639Inst Instance=new A108639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108640
{
public static readonly BigInteger[] Value={ 1L,2L,6L,60L,1260L,239904L,123263712L,872883648000L,35330106763980000L,BigInteger.Parse("15502816844111220549120"),BigInteger.Parse("32196148399600498119169883520"),BigInteger.Parse("2560463149313858442381787649990400000"),BigInteger.Parse("717635502576022020068175045395317927056000000") };
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
public class A108640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108640Inst Instance=new A108640Inst();

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