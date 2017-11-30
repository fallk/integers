using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A159505
{
public static readonly BigInteger[] Value={ 1L,22L,146L,-11660L,-404564L,6863912L,834719224L,4443809392L,-1877181877360L,-53314061897888L,4537477909175584L,280026043216724288L,BigInteger.Parse("-10709769915546886976"),BigInteger.Parse("-1371400569429065225600"),BigInteger.Parse("16887916481473586409344"),BigInteger.Parse("6861001657130755548544768"),BigInteger.Parse("65320299895805538972610816") };
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
public class A159505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159505Inst Instance=new A159505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159506
{
public static readonly BigInteger[] Value={ 1L,24L,238L,-10512L,-493620L,2365344L,890986056L,16586747712L,-1709991063408L,-85890351335040L,3140424382846176L,365679572700743424L,-2899788110604240192L,BigInteger.Parse("-1552791261528717092352"),BigInteger.Parse("-24525321318694178812800"),BigInteger.Parse("6759200537905228989502464"),BigInteger.Parse("286564191995504982328955136") };
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
public class A159506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159506Inst Instance=new A159506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159507
{
public static readonly BigInteger[] Value={ 1L,1L,-97L,-293L,28225L,143081L,-13687169L,-97818797L,9291579137L,85981515985L,-8109191282849L,-92371076948149L,8649337125963073L,117277723616986297L,BigInteger.Parse("-10901977774859968705"),BigInteger.Parse("-171807014577365168189"),BigInteger.Parse("15854100314466788828161"),BigInteger.Parse("285247499171775372548513") };
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
public class A159507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159507Inst Instance=new A159507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159508
{
public static readonly BigInteger[] Value={ 1L,3L,-89L,-855L,23601L,405963L,-10346601L,-269746047L,6288530145L,230346491283L,-4855444114041L,-240305893799463L,4513251073537809L,296139484328781915L,-4861463414700822921L,BigInteger.Parse("-420887762743191256143"),BigInteger.Parse("5883687931380635925441"),BigInteger.Parse("677603075775465797408547") };
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
public class A159508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159508Inst Instance=new A159508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159509
{
public static readonly BigInteger[] Value={ 1L,5L,-73L,-1345L,14737L,600925L,-4216505L,-374426425L,1020390305L,298652268725L,593277094615L,-289712837877425L,-2088116897382095L,330261712856941325L,4311569491549495655L,BigInteger.Parse("-431561222581976019625"),BigInteger.Parse("-8495813265487638710975"),BigInteger.Parse("634208930681100205217125") };
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
public class A159509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159509Inst Instance=new A159509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159510
{
public static readonly BigInteger[] Value={ 1L,9L,-17L,-1917L,-12255L,641169L,11775471L,-271028133L,-10517226303L,117831019545L,10336672775151L,-22444344177741L,-11344932349212447L,-75709842389888607L,13772055231387660015UL,BigInteger.Parse("227822400841416108939"),BigInteger.Parse("-18194519582567115241599") };
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
public class A159510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159510Inst Instance=new A159510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159511
{
public static readonly BigInteger[] Value={ 1L,11L,23L,-1903L,-27695L,441331L,18425191L,-56825527L,-13264761823L,-101361166885L,10584547092151L,215763961560961L,-9036738188168207L,-353142538865540413L,7628236524205351175L,BigInteger.Parse("568422165089780309561"),BigInteger.Parse("-4960863874594282822079") };
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
public class A159511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159511Inst Instance=new A159511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159512
{
public static readonly BigInteger[] Value={ 1L,13L,71L,-1625L,-41999L,91013L,21762679L,229399183L,-11947008415L,-335160068867L,6180180526759L,408799214337527L,-1347844821458351L,-498269858739890315L,-4760353861080634921L,BigInteger.Parse("621741645997081258207"),BigInteger.Parse("15080361573750589690561") };
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
public class A159512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159512Inst Instance=new A159512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159513
{
public static readonly BigInteger[] Value={ 1L,2L,-446L,-2692L,596716L,6039032L,-1330532936L,-18966452272L,4153245843856L,76585719866912L,-16667474227882976L,-377970687856869952L,BigInteger.Parse("81748056052306991296"),BigInteger.Parse("2204537826531711723392"),BigInteger.Parse("-473817052252932475634816"),BigInteger.Parse("-14836222411655648808639232"),BigInteger.Parse("3168592657883982912917729536") };
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
public class A159513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159513Inst Instance=new A159513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159514
{
public static readonly BigInteger[] Value={ 1L,4L,-434L,-5336L,564556L,11863024L,-1222798904L,-36921360416L,3704131105936L,147733421921344L,-14410797291355424L,-722443587811469696L,BigInteger.Parse("68443672240963470016"),BigInteger.Parse("4174970063145790238464"),BigInteger.Parse("-383695602357053138639744"),BigInteger.Parse("-27837093807246691056882176"),BigInteger.Parse("2478596940681121921590743296") };
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
public class A159514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159514Inst Instance=new A159514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159515
{
public static readonly BigInteger[] Value={ 1L,8L,-386L,-10288L,438796L,22028768L,-811060856L,-65966160448L,2027112412816L,253695076915328L,-6180244656582176L,-1191069803371633408L,BigInteger.Parse("21063652623108703936"),BigInteger.Parse("6600286159191690034688"),BigInteger.Parse("-70420078571652397748096"),BigInteger.Parse("-42145163431480866400519168"),BigInteger.Parse("138174222906806753595494656") };
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
public class A159515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159515Inst Instance=new A159515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159516
{
public static readonly BigInteger[] Value={ 1L,14L,-254L,-16156L,116716L,30714824L,167396536L,-80586473296L,-1655509714544L,266934167861984L,10441892693970976L,-1055017257663334336L,BigInteger.Parse("-66457610442443011904"),BigInteger.Parse("4766686645187803247744"),BigInteger.Parse("455510634120920865106816"),BigInteger.Parse("-23652976986990268349291776") };
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
public class A159516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159516Inst Instance=new A159516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159517
{
public static readonly BigInteger[] Value={ 1L,16L,-194L,-17504L,-18164L,31216576L,540334216L,-75639407744L,-2912283304304L,225705335009536L,15406032742583776L,-769177483661571584L,BigInteger.Parse("-88566701814374836544"),BigInteger.Parse("2736491182742489168896"),BigInteger.Parse("561899064537972620484736"),BigInteger.Parse("-8249509418670119836289024") };
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
public class A159517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159517Inst Instance=new A159517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159518
{
public static readonly BigInteger[] Value={ 1L,22L,34L,-19052L,-465044L,24062632L,1575726904L,-30303114512L,-5630208266864L,-14773369627808L,22477329348987424L,560981409002859328L,BigInteger.Parse("-98921189279424843584"),BigInteger.Parse("-5205565772762786930048"),BigInteger.Parse("464166510283854022505344"),BigInteger.Parse("43006727594650346154419968") };
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
public class A159518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159518Inst Instance=new A159518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159519
{
public static readonly BigInteger[] Value={ 1L,26L,226L,-17524L,-760724L,11764376L,2017502776L,20691256976L,-5817161063024L,-225734712752224L,17690399773689376L,1475756601500931776L,BigInteger.Parse("-49197807240738185024"),BigInteger.Parse("-9248228636364224401024"),BigInteger.Parse("47353227812848547963776"),BigInteger.Parse("59495024332228675973509376") };
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
public class A159519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159519Inst Instance=new A159519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159520
{
public static readonly BigInteger[] Value={ 1L,28L,334L,-15848L,-894644L,3476368L,2110287304L,49701850912L,-5255753182064L,-326087752380992L,12155343320691424L,1807744498693823872L,BigInteger.Parse("-9552103473995480384"),BigInteger.Parse("-10029279190218522359552"),BigInteger.Parse("-224940012003245065821056"),BigInteger.Parse("56886138562285829022188032") };
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
public class A159520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159520Inst Instance=new A159520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159521
{
public static readonly BigInteger[] Value={ 1L,1L,-127L,-383L,48385L,244481L,-30721919L,-218483327L,27308356097L,251035282945L,-31208190940799L,-352533353110399L,43588599491534593L,585079829869107457L,BigInteger.Parse("-71946349724044455295"),BigInteger.Parse("-1120409404849485018239"),BigInteger.Parse("137016582065315869148161") };
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
public class A159521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159521Inst Instance=new A159521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159522
{
public static readonly BigInteger[] Value={ 1L,3L,-119L,-1125L,42321L,702963L,-24976551L,-614805237L,20534573985L,691164284643L,-21582336376791L,-949437293473413L,27539617738101489L,1540954535989466835L,BigInteger.Parse("-41203060308232477191"),BigInteger.Parse("-2884999709417821999893"),BigInteger.Parse("70454876663552890207041") };
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
public class A159522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159522Inst Instance=new A159522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159523
{
public static readonly BigInteger[] Value={ 1L,5L,-103L,-1795L,30577L,1071925L,-14209655L,-894286675L,8260417505L,957051642725L,-4730742752135L,-1248679816448675L,417486712762705L,1920059631628978325L,8905600268107750505L,BigInteger.Parse("-3396218858538590405875"),BigInteger.Parse("-34079846807459832998975") };
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
public class A159523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159523Inst Instance=new A159523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159524
{
public static readonly BigInteger[] Value={ 1L,7L,-79L,-2345L,13921L,1298087L,177169L,-995690633L,-7128577855L,969687163207L,14999931831409L,-1136200046085097L,-29073304341219551L,1541690140398172135L,BigInteger.Parse("59169809406576537809"),BigInteger.Parse("-2348520065747488701257"),BigInteger.Parse("-130045674520859373502079"),BigInteger.Parse("3899449373004841245659783") };
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
public class A159524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159524Inst Instance=new A159524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159525
{
public static readonly BigInteger[] Value={ 1L,9L,-47L,-2727L,-6495L,1337769L,16196721L,-881636103L,-22446986943L,700772486985L,32165881341201L,-607495851269991L,-50757023589840927L,476300415242137833L,BigInteger.Parse("88746390990674543025"),BigInteger.Parse("-54812825197840109511"),BigInteger.Parse("-170886386128875683593599") };
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
public class A159525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159525Inst Instance=new A159525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159526
{
public static readonly BigInteger[] Value={ 1L,11L,-7L,-2893L,-29135L,1160731L,31414441L,-545882557L,-34152047263L,183311218475L,41359581850201L,220317040704211L,-55810803797336687L,-952325816292371653L,BigInteger.Parse("82393593539552158985"),BigInteger.Parse("2612897391731003751011"),BigInteger.Parse("-129453828286899103990079") };
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
public class A159526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159526Inst Instance=new A159526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159527
{
public static readonly BigInteger[] Value={ 1L,13L,41L,-2795L,-52079L,754013L,43132729L,-18356507L,-38885559775L,-486715213907L,38468867080009L,1123090745841077L,-39563985152718671L,-2239399192597236995L,BigInteger.Parse("36722281790359787609"),BigInteger.Parse("4490393016408925933957"),BigInteger.Parse("-12131671824174755067839") };
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
public class A159527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159527Inst Instance=new A159527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159528
{
public static readonly BigInteger[] Value={ 1L,15L,97L,-2385L,-73023L,125775L,48621345L,632724975L,-34073850495L,-1159018131825L,21867803792865L,1811560265628975L,-3616463755919295L,-2836803524344895025L,BigInteger.Parse("-36534257175323718495"),BigInteger.Parse("4535538057996196107375"),BigInteger.Parse("138178844646564481121025") };
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
public class A159528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159528Inst Instance=new A159528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159529
{
public static readonly BigInteger[] Value={ 1L,2L,-574L,-3460L,988396L,9976312L,-2836511816L,-40270873648L,11395985060240L,209004489868832L,-58863905303630816L,-1325773762049110592L,BigInteger.Parse("371605162396386506944"),BigInteger.Parse("9938777138365404080000"),BigInteger.Parse("-2772363635969717405017216"),BigInteger.Parse("-85969311875592284625394432"),BigInteger.Parse("23864454100106265332248473856") };
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
public class A159529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159529Inst Instance=new A159529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159530
{
public static readonly BigInteger[] Value={ 1L,4L,-562L,-6872L,947020L,19676144L,-2658183224L,-78869600288L,10439530923152L,406451155424320L,-52680635240539424L,-2560010219314727296L,BigInteger.Parse("324703437982090748608"),BigInteger.Parse("19055044633095311519488"),BigInteger.Parse("-2363601454465048638962560"),BigInteger.Parse("-163647826988867455371547136") };
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
public class A159530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159530Inst Instance=new A159530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159531
{
public static readonly BigInteger[] Value={ 1L,6L,-542L,-10188L,878700L,28826856L,-2366481864L,-114170427792L,8889763054992L,581262636440160L,-42756971593427424L,-3616239868184689344L,BigInteger.Parse("250151386181903425728"),BigInteger.Parse("26583148042820425844352"),BigInteger.Parse("-1720138627513899785854080"),BigInteger.Parse("-225431665727586284647620864") };
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
public class A159531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159531Inst Instance=new A159531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159532
{
public static readonly BigInteger[] Value={ 1L,8L,-514L,-13360L,784396L,37163488L,-1969596536L,-144639748672L,6811869595280L,723309154621568L,-29648872397674016L,-4417917892894055168L,BigInteger.Parse("153164187561258952384"),BigInteger.Parse("31867992005603238264320"),BigInteger.Parse("-895931769290473862098816"),BigInteger.Parse("-265043245463665194931667968") };
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
public class A159532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159532Inst Instance=new A159532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159533
{
public static readonly BigInteger[] Value={ 1L,10L,-478L,-16340L,665452L,44432600L,-1478830280L,-168880559600L,4294541716880L,823849124759200L,-14101714763617760L,-4902865088744353600L,BigInteger.Parse("40630051579638182080"),BigInteger.Parse("34412572771327218390400"),BigInteger.Parse("38831520143870883754880"),BigInteger.Parse("-278078223664141142377568000") };
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
public class A159533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159533Inst Instance=new A159533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159534
{
public static readonly BigInteger[] Value={ 1L,12L,-434L,-19080L,523596L,50396112L,-908439096L,-185674985568L,1447444755600L,875930470333632L,2981558025372384L,-5027099422223924352L,BigInteger.Parse("-79281938992004709696"),BigInteger.Parse("33916578324641082789120"),BigInteger.Parse("1002723429481616382125184"),BigInteger.Parse("-262420270649216245344056832") };
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
public class A159534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159534Inst Instance=new A159534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159535
{
public static readonly BigInteger[] Value={ 1L,14L,-382L,-21532L,360940L,54835144L,-275424584L,-194024223568L,-1601971263088L,874740412095200L,20579820279916576L,-4767882097991423936L,BigInteger.Parse("-197596846711589525312"),BigInteger.Parse("30303674377706263065728"),BigInteger.Parse("1908994147478771376114560"),BigInteger.Parse("-218491414999696281462267136") };
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
public class A159535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159535Inst Instance=new A159535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159536
{
public static readonly BigInteger[] Value={ 1L,16L,-322L,-23648L,179980L,57553856L,400719496L,-193185260672L,-4712275251568L,817892241322240L,37599531719812576L,-4125824647325545984L,BigInteger.Parse("-305071017031777093952"),BigInteger.Parse("23735583481341553441792"),BigInteger.Parse("2672072957678237939024000"),BigInteger.Parse("-149315174208164043426596864") };
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
public class A159536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159536Inst Instance=new A159536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159537
{
public static readonly BigInteger[] Value={ 1L,18L,-254L,-25380L,-16404L,58383288L,1098306744L,-182703721392L,-7732416071280L,705638518433568L,52925521734602784L,-3125931245323172928L,BigInteger.Parse("-392767229604421613376"),BigInteger.Parse("14611648984681938387840"),BigInteger.Parse("3214262644971898893888384"),BigInteger.Parse("-60380735974552065344410368") };
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
public class A159537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159537Inst Instance=new A159537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159538
{
public static readonly BigInteger[] Value={ 1L,20L,-178L,-26680L,-224948L,57185200L,1793803720L,-162442199200L,-10506573835120L,541001252398400L,65475222138262240L,-1817482796097507200L,BigInteger.Parse("-452641118277021465920"),BigInteger.Parse("3553238308191880620800"),BigInteger.Parse("3472210128897376907338880"),BigInteger.Parse("40691398188058840163264000") };
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
public class A159538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159538Inst Instance=new A159538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159539
{
public static readonly BigInteger[] Value={ 1L,22L,-94L,-27500L,-442004L,53855912L,2462221624L,-132603427088L,-12879424086640L,329810916948832L,74254604271575584L,-272705805989586112L,BigInteger.Parse("-478110301690448457536"),BigInteger.Parse("-8626939166846096792960"),BigInteger.Parse("3402728145231415580480384"),BigInteger.Parse("144669210933209758019200768") };
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
public class A159539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159539Inst Instance=new A159539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159540
{
public static readonly BigInteger[] Value={ 1L,24L,-2L,-27792L,-663540L,48330144L,3077554056L,-93747642048L,-14701727119728L,80647645956480L,78413927979780576L,1415790877886279424L,BigInteger.Parse("-464576773026174196032"),BigInteger.Parse("-20969768081647414789632"),BigInteger.Parse("2987555438559134954033280"),BigInteger.Parse("241388693842110119374500864") };
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
public class A159540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159540Inst Instance=new A159540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159541
{
public static readonly BigInteger[] Value={ 1L,26L,98L,-27508L,-885140L,40584856L,3613260856L,-46803498352L,-15836144380528L,-195320377514080L,77301293252140576L,3138785406587037376L,BigInteger.Parse("-409873201925846810432"),BigInteger.Parse("-32427318830159708311168"),BigInteger.Parse("2236676949686660517495680"),BigInteger.Parse("320555464665505533108859136") };
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
public class A159541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159541Inst Instance=new A159541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159542
{
public static readonly BigInteger[] Value={ 1L,28L,206L,-26600L,-1102004L,30643088L,4042798024L,6928115488L,-16163173571440L,-484604466016832L,70511903870159584L,4775347121941757312L,BigInteger.Parse("-314604965392105430336"),BigInteger.Parse("-41930746668766980765440"),BigInteger.Parse("1189880803230804742112384"),BigInteger.Parse("372620264534124941133087232") };
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
public class A159542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159542Inst Instance=new A159542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159543
{
public static readonly BigInteger[] Value={ 1L,30L,322L,-25020L,-1308948L,18577800L,4340193720L,65778001200L,-15587083755120L,-771769990202400L,57930909988062240L,6198757843011739200L,BigInteger.Parse("-182361990413747545920"),BigInteger.Parse("-48465444111541849468800"),BigInteger.Parse("-83695327377356424021120"),BigInteger.Parse("389671513929275953180896000") };
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
public class A159543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159543Inst Instance=new A159543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159544
{
public static readonly BigInteger[] Value={ 1L,32L,446L,-22720L,-1500404L,4515712L,4480670344L,127720961792L,-14041721434480L,-1039916813229568L,39767696878818784L,7283285480589104128L,BigInteger.Parse("-19777881376678496576"),BigInteger.Parse("-51149760297419738122240"),BigInteger.Parse("-1488181328853069396639616"),BigInteger.Parse("366282057803422300192698368") };
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
public class A159544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159544Inst Instance=new A159544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159545
{
public static readonly BigInteger[] Value={ 1L,1L,-161L,-485L,77761L,392041L,-62594369L,-443658221L,70538356225L,645519410641L,-102199403965409L,-1147940849203829L,180971397017155009L,2412568407869398585L,BigInteger.Parse("-378713193710259050369"),BigInteger.Parse("-5850418342758055041149"),BigInteger.Parse("914422642373171437355521") };
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
public class A159545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159545Inst Instance=new A159545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159546
{
public static readonly BigInteger[] Value={ 1L,5L,-137L,-2305L,55057L,1768925L,-35751545L,-1898152825L,31051487905L,2615263500725L,-32196751861865L,-4397710630483825L,35386058665424305L,8726079758987677325L,BigInteger.Parse("-30892640754445199705"),BigInteger.Parse("-19945212097156278171625"),BigInteger.Parse("-24656943452479555574975") };
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
public class A159546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159546Inst Instance=new A159546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159547
{
public static readonly long[] Value={ 2L,5L,10L,17L,26L,37L,50L,65L,82L,2L,3L,5L,10L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159547Inst : IEnumerable<long>
{
public static readonly long[] Value=A159547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159547.Bytes);
public long this[int i]=>Value[i];

public static A159547Inst Instance=new A159547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159548
{
public static readonly long[] Value={ 181L,199L,221L,865L,995L,1145L,5009L,5771L,6649L,29189L,33631L,38749L,170125L,196015L,225845L,991561L,1142459L,1316321L,5779241L,6658739L,7672081L,33683885L,38809975L,44716165L,196324069L,226201111L,260624909L,1144260529L,1318396691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159548Inst : IEnumerable<long>
{
public static readonly long[] Value=A159548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159548.Bytes);
public long this[int i]=>Value[i];

public static A159548Inst Instance=new A159548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159549
{
public static readonly long[] Value={ 1L,1L,5L,2L,1L,8L,2L,2L,6L,7L,5L,7L,5L,1L,8L,5L,4L,3L,2L,0L,4L,0L,3L,7L,0L,7L,2L,6L,0L,5L,1L,2L,2L,5L,9L,3L,7L,5L,4L,4L,6L,9L,0L,6L,4L,0L,7L,4L,1L,4L,0L,1L,8L,1L,6L,3L,9L,9L,6L,6L,6L,3L,0L,5L,3L,2L,5L,7L,0L,1L,7L,5L,6L,6L,2L,9L,3L,5L,7L,4L,9L,1L,3L,4L,1L,7L,4L,7L,4L,9L,0L,8L,8L,7L,2L,0L,0L,1L,5L,8L,0L,6L,3L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159549Inst : IEnumerable<long>
{
public static readonly long[] Value=A159549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159549.Bytes);
public long this[int i]=>Value[i];

public static A159549Inst Instance=new A159549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159550
{
public static readonly long[] Value={ 4L,3L,9L,0L,4L,4L,9L,6L,0L,5L,8L,7L,4L,3L,1L,4L,4L,2L,7L,2L,6L,8L,5L,0L,3L,8L,8L,1L,8L,3L,1L,0L,0L,4L,8L,5L,8L,8L,4L,6L,9L,3L,8L,6L,1L,8L,7L,3L,9L,9L,1L,2L,8L,2L,0L,4L,0L,5L,6L,2L,7L,3L,4L,5L,0L,0L,5L,8L,2L,9L,9L,1L,1L,1L,0L,6L,5L,0L,0L,4L,0L,2L,4L,7L,1L,6L,1L,1L,4L,8L,1L,4L,1L,9L,2L,4L,7L,1L,4L,3L,8L,1L,3L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159550Inst : IEnumerable<long>
{
public static readonly long[] Value=A159550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159550.Bytes);
public long this[int i]=>Value[i];

public static A159550Inst Instance=new A159550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159551
{
public static readonly long[] Value={ 10L,111L,212L,313L,414L,515L,616L,717L,818L,919L,1020L,1121L,1222L,1323L,1424L,1525L,1626L,1727L,1828L,1929L,2030L,2131L,2232L,2333L,2434L,2535L,2636L,2737L,2838L,2939L,3040L,3141L,3242L,3343L,3444L,3545L,3646L,3747L,3848L,3949L,4050L,4151L,4252L,4353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159551Inst : IEnumerable<long>
{
public static readonly long[] Value=A159551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159551.Bytes);
public long this[int i]=>Value[i];

public static A159551Inst Instance=new A159551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159552
{
public static readonly BigInteger[] Value={ 1L,7L,-113L,-3059L,33505L,2216767L,-11621681L,-2236049291L,-2473358783L,2880606369655L,23770401693199L,-4500189506988707L,-73860182366201567L,8231347125022635439L,BigInteger.Parse("213168973938378948175"),BigInteger.Parse("-17176512461982684538427"),BigInteger.Parse("-638236193904139635834239") };
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
public class A159552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159552Inst Instance=new A159552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159553
{
public static readonly long[] Value={ 2L,6L,12L,28L,40L,144L,140L,536L,864L,2560L,2068L,12720L,8216L,45192L,78660L,182832L,131104L,933984L,524324L,3698240L,4890648L,13345816L,8388652L,67390464L,60129600L,225470544L,279938160L,1032462256L,536870968L,5018059200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159553Inst : IEnumerable<long>
{
public static readonly long[] Value=A159553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159553.Bytes);
public long this[int i]=>Value[i];

public static A159553Inst Instance=new A159553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159554
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,24L,20L,67L,96L,256L,188L,1060L,632L,3228L,5244L,11427L,7712L,51888L,27596L,184912L,232888L,606628L,364724L,2807936L,2405184L,8671944L,10368080L,36873652L,18512792L,167268640L,69273668L,496472227L,551130064L,1856103040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159554Inst : IEnumerable<long>
{
public static readonly long[] Value=A159554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159554.Bytes);
public long this[int i]=>Value[i];

public static A159554Inst Instance=new A159554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159555
{
public static readonly long[] Value={ 1L,6L,22L,72L,114L,148L,164L,260L,261L,780L,1078L,1184L,1266L,2952L,4674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159555Inst : IEnumerable<long>
{
public static readonly long[] Value=A159555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159555.Bytes);
public long this[int i]=>Value[i];

public static A159555Inst Instance=new A159555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159556
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,13L,15L,16L,18L,20L,21L,23L,89L,91L,92L,94L,96L,97L,99L,102L,104L,105L,107L,109L,110L,112L,233L,235L,236L,238L,240L,241L,243L,246L,248L,249L,251L,253L,254L,256L,322L,324L,325L,327L,329L,330L,332L,335L,337L,338L,340L,342L,343L,345L,1597L,1599L,1600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159556Inst : IEnumerable<long>
{
public static readonly long[] Value=A159556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159556.Bytes);
public long this[int i]=>Value[i];

public static A159556Inst Instance=new A159556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159557
{
public static readonly long[] Value={ 4L,6L,26L,80L,246L,810L,2704L,9252L,32066L,112720L,400024L,1432860L,5170604L,18784170L,68635478L,252088496L,930138522L,3446167860L,12815663844L,47820447028L,178987624514L,671825133648L,2528212128776L,9536895064400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159557Inst : IEnumerable<long>
{
public static readonly long[] Value=A159557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159557.Bytes);
public long this[int i]=>Value[i];

public static A159557Inst Instance=new A159557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159558
{
public static readonly BigInteger[] Value={ 1L,2L,10L,204L,18326L,7157436L,11867138452L,81971848887192L,2329289249771718630L,BigInteger.Parse("270079267572894401313900"),BigInteger.Parse("127115660247624311548253487740"),BigInteger.Parse("242023658005438716992830183038644712") };
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
public class A159558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159558Inst Instance=new A159558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159559
{
public static readonly long[] Value={ 3L,5L,6L,7L,8L,11L,12L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,29L,30L,32L,33L,37L,38L,39L,40L,42L,44L,47L,48L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,67L,68L,71L,72L,74L,75L,79L,80L,81L,82L,84L,85L,89L,90L,91L,92L,93L,94L,97L,98L,101L,102L,104L,105L,106L,108L,109L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159559Inst : IEnumerable<long>
{
public static readonly long[] Value=A159559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159559.Bytes);
public long this[int i]=>Value[i];

public static A159559Inst Instance=new A159559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159560
{
public static readonly long[] Value={ 3L,4L,5L,7L,10L,11L,13L,16L,18L,19L,20L,23L,24L,26L,27L,29L,33L,37L,38L,39L,40L,41L,44L,47L,48L,49L,50L,53L,60L,61L,64L,65L,68L,69L,72L,73L,74L,75L,76L,79L,84L,89L,91L,92L,93L,97L,98L,101L,104L,106L,108L,109L,111L,112L,115L,116L,117L,121L,126L,127L,129L,133L,137L,141L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159560Inst : IEnumerable<long>
{
public static readonly long[] Value=A159560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159560.Bytes);
public long this[int i]=>Value[i];

public static A159560Inst Instance=new A159560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159561
{
public static readonly BigInteger[] Value={ 1L,11L,-41L,-4015L,-24239L,2335091L,45319591L,-1771192951L,-70875538655L,1515835139291L,120010721891191L,-1135534984848319L,-226349991243433871L,-282369893132640445L,BigInteger.Parse("473587012734212687431"),BigInteger.Parse("5849872057701168091001"),BigInteger.Parse("-1086467848309423981456319") };
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
public class A159561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159561Inst Instance=new A159561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159562
{
public static readonly BigInteger[] Value={ 1L,13L,7L,-4121L,-56975L,1929733L,71236279L,-949628849L,-93127115423L,20066487805L,136040198628199L,1736014871922487L,-219855440620458287L,-6232933639083272459L,BigInteger.Parse("381987420638602610455"),BigInteger.Parse("19102129961742695872927"),BigInteger.Parse("-679901742649149297057599") };
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
public class A159562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159562Inst Instance=new A159562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159563
{
public static readonly BigInteger[] Value={ 1L,17L,127L,-3349L,-118655L,153017L,98711839L,1529368739L,-85939956863L,-3443041152415L,66768757515199L,6712795544670683L,-4864401632683007L,BigInteger.Parse("-13132369366595418871"),BigInteger.Parse("-213005849393691708065"),BigInteger.Parse("26163114283745650962323"),BigInteger.Parse("962377156850346916957441") };
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
public class A159563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159563Inst Instance=new A159563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159564
{
public static readonly BigInteger[] Value={ 1L,2L,-718L,-4324L,1546540L,15580792L,-5551847816L,-78599686576L,27901839488912L,509795468640800L,-180286562061668576L,-4041296407709913152L,BigInteger.Parse("1423753283078352004288"),BigInteger.Parse("37861298642555391557504"),BigInteger.Parse("-13287625717688301129132160"),BigInteger.Parse("-409277258114326500121514752") };
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
public class A159564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159564Inst Instance=new A159564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159565
{
public static readonly long[] Value={ 221L,241L,265L,1061L,1205L,1369L,6145L,6989L,7949L,35809L,40729L,46325L,208709L,237385L,270001L,1216445L,1383581L,1573681L,7089961L,8064101L,9172085L,41323321L,47001025L,53458829L,240849965L,273942049L,311580889L,1403776469L,1596651269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159565Inst : IEnumerable<long>
{
public static readonly long[] Value=A159565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159565.Bytes);
public long this[int i]=>Value[i];

public static A159565Inst Instance=new A159565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159566
{
public static readonly long[] Value={ 1L,1L,3L,7L,3L,9L,7L,0L,8L,8L,6L,8L,1L,3L,6L,1L,3L,7L,3L,7L,4L,9L,5L,3L,1L,7L,5L,0L,7L,5L,7L,7L,3L,1L,7L,7L,4L,8L,0L,7L,1L,8L,9L,9L,6L,3L,7L,2L,7L,3L,5L,6L,2L,5L,5L,6L,4L,2L,6L,8L,4L,4L,5L,7L,4L,0L,9L,9L,4L,2L,3L,8L,3L,9L,2L,6L,0L,0L,1L,4L,7L,2L,4L,2L,6L,1L,7L,6L,4L,5L,5L,4L,1L,5L,8L,0L,1L,3L,0L,5L,3L,9L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159566Inst : IEnumerable<long>
{
public static readonly long[] Value=A159566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159566.Bytes);
public long this[int i]=>Value[i];

public static A159566Inst Instance=new A159566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159567
{
public static readonly long[] Value={ 4L,5L,0L,5L,3L,3L,5L,5L,9L,2L,0L,0L,4L,4L,8L,8L,4L,6L,0L,9L,8L,5L,5L,0L,1L,9L,1L,6L,3L,5L,8L,8L,1L,9L,9L,8L,5L,7L,9L,2L,7L,9L,2L,8L,0L,3L,4L,0L,2L,2L,4L,1L,6L,7L,3L,1L,8L,8L,7L,2L,6L,0L,2L,7L,3L,4L,4L,3L,7L,8L,4L,9L,4L,5L,2L,6L,0L,9L,3L,0L,5L,8L,3L,7L,0L,2L,4L,8L,2L,1L,7L,9L,0L,9L,3L,1L,1L,0L,9L,0L,6L,2L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159567Inst : IEnumerable<long>
{
public static readonly long[] Value=A159567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159567.Bytes);
public long this[int i]=>Value[i];

public static A159567Inst Instance=new A159567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159568
{
public static readonly long[] Value={ 1123564987L,1123586479L,1123869547L,1124356789L,1124378659L,1124685973L,1124698537L,1124753689L,1124763589L,1124785639L,1124879563L,1124895367L,1124896753L,1124956837L,1124978563L,1125347689L,1125386749L,1125398467L,1125487963L,1125648379L,1125748693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159568Inst : IEnumerable<long>
{
public static readonly long[] Value=A159568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159568.Bytes);
public long this[int i]=>Value[i];

public static A159568Inst Instance=new A159568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159569
{
public static readonly long[] Value={ 10123465789L,10123685749L,10123746859L,10123854679L,10123945687L,10123956487L,10124356789L,10124378569L,10124563987L,10124568793L,10124683759L,10124695783L,10124736859L,10124763589L,10124785639L,10124867539L,10124867593L,10124935687L,10125367849L,10125368749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159569Inst : IEnumerable<long>
{
public static readonly long[] Value=A159569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159569.Bytes);
public long this[int i]=>Value[i];

public static A159569Inst Instance=new A159569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159570
{
public static readonly long[] Value={ 0L,1L,5L,1L,1L,5L,20L,1L,13L,2L,1L,1L,61L,1L,1L,2L,4L,1L,3L,1L,2L,1L,5L,1L,13L,1L,11L,7L,6L,2L,77L,7L,1L,5L,4L,8L,1L,1L,6L,4L,2L,1L,1L,2L,4L,1L,1L,2L,1L,3L,1L,1L,6L,6L,1L,7L,1L,10L,1L,1L,4L,1L,4L,2L,1L,7L,1L,4L,1L,2L,17L,2L,2L,1L,5L,2L,1L,2L,1L,1L,1L,3L,3L,1L,1L,6L,1L,1L,16L,3L,1320L,2L,2L,7L,5L,9L,1L,217L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159570Inst : IEnumerable<long>
{
public static readonly long[] Value=A159570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159570.Bytes);
public long this[int i]=>Value[i];

public static A159570Inst Instance=new A159570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159571
{
public static readonly long[] Value={ 6L,39L,138L,364L,804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159571Inst : IEnumerable<long>
{
public static readonly long[] Value=A159571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159571.Bytes);
public long this[int i]=>Value[i];

public static A159571Inst Instance=new A159571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159572
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,5L,2L,1L,10L,14L,12L,6L,1L,15L,30L,39L,39L,20L,1L,21L,55L,95L,138L,142L,71L,1L,28L,91L,195L,364L,548L,551L,270L,1L,36L,140L,357L,804L,1564L,2317L,2278L,1100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159572Inst : IEnumerable<long>
{
public static readonly long[] Value=A159572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159572.Bytes);
public long this[int i]=>Value[i];

public static A159572Inst Instance=new A159572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159573
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,3L,8L,7L,12L,10L,16L,15L,33L,50L,37L,32L,31L,78L,160L,222L,151L,64L,63L,171L,420L,814L,1057L,674L,128L,127L,360L,990L,2368L,4379L,5392L,3263L,256L,255L,741L,2190L,6031L,14043L,24938L,29367L,17007L,512L,511L,1506L,4660L,14134L,38656L,87620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159573Inst : IEnumerable<long>
{
public static readonly long[] Value=A159573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159573.Bytes);
public long this[int i]=>Value[i];

public static A159573Inst Instance=new A159573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159574
{
public static readonly long[] Value={ 313L,337L,365L,1513L,1685L,1877L,8765L,9773L,10897L,51077L,56953L,63505L,297697L,331945L,370133L,1735105L,1934717L,2157293L,10112933L,11276357L,12573625L,58942493L,65723425L,73284457L,343542025L,383064193L,427133117L,2002309657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159574Inst : IEnumerable<long>
{
public static readonly long[] Value=A159574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159574.Bytes);
public long this[int i]=>Value[i];

public static A159574Inst Instance=new A159574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159575
{
public static readonly long[] Value={ 1L,1L,1L,5L,0L,4L,3L,1L,8L,2L,8L,5L,3L,7L,1L,0L,5L,9L,7L,2L,3L,6L,9L,2L,5L,5L,3L,9L,5L,5L,3L,2L,7L,0L,4L,7L,4L,9L,0L,4L,4L,8L,5L,0L,7L,0L,5L,0L,3L,8L,5L,9L,4L,9L,5L,2L,5L,9L,9L,2L,1L,8L,7L,8L,8L,9L,5L,4L,2L,7L,4L,3L,1L,5L,7L,2L,7L,4L,4L,1L,6L,3L,2L,3L,4L,7L,4L,7L,9L,9L,9L,6L,8L,1L,0L,6L,4L,3L,3L,4L,9L,8L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159575Inst : IEnumerable<long>
{
public static readonly long[] Value=A159575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159575.Bytes);
public long this[int i]=>Value[i];

public static A159575Inst Instance=new A159575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159576
{
public static readonly long[] Value={ 4L,6L,8L,7L,7L,8L,8L,3L,6L,6L,9L,2L,2L,9L,7L,1L,9L,6L,1L,1L,6L,7L,2L,9L,9L,1L,7L,1L,1L,5L,5L,5L,3L,3L,4L,3L,0L,7L,0L,7L,1L,8L,5L,8L,3L,8L,3L,3L,5L,9L,3L,0L,0L,9L,2L,9L,2L,2L,0L,8L,8L,2L,0L,2L,6L,5L,1L,1L,7L,2L,2L,2L,6L,0L,9L,5L,6L,6L,9L,3L,7L,1L,1L,6L,5L,8L,8L,4L,3L,9L,7L,9L,6L,3L,9L,9L,3L,1L,6L,9L,2L,6L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159576Inst : IEnumerable<long>
{
public static readonly long[] Value=A159576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159576.Bytes);
public long this[int i]=>Value[i];

public static A159576Inst Instance=new A159576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159577
{
public static readonly BigInteger[] Value={ 3L,125970L,44618574L,1050274875L,835668708875L,BigInteger.Parse("87740042053973197350"),BigInteger.Parse("249875247243953981660010"),BigInteger.Parse("958593992854426686094086750"),BigInteger.Parse("28077829144670491508241956182896750") };
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
public class A159577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159577Inst Instance=new A159577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159578
{
public static readonly BigInteger[] Value={ 2L,30L,9699690L,304250263527210L,BigInteger.Parse("267064515689275851355624017992790"),BigInteger.Parse("5766152219975951659023630035336134306565384015606066319856068810"),BigInteger.Parse("962947420735983927056946215901134429196419130606213075415963491270"),BigInteger.Parse("29819592777931214269172453467810429868925511217482600306406141434158090"),BigInteger.Parse("1030893141925860008499560888835674370998623848299590975192766715520279329390") };
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
public class A159578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159578Inst Instance=new A159578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159579
{
public static readonly long[] Value={ 10L,77L,125L,154L,222L,455L,575L,713L,1037L,1235L,1554L,2046L,2183L,2622L,3278L,3451L,3630L,3811L,4002L,5025L,6194L,6965L,7505L,8346L,8635L,9546L,10507L,17854L,18746L,19203L,22550L,25135L,28483L,32047L,33277L,37111L,48495L,52430L,56541L,62530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159579Inst : IEnumerable<long>
{
public static readonly long[] Value=A159579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159579.Bytes);
public long this[int i]=>Value[i];

public static A159579Inst Instance=new A159579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159580
{
public static readonly long[] Value={ 2L,2L,5L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159580Inst : IEnumerable<long>
{
public static readonly long[] Value=A159580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159580.Bytes);
public long this[int i]=>Value[i];

public static A159580Inst Instance=new A159580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159581
{
public static readonly long[] Value={ 125L,2046L,3278L,8346L,18746L,89798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159581Inst : IEnumerable<long>
{
public static readonly long[] Value=A159581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159581.Bytes);
public long this[int i]=>Value[i];

public static A159581Inst Instance=new A159581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159582
{
public static readonly long[] Value={ 1L,6L,7L,34L,41L,198L,239L,1154L,1393L,6726L,8119L,39202L,47321L,228486L,275807L,1331714L,1607521L,7761798L,9369319L,45239074L,54608393L,263672646L,318281039L,1536796802L,1855077841L,8957108166L,10812186007L,52205852194L,63018038201L,304278004998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159582Inst : IEnumerable<long>
{
public static readonly long[] Value=A159582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159582.Bytes);
public long this[int i]=>Value[i];

public static A159582Inst Instance=new A159582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159583
{
public static readonly BigInteger[] Value={ 1L,31L,2521L,97921L,4974481L,226965751L,10783342081L,504420084871L,23735900452321L,1114384154071681L,52364857850613001L,2459808940392975631L,BigInteger.Parse("115562692701892638721"),BigInteger.Parse("5428914300540041959471"),BigInteger.Parse("255044709450472227347881") };
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
public class A159583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159583Inst Instance=new A159583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159584
{
public static readonly long[] Value={ 1L,0L,-3L,-2L,0L,6L,6L,0L,-3L,-12L,0L,6L,0L,0L,-6L,4L,0L,0L,6L,0L,0L,12L,0L,-12L,1L,0L,9L,-12L,0L,-12L,-30L,0L,12L,24L,0L,6L,0L,0L,24L,24L,0L,-12L,-18L,0L,0L,-24L,0L,-12L,-23L,0L,6L,0L,0L,-18L,48L,0L,-12L,36L,0L,12L,0L,0L,-18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159584Inst : IEnumerable<long>
{
public static readonly long[] Value=A159584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159584.Bytes);
public long this[int i]=>Value[i];

public static A159584Inst Instance=new A159584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159585
{
public static readonly long[] Value={ 2L,4L,10L,4L,46L,22L,16L,46L,66L,136L,166L,124L,636L,550L,1474L,3066L,1656L,1816L,3708L,9436L,1746L,3696L,11262L,40138L,25900L,20808L,60340L,58818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159585Inst : IEnumerable<long>
{
public static readonly long[] Value=A159585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159585.Bytes);
public long this[int i]=>Value[i];

public static A159585Inst Instance=new A159585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159586
{
public static readonly long[] Value={ 4L,8L,12L,1L,20L,24L,28L,2L,16L,40L,44L,3L,52L,56L,60L,9L,68L,32L,76L,5L,84L,88L,92L,6L,36L,104L,48L,7L,116L,120L,124L,18L,132L,136L,140L,25L,148L,152L,156L,10L,164L,168L,172L,11L,80L,184L,188L,27L,64L,72L,204L,13L,212L,96L,220L,14L,228L,232L,236L,15L,244L,248L,112L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159586Inst : IEnumerable<long>
{
public static readonly long[] Value=A159586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159586.Bytes);
public long this[int i]=>Value[i];

public static A159586Inst Instance=new A159586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159587
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,35L,8L,7L,11L,21L,9L,55L,16L,15L,14L,13L,19L,65L,17L,33L,10L,39L,25L,77L,23L,45L,29L,51L,27L,1001L,32L,31L,20L,57L,6L,85L,41L,63L,22L,69L,37L,715L,47L,75L,26L,87L,43L,91L,53L,93L,28L,95L,49L,115L,12L,99L,34L,111L,61L,1309L,59L,117L,38L,67L,18L,455L,64L,123L,40L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159587Inst : IEnumerable<long>
{
public static readonly long[] Value=A159587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159587.Bytes);
public long this[int i]=>Value[i];

public static A159587Inst Instance=new A159587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159588
{
public static readonly long[] Value={ 1L,3L,2L,9L,7L,25L,5L,27L,4L,21L,13L,125L,11L,15L,14L,81L,19L,175L,17L,63L,10L,35L,29L,625L,6L,33L,8L,45L,23L,343L,37L,243L,26L,39L,22L,875L,31L,49L,34L,189L,43L,275L,41L,75L,28L,51L,53L,3125L,38L,99L,46L,105L,47L,1225L,57L,135L,55L,65L,61L,2401L,59L,69L,20L,729L,58L,245L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159588Inst : IEnumerable<long>
{
public static readonly long[] Value=A159588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159588.Bytes);
public long this[int i]=>Value[i];

public static A159588Inst Instance=new A159588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159589
{
public static readonly long[] Value={ 421L,449L,481L,2045L,2245L,2465L,11849L,13021L,14309L,69049L,75881L,83389L,402445L,442265L,486025L,2345621L,2577709L,2832761L,13671281L,15023989L,16510541L,79682065L,87566225L,96230485L,464421109L,510373361L,560872369L,2706844589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159589Inst : IEnumerable<long>
{
public static readonly long[] Value=A159589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159589.Bytes);
public long this[int i]=>Value[i];

public static A159589Inst Instance=new A159589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159590
{
public static readonly long[] Value={ 1L,0L,9L,8L,9L,4L,5L,2L,2L,6L,8L,8L,4L,6L,1L,6L,5L,9L,5L,6L,8L,8L,3L,0L,8L,8L,2L,3L,4L,4L,3L,8L,5L,5L,1L,0L,5L,4L,7L,2L,3L,6L,1L,1L,4L,9L,8L,0L,2L,4L,6L,8L,6L,9L,0L,8L,5L,8L,1L,3L,0L,0L,4L,9L,3L,0L,8L,9L,5L,7L,6L,2L,6L,6L,2L,3L,3L,0L,3L,3L,6L,5L,6L,2L,4L,7L,4L,7L,4L,9L,6L,7L,2L,5L,6L,7L,7L,6L,1L,0L,6L,5L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159590Inst : IEnumerable<long>
{
public static readonly long[] Value=A159590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159590.Bytes);
public long this[int i]=>Value[i];

public static A159590Inst Instance=new A159590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159591
{
public static readonly long[] Value={ 4L,8L,2L,6L,1L,3L,2L,8L,9L,3L,3L,4L,6L,7L,3L,4L,8L,7L,8L,0L,8L,3L,8L,8L,6L,3L,1L,5L,8L,5L,0L,4L,4L,3L,3L,0L,5L,4L,5L,4L,1L,6L,2L,0L,0L,3L,9L,3L,5L,2L,4L,6L,3L,4L,5L,7L,3L,9L,2L,2L,1L,8L,1L,2L,8L,9L,1L,7L,2L,6L,3L,7L,0L,5L,2L,5L,2L,0L,4L,7L,5L,3L,6L,6L,8L,8L,9L,1L,9L,4L,4L,1L,1L,9L,3L,9L,8L,2L,8L,6L,0L,1L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159591Inst : IEnumerable<long>
{
public static readonly long[] Value=A159591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159591.Bytes);
public long this[int i]=>Value[i];

public static A159591Inst Instance=new A159591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159592
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,177L,3491L,133261L,9917307L,1443008813L,411772442315L,231163433300285L,255964900099068155L,BigInteger.Parse("560177408302962464013"),BigInteger.Parse("2427068640913282843197355"),BigInteger.Parse("20848444510025384551575108829") };
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
public class A159592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159592Inst Instance=new A159592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159593
{
public static readonly BigInteger[] Value={ 1L,1L,4L,49L,1768L,187474L,58888462L,55210937881L,155033790773008L,1305338879106660550L,BigInteger.Parse("32966118096763299572020"),BigInteger.Parse("2497521410388697783376754490"),BigInteger.Parse("567627952695201383291867693446222") };
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
public class A159593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159593Inst Instance=new A159593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159594
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,125L,1301L,17070L,272976L,5218727L,118508219L,3224104875L,108226321884L,4740041705554L,291705715765328L,26728599026539162L,3688459631229579912L,BigInteger.Parse("751246585455211054713"),BigInteger.Parse("208348432365596381718906") };
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
public class A159594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159594Inst Instance=new A159594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159595
{
public static readonly BigInteger[] Value={ 1L,1L,4L,13L,56L,286L,2008L,19749L,280842L,5762129L,168873970L,7023348917L,412682000624L,34188301513404L,3992802803844526L,656649238572375132L,BigInteger.Parse("152278229304524217542"),BigInteger.Parse("49749953321847000835094") };
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
public class A159595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159595Inst Instance=new A159595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159596
{
public static readonly BigInteger[] Value={ 1L,1L,5L,22L,121L,863L,8476L,118131L,2361313L,67467236L,2731757961L,156417295405L,12605225573076L,1432381581679361L,229016092616239411L,BigInteger.Parse("51628631138952017332"),BigInteger.Parse("16402709158903948390585"),BigInteger.Parse("7351149638643155728435357") };
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
public class A159596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159596Inst Instance=new A159596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159597
{
public static readonly BigInteger[] Value={ 1L,1L,7L,37L,245L,2094L,24661L,410376L,9809637L,334520167L,16192227784L,1107914634442L,106788033119369L,14525652771018918L,2780328926392863928L,BigInteger.Parse("751651711717655433750"),BigInteger.Parse("286240041470280077141769") };
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
public class A159597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159597Inst Instance=new A159597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159598
{
public static readonly BigInteger[] Value={ 1L,1L,9L,52L,389L,3741L,49908L,938799L,25477165L,984680146L,54180019253L,4211350678751L,462028240134476L,71561459522839253L,15611478225943599423UL,BigInteger.Parse("4816139618587302209166"),BigInteger.Parse("2092942812095475521879845") };
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
public class A159598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159598Inst Instance=new A159598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159599
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,304L,5685L,177486L,9305821L,807656872L,113141689065L,25091265489130L,8644033129800321L,4584172093683770820L,BigInteger.Parse("3704744323753306881229"),BigInteger.Parse("4538175408875808587259022"),BigInteger.Parse("8381136688938251234193247485") };
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
public class A159599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159599Inst Instance=new A159599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159600
{
public static readonly BigInteger[] Value={ 1L,-1L,3L,-27L,441L,-11529L,442827L,-23444883L,1636819569L,-145703137041L,16106380394643L,-2164638920874507L,347592265948756521L,BigInteger.Parse("-65724760945840254489"),BigInteger.Parse("14454276753061349098587") };
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
public class A159600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159600Inst Instance=new A159600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159601
{
public static readonly BigInteger[] Value={ 1L,-3L,27L,-441L,11529L,-442827L,23444883L,-1636819569L,145703137041L,-16106380394643L,2164638920874507L,-347592265948756521L,BigInteger.Parse("65724760945840254489"),BigInteger.Parse("-14454276753061349098587") };
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
public class A159601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159601Inst Instance=new A159601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159602
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,26L,152L,1202L,12840L,184060L,3552960L,92338448L,3237738008L,153574021372L,9872941474544L,862850471831896L,102720981260693424L,16701084112350547436UL,BigInteger.Parse("3715705202756433837504"),BigInteger.Parse("1133547354784950481434016") };
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
public class A159602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159602Inst Instance=new A159602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159603
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,16L,62L,312L,2001L,16796L,183416L,2634814L,49703026L,1240433524L,40975503423L,1803618092422L,105967390883387L,8362303039735026L,888404336012975536L,BigInteger.Parse("127771790716640691664"),BigInteger.Parse("24942884185805223709166") };
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
public class A159603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159603Inst Instance=new A159603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159604
{
public static readonly BigInteger[] Value={ 1L,1L,6L,43L,856L,10744L,608375L,14284223L,551011548L,19119025101L,874788949035L,37896009869060L,20683158266928833L,1799893777863733707L,BigInteger.Parse("93147805938921355288"),BigInteger.Parse("3757831283217050847983"),BigInteger.Parse("180287028377782585130749") };
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
public class A159604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159604Inst Instance=new A159604Inst();

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