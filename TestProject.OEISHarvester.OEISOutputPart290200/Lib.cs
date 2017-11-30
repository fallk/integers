using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A279636
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,5L,1L,1L,5L,10L,15L,1L,1L,9L,22L,41L,52L,1L,1L,17L,52L,125L,196L,203L,1L,1L,33L,130L,413L,836L,1057L,877L,1L,1L,65L,340L,1445L,3916L,6277L,6322L,4140L,1L,1L,129L,922L,5261L,19676L,41077L,52396L,41393L,21147L,1L,1L,257L,2572L,19685L,104116L,288517L,481384L,479593L,293608L,115975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279636Inst : IEnumerable<long>
{
public static readonly long[] Value=A279636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279636.Bytes);
public long this[int i]=>Value[i];

public static A279636Inst Instance=new A279636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279717
{
public static readonly ulong[] Value={ 1L,1L,10L,11L,10100L,111L,1101000L,1001111L,10000L,1110011111L,100100000L,110000111111L,101101000000L,11001111111L,110110010000000L,101100011111111L,11010100000000L,110110100111111111L,111101001000000000L,1101000001111111111L,11001111010000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279717Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279717.Bytes);
public ulong this[int i]=>Value[i];

public static A279717Inst Instance=new A279717Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279718
{
public static readonly long[] Value={ 1L,2L,2L,12L,5L,56L,11L,242L,16L,999L,36L,4035L,90L,16280L,155L,65306L,344L,261723L,606L,1047574L,1510L,4192566L,2422L,16773206L,6030L,67101866L,9476L,268419573L,23824L,1073714391L,37588L,4294902483L,96466L,17179761616L,154327L,68719220948L,392151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279718Inst : IEnumerable<long>
{
public static readonly long[] Value=A279718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279718.Bytes);
public long this[int i]=>Value[i];

public static A279718Inst Instance=new A279718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279719
{
public static readonly long[] Value={ 1L,1L,2L,3L,20L,7L,104L,79L,16L,927L,288L,3135L,2880L,1663L,27776L,22783L,13568L,223743L,250368L,427007L,848896L,1779711L,3622912L,6950911L,14929920L,22323199L,17113088L,184041471L,18300928L,986349567L,363102208L,3410034687L,2520580096L,795475967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279719Inst : IEnumerable<long>
{
public static readonly long[] Value=A279719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279719.Bytes);
public long this[int i]=>Value[i];

public static A279719Inst Instance=new A279719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279720
{
public static readonly BigInteger[] Value={ 1L,0L,111L,0L,11111L,0L,1111111L,0L,111111111L,0L,11111111111L,0L,1111111111111L,0L,111111110011111L,0L,11111111000000111L,11110000L,1111111100110011011L,11110000L,BigInteger.Parse("111111110000000000011"),111111111000L,BigInteger.Parse("11111111111100000001111"),111111110000L };
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
public class A279720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279720Inst Instance=new A279720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279721
{
public static readonly BigInteger[] Value={ 1L,0L,111L,0L,11111L,0L,1111111L,0L,111111111L,0L,11111111111L,0L,1111111111111L,0L,111110011111111L,0L,11100000011111111L,11110000000000L,1101100110011111111L,1111000000000000L,BigInteger.Parse("110000000000011111111"),1111111110000000000L,BigInteger.Parse("11110000000111111111111") };
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
public class A279721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279721Inst Instance=new A279721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279722
{
public static readonly long[] Value={ 1L,0L,7L,0L,31L,0L,127L,0L,511L,0L,2047L,0L,8191L,0L,32671L,0L,130567L,240L,522651L,240L,2088963L,4088L,8386575L,4080L,33546247L,15608L,134184967L,64760L,536739843L,261834L,2140667904L,1047003L,8557953024L,12841179L,34258945536L,65499L,136935505920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279722Inst : IEnumerable<long>
{
public static readonly long[] Value=A279722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279722.Bytes);
public long this[int i]=>Value[i];

public static A279722Inst Instance=new A279722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279723
{
public static readonly long[] Value={ 1L,0L,7L,0L,31L,0L,127L,0L,511L,0L,2047L,0L,8191L,0L,31999L,0L,114943L,15360L,445695L,61440L,1573119L,523264L,7868415L,1044480L,29364223L,8187904L,117444607L,32763904L,402657279L,350220288L,3327L,3684691968L,12543L,14700973056L,50593023L,59054751744L,1044735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279723Inst : IEnumerable<long>
{
public static readonly long[] Value=A279723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279723.Bytes);
public long this[int i]=>Value[i];

public static A279723Inst Instance=new A279723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279724
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,5L,4L,8L,14L,14L,5L,11L,23L,41L,41L,6L,14L,32L,68L,122L,122L,7L,17L,41L,95L,203L,365L,365L,8L,20L,50L,122L,284L,608L,1094L,1094L,9L,23L,59L,149L,365L,851L,1823L,3281L,3281L,10L,26L,68L,176L,446L,1094L,2552L,5468L,9842L,9842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279724Inst : IEnumerable<long>
{
public static readonly long[] Value=A279724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279724.Bytes);
public long this[int i]=>Value[i];

public static A279724Inst Instance=new A279724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279725
{
public static readonly long[] Value={ 0L,168L,2022L,15090L,53160L,196962L,409956L,1096368L,2062140L,4070796L,6674010L,12603174L,18410352L,31642836L,45306438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279725Inst : IEnumerable<long>
{
public static readonly long[] Value=A279725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279725.Bytes);
public long this[int i]=>Value[i];

public static A279725Inst Instance=new A279725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279726
{
public static readonly long[] Value={ 0L,0L,0L,2L,6L,8L,16L,32L,44L,64L,92L,118L,150L,174L,202L,234L,298L,358L,382L,440L,512L,598L,686L,808L,924L,1002L,1130L,1228L,1336L,1480L,1560L,1762L,1966L,2026L,2210L,2426L,2614L,2840L,3132L,3300L,3496L,3812L,4072L,4240L,4616L,4852L,5068L,5402L,5522L,5826L,6234L,6512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279726Inst : IEnumerable<long>
{
public static readonly long[] Value=A279726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279726.Bytes);
public long this[int i]=>Value[i];

public static A279726Inst Instance=new A279726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279727
{
public static readonly long[] Value={ 0L,0L,3L,3L,8L,5L,7L,0L,12L,0L,11L,23L,13L,0L,31L,0L,17L,30L,19L,0L,19L,0L,23L,0L,0L,23L,0L,0L,29L,101L,31L,0L,0L,31L,0L,0L,37L,0L,37L,0L,41L,109L,43L,0L,43L,0L,47L,0L,0L,47L,0L,0L,100L,0L,0L,53L,0L,0L,59L,112L,61L,0L,0L,61L,0L,0L,67L,0L,67L,0L,71L,71L,73L,0L,0L,73L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279727Inst : IEnumerable<long>
{
public static readonly long[] Value=A279727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279727.Bytes);
public long this[int i]=>Value[i];

public static A279727Inst Instance=new A279727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279728
{
public static readonly long[] Value={ 0L,0L,3L,5L,12L,7L,7L,0L,24L,0L,11L,49L,13L,0L,59L,0L,17L,42L,19L,0L,23L,0L,23L,0L,0L,29L,0L,0L,29L,199L,31L,0L,0L,37L,0L,0L,37L,0L,41L,0L,41L,143L,43L,0L,47L,0L,47L,0L,0L,53L,0L,0L,112L,0L,0L,59L,0L,0L,59L,128L,61L,0L,0L,67L,0L,0L,67L,0L,71L,0L,71L,73L,73L,0L,0L,79L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279728Inst : IEnumerable<long>
{
public static readonly long[] Value=A279728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279728.Bytes);
public long this[int i]=>Value[i];

public static A279728Inst Instance=new A279728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279729
{
public static readonly long[] Value={ 0L,0L,6L,8L,20L,12L,14L,0L,36L,0L,22L,72L,26L,0L,90L,0L,34L,72L,38L,0L,42L,0L,46L,0L,0L,52L,0L,0L,58L,300L,62L,0L,0L,68L,0L,0L,74L,0L,78L,0L,82L,252L,86L,0L,90L,0L,94L,0L,0L,100L,0L,0L,212L,0L,0L,112L,0L,0L,118L,240L,122L,0L,0L,128L,0L,0L,134L,0L,138L,0L,142L,144L,146L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279729Inst : IEnumerable<long>
{
public static readonly long[] Value=A279729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279729.Bytes);
public long this[int i]=>Value[i];

public static A279729Inst Instance=new A279729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279730
{
public static readonly long[] Value={ 0L,0L,6L,14L,34L,46L,60L,60L,96L,96L,118L,190L,216L,216L,306L,306L,340L,412L,450L,450L,492L,492L,538L,538L,538L,590L,590L,590L,648L,948L,1010L,1010L,1010L,1078L,1078L,1078L,1152L,1152L,1230L,1230L,1312L,1564L,1650L,1650L,1740L,1740L,1834L,1834L,1834L,1934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279730Inst : IEnumerable<long>
{
public static readonly long[] Value=A279730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279730.Bytes);
public long this[int i]=>Value[i];

public static A279730Inst Instance=new A279730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279731
{
public static readonly long[] Value={ 9L,10L,12L,26L,49L,56L,58L,76L,122L,332L,568L,961L,992L,1018L,2042L,3344L,4336L,8186L,16129L,16256L,32762L,37432L,82704L,227744L,266176L,269072L,299576L,856544L,2097146L,5385812L,8388602L,9834772L,16580864L,17895664L,19173944L,33554426L,34636768L,61008020L,67092481L,67100672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279731Inst : IEnumerable<long>
{
public static readonly long[] Value=A279731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279731.Bytes);
public long this[int i]=>Value[i];

public static A279731Inst Instance=new A279731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279732
{
public static readonly long[] Value={ 1L,2L,6L,8L,24L,30L,48L,120L,240L,720L,840L,1440L,1560L,5040L,10080L,15120L,40320L,45360L,80640L,120960L,362880L,403200L,725760L,1088640L,3628800L,3991680L,7257600L,7620480L,10886400L,39916800L,43545600L,79833600L,119750400L,159667200L,479001600L,958003200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279732Inst : IEnumerable<long>
{
public static readonly long[] Value=A279732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279732.Bytes);
public long this[int i]=>Value[i];

public static A279732Inst Instance=new A279732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279797
{
public static readonly long[] Value={ 6L,23L,31L,34L,23L,29L,20L,9L,11L,8L,6L,4L,4L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279797Inst : IEnumerable<long>
{
public static readonly long[] Value=A279797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279797.Bytes);
public long this[int i]=>Value[i];

public static A279797Inst Instance=new A279797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279798
{
public static readonly long[] Value={ 67L,104743L,8609L,281L,521L,1163L,1436471L,12391L,136343L,1483L,23663L,727L,10453L,2029L,135481883L,7429021L,2059324621L,6864415403L,3716857L,9629L,451358821L,51782483L,62504399L,439322585771L,63337L,128110399L,42209L,59569669L,111486983L,10936129L,31585821557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279798Inst : IEnumerable<long>
{
public static readonly long[] Value=A279798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279798.Bytes);
public long this[int i]=>Value[i];

public static A279798Inst Instance=new A279798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279799
{
public static readonly BigInteger[] Value={ 1L,0L,111L,100L,10001L,10L,1111100L,1000101L,100010000L,101011L,11111000010L,10001001000L,1000100000111L,1011010100L,111110011000001L,100010011101010L,10001000110100000L,10110110011111L,1111100110110010000L,1000100110111000111L,BigInteger.Parse("100010001110101011100") };
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
public class A279799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279799Inst Instance=new A279799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279800
{
public static readonly ulong[] Value={ 1L,0L,111L,10L,10001L,10000L,11111L,10100010L,10001L,1101010000L,1000011111L,100100010L,1110000010001L,101011010000L,100000110011111L,101011100100010L,101100010001L,111110011011010000L,100110110011111L,11100011101100100010UL,1110101011100010001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279800Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279800.Bytes);
public ulong this[int i]=>Value[i];

public static A279800Inst Instance=new A279800Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279801
{
public static readonly long[] Value={ 0L,2L,22L,196L,1848L,16720L,149392L,1317720L,11508016L,99674848L,857347424L,7330950944L,62366312416L,528216075200L,4456342509184L,37466616823680L,314030294836992L,2624804780948864L,21884570459044608L,182051987035756544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279801Inst : IEnumerable<long>
{
public static readonly long[] Value=A279801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279801.Bytes);
public long this[int i]=>Value[i];

public static A279801Inst Instance=new A279801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279802
{
public static readonly BigInteger[] Value={ 2L,22L,740L,19376L,507986L,12910722L,323712032L,8013623436L,196400852184L,4773606700366L,115217934303248L,2764478696453498L,65990691037253840L,1568251660224288550L,BigInteger.Parse("37123381500487456052"),BigInteger.Parse("875734939465031708698") };
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
public class A279802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279802Inst Instance=new A279802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279803
{
public static readonly BigInteger[] Value={ 4L,196L,19376L,1476500L,110514378L,8028037200L,573336320344L,40364489132724L,2810020691400808L,193831137138886892L,13268230089583775030UL,BigInteger.Parse("902385132437593702794"),BigInteger.Parse("61032878082356786970528"),BigInteger.Parse("4108195708114892413443354") };
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
public class A279803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279803Inst Instance=new A279803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279804
{
public static readonly BigInteger[] Value={ 14L,1848L,507986L,110514378L,23500346624L,4849917013896L,982389352238899L,196014655863868720L,BigInteger.Parse("38649854832515938489"),BigInteger.Parse("7547769153037869682662"),BigInteger.Parse("1462240286143581780582744"),BigInteger.Parse("281381292175354349182558964") };
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
public class A279804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279804Inst Instance=new A279804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279805
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,2L,4L,22L,22L,4L,14L,196L,740L,196L,14L,40L,1848L,19376L,19376L,1848L,40L,120L,16720L,507986L,1476500L,507986L,16720L,120L,352L,149392L,12910722L,110514378L,110514378L,12910722L,149392L,352L,1032L,1317720L,323712032L,8028037200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279805Inst : IEnumerable<long>
{
public static readonly long[] Value=A279805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279805.Bytes);
public long this[int i]=>Value[i];

public static A279805Inst Instance=new A279805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279806
{
public static readonly long[] Value={ 1L,0L,7L,4L,17L,2L,124L,69L,272L,43L,1986L,1096L,4359L,724L,31937L,17642L,70048L,11679L,511376L,282055L,1121628L,185365L,8176448L,4520767L,17927136L,2986535L,130918732L,72188429L,287160764L,47557031L,2093056404L,1155903937L,4591303512L,763603739L,33516323706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279806Inst : IEnumerable<long>
{
public static readonly long[] Value=A279806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279806.Bytes);
public long this[int i]=>Value[i];

public static A279806Inst Instance=new A279806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279807
{
public static readonly long[] Value={ 1L,0L,7L,2L,17L,16L,31L,162L,17L,848L,543L,290L,7185L,2768L,16799L,22306L,2833L,255696L,19871L,932642L,481041L,2755280L,90527L,16572194L,1024785L,59844304L,26520991L,184818466L,129218321L,962947792L,348176799L,2207098658L,901458705L,14551549648L,12717845919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279807Inst : IEnumerable<long>
{
public static readonly long[] Value=A279807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279807.Bytes);
public long this[int i]=>Value[i];

public static A279807Inst Instance=new A279807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279808
{
public static readonly long[] Value={ 1L,1L,101L,101L,10101L,10101L,1010101L,1010101L,101000001L,101111101L,10101000101L,10101110101L,1010001010101L,1011101010101L,101010101000101L,101010101111101L,10100000101000101L,10111110101110101L,1010100010001010001L,1010111010101011101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279808Inst : IEnumerable<long>
{
public static readonly long[] Value=A279808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279808.Bytes);
public long this[int i]=>Value[i];

public static A279808Inst Instance=new A279808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279809
{
public static readonly ulong[] Value={ 1L,10L,101L,1010L,10101L,101010L,1010101L,10101010L,100000101L,1011111010L,10100010101L,101011101010L,1010101000101L,10101010111010L,101000101010101L,1011111010101010L,10100010100000101L,101011101011111010L,1000101000100010101L,10111010101011101010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279809Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279809.Bytes);
public ulong this[int i]=>Value[i];

public static A279809Inst Instance=new A279809Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279810
{
public static readonly long[] Value={ 1L,1L,5L,5L,21L,21L,85L,85L,321L,381L,1349L,1397L,5205L,5973L,21829L,21885L,82245L,97653L,345169L,357725L,1332565L,1529173L,5587265L,5600605L,21058581L,24991701L,88364101L,91576149L,341071173L,391632213L,1430541573L,1434277365L,5390013717L,6400341365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279810Inst : IEnumerable<long>
{
public static readonly long[] Value=A279810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279810.Bytes);
public long this[int i]=>Value[i];

public static A279810Inst Instance=new A279810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279811
{
public static readonly long[] Value={ 1L,2L,5L,10L,21L,42L,85L,170L,261L,762L,1301L,2794L,5445L,10938L,20821L,48810L,83205L,178938L,282901L,764650L,1398085L,2796218L,4276565L,12234410L,22041861L,45067002L,85020949L,179219178L,341132613L,715848378L,1347752277L,2947202730L,5659247877L,11722750714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279811Inst : IEnumerable<long>
{
public static readonly long[] Value=A279811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279811.Bytes);
public long this[int i]=>Value[i];

public static A279811Inst Instance=new A279811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279812
{
public static readonly long[] Value={ 440L,568L,2368L,2420L,5240L,5848L,10040L,11128L,12464L,12736L,21488L,21712L,24570L,29190L,34592L,36832L,126040L,133856L,133984L,134190L,139230L,142290L,152168L,159500L,175266L,177460L,200970L,244530L,244736L,246304L,248310L,279630L,283328L,284620L,306352L,337460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279812Inst : IEnumerable<long>
{
public static readonly long[] Value=A279812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279812.Bytes);
public long this[int i]=>Value[i];

public static A279812Inst Instance=new A279812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279877
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1100L,111L,111000L,1111L,11110000L,11111L,1111100000L,111111L,111111000000L,1111111L,11111110000000L,11111111L,1111111100000000L,111111111L,111111111000000000L,1111111111L,11111111110000000000UL,11111111111L,BigInteger.Parse("1111111111100000000000"),111111111111L };
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
public class A279877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279877Inst Instance=new A279877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279878
{
public static readonly BigInteger[] Value={ 1L,1L,10L,11L,11100L,111L,1111000L,1111L,111110000L,11111L,11111100000L,111111L,1111111000000L,1111111L,111111110000000L,11111111L,11111111100000000L,111111111L,1111111111000000000L,1111111111L,BigInteger.Parse("111111111110000000000"),11111111111L,BigInteger.Parse("11111111111100000000000") };
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
public class A279878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279878Inst Instance=new A279878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279879
{
public static readonly long[] Value={ 1L,2L,2L,12L,7L,56L,15L,240L,31L,992L,63L,4032L,127L,16256L,255L,65280L,511L,261632L,1023L,1047552L,2047L,4192256L,4095L,16773120L,8191L,67100672L,16383L,268419072L,32767L,1073709056L,65535L,4294901760L,131071L,17179738112L,262143L,68719214592L,524287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279879Inst : IEnumerable<long>
{
public static readonly long[] Value=A279879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279879.Bytes);
public long this[int i]=>Value[i];

public static A279879Inst Instance=new A279879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279880
{
public static readonly long[] Value={ 1L,1L,2L,3L,28L,7L,120L,15L,496L,31L,2016L,63L,8128L,127L,32640L,255L,130816L,511L,523776L,1023L,2096128L,2047L,8386560L,4095L,33550336L,8191L,134209536L,16383L,536854528L,32767L,2147450880L,65535L,8589869056L,131071L,34359607296L,262143L,137438691328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279880Inst : IEnumerable<long>
{
public static readonly long[] Value=A279880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279880.Bytes);
public long this[int i]=>Value[i];

public static A279880Inst Instance=new A279880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279881
{
public static readonly BigInteger[] Value={ 1L,8L,1056L,5529600L,2040024268800L,BigInteger.Parse("82038030902231040000"),BigInteger.Parse("512596445591262883479552000000"),BigInteger.Parse("671373457257855830831011844849664000000000"),BigInteger.Parse("238977230623673235057124486022413812190150656000000000000") };
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
public class A279881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279881Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279881.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279881Inst Instance=new A279881Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279882
{
public static readonly BigInteger[] Value={ 7L,15L,63L,255L,4095L,16383L,262143L,1048575L,16777215L,1073741823L,4294967295L,274877906943L,4398046511103L,17592186044415L,281474976710655L,18014398509481983L,1152921504606846975L,4611686018427387903L,BigInteger.Parse("295147905179352825855"),BigInteger.Parse("4722366482869645213695") };
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
public class A279882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279882Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279882.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279882Inst Instance=new A279882Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279883
{
public static readonly BigInteger[] Value={ 2L,17L,BigInteger.Parse("185302018885184100000000000000000000000000000001") };
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
public class A279883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279883Inst Instance=new A279883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279884
{
public static readonly BigInteger[] Value={ 2L,17L,4097L,1679617L,1000000000001L,1283918464548865L,BigInteger.Parse("4722366482869645213697"),BigInteger.Parse("12748236216396078174437377"),BigInteger.Parse("165251092644282265779977014214657"),BigInteger.Parse("25986090120790645892257018950637850957185025"),BigInteger.Parse("185302018885184100000000000000000000000000000001") };
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
public class A279884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279884Inst Instance=new A279884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279885
{
public static readonly long[] Value={ 3L,33L,141L,3993L,46264L,999999L,1736371L,23911932L,398989893L,136776310L,21348884312L,450197791054L,9475082805749L,95715977951759L,697763767367796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279885Inst : IEnumerable<long>
{
public static readonly long[] Value=A279885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279885.Bytes);
public long this[int i]=>Value[i];

public static A279885Inst Instance=new A279885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279886
{
public static readonly BigInteger[] Value={ 1L,4L,66L,7200L,6917400L,72442188000L,9822893856930000L,BigInteger.Parse("19942863749656848000000"),BigInteger.Parse("687732249521129504041350000000"),BigInteger.Parse("450437284567157389148103391935000000000"),BigInteger.Parse("6194243041031315772374678081343893262937500000000") };
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
public class A279886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279886Inst Instance=new A279886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279887
{
public static readonly BigInteger[] Value={ 1L,1L,4L,16L,153L,71838L,5965398L,2614508085L,9822629511079L,28751930151895611L,BigInteger.Parse("155212395372255675054") };
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
public class A279887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279887Inst Instance=new A279887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279888
{
public static readonly long[] Value={ 0L,1L,42L,569L,4250L,22006L,88004L,293369L,845358L,2186376L,5145646L,11282966L,23143198L,45179324L,83905292L,150271993L,258816840L,433786483L,704268402L,1119633944L,1733618768L,2640037170L,3931060364L,5777392406L,8325691750L,11873200964L,16643954724L,23133008124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279888Inst : IEnumerable<long>
{
public static readonly long[] Value=A279888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279888.Bytes);
public long this[int i]=>Value[i];

public static A279888Inst Instance=new A279888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279889
{
public static readonly long[] Value={ 0L,1L,66L,1577L,18218L,135550L,738236L,3207785L,11714718L,37347144L,106499470L,277489886L,668981686L,1512360404L,3228797252L,6570019945L,12793050456L,24001960051L,43483452090L,76485144056L,130752372320L,218220937122L,355664809556L,568293832670L,889969136158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279889Inst : IEnumerable<long>
{
public static readonly long[] Value=A279889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279889.Bytes);
public long this[int i]=>Value[i];

public static A279889Inst Instance=new A279889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279890
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,12L,19L,31L,50L,82L,133L,216L,349L,565L,914L,1480L,2395L,3876L,6271L,10147L,16418L,26566L,42985L,69552L,112537L,182089L,294626L,476716L,771343L,1248060L,2019403L,3267463L,5286866L,8554330L,13841197L,22395528L,36236725L,58632253L,94868978L,153501232L,248370211L,401871444L,650241655L,1052113099L,1702354754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279890Inst : IEnumerable<long>
{
public static readonly long[] Value=A279890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279890.Bytes);
public long this[int i]=>Value[i];

public static A279890Inst Instance=new A279890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279891
{
public static readonly long[] Value={ 0L,2L,2L,4L,4L,4L,6L,6L,6L,6L,8L,8L,8L,8L,8L,10L,10L,10L,10L,10L,10L,12L,12L,12L,12L,12L,12L,12L,14L,14L,14L,14L,14L,14L,14L,14L,16L,16L,16L,16L,16L,16L,16L,16L,16L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279891Inst : IEnumerable<long>
{
public static readonly long[] Value=A279891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279891.Bytes);
public long this[int i]=>Value[i];

public static A279891Inst Instance=new A279891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279892
{
public static readonly BigInteger[] Value={ 43867L,-28728L,-3765465144L,-3709938631392L,-493547047383096L,-21917724609403728L,-486272786232443616L,-6683009405824511424L,BigInteger.Parse("-64690198594597187640"),BigInteger.Parse("-479102079577959825624"),BigInteger.Parse("-2872821917728374840144"),BigInteger.Parse("-14520482234727711482016"),BigInteger.Parse("-63736746640768788267744") };
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
public class A279892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279892Inst Instance=new A279892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279957
{
public static readonly long[] Value={ 1L,1L,5L,7L,20L,29L,85L,125L,325L,479L,1360L,2007L,5188L,7669L,21781L,32085L,83013L,122741L,348497L,513493L,1328449L,1964029L,5575685L,8214519L,21234708L,31454677L,89134401L,131587581L,340022533L,503184757L,1426392145L,2104849909L,5441082641L,8042575189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279957Inst : IEnumerable<long>
{
public static readonly long[] Value=A279957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279957.Bytes);
public long this[int i]=>Value[i];

public static A279957Inst Instance=new A279957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279958
{
public static readonly long[] Value={ 1L,2L,5L,14L,5L,46L,85L,190L,325L,1006L,85L,3774L,1093L,11246L,21589L,43710L,83013L,179182L,283733L,703166L,1070149L,3144686L,5248085L,15723198L,5259333L,45006830L,68501589L,201047742L,336938053L,732950510L,1158697045L,2947460798L,4585690181L,11454639086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279958Inst : IEnumerable<long>
{
public static readonly long[] Value=A279958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279958.Bytes);
public long this[int i]=>Value[i];

public static A279958Inst Instance=new A279958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279959
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1100L,111L,111100L,111L,11111100L,111L,1111111100L,111L,111111111100L,111L,11111111111100L,111L,1111111111111100L,111L,111111111111111100L,111L,11111111111111111100UL,111L,BigInteger.Parse("1111111111111111111100"),111L,BigInteger.Parse("111111111111111111111100"),111L };
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
public class A279959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279959Inst Instance=new A279959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279960
{
public static readonly BigInteger[] Value={ 1L,1L,10L,11L,11100L,1111L,1110000L,111111L,111000000L,11111111L,11100000000L,1111111111L,1110000000000L,111111111111L,111000000000000L,11111111111111L,11100000000000000L,1111111111111111L,1110000000000000000L,111111111111111111L,BigInteger.Parse("111000000000000000000") };
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
public class A279960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279960Inst Instance=new A279960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279961
{
public static readonly long[] Value={ 1L,2L,2L,12L,7L,60L,7L,252L,7L,1020L,7L,4092L,7L,16380L,7L,65532L,7L,262140L,7L,1048572L,7L,4194300L,7L,16777212L,7L,67108860L,7L,268435452L,7L,1073741820L,7L,4294967292L,7L,17179869180L,7L,68719476732L,7L,274877906940L,7L,1099511627772L,7L,4398046511100L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279961Inst : IEnumerable<long>
{
public static readonly long[] Value=A279961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279961.Bytes);
public long this[int i]=>Value[i];

public static A279961Inst Instance=new A279961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279962
{
public static readonly long[] Value={ 1L,1L,2L,3L,28L,15L,112L,63L,448L,255L,1792L,1023L,7168L,4095L,28672L,16383L,114688L,65535L,458752L,262143L,1835008L,1048575L,7340032L,4194303L,29360128L,16777215L,117440512L,67108863L,469762048L,268435455L,1879048192L,1073741823L,7516192768L,4294967295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279962Inst : IEnumerable<long>
{
public static readonly long[] Value=A279962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279962.Bytes);
public long this[int i]=>Value[i];

public static A279962Inst Instance=new A279962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279963
{
public static readonly long[] Value={ 0L,8L,12L,15L,16L,18L,20L,21L,24L,27L,28L,30L,32L,33L,35L,36L,39L,40L,42L,44L,45L,48L,51L,52L,55L,56L,57L,60L,63L,64L,65L,66L,68L,69L,70L,72L,75L,76L,77L,78L,80L,84L,85L,86L,87L,88L,90L,91L,92L,93L,95L,96L,98L,99L,100L,102L,104L,105L,108L,110L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279963Inst : IEnumerable<long>
{
public static readonly long[] Value=A279963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279963.Bytes);
public long this[int i]=>Value[i];

public static A279963Inst Instance=new A279963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279964
{
public static readonly long[] Value={ 0L,1L,138L,3377L,39890L,297550L,1623980L,7065329L,25808790L,82305816L,234756742L,611706830L,1474831246L,3334313204L,7118797268L,14485772017L,28206850488L,52921773667L,95877425634L,168644231672L,288301373792L,481166453010L,784226941604L,1253068878542L,1962356045590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279964Inst : IEnumerable<long>
{
public static readonly long[] Value=A279964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279964.Bytes);
public long this[int i]=>Value[i];

public static A279964Inst Instance=new A279964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279965
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,1L,5L,2L,2L,2L,5L,3L,4L,3L,4L,3L,8L,4L,4L,3L,5L,3L,7L,3L,9L,4L,4L,3L,8L,6L,6L,8L,6L,11L,4L,4L,8L,8L,5L,9L,7L,7L,7L,5L,6L,5L,6L,8L,8L,12L,9L,7L,8L,5L,7L,5L,7L,8L,12L,9L,13L,5L,15L,8L,6L,5L,10L,9L,6L,12L,8L,13L,11L,8L,12L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279965Inst : IEnumerable<long>
{
public static readonly long[] Value=A279965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279965.Bytes);
public long this[int i]=>Value[i];

public static A279965Inst Instance=new A279965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279966
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,4L,2L,5L,1L,5L,2L,5L,2L,5L,4L,5L,0L,4L,1L,9L,2L,5L,0L,6L,6L,3L,4L,6L,2L,7L,1L,6L,4L,6L,5L,11L,2L,4L,2L,10L,1L,8L,2L,10L,3L,7L,0L,9L,4L,6L,3L,5L,1L,9L,5L,8L,0L,5L,1L,14L,4L,4L,2L,10L,7L,8L,2L,4L,2L,11L,3L,16L,3L,6L,7L,8L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279966Inst : IEnumerable<long>
{
public static readonly long[] Value=A279966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279966.Bytes);
public long this[int i]=>Value[i];

public static A279966Inst Instance=new A279966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279967
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,7L,2L,9L,10L,15L,2L,10L,1L,13L,17L,8L,0L,13L,1L,14L,9L,8L,0L,13L,3L,30L,13L,10L,2L,16L,1L,23L,5L,7L,14L,15L,2L,8L,28L,32L,2L,23L,2L,9L,49L,12L,0L,48L,2L,11L,1L,20L,3L,18L,13L,28L,0L,4L,1L,56L,5L,8L,16L,35L,46L,4L,2L,6L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279967Inst : IEnumerable<long>
{
public static readonly long[] Value=A279967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279967.Bytes);
public long this[int i]=>Value[i];

public static A279967Inst Instance=new A279967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279968
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,0L,3L,1L,4L,2L,3L,3L,5L,3L,4L,2L,3L,5L,5L,4L,7L,2L,4L,5L,5L,6L,8L,3L,5L,4L,5L,10L,7L,7L,7L,7L,5L,5L,5L,9L,6L,12L,6L,8L,9L,4L,5L,8L,6L,6L,10L,9L,9L,7L,10L,4L,6L,8L,8L,5L,13L,9L,9L,12L,12L,8L,7L,6L,7L,8L,10L,9L,10L,12L,7L,11L,14L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279968Inst : IEnumerable<long>
{
public static readonly long[] Value=A279968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279968.Bytes);
public long this[int i]=>Value[i];

public static A279968Inst Instance=new A279968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279969
{
public static readonly BigInteger[] Value={ 1L,2L,4L,64L,BigInteger.Parse("2085924839766513752338888384931203236916703635113918720651407820138886450957656787131798913024") };
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
public class A279969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279969Inst Instance=new A279969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279970
{
public static readonly BigInteger[] Value={ 0L,3L,50L,1922L,124030L,14787217L,3444870482L,1641425782980L,1628526202127628L,3404399281023205196L,BigInteger.Parse("15152580196285407820510") };
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
public class A279970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279970Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279970.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279970Inst Instance=new A279970Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279971
{
public static readonly long[] Value={ 1L,3L,9L,31L,108L,366L,1205L,3873L,12207L,37859L,115842L,350412L,1049545L,3116655L,9185349L,26890375L,78253896L,226510362L,652483133L,1871302893L,5345409483L,15213423371L,43153001406L,122024489304L,344061371665L,967537410459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279971Inst : IEnumerable<long>
{
public static readonly long[] Value=A279971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279971.Bytes);
public long this[int i]=>Value[i];

public static A279971Inst Instance=new A279971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279972
{
public static readonly long[] Value={ 0L,9L,50L,296L,1650L,8666L,43543L,211650L,1002602L,4652327L,21225237L,95473540L,424318824L,1866436977L,8136431834L,35191126234L,151149336828L,645183934470L,2738696392197L,11567109056460L,48632928912442L,203627897130121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279972Inst : IEnumerable<long>
{
public static readonly long[] Value=A279972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279972.Bytes);
public long this[int i]=>Value[i];

public static A279972Inst Instance=new A279972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280613
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10100L,10011L,1000000L,101111L,100010000L,10001111L,10001000000L,1000111111L,1010101000000L,1010100111111L,100010000000000L,10001011111111L,10101000100000000L,10100100011111111L,1000000010000000000L,111110001111111111L,BigInteger.Parse("100000001010000000000") };
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
public class A280613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280613Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280613.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280613Inst Instance=new A280613Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280614
{
public static readonly long[] Value={ 1L,0L,1L,12L,5L,50L,1L,244L,17L,964L,17L,4036L,85L,16170L,17L,65348L,277L,261194L,257L,1047676L,1281L,4190844L,69L,16774930L,5201L,67094820L,1L,268427228L,20561L,1073686308L,1L,4294932340L,87377L,17179650724L,21761L,68719291004L,267333L,274876975378L,344385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280614Inst : IEnumerable<long>
{
public static readonly long[] Value=A280614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280614.Bytes);
public long this[int i]=>Value[i];

public static A280614Inst Instance=new A280614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280615
{
public static readonly long[] Value={ 1L,0L,4L,3L,20L,19L,64L,47L,272L,143L,1088L,575L,5440L,5439L,17408L,8959L,86272L,84223L,263168L,254975L,1053696L,1020927L,5308416L,4780031L,18108416L,9588735L,67108864L,62898175L,289488896L,154746879L,1073741824L,787415039L,4652859392L,2505375743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280615Inst : IEnumerable<long>
{
public static readonly long[] Value=A280615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280615.Bytes);
public long this[int i]=>Value[i];

public static A280615Inst Instance=new A280615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280616
{
public static readonly long[] Value={ 3L,4L,9L,8L,16L,18L,26L,32L,24L,36L,42L,44L,48L,66L,70L,60L,74L,72L,94L,106L,84L,90L,102L,112L,130L,108L,126L,114L,166L,160L,150L,144L,184L,218L,174L,208L,168L,220L,138L,222L,232L,204L,216L,262L,302L,268L,234L,252L,246L,240L,264L,276L,306L,270L,340L,318L,294L,312L,342L,336L,406L,330L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280616Inst : IEnumerable<long>
{
public static readonly long[] Value=A280616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280616.Bytes);
public long this[int i]=>Value[i];

public static A280616Inst Instance=new A280616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280617
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,6L,6L,6L,6L,6L,6L,8L,8L,8L,8L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,16L,16L,16L,16L,16L,16L,19L,19L,19L,19L,20L,20L,29L,29L,29L,29L,29L,29L,31L,31L,31L,31L,31L,31L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280617Inst : IEnumerable<long>
{
public static readonly long[] Value=A280617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280617.Bytes);
public long this[int i]=>Value[i];

public static A280617Inst Instance=new A280617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280618
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280618Inst : IEnumerable<long>
{
public static readonly long[] Value=A280618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280618.Bytes);
public long this[int i]=>Value[i];

public static A280618Inst Instance=new A280618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280619
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280619Inst : IEnumerable<long>
{
public static readonly long[] Value=A280619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280619.Bytes);
public long this[int i]=>Value[i];

public static A280619Inst Instance=new A280619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280620
{
public static readonly BigInteger[] Value={ 1L,0L,1L,4L,1L,100L,161L,1764L,22001L,49700L,1649921L,10057124L,105372001L,2044251300L,12879413281L,315936586084L,3892292034001L,49987743460900L,1185027040858241L,13878406361764644L,321536491629592001L,6033371812540110500L,BigInteger.Parse("100320731761080176801"),BigInteger.Parse("2657253524511363224804"),BigInteger.Parse("47170890863193411630001"),BigInteger.Parse("1155602674484930034008100"),BigInteger.Parse("28284869824153625118984961") };
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
public class A280620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280620Inst Instance=new A280620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280621
{
public static readonly BigInteger[] Value={ 1L,0L,1L,0L,1L,20L,1L,420L,1841L,7140L,190001L,555940L,12774881L,141201060L,946212001L,25228809060L,202847031121L,3740829095780L,66881800434001L,733452394335780L,19147386646802561L,273971147946411300L,5322649952666824001L,BigInteger.Parse("124410236296546608100"),BigInteger.Parse("2010649742531247641201"),BigInteger.Parse("53865539929721514523620"),BigInteger.Parse("1113617365649653498950001") };
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
public class A280621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280621Inst Instance=new A280621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280622
{
public static readonly BigInteger[] Value={ 1L,0L,0L,2L,0L,20L,40L,182L,3360L,5320L,165480L,1193962L,7681520L,182657020L,1028347320L,21430373342L,296385660480L,2926954283120L,74104327031560L,836520209938322L,16747875178596240L,336576896391971620L,4854838471934266200L,BigInteger.Parse("128099320528299728902"),BigInteger.Parse("2250302805832188984800"),BigInteger.Parse("49372680864950984970520"),BigInteger.Parse("1245420698064315926211240") };
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
public class A280622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280622Inst Instance=new A280622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280623
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,5L,21L,101L,581L,3605L,29141L,239701L,2205861L,22832005L,246573061L,2990463301L,38108222341L,518783617205L,7633121129781L,116869543894901L,1918479435194021L,33025793008567205L,595507639576003301L,11356021765206934501UL,BigInteger.Parse("224730968057626784901"),BigInteger.Parse("4667903267042610866005"),BigInteger.Parse("101036430792914926153621"),BigInteger.Parse("2269220040134583532958101") };
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
public class A280623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280623Inst Instance=new A280623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280624
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,20L,81L,452L,2765L,19460L,156121L,1368052L,13327125L,141326500L,1616350561L,20040895252L,264759181085L,3740415315140L,56164918735401L,891038080096052L,14957788277468645L,263869908657105380L,4889789934063374641L,BigInteger.Parse("94981373343123194452"),BigInteger.Parse("1926808692484086173805"),BigInteger.Parse("40825113073569433353220"),BigInteger.Parse("900600514588651088444281") };
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
public class A280624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280624Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280624.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280624Inst Instance=new A280624Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280625
{
public static readonly BigInteger[] Value={ 1L,1L,19L,739L,35641L,3753721L,500577499L,91718242219L,22737318482161L,6983681901945841L,2676021948941279779L,BigInteger.Parse("1243547540389481251699"),BigInteger.Parse("686920343453752746986281"),BigInteger.Parse("446624144083900575607651561"),BigInteger.Parse("336962029373243047762784366059"),BigInteger.Parse("292073105918297230422637244241979"),BigInteger.Parse("288329217381806896076167481522680801"),BigInteger.Parse("321507277164646598826580516711872346081"),BigInteger.Parse("402176512693739754388880316622683052031539") };
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
public class A280625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280625Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280625.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280625Inst Instance=new A280625Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280626
{
public static readonly BigInteger[] Value={ 1L,1L,1L,109L,3889L,292681L,37275121L,5709311029L,1254902705569L,350061261777361L,120872805166945441L,BigInteger.Parse("51564789352080559549"),BigInteger.Parse("26284030671328082426449"),BigInteger.Parse("15848108292907342195314841"),BigInteger.Parse("11161807217694742818283238161"),BigInteger.Parse("9067075855589680072656446948869"),BigInteger.Parse("8422853639587133754025283126027329"),BigInteger.Parse("8870217999823146934380010426752373921"),BigInteger.Parse("10511235230699377130222779475407450044481"),BigInteger.Parse("13925615313807886230641992889497147251058189") };
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
public class A280626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280626Inst Instance=new A280626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280627
{
public static readonly BigInteger[] Value={ 1L,0L,6L,120L,4284L,382560L,40975176L,6524350560L,1420005102864L,386400824613120L,133774424157792096L,BigInteger.Parse("56530740636066364800"),BigInteger.Parse("28642309445854790698944"),BigInteger.Parse("17209537237868777504801280"),BigInteger.Parse("12062425479867549597010598016"),BigInteger.Parse("9764667204009505877211747479040"),BigInteger.Parse("9042097280460821686724885486625024"),BigInteger.Parse("9493787529624453974176836837131427840"),BigInteger.Parse("11221110790852570214718646510965006951936"),BigInteger.Parse("14830442526518302962134606954574648582420480") };
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
public class A280627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280627Inst Instance=new A280627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280628
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,19L,109L,739L,3889L,35641L,292681L,3753721L,37275121L,500577499L,5709311029L,91718242219L,1254902705569L,22737318482161L,350061261777361L,6983681901945841L,120872805166945441L,2676021948941279779L,BigInteger.Parse("51564789352080559549"),BigInteger.Parse("1243547540389481251699"),BigInteger.Parse("26284030671328082426449"),BigInteger.Parse("686920343453752746986281"),BigInteger.Parse("15848108292907342195314841"),BigInteger.Parse("446624144083900575607651561") };
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
public class A280628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280628Inst Instance=new A280628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280693
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,29L,31L,35L,37L,41L,43L,47L,49L,50L,52L,53L,55L,59L,61L,65L,66L,67L,71L,73L,77L,79L,83L,85L,89L,91L,95L,97L,101L,103L,107L,109L,113L,115L,119L,121L,127L,131L,133L,137L,139L,143L,149L,151L,157L,161L,163L,167L,169L,173L,179L,181L,186L,187L,191L,193L,197L,199L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280693Inst : IEnumerable<long>
{
public static readonly long[] Value=A280693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280693.Bytes);
public long this[int i]=>Value[i];

public static A280693Inst Instance=new A280693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280694
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,3L,7L,4L,3L,2L,11L,4L,1L,7L,3L,4L,1L,18L,1L,4L,7L,11L,1L,4L,1L,2L,3L,7L,29L,3L,1L,4L,11L,2L,7L,18L,1L,2L,3L,4L,1L,7L,1L,11L,3L,2L,47L,4L,7L,2L,3L,4L,1L,18L,11L,7L,3L,29L,1L,4L,1L,2L,7L,4L,1L,11L,1L,4L,3L,7L,1L,18L,1L,2L,3L,76L,11L,3L,1L,4L,3L,2L,1L,7L,1L,2L,29L,11L,1L,18L,7L,4L,3L,47L,1L,4L,1L,7L,11L,4L,1L,3L,1L,4L,7L,2L,1L,18L,1L,11L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280694Inst : IEnumerable<long>
{
public static readonly long[] Value=A280694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280694.Bytes);
public long this[int i]=>Value[i];

public static A280694Inst Instance=new A280694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280695
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,2L,1L,2L,3L,5L,1L,3L,13L,2L,5L,4L,17L,1L,19L,5L,3L,2L,23L,6L,25L,13L,9L,4L,1L,10L,31L,8L,3L,17L,5L,2L,37L,19L,13L,10L,41L,6L,43L,4L,15L,23L,1L,12L,7L,25L,17L,13L,53L,3L,5L,8L,19L,2L,59L,15L,61L,31L,9L,16L,65L,6L,67L,17L,23L,10L,71L,4L,73L,37L,25L,1L,7L,26L,79L,20L,27L,41L,83L,12L,85L,43L,3L,8L,89L,5L,13L,23L,31L,2L,95L,24L,97L,14L,9L,25L,101L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280695Inst : IEnumerable<long>
{
public static readonly long[] Value=A280695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280695.Bytes);
public long this[int i]=>Value[i];

public static A280695Inst Instance=new A280695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280696
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,1L,4L,3L,2L,1L,4L,1L,7L,3L,4L,1L,3L,1L,4L,7L,11L,1L,4L,1L,2L,3L,7L,1L,3L,1L,4L,11L,2L,7L,18L,1L,2L,3L,4L,1L,7L,1L,11L,3L,2L,1L,4L,7L,2L,3L,4L,1L,18L,11L,7L,3L,29L,1L,4L,1L,2L,7L,4L,1L,11L,1L,4L,3L,7L,1L,18L,1L,2L,3L,4L,11L,3L,1L,4L,3L,2L,1L,7L,1L,2L,29L,11L,1L,18L,7L,4L,3L,47L,1L,4L,1L,7L,11L,4L,1L,3L,1L,4L,7L,2L,1L,18L,1L,11L,3L,7L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280696Inst : IEnumerable<long>
{
public static readonly long[] Value=A280696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280696.Bytes);
public long this[int i]=>Value[i];

public static A280696Inst Instance=new A280696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280697
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,3L,5L,11L,3L,13L,2L,5L,4L,17L,6L,19L,5L,3L,2L,23L,6L,25L,13L,9L,4L,29L,10L,31L,8L,3L,17L,5L,2L,37L,19L,13L,10L,41L,6L,43L,4L,15L,23L,47L,12L,7L,25L,17L,13L,53L,3L,5L,8L,19L,2L,59L,15L,61L,31L,9L,16L,65L,6L,67L,17L,23L,10L,71L,4L,73L,37L,25L,19L,7L,26L,79L,20L,27L,41L,83L,12L,85L,43L,3L,8L,89L,5L,13L,23L,31L,2L,95L,24L,97L,14L,9L,25L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280697Inst : IEnumerable<long>
{
public static readonly long[] Value=A280697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280697.Bytes);
public long this[int i]=>Value[i];

public static A280697Inst Instance=new A280697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280698
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,1L,4L,3L,1L,7L,1L,3L,11L,1L,1L,18L,1L,7L,29L,3L,1L,47L,11L,3L,76L,7L,1L,123L,1L,1L,199L,3L,29L,322L,1L,3L,521L,47L,1L,843L,1L,7L,1364L,3L,1L,2207L,29L,123L,3571L,7L,1L,5778L,199L,47L,9349L,3L,1L,15127L,1L,3L,24476L,1L,521L,39603L,1L,7L,64079L,843L,1L,103682L,1L,3L,167761L,7L,199L,271443L,1L,2207L,439204L,3L,1L,710647L,3571L,3L,1149851L,47L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280698Inst : IEnumerable<long>
{
public static readonly long[] Value=A280698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280698.Bytes);
public long this[int i]=>Value[i];

public static A280698Inst Instance=new A280698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280699
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,1L,7L,2L,11L,1L,18L,1L,29L,2L,47L,1L,76L,1L,123L,2L,199L,1L,322L,1L,521L,2L,843L,1L,1364L,1L,2207L,2L,3571L,1L,5778L,1L,9349L,2L,15127L,1L,24476L,1L,39603L,2L,64079L,1L,103682L,1L,167761L,2L,271443L,1L,439204L,1L,710647L,2L,1149851L,1L,1860498L,1L,3010349L,2L,4870847L,1L,7881196L,1L,12752043L,2L,20633239L,1L,33385282L,1L,54018521L,2L,87403803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280699Inst : IEnumerable<long>
{
public static readonly long[] Value=A280699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280699.Bytes);
public long this[int i]=>Value[i];

public static A280699Inst Instance=new A280699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280700
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,1L,2L,3L,4L,1L,2L,3L,3L,4L,3L,3L,5L,1L,2L,3L,3L,4L,3L,3L,4L,5L,3L,3L,4L,4L,3L,4L,6L,1L,2L,3L,3L,4L,3L,3L,4L,5L,3L,3L,4L,4L,3L,4L,5L,6L,3L,3L,4L,4L,3L,4L,5L,5L,3L,4L,4L,5L,6L,4L,7L,1L,2L,3L,3L,4L,3L,3L,4L,5L,3L,3L,4L,4L,3L,4L,5L,6L,3L,3L,4L,4L,3L,4L,5L,5L,3L,4L,4L,5L,6L,4L,6L,7L,3L,3L,4L,4L,3L,4L,5L,5L,3L,4L,4L,5L,6L,4L,6L,6L,3L,4L,4L,5L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280700Inst : IEnumerable<long>
{
public static readonly long[] Value=A280700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280700.Bytes);
public long this[int i]=>Value[i];

public static A280700Inst Instance=new A280700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280701
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,1L,8L,1L,10L,1L,12L,1L,14L,11L,16L,1L,18L,1L,20L,1L,22L,1L,24L,1L,14L,19L,28L,1L,30L,1L,16L,1L,34L,29L,36L,1L,20L,27L,40L,1L,42L,1L,22L,1L,46L,1L,48L,49L,26L,51L,52L,1L,54L,51L,28L,1L,58L,1L,60L,1L,32L,57L,64L,65L,66L,1L,34L,1L,70L,1L,72L,1L,38L,51L,76L,1L,78L,1L,40L,1L,82L,1L,84L,1L,44L,59L,88L,1L,90L,1L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280701Inst : IEnumerable<long>
{
public static readonly long[] Value=A280701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280701.Bytes);
public long this[int i]=>Value[i];

public static A280701Inst Instance=new A280701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280702
{
public static readonly long[] Value={ 1L,3L,5L,9L,7L,15L,11L,3L,25L,3L,13L,3L,17L,3L,35L,9L,19L,3L,23L,3L,55L,3L,29L,3L,49L,3L,5L,9L,31L,3L,37L,3L,5L,3L,77L,15L,41L,3L,5L,9L,43L,3L,47L,3L,5L,3L,53L,3L,121L,147L,5L,153L,59L,3L,91L,33L,5L,3L,61L,3L,67L,3L,5L,27L,119L,195L,71L,3L,5L,3L,73L,3L,79L,3L,5L,9L,143L,3L,83L,3L,5L,3L,89L,3L,133L,3L,5L,9L,97L,3L,187L,3L,5L,3L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280702Inst : IEnumerable<long>
{
public static readonly long[] Value=A280702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280702.Bytes);
public long this[int i]=>Value[i];

public static A280702Inst Instance=new A280702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280703
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,1L,7L,1L,15L,1L,11L,1L,9L,1L,25L,1L,21L,1L,13L,1L,45L,1L,17L,25L,11L,1L,35L,1L,81L,13L,19L,1L,15L,1L,23L,17L,21L,1L,55L,1L,39L,35L,29L,1L,135L,1L,1L,19L,1L,1L,125L,1L,9L,23L,31L,1L,105L,1L,37L,55L,27L,1L,1L,1L,57L,29L,77L,1L,225L,1L,41L,49L,23L,1L,85L,1L,189L,125L,43L,1L,165L,1L,47L,31L,39L,1L,175L,1L,87L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280703Inst : IEnumerable<long>
{
public static readonly long[] Value=A280703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280703.Bytes);
public long this[int i]=>Value[i];

public static A280703Inst Instance=new A280703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280704
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,7L,1L,9L,1L,11L,1L,13L,1L,5L,1L,17L,1L,19L,1L,21L,1L,23L,1L,25L,13L,9L,1L,29L,1L,31L,17L,33L,1L,7L,1L,37L,19L,13L,1L,41L,1L,43L,23L,45L,1L,47L,1L,1L,25L,1L,1L,53L,1L,5L,29L,57L,1L,59L,1L,61L,31L,7L,1L,1L,1L,67L,35L,69L,1L,71L,1L,73L,37L,25L,1L,77L,1L,79L,41L,81L,1L,83L,1L,85L,43L,29L,1L,89L,1L,91L,47L,93L,1L,19L,1L,97L,49L,33L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280704Inst : IEnumerable<long>
{
public static readonly long[] Value=A280704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280704.Bytes);
public long this[int i]=>Value[i];

public static A280704Inst Instance=new A280704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280705
{
public static readonly long[] Value={ 1L,2L,6L,2L,30L,2L,6L,30L,210L,2L,6L,30L,30L,210L,30L,30L,2310L,2L,6L,30L,30L,210L,30L,30L,210L,2310L,30L,30L,210L,210L,30L,210L,30030L,2L,6L,30L,30L,210L,30L,30L,210L,2310L,30L,30L,210L,210L,30L,210L,2310L,30030L,30L,30L,210L,210L,30L,210L,2310L,2310L,30L,210L,210L,2310L,30030L,210L,510510L,2L,6L,30L,30L,210L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280705Inst : IEnumerable<long>
{
public static readonly long[] Value=A280705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280705.Bytes);
public long this[int i]=>Value[i];

public static A280705Inst Instance=new A280705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280706
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,13L,16L,19L,23L,26L,30L,35L,39L,44L,49L,54L,60L,66L,72L,78L,86L,92L,100L,108L,116L,124L,132L,142L,150L,159L,169L,179L,189L,200L,211L,221L,232L,243L,254L,266L,278L,290L,302L,314L,330L,340L,354L,368L,380L,394L,410L,424L,438L,454L,468L,484L,500L,516L,532L,552L,568L,585L,606L,622L,639L,658L,678L,698L,719L,740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280706Inst : IEnumerable<long>
{
public static readonly long[] Value=A280706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280706.Bytes);
public long this[int i]=>Value[i];

public static A280706Inst Instance=new A280706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280707
{
public static readonly BigInteger[] Value={ 47L,2022L,1011L,337L,111548L,55774L,27887L,353L,123198L,61599L,20533L,421357694L,210678847L,44385566460664754L,22192783230332377L,1707137171564029L,165918667661L,BigInteger.Parse("27529004277737692540278"),BigInteger.Parse("13764502138868846270139"),BigInteger.Parse("4588167379622948756713"),BigInteger.Parse("352935952278688365901"),3237944516318241889L,1577861856421L,BigInteger.Parse("2489648037916767181800822") };
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
public class A280707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280707Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280707.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280707Inst Instance=new A280707Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280708
{
public static readonly long[] Value={ 1L,8L,24L,24L,86L,1260L,1890L,14136L,197400L,10467660L,1231572090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280708Inst : IEnumerable<long>
{
public static readonly long[] Value=A280708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280708.Bytes);
public long this[int i]=>Value[i];

public static A280708Inst Instance=new A280708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280757
{
public static readonly long[] Value={ 0L,2L,1L,8L,6L,31L,31L,122L,149L,488L,687L,1979L,3087L,8115L,13640L,33568L,59588L,139797L,258280L,585208L,1113329L,2459315L,4780244L,10365381L,20466962L,43782453L,87452985L,185231393L,373127431L,784596104L,1590288132L,3326280454L,6772621201L,14110813844L,28826477126L,59889596123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280757Inst : IEnumerable<long>
{
public static readonly long[] Value=A280757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280757.Bytes);
public long this[int i]=>Value[i];

public static A280757Inst Instance=new A280757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280758
{
public static readonly long[] Value={ 1L,2L,6L,13L,32L,75L,178L,422L,999L,2368L,5609L,13290L,31486L,74597L,176736L,418723L,992042L,2350350L,5568463L,13192832L,31256529L,74053138L,175447094L,415670205L,984808096L,2333212667L,5527860066L,13096635958L,31028620727L,73513176000L,174167814073L,412639326842L,977627324334L,2316199942933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280758Inst : IEnumerable<long>
{
public static readonly long[] Value=A280758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280758.Bytes);
public long this[int i]=>Value[i];

public static A280758Inst Instance=new A280758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280759
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,3L,2L,1L,12L,12L,12L,9L,6L,3L,1L,55L,55L,55L,43L,31L,19L,10L,4L,1L,273L,273L,273L,218L,163L,108L,65L,34L,15L,5L,1L,1428L,1428L,1428L,1155L,882L,609L,391L,228L,120L,55L,21L,6L,1L,7752L,7752L,7752L,6324L,4896L,3468L,2313L,1431L,822L,431L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280759Inst : IEnumerable<long>
{
public static readonly long[] Value=A280759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280759.Bytes);
public long this[int i]=>Value[i];

public static A280759Inst Instance=new A280759Inst();

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