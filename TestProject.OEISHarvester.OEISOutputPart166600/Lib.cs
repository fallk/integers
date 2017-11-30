using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197057
{
public static readonly long[] Value={ 1L,4L,10L,18L,28L,47L,93L,189L,357L,640L,1156L,2162L,4102L,7697L,14243L,26307L,48917L,91394L,170572L,317326L,589634L,1096821L,2042877L,3805343L,7083795L,13181280L,24530278L,45664276L,85014554L,158256855L,294565501L,548276423L,1020572419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197057Inst : IEnumerable<long>
{
public static readonly long[] Value=A197057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197057.Bytes);
public long this[int i]=>Value[i];

public static A197057Inst Instance=new A197057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197058
{
public static readonly long[] Value={ 1L,5L,14L,28L,48L,90L,200L,447L,937L,1881L,3813L,7947L,16720L,34862L,71998L,148612L,308152L,640701L,1330955L,2759769L,5719391L,11860647L,24611330L,51069476L,105937956L,219719928L,455740768L,945408061L,1961252075L,4068435185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197058Inst : IEnumerable<long>
{
public static readonly long[] Value=A197058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197058.Bytes);
public long this[int i]=>Value[i];

public static A197058Inst Instance=new A197058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197059
{
public static readonly long[] Value={ 1L,7L,22L,47L,90L,211L,547L,1364L,3190L,7411L,17630L,42520L,101976L,242655L,576887L,1375887L,3286861L,7846310L,18711439L,44618322L,106438197L,253962851L,605897990L,1445349638L,3447805485L,8224998562L,19621841396L,46809917238L,111668032901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197059Inst : IEnumerable<long>
{
public static readonly long[] Value=A197059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197059.Bytes);
public long this[int i]=>Value[i];

public static A197059Inst Instance=new A197059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197060
{
public static readonly long[] Value={ 1L,10L,38L,93L,200L,547L,1685L,4932L,13343L,35901L,99603L,280909L,785677L,2175329L,6019355L,16730920L,46595762L,129615164L,360051905L,1000167816L,2780017546L,7729131408L,21485039780L,59712094301L,165955469526L,461272868992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197060Inst : IEnumerable<long>
{
public static readonly long[] Value=A197060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197060.Bytes);
public long this[int i]=>Value[i];

public static A197060Inst Instance=new A197060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197061
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,5L,10L,10L,5L,1L,1L,7L,14L,18L,14L,7L,1L,1L,10L,22L,28L,28L,22L,10L,1L,1L,14L,38L,47L,48L,47L,38L,14L,1L,1L,19L,67L,93L,90L,90L,93L,67L,19L,1L,1L,26L,111L,189L,200L,211L,200L,189L,111L,26L,1L,1L,36L,179L,357L,447L,547L,547L,447L,357L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197061Inst : IEnumerable<long>
{
public static readonly long[] Value=A197061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197061.Bytes);
public long this[int i]=>Value[i];

public static A197061Inst Instance=new A197061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197062
{
public static readonly long[] Value={ 3L,8L,13L,17L,31L,32L,50L,55L,75L,91L,98L,100L,105L,129L,162L,183L,241L,288L,311L,334L,381L,392L,413L,489L,553L,578L,615L,651L,670L,722L,726L,741L,844L,968L,1013L,1152L,1164L,1261L,1264L,1461L,1561L,1601L,1682L,1800L,1809L,1905L,1979L,2048L,2225L,2312L,2450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197062Inst : IEnumerable<long>
{
public static readonly long[] Value=A197062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197062.Bytes);
public long this[int i]=>Value[i];

public static A197062Inst Instance=new A197062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197063
{
public static readonly BigInteger[] Value={ 1L,5L,76L,3466L,645970L,387792259L,814152081238L,5880410307808966L,BigInteger.Parse("145748906353392828573") };
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
public class A197063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197063Inst Instance=new A197063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197064
{
public static readonly long[] Value={ 3L,11L,76L,408L,2026L,10582L,55882L,292564L,1530151L,8011519L,41953630L,219665320L,1150106497L,6021786417L,31529327887L,165083020845L,864350463984L,4525614428894L,23695466872796L,124066050968884L,649591959407978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197064Inst : IEnumerable<long>
{
public static readonly long[] Value=A197064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197064.Bytes);
public long this[int i]=>Value[i];

public static A197064Inst Instance=new A197064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197065
{
public static readonly long[] Value={ 4L,34L,408L,3466L,33407L,338295L,3302634L,32228538L,317069301L,3110367731L,30494103708L,299200276162L,2935153005359L,28791440736323L,282438007986238L,2770639649805104L,27178969275479327L,266616968388816645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197065Inst : IEnumerable<long>
{
public static readonly long[] Value=A197065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197065.Bytes);
public long this[int i]=>Value[i];

public static A197065Inst Instance=new A197065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197066
{
public static readonly BigInteger[] Value={ 6L,101L,2026L,33407L,645970L,11800402L,211057159L,3846342121L,70050139103L,1273134867769L,23158212416004L,421168937252570L,7658668692237200L,139281021815759142L,2532960317909556863L,BigInteger.Parse("46063788501768631565") };
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
public class A197066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197066Inst Instance=new A197066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197067
{
public static readonly BigInteger[] Value={ 9L,299L,10582L,338295L,11800402L,387792259L,12999535244L,440670363348L,14820242617606L,498301224553681L,16772367971351743L,564485156664944432L,BigInteger.Parse("18997537893037092284"),BigInteger.Parse("639342717193072673719"),BigInteger.Parse("21516206463644850941597") };
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
public class A197067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197067Inst Instance=new A197067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197068
{
public static readonly BigInteger[] Value={ 13L,890L,55882L,3302634L,211057159L,12999535244L,814152081238L,50916124396857L,3169573665892646L,197847302932994974L,12351729551918734858UL,BigInteger.Parse("770687990728503616778"),BigInteger.Parse("48091585181900385239782"),BigInteger.Parse("3001138140644565155352997") };
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
public class A197068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197068Inst Instance=new A197068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197069
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,11L,11L,4L,6L,34L,76L,34L,6L,9L,101L,408L,408L,101L,9L,13L,299L,2026L,3466L,2026L,299L,13L,19L,890L,10582L,33407L,33407L,10582L,890L,19L,28L,2643L,55882L,338295L,645970L,338295L,55882L,2643L,28L,41L,7855L,292564L,3302634L,11800402L,11800402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197069Inst : IEnumerable<long>
{
public static readonly long[] Value=A197069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197069.Bytes);
public long this[int i]=>Value[i];

public static A197069Inst Instance=new A197069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197070
{
public static readonly long[] Value={ 9L,0L,1L,5L,4L,2L,6L,7L,7L,3L,6L,9L,6L,9L,5L,7L,1L,4L,0L,4L,9L,8L,0L,3L,6L,2L,1L,1L,3L,3L,5L,8L,7L,4L,9L,3L,0L,7L,3L,7L,3L,9L,7L,1L,9L,2L,5L,5L,3L,7L,4L,1L,6L,1L,3L,4L,4L,2L,0L,3L,6L,6L,6L,5L,0L,6L,3L,7L,8L,6L,5L,4L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197070Inst : IEnumerable<long>
{
public static readonly long[] Value=A197070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197070.Bytes);
public long this[int i]=>Value[i];

public static A197070Inst Instance=new A197070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197071
{
public static readonly long[] Value={ 1L,3L,6L,4L,3L,7L,6L,3L,5L,3L,8L,4L,1L,8L,4L,1L,3L,4L,7L,4L,8L,5L,7L,8L,3L,6L,2L,5L,4L,3L,1L,3L,5L,5L,7L,7L,0L,2L,1L,0L,1L,2L,7L,4L,8L,3L,7L,2L,3L,9L,2L,4L,3L,9L,9L,9L,0L,0L,8L,5L,4L,7L,3L,1L,9L,9L,5L,9L,2L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197071Inst : IEnumerable<long>
{
public static readonly long[] Value=A197071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197071.Bytes);
public long this[int i]=>Value[i];

public static A197071Inst Instance=new A197071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197072
{
public static readonly long[] Value={ -1L,1L,5L,15L,25L,49L,97L,181L,433L,819L,1541L,3147L,6271L,12469L,25087L,49455L,99255L,196057L,391815L,781893L,1555935L,3106511L,6191001L,12351963L,24658715L,49173803L,98136735L,195868789L,391110307L,780774507L,1559147549L,3113261723L,6218243597L,12419791799L,24808942497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197072Inst : IEnumerable<long>
{
public static readonly long[] Value=A197072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197072.Bytes);
public long this[int i]=>Value[i];

public static A197072Inst Instance=new A197072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197073
{
public static readonly long[] Value={ 1L,6L,51L,1407L,109286L,25822213L,17446576240L,34357189974652L,197907262786979354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197073Inst : IEnumerable<long>
{
public static readonly long[] Value=A197073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197073.Bytes);
public long this[int i]=>Value[i];

public static A197073Inst Instance=new A197073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197074
{
public static readonly long[] Value={ 3L,13L,51L,205L,812L,3295L,13286L,53418L,215148L,866828L,3490915L,14058935L,56624663L,228059383L,918511377L,3699344410L,14899280605L,60007424663L,241682293896L,973385377892L,3920348996747L,15789363847963L,63592303009792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197074Inst : IEnumerable<long>
{
public static readonly long[] Value=A197074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197074.Bytes);
public long this[int i]=>Value[i];

public static A197074Inst Instance=new A197074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197075
{
public static readonly long[] Value={ 4L,34L,205L,1407L,9492L,65251L,445506L,3041309L,20782756L,142011656L,970224226L,6628930320L,45292120759L,309453920284L,2114314490865L,14445886493697L,98700314097726L,674361537935123L,4607518893055747L,31480487717138869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197075Inst : IEnumerable<long>
{
public static readonly long[] Value=A197075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197075.Bytes);
public long this[int i]=>Value[i];

public static A197075Inst Instance=new A197075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197076
{
public static readonly long[] Value={ 6L,81L,812L,9492L,109286L,1282123L,14895018L,173097490L,2014367937L,23437273689L,272686908212L,3172875930820L,36918402757845L,429566882643506L,4998281938091148L,58158282162055320L,676709925624440764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197076Inst : IEnumerable<long>
{
public static readonly long[] Value=A197076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197076.Bytes);
public long this[int i]=>Value[i];

public static A197076Inst Instance=new A197076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197077
{
public static readonly BigInteger[] Value={ 9L,199L,3295L,65251L,1282123L,25822213L,513380599L,10204673140L,203083535620L,4041562578683L,80433524292272L,1600907292520303L,31864518855986700L,634235619536089218L,12624003209531266181UL,BigInteger.Parse("251272907445585611658") };
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
public class A197077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197077Inst Instance=new A197077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197078
{
public static readonly BigInteger[] Value={ 13L,487L,13286L,445506L,14895018L,513380599L,17446576240L,592290047724L,20128502440024L,683993118482402L,23243767206546673L,789980959730204326L,BigInteger.Parse("26850332922315114822"),BigInteger.Parse("912620325896540690864"),BigInteger.Parse("31019623434344238447439") };
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
public class A197078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197078Inst Instance=new A197078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197079
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,3L,4L,13L,13L,4L,6L,34L,51L,34L,6L,9L,81L,205L,205L,81L,9L,13L,199L,812L,1407L,812L,199L,13L,19L,487L,3295L,9492L,9492L,3295L,487L,19L,28L,1190L,13286L,65251L,109286L,65251L,13286L,1190L,28L,41L,2910L,53418L,445506L,1282123L,1282123L,445506L,53418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197079Inst : IEnumerable<long>
{
public static readonly long[] Value=A197079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197079.Bytes);
public long this[int i]=>Value[i];

public static A197079Inst Instance=new A197079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197080
{
public static readonly long[] Value={ 1L,5L,1L,2L,14L,1L,3L,3L,2L,2L,2L,7L,1L,4L,10L,1L,2L,2L,31L,1L,4L,1L,9L,2L,8L,1L,2L,1L,4L,1L,3L,1L,4L,2L,1L,3L,63L,1L,1L,1L,44L,1L,2L,7L,3L,2L,5L,5L,5L,9L,1L,1L,2L,10L,1L,1L,1L,2L,1L,19L,4L,2L,1L,5L,5L,16L,1L,47L,198L,3L,1L,111L,3L,2L,3L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197080Inst : IEnumerable<long>
{
public static readonly long[] Value=A197080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197080.Bytes);
public long this[int i]=>Value[i];

public static A197080Inst Instance=new A197080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197081
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,3L,3L,2L,3L,4L,3L,4L,4L,4L,5L,6L,5L,4L,6L,6L,7L,7L,7L,7L,9L,10L,8L,9L,9L,11L,12L,12L,11L,11L,13L,15L,16L,13L,15L,16L,17L,20L,19L,17L,20L,23L,20L,22L,23L,23L,27L,29L,26L,25L,30L,31L,32L,34L,33L,32L,38L,41L,37L,39L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197081Inst : IEnumerable<long>
{
public static readonly long[] Value=A197081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197081.Bytes);
public long this[int i]=>Value[i];

public static A197081Inst Instance=new A197081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197082
{
public static readonly BigInteger[] Value={ 2L,9L,75L,625L,5145L,42875L,352947L,2941225L,28824005L,282475249L,4882786447L,60287465315L,744365643175L,10212696624361L,118890080527911L,1387050939492295L,17125833028425275L,211451611881577375L,2584630720649942503L,BigInteger.Parse("30088718564300934153"),BigInteger.Parse("351035049916844231785") };
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
public class A197082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197082Inst Instance=new A197082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197083
{
public static readonly long[] Value={ 0L,10L,96L,445L,1431L,3681L,8141L,16142L,29466L,50412L,81862L,127347L,191113L,278187L,394443L,546668L,742628L,991134L,1302108L,1686649L,2157099L,2727109L,3411705L,4227354L,5192030L,6325280L,7648290L,9183951L,10956925L,12993711L,15322711L,17974296L,20980872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197083Inst : IEnumerable<long>
{
public static readonly long[] Value=A197083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197083.Bytes);
public long this[int i]=>Value[i];

public static A197083Inst Instance=new A197083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197084
{
public static readonly long[] Value={ 1L,2L,25L,631L,71867L,21996614L,21989908007L,68650847877254L,670636652224421841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197084Inst : IEnumerable<long>
{
public static readonly long[] Value=A197084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197084.Bytes);
public long this[int i]=>Value[i];

public static A197084Inst Instance=new A197084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197085
{
public static readonly long[] Value={ 1L,5L,25L,96L,422L,1780L,7537L,31911L,135283L,573054L,2427879L,10286742L,43582082L,184647156L,782310778L,3314472134L,14042671183L,59495654829L,252069704002L,1067962669281L,4524717892087L,19170212756069L,81219883046173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197085Inst : IEnumerable<long>
{
public static readonly long[] Value=A197085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197085.Bytes);
public long this[int i]=>Value[i];

public static A197085Inst Instance=new A197085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197086
{
public static readonly long[] Value={ 1L,10L,96L,631L,5101L,37952L,289564L,2200339L,16713718L,127074214L,965583306L,7338942170L,55775566553L,423896532807L,3221643820945L,24484602637498L,186084334450133L,1414249624483974L,10748366775916853L,81688112676072415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197086Inst : IEnumerable<long>
{
public static readonly long[] Value=A197086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197086.Bytes);
public long this[int i]=>Value[i];

public static A197086Inst Instance=new A197086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197087
{
public static readonly long[] Value={ 1L,26L,422L,5101L,71867L,939690L,12635748L,168802858L,2257145231L,30181119596L,403549336200L,5395982997113L,72149973349274L,964732771720273L,12899599151591706L,172482705147134597L,2306295510150788549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197087Inst : IEnumerable<long>
{
public static readonly long[] Value=A197087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197087.Bytes);
public long this[int i]=>Value[i];

public static A197087Inst Instance=new A197087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197088
{
public static readonly BigInteger[] Value={ 1L,65L,1780L,37952L,939690L,21996614L,522569033L,12390326286L,293837693200L,6966924806564L,165206045134788L,3917486496222700L,92893560385495116L,2202749723178772681L,BigInteger.Parse("52232959654975192248"),BigInteger.Parse("1238579861912517506541") };
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
public class A197088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197088Inst Instance=new A197088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197089
{
public static readonly BigInteger[] Value={ 1L,161L,7537L,289564L,12635748L,522569033L,21989908007L,923559415946L,38737498552503L,1625808615727565L,68233833241429320L,2863571252883915815L,BigInteger.Parse("120178359677506216775"),BigInteger.Parse("5043597906899270802555"),BigInteger.Parse("211668526758336137032851") };
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
public class A197089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197089Inst Instance=new A197089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197090
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,10L,25L,10L,1L,1L,26L,96L,96L,26L,1L,1L,65L,422L,631L,422L,65L,1L,1L,161L,1780L,5101L,5101L,1780L,161L,1L,1L,403L,7537L,37952L,71867L,37952L,7537L,403L,1L,1L,1006L,31911L,289564L,939690L,939690L,289564L,31911L,1006L,1L,1L,2511L,135283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197090Inst : IEnumerable<long>
{
public static readonly long[] Value=A197090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197090.Bytes);
public long this[int i]=>Value[i];

public static A197090Inst Instance=new A197090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197091
{
public static readonly BigInteger[] Value={ 1L,7L,74L,3477L,457357L,183439730L,227951140324L,864930843239459L,10066466828015680364UL,BigInteger.Parse("359074320635161326740035") };
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
public class A197091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197091Inst Instance=new A197091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197092
{
public static readonly long[] Value={ 1L,7L,18L,55L,163L,484L,1439L,4275L,12704L,37749L,112171L,333314L,990437L,2943067L,8745274L,25986435L,77218255L,229452748L,681814987L,2026001783L,6020230272L,17889013145L,53156902119L,157954841890L,469360159865L,1394695832255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197092Inst : IEnumerable<long>
{
public static readonly long[] Value=A197092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197092.Bytes);
public long this[int i]=>Value[i];

public static A197092Inst Instance=new A197092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197093
{
public static readonly long[] Value={ 2L,18L,74L,384L,1880L,9274L,45843L,226260L,1117379L,5517062L,27241839L,134512788L,664185673L,3279563167L,16193558462L,79959241428L,394816250117L,1949491619113L,9626041441314L,47530685870146L,234693161662954L,1158848838643225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197093Inst : IEnumerable<long>
{
public static readonly long[] Value=A197093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197093.Bytes);
public long this[int i]=>Value[i];

public static A197093Inst Instance=new A197093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197094
{
public static readonly long[] Value={ 3L,55L,384L,3477L,30071L,259856L,2253537L,19514155L,169056920L,1464412705L,12685404677L,109886670038L,951885707773L,8245652221757L,71427443730770L,618735770258261L,5359759927360759L,46428585278694262L,402184717612536457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197094Inst : IEnumerable<long>
{
public static readonly long[] Value=A197094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197094.Bytes);
public long this[int i]=>Value[i];

public static A197094Inst Instance=new A197094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197095
{
public static readonly long[] Value={ 5L,163L,1880L,30071L,457357L,6929744L,105551542L,1604683081L,24408630177L,371223947273L,5645973938300L,85870216988266L,1306005491430390L,19863143482191568L,302100042452359958L,4594662801689083927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197095Inst : IEnumerable<long>
{
public static readonly long[] Value=A197095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197095.Bytes);
public long this[int i]=>Value[i];

public static A197095Inst Instance=new A197095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197096
{
public static readonly BigInteger[] Value={ 8L,484L,9274L,259856L,6929744L,183439730L,4886330995L,129901784708L,3454992362269L,91881627486594L,2443544908738875L,64984869174255048L,1728236147537632767L,BigInteger.Parse("45961525529160717907"),BigInteger.Parse("1222321979162332900054") };
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
public class A197096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197096Inst Instance=new A197096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197097
{
public static readonly BigInteger[] Value={ 13L,1439L,45843L,2253537L,105551542L,4886330995L,227951140324L,10611747125529L,494205872758082L,23013994189839780L,1071725356148151651L,BigInteger.Parse("49908553928282027953"),BigInteger.Parse("2324157974481616112739"),BigInteger.Parse("108232267483106900191660") };
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
public class A197097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197097Inst Instance=new A197097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197098
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,18L,18L,3L,5L,55L,74L,55L,5L,8L,163L,384L,384L,163L,8L,13L,484L,1880L,3477L,1880L,484L,13L,21L,1439L,9274L,30071L,30071L,9274L,1439L,21L,34L,4275L,45843L,259856L,457357L,259856L,45843L,4275L,34L,55L,12704L,226260L,2253537L,6929744L,6929744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197098Inst : IEnumerable<long>
{
public static readonly long[] Value=A197098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197098.Bytes);
public long this[int i]=>Value[i];

public static A197098Inst Instance=new A197098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197099
{
public static readonly long[] Value={ 1L,2L,4L,32L,48L,180L,189L,224L,288L,360L,432L,1280L,1344L,1536L,1600L,4096L,28672L,46656L,54000L,108000L,131220L,150528L,225792L,262440L,405450L,442800L,525312L,532480L,590400L,594000L,630784L,633600L,655360L,792000L,819200L,885600L,950400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197099Inst : IEnumerable<long>
{
public static readonly long[] Value=A197099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197099.Bytes);
public long this[int i]=>Value[i];

public static A197099Inst Instance=new A197099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197100
{
public static readonly long[] Value={ -3L,-3L,-5L,5L,1L,1L,13L,-71L,47L,97L,-65L,23L,73L,-149L,719L,-345L,2453L,299L,1737L,7851L,5359L,22021L,30039L,45211L,143627L,210871L,404681L,627271L,1446107L,2401465L,5033375L,8279849L,16695395L,30641101L,59192219L,107592545L,209720011L,386315899L,747523379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197100Inst : IEnumerable<long>
{
public static readonly long[] Value=A197100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197100.Bytes);
public long this[int i]=>Value[i];

public static A197100Inst Instance=new A197100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197101
{
public static readonly BigInteger[] Value={ 2L,78L,50831L,478107878L,63216096026066L,BigInteger.Parse("117783697209668555853") };
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
public class A197101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197101Inst Instance=new A197101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197102
{
public static readonly long[] Value={ 2L,6L,16L,61L,212L,753L,2661L,9415L,33302L,117802L,416703L,1474018L,5214089L,18443961L,65242401L,230783990L,816359440L,2887733833L,10214871388L,36133384697L,127815754113L,452126672783L,1599321849338L,5657331300590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197102Inst : IEnumerable<long>
{
public static readonly long[] Value=A197102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197102.Bytes);
public long this[int i]=>Value[i];

public static A197102Inst Instance=new A197102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197103
{
public static readonly long[] Value={ 6L,78L,1015L,13526L,181032L,2421376L,32393085L,433365018L,5797636941L,77561969587L,1037640271854L,13881766929498L,185713161140663L,2484509257009467L,33238281011983990L,444668628838107492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197103Inst : IEnumerable<long>
{
public static readonly long[] Value=A197103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197103.Bytes);
public long this[int i]=>Value[i];

public static A197103Inst Instance=new A197103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197104
{
public static readonly BigInteger[] Value={ 16L,1015L,50831L,2548972L,127561432L,6385146382L,319626874708L,15999836095846L,800916441358294L,40092114594159126L,2006923132890272745L,BigInteger.Parse("100462160201819897870"),BigInteger.Parse("5028914884473383292290"),BigInteger.Parse("251736423646820731452182") };
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
public class A197104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197104Inst Instance=new A197104Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197105
{
public static readonly BigInteger[] Value={ 61L,13526L,2548972L,478107878L,89735942231L,16851142959473L,3164557733113615L,594285270687803282L,BigInteger.Parse("111603060903635664138"),BigInteger.Parse("20958362653981821987537"),BigInteger.Parse("3935850790928404307414023"),BigInteger.Parse("739128413975624217196282524") };
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
public class A197105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197105Inst Instance=new A197105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197106
{
public static readonly BigInteger[] Value={ 212L,181032L,127561432L,89735942231L,63216096026066L,44545247280268585L,BigInteger.Parse("31390101087203449414"),BigInteger.Parse("22119869262708036718308"),BigInteger.Parse("15587336304367972010506477"),BigInteger.Parse("10984020530189934999886659182"),BigInteger.Parse("7740175041472778186520710031686") };
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
public class A197106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197106Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197106.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197106Inst Instance=new A197106Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197107
{
public static readonly BigInteger[] Value={ 753L,2421376L,6385146382L,16851142959473L,44545247280268585L,BigInteger.Parse("117783697209668555853") };
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
public class A197107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197107Inst Instance=new A197107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197108
{
public static readonly BigInteger[] Value={ 2661L,32393085L,319626874708L,3164557733113615L,BigInteger.Parse("31390101087203449414") };
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
public class A197108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197108Inst Instance=new A197108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197109
{
public static readonly long[] Value={ 2L,6L,6L,16L,78L,16L,61L,1015L,1015L,61L,212L,13526L,50831L,13526L,212L,753L,181032L,2548972L,2548972L,181032L,753L,2661L,2421376L,127561432L,478107878L,127561432L,2421376L,2661L,9415L,32393085L,6385146382L,89735942231L,89735942231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197109Inst : IEnumerable<long>
{
public static readonly long[] Value=A197109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197109.Bytes);
public long this[int i]=>Value[i];

public static A197109Inst Instance=new A197109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197110
{
public static readonly long[] Value={ 8L,1L,1L,7L,4L,2L,4L,2L,5L,2L,8L,3L,3L,5L,3L,6L,4L,3L,6L,3L,7L,0L,0L,2L,7L,7L,2L,4L,0L,5L,8L,7L,5L,9L,2L,7L,0L,8L,1L,0L,6L,3L,2L,1L,3L,9L,3L,9L,0L,4L,5L,1L,8L,0L,7L,6L,2L,2L,3L,2L,1L,6L,1L,5L,8L,3L,0L,9L,0L,4L,6L,2L,1L,4L,0L,2L,2L,6L,6L,3L,4L,9L,1L,7L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197110Inst : IEnumerable<long>
{
public static readonly long[] Value=A197110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197110.Bytes);
public long this[int i]=>Value[i];

public static A197110Inst Instance=new A197110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197111
{
public static readonly long[] Value={ 0L,1L,2L,6L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,2L,7L,1L,5L,5L,53L,3L,29L,3L,2L,6L,1L,1L,2L,1L,4L,8L,3L,2L,2L,1L,13L,1L,3L,1L,2L,1L,1L,1L,1L,2L,11L,4L,1L,37L,1L,142L,2L,1L,1L,8L,1L,19L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,3L,24L,1L,1L,1L,7L,1L,55L,9L,1L,1L,1L,224L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197111Inst : IEnumerable<long>
{
public static readonly long[] Value=A197111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197111.Bytes);
public long this[int i]=>Value[i];

public static A197111Inst Instance=new A197111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197112
{
public static readonly long[] Value={ 193L,3529L,9337L,27229L,46793L,78181L,90193L,112993L,135013L,437183L,849403L,935219L,1078579L,1283599L,1986973L,2209583L,2341183L,2411173L,2689693L,2744143L,3619069L,3712543L,4738183L,5132983L,6596119L,7829029L,8184713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197112Inst : IEnumerable<long>
{
public static readonly long[] Value=A197112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197112.Bytes);
public long this[int i]=>Value[i];

public static A197112Inst Instance=new A197112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197113
{
public static readonly long[] Value={ 1L,9L,10L,15L,21L,25L,26L,27L,33L,34L,35L,39L,45L,49L,50L,51L,55L,57L,58L,63L,65L,69L,74L,75L,77L,81L,82L,85L,87L,91L,93L,95L,99L,105L,106L,111L,115L,117L,119L,121L,122L,123L,125L,129L,130L,133L,135L,141L,143L,145L,146L,147L,153L,155L,159L,161L,165L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197113Inst : IEnumerable<long>
{
public static readonly long[] Value=A197113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197113.Bytes);
public long this[int i]=>Value[i];

public static A197113Inst Instance=new A197113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197114
{
public static readonly long[] Value={ 32009L,52009L,82009L,92009L,120091L,120097L,172009L,182009L,200903L,200909L,200927L,200929L,200971L,200983L,200987L,200989L,242009L,272009L,302009L,322009L,332009L,420097L,442009L,452009L,512009L,532009L,620099L,622009L,682009L,692009L,720091L,742009L,752009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197114Inst : IEnumerable<long>
{
public static readonly long[] Value=A197114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197114.Bytes);
public long this[int i]=>Value[i];

public static A197114Inst Instance=new A197114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197115
{
public static readonly long[] Value={ 2L,8L,10L,17L,18L,26L,32L,37L,40L,41L,50L,58L,65L,68L,72L,73L,74L,82L,89L,90L,97L,98L,101L,104L,106L,113L,122L,128L,130L,137L,145L,148L,153L,160L,162L,164L,170L,185L,193L,197L,200L,202L,218L,226L,232L,233L,234L,241L,242L,250L,257L,260L,265L,269L,272L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197115Inst : IEnumerable<long>
{
public static readonly long[] Value=A197115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197115.Bytes);
public long this[int i]=>Value[i];

public static A197115Inst Instance=new A197115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197116
{
public static readonly long[] Value={ 0L,2L,2L,2L,4L,1L,3L,1L,2L,2L,5L,1L,4L,2L,1L,2L,4L,3L,3L,1L,2L,1L,4L,1L,1L,1L,0L,2L,3L,1L,6L,1L,3L,1L,2L,3L,3L,3L,3L,1L,7L,3L,2L,1L,4L,2L,3L,1L,3L,1L,2L,2L,3L,1L,4L,3L,3L,1L,3L,0L,4L,0L,3L,3L,3L,2L,1L,2L,0L,3L,1L,2L,4L,4L,3L,1L,4L,2L,3L,3L,3L,2L,3L,6L,0L,4L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197116Inst : IEnumerable<long>
{
public static readonly long[] Value=A197116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197116.Bytes);
public long this[int i]=>Value[i];

public static A197116Inst Instance=new A197116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197117
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,2L,0L,3L,2L,2L,0L,3L,1L,4L,0L,3L,2L,5L,2L,4L,2L,1L,1L,2L,3L,2L,1L,2L,2L,3L,0L,4L,2L,4L,1L,2L,4L,7L,0L,4L,3L,3L,0L,4L,5L,1L,0L,3L,2L,2L,1L,1L,2L,2L,0L,2L,3L,2L,1L,4L,0L,5L,0L,2L,5L,4L,0L,7L,4L,2L,2L,7L,0L,3L,1L,2L,0L,5L,0L,2L,3L,1L,0L,4L,4L,0L,0L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197117Inst : IEnumerable<long>
{
public static readonly long[] Value=A197117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197117.Bytes);
public long this[int i]=>Value[i];

public static A197117Inst Instance=new A197117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197118
{
public static readonly long[] Value={ 1L,2L,2L,3L,0L,4L,2L,3L,1L,4L,1L,4L,2L,1L,2L,5L,0L,5L,1L,2L,2L,4L,2L,4L,1L,3L,0L,6L,2L,4L,0L,4L,1L,3L,3L,4L,1L,4L,3L,2L,0L,5L,7L,1L,0L,5L,1L,5L,0L,1L,3L,7L,2L,8L,3L,4L,1L,4L,2L,8L,0L,3L,5L,6L,0L,7L,2L,2L,1L,1L,2L,8L,1L,2L,1L,7L,0L,2L,0L,3L,0L,5L,0L,4L,1L,2L,2L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197118Inst : IEnumerable<long>
{
public static readonly long[] Value=A197118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197118.Bytes);
public long this[int i]=>Value[i];

public static A197118Inst Instance=new A197118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197119
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,3L,2L,1L,1L,1L,2L,2L,2L,2L,4L,0L,5L,3L,3L,1L,3L,2L,2L,0L,3L,1L,4L,1L,3L,4L,1L,0L,4L,3L,1L,3L,1L,1L,2L,1L,4L,2L,2L,2L,1L,1L,3L,0L,0L,0L,4L,3L,1L,2L,6L,0L,4L,1L,2L,1L,2L,3L,3L,0L,3L,8L,4L,0L,2L,1L,1L,0L,1L,1L,4L,0L,3L,1L,7L,1L,5L,2L,1L,1L,4L,2L,3L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197119Inst : IEnumerable<long>
{
public static readonly long[] Value=A197119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197119.Bytes);
public long this[int i]=>Value[i];

public static A197119Inst Instance=new A197119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197120
{
public static readonly long[] Value={ 5L,13L,20L,29L,45L,52L,53L,61L,80L,85L,109L,116L,117L,125L,149L,157L,173L,180L,181L,208L,212L,229L,244L,245L,261L,277L,293L,317L,320L,325L,340L,365L,397L,405L,421L,436L,445L,461L,464L,468L,477L,493L,500L,509L,533L,541L,549L,565L,596L,605L,613L,628L,629L,637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197120Inst : IEnumerable<long>
{
public static readonly long[] Value=A197120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197120.Bytes);
public long this[int i]=>Value[i];

public static A197120Inst Instance=new A197120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197121
{
public static readonly long[] Value={ 21L,69L,77L,84L,93L,133L,165L,189L,205L,213L,221L,237L,253L,276L,285L,301L,308L,309L,336L,341L,357L,372L,413L,429L,437L,453L,469L,501L,517L,525L,532L,581L,589L,597L,621L,645L,660L,669L,693L,717L,741L,749L,756L,789L,805L,820L,837L,852L,861L,869L,884L,893L,917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197121Inst : IEnumerable<long>
{
public static readonly long[] Value=A197121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197121.Bytes);
public long this[int i]=>Value[i];

public static A197121Inst Instance=new A197121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197122
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,7L,7L,11L,12L,17L,18L,26L,28L,37L,40L,53L,57L,74L,79L,101L,109L,136L,145L,181L,195L,237L,255L,308L,332L,397L,427L,506L,546L,641L,688L,807L,868L,1007L,1081L,1250L,1342L,1544L,1655L,1893L,2033L,2313L,2477L,2812L,3015L,3403L,3644L,4102L,4390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197122Inst : IEnumerable<long>
{
public static readonly long[] Value=A197122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197122.Bytes);
public long this[int i]=>Value[i];

public static A197122Inst Instance=new A197122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197123
{
public static readonly long[] Value={ 1L,26L,592L,582L,60943L,949129L,8530614L,52637962L,201890888L,4392366484L,89879780761L,756130190263L,3186120489507L,18220874234996L,276854551127715L,8230687217052243L,93415455347042966L,13724950651727463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197123Inst : IEnumerable<long>
{
public static readonly long[] Value=A197123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197123.Bytes);
public long this[int i]=>Value[i];

public static A197123Inst Instance=new A197123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197124
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,11L,31L,71L,9L,23L,29L,313L,74L,14L,34L,75L,35L,96L,16L,77L,17L,37L,98L,38L,99L,710L,110L,310L,7109L,113L,12L,713L,1137L,13L,91L,4L,915L,115L,716L,316L,717L,317L,918L,119L,1193L,19L,719L,92L,112L,232L,27L,22L,923L,32L,39L,24L,125L,1257L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197124Inst : IEnumerable<long>
{
public static readonly long[] Value=A197124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197124.Bytes);
public long this[int i]=>Value[i];

public static A197124Inst Instance=new A197124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197125
{
public static readonly long[] Value={ 1L,4L,9L,10L,40L,90L,100L,400L,900L,1000L,1111L,1177L,1224L,1242L,1339L,1393L,1422L,1717L,1771L,1933L,2124L,2142L,2214L,2241L,2412L,2421L,3139L,3193L,3319L,3391L,3913L,3931L,4000L,4122L,4212L,4221L,4444L,4588L,4669L,4696L,4858L,4885L,4966L,5488L,5848L,5884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197125Inst : IEnumerable<long>
{
public static readonly long[] Value=A197125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197125.Bytes);
public long this[int i]=>Value[i];

public static A197125Inst Instance=new A197125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197126
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,4L,2L,0L,1L,8L,2L,1L,0L,1L,11L,4L,2L,1L,0L,1L,19L,5L,3L,1L,1L,0L,1L,26L,10L,3L,3L,1L,1L,0L,1L,41L,11L,7L,3L,2L,1L,1L,0L,1L,56L,20L,8L,5L,3L,2L,1L,1L,0L,1L,83L,25L,13L,6L,5L,2L,2L,1L,1L,0L,1L,112L,38L,17L,11L,5L,5L,2L,2L,1L,1L,0L,1L,160L,49L,25L,13L,9L,5L,4L,2L,2L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197126Inst : IEnumerable<long>
{
public static readonly long[] Value=A197126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197126.Bytes);
public long this[int i]=>Value[i];

public static A197126Inst Instance=new A197126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197127
{
public static readonly long[] Value={ 6L,14L,22L,30L,34L,38L,42L,46L,54L,56L,62L,66L,69L,70L,78L,86L,87L,93L,94L,102L,110L,114L,115L,118L,126L,130L,132L,134L,138L,142L,146L,150L,154L,155L,156L,158L,159L,166L,174L,177L,178L,182L,183L,184L,185L,186L,190L,194L,198L,206L,210L,214L,220L,222L,228L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197127Inst : IEnumerable<long>
{
public static readonly long[] Value=A197127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197127.Bytes);
public long this[int i]=>Value[i];

public static A197127Inst Instance=new A197127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197128
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,23L,24L,26L,27L,28L,29L,31L,32L,33L,35L,37L,39L,40L,41L,43L,44L,45L,47L,48L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,63L,65L,67L,68L,71L,72L,73L,74L,75L,76L,77L,79L,80L,82L,83L,84L,85L,88L,89L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197128Inst : IEnumerable<long>
{
public static readonly long[] Value=A197128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197128.Bytes);
public long this[int i]=>Value[i];

public static A197128Inst Instance=new A197128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197129
{
public static readonly long[] Value={ 1L,4L,9L,10L,40L,90L,100L,400L,900L,1000L,1111L,1224L,1242L,1339L,1393L,1422L,1933L,2124L,2142L,2214L,2241L,2412L,2421L,3139L,3193L,3319L,3391L,3913L,3931L,4000L,4122L,4212L,4221L,4444L,4669L,4696L,4966L,6469L,6496L,6649L,6694L,6946L,6964L,9000L,9133L,9313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197129Inst : IEnumerable<long>
{
public static readonly long[] Value=A197129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197129.Bytes);
public long this[int i]=>Value[i];

public static A197129Inst Instance=new A197129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197130
{
public static readonly BigInteger[] Value={ 1L,10L,100L,1136L,14816L,220032L,3679488L,68548608L,1409347584L,31717048320L,775808778240L,20499651624960L,582040706088960L,17674457139118080L,571655258741145600L,BigInteger.Parse("19621314364126003200"),BigInteger.Parse("712374154997583052800"),BigInteger.Parse("27277192770051951820800") };
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
public class A197130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197130Inst Instance=new A197130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197131
{
public static readonly BigInteger[] Value={ 4L,46L,544L,7216L,108096L,1816704L,33951744L,699512832L,15765626880L,386046443520L,10208951009280L,290039357767680L,8811722692362240L,285113464809062400L,9789232245217689600UL,BigInteger.Parse("355501479519741542400"),BigInteger.Parse("13615286053738276454400"),BigInteger.Parse("548476851979845579571200") };
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
public class A197131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197131Inst Instance=new A197131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197132
{
public static readonly long[] Value={ 1L,4L,16L,52L,157L,434L,1144L,2862L,6906L,16090L,36449L,80430L,173555L,366802L,761102L,1552569L,3118508L,6174461L,12064383L,23283027L,44419855L,83834278L,156626605L,289839251L,531534746L,966483534L,1743164649L,3119864511L,5543030861L,9779552117L,17139055493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197132Inst : IEnumerable<long>
{
public static readonly long[] Value=A197132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197132.Bytes);
public long this[int i]=>Value[i];

public static A197132Inst Instance=new A197132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197133
{
public static readonly long[] Value={ 2L,7L,2L,9L,7L,1L,8L,4L,9L,2L,3L,6L,8L,2L,4L,9L,5L,0L,4L,0L,8L,6L,1L,6L,8L,0L,6L,0L,8L,3L,8L,6L,9L,8L,3L,1L,0L,4L,7L,4L,0L,6L,6L,5L,1L,9L,6L,6L,4L,4L,0L,1L,8L,2L,7L,6L,6L,8L,0L,0L,0L,1L,1L,4L,8L,4L,3L,3L,5L,9L,2L,7L,0L,1L,0L,2L,2L,0L,8L,9L,0L,4L,3L,5L,9L,2L,4L,4L,8L,6L,4L,3L,1L,9L,4L,0L,5L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197133Inst : IEnumerable<long>
{
public static readonly long[] Value=A197133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197133.Bytes);
public long this[int i]=>Value[i];

public static A197133Inst Instance=new A197133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197134
{
public static readonly long[] Value={ 1L,1L,5L,4L,0L,2L,2L,6L,7L,3L,8L,7L,1L,2L,7L,8L,8L,2L,8L,5L,9L,2L,3L,6L,7L,4L,7L,9L,5L,7L,3L,6L,8L,7L,0L,4L,8L,4L,0L,3L,5L,4L,2L,1L,9L,7L,7L,9L,8L,2L,0L,1L,9L,0L,3L,3L,3L,9L,1L,1L,7L,8L,6L,8L,2L,4L,2L,8L,6L,9L,2L,2L,4L,2L,3L,8L,9L,4L,6L,1L,7L,7L,3L,0L,4L,8L,6L,3L,1L,4L,6L,1L,2L,8L,4L,3L,4L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197134Inst : IEnumerable<long>
{
public static readonly long[] Value=A197134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197134.Bytes);
public long this[int i]=>Value[i];

public static A197134Inst Instance=new A197134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197135
{
public static readonly long[] Value={ 6L,3L,8L,3L,2L,7L,3L,0L,5L,0L,7L,8L,0L,4L,2L,1L,7L,6L,6L,2L,3L,6L,3L,4L,6L,4L,4L,6L,0L,3L,0L,3L,3L,4L,2L,6L,1L,1L,8L,1L,7L,1L,1L,2L,1L,3L,4L,4L,4L,6L,0L,3L,0L,0L,5L,4L,1L,7L,3L,8L,2L,6L,2L,6L,5L,9L,0L,9L,6L,1L,1L,4L,2L,7L,3L,5L,2L,4L,9L,2L,9L,1L,4L,0L,8L,3L,0L,0L,4L,2L,2L,0L,4L,8L,0L,4L,4L,8L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197135Inst : IEnumerable<long>
{
public static readonly long[] Value=A197135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197135.Bytes);
public long this[int i]=>Value[i];

public static A197135Inst Instance=new A197135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197136
{
public static readonly long[] Value={ 4L,5L,5L,4L,0L,1L,9L,1L,3L,1L,2L,1L,4L,9L,0L,1L,8L,8L,6L,2L,7L,7L,3L,7L,4L,4L,3L,2L,4L,0L,1L,8L,1L,2L,5L,1L,0L,4L,1L,4L,1L,8L,8L,0L,2L,7L,0L,2L,7L,8L,0L,0L,6L,8L,4L,8L,2L,9L,8L,3L,7L,6L,5L,8L,3L,5L,7L,6L,7L,1L,1L,6L,7L,0L,4L,9L,2L,9L,6L,4L,8L,5L,6L,6L,4L,5L,9L,0L,6L,1L,5L,5L,5L,8L,4L,7L,3L,3L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197136Inst : IEnumerable<long>
{
public static readonly long[] Value=A197136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197136.Bytes);
public long this[int i]=>Value[i];

public static A197136Inst Instance=new A197136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197137
{
public static readonly long[] Value={ 3L,3L,5L,0L,1L,6L,2L,3L,1L,5L,9L,4L,3L,7L,7L,2L,2L,8L,7L,6L,6L,7L,5L,8L,7L,3L,2L,8L,8L,1L,5L,5L,7L,1L,0L,1L,9L,4L,1L,7L,2L,0L,5L,6L,2L,7L,5L,0L,0L,2L,5L,9L,5L,5L,3L,4L,7L,3L,1L,0L,2L,0L,6L,0L,2L,9L,9L,3L,2L,3L,3L,6L,1L,1L,7L,7L,1L,8L,5L,2L,3L,0L,0L,9L,0L,7L,0L,0L,4L,9L,0L,8L,6L,3L,6L,7L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197137Inst : IEnumerable<long>
{
public static readonly long[] Value=A197137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197137.Bytes);
public long this[int i]=>Value[i];

public static A197137Inst Instance=new A197137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197138
{
public static readonly long[] Value={ 3L,4L,8L,8L,3L,0L,2L,2L,3L,1L,8L,9L,9L,0L,3L,3L,3L,8L,6L,3L,0L,1L,1L,3L,2L,5L,5L,3L,4L,2L,8L,8L,1L,2L,3L,2L,7L,7L,1L,5L,9L,4L,2L,4L,2L,1L,4L,1L,3L,2L,4L,2L,5L,0L,2L,7L,8L,0L,5L,2L,7L,1L,9L,4L,2L,3L,3L,5L,2L,7L,4L,3L,9L,4L,6L,5L,1L,7L,3L,0L,1L,4L,4L,2L,8L,4L,9L,2L,6L,9L,4L,7L,1L,9L,7L,8L,3L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197138Inst : IEnumerable<long>
{
public static readonly long[] Value=A197138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197138.Bytes);
public long this[int i]=>Value[i];

public static A197138Inst Instance=new A197138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197139
{
public static readonly long[] Value={ 2L,8L,8L,6L,1L,1L,7L,1L,0L,5L,8L,9L,8L,0L,0L,1L,2L,9L,1L,5L,3L,6L,7L,2L,6L,5L,3L,2L,0L,0L,9L,5L,1L,1L,4L,1L,4L,5L,1L,7L,1L,7L,7L,6L,1L,7L,4L,7L,7L,3L,9L,4L,8L,5L,3L,3L,8L,8L,0L,7L,7L,5L,4L,2L,9L,4L,9L,9L,1L,5L,0L,7L,4L,1L,3L,0L,8L,4L,2L,4L,6L,6L,2L,4L,9L,4L,9L,2L,7L,6L,4L,3L,9L,9L,0L,1L,8L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197139Inst : IEnumerable<long>
{
public static readonly long[] Value=A197139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197139.Bytes);
public long this[int i]=>Value[i];

public static A197139Inst Instance=new A197139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197140
{
public static readonly long[] Value={ 1L,4L,4L,0L,6L,1L,9L,7L,0L,0L,5L,3L,8L,1L,9L,9L,1L,1L,7L,6L,3L,3L,2L,5L,2L,3L,0L,2L,5L,8L,9L,2L,7L,7L,4L,3L,5L,3L,7L,9L,9L,0L,9L,4L,7L,2L,6L,0L,8L,9L,0L,3L,3L,7L,7L,3L,9L,8L,4L,6L,7L,3L,6L,4L,2L,5L,6L,5L,6L,3L,7L,3L,8L,9L,3L,2L,7L,7L,8L,9L,2L,9L,4L,2L,8L,1L,7L,1L,4L,8L,8L,0L,4L,1L,0L,3L,9L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197140Inst : IEnumerable<long>
{
public static readonly long[] Value=A197140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197140.Bytes);
public long this[int i]=>Value[i];

public static A197140Inst Instance=new A197140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197141
{
public static readonly long[] Value={ 1L,6L,7L,3L,6L,4L,7L,3L,0L,4L,1L,5L,2L,9L,1L,5L,0L,7L,8L,0L,1L,3L,8L,6L,3L,4L,3L,3L,2L,7L,8L,1L,6L,6L,0L,2L,6L,8L,5L,8L,3L,6L,5L,7L,7L,1L,0L,3L,5L,3L,9L,2L,8L,6L,1L,7L,9L,9L,4L,6L,0L,5L,6L,9L,5L,2L,6L,1L,8L,9L,5L,6L,2L,8L,0L,5L,4L,7L,5L,7L,2L,9L,1L,1L,9L,3L,7L,1L,7L,0L,9L,5L,8L,5L,1L,2L,9L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197141Inst : IEnumerable<long>
{
public static readonly long[] Value=A197141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197141.Bytes);
public long this[int i]=>Value[i];

public static A197141Inst Instance=new A197141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197142
{
public static readonly long[] Value={ 2L,6L,9L,1L,4L,1L,3L,9L,7L,9L,7L,8L,1L,7L,3L,6L,7L,9L,1L,9L,2L,8L,8L,6L,5L,6L,0L,5L,7L,5L,3L,2L,2L,5L,2L,1L,8L,3L,8L,5L,7L,6L,7L,6L,4L,6L,9L,2L,4L,6L,8L,9L,7L,0L,9L,7L,1L,2L,4L,7L,6L,5L,3L,6L,6L,0L,0L,4L,2L,2L,1L,8L,8L,2L,5L,9L,8L,6L,2L,1L,0L,6L,1L,9L,1L,0L,1L,9L,6L,9L,9L,3L,8L,3L,3L,7L,6L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197142Inst : IEnumerable<long>
{
public static readonly long[] Value=A197142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197142.Bytes);
public long this[int i]=>Value[i];

public static A197142Inst Instance=new A197142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197143
{
public static readonly long[] Value={ 2L,7L,4L,6L,3L,9L,4L,1L,0L,7L,6L,1L,0L,0L,7L,1L,1L,6L,5L,6L,7L,9L,9L,5L,4L,9L,7L,2L,2L,5L,2L,5L,7L,3L,3L,7L,4L,3L,9L,0L,5L,1L,4L,5L,6L,9L,1L,4L,5L,8L,6L,7L,1L,7L,4L,6L,4L,6L,3L,3L,5L,2L,3L,4L,4L,2L,2L,7L,3L,4L,8L,3L,1L,6L,8L,3L,0L,0L,4L,7L,0L,6L,1L,1L,5L,0L,0L,9L,6L,4L,4L,3L,2L,2L,4L,7L,9L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197143Inst : IEnumerable<long>
{
public static readonly long[] Value=A197143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197143.Bytes);
public long this[int i]=>Value[i];

public static A197143Inst Instance=new A197143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197144
{
public static readonly long[] Value={ 3L,8L,2L,8L,9L,1L,1L,1L,4L,1L,5L,4L,2L,9L,4L,3L,6L,5L,3L,2L,1L,9L,8L,8L,2L,2L,4L,1L,3L,9L,6L,4L,8L,6L,7L,2L,1L,7L,2L,4L,4L,5L,0L,5L,3L,9L,0L,2L,8L,4L,8L,7L,2L,0L,0L,6L,8L,2L,2L,8L,6L,6L,4L,6L,4L,8L,7L,9L,4L,9L,4L,6L,6L,2L,6L,1L,3L,2L,4L,9L,7L,5L,7L,1L,7L,5L,9L,4L,6L,9L,1L,5L,9L,2L,6L,0L,8L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197144Inst : IEnumerable<long>
{
public static readonly long[] Value=A197144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197144.Bytes);
public long this[int i]=>Value[i];

public static A197144Inst Instance=new A197144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197145
{
public static readonly long[] Value={ 3L,7L,4L,2L,3L,8L,9L,1L,4L,2L,4L,4L,5L,1L,8L,4L,1L,9L,5L,1L,8L,5L,8L,7L,4L,1L,5L,7L,1L,6L,1L,4L,0L,6L,6L,7L,0L,4L,5L,0L,6L,4L,6L,4L,8L,5L,2L,6L,0L,5L,4L,6L,0L,6L,9L,0L,4L,8L,1L,7L,1L,5L,0L,7L,3L,7L,4L,9L,5L,6L,2L,2L,6L,8L,0L,8L,9L,9L,8L,5L,9L,9L,2L,0L,1L,0L,6L,0L,7L,8L,9L,0L,7L,6L,1L,6L,9L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197145Inst : IEnumerable<long>
{
public static readonly long[] Value=A197145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197145.Bytes);
public long this[int i]=>Value[i];

public static A197145Inst Instance=new A197145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197146
{
public static readonly long[] Value={ 4L,9L,2L,5L,4L,5L,5L,2L,2L,0L,4L,3L,5L,0L,0L,2L,8L,4L,4L,0L,9L,7L,4L,9L,8L,0L,2L,1L,9L,0L,5L,0L,2L,7L,3L,0L,7L,8L,7L,4L,1L,2L,9L,9L,2L,1L,1L,4L,9L,9L,6L,8L,6L,7L,1L,5L,9L,4L,8L,6L,0L,3L,3L,2L,4L,7L,8L,5L,2L,6L,5L,8L,1L,6L,3L,1L,3L,8L,3L,0L,0L,5L,0L,8L,7L,6L,8L,0L,1L,9L,9L,1L,3L,3L,0L,7L,6L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197146Inst : IEnumerable<long>
{
public static readonly long[] Value=A197146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197146.Bytes);
public long this[int i]=>Value[i];

public static A197146Inst Instance=new A197146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197147
{
public static readonly long[] Value={ 4L,7L,0L,8L,0L,0L,0L,0L,1L,7L,4L,9L,6L,4L,6L,0L,2L,7L,3L,9L,3L,1L,7L,3L,5L,6L,4L,4L,1L,0L,5L,4L,5L,3L,5L,3L,3L,8L,5L,0L,6L,9L,2L,6L,7L,9L,9L,5L,1L,2L,9L,0L,8L,3L,1L,2L,1L,0L,9L,5L,6L,9L,5L,1L,9L,1L,4L,2L,6L,9L,5L,3L,3L,3L,0L,7L,7L,9L,3L,1L,2L,8L,6L,3L,1L,3L,7L,8L,1L,7L,5L,8L,5L,6L,3L,2L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197147Inst : IEnumerable<long>
{
public static readonly long[] Value=A197147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197147.Bytes);
public long this[int i]=>Value[i];

public static A197147Inst Instance=new A197147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197148
{
public static readonly long[] Value={ 1L,6L,0L,4L,7L,9L,3L,6L,1L,8L,4L,6L,2L,1L,3L,9L,9L,0L,7L,3L,7L,8L,3L,1L,7L,9L,5L,0L,7L,1L,7L,9L,6L,1L,8L,4L,6L,7L,1L,5L,4L,4L,9L,2L,1L,9L,9L,9L,1L,2L,8L,6L,0L,7L,7L,8L,6L,3L,6L,2L,9L,2L,2L,1L,4L,9L,2L,1L,6L,3L,7L,2L,6L,1L,9L,1L,2L,6L,0L,4L,2L,1L,6L,6L,7L,9L,9L,7L,0L,2L,2L,8L,4L,7L,0L,1L,4L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197148Inst : IEnumerable<long>
{
public static readonly long[] Value=A197148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197148.Bytes);
public long this[int i]=>Value[i];

public static A197148Inst Instance=new A197148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197149
{
public static readonly long[] Value={ 1L,9L,9L,9L,1L,5L,8L,3L,9L,9L,5L,8L,0L,3L,4L,4L,2L,6L,8L,8L,1L,7L,4L,2L,3L,5L,4L,3L,8L,4L,6L,1L,6L,4L,7L,3L,4L,1L,3L,2L,8L,2L,3L,4L,7L,1L,1L,8L,9L,0L,6L,8L,3L,7L,7L,0L,9L,2L,8L,1L,2L,8L,1L,0L,4L,6L,8L,5L,4L,8L,5L,2L,8L,7L,0L,0L,4L,9L,0L,3L,2L,7L,6L,5L,3L,7L,3L,7L,5L,1L,3L,1L,8L,9L,2L,0L,5L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197149Inst : IEnumerable<long>
{
public static readonly long[] Value=A197149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197149.Bytes);
public long this[int i]=>Value[i];

public static A197149Inst Instance=new A197149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197150
{
public static readonly long[] Value={ 2L,8L,5L,1L,0L,5L,9L,7L,9L,0L,6L,2L,9L,8L,6L,2L,6L,3L,9L,8L,2L,6L,0L,7L,2L,3L,4L,0L,8L,5L,3L,6L,2L,6L,8L,9L,3L,3L,3L,9L,0L,9L,3L,5L,8L,1L,7L,2L,2L,1L,0L,1L,7L,3L,2L,2L,7L,0L,3L,3L,5L,9L,2L,6L,3L,9L,6L,4L,6L,0L,5L,4L,3L,6L,4L,2L,1L,0L,3L,0L,0L,7L,6L,0L,4L,2L,3L,4L,3L,8L,3L,2L,1L,8L,5L,2L,6L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197150Inst : IEnumerable<long>
{
public static readonly long[] Value=A197150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197150.Bytes);
public long this[int i]=>Value[i];

public static A197150Inst Instance=new A197150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197151
{
public static readonly long[] Value={ 3L,1L,6L,0L,9L,4L,6L,9L,7L,3L,0L,6L,5L,4L,4L,6L,5L,0L,6L,1L,3L,5L,8L,4L,4L,2L,7L,9L,9L,1L,7L,5L,8L,5L,1L,2L,1L,8L,2L,1L,5L,9L,8L,7L,5L,0L,7L,7L,8L,1L,5L,1L,2L,0L,1L,1L,2L,2L,6L,6L,0L,0L,3L,9L,0L,9L,7L,3L,9L,2L,1L,0L,8L,9L,2L,2L,3L,1L,0L,1L,2L,3L,7L,1L,5L,4L,0L,1L,3L,3L,7L,8L,3L,3L,5L,1L,0L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197151Inst : IEnumerable<long>
{
public static readonly long[] Value=A197151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197151.Bytes);
public long this[int i]=>Value[i];

public static A197151Inst Instance=new A197151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197152
{
public static readonly long[] Value={ 3L,1L,5L,0L,9L,1L,1L,0L,8L,4L,3L,3L,5L,9L,4L,2L,6L,1L,2L,0L,5L,2L,8L,5L,6L,7L,3L,7L,5L,4L,2L,1L,5L,0L,1L,4L,0L,6L,2L,2L,5L,6L,2L,9L,3L,7L,1L,7L,4L,0L,6L,9L,9L,1L,8L,3L,8L,7L,1L,8L,7L,8L,9L,1L,8L,1L,3L,6L,6L,1L,9L,1L,5L,6L,2L,0L,2L,9L,2L,3L,6L,5L,0L,5L,6L,2L,1L,8L,0L,4L,1L,8L,8L,5L,5L,5L,4L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197152Inst : IEnumerable<long>
{
public static readonly long[] Value=A197152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197152.Bytes);
public long this[int i]=>Value[i];

public static A197152Inst Instance=new A197152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197153
{
public static readonly long[] Value={ 1L,4L,8L,1L,5L,0L,6L,5L,0L,5L,8L,4L,4L,3L,0L,9L,1L,9L,4L,0L,3L,5L,9L,2L,5L,3L,0L,6L,6L,1L,1L,1L,4L,1L,7L,3L,6L,8L,1L,0L,5L,2L,2L,1L,1L,7L,1L,5L,7L,4L,1L,6L,1L,8L,6L,8L,5L,0L,4L,8L,6L,5L,0L,0L,7L,1L,1L,5L,4L,4L,9L,9L,4L,7L,0L,5L,6L,5L,9L,1L,4L,7L,2L,5L,7L,2L,4L,3L,2L,3L,1L,9L,0L,7L,7L,4L,3L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197153Inst : IEnumerable<long>
{
public static readonly long[] Value=A197153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197153.Bytes);
public long this[int i]=>Value[i];

public static A197153Inst Instance=new A197153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197154
{
public static readonly long[] Value={ 4L,2L,2L,3L,6L,0L,3L,3L,0L,4L,1L,9L,3L,9L,8L,1L,1L,4L,7L,6L,0L,7L,9L,3L,9L,5L,2L,5L,9L,6L,1L,6L,9L,0L,1L,4L,2L,0L,9L,3L,1L,8L,6L,8L,4L,1L,9L,3L,2L,0L,8L,6L,3L,1L,1L,7L,6L,6L,3L,2L,5L,7L,8L,0L,7L,1L,2L,4L,8L,7L,6L,2L,3L,0L,6L,5L,6L,6L,0L,5L,7L,7L,8L,3L,5L,2L,3L,0L,8L,5L,0L,5L,5L,3L,0L,6L,3L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197154Inst : IEnumerable<long>
{
public static readonly long[] Value=A197154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197154.Bytes);
public long this[int i]=>Value[i];

public static A197154Inst Instance=new A197154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197155
{
public static readonly long[] Value={ 1L,9L,4L,6L,3L,4L,6L,4L,0L,2L,3L,7L,8L,4L,8L,3L,8L,5L,6L,1L,6L,6L,4L,0L,9L,1L,1L,4L,2L,3L,0L,0L,8L,0L,6L,8L,1L,8L,5L,8L,2L,1L,0L,6L,7L,1L,1L,7L,6L,0L,3L,8L,5L,7L,0L,1L,8L,9L,2L,3L,8L,5L,0L,9L,1L,0L,4L,9L,9L,8L,9L,5L,6L,0L,1L,8L,8L,6L,8L,0L,1L,9L,1L,0L,7L,7L,4L,4L,3L,2L,0L,7L,0L,6L,5L,2L,2L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197155Inst : IEnumerable<long>
{
public static readonly long[] Value=A197155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197155.Bytes);
public long this[int i]=>Value[i];

public static A197155Inst Instance=new A197155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197156
{
public static readonly long[] Value={ 1L,3L,5L,20L,56L,225L,819L,3333L,13336L,55231L,229146L,963284L,4068503L,17301000L,73893082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197156Inst : IEnumerable<long>
{
public static readonly long[] Value=A197156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197156.Bytes);
public long this[int i]=>Value[i];

public static A197156Inst Instance=new A197156Inst();

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