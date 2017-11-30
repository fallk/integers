using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A246582
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,-1L,1L,-2L,1L,-3L,1L,-4L,2L,-5L,3L,-6L,5L,-7L,7L,-8L,10L,-10L,13L,-12L,17L,-15L,21L,-19L,26L,-24L,31L,-30L,38L,-38L,45L,-47L,54L,-58L,64L,-71L,77L,-86L,91L,-103L,109L,-124L,129L,-147L,154L,-174L,182L,-205L,216L,-241L,254L,-282L,300L,-330L,351L,-384L,412L,-447L,480L,-519L,560L,-602L,649L,-696L,753L,-805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246582Inst : IEnumerable<long>
{
public static readonly long[] Value=A246582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246582.Bytes);
public long this[int i]=>Value[i];

public static A246582Inst Instance=new A246582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246583
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,-1L,2L,-2L,3L,-4L,3L,-6L,5L,-9L,6L,-12L,10L,-16L,13L,-20L,20L,-26L,26L,-32L,37L,-41L,47L,-51L,63L,-65L,78L,-81L,101L,-103L,123L,-128L,155L,-161L,187L,-199L,232L,-247L,278L,-302L,341L,-371L,407L,-449L,495L,-545L,589L,-654L,711L,-786L,843L,-936L,1011L,-1116L,1194L,-1320L,1423L,-1563L,1674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246583Inst : IEnumerable<long>
{
public static readonly long[] Value=A246583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246583.Bytes);
public long this[int i]=>Value[i];

