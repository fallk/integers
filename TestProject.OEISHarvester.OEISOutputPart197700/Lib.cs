using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A229885
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,5L,15L,35L,70L,574L,2674L,9274L,26599L,305747L,1944033L,8995805L,33757360L,498851248L,4017418768L,23236611280L,107709888805L,1945409895065L,18965460022971L,131635127294783L,726401013530416L,15505381392117616L,177447751441161616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229885Inst : IEnumerable<long>
{
public static readonly long[] Value=A229885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229885.Bytes);
public long this[int i]=>Value[i];

public static A229885Inst Instance=new A229885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229886
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,6L,21L,56L,126L,252L,2562L,14442L,59487L,199627L,578005L,8330800L,65056960L,363823800L,1628423880L,6190034016L,115452938151L,1152005977431L,8137667253101L,45527993728141L,214265281290061L,4904624749585886L,59578069604921361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229886Inst : IEnumerable<long>
{
public static readonly long[] Value=A229886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229886.Bytes);
public long this[int i]=>Value[i];

public static A229886Inst Instance=new A229886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229887
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,7L,28L,84L,210L,462L,924L,11220L,74283L,354563L,1363571L,4482323L,13058891L,226630385L,2101302530L,13794660782L,71790720848L,314709809876L,1206605493016L,27221495651416L,324504194839891L,2711270620975411L,17790823624994551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229887Inst : IEnumerable<long>
{
public static readonly long[] Value=A229887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229887.Bytes);
public long this[int i]=>Value[i];

