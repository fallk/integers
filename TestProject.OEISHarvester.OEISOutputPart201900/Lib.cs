using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277609
{
public static readonly BigInteger[] Value={ 0L,0L,6L,18L,78L,426L,2790L,21234L,183822L,1781802L,19104774L,224406930L,2864826126L,39486808938L,584328412518L,9238767895026L,155416555683150L,2771424197143914L,52216883883837702L,1036463580947218962L,BigInteger.Parse("21616958644969620174"),BigInteger.Parse("472612476001411964970"),BigInteger.Parse("10808196686285486012646") };
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
public class A277609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277609Inst Instance=new A277609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277610
{
public static readonly BigInteger[] Value={ 1L,1L,5L,36L,339L,3999L,57388L,977577L,19348425L,436886364L,11084633347L,312102694743L,9653262860564L,325242329821529L,11853828646799153L,464582888781914004L,BigInteger.Parse("19481645509391087747"),BigInteger.Parse("870252961810204549919"),BigInteger.Parse("41253445365917239409916"),BigInteger.Parse("2068244310629828065675481"),BigInteger.Parse("109336176534540098236055769"),BigInteger.Parse("6078206718063279979791668252"),BigInteger.Parse("354471031348340363987467541507"),BigInteger.Parse("21638266052947649126008431859703"),BigInteger.Parse("1379839169160669434086676475756260") };
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
public class A277610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277610Inst Instance=new A277610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277611
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,27L,180L,1678L,20388L,305331L,5423511L,111282445L,2587931469L,67239205808L,1929910531883L,60636166356164L,2069775112992573L,76268207153351225L,3017346008698599752L,BigInteger.Parse("127561003043924116908"),BigInteger.Parse("5738904556162964523209"),BigInteger.Parse("273764048456544759900846"),BigInteger.Parse("13802374108958236134168506"),BigInteger.Parse("733335098861491664742838394"),BigInteger.Parse("40953333749038944871704984923"),BigInteger.Parse("2398217239830108487402017089693"),BigInteger.Parse("146949291558772355319517897103987") };
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
public class A277611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277611Inst Instance=new A277611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277612
{
public static readonly BigInteger[] Value={ 1L,4L,24L,224L,2880L,47104L,935424L,21853184L,587089920L,17829167104L,603915485184L,22571950997504L,922735222456320L,40954197741666304L,1961183862263906304L,BigInteger.Parse("100787274348058640384"),BigInteger.Parse("5532701353887903252480"),BigInteger.Parse("323102311113161602760704"),BigInteger.Parse("20000832981651983154806784"),BigInteger.Parse("1308180577070098190616756224"),BigInteger.Parse("90146906116103034082689024000"),BigInteger.Parse("6527896185206802934447948693504") };
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
public class A277612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277612Inst Instance=new A277612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277613
{
public static readonly long[] Value={ 1L,7L,19L,47L,76L,145L,183L,319L,433L,762L,1068L,1625L,1457L,511L,-2696L,-7617L,-12494L,-8999L,14802L,78682L,195984L,363458L,530289L,574297L,252976L,-820475L,-3259007L,-7929105L,-15918795L,-27966750L,-42783874L,-52969921L,-37772397L,47098898L,278012363L,759015293L,1583148046L,2729030066L,3860814119L,4015793914L,1214574612L,-7871995868L,-27884564061L,-63760120938L,-117678872282L,-182313402679L,-228194585696L,-183355932567L,93528356566L,836233409412L,2360489258476L,4956621402741L,8577450776595L,12176709992155L,12572248705543L,2874527812671L,-29026344726969L,-100513507605919L,-229939345736773L,-423043591887710L,-643162163240861L,-757839109104688L,-458886747576888L,831588355306815L,4020413344163097L,10249469548463477L,20417504944664974L,33937902760293134L,46224437161712292L,44445354551818961L,1635692222011481L,-129140996172417587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277613Inst : IEnumerable<long>
{
public static readonly long[] Value=A277613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277613.Bytes);
public long this[int i]=>Value[i];

public static A277613Inst Instance=new A277613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277614
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,73L,426L,4951L,41308L,658785L,7149628L,144963451L,1937124696L,47660873833L,756536698360L,21888570052623L,402400189738576L,13384439813823361L,279666289640774928L,10512823691028429235UL,BigInteger.Parse("246061359639756047008"),BigInteger.Parse("10314843348672697017801"),BigInteger.Parse("267328220273408530004896"),BigInteger.Parse("12363686002049118477390343"),BigInteger.Parse("351473836594567725961268160"),BigInteger.Parse("17776996370247936310502612833"),BigInteger.Parse("550002942283550733215994429376") };
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
public class A277614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277614Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277614.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277614Inst Instance=new A277614Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277615
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,5L,4L,4L,5L,6L,5L,5L,6L,7L,4L,6L,6L,7L,8L,5L,7L,7L,8L,5L,9L,5L,6L,8L,8L,9L,5L,6L,10L,6L,5L,7L,9L,9L,10L,6L,7L,11L,7L,6L,8L,10L,10L,6L,11L,7L,8L,12L,8L,7L,9L,11L,11L,7L,12L,8L,9L,13L,5L,9L,8L,10L,12L,12L,8L,13L,9L,10L,14L,6L,10L,9L,11L,13L,13L,5L,9L,14L,10L,11L,15L,7L,11L,10L,12L,14L,14L,6L,10L,15L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277615Inst : IEnumerable<long>
{
public static readonly long[] Value=A277615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277615.Bytes);
public long this[int i]=>Value[i];

public static A277615Inst Instance=new A277615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277616
{
public static readonly long[] Value={ 0L,4L,8L,12L,3L,7L,11L,2L,6L,10L,1L,5L,9L,13L,17L,21L,25L,16L,20L,24L,15L,19L,23L,14L,18L,22L,26L,30L,34L,38L,29L,33L,37L,28L,32L,36L,27L,31L,35L,39L,43L,47L,51L,42L,46L,50L,41L,45L,49L,40L,44L,48L,52L,56L,60L,64L,55L,59L,63L,54L,58L,62L,53L,57L,61L,65L,69L,73L,77L,68L,72L,76L,67L,71L,75L,66L,70L,74L,78L,82L,86L,90L,81L,85L,89L,80L,84L,88L,79L,83L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277616Inst : IEnumerable<long>
{
public static readonly long[] Value=A277616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277616.Bytes);
public long this[int i]=>Value[i];

public static A277616Inst Instance=new A277616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277617
{
public static readonly long[] Value={ 1L,5L,9L,13L,4L,8L,12L,3L,7L,11L,2L,6L,10L,14L,18L,22L,26L,17L,21L,25L,16L,20L,24L,15L,19L,23L,27L,31L,35L,39L,30L,34L,38L,29L,33L,37L,28L,32L,36L,40L,44L,48L,52L,43L,47L,51L,42L,46L,50L,41L,45L,49L,53L,57L,61L,65L,56L,60L,64L,55L,59L,63L,54L,58L,62L,66L,70L,74L,78L,69L,73L,77L,68L,72L,76L,67L,71L,75L,79L,83L,87L,91L,82L,86L,90L,81L,85L,89L,80L,84L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277617Inst : IEnumerable<long>
{
public static readonly long[] Value=A277617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277617.Bytes);
public long this[int i]=>Value[i];

public static A277617Inst Instance=new A277617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277618
{
public static readonly long[] Value={ 0L,2L,4L,1L,3L,5L,7L,9L,6L,8L,10L,12L,14L,11L,13L,15L,17L,19L,16L,18L,20L,22L,24L,21L,23L,25L,27L,29L,26L,28L,30L,32L,34L,31L,33L,35L,37L,39L,36L,38L,40L,42L,44L,41L,43L,45L,47L,49L,46L,48L,50L,52L,54L,51L,53L,55L,57L,59L,56L,58L,60L,62L,64L,61L,63L,65L,67L,69L,66L,68L,70L,72L,74L,71L,73L,75L,77L,79L,76L,78L,80L,82L,84L,81L,83L,85L,87L,89L,86L,88L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277618Inst : IEnumerable<long>
{
public static readonly long[] Value=A277618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277618.Bytes);
public long this[int i]=>Value[i];

public static A277618Inst Instance=new A277618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277619
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,6L,8L,14L,19L,28L,37L,51L,64L,84L,103L,129L,155L,189L,222L,265L,307L,359L,411L,474L,536L,611L,685L,772L,859L,960L,1060L,1176L,1291L,1422L,1553L,1701L,1848L,2014L,2179L,2363L,2547L,2751L,2954L,3179L,3403L,3649L,3895L,4164L,4432L,4725L,5017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277619Inst : IEnumerable<long>
{
public static readonly long[] Value=A277619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277619.Bytes);
public long this[int i]=>Value[i];

public static A277619Inst Instance=new A277619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277636
{
public static readonly long[] Value={ 1L,343L,6859L,50653L,226981L,753571L,2048383L,4826809L,10218313L,19902511L,36264691L,62570773L,103161709L,163667323L,251239591L,374805361L,545338513L,776151559L,1083206683L,1485446221L,2005142581L,2668267603L,3504881359L,4549540393L,5841725401L,7426288351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277636Inst : IEnumerable<long>
{
public static readonly long[] Value=A277636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277636.Bytes);
public long this[int i]=>Value[i];

public static A277636Inst Instance=new A277636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277637
{
public static readonly BigInteger[] Value={ 1L,4L,34L,454L,7384L,133510L,2583958L,52468078L,1104191608L,23891534758L,528527606698L,11905777228618L,272269758961018L,6306419621308618L,147677930682023818L,3491114167267938298L,BigInteger.Parse("83217317955857060788"),BigInteger.Parse("1998209467779811473538"),BigInteger.Parse("48293984598611551487038"),BigInteger.Parse("1174012306200941229710038"),BigInteger.Parse("28689784424223599507417938") };
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
public class A277637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277637Inst Instance=new A277637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277638
{
public static readonly BigInteger[] Value={ 1L,4L,37L,520L,8803L,165292L,3320023L,69943804L,1526981575L,34271322316L,786371041603L,18372739163632L,435772652437381L,10468369504009060L,254238148448959729L,6233226769739934964L,BigInteger.Parse("154092763036678601551"),BigInteger.Parse("3837301178450916902428") };
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
public class A277638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277638Inst Instance=new A277638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277639
{
public static readonly BigInteger[] Value={ 1L,4L,43L,718L,14779L,344452L,8725093L,234594766L,6596287411L,192032529388L,5747827847545L,175986201591130L,5490952102178725L,174077883157001740L,5594651323154783515L,BigInteger.Parse("181946073109880839450"),BigInteger.Parse("5978730547304013537475"),BigInteger.Parse("198263347772478727193740"),BigInteger.Parse("6628299876919271425393105"),BigInteger.Parse("223211734849614639629628010"),BigInteger.Parse("7566093949269408444819804937") };
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
public class A277639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277639Inst Instance=new A277639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277640
{
public static readonly long[] Value={ -2L,1L,-3L,-1L,7L,-1L,6L,4L,-15L,-15L,-13L,1L,-23L,1L,8L,-15L,-22L,13L,-33L,27L,25L,11L,-17L,24L,-32L,-53L,31L,42L,-19L,18L,-35L,55L,-5L,38L,-29L,76L,34L,44L,-71L,-21L,-13L,16L,46L,70L,92L,70L,-39L,88L,-84L,-118L,-120L,64L,107L,111L,-56L,124L,-13L,-23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277640Inst : IEnumerable<long>
{
public static readonly long[] Value=A277640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277640.Bytes);
public long this[int i]=>Value[i];

public static A277640Inst Instance=new A277640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277641
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277641Inst : IEnumerable<long>
{
public static readonly long[] Value=A277641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277641.Bytes);
public long this[int i]=>Value[i];

public static A277641Inst Instance=new A277641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277642
{
public static readonly long[] Value={ 38L,10L,1L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277642Inst : IEnumerable<long>
{
public static readonly long[] Value=A277642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277642.Bytes);
public long this[int i]=>Value[i];

public static A277642Inst Instance=new A277642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277643
{
public static readonly long[] Value={ 1L,3L,7L,15L,29L,53L,93L,157L,257L,411L,643L,987L,1491L,2219L,3259L,4731L,6793L,9657L,13605L,19005L,26341L,36245L,49533L,67261L,90789L,121855L,162679L,216087L,285655L,375903L,492527L,642671L,835283L,1081539L,1395347L,1793987L,2298873L,2936465L,3739401L,4747849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277643Inst : IEnumerable<long>
{
public static readonly long[] Value=A277643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277643.Bytes);
public long this[int i]=>Value[i];

public static A277643Inst Instance=new A277643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277644
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,47L,48L,50L,51L,52L,53L,55L,56L,57L,58L,60L,61L,62L,63L,64L,66L,67L,68L,69L,71L,72L,73L,74L,75L,77L,78L,79L,80L,82L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277644Inst : IEnumerable<long>
{
public static readonly long[] Value=A277644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277644.Bytes);
public long this[int i]=>Value[i];

public static A277644Inst Instance=new A277644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277645
{
public static readonly long[] Value={ 5L,10L,16L,21L,27L,32L,38L,43L,49L,54L,59L,65L,70L,76L,81L,87L,92L,98L,103L,108L,114L,119L,125L,130L,136L,141L,147L,152L,158L,163L,168L,174L,179L,185L,190L,196L,201L,207L,212L,217L,223L,228L,234L,239L,245L,250L,256L,261L,267L,272L,277L,283L,288L,294L,299L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277645Inst : IEnumerable<long>
{
public static readonly long[] Value=A277645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277645.Bytes);
public long this[int i]=>Value[i];

public static A277645Inst Instance=new A277645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277646
{
public static readonly long[] Value={ 1L,4L,2L,1L,1L,9L,4L,3L,2L,1L,1L,1L,1L,1L,16L,8L,5L,4L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,25L,12L,8L,6L,5L,4L,3L,3L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,36L,18L,12L,9L,7L,6L,5L,4L,4L,3L,3L,3L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,49L,24L,16L,12L,9L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277646Inst : IEnumerable<long>
{
public static readonly long[] Value=A277646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277646.Bytes);
public long this[int i]=>Value[i];

public static A277646Inst Instance=new A277646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277647
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,4L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,3L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,4L,3L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,4L,4L,3L,3L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277647Inst : IEnumerable<long>
{
public static readonly long[] Value=A277647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277647.Bytes);
public long this[int i]=>Value[i];

public static A277647Inst Instance=new A277647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277648
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,4L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,5L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,4L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,4L,4L,3L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,5L,4L,3L,3L,3L,2L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277648Inst : IEnumerable<long>
{
public static readonly long[] Value=A277648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277648.Bytes);
public long this[int i]=>Value[i];

public static A277648Inst Instance=new A277648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277649
{
public static readonly long[] Value={ 1L,2L,8L,14L,52L,99L,589L,594L,595L,1566L,1961L,3465L,5301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277649Inst : IEnumerable<long>
{
public static readonly long[] Value=A277649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277649.Bytes);
public long this[int i]=>Value[i];

public static A277649Inst Instance=new A277649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277650
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,30L,40L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277650Inst : IEnumerable<long>
{
public static readonly long[] Value=A277650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277650.Bytes);
public long this[int i]=>Value[i];

public static A277650Inst Instance=new A277650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277651
{
public static readonly long[] Value={ 5L,9L,0L,6L,1L,6L,1L,0L,9L,1L,4L,9L,6L,4L,1L,2L,4L,9L,7L,4L,3L,8L,0L,6L,9L,0L,9L,3L,2L,3L,2L,5L,1L,5L,5L,7L,1L,1L,6L,6L,5L,3L,0L,4L,8L,8L,7L,3L,8L,8L,0L,0L,6L,7L,4L,4L,0L,2L,7L,9L,2L,0L,1L,9L,2L,1L,8L,2L,4L,9L,3L,3L,7L,5L,4L,4L,5L,7L,2L,7L,5L,2L,5L,4L,4L,3L,5L,2L,2L,3L,9L,4L,1L,8L,4L,8L,8L,3L,8L,6L,2L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277651Inst : IEnumerable<long>
{
public static readonly long[] Value=A277651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277651.Bytes);
public long this[int i]=>Value[i];

public static A277651Inst Instance=new A277651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277716
{
public static readonly long[] Value={ 3L,7L,15L,31L,63L,127L,219L,255L,291L,439L,511L,583L,819L,879L,1023L,1167L,1443L,1639L,1747L,1759L,1915L,2047L,2115L,2335L,2887L,3187L,3279L,3339L,3495L,3519L,3831L,4095L,4231L,4671L,5043L,5775L,5995L,6375L,6559L,6679L,6991L,7039L,7323L,7663L,8191L,8463L,8931L,9343L,10087L,10515L,11551L,11991L,12531L,12751L,12827L,13119L,13359L,13983L,14079L,14647L,15327L,16383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277716Inst : IEnumerable<long>
{
public static readonly long[] Value=A277716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277716.Bytes);
public long this[int i]=>Value[i];

public static A277716Inst Instance=new A277716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277717
{
public static readonly long[] Value={ 3L,5L,7L,13L,19L,23L,29L,37L,43L,47L,61L,67L,71L,73L,79L,89L,97L,103L,109L,113L,151L,179L,181L,193L,211L,223L,233L,241L,277L,281L,283L,293L,307L,313L,331L,337L,347L,349L,359L,373L,379L,383L,397L,401L,409L,419L,421L,443L,449L,463L,467L,479L,487L,523L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277717Inst : IEnumerable<long>
{
public static readonly long[] Value=A277717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277717.Bytes);
public long this[int i]=>Value[i];

public static A277717Inst Instance=new A277717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277718
{
public static readonly long[] Value={ 5L,11L,17L,29L,37L,53L,127L,149L,211L,223L,307L,331L,541L,1361L,1693L,1973L,2203L,2503L,2999L,3299L,4327L,4861L,5623L,5779L,5981L,6521L,6947L,7283L,8501L,9587L,10007L,10831L,11777L,15727L,19661L,31469L,34123L,35671L,35729L,43391L,44351L,45943L,48731L,58889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277718Inst : IEnumerable<long>
{
public static readonly long[] Value=A277718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277718.Bytes);
public long this[int i]=>Value[i];

public static A277718Inst Instance=new A277718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277719
{
public static readonly long[] Value={ 3L,5L,7L,10L,12L,16L,31L,35L,47L,48L,63L,67L,100L,218L,264L,298L,328L,368L,430L,463L,591L,651L,739L,758L,782L,843L,891L,929L,1060L,1184L,1230L,1316L,1410L,1832L,2226L,3386L,3645L,3794L,3796L,4523L,4613L,4755L,5009L,5950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277719Inst : IEnumerable<long>
{
public static readonly long[] Value=A277719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277719.Bytes);
public long this[int i]=>Value[i];

public static A277719Inst Instance=new A277719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277720
{
public static readonly ulong[] Value={ 2320690177L,17069520863233L,42182344790209L,65465530560001L,3432376805760001L,13322002122777601L,20388795375960001L,129009714848870401L,580007888606160001L,1096591987029196801L,3029756968906340401L,5806765663003468801L,6213994663149504001L,6367205158826803201L,7802569551798000001L,10319507991273499201UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277720Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A277720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277720.Bytes);
public ulong this[int i]=>Value[i];

public static A277720Inst Instance=new A277720Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277721
{
public static readonly long[] Value={ 2L,1L,1L,0L,3L,2L,2L,1L,1L,1L,0L,2L,1L,2L,1L,1L,0L,3L,2L,2L,1L,0L,1L,0L,2L,1L,2L,1L,3L,2L,2L,2L,1L,1L,0L,3L,2L,2L,1L,1L,1L,3L,2L,2L,2L,1L,1L,0L,2L,2L,2L,1L,0L,1L,0L,2L,1L,1L,1L,1L,0L,2L,2L,2L,1L,0L,0L,0L,2L,1L,1L,1L,3L,2L,2L,1L,1L,1L,0L,2L,2L,2L,1L,1L,0L,3L,2L,2L,1L,1L,1L,0L,2L,1L,2L,1L,1L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277721Inst : IEnumerable<long>
{
public static readonly long[] Value=A277721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277721.Bytes);
public long this[int i]=>Value[i];

public static A277721Inst Instance=new A277721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277722
{
public static readonly long[] Value={ 0L,3L,6L,10L,13L,16L,20L,23L,27L,30L,33L,37L,40L,43L,47L,50L,54L,57L,60L,64L,67L,71L,74L,77L,81L,84L,87L,91L,94L,98L,101L,104L,108L,111L,115L,118L,121L,125L,128L,131L,135L,138L,142L,145L,148L,152L,155L,158L,162L,165L,169L,172L,175L,179L,182L,186L,189L,192L,196L,199L,202L,206L,209L,213L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277722Inst : IEnumerable<long>
{
public static readonly long[] Value=A277722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277722.Bytes);
public long this[int i]=>Value[i];

public static A277722Inst Instance=new A277722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277723
{
public static readonly long[] Value={ 0L,6L,12L,18L,24L,31L,37L,43L,49L,56L,62L,68L,74L,80L,87L,93L,99L,105L,112L,118L,124L,130L,136L,143L,149L,155L,161L,168L,174L,180L,186L,192L,199L,205L,211L,217L,224L,230L,236L,242L,248L,255L,261L,267L,273L,280L,286L,292L,298L,304L,311L,317L,323L,329L,336L,342L,348L,354L,360L,367L,373L,379L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277723Inst : IEnumerable<long>
{
public static readonly long[] Value=A277723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277723.Bytes);
public long this[int i]=>Value[i];

public static A277723Inst Instance=new A277723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277724
{
public static readonly long[] Value={ 0L,3L,16L,20L,23L,27L,33L,40L,47L,57L,60L,64L,71L,77L,84L,91L,101L,104L,108L,115L,121L,125L,128L,145L,148L,152L,158L,165L,169L,172L,182L,189L,196L,202L,206L,209L,213L,226L,233L,240L,246L,250L,253L,257L,263L,270L,274L,277L,290L,294L,297L,301L,307L,314L,321L,331L,334L,338L,345L,351L,358L,375L,378L,382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277724Inst : IEnumerable<long>
{
public static readonly long[] Value=A277724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277724.Bytes);
public long this[int i]=>Value[i];

public static A277724Inst Instance=new A277724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277725
{
public static readonly long[] Value={ 0L,12L,18L,31L,49L,62L,68L,80L,93L,99L,112L,130L,136L,143L,161L,174L,180L,211L,217L,224L,242L,248L,255L,261L,286L,292L,323L,329L,336L,342L,354L,360L,367L,373L,404L,410L,423L,435L,441L,448L,454L,472L,485L,491L,516L,522L,535L,553L,560L,566L,572L,584L,597L,603L,616L,634L,640L,647L,665L,678L,684L,709L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277725Inst : IEnumerable<long>
{
public static readonly long[] Value=A277725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277725.Bytes);
public long this[int i]=>Value[i];

public static A277725Inst Instance=new A277725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277726
{
public static readonly long[] Value={ 0L,6L,37L,43L,74L,87L,118L,155L,186L,192L,199L,230L,236L,267L,280L,304L,311L,317L,348L,385L,392L,416L,429L,460L,466L,497L,504L,510L,541L,578L,622L,659L,690L,696L,703L,734L,740L,771L,784L,808L,815L,852L,889L,896L,920L,933L,964L,970L,1001L,1008L,1014L,1045L,1082L,1126L,1163L,1194L,1200L,1207L,1238L,1244L,1275L,1288L,1312L,1319L,1356L,1387L,1393L,1400L,1424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277726Inst : IEnumerable<long>
{
public static readonly long[] Value=A277726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277726.Bytes);
public long this[int i]=>Value[i];

public static A277726Inst Instance=new A277726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277727
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,16L,18L,20L,22L,23L,24L,25L,27L,29L,30L,31L,33L,34L,36L,37L,38L,40L,42L,43L,44L,45L,47L,49L,50L,51L,53L,54L,55L,56L,57L,58L,60L,62L,64L,66L,67L,68L,69L,71L,73L,74L,75L,77L,79L,80L,81L,82L,84L,86L,87L,88L,90L,91L,93L,94L,95L,97L,98L,99L,101L,103L,104L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277727Inst : IEnumerable<long>
{
public static readonly long[] Value=A277727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277727.Bytes);
public long this[int i]=>Value[i];

public static A277727Inst Instance=new A277727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277728
{
public static readonly long[] Value={ 2L,4L,8L,15L,17L,19L,21L,26L,28L,32L,35L,39L,41L,46L,48L,52L,59L,61L,63L,65L,70L,72L,76L,78L,83L,85L,89L,92L,96L,100L,102L,107L,109L,113L,116L,120L,122L,127L,129L,133L,140L,144L,146L,151L,153L,157L,159L,164L,166L,170L,173L,177L,181L,184L,188L,190L,195L,197L,201L,203L,208L,210L,212L,214L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277728Inst : IEnumerable<long>
{
public static readonly long[] Value=A277728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277728.Bytes);
public long this[int i]=>Value[i];

public static A277728Inst Instance=new A277728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277729
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,0L,1L,1L,3L,0L,1L,1L,3L,0L,2L,1L,4L,0L,2L,1L,4L,0L,3L,1L,4L,0L,3L,0L,1L,1L,5L,0L,3L,0L,1L,1L,5L,0L,3L,0L,2L,1L,5L,0L,4L,0L,2L,1L,6L,0L,4L,0L,2L,1L,6L,0L,5L,0L,2L,1L,6L,0L,5L,0L,3L,1L,6L,0L,5L,0L,4L,1L,7L,0L,5L,0L,4L,1L,7L,0L,5L,0L,5L,1L,7L,0L,6L,0L,5L,1L,8L,0L,6L,0L,5L,1L,8L,0L,6L,0L,6L,1L,8L,0L,7L,0L,6L,1L,8L,0L,7L,0L,7L,1L,8L,0L,7L,0L,7L,0L,1L,1L,8L,0L,8L,0L,7L,0L,1L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277729Inst : IEnumerable<long>
{
public static readonly long[] Value=A277729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277729.Bytes);
public long this[int i]=>Value[i];

public static A277729Inst Instance=new A277729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277730
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,1L,3L,2L,4L,2L,4L,3L,4L,3L,1L,5L,3L,1L,5L,3L,2L,5L,4L,2L,6L,4L,2L,6L,5L,2L,6L,5L,3L,6L,5L,4L,7L,5L,4L,7L,5L,5L,7L,6L,5L,8L,6L,5L,8L,6L,6L,8L,7L,6L,8L,7L,7L,8L,7L,7L,1L,8L,8L,7L,1L,9L,8L,7L,1L,9L,9L,7L,1L,10L,9L,7L,1L,10L,10L,7L,1L,10L,10L,7L,1L,0L,0L,1L,10L,11L,7L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277730Inst : IEnumerable<long>
{
public static readonly long[] Value=A277730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277730.Bytes);
public long this[int i]=>Value[i];

public static A277730Inst Instance=new A277730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277731
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277731Inst : IEnumerable<long>
{
public static readonly long[] Value=A277731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277731.Bytes);
public long this[int i]=>Value[i];

public static A277731Inst Instance=new A277731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277748
{
public static readonly long[] Value={ 1L,4L,40L,768L,27648L,1900544L,253755392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277748Inst : IEnumerable<long>
{
public static readonly long[] Value=A277748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277748.Bytes);
public long this[int i]=>Value[i];

public static A277748Inst Instance=new A277748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277749
{
public static readonly long[] Value={ 2L,1L,4L,3L,2L,3L,4L,1L,6L,5L,4L,7L,10L,3L,8L,5L,2L,5L,8L,3L,10L,7L,4L,5L,6L,1L,8L,7L,6L,11L,16L,5L,14L,9L,4L,11L,18L,7L,24L,17L,10L,13L,16L,3L,14L,11L,8L,13L,18L,5L,12L,7L,2L,7L,12L,5L,18L,13L,8L,11L,14L,3L,16L,13L,10L,17L,24L,7L,18L,11L,4L,9L,14L,5L,16L,11L,6L,7L,8L,1L,10L,9L,8L,15L,22L,7L,20L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277749Inst : IEnumerable<long>
{
public static readonly long[] Value=A277749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277749.Bytes);
public long this[int i]=>Value[i];

public static A277749Inst Instance=new A277749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277750
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,3L,2L,1L,3L,5L,2L,7L,5L,3L,4L,5L,1L,5L,4L,3L,5L,7L,2L,5L,3L,1L,4L,7L,3L,11L,8L,5L,7L,9L,2L,11L,9L,7L,12L,17L,5L,13L,8L,3L,7L,11L,4L,13L,9L,5L,6L,7L,1L,7L,6L,5L,9L,13L,4L,11L,7L,3L,8L,13L,5L,17L,12L,7L,9L,11L,2L,9L,7L,5L,8L,11L,3L,7L,4L,1L,5L,9L,4L,15L,11L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277750Inst : IEnumerable<long>
{
public static readonly long[] Value=A277750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277750.Bytes);
public long this[int i]=>Value[i];

public static A277750Inst Instance=new A277750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277751
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,31L,1L,60L,4L,116L,12L,225L,30L,1L,436L,72L,4L,845L,166L,13L,1637L,375L,35L,1L,3172L,828L,92L,4L,6146L,1802L,230L,14L,11909L,3872L,562L,40L,1L,23075L,8243L,1333L,113L,4L,44711L,17404L,3106L,300L,15L,86633L,36501L,7114L,778L,45L,1L,167863L,76104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277751Inst : IEnumerable<long>
{
public static readonly long[] Value=A277751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277751.Bytes);
public long this[int i]=>Value[i];

public static A277751Inst Instance=new A277751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277752
{
public static readonly long[] Value={ 1L,0L,2L,-2L,4L,-7L,10L,-19L,27L,-49L,73L,-126L,195L,-326L,516L,-848L,1358L,-2213L,3564L,-5785L,9341L,-15135L,24467L,-39612L,64069L,-103692L,167750L,-271454L,439192L,-710659L,1149838L,-1860511L,3010335L,-4870861L,7881181L,-12752058L,20633223L,-33385298L,54018504L,-87403820L,141422306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277752Inst : IEnumerable<long>
{
public static readonly long[] Value=A277752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277752.Bytes);
public long this[int i]=>Value[i];

public static A277752Inst Instance=new A277752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277753
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,4L,8L,12L,19L,28L,42L,58L,82L,110L,150L,200L,263L,344L,450L,578L,741L,947L,1197L,1513L,1899L,2374L,2954L,3669L,4529L,5576L,6849L,8380L,10223L,12449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277753Inst : IEnumerable<long>
{
public static readonly long[] Value=A277753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277753.Bytes);
public long this[int i]=>Value[i];

public static A277753Inst Instance=new A277753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277754
{
public static readonly long[] Value={ 2L,9L,2L,5L,6L,4L,0L,8L,4L,6L,1L,0L,7L,1L,4L,2L,7L,5L,9L,7L,1L,3L,0L,8L,7L,8L,0L,4L,8L,9L,4L,1L,1L,3L,8L,6L,8L,5L,7L,2L,9L,5L,3L,3L,3L,9L,2L,7L,9L,6L,0L,3L,4L,8L,0L,8L,8L,5L,9L,8L,1L,0L,1L,9L,2L,5L,2L,0L,8L,2L,7L,6L,3L,1L,5L,4L,6L,8L,1L,0L,9L,5L,1L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277754Inst : IEnumerable<long>
{
public static readonly long[] Value=A277754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277754.Bytes);
public long this[int i]=>Value[i];

public static A277754Inst Instance=new A277754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277755
{
public static readonly long[] Value={ 4L,6L,1L,0L,8L,7L,9L,4L,6L,9L,6L,8L,7L,6L,7L,2L,0L,1L,8L,2L,8L,0L,3L,3L,2L,8L,9L,3L,9L,2L,6L,8L,5L,4L,5L,4L,9L,9L,2L,2L,7L,0L,9L,8L,0L,2L,4L,4L,6L,4L,6L,0L,3L,0L,8L,1L,8L,3L,5L,2L,2L,9L,4L,5L,2L,0L,5L,3L,1L,4L,8L,8L,7L,7L,1L,4L,5L,9L,4L,6L,4L,4L,7L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277755Inst : IEnumerable<long>
{
public static readonly long[] Value=A277755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277755.Bytes);
public long this[int i]=>Value[i];

public static A277755Inst Instance=new A277755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277756
{
public static readonly BigInteger[] Value={ 1L,5L,32L,224L,1723L,14569L,135286L,1375882L,15263414L,183817326L,2391291386L,33443618930L,500611975023L,7988044467121L,135376576319870L,2428721569276698L,45988428905194350L,916607431346170686L,BigInteger.Parse("19182997480530342168"),BigInteger.Parse("420606731490047403144") };
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
public class A277756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277756Inst Instance=new A277756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277757
{
public static readonly BigInteger[] Value={ 2L,128L,8192L,524288L,33554432L,2147483648L,137438953472L,8796093022208L,562949953421312L,36028797018963968L,2305843009213693952L,BigInteger.Parse("147573952589676412928"),BigInteger.Parse("9444732965739290427392"),BigInteger.Parse("604462909807314587353088"),BigInteger.Parse("38685626227668133590597632") };
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
public class A277757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277757Inst Instance=new A277757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277758
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,5L,7L,9L,9L,10L,10L,12L,10L,11L,12L,13L,13L,14L,12L,14L,12L,15L,15L,17L,15L,19L,19L,17L,19L,20L,21L,17L,24L,20L,20L,21L,22L,22L,20L,26L,26L,24L,26L,29L,27L,28L,26L,27L,27L,31L,28L,28L,28L,31L,29L,30L,30L,28L,29L,32L,32L,26L,26L,31L,28L,29L,28L,30L,34L,33L,34L,35L,34L,31L,37L,35L,35L,35L,37L,42L,39L,37L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277758Inst : IEnumerable<long>
{
public static readonly long[] Value=A277758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277758.Bytes);
public long this[int i]=>Value[i];

public static A277758Inst Instance=new A277758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277759
{
public static readonly BigInteger[] Value={ 1L,1L,4L,30L,324L,4540L,78060L,1589448L,37388400L,997513200L,29759790240L,981669324240L,35475203063520L,1393746645107232L,59147129937893088L,2696314664384853120L,BigInteger.Parse("131405475202661963520"),BigInteger.Parse("6817779852438948837120"),BigInteger.Parse("375193156508083422581760") };
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
public class A277759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277759Inst Instance=new A277759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277760
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,2L,1L,2L,2L,1L,2L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,4L,3L,2L,2L,3L,4L,3L,3L,2L,4L,3L,2L,3L,4L,4L,3L,2L,2L,4L,4L,3L,2L,2L,4L,3L,4L,2L,3L,4L,3L,4L,3L,3L,3L,3L,3L,2L,3L,2L,4L,3L,3L,4L,4L,4L,3L,3L,2L,4L,3L,4L,3L,3L,2L,4L,4L,4L,4L,5L,3L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,4L,5L,4L,4L,3L,3L,4L,4L,4L,4L,5L,3L,4L,4L,4L,4L,5L,2L,4L,4L,5L,3L,5L,3L,4L,6L,4L,3L,4L,4L,5L,5L,4L,3L,3L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277760Inst : IEnumerable<long>
{
public static readonly long[] Value=A277760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277760.Bytes);
public long this[int i]=>Value[i];

public static A277760Inst Instance=new A277760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277761
{
public static readonly long[] Value={ 0L,1L,2L,14L,56L,284L,1304L,6248L,29408L,139472L,659360L,3121376L,14768000L,69887936L,330703232L,1564924544L,7405262336L,35042157824L,165821110784L,784674242048L,3713117739008L,17570663078912L,83145267845120L,393447636985856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277761Inst : IEnumerable<long>
{
public static readonly long[] Value=A277761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277761.Bytes);
public long this[int i]=>Value[i];

public static A277761Inst Instance=new A277761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277762
{
public static readonly long[] Value={ 0L,4L,17L,330L,3666L,46289L,560809L,6883464L,84161576L,1030163755L,12605295745L,154256946272L,1887655962034L,23099627259711L,282674025688925L,3459132503499606L,42330011144976582L,517999809756567289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277762Inst : IEnumerable<long>
{
public static readonly long[] Value=A277762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277762.Bytes);
public long this[int i]=>Value[i];

public static A277762Inst Instance=new A277762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277763
{
public static readonly BigInteger[] Value={ 0L,18L,204L,9741L,270291L,8971150L,280603511L,8946059000L,283436060320L,8998418743638L,285487168951921L,9059457397078866L,287466089870053015L,9121814912567142070L,BigInteger.Parse("289449332145382072648"),BigInteger.Parse("9184699258737221554558") };
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
public class A277763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277763Inst Instance=new A277763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277796
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,11L,23L,47L,105L,231L,537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277796Inst : IEnumerable<long>
{
public static readonly long[] Value=A277796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277796.Bytes);
public long this[int i]=>Value[i];

public static A277796Inst Instance=new A277796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277797
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1100L,1L,111100L,1L,11111100L,1L,1111111100L,1L,111111111100L,1L,11111111111100L,1L,1111111111111100L,1L,111111111111111100L,1L,11111111111111111100UL,1L,BigInteger.Parse("1111111111111111111100"),1L,BigInteger.Parse("111111111111111111111100"),1L,BigInteger.Parse("11111111111111111111111100"),1L };
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
public class A277797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277797Inst Instance=new A277797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277798
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10000L,1111L,1000000L,111111L,100000000L,11111111L,10000000000L,1111111111L,1000000000000L,111111111111L,100000000000000L,11111111111111L,10000000000000000L,1111111111111111L,1000000000000000000L,111111111111111111L,BigInteger.Parse("100000000000000000000") };
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
public class A277798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277798Inst Instance=new A277798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277799
{
public static readonly long[] Value={ 1L,0L,1L,12L,1L,60L,1L,252L,1L,1020L,1L,4092L,1L,16380L,1L,65532L,1L,262140L,1L,1048572L,1L,4194300L,1L,16777212L,1L,67108860L,1L,268435452L,1L,1073741820L,1L,4294967292L,1L,17179869180L,1L,68719476732L,1L,274877906940L,1L,1099511627772L,1L,4398046511100L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277799Inst : IEnumerable<long>
{
public static readonly long[] Value=A277799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277799.Bytes);
public long this[int i]=>Value[i];

public static A277799Inst Instance=new A277799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277800
{
public static readonly long[] Value={ 1L,0L,4L,3L,16L,15L,64L,63L,256L,255L,1024L,1023L,4096L,4095L,16384L,16383L,65536L,65535L,262144L,262143L,1048576L,1048575L,4194304L,4194303L,16777216L,16777215L,67108864L,67108863L,268435456L,268435455L,1073741824L,1073741823L,4294967296L,4294967295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277800Inst : IEnumerable<long>
{
public static readonly long[] Value=A277800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277800.Bytes);
public long this[int i]=>Value[i];

public static A277800Inst Instance=new A277800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277801
{
public static readonly long[] Value={ -1L,-1L,-1L,1L,5L,19L,47L,109L,233L,483L,993L,2011L,4055L,8149L,16337L,32715L,65477L,131011L,262077L,524217L,1048503L,2097073L,4194221L,8388519L,16777119L,33554331L,67108761L,134217621L,268435347L,536870799L,1073741697L,2147483517L,4294967159L,8589934453L,17179869035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277801Inst : IEnumerable<long>
{
public static readonly long[] Value=A277801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277801.Bytes);
public long this[int i]=>Value[i];

public static A277801Inst Instance=new A277801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277802
{
public static readonly long[] Value={ 1L,4L,9L,2L,25L,36L,49L,3L,100L,121L,18L,169L,196L,225L,289L,12L,361L,50L,441L,484L,529L,5L,676L,98L,841L,900L,961L,1089L,1156L,1225L,6L,1369L,1444L,1521L,1681L,1764L,1849L,242L,75L,2116L,2209L,7L,20L,2601L,338L,2809L,3025L,3249L,3364L,3481L,450L,3721L,3844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277802Inst : IEnumerable<long>
{
public static readonly long[] Value=A277802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277802.Bytes);
public long this[int i]=>Value[i];

public static A277802Inst Instance=new A277802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277803
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,3L,10L,11L,12L,13L,14L,15L,17L,12L,19L,20L,21L,22L,23L,5L,26L,28L,29L,30L,31L,33L,34L,35L,6L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,7L,20L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,45L,76L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277803Inst : IEnumerable<long>
{
public static readonly long[] Value=A277803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277803.Bytes);
public long this[int i]=>Value[i];

public static A277803Inst Instance=new A277803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277804
{
public static readonly long[] Value={ 1L,2L,8L,12L,24L,36L,128L,288L,384L,864L,972L,1152L,1944L,3456L,6144L,6912L,13122L,18432L,26244L,31104L,62208L,69984L,209952L,279936L,294912L,497664L,839808L,884736L,1679616L,3538944L,4478976L,13436928L,22674816L,25165824L,31850496L,45349632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277804Inst : IEnumerable<long>
{
public static readonly long[] Value=A277804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277804.Bytes);
public long this[int i]=>Value[i];

public static A277804Inst Instance=new A277804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277805
{
public static readonly long[] Value={ 57L,209L,228L,217L,233L,801L,836L,809L,912L,793L,868L,785L,1009L,932L,1017L,969L,3137L,3204L,3145L,3344L,3193L,3236L,3185L,3648L,3217L,3172L,3225L,3472L,3241L,3140L,3233L,3937L,4036L,3945L,3728L,3929L,4068L,3921L,4017L,3876L,4025L,3977L,12417L,12548L,12425L,12816L,12473L,12580L,12465L,13376L,12369L,12772L,12377L,12944L,12393L,12740L,12385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277805Inst : IEnumerable<long>
{
public static readonly long[] Value=A277805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277805.Bytes);
public long this[int i]=>Value[i];

public static A277805Inst Instance=new A277805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277806
{
public static readonly long[] Value={ 115L,230L,460L,461L,920L,922L,1840L,1844L,3680L,3688L,7360L,7376L,14720L,14752L,29440L,29504L,56757L,58880L,59008L,113514L,117760L,118016L,130057L,227028L,235520L,236032L,260114L,454056L,454933L,471040L,472064L,472533L,520228L,908112L,909866L,942080L,944128L,945066L,1040456L,1816224L,1819732L,1884160L,1888256L,1890132L,2034537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277806Inst : IEnumerable<long>
{
public static readonly long[] Value=A277806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277806.Bytes);
public long this[int i]=>Value[i];

public static A277806Inst Instance=new A277806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277807
{
public static readonly long[] Value={ 83L,166L,332L,365L,664L,730L,1328L,1460L,2656L,2920L,5312L,5840L,10624L,11680L,21248L,23360L,33051L,42496L,46720L,66102L,84992L,93440L,115785L,132204L,169984L,186880L,231570L,264408L,279099L,339968L,373760L,388731L,463140L,528816L,558198L,679936L,747520L,777462L,926280L,1057632L,1116396L,1359872L,1495040L,1554924L,1677591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277807Inst : IEnumerable<long>
{
public static readonly long[] Value=A277807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277807.Bytes);
public long this[int i]=>Value[i];

public static A277807Inst Instance=new A277807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277808
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,5L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,5L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,6L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277808Inst : IEnumerable<long>
{
public static readonly long[] Value=A277808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277808.Bytes);
public long this[int i]=>Value[i];

public static A277808Inst Instance=new A277808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277809
{
public static readonly long[] Value={ 2L,3L,6L,30L,15L,10L,5L,14L,21L,210L,70L,35L,462L,1155L,22L,105L,330L,55L,910L,39L,858L,42L,33L,2002L,5005L,72930L,3315L,1870L,7L,770L,2145L,714L,85L,2926L,5187L,9699690L,154L,77L,390L,3927L,248710L,11305L,238602L,111546435L,46L,231L,546L,91L,3094L,440895L,152490L,21505L,93763670L,87L,4002L,2310L,1365L,170170L,17017L,114114L,9867L,2306486L,1078282205L,620310L,13485L,7130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277809Inst : IEnumerable<long>
{
public static readonly long[] Value=A277809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277809.Bytes);
public long this[int i]=>Value[i];

public static A277809Inst Instance=new A277809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277810
{
public static readonly long[] Value={ 2L,6L,3L,10L,15L,30L,210L,21L,14L,5L,22L,1155L,462L,35L,70L,858L,39L,910L,55L,330L,105L,1870L,3315L,72930L,5005L,2002L,33L,42L,9699690L,5187L,2926L,85L,714L,2145L,770L,7L,46L,111546435L,238602L,11305L,248710L,3927L,390L,77L,154L,4002L,87L,93763670L,21505L,152490L,440895L,3094L,91L,546L,231L,7130L,13485L,620310L,1078282205L,2306486L,9867L,114114L,17017L,170170L,1365L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277810Inst : IEnumerable<long>
{
public static readonly long[] Value=A277810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277810.Bytes);
public long this[int i]=>Value[i];

public static A277810Inst Instance=new A277810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277811
{
public static readonly long[] Value={ 2L,3L,30L,5L,70L,105L,42L,7L,154L,231L,2310L,385L,110L,165L,66L,11L,286L,429L,4290L,715L,10010L,15015L,6006L,1001L,182L,273L,2730L,455L,130L,195L,78L,13L,442L,663L,6630L,1105L,15470L,23205L,9282L,1547L,34034L,51051L,510510L,85085L,24310L,36465L,14586L,2431L,374L,561L,5610L,935L,13090L,19635L,7854L,1309L,238L,357L,3570L,595L,170L,255L,102L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277811Inst : IEnumerable<long>
{
public static readonly long[] Value=A277811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277811.Bytes);
public long this[int i]=>Value[i];

public static A277811Inst Instance=new A277811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277876
{
public static readonly BigInteger[] Value={ 2L,3L,6L,20L,80L,420L,2520L,18144L,145152L,1330560L,13305600L,148262400L,1779148800L,23351328000L,326918592000L,4940103168000L,79041650688000L,1351612226764800L,24329020081766400L,464463110651904000L,9289262213038080000UL,BigInteger.Parse("195848611658219520000") };
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
public class A277876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277876Inst Instance=new A277876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277877
{
public static readonly long[] Value={ 0L,30L,608L,8740L,109296L,1269450L,14096320L,151927776L,1603346160L,16659866938L,171064877280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277877Inst : IEnumerable<long>
{
public static readonly long[] Value=A277877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277877.Bytes);
public long this[int i]=>Value[i];

public static A277877Inst Instance=new A277877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277878
{
public static readonly long[] Value={ 3L,1123L,11L,29L,23L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277878Inst : IEnumerable<long>
{
public static readonly long[] Value=A277878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277878.Bytes);
public long this[int i]=>Value[i];

public static A277878Inst Instance=new A277878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277879
{
public static readonly long[] Value={ 2L,281L,2L,3L,2L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277879Inst : IEnumerable<long>
{
public static readonly long[] Value=A277879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277879.Bytes);
public long this[int i]=>Value[i];

public static A277879Inst Instance=new A277879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277880
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,12L,10L,9L,7L,24L,20L,18L,15L,8L,48L,40L,36L,30L,17L,11L,96L,80L,72L,60L,34L,23L,13L,192L,160L,144L,120L,68L,46L,27L,14L,384L,320L,288L,240L,136L,92L,54L,29L,16L,768L,640L,576L,480L,272L,184L,108L,58L,33L,19L,1536L,1280L,1152L,960L,544L,368L,216L,116L,66L,39L,21L,3072L,2560L,2304L,1920L,1088L,736L,432L,232L,132L,78L,43L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277880Inst : IEnumerable<long>
{
public static readonly long[] Value=A277880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277880.Bytes);
public long this[int i]=>Value[i];

public static A277880Inst Instance=new A277880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277881
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,15L,9L,8L,21L,7L,28L,36L,14L,45L,20L,13L,55L,12L,66L,78L,27L,11L,91L,105L,35L,120L,44L,19L,136L,153L,54L,26L,171L,18L,190L,210L,65L,17L,231L,253L,77L,276L,90L,34L,300L,16L,325L,351L,104L,378L,119L,43L,406L,435L,135L,53L,465L,25L,496L,528L,152L,561L,170L,64L,595L,33L,630L,666L,189L,24L,703L,741L,209L,780L,230L,76L,820L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277881Inst : IEnumerable<long>
{
public static readonly long[] Value=A277881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277881.Bytes);
public long this[int i]=>Value[i];

public static A277881Inst Instance=new A277881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277882
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,8L,15L,18L,20L,24L,11L,17L,30L,36L,40L,48L,13L,23L,34L,60L,72L,80L,96L,14L,27L,46L,68L,120L,144L,160L,192L,16L,29L,54L,92L,136L,240L,288L,320L,384L,19L,33L,58L,108L,184L,272L,480L,576L,640L,768L,21L,39L,66L,116L,216L,368L,544L,960L,1152L,1280L,1536L,22L,43L,78L,132L,232L,432L,736L,1088L,1920L,2304L,2560L,3072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277882Inst : IEnumerable<long>
{
public static readonly long[] Value=A277882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277882.Bytes);
public long this[int i]=>Value[i];

public static A277882Inst Instance=new A277882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277883
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,11L,8L,9L,16L,10L,22L,29L,12L,37L,17L,13L,46L,14L,56L,67L,23L,15L,79L,92L,30L,106L,38L,18L,121L,137L,47L,24L,154L,19L,172L,191L,57L,20L,211L,232L,68L,254L,80L,31L,277L,21L,301L,326L,93L,352L,107L,39L,379L,407L,122L,48L,436L,25L,466L,497L,138L,529L,155L,58L,562L,32L,596L,631L,173L,26L,667L,704L,192L,742L,212L,69L,781L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277883Inst : IEnumerable<long>
{
public static readonly long[] Value=A277883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277883.Bytes);
public long this[int i]=>Value[i];

public static A277883Inst Instance=new A277883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277884
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,5L,6L,7L,8L,2L,6L,9L,1L,10L,11L,12L,13L,14L,6L,4L,8L,10L,15L,16L,13L,2L,11L,17L,1L,18L,19L,20L,21L,22L,6L,23L,13L,10L,3L,7L,1L,14L,15L,17L,8L,24L,25L,26L,27L,22L,11L,4L,13L,18L,25L,28L,21L,2L,19L,29L,1L,30L,31L,32L,33L,34L,6L,35L,21L,10L,25L,36L,37L,22L,3L,17L,13L,5L,15L,12L,38L,2L,15L,23L,1L,24L,39L,28L,37L,14L,25L,40L,8L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277884Inst : IEnumerable<long>
{
public static readonly long[] Value=A277884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277884.Bytes);
public long this[int i]=>Value[i];

public static A277884Inst Instance=new A277884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277885
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,3L,0L,2L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,1L,4L,3L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,2L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,3L,1L,0L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,4L,2L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277885Inst : IEnumerable<long>
{
public static readonly long[] Value=A277885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277885.Bytes);
public long this[int i]=>Value[i];

public static A277885Inst Instance=new A277885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277886
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,7L,6L,5L,10L,11L,9L,13L,14L,15L,12L,17L,10L,19L,15L,21L,22L,23L,18L,7L,26L,15L,21L,29L,30L,31L,24L,33L,34L,35L,27L,37L,38L,39L,30L,41L,42L,43L,33L,25L,46L,47L,36L,11L,14L,51L,39L,53L,30L,55L,42L,57L,58L,59L,45L,61L,62L,35L,48L,65L,66L,67L,51L,69L,70L,71L,54L,73L,74L,21L,57L,77L,78L,79L,60L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277886Inst : IEnumerable<long>
{
public static readonly long[] Value=A277886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277886.Bytes);
public long this[int i]=>Value[i];

public static A277886Inst Instance=new A277886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277887
{
public static readonly long[] Value={ 1L,4L,16L,20L,22L,25L,31L,48L,51L,55L,64L,66L,82L,84L,90L,100L,102L,120L,126L,127L,152L,156L,177L,197L,201L,203L,206L,212L,222L,231L,237L,238L,246L,252L,264L,266L,267L,272L,295L,297L,324L,337L,339L,347L,362L,364L,375L,379L,389L,396L,399L,401L,403L,415L,424L,433L,439L,449L,457L,460L,464L,466L,473L,489L,508L,509L,517L,518L,536L,540L,558L,575L,576L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277887Inst : IEnumerable<long>
{
public static readonly long[] Value=A277887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277887.Bytes);
public long this[int i]=>Value[i];

public static A277887Inst Instance=new A277887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277888
{
public static readonly long[] Value={ 3L,11L,43L,53L,59L,67L,83L,131L,139L,149L,173L,179L,227L,233L,251L,277L,283L,331L,347L,349L,419L,431L,491L,547L,557L,563L,571L,587L,617L,643L,659L,661L,683L,701L,733L,739L,743L,757L,821L,827L,907L,941L,947L,971L,1013L,1019L,1051L,1061L,1091L,1109L,1117L,1123L,1129L,1163L,1187L,1213L,1229L,1259L,1283L,1291L,1301L,1307L,1327L,1373L,1427L,1429L,1451L,1453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277888Inst : IEnumerable<long>
{
public static readonly long[] Value=A277888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277888.Bytes);
public long this[int i]=>Value[i];

public static A277888Inst Instance=new A277888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277889
{
public static readonly long[] Value={ 0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,-1L,-2L,-1L,-2L,-3L,-2L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,-2L,-1L,0L,-1L,-2L,-1L,-2L,-1L,-2L,-1L,-2L,-3L,-2L,-1L,-2L,-1L,-2L,-3L,-2L,-3L,-4L,-3L,-2L,-3L,-2L,-1L,-2L,-1L,-2L,-3L,-4L,-3L,-4L,-3L,-2L,-3L,-2L,-1L,-2L,-1L,-2L,-1L,-2L,-3L,-2L,-1L,-2L,-1L,-2L,-1L,0L,-1L,0L,1L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277889Inst : IEnumerable<long>
{
public static readonly long[] Value=A277889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277889.Bytes);
public long this[int i]=>Value[i];

public static A277889Inst Instance=new A277889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277890
{
public static readonly long[] Value={ 0L,2L,0L,3L,2L,3L,1L,5L,3L,4L,4L,6L,3L,5L,3L,7L,8L,8L,6L,8L,9L,10L,6L,8L,10L,10L,7L,11L,10L,13L,11L,12L,12L,14L,10L,13L,12L,13L,14L,15L,13L,15L,15L,18L,18L,16L,15L,17L,21L,18L,18L,18L,19L,20L,16L,21L,20L,20L,22L,20L,23L,20L,22L,23L,21L,23L,23L,27L,25L,24L,22L,28L,22L,27L,24L,26L,25L,25L,29L,29L,28L,26L,30L,31L,28L,28L,31L,30L,32L,33L,27L,32L,34L,34L,30L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277890Inst : IEnumerable<long>
{
public static readonly long[] Value=A277890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277890.Bytes);
public long this[int i]=>Value[i];

public static A277890Inst Instance=new A277890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277891
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,2L,4L,2L,4L,3L,4L,4L,6L,5L,7L,6L,5L,6L,7L,7L,6L,6L,11L,9L,9L,9L,12L,9L,10L,9L,11L,11L,12L,11L,14L,13L,15L,12L,14L,14L,16L,14L,15L,13L,15L,17L,18L,17L,14L,17L,19L,18L,20L,17L,22L,19L,22L,20L,20L,22L,20L,22L,23L,22L,24L,25L,22L,22L,25L,26L,26L,25L,28L,24L,30L,26L,28L,29L,27L,27L,28L,32L,29L,28L,32L,32L,29L,31L,30L,29L,35L,33L,32L,32L,35L,34L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277891Inst : IEnumerable<long>
{
public static readonly long[] Value=A277891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277891.Bytes);
public long this[int i]=>Value[i];

public static A277891Inst Instance=new A277891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277908
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,14L,15L,20L,21L,23L,24L,33L,34L,35L,36L,37L,38L,43L,44L,46L,47L,50L,51L,60L,61L,64L,65L,66L,67L,76L,77L,90L,91L,93L,94L,103L,104L,105L,106L,116L,117L,127L,128L,140L,141L,144L,145L,147L,148L,154L,155L,163L,164L,167L,168L,200L,201L,206L,207L,215L,216L,247L,248L,275L,276L,285L,286L,287L,288L,293L,294L,295L,296L,303L,304L,313L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277908Inst : IEnumerable<long>
{
public static readonly long[] Value=A277908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277908.Bytes);
public long this[int i]=>Value[i];

public static A277908Inst Instance=new A277908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277909
{
public static readonly long[] Value={ 2L,4L,6L,14L,20L,23L,33L,35L,37L,43L,46L,50L,60L,64L,66L,76L,90L,93L,103L,105L,116L,127L,140L,144L,147L,154L,163L,167L,200L,206L,215L,247L,275L,285L,287L,293L,295L,303L,313L,323L,337L,340L,344L,363L,365L,410L,427L,430L,433L,435L,440L,476L,483L,495L,497L,523L,527L,533L,536L,555L,566L,596L,623L,625L,665L,667L,676L,694L,696L,714L,747L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277909Inst : IEnumerable<long>
{
public static readonly long[] Value=A277909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277909.Bytes);
public long this[int i]=>Value[i];

public static A277909Inst Instance=new A277909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277910
{
public static readonly long[] Value={ 3L,5L,7L,15L,21L,24L,34L,36L,38L,44L,47L,51L,61L,65L,67L,77L,91L,94L,104L,106L,117L,128L,141L,145L,148L,155L,164L,168L,201L,207L,216L,248L,276L,286L,288L,294L,296L,304L,314L,324L,338L,341L,345L,364L,366L,411L,428L,431L,434L,436L,441L,477L,484L,496L,498L,524L,528L,534L,537L,556L,567L,597L,624L,626L,666L,668L,677L,695L,697L,715L,748L,758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277910Inst : IEnumerable<long>
{
public static readonly long[] Value=A277910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277910.Bytes);
public long this[int i]=>Value[i];

public static A277910Inst Instance=new A277910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277911
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,7L,6L,10L,17L,8L,13L,26L,11L,15L,14L,18L,9L,16L,31L,21L,20L,40L,24L,23L,27L,12L,25L,30L,45L,28L,19L,54L,34L,33L,36L,35L,38L,37L,68L,22L,57L,115L,44L,43L,29L,47L,46L,74L,73L,51L,50L,87L,55L,32L,53L,58L,41L,56L,180L,61L,60L,96L,83L,65L,64L,67L,66L,39L,101L,100L,75L,110L,49L,48L,71L,77L,76L,80L,124L,78L,84L,283L,63L,81L,126L,88L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277911Inst : IEnumerable<long>
{
public static readonly long[] Value=A277911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277911.Bytes);
public long this[int i]=>Value[i];

public static A277911Inst Instance=new A277911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277912
{
public static readonly long[] Value={ 0L,1L,7L,38L,175L,714L,2653L,9139L,29563L,90650L,265401L,746142L,2023566L,5314008L,13554912L,33673525L,81654104L,193646588L,449903128L,1025532912L,2296519589L,5058078488L,10968488747L,23440057192L,49406752403L,102792264765L,211242738976L,429066735314L,861868377262L,1713014236294L,3370525567099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277912Inst : IEnumerable<long>
{
public static readonly long[] Value=A277912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277912.Bytes);
public long this[int i]=>Value[i];

public static A277912Inst Instance=new A277912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277913
{
public static readonly long[] Value={ 2L,3L,6L,8L,12L,15L,20L,24L,30L,35L,42L,48L,56L,60L,63L,68L,72L,75L,78L,80L,84L,87L,90L,99L,110L,120L,132L,143L,156L,168L,180L,182L,195L,210L,224L,240L,248L,255L,264L,272L,288L,306L,312L,318L,323L,330L,336L,342L,360L,380L,399L,420L,440L,462L,483L,506L,528L,552L,564L,575L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277913Inst : IEnumerable<long>
{
public static readonly long[] Value=A277913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277913.Bytes);
public long this[int i]=>Value[i];

public static A277913Inst Instance=new A277913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277914
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,2L,1L,2L,1L,0L,1L,2L,3L,4L,5L,4L,5L,4L,5L,6L,5L,4L,3L,4L,5L,4L,5L,4L,3L,2L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,7L,8L,7L,8L,9L,10L,9L,8L,9L,8L,9L,10L,11L,10L,11L,10L,11L,10L,9L,10L,11L,10L,9L,8L,7L,8L,9L,10L,9L,10L,11L,10L,9L,10L,9L,10L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277914Inst : IEnumerable<long>
{
public static readonly long[] Value=A277914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277914.Bytes);
public long this[int i]=>Value[i];

public static A277914Inst Instance=new A277914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277915
{
public static readonly long[] Value={ 8L,7L,12L,11L,9L,15L,29L,22L,13L,16L,23L,43L,25L,14L,20L,53L,46L,49L,31L,18L,21L,103L,79L,67L,58L,33L,19L,24L,191L,137L,106L,69L,71L,41L,21L,28L,47L,229L,206L,131L,89L,86L,44L,26L,30L,59L,94L,361L,239L,157L,92L,87L,50L,27L,32L,311L,118L,139L,382L,274L,158L,115L,98L,55L,28L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277915Inst : IEnumerable<long>
{
public static readonly long[] Value=A277915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277915.Bytes);
public long this[int i]=>Value[i];

public static A277915Inst Instance=new A277915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277916
{
public static readonly ulong[] Value={ 1L,10L,100L,1010L,10000L,101000L,1000100L,10101010L,100000000L,1010000000L,10001000000L,101010100000L,1000000010000L,10100000101000L,100010001000100L,1010101010101010L,10000000000000000L,101000000000000000L,1000100000000000000L,10101010000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277916Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A277916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277916.Bytes);
public ulong this[int i]=>Value[i];

public static A277916Inst Instance=new A277916Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}