using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A227657
{
public static readonly BigInteger[] Value={ 1L,1L,8L,320L,33904L,7453320L,2940381648L,1891074940160L,1850957806329280L,2618225365541294080L,BigInteger.Parse("5140671157605632743040"),BigInteger.Parse("13563806648374752374753280"),BigInteger.Parse("46834662679585827124435729920"),BigInteger.Parse("206992078337280281738792256468480"),BigInteger.Parse("1149167357682367147108624229192064000") };
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
public class A227657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227657Inst Instance=new A227657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227658
{
public static readonly BigInteger[] Value={ 1L,1L,16L,2328L,1281696L,1897242448L,6173789662504L,38746316631586896L,BigInteger.Parse("427196257460311066608"),BigInteger.Parse("7716228754248308194763776"),BigInteger.Parse("216245142312150285990621189096"),BigInteger.Parse("9001993707519997876764394044746416"),BigInteger.Parse("537141544856485105833302134461795535280") };
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
public class A227658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227658Inst Instance=new A227658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227659
{
public static readonly BigInteger[] Value={ 1L,1L,32L,16936L,48447504L,482913033152L,12981179566917088L,BigInteger.Parse("796655971557156062816"),BigInteger.Parse("99184884676523895557447104"),BigInteger.Parse("22936896882912935631904962898880"),BigInteger.Parse("9200010705455824278689045306643126144"),BigInteger.Parse("6059192105645758114515721403170312097489088"),BigInteger.Parse("6265311017439732830154018479087530633271635314944") };
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
public class A227659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227659Inst Instance=new A227659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227660
{
public static readonly BigInteger[] Value={ 1L,1L,64L,123208L,1831288096L,122911984813568L,BigInteger.Parse("27297846037161958056"),BigInteger.Parse("16391903881902996952724768"),BigInteger.Parse("23066495371480810626495005438496"),BigInteger.Parse("68371528221534300846360580266415146176"),BigInteger.Parse("392997779138060823651445903318712755280168960"),BigInteger.Parse("4100456330337958604264976205090832646574842298883968") };
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
public class A227660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227660Inst Instance=new A227660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227661
{
public static readonly BigInteger[] Value={ 1L,1L,128L,896328L,69221669104L,31283451053916800L,BigInteger.Parse("57403822541579269311072"),BigInteger.Parse("337320253484345016223956919936"),BigInteger.Parse("5366698074745901061777599023075846976"),BigInteger.Parse("203989890816333447880297347963799273322740544"),BigInteger.Parse("16812841813975825541536765059695075768059296587720768") };
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
public class A227661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227661Inst Instance=new A227661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227662
{
public static readonly BigInteger[] Value={ 1L,1L,256L,6520712L,2616540574496L,7962224756951452544L,BigInteger.Parse("120712076511505386344017520"),BigInteger.Parse("6941648177366735193973359263017216"),BigInteger.Parse("1248760044848501400078426452469652899962528"),BigInteger.Parse("608787871679690303320891056934368872583827110376320") };
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
public class A227662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227662Inst Instance=new A227662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227663
{
public static readonly BigInteger[] Value={ 1L,1L,512L,47437640L,98903777810704L,BigInteger.Parse("2026535155335964884480"),BigInteger.Parse("253839841305922000782983605664"),BigInteger.Parse("142850870919946441196223189856661775872"),BigInteger.Parse("290576954131557518350262914717217159752148225600"),BigInteger.Parse("1817025580455577353700768095528219275036151622984555026720") };
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
public class A227663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227663Inst Instance=new A227663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227664
{
public static readonly BigInteger[] Value={ 1L,1L,1024L,345104904L,3738507768500896L,BigInteger.Parse("515791104488454210243072"),BigInteger.Parse("533787802709908480895773030991840"),BigInteger.Parse("2939698583689917131062885788617101100432640"),BigInteger.Parse("67615349092818211761363011993295568195043095341810560"),BigInteger.Parse("5423343272088334681448905520570069990718596808928384073877898816") };
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
public class A227664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227664Inst Instance=new A227664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227665
{
public static readonly long[] Value={ 1L,6L,44L,320L,2328L,16936L,123208L,896328L,6520712L,47437640L,345104904L,2510609608L,18264477064L,132872558664L,966636864776L,7032203170760L,51158695924872L,372175277815624L,2707544336559112L,19697160911545032L,143295215053933448L,1042460827200624200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227665Inst : IEnumerable<long>
{
public static readonly long[] Value=A227665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227665.Bytes);
public long this[int i]=>Value[i];

public static A227665Inst Instance=new A227665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227666
{
public static readonly BigInteger[] Value={ 1L,24L,896L,33904L,1281696L,48447504L,1831288096L,69221669104L,2616540574496L,98903777810704L,3738507768500896L,141313513441272304L,5341572177372667296L,BigInteger.Parse("201908456107703653904"),BigInteger.Parse("7632027293479058673696"),BigInteger.Parse("288486385024598708555504"),BigInteger.Parse("10904624832208006924120096") };
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
public class A227666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227666Inst Instance=new A227666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227667
{
public static readonly BigInteger[] Value={ 1L,120L,29392L,7453320L,1897242448L,482913033152L,122911984813568L,31283451053916800L,7962224756951452544L,BigInteger.Parse("2026535155335964884480"),BigInteger.Parse("515791104488454210243072"),BigInteger.Parse("131278484324109833244067840"),BigInteger.Parse("33412829924638979294019463168"),BigInteger.Parse("8504190228674549912505288509440") };
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
public class A227667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227667Inst Instance=new A227667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227668
{
public static readonly BigInteger[] Value={ 1L,720L,1413792L,2940381648L,6173789662504L,12981179566917088L,BigInteger.Parse("27297846037161958056"),BigInteger.Parse("57403822541579269311072"),BigInteger.Parse("120712076511505386344017520"),BigInteger.Parse("253839841305922000782983605664"),BigInteger.Parse("533787802709908480895773030991840"),BigInteger.Parse("1122477022599575074944649300433060288") };
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
public class A227668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227668Inst Instance=new A227668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227669
{
public static readonly BigInteger[] Value={ 1L,5040L,93770800L,1891074940160L,38746316631586896L,BigInteger.Parse("796655971557156062816"),BigInteger.Parse("16391903881902996952724768"),BigInteger.Parse("337320253484345016223956919936"),BigInteger.Parse("6941648177366735193973359263017216"),BigInteger.Parse("142850870919946441196223189856661775872"),BigInteger.Parse("2939698583689917131062885788617101100432640") };
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
public class A227669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227669Inst Instance=new A227669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227670
{
public static readonly BigInteger[] Value={ 1L,40320L,8201380224L,1850957806329280L,BigInteger.Parse("427196257460311066608"),BigInteger.Parse("99184884676523895557447104"),BigInteger.Parse("23066495371480810626495005438496"),BigInteger.Parse("5366698074745901061777599023075846976"),BigInteger.Parse("1248760044848501400078426452469652899962528"),BigInteger.Parse("290576954131557518350262914717217159752148225600") };
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
public class A227670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227670Inst Instance=new A227670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227671
{
public static readonly BigInteger[] Value={ 1L,362880L,914570667792L,2618225365541294080L,BigInteger.Parse("7716228754248308194763776"),BigInteger.Parse("22936896882912935631904962898880"),BigInteger.Parse("68371528221534300846360580266415146176"),BigInteger.Parse("203989890816333447880297347963799273322740544"),BigInteger.Parse("608787871679690303320891056934368872583827110376320") };
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
public class A227671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227671Inst Instance=new A227671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227672
{
public static readonly BigInteger[] Value={ 1L,3628800L,126651310675680L,BigInteger.Parse("5140671157605632743040"),BigInteger.Parse("216245142312150285990621189096"),BigInteger.Parse("9200010705455824278689045306643126144"),BigInteger.Parse("392997779138060823651445903318712755280168960"),BigInteger.Parse("16812841813975825541536765059695075768059296587720768") };
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
public class A227672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227672Inst Instance=new A227672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227673
{
public static readonly BigInteger[] Value={ 1L,1L,4L,320L,1281696L,482913033152L,BigInteger.Parse("27297846037161958056"),BigInteger.Parse("337320253484345016223956919936"),BigInteger.Parse("1248760044848501400078426452469652899962528"),BigInteger.Parse("1817025580455577353700768095528219275036151622984555026720") };
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
public class A227673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227673Inst Instance=new A227673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227674
{
public static readonly long[] Value={ 2L,16L,283L,11971L,1330361L,418147052L,392636087774L,1142471406383630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227674Inst : IEnumerable<long>
{
public static readonly long[] Value=A227674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227674.Bytes);
public long this[int i]=>Value[i];

public static A227674Inst Instance=new A227674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227675
{
public static readonly long[] Value={ 4L,16L,50L,131L,301L,625L,1198L,2153L,3670L,5986L,9406L,14315L,21191L,30619L,43306L,60097L,81992L,110164L,145978L,191011L,247073L,316229L,400822L,503497L,627226L,775334L,951526L,1159915L,1405051L,1691951L,2026130L,2413633L,2861068L,3375640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227675Inst : IEnumerable<long>
{
public static readonly long[] Value=A227675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227675.Bytes);
public long this[int i]=>Value[i];

public static A227675Inst Instance=new A227675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227676
{
public static readonly long[] Value={ 7L,50L,283L,1343L,5434L,19188L,60484L,173433L,459198L,1135975L,2650373L,5876032L,12455509L,25370717L,49868689L,94927157L,175523369L,316075856L,555569995L,955063241L,1608505660L,2658118770L,4315965894L,6893838077L,10844191896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227676Inst : IEnumerable<long>
{
public static readonly long[] Value=A227676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227676.Bytes);
public long this[int i]=>Value[i];

public static A227676Inst Instance=new A227676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227677
{
public static readonly long[] Value={ 11L,131L,1343L,11971L,90884L,592791L,3380440L,17161921L,78807477L,331649881L,1292860261L,4709556398L,16147197916L,52422604429L,161978060979L,478412562214L,1355794408584L,3698766477709L,9741946309658L,24835300279682L,61420677587519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227677Inst : IEnumerable<long>
{
public static readonly long[] Value=A227677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227677.Bytes);
public long this[int i]=>Value[i];

public static A227677Inst Instance=new A227677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227678
{
public static readonly long[] Value={ 16L,301L,5434L,90884L,1330361L,16795263L,184000783L,1773503344L,15261176700L,118793987740L,845798776106L,5559078678951L,33988369766356L,194559879927981L,1048491460707150L,5344823772801721L,25880047053192859L,119467909882082282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227678Inst : IEnumerable<long>
{
public static readonly long[] Value=A227678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227678.Bytes);
public long this[int i]=>Value[i];

public static A227678Inst Instance=new A227678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227679
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,11L,50L,50L,11L,16L,131L,283L,131L,16L,22L,301L,1343L,1343L,301L,22L,29L,625L,5434L,11971L,5434L,625L,29L,37L,1198L,19188L,90884L,90884L,19188L,1198L,37L,46L,2153L,60484L,592791L,1330361L,592791L,60484L,2153L,46L,56L,3670L,173433L,3380440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227679Inst : IEnumerable<long>
{
public static readonly long[] Value=A227679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227679.Bytes);
public long this[int i]=>Value[i];

public static A227679Inst Instance=new A227679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227680
{
public static readonly long[] Value={ 30L,36L,42L,66L,70L,72L,78L,105L,108L,114L,130L,144L,154L,165L,174L,182L,196L,210L,216L,222L,231L,238L,246L,255L,273L,282L,285L,286L,288L,310L,318L,324L,345L,357L,366L,370L,385L,392L,399L,418L,430L,432L,434L,441L,442L,455L,462L,465L,474L,483L,494L,498L,518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227680Inst : IEnumerable<long>
{
public static readonly long[] Value=A227680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227680.Bytes);
public long this[int i]=>Value[i];

public static A227680Inst Instance=new A227680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227681
{
public static readonly long[] Value={ 1L,1L,3L,6L,12L,23L,43L,79L,142L,252L,442L,766L,1316L,2244L,3799L,6393L,10704L,17841L,29618L,49000L,80823L,132964L,218242L,357501L,584608L,954553L,1556575L,2535425L,4125805L,6708143L,10898897L,17696749L,28719276L,46586050L,75538702L,122444483L,198420445L,321461918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227681Inst : IEnumerable<long>
{
public static readonly long[] Value=A227681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227681.Bytes);
public long this[int i]=>Value[i];

public static A227681Inst Instance=new A227681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227682
{
public static readonly long[] Value={ 1L,1L,3L,7L,16L,35L,76L,162L,342L,715L,1484L,3060L,6278L,12824L,26102L,52969L,107224L,216601L,436798L,879584L,1769117L,3554726L,7136736L,14318524L,28711315L,57544864L,115290624L,230910993L,462362571L,925610398L,1852669016L,3707705019L,7419275371L,14844857959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227682Inst : IEnumerable<long>
{
public static readonly long[] Value=A227682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227682.Bytes);
public long this[int i]=>Value[i];

public static A227682Inst Instance=new A227682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227683
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,6L,6L,7L,9L,10L,12L,13L,13L,15L,16L,18L,19L,21L,22L,22L,24L,25L,27L,30L,31L,32L,33L,33L,35L,39L,40L,42L,42L,45L,46L,48L,50L,51L,53L,54L,55L,58L,59L,60L,60L,64L,68L,69L,69L,71L,72L,73L,76L,78L,80L,81L,82L,84L,85L,86L,89L,93L,94L,95L,96L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227683Inst : IEnumerable<long>
{
public static readonly long[] Value=A227683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227683.Bytes);
public long this[int i]=>Value[i];

public static A227683Inst Instance=new A227683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227684
{
public static readonly long[] Value={ 0L,1L,4L,3L,5L,9L,2L,13L,9L,7L,12L,5L,13L,8L,11L,14L,17L,29L,53L,3L,34L,25L,19L,16L,13L,23L,33L,10L,17L,24L,31L,52L,7L,39L,25L,18L,29L,51L,11L,37L,26L,15L,34L,19L,42L,23L,27L,31L,39L,47L,59L,83L,135L,4L,161L,97L,69L,53L,45L,41L,33L,29L,54L,25L,46L,21L,59L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227684Inst : IEnumerable<long>
{
public static readonly long[] Value=A227684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227684.Bytes);
public long this[int i]=>Value[i];

public static A227684Inst Instance=new A227684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227685
{
public static readonly long[] Value={ 1L,3L,5L,7L,15L,2L,19L,13L,11L,9L,16L,23L,7L,19L,12L,29L,17L,22L,32L,57L,5L,88L,53L,38L,28L,51L,23L,59L,18L,31L,44L,70L,13L,60L,47L,34L,76L,21L,50L,29L,66L,37L,45L,53L,69L,85L,117L,189L,8L,243L,147L,107L,83L,67L,59L,51L,94L,43L,78L,35L,97L,62L,89L,27L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227685Inst : IEnumerable<long>
{
public static readonly long[] Value=A227685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227685.Bytes);
public long this[int i]=>Value[i];

public static A227685Inst Instance=new A227685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227686
{
public static readonly long[] Value={ 1L,4L,7L,10L,22L,3L,29L,20L,17L,14L,25L,36L,11L,30L,19L,46L,27L,35L,51L,91L,8L,141L,85L,61L,45L,82L,37L,95L,29L,50L,71L,113L,21L,97L,76L,55L,123L,34L,81L,47L,107L,60L,73L,86L,112L,138L,190L,307L,13L,395L,239L,174L,135L,109L,96L,83L,153L,70L,127L,57L,158L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227686Inst : IEnumerable<long>
{
public static readonly long[] Value=A227686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227686.Bytes);
public long this[int i]=>Value[i];

public static A227686Inst Instance=new A227686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227687
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,1L,4L,2L,3L,1L,3L,2L,3L,1L,3L,2L,3L,1L,5L,3L,2L,3L,1L,5L,3L,2L,3L,5L,1L,4L,3L,2L,3L,5L,1L,4L,3L,2L,3L,4L,1L,6L,4L,3L,2L,3L,5L,1L,6L,4L,3L,2L,3L,4L,7L,1L,5L,3L,5L,2L,3L,4L,7L,1L,5L,4L,3L,2L,3L,4L,6L,1L,7L,4L,3L,5L,2L,3L,4L,6L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227687Inst : IEnumerable<long>
{
public static readonly long[] Value=A227687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227687.Bytes);
public long this[int i]=>Value[i];

public static A227687Inst Instance=new A227687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227688
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,4L,13L,9L,5L,21L,11L,17L,6L,19L,13L,20L,7L,22L,15L,23L,8L,41L,25L,17L,26L,9L,46L,28L,19L,29L,49L,10L,41L,31L,21L,32L,54L,11L,45L,34L,23L,35L,47L,12L,73L,49L,37L,25L,38L,64L,13L,79L,53L,40L,27L,41L,55L,97L,14L,71L,43L,72L,29L,44L,59L,104L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227688Inst : IEnumerable<long>
{
public static readonly long[] Value=A227688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227688.Bytes);
public long this[int i]=>Value[i];

public static A227688Inst Instance=new A227688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227689
{
public static readonly long[] Value={ 1L,30L,329L,3319L,33216L,332190L,3321925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227689Inst : IEnumerable<long>
{
public static readonly long[] Value=A227689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227689.Bytes);
public long this[int i]=>Value[i];

public static A227689Inst Instance=new A227689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227690
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,4L,3L,4L,1L,1L,1L,1L,5L,6L,6L,5L,1L,1L,1L,1L,9L,10L,13L,10L,9L,1L,1L,1L,1L,12L,21L,39L,39L,21L,12L,1L,1L,1L,1L,21L,39L,115L,77L,115L,39L,21L,1L,1L,1L,1L,30L,82L,295L,521L,521L,295L,82L,30L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227690Inst : IEnumerable<long>
{
public static readonly long[] Value=A227690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227690.Bytes);
public long this[int i]=>Value[i];

public static A227690Inst Instance=new A227690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227691
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,32L,33L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227691Inst : IEnumerable<long>
{
public static readonly long[] Value=A227691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227691.Bytes);
public long this[int i]=>Value[i];

public static A227691Inst Instance=new A227691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227692
{
public static readonly long[] Value={ 169L,24649L,833569L,20367169L,214534609L,368678401L,372142681L,392554969L,407676481L,771617284L,1013021584L,1212780625L,1404075841L,1567051396L,1623848209L,2538748996L,2866103296L,2898960964L,3015437569L,3967236196L,4098688441L,4937451289L,5854239169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227692Inst : IEnumerable<long>
{
public static readonly long[] Value=A227692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227692.Bytes);
public long this[int i]=>Value[i];

public static A227692Inst Instance=new A227692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227693
{
public static readonly BigInteger[] Value={ 4L,25L,168L,1229L,9595L,78527L,664408L,5759130L,50833725L,455019102L,4118498801L,37616575907L,346165453783L,3205869110911L,29851888456753L,279286334215803L,2623780688311969L,24739953477533166L,234041108830344356L,2220562531262307905L,BigInteger.Parse("21124612016460745383"),BigInteger.Parse("201448482556532026684"),BigInteger.Parse("1925296277838503159171"),BigInteger.Parse("18437832696789559015711"),BigInteger.Parse("176901280909820032014422") };
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
public class A227693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227693Inst Instance=new A227693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227694
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,-3L,-29L,171L,2325L,13809L,33409L,-443988L,-8663889L,-99916944L,-927360109L,-7318034084L,-47993181878L,-223530657736L,810207694L,16558446000251L,257071298610935L,2657469557986545L,18804132783879606L,24113768300809752L,-2232929440358147845L,BigInteger.Parse("-54971510676262602742") };
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
public class A227694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227694Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227694.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227694Inst Instance=new A227694Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227695
{
public static readonly long[] Value={ 1L,-10L,37L,-50L,-30L,128L,-25L,-34L,-320L,310L,410L,-370L,-87L,-410L,320L,30L,500L,384L,-630L,-640L,-359L,300L,-326L,2560L,-110L,-1098L,-1280L,-370L,1490L,-1850L,269L,1500L,1216L,640L,570L,-3328L,340L,-2010L,-1110L,1790L,768L,3200L,303L,750L,-1600L,-442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227695Inst : IEnumerable<long>
{
public static readonly long[] Value=A227695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227695.Bytes);
public long this[int i]=>Value[i];

public static A227695Inst Instance=new A227695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227696
{
public static readonly long[] Value={ 1L,-1L,2L,0L,2L,-1L,2L,0L,1L,-2L,2L,0L,2L,0L,2L,0L,3L,-2L,0L,0L,2L,-1L,2L,0L,2L,-2L,2L,0L,0L,0L,4L,0L,2L,-1L,2L,0L,2L,-2L,0L,0L,1L,-2L,2L,0L,4L,0L,2L,0L,0L,-2L,2L,0L,2L,0L,2L,0L,3L,-2L,2L,0L,2L,0L,0L,0L,2L,-3L,2L,0L,0L,-2L,2L,0L,4L,0L,2L,0L,2L,0L,0L,0L,2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227696Inst : IEnumerable<long>
{
public static readonly long[] Value=A227696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227696.Bytes);
public long this[int i]=>Value[i];

public static A227696Inst Instance=new A227696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227697
{
public static readonly long[] Value={ 2L,4L,6L,7L,9L,12L,16L,18L,21L,22L,24L,27L,30L,36L,37L,39L,42L,46L,48L,51L,57L,60L,66L,67L,69L,72L,81L,87L,90L,102L,106L,108L,111L,120L,121L,123L,126L,132L,135L,141L,150L,156L,165L,171L,172L,174L,177L,186L,192L,207L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227697Inst : IEnumerable<long>
{
public static readonly long[] Value=A227697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227697.Bytes);
public long this[int i]=>Value[i];

public static A227697Inst Instance=new A227697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227698
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,2L,0L,1L,2L,0L,1L,1L,0L,1L,1L,2L,0L,0L,2L,0L,1L,1L,0L,0L,0L,1L,0L,1L,2L,0L,0L,1L,1L,2L,0L,1L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,2L,0L,1L,0L,0L,0L,0L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227698Inst : IEnumerable<long>
{
public static readonly long[] Value=A227698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227698.Bytes);
public long this[int i]=>Value[i];

public static A227698Inst Instance=new A227698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227699
{
public static readonly long[] Value={ 34081L,133753L,606505L,2879881L,13759561L,65105353L,303499465L,1393200841L,6306020041L,28195082953L,124751348425L,547085017801L,2381092856521L,10296337572553L,44275297821385L,189465493250761L,807328896525001L,3427204095550153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227699Inst : IEnumerable<long>
{
public static readonly long[] Value=A227699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227699.Bytes);
public long this[int i]=>Value[i];

public static A227699Inst Instance=new A227699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227700
{
public static readonly long[] Value={ 299671L,1624639L,9938719L,60310495L,352063711L,1970086879L,10608950239L,55279894495L,280190685151L,1387684298719L,6740446216159L,32207067824095L,151750499712991L,706442679304159L,3254507926208479L,14856796917219295L,67277314593931231L,302489552025567199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227700Inst : IEnumerable<long>
{
public static readonly long[] Value=A227700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227700.Bytes);
public long this[int i]=>Value[i];

public static A227700Inst Instance=new A227700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227701
{
public static readonly long[] Value={ 48279L,96987L,255171L,834771L,3170163L,13124019L,56647731L,248434995L,1092754227L,4792876851L,20915808051L,90764867379L,391736497971L,1682238527283L,7191380186931L,30617911318323L,129886929049395L,549220992440115L,2315602753509171L,9737340299794227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227701Inst : IEnumerable<long>
{
public static readonly long[] Value=A227701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227701.Bytes);
public long this[int i]=>Value[i];

public static A227701Inst Instance=new A227701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227702
{
public static readonly long[] Value={ 449908L,1096118L,3588202L,14360018L,64595362L,307414082L,1492075906L,7247514626L,34935347458L,166607364866L,785654642434L,3665131036418L,16929529343746L,77501591179010L,351950298746626L,1586770938400514L,7107632205434626L,31651156830097154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227702Inst : IEnumerable<long>
{
public static readonly long[] Value=A227702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227702.Bytes);
public long this[int i]=>Value[i];

public static A227702Inst Instance=new A227702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227703
{
public static readonly long[] Value={ 52L,150L,328L,610L,1020L,1582L,2320L,3258L,4420L,5830L,7512L,9490L,11788L,14430L,17440L,20842L,24660L,28918L,33640L,38850L,44572L,50830L,57648L,65050L,73060L,81702L,91000L,100978L,111660L,123070L,135232L,148170L,161908L,176470L,191880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227703Inst : IEnumerable<long>
{
public static readonly long[] Value=A227703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227703.Bytes);
public long this[int i]=>Value[i];

public static A227703Inst Instance=new A227703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227704
{
public static readonly long[] Value={ 82L,273L,692L,1475L,2790L,4837L,7848L,12087L,17850L,25465L,35292L,47723L,63182L,82125L,105040L,132447L,164898L,202977L,247300L,298515L,357302L,424373L,500472L,586375L,682890L,790857L,911148L,1044667L,1192350L,1355165L,1534112L,1730223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227704Inst : IEnumerable<long>
{
public static readonly long[] Value=A227704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227704.Bytes);
public long this[int i]=>Value[i];

public static A227704Inst Instance=new A227704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227705
{
public static readonly long[] Value={ 198L,3834L,34434L,230418L,1327410L,7005042L,34949106L,167809266L,783885042L,3587327730L,16158854898L,71878385394L,316494986994L,1381924896498L,5991517716210L,25821420060402L,110707230375666L,472515428744946L,2008808357363442L,8510221225819890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227705Inst : IEnumerable<long>
{
public static readonly long[] Value=A227705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227705.Bytes);
public long this[int i]=>Value[i];

public static A227705Inst Instance=new A227705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227706
{
public static readonly long[] Value={ 477L,16515L,222975L,2038455L,15095079L,98153991L,584951751L,3276557127L,17527771719L,90505289799L,454449839175L,2230961075271L,10750358250567L,51003115291719L,238802012701767L,1105498179306567L,5067682186396743L,23031604974453831L,103882403285042247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227706Inst : IEnumerable<long>
{
public static readonly long[] Value=A227706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227706.Bytes);
public long this[int i]=>Value[i];

public static A227706Inst Instance=new A227706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227707
{
public static readonly long[] Value={ 12L,78L,444L,2328L,11568L,55392L,258240L,1180032L,5309184L,23594496L,103812096L,452990976L,1962946560L,8455741440L,36238835712L,154618920960L,657130192896L,2783139201024L,11751031308288L,49478024822784L,207807700795392L,870813215490048L,3641582523777024L,15199648767541248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227707Inst : IEnumerable<long>
{
public static readonly long[] Value=A227707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227707.Bytes);
public long this[int i]=>Value[i];

public static A227707Inst Instance=new A227707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227708
{
public static readonly long[] Value={ 84L,354L,1674L,8178L,39858L,191250L,900498L,4164114L,18952722L,85106706L,377862162L,1661755410L,7249502226L,31410683922L,135299432466L,579837493266L,2473936945170L,10514155438098L,44530379784210L,188016821796882L,791649070350354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227708Inst : IEnumerable<long>
{
public static readonly long[] Value=A227708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227708.Bytes);
public long this[int i]=>Value[i];

public static A227708Inst Instance=new A227708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227709
{
public static readonly long[] Value={ 159L,906L,5664L,34932L,206652L,1168620L,6344268L,33264780L,169424652L,842319372L,4104041484L,19659270156L,92822679564L,432877854732L,1997218529292L,9129086189580L,41386604691468L,186264812126220L,832881548328972L,3702608701685772L,16373934411743244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227709Inst : IEnumerable<long>
{
public static readonly long[] Value=A227709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227709.Bytes);
public long this[int i]=>Value[i];

public static A227709Inst Instance=new A227709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227710
{
public static readonly long[] Value={ 47160L,501516L,3609684L,21645828L,117137700L,594466020L,2889375588L,13620124260L,62765849700L,284277930084L,1270122831972L,5612855201892L,24581542031460L,106848038187108L,461482510708836L,1982297444839524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227710Inst : IEnumerable<long>
{
public static readonly long[] Value=A227710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227710.Bytes);
public long this[int i]=>Value[i];

public static A227710Inst Instance=new A227710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227711
{
public static readonly long[] Value={ 403929L,7123491L,73556943L,584118615L,3973793223L,24439248231L,140086159911L,762624306855L,3992164666791L,20266876319655L,100389136655271L,487362872044455L,2326764524198823L,10952675858742183L,50938660677696423L,234448450914335655L,1069296992883227559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227711Inst : IEnumerable<long>
{
public static readonly long[] Value=A227711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227711.Bytes);
public long this[int i]=>Value[i];

public static A227711Inst Instance=new A227711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227712
{
public static readonly long[] Value={ 4L,10L,25L,58L,127L,268L,553L,1126L,2275L,4576L,9181L,18394L,36823L,73684L,147409L,294862L,589771L,1179592L,2359237L,4718530L,9437119L,18874300L,37748665L,75497398L,150994867L,301989808L,603979693L,1207959466L,2415919015L,4831838116L,9663676321L,19327352734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227712Inst : IEnumerable<long>
{
public static readonly long[] Value=A227712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227712.Bytes);
public long this[int i]=>Value[i];

public static A227712Inst Instance=new A227712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227713
{
public static readonly long[] Value={ 1L,9L,90L,836L,6856L,49787L,326618L,1977322L,11244976L,60908337L,317509874L,1605448440L,7920487752L,38297112551L,182108066522L,853884638758L,3956279351760L,18143381822941L,82466719670866L,371917534537524L,1665777832832136L,7415146800493139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227713Inst : IEnumerable<long>
{
public static readonly long[] Value=A227713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227713.Bytes);
public long this[int i]=>Value[i];

public static A227713Inst Instance=new A227713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227714
{
public static readonly long[] Value={ 1L,12L,178L,2688L,35995L,407992L,3952943L,33615105L,257526804L,1815863659L,11982128854L,74936243346L,448516091145L,2588488505682L,14488775962673L,79019272700951L,421449109356322L,2204733396548381L,11340131754176896L,57464577063754608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227714Inst : IEnumerable<long>
{
public static readonly long[] Value=A227714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227714.Bytes);
public long this[int i]=>Value[i];

public static A227714Inst Instance=new A227714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227715
{
public static readonly long[] Value={ 1L,4L,4L,28L,24L,16L,188L,188L,128L,64L,1428L,1368L,1120L,640L,256L,10708L,10572L,8864L,6208L,3072L,1024L,82948L,81376L,71572L,53376L,32768L,14336L,4096L,644788L,637148L,570512L,453424L,304640L,166912L,65536L,16384L,5067404L,5007560L,4572076L,3762672L,2728256L,1669120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227715Inst : IEnumerable<long>
{
public static readonly long[] Value=A227715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227715.Bytes);
public long this[int i]=>Value[i];

public static A227715Inst Instance=new A227715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227716
{
public static readonly long[] Value={ 2L,10L,8L,74L,56L,32L,518L,464L,288L,128L,3934L,3520L,2656L,1408L,512L,29914L,27768L,21920L,14336L,6656L,2048L,232094L,217316L,181456L,128256L,74240L,30720L,8192L,1812890L,1719616L,1475172L,1118592L,716288L,372736L,139264L,32768L,14277886L,13633972L,11989800L,9480048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227716Inst : IEnumerable<long>
{
public static readonly long[] Value=A227716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227716.Bytes);
public long this[int i]=>Value[i];

public static A227716Inst Instance=new A227716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227717
{
public static readonly long[] Value={ 3L,4L,9L,6L,0L,7L,6L,7L,3L,9L,0L,5L,6L,1L,5L,9L,7L,4L,7L,2L,8L,6L,4L,5L,2L,7L,8L,6L,5L,2L,1L,4L,9L,2L,5L,5L,1L,5L,7L,7L,0L,0L,6L,6L,0L,1L,9L,0L,8L,8L,3L,0L,8L,8L,3L,7L,5L,5L,7L,6L,2L,2L,7L,1L,7L,3L,4L,3L,8L,7L,4L,4L,9L,4L,2L,7L,2L,1L,9L,0L,0L,0L,3L,0L,7L,0L,6L,0L,7L,1L,0L,6L,1L,5L,2L,3L,8L,7L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227717Inst : IEnumerable<long>
{
public static readonly long[] Value=A227717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227717.Bytes);
public long this[int i]=>Value[i];

public static A227717Inst Instance=new A227717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227718
{
public static readonly long[] Value={ 6L,7L,0L,7L,1L,5L,2L,2L,6L,0L,2L,3L,1L,7L,5L,9L,4L,0L,6L,3L,0L,5L,2L,9L,7L,6L,1L,3L,8L,3L,6L,8L,4L,4L,1L,5L,3L,6L,5L,4L,4L,4L,1L,6L,5L,2L,8L,9L,3L,3L,7L,6L,0L,2L,0L,4L,5L,8L,7L,8L,0L,5L,0L,7L,0L,0L,3L,4L,7L,3L,1L,1L,5L,6L,7L,7L,8L,7L,1L,4L,3L,6L,7L,0L,9L,4L,1L,1L,2L,9L,6L,2L,2L,9L,0L,8L,1L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227718Inst : IEnumerable<long>
{
public static readonly long[] Value=A227718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227718.Bytes);
public long this[int i]=>Value[i];

public static A227718Inst Instance=new A227718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227719
{
public static readonly long[] Value={ 5L,16L,33L,56L,86L,121L,162L,209L,263L,322L,387L,458L,536L,619L,708L,803L,905L,1012L,1125L,1244L,1370L,1501L,1638L,1781L,1931L,2086L,2247L,2414L,2588L,2767L,2952L,3143L,3341L,3544L,3753L,3968L,4190L,4417L,4650L,4889L,5135L,5386L,5643L,5906L,6176L,6451L,6732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227719Inst : IEnumerable<long>
{
public static readonly long[] Value=A227719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227719.Bytes);
public long this[int i]=>Value[i];

public static A227719Inst Instance=new A227719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227720
{
public static readonly long[] Value={ 5L,16L,34L,57L,86L,121L,163L,210L,263L,322L,388L,459L,536L,619L,709L,804L,905L,1012L,1126L,1245L,1370L,1501L,1639L,1782L,1931L,2086L,2248L,2415L,2588L,2767L,2953L,3144L,3341L,3544L,3754L,3969L,4190L,4417L,4651L,4890L,5135L,5386L,5644L,5907L,6176L,6451L,6733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227720Inst : IEnumerable<long>
{
public static readonly long[] Value=A227720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227720.Bytes);
public long this[int i]=>Value[i];

public static A227720Inst Instance=new A227720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227721
{
public static readonly long[] Value={ 17L,44L,83L,134L,197L,272L,359L,458L,569L,692L,827L,974L,1133L,1304L,1487L,1682L,1889L,2108L,2339L,2582L,2837L,3104L,3383L,3674L,3977L,4292L,4619L,4958L,5309L,5672L,6047L,6434L,6833L,7244L,7667L,8102L,8549L,9008L,9479L,9962L,10457L,10964L,11483L,12014L,12557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227721Inst : IEnumerable<long>
{
public static readonly long[] Value=A227721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227721.Bytes);
public long this[int i]=>Value[i];

public static A227721Inst Instance=new A227721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227722
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,15L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,51L,53L,54L,55L,60L,61L,63L,85L,86L,87L,90L,91L,95L,102L,103L,105L,107L,111L,119L,123L,125L,126L,127L,255L,257L,258L,259L,260L,261L,262L,263L,264L,265L,266L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227722Inst : IEnumerable<long>
{
public static readonly long[] Value=A227722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227722.Bytes);
public long this[int i]=>Value[i];

public static A227722Inst Instance=new A227722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227723
{
public static readonly long[] Value={ 0L,1L,3L,6L,7L,15L,22L,23L,24L,25L,27L,30L,31L,60L,61L,63L,105L,107L,111L,126L,127L,255L,278L,279L,280L,281L,282L,283L,286L,287L,300L,301L,303L,316L,317L,318L,319L,360L,361L,362L,363L,366L,367L,382L,383L,384L,385L,386L,387L,390L,391L,393L,395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227723Inst : IEnumerable<long>
{
public static readonly long[] Value=A227723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227723.Bytes);
public long this[int i]=>Value[i];

public static A227723Inst Instance=new A227723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227724
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,0L,0L,7L,0L,7L,0L,15L,0L,105L,750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227724Inst : IEnumerable<long>
{
public static readonly long[] Value=A227724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227724.Bytes);
public long this[int i]=>Value[i];

public static A227724Inst Instance=new A227724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227725
{
public static readonly long[] Value={ 2L,2L,1L,2L,3L,2L,2L,7L,14L,23L,2L,15L,70L,345L,3904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227725Inst : IEnumerable<long>
{
public static readonly long[] Value=A227725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227725.Bytes);
public long this[int i]=>Value[i];

public static A227725Inst Instance=new A227725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227726
{
public static readonly long[] Value={ 1L,4L,20L,112L,660L,4004L,24752L,155040L,980628L,6249100L,40060020L,258048960L,1668903600L,10829900592L,70480305440L,459823234112L,3006465218196L,19694758782300L,129235131438140L,849311959095600L,5589126007740660L,36825913869817380L,242910890642347200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227726Inst : IEnumerable<long>
{
public static readonly long[] Value=A227726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227726.Bytes);
public long this[int i]=>Value[i];

public static A227726Inst Instance=new A227726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227727
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,3L,5L,3L,7L,3L,3L,4L,3L,7L,4L,3L,3L,5L,3L,4L,4L,3L,3L,3L,11L,3L,16L,9L,3L,5L,3L,3L,19L,3L,4L,7L,3L,6L,22L,3L,3L,5L,3L,4L,4L,3L,5L,4L,19L,3L,3L,15L,3L,11L,6L,3L,7L,5L,4L,3L,3L,3L,4L,3L,5L,5L,3L,4L,37L,5L,3L,14L,3L,3L,4L,3L,4L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227727Inst : IEnumerable<long>
{
public static readonly long[] Value=A227727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227727.Bytes);
public long this[int i]=>Value[i];

public static A227727Inst Instance=new A227727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227728
{
public static readonly long[] Value={ 10L,43L,179L,740L,3054L,12599L,51971L,214376L,884278L,3647546L,15045706L,62061794L,255997704L,1055960840L,4355715996L,17966823308L,74111062350L,305699536774L,1260975134078L,5201376179830L,21455073484758L,88499689759294L,365050956038686L,1505792854949114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227728Inst : IEnumerable<long>
{
public static readonly long[] Value=A227728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227728.Bytes);
public long this[int i]=>Value[i];

public static A227728Inst Instance=new A227728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227729
{
public static readonly long[] Value={ 1L,4L,1L,7L,0L,3L,7L,9L,0L,2L,9L,6L,0L,9L,3L,6L,1L,6L,7L,7L,1L,0L,5L,9L,9L,8L,9L,5L,2L,7L,0L,1L,3L,9L,2L,2L,5L,4L,6L,7L,5L,9L,2L,9L,1L,5L,1L,3L,8L,5L,6L,4L,1L,3L,7L,5L,6L,7L,5L,2L,3L,9L,1L,8L,3L,9L,4L,3L,7L,0L,3L,7L,8L,5L,1L,4L,7L,4L,5L,4L,9L,0L,7L,4L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227729Inst : IEnumerable<long>
{
public static readonly long[] Value=A227729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227729.Bytes);
public long this[int i]=>Value[i];

public static A227729Inst Instance=new A227729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227730
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,24L,32L,36L,48L,60L,64L,72L,80L,96L,108L,112L,120L,128L,144L,160L,168L,180L,192L,216L,224L,240L,252L,256L,288L,300L,320L,324L,336L,360L,384L,396L,400L,420L,432L,448L,480L,504L,512L,528L,540L,560L,576L,600L,640L,648L,660L,672L,704L,720L,756L,768L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227730Inst : IEnumerable<long>
{
public static readonly long[] Value=A227730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227730.Bytes);
public long this[int i]=>Value[i];

public static A227730Inst Instance=new A227730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227731
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,16L,18L,20L,24L,27L,30L,32L,36L,40L,45L,48L,54L,60L,63L,64L,72L,80L,81L,84L,90L,96L,100L,108L,112L,120L,126L,128L,135L,140L,144L,150L,160L,162L,168L,176L,180L,189L,192L,200L,210L,216L,220L,224L,225L,240L,243L,252L,256L,264L,270L,280L,288L,300L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227731Inst : IEnumerable<long>
{
public static readonly long[] Value=A227731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227731.Bytes);
public long this[int i]=>Value[i];

public static A227731Inst Instance=new A227731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227732
{
public static readonly long[] Value={ 1L,8L,52L,288L,1396L,6208L,25744L,100608L,374500L,1336488L,4596000L,15297056L,49444368L,155640640L,478268800L,1437600000L,4234216836L,12238666208L,34761065924L,97130259232L,267280386128L,724987680384L,1940011007056L,5125212451584L,13376644454672L,34512562565224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227732Inst : IEnumerable<long>
{
public static readonly long[] Value=A227732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227732.Bytes);
public long this[int i]=>Value[i];

public static A227732Inst Instance=new A227732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227733
{
public static readonly long[] Value={ 8L,40L,128L,176L,288L,640L,512L,736L,1352L,1440L,1152L,2816L,1568L,2560L,4608L,3008L,2592L,6760L,3200L,6336L,8192L,5760L,4608L,11776L,7688L,7840L,12800L,11264L,7200L,23040L,8192L,12160L,18432L,12960L,18432L,29744L,11552L,16000L,25088L,26496L,14112L,40960L,15488L,25344L,48672L,23040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227733Inst : IEnumerable<long>
{
public static readonly long[] Value=A227733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227733.Bytes);
public long this[int i]=>Value[i];

public static A227733Inst Instance=new A227733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227734
{
public static readonly long[] Value={ 84L,120L,132L,168L,195L,228L,231L,255L,260L,264L,276L,280L,308L,312L,340L,372L,399L,408L,420L,435L,440L,455L,456L,483L,516L,520L,532L,552L,555L,564L,580L,595L,615L,616L,627L,644L,651L,660L,663L,680L,696L,708L,715L,728L,740L,744L,759L,760L,795L,804L,820L,836L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227734Inst : IEnumerable<long>
{
public static readonly long[] Value=A227734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227734.Bytes);
public long this[int i]=>Value[i];

public static A227734Inst Instance=new A227734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227735
{
public static readonly long[] Value={ 39L,55L,56L,68L,87L,95L,104L,111L,116L,119L,136L,143L,152L,155L,159L,164L,183L,184L,199L,203L,212L,215L,219L,239L,244L,247L,248L,259L,287L,291L,292L,295L,296L,299L,303L,319L,323L,327L,328L,335L,339L,344L,355L,356L,367L,371L,376L,388L,391L,395L,404L,407L,411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227735Inst : IEnumerable<long>
{
public static readonly long[] Value=A227735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227735.Bytes);
public long this[int i]=>Value[i];

public static A227735Inst Instance=new A227735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227736
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,3L,3L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,3L,4L,4L,1L,1L,3L,1L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,3L,2L,1L,2L,2L,1L,1L,1L,2L,2L,1L,2L,2L,3L,1L,1L,3L,1L,4L,5L,5L,1L,1L,4L,1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227736Inst : IEnumerable<long>
{
public static readonly long[] Value=A227736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227736.Bytes);
public long this[int i]=>Value[i];

public static A227736Inst Instance=new A227736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227737
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,5L,5L,6L,6L,7L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,13L,13L,13L,14L,14L,15L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,26L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227737Inst : IEnumerable<long>
{
public static readonly long[] Value=A227737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227737.Bytes);
public long this[int i]=>Value[i];

public static A227737Inst Instance=new A227737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227738
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,1L,2L,3L,1L,3L,3L,3L,4L,1L,3L,4L,1L,2L,3L,4L,2L,3L,4L,2L,4L,1L,2L,4L,1L,4L,4L,4L,5L,1L,4L,5L,1L,2L,4L,5L,2L,4L,5L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,3L,4L,5L,3L,4L,5L,3L,5L,1L,3L,5L,1L,2L,3L,5L,2L,3L,5L,2L,5L,1L,2L,5L,1L,5L,5L,5L,6L,1L,5L,6L,1L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227738Inst : IEnumerable<long>
{
public static readonly long[] Value=A227738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227738.Bytes);
public long this[int i]=>Value[i];

public static A227738Inst Instance=new A227738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227739
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,2L,3L,3L,3L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,3L,1L,1L,2L,1L,3L,4L,4L,4L,1L,3L,3L,1L,1L,2L,2L,2L,3L,3L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,2L,4L,1L,1L,3L,1L,4L,5L,5L,5L,1L,4L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227739Inst : IEnumerable<long>
{
public static readonly long[] Value=A227739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227739.Bytes);
public long this[int i]=>Value[i];

public static A227739Inst Instance=new A227739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227740
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,1L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227740Inst : IEnumerable<long>
{
public static readonly long[] Value=A227740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227740.Bytes);
public long this[int i]=>Value[i];

public static A227740Inst Instance=new A227740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227741
{
public static readonly long[] Value={ 1L,3L,2L,4L,6L,5L,9L,8L,7L,11L,10L,12L,14L,13L,17L,16L,15L,21L,20L,19L,18L,24L,23L,22L,26L,25L,29L,28L,27L,31L,30L,32L,34L,33L,37L,36L,35L,41L,40L,39L,38L,44L,43L,42L,48L,47L,46L,45L,53L,52L,51L,50L,49L,57L,56L,55L,54L,60L,59L,58L,62L,61L,65L,64L,63L,69L,68L,67L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227741Inst : IEnumerable<long>
{
public static readonly long[] Value=A227741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227741.Bytes);
public long this[int i]=>Value[i];

public static A227741Inst Instance=new A227741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227742
{
public static readonly long[] Value={ 1L,4L,8L,12L,16L,23L,28L,32L,36L,43L,51L,59L,64L,71L,76L,80L,84L,91L,99L,107L,115L,126L,135L,143L,148L,155L,163L,171L,176L,183L,188L,192L,196L,203L,211L,219L,227L,238L,247L,255L,263L,274L,286L,298L,307L,318L,327L,335L,340L,347L,355L,363L,371L,382L,391L,399L,404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227742Inst : IEnumerable<long>
{
public static readonly long[] Value=A227742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227742.Bytes);
public long this[int i]=>Value[i];

public static A227742Inst Instance=new A227742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227743
{
public static readonly long[] Value={ 0L,1L,3L,5L,47L,54L,79L,85L,92L,102L,111L,155L,165L,196L,209L,220L,255L,284L,297L,346L,373L,464L,511L,533L,745L,842L,1039L,1066L,1210L,1358L,1505L,1540L,1577L,1728L,1796L,1947L,2196L,3034L,3087L,3615L,3974L,4036L,4113L,4372L,4740L,5050L,5107L,5632L,5870L,6159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227743Inst : IEnumerable<long>
{
public static readonly long[] Value=A227743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227743.Bytes);
public long this[int i]=>Value[i];

public static A227743Inst Instance=new A227743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227744
{
public static readonly long[] Value={ 0L,1L,4L,9L,144L,169L,256L,289L,324L,361L,400L,576L,625L,784L,841L,900L,1024L,1156L,1225L,1521L,1681L,2116L,2304L,2401L,3721L,4225L,5184L,5329L,6241L,7225L,8281L,8464L,8649L,9604L,10000L,10816L,12100L,18225L,18496L,21904L,24025L,24336L,24649L,26244L,28900L,31329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227744Inst : IEnumerable<long>
{
public static readonly long[] Value=A227744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227744.Bytes);
public long this[int i]=>Value[i];

public static A227744Inst Instance=new A227744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227745
{
public static readonly long[] Value={ 0L,1L,2L,3L,12L,13L,16L,17L,18L,19L,20L,24L,25L,28L,29L,30L,32L,34L,35L,39L,41L,46L,48L,49L,61L,65L,72L,73L,79L,85L,91L,92L,93L,98L,100L,104L,110L,135L,136L,148L,155L,156L,157L,162L,170L,177L,178L,190L,195L,200L,206L,207L,208L,209L,213L,214L,226L,228L,247L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227745Inst : IEnumerable<long>
{
public static readonly long[] Value=A227745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227745.Bytes);
public long this[int i]=>Value[i];

public static A227745Inst Instance=new A227745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227746
{
public static readonly BigInteger[] Value={ 2L,13L,210L,10092L,1378923L,536234494L,593219255593L,1866485946679255L,16707964949615383863UL,BigInteger.Parse("425495289603079437453771"),BigInteger.Parse("30826893520750966059187346452") };
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
public class A227746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227746Inst Instance=new A227746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227747
{
public static readonly long[] Value={ 4L,13L,40L,129L,409L,1300L,4137L,13152L,41825L,133009L,422964L,1345045L,4277288L,13601889L,43254441L,137550436L,437414545L,1390991616L,4423395649L,14066532769L,44732002468L,142249129309L,452356561000L,1438507633089L,4574498058553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227747Inst : IEnumerable<long>
{
public static readonly long[] Value=A227747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227747.Bytes);
public long this[int i]=>Value[i];

public static A227747Inst Instance=new A227747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227748
{
public static readonly long[] Value={ 7L,40L,210L,1122L,6002L,32114L,171759L,918746L,4914405L,26287020L,140609297L,752118530L,4023077949L,21519427103L,115107316893L,615708512376L,3293422046623L,17616499557546L,94230576122959L,504038923797692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227748Inst : IEnumerable<long>
{
public static readonly long[] Value=A227748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227748.Bytes);
public long this[int i]=>Value[i];

public static A227748Inst Instance=new A227748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227749
{
public static readonly long[] Value={ 13L,129L,1122L,10092L,90881L,817897L,7363367L,66282981L,596664236L,5371092567L,48349664362L,435235707529L,3917920494766L,35268475932174L,317481024485129L,2857912000299502L,25726454110486757L,231585311593846637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227749Inst : IEnumerable<long>
{
public static readonly long[] Value=A227749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227749.Bytes);
public long this[int i]=>Value[i];

public static A227749Inst Instance=new A227749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227750
{
public static readonly ulong[] Value={ 24L,409L,6002L,90881L,1378923L,20935625L,317839952L,4824746883L,73241810146L,1111840502498L,16878162167610L,256217101254446L,3889475171157074L,59043746368678100L,896307041512584467L,13606289568286192979UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227750Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A227750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227750.Bytes);
public ulong this[int i]=>Value[i];

public static A227750Inst Instance=new A227750Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227751
{
public static readonly long[] Value={ 2L,4L,4L,7L,13L,7L,13L,40L,40L,13L,24L,129L,210L,129L,24L,44L,409L,1122L,1122L,409L,44L,81L,1300L,6002L,10092L,6002L,1300L,81L,149L,4137L,32114L,90881L,90881L,32114L,4137L,149L,274L,13152L,171759L,817897L,1378923L,817897L,171759L,13152L,274L,504L,41825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227751Inst : IEnumerable<long>
{
public static readonly long[] Value=A227751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227751.Bytes);
public long this[int i]=>Value[i];

public static A227751Inst Instance=new A227751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227752
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,0L,1L,2L,1L,2L,1L,1L,1L,0L,2L,0L,0L,0L,1L,2L,2L,0L,2L,2L,1L,2L,1L,1L,1L,1L,2L,1L,0L,1L,2L,1L,0L,0L,0L,1L,0L,1L,1L,2L,2L,1L,3L,1L,0L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,2L,1L,0L,1L,2L,2L,0L,0L,0L,2L,0L,2L,2L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227752Inst : IEnumerable<long>
{
public static readonly long[] Value=A227752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227752.Bytes);
public long this[int i]=>Value[i];

public static A227752Inst Instance=new A227752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227753
{
public static readonly long[] Value={ 5L,10L,18L,20L,21L,22L,26L,37L,41L,42L,43L,45L,53L,69L,73L,74L,75L,77L,81L,82L,83L,84L,85L,86L,87L,89L,90L,91L,93L,101L,105L,106L,107L,109L,117L,138L,146L,148L,149L,150L,154L,162L,164L,165L,166L,168L,169L,170L,171L,172L,173L,174L,178L,180L,181L,182L,186L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227753Inst : IEnumerable<long>
{
public static readonly long[] Value=A227753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227753.Bytes);
public long this[int i]=>Value[i];

public static A227753Inst Instance=new A227753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227754
{
public static readonly long[] Value={ 459L,2023L,5063L,11111L,87615L,92080L,224720L,268191L,390224L,524799L,535601L,680096L,758848L,1144375L,1235168L,1303169L,1319297L,1366000L,1525568L,2570291L,2985620L,3085874L,3090969L,3297096L,4100071L,4507524L,5695742L,5812158L,5869968L,6324725L,6540544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227754Inst : IEnumerable<long>
{
public static readonly long[] Value=A227754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227754.Bytes);
public long this[int i]=>Value[i];

public static A227754Inst Instance=new A227754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227755
{
public static readonly long[] Value={ 735L,2172L,3484L,6324L,6747L,6867L,7424L,7865L,14012L,14640L,35321L,39284L,42172L,47724L,57075L,60155L,63664L,89975L,104923L,105412L,113283L,114204L,149144L,151959L,153924L,155708L,176860L,189780L,221705L,230124L,244035L,250995L,327700L,349811L,351075L,357752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227755Inst : IEnumerable<long>
{
public static readonly long[] Value=A227755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227755.Bytes);
public long this[int i]=>Value[i];

public static A227755Inst Instance=new A227755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227756
{
public static readonly long[] Value={ 23L,29L,41L,53L,101L,113L,137L,173L,257L,281L,317L,353L,401L,617L,641L,653L,677L,761L,821L,941L,977L,1181L,1193L,1361L,1373L,1433L,1613L,1697L,1877L,1901L,2081L,2153L,2237L,2273L,2297L,2333L,2381L,2633L,2657L,2693L,2741L,2777L,2801L,3137L,3413L,3461L,3557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227756Inst : IEnumerable<long>
{
public static readonly long[] Value=A227756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227756.Bytes);
public long this[int i]=>Value[i];

public static A227756Inst Instance=new A227756Inst();

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