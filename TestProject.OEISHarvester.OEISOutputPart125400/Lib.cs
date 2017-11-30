using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A154705
{
public static readonly long[] Value={ 9L,0L,3L,9L,6L,9L,3L,6L,5L,0L,2L,2L,5L,6L,6L,2L,8L,0L,3L,8L,5L,4L,1L,1L,7L,4L,0L,4L,6L,4L,0L,5L,1L,6L,6L,1L,8L,1L,3L,8L,3L,7L,4L,1L,6L,1L,8L,5L,2L,0L,0L,3L,4L,4L,6L,0L,9L,7L,5L,1L,9L,8L,9L,0L,4L,7L,8L,9L,7L,5L,8L,8L,8L,7L,1L,2L,5L,2L,3L,3L,9L,9L,5L,0L,8L,7L,4L,7L,6L,9L,6L,9L,4L,8L,9L,8L,5L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154705Inst : IEnumerable<long>
{
public static readonly long[] Value=A154705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154705.Bytes);
public long this[int i]=>Value[i];

public static A154705Inst Instance=new A154705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154706
{
public static readonly long[] Value={ 1L,13L,13L,118L,228L,118L,846L,3234L,3234L,846L,5279L,38932L,63258L,38932L,5279L,30339L,405927L,1082454L,1082454L,405927L,30339L,165820L,3796728L,16512132L,24852880L,16512132L,3796728L,165820L,878188L,32837380L,226681452L,509876260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154706Inst : IEnumerable<long>
{
public static readonly long[] Value=A154706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154706.Bytes);
public long this[int i]=>Value[i];

public static A154706Inst Instance=new A154706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154707
{
public static readonly long[] Value={ 8L,8L,9L,4L,8L,2L,7L,5L,3L,5L,3L,3L,9L,7L,8L,2L,3L,7L,8L,8L,1L,1L,3L,9L,0L,4L,9L,5L,6L,3L,4L,2L,5L,1L,7L,4L,1L,0L,3L,3L,5L,1L,6L,1L,1L,0L,8L,5L,4L,5L,8L,0L,3L,4L,1L,1L,8L,7L,6L,3L,7L,9L,8L,1L,3L,1L,9L,0L,8L,2L,3L,3L,2L,8L,3L,3L,9L,8L,5L,0L,4L,5L,8L,7L,3L,7L,3L,4L,8L,7L,7L,6L,8L,4L,5L,7L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154707Inst : IEnumerable<long>
{
public static readonly long[] Value=A154707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154707.Bytes);
public long this[int i]=>Value[i];

public static A154707Inst Instance=new A154707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154708
{
public static readonly long[] Value={ 3L,4L,7L,8L,11L,12L,15L,16L,19L,20L,23L,24L,27L,28L,31L,32L,35L,36L,39L,40L,43L,44L,47L,48L,51L,52L,55L,56L,59L,60L,63L,64L,67L,68L,71L,72L,75L,76L,79L,80L,83L,84L,87L,88L,91L,92L,95L,96L,99L,100L,103L,104L,107L,108L,111L,112L,115L,116L,119L,120L,123L,124L,127L,128L,131L,132L,135L,136L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154708Inst : IEnumerable<long>
{
public static readonly long[] Value=A154708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154708.Bytes);
public long this[int i]=>Value[i];

public static A154708Inst Instance=new A154708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154709
{
public static readonly long[] Value={ 2146689L,6751269L,50243409L,82312875L,165469149L,170953875L,176558481L,549353259L,1929781125L,3314613771L,5079577959L,5630252139L,6219352719L,6591796875L,7245075375L,10289109375L,11993263569L,14084823375L,14724139851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154709Inst : IEnumerable<long>
{
public static readonly long[] Value=A154709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154709.Bytes);
public long this[int i]=>Value[i];

public static A154709Inst Instance=new A154709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154710
{
public static readonly long[] Value={ 8L,64L,4096L,17576L,405224L,1191016L,1906624L,6229504L,6859000L,11239424L,21952000L,68921000L,103823000L,122023936L,254840104L,267089984L,445943744L,449455096L,681472000L,719323136L,1427628376L,1710777536L,2887553024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154710Inst : IEnumerable<long>
{
public static readonly long[] Value=A154710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154710.Bytes);
public long this[int i]=>Value[i];

public static A154710Inst Instance=new A154710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154711
{
public static readonly long[] Value={ 36L,144L,1296L,5184L,6084L,28224L,39204L,41616L,116964L,186624L,207936L,242064L,285156L,345744L,352836L,443556L,527076L,571536L,617796L,646416L,992016L,1028196L,1468944L,1483524L,1557504L,1572516L,1602756L,1726596L,1806336L,2178576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154711Inst : IEnumerable<long>
{
public static readonly long[] Value=A154711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154711.Bytes);
public long this[int i]=>Value[i];

public static A154711Inst Instance=new A154711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154712
{
public static readonly long[] Value={ 1L,2L,6L,12L,13L,28L,33L,34L,57L,72L,76L,82L,89L,98L,99L,111L,121L,126L,131L,134L,166L,169L,202L,203L,208L,209L,211L,219L,224L,246L,252L,259L,301L,302L,317L,348L,383L,387L,394L,436L,439L,511L,512L,527L,572L,574L,642L,666L,667L,677L,726L,763L,769L,779L,792L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154712Inst : IEnumerable<long>
{
public static readonly long[] Value=A154712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154712.Bytes);
public long this[int i]=>Value[i];

public static A154712Inst Instance=new A154712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154713
{
public static readonly long[] Value={ 8L,1728L,110592L,287496L,474552L,2000376L,7077888L,34012224L,191102976L,401947272L,631628712L,5890514616L,14996130696L,15550119936L,19421724672L,32339798856L,35158608576L,62949797352L,68518346688L,76657300992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154713Inst : IEnumerable<long>
{
public static readonly long[] Value=A154713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154713.Bytes);
public long this[int i]=>Value[i];

public static A154713Inst Instance=new A154713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154714
{
public static readonly long[] Value={ 3L,4L,8L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154714Inst : IEnumerable<long>
{
public static readonly long[] Value=A154714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154714.Bytes);
public long this[int i]=>Value[i];

public static A154714Inst Instance=new A154714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154715
{
public static readonly long[] Value={ 1L,2L,3L,4L,18L,16L,8L,81L,192L,125L,16L,324L,1536L,2500L,1296L,32L,1215L,10240L,31250L,38880L,16807L,64L,4374L,61440L,312500L,699840L,705894L,262144L,128L,15309L,344064L,2734375L,9797760L,17294403L,14680064L,4782969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154715Inst : IEnumerable<long>
{
public static readonly long[] Value=A154715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154715.Bytes);
public long this[int i]=>Value[i];

public static A154715Inst Instance=new A154715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154716
{
public static readonly long[] Value={ 1729L,5681L,13547L,56327L,237553L,789289L,1089019L,1560553L,2530217L,4480109L,7703209L,12131401L,18417101L,24119467L,30355679L,38022301L,46039783L,53272619L,57627329L,62188859L,79075651L,112140029L,169169677L,226833263L,271152373L,300157327L,325898231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154716Inst : IEnumerable<long>
{
public static readonly long[] Value=A154716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154716.Bytes);
public long this[int i]=>Value[i];

public static A154716Inst Instance=new A154716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154717
{
public static readonly long[] Value={ 1729L,2093L,2821L,3059L,4123L,4991L,5681L,7189L,7657L,8827L,9269L,9373L,9919L,10507L,12649L,12719L,12901L,13547L,13699L,14497L,15197L,15617L,16583L,17143L,17549L,17563L,18487L,19513L,21049L,21749L,22211L,22351L,22379L,23621L,23653L,23933L,23959L,25441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154717Inst : IEnumerable<long>
{
public static readonly long[] Value=A154717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154717.Bytes);
public long this[int i]=>Value[i];

public static A154717Inst Instance=new A154717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154718
{
public static readonly long[] Value={ 8L,7L,6L,0L,9L,6L,0L,8L,7L,9L,5L,8L,9L,3L,5L,2L,4L,0L,3L,2L,0L,7L,6L,1L,6L,8L,4L,7L,4L,1L,4L,6L,6L,3L,2L,3L,5L,4L,3L,8L,9L,0L,0L,2L,7L,1L,1L,1L,0L,6L,1L,5L,1L,4L,5L,0L,3L,0L,1L,1L,6L,1L,8L,6L,3L,0L,7L,2L,1L,6L,4L,0L,1L,1L,0L,1L,5L,9L,1L,5L,8L,5L,2L,3L,8L,3L,9L,6L,6L,3L,9L,4L,2L,2L,7L,6L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154718Inst : IEnumerable<long>
{
public static readonly long[] Value=A154718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154718.Bytes);
public long this[int i]=>Value[i];

public static A154718Inst Instance=new A154718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154719
{
public static readonly long[] Value={ 8L,6L,3L,6L,7L,5L,7L,1L,2L,5L,3L,8L,2L,6L,2L,8L,2L,2L,0L,6L,4L,8L,0L,6L,6L,8L,9L,1L,8L,4L,9L,5L,8L,5L,5L,4L,1L,6L,2L,9L,4L,2L,9L,0L,8L,9L,3L,0L,5L,0L,5L,7L,6L,3L,2L,1L,5L,8L,0L,2L,0L,7L,2L,0L,8L,0L,1L,9L,2L,6L,2L,9L,6L,3L,7L,7L,9L,4L,9L,2L,1L,7L,7L,9L,1L,3L,3L,2L,7L,3L,1L,3L,8L,6L,4L,6L,1L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154719Inst : IEnumerable<long>
{
public static readonly long[] Value=A154719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154719.Bytes);
public long this[int i]=>Value[i];

public static A154719Inst Instance=new A154719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154720
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,0L,3L,0L,5L,1L,0L,3L,4L,5L,0L,7L,0L,0L,3L,0L,5L,0L,7L,0L,0L,1L,0L,0L,0L,5L,6L,7L,0L,0L,0L,11L,1L,0L,3L,0L,0L,0L,7L,0L,0L,0L,11L,0L,13L,0L,0L,3L,0L,5L,0L,0L,8L,0L,0L,11L,0L,13L,0L,0L,1L,0L,0L,0L,5L,0L,7L,0L,9L,0L,11L,0L,13L,0L,0L,0L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154720Inst : IEnumerable<long>
{
public static readonly long[] Value=A154720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154720.Bytes);
public long this[int i]=>Value[i];

public static A154720Inst Instance=new A154720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154721
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,0L,0L,0L,5L,1L,0L,3L,0L,5L,0L,7L,0L,0L,3L,0L,0L,0L,7L,0L,0L,1L,0L,0L,0L,5L,0L,7L,0L,0L,0L,11L,1L,0L,3L,0L,0L,0L,0L,0L,0L,0L,11L,0L,13L,0L,0L,3L,0L,5L,0L,0L,0L,0L,0L,11L,0L,13L,0L,0L,1L,0L,0L,0L,5L,0L,7L,0L,0L,0L,11L,0L,13L,0L,0L,0L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154721Inst : IEnumerable<long>
{
public static readonly long[] Value=A154721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154721.Bytes);
public long this[int i]=>Value[i];

public static A154721Inst Instance=new A154721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154722
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,3L,5L,1L,3L,4L,5L,7L,3L,5L,7L,1L,5L,6L,7L,11L,1L,3L,7L,11L,13L,3L,5L,8L,11L,13L,1L,5L,7L,9L,11L,13L,17L,1L,3L,7L,10L,13L,17L,19L,3L,5L,11L,17L,19L,1L,5L,7L,11L,12L,13L,17L,19L,23L,3L,7L,13L,19L,23L,5L,11L,14L,17L,23L,1L,7L,11L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154722Inst : IEnumerable<long>
{
public static readonly long[] Value=A154722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154722.Bytes);
public long this[int i]=>Value[i];

public static A154722Inst Instance=new A154722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154723
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,1L,3L,5L,7L,3L,7L,1L,5L,7L,11L,1L,3L,11L,13L,3L,5L,11L,13L,1L,5L,7L,11L,13L,17L,1L,3L,7L,13L,17L,19L,3L,5L,17L,19L,1L,5L,7L,11L,13L,17L,19L,23L,3L,7L,19L,23L,5L,11L,17L,23L,1L,7L,11L,13L,17L,19L,23L,29L,1L,3L,13L,19L,29L,31L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154723Inst : IEnumerable<long>
{
public static readonly long[] Value=A154723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154723.Bytes);
public long this[int i]=>Value[i];

public static A154723Inst Instance=new A154723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154724
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,0L,3L,0L,0L,0L,0L,3L,4L,5L,0L,0L,0L,0L,3L,0L,5L,0L,7L,0L,0L,0L,0L,0L,0L,5L,6L,7L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,7L,0L,0L,0L,11L,0L,0L,0L,0L,3L,0L,5L,0L,0L,8L,0L,0L,11L,0L,13L,0L,0L,0L,0L,0L,0L,5L,0L,7L,0L,9L,0L,11L,0L,13L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154724Inst : IEnumerable<long>
{
public static readonly long[] Value=A154724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154724.Bytes);
public long this[int i]=>Value[i];

public static A154724Inst Instance=new A154724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154725
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,5L,0L,0L,0L,0L,3L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,5L,0L,7L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,3L,0L,5L,0L,0L,0L,0L,0L,11L,0L,13L,0L,0L,0L,0L,0L,0L,5L,0L,7L,0L,0L,0L,11L,0L,13L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154725Inst : IEnumerable<long>
{
public static readonly long[] Value=A154725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154725.Bytes);
public long this[int i]=>Value[i];

public static A154725Inst Instance=new A154725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154726
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,3L,5L,7L,5L,6L,7L,3L,7L,11L,3L,5L,8L,11L,13L,5L,7L,9L,11L,13L,3L,7L,10L,13L,17L,3L,5L,11L,17L,19L,5L,7L,11L,12L,13L,17L,19L,3L,7L,13L,19L,23L,5L,11L,14L,17L,23L,7L,11L,13L,15L,17L,19L,23L,3L,13L,16L,19L,29L,3L,5L,11L,17L,23L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154726Inst : IEnumerable<long>
{
public static readonly long[] Value=A154726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154726.Bytes);
public long this[int i]=>Value[i];

public static A154726Inst Instance=new A154726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154727
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,3L,7L,5L,7L,3L,11L,3L,5L,11L,13L,5L,7L,11L,13L,3L,7L,13L,17L,3L,5L,17L,19L,5L,7L,11L,13L,17L,19L,3L,7L,19L,23L,5L,11L,17L,23L,7L,11L,13L,17L,19L,23L,3L,13L,19L,29L,3L,5L,11L,23L,29L,31L,5L,7L,13L,17L,19L,23L,29L,31L,7L,31L,3L,11L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154727Inst : IEnumerable<long>
{
public static readonly long[] Value=A154727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154727.Bytes);
public long this[int i]=>Value[i];

public static A154727Inst Instance=new A154727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154728
{
public static readonly long[] Value={ 1729L,7657L,21793L,49321L,97051L,175741L,298351L,386389L,559399L,789289L,1089019L,1425829L,1924177L,2665603L,3295273L,3864241L,4631971L,5694079L,6951667L,8103877L,9363547L,10775137L,12307147L,14956219L,18091147L,21243961L,24066037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154728Inst : IEnumerable<long>
{
public static readonly long[] Value=A154728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154728.Bytes);
public long this[int i]=>Value[i];

public static A154728Inst Instance=new A154728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154729
{
public static readonly long[] Value={ 1729L,2821L,3367L,3913L,4123L,4921L,5551L,5719L,6097L,6643L,7189L,7657L,8029L,8113L,8827L,8911L,9139L,9331L,9373L,9709L,9919L,10507L,10621L,11137L,11557L,12649L,12901L,13237L,13699L,13741L,14287L,14497L,14539L,14833L,14911L,15067L,15799L,15841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154729Inst : IEnumerable<long>
{
public static readonly long[] Value=A154729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154729.Bytes);
public long this[int i]=>Value[i];

public static A154729Inst Instance=new A154729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154730
{
public static readonly long[] Value={ 7L,6L,4L,2L,8L,8L,8L,6L,8L,2L,8L,0L,7L,6L,7L,0L,6L,8L,6L,2L,5L,8L,5L,6L,5L,2L,4L,6L,4L,0L,3L,8L,3L,2L,2L,8L,2L,6L,2L,0L,1L,6L,1L,0L,0L,2L,8L,9L,8L,8L,9L,6L,8L,9L,2L,8L,9L,0L,8L,8L,6L,8L,7L,2L,8L,6L,8L,8L,6L,2L,8L,6L,0L,8L,5L,0L,8L,4L,8L,8L,4L,2L,8L,3L,6L,8L,3L,2L,8L,2L,6L,8L,2L,0L,8L,1L,8L,8L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154730Inst : IEnumerable<long>
{
public static readonly long[] Value=A154730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154730.Bytes);
public long this[int i]=>Value[i];

public static A154730Inst Instance=new A154730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154731
{
public static readonly long[] Value={ 4L,18L,180L,2028L,8820L,34848L,108288L,191748L,720900L,875520L,960498L,990000L,1355310L,1629108L,1713600L,1756920L,2334948L,2609028L,7376850L,8448048L,21639798L,37148148L,42023088L,48893940L,60544008L,63840000L,100328400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154731Inst : IEnumerable<long>
{
public static readonly long[] Value=A154731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154731.Bytes);
public long this[int i]=>Value[i];

public static A154731Inst Instance=new A154731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154732
{
public static readonly long[] Value={ 2L,5L,9L,11L,12L,26L,44L,47L,62L,69L,71L,89L,125L,140L,147L,179L,219L,254L,264L,285L,294L,312L,317L,326L,341L,344L,384L,407L,461L,495L,659L,680L,714L,740L,837L,845L,861L,866L,867L,957L,989L,1071L,1079L,1152L,1215L,1310L,1437L,1481L,1499L,1511L,1530L,1577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154732Inst : IEnumerable<long>
{
public static readonly long[] Value=A154732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154732.Bytes);
public long this[int i]=>Value[i];

public static A154732Inst Instance=new A154732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154733
{
public static readonly long[] Value={ 12L,150L,810L,1452L,1872L,18252L,87120L,106032L,242172L,333270L,362952L,712890L,1968750L,2763600L,3198132L,5767380L,10551420L,16451580L,18469440L,23230350L,25498620L,30468672L,31955502L,34752252L,39768102L,40825920L,56770560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154733Inst : IEnumerable<long>
{
public static readonly long[] Value=A154733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154733.Bytes);
public long this[int i]=>Value[i];

public static A154733Inst Instance=new A154733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154734
{
public static readonly long[] Value={ 2L,4L,12L,138L,822L,2082L,3918L,21738L,39342L,62130L,70878L,106032L,117372L,129288L,135462L,182712L,512580L,524802L,575130L,682698L,769422L,799482L,893118L,1008912L,1026030L,1043292L,1828830L,2368578L,2447580L,3247428L,3278082L,3465030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154734Inst : IEnumerable<long>
{
public static readonly long[] Value=A154734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154734.Bytes);
public long this[int i]=>Value[i];

public static A154734Inst Instance=new A154734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154735
{
public static readonly long[] Value={ 8L,5L,2L,1L,0L,9L,6L,0L,7L,2L,2L,0L,1L,2L,7L,6L,2L,7L,8L,2L,7L,0L,8L,5L,9L,9L,9L,8L,7L,7L,4L,2L,2L,4L,6L,2L,1L,0L,8L,0L,4L,1L,1L,9L,9L,7L,7L,9L,6L,4L,9L,9L,8L,3L,4L,6L,4L,8L,1L,7L,5L,5L,9L,3L,2L,8L,3L,3L,8L,7L,4L,2L,7L,3L,9L,5L,0L,7L,8L,3L,2L,9L,6L,5L,2L,7L,0L,2L,2L,5L,0L,2L,0L,5L,7L,3L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154735Inst : IEnumerable<long>
{
public static readonly long[] Value=A154735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154735.Bytes);
public long this[int i]=>Value[i];

public static A154735Inst Instance=new A154735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154736
{
public static readonly long[] Value={ 3L,4L,16L,40L,64L,88L,208L,280L,352L,376L,460L,484L,508L,520L,604L,1012L,1024L,1072L,1168L,1240L,1264L,1336L,1420L,1432L,1444L,1912L,2176L,2212L,2548L,2560L,2632L,2836L,2848L,2872L,2944L,2956L,3184L,3220L,3508L,3616L,3640L,3772L,3868L,3892L,3928L,3940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154736Inst : IEnumerable<long>
{
public static readonly long[] Value=A154736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154736.Bytes);
public long this[int i]=>Value[i];

public static A154736Inst Instance=new A154736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154737
{
public static readonly BigInteger[] Value={ -1L,1L,3L,164L,BigInteger.Parse("6957245584036948615038006292270726370571486830808434942221507554589944046539124911869946306936720078616701636095631") };
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
public class A154737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154737Inst Instance=new A154737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154738
{
public static readonly long[] Value={ 1L,6L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,3L,2L,1L,6L,7L,7L,7L,9L,4L,2L,4L,5L,3L,3L,4L,1L,0L,6L,7L,9L,7L,8L,4L,9L,3L,0L,3L,6L,4L,7L,9L,7L,9L,5L,9L,9L,5L,5L,2L,6L,0L,3L,9L,5L,8L,8L,8L,2L,2L,4L,8L,2L,5L,7L,2L,5L,6L,5L,5L,1L,3L,5L,3L,1L,3L,6L,7L,2L,0L,5L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154738Inst : IEnumerable<long>
{
public static readonly long[] Value=A154738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154738.Bytes);
public long this[int i]=>Value[i];

public static A154738Inst Instance=new A154738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154739
{
public static readonly long[] Value={ 5L,4L,1L,1L,9L,6L,1L,0L,0L,1L,4L,6L,1L,9L,6L,9L,8L,4L,3L,9L,9L,7L,2L,3L,2L,0L,5L,3L,6L,6L,3L,8L,9L,4L,2L,0L,0L,6L,1L,0L,7L,2L,0L,6L,3L,3L,7L,8L,0L,1L,5L,4L,4L,4L,6L,8L,1L,2L,9L,7L,0L,9L,5L,6L,5L,2L,9L,8L,8L,9L,7L,3L,5L,4L,1L,0L,1L,2L,6L,6L,6L,4L,7L,7L,8L,2L,6L,1L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154739Inst : IEnumerable<long>
{
public static readonly long[] Value=A154739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154739.Bytes);
public long this[int i]=>Value[i];

public static A154739Inst Instance=new A154739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154740
{
public static readonly long[] Value={ 0L,1L,1L,5L,1L,1L,3L,6L,1L,3L,3L,10L,10L,1L,1L,1L,5L,2L,3L,1L,1L,3L,6L,1L,8L,74L,2L,1L,2L,4L,2L,4L,3L,5L,9L,4L,3L,1L,1L,1L,2L,1L,17L,6L,1L,2L,12L,1L,1L,1L,2L,1L,24L,1L,2L,1L,2L,9L,989L,2L,13L,1L,5L,1L,1L,1L,64L,2L,2L,1L,1L,9L,1L,3L,1L,1L,1L,2L,3L,11L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154740Inst : IEnumerable<long>
{
public static readonly long[] Value=A154740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154740.Bytes);
public long this[int i]=>Value[i];

public static A154740Inst Instance=new A154740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154741
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,6L,7L,13L,46L,289L,335L,1294L,4217L,43464L,438857L,482321L,921178L,1403499L,7938673L,17280845L,59781208L,77062053L,136843261L,487591836L,3062394277L,3549986113L,31462283181L,2331758941507L,4694980166195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154741Inst : IEnumerable<long>
{
public static readonly long[] Value=A154741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154741.Bytes);
public long this[int i]=>Value[i];

public static A154741Inst Instance=new A154741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154742
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,11L,13L,24L,85L,534L,619L,2391L,7792L,80311L,810902L,891213L,1702115L,2593328L,14668755L,31930838L,110461269L,142392107L,252853376L,900952235L,5658566786L,6559519021L,58134718954L,4308528721617L,8675192162188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154742Inst : IEnumerable<long>
{
public static readonly long[] Value=A154742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154742.Bytes);
public long this[int i]=>Value[i];

public static A154742Inst Instance=new A154742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154743
{
public static readonly long[] Value={ 3L,4L,8L,3L,1L,0L,6L,9L,9L,7L,4L,9L,0L,0L,6L,5L,2L,3L,6L,8L,6L,3L,7L,4L,4L,9L,4L,3L,2L,7L,2L,6L,1L,0L,2L,0L,2L,5L,2L,9L,3L,7L,8L,3L,0L,1L,0L,7L,0L,3L,2L,9L,0L,2L,2L,0L,5L,7L,7L,6L,1L,3L,8L,7L,4L,4L,5L,4L,1L,9L,1L,3L,2L,7L,3L,0L,1L,4L,9L,2L,0L,0L,5L,6L,4L,5L,7L,3L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154743Inst : IEnumerable<long>
{
public static readonly long[] Value=A154743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154743.Bytes);
public long this[int i]=>Value[i];

public static A154743Inst Instance=new A154743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154744
{
public static readonly long[] Value={ 0L,2L,1L,6L,1L,3L,32L,18L,3L,8L,1L,2L,2L,2L,8L,5L,2L,1L,3L,2L,1L,14L,2L,1L,2L,190L,1L,2L,9L,1L,1L,1L,2L,4L,1L,1L,2L,5L,1L,1L,1L,1L,2L,2L,3L,1L,30L,1L,1L,5L,4L,6L,1L,3L,8L,3L,4L,6L,3L,1L,1L,1L,1L,7L,1L,68L,20L,1L,3L,1L,2L,1L,1L,2L,1L,15L,2L,2L,4L,2L,1L,2L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154744Inst : IEnumerable<long>
{
public static readonly long[] Value=A154744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154744.Bytes);
public long this[int i]=>Value[i];

public static A154744Inst Instance=new A154744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154745
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,7L,8L,31L,1000L,18031L,55093L,458775L,513868L,1486511L,3486890L,8460291L,71169218L,364306381L,799781980L,1164088361L,4292047063L,9748182487L,14040229550L,206311396187L,426663021924L,632974418111L,1692611858146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154745Inst : IEnumerable<long>
{
public static readonly long[] Value=A154745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154745.Bytes);
public long this[int i]=>Value[i];

public static A154745Inst Instance=new A154745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154746
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,20L,23L,89L,2871L,51767L,158172L,1317143L,1475315L,4267773L,10010861L,24289495L,204326821L,1045923600L,2296174021L,3342097621L,12322466884L,27987031389L,40309498273L,592320007211L,1224949512695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154746Inst : IEnumerable<long>
{
public static readonly long[] Value=A154746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154746.Bytes);
public long this[int i]=>Value[i];

public static A154746Inst Instance=new A154746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154747
{
public static readonly long[] Value={ 6L,4L,3L,5L,9L,4L,2L,5L,2L,9L,0L,5L,5L,8L,2L,6L,2L,4L,7L,3L,5L,4L,4L,3L,4L,3L,7L,4L,1L,8L,2L,0L,9L,8L,0L,8L,9L,2L,4L,2L,0L,2L,7L,4L,2L,4L,4L,4L,0L,0L,7L,6L,5L,1L,1L,5L,6L,1L,5L,2L,0L,0L,9L,3L,5L,2L,0L,7L,4L,8L,5L,0L,3L,2L,1L,8L,3L,6L,5L,1L,9L,5L,4L,5L,1L,3L,4L,2L,4L,6L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154747Inst : IEnumerable<long>
{
public static readonly long[] Value=A154747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154747.Bytes);
public long this[int i]=>Value[i];

public static A154747Inst Instance=new A154747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154748
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,6L,1L,2L,2L,2L,1L,1L,6L,1L,179L,46L,1L,1L,3L,2L,1L,1L,3L,6L,3L,1L,1L,1L,1L,2L,1L,1L,56L,1L,1L,1L,1L,66L,1L,1L,2L,17L,8L,2L,7L,12L,1L,1L,8L,1L,2L,2L,1L,1L,2L,1L,12L,1L,2L,2L,2L,2L,1L,1L,1L,8L,1L,1L,1L,1L,2L,1L,2L,5L,1L,6L,8L,1L,1L,1L,2L,7L,1L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154748Inst : IEnumerable<long>
{
public static readonly long[] Value=A154748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154748.Bytes);
public long this[int i]=>Value[i];

public static A154748Inst Instance=new A154748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154749
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,9L,56L,65L,186L,437L,1060L,1497L,2557L,16839L,19396L,3488723L,160500654L,163989377L,324490031L,1137459470L,2599408971L,3736868441L,6336277412L,22745700677L,142810481474L,451177145099L,593987626573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154749Inst : IEnumerable<long>
{
public static readonly long[] Value=A154749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154749.Bytes);
public long this[int i]=>Value[i];

public static A154749Inst Instance=new A154749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154750
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,3L,14L,87L,101L,289L,679L,1647L,2326L,3973L,26164L,30137L,5420687L,249381739L,254802426L,504184165L,1767354921L,4038894007L,5806248928L,9845142935L,35341677733L,221895209333L,701027305732L,922922515065L,1623949820797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154750Inst : IEnumerable<long>
{
public static readonly long[] Value=A154750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154750.Bytes);
public long this[int i]=>Value[i];

public static A154750Inst Instance=new A154750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154751
{
public static readonly long[] Value={ 2L,5L,2L,3L,7L,1L,9L,0L,1L,4L,2L,8L,5L,8L,2L,9L,7L,4L,8L,3L,9L,8L,1L,0L,8L,4L,5L,7L,3L,7L,1L,0L,4L,3L,4L,1L,7L,1L,9L,8L,3L,4L,2L,5L,6L,0L,5L,2L,7L,5L,2L,1L,7L,1L,1L,4L,8L,2L,6L,1L,9L,7L,7L,5L,3L,5L,4L,7L,4L,0L,8L,0L,5L,5L,2L,3L,6L,5L,9L,2L,2L,0L,2L,4L,4L,6L,9L,0L,7L,5L,4L,1L,9L,7L,8L,0L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154751Inst : IEnumerable<long>
{
public static readonly long[] Value=A154751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154751.Bytes);
public long this[int i]=>Value[i];

public static A154751Inst Instance=new A154751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154752
{
public static readonly long[] Value={ 0L,2L,0L,3L,2L,0L,7L,2L,3L,0L,5L,2L,3L,11L,0L,13L,2L,3L,13L,5L,0L,7L,2L,3L,19L,5L,17L,0L,19L,2L,3L,11L,5L,13L,7L,0L,31L,2L,3L,19L,5L,41L,7L,23L,0L,31L,2L,3L,13L,5L,23L,7L,17L,53L,0L,11L,2L,3L,23L,5L,61L,7L,53L,19L,29L,0L,31L,2L,3L,67L,5L,17L,7L,19L,47L,31L,11L,0L,13L,2L,3L,37L,5L,29L,7L,31L,59L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154752Inst : IEnumerable<long>
{
public static readonly long[] Value=A154752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154752.Bytes);
public long this[int i]=>Value[i];

public static A154752Inst Instance=new A154752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154753
{
public static readonly long[] Value={ 4L,13L,31L,16L,110L,56L,96L,120L,553L,140L,331L,469L,560L,308L,46L,52L,3541L,620L,1519L,5113L,1776L,1040L,287L,8011L,3169L,680L,17L,1272L,330L,12883L,1792L,5720L,18907L,1288L,7400L,950L,8269L,54L,9296L,2494L,32221L,10981L,36673L,1552L,3234L,66L,1855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154753Inst : IEnumerable<long>
{
public static readonly long[] Value=A154753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154753.Bytes);
public long this[int i]=>Value[i];

public static A154753Inst Instance=new A154753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154754
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,1L,1L,3L,1L,3L,1L,3L,1L,1L,3L,1L,3L,1L,3L,1L,1L,1L,1L,1L,3L,1L,3L,3L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154754Inst : IEnumerable<long>
{
public static readonly long[] Value=A154754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154754.Bytes);
public long this[int i]=>Value[i];

public static A154754Inst Instance=new A154754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154755
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,29L,31L,37L,41L,43L,47L,53L,59L,67L,71L,83L,89L,97L,101L,107L,113L,131L,137L,149L,157L,167L,173L,179L,181L,191L,197L,223L,227L,229L,233L,239L,251L,257L,263L,269L,277L,281L,283L,293L,311L,313L,317L,331L,347L,353L,359L,367L,379L,383L,389L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154755Inst : IEnumerable<long>
{
public static readonly long[] Value=A154755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154755.Bytes);
public long this[int i]=>Value[i];

public static A154755Inst Instance=new A154755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154756
{
public static readonly long[] Value={ 7L,13L,19L,61L,73L,79L,103L,109L,127L,139L,151L,163L,193L,199L,211L,241L,271L,307L,337L,349L,373L,409L,421L,523L,541L,547L,571L,607L,613L,673L,739L,757L,769L,787L,811L,853L,877L,883L,907L,919L,937L,967L,991L,1009L,1033L,1063L,1087L,1117L,1123L,1129L,1201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154756Inst : IEnumerable<long>
{
public static readonly long[] Value=A154756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154756.Bytes);
public long this[int i]=>Value[i];

public static A154756Inst Instance=new A154756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154757
{
public static readonly long[] Value={ 1L,1L,3L,14L,83L,574L,4433L,37274L,335751L,3204616L,32159272L,337383121L,3684215369L,41735965645L,489173496890L,5919292080009L,73818803114991L,947369389903293L,12496580900037441L,169248542357479944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154757Inst : IEnumerable<long>
{
public static readonly long[] Value=A154757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154757.Bytes);
public long this[int i]=>Value[i];

public static A154757Inst Instance=new A154757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154758
{
public static readonly long[] Value={ 2L,23L,29L,41L,43L,47L,61L,67L,83L,89L,101L,103L,107L,109L,127L,149L,163L,167L,181L,211L,233L,239L,251L,257L,271L,277L,293L,307L,347L,349L,367L,383L,389L,419L,431L,433L,439L,457L,479L,491L,499L,503L,509L,521L,523L,541L,547L,563L,569L,587L,613L,617L,619L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154758Inst : IEnumerable<long>
{
public static readonly long[] Value=A154758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154758.Bytes);
public long this[int i]=>Value[i];

public static A154758Inst Instance=new A154758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154759
{
public static readonly long[] Value={ 1L,7L,2L,2L,7L,0L,6L,2L,3L,2L,2L,9L,3L,5L,7L,2L,2L,0L,2L,6L,8L,0L,4L,2L,6L,2L,7L,5L,0L,5L,5L,8L,6L,2L,5L,2L,8L,2L,7L,9L,1L,6L,7L,7L,2L,8L,3L,1L,9L,0L,4L,1L,7L,9L,7L,2L,8L,7L,9L,0L,4L,1L,5L,1L,8L,4L,2L,6L,4L,8L,3L,3L,0L,1L,5L,1L,5L,4L,2L,0L,2L,4L,3L,3L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154759Inst : IEnumerable<long>
{
public static readonly long[] Value=A154759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154759.Bytes);
public long this[int i]=>Value[i];

public static A154759Inst Instance=new A154759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154760
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,5L,8L,5L,4L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154760Inst : IEnumerable<long>
{
public static readonly long[] Value=A154760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154760.Bytes);
public long this[int i]=>Value[i];

public static A154760Inst Instance=new A154760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154761
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,37L,43L,47L,53L,67L,73L,83L,223L,227L,233L,257L,263L,277L,283L,307L,337L,347L,353L,367L,373L,383L,433L,443L,457L,463L,467L,487L,503L,523L,547L,557L,563L,577L,587L,607L,643L,647L,653L,673L,677L,683L,727L,733L,743L,757L,773L,787L,823L,827L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154761Inst : IEnumerable<long>
{
public static readonly long[] Value=A154761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154761.Bytes);
public long this[int i]=>Value[i];

public static A154761Inst Instance=new A154761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154762
{
public static readonly long[] Value={ 13L,17L,29L,31L,59L,71L,79L,97L,103L,107L,163L,167L,241L,269L,281L,349L,389L,421L,431L,439L,479L,509L,541L,569L,613L,617L,631L,659L,701L,709L,761L,769L,821L,829L,839L,859L,907L,947L,967L,983L,1063L,1087L,1123L,1153L,1213L,1217L,1229L,1231L,1259L,1279L,1297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154762Inst : IEnumerable<long>
{
public static readonly long[] Value=A154762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154762.Bytes);
public long this[int i]=>Value[i];

public static A154762Inst Instance=new A154762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154763
{
public static readonly long[] Value={ 41L,61L,89L,149L,181L,241L,269L,281L,401L,409L,419L,421L,443L,449L,461L,463L,467L,487L,491L,499L,601L,619L,641L,643L,647L,661L,683L,691L,809L,811L,821L,829L,863L,881L,883L,887L,941L,1049L,1061L,1069L,1181L,1249L,1289L,1409L,1429L,1447L,1481L,1483L,1487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154763Inst : IEnumerable<long>
{
public static readonly long[] Value=A154763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154763.Bytes);
public long this[int i]=>Value[i];

public static A154763Inst Instance=new A154763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154764
{
public static readonly long[] Value={ 3L,5L,7L,23L,29L,41L,43L,47L,61L,67L,83L,89L,223L,227L,229L,241L,263L,269L,281L,283L,401L,409L,421L,443L,449L,461L,463L,467L,487L,601L,607L,641L,643L,647L,661L,683L,809L,821L,823L,827L,829L,863L,881L,883L,887L,2003L,2027L,2029L,2063L,2069L,2081L,2083L,2087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154764Inst : IEnumerable<long>
{
public static readonly long[] Value=A154764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154764.Bytes);
public long this[int i]=>Value[i];

public static A154764Inst Instance=new A154764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154765
{
public static readonly long[] Value={ 2L,11L,19L,29L,43L,47L,67L,83L,103L,107L,163L,167L,191L,199L,211L,229L,263L,283L,349L,389L,431L,439L,479L,509L,541L,569L,613L,617L,631L,659L,701L,709L,761L,769L,823L,827L,839L,859L,907L,911L,919L,929L,947L,967L,983L,991L,1013L,1031L,1039L,1051L,1093L,1097L,1103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154765Inst : IEnumerable<long>
{
public static readonly long[] Value=A154765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154765.Bytes);
public long this[int i]=>Value[i];

public static A154765Inst Instance=new A154765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154766
{
public static readonly long[] Value={ 1L,9L,10L,13L,14L,15L,18L,19L,23L,24L,26L,27L,28L,29L,31L,35L,38L,39L,42L,47L,51L,52L,54L,55L,58L,59L,62L,63L,69L,70L,73L,76L,77L,81L,83L,84L,85L,88L,92L,94L,95L,96L,97L,98L,99L,100L,101L,103L,104L,107L,112L,113L,114L,115L,119L,120L,122L,123L,125L,126L,127L,129L,132L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154766Inst : IEnumerable<long>
{
public static readonly long[] Value=A154766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154766.Bytes);
public long this[int i]=>Value[i];

public static A154766Inst Instance=new A154766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154767
{
public static readonly long[] Value={ 2L,41L,43L,61L,83L,163L,181L,211L,241L,263L,281L,283L,383L,401L,421L,431L,433L,443L,461L,463L,487L,563L,587L,601L,613L,631L,641L,643L,653L,661L,683L,787L,811L,821L,823L,827L,853L,857L,863L,877L,881L,883L,887L,1021L,1061L,1063L,1087L,1163L,1181L,1187L,1201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154767Inst : IEnumerable<long>
{
public static readonly long[] Value=A154767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154767.Bytes);
public long this[int i]=>Value[i];

public static A154767Inst Instance=new A154767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154768
{
public static readonly long[] Value={ 1L,56L,61L,78L,91L,93L,110L,143L,144L,172L,178L,179L,181L,197L,252L,279L,305L,311L,313L,314L,315L,323L,324L,326L,334L,340L,354L,360L,382L,386L,289L,390L,408L,409L,411L,412L,413L,415L,418L,436L,438L,441L,507L,531L,551L,552L,554L,556L,575L,582L,588L,602L,623L,643L,647L,653L,679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154768Inst : IEnumerable<long>
{
public static readonly long[] Value=A154768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154768.Bytes);
public long this[int i]=>Value[i];

public static A154768Inst Instance=new A154768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154769
{
public static readonly BigInteger[] Value={ 1234567891L,BigInteger.Parse("1234567891234567891234567891"),BigInteger.Parse("1234567891234567891234567891234567891234567891234567891234567891234567") };
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
public class A154769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154769Inst Instance=new A154769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154770
{
public static readonly long[] Value={ 10L,11L,12L,15L,21L,24L,30L,33L,36L,45L,54L,63L,72L,81L,90L,99L,108L,127L,176L,283L,407L,458L,578L,733L,849L,1003L,1117L,1381L,2044L,2318L,2953L,4397L,5435L,6557L,7964L,9989L,12279L,16572L,26426L,36970L,49970L,67738L,84716L,100181L,111599L,139413L,209606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154770Inst : IEnumerable<long>
{
public static readonly long[] Value=A154770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154770.Bytes);
public long this[int i]=>Value[i];

public static A154770Inst Instance=new A154770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154771
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,15L,17L,19L,21L,23L,25L,27L,29L,22L,24L,24L,28L,30L,32L,34L,36L,38L,40L,33L,35L,37L,36L,41L,43L,45L,47L,49L,51L,44L,46L,48L,50L,48L,54L,56L,58L,60L,62L,55L,57L,59L,61L,63L,60L,67L,69L,71L,73L,66L,68L,70L,72L,74L,76L,72L,80L,82L,84L,77L,79L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154771Inst : IEnumerable<long>
{
public static readonly long[] Value=A154771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154771.Bytes);
public long this[int i]=>Value[i];

public static A154771Inst Instance=new A154771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154772
{
public static readonly long[] Value={ 1L,3L,7L,14L,22L,29L,41L,46L,62L,64L,67L,88L,167L,179L,207L,231L,239L,249L,263L,266L,286L,290L,309L,315L,322L,323L,326L,344L,350L,353L,354L,372L,392L,421L,444L,454L,458L,496L,505L,553L,560L,561L,571L,585L,613L,636L,647L,661L,669L,682L,745L,788L,790L,791L,815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154772Inst : IEnumerable<long>
{
public static readonly long[] Value=A154772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154772.Bytes);
public long this[int i]=>Value[i];

public static A154772Inst Instance=new A154772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154773
{
public static readonly long[] Value={ 3L,5L,11L,14L,18L,20L,26L,27L,28L,29L,31L,38L,42L,52L,58L,64L,73L,82L,85L,90L,110L,125L,138L,156L,167L,180L,212L,234L,248L,297L,299L,303L,305L,308L,312L,314L,317L,319L,334L,336L,348L,361L,365L,371L,372L,377L,379L,414L,451L,465L,478L,499L,508L,509L,535L,554L,564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154773Inst : IEnumerable<long>
{
public static readonly long[] Value=A154773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154773.Bytes);
public long this[int i]=>Value[i];

public static A154773Inst Instance=new A154773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154774
{
public static readonly long[] Value={ 10L,14L,15L,25L,60L,74L,76L,87L,127L,129L,130L,140L,171L,196L,207L,224L,259L,263L,302L,314L,315L,319L,333L,337L,377L,389L,451L,454L,470L,491L,508L,518L,549L,568L,574L,589L,592L,624L,629L,636L,690L,696L,729L,748L,753L,769L,770L,771L,781L,791L,802L,833L,844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154774Inst : IEnumerable<long>
{
public static readonly long[] Value=A154774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154774.Bytes);
public long this[int i]=>Value[i];

public static A154774Inst Instance=new A154774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154775
{
public static readonly long[] Value={ 2L,4L,5L,42L,46L,49L,59L,82L,84L,100L,119L,128L,137L,182L,185L,187L,192L,233L,264L,301L,303L,340L,376L,390L,395L,422L,438L,446L,471L,472L,494L,518L,527L,570L,598L,609L,611L,633L,667L,688L,714L,716L,726L,728L,733L,744L,831L,837L,865L,875L,896L,926L,940L,948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154775Inst : IEnumerable<long>
{
public static readonly long[] Value=A154775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154775.Bytes);
public long this[int i]=>Value[i];

public static A154775Inst Instance=new A154775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154776
{
public static readonly long[] Value={ 1L,5L,4L,7L,4L,1L,1L,2L,2L,8L,9L,3L,8L,1L,6L,6L,3L,4L,7L,4L,8L,0L,9L,8L,4L,5L,5L,3L,8L,7L,1L,2L,8L,3L,5L,0L,5L,8L,6L,0L,5L,6L,7L,4L,3L,7L,8L,2L,8L,4L,1L,3L,7L,1L,3L,5L,5L,7L,9L,7L,9L,7L,1L,5L,3L,0L,6L,5L,6L,8L,0L,7L,4L,1L,6L,2L,8L,9L,1L,2L,1L,5L,3L,2L,6L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154776Inst : IEnumerable<long>
{
public static readonly long[] Value=A154776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154776.Bytes);
public long this[int i]=>Value[i];

public static A154776Inst Instance=new A154776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154777
{
public static readonly long[] Value={ 3L,6L,9L,11L,12L,17L,18L,19L,22L,24L,27L,33L,34L,36L,38L,41L,43L,44L,48L,51L,54L,57L,59L,66L,67L,68L,72L,73L,75L,76L,81L,82L,83L,86L,88L,89L,96L,97L,99L,102L,107L,108L,113L,114L,118L,121L,123L,129L,131L,132L,134L,136L,137L,139L,144L,146L,147L,150L,152L,153L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154777Inst : IEnumerable<long>
{
public static readonly long[] Value=A154777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154777.Bytes);
public long this[int i]=>Value[i];

public static A154777Inst Instance=new A154777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154778
{
public static readonly long[] Value={ 6L,9L,14L,21L,24L,29L,30L,36L,41L,45L,46L,49L,54L,56L,61L,69L,70L,81L,84L,86L,89L,94L,96L,101L,105L,109L,116L,120L,126L,129L,134L,141L,144L,145L,149L,150L,161L,164L,166L,174L,180L,181L,184L,189L,196L,201L,205L,206L,214L,216L,224L,225L,229L,230L,241L,244L,245L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154778Inst : IEnumerable<long>
{
public static readonly long[] Value=A154778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154778.Bytes);
public long this[int i]=>Value[i];

public static A154778Inst Instance=new A154778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154779
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,12L,17L,34L,55L,98L,161L,288L,448L,811L,1265L,2145L,3425L,5860L,9305L,15384L,24690L,40445L,64715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154779Inst : IEnumerable<long>
{
public static readonly long[] Value=A154779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154779.Bytes);
public long this[int i]=>Value[i];

public static A154779Inst Instance=new A154779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154780
{
public static readonly long[] Value={ 5L,35L,235L,335L,2335L,3335L,23335L,32335L,33335L,72335L,233335L,323335L,333335L,372335L,572335L,723335L,2333335L,2372335L,2723335L,3233335L,3323335L,3333335L,3572335L,3723335L,7233335L,7323335L,7372335L,7572335L,22372335L,23333335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154780Inst : IEnumerable<long>
{
public static readonly long[] Value=A154780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154780.Bytes);
public long this[int i]=>Value[i];

public static A154780Inst Instance=new A154780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154781
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,2L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,3L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,4L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,5L,11L,12L,13L,14L,6L,7L,8L,9L,10L,11L,6L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,7L,15L,16L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154781Inst : IEnumerable<long>
{
public static readonly long[] Value=A154781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154781.Bytes);
public long this[int i]=>Value[i];

public static A154781Inst Instance=new A154781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154782
{
public static readonly long[] Value={ 0L,0L,1L,-1L,0L,-1L,-1L,1L,2L,0L,-1L,-1L,-1L,-1L,1L,-1L,0L,2L,3L,-1L,-1L,-1L,-1L,1L,-1L,0L,-1L,-1L,2L,-1L,-1L,3L,4L,-1L,1L,-1L,0L,-1L,-1L,-1L,-1L,2L,-1L,-1L,-1L,-1L,3L,1L,-1L,0L,5L,-1L,-1L,-1L,-1L,-1L,2L,-1L,-1L,-1L,-1L,-1L,1L,3L,0L,-1L,-1L,-1L,4L,-1L,-1L,5L,6L,2L,-1L,-1L,-1L,-1L,-1L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154782Inst : IEnumerable<long>
{
public static readonly long[] Value=A154782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154782.Bytes);
public long this[int i]=>Value[i];

public static A154782Inst Instance=new A154782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154783
{
public static readonly long[] Value={ 1L,6L,9L,20L,15L,30L,35L,40L,63L,70L,55L,108L,65L,70L,135L,112L,119L,162L,95L,140L,231L,198L,161L,312L,225L,182L,351L,196L,203L,450L,217L,352L,429L,238L,385L,540L,407L,418L,585L,440L,369L,798L,387L,396L,945L,414L,423L,720L,441L,650L,969L,676L,583L,1026L,825L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154783Inst : IEnumerable<long>
{
public static readonly long[] Value=A154783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154783.Bytes);
public long this[int i]=>Value[i];

public static A154783Inst Instance=new A154783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154784
{
public static readonly long[] Value={ 0L,4L,6L,16L,10L,24L,28L,32L,54L,60L,44L,96L,52L,56L,120L,96L,102L,144L,76L,120L,210L,176L,138L,288L,200L,156L,324L,168L,174L,420L,186L,320L,396L,204L,350L,504L,370L,380L,546L,400L,328L,756L,344L,352L,900L,368L,376L,672L,392L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154784Inst : IEnumerable<long>
{
public static readonly long[] Value=A154784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154784.Bytes);
public long this[int i]=>Value[i];

public static A154784Inst Instance=new A154784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154785
{
public static readonly long[] Value={ 1L,2L,3L,12L,15L,18L,21L,40L,45L,50L,55L,84L,65L,70L,105L,80L,119L,162L,57L,140L,189L,154L,161L,264L,225L,182L,297L,196L,203L,390L,155L,352L,429L,170L,385L,468L,333L,418L,585L,360L,369L,714L,387L,396L,855L,414L,423L,720L,343L,650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154785Inst : IEnumerable<long>
{
public static readonly long[] Value=A154785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154785.Bytes);
public long this[int i]=>Value[i];

public static A154785Inst Instance=new A154785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154786
{
public static readonly long[] Value={ 0L,0L,0L,8L,10L,12L,14L,32L,36L,40L,44L,72L,52L,56L,90L,64L,102L,144L,38L,120L,168L,132L,138L,240L,200L,156L,270L,168L,174L,360L,124L,320L,396L,136L,350L,432L,296L,380L,546L,320L,328L,672L,344L,352L,810L,368L,376L,672L,294L,600L,816L,520L,530L,864L,660L,784L,1140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154786Inst : IEnumerable<long>
{
public static readonly long[] Value=A154786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154786.Bytes);
public long this[int i]=>Value[i];

public static A154786Inst Instance=new A154786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154787
{
public static readonly long[] Value={ 0L,0L,0L,4L,5L,6L,7L,16L,18L,20L,22L,36L,26L,28L,45L,32L,51L,72L,19L,60L,84L,66L,69L,120L,100L,78L,135L,84L,87L,180L,62L,160L,198L,68L,175L,216L,148L,190L,273L,160L,164L,336L,172L,176L,405L,184L,188L,336L,147L,300L,408L,260L,265L,432L,330L,392L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154787Inst : IEnumerable<long>
{
public static readonly long[] Value=A154787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154787.Bytes);
public long this[int i]=>Value[i];

public static A154787Inst Instance=new A154787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154788
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,12L,24L,40L,48L,56L,128L,144L,192L,256L,384L,480L,576L,768L,1536L,4608L,6144L,6912L,15360L,36864L,294912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154788Inst : IEnumerable<long>
{
public static readonly long[] Value=A154788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154788.Bytes);
public long this[int i]=>Value[i];

public static A154788Inst Instance=new A154788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154789
{
public static readonly long[] Value={ 1L,2L,7L,9L,15L,19L,21L,39L,59L,66L,75L,96L,124L,125L,180L,327L,358L,434L,699L,999L,1685L,1779L,3561L,4184L,4835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154789Inst : IEnumerable<long>
{
public static readonly long[] Value=A154789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154789.Bytes);
public long this[int i]=>Value[i];

public static A154789Inst Instance=new A154789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154790
{
public static readonly BigInteger[] Value={ 1L,2L,15L,30L,176L,490L,792L,31185L,831820L,2323520L,8118264L,118114304L,2841940500L,3163127352L,684957390936L,60105349839666544L,471314064268398780L,BigInteger.Parse("52527070729108240605"),BigInteger.Parse("57601805366500810491219000") };
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
public class A154790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154790Inst Instance=new A154790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154791
{
public static readonly long[] Value={ 0L,1L,3L,1L,0L,5L,1L,3L,5L,7L,0L,3L,0L,7L,0L,1L,0L,5L,7L,0L,11L,1L,3L,0L,0L,0L,11L,13L,0L,3L,5L,0L,0L,11L,13L,0L,1L,0L,5L,7L,0L,11L,13L,0L,17L,1L,3L,0L,7L,0L,0L,13L,0L,17L,19L,0L,3L,5L,0L,0L,0L,0L,0L,17L,19L,0L,1L,0L,5L,7L,0L,11L,13L,0L,17L,19L,0L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154791Inst : IEnumerable<long>
{
public static readonly long[] Value=A154791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154791.Bytes);
public long this[int i]=>Value[i];

public static A154791Inst Instance=new A154791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154792
{
public static readonly long[] Value={ 0L,1L,3L,1L,0L,5L,0L,3L,5L,0L,0L,3L,0L,7L,0L,0L,0L,5L,7L,0L,0L,0L,3L,0L,0L,0L,11L,0L,0L,0L,5L,0L,0L,11L,0L,0L,0L,0L,0L,7L,0L,11L,0L,0L,0L,0L,0L,0L,7L,0L,0L,13L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154792Inst : IEnumerable<long>
{
public static readonly long[] Value=A154792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154792.Bytes);
public long this[int i]=>Value[i];

public static A154792Inst Instance=new A154792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154793
{
public static readonly long[] Value={ 1L,4L,2L,4L,8L,2L,8L,7L,4L,8L,4L,3L,2L,0L,8L,8L,7L,0L,6L,0L,5L,6L,7L,0L,8L,3L,1L,2L,0L,0L,5L,1L,6L,2L,1L,1L,7L,1L,9L,1L,0L,2L,8L,6L,5L,1L,0L,9L,1L,2L,5L,4L,8L,0L,0L,1L,5L,8L,3L,0L,5L,8L,3L,1L,1L,6L,3L,4L,7L,0L,3L,2L,1L,4L,3L,7L,0L,3L,7L,3L,7L,8L,6L,5L,5L,4L,9L,6L,2L,6L,2L,1L,9L,9L,0L,9L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154793Inst : IEnumerable<long>
{
public static readonly long[] Value=A154793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154793.Bytes);
public long this[int i]=>Value[i];

public static A154793Inst Instance=new A154793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154794
{
public static readonly long[] Value={ 1L,2L,0L,4L,1L,1L,9L,9L,8L,2L,6L,5L,5L,9L,2L,4L,7L,8L,0L,8L,5L,4L,9L,5L,5L,5L,7L,8L,8L,9L,7L,9L,7L,2L,1L,0L,7L,0L,7L,2L,7L,5L,9L,5L,2L,5L,8L,4L,8L,4L,3L,4L,1L,6L,5L,2L,4L,1L,7L,0L,9L,8L,4L,4L,5L,0L,8L,4L,3L,2L,7L,5L,7L,0L,9L,7L,6L,9L,8L,0L,3L,7L,9L,4L,7L,7L,0L,9L,0L,0L,8L,4L,7L,2L,7L,4L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154794Inst : IEnumerable<long>
{
public static readonly long[] Value=A154794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154794.Bytes);
public long this[int i]=>Value[i];

public static A154794Inst Instance=new A154794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154795
{
public static readonly long[] Value={ 1L,3L,7L,15L,101L,297L,1255L,4565L,10143L,14883L,21637L,31185L,44583L,63261L,173525L,239943L,329931L,1121505L,1505499L,2679689L,3554345L,4697205L,6185689L,10619863L,18004327L,23338469L,30167357L,38887673L,49995925L,64112359L,82010177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154795Inst : IEnumerable<long>
{
public static readonly long[] Value=A154795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154795.Bytes);
public long this[int i]=>Value[i];

public static A154795Inst Instance=new A154795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154796
{
public static readonly long[] Value={ 30L,56L,176L,490L,792L,1958L,3010L,6842L,89134L,124754L,451276L,614154L,831820L,2012558L,8118264L,13848650L,133230930L,214481126L,271248950L,541946240L,851376628L,1327710076L,3163127352L,4835271870L,5964539504L,7346629512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154796Inst : IEnumerable<long>
{
public static readonly long[] Value=A154796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154796.Bytes);
public long this[int i]=>Value[i];

public static A154796Inst Instance=new A154796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154797
{
public static readonly long[] Value={ 1L,5L,11L,77L,135L,231L,385L,627L,1575L,8349L,17977L,26015L,75175L,147273L,281589L,386155L,526823L,966467L,3087735L,5392783L,9289091L,20506255L,44108109L,56634173L,72533807L,241265379L,304801365L,952050665L,1482074143L,6620830889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154797Inst : IEnumerable<long>
{
public static readonly long[] Value=A154797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154797.Bytes);
public long this[int i]=>Value[i];

public static A154797Inst Instance=new A154797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154798
{
public static readonly long[] Value={ 2L,22L,42L,1002L,2436L,3718L,5604L,12310L,37338L,53174L,105558L,204226L,715220L,1300156L,1741630L,2323520L,4087968L,7089500L,12132164L,15796476L,26543660L,34262962L,92669720L,118114304L,150198136L,190569292L,384276336L,483502844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154798Inst : IEnumerable<long>
{
public static readonly long[] Value=A154798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154798.Bytes);
public long this[int i]=>Value[i];

public static A154798Inst Instance=new A154798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154799
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,19L,20L,21L,24L,28L,31L,33L,41L,42L,44L,52L,58L,69L,73L,76L,83L,92L,98L,115L,129L,138L,139L,154L,164L,165L,166L,172L,190L,198L,218L,223L,241L,268L,274L,292L,304L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154799Inst : IEnumerable<long>
{
public static readonly long[] Value=A154799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154799.Bytes);
public long this[int i]=>Value[i];

public static A154799Inst Instance=new A154799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154800
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,3L,5L,3L,7L,5L,7L,3L,11L,5L,11L,7L,11L,7L,13L,5L,17L,11L,13L,7L,19L,11L,17L,13L,17L,13L,19L,11L,23L,17L,19L,7L,31L,17L,23L,19L,23L,13L,31L,17L,29L,19L,29L,19L,31L,23L,29L,23L,31L,19L,37L,17L,41L,29L,31L,19L,43L,23L,41L,29L,37L,31L,37L,29L,41L,31L,41L,31L,43L,29L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154800Inst : IEnumerable<long>
{
public static readonly long[] Value=A154800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154800.Bytes);
public long this[int i]=>Value[i];

public static A154800Inst Instance=new A154800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154801
{
public static readonly long[] Value={ 1L,1L,5L,6L,2L,5L,9L,3L,0L,5L,2L,7L,1L,5L,5L,1L,4L,3L,7L,0L,6L,4L,8L,4L,4L,0L,3L,0L,8L,0L,1L,0L,5L,4L,2L,6L,4L,7L,6L,5L,1L,7L,8L,4L,6L,3L,9L,4L,2L,7L,8L,4L,0L,1L,4L,5L,0L,5L,3L,6L,6L,2L,7L,1L,1L,9L,4L,1L,2L,6L,3L,3L,4L,2L,2L,7L,6L,6L,3L,0L,8L,7L,7L,3L,1L,9L,0L,8L,3L,6L,6L,1L,5L,6L,7L,9L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154801Inst : IEnumerable<long>
{
public static readonly long[] Value=A154801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154801.Bytes);
public long this[int i]=>Value[i];

public static A154801Inst Instance=new A154801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154802
{
public static readonly long[] Value={ 1L,1L,1L,5L,7L,7L,1L,7L,8L,2L,6L,0L,4L,5L,1L,9L,3L,7L,2L,7L,6L,4L,1L,7L,6L,3L,2L,4L,1L,5L,1L,5L,4L,2L,4L,1L,2L,4L,1L,9L,1L,7L,7L,3L,5L,0L,3L,8L,5L,8L,9L,2L,2L,7L,1L,8L,9L,0L,7L,8L,4L,0L,1L,3L,6L,3L,3L,1L,0L,6L,0L,2L,0L,9L,6L,1L,8L,7L,0L,2L,3L,6L,3L,2L,2L,7L,8L,8L,8L,6L,9L,4L,0L,1L,4L,5L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154802Inst : IEnumerable<long>
{
public static readonly long[] Value=A154802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154802.Bytes);
public long this[int i]=>Value[i];

public static A154802Inst Instance=new A154802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154803
{
public static readonly long[] Value={ 1L,0L,8L,0L,9L,5L,2L,6L,1L,7L,7L,0L,9L,2L,7L,8L,9L,6L,5L,1L,7L,6L,4L,3L,2L,0L,1L,3L,8L,0L,2L,5L,6L,9L,1L,7L,7L,5L,9L,4L,5L,7L,6L,8L,0L,9L,2L,5L,4L,7L,2L,4L,5L,9L,7L,6L,1L,1L,1L,2L,9L,9L,2L,2L,6L,9L,4L,7L,0L,2L,7L,7L,4L,9L,3L,7L,8L,1L,2L,4L,8L,1L,2L,1L,2L,3L,3L,1L,5L,9L,7L,5L,0L,0L,5L,0L,8L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154803Inst : IEnumerable<long>
{
public static readonly long[] Value=A154803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154803.Bytes);
public long this[int i]=>Value[i];

public static A154803Inst Instance=new A154803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154804
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,2L,3L,3L,2L,4L,2L,2L,4L,3L,3L,4L,2L,3L,5L,4L,3L,6L,4L,3L,6L,3L,3L,7L,3L,5L,6L,3L,5L,7L,5L,5L,7L,5L,4L,9L,4L,4L,10L,4L,4L,7L,4L,6L,9L,6L,5L,9L,7L,7L,11L,6L,5L,12L,3L,5L,10L,4L,7L,10L,5L,5L,9L,8L,7L,11L,5L,5L,13L,5L,8L,11L,5L,8L,10L,6L,5L,14L,9L,6L,12L,7L,6L,15L,7L,8L,13L,5L,8L,12L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154804Inst : IEnumerable<long>
{
public static readonly long[] Value=A154804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154804.Bytes);
public long this[int i]=>Value[i];

public static A154804Inst Instance=new A154804Inst();

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