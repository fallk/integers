using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A210157
{
public static readonly BigInteger[] Value={ 13L,6977L,63734680L,7497695247894L,11230410246683136735UL,BigInteger.Parse("214160856104080731185022846"),BigInteger.Parse("51994930493116642866385994032327421"),BigInteger.Parse("160715719061735613747680039160868439624176414") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210157Inst Instance=new A210157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210158
{
public static readonly long[] Value={ 13L,148L,1977L,27720L,393649L,5608216L,79963353L,1140367704L,16263750913L,231954064216L,3308145663081L,47181050078808L,672900213492241L,9596961465020248L,136872702133795833L,1952090431423132248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210158Inst : IEnumerable<long>
{
public static readonly long[] Value=A210158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210158.Bytes);
public long this[int i]=>Value[i];

public static A210158Inst Instance=new A210158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210159
{
public static readonly BigInteger[] Value={ 148L,6977L,351482L,17864271L,908980864L,46257884813L,2354098130302L,119802073302399L,6096832015875652L,310273110797149253L,15790069903296057458UL,BigInteger.Parse("803570464268447301967"),BigInteger.Parse("40894403574255214909720") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210159Inst Instance=new A210159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210160
{
public static readonly BigInteger[] Value={ 1977L,351482L,63734680L,11572169594L,2101304030788L,381562168006676L,69285421396766192L,12581094577437564692UL,BigInteger.Parse("2284520145501218842460"),BigInteger.Parse("414831337889494109430366"),BigInteger.Parse("75326557848453481157022672") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210160Inst Instance=new A210160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210161
{
public static readonly BigInteger[] Value={ 27720L,17864271L,11572169594L,7497695247894L,4857832789667601L,3147440073860364317L,BigInteger.Parse("2039258946769923053510"),BigInteger.Parse("1321256944854221652586980"),BigInteger.Parse("856056028090645842341607753"),BigInteger.Parse("554647546859512237920284437315") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210161Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210161.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210161Inst Instance=new A210161Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210162
{
public static readonly BigInteger[] Value={ 393649L,908980864L,2101304030788L,4857832789667601L,11230410246683136735UL,BigInteger.Parse("25962633684406082924528"),BigInteger.Parse("60020811817199659899093212"),BigInteger.Parse("138757026672024094981417833759"),BigInteger.Parse("320780607033534210335763669108271") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210162Inst Instance=new A210162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210163
{
public static readonly BigInteger[] Value={ 5608216L,46257884813L,381562168006676L,3147440073860364317L,BigInteger.Parse("25962633684406082924528"),BigInteger.Parse("214160856104080731185022846"),BigInteger.Parse("1766572383518778985494433173997"),BigInteger.Parse("14572121378241022983911998699738096") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210163Inst Instance=new A210163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210164
{
public static readonly BigInteger[] Value={ 79963353L,2354098130302L,69285421396766192L,BigInteger.Parse("2039258946769923053510"),BigInteger.Parse("60020811817199659899093212"),BigInteger.Parse("1766572383518778985494433173997"),BigInteger.Parse("51994930493116642866385994032327421") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210164Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210164.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210164Inst Instance=new A210164Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210165
{
public static readonly long[] Value={ 13L,148L,148L,1977L,6977L,1977L,27720L,351482L,351482L,27720L,393649L,17864271L,63734680L,17864271L,393649L,5608216L,908980864L,11572169594L,11572169594L,908980864L,5608216L,79963353L,46257884813L,2101304030788L,7497695247894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210165Inst : IEnumerable<long>
{
public static readonly long[] Value=A210165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210165.Bytes);
public long this[int i]=>Value[i];

public static A210165Inst Instance=new A210165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210166
{
public static readonly BigInteger[] Value={ 1L,201L,89293L,101095392L,343737526300L,3748133016211929L,BigInteger.Parse("134623935213997208181"),BigInteger.Parse("16106430235512371314453933") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210166Inst Instance=new A210166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210167
{
public static readonly long[] Value={ 1L,10L,101L,910L,7545L,59178L,447429L,3300982L,23953969L,171879010L,1223834045L,8668104046L,61170701289L,430597896090L,3025851581877L,21237517730278L,148936511331361L,1043880899831122L,7313575755465773L,51226014364080862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210167Inst : IEnumerable<long>
{
public static readonly long[] Value=A210167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210167.Bytes);
public long this[int i]=>Value[i];

public static A210167Inst Instance=new A210167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210168
{
public static readonly long[] Value={ 10L,201L,3283L,48577L,679253L,9173091L,121178151L,1578188865L,20364553277L,261193130859L,3336758862031L,42516443800121L,540813127075381L,6871496034443795L,87244283342152055L,1107170119794198769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210168Inst : IEnumerable<long>
{
public static readonly long[] Value=A210168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210168.Bytes);
public long this[int i]=>Value[i];

public static A210168Inst Instance=new A210168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210169
{
public static readonly BigInteger[] Value={ 101L,3283L,89293L,2266901L,55406625L,1323907951L,31194685583L,728618654983L,16924786006687L,391770747425385L,9048653573565509L,208704389188320759L,4809477953050228735L,BigInteger.Parse("110770487003358715391"),BigInteger.Parse("2550345502157173838959") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210169Inst Instance=new A210169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210170
{
public static readonly BigInteger[] Value={ 910L,48577L,2266901L,101095392L,4397691548L,188568419989L,8015152545175L,338864385855724L,14279316795033022L,600493383399648691L,BigInteger.Parse("25221353246754934437"),BigInteger.Parse("1058515711497044756258"),BigInteger.Parse("44404162219437478885636") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210170Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210170.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210170Inst Instance=new A210170Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210171
{
public static readonly BigInteger[] Value={ 7545L,679253L,55406625L,4397691548L,343737526300L,26640186018717L,2054059689574097L,157885132526126296L,12112997279818925338UL,BigInteger.Parse("928256678269308585687"),BigInteger.Parse("71086500262054721658815"),BigInteger.Parse("5441614895591983767635526") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210171Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210171.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210171Inst Instance=new A210171Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210172
{
public static readonly BigInteger[] Value={ 59178L,9173091L,1323907951L,188568419989L,26640186018717L,3748133016211929L,526005343487519133L,BigInteger.Parse("73706883182657394867"),BigInteger.Parse("10318722914922314099443"),BigInteger.Parse("1443787914404541881751435"),BigInteger.Parse("201946673325313730165095787") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210172Inst Instance=new A210172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210173
{
public static readonly BigInteger[] Value={ 447429L,121178151L,31194685583L,8015152545175L,2054059689574097L,526005343487519133L,BigInteger.Parse("134623935213997208181"),BigInteger.Parse("34444100480845830787435"),BigInteger.Parse("8810801446317160038967977"),BigInteger.Parse("2253508518406295673345100975") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210173Inst Instance=new A210173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210174
{
public static readonly long[] Value={ 1L,10L,10L,101L,201L,101L,910L,3283L,3283L,910L,7545L,48577L,89293L,48577L,7545L,59178L,679253L,2266901L,2266901L,679253L,59178L,447429L,9173091L,55406625L,101095392L,55406625L,9173091L,447429L,3300982L,121178151L,1323907951L,4397691548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210174Inst : IEnumerable<long>
{
public static readonly long[] Value=A210174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210174.Bytes);
public long this[int i]=>Value[i];

public static A210174Inst Instance=new A210174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210175
{
public static readonly BigInteger[] Value={ 1L,2316L,7363642L,178967377396L,35812805301833530L,BigInteger.Parse("59168572185919156908468"),BigInteger.Parse("807064033391082670768444038930"),BigInteger.Parse("90885346773699848616006199051130800984") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210175Inst Instance=new A210175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210176
{
public static readonly long[] Value={ 1L,51L,744L,9042L,103752L,1165620L,12988416L,144259560L,1600182816L,17740623696L,196642606464L,2179465613472L,24155044021632L,267707038144320L,2966944305186816L,32881987112668800L,364423467992173056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210176Inst : IEnumerable<long>
{
public static readonly long[] Value=A210176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210176.Bytes);
public long this[int i]=>Value[i];

public static A210176Inst Instance=new A210176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210177
{
public static readonly BigInteger[] Value={ 51L,2316L,79017L,2563795L,82255351L,2632469015L,84200356757L,2692825679001L,86117153792391L,2754026796151627L,88073648144059741L,2816590158892560329L,BigInteger.Parse("90074382683817260687"),BigInteger.Parse("2880573249877838455779"),BigInteger.Parse("92120555990382118611861") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210177Inst Instance=new A210177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210178
{
public static readonly BigInteger[] Value={ 744L,79017L,7363642L,677791782L,62264517380L,5718695139568L,525217898009080L,48237037195753208L,4430181416208443992L,BigInteger.Parse("406876280707186239248"),BigInteger.Parse("37368290569123715949088"),BigInteger.Parse("3431974791829880915134368") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210178Inst Instance=new A210178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210179
{
public static readonly BigInteger[] Value={ 9042L,2563795L,677791782L,178967377396L,47230346056196L,12464481048826696L,3289463766677655180L,BigInteger.Parse("868112796406514394762"),BigInteger.Parse("229101105231079683475878"),BigInteger.Parse("60461401929004270020060446"),BigInteger.Parse("15956191555188818333370424668") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210179Inst Instance=new A210179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210180
{
public static readonly BigInteger[] Value={ 103752L,82255351L,62264517380L,47230346056196L,35812805301833530L,BigInteger.Parse("27156404404201709994"),BigInteger.Parse("20592266923035456358072"),BigInteger.Parse("15614795007150616398474584"),BigInteger.Parse("11840454887138919128812338618"),BigInteger.Parse("8978431861925796030847663452124") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210180Inst Instance=new A210180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210181
{
public static readonly BigInteger[] Value={ 1165620L,2632469015L,5718695139568L,12464481048826696L,BigInteger.Parse("27156404404201709994"),BigInteger.Parse("59168572185919156908468"),BigInteger.Parse("128916198764977919097970016"),BigInteger.Parse("280882175302896412528199673868"),BigInteger.Parse("611985080884296074533935641104282") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210181Inst Instance=new A210181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210182
{
public static readonly BigInteger[] Value={ 12988416L,84200356757L,525217898009080L,3289463766677655180L,BigInteger.Parse("20592266923035456358072"),BigInteger.Parse("128916198764977919097970016"),BigInteger.Parse("807064033391082670768444038930"),BigInteger.Parse("5052529194034452722003155551168526") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210182Inst Instance=new A210182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210183
{
public static readonly long[] Value={ 1L,51L,51L,744L,2316L,744L,9042L,79017L,79017L,9042L,103752L,2563795L,7363642L,2563795L,103752L,1165620L,82255351L,677791782L,677791782L,82255351L,1165620L,12988416L,2632469015L,62264517380L,178967377396L,62264517380L,2632469015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210183Inst : IEnumerable<long>
{
public static readonly long[] Value=A210183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210183.Bytes);
public long this[int i]=>Value[i];

public static A210183Inst Instance=new A210183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210184
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,10L,12L,12L,17L,19L,21L,26L,29L,26L,31L,35L,37L,41L,42L,39L,44L,49L,55L,59L,59L,65L,71L,75L,63L,73L,80L,82L,90L,90L,104L,86L,103L,104L,107L,111L,113L,114L,120L,125L,120L,115L,139L,149L,132L,141L,147L,150L,147L,164L,166L,172L,172L,170L,172L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210184Inst : IEnumerable<long>
{
public static readonly long[] Value=A210184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210184.Bytes);
public long this[int i]=>Value[i];

public static A210184Inst Instance=new A210184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210185
{
public static readonly long[] Value={ 1L,3L,7L,12L,24L,56L,97L,103L,156L,224L,341L,494L,608L,521L,732L,821L,997L,1412L,1312L,1228L,1592L,1984L,2212L,2503L,2583L,3158L,3644L,3846L,3309L,4004L,5149L,5394L,6214L,6129L,7667L,6371L,8100L,8320L,8464L,9174L,10195L,10083L,11973L,11660L,12174L,11530L,14053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210185Inst : IEnumerable<long>
{
public static readonly long[] Value=A210185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210185.Bytes);
public long this[int i]=>Value[i];

public static A210185Inst Instance=new A210185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210186
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,19L,23L,23L,23L,47L,59L,61L,71L,71L,71L,101L,101L,101L,101L,101L,101L,113L,113L,113L,113L,113L,113L,113L,113L,113L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,223L,487L,487L,661L,661L,661L,661L,661L,661L,661L,661L,661L,719L,719L,719L,719L,719L,719L,811L,811L,811L,811L,811L,811L,811L,811L,811L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210186Inst : IEnumerable<long>
{
public static readonly long[] Value=A210186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210186.Bytes);
public long this[int i]=>Value[i];

public static A210186Inst Instance=new A210186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210187
{
public static readonly long[] Value={ 1L,3L,6L,2L,10L,9L,2L,15L,25L,13L,2L,21L,55L,49L,17L,2L,28L,105L,140L,81L,21L,2L,36L,182L,336L,285L,121L,25L,2L,45L,294L,714L,825L,506L,169L,29L,2L,55L,450L,1386L,2079L,1716L,819L,225L,33L,2L,66L,660L,2508L,4719L,5005L,3185L,1240L,289L,37L,2L,78L,935L,4290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210187Inst : IEnumerable<long>
{
public static readonly long[] Value=A210187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210187.Bytes);
public long this[int i]=>Value[i];

public static A210187Inst Instance=new A210187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210188
{
public static readonly long[] Value={ 1L,2L,2L,3L,7L,2L,4L,16L,11L,2L,5L,30L,36L,15L,2L,6L,50L,91L,64L,19L,2L,7L,77L,196L,204L,100L,23L,2L,8L,112L,378L,540L,385L,144L,27L,2L,9L,156L,672L,1254L,1210L,650L,196L,31L,2L,10L,210L,1122L,2640L,3289L,2366L,1015L,256L,35L,2L,11L,275L,1782L,5148L,8008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210188Inst : IEnumerable<long>
{
public static readonly long[] Value=A210188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210188.Bytes);
public long this[int i]=>Value[i];

public static A210188Inst Instance=new A210188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210189
{
public static readonly long[] Value={ 1L,3L,6L,2L,10L,10L,15L,30L,4L,21L,70L,28L,28L,140L,112L,8L,36L,252L,336L,72L,45L,420L,840L,360L,16L,55L,660L,1848L,1320L,176L,66L,990L,3696L,3960L,1056L,32L,78L,1430L,6864L,10296L,4576L,416L,91L,2002L,12012L,24024L,16016L,2912L,64L,105L,2730L,20020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210189Inst : IEnumerable<long>
{
public static readonly long[] Value=A210189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210189.Bytes);
public long this[int i]=>Value[i];

public static A210189Inst Instance=new A210189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210190
{
public static readonly long[] Value={ 1L,2L,2L,3L,8L,4L,20L,4L,5L,40L,24L,6L,70L,84L,8L,7L,112L,224L,64L,8L,168L,504L,288L,16L,9L,240L,1008L,960L,160L,10L,330L,1848L,2640L,880L,32L,11L,440L,3168L,6336L,3520L,384L,12L,572L,5148L,13728L,11440L,2496L,64L,13L,728L,8008L,27456L,32032L,11648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210190Inst : IEnumerable<long>
{
public static readonly long[] Value=A210190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210190.Bytes);
public long this[int i]=>Value[i];

public static A210190Inst Instance=new A210190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210191
{
public static readonly long[] Value={ 1L,3L,5L,3L,7L,10L,3L,9L,21L,16L,3L,11L,36L,47L,22L,3L,13L,55L,104L,85L,28L,3L,15L,78L,195L,236L,135L,34L,3L,17L,105L,328L,535L,456L,197L,40L,3L,19L,136L,511L,1058L,1227L,788L,271L,46L,3L,21L,171L,752L,1897L,2820L,2471L,1256L,357L,52L,3L,23L,210L,1059L,3160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210191Inst : IEnumerable<long>
{
public static readonly long[] Value=A210191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210191.Bytes);
public long this[int i]=>Value[i];

public static A210191Inst Instance=new A210191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210192
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,3L,1L,11L,13L,3L,1L,15L,31L,19L,3L,1L,19L,57L,63L,25L,3L,1L,23L,91L,151L,107L,31L,3L,1L,27L,133L,299L,321L,163L,37L,3L,1L,31L,183L,523L,771L,591L,231L,43L,3L,1L,35L,241L,839L,1593L,1683L,985L,311L,49L,3L,1L,39L,307L,1263L,2955L,4047L,3259L,1527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210192Inst : IEnumerable<long>
{
public static readonly long[] Value=A210192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210192.Bytes);
public long this[int i]=>Value[i];

public static A210192Inst Instance=new A210192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210193
{
public static readonly long[] Value={ 1L,3L,6L,3L,10L,14L,3L,15L,40L,23L,3L,21L,90L,97L,32L,3L,28L,175L,301L,181L,41L,3L,36L,308L,770L,728L,292L,50L,3L,45L,504L,1722L,2346L,1452L,430L,59L,3L,55L,780L,3486L,6456L,5686L,2554L,595L,68L,3L,66L,1155L,6534L,15774L,18722L,11816L,4115L,787L,77L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210193Inst : IEnumerable<long>
{
public static readonly long[] Value=A210193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210193.Bytes);
public long this[int i]=>Value[i];

public static A210193Inst Instance=new A210193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210194
{
public static readonly long[] Value={ 1L,2L,3L,3L,11L,3L,4L,26L,20L,3L,5L,50L,74L,29L,3L,6L,85L,204L,149L,38L,3L,7L,133L,469L,547L,251L,47L,3L,8L,196L,952L,1618L,1160L,380L,56L,3L,9L,276L,1764L,4110L,4234L,2124L,536L,65L,3L,10L,375L,3048L,9318L,13036L,9262L,3520L,719L,74L,3L,11L,495L,4983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210194Inst : IEnumerable<long>
{
public static readonly long[] Value=A210194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210194.Bytes);
public long this[int i]=>Value[i];

public static A210194Inst Instance=new A210194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210195
{
public static readonly long[] Value={ 1L,3L,5L,4L,7L,12L,8L,9L,24L,32L,16L,11L,40L,80L,80L,32L,13L,60L,160L,240L,192L,64L,15L,84L,280L,560L,672L,448L,128L,17L,112L,448L,1120L,1792L,1792L,1024L,256L,19L,144L,672L,2016L,4032L,5376L,4608L,2304L,512L,21L,180L,960L,3360L,8064L,13440L,15360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210195Inst : IEnumerable<long>
{
public static readonly long[] Value=A210195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210195.Bytes);
public long this[int i]=>Value[i];

public static A210195Inst Instance=new A210195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210196
{
public static readonly long[] Value={ 1L,1L,4L,1L,8L,8L,1L,12L,24L,16L,1L,16L,48L,64L,32L,1L,20L,80L,160L,160L,64L,1L,24L,120L,320L,480L,384L,128L,1L,28L,168L,560L,1120L,1344L,896L,256L,1L,32L,224L,896L,2240L,3584L,3584L,2048L,512L,1L,36L,288L,1344L,4032L,8064L,10752L,9216L,4608L,1024L,1L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210196Inst : IEnumerable<long>
{
public static readonly long[] Value=A210196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210196.Bytes);
public long this[int i]=>Value[i];

public static A210196Inst Instance=new A210196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210197
{
public static readonly long[] Value={ 1L,3L,7L,1L,15L,5L,31L,17L,1L,63L,49L,7L,127L,129L,31L,1L,255L,321L,111L,9L,511L,769L,351L,49L,1L,1023L,1793L,1023L,209L,11L,2047L,4097L,2815L,769L,71L,1L,4095L,9217L,7423L,2561L,351L,13L,8191L,20481L,18943L,7937L,1471L,97L,1L,16383L,45057L,47103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210197Inst : IEnumerable<long>
{
public static readonly long[] Value=A210197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210197.Bytes);
public long this[int i]=>Value[i];

public static A210197Inst Instance=new A210197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210198
{
public static readonly long[] Value={ 1L,3L,1L,7L,4L,15L,12L,1L,31L,32L,6L,63L,80L,24L,1L,127L,192L,80L,8L,255L,448L,240L,40L,1L,511L,1024L,672L,160L,10L,1023L,2304L,1792L,560L,60L,1L,2047L,5120L,4608L,1792L,280L,12L,4095L,11264L,11520L,5376L,1120L,84L,1L,8191L,24576L,28160L,15360L,4032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210198Inst : IEnumerable<long>
{
public static readonly long[] Value=A210198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210198.Bytes);
public long this[int i]=>Value[i];

public static A210198Inst Instance=new A210198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210199
{
public static readonly long[] Value={ 1L,3L,6L,2L,11L,7L,2L,19L,19L,9L,2L,32L,44L,30L,11L,2L,53L,94L,83L,43L,13L,2L,87L,190L,207L,137L,58L,15L,2L,142L,370L,480L,387L,208L,75L,17L,2L,231L,701L,1057L,1004L,653L,298L,94L,19L,2L,375L,1301L,2238L,2448L,1865L,1026L,409L,115L,21L,2L,608L,2376L,4596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210199Inst : IEnumerable<long>
{
public static readonly long[] Value=A210199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210199.Bytes);
public long this[int i]=>Value[i];

public static A210199Inst Instance=new A210199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210200
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,2L,7L,12L,7L,2L,12L,25L,21L,9L,2L,20L,50L,53L,32L,11L,2L,33L,96L,124L,94L,45L,13L,2L,54L,180L,273L,250L,150L,60L,15L,2L,88L,331L,577L,617L,445L,223L,77L,17L,2L,143L,600L,1181L,1444L,1212L,728L,315L,96L,19L,2L,232L,1075L,2358L,3242L,3101L,2163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210200Inst : IEnumerable<long>
{
public static readonly long[] Value=A210200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210200.Bytes);
public long this[int i]=>Value[i];

public static A210200Inst Instance=new A210200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210201
{
public static readonly long[] Value={ 1L,3L,6L,3L,11L,10L,6L,19L,27L,23L,12L,32L,62L,73L,52L,24L,53L,132L,193L,187L,116L,48L,87L,266L,468L,552L,462L,256L,96L,142L,517L,1061L,1482L,1495L,1112L,560L,192L,231L,978L,2297L,3688L,4369L,3896L,2624L,1216L,384L,375L,1813L,4797L,8703L,11758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210201Inst : IEnumerable<long>
{
public static readonly long[] Value=A210201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210201.Bytes);
public long this[int i]=>Value[i];

public static A210201Inst Instance=new A210201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210202
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,7L,17L,17L,12L,12L,35L,50L,40L,24L,20L,70L,120L,135L,92L,48L,33L,134L,275L,365L,346L,208L,96L,54L,251L,593L,930L,1033L,856L,464L,192L,88L,461L,1236L,2206L,2874L,2784L,2064L,1024L,384L,143L,835L,2500L,5015L,7389L,8355L,7240L,4880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210202Inst : IEnumerable<long>
{
public static readonly long[] Value=A210202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210202.Bytes);
public long this[int i]=>Value[i];

public static A210202Inst Instance=new A210202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210203
{
public static readonly long[] Value={ 1L,3L,7L,2L,15L,10L,2L,31L,34L,14L,2L,63L,98L,62L,18L,2L,127L,258L,222L,98L,22L,2L,255L,642L,702L,418L,142L,26L,2L,511L,1538L,2046L,1538L,702L,194L,30L,2L,1023L,3586L,5630L,5122L,2942L,1090L,254L,34L,2L,2047L,8194L,14846L,15874L,11006L,5122L,1598L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210203Inst : IEnumerable<long>
{
public static readonly long[] Value=A210203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210203.Bytes);
public long this[int i]=>Value[i];

public static A210203Inst Instance=new A210203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210204
{
public static readonly long[] Value={ 1L,3L,2L,7L,8L,2L,15L,24L,12L,2L,31L,64L,48L,16L,2L,63L,160L,160L,80L,20L,2L,127L,384L,480L,320L,120L,24L,2L,255L,896L,1344L,1120L,560L,168L,28L,2L,511L,2048L,3584L,3584L,2240L,896L,224L,32L,2L,1023L,4608L,9216L,10752L,8064L,4032L,1344L,288L,36L,2L,2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210204Inst : IEnumerable<long>
{
public static readonly long[] Value=A210204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210204.Bytes);
public long this[int i]=>Value[i];

public static A210204Inst Instance=new A210204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210205
{
public static readonly long[] Value={ 439L,34603L,1016201L,3696493L,4002991L,6344687L,10221397L,14662309L,16209029L,19925483L,20856907L,22805969L,43441271L,60120691L,60761413L,62056457L,62710787L,87791567L,96268243L,125977651L,166225747L,170027449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210205Inst : IEnumerable<long>
{
public static readonly long[] Value=A210205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210205.Bytes);
public long this[int i]=>Value[i];

public static A210205Inst Instance=new A210205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210206
{
public static readonly long[] Value={ 12L,42L,90L,160L,240L,344L,462L,598L,756L,922L,1108L,1314L,1534L,1772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210206Inst : IEnumerable<long>
{
public static readonly long[] Value=A210206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210206.Bytes);
public long this[int i]=>Value[i];

public static A210206Inst Instance=new A210206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210207
{
public static readonly long[] Value={ 168L,432L,480L,624L,672L,768L,1320L,1512L,1536L,1560L,1680L,1728L,1848L,1920L,2040L,2304L,2376L,2496L,2520L,2688L,2856L,3024L,3072L,3240L,3696L,3720L,3840L,3864L,3888L,4104L,4200L,4320L,4536L,5280L,5376L,5616L,5712L,6000L,6048L,6144L,6240L,6552L,6720L,6912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210207Inst : IEnumerable<long>
{
public static readonly long[] Value=A210207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210207.Bytes);
public long this[int i]=>Value[i];

public static A210207Inst Instance=new A210207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210208
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,4L,1L,5L,1L,2L,3L,1L,7L,1L,2L,4L,8L,1L,3L,9L,1L,2L,5L,1L,11L,1L,2L,3L,4L,1L,13L,1L,2L,7L,1L,3L,5L,1L,2L,4L,8L,16L,1L,17L,1L,2L,3L,9L,1L,19L,1L,2L,4L,5L,1L,3L,7L,1L,2L,11L,1L,23L,1L,2L,3L,4L,8L,1L,5L,25L,1L,2L,13L,1L,3L,9L,27L,1L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210208Inst : IEnumerable<long>
{
public static readonly long[] Value=A210208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210208.Bytes);
public long this[int i]=>Value[i];

public static A210208Inst Instance=new A210208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210209
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,4L,1L,3L,2L,11L,1L,8L,1L,29L,2L,21L,1L,76L,1L,55L,2L,199L,1L,144L,1L,521L,2L,377L,1L,1364L,1L,987L,2L,3571L,1L,2584L,1L,9349L,2L,6765L,1L,24476L,1L,17711L,2L,64079L,1L,46368L,1L,167761L,2L,121393L,1L,439204L,1L,317811L,2L,1149851L,1L,832040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210209Inst : IEnumerable<long>
{
public static readonly long[] Value=A210209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210209.Bytes);
public long this[int i]=>Value[i];

public static A210209Inst Instance=new A210209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210210
{
public static readonly long[] Value={ 0L,1L,2L,4L,2L,2L,4L,1L,2L,3L,3L,6L,2L,9L,4L,6L,7L,4L,4L,6L,3L,3L,3L,5L,2L,6L,4L,4L,4L,8L,3L,4L,6L,3L,3L,8L,8L,6L,6L,7L,7L,10L,7L,6L,14L,5L,5L,8L,5L,4L,6L,3L,3L,13L,2L,14L,12L,12L,12L,18L,18L,18L,11L,11L,11L,17L,10L,11L,11L,16L,16L,9L,9L,16L,15L,16L,8L,14L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210210Inst : IEnumerable<long>
{
public static readonly long[] Value=A210210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210210.Bytes);
public long this[int i]=>Value[i];

public static A210210Inst Instance=new A210210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210211
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,8L,8L,1L,5L,14L,19L,16L,1L,6L,21L,42L,42L,32L,1L,7L,30L,72L,114L,89L,64L,1L,8L,40L,120L,216L,290L,184L,128L,1L,9L,52L,178L,414L,593L,706L,375L,256L,1L,10L,65L,260L,670L,1292L,1531L,1666L,758L,512L,1L,11L,80L,355L,1090L,2247L,3754L,3782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210211Inst : IEnumerable<long>
{
public static readonly long[] Value=A210211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210211.Bytes);
public long this[int i]=>Value[i];

public static A210211Inst Instance=new A210211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210212
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,4L,4L,10L,11L,8L,5L,16L,28L,23L,16L,6L,24L,51L,72L,47L,32L,7L,33L,90L,144L,176L,95L,64L,8L,44L,138L,294L,377L,416L,191L,128L,9L,56L,208L,492L,878L,938L,960L,383L,256L,10L,70L,290L,830L,1577L,2462L,2251L,2176L,767L,512L,11L,85L,400L,1250L,2952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210212Inst : IEnumerable<long>
{
public static readonly long[] Value=A210212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210212.Bytes);
public long this[int i]=>Value[i];

public static A210212Inst Instance=new A210212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210213
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,7L,9L,4L,1L,12L,21L,16L,5L,1L,20L,46L,46L,25L,6L,1L,33L,94L,121L,85L,36L,7L,1L,54L,185L,289L,260L,141L,49L,8L,1L,88L,353L,653L,708L,491L,217L,64L,9L,1L,143L,659L,1409L,1800L,1499L,847L,316L,81L,10L,1L,232L,1209L,2939L,4320L,4229L,2863L,1366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210213Inst : IEnumerable<long>
{
public static readonly long[] Value=A210213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210213.Bytes);
public long this[int i]=>Value[i];

public static A210213Inst Instance=new A210213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210214
{
public static readonly long[] Value={ 1L,3L,1L,6L,5L,1L,11L,14L,7L,1L,19L,34L,25L,9L,1L,32L,74L,75L,39L,11L,1L,53L,152L,195L,139L,56L,13L,1L,87L,299L,468L,419L,231L,76L,15L,1L,142L,571L,1056L,1147L,791L,356L,99L,17L,1L,231L,1066L,2280L,2911L,2429L,1364L,519L,125L,19L,1L,375L,1956L,4755L,6991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210214Inst : IEnumerable<long>
{
public static readonly long[] Value=A210214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210214.Bytes);
public long this[int i]=>Value[i];

public static A210214Inst Instance=new A210214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210215
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,1L,2L,5L,7L,1L,2L,5L,12L,11L,1L,2L,5L,13L,26L,16L,1L,2L,5L,13L,33L,51L,22L,1L,2L,5L,13L,34L,79L,92L,29L,1L,2L,5L,13L,34L,88L,176L,155L,37L,1L,2L,5L,13L,34L,89L,221L,365L,247L,46L,1L,2L,5L,13L,34L,89L,232L,530L,709L,376L,56L,1L,2L,5L,13L,34L,89L,233L,596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210215Inst : IEnumerable<long>
{
public static readonly long[] Value=A210215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210215.Bytes);
public long this[int i]=>Value[i];

public static A210215Inst Instance=new A210215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210216
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,3L,7L,4L,1L,3L,8L,14L,5L,1L,3L,8L,20L,25L,6L,1L,3L,8L,21L,46L,41L,7L,1L,3L,8L,21L,54L,97L,63L,8L,1L,3L,8L,21L,55L,133L,189L,92L,9L,1L,3L,8L,21L,55L,143L,309L,344L,129L,10L,1L,3L,8L,21L,55L,144L,364L,674L,591L,175L,11L,1L,3L,8L,21L,55L,144L,376L,894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210216Inst : IEnumerable<long>
{
public static readonly long[] Value=A210216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210216.Bytes);
public long this[int i]=>Value[i];

public static A210216Inst Instance=new A210216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210217
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,1L,2L,6L,12L,1L,2L,6L,19L,27L,1L,2L,6L,20L,57L,58L,1L,2L,6L,20L,67L,160L,121L,1L,2L,6L,20L,68L,218L,424L,248L,1L,2L,6L,20L,68L,231L,680L,1073L,503L,1L,2L,6L,20L,68L,232L,775L,2028L,2619L,1014L,1L,2L,6L,20L,68L,232L,791L,2543L,5797L,6214L,2037L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210217Inst : IEnumerable<long>
{
public static readonly long[] Value=A210217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210217.Bytes);
public long this[int i]=>Value[i];

public static A210217Inst Instance=new A210217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210218
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,7L,1L,4L,13L,15L,1L,4L,14L,38L,31L,1L,4L,14L,47L,103L,63L,1L,4L,14L,48L,151L,264L,127L,1L,4L,14L,48L,163L,462L,649L,255L,1L,4L,14L,48L,164L,544L,1348L,1546L,511L,1L,4L,14L,48L,164L,559L,1768L,3769L,3595L,1023L,1L,4L,14L,48L,164L,560L,1893L,5564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210218Inst : IEnumerable<long>
{
public static readonly long[] Value=A210218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210218.Bytes);
public long this[int i]=>Value[i];

public static A210218Inst Instance=new A210218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210219
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,9L,7L,1L,5L,16L,22L,11L,1L,6L,25L,50L,46L,16L,1L,7L,36L,95L,130L,86L,22L,1L,8L,49L,161L,295L,296L,148L,29L,1L,9L,64L,252L,581L,791L,610L,239L,37L,1L,10L,81L,372L,1036L,1792L,1897L,1163L,367L,46L,1L,11L,100L,525L,1716L,3612L,4900L,4166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210219Inst : IEnumerable<long>
{
public static readonly long[] Value=A210219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210219.Bytes);
public long this[int i]=>Value[i];

public static A210219Inst Instance=new A210219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210220
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,3L,4L,12L,13L,4L,5L,20L,34L,24L,5L,6L,30L,70L,80L,40L,6L,7L,42L,125L,200L,166L,62L,7L,8L,56L,203L,420L,496L,314L,91L,8L,9L,72L,308L,784L,1211L,1106L,553L,128L,9L,10L,90L,444L,1344L,2576L,3108L,2269L,920L,174L,10L,11L,110L,615L,2160L,4956L,7476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210220Inst : IEnumerable<long>
{
public static readonly long[] Value=A210220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210220.Bytes);
public long this[int i]=>Value[i];

public static A210220Inst Instance=new A210220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210221
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,4L,4L,8L,10L,8L,8L,13L,20L,24L,16L,16L,21L,40L,52L,56L,32L,32L,34L,76L,116L,128L,128L,64L,64L,55L,142L,240L,312L,304L,288L,128L,128L,89L,260L,488L,688L,800L,704L,640L,256L,256L,144L,470L,964L,1496L,1856L,1984L,1600L,1408L,512L,512L,233L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210221Inst : IEnumerable<long>
{
public static readonly long[] Value=A210221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210221.Bytes);
public long this[int i]=>Value[i];

public static A210221Inst Instance=new A210221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210222
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,2L,4L,12L,10L,2L,5L,20L,28L,14L,2L,6L,30L,60L,52L,18L,2L,7L,42L,110L,140L,84L,22L,2L,8L,56L,182L,310L,276L,124L,26L,2L,9L,72L,280L,602L,726L,484L,172L,30L,2L,10L,90L,408L,1064L,1638L,1486L,780L,228L,34L,2L,11L,110L,570L,1752L,3304L,3850L,2750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210222Inst : IEnumerable<long>
{
public static readonly long[] Value=A210222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210222.Bytes);
public long this[int i]=>Value[i];

public static A210222Inst Instance=new A210222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210223
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,1L,2L,7L,10L,1L,2L,7L,22L,17L,1L,2L,7L,26L,57L,26L,1L,2L,7L,26L,89L,126L,37L,1L,2L,7L,26L,97L,266L,247L,50L,1L,2L,7L,26L,97L,346L,695L,442L,65L,1L,2L,7L,26L,97L,362L,1127L,1618L,737L,82L,1L,2L,7L,26L,97L,362L,1319L,3298L,3425L,1162L,101L,1L,2L,7L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210223Inst : IEnumerable<long>
{
public static readonly long[] Value=A210223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210223.Bytes);
public long this[int i]=>Value[i];

public static A210223Inst Instance=new A210223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210224
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,5L,1L,5L,15L,7L,1L,5L,19L,35L,9L,1L,5L,19L,63L,69L,11L,1L,5L,19L,71L,177L,121L,13L,1L,5L,19L,71L,249L,429L,195L,15L,1L,5L,19L,71L,265L,781L,923L,295L,17L,1L,5L,19L,71L,265L,957L,2171L,1807L,425L,19L,1L,5L,19L,71L,265L,989L,3211L,5407L,3281L,589L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210224Inst : IEnumerable<long>
{
public static readonly long[] Value=A210224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210224.Bytes);
public long this[int i]=>Value[i];

public static A210224Inst Instance=new A210224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210225
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,4L,12L,10L,1L,5L,22L,36L,17L,1L,6L,35L,88L,87L,26L,1L,7L,51L,175L,277L,181L,37L,1L,8L,70L,306L,680L,734L,338L,50L,1L,9L,92L,490L,1416L,2196L,1710L,582L,65L,1L,10L,117L,736L,2632L,5402L,6156L,3606L,941L,82L,1L,11L,145L,1053L,4502L,11592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210225Inst : IEnumerable<long>
{
public static readonly long[] Value=A210225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210225.Bytes);
public long this[int i]=>Value[i];

public static A210225Inst Instance=new A210225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210226
{
public static readonly long[] Value={ 1L,2L,3L,3L,9L,5L,4L,18L,24L,7L,5L,30L,66L,51L,9L,6L,45L,140L,189L,94L,11L,7L,63L,255L,505L,457L,157L,13L,8L,84L,420L,1110L,1516L,976L,244L,15L,9L,108L,644L,2142L,3986L,3960L,1896L,359L,17L,10L,135L,936L,3766L,8960L,12338L,9276L,3419L,506L,19L,11L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210226Inst : IEnumerable<long>
{
public static readonly long[] Value=A210226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210226.Bytes);
public long this[int i]=>Value[i];

public static A210226Inst Instance=new A210226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210227
{
public static readonly long[] Value={ 1L,2L,1L,2L,6L,1L,2L,8L,16L,1L,2L,8L,32L,38L,1L,2L,8L,36L,112L,84L,1L,2L,8L,36L,156L,348L,178L,1L,2L,8L,36L,164L,620L,988L,368L,1L,2L,8L,36L,164L,732L,2244L,2624L,750L,1L,2L,8L,36L,164L,748L,3108L,7468L,6632L,1516L,1L,2L,8L,36L,164L,748L,3380L,12348L,23164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210227Inst : IEnumerable<long>
{
public static readonly long[] Value=A210227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210227.Bytes);
public long this[int i]=>Value[i];

public static A210227Inst Instance=new A210227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210228
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,10L,1L,6L,24L,22L,1L,6L,28L,80L,46L,1L,6L,28L,120L,236L,94L,1L,6L,28L,128L,464L,640L,190L,1L,6L,28L,128L,568L,1624L,1636L,382L,1L,6L,28L,128L,584L,2376L,5224L,4008L,766L,1L,6L,28L,128L,584L,2632L,9240L,15696L,9516L,1534L,1L,6L,28L,128L,584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210228Inst : IEnumerable<long>
{
public static readonly long[] Value=A210228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210228.Bytes);
public long this[int i]=>Value[i];

public static A210228Inst Instance=new A210228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210229
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,7L,8L,4L,1L,12L,18L,13L,5L,1L,20L,38L,35L,19L,6L,1L,33L,76L,86L,59L,26L,7L,1L,54L,147L,197L,164L,91L,34L,8L,1L,88L,277L,430L,420L,281L,132L,43L,9L,1L,143L,512L,904L,1014L,792L,447L,183L,53L,10L,1L,232L,932L,1846L,2338L,2087L,1371L,673L,245L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210229Inst : IEnumerable<long>
{
public static readonly long[] Value=A210229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210229.Bytes);
public long this[int i]=>Value[i];

public static A210229Inst Instance=new A210229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210230
{
public static readonly long[] Value={ 1L,3L,1L,6L,4L,1L,11L,11L,5L,1L,19L,26L,17L,6L,1L,32L,56L,48L,24L,7L,1L,53L,114L,121L,78L,32L,8L,1L,87L,223L,283L,223L,117L,41L,9L,1L,142L,424L,627L,584L,372L,166L,51L,10L,1L,231L,789L,1334L,1434L,1073L,579L,226L,62L,11L,1L,375L,1444L,2750L,3352L,2879L,1818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210230Inst : IEnumerable<long>
{
public static readonly long[] Value=A210230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210230.Bytes);
public long this[int i]=>Value[i];

public static A210230Inst Instance=new A210230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210231
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,8L,7L,1L,5L,14L,18L,11L,1L,6L,21L,39L,36L,16L,1L,7L,30L,69L,93L,66L,22L,1L,8L,40L,114L,192L,199L,113L,29L,1L,9L,52L,172L,360L,474L,393L,183L,37L,1L,10L,65L,250L,610L,997L,1068L,729L,283L,46L,1L,11L,80L,345L,980L,1882L,2501L,2238L,1285L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210231Inst : IEnumerable<long>
{
public static readonly long[] Value=A210231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210231.Bytes);
public long this[int i]=>Value[i];

public static A210231Inst Instance=new A210231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210232
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,10L,10L,4L,5L,16L,25L,18L,5L,6L,24L,48L,54L,30L,6L,7L,33L,84L,123L,106L,47L,7L,8L,44L,132L,246L,282L,194L,70L,8L,9L,56L,198L,438L,637L,594L,336L,100L,9L,10L,70L,280L,730L,1272L,1504L,1170L,556L,138L,10L,11L,85L,385L,1140L,2337L,3337L,3301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210232Inst : IEnumerable<long>
{
public static readonly long[] Value=A210232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210232.Bytes);
public long this[int i]=>Value[i];

public static A210232Inst Instance=new A210232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210233
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,4L,10L,12L,1L,5L,18L,30L,27L,1L,6L,27L,68L,83L,58L,1L,7L,39L,119L,225L,217L,121L,1L,8L,52L,200L,454L,680L,544L,248L,1L,9L,68L,300L,866L,1566L,1928L,1320L,503L,1L,10L,85L,440L,1450L,3332L,5014L,5216L,3121L,1014L,1L,11L,105L,605L,2350L,6182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210233Inst : IEnumerable<long>
{
public static readonly long[] Value=A210233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210233.Bytes);
public long this[int i]=>Value[i];

public static A210233Inst Instance=new A210233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210234
{
public static readonly long[] Value={ 1L,2L,3L,3L,7L,7L,4L,14L,20L,15L,5L,22L,50L,53L,31L,6L,33L,92L,157L,134L,63L,7L,45L,161L,335L,455L,327L,127L,8L,60L,248L,666L,1112L,1248L,776L,255L,9L,76L,372L,1150L,2466L,3448L,3288L,1801L,511L,10L,95L,520L,1910L,4732L,8426L,10144L,8399L,4106L,1023L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210234Inst : IEnumerable<long>
{
public static readonly long[] Value=A210234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210234.Bytes);
public long this[int i]=>Value[i];

public static A210234Inst Instance=new A210234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210235
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,1L,7L,12L,7L,1L,12L,29L,28L,11L,1L,20L,64L,86L,56L,16L,1L,33L,132L,230L,210L,101L,22L,1L,54L,261L,560L,662L,451L,169L,29L,1L,88L,500L,1279L,1860L,1646L,883L,267L,37L,1L,143L,936L,2785L,4819L,5257L,3682L,1611L,403L,46L,1L,232L,1721L,5848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210235Inst : IEnumerable<long>
{
public static readonly long[] Value=A210235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210235.Bytes);
public long this[int i]=>Value[i];

public static A210235Inst Instance=new A210235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210236
{
public static readonly long[] Value={ 1L,3L,2L,6L,8L,3L,11L,22L,16L,4L,19L,52L,57L,28L,5L,32L,112L,166L,124L,45L,6L,53L,228L,428L,432L,241L,68L,7L,87L,446L,1018L,1300L,984L,432L,98L,8L,142L,848L,2285L,3540L,3397L,2036L,728L,136L,9L,231L,1578L,4912L,8964L,10443L,7962L,3914L,1168L,183L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210236Inst : IEnumerable<long>
{
public static readonly long[] Value=A210236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210236.Bytes);
public long this[int i]=>Value[i];

public static A210236Inst Instance=new A210236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210237
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,6L,1L,4L,6L,12L,24L,1L,5L,10L,20L,30L,60L,120L,1L,6L,15L,20L,30L,60L,90L,120L,180L,360L,720L,1L,7L,21L,35L,42L,105L,140L,210L,420L,630L,840L,1260L,2520L,5040L,1L,8L,28L,56L,70L,168L,280L,336L,420L,560L,840L,1120L,1680L,2520L,3360L,5040L,6720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210237Inst : IEnumerable<long>
{
public static readonly long[] Value=A210237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210237.Bytes);
public long this[int i]=>Value[i];

public static A210237Inst Instance=new A210237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210238
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,1L,4L,12L,6L,12L,1L,5L,20L,20L,30L,30L,20L,1L,6L,30L,30L,15L,60L,120L,20L,60L,90L,30L,1L,7L,42L,42L,42L,105L,210L,105L,245L,420L,140L,105L,210L,42L,1L,8L,56L,56L,224L,28L,336L,336L,280L,168L,168L,840L,420L,1120L,70L,1120L,560L,168L,420L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210238Inst : IEnumerable<long>
{
public static readonly long[] Value=A210238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210238.Bytes);
public long this[int i]=>Value[i];

public static A210238Inst Instance=new A210238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210239
{
public static readonly long[] Value={ 1L,2L,2L,2L,5L,3L,2L,9L,12L,5L,2L,13L,28L,25L,8L,2L,17L,52L,74L,50L,13L,2L,21L,84L,167L,177L,96L,21L,2L,25L,124L,320L,470L,397L,180L,34L,2L,29L,172L,549L,1041L,1211L,850L,331L,55L,2L,33L,228L,870L,2034L,3042L,2928L,1758L,600L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210239Inst : IEnumerable<long>
{
public static readonly long[] Value=A210239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210239.Bytes);
public long this[int i]=>Value[i];

public static A210239Inst Instance=new A210239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210240
{
public static readonly long[] Value={ 5L,8L,13L,17L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210240Inst : IEnumerable<long>
{
public static readonly long[] Value=A210240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210240.Bytes);
public long this[int i]=>Value[i];

public static A210240Inst Instance=new A210240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210241
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,13L,15L,19L,22L,25L,27L,31L,33L,36L,39L,44L,46L,50L,52L,56L,59L,62L,64L,69L,72L,75L,79L,83L,85L,89L,91L,97L,100L,103L,106L,111L,113L,116L,119L,124L,126L,130L,132L,136L,140L,143L,145L,151L,154L,158L,161L,165L,167L,172L,175L,180L,183L,186L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210241Inst : IEnumerable<long>
{
public static readonly long[] Value=A210241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210241.Bytes);
public long this[int i]=>Value[i];

public static A210241Inst Instance=new A210241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210242
{
public static readonly long[] Value={ 17L,19L,89L,97L,137L,139L,263L,269L,757L,761L,907L,911L,1201L,1213L,1481L,1483L,2309L,2311L,2609L,2617L,4679L,4691L,5743L,5749L,10733L,10739L,16103L,16111L,16267L,16273L,19759L,19763L,20269L,20287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210242Inst : IEnumerable<long>
{
public static readonly long[] Value=A210242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210242.Bytes);
public long this[int i]=>Value[i];

public static A210242Inst Instance=new A210242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210243
{
public static readonly long[] Value={ 1L,3L,1L,2L,3L,2L,1L,3L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,3L,2L,1L,3L,2L,1L,2L,3L,1L,3L,2L,1L,3L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,1L,3L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,3L,2L,3L,1L,2L,1L,2L,3L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210243Inst : IEnumerable<long>
{
public static readonly long[] Value=A210243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210243.Bytes);
public long this[int i]=>Value[i];

public static A210243Inst Instance=new A210243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210244
{
public static readonly long[] Value={ -1L,-1L,1L,5L,-7L,-49L,-53L,2215L,1259L,-14201L,-183197L,248885L,9583753L,14525053L,-554173253L,-4573299625L,99833187251L,215440236599L,-1654012631597L,-84480933600305L,-36267273557287L,10992430255511053L,117548575473066241L,-1380910044674479865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210244Inst : IEnumerable<long>
{
public static readonly long[] Value=A210244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210244.Bytes);
public long this[int i]=>Value[i];

public static A210244Inst Instance=new A210244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210245
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210245Inst : IEnumerable<long>
{
public static readonly long[] Value=A210245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210245.Bytes);
public long this[int i]=>Value[i];

public static A210245Inst Instance=new A210245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210246
{
public static readonly BigInteger[] Value={ 1L,-1L,-2L,2L,40L,104L,-1232L,-13168L,16000L,1483904L,9695488L,-151161088L,-3287997440L,146760704L,866038110208L,10263094740992L,-169941494497280L,-6324725967978496L,-15215847186563072L,2895126258819203072L,BigInteger.Parse("54295929047166484480") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210246Inst Instance=new A210246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210247
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210247Inst : IEnumerable<long>
{
public static readonly long[] Value=A210247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210247.Bytes);
public long this[int i]=>Value[i];

public static A210247Inst Instance=new A210247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210248
{
public static readonly long[] Value={ 7L,241L,967L,15787L,111577L,1587499L,25230061L,118194961L,188698981L,761453863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210248Inst : IEnumerable<long>
{
public static readonly long[] Value=A210248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210248.Bytes);
public long this[int i]=>Value[i];

public static A210248Inst Instance=new A210248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210249
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,3L,4L,8L,10L,18L,23L,37L,47L,71L,90L,131L,164L,230L,288L,393L,488L,653L,807L,1060L,1303L,1686L,2063L,2637L,3210L,4057L,4920L,6158L,7434L,9228L,11098L,13671L,16380L,20040L,23928L,29098L,34624L,41869L,49668L,59755L,70667L,84626L,99795L,118991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210249Inst : IEnumerable<long>
{
public static readonly long[] Value=A210249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210249.Bytes);
public long this[int i]=>Value[i];

public static A210249Inst Instance=new A210249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210250
{
public static readonly long[] Value={ 48L,192L,240L,432L,480L,672L,768L,936L,960L,1200L,1440L,1680L,1728L,1920L,2160L,2352L,2640L,2688L,2856L,3072L,3744L,3840L,3864L,3888L,4032L,4320L,4368L,4536L,4800L,5016L,5040L,5376L,5712L,5760L,5808L,5880L,6000L,6048L,6072L,6696L,6720L,6912L,7056L,7392L,7560L,7680L,7728L,7752L,7920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210250Inst : IEnumerable<long>
{
public static readonly long[] Value=A210250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210250.Bytes);
public long this[int i]=>Value[i];

public static A210250Inst Instance=new A210250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210251
{
public static readonly long[] Value={ 1L,9L,21L,25L,29L,41L,49L,61L,69L,81L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210251Inst : IEnumerable<long>
{
public static readonly long[] Value=A210251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210251.Bytes);
public long this[int i]=>Value[i];

public static A210251Inst Instance=new A210251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210252
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,4L,0L,0L,0L,3L,24L,0L,0L,0L,0L,33L,188L,0L,0L,0L,0L,13L,338L,1705L,0L,0L,0L,0L,0L,252L,3580L,16980L,0L,0L,0L,0L,0L,68L,3740L,39525L,180670L,0L,0L,0L,0L,0L,0L,1938L,51300L,452865L,2020120L,0L,0L,0L,0L,0L,0L,399L,38076L,685419L,5354832L,23478426L,0L,0L,0L,0L,0L,0L,0L,15180L,646415L,9095856L,65022840L,281481880L,0L,0L,0L,0L,0L,0L,0L,2530L,373175L,10215450L,120872850L,807560625L,3461873536L,0L,0L,0L,0L,0L,0L,0L,0L,121095L,7580040L,155282400L,1614234960L,10224817515L,43494961404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210252Inst : IEnumerable<long>
{
public static readonly long[] Value=A210252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210252.Bytes);
public long this[int i]=>Value[i];

public static A210252Inst Instance=new A210252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210253
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,8L,9L,10L,11L,13L,14L,16L,16L,16L,17L,18L,19L,20L,22L,24L,24L,25L,26L,27L,29L,30L,32L,32L,32L,32L,33L,34L,35L,36L,37L,40L,40L,41L,42L,43L,45L,46L,48L,48L,48L,49L,50L,51L,52L,54L,56L,56L,57L,58L,59L,61L,62L,64L,64L,64L,64L,64L,65L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210253Inst : IEnumerable<long>
{
public static readonly long[] Value=A210253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210253.Bytes);
public long this[int i]=>Value[i];

public static A210253Inst Instance=new A210253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210254
{
public static readonly long[] Value={ 0L,7L,12L,15L,21L,23L,28L,31L,38L,39L,44L,47L,53L,55L,60L,63L,70L,76L,79L,85L,87L,92L,95L,102L,103L,108L,111L,117L,119L,124L,127L,134L,136L,140L,143L,149L,151L,156L,159L,166L,167L,172L,175L,181L,183L,188L,191L,198L,204L,207L,213L,215L,220L,223L,230L,231L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210254Inst : IEnumerable<long>
{
public static readonly long[] Value=A210254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210254.Bytes);
public long this[int i]=>Value[i];

public static A210254Inst Instance=new A210254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210255
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,1L,2L,1L,2L,2L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,0L,1L,2L,1L,2L,3L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,1L,2L,1L,2L,2L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,0L,0L,1L,2L,1L,2L,3L,1L,0L,1L,2L,1L,1L,2L,0L,0L,0L,1L,2L,1L,2L,2L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,0L,1L,2L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210255Inst : IEnumerable<long>
{
public static readonly long[] Value=A210255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210255.Bytes);
public long this[int i]=>Value[i];

public static A210255Inst Instance=new A210255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210256
{
public static readonly long[] Value={ 2L,1L,3L,1L,4L,1L,2L,4L,2L,1L,6L,1L,2L,2L,6L,1L,3L,1L,7L,2L,2L,1L,4L,6L,2L,2L,3L,1L,9L,1L,3L,2L,2L,2L,10L,1L,2L,2L,4L,1L,10L,1L,3L,3L,2L,1L,5L,8L,3L,2L,3L,1L,4L,2L,11L,2L,2L,1L,6L,1L,2L,3L,11L,2L,4L,1L,3L,2L,4L,1L,14L,1L,2L,3L,3L,2L,4L,1L,5L,11L,2L,1L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210256Inst : IEnumerable<long>
{
public static readonly long[] Value=A210256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210256.Bytes);
public long this[int i]=>Value[i];

public static A210256Inst Instance=new A210256Inst();

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