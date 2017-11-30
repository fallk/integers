using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190890
{
public static readonly long[] Value={ 3L,7L,16L,20L,24L,28L,33L,37L,41L,45L,54L,58L,62L,71L,75L,79L,88L,92L,96L,100L,105L,109L,113L,117L,126L,130L,134L,143L,147L,151L,160L,164L,168L,172L,177L,181L,185L,189L,194L,198L,202L,206L,215L,219L,223L,232L,236L,240L,244L,249L,253L,257L,261L,266L,270L,274L,278L,287L,291L,295L,304L,308L,312L,321L,325L,329L,333L,338L,342L,346L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190890Inst : IEnumerable<long>
{
public static readonly long[] Value=A190890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190890.Bytes);
public long this[int i]=>Value[i];

public static A190890Inst Instance=new A190890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190891
{
public static readonly long[] Value={ 4L,8L,12L,21L,25L,29L,38L,42L,46L,50L,55L,59L,63L,67L,72L,76L,80L,84L,93L,97L,101L,110L,114L,118L,122L,127L,131L,135L,139L,144L,148L,152L,156L,165L,169L,173L,182L,186L,190L,199L,203L,207L,211L,216L,220L,224L,228L,237L,241L,245L,254L,258L,262L,271L,275L,279L,283L,288L,292L,296L,300L,309L,313L,317L,326L,330L,334L,343L,347L,351L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190891Inst : IEnumerable<long>
{
public static readonly long[] Value=A190891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190891.Bytes);
public long this[int i]=>Value[i];

public static A190891Inst Instance=new A190891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190924
{
public static readonly BigInteger[] Value={ 1L,1146L,2001240L,4336589521L,10691055854826L,28712861760925166L,BigInteger.Parse("81958815992936732932"),BigInteger.Parse("244852995292964593983615"),BigInteger.Parse("757831532841526180711756422"),BigInteger.Parse("2412699575781124816170722396128") };
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
public class A190924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190924Inst Instance=new A190924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190925
{
public static readonly BigInteger[] Value={ 1L,292L,105876L,44288275L,20437852622L,10113495071580L,5269762016304712L,2856775055641524277L,BigInteger.Parse("1597895488904165852658"),BigInteger.Parse("916687622818117768899294"),BigInteger.Parse("537007089073991920696345332"),BigInteger.Parse("320160637492321800832759074249") };
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
public class A190925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190925Inst Instance=new A190925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190926
{
public static readonly BigInteger[] Value={ 1L,40L,1744L,79944L,3791001L,184877712L,9230302913L,470167308382L,24367956213267L,1282234744431834L,68376498305017644L,3689492332817242036L,BigInteger.Parse("201174991614802295504"),BigInteger.Parse("11072289690651114833968"),BigInteger.Parse("614516844070147078701721") };
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
public class A190926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190926Inst Instance=new A190926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190927
{
public static readonly BigInteger[] Value={ 1L,47844L,4420321081L,551248360550999L,BigInteger.Parse("81644850343968535401"),BigInteger.Parse("13519747358522016160671387"),BigInteger.Parse("2421032324142610480402567434373"),BigInteger.Parse("459408385876250801291447710561829082") };
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
public class A190927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190927Inst Instance=new A190927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190928
{
public static readonly BigInteger[] Value={ 1L,15422L,418539642L,14956351701700L,628262652845622327L,BigInteger.Parse("29351897757297625841299"),BigInteger.Parse("1478434177099995753393526682"),BigInteger.Parse("78758866558881824054985784506762"),BigInteger.Parse("4381475477876207136274219572894470265") };
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
public class A190928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190928Inst Instance=new A190928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190929
{
public static readonly BigInteger[] Value={ 1L,4317L,27361381L,216956034178L,1979495929398725L,BigInteger.Parse("19864953170991117438"),BigInteger.Parse("213525202167474545255168"),BigInteger.Parse("2417277939494344003029244944"),BigInteger.Parse("28496810287352430019813986577684"),BigInteger.Parse("347046513903606031118705549409373406") };
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
public class A190929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190929Inst Instance=new A190929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190930
{
public static readonly BigInteger[] Value={ 1L,876L,930776L,1121366420L,1480802920785L,2096040262602013L,3130500265589863279L,BigInteger.Parse("4877720372114515794195"),BigInteger.Parse("7863552772351099534263185"),BigInteger.Parse("13036319691799230161857187106"),BigInteger.Parse("22121167328810053450410257014723") };
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
public class A190930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190930Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190930.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190930Inst Instance=new A190930Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190931
{
public static readonly BigInteger[] Value={ 1L,80L,6976L,639552L,60656016L,5898286349L,585487585760L,59147199364720L,6067259409345901L,630842897289489196L,BigInteger.Parse("66388460469198215359"),BigInteger.Parse("7062901351795999772739"),BigInteger.Parse("758832478269321359233282") };
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
public class A190931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190931Inst Instance=new A190931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190932
{
public static readonly BigInteger[] Value={ 1L,721315L,1133879136649L,2536823683737613858L,BigInteger.Parse("6945222145021508480249929"),BigInteger.Parse("21671513613423101256198918372909"),BigInteger.Parse("74115215422015289392187745053216373265"),BigInteger.Parse("271259741131895052775392614041761701799270286") };
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
public class A190932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190932Inst Instance=new A190932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190933
{
public static readonly BigInteger[] Value={ 1L,237135L,113320421342L,75493034668888898L,BigInteger.Parse("61020892783461730439520"),BigInteger.Parse("55972697524167501761912203050"),BigInteger.Parse("56130843535667787404732305560914654"),BigInteger.Parse("60145268975482058312829825943102522201980") };
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
public class A190933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190933Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190933.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190933Inst Instance=new A190933Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190934
{
public static readonly BigInteger[] Value={ 1L,69862L,8448460856L,1368009041285362L,BigInteger.Parse("264254904464540309234"),BigInteger.Parse("57423352933863499038305899"),BigInteger.Parse("13572657844345224433713852762532"),BigInteger.Parse("3416706600719684324699523157615472238") };
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
public class A190934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190934Inst Instance=new A190934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190935
{
public static readonly BigInteger[] Value={ 1L,16924L,403365340L,11922480289932L,407090790228102102L,BigInteger.Parse("15381627927280923953894"),BigInteger.Parse("626076436927654841850687690"),BigInteger.Parse("26973009375096737119981280672009"),BigInteger.Parse("1215269783462969270931217890768937234") };
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
public class A190935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190935Inst Instance=new A190935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190936
{
public static readonly BigInteger[] Value={ 1L,2628L,8341096L,29584295480L,113973074548248L,468377213896673183L,BigInteger.Parse("2027292282593307983972"),BigInteger.Parse("9154283191553066456530508"),BigInteger.Parse("42808534280820262732168056032"),BigInteger.Parse("206132516276458610178941094332608") };
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
public class A190936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190936Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190936.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190936Inst Instance=new A190936Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190937
{
public static readonly BigInteger[] Value={ 1L,160L,27904L,5116416L,970496256L,188745163168L,37428317148293L,7542831976684720L,1541320654071476368L,BigInteger.Parse("318820105535954581717"),BigInteger.Parse("66668953406861928775959"),BigInteger.Parse("14078842985707487656207628") };
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
public class A190937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190937Inst Instance=new A190937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190938
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190938Inst : IEnumerable<long>
{
public static readonly long[] Value=A190938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190938.Bytes);
public long this[int i]=>Value[i];

public static A190938Inst Instance=new A190938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190939
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,17L,33L,51L,65L,85L,105L,129L,153L,165L,195L,255L,257L,513L,771L,1025L,1285L,1545L,2049L,2313L,2565L,3075L,3855L,4097L,4369L,4641L,5185L,6273L,8193L,8481L,8721L,9345L,10305L,12291L,13107L,15555L,16385L,16705L,17025L,17425L,18465L,20485L,21845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190939Inst : IEnumerable<long>
{
public static readonly long[] Value=A190939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190939.Bytes);
public long this[int i]=>Value[i];

public static A190939Inst Instance=new A190939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190956
{
public static readonly BigInteger[] Value={ 0L,1L,10L,106L,1120L,11836L,125080L,1321816L,13968640L,147617296L,1559984800L,16485551776L,174215426560L,1841067576256L,19455968321920L,205606088676736L,2172796696698880L,22961603499049216L,242652815170685440L,2564297772701149696L,BigInteger.Parse("27098894618035609600") };
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
public class A190956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190956Inst Instance=new A190956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190957
{
public static readonly BigInteger[] Value={ 0L,1L,10L,108L,1160L,12464L,133920L,1438912L,15460480L,166116096L,1784844800L,19177376768L,206052526080L,2213944274944L,23787862958080L,255590183780352L,2746204741468160L,29506768884924416L,317037326780989440L,3406427418889289728L,BigInteger.Parse("36600572803140812800") };
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
public class A190957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190957Inst Instance=new A190957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190958
{
public static readonly long[] Value={ 0L,1L,2L,-6L,-32L,-4L,312L,664L,-1792L,-10224L,-2528L,97184L,219648L,-532544L,-3261568L,-1197696L,30220288L,72417536L,-157367808L,-1038910976L,-504143872L,9380822016L,23803082752L,-46202054656L,-330434936832L,-198849327104L,2906650714112L,7801794699264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190958Inst : IEnumerable<long>
{
public static readonly long[] Value=A190958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190958.Bytes);
public long this[int i]=>Value[i];

public static A190958Inst Instance=new A190958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190959
{
public static readonly long[] Value={ 0L,1L,3L,4L,-3L,-29L,-72L,-71L,147L,796L,1653L,979L,-5328L,-20879L,-35997L,-3596L,169197L,525571L,730728L,-435671L,-4960653L,-12703604L,-13307547L,23595379L,137323872L,293994721L,195364803L,-883879196L,-3628461603L,-6465988829L,-1255658472L,28562968729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190959Inst : IEnumerable<long>
{
public static readonly long[] Value=A190959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190959.Bytes);
public long this[int i]=>Value[i];

public static A190959Inst Instance=new A190959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190960
{
public static readonly long[] Value={ 0L,1L,3L,3L,-9L,-45L,-81L,27L,567L,1539L,1215L,-5589L,-24057L,-38637L,28431L,317115L,780759L,439587L,-3365793L,-12734901L,-18009945L,22379571L,175198383L,391317723L,122762871L,-1979617725L,-6675430401L,-8148584853L,15606827847L,95711992659L,193495010895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190960Inst : IEnumerable<long>
{
public static readonly long[] Value=A190960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190960.Bytes);
public long this[int i]=>Value[i];

public static A190960Inst Instance=new A190960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190961
{
public static readonly long[] Value={ 0L,1L,3L,2L,-15L,-59L,-72L,197L,1095L,1906L,-1947L,-19183L,-43920L,2521L,315003L,927362L,577065L,-4760339L,-18320472L,-21639043L,63326175L,341451826L,581072253L,-646946023L,-6008343840L,-13496409359L,1569178803L,99182401922L,286562954145L,165412048981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190961Inst : IEnumerable<long>
{
public static readonly long[] Value=A190961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190961.Bytes);
public long this[int i]=>Value[i];

public static A190961Inst Instance=new A190961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190962
{
public static readonly long[] Value={ 0L,1L,3L,1L,-21L,-71L,-45L,433L,1659L,1513L,-8733L,-38303L,-45045L,171289L,874227L,1252369L,-3236709L,-19729079L,-33293565L,57951937L,440204331L,856997497L,-950642157L,-9707906447L,-21518582085L,13107505321L,211471172643L,529553475361L,-103108955061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190962Inst : IEnumerable<long>
{
public static readonly long[] Value=A190962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190962.Bytes);
public long this[int i]=>Value[i];

public static A190962Inst Instance=new A190962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190963
{
public static readonly long[] Value={ 0L,1L,3L,0L,-27L,-81L,0L,729L,2187L,0L,-19683L,-59049L,0L,531441L,1594323L,0L,-14348907L,-43046721L,0L,387420489L,1162261467L,0L,-10460353203L,-31381059609L,0L,282429536481L,847288609443L,0L,-7625597484987L,-22876792454961L,0L,205891132094649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190963Inst : IEnumerable<long>
{
public static readonly long[] Value=A190963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190963.Bytes);
public long this[int i]=>Value[i];

public static A190963Inst Instance=new A190963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190964
{
public static readonly long[] Value={ 0L,1L,3L,-1L,-33L,-89L,63L,1079L,2607L,-2969L,-34977L,-75241L,124047L,1124551L,2133183L,-4845961L,-35869713L,-59149529L,181248543L,1135240919L,1593237327L,-6572697209L,-35650464897L,-41224422601L,232831381167L,1110738369511L,1003901296863L,-8095679804521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190964Inst : IEnumerable<long>
{
public static readonly long[] Value=A190964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190964.Bytes);
public long this[int i]=>Value[i];

public static A190964Inst Instance=new A190964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190965
{
public static readonly long[] Value={ 0L,1L,4L,10L,16L,4L,-80L,-344L,-896L,-1520L,-704L,6304L,29440L,79936L,143104L,92800L,-487424L,-2506496L,-7101440L,-13366784L,-10858496L,36766720L,212217856L,628271104L,1239777280L,1189482496L,-2680733696L,-17859829760L,-55354916864L,-114260688896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190965Inst : IEnumerable<long>
{
public static readonly long[] Value=A190965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190965.Bytes);
public long this[int i]=>Value[i];

public static A190965Inst Instance=new A190965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190966
{
public static readonly long[] Value={ 0L,1L,4L,8L,0L,-64L,-256L,-512L,0L,4096L,16384L,32768L,0L,-262144L,-1048576L,-2097152L,0L,16777216L,67108864L,134217728L,0L,-1073741824L,-4294967296L,-8589934592L,0L,68719476736L,274877906944L,549755813888L,0L,-4398046511104L,-17592186044416L,-35184372088832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190966Inst : IEnumerable<long>
{
public static readonly long[] Value=A190966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190966.Bytes);
public long this[int i]=>Value[i];

public static A190966Inst Instance=new A190966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190967
{
public static readonly long[] Value={ 0L,1L,4L,7L,-8L,-95L,-308L,-377L,1264L,8449L,22420L,13639L,-147224L,-711647L,-1521572L,318535L,14968288L,57006337L,93310756L,-139814009L,-1399052840L,-4337885279L,-4760065556L,20000705287L,122843411152L,311367297025L,139878487732L,-2242791722297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190967Inst : IEnumerable<long>
{
public static readonly long[] Value=A190967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190967.Bytes);
public long this[int i]=>Value[i];

public static A190967Inst Instance=new A190967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190968
{
public static readonly long[] Value={ 0L,1L,4L,6L,-16L,-124L,-336L,-104L,2944L,12816L,21824L,-40864L,-381696L,-1118144L,-655616L,8558976L,40792064L,77578496L,-97606656L,-1166211584L,-3688779776L,-3093003264L,24515784704L,128993171456L,270814838784L,-206672359424L,-3534837825536L,-12072627707904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190968Inst : IEnumerable<long>
{
public static readonly long[] Value=A190968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190968.Bytes);
public long this[int i]=>Value[i];

public static A190968Inst Instance=new A190968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190969
{
public static readonly long[] Value={ 0L,1L,5L,17L,45L,89L,85L,-287L,-2115L,-8279L,-24475L,-56143L,-84915L,24569L,802165L,3814273L,12654045L,32756041L,62547845L,50690897L,-246928275L,-1640168551L,-6225416555L,-18005734367L,-40225339395L,-57080822039L,36398604965L,638639601137L,2902009165965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190969Inst : IEnumerable<long>
{
public static readonly long[] Value=A190969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190969.Bytes);
public long this[int i]=>Value[i];

public static A190969Inst Instance=new A190969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190970
{
public static readonly long[] Value={ 0L,1L,5L,16L,35L,31L,-160L,-1079L,-3955L,-10064L,-14725L,16951L,217280L,933841L,2713685L,5163856L,1396115L,-39494129L,-210035680L,-694731239L,-1583335075L,-1664094224L,5929544555L,44624570791L,169756952960L,447163627681L,708005561765L,-484444840304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190970Inst : IEnumerable<long>
{
public static readonly long[] Value=A190970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190970.Bytes);
public long this[int i]=>Value[i];

public static A190970Inst Instance=new A190970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190971
{
public static readonly long[] Value={ 0L,1L,5L,15L,25L,-25L,-375L,-1625L,-4375L,-5625L,15625L,134375L,515625L,1234375L,1015625L,-7265625L,-46484375L,-159765625L,-333984375L,-72265625L,2978515625L,15615234375L,48291015625L,85302734375L,-56396484375L,-1135009765625L,-5111083984375L,-14205322265625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190971Inst : IEnumerable<long>
{
public static readonly long[] Value=A190971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190971.Bytes);
public long this[int i]=>Value[i];

public static A190971Inst Instance=new A190971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191084
{
public static readonly long[] Value={ 5L,19L,23L,31L,37L,43L,53L,59L,61L,71L,73L,79L,83L,97L,107L,127L,149L,157L,163L,167L,173L,179L,193L,197L,211L,227L,229L,233L,239L,257L,271L,281L,307L,331L,337L,347L,353L,367L,379L,383L,401L,409L,419L,421L,431L,433L,509L,521L,541L,557L,577L,587L,593L,601L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191084Inst : IEnumerable<long>
{
public static readonly long[] Value=A191084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191084.Bytes);
public long this[int i]=>Value[i];

public static A191084Inst Instance=new A191084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191085
{
public static readonly long[] Value={ 2L,3L,11L,17L,37L,61L,67L,71L,101L,103L,109L,131L,137L,139L,149L,151L,157L,163L,173L,181L,193L,197L,199L,239L,251L,257L,269L,281L,283L,311L,313L,317L,331L,359L,367L,379L,401L,419L,421L,431L,433L,439L,449L,457L,463L,467L,487L,499L,503L,521L,523L,541L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191085Inst : IEnumerable<long>
{
public static readonly long[] Value=A191085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191085.Bytes);
public long this[int i]=>Value[i];

public static A191085Inst Instance=new A191085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191086
{
public static readonly long[] Value={ 3L,23L,31L,37L,41L,53L,59L,61L,73L,83L,101L,113L,127L,131L,137L,149L,151L,157L,167L,173L,193L,197L,199L,223L,233L,251L,257L,269L,277L,281L,283L,307L,311L,313L,331L,347L,359L,367L,379L,397L,409L,433L,449L,463L,491L,503L,523L,541L,569L,571L,577L,593L,599L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191086Inst : IEnumerable<long>
{
public static readonly long[] Value=A191086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191086.Bytes);
public long this[int i]=>Value[i];

public static A191086Inst Instance=new A191086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191087
{
public static readonly long[] Value={ 7L,17L,23L,29L,31L,41L,43L,47L,59L,71L,73L,79L,83L,89L,109L,137L,151L,157L,163L,179L,181L,197L,211L,233L,241L,263L,269L,277L,281L,283L,313L,331L,347L,353L,367L,379L,397L,401L,409L,421L,431L,439L,443L,449L,457L,463L,467L,503L,509L,521L,557L,569L,577L,587L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191087Inst : IEnumerable<long>
{
public static readonly long[] Value=A191087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191087.Bytes);
public long this[int i]=>Value[i];

public static A191087Inst Instance=new A191087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191088
{
public static readonly long[] Value={ 3L,5L,43L,43L,67L,67L,163L,163L,163L,163L,163L,163L,74093L,77683L,214037L,214037L,214037L,2004917L,36254563L,51599563L,96295483L,96295483L,114148483L,163520117L,163520117L,261153653L,261153653L,585811843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191088Inst : IEnumerable<long>
{
public static readonly long[] Value=A191088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191088.Bytes);
public long this[int i]=>Value[i];

public static A191088Inst Instance=new A191088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191089
{
public static readonly long[] Value={ 3L,5L,43L,43L,67L,67L,163L,163L,163L,163L,163L,163L,74093L,170957L,360293L,679733L,2004917L,2004917L,51599563L,51599563L,96295483L,96295483L,146161723L,1408126003L,1728061733L,1728061733L,1728061733L,1728061733L,1728061733L,1728061733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191089Inst : IEnumerable<long>
{
public static readonly long[] Value=A191089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191089.Bytes);
public long this[int i]=>Value[i];

public static A191089Inst Instance=new A191089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191090
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,2L,1L,1L,4L,2L,3L,1L,2L,2L,2L,1L,2L,5L,2L,3L,2L,2L,2L,2L,4L,2L,3L,2L,6L,2L,2L,2L,2L,4L,2L,3L,2L,3L,2L,2L,4L,7L,5L,2L,4L,2L,3L,2L,2L,4L,3L,3L,2L,5L,2L,3L,8L,4L,4L,3L,4L,2L,3L,2L,6L,4L,5L,5L,3L,4L,2L,3L,4L,9L,4L,3L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191090Inst : IEnumerable<long>
{
public static readonly long[] Value=A191090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191090.Bytes);
public long this[int i]=>Value[i];

public static A191090Inst Instance=new A191090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191091
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,4L,2L,1L,2L,3L,3L,2L,3L,4L,1L,3L,2L,3L,2L,4L,3L,4L,3L,1L,4L,3L,4L,2L,5L,4L,2L,3L,2L,5L,1L,4L,3L,6L,2L,2L,4L,3L,3L,2L,5L,4L,3L,1L,2L,5L,2L,2L,3L,6L,3L,3L,2L,3L,4L,2L,3L,4L,1L,2L,3L,3L,3L,3L,3L,4L,2L,4L,2L,3L,4L,3L,3L,4L,2L,1L,4L,3L,4L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191091Inst : IEnumerable<long>
{
public static readonly long[] Value=A191091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191091.Bytes);
public long this[int i]=>Value[i];

public static A191091Inst Instance=new A191091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191092
{
public static readonly BigInteger[] Value={ 0L,1L,61L,2836L,129288L,6160640L,313921008L,17239040000L,1021644763392L,65244849242112L,4477975127425280L,329252714454974464L,BigInteger.Parse("25850313756000000000"),BigInteger.Parse("2160223055912342913024"),BigInteger.Parse("191558954408834121740288"),BigInteger.Parse("17973564914103712921681920") };
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
public class A191092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191092Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191092.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191092Inst Instance=new A191092Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191093
{
public static readonly long[] Value={ 2L,1L,6L,1L,10L,1L,5L,1L,6L,3L,22L,3L,26L,1L,30L,0L,34L,2L,38L,5L,42L,3L,9L,3L,1L,7L,6L,7L,58L,1L,62L,1L,66L,3L,70L,3L,74L,5L,78L,5L,82L,11L,29L,11L,30L,3L,13L,1L,14L,3L,102L,1L,106L,1L,110L,7L,114L,15L,118L,15L,41L,1L,42L,1L,130L,17L,134L,17L,138L,3L,142L,3L,29L,19L,30L,19L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191093Inst : IEnumerable<long>
{
public static readonly long[] Value=A191093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191093.Bytes);
public long this[int i]=>Value[i];

public static A191093Inst Instance=new A191093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191094
{
public static readonly long[] Value={ 1L,4L,28L,228L,2018L,18892L,184400L,1857856L,19189675L,202214452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191094Inst : IEnumerable<long>
{
public static readonly long[] Value=A191094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191094.Bytes);
public long this[int i]=>Value[i];

public static A191094Inst Instance=new A191094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191095
{
public static readonly long[] Value={ 1L,5L,45L,485L,5775L,73437L,979335L,13536225L,192393410L,2796392165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191095Inst : IEnumerable<long>
{
public static readonly long[] Value=A191095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191095.Bytes);
public long this[int i]=>Value[i];

public static A191095Inst Instance=new A191095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191096
{
public static readonly long[] Value={ 1L,6L,66L,886L,13281L,213978L,3630090L,64012932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191096Inst : IEnumerable<long>
{
public static readonly long[] Value=A191096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191096.Bytes);
public long this[int i]=>Value[i];

public static A191096Inst Instance=new A191096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191097
{
public static readonly long[] Value={ 1L,7L,91L,1463L,26460L,516691L,10654378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191097Inst : IEnumerable<long>
{
public static readonly long[] Value=A191097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191097.Bytes);
public long this[int i]=>Value[i];

public static A191097Inst Instance=new A191097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191098
{
public static readonly long[] Value={ 1L,8L,120L,2248L,47636L,1088017L,26424957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191098Inst : IEnumerable<long>
{
public static readonly long[] Value=A191098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191098.Bytes);
public long this[int i]=>Value[i];

public static A191098Inst Instance=new A191098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191099
{
public static readonly long[] Value={ 11L,52L,255L,1335L,7432L,43833L,272947L,1788850L,12303997L,88586135L,666047210L,5218287687L,42518759887L,359651145332L,3152929344235L,28603584325827L,268159523175744L,2594608337127709L,25878365376280647L,265770087291261082L,2807571511844891521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191099Inst : IEnumerable<long>
{
public static readonly long[] Value=A191099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191099.Bytes);
public long this[int i]=>Value[i];

public static A191099Inst Instance=new A191099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191164
{
public static readonly long[] Value={ 4L,5L,6L,7L,11L,12L,13L,14L,18L,19L,20L,21L,25L,26L,27L,28L,32L,33L,34L,35L,39L,40L,41L,42L,46L,47L,48L,49L,53L,54L,55L,56L,61L,62L,63L,68L,69L,70L,75L,76L,77L,82L,83L,84L,89L,90L,91L,96L,97L,98L,103L,104L,105L,110L,111L,112L,113L,117L,118L,119L,120L,124L,125L,126L,127L,131L,132L,133L,134L,138L,139L,140L,141L,145L,146L,147L,148L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191164Inst : IEnumerable<long>
{
public static readonly long[] Value=A191164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191164.Bytes);
public long this[int i]=>Value[i];

public static A191164Inst Instance=new A191164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191165
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,13L,14L,17L,18L,22L,31L,40L,41L,49L,50L,53L,54L,65L,66L,70L,86L,112L,121L,122L,148L,149L,157L,158L,161L,162L,193L,194L,197L,198L,209L,210L,214L,257L,258L,262L,274L,278L,342L,355L,364L,365L,436L,445L,446L,472L,473L,481L,482L,485L,486L,580L,581L,589L,590L,593L,594L,625L,626L,629L,630L,641L,642L,646L,769L,770L,773L,774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191165Inst : IEnumerable<long>
{
public static readonly long[] Value=A191165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191165.Bytes);
public long this[int i]=>Value[i];

public static A191165Inst Instance=new A191165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191166
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,11L,14L,19L,20L,23L,27L,31L,32L,36L,41L,43L,55L,56L,59L,68L,75L,79L,80L,91L,92L,95L,100L,107L,122L,123L,127L,128L,163L,164L,167L,171L,176L,203L,219L,223L,224L,228L,235L,236L,239L,271L,272L,275L,284L,292L,299L,315L,319L,320L,363L,365L,367L,368L,379L,380L,383L,420L,427L,484L,487L,488L,491L,500L,507L,511L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191166Inst : IEnumerable<long>
{
public static readonly long[] Value=A191166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191166.Bytes);
public long this[int i]=>Value[i];

public static A191166Inst Instance=new A191166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191167
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,11L,14L,15L,19L,20L,23L,24L,27L,31L,32L,41L,42L,43L,51L,55L,56L,59L,60L,68L,69L,75L,79L,80L,91L,92L,95L,96L,107L,122L,123L,127L,128L,132L,163L,164L,167L,168L,171L,176L,177L,203L,204L,213L,219L,223L,224L,235L,236L,239L,240L,271L,272L,275L,276L,284L,285L,299L,315L,319L,320L,363L,365L,366L,367L,368L,375L,379L,380L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191167Inst : IEnumerable<long>
{
public static readonly long[] Value=A191167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191167.Bytes);
public long this[int i]=>Value[i];

public static A191167Inst Instance=new A191167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191168
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,11L,14L,15L,16L,19L,20L,23L,27L,31L,32L,41L,43L,44L,47L,55L,56L,59L,63L,64L,68L,75L,79L,80L,91L,92L,95L,107L,122L,123L,127L,128L,131L,140L,163L,164L,167L,171L,175L,176L,187L,188L,191L,203L,219L,223L,224L,235L,236L,239L,251L,255L,256L,271L,272L,275L,284L,299L,315L,319L,320L,363L,365L,367L,368L,379L,380L,383L,392L,419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191168Inst : IEnumerable<long>
{
public static readonly long[] Value=A191168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191168.Bytes);
public long this[int i]=>Value[i];

public static A191168Inst Instance=new A191168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191169
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,11L,14L,16L,17L,20L,23L,32L,35L,41L,44L,47L,56L,59L,64L,68L,71L,80L,92L,95L,98L,122L,125L,128L,131L,140L,143L,152L,164L,167L,176L,179L,188L,191L,203L,206L,224L,236L,239L,256L,272L,275L,284L,287L,314L,320L,365L,368L,380L,383L,392L,395L,419L,422L,488L,491L,500L,503L,512L,524L,527L,530L,560L,563L,572L,575L,608L,611L,638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191169Inst : IEnumerable<long>
{
public static readonly long[] Value=A191169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191169.Bytes);
public long this[int i]=>Value[i];

public static A191169Inst Instance=new A191169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191170
{
public static readonly long[] Value={ 1L,2L,5L,9L,14L,21L,26L,37L,41L,50L,57L,62L,77L,85L,105L,110L,114L,122L,149L,165L,170L,185L,229L,230L,249L,254L,306L,309L,314L,329L,341L,365L,421L,441L,446L,489L,494L,509L,554L,562L,597L,661L,681L,686L,689L,741L,746L,761L,882L,917L,921L,926L,941L,986L,997L,1017L,1022L,1094L,1237L,1257L,1262L,1317L,1322L,1330L,1337L,1365L,1461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191170Inst : IEnumerable<long>
{
public static readonly long[] Value=A191170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191170.Bytes);
public long this[int i]=>Value[i];

public static A191170Inst Instance=new A191170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191171
{
public static readonly long[] Value={ 1L,2L,5L,9L,10L,14L,19L,21L,26L,37L,41L,46L,57L,62L,77L,82L,85L,91L,105L,110L,122L,127L,149L,165L,170L,172L,185L,190L,229L,230L,235L,249L,254L,309L,314L,329L,334L,341L,365L,370L,415L,421L,441L,446L,489L,494L,509L,514L,554L,559L,597L,661L,681L,686L,689L,694L,739L,741L,746L,761L,766L,820L,917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191171Inst : IEnumerable<long>
{
public static readonly long[] Value=A191171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191171.Bytes);
public long this[int i]=>Value[i];

public static A191171Inst Instance=new A191171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191172
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,10L,14L,17L,22L,26L,29L,41L,42L,50L,57L,58L,65L,70L,77L,86L,90L,106L,118L,121L,122L,125L,149L,166L,170L,173L,194L,202L,209L,230L,234L,257L,262L,269L,282L,310L,313L,317L,346L,353L,362L,365L,374L,377L,426L,446L,474L,490L,497L,502L,509L,518L,569L,581L,598L,605L,626L,633L,666L,682L,689L,694L,701L,770L,778L,785L,806L,810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191172Inst : IEnumerable<long>
{
public static readonly long[] Value=A191172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191172.Bytes);
public long this[int i]=>Value[i];

public static A191172Inst Instance=new A191172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191173
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,10L,12L,14L,17L,21L,22L,26L,29L,30L,41L,42L,48L,50L,57L,58L,65L,70L,77L,86L,90L,93L,106L,111L,118L,122L,125L,129L,149L,156L,166L,170L,173L,192L,194L,201L,202L,209L,230L,234L,237L,257L,262L,264L,269L,273L,282L,310L,317L,346L,353L,362L,365L,372L,374L,381L,426L,435L,446L,453L,474L,490L,497L,502L,509L,516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191173Inst : IEnumerable<long>
{
public static readonly long[] Value=A191173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191173.Bytes);
public long this[int i]=>Value[i];

public static A191173Inst Instance=new A191173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191174
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,14L,16L,20L,23L,28L,31L,32L,41L,44L,47L,56L,59L,64L,68L,80L,83L,92L,95L,112L,122L,124L,127L,128L,131L,140L,164L,167L,176L,188L,191L,203L,224L,236L,239L,248L,256L,272L,275L,284L,320L,332L,335L,365L,368L,371L,380L,383L,392L,419L,448L,488L,491L,496L,500L,508L,511L,512L,524L,527L,560L,563L,572L,608L,656L,668L,671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191174Inst : IEnumerable<long>
{
public static readonly long[] Value=A191174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191174.Bytes);
public long this[int i]=>Value[i];

public static A191174Inst Instance=new A191174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191175
{
public static readonly long[] Value={ 1L,2L,5L,7L,11L,14L,20L,23L,31L,32L,41L,47L,50L,59L,68L,83L,92L,95L,104L,122L,127L,131L,140L,167L,176L,185L,191L,203L,212L,239L,248L,275L,284L,293L,335L,365L,371L,374L,380L,383L,392L,419L,428L,455L,491L,500L,511L,527L,536L,563L,572L,608L,617L,671L,707L,716L,743L,752L,767L,815L,824L,833L,851L,860L,941L,959L,995L,1004L,1094L,1103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191175Inst : IEnumerable<long>
{
public static readonly long[] Value=A191175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191175.Bytes);
public long this[int i]=>Value[i];

public static A191175Inst Instance=new A191175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191176
{
public static readonly long[] Value={ 2L,4L,6L,7L,9L,11L,13L,14L,16L,18L,21L,23L,25L,28L,30L,32L,35L,37L,39L,40L,42L,44L,46L,47L,49L,51L,53L,54L,56L,58L,61L,63L,65L,68L,70L,72L,75L,77L,79L,80L,82L,84L,86L,87L,89L,91L,93L,94L,96L,98L,101L,103L,105L,108L,110L,112L,113L,115L,117L,119L,120L,122L,124L,126L,127L,129L,131L,134L,136L,138L,141L,143L,145L,148L,150L,152L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191176Inst : IEnumerable<long>
{
public static readonly long[] Value=A191176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191176.Bytes);
public long this[int i]=>Value[i];

public static A191176Inst Instance=new A191176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191177
{
public static readonly long[] Value={ 1L,3L,9L,21L,27L,33L,75L,81L,99L,105L,129L,183L,237L,243L,291L,297L,315L,321L,387L,393L,417L,513L,669L,723L,729L,885L,891L,939L,945L,963L,969L,1155L,1161L,1179L,1185L,1251L,1257L,1281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191177Inst : IEnumerable<long>
{
public static readonly long[] Value=A191177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191177.Bytes);
public long this[int i]=>Value[i];

public static A191177Inst Instance=new A191177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191178
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,10L,18L,22L,27L,30L,34L,38L,50L,54L,66L,70L,81L,86L,90L,102L,106L,114L,118L,134L,150L,162L,178L,198L,210L,214L,243L,258L,262L,270L,278L,306L,318L,322L,342L,354L,358L,370L,402L,406L,422L,450L,454L,470L,486L,534L,562L,594L,598L,626L,630L,642L,646L,729L,774L,786L,790L,810L,834L,838L,854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191178Inst : IEnumerable<long>
{
public static readonly long[] Value=A191178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191178.Bytes);
public long this[int i]=>Value[i];

public static A191178Inst Instance=new A191178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191179
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,10L,14L,17L,18L,22L,23L,26L,27L,29L,30L,34L,38L,41L,50L,53L,54L,65L,66L,68L,70L,77L,80L,81L,86L,89L,90L,101L,102L,106L,113L,114L,118L,122L,134L,149L,150L,158L,161L,162L,194L,197L,198L,203L,209L,210L,214L,230L,239L,242L,243L,257L,258L,262L,266L,269L,270L,278L,302L,305L,306L,317L,318L,322L,338L,341L,342L,353L,354L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191179Inst : IEnumerable<long>
{
public static readonly long[] Value=A191179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191179.Bytes);
public long this[int i]=>Value[i];

public static A191179Inst Instance=new A191179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191212
{
public static readonly long[] Value={ 1L,5L,6L,8L,17L,20L,22L,26L,53L,62L,68L,70L,80L,82L,90L,106L,120L,161L,188L,206L,212L,214L,242L,248L,250L,272L,274L,282L,320L,322L,330L,362L,376L,426L,440L,485L,566L,568L,620L,638L,644L,646L,728L,746L,752L,754L,818L,824L,826L,848L,850L,858L,962L,968L,970L,992L,994L,1002L,1088L,1090L,1098L,1130L,1144L,1280L,1282L,1290L,1322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191212Inst : IEnumerable<long>
{
public static readonly long[] Value=A191212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191212.Bytes);
public long this[int i]=>Value[i];

public static A191212Inst Instance=new A191212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191213
{
public static readonly long[] Value={ 1L,5L,6L,15L,17L,20L,22L,26L,51L,53L,60L,62L,68L,70L,80L,82L,90L,106L,141L,159L,161L,186L,188L,204L,206L,212L,214L,240L,242L,248L,250L,272L,274L,282L,320L,322L,330L,362L,426L,465L,483L,485L,546L,564L,566L,618L,620L,636L,638L,644L,646L,726L,728L,744L,746L,752L,754L,816L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191213Inst : IEnumerable<long>
{
public static readonly long[] Value=A191213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191213.Bytes);
public long this[int i]=>Value[i];

public static A191213Inst Instance=new A191213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191214
{
public static readonly long[] Value={ 1L,4L,5L,8L,11L,12L,15L,18L,19L,22L,25L,26L,29L,30L,32L,33L,36L,37L,39L,40L,43L,44L,46L,47L,50L,51L,53L,54L,57L,58L,61L,64L,65L,68L,71L,72L,75L,78L,79L,82L,85L,86L,89L,90L,92L,93L,96L,97L,99L,100L,103L,104L,106L,107L,110L,111L,114L,117L,118L,121L,124L,125L,128L,131L,132L,135L,138L,139L,142L,143L,145L,146L,149L,150L,152L,153L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191214Inst : IEnumerable<long>
{
public static readonly long[] Value=A191214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191214.Bytes);
public long this[int i]=>Value[i];

public static A191214Inst Instance=new A191214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191215
{
public static readonly long[] Value={ 2L,3L,6L,7L,9L,10L,13L,14L,16L,17L,20L,21L,23L,24L,27L,28L,31L,34L,35L,38L,41L,42L,45L,48L,49L,52L,55L,56L,59L,60L,62L,63L,66L,67L,69L,70L,73L,74L,76L,77L,80L,81L,83L,84L,87L,88L,91L,94L,95L,98L,101L,102L,105L,108L,109L,112L,113L,115L,116L,119L,120L,122L,123L,126L,127L,129L,130L,133L,134L,136L,137L,140L,141L,144L,147L,148L,151L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191215Inst : IEnumerable<long>
{
public static readonly long[] Value=A191215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191215.Bytes);
public long this[int i]=>Value[i];

public static A191215Inst Instance=new A191215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191216
{
public static readonly long[] Value={ 361L,230456L,1005768L,3462570L,11006128L,25925028L,61456764L,127697940L,249379116L,448408452L,740850012L,1263239320L,1914568816L,2884222410L,4371191782L,6287341056L,8758591370L,11640682466L,15938770638L,21721208748L,29153150298L,38784336168L,49888704100L,62506263054L,76188213990L,95511276660L,118760260290L,150724895476L,187405610004L,243040520764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191216Inst : IEnumerable<long>
{
public static readonly long[] Value=A191216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191216.Bytes);
public long this[int i]=>Value[i];

public static A191216Inst Instance=new A191216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191217
{
public static readonly long[] Value={ 5L,10L,13L,17L,20L,26L,29L,34L,37L,40L,41L,45L,52L,53L,58L,61L,68L,73L,74L,80L,82L,89L,90L,97L,101L,104L,106L,109L,113L,116L,117L,122L,136L,137L,146L,148L,149L,153L,157L,160L,164L,173L,178L,180L,181L,193L,194L,197L,202L,208L,212L,218L,226L,229L,232L,233L,234L,241L,244L,245L,257L,261L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191217Inst : IEnumerable<long>
{
public static readonly long[] Value=A191217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191217.Bytes);
public long this[int i]=>Value[i];

public static A191217Inst Instance=new A191217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191218
{
public static readonly long[] Value={ 5L,13L,17L,29L,37L,41L,45L,53L,61L,73L,89L,97L,101L,109L,113L,117L,137L,149L,153L,157L,173L,181L,193L,197L,229L,233L,241L,245L,257L,261L,269L,277L,281L,293L,313L,317L,325L,333L,337L,349L,353L,369L,373L,389L,397L,401L,405L,409L,421L,425L,433L,449L,457L,461L,477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191218Inst : IEnumerable<long>
{
public static readonly long[] Value=A191218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191218.Bytes);
public long this[int i]=>Value[i];

public static A191218Inst Instance=new A191218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191219
{
public static readonly long[] Value={ 5L,9L,13L,41L,49L,61L,113L,121L,169L,181L,225L,289L,313L,421L,441L,613L,625L,761L,925L,1013L,1201L,1301L,1521L,1681L,1741L,1849L,1861L,2025L,2113L,2381L,2401L,2521L,3121L,3481L,3613L,3969L,4325L,4513L,4761L,4901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191219Inst : IEnumerable<long>
{
public static readonly long[] Value=A191219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191219.Bytes);
public long this[int i]=>Value[i];

public static A191219Inst Instance=new A191219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191220
{
public static readonly long[] Value={ 6L,5L,6L,1L,7L,6L,3L,4L,3L,5L,5L,8L,6L,8L,3L,5L,3L,5L,9L,9L,1L,7L,8L,0L,0L,1L,5L,7L,8L,1L,5L,2L,3L,0L,3L,9L,0L,8L,9L,0L,4L,7L,9L,0L,4L,2L,8L,0L,0L,6L,8L,6L,5L,5L,1L,3L,1L,9L,2L,4L,4L,8L,6L,0L,3L,0L,5L,5L,2L,9L,1L,4L,0L,1L,5L,3L,7L,5L,7L,7L,9L,4L,3L,5L,3L,3L,0L,0L,6L,9L,0L,8L,9L,9L,6L,9L,7L,1L,5L,6L,4L,8L,3L,3L,9L,5L,9L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191220Inst : IEnumerable<long>
{
public static readonly long[] Value=A191220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191220.Bytes);
public long this[int i]=>Value[i];

public static A191220Inst Instance=new A191220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191221
{
public static readonly long[] Value={ 1L,10L,11L,19L,35L,37L,53L,59L,73L,91L,95L,100L,101L,143L,181L,218L,232L,250L,272L,296L,298L,323L,341L,343L,365L,383L,385L,418L,436L,454L,490L,509L,527L,547L,563L,583L,610L,634L,650L,656L,670L,692L,725L,727L,745L,749L,767L,787L,812L,814L,838L,850L,892L,905L,947L,949L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191221Inst : IEnumerable<long>
{
public static readonly long[] Value=A191221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191221.Bytes);
public long this[int i]=>Value[i];

public static A191221Inst Instance=new A191221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191222
{
public static readonly BigInteger[] Value={ 1L,3L,5L,17L,107L,598L,5688L,77906L,1352347L,34249359L,1204670396L,58155968015L,3946610726739L,371524667930965L,48587161215494423L,8859996760746649440L,BigInteger.Parse("2245679398171585663077"),BigInteger.Parse("791847513412090215745935") };
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
public class A191222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191222Inst Instance=new A191222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191223
{
public static readonly BigInteger[] Value={ 1L,3L,6L,16L,88L,534L,4001L,49783L,802282L,16846980L,518093110L,21604679482L,1210757513851L,95028176738441L,10229389014494032L,1500221649654979714L,BigInteger.Parse("303756994018728446946"),BigInteger.Parse("84493641616490831589232") };
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
public class A191223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191223Inst Instance=new A191223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191224
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,29L,74L,267L,1270L,6853L,46338L,452697L,5888876L,103743236L,2568916974L,83100685126L,3548166614885L,196909507948313L,14058252177537760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191224Inst : IEnumerable<long>
{
public static readonly long[] Value=A191224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191224.Bytes);
public long this[int i]=>Value[i];

public static A191224Inst Instance=new A191224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191225
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,0L,2L,1L,1L,2L,1L,2L,0L,2L,3L,2L,1L,2L,2L,2L,1L,4L,2L,2L,1L,0L,4L,3L,5L,1L,3L,2L,1L,5L,1L,2L,3L,4L,4L,4L,2L,2L,2L,4L,2L,3L,4L,3L,5L,4L,3L,2L,5L,4L,2L,5L,1L,6L,1L,5L,5L,7L,2L,2L,1L,10L,6L,6L,2L,2L,5L,0L,3L,7L,5L,4L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191225Inst : IEnumerable<long>
{
public static readonly long[] Value=A191225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191225.Bytes);
public long this[int i]=>Value[i];

public static A191225Inst Instance=new A191225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191226
{
public static readonly long[] Value={ 1L,2L,12L,22L,29L,36L,65L,69L,117L,118L,73L,100L,108L,154L,161L,200L,254L,172L,274L,239L,340L,321L,334L,330L,345L,471L,378L,481L,357L,526L,522L,515L,610L,635L,612L,655L,648L,792L,809L,731L,797L,594L,806L,851L,988L,886L,963L,933L,1005L,1111L,927L,1124L,970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191226Inst : IEnumerable<long>
{
public static readonly long[] Value=A191226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191226.Bytes);
public long this[int i]=>Value[i];

public static A191226Inst Instance=new A191226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191227
{
public static readonly long[] Value={ 79L,194L,153L,284L,420L,333L,454L,592L,504L,412L,652L,512L,486L,617L,613L,660L,1130L,753L,1002L,849L,1060L,957L,1034L,1037L,1198L,961L,969L,1056L,1368L,1400L,1264L,1314L,1301L,1683L,1510L,1571L,1532L,1625L,1771L,1810L,1745L,1907L,1961L,1877L,1851L,2104L,2097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191227Inst : IEnumerable<long>
{
public static readonly long[] Value=A191227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191227.Bytes);
public long this[int i]=>Value[i];

public static A191227Inst Instance=new A191227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191276
{
public static readonly long[] Value={ 0L,1L,4L,5L,7L,8L,11L,12L,13L,16L,17L,19L,20L,23L,24L,25L,28L,29L,31L,32L,35L,36L,37L,40L,41L,43L,44L,47L,48L,49L,52L,53L,55L,56L,59L,60L,61L,64L,65L,67L,68L,71L,72L,73L,76L,77L,79L,80L,83L,84L,85L,88L,89L,91L,92L,95L,96L,97L,100L,101L,103L,104L,107L,108L,109L,112L,113L,115L,116L,119L,120L,121L,124L,125L,127L,128L,131L,132L,133L,136L,137L,139L,140L,143L,144L,145L,148L,149L,151L,152L,155L,156L,157L,160L,161L,163L,164L,167L,168L,169L,172L,173L,175L,176L,179L,180L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191276Inst : IEnumerable<long>
{
public static readonly long[] Value=A191276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191276.Bytes);
public long this[int i]=>Value[i];

public static A191276Inst Instance=new A191276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191277
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,56L,376L,3152L,30640L,338816L,4226176L,58564352L,892337920L,14834994176L,267186021376L,5182147684352L,107689460377600L,2387077442011136L,56219583797886976L,1401949974947889152L,BigInteger.Parse("36902741817196871680"),BigInteger.Parse("1022494706646806429696") };
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
public class A191277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191277Inst Instance=new A191277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191278
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,6L,1L,3L,3L,1L,1L,6L,1L,6L,3L,3L,1L,10L,1L,3L,1L,6L,1L,16L,1L,1L,3L,3L,3L,20L,1L,3L,3L,10L,1L,16L,1L,6L,6L,3L,1L,15L,1L,6L,3L,6L,1L,10L,3L,10L,3L,3L,1L,50L,1L,3L,6L,1L,3L,16L,1L,6L,3L,16L,1L,50L,1L,3L,6L,6L,3L,16L,1L,15L,1L,3L,1L,50L,3L,3L,3L,10L,1L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191278Inst : IEnumerable<long>
{
public static readonly long[] Value=A191278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191278.Bytes);
public long this[int i]=>Value[i];

public static A191278Inst Instance=new A191278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191279
{
public static readonly long[] Value={ 22L,51L,87L,91L,102L,121L,145L,169L,187L,190L,212L,220L,225L,245L,247L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191279Inst : IEnumerable<long>
{
public static readonly long[] Value=A191279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191279.Bytes);
public long this[int i]=>Value[i];

public static A191279Inst Instance=new A191279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191280
{
public static readonly long[] Value={ 1L,1L,2L,6L,18L,60L,210L,754L,2766L,10280L,38568L,145770L,554162L,2116568L,8115660L,31220672L,120442860L,465775226L,1805074882L,7008550224L,27257398714L,106166467074L,414068416752L,1616899329454L,6320798698322L,24734167234028L,96877398455260L,379765373701964L,1489867265555382L,5849164981941642L,22979031257945948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191280Inst : IEnumerable<long>
{
public static readonly long[] Value=A191280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191280.Bytes);
public long this[int i]=>Value[i];

public static A191280Inst Instance=new A191280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191281
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,13L,14L,16L,24L,26L,28L,31L,32L,43L,48L,52L,56L,57L,62L,64L,86L,96L,104L,112L,114L,124L,128L,133L,157L,172L,183L,192L,208L,224L,228L,241L,248L,256L,266L,314L,344L,366L,384L,416L,448L,456L,482L,496L,512L,532L,553L,628L,651L,688L,732L,757L,768L,832L,896L,912L,931L,964L,992L,993L,1024L,1064L,1106L,1256L,1302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191281Inst : IEnumerable<long>
{
public static readonly long[] Value=A191281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191281.Bytes);
public long this[int i]=>Value[i];

public static A191281Inst Instance=new A191281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191282
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,13L,14L,16L,21L,24L,26L,28L,32L,42L,43L,48L,52L,56L,57L,64L,73L,84L,86L,96L,104L,112L,114L,128L,146L,157L,168L,172L,183L,192L,208L,211L,224L,228L,256L,273L,292L,314L,336L,344L,366L,384L,416L,422L,448L,456L,463L,512L,546L,584L,601L,628L,672L,688L,703L,732L,768L,813L,832L,844L,896L,912L,926L,1024L,1057L,1092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191282Inst : IEnumerable<long>
{
public static readonly long[] Value=A191282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191282.Bytes);
public long this[int i]=>Value[i];

public static A191282Inst Instance=new A191282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191283
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,16L,20L,21L,24L,32L,36L,40L,42L,48L,55L,64L,72L,78L,80L,84L,96L,110L,128L,136L,144L,156L,160L,168L,192L,210L,220L,231L,256L,272L,288L,300L,312L,320L,336L,384L,420L,440L,462L,512L,528L,544L,576L,600L,624L,640L,666L,672L,768L,820L,840L,880L,903L,924L,1024L,1056L,1088L,1152L,1176L,1200L,1248L,1280L,1332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191283Inst : IEnumerable<long>
{
public static readonly long[] Value=A191283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191283.Bytes);
public long this[int i]=>Value[i];

public static A191283Inst Instance=new A191283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191284
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,13L,16L,18L,19L,24L,26L,27L,28L,32L,36L,38L,39L,40L,42L,48L,52L,54L,56L,57L,58L,60L,63L,64L,72L,76L,78L,80L,81L,84L,85L,87L,90L,94L,96L,104L,108L,112L,114L,116L,117L,120L,121L,126L,127L,128L,130L,135L,141L,144L,152L,156L,160L,162L,168L,170L,171L,174L,175L,180L,181L,188L,189L,190L,192L,195L,202L,208L,211L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191284Inst : IEnumerable<long>
{
public static readonly long[] Value=A191284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191284.Bytes);
public long this[int i]=>Value[i];

public static A191284Inst Instance=new A191284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191285
{
public static readonly long[] Value={ 0L,1L,3L,4L,8L,9L,12L,24L,27L,32L,36L,40L,72L,81L,96L,108L,120L,216L,243L,288L,324L,360L,364L,512L,648L,729L,800L,864L,972L,1080L,1092L,1536L,1944L,2187L,2400L,2592L,2916L,3240L,3276L,3280L,4608L,5832L,6561L,7200L,7776L,8748L,9720L,9828L,9840L,13824L,17496L,19683L,21600L,23328L,26244L,29160L,29484L,29520L,29524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191285Inst : IEnumerable<long>
{
public static readonly long[] Value=A191285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191285.Bytes);
public long this[int i]=>Value[i];

public static A191285Inst Instance=new A191285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191286
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,15L,18L,26L,27L,30L,37L,45L,54L,78L,81L,82L,90L,101L,111L,135L,162L,226L,234L,243L,246L,270L,303L,325L,333L,405L,486L,677L,678L,702L,729L,730L,738L,810L,901L,909L,975L,999L,1215L,1370L,1458L,2026L,2031L,2034L,2106L,2187L,2190L,2214L,2430L,2703L,2727L,2917L,2925L,2997L,3645L,4110L,4374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191286Inst : IEnumerable<long>
{
public static readonly long[] Value=A191286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191286.Bytes);
public long this[int i]=>Value[i];

public static A191286Inst Instance=new A191286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191287
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,12L,13L,18L,19L,27L,28L,36L,39L,40L,42L,54L,57L,58L,60L,63L,81L,84L,85L,87L,90L,94L,108L,117L,120L,121L,126L,127L,130L,135L,141L,162L,171L,174L,175L,180L,181L,189L,190L,195L,202L,211L,243L,252L,255L,256L,261L,262L,270L,271L,282L,283L,285L,292L,303L,316L,324L,351L,360L,363L,364L,378L,381L,382L,384L,390L,391L,393L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191287Inst : IEnumerable<long>
{
public static readonly long[] Value=A191287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191287.Bytes);
public long this[int i]=>Value[i];

public static A191287Inst Instance=new A191287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191288
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,10L,16L,20L,21L,32L,33L,40L,42L,64L,66L,80L,84L,85L,128L,132L,133L,147L,160L,168L,170L,256L,264L,266L,294L,320L,336L,340L,341L,363L,512L,528L,532L,533L,588L,640L,672L,680L,682L,726L,1024L,1056L,1064L,1066L,1176L,1280L,1344L,1360L,1364L,1365L,1452L,2048L,2112L,2128L,2132L,2133L,2352L,2408L,2560L,2688L,2720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191288Inst : IEnumerable<long>
{
public static readonly long[] Value=A191288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191288.Bytes);
public long this[int i]=>Value[i];

public static A191288Inst Instance=new A191288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191289
{
public static readonly long[] Value={ 1L,2L,4L,5L,11L,14L,16L,25L,32L,41L,47L,74L,95L,121L,122L,140L,196L,221L,256L,284L,362L,365L,419L,587L,625L,662L,767L,851L,1024L,1085L,1094L,1256L,1681L,1760L,1874L,1985L,2209L,2300L,2552L,3071L,3254L,3281L,3767L,5042L,5279L,5476L,5621L,5954L,6626L,6899L,7655L,9025L,9212L,9761L,9842L,11300L,14641L,14884L,15125L,15836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191289Inst : IEnumerable<long>
{
public static readonly long[] Value=A191289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191289.Bytes);
public long this[int i]=>Value[i];

public static A191289Inst Instance=new A191289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191290
{
public static readonly long[] Value={ 1L,3L,6L,7L,13L,15L,21L,27L,28L,31L,43L,55L,57L,63L,87L,91L,111L,115L,120L,127L,175L,183L,223L,231L,241L,255L,351L,367L,378L,406L,447L,463L,483L,496L,511L,703L,735L,757L,813L,895L,927L,946L,967L,993L,1023L,1407L,1471L,1515L,1540L,1627L,1653L,1791L,1855L,1893L,1935L,1987L,2016L,2047L,2815L,2943L,3031L,3081L,3255L,3307L,3583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191290Inst : IEnumerable<long>
{
public static readonly long[] Value=A191290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191290.Bytes);
public long this[int i]=>Value[i];

public static A191290Inst Instance=new A191290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191291
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191291Inst : IEnumerable<long>
{
public static readonly long[] Value=A191291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191291.Bytes);
public long this[int i]=>Value[i];

public static A191291Inst Instance=new A191291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191324
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,13L,14L,17L,20L,22L,23L,26L,31L,34L,35L,40L,41L,44L,47L,52L,53L,61L,62L,67L,68L,71L,79L,80L,92L,94L,95L,101L,103L,104L,107L,119L,121L,122L,125L,134L,139L,142L,143L,152L,155L,157L,158L,161L,179L,182L,184L,185L,188L,202L,203L,206L,209L,214L,215L,229L,233L,236L,238L,239L,242L,269L,274L,277L,278L,283L,284L,287L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191324Inst : IEnumerable<long>
{
public static readonly long[] Value=A191324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191324.Bytes);
public long this[int i]=>Value[i];

public static A191324Inst Instance=new A191324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191325
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,15L,17L,18L,19L,22L,25L,27L,28L,30L,32L,33L,37L,40L,42L,45L,47L,48L,49L,55L,60L,62L,63L,67L,70L,72L,73L,75L,80L,82L,90L,92L,93L,94L,100L,105L,108L,109L,112L,117L,120L,122L,123L,135L,137L,138L,139L,141L,150L,155L,157L,162L,163L,167L,168L,175L,180L,182L,183L,184L,187L,200L,202L,205L,207L,208L,211L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191325Inst : IEnumerable<long>
{
public static readonly long[] Value=A191325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191325.Bytes);
public long this[int i]=>Value[i];

public static A191325Inst Instance=new A191325Inst();

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