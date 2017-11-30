using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A113641
{
public static readonly long[] Value={ 1267834459L,1957283461L,2449856317L,2452396871L,2459637181L,2523476981L,3815417629L,4176385921L,4357289761L,4682134579L,5748693121L,6913548721L,7531426981L,7693527841L,8129734561L,9146572381L,9752463781L,11396574289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113641Inst : IEnumerable<long>
{
public static readonly long[] Value=A113641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113641.Bytes);
public long this[int i]=>Value[i];

public static A113641Inst Instance=new A113641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113642
{
public static readonly long[] Value={ 12539670481L,13069482857L,15076432489L,15342679801L,16974853201L,17392546081L,18260734519L,18394765201L,21654091837L,23759084161L,24785139601L,25089467413L,26714530189L,27631845901L,29384567041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113642Inst : IEnumerable<long>
{
public static readonly long[] Value=A113642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113642.Bytes);
public long this[int i]=>Value[i];

public static A113642Inst Instance=new A113642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113643
{
public static readonly long[] Value={ 17392546081L,18394765201L,32798165401L,61280451937L,96112743805L,103964580721L,129386974501L,165274930081L,176962430851L,189147932065L,194687539201L,206238795841L,236791540801L,248979435601L,249817563601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113643Inst : IEnumerable<long>
{
public static readonly long[] Value=A113643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113643.Bytes);
public long this[int i]=>Value[i];

public static A113643Inst Instance=new A113643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113644
{
public static readonly long[] Value={ 5748693121L,9146572381L,13946829751L,15989367241L,28239546721L,28637914561L,36976452481L,73487592361L,79623874561L,92437591681L,95287763341L,121254376891L,129855637441L,149378245633L,189634571281L,195376852441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113644Inst : IEnumerable<long>
{
public static readonly long[] Value=A113644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113644.Bytes);
public long this[int i]=>Value[i];

public static A113644Inst Instance=new A113644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113645
{
public static readonly long[] Value={ 4L,8L,12L,16L,18L,24L,27L,32L,36L,48L,54L,64L,72L,80L,81L,96L,108L,120L,128L,144L,160L,162L,180L,192L,200L,216L,240L,243L,256L,270L,288L,300L,320L,324L,360L,384L,400L,405L,432L,448L,450L,480L,486L,500L,512L,540L,576L,600L,640L,648L,672L,675L,720L,729L,750L,768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113645Inst : IEnumerable<long>
{
public static readonly long[] Value=A113645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113645.Bytes);
public long this[int i]=>Value[i];

public static A113645Inst Instance=new A113645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113646
{
public static readonly long[] Value={ 4L,4L,4L,4L,6L,6L,8L,8L,9L,10L,12L,12L,14L,14L,15L,16L,18L,18L,20L,20L,21L,22L,24L,24L,25L,26L,27L,28L,30L,30L,32L,32L,33L,34L,35L,36L,38L,38L,39L,40L,42L,42L,44L,44L,45L,46L,48L,48L,49L,50L,51L,52L,54L,54L,55L,56L,57L,58L,60L,60L,62L,62L,63L,64L,65L,66L,68L,68L,69L,70L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113646Inst : IEnumerable<long>
{
public static readonly long[] Value=A113646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113646.Bytes);
public long this[int i]=>Value[i];

public static A113646Inst Instance=new A113646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113647
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,13L,1L,15L,41L,67L,1L,31L,113L,247L,381L,1L,63L,289L,783L,1545L,2307L,1L,127L,705L,2271L,5361L,9975L,14589L,1L,255L,1665L,6207L,16929L,36879L,66057L,95235L,1L,511L,3841L,16255L,50113L,123871L,255985L,446455L,636925L,1L,1023L,8705L,41215L,141441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113647Inst : IEnumerable<long>
{
public static readonly long[] Value=A113647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113647.Bytes);
public long this[int i]=>Value[i];

public static A113647Inst Instance=new A113647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113648
{
public static readonly long[] Value={ 1L,3L,6L,1L,3L,5L,7L,9L,12L,15L,18L,21L,24L,27L,30L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,36L,39L,42L,45L,48L,51L,54L,57L,60L,63L,66L,69L,72L,75L,78L,81L,84L,87L,90L,93L,96L,99L,102L,105L,108L,111L,114L,117L,120L,123L,126L,1L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113648Inst : IEnumerable<long>
{
public static readonly long[] Value=A113648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113648.Bytes);
public long this[int i]=>Value[i];

public static A113648Inst Instance=new A113648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113649
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,5L,21L,34L,21L,55L,55L,89L,39L,37L,160L,98L,272L,293L,57L,365L,150L,101L,345L,433L,25L,665L,696L,709L,754L,440L,775L,994L,883L,1090L,765L,1241L,481L,230L,1511L,1355L,1599L,257L,1677L,805L,20L,1382L,752L,289L,2275L,1525L,1414L,821L,1484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113649Inst : IEnumerable<long>
{
public static readonly long[] Value=A113649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113649.Bytes);
public long this[int i]=>Value[i];

public static A113649Inst Instance=new A113649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113650
{
public static readonly long[] Value={ 2L,3L,5L,21L,55L,39L,272L,57L,345L,754L,775L,481L,1599L,1677L,752L,1484L,590L,2928L,469L,3905L,4234L,3871L,1743L,445L,3589L,9797L,2266L,2568L,2834L,6780L,1651L,8384L,7946L,16263L,17880L,9060L,6908L,26080L,7348L,22490L,31146L,23711L,17954L,5983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113650Inst : IEnumerable<long>
{
public static readonly long[] Value=A113650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113650.Bytes);
public long this[int i]=>Value[i];

public static A113650Inst Instance=new A113650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113651
{
public static readonly long[] Value={ 2L,7L,0L,47L,2L,167L,287L,2L,527L,2L,2L,1367L,2L,1847L,2207L,2807L,2L,2L,4487L,2L,5327L,2L,6887L,2L,9407L,2L,10607L,11447L,2L,12767L,16127L,2L,18767L,2L,2L,2L,24647L,26567L,27887L,29927L,2L,2L,2L,37247L,38807L,2L,2L,49727L,51527L,2L,54287L,2L,2L,2L,66047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113651Inst : IEnumerable<long>
{
public static readonly long[] Value=A113651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113651.Bytes);
public long this[int i]=>Value[i];

public static A113651Inst Instance=new A113651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113652
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,2L,0L,0L,-1L,1L,-2L,0L,0L,2L,0L,0L,-1L,2L,-1L,0L,-2L,0L,0L,0L,0L,3L,-2L,0L,0L,2L,0L,0L,-1L,0L,-2L,0L,-1L,2L,0L,0L,-2L,2L,0L,0L,0L,2L,0L,0L,0L,1L,-3L,0L,-2L,2L,0L,0L,0L,0L,-2L,0L,0L,2L,0L,0L,-1L,4L,0L,0L,-2L,0L,0L,0L,-1L,2L,-2L,0L,0L,0L,0L,0L,-2L,1L,-2L,0L,0L,4L,0L,0L,0L,2L,-2L,0L,0L,0L,0L,0L,0L,2L,-1L,0L,-3L,2L,0L,0L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113652Inst : IEnumerable<long>
{
public static readonly long[] Value=A113652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113652.Bytes);
public long this[int i]=>Value[i];

public static A113652Inst Instance=new A113652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113653
{
public static readonly long[] Value={ 6L,51L,55L,69L,82L,183L,194L,249L,259L,287L,309L,314L,319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113653Inst : IEnumerable<long>
{
public static readonly long[] Value=A113653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113653.Bytes);
public long this[int i]=>Value[i];

public static A113653Inst Instance=new A113653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113654
{
public static readonly long[] Value={ 1L,11L,101L,125L,153L,1205L,1502L,1810L,3080L,7631L,18010L,18650L,21020L,36559L,36911L,44805L,53999L,60541L,68443L,120005L,189585L,210020L,487195L,1059449L,1750004L,1800010L,1860050L,1872250L,2072139L,2170100L,2268661L,2496750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113654Inst : IEnumerable<long>
{
public static readonly long[] Value=A113654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113654.Bytes);
public long this[int i]=>Value[i];

public static A113654Inst Instance=new A113654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113655
{
public static readonly long[] Value={ 3L,2L,1L,6L,5L,4L,9L,8L,7L,12L,11L,10L,15L,14L,13L,18L,17L,16L,21L,20L,19L,24L,23L,22L,27L,26L,25L,30L,29L,28L,33L,32L,31L,36L,35L,34L,39L,38L,37L,42L,41L,40L,45L,44L,43L,48L,47L,46L,51L,50L,49L,54L,53L,52L,57L,56L,55L,60L,59L,58L,63L,62L,61L,66L,65L,64L,69L,68L,67L,72L,71L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113655Inst : IEnumerable<long>
{
public static readonly long[] Value=A113655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113655.Bytes);
public long this[int i]=>Value[i];

public static A113655Inst Instance=new A113655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113656
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,3L,1L,7L,1L,9L,3L,1L,6L,1L,8L,9L,1L,0L,7L,1L,2L,7L,5L,2L,1L,6L,0L,7L,1L,2L,7L,9L,2L,2L,0L,3L,2L,2L,8L,1L,3L,2L,1L,7L,4L,2L,5L,3L,4L,4L,2L,3L,9L,6L,8L,9L,9L,9L,4L,1L,1L,1L,2L,1L,3L,1L,9L,9L,3L,7L,2L,1L,7L,0L,1L,2L,3L,2L,0L,9L,4L,4L,4L,9L,7L,8L,6L,2L,4L,3L,1L,1L,0L,5L,0L,3L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113656Inst : IEnumerable<long>
{
public static readonly long[] Value=A113656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113656.Bytes);
public long this[int i]=>Value[i];

public static A113656Inst Instance=new A113656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113657
{
public static readonly long[] Value={ 0L,0L,0L,9L,1L,8L,2L,7L,3L,6L,4L,5L,5L,4L,6L,3L,7L,2L,8L,1L,9L,1L,0L,0L,0L,9L,1L,8L,2L,7L,3L,6L,4L,5L,5L,4L,6L,3L,7L,2L,8L,1L,9L,1L,0L,0L,0L,9L,1L,8L,2L,7L,3L,6L,4L,5L,5L,4L,6L,3L,7L,2L,8L,1L,9L,1L,0L,0L,0L,9L,1L,8L,2L,7L,3L,6L,4L,5L,5L,4L,6L,3L,7L,2L,8L,1L,9L,1L,0L,0L,0L,9L,1L,8L,2L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113657Inst : IEnumerable<long>
{
public static readonly long[] Value=A113657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113657.Bytes);
public long this[int i]=>Value[i];

public static A113657Inst Instance=new A113657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113658
{
public static readonly long[] Value={ 1L,3L,2L,7L,4L,8L,6L,15L,9L,19L,10L,23L,12L,20L,5L,31L,16L,27L,18L,24L,14L,11L,22L,32L,25L,39L,26L,48L,28L,35L,30L,63L,21L,51L,34L,71L,36L,56L,38L,64L,40L,83L,42L,55L,44L,68L,46L,95L,49L,75L,17L,103L,52L,80L,54L,111L,57L,87L,58L,104L,60L,92L,62L,127L,65L,99L,66L,119L,45L,84L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113658Inst : IEnumerable<long>
{
public static readonly long[] Value=A113658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113658.Bytes);
public long this[int i]=>Value[i];

public static A113658Inst Instance=new A113658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113659
{
public static readonly long[] Value={ 1L,9L,25L,49L,57L,65L,81L,85L,93L,121L,133L,153L,169L,185L,201L,209L,217L,225L,253L,261L,289L,297L,301L,305L,309L,329L,333L,345L,361L,369L,381L,385L,393L,417L,441L,469L,477L,489L,497L,501L,505L,513L,525L,529L,533L,553L,561L,565L,581L,621L,625L,633L,637L,645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113659Inst : IEnumerable<long>
{
public static readonly long[] Value=A113659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113659.Bytes);
public long this[int i]=>Value[i];

public static A113659Inst Instance=new A113659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113660
{
public static readonly long[] Value={ 1L,6L,12L,6L,-6L,0L,12L,12L,12L,6L,0L,0L,-6L,12L,24L,0L,-6L,0L,12L,12L,0L,12L,0L,0L,12L,6L,24L,6L,-12L,0L,0L,12L,12L,0L,0L,0L,-6L,12L,24L,12L,0L,0L,24L,12L,0L,0L,0L,0L,-6L,18L,12L,0L,-12L,0L,12L,0L,24L,12L,0L,0L,0L,12L,24L,12L,-6L,0L,0L,12L,0L,0L,0L,0L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113660Inst : IEnumerable<long>
{
public static readonly long[] Value=A113660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113660.Bytes);
public long this[int i]=>Value[i];

public static A113660Inst Instance=new A113660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113661
{
public static readonly long[] Value={ 1L,2L,1L,-1L,0L,2L,2L,2L,1L,0L,0L,-1L,2L,4L,0L,-1L,0L,2L,2L,0L,2L,0L,0L,2L,1L,4L,1L,-2L,0L,0L,2L,2L,0L,0L,0L,-1L,2L,4L,2L,0L,0L,4L,2L,0L,0L,0L,0L,-1L,3L,2L,0L,-2L,0L,2L,0L,4L,2L,0L,0L,0L,2L,4L,2L,-1L,0L,0L,2L,0L,0L,0L,0L,2L,2L,4L,1L,-2L,0L,4L,2L,0L,1L,0L,0L,-2L,0L,4L,0L,0L,0L,0L,4L,0L,2L,0L,0L,2L,2L,6L,0L,-1L,0L,0L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113661Inst : IEnumerable<long>
{
public static readonly long[] Value=A113661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113661.Bytes);
public long this[int i]=>Value[i];

public static A113661Inst Instance=new A113661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113662
{
public static readonly BigInteger[] Value={ 1L,2L,9L,62L,566L,6372L,84837L,1300214L,22511322L,434226300L,9231983850L,214481625516L,5406323440492L,146963638311880L,4286068830850797L,133501081493969574L,4423404073559930162L,BigInteger.Parse("155359770700317171084") };
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
public class A113662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113662Inst Instance=new A113662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113663
{
public static readonly BigInteger[] Value={ 1L,3L,21L,226L,3216L,56229L,1158249L,27367560L,728245038L,21531918486L,700096811670L,24826071871890L,953594302010230L,39446976470619801L,1748616265593936681L,BigInteger.Parse("82701936091459565976"),BigInteger.Parse("4157268410857737364182") };
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
public class A113663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113663Inst Instance=new A113663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113664
{
public static readonly BigInteger[] Value={ 1L,4L,38L,556L,10745L,254700L,7100444L,226687964L,8138624340L,324257974800L,14191562670382L,676772204063828L,34931592000218062L,1940427169943222088L,BigInteger.Parse("115440543670528170360"),BigInteger.Parse("7323969420842077029820"),BigInteger.Parse("493653199877341017573868") };
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
public class A113664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113664Inst Instance=new A113664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113665
{
public static readonly BigInteger[] Value={ 1L,5L,60L,1110L,27105L,811026L,28511130L,1146762120L,51826136580L,2597311722545L,142897603735880L,8561763675801900L,554962861232408910L,BigInteger.Parse("38698651781787343980"),BigInteger.Parse("2889100726488051970230"),BigInteger.Parse("229948324353525499175160") };
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
public class A113665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113665Inst Instance=new A113665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113666
{
public static readonly BigInteger[] Value={ 1L,6L,87L,1946L,57429L,2075376L,88058362L,4272270786L,232769956974L,14056832143770L,931523802358452L,67202173618455120L,5243275012537211083L,BigInteger.Parse("439986956480236610424"),BigInteger.Parse("39519795153012732250740") };
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
public class A113666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113666Inst Instance=new A113666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113667
{
public static readonly BigInteger[] Value={ 1L,7L,119L,3122L,108031L,4575543L,227428166L,12920344256L,823981508700L,58224680389435L,4513525625433076L,380801193456921958L,BigInteger.Parse("34738963053424196609"),BigInteger.Parse("3407790141561016562022"),BigInteger.Parse("357764735284328750251272") };
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
public class A113667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113667Inst Instance=new A113667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113668
{
public static readonly BigInteger[] Value={ 1L,8L,156L,4696L,186406L,9053640L,515875660L,33585910968L,2453913830097L,198609146859416L,17630476159933080L,1703025192274201272L,BigInteger.Parse("177846105338917975896"),BigInteger.Parse("19968484152350242447288") };
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
public class A113668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113668Inst Instance=new A113668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113669
{
public static readonly BigInteger[] Value={ 1L,1L,6L,63L,904L,16080L,337374L,8107743L,218940480L,6554205342L,215319184860L,7701064928370L,297912862462680L,12396725926132990L,552257670588677214L,BigInteger.Parse("26229243983909050215"),BigInteger.Parse("1323230977463353055616"),BigInteger.Parse("70673562984581535191094") };
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
public class A113669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113669Inst Instance=new A113669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113670
{
public static readonly BigInteger[] Value={ 1L,1L,8L,114L,2224L,53725L,1528200L,49703108L,1813503712L,73247619060L,3242579748000L,156107189374202L,8121266448765936L,454110696002834806L,BigInteger.Parse("27165980379205109232"),BigInteger.Parse("1731608155057922555400"),BigInteger.Parse("117183510733473232477120") };
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
public class A113670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113670Inst Instance=new A113670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113671
{
public static readonly BigInteger[] Value={ 1L,1L,10L,180L,4440L,135525L,4866156L,199577910L,9174096960L,466435229220L,25973117225450L,1571873641094680L,102741164109622800L,7214517196021315830L,BigInteger.Parse("541781124945022815720"),BigInteger.Parse("43336510897320779553450") };
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
public class A113671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113671Inst Instance=new A113671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113672
{
public static readonly BigInteger[] Value={ 1L,1L,12L,261L,7784L,287145L,12452256L,616408534L,34178166288L,2094929612766L,140568321437700L,10246761825942972L,806426083421461440L,BigInteger.Parse("68162575162983744079"),BigInteger.Parse("6159817390723312545936"),BigInteger.Parse("592796927295190983761100") };
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
public class A113672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113672Inst Instance=new A113672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113673
{
public static readonly BigInteger[] Value={ 1L,1L,14L,357L,12488L,540155L,27453258L,1591997162L,103362754048L,7415833578300L,582246803894350L,49648781879763836L,4569614321483063496L,BigInteger.Parse("451606519694514555917"),BigInteger.Parse("47709061981854231868308") };
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
public class A113673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113673Inst Instance=new A113673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113674
{
public static readonly BigInteger[] Value={ 1L,1L,16L,468L,18784L,932030L,54321840L,3611129620L,268687287744L,22085224470873L,1986091468594160L,193935237759263880L,BigInteger.Parse("20436302307290415264"),BigInteger.Parse("2311999369405933686648"),BigInteger.Parse("279558778132903394262032") };
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
public class A113674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113674Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113674.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113674Inst Instance=new A113674Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113675
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113675Inst : IEnumerable<long>
{
public static readonly long[] Value=A113675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113675.Bytes);
public long this[int i]=>Value[i];

public static A113675Inst Instance=new A113675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113676
{
public static readonly long[] Value={ 1L,1L,2L,6L,27L,234L,6202L,1084009L,4362192095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113676Inst : IEnumerable<long>
{
public static readonly long[] Value=A113676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113676.Bytes);
public long this[int i]=>Value[i];

public static A113676Inst Instance=new A113676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113677
{
public static readonly BigInteger[] Value={ 3L,30L,840L,37800L,2328480L,181621440L,17124307200L,1892235945600L,239683219776000L,34226763784012800L,5438943917677670400L,BigInteger.Parse("951815185593592320000"),BigInteger.Parse("181869917001114101760000") };
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
public class A113677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113677Inst Instance=new A113677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113678
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,2L,2L,0L,1L,6L,2L,2L,0L,1L,10L,6L,2L,2L,0L,1L,22L,10L,6L,2L,2L,0L,1L,42L,22L,10L,6L,2L,2L,0L,1L,86L,42L,22L,10L,6L,2L,2L,0L,1L,170L,86L,42L,22L,10L,6L,2L,2L,0L,1L,342L,170L,86L,42L,22L,10L,6L,2L,2L,0L,1L,682L,342L,170L,86L,42L,22L,10L,6L,2L,2L,0L,1L,1366L,682L,342L,170L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113678Inst : IEnumerable<long>
{
public static readonly long[] Value=A113678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113678.Bytes);
public long this[int i]=>Value[i];

public static A113678Inst Instance=new A113678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113679
{
public static readonly long[] Value={ 1L,0L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113679Inst : IEnumerable<long>
{
public static readonly long[] Value=A113679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113679.Bytes);
public long this[int i]=>Value[i];

public static A113679Inst Instance=new A113679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113680
{
public static readonly long[] Value={ 1L,0L,1L,-2L,0L,1L,-2L,-2L,0L,1L,-2L,-2L,-2L,0L,1L,-2L,-2L,-2L,-2L,0L,1L,-2L,-2L,-2L,-2L,-2L,0L,1L,-2L,-2L,-2L,-2L,-2L,-2L,0L,1L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,0L,1L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,0L,1L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,0L,1L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,0L,1L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113680Inst : IEnumerable<long>
{
public static readonly long[] Value=A113680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113680.Bytes);
public long this[int i]=>Value[i];

public static A113680Inst Instance=new A113680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113681
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113681Inst : IEnumerable<long>
{
public static readonly long[] Value=A113681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113681.Bytes);
public long this[int i]=>Value[i];

public static A113681Inst Instance=new A113681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113682
{
public static readonly long[] Value={ 1L,1L,4L,9L,26L,70L,197L,553L,1570L,4476L,12827L,36894L,106471L,308113L,893804L,2598313L,7567466L,22076404L,64498427L,188689684L,552675365L,1620567763L,4756614062L,13974168190L,41088418151L,120906613075L,356035078102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113682Inst : IEnumerable<long>
{
public static readonly long[] Value=A113682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113682.Bytes);
public long this[int i]=>Value[i];

public static A113682Inst Instance=new A113682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113683
{
public static readonly long[] Value={ 10L,42L,14L,54L,18L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113683Inst : IEnumerable<long>
{
public static readonly long[] Value=A113683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113683.Bytes);
public long this[int i]=>Value[i];

public static A113683Inst Instance=new A113683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113684
{
public static readonly long[] Value={ 0L,1L,4L,11L,25L,52L,102L,193L,356L,645L,1153L,2040L,3580L,6241L,10820L,18671L,32089L,54956L,93826L,159745L,271300L,459721L,777409L,1312176L,2211000L,3719617L,6248452L,10482323L,17562841L,29391460L,49132638L,82048705L,136884260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113684Inst : IEnumerable<long>
{
public static readonly long[] Value=A113684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113684.Bytes);
public long this[int i]=>Value[i];

public static A113684Inst Instance=new A113684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113685
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,2L,2L,0L,1L,0L,2L,0L,2L,0L,2L,0L,3L,3L,0L,2L,0L,2L,0L,4L,0L,3L,0L,4L,0L,3L,0L,5L,5L,0L,3L,0L,4L,0L,4L,0L,6L,0L,5L,0L,6L,0L,6L,0L,5L,0L,8L,7L,0L,5L,0L,6L,0L,8L,0L,6L,0L,10L,0L,7L,0L,10L,0L,9L,0L,10L,0L,8L,0L,12L,11L,0L,7L,0L,10L,0L,12L,0L,12L,0L,10L,0L,15L,0L,11L,0L,14L,0L,15L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113685Inst : IEnumerable<long>
{
public static readonly long[] Value=A113685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113685.Bytes);
public long this[int i]=>Value[i];

public static A113685Inst Instance=new A113685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113686
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,2L,0L,1L,0L,2L,0L,1L,0L,2L,3L,0L,2L,0L,2L,0L,4L,0L,2L,0L,2L,0L,3L,5L,0L,3L,0L,4L,0L,3L,0L,6L,0L,4L,0L,4L,0L,3L,0L,5L,8L,0L,5L,0L,6L,0L,6L,0L,5L,0L,10L,0L,6L,0L,8L,0L,6L,0L,5L,0L,7L,12L,0L,8L,0L,10L,0L,9L,0L,10L,0L,7L,0L,15L,0L,10L,0L,12L,0L,12L,0L,10L,0L,7L,0L,11L,18L,0L,12L,0L,16L,0L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113686Inst : IEnumerable<long>
{
public static readonly long[] Value=A113686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113686.Bytes);
public long this[int i]=>Value[i];

public static A113686Inst Instance=new A113686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113687
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,-1L,-1L,1L,1L,0L,0L,1L,-1L,1L,-1L,0L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,-1L,0L,0L,1L,1L,1L,0L,1L,-1L,0L,1L,0L,-1L,0L,0L,1L,-1L,-1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,-1L,-2L,0L,-1L,0L,0L,-1L,0L,1L,1L,-1L,1L,0L,-1L,0L,2L,0L,0L,-1L,0L,1L,0L,0L,-1L,1L,0L,-1L,0L,-1L,2L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,-1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113687Inst : IEnumerable<long>
{
public static readonly long[] Value=A113687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113687.Bytes);
public long this[int i]=>Value[i];

public static A113687Inst Instance=new A113687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113688
{
public static readonly long[] Value={ 65L,74L,249L,295L,309L,355L,422L,511L,545L,667L,669L,758L,926L,943L,979L,998L,1099L,1167L,1186L,1322L,1457L,1469L,1561L,1585L,1658L,1711L,1774L,1779L,1835L,1891L,1959L,1961L,1963L,2021L,2038L,2066L,2155L,2186L,2191L,2206L,2271L,2329L,2342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113688Inst : IEnumerable<long>
{
public static readonly long[] Value=A113688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113688.Bytes);
public long this[int i]=>Value[i];

public static A113688Inst Instance=new A113688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113689
{
public static readonly long[] Value={ 0L,0L,2L,6L,9L,13L,17L,21L,23L,31L,37L,45L,54L,59L,72L,77L,83L,93L,104L,116L,125L,140L,150L,164L,180L,188L,203L,219L,236L,255L,272L,287L,301L,317L,334L,354L,378L,403L,419L,430L,450L,475L,498L,521L,542L,560L,588L,608L,626L,652L,677L,698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113689Inst : IEnumerable<long>
{
public static readonly long[] Value=A113689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113689.Bytes);
public long this[int i]=>Value[i];

public static A113689Inst Instance=new A113689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113690
{
public static readonly long[] Value={ 86L,298L,371L,1243L,1541L,2426L,2627L,3053L,4258L,5366L,5663L,6281L,6602L,6931L,7613L,8327L,9073L,9458L,10661L,13283L,14702L,15191L,16706L,18293L,18838L,23486L,25361L,26002L,26651L,27973L,28646L,34318L,35063L,36577L,38123L,41311L,43786L,44627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113690Inst : IEnumerable<long>
{
public static readonly long[] Value=A113690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113690.Bytes);
public long this[int i]=>Value[i];

public static A113690Inst Instance=new A113690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113691
{
public static readonly long[] Value={ 46L,77L,218L,1073L,1351L,1502L,1661L,2186L,2998L,4193L,4727L,5006L,5293L,5891L,7183L,8603L,10558L,12266L,13631L,14581L,15563L,19811L,20953L,25202L,27806L,29843L,30538L,31241L,32671L,33398L,35627L,37153L,39502L,40301L,46118L,46981L,49618L,56051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113691Inst : IEnumerable<long>
{
public static readonly long[] Value=A113691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113691.Bytes);
public long this[int i]=>Value[i];

public static A113691Inst Instance=new A113691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113692
{
public static readonly long[] Value={ 6L,69L,106L,265L,334L,411L,589L,799L,1041L,1174L,1315L,1959L,2329L,3394L,4659L,5221L,5815L,7099L,8146L,8511L,10869L,16449L,21979L,23181L,23794L,25681L,26326L,31774L,33949L,35439L,36961L,38515L,40101L,43369L,45051L,48511L,50289L,52099L,54874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113692Inst : IEnumerable<long>
{
public static readonly long[] Value=A113692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113692.Bytes);
public long this[int i]=>Value[i];

public static A113692Inst Instance=new A113692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113693
{
public static readonly long[] Value={ 4L,15L,34L,249L,391L,565L,771L,886L,1915L,3814L,5149L,5739L,6046L,7354L,9169L,10765L,11611L,15814L,16321L,18429L,20665L,22426L,24259L,28141L,29499L,32311L,36769L,39106L,43161L,48291L,52786L,53709L,57481L,60394L,63379L,65409L,67471L,69565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113693Inst : IEnumerable<long>
{
public static readonly long[] Value=A113693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113693.Bytes);
public long this[int i]=>Value[i];

public static A113693Inst Instance=new A113693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113694
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,2L,4L,4L,4L,6L,6L,6L,8L,8L,9L,1L,1L,1L,3L,3L,3L,5L,5L,5L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113694Inst : IEnumerable<long>
{
public static readonly long[] Value=A113694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113694.Bytes);
public long this[int i]=>Value[i];

public static A113694Inst Instance=new A113694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113695
{
public static readonly ulong[] Value={ 1L,2L,30L,40L,520L,6120L,75080L,821920L,9125440L,1012882880L,11690270720L,127219466240L,1377297694720L,14982604718080L,1512710259671040L,16662943738757120L,178381140013219840L,18013061754595573760UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113695Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A113695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113695.Bytes);
public ulong this[int i]=>Value[i];

public static A113695Inst Instance=new A113695Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113696
{
public static readonly ulong[] Value={ 65L,8L,763L,781L,8509L,81524L,913482L,900690927L,900937344L,86643235592L,918905814153L,9236889506739L,919264520846713L,990447749150478L,90782894270509757L,9341202627992078164UL,9902877281132422544UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113696Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A113696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113696.Bytes);
public ulong this[int i]=>Value[i];

public static A113696Inst Instance=new A113696Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113697
{
public static readonly long[] Value={ 6L,8L,8L,9L,9L,9L,9L,90L,91L,92L,92L,93L,93L,94L,94L,95L,95L,95L,96L,96L,96L,96L,96L,97L,97L,97L,97L,97L,97L,97L,97L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113697Inst : IEnumerable<long>
{
public static readonly long[] Value=A113697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113697.Bytes);
public long this[int i]=>Value[i];

public static A113697Inst Instance=new A113697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113698
{
public static readonly long[] Value={ 1L,2L,12L,3L,13L,23L,123L,4L,14L,24L,34L,124L,134L,234L,1234L,5L,15L,25L,35L,45L,125L,135L,145L,235L,245L,345L,1235L,1245L,1345L,2345L,12345L,6L,16L,26L,36L,46L,56L,126L,136L,146L,156L,236L,246L,256L,346L,356L,456L,1236L,1246L,1256L,1346L,1356L,1456L,2346L,2356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113698Inst : IEnumerable<long>
{
public static readonly long[] Value=A113698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113698.Bytes);
public long this[int i]=>Value[i];

public static A113698Inst Instance=new A113698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113699
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,513L,514L,3L,5L,9L,17L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113699Inst : IEnumerable<long>
{
public static readonly long[] Value=A113699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113699.Bytes);
public long this[int i]=>Value[i];

public static A113699Inst Instance=new A113699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113700
{
public static readonly long[] Value={ 2L,3L,50L,75L,122L,174L,183L,194L,203L,291L,338L,410L,507L,615L,722L,794L,842L,914L,1058L,1082L,1083L,1154L,1182L,1191L,1202L,1263L,1346L,1371L,1379L,1442L,1562L,1572L,1587L,1623L,1682L,1703L,1731L,1778L,1803L,1922L,2018L,2019L,2066L,2163L,2343L,2354L,2426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113700Inst : IEnumerable<long>
{
public static readonly long[] Value=A113700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113700.Bytes);
public long this[int i]=>Value[i];

public static A113700Inst Instance=new A113700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113701
{
public static readonly long[] Value={ 1734L,2312L,4335L,4804L,6005L,7494L,8407L,8994L,9992L,10493L,12548L,13491L,16004L,18244L,18735L,18822L,19268L,20005L,21956L,21959L,22805L,23412L,24026L,24964L,25363L,26076L,27332L,28007L,28902L,30020L,30692L,31205L,31927L,32934L,33167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113701Inst : IEnumerable<long>
{
public static readonly long[] Value=A113701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113701.Bytes);
public long this[int i]=>Value[i];

public static A113701Inst Instance=new A113701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113702
{
public static readonly long[] Value={ 10L,11L,22L,23L,12L,13L,91L,161L,189L,285L,429L,473L,869L,957L,1437L,2157L,3237L,4857L,7287L,4164L,3470L,4511L,2256L,1464L,1172L,782L,783L,392L,294L,413L,531L,342L,343L,172L,173L,519L,346L,347L,694L,1735L,1388L,926L,927L,464L,248L,166L,167L,84L,70L,71L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113702Inst : IEnumerable<long>
{
public static readonly long[] Value=A113702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113702.Bytes);
public long this[int i]=>Value[i];

public static A113702Inst Instance=new A113702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113703
{
public static readonly long[] Value={ 10L,19L,18L,27L,26L,39L,38L,56L,111L,74L,147L,146L,219L,218L,435L,290L,579L,578L,867L,866L,1299L,1298L,1947L,1121L,589L,341L,186L,371L,265L,105L,69L,45L,44L,55L,54L,80L,159L,53L,52L,103L,102L,152L,208L,415L,414L,459L,458L,915L,365L,145L,115L,114L,132L,176L,351L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113703Inst : IEnumerable<long>
{
public static readonly long[] Value=A113703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113703.Bytes);
public long this[int i]=>Value[i];

public static A113703Inst Instance=new A113703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113704
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113704Inst : IEnumerable<long>
{
public static readonly long[] Value=A113704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113704.Bytes);
public long this[int i]=>Value[i];

public static A113704Inst Instance=new A113704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113705
{
public static readonly BigInteger[] Value={ 1L,10L,110L,1010L,10110L,100010L,1001110L,10000010L,100010110L,1000001010L,10000100110L,100000000010L,1000001011110L,10000000000010L,100000010000110L,1000000000101010L,10000000100010110L,100000000000000010L,1000000001001001110L,10000000000000000010UL,BigInteger.Parse("100000000010000110110") };
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
public class A113705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113705Inst Instance=new A113705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113706
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,-1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,-1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,-1L,1L,1L,-1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,1L,0L,1L,0L,-1L,1L,1L,-1L,0L,1L,-1L,0L,2L,0L,-1L,1L,0L,-1L,1L,1L,0L,1L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113706Inst : IEnumerable<long>
{
public static readonly long[] Value=A113706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113706.Bytes);
public long this[int i]=>Value[i];

public static A113706Inst Instance=new A113706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113707
{
public static readonly long[] Value={ 1L,69L,609L,196833L,241605L,440503L,2374119L,2841633L,3256479L,5529975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113707Inst : IEnumerable<long>
{
public static readonly long[] Value=A113707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113707.Bytes);
public long this[int i]=>Value[i];

public static A113707Inst Instance=new A113707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113708
{
public static readonly long[] Value={ 0L,1L,1138L,1634L,2178L,4179L,4338L,4514L,6514L,6725L,8208L,9219L,9474L,13139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113708Inst : IEnumerable<long>
{
public static readonly long[] Value=A113708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113708.Bytes);
public long this[int i]=>Value[i];

public static A113708Inst Instance=new A113708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113709
{
public static readonly long[] Value={ 4L,6L,8L,12L,16L,18L,20L,24L,30L,36L,40L,42L,44L,48L,54L,60L,66L,68L,72L,78L,80L,84L,96L,100L,102L,104L,108L,112L,126L,128L,132L,138L,140L,150L,156L,162L,164L,168L,174L,180L,190L,192L,196L,198L,204L,216L,224L,228L,232L,234L,240L,250L,252L,258L,264L,270L,276L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113709Inst : IEnumerable<long>
{
public static readonly long[] Value=A113709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113709.Bytes);
public long this[int i]=>Value[i];

public static A113709Inst Instance=new A113709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113710
{
public static readonly long[] Value={ 2L,3L,2L,6L,4L,9L,5L,4L,15L,6L,10L,21L,11L,8L,9L,30L,11L,17L,36L,13L,20L,14L,12L,25L,51L,26L,54L,28L,9L,32L,22L,69L,14L,75L,26L,27L,41L,28L,29L,90L,19L,96L,49L,99L,17L,18L,56L,114L,58L,39L,120L,25L,42L,43L,44L,135L,46L,70L,141L,29L,21L,77L,156L,79L,23L,56L,34L,174L,88L,59L,45L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113710Inst : IEnumerable<long>
{
public static readonly long[] Value=A113710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113710.Bytes);
public long this[int i]=>Value[i];

public static A113710Inst Instance=new A113710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113711
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,11L,5L,1L,1L,51L,29L,7L,1L,1L,291L,189L,55L,9L,1L,1L,1955L,1373L,463L,89L,11L,1L,1L,14947L,11037L,4159L,921L,131L,13L,1L,1L,127203L,97565L,39871L,9945L,1611L,181L,15L,1L,1L,1188067L,942109L,408703L,112217L,20411L,2581L,239L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113711Inst : IEnumerable<long>
{
public static readonly long[] Value=A113711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113711.Bytes);
public long this[int i]=>Value[i];

public static A113711Inst Instance=new A113711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113712
{
public static readonly long[] Value={ 1L,3L,11L,51L,291L,1955L,14947L,127203L,1188067L,12063459L,132253411L,1557096163L,19600652003L,262792435427L,3740012173027L,56328120653539L,895281283880675L,14978332471744227L,263154416079230691L,4844530248867534563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113712Inst : IEnumerable<long>
{
public static readonly long[] Value=A113712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113712.Bytes);
public long this[int i]=>Value[i];

public static A113712Inst Instance=new A113712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113713
{
public static readonly long[] Value={ 1L,5L,29L,189L,1373L,11037L,97565L,942109L,9869853L,111475229L,1349927453L,17444868637L,239615283741L,3486244426269L,53566700311069L,866907958202909L,14742110756459037L,262857666867286557L,4904594355185832477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113713Inst : IEnumerable<long>
{
public static readonly long[] Value=A113713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113713.Bytes);
public long this[int i]=>Value[i];

public static A113713Inst Instance=new A113713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113714
{
public static readonly long[] Value={ 1L,7L,55L,463L,4159L,39871L,408703L,4484095L,52626943L,659428351L,8797030399L,124546033663L,1865317382143L,29463497922559L,489461328435199L,8530417847785471L,155621475302856703L,2965833596006389759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113714Inst : IEnumerable<long>
{
public static readonly long[] Value=A113714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113714.Bytes);
public long this[int i]=>Value[i];

public static A113714Inst Instance=new A113714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113715
{
public static readonly long[] Value={ 1L,2L,5L,18L,89L,546L,3893L,31210L,276393L,2674346L,28053749L,317122018L,3843832473L,49745582994L,684808185109L,9994279232186L,154164863607273L,2506527296803674L,42846740489105301L,768278266512841330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113715Inst : IEnumerable<long>
{
public static readonly long[] Value=A113715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113715.Bytes);
public long this[int i]=>Value[i];

public static A113715Inst Instance=new A113715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113716
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,22L,7L,1L,1L,157L,61L,10L,1L,1L,1372L,601L,118L,13L,1L,1L,14008L,6595L,1495L,193L,16L,1L,1L,161995L,79981L,20206L,3001L,286L,19L,1L,1L,2079994L,1065589L,291394L,48685L,5281L,397L,22L,1L,1L,29268778L,15495415L,4492621L,825313L,100456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113716Inst : IEnumerable<long>
{
public static readonly long[] Value=A113716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113716.Bytes);
public long this[int i]=>Value[i];

public static A113716Inst Instance=new A113716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113717
{
public static readonly ulong[] Value={ 1L,4L,22L,157L,1372L,14008L,161995L,2079994L,29268778L,447355381L,7378113658L,130623533086L,2471708825851L,49801573782382L,1064903759520232L,24092915169822295L,575151611909110366L,14450636276353406074UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113717Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A113717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113717.Bytes);
public ulong this[int i]=>Value[i];

public static A113717Inst Instance=new A113717Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113718
{
public static readonly ulong[] Value={ 1L,7L,61L,601L,6595L,79981L,1065589L,15495415L,244303729L,4150355713L,75565751587L,1467738869713L,30293536617097L,662150899215079L,15282101338843129L,371439268964362789L,9485239068692006047UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113718Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A113718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113718.Bytes);
public ulong this[int i]=>Value[i];

public static A113718Inst Instance=new A113718Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113719
{
public static readonly BigInteger[] Value={ 1L,2L,6L,31L,230L,2106L,22309L,265490L,3491364L,50191633L,782625062L,13155329058L,237183163807L,4566977815064L,93561632638164L,2032495366177429L,46677419939036132L,1130141423614269072L,BigInteger.Parse("28774960495683155947") };
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
public class A113719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113719Inst Instance=new A113719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113720
{
public static readonly long[] Value={ 1L,1L,2L,11L,12L,31L,1111L,15L,51L,121L,1211L,11212L,114111L,2111213L,21313111L,13111111113L,111114181L,118151111L,5111131114L,2111414131L,1413113111111L,131111111111216L,1111217110111L,13101114111213L,4111214111313111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113720Inst : IEnumerable<long>
{
public static readonly long[] Value=A113720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113720.Bytes);
public long this[int i]=>Value[i];

public static A113720Inst Instance=new A113720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113721
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,21L,112L,131L,11112L,1511L,21114L,131211L,21111131L,115121111L,41113151L,11113141112L,13111511131L,1131311131114L,13131113131311L,2111113111113131112L,13111515121111131111UL,BigInteger.Parse("41511111311131115151") };
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
public class A113721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113721Inst Instance=new A113721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113722
{
public static readonly long[] Value={ 1L,3L,5L,5L,5L,7L,7L,7L,7L,7L,9L,9L,9L,9L,9L,11L,11L,11L,11L,11L,13L,13L,13L,13L,13L,13L,13L,15L,15L,15L,15L,15L,15L,15L,17L,17L,17L,17L,17L,17L,17L,19L,19L,19L,19L,19L,19L,19L,21L,21L,21L,21L,21L,21L,21L,23L,23L,23L,23L,23L,23L,23L,23L,23L,25L,25L,25L,25L,25L,25L,25L,25L,25L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113722Inst : IEnumerable<long>
{
public static readonly long[] Value=A113722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113722.Bytes);
public long this[int i]=>Value[i];

public static A113722Inst Instance=new A113722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113723
{
public static readonly long[] Value={ 1L,1L,3L,15L,135L,3845L,769605L,3821696361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113723Inst : IEnumerable<long>
{
public static readonly long[] Value=A113723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113723.Bytes);
public long this[int i]=>Value[i];

public static A113723Inst Instance=new A113723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113724
{
public static readonly long[] Value={ 2L,4L,4L,6L,6L,6L,6L,8L,8L,8L,8L,10L,10L,10L,10L,10L,10L,12L,12L,12L,12L,12L,12L,14L,14L,14L,14L,14L,14L,16L,16L,16L,16L,16L,16L,18L,18L,18L,18L,18L,18L,18L,18L,20L,20L,20L,20L,20L,20L,20L,20L,22L,22L,22L,22L,22L,22L,22L,22L,24L,24L,24L,24L,24L,24L,24L,24L,26L,26L,26L,26L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113724Inst : IEnumerable<long>
{
public static readonly long[] Value=A113724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113724.Bytes);
public long this[int i]=>Value[i];

public static A113724Inst Instance=new A113724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113725
{
public static readonly long[] Value={ 1L,2L,8L,56L,984L,87848L,115679160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113725Inst : IEnumerable<long>
{
public static readonly long[] Value=A113725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113725.Bytes);
public long this[int i]=>Value[i];

public static A113725Inst Instance=new A113725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113726
{
public static readonly long[] Value={ 1L,0L,1L,4L,5L,8L,25L,44L,77L,176L,353L,660L,1365L,2776L,5417L,10876L,21981L,43648L,87153L,175076L,349669L,698280L,1398585L,2797260L,5590381L,11184720L,22373761L,44735284L,89474165L,178969208L,357910345L,715807004L,1431683837L,2863325216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113726Inst : IEnumerable<long>
{
public static readonly long[] Value=A113726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113726.Bytes);
public long this[int i]=>Value[i];

public static A113726Inst Instance=new A113726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113727
{
public static readonly long[] Value={ 1L,0L,4L,4L,17L,32L,88L,200L,497L,1184L,2876L,6924L,16737L,40384L,97520L,235408L,568353L,1372096L,3312564L,7997204L,19306993L,46611168L,112529352L,271669848L,655869073L,1583407968L,3822685036L,9228778012L,22280241089L,53789260160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113727Inst : IEnumerable<long>
{
public static readonly long[] Value=A113727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113727.Bytes);
public long this[int i]=>Value[i];

public static A113727Inst Instance=new A113727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113728
{
public static readonly long[] Value={ 3L,4L,6L,12L,12L,18L,18L,20L,24L,32L,40L,42L,42L,50L,48L,56L,64L,70L,72L,72L,80L,80L,84L,96L,102L,102L,108L,108L,126L,126L,130L,136L,144L,144L,152L,156L,160L,170L,168L,176L,180L,192L,192L,198L,210L,216L,224L,228L,228L,230L,240L,240L,256L,252L,264L,264L,272L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113728Inst : IEnumerable<long>
{
public static readonly long[] Value=A113728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113728.Bytes);
public long this[int i]=>Value[i];

public static A113728Inst Instance=new A113728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113729
{
public static readonly long[] Value={ 5L,8L,8L,10L,16L,20L,24L,24L,28L,36L,36L,40L,48L,48L,56L,56L,60L,72L,72L,72L,80L,90L,90L,98L,100L,104L,110L,120L,110L,120L,132L,144L,140L,144L,154L,160L,160L,176L,168L,180L,182L,192L,192L,198L,208L,224L,216L,230L,228L,240L,234L,252L,242L,252L,266L,266L,276L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113729Inst : IEnumerable<long>
{
public static readonly long[] Value=A113729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113729.Bytes);
public long this[int i]=>Value[i];

public static A113729Inst Instance=new A113729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113730
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,5L,5L,4L,4L,4L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,38L,38L,38L,38L,38L,38L,37L,37L,37L,37L,37L,37L,36L,36L,36L,36L,36L,36L,35L,35L,35L,35L,35L,35L,34L,34L,34L,34L,34L,34L,34L,33L,33L,33L,33L,33L,33L,33L,32L,32L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113730Inst : IEnumerable<long>
{
public static readonly long[] Value=A113730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113730.Bytes);
public long this[int i]=>Value[i];

public static A113730Inst Instance=new A113730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113731
{
public static readonly long[] Value={ 1L,1L,2L,6L,27L,225L,5273L,684632L,1490340903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113731Inst : IEnumerable<long>
{
public static readonly long[] Value=A113731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113731.Bytes);
public long this[int i]=>Value[i];

public static A113731Inst Instance=new A113731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113732
{
public static readonly long[] Value={ 1L,3L,5L,15L,22L,91L,187L,703L,1891L,2701L,12403L,18721L,38503L,49141L,79003L,88831L,104653L,146611L,188191L,218791L,226801L,269011L,286903L,385003L,497503L,597871L,665281L,721801L,736291L,765703L,873181L,954271L,1056331L,1314631L,1373653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113732Inst : IEnumerable<long>
{
public static readonly long[] Value=A113732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113732.Bytes);
public long this[int i]=>Value[i];

public static A113732Inst Instance=new A113732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113733
{
public static readonly long[] Value={ 1L,2L,4L,5L,11L,13L,33L,37L,61L,73L,157L,193L,277L,313L,397L,421L,457L,541L,613L,661L,673L,733L,757L,877L,997L,1093L,1153L,1201L,1213L,1237L,1321L,1381L,1453L,1621L,1657L,1753L,1873L,1933L,1993L,2017L,2137L,2341L,2473L,2557L,2593L,2797L,2857L,2917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113733Inst : IEnumerable<long>
{
public static readonly long[] Value=A113733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113733.Bytes);
public long this[int i]=>Value[i];

public static A113733Inst Instance=new A113733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113734
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,38L,263L,5536L,690168L,1491031071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113734Inst : IEnumerable<long>
{
public static readonly long[] Value=A113734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113734.Bytes);
public long this[int i]=>Value[i];

public static A113734Inst Instance=new A113734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113735
{
public static readonly long[] Value={ 1L,14L,17L,154L,1196L,26979L,66079L,279174L,1698619L,9397685L,302768895L,594963655L,2249805789L,6794867989L,9785759929L,75077778589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113735Inst : IEnumerable<long>
{
public static readonly long[] Value=A113735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113735.Bytes);
public long this[int i]=>Value[i];

public static A113735Inst Instance=new A113735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113736
{
public static readonly long[] Value={ 0L,1L,2L,11L,3L,22L,4L,23L,14L,24L,5L,34L,6L,25L,16L,26L,7L,36L,8L,27L,18L,28L,9L,38L,19L,29L,119L,39L,229L,49L,239L,68L,249L,59L,268L,69L,259L,88L,269L,79L,288L,89L,279L,189L,289L,99L,389L,199L,299L,1199L,399L,2299L,499L,2399L,689L,2499L,599L,2689L,699L,2599L,889L,2699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113736Inst : IEnumerable<long>
{
public static readonly long[] Value=A113736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113736.Bytes);
public long this[int i]=>Value[i];

public static A113736Inst Instance=new A113736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113737
{
public static readonly long[] Value={ 1L,3L,6L,6L,5L,7L,7L,1L,4L,0L,3L,9L,7L,5L,6L,6L,2L,7L,3L,7L,3L,4L,8L,0L,7L,0L,7L,4L,1L,0L,2L,8L,0L,3L,8L,8L,1L,0L,2L,6L,3L,9L,9L,2L,3L,9L,1L,9L,5L,5L,5L,9L,6L,1L,7L,4L,1L,4L,7L,8L,3L,0L,1L,7L,7L,7L,2L,7L,4L,2L,8L,7L,4L,7L,0L,4L,0L,5L,5L,2L,5L,1L,4L,4L,8L,7L,4L,4L,3L,4L,0L,5L,7L,4L,3L,3L,8L,6L,3L,5L,1L,2L,5L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113737Inst : IEnumerable<long>
{
public static readonly long[] Value=A113737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113737.Bytes);
public long this[int i]=>Value[i];

public static A113737Inst Instance=new A113737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113738
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,12L,22L,1L,1L,4L,4L,1L,2L,1L,3L,2L,2L,11L,1L,202L,1L,5L,1L,2L,1L,5L,1L,2L,1L,1L,1L,1L,3L,2L,1L,2L,2L,5L,2L,1L,1L,2L,1L,3L,1L,1L,15L,2L,1L,12L,1L,2L,2L,1L,1L,1L,2L,1L,3L,1L,2L,10L,1L,6L,5L,1L,2L,1L,2L,6L,1L,1L,2L,8L,2L,19L,3L,1L,1L,1L,2L,1L,1L,1L,5L,1L,2L,2L,1L,3L,1L,6L,12L,2L,4L,1L,5L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113738Inst : IEnumerable<long>
{
public static readonly long[] Value=A113738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113738.Bytes);
public long this[int i]=>Value[i];

public static A113738Inst Instance=new A113738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113739
{
public static readonly long[] Value={ 339738625L,10460353204L,83682825625L,669462604993L,2641807540225L,3761479876609L,7625597484988L,18075490334785L,35184372088833L,481469424205825L,488038239039169L,570630428688385L,1125899906842625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113739Inst : IEnumerable<long>
{
public static readonly long[] Value=A113739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113739.Bytes);
public long this[int i]=>Value[i];

public static A113739Inst Instance=new A113739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113740
{
public static readonly BigInteger[] Value={ 1999004627104432129L,4052555153018976268L,8754997675608244225L,9606056659007943745UL,11832592569282330625UL,BigInteger.Parse("22769912080611422209"),BigInteger.Parse("68309736241834266625"),BigInteger.Parse("354577405862133891073"),BigInteger.Parse("12449449430074295092225") };
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
public class A113740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113740Inst Instance=new A113740Inst();

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