public static A229887Inst Instance=new A229887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230032
{
public static readonly long[] Value={ 138594L,249474L,277194L,471234L,554394L,665274L,900870L,1015554L,1081074L,1191954L,1244874L,1358274L,1385994L,1607754L,1801794L,1857234L,2189874L,2356170L,2356194L,2411634L,2439354L,2489754L,2522514L,2550234L,2633394L,2688834L,2702670L,2716554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230032Inst : IEnumerable<long>
{
public static readonly long[] Value=A230032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230032.Bytes);
public long this[int i]=>Value[i];

public static A230032Inst Instance=new A230032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230033
{
public static readonly BigInteger[] Value={ 10082L,401998L,19681538L,1034315998L,55820091938L,3044533460992L,166779871224962L,9152970837103102L,502711247500143362L,BigInteger.Parse("27619744381029252622"),BigInteger.Parse("1517688682641434229698"),BigInteger.Parse("83401213534557960429502"),BigInteger.Parse("4583249488240161816039552"),BigInteger.Parse("251871805990373105011941118"),BigInteger.Parse("13841645914590329223808310018"),BigInteger.Parse("760670944425011837491619633038") };
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
public class A230033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230033Inst Instance=new A230033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230034
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,51L,52L,54L,56L,57L,58L,60L,62L,63L,64L,66L,68L,70L,72L,74L,75L,76L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230034Inst : IEnumerable<long>
{
public static readonly long[] Value=A230034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230034.Bytes);
public long this[int i]=>Value[i];

public static A230034Inst Instance=new A230034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230035
{
public static readonly long[] Value={ 31L,37L,41L,43L,47L,49L,53L,55L,59L,61L,65L,67L,69L,71L,73L,77L,79L,83L,85L,86L,87L,89L,91L,92L,93L,95L,97L,99L,101L,103L,106L,107L,109L,111L,113L,115L,116L,117L,118L,119L,121L,122L,123L,125L,127L,128L,129L,131L,133L,134L,135L,136L,137L,139L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230035Inst : IEnumerable<long>
{
public static readonly long[] Value=A230035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230035.Bytes);
public long this[int i]=>Value[i];

public static A230035Inst Instance=new A230035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230036
{
public static readonly long[] Value={ 3L,13L,149L,15377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230036Inst : IEnumerable<long>
{
public static readonly long[] Value=A230036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230036.Bytes);
public long this[int i]=>Value[i];

public static A230036Inst Instance=new A230036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230037
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,3L,3L,2L,2L,2L,2L,4L,3L,2L,3L,2L,5L,2L,4L,3L,4L,4L,4L,3L,3L,4L,5L,7L,4L,5L,2L,5L,4L,5L,7L,5L,5L,4L,4L,4L,6L,6L,8L,4L,5L,3L,4L,5L,6L,7L,4L,6L,2L,5L,3L,7L,8L,4L,4L,1L,4L,2L,7L,6L,3L,5L,3L,5L,4L,6L,6L,5L,4L,3L,5L,4L,5L,3L,3L,3L,6L,7L,5L,2L,4L,4L,5L,3L,6L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230037Inst : IEnumerable<long>
{
public static readonly long[] Value=A230037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230037.Bytes);
public long this[int i]=>Value[i];

public static A230037Inst Instance=new A230037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230038
{
public static readonly long[] Value={ 0L,2L,1L,5L,3L,0L,6L,2L,10L,5L,15L,9L,2L,14L,6L,20L,11L,1L,17L,6L,24L,12L,32L,19L,5L,27L,12L,36L,20L,3L,29L,11L,39L,20L,0L,30L,9L,41L,19L,53L,30L,6L,42L,17L,55L,29L,2L,42L,14L,56L,27L,71L,41L,10L,56L,24L,72L,39L,5L,55L,20L,72L,36L,90L,53L,15L,71L,32L,90L,50L,9L,69L,27L,89L,46L,2L,66L,21L,87L,41L,109L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230038Inst : IEnumerable<long>
{
public static readonly long[] Value=A230038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230038.Bytes);
public long this[int i]=>Value[i];

public static A230038Inst Instance=new A230038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230039
{
public static readonly long[] Value={ 7L,13L,17L,19L,43L,47L,67L,73L,97L,127L,137L,139L,157L,167L,193L,197L,199L,223L,227L,229L,269L,277L,283L,307L,337L,349L,353L,379L,383L,397L,409L,439L,463L,467L,487L,503L,523L,547L,557L,563L,599L,607L,613L,617L,643L,647L,739L,773L,797L,827L,853L,859L,887L,929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230039Inst : IEnumerable<long>
{
public static readonly long[] Value=A230039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230039.Bytes);
public long this[int i]=>Value[i];

public static A230039Inst Instance=new A230039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230040
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,3L,1L,3L,4L,5L,2L,1L,1L,3L,4L,4L,3L,4L,6L,5L,2L,2L,6L,5L,1L,2L,4L,2L,2L,3L,6L,5L,7L,6L,2L,3L,4L,4L,2L,3L,5L,1L,4L,7L,4L,6L,3L,9L,4L,2L,5L,4L,3L,9L,2L,4L,3L,6L,3L,5L,8L,8L,5L,8L,6L,2L,4L,3L,4L,1L,6L,4L,3L,8L,8L,6L,6L,9L,11L,2L,4L,2L,8L,3L,4L,6L,10L,5L,11L,7L,8L,6L,10L,4L,1L,3L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230040Inst : IEnumerable<long>
{
public static readonly long[] Value=A230040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230040.Bytes);
public long this[int i]=>Value[i];

public static A230040Inst Instance=new A230040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230041
{
public static readonly long[] Value={ 2L,3L,5L,7L,19L,29L,37L,47L,59L,79L,89L,199L,269L,359L,379L,389L,479L,499L,599L,797L,887L,997L,1889L,1999L,2689L,2699L,2789L,2999L,3889L,3989L,4789L,4799L,4889L,4999L,6899L,8999L,25999L,27799L,28789L,28979L,29989L,37799L,37889L,39799L,39989L,48799L,48889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230041Inst : IEnumerable<long>
{
public static readonly long[] Value=A230041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230041.Bytes);
public long this[int i]=>Value[i];

public static A230041Inst Instance=new A230041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230042
{
public static readonly long[] Value={ 2L,3L,5L,7L,181L,191L,353L,373L,383L,727L,757L,787L,797L,19891L,19991L,34843L,35753L,36563L,37573L,38783L,74747L,75557L,76667L,77977L,78787L,78887L,79997L,1987891L,1988891L,1998991L,3479743L,3487843L,3569653L,3586853L,3589853L,3689863L,3698963L,3799973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230042Inst : IEnumerable<long>
{
public static readonly long[] Value=A230042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230042.Bytes);
public long this[int i]=>Value[i];

public static A230042Inst Instance=new A230042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230043
{
public static readonly long[] Value={ 1L,8232L,32640L,265825L,3846879L,6517665L,14705145L,16926000L,31441920L,56471688L,146475000L,211421364L,277368000L,369022500L,662518050L,679568670L,968353620L,2166699360L,3091750900L,3755367252L,4122716598L,6536970000L,9740587500L,10066738500L,12423246290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230043Inst : IEnumerable<long>
{
public static readonly long[] Value=A230043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230043.Bytes);
public long this[int i]=>Value[i];

public static A230043Inst Instance=new A230043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230044
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,9L,10L,11L,12L,14L,15L,17L,19L,20L,21L,24L,27L,28L,29L,30L,32L,35L,36L,39L,41L,42L,44L,45L,46L,50L,51L,53L,54L,55L,56L,57L,62L,65L,66L,69L,71L,72L,74L,75L,77L,78L,80L,82L,84L,87L,89L,90L,91L,95L,96L,100L,101L,104L,105L,107L,109L,110L,111L,116L,117L,119L,120L,122L,126L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230044Inst : IEnumerable<long>
{
public static readonly long[] Value=A230044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230044.Bytes);
public long this[int i]=>Value[i];

public static A230044Inst Instance=new A230044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230045
{
public static readonly long[] Value={ 2L,3L,5L,7L,181L,191L,373L,383L,727L,757L,787L,797L,17971L,19891L,19991L,76667L,77977L,78887L,79997L,1987891L,1988891L,1998991L,3799973L,3899983L,3998993L,7897987L,7996997L,9888889L,9889889L,9989899L,199999991L,768989867L,779969977L,779999977L,798989897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230045Inst : IEnumerable<long>
{
public static readonly long[] Value=A230045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230045.Bytes);
public long this[int i]=>Value[i];

public static A230045Inst Instance=new A230045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230046
{
public static readonly long[] Value={ 2L,3L,5L,7L,151L,181L,191L,353L,373L,383L,727L,757L,787L,797L,17971L,19891L,19991L,38783L,74747L,75557L,76367L,76667L,77477L,77977L,78787L,78887L,79697L,79997L,1879781L,1895981L,1969691L,1987891L,1988891L,1998991L,3799973L,3899983L,3997993L,3998993L,7696967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230046Inst : IEnumerable<long>
{
public static readonly long[] Value=A230046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230046.Bytes);
public long this[int i]=>Value[i];

public static A230046Inst Instance=new A230046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230047
{
public static readonly long[] Value={ 2L,3L,5L,7L,181L,191L,313L,353L,373L,383L,727L,757L,787L,797L,17971L,19891L,19991L,34843L,35753L,36563L,37573L,38783L,74747L,75557L,76667L,77977L,78787L,78887L,79997L,1987891L,1988891L,1998991L,3479743L,3487843L,3569653L,3586853L,3589853L,3689863L,3698963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230047Inst : IEnumerable<long>
{
public static readonly long[] Value=A230047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230047.Bytes);
public long this[int i]=>Value[i];

public static A230047Inst Instance=new A230047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230096
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,2L,2L,6L,6L,10L,10L,22L,22L,42L,42L,86L,86L,170L,170L,342L,342L,682L,682L,1366L,1366L,2730L,2730L,5462L,5462L,10922L,10922L,21846L,21846L,43690L,43690L,87382L,87382L,174762L,174762L,349526L,349526L,699050L,699050L,1398102L,1398102L,2796202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230096Inst : IEnumerable<long>
{
public static readonly long[] Value=A230096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230096.Bytes);
public long this[int i]=>Value[i];

public static A230096Inst Instance=new A230096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230097
{
public static readonly long[] Value={ 0L,1L,3L,5L,11L,21L,39L,45L,75L,155L,181L,627L,923L,1241L,2505L,3915L,5221L,6475L,11309L,15595L,19637L,31595L,44491L,69451L,113447L,185269L,244661L,357081L,453677L,908091L,980853L,2960011L,2965685L,5931189L,11862197L,20437147L,22193965L,43586515L,57804981L,157355851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230097Inst : IEnumerable<long>
{
public static readonly long[] Value=A230097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230097.Bytes);
public long this[int i]=>Value[i];

public static A230097Inst Instance=new A230097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230098
{
public static readonly long[] Value={ -1L,1L,8L,19L,34L,77L,124L,175L,218L,249L,436L,515L,646L,825L,956L,1047L,1228L,1373L,1800L,2019L,2378L,2581L,3024L,3143L,3316L,4021L,4592L,4987L,5490L,5741L,5850L,6487L,6740L,7777L,7864L,8771L,9354L,10177L,10760L,11311L,11542L,12893L,13098L,14275L,15236L,16381L,16438L,17903L,18688L,19909L,20732L,20827L,22638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230098Inst : IEnumerable<long>
{
public static readonly long[] Value=A230098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230098.Bytes);
public long this[int i]=>Value[i];

public static A230098Inst Instance=new A230098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230099
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,20L,23L,26L,29L,32L,35L,38L,41L,44L,47L,30L,34L,38L,42L,46L,50L,54L,58L,62L,66L,40L,45L,50L,55L,60L,65L,70L,75L,80L,85L,50L,56L,62L,68L,74L,80L,86L,92L,98L,104L,60L,67L,74L,81L,88L,95L,102L,109L,116L,123L,70L,78L,86L,94L,102L,110L,118L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230099Inst : IEnumerable<long>
{
public static readonly long[] Value=A230099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230099.Bytes);
public long this[int i]=>Value[i];

public static A230099Inst Instance=new A230099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230100
{
public static readonly long[] Value={ 10000000000001L,10000000000003L,10000000000005L,10000000000007L,10000000000009L,10000000000011L,10000000000013L,10000000000015L,10000000000102L,10000000000104L,10000000000106L,10000000000108L,10000000000110L,10000000000112L,10000000000114L,10000000000116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230100Inst : IEnumerable<long>
{
public static readonly long[] Value=A230100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230100.Bytes);
public long this[int i]=>Value[i];

public static A230100Inst Instance=new A230100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230101
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,49L,64L,81L,10L,11L,24L,39L,56L,75L,96L,119L,144L,171L,40L,42L,88L,138L,192L,250L,312L,378L,448L,522L,90L,93L,192L,297L,408L,525L,648L,777L,912L,1053L,160L,164L,336L,516L,704L,900L,1104L,1316L,1536L,1764L,250L,255L,520L,795L,1080L,1375L,1680L,1995L,2320L,2655L,360L,366L,744L,1134L,1536L,1950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230101Inst : IEnumerable<long>
{
public static readonly long[] Value=A230101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230101.Bytes);
public long this[int i]=>Value[i];

public static A230101Inst Instance=new A230101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230102
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,22L,26L,38L,62L,74L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230102Inst : IEnumerable<long>
{
public static readonly long[] Value=A230102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230102.Bytes);
public long this[int i]=>Value[i];

public static A230102Inst Instance=new A230102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230103
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,1L,1L,1L,0L,2L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,2L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,3L,0L,0L,0L,1L,1L,1L,0L,1L,0L,2L,0L,2L,0L,0L,1L,1L,1L,1L,0L,2L,0L,0L,0L,2L,1L,0L,0L,1L,0L,3L,1L,0L,0L,0L,1L,2L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,2L,0L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230103Inst : IEnumerable<long>
{
public static readonly long[] Value=A230103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230103.Bytes);
public long this[int i]=>Value[i];

public static A230103Inst Instance=new A230103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230104
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,25L,27L,31L,33L,36L,37L,39L,43L,48L,49L,51L,52L,53L,57L,59L,61L,63L,64L,69L,71L,72L,73L,76L,77L,79L,82L,83L,84L,87L,91L,93L,96L,97L,99L,111L,113L,115L,117L,119L,121L,127L,131L,133L,136L,137L,139L,148L,149L,151L,153L,157L,159L,163L,164L,169L,171L,172L,173L,176L,177L,179L,182L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230104Inst : IEnumerable<long>
{
public static readonly long[] Value=A230104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230104.Bytes);
public long this[int i]=>Value[i];

public static A230104Inst Instance=new A230104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230105
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,22L,23L,24L,28L,29L,30L,32L,34L,35L,40L,41L,42L,44L,45L,46L,47L,54L,55L,56L,58L,65L,66L,67L,68L,75L,78L,81L,85L,88L,89L,90L,92L,94L,95L,101L,103L,105L,106L,108L,112L,114L,122L,124L,125L,128L,129L,132L,135L,141L,143L,144L,145L,146L,147L,152L,154L,155L,156L,158L,161L,165L,166L,167L,168L,175L,178L,181L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230105Inst : IEnumerable<long>
{
public static readonly long[] Value=A230105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230105.Bytes);
public long this[int i]=>Value[i];

public static A230105Inst Instance=new A230105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230106
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,2L,0L,2L,0L,2L,0L,2L,0L,1L,0L,2L,1L,1L,0L,2L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,2L,0L,0L,1L,1L,0L,2L,1L,1L,1L,0L,0L,2L,0L,0L,0L,1L,2L,1L,0L,1L,0L,1L,0L,2L,0L,0L,1L,2L,1L,1L,0L,1L,0L,0L,0L,2L,1L,0L,1L,1L,0L,2L,1L,0L,0L,0L,1L,2L,0L,2L,1L,0L,0L,1L,0L,1L,1L,0L,0L,2L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230106Inst : IEnumerable<long>
{
public static readonly long[] Value=A230106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230106.Bytes);
public long this[int i]=>Value[i];

public static A230106Inst Instance=new A230106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230107
{
public static readonly long[] Value={ 0L,0L,-1L,0L,52L,-1L,11L,0L,-1L,51L,50L,-1L,49L,10L,-1L,0L,48L,-1L,9L,50L,-1L,49L,0L,-1L,47L,48L,-1L,0L,8L,-1L,49L,46L,-1L,47L,48L,-1L,45L,0L,-1L,7L,46L,-1L,47L,6L,-1L,45L,44L,-1L,0L,46L,-1L,5L,5L,-1L,45L,44L,-1L,43L,4L,-1L,4L,0L,-1L,4L,44L,-1L,43L,3L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230107Inst : IEnumerable<long>
{
public static readonly long[] Value=A230107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230107.Bytes);
public long this[int i]=>Value[i];

public static A230107Inst Instance=new A230107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230108
{
public static readonly long[] Value={ 2L,3L,6L,8L,11L,12L,18L,19L,22L,24L,27L,32L,38L,43L,44L,48L,50L,51L,54L,59L,66L,67L,72L,75L,76L,83L,86L,88L,96L,98L,99L,102L,107L,108L,114L,118L,123L,128L,131L,134L,139L,146L,147L,150L,152L,162L,163L,166L,171L,172L,176L,178L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230108Inst : IEnumerable<long>
{
public static readonly long[] Value=A230108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230108.Bytes);
public long this[int i]=>Value[i];

public static A230108Inst Instance=new A230108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230109
{
public static readonly long[] Value={ 3L,7L,12L,13L,19L,21L,27L,28L,31L,39L,43L,48L,52L,57L,61L,63L,67L,73L,75L,76L,84L,91L,93L,97L,103L,108L,109L,111L,112L,117L,124L,127L,129L,133L,139L,147L,151L,156L,157L,163L,171L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230109Inst : IEnumerable<long>
{
public static readonly long[] Value=A230109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230109.Bytes);
public long this[int i]=>Value[i];

public static A230109Inst Instance=new A230109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230110
{
public static readonly long[] Value={ 8L,10L,30L,63L,64L,512L,588L,720L,800L,1320L,3960L,4096L,5184L,5760L,6400L,7200L,21600L,27720L,27900L,32768L,35280L,41472L,46080L,51200L,70840L,84672L,92400L,95040L,105600L,151200L,188160L,262144L,331776L,368640L,376320L,409600L,504000L,518400L,576000L,640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230110Inst : IEnumerable<long>
{
public static readonly long[] Value=A230110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230110.Bytes);
public long this[int i]=>Value[i];

public static A230110Inst Instance=new A230110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230111
{
public static readonly long[] Value={ 8L,10L,64L,512L,720L,800L,1320L,1944L,4096L,5184L,5760L,6400L,7200L,8370L,23520L,32768L,41472L,44000L,46080L,47040L,51200L,69580L,74088L,76096L,84672L,93000L,95040L,105600L,129360L,235200L,240000L,262144L,331776L,368640L,409600L,518400L,546480L,576000L,640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230111Inst : IEnumerable<long>
{
public static readonly long[] Value=A230111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230111.Bytes);
public long this[int i]=>Value[i];

public static A230111Inst Instance=new A230111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230160
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,7L,5L,6L,8L,4L,2L,7L,8L,7L,0L,5L,4L,7L,0L,6L,2L,9L,7L,0L,4L,0L,2L,0L,5L,7L,1L,0L,9L,2L,9L,3L,5L,6L,0L,6L,8L,5L,9L,2L,7L,1L,8L,5L,5L,2L,8L,3L,6L,8L,1L,4L,8L,5L,7L,0L,1L,6L,2L,8L,0L,0L,7L,1L,6L,6L,3L,3L,2L,5L,7L,9L,5L,2L,8L,4L,4L,3L,4L,5L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230160Inst : IEnumerable<long>
{
public static readonly long[] Value=A230160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230160.Bytes);
public long this[int i]=>Value[i];

public static A230160Inst Instance=new A230160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230161
{
public static readonly long[] Value={ 1L,0L,9L,6L,9L,8L,1L,5L,5L,7L,7L,9L,8L,5L,5L,9L,8L,1L,7L,9L,0L,8L,2L,7L,8L,9L,6L,7L,1L,6L,7L,5L,3L,7L,0L,8L,9L,5L,9L,2L,5L,3L,0L,1L,0L,8L,2L,1L,2L,7L,8L,6L,7L,1L,3L,8L,1L,2L,3L,2L,8L,8L,5L,1L,2L,4L,8L,5L,5L,8L,9L,8L,0L,5L,9L,9L,0L,1L,8L,4L,9L,3L,4L,7L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230161Inst : IEnumerable<long>
{
public static readonly long[] Value=A230161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230161.Bytes);
public long this[int i]=>Value[i];

public static A230161Inst Instance=new A230161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230162
{
public static readonly long[] Value={ 1L,0L,8L,5L,0L,7L,0L,2L,4L,5L,4L,9L,1L,4L,5L,0L,8L,2L,8L,3L,3L,6L,8L,9L,5L,8L,6L,4L,0L,9L,7L,3L,1L,4L,2L,3L,4L,0L,5L,0L,6L,5L,3L,6L,3L,1L,0L,3L,0L,8L,9L,6L,5L,8L,1L,4L,6L,8L,6L,1L,5L,5L,3L,3L,3L,6L,5L,1L,8L,0L,4L,9L,9L,4L,0L,1L,1L,5L,7L,1L,9L,9L,7L,4L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230162Inst : IEnumerable<long>
{
public static readonly long[] Value=A230162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230162.Bytes);
public long this[int i]=>Value[i];

public static A230162Inst Instance=new A230162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230163
{
public static readonly long[] Value={ 1L,0L,7L,5L,7L,6L,6L,0L,6L,6L,0L,8L,6L,8L,3L,7L,1L,5L,8L,0L,5L,9L,5L,9L,9L,5L,2L,4L,1L,6L,5L,2L,7L,5L,8L,2L,0L,6L,9L,2L,5L,3L,0L,2L,4L,7L,6L,3L,9L,2L,0L,3L,2L,7L,9L,4L,7L,7L,0L,6L,8L,3L,9L,4L,5L,4L,4L,4L,7L,2L,6L,2L,6L,9L,5L,8L,5L,8L,2L,1L,6L,1L,9L,3L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230163Inst : IEnumerable<long>
{
public static readonly long[] Value=A230163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230163.Bytes);
public long this[int i]=>Value[i];

public static A230163Inst Instance=new A230163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230164
{
public static readonly long[] Value={ 17296L,24016L,334144656L,358585488L,2955423888L,311063879024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230164Inst : IEnumerable<long>
{
public static readonly long[] Value=A230164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230164.Bytes);
public long this[int i]=>Value[i];

public static A230164Inst Instance=new A230164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230165
{
public static readonly long[] Value={ 6L,15L,42L,47058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230165Inst : IEnumerable<long>
{
public static readonly long[] Value=A230165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230165.Bytes);
public long this[int i]=>Value[i];

public static A230165Inst Instance=new A230165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230166
{
public static readonly long[] Value={ 1L,3L,15L,135L,819L,1365L,1485L,2295L,9009L,13923L,63855L,387387L,397575L,667275L,14381055L,16410735L,99558459L,271543725L,3145425129L,7096702977L,741585912975L,2148325363107L,4847048133291L,39206559148911L,53164445037705L,130468907286855L,1229923663366167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230166Inst : IEnumerable<long>
{
public static readonly long[] Value=A230166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230166.Bytes);
public long this[int i]=>Value[i];

public static A230166Inst Instance=new A230166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230167
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,2L,4L,4L,7L,7L,10L,10L,15L,14L,20L,19L,25L,24L,31L,31L,39L,37L,45L,44L,55L,53L,63L,61L,72L,71L,83L,81L,94L,91L,105L,103L,118L,115L,130L,128L,144L,141L,158L,155L,174L,170L,188L,185L,205L,202L,222L,218L,239L,235L,258L,254L,277L,272L,295L,292L,317L,312L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230167Inst : IEnumerable<long>
{
public static readonly long[] Value=A230167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230167.Bytes);
public long this[int i]=>Value[i];

public static A230167Inst Instance=new A230167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230168
{
public static readonly BigInteger[] Value={ 89L,179L,359L,719L,1439L,2879L,11519L,23039L,737279L,1474559L,2949119L,188743679L,12079595519L,24159191039L,3092376453119L,6184752906239L,810647932926689279L,BigInteger.Parse("25940733853654056959"),BigInteger.Parse("1740853180245066011576893439"),BigInteger.Parse("445658414142736898963684720639") };
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
public class A230168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230168Inst Instance=new A230168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230169
{
public static readonly BigInteger[] Value={ 0L,27L,3787L,4722977L,49754476927L,4381081731832923L,BigInteger.Parse("3274958849115023706081") };
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
public class A230169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230169Inst Instance=new A230169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230170
{
public static readonly long[] Value={ 3L,27L,193L,1407L,10211L,73417L,530771L,3841171L,27770777L,200748959L,1451396131L,10493696945L,75868350707L,548518150083L,3965728577777L,28671821546207L,207294285260867L,1498715914818009L,10835559670997043L,78339967436748115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230170Inst : IEnumerable<long>
{
public static readonly long[] Value=A230170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230170.Bytes);
public long this[int i]=>Value[i];

public static A230170Inst Instance=new A230170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230171
{
public static readonly BigInteger[] Value={ 3L,193L,3787L,78849L,1637019L,33908253L,704822331L,14643857893L,304104787011L,6315931613849L,131183171878903L,2724650132436217L,56590036701710599L,1175359025263665849L,BigInteger.Parse("24411897444501278899"),BigInteger.Parse("507028430780683682221") };
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
public class A230171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230171Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230171.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230171Inst Instance=new A230171Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230172
{
public static readonly BigInteger[] Value={ 9L,1407L,78849L,4722977L,284444079L,17072965263L,1027868078181L,61861526624839L,3721702070420191L,223920929460093089L,13473042937456532657UL,BigInteger.Parse("810647385075641076549"),BigInteger.Parse("48774886700839338028985"),BigInteger.Parse("2934683063063203660000047") };
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
public class A230172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230172Inst Instance=new A230172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230173
{
public static readonly BigInteger[] Value={ 15L,10211L,1637019L,284444079L,49754476927L,8666440899433L,1514677019365483L,264644708761844781L,BigInteger.Parse("46219801332800121297"),BigInteger.Parse("8072805292655435557305"),BigInteger.Parse("1410066823439995419927677"),BigInteger.Parse("246292114172239867332919195") };
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
public class A230173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230173Inst Instance=new A230173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230174
{
public static readonly BigInteger[] Value={ 33L,73417L,33908253L,17072965263L,8666440899433L,4381081731832923L,2222884630214739547L,BigInteger.Parse("1127411488744987043611"),BigInteger.Parse("571557326062169407226463"),BigInteger.Parse("289782351408303721961315329"),BigInteger.Parse("146927686537779809297483679829") };
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
public class A230174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230174Inst Instance=new A230174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230175
{
public static readonly BigInteger[] Value={ 63L,530771L,704822331L,1027868078181L,1514677019365483L,2222884630214739547L,BigInteger.Parse("3274958849115023706081"),BigInteger.Parse("4822680345112751878337083"),BigInteger.Parse("7098618594645882579322969411"),BigInteger.Parse("10449577732703043756255819628725") };
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
public class A230175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230175Inst Instance=new A230175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230224
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,2L,1L,2L,1L,2L,2L,4L,1L,3L,3L,3L,4L,4L,3L,5L,4L,5L,3L,6L,4L,6L,5L,5L,5L,7L,5L,9L,4L,6L,6L,8L,6L,9L,5L,7L,7L,10L,6L,8L,7L,8L,7L,9L,5L,10L,7L,11L,7L,7L,7L,11L,7L,10L,6L,10L,6L,13L,7L,9L,7L,11L,9L,11L,7L,9L,6L,14L,8L,12L,6L,13L,11L,12L,11L,13L,10L,16L,9L,14L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230224Inst : IEnumerable<long>
{
public static readonly long[] Value=A230224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230224.Bytes);
public long this[int i]=>Value[i];

public static A230224Inst Instance=new A230224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230225
{
public static readonly long[] Value={ 31L,37L,59L,61L,71L,79L,101L,103L,107L,109L,149L,151L,163L,181L,211L,241L,257L,263L,271L,311L,313L,317L,331L,347L,367L,373L,389L,401L,421L,433L,449L,457L,461L,479L,499L,521L,541L,569L,571L,577L,587L,601L,619L,631L,661L,673L,677L,691L,701L,709L,727L,733L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230225Inst : IEnumerable<long>
{
public static readonly long[] Value=A230225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230225.Bytes);
public long this[int i]=>Value[i];

public static A230225Inst Instance=new A230225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230226
{
public static readonly long[] Value={ 49L,91L,121L,133L,143L,217L,247L,259L,273L,341L,361L,385L,403L,451L,475L,481L,511L,517L,539L,589L,611L,625L,637L,651L,665L,671L,721L,737L,749L,767L,775L,779L,793L,803L,805L,847L,861L,871L,875L,889L,925L,949L,959L,961L,1001L,1015L,1027L,1029L,1053L,1057L,1067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230226Inst : IEnumerable<long>
{
public static readonly long[] Value=A230226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230226.Bytes);
public long this[int i]=>Value[i];

public static A230226Inst Instance=new A230226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230227
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,31L,37L,41L,47L,53L,59L,61L,67L,79L,83L,89L,97L,101L,107L,109L,131L,137L,151L,157L,163L,167L,173L,191L,193L,199L,223L,229L,251L,257L,269L,277L,283L,307L,313L,317L,331L,347L,353L,367L,373L,397L,401L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230227Inst : IEnumerable<long>
{
public static readonly long[] Value=A230227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230227.Bytes);
public long this[int i]=>Value[i];

public static A230227Inst Instance=new A230227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230228
{
public static readonly BigInteger[] Value={ 2L,191L,1123529253211L,3868168229228618683L,BigInteger.Parse("164471141292141174461") };
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
public class A230228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230228Inst Instance=new A230228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230229
{
public static readonly BigInteger[] Value={ 2L,11L,74747L,185595581L,16831813861L,94350482728405349L,3842148274728412483L,BigInteger.Parse("30308322353935322380303") };
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
public class A230229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230229Inst Instance=new A230229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230230
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,3L,4L,3L,3L,5L,1L,5L,5L,3L,4L,5L,3L,2L,6L,4L,3L,6L,3L,3L,6L,3L,5L,6L,3L,6L,5L,4L,4L,9L,5L,4L,9L,5L,3L,9L,4L,4L,6L,4L,5L,6L,5L,5L,10L,4L,8L,10L,3L,7L,12L,3L,6L,11L,5L,7L,8L,3L,4L,6L,6L,4L,7L,2L,7L,9L,2L,10L,9L,3L,9L,8L,3L,5L,14L,8L,4L,12L,5L,5L,11L,5L,6L,8L,3L,8L,7L,4L,9L,11L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230230Inst : IEnumerable<long>
{
public static readonly long[] Value=A230230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230230.Bytes);
public long this[int i]=>Value[i];

public static A230230Inst Instance=new A230230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230231
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362879L,3628781L,39916492L,478996716L,6226941864L,87176969880L,1307651304960L,20922368987520L,355679390626560L,6402213152423659L,121641748198554547L,2432828930036156696L,BigInteger.Parse("51089280818439941448"),BigInteger.Parse("1123961390341566969192") };
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
public class A230231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230231Inst Instance=new A230231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230232
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,3628799L,39916779L,479001228L,6227014404L,87178179816L,1307672369640L,20922752672640L,355686706327680L,6402359109968640L,121644792614741760L,2432895242801771955L,BigInteger.Parse("51090787299486057355"),BigInteger.Parse("1123997039003038423610") };
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
public class A230232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230232Inst Instance=new A230232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230233
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,3628800L,39916799L,479001577L,6227020358L,87178283010L,1307674215120L,20922786961440L,355687370176320L,6402372516146880L,121645075013280000L,2432901444395385600L,BigInteger.Parse("51090929159028595200"),BigInteger.Parse("1124000415686590747031") };
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
public class A230233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230233Inst Instance=new A230233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230234
{
public static readonly BigInteger[] Value={ 1L,16L,231L,3322L,49236L,761904L,12372360L,211170960L,3788091451L,71356438043L,1409672722481L,29163603260677L,630867328411136L,14247689906846928L,335437110802718232L,8220763598490652440L,BigInteger.Parse("209435069840238717949"),BigInteger.Parse("5539287889970005834349"),BigInteger.Parse("151909981369978722092098") };
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
public class A230234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230234Inst Instance=new A230234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230235
{
public static readonly BigInteger[] Value={ 1L,18L,287L,4512L,72540L,1209936L,21064680L,383685120L,7315701120L,145957544981L,3044416187213L,66312765615259L,1506481046115907L,35648661471454418L,877558860954150150L,BigInteger.Parse("22444760416001869200"),BigInteger.Parse("595702609788740888400"),BigInteger.Parse("16387438983202886695200") };
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
public class A230235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230235Inst Instance=new A230235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230236
{
public static readonly BigInteger[] Value={ 1L,20L,349L,5954L,103194L,1845480L,34288800L,663848640L,13406178240L,282398538240L,6201593613645L,141859542537845L,3376683552323421L,83546513273754977L,2146303277645066980L,BigInteger.Parse("57187254952684274700"),BigInteger.Parse("1578640101972070456800"),BigInteger.Parse("45101111852055549981600") };
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
public class A230236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230236Inst Instance=new A230236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230237
{
public static readonly long[] Value={ 46427L,66929L,1560793L,1796647L,1810601L,1839673L,2053781L,2176673L,2426063L,2467007L,3172013L,3898603L,4208939L,12011921L,19504309L,29241797L,35464241L,35501573L,46838431L,46976227L,66580381L,69406561L,88015273L,104722321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230237Inst : IEnumerable<long>
{
public static readonly long[] Value=A230237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230237.Bytes);
public long this[int i]=>Value[i];

public static A230237Inst Instance=new A230237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230238
{
public static readonly long[] Value={ 6L,37716L,58710L,120930L,1269432L,2663850L,3349170L,3995244L,4353426L,5468424L,7191072L,7437960L,7564128L,7613892L,8354610L,8810490L,10309410L,11917620L,13573500L,21970980L,23877450L,24712350L,38801790L,49394556L,56208264L,56809578L,57339150L,66379170L,77966616L,91549710L,93657564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230238Inst : IEnumerable<long>
{
public static readonly long[] Value=A230238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230238.Bytes);
public long this[int i]=>Value[i];

public static A230238Inst Instance=new A230238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230239
{
public static readonly long[] Value={ 0L,1L,4L,5L,9L,12L,13L,16L,17L,20L,21L,25L,28L,29L,32L,33L,36L,37L,41L,44L,45L,48L,49L,52L,53L,57L,60L,61L,64L,65L,68L,69L,73L,76L,77L,80L,81L,84L,85L,89L,92L,93L,96L,97L,100L,101L,105L,108L,109L,112L,113L,116L,117L,121L,124L,125L,128L,129L,132L,133L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230239Inst : IEnumerable<long>
{
public static readonly long[] Value=A230239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230239.Bytes);
public long this[int i]=>Value[i];

public static A230239Inst Instance=new A230239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230288
{
public static readonly long[] Value={ 0L,5L,11L,13L,17L,26L,35L,44L,53L,62L,71L,79L,97L,105L,111L,113L,117L,125L,131L,133L,137L,145L,151L,153L,157L,165L,171L,173L,177L,185L,191L,193L,197L,206L,214L,220L,222L,226L,234L,240L,242L,246L,254L,260L,262L,266L,274L,280L,282L,286L,294L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230288Inst : IEnumerable<long>
{
public static readonly long[] Value=A230288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230288.Bytes);
public long this[int i]=>Value[i];

public static A230288Inst Instance=new A230288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230289
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,5L,8L,9L,10L,13L,24L,41L,26L,51L,64L,151L,276L,335L,446L,219L,550L,451L,1674L,1685L,2192L,2667L,9220L,17647L,3972L,9221L,17648L,25311L,35776L,25339L,147018L,112397L,146972L,212667L,243892L,243871L,963024L,1263521L,1838078L,2380569L,2380378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230289Inst : IEnumerable<long>
{
public static readonly long[] Value=A230289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230289.Bytes);
public long this[int i]=>Value[i];

public static A230289Inst Instance=new A230289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230290
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,4L,5L,4L,4L,4L,6L,7L,7L,5L,4L,10L,10L,10L,8L,9L,11L,10L,12L,10L,10L,13L,15L,14L,12L,14L,14L,14L,16L,16L,17L,17L,19L,21L,19L,20L,20L,18L,16L,16L,18L,24L,24L,23L,23L,21L,28L,28L,28L,24L,24L,26L,25L,27L,27L,28L,30L,30L,32L,28L,28L,30L,28L,30L,28L,29L,33L,39L,39L,37L,35L,39L,40L,38L,36L,36L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230290Inst : IEnumerable<long>
{
public static readonly long[] Value=A230290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230290.Bytes);
public long this[int i]=>Value[i];

public static A230290Inst Instance=new A230290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230291
{
public static readonly long[] Value={ 0L,2L,2L,2L,0L,2L,4L,6L,6L,4L,4L,4L,6L,6L,6L,6L,10L,10L,10L,10L,10L,12L,10L,10L,8L,6L,12L,14L,16L,16L,16L,18L,16L,18L,16L,14L,16L,16L,16L,12L,18L,22L,22L,24L,20L,22L,22L,24L,22L,20L,22L,28L,26L,26L,26L,24L,26L,26L,26L,26L,24L,28L,30L,30L,30L,30L,34L,34L,36L,32L,32L,32L,34L,36L,32L,34L,36L,34L,34L,34L,36L,36L,40L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230291Inst : IEnumerable<long>
{
public static readonly long[] Value=A230291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230291.Bytes);
public long this[int i]=>Value[i];

public static A230291Inst Instance=new A230291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230292
{
public static readonly long[] Value={ 1L,1L,2L,6L,6L,8L,6L,6L,11L,9L,13L,15L,14L,18L,20L,18L,14L,19L,21L,21L,25L,21L,25L,31L,33L,33L,31L,29L,33L,36L,32L,32L,34L,40L,40L,42L,41L,37L,49L,51L,51L,49L,47L,51L,52L,54L,50L,54L,54L,58L,60L,52L,56L,64L,62L,66L,68L,64L,68L,74L,72L,68L,73L,75L,75L,75L,77L,77L,85L,83L,79L,77L,72L,84L,88L,88L,84L,92L,94L,90L,98L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230292Inst : IEnumerable<long>
{
public static readonly long[] Value=A230292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230292.Bytes);
public long this[int i]=>Value[i];

public static A230292Inst Instance=new A230292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230293
{
public static readonly long[] Value={ 1L,0L,1L,3L,1L,1L,3L,3L,3L,6L,2L,1L,7L,5L,6L,6L,4L,6L,8L,7L,6L,8L,8L,8L,10L,6L,8L,15L,11L,10L,10L,8L,8L,14L,12L,11L,17L,15L,15L,15L,11L,10L,16L,14L,15L,17L,13L,19L,21L,19L,17L,17L,19L,17L,22L,15L,15L,21L,21L,23L,21L,21L,21L,27L,23L,22L,24L,20L,22L,28L,22L,21L,31L,25L,23L,27L,25L,28L,30L,28L,26L,28L,30L,30L,30L,26L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230293Inst : IEnumerable<long>
{
public static readonly long[] Value=A230293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230293.Bytes);
public long this[int i]=>Value[i];

public static A230293Inst Instance=new A230293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230294
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,3L,1L,3L,3L,1L,5L,5L,3L,5L,5L,5L,5L,5L,5L,8L,10L,6L,8L,7L,5L,11L,9L,7L,11L,12L,10L,10L,12L,10L,12L,14L,10L,12L,12L,11L,17L,16L,14L,16L,14L,14L,18L,18L,14L,16L,18L,14L,16L,18L,18L,25L,23L,19L,19L,18L,20L,20L,22L,20L,24L,24L,18L,24L,24L,22L,26L,25L,21L,27L,29L,27L,27L,27L,25L,25L,29L,25L,29L,28L,26L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230294Inst : IEnumerable<long>
{
public static readonly long[] Value=A230294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230294.Bytes);
public long this[int i]=>Value[i];

public static A230294Inst Instance=new A230294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230295
{
public static readonly long[] Value={ 0L,2L,0L,0L,4L,2L,2L,2L,2L,4L,6L,4L,2L,6L,4L,6L,8L,4L,4L,10L,8L,6L,10L,6L,8L,10L,10L,8L,8L,10L,12L,16L,10L,10L,14L,10L,12L,12L,10L,14L,18L,16L,12L,18L,18L,16L,18L,12L,12L,18L,16L,16L,20L,20L,22L,24L,18L,18L,22L,20L,20L,22L,16L,16L,26L,26L,26L,26L,22L,24L,24L,24L,24L,24L,26L,26L,32L,24L,26L,30L,28L,28L,28L,26L,26L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230295Inst : IEnumerable<long>
{
public static readonly long[] Value=A230295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230295.Bytes);
public long this[int i]=>Value[i];

public static A230295Inst Instance=new A230295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230296
{
public static readonly long[] Value={ 0L,2L,2L,3L,2L,2L,4L,2L,4L,6L,8L,8L,6L,4L,6L,5L,12L,8L,7L,8L,10L,12L,10L,16L,14L,12L,14L,12L,12L,12L,16L,18L,12L,14L,14L,12L,16L,20L,19L,19L,19L,26L,24L,22L,24L,24L,22L,20L,20L,20L,20L,26L,26L,24L,26L,28L,28L,22L,24L,24L,24L,30L,30L,32L,34L,36L,38L,33L,31L,30L,30L,36L,36L,35L,35L,36L,36L,36L,36L,36L,38L,38L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230296Inst : IEnumerable<long>
{
public static readonly long[] Value=A230296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230296.Bytes);
public long this[int i]=>Value[i];

public static A230296Inst Instance=new A230296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230297
{
public static readonly long[] Value={ 1L,10L,11L,101L,111L,1010L,1100L,1110L,10001L,10011L,10110L,11001L,11100L,11111L,100100L,100110L,101001L,101100L,101111L,110100L,110111L,111100L,1000000L,1000001L,1000011L,1000110L,1001001L,1001100L,1001111L,1010100L,1010111L,1011100L,1100000L,1100010L,1100101L,1101001L,1101101L,1110010L,1110110L,1111011L,10000001L,10000011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230297Inst : IEnumerable<long>
{
public static readonly long[] Value=A230297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230297.Bytes);
public long this[int i]=>Value[i];

public static A230297Inst Instance=new A230297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230298
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230298Inst : IEnumerable<long>
{
public static readonly long[] Value=A230298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230298.Bytes);
public long this[int i]=>Value[i];

public static A230298Inst Instance=new A230298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230299
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,52L,0L,11L,0L,0L,51L,50L,0L,49L,10L,0L,0L,48L,0L,9L,50L,0L,49L,0L,0L,47L,48L,0L,0L,8L,0L,49L,46L,0L,47L,48L,0L,45L,0L,0L,7L,46L,7L,47L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230299Inst : IEnumerable<long>
{
public static readonly long[] Value=A230299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230299.Bytes);
public long this[int i]=>Value[i];

public static A230299Inst Instance=new A230299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230300
{
public static readonly long[] Value={ 1L,3L,4L,6L,6L,8L,9L,11L,10L,12L,13L,15L,15L,17L,18L,20L,18L,20L,21L,23L,23L,25L,26L,28L,27L,29L,30L,32L,32L,34L,35L,37L,34L,36L,37L,39L,39L,41L,42L,44L,43L,45L,46L,48L,48L,50L,51L,53L,51L,53L,54L,56L,56L,58L,59L,61L,60L,62L,63L,65L,65L,67L,68L,70L,66L,68L,69L,71L,71L,73L,74L,76L,75L,77L,78L,80L,80L,82L,83L,85L,83L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230300Inst : IEnumerable<long>
{
public static readonly long[] Value=A230300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230300.Bytes);
public long this[int i]=>Value[i];

public static A230300Inst Instance=new A230300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230301
{
public static readonly long[] Value={ 2L,5L,7L,14L,16L,19L,22L,24L,31L,33L,38L,40L,47L,49L,52L,55L,57L,64L,72L,79L,81L,84L,87L,89L,96L,98L,103L,105L,112L,114L,117L,120L,122L,129L,131L,134L,136L,143L,145L,148L,151L,153L,160L,162L,167L,169L,176L,178L,181L,184L,186L,193L,201L,208L,210L,213L,216L,218L,225L,227L,232L,234L,241L,243L,246L,249L,251L,271L,273L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230301Inst : IEnumerable<long>
{
public static readonly long[] Value=A230301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230301.Bytes);
public long this[int i]=>Value[i];

public static A230301Inst Instance=new A230301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230302
{
public static readonly BigInteger[] Value={ 2L,7L,12L,136L,260L,4233L,8206L,BigInteger.Parse("87112285931760246646623899502532662136846"),BigInteger.Parse("174224571863520493293247799005065324265486"),BigInteger.Parse("1852673427797059126777135760139006525739432040582009271277945243629142736371850"),BigInteger.Parse("3705346855594118253554271520278013051304639509300498049262642688253220148478214") };
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
public class A230302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230302Inst Instance=new A230302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230303
{
public static readonly BigInteger[] Value={ 0L,5L,129L,4102L,BigInteger.Parse("87112285931760246646623899502532662132742"),BigInteger.Parse("1852673427797059126777135760139006525652319754650249024631321344126610074239106") };
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
public class A230303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230303.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230303Inst Instance=new A230303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230352
{
public static readonly long[] Value={ 1L,1L,3L,7L,20L,49L,148L,391L,1167L,3309L,9974L,29083L,88851L,265815L,818676L,2497633L,7753214L,23968298L,75015661L,234347623L,738220718L,2325779822L,7369929088L,23374281968L,74451070741L,237439581606L,759696374373L,2434110886204L,7818771362163L,25150994589336L,81070450302439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230352Inst : IEnumerable<long>
{
public static readonly long[] Value=A230352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230352.Bytes);
public long this[int i]=>Value[i];

public static A230352Inst Instance=new A230352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230353
{
public static readonly long[] Value={ 575L,1775L,2075L,2225L,2825L,3475L,6575L,8381L,8675L,8825L,8975L,8993L,10235L,11225L,11675L,11975L,12035L,12167L,12905L,13075L,14275L,14825L,18745L,19925L,21575L,22881L,23943L,24389L,25325L,25775L,26765L,27575L,30189L,30925L,30981L,31433L,32223L,32675L,32975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230353Inst : IEnumerable<long>
{
public static readonly long[] Value=A230353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230353.Bytes);
public long this[int i]=>Value[i];

public static A230353Inst Instance=new A230353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230354
{
public static readonly long[] Value={ 12L,18L,36L,54L,60L,72L,90L,108L,126L,132L,144L,156L,162L,180L,198L,204L,216L,228L,234L,240L,252L,270L,276L,306L,320L,324L,342L,348L,360L,372L,378L,396L,414L,420L,432L,450L,504L,516L,522L,540L,558L,594L,612L,624L,630L,636L,660L,702L,708L,720L,732L,738L,756L,774L,780L,792L,810L,900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230354Inst : IEnumerable<long>
{
public static readonly long[] Value=A230354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230354.Bytes);
public long this[int i]=>Value[i];

public static A230354Inst Instance=new A230354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230355
{
public static readonly long[] Value={ 12L,24L,60L,100L,120L,132L,150L,156L,200L,204L,228L,240L,264L,276L,300L,320L,348L,372L,420L,500L,516L,552L,600L,624L,636L,660L,700L,708L,732L,744L,780L,912L,1000L,1014L,1050L,1056L,1068L,1092L,1100L,1128L,1164L,1200L,1212L,1216L,1236L,1248L,1272L,1300L,1308L,1320L,1356L,1380L,1392L,1400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230355Inst : IEnumerable<long>
{
public static readonly long[] Value=A230355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230355.Bytes);
public long this[int i]=>Value[i];

public static A230355Inst Instance=new A230355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230356
{
public static readonly long[] Value={ 10L,18L,27L,40L,45L,54L,63L,72L,90L,108L,117L,126L,135L,153L,160L,162L,171L,180L,207L,216L,220L,234L,243L,250L,252L,261L,270L,304L,306L,315L,333L,342L,351L,360L,405L,414L,423L,432L,450L,490L,504L,513L,522L,531L,540L,603L,612L,621L,630L,640L,702L,711L,720L,801L,810L,931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230356Inst : IEnumerable<long>
{
public static readonly long[] Value=A230356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230356.Bytes);
public long this[int i]=>Value[i];

public static A230356Inst Instance=new A230356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230357
{
public static readonly long[] Value={ 22L,94L,105L,114L,136L,140L,160L,166L,202L,222L,234L,250L,265L,274L,346L,355L,361L,382L,424L,438L,445L,454L,516L,517L,526L,532L,562L,634L,702L,706L,712L,732L,812L,913L,915L,922L,1036L,1071L,1086L,1111L,1116L,1122L,1138L,1165L,1185L,1204L,1206L,1219L,1221L,1230L,1239L,1255L,1282L,1312L,1316L,1318L,1345L,1363L,1400L,1404L,1432L,1507L,1520L,1530L,1550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230357Inst : IEnumerable<long>
{
public static readonly long[] Value=A230357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230357.Bytes);
public long this[int i]=>Value[i];

public static A230357Inst Instance=new A230357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230358
{
public static readonly long[] Value={ 2L,1L,9L,8L,25L,24L,91L,90L,119L,118L,117L,116L,115L,114L,527L,526L,525L,524L,889L,888L,1131L,1130L,1339L,1338L,1337L,1336L,1335L,1334L,1333L,1332L,1331L,1330L,1329L,1328L,9553L,9552L,15691L,15690L,15689L,15688L,15687L,15686L,15685L,15684L,19617L,19616L,19615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230358Inst : IEnumerable<long>
{
public static readonly long[] Value=A230358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230358.Bytes);
public long this[int i]=>Value[i];

public static A230358Inst Instance=new A230358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230359
{
public static readonly long[] Value={ 5L,11L,13L,17L,19L,29L,31L,37L,41L,47L,53L,59L,61L,71L,73L,79L,89L,97L,101L,107L,109L,113L,131L,137L,139L,149L,151L,157L,173L,179L,181L,191L,193L,197L,199L,211L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,293L,307L,311L,313L,317L,331L,337L,347L,349L,353L,359L,373L,379L,389L,397L,401L,409L,419L,421L,431L,433L,439L,449L,457L,461L,479L,491L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230359Inst : IEnumerable<long>
{
public static readonly long[] Value=A230359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230359.Bytes);
public long this[int i]=>Value[i];

public static A230359Inst Instance=new A230359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230360
{
public static readonly long[] Value={ 2L,1L,0L,3L,6L,3L,0L,5L,12L,11L,0L,5L,12L,0L,0L,5L,0L,0L,0L,48L,14L,0L,61L,188L,83L,0L,81L,232L,268L,0L,0L,650L,0L,0L,622L,299L,0L,0L,0L,501L,0L,0L,2655L,602L,0L,6429L,8990L,7856L,0L,26187L,17898L,3744L,0L,40300L,16395L,0L,0L,0L,0L,0L,0L,124876L,173552L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230360Inst : IEnumerable<long>
{
public static readonly long[] Value=A230360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230360.Bytes);
public long this[int i]=>Value[i];

public static A230360Inst Instance=new A230360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230361
{
public static readonly long[] Value={ 23660L,26250L,53235L,94640L,105000L,147875L,212940L,222530L,236250L,378560L,390390L,420000L,479115L,591500L,656250L,788970L,851760L,945000L,1286250L,1330875L,1561560L,1680000L,1916460L,2126250L,2608515L,2625000L,3176250L,3407040L,3513510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230361Inst : IEnumerable<long>
{
public static readonly long[] Value=A230361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230361.Bytes);
public long this[int i]=>Value[i];

public static A230361Inst Instance=new A230361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230362
{
public static readonly long[] Value={ 3L,13L,7L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,7L,2L,2L,3L,2L,2L,3L,7L,2L,3L,7L,11L,13L,7L,2L,3L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,7L,2L,2L,3L,2L,3L,7L,7L,2L,3L,11L,2L,3L,7L,2L,2L,2L,3L,43L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230362Inst : IEnumerable<long>
{
public static readonly long[] Value=A230362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230362.Bytes);
public long this[int i]=>Value[i];

public static A230362Inst Instance=new A230362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230363
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,362880L,3628800L,39916800L,479001600L,6227020800L,1307674368000L,121645100408832000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230363Inst : IEnumerable<long>
{
public static readonly long[] Value=A230363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230363.Bytes);
public long this[int i]=>Value[i];

public static A230363Inst Instance=new A230363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230364
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,28L,55L,66L,105L,120L,136L,171L,231L,325L,406L,465L,561L,820L,1081L,1770L,2016L,2145L,2211L,3160L,3321L,5778L,7750L,11026L,13041L,13695L,15400L,17020L,23220L,34716L,41616L,55945L,60031L,70876L,75078L,100576L,106953L,126756L,196251L,260281L,263175L,374545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230364Inst : IEnumerable<long>
{
public static readonly long[] Value=A230364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230364.Bytes);
public long this[int i]=>Value[i];

public static A230364Inst Instance=new A230364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230365
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,121L,144L,196L,225L,256L,324L,441L,529L,900L,1296L,4096L,4489L,5041L,5476L,6561L,7056L,10609L,14884L,15625L,17956L,28561L,42025L,44100L,46656L,53361L,136900L,139129L,143641L,152100L,184041L,220900L,222784L,360000L,370881L,404496L,443556L,505521L,609961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230365Inst : IEnumerable<long>
{
public static readonly long[] Value=A230365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230365.Bytes);
public long this[int i]=>Value[i];

public static A230365Inst Instance=new A230365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230366
{
public static readonly long[] Value={ 0L,1L,1L,1L,5L,8L,7L,6L,12L,25L,22L,19L,39L,42L,35L,28L,68L,69L,76L,65L,91L,110L,92L,74L,125L,169L,144L,147L,203L,190L,186L,152L,242L,289L,245L,201L,333L,342L,286L,270L,410L,413L,430L,363L,420L,460L,423L,340L,490L,575L,578L,585L,689L,666L,605L,546L,760L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230366Inst : IEnumerable<long>
{
public static readonly long[] Value=A230366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230366.Bytes);
public long this[int i]=>Value[i];

public static A230366Inst Instance=new A230366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230367
{
public static readonly BigInteger[] Value={ 1L,3L,15L,142L,4300L,384199L,98654374L,70130880569L,136638863494089L,730439999032117301L,BigInteger.Parse("10764688922047900738650"),BigInteger.Parse("439762062635963206090747374") };
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
public class A230367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230367Inst Instance=new A230367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230464
{
public static readonly long[] Value={ 0L,0L,114L,1384L,16926L,212124L,2647098L,33046400L,412565142L,5150701380L,64304187186L,802809801448L,10022730288270L,125129422257516L,1562186333636778L,19503215967524816L,243489156724526214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230464Inst : IEnumerable<long>
{
public static readonly long[] Value=A230464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230464.Bytes);
public long this[int i]=>Value[i];

public static A230464Inst Instance=new A230464Inst();

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