public static A246583Inst Instance=new A246583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246584
{
public static readonly long[] Value={ 1L,2L,6L,12L,26L,48L,92L,160L,282L,470L,784L,1260L,2020L,3152L,4896L,7456L,11290L,16836L,24962L,36556L,53232L,76736L,110012L,156384L,221156L,310482L,433776L,602200L,832224L,1143696L,1565088L,2131072L,2890266L,3902344L,5249356L,7032576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246584Inst : IEnumerable<long>
{
public static readonly long[] Value=A246584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246584.Bytes);
public long this[int i]=>Value[i];

public static A246584Inst Instance=new A246584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246585
{
public static readonly long[] Value={ 1L,12L,92L,470L,2020L,7456L,24962L,76736L,221156L,602200L,1565088L,3902344L,9389022L,21876192L,49542464L,109333520L,235717092L,497416856L,1029271544L,2091480776L,4179123296L,8220922592L,15937506968L,30477650240L,57540075230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246585Inst : IEnumerable<long>
{
public static readonly long[] Value=A246585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246585.Bytes);
public long this[int i]=>Value[i];

public static A246585Inst Instance=new A246585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246586
{
public static readonly long[] Value={ 2L,26L,160L,784L,3152L,11290L,36556L,110012L,310482L,832224L,2131072L,5249356L,12488368L,28816368L,64676460L,141598304L,303031202L,635197072L,1306210848L,2639071792L,5245173264L,10266881562L,19811351308L,37720810240L,70922550372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246586Inst : IEnumerable<long>
{
public static readonly long[] Value=A246586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246586.Bytes);
public long this[int i]=>Value[i];

public static A246586Inst Instance=new A246586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246587
{
public static readonly long[] Value={ 6L,48L,282L,1260L,4896L,16836L,53232L,156384L,433776L,1143696L,2890266L,7032576L,16557084L,37838052L,84206724L,182913216L,388685430L,809399280L,1654446816L,3323927340L,6572070528L,12801615744L,24590359284L,46619988384L,87302773392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246587Inst : IEnumerable<long>
{
public static readonly long[] Value=A246587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246587.Bytes);
public long this[int i]=>Value[i];

public static A246587Inst Instance=new A246587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246588
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246588Inst : IEnumerable<long>
{
public static readonly long[] Value=A246588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246588.Bytes);
public long this[int i]=>Value[i];

public static A246588Inst Instance=new A246588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246589
{
public static readonly long[] Value={ 1L,3L,8L,10L,12L,14L,21L,23L,25L,27L,34L,36L,38L,40L,45L,47L,49L,51L,58L,60L,62L,64L,69L,71L,73L,75L,82L,84L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246589Inst : IEnumerable<long>
{
public static readonly long[] Value=A246589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246589.Bytes);
public long this[int i]=>Value[i];

public static A246589Inst Instance=new A246589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246590
{
public static readonly long[] Value={ 6L,12L,14L,22L,24L,28L,30L,38L,44L,46L,48L,54L,56L,60L,62L,70L,76L,78L,86L,88L,92L,94L,96L,102L,108L,110L,112L,118L,120L,124L,126L,134L,140L,142L,150L,152L,156L,158L,166L,172L,174L,176L,182L,184L,188L,190L,192L,198L,204L,206L,214L,216L,220L,222L,224L,230L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246590Inst : IEnumerable<long>
{
public static readonly long[] Value=A246590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246590.Bytes);
public long this[int i]=>Value[i];

public static A246590Inst Instance=new A246590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246591
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,3L,3L,7L,1L,3L,3L,7L,5L,7L,7L,15L,1L,3L,3L,7L,5L,7L,7L,15L,9L,11L,11L,15L,13L,15L,15L,31L,1L,3L,3L,7L,5L,7L,7L,15L,9L,11L,11L,15L,13L,15L,15L,31L,17L,19L,19L,23L,21L,23L,23L,31L,25L,27L,27L,31L,29L,31L,31L,63L,1L,3L,3L,7L,5L,7L,7L,15L,9L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246591Inst : IEnumerable<long>
{
public static readonly long[] Value=A246591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246591.Bytes);
public long this[int i]=>Value[i];

public static A246591Inst Instance=new A246591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246592
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,3L,5L,7L,4L,5L,6L,7L,10L,11L,13L,15L,8L,9L,10L,11L,12L,13L,14L,15L,20L,21L,22L,23L,26L,27L,29L,31L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,40L,41L,42L,43L,44L,45L,46L,47L,52L,53L,54L,55L,58L,59L,61L,63L,32L,33L,34L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246592Inst : IEnumerable<long>
{
public static readonly long[] Value=A246592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246592.Bytes);
public long this[int i]=>Value[i];

public static A246592Inst Instance=new A246592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246593
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,6L,7L,8L,12L,12L,14L,12L,14L,14L,15L,16L,24L,24L,26L,24L,28L,28L,30L,24L,28L,28L,30L,28L,30L,30L,31L,32L,48L,48L,50L,48L,52L,52L,54L,48L,56L,56L,58L,56L,60L,60L,62L,48L,56L,56L,58L,56L,60L,60L,62L,56L,60L,60L,62L,60L,62L,62L,63L,64L,96L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246593Inst : IEnumerable<long>
{
public static readonly long[] Value=A246593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246593.Bytes);
public long this[int i]=>Value[i];

public static A246593Inst Instance=new A246593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246594
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,6L,7L,8L,10L,12L,13L,12L,14L,14L,15L,16L,18L,20L,21L,24L,25L,26L,27L,24L,26L,28L,29L,28L,30L,30L,31L,32L,34L,36L,37L,40L,41L,42L,43L,48L,49L,50L,51L,52L,53L,54L,55L,48L,50L,52L,53L,56L,57L,58L,59L,56L,58L,60L,61L,60L,62L,62L,63L,64L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246594Inst : IEnumerable<long>
{
public static readonly long[] Value=A246594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246594.Bytes);
public long this[int i]=>Value[i];

public static A246594Inst Instance=new A246594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246595
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,4L,9L,1L,1L,1L,4L,4L,4L,9L,16L,1L,1L,1L,4L,1L,1L,4L,9L,4L,4L,4L,16L,9L,9L,16L,25L,1L,1L,1L,4L,1L,1L,4L,9L,1L,1L,1L,4L,4L,4L,9L,16L,4L,4L,4L,16L,4L,4L,16L,36L,9L,9L,9L,36L,16L,16L,25L,36L,1L,1L,1L,4L,1L,1L,4L,9L,1L,1L,1L,4L,4L,4L,9L,16L,1L,1L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246595Inst : IEnumerable<long>
{
public static readonly long[] Value=A246595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246595.Bytes);
public long this[int i]=>Value[i];

public static A246595Inst Instance=new A246595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246596
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,5L,1L,1L,1L,2L,2L,2L,5L,14L,1L,1L,1L,2L,1L,1L,2L,5L,2L,2L,2L,4L,5L,5L,14L,42L,1L,1L,1L,2L,1L,1L,2L,5L,1L,1L,1L,2L,2L,2L,5L,14L,2L,2L,2L,4L,2L,2L,4L,10L,5L,5L,5L,10L,14L,14L,42L,132L,1L,1L,1L,2L,1L,1L,2L,5L,1L,1L,1L,2L,2L,2L,5L,14L,1L,1L,1L,2L,1L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246596Inst : IEnumerable<long>
{
public static readonly long[] Value=A246596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246596.Bytes);
public long this[int i]=>Value[i];

public static A246596Inst Instance=new A246596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246597
{
public static readonly long[] Value={ 1L,3L,6L,12L,22L,39L,78L,132L,269L,526L,1036L,2067L,4162L,8252L,16387L,32662L,65372L,130953L,262212L,524550L,1047850L,2097353L,4192505L,8384471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246597Inst : IEnumerable<long>
{
public static readonly long[] Value=A246597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246597.Bytes);
public long this[int i]=>Value[i];

public static A246597Inst Instance=new A246597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246598
{
public static readonly long[] Value={ 1L,4L,11L,60L,362L,2987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246598Inst : IEnumerable<long>
{
public static readonly long[] Value=A246598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246598.Bytes);
public long this[int i]=>Value[i];

public static A246598Inst Instance=new A246598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246599
{
public static readonly BigInteger[] Value={ 10L,840L,257040L,137214000L,118248530400L,154686980448000L,292276881344448000L,BigInteger.Parse("766864651478365440000"),BigInteger.Parse("2706292794907249067520000"),BigInteger.Parse("12512021073989410699165440000") };
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
public class A246599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246599Inst Instance=new A246599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246600
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,4L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,2L,2L,4L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,4L,2L,2L,4L,3L,2L,2L,2L,2L,4L,2L,2L,6L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,2L,4L,2L,3L,2L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246600Inst : IEnumerable<long>
{
public static readonly long[] Value=A246600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246600.Bytes);
public long this[int i]=>Value[i];

public static A246600Inst Instance=new A246600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246601
{
public static readonly long[] Value={ 1L,2L,4L,4L,6L,8L,8L,8L,10L,12L,12L,16L,14L,16L,24L,16L,18L,20L,20L,24L,22L,24L,24L,32L,26L,28L,40L,32L,30L,48L,32L,32L,34L,36L,36L,40L,38L,40L,43L,48L,42L,44L,44L,48L,60L,48L,48L,64L,50L,52L,72L,56L,54L,80L,61L,64L,58L,60L,60L,96L,62L,64L,104L,64L,66L,68L,68L,72L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246601Inst : IEnumerable<long>
{
public static readonly long[] Value=A246601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246601.Bytes);
public long this[int i]=>Value[i];

public static A246601Inst Instance=new A246601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246602
{
public static readonly long[] Value={ 1L,24L,2040L,297000L,68922000L,24038380800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246602Inst : IEnumerable<long>
{
public static readonly long[] Value=A246602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246602.Bytes);
public long this[int i]=>Value[i];

public static A246602Inst Instance=new A246602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246603
{
public static readonly long[] Value={ 1L,1L,7L,37L,37L,37L,37L,1423L,10987L,13297L,219277L,219277L,669463L,2215987L,7841563L,33376753L,54444163L,112545673L,267625087L,1676296087L,2772262903L,2782012963L,4341199657L,34694683237L,39965586763L,232265913427L,1879768081657L,1879768081657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246603Inst : IEnumerable<long>
{
public static readonly long[] Value=A246603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246603.Bytes);
public long this[int i]=>Value[i];

public static A246603Inst Instance=new A246603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246604
{
public static readonly long[] Value={ 1L,0L,0L,2L,10L,37L,126L,422L,1422L,4853L,16786L,58775L,208000L,742887L,2674426L,9694830L,35357654L,129644773L,477638682L,1767263171L,6564120400L,24466266999L,91482563618L,343059613627L,1289904147300L,4861946401427L,18367353072126L,69533550915977L,263747951750332L,1002242216651339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246604Inst : IEnumerable<long>
{
public static readonly long[] Value=A246604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246604.Bytes);
public long this[int i]=>Value[i];

public static A246604Inst Instance=new A246604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246605
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,81L,512L,729L,2401L,6561L,32768L,59049L,531441L,2097152L,4782969L,43046721L,134217728L,387420489L,3486784401L,31381059609L,282429536481L,2541865828329L,22876792454961L,205891132094649L,1853020188851841L,16677181699666569L,150094635296999121L,1350851717672992089L,12157665459056928801UL,BigInteger.Parse("109418989131512359209") };
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
public class A246605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246605Inst Instance=new A246605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246606
{
public static readonly BigInteger[] Value={ 1L,4L,78L,3216L,229080L,25022880L,3884393520L,812752093440L,220448163358080L,75225258805132800L,BigInteger.Parse("31537353006189676800"),BigInteger.Parse("15933924342019634227200"),BigInteger.Parse("9548252826112300306406400"),BigInteger.Parse("6695627848564821490753228800"),BigInteger.Parse("5431772705577464891946292992000") };
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
public class A246606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246606Inst Instance=new A246606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246607
{
public static readonly long[] Value={ 1L,1L,1L,-5L,-23L,-59L,241L,2311L,9745L,-30743L,-529919L,-3161069L,6984121L,216832045L,1696212337L,-2117117729L,-138721306079L,-1359994188719L,367573878145L,127713732858667L,1523067770484361L,1104033549399061L,-159815269852521359L,-2270787199743845705L,-3946710127731620303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246607Inst : IEnumerable<long>
{
public static readonly long[] Value=A246607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246607.Bytes);
public long this[int i]=>Value[i];

public static A246607Inst Instance=new A246607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246608
{
public static readonly long[] Value={ 1L,-2L,0L,0L,-6L,16L,0L,0L,8L,-50L,0L,0L,16L,80L,0L,0L,-38L,-96L,0L,0L,-16L,160L,0L,0L,48L,-242L,0L,0L,64L,240L,0L,0L,-56L,-288L,0L,0L,-150L,400L,0L,0L,112L,-384L,0L,0L,112L,496L,0L,0L,-112L,-674L,0L,0L,-80L,560L,0L,0L,160L,-672L,0L,0L,192L,880L,0L,0L,-294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246608Inst : IEnumerable<long>
{
public static readonly long[] Value=A246608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246608.Bytes);
public long this[int i]=>Value[i];

public static A246608Inst Instance=new A246608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246609
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,1L,0L,27L,6L,2L,0L,256L,57L,24L,6L,0L,3125L,680L,300L,120L,24L,0L,46656L,9945L,4480L,2160L,720L,120L,0L,823543L,172032L,78750L,41160L,17640L,5040L,720L,0L,16777216L,3438673L,1591296L,866460L,430080L,161280L,40320L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246609Inst : IEnumerable<long>
{
public static readonly long[] Value=A246609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246609.Bytes);
public long this[int i]=>Value[i];

public static A246609Inst Instance=new A246609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246610
{
public static readonly BigInteger[] Value={ 1L,0L,0L,2L,24L,300L,4480L,78750L,1591296L,36355256L,927244800L,26127386010L,806251494400L,27046291980708L,980094896062464L,38158333538165750L,1588601646620835840L,BigInteger.Parse("70427042234715548400"),BigInteger.Parse("3312574102411273437184"),BigInteger.Parse("164767312911755127462066"),BigInteger.Parse("8641342923227371929600000") };
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
public class A246610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246610Inst Instance=new A246610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246611
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,6L,120L,2160L,41160L,866460L,20294064L,526680000L,15036999120L,468848156040L,15859299473160L,578619457031616L,22654279249875000L,947570269816868880L,BigInteger.Parse("42174922731482980320"),BigInteger.Parse("1990416896317283627520"),BigInteger.Parse("99290011292792071612704"),BigInteger.Parse("5220362654145754082460000") };
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
public class A246611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246611Inst Instance=new A246611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246612
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,24L,720L,17640L,430080L,11022480L,302835456L,8976567600L,287236730880L,9901354268520L,366504424366080L,14515574208519384L,612912858447052800L,BigInteger.Parse("27497080096591516320"),BigInteger.Parse("1306520704652165775360"),BigInteger.Parse("65556843230110158804960"),BigInteger.Parse("3464412427539012262035456") };
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
public class A246612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246612Inst Instance=new A246612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246613
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,0L,120L,5040L,161280L,4898880L,151200000L,4870182240L,165589522560L,5970883913280L,228632817853440L,9292843409850000L,400385970127503360L,18252778818295082880UL,BigInteger.Parse("878619947953407528960"),BigInteger.Parse("44562094805330883023040"),BigInteger.Parse("2376296054962478899200000") };
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
public class A246613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246613Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246613.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246613Inst Instance=new A246613Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246614
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,0L,0L,720L,40320L,1632960L,60480000L,2213719200L,82771476480L,3211179491520L,130247609057280L,5542874078742000L,247828800444825600L,11643316737494682240UL,BigInteger.Parse("574455837701776343040"),BigInteger.Parse("29734324379435446505280"),BigInteger.Parse("1612668074301849600000000") };
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
public class A246614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246614Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246614.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246614Inst Instance=new A246614Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246615
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,5040L,362880L,18144000L,804988800L,34488115200L,1482082842240L,65120246231040L,2955402450000000L,139297568464454400L,6837892496270035200L,BigInteger.Parse("350034595015623598080"),BigInteger.Parse("18692451288585606954240"),BigInteger.Parse("1041114148173066240000000") };
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
public class A246615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246615Inst Instance=new A246615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246616
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,40320L,3628800L,219542400L,11496038400L,570031862400L,27908676956160L,1379187810000000L,69648048665395200L,3619848890071814400L,BigInteger.Parse("194428045753727385600"),BigInteger.Parse("10817313676715756770560"),BigInteger.Parse("624148118196535296000000"),BigInteger.Parse("37365232440634029661766400") };
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
public class A246616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246616Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246616.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246616Inst Instance=new A246616Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246617
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,362880L,39916800L,2874009600L,175394419200L,9967384627200L,551675124000000L,30471021291110400L,1703458301210265600L,BigInteger.Parse("97213825272736972800"),BigInteger.Parse("5693251850259515942400"),BigInteger.Parse("343266731083210449715200"),BigInteger.Parse("21349233350716392722764800") };
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
public class A246617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246617Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246617.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246617Inst Instance=new A246617Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246618
{
public static readonly BigInteger[] Value={ 1L,4L,57L,4480L,866460L,302835456L,165589522560L,130247609057280L,139297568464454400L,BigInteger.Parse("194428045753727385600"),BigInteger.Parse("343266731083210449715200"),BigInteger.Parse("747889980460943180326502400"),BigInteger.Parse("1971026081420013638259189350400"),BigInteger.Parse("6180432779330984921337015828480000") };
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
public class A246618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246618Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246618.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246618Inst Instance=new A246618Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246619
{
public static readonly BigInteger[] Value={ 1L,20L,1876L,229680L,31497284L,4600393936L,699440711760L,109341854545792L,17445620031680100L,2827280025640259280L,BigInteger.Parse("463882742476664594512"),BigInteger.Parse("76875122571167921990080"),BigInteger.Parse("12845419277094419018993808"),BigInteger.Parse("2161338658294952555703260480"),BigInteger.Parse("365816910931667192749720139072") };
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
public class A246619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246619Inst Instance=new A246619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246620
{
public static readonly BigInteger[] Value={ 1L,30L,4140L,738192L,146955276L,31113230148L,6851807953900L,1550766110966400L,358116337203378732L,BigInteger.Parse("83984165552626389864"),BigInteger.Parse("19937272615715693766528"),BigInteger.Parse("4779986445560522545646400"),BigInteger.Parse("1155414579663560935856564700"),BigInteger.Parse("281212253617692376239817669056") };
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
public class A246620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246620Inst Instance=new A246620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246621
{
public static readonly BigInteger[] Value={ 1L,42L,7986L,1950512L,530931786L,153580152492L,46190668836656L,14274134610246720L,4500027052542851130L,BigInteger.Parse("1440557297650459814996"),BigInteger.Parse("466776334221187994469180"),BigInteger.Parse("152741149363060061495819904"),BigInteger.Parse("50388989722150284436348268528"),BigInteger.Parse("16737346518387797143628281698720") };
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
public class A246621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246621Inst Instance=new A246621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246622
{
public static readonly long[] Value={ 2L,11L,23L,29L,41L,47L,67L,109L,89L,107L,101L,167L,181L,223L,199L,227L,251L,293L,283L,349L,331L,433L,347L,461L,313L,383L,353L,379L,431L,457L,379L,443L,521L,547L,457L,491L,593L,499L,557L,673L,601L,823L,619L,653L,839L,607L,617L,631L,659L,673L,659L,743L,929L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246622Inst : IEnumerable<long>
{
public static readonly long[] Value=A246622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246622.Bytes);
public long this[int i]=>Value[i];

public static A246622Inst Instance=new A246622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246623
{
public static readonly BigInteger[] Value={ 1L,1L,14L,9918L,964948464L,25071989721176760L,BigInteger.Parse("284751719071722748492598160"),BigInteger.Parse("2093930745462011336917616846237237197680"),BigInteger.Parse("13828562491398961948219629077212979214965847920914986240"),BigInteger.Parse("108581107327233631269616107897051314148463756259194308769323017769436778880") };
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
public class A246623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246623Inst Instance=new A246623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246624
{
public static readonly long[] Value={ 1L,2L,6L,22L,42L,1518L,5292L,7948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246624Inst : IEnumerable<long>
{
public static readonly long[] Value=A246624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246624.Bytes);
public long this[int i]=>Value[i];

public static A246624Inst Instance=new A246624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246625
{
public static readonly long[] Value={ 25L,323L,471L,2512L,1520900L,9320684L,10302650L,30713850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246625Inst : IEnumerable<long>
{
public static readonly long[] Value=A246625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246625.Bytes);
public long this[int i]=>Value[i];

public static A246625Inst Instance=new A246625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246626
{
public static readonly long[] Value={ 1L,3L,4L,44L,84L,304L,1236L,7144L,7628L,11502L,12732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246626Inst : IEnumerable<long>
{
public static readonly long[] Value=A246626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246626.Bytes);
public long this[int i]=>Value[i];

public static A246626Inst Instance=new A246626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246627
{
public static readonly long[] Value={ 11L,13L,37350L,40878L,77565L,2419530L,5311238L,5893650L,6809166L,12387704L,98376110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246627Inst : IEnumerable<long>
{
public static readonly long[] Value=A246627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246627.Bytes);
public long this[int i]=>Value[i];

public static A246627Inst Instance=new A246627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246628
{
public static readonly long[] Value={ 1L,2L,10L,635L,1810L,4502L,7598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246628Inst : IEnumerable<long>
{
public static readonly long[] Value=A246628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246628.Bytes);
public long this[int i]=>Value[i];

public static A246628Inst Instance=new A246628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246629
{
public static readonly long[] Value={ 153L,442L,145416L,174417L,499305L,826312L,1134378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246629Inst : IEnumerable<long>
{
public static readonly long[] Value=A246629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246629.Bytes);
public long this[int i]=>Value[i];

public static A246629Inst Instance=new A246629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246630
{
public static readonly long[] Value={ 344L,4016L,16064L,39208L,69430L,130250L,1028096L,1210928L,4843712L,16449536L,65798144L,309997568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246630Inst : IEnumerable<long>
{
public static readonly long[] Value=A246630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246630.Bytes);
public long this[int i]=>Value[i];

public static A246630Inst Instance=new A246630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246631
{
public static readonly long[] Value={ 1L,2L,4L,8L,6L,8L,8L,0L,12L,10L,8L,24L,8L,8L,16L,0L,6L,16L,12L,24L,24L,16L,8L,0L,24L,10L,24L,32L,0L,24L,16L,0L,12L,16L,16L,48L,30L,8L,24L,0L,24L,32L,16L,24L,24L,24L,16L,0L,8L,18L,28L,48L,24L,24L,32L,0L,48L,16L,8L,72L,0L,24L,32L,0L,6L,32L,32L,24L,48L,32L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246631Inst : IEnumerable<long>
{
public static readonly long[] Value=A246631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246631.Bytes);
public long this[int i]=>Value[i];

public static A246631Inst Instance=new A246631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246632
{
public static readonly BigInteger[] Value={ 1L,56L,14014L,4488180L,1600210950L,606021260768L,238569956361984L,96484621769643360L,BigInteger.Parse("39804374977976438550"),BigInteger.Parse("16673506088758905946560"),BigInteger.Parse("7069147910017295001150416"),BigInteger.Parse("3026650659542070433624365472"),BigInteger.Parse("1306409837754633649293171595680"),BigInteger.Parse("567753549048151735754482750312560") };
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
public class A246632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246632Inst Instance=new A246632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246633
{
public static readonly BigInteger[] Value={ 1L,72L,22920L,9314448L,4211047080L,2021601931776L,1008673456254640L,516987835463640000L,BigInteger.Parse("270280816277448460968"),BigInteger.Parse("143468491665604992744000"),BigInteger.Parse("77077894838606703430234560"),BigInteger.Parse("41816670323883372478262418912"),BigInteger.Parse("22870956616373890690700028823920") };
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
public class A246633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246633Inst Instance=new A246633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246634
{
public static readonly BigInteger[] Value={ 1L,90L,35496L,17841200L,9971182584L,5916327194316L,3648050813115800L,2310560873100793632L,BigInteger.Parse("1492663932178728961080"),BigInteger.Parse("979042561410295182717884"),BigInteger.Parse("649927612557635200254228312"),BigInteger.Parse("435681134491491690959679500160"),BigInteger.Parse("294430853393989822000413120805880") };
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
public class A246634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246634Inst Instance=new A246634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246635
{
public static readonly BigInteger[] Value={ 1L,110L,52630L,32050452L,21695031326L,15588534391688L,11639131492660980L,8926158067633260480L,BigInteger.Parse("6982075699637390684782"),BigInteger.Parse("5544869068478382127856796"),BigInteger.Parse("4456728497956906393963534248"),BigInteger.Parse("3617239034515121761037837277200"),BigInteger.Parse("2959687584848274006351647631119940") };
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
public class A246635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246635Inst Instance=new A246635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246636
{
public static readonly long[] Value={ 0L,1L,5L,17L,41L,125L,161L,377L,485L,881L,1457L,2645L,3077L,3941L,5417L,9197L,11825L,14405L,16757L,18521L,24965L,26405L,37337L,39365L,42461L,71441L,77657L,95921L,99077L,113777L,117305L,143261L,174761L,175445L,184841L,265481L,304037L,308825L,318401L,351917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246636Inst : IEnumerable<long>
{
public static readonly long[] Value=A246636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246636.Bytes);
public long this[int i]=>Value[i];

public static A246636Inst Instance=new A246636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246637
{
public static readonly BigInteger[] Value={ 1L,1L,3L,1533L,4870483401L,BigInteger.Parse("10632494904416274948861848751148863"),BigInteger.Parse("442778652527729430645666843207235634221292901"),BigInteger.Parse("8594831104112238244501123836952492157088005557663896974587707618787108"),BigInteger.Parse("970692073484990407927190417652798419153") };
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
public class A246637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246637Inst Instance=new A246637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246638
{
public static readonly long[] Value={ 5L,8L,17L,41L,104L,269L,701L,1832L,4793L,12545L,32840L,85973L,225077L,589256L,1542689L,4038809L,10573736L,27682397L,72473453L,189737960L,496740425L,1300483313L,3404709512L,8913645221L,23336226149L,61095033224L,159948873521L,418751587337L,1096305888488L,2870166078125L,7514192345885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246638Inst : IEnumerable<long>
{
public static readonly long[] Value=A246638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246638.Bytes);
public long this[int i]=>Value[i];

public static A246638Inst Instance=new A246638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246639
{
public static readonly long[] Value={ 8L,13L,28L,68L,173L,448L,1168L,3053L,7988L,20908L,54733L,143288L,375128L,982093L,2571148L,6731348L,17622893L,46137328L,120789088L,316229933L,827900708L,2167472188L,5674515853L,14856075368L,38893710248L,101825055373L,266581455868L,697919312228L,1827176480813L,4783610130208L,12523653909808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246639Inst : IEnumerable<long>
{
public static readonly long[] Value=A246639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246639.Bytes);
public long this[int i]=>Value[i];

public static A246639Inst Instance=new A246639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246640
{
public static readonly long[] Value={ 2L,3L,6L,14L,35L,90L,234L,611L,1598L,4182L,10947L,28658L,75026L,196419L,514230L,1346270L,3524579L,9227466L,24157818L,63245987L,165580142L,433494438L,1134903171L,2971215074L,7778742050L,20365011075L,53316291174L,139583862446L,365435296163L,956722026042L,2504730781962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246640Inst : IEnumerable<long>
{
public static readonly long[] Value=A246640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246640.Bytes);
public long this[int i]=>Value[i];

public static A246640Inst Instance=new A246640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246641
{
public static readonly BigInteger[] Value={ 1L,9L,153L,2737L,49105L,881145L,15811497L,283725793L,5091252769L,91358824041L,1639367579961L,29417257615249L,527871269494513L,9472265593285977L,169972909409653065L,3050040103780469185L,BigInteger.Parse("54730748958638792257"),BigInteger.Parse("982103441151717791433"),BigInteger.Parse("17623131191772281453529"),BigInteger.Parse("316234258010749348372081"),BigInteger.Parse("5674593513001715989243921") };
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
public class A246641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246641Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246641.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246641Inst Instance=new A246641Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246642
{
public static readonly BigInteger[] Value={ 1L,41L,761L,13681L,245521L,4405721L,79057481L,1418628961L,25456263841L,456794120201L,8196837899801L,147086288076241L,2639356347472561L,47361327966429881L,849864547048265321L,15250200518902345921UL,BigInteger.Parse("273653744793193961281"),BigInteger.Parse("4910517205758588957161"),BigInteger.Parse("88115655958861407267641") };
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
public class A246642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246642Inst Instance=new A246642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246643
{
public static readonly BigInteger[] Value={ 1L,10L,121L,1690L,25921L,420250L,7027801L,119508490L,2050368961L,35341836010L,610665665401L,10564982353210L,182902930753921L,3167536046903290L,54865571909148121L,950426408617182250L,16464857882672822401UL,BigInteger.Parse("285238628280432626890"),BigInteger.Parse("4941562979309619843961") };
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
public class A246643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246643Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246643.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246643Inst Instance=new A246643Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246644
{
public static readonly long[] Value={ 4L,4L,2L,4L,9L,3L,3L,3L,4L,0L,2L,4L,4L,4L,2L,1L,0L,3L,3L,2L,8L,1L,6L,5L,0L,1L,0L,6L,6L,4L,6L,9L,3L,3L,0L,3L,2L,7L,3L,7L,4L,7L,2L,8L,7L,7L,3L,2L,7L,8L,1L,6L,7L,6L,5L,7L,5L,4L,3L,6L,8L,8L,3L,2L,2L,3L,3L,0L,5L,6L,0L,9L,7L,0L,3L,4L,1L,9L,8L,9L,6L,5L,1L,4L,7L,1L,5L,8L,8L,3L,6L,0L,8L,6L,5L,5L,2L,8L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246644Inst : IEnumerable<long>
{
public static readonly long[] Value=A246644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246644.Bytes);
public long this[int i]=>Value[i];

public static A246644Inst Instance=new A246644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246645
{
public static readonly BigInteger[] Value={ 1L,22L,403L,7084L,123205L,2136706L,37027927L,641541208L,11114644489L,192557340910L,3335975296411L,57794311907332L,1001260862952013L,17346399720450394L,300518663950795615L,5206352229561021616L,BigInteger.Parse("90197737270328030737"),BigInteger.Parse("1562635689352773925318"),BigInteger.Parse("27071968446864455867299") };
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
public class A246645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246645Inst Instance=new A246645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246646
{
public static readonly long[] Value={ 2L,1L,3L,5L,8L,4L,2L,6L,3L,7L,11L,17L,26L,13L,20L,10L,5L,9L,14L,7L,12L,6L,15L,23L,35L,53L,80L,40L,20L,16L,8L,18L,9L,19L,29L,44L,22L,11L,21L,32L,16L,24L,12L,25L,38L,19L,27L,41L,62L,31L,47L,71L,107L,161L,242L,121L,182L,91L,137L,206L,103L,155L,233L,350L,175L,263L,395L,593L,890L,445L,668L,334L,167L,251L,377L,566L,283L,425L,638L,319L,479L,719L,1079L,1619L,2429L,3644L,1822L,911L,1367L,2051L,3077L,4616L,2308L,1154L,577L,866L,433L,650L,325L,488L,244L,122L,61L,92L,46L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246646Inst : IEnumerable<long>
{
public static readonly long[] Value=A246646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246646.Bytes);
public long this[int i]=>Value[i];

public static A246646Inst Instance=new A246646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246647
{
public static readonly long[] Value={ 2L,3L,6L,7L,9L,12L,15L,16L,18L,19L,21L,24L,25L,27L,28L,30L,33L,34L,36L,37L,39L,42L,43L,45L,48L,51L,52L,54L,55L,57L,60L,63L,64L,66L,69L,70L,72L,73L,75L,78L,79L,81L,82L,84L,87L,88L,90L,93L,96L,97L,99L,100L,102L,105L,106L,108L,109L,111L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246647Inst : IEnumerable<long>
{
public static readonly long[] Value=A246647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246647.Bytes);
public long this[int i]=>Value[i];

public static A246647Inst Instance=new A246647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246648
{
public static readonly long[] Value={ 0L,1L,7L,127L,227L,647L,1351L,1907L,3239L,4607L,5219L,5975L,11447L,13159L,13919L,21527L,22049L,23759L,23939L,24839L,30959L,31283L,31583L,31967L,32767L,37223L,46091L,46511L,47267L,60479L,65663L,66527L,78539L,78599L,81727L,82799L,84311L,98405L,102671L,103967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246648Inst : IEnumerable<long>
{
public static readonly long[] Value=A246648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246648.Bytes);
public long this[int i]=>Value[i];

public static A246648Inst Instance=new A246648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246649
{
public static readonly BigInteger[] Value={ 1L,1L,17L,BigInteger.Parse("1334440654591915542993625911497130241"),BigInteger.Parse("948042080603099421350928003060030968743284199473954197137709371401") };
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
public class A246649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246649Inst Instance=new A246649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246650
{
public static readonly long[] Value={ 1L,1L,-2L,0L,2L,-3L,-2L,0L,1L,2L,-2L,0L,2L,0L,-2L,0L,3L,2L,0L,0L,2L,-3L,-2L,0L,2L,2L,-2L,0L,0L,0L,-4L,0L,2L,1L,-2L,0L,2L,-6L,0L,0L,1L,2L,-2L,0L,4L,0L,-2L,0L,0L,2L,-2L,0L,2L,0L,-2L,0L,3L,2L,-2L,0L,2L,0L,0L,0L,2L,3L,-2L,0L,0L,-6L,-2L,0L,4L,0L,-2L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246650Inst : IEnumerable<long>
{
public static readonly long[] Value=A246650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246650.Bytes);
public long this[int i]=>Value[i];

public static A246650Inst Instance=new A246650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246651
{
public static readonly long[] Value={ 10L,7L,3L,6L,9L,2L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246651Inst : IEnumerable<long>
{
public static readonly long[] Value=A246651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246651.Bytes);
public long this[int i]=>Value[i];

public static A246651Inst Instance=new A246651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246652
{
public static readonly long[] Value={ 1L,1L,4L,11L,47L,172L,725L,2945L,12592L,53607L,233115L,1017428L,4488097L,19893325L,88746008L,397610355L,1789394067L,8081593288L,36622787565L,166442457597L,758467464848L,3464526761611L,15859854880999L,72747086739548L,334290271569069L,1538717057137809L,7093579418490760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246652Inst : IEnumerable<long>
{
public static readonly long[] Value=A246652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246652.Bytes);
public long this[int i]=>Value[i];

public static A246652Inst Instance=new A246652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246653
{
public static readonly long[] Value={ 1L,1L,3L,9L,25L,87L,287L,993L,3519L,12525L,45369L,165519L,608569L,2253307L,8386575L,31370297L,117834837L,444258387L,1680516731L,6375706325L,24253227159L,92481509389L,353417696625L,1353280137975L,5191349266275L,19948136148837L,76771074483837L,295880290515411L,1141860205058433L,4412129801125275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246653Inst : IEnumerable<long>
{
public static readonly long[] Value=A246653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246653.Bytes);
public long this[int i]=>Value[i];

public static A246653Inst Instance=new A246653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246654
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,3L,2L,1L,0L,10L,7L,3L,1L,0L,43L,30L,13L,4L,1L,0L,225L,157L,68L,21L,5L,1L,0L,1393L,972L,421L,130L,31L,6L,1L,0L,9976L,6961L,3015L,931L,222L,43L,7L,1L,0L,81201L,56660L,24541L,7578L,1807L,350L,57L,8L,1L,0L,740785L,516901L,223884L,69133L,16485L,3193L,520L,73L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246654Inst : IEnumerable<long>
{
public static readonly long[] Value=A246654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246654.Bytes);
public long this[int i]=>Value[i];

public static A246654Inst Instance=new A246654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246655
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,16L,17L,19L,23L,25L,27L,29L,31L,32L,37L,41L,43L,47L,49L,53L,59L,61L,64L,67L,71L,73L,79L,81L,83L,89L,97L,101L,103L,107L,109L,113L,121L,125L,127L,128L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246655Inst : IEnumerable<long>
{
public static readonly long[] Value=A246655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246655.Bytes);
public long this[int i]=>Value[i];

public static A246655Inst Instance=new A246655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246656
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,0L,0L,3L,0L,-1L,0L,1L,0L,1L,8L,5L,-5L,0L,3L,1L,0L,0L,-18L,0L,29L,0L,-8L,0L,1L,0L,1L,-80L,-13L,121L,29L,-35L,-7L,4L,1L,0L,0L,357L,0L,-513L,0L,182L,0L,-22L,0L,1L,0L,1L,1865L,344L,-2686L,-484L,945L,175L,-114L,-21L,5L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246656Inst : IEnumerable<long>
{
public static readonly long[] Value=A246656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246656.Bytes);
public long this[int i]=>Value[i];

public static A246656Inst Instance=new A246656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246657
{
public static readonly long[] Value={ 0L,1L,3L,7L,24L,87L,332L,1320L,5407L,22672L,96844L,419910L,1843386L,8176962L,36594388L,165026353L,749170529L,3420949803L,15702232962L,72407225094L,335276107549L,1558289108596L,7267201176311L,33996105203757L,159484982985619L,750134031377432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246657Inst : IEnumerable<long>
{
public static readonly long[] Value=A246657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246657.Bytes);
public long this[int i]=>Value[i];

public static A246657Inst Instance=new A246657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246658
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,9L,4L,1L,0L,56L,25L,6L,1L,0L,457L,204L,49L,8L,1L,0L,4626L,2065L,496L,81L,10L,1L,0L,55969L,24984L,6001L,980L,121L,12L,1L,0L,788192L,351841L,84510L,13801L,1704L,169L,14L,1L,0L,12667041L,5654440L,1358161L,221796L,27385L,2716L,225L,16L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246658Inst : IEnumerable<long>
{
public static readonly long[] Value=A246658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246658.Bytes);
public long this[int i]=>Value[i];

public static A246658Inst Instance=new A246658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246659
{
public static readonly long[] Value={ 1L,1L,3L,7L,9L,28L,95L,306L,285L,1071L,3948L,14148L,11844L,47160L,182655L,690580L,547965L,2244385L,8961953L,35016345L,26885859L,112052304L,456606332L,1824478488L,1369818996L,5777515212L,23884958520L,97002706248L,71654875560L,304865648208L,1273989485439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246659Inst : IEnumerable<long>
{
public static readonly long[] Value=A246659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246659.Bytes);
public long this[int i]=>Value[i];

public static A246659Inst Instance=new A246659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246660
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,2L,2L,6L,24L,1L,1L,1L,2L,1L,1L,2L,6L,2L,2L,2L,4L,6L,6L,24L,120L,1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,2L,2L,6L,24L,2L,2L,2L,4L,2L,2L,4L,12L,6L,6L,6L,12L,24L,24L,120L,720L,1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,2L,2L,6L,24L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246660Inst : IEnumerable<long>
{
public static readonly long[] Value=A246660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246660.Bytes);
public long this[int i]=>Value[i];

public static A246660Inst Instance=new A246660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246661
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,2L,2L,6L,6L,1L,1L,1L,2L,1L,1L,2L,6L,2L,2L,2L,4L,6L,6L,6L,30L,1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,2L,2L,6L,6L,2L,2L,2L,4L,2L,2L,4L,12L,6L,6L,6L,12L,6L,6L,30L,20L,1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,2L,2L,6L,6L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246661Inst : IEnumerable<long>
{
public static readonly long[] Value=A246661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246661.Bytes);
public long this[int i]=>Value[i];

public static A246661Inst Instance=new A246661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246662
{
public static readonly BigInteger[] Value={ -10L,7L,-3L,1L,0L,1L,5L,31L,222L,1807L,16485L,166657L,1849712L,22363201L,292571325L,4118361751L,62067997590L,997206323191L,17014575491837L,307259565176257L,5854946313840720L,117406185841990657L,2471384848995644517L,BigInteger.Parse("54487872863746170031"),BigInteger.Parse("1255692460715157555230") };
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
public class A246662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246662Inst Instance=new A246662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246663
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,20L,24L,30L,32L,36L,40L,48L,60L,64L,70L,72L,80L,96L,120L,128L,140L,144L,160L,180L,192L,216L,240L,252L,256L,280L,288L,320L,360L,384L,400L,420L,432L,480L,504L,512L,560L,576L,600L,630L,640L,720L,768L,800L,840L,864L,900L,960L,1008L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246663Inst : IEnumerable<long>
{
public static readonly long[] Value=A246663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246663.Bytes);
public long this[int i]=>Value[i];

public static A246663Inst Instance=new A246663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246664
{
public static readonly long[] Value={ 2L,1L,1L,9L,8L,2L,4L,4L,0L,9L,8L,9L,2L,0L,6L,3L,6L,4L,9L,4L,6L,4L,0L,0L,5L,3L,8L,3L,0L,0L,7L,4L,0L,9L,1L,5L,4L,5L,5L,4L,4L,6L,3L,9L,6L,3L,2L,5L,3L,4L,1L,9L,8L,5L,4L,0L,9L,2L,0L,2L,7L,5L,4L,2L,6L,7L,6L,2L,7L,7L,4L,3L,8L,7L,1L,8L,5L,4L,8L,7L,9L,8L,2L,3L,9L,8L,7L,3L,8L,6L,2L,6L,6L,3L,0L,3L,2L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246664Inst : IEnumerable<long>
{
public static readonly long[] Value=A246664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246664.Bytes);
public long this[int i]=>Value[i];

public static A246664Inst Instance=new A246664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246665
{
public static readonly long[] Value={ 4L,3L,5L,1L,7L,0L,8L,0L,5L,5L,8L,0L,1L,2L,7L,6L,5L,8L,0L,5L,9L,1L,8L,9L,9L,1L,2L,8L,4L,7L,8L,5L,8L,4L,1L,0L,4L,2L,7L,9L,6L,2L,5L,9L,4L,7L,5L,3L,4L,7L,0L,2L,4L,7L,0L,2L,9L,7L,9L,1L,2L,3L,0L,4L,4L,3L,9L,0L,6L,6L,5L,8L,7L,5L,4L,4L,3L,0L,3L,3L,5L,7L,8L,4L,9L,9L,7L,6L,6L,2L,8L,6L,8L,5L,0L,2L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246665Inst : IEnumerable<long>
{
public static readonly long[] Value=A246665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246665.Bytes);
public long this[int i]=>Value[i];

public static A246665Inst Instance=new A246665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246666
{
public static readonly long[] Value={ 1L,3L,5L,9L,31L,43L,45L,51L,71L,89L,135L,141L,145L,149L,159L,163L,169L,183L,185L,225L,233L,241L,255L,261L,271L,281L,283L,285L,299L,309L,311L,313L,355L,395L,401L,411L,415L,423L,429L,435L,449L,453L,485L,491L,541L,551L,561L,579L,583L,589L,603L,621L,625L,635L,681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246666Inst : IEnumerable<long>
{
public static readonly long[] Value=A246666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246666.Bytes);
public long this[int i]=>Value[i];

public static A246666Inst Instance=new A246666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246667
{
public static readonly long[] Value={ 1L,3L,4L,5L,0L,1L,6L,6L,1L,7L,0L,2L,1L,9L,9L,6L,9L,8L,4L,4L,9L,0L,5L,7L,9L,9L,1L,9L,9L,9L,8L,6L,9L,1L,5L,0L,1L,5L,3L,8L,7L,5L,8L,4L,2L,0L,6L,0L,6L,3L,6L,7L,5L,4L,1L,6L,2L,8L,7L,2L,6L,1L,0L,5L,7L,9L,1L,3L,1L,4L,6L,4L,9L,5L,5L,9L,7L,2L,0L,5L,8L,8L,3L,9L,0L,5L,8L,1L,8L,7L,3L,7L,8L,3L,8L,9L,8L,6L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246667Inst : IEnumerable<long>
{
public static readonly long[] Value=A246667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246667.Bytes);
public long this[int i]=>Value[i];

public static A246667Inst Instance=new A246667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246668
{
public static readonly long[] Value={ 4L,4L,9L,2L,4L,7L,2L,1L,8L,8L,6L,9L,2L,1L,6L,2L,7L,1L,2L,2L,9L,8L,7L,9L,3L,9L,4L,3L,7L,9L,7L,0L,9L,2L,6L,7L,5L,0L,4L,8L,5L,8L,7L,3L,6L,3L,6L,9L,4L,5L,9L,4L,6L,4L,8L,6L,8L,4L,1L,3L,7L,4L,7L,6L,4L,4L,9L,3L,5L,5L,5L,8L,6L,7L,2L,6L,3L,2L,6L,4L,2L,4L,5L,5L,4L,8L,0L,4L,3L,7L,2L,7L,6L,8L,7L,6L,8L,4L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246668Inst : IEnumerable<long>
{
public static readonly long[] Value=A246668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246668.Bytes);
public long this[int i]=>Value[i];

public static A246668Inst Instance=new A246668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246669
{
public static readonly BigInteger[] Value={ 2L,5L,42L,429L,58786L,742900L,129644790L,1767263190L,343059613650L,1002242216651368L,14544636039226909L,BigInteger.Parse("45950804324621742364"),BigInteger.Parse("10113918591637898134020"),BigInteger.Parse("150853479205085351660700"),BigInteger.Parse("33868773757191046886429490"),BigInteger.Parse("116157871455782434250553845880") };
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
public class A246669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246669Inst Instance=new A246669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246670
{
public static readonly long[] Value={ 2L,2L,3L,11L,43L,181L,743L,2971L,11933L,47129L,185569L,729947L,2868191L,11265517L,44230699L,173632489L,681785497L,2677741049L,10520707411L,41351166313L,162595828093L,639609298351L,2517120334919L,9910036308649L,39032346154387L,153796890460823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246670Inst : IEnumerable<long>
{
public static readonly long[] Value=A246670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246670.Bytes);
public long this[int i]=>Value[i];

public static A246670Inst Instance=new A246670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246671
{
public static readonly long[] Value={ 8L,3L,9L,9L,2L,3L,6L,7L,5L,6L,9L,2L,3L,7L,2L,6L,8L,9L,6L,0L,3L,7L,7L,6L,9L,7L,7L,4L,2L,1L,8L,1L,5L,5L,6L,9L,3L,6L,1L,6L,2L,0L,6L,9L,8L,7L,0L,3L,9L,1L,2L,8L,5L,0L,4L,1L,5L,8L,2L,7L,2L,1L,6L,3L,6L,0L,9L,0L,8L,9L,6L,8L,6L,3L,9L,5L,3L,4L,6L,3L,8L,0L,6L,3L,8L,8L,0L,2L,0L,9L,6L,4L,6L,8L,0L,9L,7L,9L,9L,9L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246671Inst : IEnumerable<long>
{
public static readonly long[] Value=A246671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246671.Bytes);
public long this[int i]=>Value[i];

public static A246671Inst Instance=new A246671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246672
{
public static readonly long[] Value={ 2L,7L,9L,3L,9L,9L,7L,6L,5L,2L,6L,0L,1L,5L,5L,0L,7L,9L,6L,0L,9L,9L,0L,7L,1L,1L,4L,1L,3L,6L,6L,8L,5L,0L,4L,2L,5L,8L,0L,0L,8L,3L,9L,1L,1L,6L,6L,2L,7L,3L,4L,2L,1L,1L,6L,1L,3L,5L,1L,5L,9L,8L,3L,1L,5L,4L,4L,3L,6L,3L,6L,4L,8L,8L,8L,9L,2L,8L,6L,8L,3L,5L,6L,2L,1L,1L,7L,4L,5L,6L,8L,8L,4L,2L,9L,1L,3L,5L,6L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246672Inst : IEnumerable<long>
{
public static readonly long[] Value=A246672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246672.Bytes);
public long this[int i]=>Value[i];

public static A246672Inst Instance=new A246672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246673
{
public static readonly long[] Value={ 1L,1L,6L,5L,6L,2L,3L,2L,8L,7L,7L,3L,1L,6L,2L,2L,7L,7L,2L,0L,8L,2L,1L,5L,2L,0L,2L,1L,1L,0L,7L,5L,4L,0L,4L,0L,8L,2L,5L,5L,4L,9L,1L,3L,4L,5L,9L,6L,3L,3L,4L,2L,1L,0L,3L,0L,1L,9L,0L,0L,5L,3L,3L,6L,8L,9L,2L,2L,1L,4L,1L,5L,7L,7L,7L,7L,3L,4L,1L,2L,0L,7L,5L,2L,0L,1L,9L,1L,9L,6L,4L,8L,9L,9L,2L,5L,5L,9L,9L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246673Inst : IEnumerable<long>
{
public static readonly long[] Value=A246673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246673.Bytes);
public long this[int i]=>Value[i];

public static A246673Inst Instance=new A246673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246674
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,7L,1L,1L,1L,3L,3L,3L,7L,15L,1L,1L,1L,3L,1L,1L,3L,7L,3L,3L,3L,9L,7L,7L,15L,31L,1L,1L,1L,3L,1L,1L,3L,7L,1L,1L,1L,3L,3L,3L,7L,15L,3L,3L,3L,9L,3L,3L,9L,21L,7L,7L,7L,21L,15L,15L,31L,63L,1L,1L,1L,3L,1L,1L,3L,7L,1L,1L,1L,3L,3L,3L,7L,15L,1L,1L,1L,3L,1L,1L,3L,7L,3L,3L,3L,9L,7L,7L,15L,31L,3L,3L,3L,9L,3L,3L,9L,21L,3L,3L,3L,9L,9L,9L,21L,45L,7L,7L,7L,21L,7L,7L,21L,49L,15L,15L,15L,45L,31L,31L,63L,127L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246674Inst : IEnumerable<long>
{
public static readonly long[] Value=A246674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246674.Bytes);
public long this[int i]=>Value[i];

public static A246674Inst Instance=new A246674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246675
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,16L,11L,32L,13L,10L,15L,64L,17L,128L,19L,18L,21L,256L,23L,12L,25L,14L,27L,512L,29L,1024L,31L,26L,33L,20L,35L,2048L,37L,42L,39L,4096L,41L,8192L,43L,22L,45L,16384L,47L,24L,49L,50L,51L,32768L,53L,36L,55L,66L,57L,65536L,59L,131072L,61L,38L,63L,52L,65L,262144L,67L,74L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246675Inst : IEnumerable<long>
{
public static readonly long[] Value=A246675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246675.Bytes);
public long this[int i]=>Value[i];

public static A246675Inst Instance=new A246675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246676
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,14L,11L,24L,13L,26L,15L,10L,17L,20L,19L,34L,21L,44L,23L,48L,25L,32L,27L,124L,29L,80L,31L,12L,33L,74L,35L,54L,37L,62L,39L,76L,41L,38L,43L,174L,45L,134L,47L,120L,49L,50L,51L,64L,53L,98L,55L,342L,57L,104L,59L,624L,61L,242L,63L,16L,65L,56L,67L,244L,69L,224L,71L,90L,73L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246676Inst : IEnumerable<long>
{
public static readonly long[] Value=A246676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246676.Bytes);
public long this[int i]=>Value[i];

public static A246676Inst Instance=new A246676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246677
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,16L,11L,32L,17L,10L,15L,64L,13L,128L,19L,18L,33L,256L,23L,12L,65L,14L,35L,512L,21L,1024L,31L,26L,129L,20L,27L,2048L,257L,42L,39L,4096L,37L,8192L,67L,22L,513L,16384L,47L,24L,25L,50L,131L,32768L,29L,36L,71L,66L,1025L,65536L,43L,131072L,2049L,38L,63L,52L,53L,262144L,259L,74L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246677Inst : IEnumerable<long>
{
public static readonly long[] Value=A246677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246677.Bytes);
public long this[int i]=>Value[i];

public static A246677Inst Instance=new A246677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246678
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,14L,11L,24L,17L,26L,15L,10L,13L,20L,19L,34L,29L,44L,23L,48L,49L,32L,35L,124L,53L,80L,31L,12L,21L,74L,27L,54L,41L,62L,39L,76L,69L,38L,59L,174L,89L,134L,47L,120L,97L,50L,99L,64L,65L,98L,71L,342L,249L,104L,107L,624L,161L,242L,63L,16L,25L,56L,43L,244L,149L,224L,55L,90L,109L,68L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246678Inst : IEnumerable<long>
{
public static readonly long[] Value=A246678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246678.Bytes);
public long this[int i]=>Value[i];

public static A246678Inst Instance=new A246678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246679
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,16L,5L,32L,64L,9L,128L,6L,7L,256L,512L,13L,10L,1024L,21L,2048L,4096L,11L,8192L,12L,25L,16384L,18L,33L,32768L,65536L,19L,26L,131072L,37L,262144L,524288L,17L,20L,1048576L,15L,2097152L,42L,45L,4194304L,36L,57L,50L,8388608L,27L,16777216L,33554432L,29L,67108864L,134217728L,61L,268435456L,66L,43L,52L,24L,73L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246679Inst : IEnumerable<long>
{
public static readonly long[] Value=A246679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246679.Bytes);
public long this[int i]=>Value[i];

public static A246679Inst Instance=new A246679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246680
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,12L,13L,5L,10L,17L,22L,24L,16L,62L,40L,6L,37L,27L,31L,38L,19L,87L,67L,60L,25L,32L,49L,171L,52L,312L,121L,8L,28L,122L,112L,45L,34L,137L,94L,71L,82L,42L,58L,269L,43L,437L,202L,84L,73L,47L,76L,59L,187L,162L,148L,665L,46L,192L,157L,1200L,55L,1562L,364L,9L,97L,57L,85L,423L,115L,612L,337L,93L,61L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246680Inst : IEnumerable<long>
{
public static readonly long[] Value=A246680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246680.Bytes);
public long this[int i]=>Value[i];

public static A246680Inst Instance=new A246680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246681
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,9L,10L,8L,14L,11L,12L,15L,18L,20L,16L,25L,28L,21L,22L,24L,30L,27L,36L,40L,32L,50L,56L,33L,42L,13L,44L,48L,60L,54L,72L,45L,80L,64L,100L,35L,112L,75L,66L,84L,26L,63L,88L,96L,120L,108L,144L,81L,90L,160L,128L,200L,70L,49L,224L,99L,150L,132L,168L,52L,126L,55L,176L,192L,240L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246681Inst : IEnumerable<long>
{
public static readonly long[] Value=A246681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246681.Bytes);
public long this[int i]=>Value[i];

public static A246681Inst Instance=new A246681Inst();

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