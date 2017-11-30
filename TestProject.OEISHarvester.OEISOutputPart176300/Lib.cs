using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A206757
{
public static readonly BigInteger[] Value={ 7010L,1002015L,151490088L,22816914744L,3433011146796L,516680726881281L,77761210840373532L,11703109168740768786UL,BigInteger.Parse("1761326885997547548069"),BigInteger.Parse("265081031088260037886873"),BigInteger.Parse("39894896316961156440661115") };
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
public class A206757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206757Inst Instance=new A206757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206758
{
public static readonly BigInteger[] Value={ 56970L,21403411L,8593845900L,3433011146796L,1369877126104389L,546822154520262723L,BigInteger.Parse("218272782111457761883"),BigInteger.Parse("87126442650702977795783"),BigInteger.Parse("34777725083499964890984227"),BigInteger.Parse("13882009241923927696955420829") };
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
public class A206758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206758Inst Instance=new A206758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206759
{
public static readonly BigInteger[] Value={ 463064L,457325164L,487641463195L,516680726881281L,546822154520262723L,BigInteger.Parse("578960195790179305672"),BigInteger.Parse("612965374305549492727567"),BigInteger.Parse("648963710428833478397389783") };
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
public class A206759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206759Inst Instance=new A206759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206760
{
public static readonly BigInteger[] Value={ 3764188L,9771502433L,27669705981731L,77761210840373532L,BigInteger.Parse("218272782111457761883"),BigInteger.Parse("612965374305549492727567") };
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
public class A206760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206760Inst Instance=new A206760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206761
{
public static readonly long[] Value={ 14L,106L,106L,861L,2187L,861L,7010L,46860L,46860L,7010L,56970L,1002015L,2668146L,1002015L,56970L,463064L,21403411L,151490088L,151490088L,21403411L,463064L,3764188L,457325164L,8593845900L,22816914744L,8593845900L,457325164L,3764188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206761Inst : IEnumerable<long>
{
public static readonly long[] Value=A206761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206761.Bytes);
public long this[int i]=>Value[i];

public static A206761Inst Instance=new A206761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206762
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,2L,5L,6L,1L,8L,2L,5L,7L,2L,3L,0L,5L,8L,4L,16L,3L,8L,4L,10L,1L,13L,8L,2L,19L,4L,11L,11L,7L,3L,1L,12L,13L,4L,1L,24L,2L,8L,5L,9L,25L,16L,2L,12L,0L,26L,0L,17L,22L,44L,22L,37L,7L,48L,4L,37L,18L,7L,39L,16L,19L,7L,15L,19L,36L,30L,1L,14L,15L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206762Inst : IEnumerable<long>
{
public static readonly long[] Value=A206762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206762.Bytes);
public long this[int i]=>Value[i];

public static A206762Inst Instance=new A206762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206763
{
public static readonly BigInteger[] Value={ 1L,1L,0L,3L,23L,225L,2824L,42670L,762286L,15647321L,363901749L,9443387329L,270721307582L,8493470965716L,289518611494068L,10653599202688527L,420933469388468297L,17773313165985120798UL,BigInteger.Parse("798686060913371460133"),BigInteger.Parse("38058408270727983373232") };
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
public class A206763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206763Inst Instance=new A206763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206764
{
public static readonly BigInteger[] Value={ 1L,-1L,10L,79L,1026L,15686L,279938L,5771359L,134218243L,3487832974L,100000000002L,3138673052878L,106993205379074L,3937454749863382L,155568096631586820L,6568441588686506943L,BigInteger.Parse("295147905179352825858"),BigInteger.Parse("14063102470280932000757"),BigInteger.Parse("708235345355337676357634") };
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
public class A206764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206764Inst Instance=new A206764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206765
{
public static readonly BigInteger[] Value={ 1L,1L,12L,87L,907L,8393L,118932L,1683990L,31209334L,635005549L,15054451057L,393600573337L,11466736952722L,363842430190308L,12564913404375244L,467483278911401155L,BigInteger.Parse("18670853023655302285"),BigInteger.Parse("795978439482823960066"),BigInteger.Parse("36093307429580735618893") };
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
public class A206765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206765Inst Instance=new A206765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206766
{
public static readonly BigInteger[] Value={ 1L,23L,226L,3039L,33306L,594902L,10012010L,220553599L,5170061143L,138942811678L,4049569009674L,130045043225838L,4503599691290714L,168477832912220134L,6746676272050878036L,BigInteger.Parse("288487396687082933759"),BigInteger.Parse("13107200000016921588858"),BigInteger.Parse("630907565930072760920429") };
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
public class A206766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206766Inst Instance=new A206766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206767
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,10L,10L,11L,12L,13L,14L,14L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,22L,23L,24L,25L,25L,26L,27L,27L,28L,29L,30L,30L,31L,32L,32L,33L,34L,35L,35L,36L,36L,37L,37L,38L,39L,40L,40L,41L,41L,42L,43L,43L,44L,45L,46L,46L,47L,47L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206767Inst : IEnumerable<long>
{
public static readonly long[] Value=A206767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206767.Bytes);
public long this[int i]=>Value[i];

public static A206767Inst Instance=new A206767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206768
{
public static readonly long[] Value={ 3L,5L,5L,7L,7L,11L,81L,11L,11L,13L,13L,17L,4431L,17L,17L,19L,19L,23L,25L,23L,23L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206768Inst : IEnumerable<long>
{
public static readonly long[] Value=A206768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206768.Bytes);
public long this[int i]=>Value[i];

public static A206768Inst Instance=new A206768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206769
{
public static readonly long[] Value={ 3L,4L,6L,8L,6L,5L,2L,1L,1L,0L,2L,3L,8L,0L,9L,4L,9L,6L,0L,4L,2L,0L,3L,5L,1L,0L,0L,0L,4L,7L,1L,1L,3L,3L,2L,5L,3L,1L,8L,1L,1L,8L,7L,8L,0L,5L,7L,1L,6L,2L,0L,0L,8L,2L,3L,3L,6L,4L,4L,9L,2L,4L,3L,8L,6L,8L,1L,1L,8L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206769Inst : IEnumerable<long>
{
public static readonly long[] Value=A206769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206769.Bytes);
public long this[int i]=>Value[i];

public static A206769Inst Instance=new A206769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206770
{
public static readonly long[] Value={ 5L,7L,11L,11L,13L,17L,17L,19L,23L,23L,29L,29L,21L,31L,37L,37L,37L,41L,28L,33L,47L,47L,53L,53L,53L,59L,59L,44L,61L,67L,67L,67L,71L,57L,73L,79L,79L,79L,83L,83L,69L,89L,74L,101L,68L,97L,97L,85L,101L,103L,107L,107L,109L,113L,93L,131L,127L,127L,131L,127L,127L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206770Inst : IEnumerable<long>
{
public static readonly long[] Value=A206770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206770.Bytes);
public long this[int i]=>Value[i];

public static A206770Inst Instance=new A206770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206771
{
public static readonly long[] Value={ 0L,1L,1L,9L,5L,175L,189L,1617L,429L,57915L,60775L,508079L,264537L,8788507L,9100525L,75218625L,9694845L,5109183315L,5250613995L,43106892675L,22090789875L,723694276305L,740104577355L,6049284520695L,1543768261425L,201547523019375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206771Inst : IEnumerable<long>
{
public static readonly long[] Value=A206771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206771.Bytes);
public long this[int i]=>Value[i];

public static A206771Inst Instance=new A206771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206772
{
public static readonly long[] Value={ 1L,5L,5L,9L,6L,9L,13L,10L,10L,13L,17L,14L,11L,14L,17L,21L,18L,15L,15L,18L,21L,25L,22L,19L,16L,19L,22L,25L,29L,26L,23L,20L,20L,23L,26L,29L,33L,30L,27L,24L,21L,24L,27L,30L,33L,37L,34L,31L,28L,25L,25L,28L,31L,34L,37L,41L,38L,35L,32L,29L,26L,29L,32L,35L,38L,41L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206772Inst : IEnumerable<long>
{
public static readonly long[] Value=A206772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206772.Bytes);
public long this[int i]=>Value[i];

public static A206772Inst Instance=new A206772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206773
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,11L,1L,1L,1L,13L,1L,16L,1L,15L,1L,1L,1L,31L,1L,1L,10L,19L,1L,32L,1L,29L,1L,1L,1L,50L,1L,1L,1L,43L,1L,42L,1L,27L,25L,1L,1L,71L,1L,36L,1L,31L,1L,61L,1L,55L,1L,1L,1L,98L,1L,1L,31L,61L,1L,62L,1L,39L,1L,60L,1L,118L,1L,1L,41L,43L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206773Inst : IEnumerable<long>
{
public static readonly long[] Value=A206773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206773.Bytes);
public long this[int i]=>Value[i];

public static A206773Inst Instance=new A206773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206774
{
public static readonly long[] Value={ 0L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-4L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-4L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-4L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206774Inst : IEnumerable<long>
{
public static readonly long[] Value=A206774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206774.Bytes);
public long this[int i]=>Value[i];

public static A206774Inst Instance=new A206774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206775
{
public static readonly long[] Value={ 1L,4L,6L,7L,11L,12L,15L,17L,22L,24L,28L,31L,40L,42L,43L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206775Inst : IEnumerable<long>
{
public static readonly long[] Value=A206775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206775.Bytes);
public long this[int i]=>Value[i];

public static A206775Inst Instance=new A206775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206776
{
public static readonly long[] Value={ 2L,3L,13L,45L,161L,573L,2041L,7269L,25889L,92205L,328393L,1169589L,4165553L,14835837L,52838617L,188187525L,670239809L,2387094477L,8501763049L,30279478101L,107841960401L,384084837405L,1367938433017L,4871984973861L,17351831787617L,61799465310573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206776Inst : IEnumerable<long>
{
public static readonly long[] Value=A206776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206776.Bytes);
public long this[int i]=>Value[i];

public static A206776Inst Instance=new A206776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206777
{
public static readonly long[] Value={ 1L,1L,2L,3L,9L,15L,75L,133L,676L,1712L,7295L,16797L,100889L,208013L,1083061L,3186268L,14634359L,35357671L,209715154L,477638701L,2679305455L,7638371497L,35224117709L,91482563641L,568102780247L,1311836293464L,6979729709485L,21256008509080L,103440124113965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206777Inst : IEnumerable<long>
{
public static readonly long[] Value=A206777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206777.Bytes);
public long this[int i]=>Value[i];

public static A206777Inst Instance=new A206777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206778
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,1L,5L,1L,2L,3L,6L,1L,7L,1L,2L,1L,3L,1L,2L,5L,10L,1L,11L,1L,2L,3L,6L,1L,13L,1L,2L,7L,14L,1L,3L,5L,15L,1L,2L,1L,17L,1L,2L,3L,6L,1L,19L,1L,2L,5L,10L,1L,3L,7L,21L,1L,2L,11L,22L,1L,23L,1L,2L,3L,6L,1L,5L,1L,2L,13L,26L,1L,3L,1L,2L,7L,14L,1L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206778Inst : IEnumerable<long>
{
public static readonly long[] Value=A206778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206778.Bytes);
public long this[int i]=>Value[i];

public static A206778Inst Instance=new A206778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206779
{
public static readonly BigInteger[] Value={ 2L,16L,230L,6752L,316744L,25571618L,3210775788L,659966594476L,210237711494832L,108398626938474968L,BigInteger.Parse("87023259420675848572"),BigInteger.Parse("113203578571407946861858"),BigInteger.Parse("230632914425943836888182164") };
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
public class A206779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206779Inst Instance=new A206779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206780
{
public static readonly long[] Value={ 7L,49L,230L,1020L,4120L,16109L,61003L,227197L,834806L,3041436L,11009856L,39680145L,142545383L,510891025L,1827957230L,6532356532L,23322885552L,83216416445L,296774223739L,1058010185133L,3770863749966L,13437211488900L,47875876583016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206780Inst : IEnumerable<long>
{
public static readonly long[] Value=A206780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206780.Bytes);
public long this[int i]=>Value[i];

public static A206780Inst Instance=new A206780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206781
{
public static readonly long[] Value={ 12L,144L,1020L,6752L,39276L,219061L,1165366L,6052170L,30750128L,154046108L,762592234L,3742458919L,18234837346L,88348314182L,426051182458L,2046737779538L,9800851550334L,46804771654291L,223004711416620L,1060425465768772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206781Inst : IEnumerable<long>
{
public static readonly long[] Value=A206781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206781.Bytes);
public long this[int i]=>Value[i];

public static A206781Inst Instance=new A206781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206782
{
public static readonly long[] Value={ 20L,400L,4120L,39276L,316744L,2431277L,17515482L,122505076L,831545408L,5542985790L,36347298916L,235599789563L,1511905540616L,9627564142088L,60901858059234L,383175178571448L,2399618712548128L,14968430954427611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206782Inst : IEnumerable<long>
{
public static readonly long[] Value=A206782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206782.Bytes);
public long this[int i]=>Value[i];

public static A206782Inst Instance=new A206782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206783
{
public static readonly long[] Value={ 33L,1089L,16109L,219061L,2431277L,25571618L,248652016L,2339185464L,21198003576L,188119640818L,1635325209384L,14020483612445L,118681118328599L,995030464602413L,8271058337085215L,68276292898767503L,560139098581304227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206783Inst : IEnumerable<long>
{
public static readonly long[] Value=A206783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206783.Bytes);
public long this[int i]=>Value[i];

public static A206783Inst Instance=new A206783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206784
{
public static readonly long[] Value={ 54L,2916L,61003L,1165366L,17515482L,248652016L,3210775788L,40009922008L,476334876958L,5542093365196L,62879423961226L,702454161467961L,7727332842269952L,84083787760092394L,905578254568069211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206784Inst : IEnumerable<long>
{
public static readonly long[] Value=A206784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206784.Bytes);
public long this[int i]=>Value[i];

public static A206784Inst Instance=new A206784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206785
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,12L,49L,49L,12L,20L,144L,230L,144L,20L,33L,400L,1020L,1020L,400L,33L,54L,1089L,4120L,6752L,4120L,1089L,54L,88L,2916L,16109L,39276L,39276L,16109L,2916L,88L,143L,7744L,61003L,219061L,316744L,219061L,61003L,7744L,143L,232L,20449L,227197L,1165366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206785Inst : IEnumerable<long>
{
public static readonly long[] Value=A206785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206785.Bytes);
public long this[int i]=>Value[i];

public static A206785Inst Instance=new A206785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206786
{
public static readonly long[] Value={ 1L,1L,56L,1L,67L,56L,56L,1L,67L,67L,253L,56L,67L,56L,1L,1L,56L,67L,56L,67L,67L,253L,1L,56L,56L,67L,1L,56L,1L,1L,155L,1L,187L,56L,1L,67L,56L,56L,1L,67L,67L,67L,56L,253L,56L,1L,1L,56L,67L,56L,67L,67L,67L,1L,242L,56L,67L,1L,56L,1L,1L,155L,1L,1L,56L,187L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206786Inst : IEnumerable<long>
{
public static readonly long[] Value=A206786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206786.Bytes);
public long this[int i]=>Value[i];

public static A206786Inst Instance=new A206786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206787
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,4L,8L,1L,4L,6L,12L,4L,14L,8L,24L,1L,18L,4L,20L,6L,32L,12L,24L,4L,6L,14L,4L,8L,30L,24L,32L,1L,48L,18L,48L,4L,38L,20L,56L,6L,42L,32L,44L,12L,24L,24L,48L,4L,8L,6L,72L,14L,54L,4L,72L,8L,80L,30L,60L,24L,62L,32L,32L,1L,84L,48L,68L,18L,96L,48L,72L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206787Inst : IEnumerable<long>
{
public static readonly long[] Value=A206787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206787.Bytes);
public long this[int i]=>Value[i];

public static A206787Inst Instance=new A206787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206788
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,12L,17L,29L,41L,53L,94L,147L,200L,253L,306L,359L,665L,971L,1636L,2301L,2966L,3631L,4296L,4961L,5626L,6291L,6956L,7621L,8286L,8951L,9616L,10281L,10946L,11611L,12276L,12941L,13606L,14271L,14936L,15601L,16266L,31867L,47468L,79335L,111202L,190537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206788Inst : IEnumerable<long>
{
public static readonly long[] Value=A206788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206788.Bytes);
public long this[int i]=>Value[i];

public static A206788Inst Instance=new A206788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206789
{
public static readonly BigInteger[] Value={ 4L,256L,180446L,1382766472L,120305843593958L,BigInteger.Parse("118056098980249594900") };
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
public class A206789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206789Inst Instance=new A206789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206790
{
public static readonly long[] Value={ 4L,16L,61L,232L,883L,3361L,12793L,48694L,185344L,705475L,2685250L,10220869L,38903701L,148079185L,563633908L,2145360148L,8165885869L,31081817236L,118306743223L,450311041525L,1714019240113L,6524072662150L,24832582450012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206790Inst : IEnumerable<long>
{
public static readonly long[] Value=A206790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206790.Bytes);
public long this[int i]=>Value[i];

public static A206790Inst Instance=new A206790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206791
{
public static readonly long[] Value={ 16L,256L,3721L,53824L,779689L,11296321L,163660849L,2371105636L,34352398336L,497694975625L,7210567562500L,104466163115161L,1513497951497401L,21927445030264225L,317683182247352464L,4602570164626581904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206791Inst : IEnumerable<long>
{
public static readonly long[] Value=A206791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206791.Bytes);
public long this[int i]=>Value[i];

public static A206791Inst Instance=new A206791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206792
{
public static readonly BigInteger[] Value={ 61L,3721L,180446L,8683735L,420657877L,20388622016L,988006480837L,47875604265753L,2319909967411854L,112416368647596277L,5447383252826053743L,BigInteger.Parse("263964878153391214108"),BigInteger.Parse("12790995849530364514091"),BigInteger.Parse("619815723744309803868951") };
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
public class A206792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206792Inst Instance=new A206792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206793
{
public static readonly BigInteger[] Value={ 232L,53824L,8683735L,1382766472L,222851712982L,35954795295641L,5798927126392378L,935195769843015103L,BigInteger.Parse("150819269855143535380"),BigInteger.Parse("24322790361067935901218"),BigInteger.Parse("3922570242526007854435915") };
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
public class A206793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206793Inst Instance=new A206793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206794
{
public static readonly BigInteger[] Value={ 883L,779689L,420657877L,222851712982L,120305843593958L,65062863493632615L,BigInteger.Parse("35167047469699730422"),BigInteger.Parse("19004801554874439636884"),BigInteger.Parse("10270327007308337981249938"),BigInteger.Parse("5550227464430262903036046771"),BigInteger.Parse("2999437616268613754031487694079") };
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
public class A206794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206794Inst Instance=new A206794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206795
{
public static readonly BigInteger[] Value={ 3361L,11296321L,20388622016L,35954795295641L,65062863493632615L,BigInteger.Parse("118056098980249594900") };
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
public class A206795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206795Inst Instance=new A206795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206796
{
public static readonly BigInteger[] Value={ 12793L,163660849L,988006480837L,5798927126392378L,BigInteger.Parse("35167047469699730422") };
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
public class A206796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206796Inst Instance=new A206796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206797
{
public static readonly long[] Value={ 4L,16L,16L,61L,256L,61L,232L,3721L,3721L,232L,883L,53824L,180446L,53824L,883L,3361L,779689L,8683735L,8683735L,779689L,3361L,12793L,11296321L,420657877L,1382766472L,420657877L,11296321L,12793L,48694L,163660849L,20388622016L,222851712982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206797Inst : IEnumerable<long>
{
public static readonly long[] Value=A206797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206797.Bytes);
public long this[int i]=>Value[i];

public static A206797Inst Instance=new A206797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206798
{
public static readonly long[] Value={ 4L,6L,8L,1L,9L,2L,10L,3L,5L,7L,12L,11L,14L,13L,17L,19L,15L,23L,16L,29L,31L,37L,18L,41L,43L,47L,53L,59L,20L,61L,21L,67L,71L,73L,79L,83L,22L,89L,97L,101L,24L,103L,25L,107L,109L,113L,26L,127L,131L,137L,139L,149L,27L,151L,157L,163L,167L,173L,28L,179L,30L,181L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206798Inst : IEnumerable<long>
{
public static readonly long[] Value=A206798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206798.Bytes);
public long this[int i]=>Value[i];

public static A206798Inst Instance=new A206798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206799
{
public static readonly long[] Value={ 4L,1L,0L,2L,4L,3L,4L,4L,4L,5L,4L,6L,8L,7L,8L,8L,8L,9L,12L,10L,12L,15L,12L,12L,16L,17L,16L,18L,20L,19L,20L,20L,24L,25L,24L,26L,28L,27L,28L,32L,32L,33L,36L,34L,36L,39L,40L,40L,44L,45L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206799Inst : IEnumerable<long>
{
public static readonly long[] Value=A206799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206799.Bytes);
public long this[int i]=>Value[i];

public static A206799Inst Instance=new A206799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206800
{
public static readonly long[] Value={ 1L,3L,1L,8L,5L,1L,21L,19L,7L,1L,55L,65L,34L,9L,1L,144L,210L,141L,53L,11L,1L,377L,654L,534L,257L,76L,13L,1L,987L,1985L,1905L,1111L,421L,103L,15L,1L,2584L,5911L,6512L,4447L,2041L,641L,134L,17L,1L,6765L,17345L,21557L,16837L,9038L,3440L,925L,169L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206800Inst : IEnumerable<long>
{
public static readonly long[] Value=A206800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206800.Bytes);
public long this[int i]=>Value[i];

public static A206800Inst Instance=new A206800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206801
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,285L,5476L,143080L,4840256L,205348521L,10675415800L,667749546288L,49499829165414L,4292944063388838L,430749877491962328L,BigInteger.Parse("49520529524763502478"),BigInteger.Parse("6467220964216618610444"),BigInteger.Parse("952209872438113961762005"),BigInteger.Parse("157000879970348439087083080") };
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
public class A206801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206801Inst Instance=new A206801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206802
{
public static readonly long[] Value={ 1L,3L,9L,13L,23L,29L,43L,67L,76L,106L,128L,140L,166L,208L,253L,269L,320L,356L,375L,435L,477L,543L,635L,683L,708L,760L,787L,843L,1046L,1106L,1199L,1231L,1396L,1430L,1535L,1643L,1717L,1831L,1948L,1988L,2193L,2235L,2321L,2365L,2635L,2911L,3005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206802Inst : IEnumerable<long>
{
public static readonly long[] Value=A206802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206802.Bytes);
public long this[int i]=>Value[i];

public static A206802Inst Instance=new A206802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206803
{
public static readonly long[] Value={ 2L,8L,26L,52L,98L,156L,242L,376L,528L,740L,996L,1276L,1608L,2024L,2530L,3068L,3708L,4420L,5170L,6040L,6994L,8080L,9350L,10716L,12132L,13652L,15226L,16912L,19004L,21216L,23614L,26076L,28868L,31728L,34798L,38084L,41518L,45180L,49076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206803Inst : IEnumerable<long>
{
public static readonly long[] Value=A206803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206803.Bytes);
public long this[int i]=>Value[i];

public static A206803Inst Instance=new A206803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206804
{
public static readonly long[] Value={ 1L,4L,13L,26L,49L,78L,121L,188L,264L,370L,498L,638L,804L,1012L,1265L,1534L,1854L,2210L,2585L,3020L,3497L,4040L,4675L,5358L,6066L,6826L,7613L,8456L,9502L,10608L,11807L,13038L,14434L,15864L,17399L,19042L,20759L,22590L,24538L,26526L,28719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206804Inst : IEnumerable<long>
{
public static readonly long[] Value=A206804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206804.Bytes);
public long this[int i]=>Value[i];

public static A206804Inst Instance=new A206804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206805
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,11L,13L,14L,16L,17L,19L,21L,22L,24L,26L,27L,29L,30L,32L,34L,35L,37L,39L,40L,42L,44L,45L,47L,48L,50L,52L,53L,55L,57L,58L,60L,61L,63L,65L,66L,68L,70L,71L,73L,75L,76L,78L,79L,81L,83L,84L,86L,88L,89L,91L,92L,94L,96L,97L,99L,101L,102L,104L,106L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206805Inst : IEnumerable<long>
{
public static readonly long[] Value=A206805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206805.Bytes);
public long this[int i]=>Value[i];

public static A206805Inst Instance=new A206805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206806
{
public static readonly long[] Value={ 1L,4L,13L,30L,62L,112L,190L,300L,455L,660L,931L,1274L,1708L,2240L,2892L,3672L,4605L,5700L,6985L,8470L,10186L,12144L,14378L,16900L,19747L,22932L,26495L,30450L,34840L,39680L,45016L,50864L,57273L,64260L,71877L,80142L,89110L,98800L,109270L,120540L,132671L,145684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206806Inst : IEnumerable<long>
{
public static readonly long[] Value=A206806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206806.Bytes);
public long this[int i]=>Value[i];

public static A206806Inst Instance=new A206806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206807
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,15L,18L,20L,23L,25L,28L,31L,33L,36L,38L,41L,43L,46L,49L,51L,54L,56L,59L,62L,64L,67L,69L,72L,74L,77L,80L,82L,85L,87L,90L,93L,95L,98L,100L,103L,105L,108L,111L,113L,116L,118L,121L,124L,126L,129L,131L,134L,137L,139L,142L,144L,147L,149L,152L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206807Inst : IEnumerable<long>
{
public static readonly long[] Value=A206807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206807.Bytes);
public long this[int i]=>Value[i];

public static A206807Inst Instance=new A206807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206808
{
public static readonly long[] Value={ 7L,45L,156L,400L,855L,1617L,2800L,4536L,6975L,10285L,14652L,20280L,27391L,36225L,47040L,60112L,75735L,94221L,115900L,141120L,170247L,203665L,241776L,285000L,333775L,388557L,449820L,518056L,593775L,677505L,769792L,871200L,982311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206808Inst : IEnumerable<long>
{
public static readonly long[] Value=A206808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206808.Bytes);
public long this[int i]=>Value[i];

public static A206808Inst Instance=new A206808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206809
{
public static readonly long[] Value={ 7L,52L,208L,608L,1463L,3080L,5880L,10416L,17391L,27676L,42328L,62608L,89999L,126224L,173264L,233376L,309111L,403332L,519232L,660352L,830599L,1034264L,1276040L,1561040L,1894815L,2283372L,2733192L,3251248L,3845023L,4522528L,5292320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206809Inst : IEnumerable<long>
{
public static readonly long[] Value=A206809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206809.Bytes);
public long this[int i]=>Value[i];

public static A206809Inst Instance=new A206809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206810
{
public static readonly long[] Value={ 15L,145L,670L,2146L,5501L,12131L,23996L,43716L,74667L,121077L,188122L,282022L,410137L,581063L,804728L,1092488L,1457223L,1913433L,2477334L,3166954L,4002229L,5005099L,6199604L,7611980L,9270755L,11206845L,13453650L,16047150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206810Inst : IEnumerable<long>
{
public static readonly long[] Value=A206810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206810.Bytes);
public long this[int i]=>Value[i];

public static A206810Inst Instance=new A206810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206811
{
public static readonly long[] Value={ 15L,160L,830L,2976L,8477L,20608L,44604L,88320L,162987L,284064L,472186L,754208L,1164345L,1745408L,2550136L,3642624L,5099847L,7013280L,9490614L,12657568L,16659797L,21664896L,27864500L,35476480L,44747235L,55954080L,69407730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206811Inst : IEnumerable<long>
{
public static readonly long[] Value=A206811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206811.Bytes);
public long this[int i]=>Value[i];

public static A206811Inst Instance=new A206811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206812
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,14L,16L,17L,20L,21L,24L,26L,28L,30L,32L,34L,36L,38L,40L,43L,44L,46L,49L,50L,53L,55L,57L,59L,60L,63L,65L,67L,69L,72L,73L,75L,77L,79L,82L,83L,86L,88L,89L,92L,94L,96L,98L,100L,102L,104L,106L,108L,111L,112L,115L,116L,118L,121L,122L,125L,127L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206812Inst : IEnumerable<long>
{
public static readonly long[] Value=A206812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206812.Bytes);
public long this[int i]=>Value[i];

public static A206812Inst Instance=new A206812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206813
{
public static readonly long[] Value={ 2L,6L,9L,12L,15L,19L,22L,25L,29L,31L,35L,39L,41L,45L,48L,51L,54L,58L,61L,64L,68L,71L,74L,78L,81L,84L,87L,91L,93L,97L,101L,103L,107L,110L,113L,117L,120L,123L,126L,130L,132L,136L,140L,143L,146L,149L,153L,156L,159L,163L,165L,169L,173L,175L,179L,182L,185L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206813Inst : IEnumerable<long>
{
public static readonly long[] Value=A206813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206813.Bytes);
public long this[int i]=>Value[i];

public static A206813Inst Instance=new A206813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206814
{
public static readonly long[] Value={ 4L,8L,13L,18L,23L,27L,33L,37L,42L,47L,52L,56L,62L,66L,70L,76L,80L,85L,90L,95L,99L,105L,109L,114L,119L,124L,128L,134L,138L,142L,147L,152L,157L,161L,167L,171L,176L,181L,186L,190L,196L,200L,204L,210L,214L,219L,224L,229L,233L,239L,243L,248L,253L,258L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206814Inst : IEnumerable<long>
{
public static readonly long[] Value=A206814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206814.Bytes);
public long this[int i]=>Value[i];

public static A206814Inst Instance=new A206814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206815
{
public static readonly long[] Value={ 1L,2L,5L,7L,9L,11L,14L,15L,17L,19L,22L,23L,26L,28L,30L,31L,34L,36L,39L,40L,42L,44L,47L,49L,50L,52L,54L,56L,58L,60L,63L,65L,67L,68L,70L,72L,75L,77L,78L,80L,83L,85L,87L,89L,91L,93L,96L,98L,99L,101L,103L,105L,108L,109L,111L,113L,115L,117L,119L,121L,124L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206815Inst : IEnumerable<long>
{
public static readonly long[] Value=A206815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206815.Bytes);
public long this[int i]=>Value[i];

public static A206815Inst Instance=new A206815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206816
{
public static readonly BigInteger[] Value={ 1L,9L,63L,447L,3447L,29367L,276327L,2856807L,32250087L,395130087L,5225062887L,74201293287L,1126567808487L,18213512883687L,312440245683687L,5668674457011687L,108462341176755687L,2182831421832627687L,BigInteger.Parse("46096712669420979687") };
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
public class A206816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206816Inst Instance=new A206816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206817
{
public static readonly BigInteger[] Value={ 1L,10L,73L,520L,3967L,33334L,309661L,3166468L,35416555L,430546642L,5655609529L,79856902816L,1206424711303L,19419937594990L,331860183278677L,6000534640290364L,114462875817046051L,2297294297649673738L,BigInteger.Parse("48394006967070653425") };
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
public class A206817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206817Inst Instance=new A206817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206818
{
public static readonly long[] Value={ 3L,4L,6L,8L,10L,12L,13L,16L,18L,20L,21L,24L,25L,27L,29L,32L,33L,35L,37L,38L,41L,43L,45L,46L,48L,51L,53L,55L,57L,59L,61L,62L,64L,66L,69L,71L,73L,74L,76L,79L,81L,82L,84L,86L,88L,90L,92L,94L,95L,97L,100L,102L,104L,106L,107L,110L,112L,114L,116L,118L,120L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206818Inst : IEnumerable<long>
{
public static readonly long[] Value=A206818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206818.Bytes);
public long this[int i]=>Value[i];

public static A206818Inst Instance=new A206818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206819
{
public static readonly long[] Value={ 1L,10L,1L,90L,20L,1L,800L,280L,30L,1L,7100L,3400L,570L,40L,1L,63000L,38300L,8800L,960L,50L,1L,559000L,412000L,120600L,18000L,1450L,60L,1L,4960000L,4296000L,1530000L,291000L,32000L,2040L,70L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206819Inst : IEnumerable<long>
{
public static readonly long[] Value=A206819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206819.Bytes);
public long this[int i]=>Value[i];

public static A206819Inst Instance=new A206819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206820
{
public static readonly BigInteger[] Value={ 1L,1L,3L,42L,914L,23694L,1048542L,45379878L,3272115926L,257662344206L,27726935045366L,3101635433302996L,474878584235678020L,BigInteger.Parse("76786899439922296204"),BigInteger.Parse("15844064187141655171020"),BigInteger.Parse("3326909755872288926885670"),BigInteger.Parse("897661138669999282018222470"),BigInteger.Parse("246381314116108359863665821750") };
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
public class A206820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206820Inst Instance=new A206820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206821
{
public static readonly long[] Value={ 2L,3L,7L,8L,10L,14L,16L,18L,21L,23L,29L,31L,35L,41L,42L,44L,48L,50L,54L,56L,60L,62L,66L,70L,72L,76L,78L,80L,82L,84L,86L,88L,93L,97L,99L,103L,109L,111L,115L,117L,123L,125L,129L,131L,137L,141L,143L,147L,153L,155L,159L,161L,165L,167L,171L,173L,179L,183L,186L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206821Inst : IEnumerable<long>
{
public static readonly long[] Value=A206821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206821.Bytes);
public long this[int i]=>Value[i];

public static A206821Inst Instance=new A206821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206822
{
public static readonly long[] Value={ 1L,4L,5L,6L,9L,11L,12L,13L,15L,17L,19L,20L,22L,24L,25L,26L,27L,28L,30L,32L,33L,34L,36L,37L,38L,39L,40L,43L,45L,46L,47L,49L,51L,52L,53L,55L,57L,58L,59L,61L,63L,64L,65L,67L,68L,69L,71L,73L,74L,75L,77L,79L,81L,83L,85L,87L,89L,90L,91L,92L,94L,95L,96L,98L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206822Inst : IEnumerable<long>
{
public static readonly long[] Value=A206822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206822.Bytes);
public long this[int i]=>Value[i];

public static A206822Inst Instance=new A206822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206823
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,2L,3L,18L,0L,6L,40L,48L,144L,0L,24L,205L,1000L,600L,1200L,0L,120L,2556L,7380L,18000L,7200L,10800L,0L,720L,24409L,125244L,180810L,294000L,88200L,105840L,0L,5040L,347712L,1562176L,4007808L,3857280L,4704000L,1128960L,1128960L,0L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206823Inst : IEnumerable<long>
{
public static readonly long[] Value=A206823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206823.Bytes);
public long this[int i]=>Value[i];

public static A206823Inst Instance=new A206823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206824
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,1L,3L,2L,3L,2L,1L,2L,3L,2L,1L,4L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,4L,1L,2L,3L,1L,3L,4L,1L,2L,3L,4L,1L,2L,1L,2L,3L,2L,3L,4L,1L,2L,1L,2L,1L,4L,3L,2L,3L,2L,1L,4L,3L,2L,3L,2L,3L,2L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206824Inst : IEnumerable<long>
{
public static readonly long[] Value=A206824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206824.Bytes);
public long this[int i]=>Value[i];

public static A206824Inst Instance=new A206824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206825
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,3L,2L,0L,0L,1L,0L,0L,0L,7L,0L,2L,0L,1L,0L,0L,0L,3L,4L,0L,8L,1L,0L,0L,0L,7L,0L,0L,0L,5L,0L,0L,0L,3L,0L,0L,0L,1L,2L,0L,0L,7L,6L,4L,0L,1L,0L,8L,0L,3L,0L,0L,0L,1L,0L,0L,2L,15L,0L,0L,0L,1L,0L,0L,0L,11L,0L,0L,4L,1L,0L,0L,0L,7L,26L,0L,0L,1L,0L,0L,0L,3L,0L,2L,0L,1L,0L,0L,0L,7L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206825Inst : IEnumerable<long>
{
public static readonly long[] Value=A206825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206825.Bytes);
public long this[int i]=>Value[i];

public static A206825Inst Instance=new A206825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206826
{
public static readonly long[] Value={ 0L,2L,1L,2L,1L,2L,1L,2L,3L,2L,2L,2L,3L,4L,1L,2L,1L,2L,6L,3L,3L,2L,4L,2L,3L,2L,6L,2L,5L,2L,1L,3L,3L,8L,3L,2L,3L,4L,6L,2L,3L,2L,6L,3L,3L,2L,2L,2L,3L,5L,6L,2L,1L,8L,6L,5L,3L,2L,8L,2L,3L,5L,1L,8L,5L,2L,6L,4L,12L,2L,2L,2L,3L,3L,6L,8L,4L,2L,6L,2L,3L,2L,8L,8L,3L,3L,6L,2L,5L,8L,6L,4L,3L,8L,2L,2L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206826Inst : IEnumerable<long>
{
public static readonly long[] Value=A206826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206826.Bytes);
public long this[int i]=>Value[i];

public static A206826Inst Instance=new A206826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206827
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,1L,1L,3L,2L,2L,2L,3L,3L,1L,2L,1L,2L,3L,3L,3L,2L,1L,2L,3L,1L,3L,2L,3L,2L,1L,3L,3L,8L,1L,2L,3L,3L,3L,2L,4L,2L,3L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,8L,3L,3L,3L,2L,2L,2L,3L,3L,1L,8L,3L,2L,3L,3L,9L,2L,1L,2L,3L,3L,3L,8L,2L,2L,3L,1L,3L,2L,4L,8L,3L,3L,3L,2L,5L,8L,3L,3L,3L,8L,2L,2L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206827Inst : IEnumerable<long>
{
public static readonly long[] Value=A206827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206827.Bytes);
public long this[int i]=>Value[i];

public static A206827Inst Instance=new A206827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206828
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,1L,2L,2L,3L,2L,2L,1L,8L,2L,1L,1L,5L,2L,1L,2L,11L,1L,0L,1L,4L,1L,3L,4L,1L,2L,1L,1L,8L,1L,15L,1L,2L,12L,1L,1L,5L,2L,3L,0L,1L,3L,3L,3L,1L,0L,1L,1L,2L,1L,1L,0L,5L,2L,23L,1L,4L,0L,4L,1L,7L,3L,1L,12L,2L,24L,2L,1L,8L,3L,3L,1L,6L,0L,3L,1L,37L,1L,3L,26L,1L,1L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206828Inst : IEnumerable<long>
{
public static readonly long[] Value=A206828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206828.Bytes);
public long this[int i]=>Value[i];

public static A206828Inst Instance=new A206828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206829
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,3L,3L,1L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,1L,3L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,3L,1L,1L,2L,4L,1L,3L,1L,2L,2L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,2L,2L,3L,1L,2L,2L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206829Inst : IEnumerable<long>
{
public static readonly long[] Value=A206829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206829.Bytes);
public long this[int i]=>Value[i];

public static A206829Inst Instance=new A206829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206830
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,34L,520L,14397L,993806L,222547738L,98753510701L,66772601607218L,82150206439975648L,BigInteger.Parse("310163020349941301606"),BigInteger.Parse("3022167582612808506550780"),BigInteger.Parse("47176617497043375266215814522"),BigInteger.Parse("1129578055293824008530028604347686"),BigInteger.Parse("62478430488069985838347598494293429802") };
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
public class A206830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206830Inst Instance=new A206830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206831
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,-1L,-3L,-1L,1L,1L,0L,-4L,-2L,1L,1L,5L,4L,-4L,-3L,1L,-1L,0L,9L,10L,-3L,-4L,1L,-1L,-7L,-9L,9L,17L,-1L,-5L,1L,1L,0L,-16L,-28L,2L,24L,2L,-6L,1L,1L,9L,16L,-16L,-54L,-14L,30L,6L,-7L,1L,-1L,0L,25L,60L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206831Inst : IEnumerable<long>
{
public static readonly long[] Value=A206831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206831.Bytes);
public long this[int i]=>Value[i];

public static A206831Inst Instance=new A206831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206832
{
public static readonly BigInteger[] Value={ 4L,256L,205518L,2152805235L,289315497297232L,BigInteger.Parse("503617001775793994676") };
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
public class A206832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206832Inst Instance=new A206832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206833
{
public static readonly BigInteger[] Value={ 62L,3844L,205518L,11086238L,594138770L,31871929292L,1709151563122L,91660941819721L,4915627501055508L,263618474002793711L,14137483745254072360UL,BigInteger.Parse("758173414191897631373"),BigInteger.Parse("40659772418623190807112"),BigInteger.Parse("2180526385915587703254011") };
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
public class A206833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206833Inst Instance=new A206833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206834
{
public static readonly BigInteger[] Value={ 241L,58081L,11091161L,2152805235L,413843625776L,79716622309437L,15348900754966668L,2955760887154751440L,BigInteger.Parse("569180485178587224840"),BigInteger.Parse("109606019483652083444194"),BigInteger.Parse("21106586871668692105099671") };
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
public class A206834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206834Inst Instance=new A206834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206835
{
public static readonly BigInteger[] Value={ 936L,876096L,598618182L,418964575189L,289315497297232L,200394014933364651L,BigInteger.Parse("138717281035824236746"),BigInteger.Parse("96044763651330733440061"),BigInteger.Parse("66496497760141121001068506"),BigInteger.Parse("46039394019866319590935260100") };
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
public class A206835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206835Inst Instance=new A206835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206836
{
public static readonly BigInteger[] Value={ 3636L,13220496L,32326073197L,81562078260316L,202239575474145573L,BigInteger.Parse("503617001775793994676"),BigInteger.Parse("1253153235463965319380998"),BigInteger.Parse("3119258907440765674089992703"),BigInteger.Parse("7763820132416499980446666540204") };
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
public class A206836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206836Inst Instance=new A206836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206837
{
public static readonly BigInteger[] Value={ 14124L,199487376L,1745398353572L,15877946803718090L,BigInteger.Parse("141405314141528391344"),BigInteger.Parse("1266270368466567536724535") };
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
public class A206837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206837Inst Instance=new A206837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206838
{
public static readonly long[] Value={ 4L,16L,16L,62L,256L,62L,241L,3844L,3844L,241L,936L,58081L,205518L,58081L,936L,3636L,876096L,11091161L,11086238L,876096L,3636L,14124L,13220496L,598618182L,2152805235L,594138770L,13220496L,14124L,54865L,199487376L,32326073197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206838Inst : IEnumerable<long>
{
public static readonly long[] Value=A206838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206838.Bytes);
public long this[int i]=>Value[i];

public static A206838Inst Instance=new A206838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206839
{
public static readonly long[] Value={ 1L,4L,16L,62L,241L,936L,3636L,14124L,54865L,213124L,827884L,3215930L,12492337L,48526704L,188502840L,732242616L,2844409393L,11049158596L,42920651992L,166726031798L,647650219393L,2515808732184L,9772703517132L,37962239661540L,147464991401185L,572830367302660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206839Inst : IEnumerable<long>
{
public static readonly long[] Value=A206839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206839.Bytes);
public long this[int i]=>Value[i];

public static A206839Inst Instance=new A206839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206840
{
public static readonly BigInteger[] Value={ 1L,16L,256L,3844L,58081L,876096L,13220496L,199487376L,3010168225L,45421839376L,685391917456L,10342205764900L,156058483721569L,2354841001103616L,35533320688065600L,536179248686523456L,8090664794986628449L,BigInteger.Parse("122083905679560691216"),BigInteger.Parse("1842182367418373568064") };
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
public class A206840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206840Inst Instance=new A206840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206841
{
public static readonly BigInteger[] Value={ 62L,3844L,205518L,11091161L,598618182L,32326073197L,1745398353572L,94242149338308L,5088562764245208L,274755325893611168L,14835328260073233210UL,BigInteger.Parse("801029018974028227334"),BigInteger.Parse("43251318116995342267638"),BigInteger.Parse("2335341775687363077659074") };
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
public class A206841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206841Inst Instance=new A206841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206842
{
public static readonly BigInteger[] Value={ 241L,58081L,11086238L,2152805235L,418964575189L,81562078260316L,15877946803718090L,3091067307303254867L,BigInteger.Parse("601761995188912369335"),BigInteger.Parse("117150369608909238252579"),BigInteger.Parse("22806723149404940748682374") };
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
public class A206842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206842Inst Instance=new A206842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206843
{
public static readonly BigInteger[] Value={ 936L,876096L,594138770L,413843625776L,289315497297232L,202239575474145573L,BigInteger.Parse("141405314141528391344"),BigInteger.Parse("98873946045190495775955"),BigInteger.Parse("69135467925548799599684158"),BigInteger.Parse("48341867791501329150634897274") };
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
public class A206843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206843Inst Instance=new A206843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206844
{
public static readonly BigInteger[] Value={ 3636L,13220496L,31871929292L,79716622309437L,200394014933364651L,BigInteger.Parse("503617001775793994676"),BigInteger.Parse("1266270368466567536724535"),BigInteger.Parse("3183935032870732412305270412") };
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
public class A206844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206844Inst Instance=new A206844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206845
{
public static readonly BigInteger[] Value={ 14124L,199487376L,1709151563122L,15348900754966668L,BigInteger.Parse("138717281035824236746"),BigInteger.Parse("1253153235463965319380998") };
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
public class A206845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206845Inst Instance=new A206845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206846
{
public static readonly BigInteger[] Value={ 1L,2L,11L,776L,921193L,10359730908L,1620677532919905L,BigInteger.Parse("1969126979596399128130"),BigInteger.Parse("32593711828578589304123599877"),BigInteger.Parse("3931730912701446701027876250509820962"),BigInteger.Parse("6413805618092047206104426809813307222469463650"),BigInteger.Parse("74040826359052943559114050244071546075856822107307951070") };
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
public class A206846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206846Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206846.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206846Inst Instance=new A206846Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206847
{
public static readonly BigInteger[] Value={ 1L,2L,18L,2270L,3678482L,51789416252L,9723940840418814L,BigInteger.Parse("13783866167176942874214"),BigInteger.Parse("260749663122506218247699587346"),BigInteger.Parse("35385577627626083328957267246097557212"),BigInteger.Parse("64138056102285851525440919122006580387539950268"),BigInteger.Parse("814449089808478655249485968539593253265395820497817710866") };
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
public class A206847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206847Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206847.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206847Inst Instance=new A206847Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206848
{
public static readonly BigInteger[] Value={ 1L,2L,5L,53L,3422L,826606L,1335470713L,9548109569885L,190076214495558260L,BigInteger.Parse("18558289189760778318731"),BigInteger.Parse("10286810587274357297985552184"),BigInteger.Parse("16301371794177939084545371104827679"),BigInteger.Parse("91249944361047494534207504939405352235731"),BigInteger.Parse("3283593155431496336538359592977826684908598341441") };
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
public class A206848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206848Inst Instance=new A206848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206849
{
public static readonly BigInteger[] Value={ 1L,2L,6L,137L,13278L,4098627L,8002879629L,66818063663192L,1520456935214867934L,BigInteger.Parse("167021181249536494996841"),BigInteger.Parse("102867734705055054467692090431"),BigInteger.Parse("179314863425920182637610314008444247"),BigInteger.Parse("1094998941099523423274757578750950802034789") };
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
public class A206849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206849Inst Instance=new A206849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206850
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,8L,56L,522L,5972L,424954L,16560881L,1528544877L,483389731955L,70609119680761L,53933819677734187L,BigInteger.Parse("58734216507052608587"),BigInteger.Parse("38789122414735365076327"),BigInteger.Parse("202547156817505166242299130"),BigInteger.Parse("712808848212730366850407506134"),BigInteger.Parse("2914935606380176735260119042755221") };
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
public class A206850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206850Inst Instance=new A206850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206851
{
public static readonly BigInteger[] Value={ 1L,3L,7L,15L,231L,2763L,37773L,3347359L,145164760L,15115517783L,5300285945494L,841490209145991L,700215432847179640L,BigInteger.Parse("821522962294608211319"),BigInteger.Parse("580955012898669141073842"),BigInteger.Parse("3240132942509582109732641935"),BigInteger.Parse("12114306457535986210506222037102") };
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
public class A206851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206851Inst Instance=new A206851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206852
{
public static readonly BigInteger[] Value={ 30233088000000L,BigInteger.Parse("32462531054272512000000"),BigInteger.Parse("6224724715037147546112000000"),BigInteger.Parse("34856377305871210027941888000000"),BigInteger.Parse("28156757354736328125000000000000000"),BigInteger.Parse("6683747269421867033919422988288000000"),BigInteger.Parse("681433858470444619689081338982912000000") };
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
public class A206852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206852Inst Instance=new A206852Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206853
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,13L,14L,22L,26L,28L,31L,47L,55L,59L,61L,62L,94L,110L,118L,122L,124L,127L,191L,223L,239L,247L,251L,253L,254L,382L,446L,478L,494L,502L,506L,508L,511L,767L,895L,959L,991L,1007L,1015L,1019L,1021L,1022L,1534L,1790L,1918L,1982L,2014L,2030L,2038L,2042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A206853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206853Inst : IEnumerable<long>
{
public static readonly long[] Value=A206853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206853.Bytes);
public long this[int i]=>Value[i];

public static A206853Inst Instance=new A206853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206854
{
public static readonly BigInteger[] Value={ 2L,33263L,2775683761181L,52139749485151463L,BigInteger.Parse("31359251876786281892441299570699"),BigInteger.Parse("2385018819218440287149") };
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
public class A206854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206854Inst Instance=new A206854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206855
{
public static readonly BigInteger[] Value={ 0L,0L,2L,12L,96L,1000L,12960L,201684L,3670016L,76527504L,18000000000L,47158953820L,1362182012928L,43011849456888L,1474041721757696L,54493461914062500L,2161727821137838080L,BigInteger.Parse("91597537648314105376"),BigInteger.Parse("4128944057284204560384"),BigInteger.Parse("197293926880252878693804"),BigInteger.Parse("9961472000000000000000000") };
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
public class A206855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206855Inst Instance=new A206855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206856
{
public static readonly BigInteger[] Value={ 3L,81L,11092L,7598355L,31208037240L,729358354663001L,BigInteger.Parse("92792498733436652359") };
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
public class A206856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206856Inst Instance=new A206856Inst();

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